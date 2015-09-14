Public Class configuracion

    Private Sub configuracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckBox1.Checked = My.Settings.MostrarLista
    End Sub


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Settings.MostrarLista = CheckBox1.Checked
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If textlastpass.Text = My.Settings.Password And textusuario.Text = My.Settings.Usuario And TextNewUsuer.Text = TextConNewUsuer.Text And textnewpass.Text = textconfirmpass.Text Then
            MsgBox("Contraseña cambiada con exito", MsgBoxStyle.Information)
            My.Settings.Password = textnewpass.Text
            My.Settings.Usuario = TextNewUsuer.Text
        Else
            MsgBox("Error no se ha podido cambiar la contraseña", MsgBoxStyle.Critical, AcceptButton)

        End If
        textlastpass.Text = ""
        textnewpass.Text = ""
        textconfirmpass.Text = ""
        textusuario.Text = ""
        Me.Close()
    End Sub

   
End Class