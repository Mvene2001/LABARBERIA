Public Class Form_Empleados
    Public texto As String
    Public id_seleccionado As String
    Private Sub Form_Empleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostrar_datos_Empleados(" ")
    End Sub

    Private Sub borrar_datos_en_tablas()
        listbox_id.Items.Clear()
        listbox_nombre.Items.Clear()
        listbox_apellido.Items.Clear()
        listbox_telefono.Items.Clear()
        listbox_correo.Items.Clear()
    End Sub

    Private Sub mostrar_datos_Empleados(ByVal cadena As String)
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
        Cmd1.CommandText = "Select Id, nombreEmpleado,apellidoEmpleado,telefonoEmpleado,direccionEmpleado FROM Empleados " & cadena

        Rs1 = Cmd1.Execute

        If (Rs1.EOF <> True And Rs1.BOF = False) Then

            datos = Rs1.GetRows()




            For i = 0 To UBound(datos, 2) Step 1
                listbox_id.Items.Add(datos(0, i))
                listbox_nombre.Items.Add(datos(1, i))
                listbox_apellido.Items.Add(datos(2, i))
                listbox_telefono.Items.Add(datos(3, i))
                listbox_correo.Items.Add(datos(4, i))
            Next
            Rs1.Close()
            Conn1.Close()
            Conn1.ConnectionString = ""

        End If






    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim texto As String
        texto = "'" & TextBox1.Text & "%'"
        mostrar_datos_Empleados("where( nombreEmpleado like " & texto & " OR apellidoEmpleado like " & texto & ")")
    End Sub

    Private Sub listbox_id_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listbox_id.DoubleClick
        texto = listbox_nombre.Items.Item(listbox_id.SelectedIndex) & " " & listbox_apellido.Items.Item(listbox_id.SelectedIndex)
        Me.Close()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ' Se concatenan los datos que se van a enviar al sistema    

        Dim Conn1 As New ADODB.Connection
        Dim AccessConnect As String
        AccessConnect = "Driver={Microsoft Access Driver (*.mdb)};" & _
                 "Dbq=db.mdb;" & _
                 "DefaultDir=C:\db\;" & _
                 "Uid=Admin;Pwd=;"

        Dim Cmd1 As New ADODB.Command
        Dim Rs1 As New ADODB.Recordset

        Dim stringNombres, stringApellidos, stringTelefono, stringMail As String
        Conn1.ConnectionString = AccessConnect
        Conn1.Open()

        Cmd1.ActiveConnection = Conn1

        stringNombres = "'" & text_NombreEmpleado.Text & "',"
        stringApellidos = "'" & text_ApellidoEmpleado.Text & "',"
        stringTelefono = "'" & text_Telefono.Text & "',"
        stringMail = "'" & text_correo.Text & "')"
        Cmd1.CommandText = "Insert into Empleados(nombreEmpleado,ApellidoEmpleado,telefonoEmpleado,direccionEmpleado) values(" & _
                            stringNombres & stringApellidos & stringTelefono & stringMail
        Rs1 = Cmd1.Execute
        Threading.Thread.Sleep(1000)
        mostrar_datos_Empleados("")



    End Sub

    Private Sub EditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarToolStripMenuItem.Click
        If (listbox_id.SelectedIndex < 0) Then
            MsgBox("Seleccione empleado a Editar Primero")
        Else
            GuardarCambiosToolStripMenuItem.Enabled = True
            Button1.Enabled = False
            text_ApellidoEmpleado.Text = listbox_apellido.Items.Item(listbox_id.SelectedIndex)
            text_NombreEmpleado.Text = listbox_nombre.Items.Item(listbox_id.SelectedIndex)
            text_Telefono.Text = listbox_telefono.Items.Item(listbox_id.SelectedIndex)
            text_correo.Text = listbox_correo.Items.Item(listbox_id.SelectedIndex)
            id_seleccionado = listbox_id.Items.Item(listbox_id.SelectedIndex)
            listbox_id.SelectionMode = SelectionMode.None
            CancelarToolStripMenuItem.Enabled = True

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

        Dim stringNombres, stringApellidos, stringTelefono, stringMail As String
        Conn1.ConnectionString = AccessConnect
        Conn1.Open()

        Cmd1.ActiveConnection = Conn1

        stringNombres = "'" & text_NombreEmpleado.Text & "',"
        stringApellidos = "'" & text_ApellidoEmpleado.Text & "',"
        stringTelefono = "'" & text_Telefono.Text & "',"
        stringMail = "'" & text_correo.Text & "'"
        Cmd1.CommandText = "Update Empleados Set " & _
                            "nombreEmpleado =" & stringNombres & "ApellidoEmpleado =" & stringApellidos & _
                            "telefonoEmpleado =" & stringTelefono & "direccionEmpleado =" & stringMail & _
                            "Where Id=" & id_seleccionado

        Rs1 = Cmd1.Execute
        borrardatos()
        Threading.Thread.Sleep(500)
        mostrar_datos_Empleados("")
        GuardarCambiosToolStripMenuItem.Enabled = False
        Button1.Enabled = True
        listbox_id.SelectionMode = SelectionMode.One
        CancelarToolStripMenuItem.Enabled = False
    End Sub
    Private Sub borrardatos()
        text_NombreEmpleado.Text = ""
        text_ApellidoEmpleado.Text = ""
        text_correo.Text = ""
        text_Telefono.Text = ""
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
End Class