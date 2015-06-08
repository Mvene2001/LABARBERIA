<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_carroDeVenta
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_carroDeVenta))
        Me.listbox_cantidad = New System.Windows.Forms.ListBox()
        Me.listbox_producto = New System.Windows.Forms.ListBox()
        Me.listbox_precio_unitario = New System.Windows.Forms.ListBox()
        Me.listbox_subtotal = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.textTotal = New System.Windows.Forms.TextBox()
        Me.listbox_id = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextCantidad = New System.Windows.Forms.TextBox()
        Me.TextProducto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AgregarBoton = New System.Windows.Forms.Button()
        Me.label_empleado = New System.Windows.Forms.Label()
        Me.label_cliente = New System.Windows.Forms.Label()
        Me.efectivo = New System.Windows.Forms.RadioButton()
        Me.tarjeta = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.listbox_descuento = New System.Windows.Forms.ListBox()
        Me.boton_quitar = New System.Windows.Forms.Button()
        Me.getTimme_control = New System.Windows.Forms.Timer(Me.components)
        Me.textbox_cliente = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.comboboxCliente = New System.Windows.Forms.ComboBox()
        Me.LabelClienteText = New System.Windows.Forms.Label()
        Me.ComboBoxEmpleados = New System.Windows.Forms.ComboBox()
        Me.relogyhora = New System.Windows.Forms.TextBox()
        Me.boton_cobrar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'listbox_cantidad
        '
        Me.listbox_cantidad.FormattingEnabled = True
        Me.listbox_cantidad.Location = New System.Drawing.Point(70, 30)
        Me.listbox_cantidad.Name = "listbox_cantidad"
        Me.listbox_cantidad.Size = New System.Drawing.Size(55, 173)
        Me.listbox_cantidad.TabIndex = 5
        '
        'listbox_producto
        '
        Me.listbox_producto.FormattingEnabled = True
        Me.listbox_producto.Location = New System.Drawing.Point(126, 30)
        Me.listbox_producto.Name = "listbox_producto"
        Me.listbox_producto.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listbox_producto.Size = New System.Drawing.Size(137, 173)
        Me.listbox_producto.TabIndex = 6
        '
        'listbox_precio_unitario
        '
        Me.listbox_precio_unitario.FormattingEnabled = True
        Me.listbox_precio_unitario.Location = New System.Drawing.Point(264, 30)
        Me.listbox_precio_unitario.Name = "listbox_precio_unitario"
        Me.listbox_precio_unitario.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listbox_precio_unitario.Size = New System.Drawing.Size(84, 173)
        Me.listbox_precio_unitario.TabIndex = 7
        '
        'listbox_subtotal
        '
        Me.listbox_subtotal.FormattingEnabled = True
        Me.listbox_subtotal.Location = New System.Drawing.Point(436, 30)
        Me.listbox_subtotal.Name = "listbox_subtotal"
        Me.listbox_subtotal.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listbox_subtotal.Size = New System.Drawing.Size(84, 173)
        Me.listbox_subtotal.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(68, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Cantidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(123, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Producto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(261, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Precio Unitario"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(433, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Sub total"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(399, 212)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Total"
        '
        'textTotal
        '
        Me.textTotal.Location = New System.Drawing.Point(436, 209)
        Me.textTotal.Name = "textTotal"
        Me.textTotal.Size = New System.Drawing.Size(84, 20)
        Me.textTotal.TabIndex = 4
        '
        'listbox_id
        '
        Me.listbox_id.FormattingEnabled = True
        Me.listbox_id.Location = New System.Drawing.Point(14, 30)
        Me.listbox_id.Name = "listbox_id"
        Me.listbox_id.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listbox_id.Size = New System.Drawing.Size(55, 173)
        Me.listbox_id.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Id"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextCantidad)
        Me.GroupBox1.Controls.Add(Me.TextProducto)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.AgregarBoton)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(297, 81)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(136, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cantidad"
        '
        'TextCantidad
        '
        Me.TextCantidad.Location = New System.Drawing.Point(139, 44)
        Me.TextCantidad.Name = "TextCantidad"
        Me.TextCantidad.Size = New System.Drawing.Size(46, 20)
        Me.TextCantidad.TabIndex = 1
        '
        'TextProducto
        '
        Me.TextProducto.Location = New System.Drawing.Point(13, 44)
        Me.TextProducto.Name = "TextProducto"
        Me.TextProducto.Size = New System.Drawing.Size(124, 20)
        Me.TextProducto.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Producto"
        '
        'AgregarBoton
        '
        Me.AgregarBoton.Image = Global.WindowsApplication1.My.Resources.Resources.shopping_cart_add
        Me.AgregarBoton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AgregarBoton.Location = New System.Drawing.Point(197, 7)
        Me.AgregarBoton.Name = "AgregarBoton"
        Me.AgregarBoton.Size = New System.Drawing.Size(94, 69)
        Me.AgregarBoton.TabIndex = 1
        Me.AgregarBoton.Text = "  Agregar"
        Me.AgregarBoton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AgregarBoton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AgregarBoton.UseVisualStyleBackColor = True
        '
        'label_empleado
        '
        Me.label_empleado.AutoSize = True
        Me.label_empleado.Location = New System.Drawing.Point(3, 53)
        Me.label_empleado.Name = "label_empleado"
        Me.label_empleado.Size = New System.Drawing.Size(54, 13)
        Me.label_empleado.TabIndex = 16
        Me.label_empleado.Text = "Empleado"
        '
        'label_cliente
        '
        Me.label_cliente.AutoSize = True
        Me.label_cliente.Location = New System.Drawing.Point(3, 0)
        Me.label_cliente.Name = "label_cliente"
        Me.label_cliente.Size = New System.Drawing.Size(54, 13)
        Me.label_cliente.TabIndex = 16
        Me.label_cliente.Text = "Cliente     "
        '
        'efectivo
        '
        Me.efectivo.AutoSize = True
        Me.efectivo.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.efectivo.Checked = True
        Me.efectivo.Location = New System.Drawing.Point(535, 124)
        Me.efectivo.Name = "efectivo"
        Me.efectivo.Size = New System.Drawing.Size(64, 17)
        Me.efectivo.TabIndex = 17
        Me.efectivo.TabStop = True
        Me.efectivo.Text = "Efectivo"
        Me.efectivo.UseVisualStyleBackColor = True
        '
        'tarjeta
        '
        Me.tarjeta.AutoSize = True
        Me.tarjeta.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.tarjeta.Location = New System.Drawing.Point(535, 147)
        Me.tarjeta.Name = "tarjeta"
        Me.tarjeta.Size = New System.Drawing.Size(58, 17)
        Me.tarjeta.TabIndex = 17
        Me.tarjeta.Text = "Tarjeta"
        Me.tarjeta.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.tarjeta)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.efectivo)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.listbox_descuento)
        Me.GroupBox2.Controls.Add(Me.listbox_subtotal)
        Me.GroupBox2.Controls.Add(Me.listbox_precio_unitario)
        Me.GroupBox2.Controls.Add(Me.listbox_producto)
        Me.GroupBox2.Controls.Add(Me.listbox_id)
        Me.GroupBox2.Controls.Add(Me.textTotal)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.listbox_cantidad)
        Me.GroupBox2.Controls.Add(Me.boton_quitar)
        Me.GroupBox2.Location = New System.Drawing.Point(38, 134)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(637, 239)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(347, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Descuento"
        '
        'listbox_descuento
        '
        Me.listbox_descuento.FormattingEnabled = True
        Me.listbox_descuento.Location = New System.Drawing.Point(350, 30)
        Me.listbox_descuento.Name = "listbox_descuento"
        Me.listbox_descuento.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listbox_descuento.Size = New System.Drawing.Size(84, 173)
        Me.listbox_descuento.TabIndex = 8
        '
        'boton_quitar
        '
        Me.boton_quitar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.boton_quitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton_quitar.Image = CType(resources.GetObject("boton_quitar.Image"), System.Drawing.Image)
        Me.boton_quitar.Location = New System.Drawing.Point(526, 30)
        Me.boton_quitar.Name = "boton_quitar"
        Me.boton_quitar.Size = New System.Drawing.Size(89, 74)
        Me.boton_quitar.TabIndex = 2
        Me.boton_quitar.UseVisualStyleBackColor = True
        '
        'getTimme_control
        '
        '
        'textbox_cliente
        '
        Me.textbox_cliente.Location = New System.Drawing.Point(63, 30)
        Me.textbox_cliente.Name = "textbox_cliente"
        Me.textbox_cliente.ReadOnly = True
        Me.textbox_cliente.Size = New System.Drawing.Size(160, 20)
        Me.textbox_cliente.TabIndex = 20
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(614, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(114, 47)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Seleccionar Cliente"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.label_cliente)
        Me.FlowLayoutPanel1.Controls.Add(Me.comboboxCliente)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelClienteText)
        Me.FlowLayoutPanel1.Controls.Add(Me.textbox_cliente)
        Me.FlowLayoutPanel1.Controls.Add(Me.label_empleado)
        Me.FlowLayoutPanel1.Controls.Add(Me.ComboBoxEmpleados)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(368, 19)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(236, 109)
        Me.FlowLayoutPanel1.TabIndex = 21
        '
        'comboboxCliente
        '
        Me.comboboxCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboboxCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboboxCliente.FormattingEnabled = True
        Me.comboboxCliente.Location = New System.Drawing.Point(63, 3)
        Me.comboboxCliente.Name = "comboboxCliente"
        Me.comboboxCliente.Size = New System.Drawing.Size(160, 21)
        Me.comboboxCliente.TabIndex = 22
        Me.comboboxCliente.TabStop = False
        '
        'LabelClienteText
        '
        Me.LabelClienteText.AutoSize = True
        Me.LabelClienteText.Location = New System.Drawing.Point(3, 27)
        Me.LabelClienteText.Name = "LabelClienteText"
        Me.LabelClienteText.Size = New System.Drawing.Size(54, 13)
        Me.LabelClienteText.TabIndex = 23
        Me.LabelClienteText.Text = "Cliente     "
        '
        'ComboBoxEmpleados
        '
        Me.ComboBoxEmpleados.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxEmpleados.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxEmpleados.FormattingEnabled = True
        Me.ComboBoxEmpleados.Location = New System.Drawing.Point(63, 56)
        Me.ComboBoxEmpleados.Name = "ComboBoxEmpleados"
        Me.ComboBoxEmpleados.Size = New System.Drawing.Size(160, 21)
        Me.ComboBoxEmpleados.TabIndex = 21
        '
        'relogyhora
        '
        Me.relogyhora.Enabled = False
        Me.relogyhora.Location = New System.Drawing.Point(38, 12)
        Me.relogyhora.Name = "relogyhora"
        Me.relogyhora.ReadOnly = True
        Me.relogyhora.Size = New System.Drawing.Size(297, 20)
        Me.relogyhora.TabIndex = 20
        Me.relogyhora.Text = "relogyhora"
        '
        'boton_cobrar
        '
        Me.boton_cobrar.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.shopping_cart_accept
        Me.boton_cobrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.boton_cobrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.boton_cobrar.Location = New System.Drawing.Point(236, 377)
        Me.boton_cobrar.Name = "boton_cobrar"
        Me.boton_cobrar.Size = New System.Drawing.Size(196, 144)
        Me.boton_cobrar.TabIndex = 13
        Me.boton_cobrar.Text = "Cobrar"
        Me.boton_cobrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.boton_cobrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.boton_cobrar.UseVisualStyleBackColor = True
        '
        'Form_carroDeVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 521)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.relogyhora)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.boton_cobrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form_carroDeVenta"
        Me.Text = "Inicio"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AgregarBoton As System.Windows.Forms.Button
    Friend WithEvents listbox_cantidad As System.Windows.Forms.ListBox
    Friend WithEvents listbox_producto As System.Windows.Forms.ListBox
    Friend WithEvents listbox_precio_unitario As System.Windows.Forms.ListBox
    Friend WithEvents listbox_subtotal As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents textTotal As System.Windows.Forms.TextBox
    Friend WithEvents boton_quitar As System.Windows.Forms.Button
    Friend WithEvents boton_cobrar As System.Windows.Forms.Button
    Friend WithEvents listbox_id As System.Windows.Forms.ListBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextCantidad As System.Windows.Forms.TextBox
    Friend WithEvents TextProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents label_empleado As System.Windows.Forms.Label
    Friend WithEvents label_cliente As System.Windows.Forms.Label
    Friend WithEvents efectivo As System.Windows.Forms.RadioButton
    Friend WithEvents tarjeta As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents getTimme_control As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents listbox_descuento As System.Windows.Forms.ListBox
    Friend WithEvents textbox_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents relogyhora As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxEmpleados As System.Windows.Forms.ComboBox
    Friend WithEvents comboboxCliente As System.Windows.Forms.ComboBox
    Friend WithEvents LabelClienteText As System.Windows.Forms.Label

End Class
