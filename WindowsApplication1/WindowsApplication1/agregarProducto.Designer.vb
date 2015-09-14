<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agregarProducto
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
        Me.boton_agregar_producto = New System.Windows.Forms.Button()
        Me.text_codigoDeProducto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.text_descripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.text_precioUnitario = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.listbox_precio_unitario = New System.Windows.Forms.ListBox()
        Me.listbox_producto = New System.Windows.Forms.ListBox()
        Me.listbox_codigoDeProducto = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.listbox_costo = New System.Windows.Forms.ListBox()
        Me.listbox_descuento = New System.Windows.Forms.ListBox()
        Me.listbox_comision = New System.Windows.Forms.ListBox()
        Me.text_comision = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.text_descuento = New System.Windows.Forms.TextBox()
        Me.boton_modificar = New System.Windows.Forms.Button()
        Me.boton_cancelar = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox_costo = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'boton_agregar_producto
        '
        Me.boton_agregar_producto.Location = New System.Drawing.Point(31, 216)
        Me.boton_agregar_producto.Name = "boton_agregar_producto"
        Me.boton_agregar_producto.Size = New System.Drawing.Size(112, 31)
        Me.boton_agregar_producto.TabIndex = 3
        Me.boton_agregar_producto.Text = "Agregar Producto"
        Me.boton_agregar_producto.UseVisualStyleBackColor = True
        '
        'text_codigoDeProducto
        '
        Me.text_codigoDeProducto.Location = New System.Drawing.Point(128, 44)
        Me.text_codigoDeProducto.Name = "text_codigoDeProducto"
        Me.text_codigoDeProducto.Size = New System.Drawing.Size(123, 20)
        Me.text_codigoDeProducto.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Codigo de Producto"
        '
        'text_descripcion
        '
        Me.text_descripcion.Location = New System.Drawing.Point(128, 70)
        Me.text_descripcion.Name = "text_descripcion"
        Me.text_descripcion.Size = New System.Drawing.Size(123, 20)
        Me.text_descripcion.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Descripción"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Precio Unitario"
        '
        'text_precioUnitario
        '
        Me.text_precioUnitario.Location = New System.Drawing.Point(128, 96)
        Me.text_precioUnitario.Name = "text_precioUnitario"
        Me.text_precioUnitario.Size = New System.Drawing.Size(123, 20)
        Me.text_precioUnitario.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(289, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Precio Unitario"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(151, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Producto"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Codigo de Producto"
        '
        'listbox_precio_unitario
        '
        Me.listbox_precio_unitario.FormattingEnabled = True
        Me.listbox_precio_unitario.Location = New System.Drawing.Point(292, 46)
        Me.listbox_precio_unitario.Name = "listbox_precio_unitario"
        Me.listbox_precio_unitario.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listbox_precio_unitario.Size = New System.Drawing.Size(96, 342)
        Me.listbox_precio_unitario.TabIndex = 14
        '
        'listbox_producto
        '
        Me.listbox_producto.FormattingEnabled = True
        Me.listbox_producto.Location = New System.Drawing.Point(154, 46)
        Me.listbox_producto.Name = "listbox_producto"
        Me.listbox_producto.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listbox_producto.Size = New System.Drawing.Size(137, 342)
        Me.listbox_producto.TabIndex = 13
        '
        'listbox_codigoDeProducto
        '
        Me.listbox_codigoDeProducto.FormattingEnabled = True
        Me.listbox_codigoDeProducto.Location = New System.Drawing.Point(25, 46)
        Me.listbox_codigoDeProducto.Name = "listbox_codigoDeProducto"
        Me.listbox_codigoDeProducto.Size = New System.Drawing.Size(128, 342)
        Me.listbox_codigoDeProducto.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.listbox_producto)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.listbox_codigoDeProducto)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.listbox_costo)
        Me.GroupBox1.Controls.Add(Me.listbox_descuento)
        Me.GroupBox1.Controls.Add(Me.listbox_comision)
        Me.GroupBox1.Controls.Add(Me.listbox_precio_unitario)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(274, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(682, 410)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de Productos"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(578, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Costo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(484, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Descuentos"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(386, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Comisiones"
        '
        'listbox_costo
        '
        Me.listbox_costo.FormattingEnabled = True
        Me.listbox_costo.Location = New System.Drawing.Point(580, 46)
        Me.listbox_costo.Name = "listbox_costo"
        Me.listbox_costo.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listbox_costo.Size = New System.Drawing.Size(96, 342)
        Me.listbox_costo.TabIndex = 14
        '
        'listbox_descuento
        '
        Me.listbox_descuento.FormattingEnabled = True
        Me.listbox_descuento.Location = New System.Drawing.Point(486, 46)
        Me.listbox_descuento.Name = "listbox_descuento"
        Me.listbox_descuento.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listbox_descuento.Size = New System.Drawing.Size(96, 342)
        Me.listbox_descuento.TabIndex = 14
        '
        'listbox_comision
        '
        Me.listbox_comision.FormattingEnabled = True
        Me.listbox_comision.Location = New System.Drawing.Point(389, 46)
        Me.listbox_comision.Name = "listbox_comision"
        Me.listbox_comision.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listbox_comision.Size = New System.Drawing.Size(96, 342)
        Me.listbox_comision.TabIndex = 14
        '
        'text_comision
        '
        Me.text_comision.Location = New System.Drawing.Point(128, 121)
        Me.text_comision.Name = "text_comision"
        Me.text_comision.Size = New System.Drawing.Size(123, 20)
        Me.text_comision.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Comision"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 147)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Descuento"
        '
        'text_descuento
        '
        Me.text_descuento.Location = New System.Drawing.Point(128, 147)
        Me.text_descuento.Name = "text_descuento"
        Me.text_descuento.Size = New System.Drawing.Size(123, 20)
        Me.text_descuento.TabIndex = 19
        '
        'boton_modificar
        '
        Me.boton_modificar.Location = New System.Drawing.Point(156, 216)
        Me.boton_modificar.Name = "boton_modificar"
        Me.boton_modificar.Size = New System.Drawing.Size(112, 31)
        Me.boton_modificar.TabIndex = 3
        Me.boton_modificar.Text = "Modificar"
        Me.boton_modificar.UseVisualStyleBackColor = True
        '
        'boton_cancelar
        '
        Me.boton_cancelar.Location = New System.Drawing.Point(84, 253)
        Me.boton_cancelar.Name = "boton_cancelar"
        Me.boton_cancelar.Size = New System.Drawing.Size(112, 31)
        Me.boton_cancelar.TabIndex = 3
        Me.boton_cancelar.Text = "Cancelar"
        Me.boton_cancelar.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 173)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Costo"
        '
        'TextBox_costo
        '
        Me.TextBox_costo.Location = New System.Drawing.Point(128, 173)
        Me.TextBox_costo.Name = "TextBox_costo"
        Me.TextBox_costo.Size = New System.Drawing.Size(123, 20)
        Me.TextBox_costo.TabIndex = 19
        '
        'agregarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 457)
        Me.Controls.Add(Me.TextBox_costo)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.text_descuento)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.text_comision)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.text_precioUnitario)
        Me.Controls.Add(Me.text_descripcion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.text_codigoDeProducto)
        Me.Controls.Add(Me.boton_cancelar)
        Me.Controls.Add(Me.boton_modificar)
        Me.Controls.Add(Me.boton_agregar_producto)
        Me.Name = "agregarProducto"
        Me.Text = "agregarProducto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents boton_agregar_producto As System.Windows.Forms.Button
    Friend WithEvents text_codigoDeProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents text_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents text_precioUnitario As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents listbox_precio_unitario As System.Windows.Forms.ListBox
    Friend WithEvents listbox_producto As System.Windows.Forms.ListBox
    Friend WithEvents listbox_codigoDeProducto As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents text_comision As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents listbox_descuento As System.Windows.Forms.ListBox
    Friend WithEvents listbox_comision As System.Windows.Forms.ListBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents text_descuento As System.Windows.Forms.TextBox
    Friend WithEvents boton_modificar As System.Windows.Forms.Button
    Friend WithEvents boton_cancelar As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents listbox_costo As System.Windows.Forms.ListBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox_costo As System.Windows.Forms.TextBox
End Class
