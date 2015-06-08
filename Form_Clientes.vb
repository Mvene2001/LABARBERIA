Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class Form_Clientes

    Public texto As String
    Public id_seleccionado As String

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Form_Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostrar_datos_Cliente(" Where Clientes.Id >= 0 ")
        CancelarToolStripMenuItem.Enabled = False
        End Sub

    Private Sub borrar_datos_en_tablas()
        listbox_id.Items.Clear()
        listbox_fechaN.Items.Clear()
        listbox_nombre.Items.Clear()
        listbox_apellido.Items.Clear()
        listbox_telefono.Items.Clear()
        listbox_correo.Items.Clear()
    End Sub
    Private Sub mostrar_datos_Cliente(ByVal cadena As String)
        Dim i As Integer
        Dim Conn1 As New ADODB.Connection
        Dim AccessConnect As String
        AccessConnect = "Driver={Microsoft Access Driver (*.mdb)};" & _
                 "Dbq=db.mdb;" & _
                 "DefaultDir=C:\db\;" & _
                 "Uid=Admin;Pwd=;"

        Dim Cmd1 As New ADODB.Command
        Dim Rs1 As New ADODB.Recordset

        Dim datos As Object
        borrar_datos_en_tablas()




        Conn1.ConnectionString = AccessConnect
        Conn1.Open()
        Cmd1.ActiveConnection = Conn1
        Cmd1.CommandText = "Select Clientes.Id, Clientes.FechaNacimientoCliente,Clientes.NombreCliente, Clientes.ApellidoCliente,  Clientes.telefonoCliente, Clientes.emailCliente FROM Clientes " & cadena

        Rs1 = Cmd1.Execute

        If (Rs1.EOF <> True And Rs1.BOF = False) Then

            datos = Rs1.GetRows()




            For i = 0 To UBound(datos, 2) Step 1
                listbox_id.Items.Add(datos(0, i))
                listbox_fechaN.Items.Add(datos(1, i))
                listbox_nombre.Items.Add(datos(2, i))
                listbox_apellido.Items.Add(datos(3, i))
                listbox_telefono.Items.Add(datos(4, i))
                listbox_correo.Items.Add(datos(5, i))
            Next
            Rs1.Close()
            Conn1.Close()
            Conn1.ConnectionString = ""

        End If






    End Sub

    Private Sub listbox_id_DobleClicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listbox_id.DoubleClick
        If listbox_id.SelectedIndex >= 0 Then
            texto = listbox_nombre.Items.Item(listbox_id.SelectedIndex) & " " & listbox_apellido.Items.Item(listbox_id.SelectedIndex)

            Me.Close()
        End If

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

        Dim texto As String
        texto = "'" & TextBox1.Text & "%'"
        mostrar_datos_Cliente("where( NombreCliente like " & texto & " OR ApellidoCliente like " & texto & ")")
    End Sub


    Private Sub GuardarCliente(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Se concatenan los datos que se van a enviar al sistema    

        Dim Conn1 As New ADODB.Connection
        Dim AccessConnect As String
        AccessConnect = "Driver={Microsoft Access Driver (*.mdb)};" & _
                 "Dbq=db.mdb;" & _
                 "DefaultDir=C:\db\;" & _
                 "Uid=Admin;Pwd=;"

        Dim Cmd1 As New ADODB.Command
        Dim Rs1 As New ADODB.Recordset

        Dim stringFecha, stringNombres, stringApellidos, stringTelefono, stringMail As String
        Conn1.ConnectionString = AccessConnect
        Conn1.Open()

        Cmd1.ActiveConnection = Conn1
        stringFecha = "'" & text_fecha_cliente.Text & "',"
        stringNombres = "'" & text_nombre_clientes.Text & "',"
        stringApellidos = "'" & text_ApellidosCliente.Text & "',"
        stringTelefono = "'" & textTelefonoCliente.Text & "',"
        stringMail = "'" & text_correo_cliente.Text & "')"
        Cmd1.CommandText = "Insert into Clientes(FechaNacimientoCliente,NombreCliente,ApellidoCliente,telefonoCliente,emailCliente) values(" & _
                            stringFecha & stringNombres & stringApellidos & stringTelefono & stringMail
        Rs1 = Cmd1.Execute
        Threading.Thread.Sleep(1000)
        mostrar_datos_Cliente(" Where Clientes.Id >= 0 ")
    End Sub

    Private Sub EditarClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarClienteToolStripMenuItem.Click
        If (listbox_id.SelectedIndex < 0) Then
            MsgBox("Seleccione cliente a Editar Primero")
        Else
            GuardarCambiosToolStripMenuItem.Enabled = True
            Button1.Enabled = False
            text_ApellidosCliente.Text = listbox_apellido.Items.Item(listbox_id.SelectedIndex)
            text_nombre_clientes.Text = listbox_nombre.Items.Item(listbox_id.SelectedIndex)
            textTelefonoCliente.Text = listbox_telefono.Items.Item(listbox_id.SelectedIndex)
            text_correo_cliente.Text = listbox_correo.Items.Item(listbox_id.SelectedIndex)
            text_fecha_cliente.Text = ""
            id_seleccionado = listbox_id.Items.Item(listbox_id.SelectedIndex)
            listbox_id.SelectionMode = SelectionMode.None
            CancelarToolStripMenuItem.Enabled = True

            Try
                text_fecha_cliente.Text = listbox_fechaN.Items.Item(listbox_id.SelectedIndex)
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub GuardarCambiosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarCambiosToolStripMenuItem.Click
        GuardarCambiosToolStripMenuItem.Enabled = False
        Button1.Enabled = True

        Dim Conn1 As New ADODB.Connection
        Dim AccessConnect As String
        AccessConnect = "Driver={Microsoft Access Driver (*.mdb)};" & _
                 "Dbq=db.mdb;" & _
                 "DefaultDir=C:\db\;" & _
                 "Uid=Admin;Pwd=;"

        Dim Cmd1 As New ADODB.Command
        Dim Rs1 As New ADODB.Recordset

        Dim stringFecha, stringNombres, stringApellidos, stringTelefono, stringMail As String
        Conn1.ConnectionString = AccessConnect
        Conn1.Open()

        Cmd1.ActiveConnection = Conn1
        stringFecha = "'" & text_fecha_cliente.Text & "',"
        stringNombres = "'" & text_nombre_clientes.Text & "',"
        stringApellidos = "'" & text_ApellidosCliente.Text & "',"
        stringTelefono = "'" & textTelefonoCliente.Text & "',"
        stringMail = "'" & text_correo_cliente.Text & "'"
        Cmd1.CommandText = "Update Clientes Set FechaNacimientoCliente=" & stringFecha & _
                            "NombreCliente =" & stringNombres & "ApellidoCliente =" & stringApellidos & _
                            "telefonoCliente =" & stringTelefono & "emailCliente =" & stringMail & _
                            "Where Id=" & id_seleccionado
        Rs1 = Cmd1.Execute
        borrardatos()
        Threading.Thread.Sleep(500)
        mostrar_datos_Cliente(" Where Clientes.Id >= 0 ")
        GuardarCambiosToolStripMenuItem.Enabled = False
        Button1.Enabled = True
        listbox_id.SelectionMode = SelectionMode.One
        CancelarToolStripMenuItem.Enabled = False
    End Sub

    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        Dim respuesta As Integer
        respuesta = MsgBox(" Seguro que desea cancelar la edicion", vbYesNo, "Guardar cambios")
        If respuesta = vbYes Then
            borrardatos()
            GuardarCambiosToolStripMenuItem.Enabled = False
            Button1.Enabled = True
            listbox_id.SelectionMode = SelectionMode.One
            CancelarToolStripMenuItem.Enabled = False
        End If
    End Sub
    Private Sub borrardatos()
        text_ApellidosCliente.Text = ""
        text_nombre_clientes.Text = ""
        text_fecha_cliente.Text = ""
        textTelefonoCliente.Text = ""
        text_correo_cliente.Text = ""

    End Sub

    
End Class
