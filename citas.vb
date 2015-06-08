Public Class citas

    Private Sub citas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostrar_datos_citas()
        cargar_clientes()
        cargar_empleados()
    End Sub
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
                ComboBox2.Items.Add(datos(0, i) & "," & datos(1, i))


            Next
            Rs1.Close()
            Conn1.Close()
            Conn1.ConnectionString = ""

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
                ComboBox1.Items.Add(datos(0, i) & "," & datos(1, i))


            Next
            Rs1.Close()
            Conn1.Close()
            Conn1.ConnectionString = ""

        End If

    End Sub


    Private Sub mostrar_datos_citas()

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
        Cmd1.CommandText = "SELECT Citas.Id, Citas.Nombre, Citas.Fecha, Horarios.Horario " & _
                            "FROM Horarios LEFT JOIN Citas ON Horarios.Horario = Citas.Horario " & _
                            "WHERE ((Day(Fecha)=Day('" & DateTime.Parse(DateTimePicker1.Value).ToShortDateString & "') And Month(Fecha)=Month('" & DateTime.Parse(DateTimePicker1.Value).ToShortDateString & "') And Year(Fecha)=Year('" & DateTime.Parse(DateTimePicker1.Value).ToShortDateString & "'))) OR (((Citas.Fecha) Is Null));"
        Rs1 = Cmd1.Execute
        borrardatos()

        If (Rs1.EOF <> True And Rs1.BOF = False) Then

            datos = Rs1.GetRows()




            For i = 0 To UBound(datos, 2) Step 1
                listbox_id.Items.Add(datos(0, i))
                listbox_nombre.Items.Add(datos(1, i))
                listbox_horario.Items.Add(datos(3, i))

            Next
            Rs1.Close()
            Conn1.Close()
            Conn1.ConnectionString = ""

        End If

    End Sub
    Private Sub borrardatos()
        listbox_horario.Items.Clear()
        listbox_id.Items.Clear()
        listbox_nombre.Items.Clear()

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        mostrar_datos_citas()
    End Sub
End Class