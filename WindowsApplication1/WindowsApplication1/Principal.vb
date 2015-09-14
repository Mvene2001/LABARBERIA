Imports Microsoft.Office.Interop

Public Class Principal
    Dim AccessConnect As String
    Public venta As Form_carroDeVenta
    Private Sub iniciar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AccessConnect = "Driver={Microsoft Access Driver (*.mdb)};" & _
                 "Dbq=db.mdb;" & _
                 "DefaultDir=C:\db\;" & _
                 "Uid=Admin;Pwd=;"
        label_hora_actual.Text = Now()
        tiempo.Interval = 1000
        tiempo.Start()
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub tiempo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tiempo.Tick
        label_hora_actual.Text = Now()
    End Sub

    Public Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        venta = New Form_carroDeVenta(AccessConnect)
        venta.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim loger = New login
        loger.ShowDialog()
        If loger.UsuarioOK = True Then
            Dim productos = New agregarProducto(AccessConnect)
            productos.ShowDialog()
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim Clientes_form = New Form_Clientes
        Clientes_form.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim loger = New login
        loger.ShowDialog()
        If loger.UsuarioOK = True Then
            Dim Empleados_form = New Form_Empleados
            Empleados_form.ShowDialog()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        loadFile("C:\db\reportes.mdb")
       
    End Sub


   

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim citas_form = New citas
        citas_form.ShowDialog()
    End Sub

    Private Sub loadFile(ByVal myCoolSelectedFile As String)
        If IO.File.Exists(myCoolSelectedFile) Then
            Process.Start(myCoolSelectedFile)
        Else
            MsgBox("This file does not exist.")
        End If
    End Sub


End Class