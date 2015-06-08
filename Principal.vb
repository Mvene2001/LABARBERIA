Imports Microsoft.Office.Interop
Imports System
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text

Public Class Principal
    Dim AccessConnect As String
    Public venta As Form_carroDeVenta
    Private Sub iniciar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim activo As Boolean
        activo = My.Settings.MostrarLista
        AccessConnect = "Driver={Microsoft Access Driver (*.mdb)};" & _
                 "Dbq=db.mdb;" & _
                 "DefaultDir=C:\db\;" & _
                 "Uid=Admin;Pwd=;"
        label_hora_actual.Text = Now()
        tiempo.Interval = 1000
        tiempo.Start()

        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Declare Auto Function GetPrivateProfileString Lib "kernel32" (ByVal lpAppName As String, _
            ByVal lpKeyName As String, _
            ByVal lpDefault As String, _
            ByVal lpReturnedString As StringBuilder, _
            ByVal nSize As Integer, _
            ByVal lpFileName As String) As Integer





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
        Dim loger = New login
        loger.ShowDialog()
        If loger.UsuarioOK = True Then
            loadFile("C:\db\reportes.mdb")
        End If
    End Sub




    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
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


    Private Sub ConfiguracionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguracionToolStripMenuItem.Click
        Dim config As configuracion
        config = New configuracion
        config.ShowDialog()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim inicio, caja As String
        Dim Conn1 As New ADODB.Connection
        Dim Cmd1 As New ADODB.Command
        Dim Rs1 As New ADODB.Recordset
        caja = "0"
        Dim datos As Object
        Dim ns As Globalization.NumberStyles = Globalization.NumberStyles.AllowCurrencySymbol Or _
            Globalization.NumberStyles.AllowDecimalPoint Or _
            Globalization.NumberStyles.AllowThousands
        inicio = InputBox(" Inicio de caja ")
        If IsNumeric(inicio) Then
            Conn1.ConnectionString = AccessConnect
            Conn1.Open()
            Cmd1.ActiveConnection = Conn1
            Cmd1.CommandText = "SELECT * FROM MontoEnCaja"
            Rs1 = Cmd1.Execute

            If (Rs1.EOF <> True And Rs1.BOF = False) Then

                datos = Rs1.GetRows()

                If IsNumeric(datos(0, 0)) Then

                    caja = FormatCurrency((datos(0, 0)), , , TriState.True, TriState.True)
                Else
                    caja = FormatCurrency(0, , , TriState.True, TriState.True)
                End If
            End If
            Rs1.Close()
            Conn1.Close()
            Conn1.ConnectionString = ""





            MsgBox("Monto Inicial:   " & FormatCurrency(inicio, , , TriState.True, TriState.True) & vbCrLf & "Ventas:               " _
                      & FormatCurrency((Decimal.Parse(caja, ns)), , , , ) _
                      & vbCrLf & "Valor en Caja:    " _
                      & FormatCurrency((Decimal.Parse(inicio, ns) + Decimal.Parse(caja, ns)), , , , ) _
                      , vbOKOnly, "La Barberia")


        End If
    End Sub
End Class