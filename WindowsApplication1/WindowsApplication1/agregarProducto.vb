Public Class agregarProducto

    Dim AccessConnect As String
    Private Sub borrar_datos_en_tablas()
        listbox_codigoDeProducto.Items.Clear()
        listbox_producto.Items.Clear()
        listbox_precio_unitario.Items.Clear()
        listbox_descuento.Items.Clear()
        listbox_comision.Items.Clear()
        listbox_costo.Items.Clear()
    End Sub
    Private Sub mostrar_datos_en_tablas()
        Dim i As Integer
        Dim Conn1 As New ADODB.Connection
        Dim Cmd1 As New ADODB.Command
        Dim Rs1 As New ADODB.Recordset

        Dim datos As Object
        borrar_datos_en_tablas()




        Conn1.ConnectionString = AccessConnect
        Conn1.Open()
        Cmd1.ActiveConnection = Conn1
        Cmd1.CommandText = "SELECT NumerodeSerie, Producto,UltimoPrecio,UltimoDescuento,UltimaComision,UltimCosto FROM ultimosPrecios "
        Rs1 = Cmd1.Execute

        If (Rs1.EOF <> True And Rs1.BOF = False) Then

            datos = Rs1.GetRows()




            For i = 0 To UBound(datos, 2) Step 1
                listbox_codigoDeProducto.Items.Add(datos(0, i))
                listbox_producto.Items.Add(datos(1, i))
                listbox_precio_unitario.Items.Add(FormatCurrency(datos(2, i), , , TriState.True, TriState.True))
                listbox_descuento.Items.Add(FormatCurrency(datos(3, i), , , TriState.True, TriState.True))
                listbox_comision.Items.Add(FormatCurrency(datos(4, i), , , TriState.True, TriState.True))
                listbox_costo.Items.Add(FormatCurrency(datos(5, i), , , TriState.True, TriState.True))
            Next
            Rs1.Close()
            Conn1.Close()
            Conn1.ConnectionString = ""

        End If



    End Sub
    Private Sub agregarProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        mostrar_datos_en_tablas()

    End Sub

    Private Sub boton_agregar_producto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_agregar_producto.Click


        Dim i As Integer
        Dim Conn1 As New ADODB.Connection
        Dim Cmd1 As New ADODB.Command
        Dim Rs1 As New ADODB.Recordset
        Dim datos As Object
        Dim cadena As String

        If (text_codigoDeProducto.Text <> "" And text_descripcion.Text <> "" And IsNumeric(text_precioUnitario.Text)) Then
            cadena = "'" & text_codigoDeProducto.Text & "'"

            Conn1.ConnectionString = AccessConnect
            Conn1.Open()
            Cmd1.ActiveConnection = Conn1
            Cmd1.CommandText = "SELECT NumerodeSerie, Producto,UltimoPrecio FROM ultimosPrecios Where NumerodeSerie = " & cadena
            Rs1 = Cmd1.Execute

            If (Rs1.EOF = True Or Rs1.BOF = True) Then
                Cmd1.CommandText = "Insert into Productos(NumerodeSerie,Producto) Values(" & _
                                   "'" & text_codigoDeProducto.Text & "','" & text_descripcion.Text & "')"
                Rs1 = Cmd1.Execute
                Cmd1.CommandText = "SELECT Id FROM Productos Where NumerodeSerie = " & cadena
                Rs1 = Cmd1.Execute
                datos = Rs1.GetRows()
                i = datos(0, 0)
                Cmd1.CommandText = "Insert into actualizarPrecios(ProductoId,Precio,Comision,Descuento,Costo) Values(" & _
                                     i & "," & text_precioUnitario.Text & "," & text_comision.Text & "," & text_descuento.Text & "," & TextBox_costo.Text & ")"
                Rs1 = Cmd1.Execute
                Conn1.Close()
                Conn1.ConnectionString = ""
                mostrar_datos_en_tablas()
            Else
                MsgBox("Articulo encontrado")

                Rs1.Close()
                Conn1.Close()
                Conn1.ConnectionString = ""

            End If


        End If

    End Sub


    Public Sub New(ByVal cadena_conexion As String)

        ' This call is required by the designer.
        InitializeComponent()
        AccessConnect = cadena_conexion
        boton_modificar.Enabled = False
        boton_cancelar.Enabled = False




        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub modificarProducto(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listbox_codigoDeProducto.DoubleClick
        Dim i As Integer
        i = listbox_codigoDeProducto.SelectedIndex
        text_codigoDeProducto.Text = listbox_codigoDeProducto.Items.Item(i)
        text_comision.Text = listbox_comision.Items.Item(i)
        text_precioUnitario.Text = listbox_precio_unitario.Items.Item(i)
        text_descripcion.Text = listbox_producto.Items.Item(i)
        text_descuento.Text = listbox_descuento.Items.Item(i)
        boton_agregar_producto.Enabled = False
        boton_modificar.Enabled = True
        boton_cancelar.Enabled = True
    End Sub

    Private Sub cancelar_modificacion(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_cancelar.Click
        boton_agregar_producto.Enabled = True
        boton_modificar.Enabled = False
        boton_cancelar.Enabled = False
    End Sub

    Private Sub boton_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_modificar.Click


        Dim i As Integer
        Dim Conn1 As New ADODB.Connection
        Dim Cmd1 As New ADODB.Command
        Dim Rs1 As New ADODB.Recordset
        Dim datos As Object
        Dim cadena As String

        If (text_codigoDeProducto.Text <> "" And text_descripcion.Text <> "" And IsNumeric(text_precioUnitario.Text)) Then
            cadena = "'" & text_codigoDeProducto.Text & "'"

            Conn1.ConnectionString = AccessConnect
            Conn1.Open()
            Cmd1.ActiveConnection = Conn1
            Cmd1.CommandText = "SELECT NumerodeSerie, Producto,UltimoPrecio FROM ultimosPrecios Where NumerodeSerie = " & cadena
            Rs1 = Cmd1.Execute

            If (Rs1.EOF = False Or Rs1.BOF = False) Then
                'Cmd1.CommandText = "Insert into Productos(NumerodeSerie,Producto) Values(" & _
                '                   "'" & text_codigoDeProducto.Text & "','" & text_descripcion.Text & "')"
                'Rs1 = Cmd1.Execute
                Cmd1.CommandText = "SELECT Id FROM Productos Where NumerodeSerie = " & cadena
                Rs1 = Cmd1.Execute
                datos = Rs1.GetRows()
                i = datos(0, 0)
                Cmd1.CommandText = " Update Productos set Producto = '" & text_descripcion.Text & "' Where Id = " & i
                Rs1 = Cmd1.Execute
                Dim ns As Globalization.NumberStyles = Globalization.NumberStyles.AllowCurrencySymbol Or _
            Globalization.NumberStyles.AllowDecimalPoint Or _
            Globalization.NumberStyles.AllowThousands
                Cmd1.CommandText = "Insert into actualizarPrecios(ProductoId,Precio,Comision,Descuento,Costo) Values(" & _
                                     i & "," & Decimal.Parse(text_precioUnitario.Text, ns) & "," & Decimal.Parse(text_comision.Text, ns) & "," & Decimal.Parse(text_descuento.Text, ns) & "," & Decimal.Parse(TextBox_costo.Text, ns) & ")"
                Rs1 = Cmd1.Execute
                Conn1.Close()
                Conn1.ConnectionString = ""
                mostrar_datos_en_tablas()
            Else
                Rs1.Close()
                Conn1.Close()
                Conn1.ConnectionString = ""

            End If
        End If
    End Sub

    
  
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_costo.TextChanged

    End Sub
   
End Class