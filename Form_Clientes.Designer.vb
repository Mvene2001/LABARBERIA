<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Clientes
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.listbox_id = New System.Windows.Forms.ListBox()
        Me.listbox_fechaN = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.listbox_nombre = New System.Windows.Forms.ListBox()
        Me.listbox_apellido = New System.Windows.Forms.ListBox()
        Me.listbox_telefono = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.listbox_correo = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarCambiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.text_nombre_clientes = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.text_ApellidosCliente = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.textTelefonoCliente = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.text_correo_cliente = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.text_fecha_cliente = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 12)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Id"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(63, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 12)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Fecha Nacimiento"
        '
        'listbox_id
        '
        Me.listbox_id.FormattingEnabled = True
        Me.listbox_id.Location = New System.Drawing.Point(3, 15)
        Me.listbox_id.Name = "listbox_id"
        Me.listbox_id.Size = New System.Drawing.Size(54, 342)
        Me.listbox_id.TabIndex = 8
        '
        'listbox_fechaN
        '
        Me.listbox_fechaN.FormattingEnabled = True
        Me.listbox_fechaN.Location = New System.Drawing.Point(63, 15)
        Me.listbox_fechaN.Name = "listbox_fechaN"
        Me.listbox_fechaN.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listbox_fechaN.Size = New System.Drawing.Size(93, 342)
        Me.listbox_fechaN.TabIndex = 8
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 6
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.listbox_id, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.listbox_fechaN, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.listbox_nombre, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.listbox_apellido, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.listbox_telefono, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.listbox_correo, 5, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(26, 143)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.581267!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96.41873!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(604, 363)
        Me.TableLayoutPanel2.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(471, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 12)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Correo E."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(162, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 12)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nombres"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(265, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 12)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Apellidos"
        '
        'listbox_nombre
        '
        Me.listbox_nombre.FormattingEnabled = True
        Me.listbox_nombre.Location = New System.Drawing.Point(162, 15)
        Me.listbox_nombre.Name = "listbox_nombre"
        Me.listbox_nombre.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listbox_nombre.Size = New System.Drawing.Size(97, 342)
        Me.listbox_nombre.TabIndex = 13
        '
        'listbox_apellido
        '
        Me.listbox_apellido.FormattingEnabled = True
        Me.listbox_apellido.Location = New System.Drawing.Point(265, 15)
        Me.listbox_apellido.Name = "listbox_apellido"
        Me.listbox_apellido.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listbox_apellido.Size = New System.Drawing.Size(97, 342)
        Me.listbox_apellido.TabIndex = 14
        '
        'listbox_telefono
        '
        Me.listbox_telefono.FormattingEnabled = True
        Me.listbox_telefono.Location = New System.Drawing.Point(368, 15)
        Me.listbox_telefono.Name = "listbox_telefono"
        Me.listbox_telefono.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listbox_telefono.Size = New System.Drawing.Size(97, 342)
        Me.listbox_telefono.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(368, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 12)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Teléfono"
        '
        'listbox_correo
        '
        Me.listbox_correo.FormattingEnabled = True
        Me.listbox_correo.Location = New System.Drawing.Point(471, 15)
        Me.listbox_correo.Name = "listbox_correo"
        Me.listbox_correo.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listbox_correo.Size = New System.Drawing.Size(130, 342)
        Me.listbox_correo.TabIndex = 23
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(397, 109)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(233, 20)
        Me.TextBox1.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(352, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Buscar "
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(666, 24)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarClienteToolStripMenuItem, Me.GuardarCambiosToolStripMenuItem, Me.CancelarToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'EditarClienteToolStripMenuItem
        '
        Me.EditarClienteToolStripMenuItem.Name = "EditarClienteToolStripMenuItem"
        Me.EditarClienteToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.EditarClienteToolStripMenuItem.Text = "Editar Cliente"
        '
        'GuardarCambiosToolStripMenuItem
        '
        Me.GuardarCambiosToolStripMenuItem.Enabled = False
        Me.GuardarCambiosToolStripMenuItem.Name = "GuardarCambiosToolStripMenuItem"
        Me.GuardarCambiosToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.GuardarCambiosToolStripMenuItem.Text = "Guardar Cambios"
        '
        'CancelarToolStripMenuItem
        '
        Me.CancelarToolStripMenuItem.Enabled = False
        Me.CancelarToolStripMenuItem.Name = "CancelarToolStripMenuItem"
        Me.CancelarToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.CancelarToolStripMenuItem.Text = "Cancelar"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(24, 20)
        Me.ToolStripMenuItem1.Text = "&?"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FlowLayoutPanel1)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(604, 79)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Crear Nuevo"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Label8)
        Me.FlowLayoutPanel1.Controls.Add(Me.text_nombre_clientes)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label9)
        Me.FlowLayoutPanel1.Controls.Add(Me.text_ApellidosCliente)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label11)
        Me.FlowLayoutPanel1.Controls.Add(Me.textTelefonoCliente)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label12)
        Me.FlowLayoutPanel1.Controls.Add(Me.text_correo_cliente)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label10)
        Me.FlowLayoutPanel1.Controls.Add(Me.text_fecha_cliente)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(598, 60)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Nombres"
        '
        'text_nombre_clientes
        '
        Me.text_nombre_clientes.Location = New System.Drawing.Point(58, 3)
        Me.text_nombre_clientes.Name = "text_nombre_clientes"
        Me.text_nombre_clientes.Size = New System.Drawing.Size(155, 20)
        Me.text_nombre_clientes.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(219, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Apellidos"
        '
        'text_ApellidosCliente
        '
        Me.text_ApellidosCliente.Location = New System.Drawing.Point(274, 3)
        Me.text_ApellidosCliente.Name = "text_ApellidosCliente"
        Me.text_ApellidosCliente.Size = New System.Drawing.Size(158, 20)
        Me.text_ApellidosCliente.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(438, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Telefono"
        '
        'textTelefonoCliente
        '
        Me.textTelefonoCliente.Location = New System.Drawing.Point(493, 3)
        Me.textTelefonoCliente.Name = "textTelefonoCliente"
        Me.textTelefonoCliente.Size = New System.Drawing.Size(100, 20)
        Me.textTelefonoCliente.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Correo E."
        '
        'text_correo_cliente
        '
        Me.text_correo_cliente.Location = New System.Drawing.Point(60, 29)
        Me.text_correo_cliente.Name = "text_correo_cliente"
        Me.text_correo_cliente.Size = New System.Drawing.Size(153, 20)
        Me.text_correo_cliente.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(219, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Fecha de N."
        '
        'text_fecha_cliente
        '
        Me.text_fecha_cliente.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.text_fecha_cliente.Location = New System.Drawing.Point(291, 29)
        Me.text_fecha_cliente.Name = "text_fecha_cliente"
        Me.text_fecha_cliente.Size = New System.Drawing.Size(141, 20)
        Me.text_fecha_cliente.TabIndex = 4
        Me.text_fecha_cliente.Value = New Date(2015, 5, 1, 0, 0, 0, 0)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(438, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 534)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Clientes"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form_Clientes"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents listbox_id As System.Windows.Forms.ListBox
    Friend WithEvents listbox_fechaN As System.Windows.Forms.ListBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents listbox_apellido As System.Windows.Forms.ListBox
    Friend WithEvents listbox_nombre As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents listbox_telefono As System.Windows.Forms.ListBox
    Friend WithEvents listbox_correo As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents text_nombre_clientes As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents text_ApellidosCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents textTelefonoCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents text_correo_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents text_fecha_cliente As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents EditarClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarCambiosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
