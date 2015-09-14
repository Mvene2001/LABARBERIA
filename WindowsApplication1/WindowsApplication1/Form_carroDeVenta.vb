Imports System.Data.SqlClient
Public Class Form_carroDeVenta
    Public texto As String
    Dim AccessConnect As String

    Private Sub cargar_clientes()
        Dim Conn1 As New ADODB.Connection
        Dim AccessConnect As String
        AccessConnect = "Driver={Microsoft Access Driver (*.mdb)};" & _
                 "Dbq=db.mdb;" & _
                 "DefaultDir=C:\db\;" & _
                 "Uid=Admin;Pwd=;"

        Dim Cmd1 As New ADODB.Command
        Dim Rs1 As New ADODB.Recordset

        Conn1.ConnectionString = AccessConnect
        Conn1.Open()
        Dim datos As Object
        Cmd1.ActiveConnection = Conn1
        Cmd1.CommandText = "SELECT NombreCliente,ApellidoCliente " & _
                            "FROM Clientes"

        Rs1 = Cmd1.Execute

        If (Rs1.EOF <> True And Rs1.BOF = False) Then

            datos = Rs1.GetRows()




            For i = 0 To UBound(datos, 2) Step 1
                ComboBoxEmpleados.Items.Add(datos(0, i) & "," & datos(1, i))


            Next
            Rs1.Close()
            Conn1.Close()
            Conn1.ConnectionString = ""

        End If
    End Sub

    Private Sub AgregarBoton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarBoton.Click
        Dim Cantidad As Integer
        Dim total As Double
        Dim i As Integer
        Dim Conn1 As New ADODB.Connection
        Dim Cmd1 As New ADODB.Command
        Dim Rs1 As New ADODB.Recordset

        Dim datos As Object
        Dim cadena As String

        cadena = "'" & TextProducto.Text & "'"
        
        total = 0
        If (IsNumeric(TextCantidad.Text)) Then
            Conn1.ConnectionString = AccessConnect
            Conn1.Open()
            Cmd1.ActiveConnection = Conn1
            Cmd1.CommandText = "SELECT Producto, UltimoPrecio,Id,UltimoDescuento FROM ultimosPrecios Where NumerodeSerie LIKE " & cadena
            Rs1 = Cmd1.Execute

            If (Rs1.EOF <> True And Rs1.BOF = False) Then

                datos = Rs1.GetRows()


                Cantidad = CInt(TextCantidad.Text)

                listbox_cantidad.Items.Add(TextCantidad.Text)
                listbox_id.Items.Add(datos(2, 0))
                listbox_producto.Items.Add(datos(0, 0))
                listbox_precio_unitario.Items.Add(FormatCurrency(datos(1, 0), , , TriState.True, TriState.True))
                listbox_descuento.Items.Add(FormatCurrency(datos(3, 0), , , TriState.True, TriState.True))
                listbox_subtotal.Items.Add(FormatCurrency((datos(1, 0) - datos(3, 0)) * Cantidad, , , TriState.True, TriState.True))

                For i = 0 To listbox_subtotal.Items.Count - 1 Step 1
                    total = total + listbox_subtotal.Items.Item(i)
                Next
            Else
                MsgBox("Favor de digitar una cantidad y producto correcto", , "Advertencia")
            End If
            Rs1.Close()
            Conn1.Close()
            Conn1.ConnectionString = ""

        End If
        textTotal.Text = FormatCurrency(total, , , TriState.True, TriState.True)
        TextProducto.Text = ""
        TextCantidad.Text = ""
        TextProducto.Select()

    End Sub

    Private Sub Borrar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_quitar.Click
        Dim item As Integer
        Dim total As Double
        item = listbox_cantidad.SelectedIndex
        If item >= 0 Then
            listbox_cantidad.Items.RemoveAt(item)
            listbox_producto.Items.RemoveAt(item)
            listbox_precio_unitario.Items.RemoveAt(item)
            listbox_descuento.Items.RemoveAt(item)
            listbox_subtotal.Items.RemoveAt(item)
            listbox_id.Items.RemoveAt(item)

            total = 0
            For i = 0 To listbox_subtotal.Items.Count - 1 Step 1
                total = total + listbox_subtotal.Items.Item(i)
            Next
            textTotal.Text = FormatCurrency(total, , , TriState.True, TriState.True)
        End If

    End Sub

    Private Sub boton_cobrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_cobrar.Click
        Dim Conn1 As New adodb.Connection
        Dim Cmd1 As New adodb.Command
        Dim Rs1 As New adodb.Recordset
        Dim item As Integer
        Dim fecha As String
        fecha = relogyhora.Text
        If (listbox_subtotal.Items.Count > 0 And textbox_cliente.Text <> "" And ComboBoxEmpleados.Text <> "") Then
            Dim ns As Globalization.NumberStyles = Globalization.NumberStyles.AllowCurrencySymbol Or _
            Globalization.NumberStyles.AllowDecimalPoint Or _
            Globalization.NumberStyles.AllowThousands

            Conn1.ConnectionString = AccessConnect
            Conn1.Open()
            Cmd1.ActiveConnection = Conn1


            Cmd1.CommandText = "INSERT INTO Ventas(VentaId,ClienteID,EmpleadoID,ModoDePago,FechaDeVenta) Values ('" _
                                    & fecha & "','" & textbox_cliente.Text & "','" _
                                    & ComboBoxEmpleados.Text & "','Efectivo','" & DateTime.Parse(fecha).ToShortDateString & "')"
            Rs1 = Cmd1.Execute
            'Decimal.Parse(listbox_precio_unitario.Items.Item(item), ns)
            For item = 0 To listbox_subtotal.Items.Count - 1 Step 1
                Cmd1.CommandText = "INSERT INTO ProductoVendido(VentaId,ProductoId,Cantidad) Values ('" _
                                    & fecha & "'," & listbox_id.Items.Item(item) & "," _
                                    & listbox_cantidad.Items.Item(item) & ")"
                Rs1 = Cmd1.Execute
            Next
            Conn1.Close()
            Conn1.ConnectionString = ""

            Dim a As Double
            a = Decimal.Parse(InputBox(Prompt:="Monto con el que se" & vbCrLf & "realizo el pago:", Title:="Pago:"), ns)
            MsgBox("Usted pago:   " & FormatCurrency(a, , , TriState.True, TriState.True) & vbCrLf & "Su cambio:    " _
                   & FormatCurrency((a - Decimal.Parse(textTotal.Text, ns)), , , , ) _
                   & vbCrLf & "Venta realiada con exito", vbOKOnly, "La Barberia")
            limpiar_campos()
        Else
            MsgBox("Error: Necesitas capturar los datos" & vbCrLf & "antes de poder efectuar la venta", vbOKOnly, "La Barberia")
        End If

    End Sub
    Private Sub limpiar_campos()
        listbox_cantidad.Items.Clear()
        listbox_descuento.Items.Clear()
        listbox_precio_unitario.Items.Clear()
        listbox_producto.Items.Clear()
        listbox_subtotal.Items.Clear()
        listbox_id.Items.Clear()
        TextProducto.Text = ""
        TextCantidad.Text = ""
        textbox_cliente.Text = ""
        ComboBoxEmpleados.Text = ""
        textTotal.Text = FormatCurrency(0, , , TriState.True, TriState.True)
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbDataSet.Clientes' table. You can move, or remove it, as needed.

        textTotal.Text = FormatCurrency(0, , , TriState.True, TriState.True)
        relogyhora.Text = Now()
        AgregarBoton.Enabled = False
        getTimme_control.Interval = 1000
        getTimme_control.Start()
        cargar_empleados()
    End Sub


    Private Sub getTimme_control_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles getTimme_control.Tick
        relogyhora.Text = Now()
    End Sub


    Public Sub New(ByVal cadena_de_conexion As String)
        AccessConnect = cadena_de_conexion
        
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim seleccionCliente = New Form_Clientes
        seleccionCliente.ShowDialog()
        textbox_cliente.Text = seleccionCliente.texto
        If (textbox_cliente.Text <> "" And ComboBoxEmpleados.Text <> "") Then
            AgregarBoton.Enabled = True
        Else
            AgregarBoton.Enabled = False
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim seleccionEmpleado = New Form_Empleados
        seleccionEmpleado.ShowDialog()
        ComboBoxEmpleados.Text = seleccionEmpleado.texto
        If (textbox_cliente.Text <> "" And ComboBoxEmpleados.Text <> "") Then
            AgregarBoton.Enabled = True
        Else
            AgregarBoton.Enabled = False
        End If
    End Sub
    Private Sub cargar_empleados()

        Dim Conn1 As New ADODB.Connection
        Dim AccessConnect As String
        AccessConnect = "Driver={Microsoft Access Driver (*.mdb)};" & _
                 "Dbq=db.mdb;" & _
                 "DefaultDir=C:\db\;" & _
                 "Uid=Admin;Pwd=;"

        Dim Cmd1 As New ADODB.Command
        Dim Rs1 As New ADODB.Recordset

        Conn1.ConnectionString = AccessConnect
        Conn1.Open()
        Dim datos As Object
        Cmd1.ActiveConnection = Conn1
        Cmd1.CommandText = "SELECT nombreEmpleado,apellidoEmpleado " & _
                            "FROM Empleados"

        Rs1 = Cmd1.Execute

        If (Rs1.EOF <> True And Rs1.BOF = False) Then

            datos = Rs1.GetRows()




            For i = 0 To UBound(datos, 2) Step 1
                ComboBoxEmpleados.Items.Add(datos(0, i) & "," & datos(1, i))


            Next
            Rs1.Close()
            Conn1.Close()
            Conn1.ConnectionString = ""

        End If

    End Sub
End Class
