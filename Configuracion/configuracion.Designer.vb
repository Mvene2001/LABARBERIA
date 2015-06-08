<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class configuracion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.textconfirmpass = New System.Windows.Forms.TextBox()
        Me.textnewpass = New System.Windows.Forms.TextBox()
        Me.textlastpass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textusuario = New System.Windows.Forms.TextBox()
        Me.TextNewUsuer = New System.Windows.Forms.TextBox()
        Me.TextConNewUsuer = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(53, 12)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(211, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Mostrar Clientes como lista desplegable"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Confirme Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contraseña Anterior"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Contraseña Nueva"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.textconfirmpass, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.textnewpass, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.textlastpass, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.textusuario, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextNewUsuer, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextConNewUsuer, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(53, 53)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(338, 161)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'textconfirmpass
        '
        Me.textconfirmpass.Location = New System.Drawing.Point(114, 133)
        Me.textconfirmpass.Name = "textconfirmpass"
        Me.textconfirmpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textconfirmpass.Size = New System.Drawing.Size(211, 20)
        Me.textconfirmpass.TabIndex = 11
        '
        'textnewpass
        '
        Me.textnewpass.Location = New System.Drawing.Point(114, 107)
        Me.textnewpass.Name = "textnewpass"
        Me.textnewpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textnewpass.Size = New System.Drawing.Size(211, 20)
        Me.textnewpass.TabIndex = 10
        '
        'textlastpass
        '
        Me.textlastpass.Location = New System.Drawing.Point(114, 81)
        Me.textlastpass.Name = "textlastpass"
        Me.textlastpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textlastpass.Size = New System.Drawing.Size(211, 20)
        Me.textlastpass.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Confirme Contraseña"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Usuario Anterior"
        '
        'textusuario
        '
        Me.textusuario.Location = New System.Drawing.Point(114, 3)
        Me.textusuario.Name = "textusuario"
        Me.textusuario.Size = New System.Drawing.Size(211, 20)
        Me.textusuario.TabIndex = 8
        '
        'TextNewUsuer
        '
        Me.TextNewUsuer.Location = New System.Drawing.Point(114, 29)
        Me.TextNewUsuer.Name = "TextNewUsuer"
        Me.TextNewUsuer.Size = New System.Drawing.Size(211, 20)
        Me.TextNewUsuer.TabIndex = 8
        '
        'TextConNewUsuer
        '
        Me.TextConNewUsuer.Location = New System.Drawing.Point(114, 55)
        Me.TextConNewUsuer.Name = "TextConNewUsuer"
        Me.TextConNewUsuer.Size = New System.Drawing.Size(211, 20)
        Me.TextConNewUsuer.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 32)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Guardar Cambios"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.Button1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Button2, 0, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(432, 21)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(143, 193)
        Me.TableLayoutPanel2.TabIndex = 11
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(3, 41)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 32)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Cambiar Contraseña"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Usuario Nuevo"
        '
        'configuracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 261)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Name = "configuracion"
        Me.Text = "configuracion"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents textconfirmpass As System.Windows.Forms.TextBox
    Friend WithEvents textnewpass As System.Windows.Forms.TextBox
    Friend WithEvents textlastpass As System.Windows.Forms.TextBox
    Friend WithEvents textusuario As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextNewUsuer As System.Windows.Forms.TextBox
    Friend WithEvents TextConNewUsuer As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
