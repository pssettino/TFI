<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAMVenta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtNroVenta = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFechaHora = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnAgregarVino = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPrecioLista = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.cmbVino = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtImporteTotal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgVinosPorVenta = New System.Windows.Forms.DataGridView()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.venta_vino_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroVino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gvBtnEliminarVino = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Eliminado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgVinosPorVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNroVenta
        '
        Me.txtNroVenta.Enabled = False
        Me.txtNroVenta.Location = New System.Drawing.Point(119, 18)
        Me.txtNroVenta.Name = "txtNroVenta"
        Me.txtNroVenta.ReadOnly = True
        Me.txtNroVenta.Size = New System.Drawing.Size(103, 20)
        Me.txtNroVenta.TabIndex = 0
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(407, 52)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(111, 20)
        Me.txtPrecio.TabIndex = 5
        Me.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(26, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nro Venta"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFechaHora
        '
        Me.lblFechaHora.Location = New System.Drawing.Point(311, 18)
        Me.lblFechaHora.Name = "lblFechaHora"
        Me.lblFechaHora.Size = New System.Drawing.Size(93, 21)
        Me.lblFechaHora.TabIndex = 2
        Me.lblFechaHora.Text = "Fecha y Hora"
        Me.lblFechaHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(5, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Clientes activos"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(11, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Vino"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(340, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Cantidad"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(307, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 21)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Precio de Venta"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(524, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 21)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Por unidad"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(227, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 21)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Por unidad"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAgregarVino
        '
        Me.btnAgregarVino.Location = New System.Drawing.Point(15, 101)
        Me.btnAgregarVino.Name = "btnAgregarVino"
        Me.btnAgregarVino.Size = New System.Drawing.Size(101, 27)
        Me.btnAgregarVino.TabIndex = 3
        Me.btnAgregarVino.Text = "&Agregar Vino"
        Me.btnAgregarVino.UseVisualStyleBackColor = True
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(408, 18)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCantidad.Maximum = New Decimal(New Integer() {32767, 0, 0, 0})
        Me.txtCantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(110, 20)
        Me.txtCantidad.TabIndex = 113
        Me.txtCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 20)
        Me.Label7.TabIndex = 114
        Me.Label7.Text = "Precio de Lista"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPrecioLista
        '
        Me.txtPrecioLista.Enabled = False
        Me.txtPrecioLista.Location = New System.Drawing.Point(110, 52)
        Me.txtPrecioLista.Name = "txtPrecioLista"
        Me.txtPrecioLista.ReadOnly = True
        Me.txtPrecioLista.Size = New System.Drawing.Size(111, 20)
        Me.txtPrecioLista.TabIndex = 116
        Me.txtPrecioLista.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.lblFechaHora)
        Me.GroupBox1.Controls.Add(Me.txtNroVenta)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(691, 93)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Venta"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(408, 18)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(180, 20)
        Me.DateTimePicker1.TabIndex = 119
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(119, 52)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(171, 21)
        Me.ComboBox2.TabIndex = 118
        '
        'cmbVino
        '
        Me.cmbVino.FormattingEnabled = True
        Me.cmbVino.Location = New System.Drawing.Point(109, 19)
        Me.cmbVino.Name = "cmbVino"
        Me.cmbVino.Size = New System.Drawing.Size(180, 21)
        Me.cmbVino.TabIndex = 118
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCancelar)
        Me.GroupBox2.Controls.Add(Me.txtImporteTotal)
        Me.GroupBox2.Controls.Add(Me.cmbVino)
        Me.GroupBox2.Controls.Add(Me.txtPrecioLista)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.dgVinosPorVenta)
        Me.GroupBox2.Controls.Add(Me.btnAgregarVino)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtPrecio)
        Me.GroupBox2.Controls.Add(Me.btnAceptar)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtCantidad)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(690, 391)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Vinos"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(550, 358)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(127, 27)
        Me.btnCancelar.TabIndex = 123
        Me.btnCancelar.Text = "&Cancelar"
        '
        'txtImporteTotal
        '
        Me.txtImporteTotal.Enabled = False
        Me.txtImporteTotal.Location = New System.Drawing.Point(550, 326)
        Me.txtImporteTotal.Margin = New System.Windows.Forms.Padding(2)
        Me.txtImporteTotal.Name = "txtImporteTotal"
        Me.txtImporteTotal.ReadOnly = True
        Me.txtImporteTotal.Size = New System.Drawing.Size(127, 20)
        Me.txtImporteTotal.TabIndex = 122
        Me.txtImporteTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(481, 329)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 121
        Me.Label9.Text = "Precio Total"
        '
        'dgVinosPorVenta
        '
        Me.dgVinosPorVenta.AllowUserToAddRows = False
        Me.dgVinosPorVenta.AllowUserToDeleteRows = False
        Me.dgVinosPorVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgVinosPorVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVinosPorVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.venta_vino_id, Me.NroVino, Me.Vino, Me.CantVenta, Me.PrecioVenta, Me.gvBtnEliminarVino, Me.Eliminado})
        Me.dgVinosPorVenta.Location = New System.Drawing.Point(15, 144)
        Me.dgVinosPorVenta.Name = "dgVinosPorVenta"
        Me.dgVinosPorVenta.ReadOnly = True
        Me.dgVinosPorVenta.RowHeadersVisible = False
        Me.dgVinosPorVenta.Size = New System.Drawing.Size(662, 177)
        Me.dgVinosPorVenta.TabIndex = 120
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(417, 358)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(127, 27)
        Me.btnAceptar.TabIndex = 119
        Me.btnAceptar.Text = "&Aceptar"
        '
        'venta_vino_id
        '
        Me.venta_vino_id.HeaderText = ""
        Me.venta_vino_id.Name = "venta_vino_id"
        Me.venta_vino_id.ReadOnly = True
        Me.venta_vino_id.Visible = False
        '
        'NroVino
        '
        Me.NroVino.FillWeight = 40.0!
        Me.NroVino.HeaderText = "Nro"
        Me.NroVino.Name = "NroVino"
        Me.NroVino.ReadOnly = True
        '
        'Vino
        '
        Me.Vino.FillWeight = 80.0!
        Me.Vino.HeaderText = "Vino"
        Me.Vino.Name = "Vino"
        Me.Vino.ReadOnly = True
        '
        'CantVenta
        '
        Me.CantVenta.FillWeight = 50.0!
        Me.CantVenta.HeaderText = "Cantidad"
        Me.CantVenta.Name = "CantVenta"
        Me.CantVenta.ReadOnly = True
        '
        'PrecioVenta
        '
        Me.PrecioVenta.FillWeight = 120.0!
        Me.PrecioVenta.HeaderText = "Precio Venta (por unidad)"
        Me.PrecioVenta.Name = "PrecioVenta"
        Me.PrecioVenta.ReadOnly = True
        '
        'gvBtnEliminarVino
        '
        Me.gvBtnEliminarVino.FillWeight = 150.0!
        Me.gvBtnEliminarVino.HeaderText = ""
        Me.gvBtnEliminarVino.Name = "gvBtnEliminarVino"
        Me.gvBtnEliminarVino.ReadOnly = True
        Me.gvBtnEliminarVino.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvBtnEliminarVino.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.gvBtnEliminarVino.Text = "Eliminar"
        '
        'Eliminado
        '
        Me.Eliminado.HeaderText = ""
        Me.Eliminado.Name = "Eliminado"
        Me.Eliminado.ReadOnly = True
        Me.Eliminado.Visible = False
        '
        'frmAMVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 512)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAMVenta"
        Me.Text = "Ventas"
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgVinosPorVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtNroVenta As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblFechaHora As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnAgregarVino As System.Windows.Forms.Button
    Friend WithEvents txtCantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPrecioLista As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbVino As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtImporteTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dgVinosPorVenta As System.Windows.Forms.DataGridView
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents venta_vino_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NroVino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantVenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioVenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gvBtnEliminarVino As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Eliminado As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
