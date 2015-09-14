Public Class login
    Public Contrasena As String
    Public Usuario As String
    Public UsuarioOK As Boolean
    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        If UsernameTextBox.Text = My.Settings.Usuario And PasswordTextBox.Text = My.Settings.Password Then
            UsuarioOK = True
        Else
            MsgBox("Usuario o contraseña incorrecta")
            UsuarioOK = False
        End If

        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        UsuarioOK = False
        Me.Close()
    End Sub


    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Contrasena = "Jesus123"
        Usuario = "Jesus"
    End Sub
End Class
