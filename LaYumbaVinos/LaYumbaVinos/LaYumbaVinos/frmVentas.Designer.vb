<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentas
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.btnLimpiarVenta = New System.Windows.Forms.Button()
        Me.btnBuscarVenta = New System.Windows.Forms.Button()
        Me.lblFechaDesde = New System.Windows.Forms.Label()
        Me.lblFechaHasta = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnNuevaVenta = New System.Windows.Forms.Button()
        Me.dgVentas = New System.Windows.Forms.DataGridView()
        Me.NroVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_Venta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgBtnModificarVenta = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbCliente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpFechaDesde)
        Me.GroupBox1.Controls.Add(Me.dtpFechaHasta)
        Me.GroupBox1.Controls.Add(Me.btnLimpiarVenta)
        Me.GroupBox1.Controls.Add(Me.btnBuscarVenta)
        Me.GroupBox1.Controls.Add(Me.lblFechaDesde)
        Me.GroupBox1.Controls.Add(Me.lblFechaHasta)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(769, 96)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro"
        '
        'cmbCliente
        '
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(116, 55)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(128, 21)
        Me.cmbCliente.TabIndex = 117
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 19)
        Me.Label2.TabIndex = 116
        Me.Label2.Text = "Cliente"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDesde.Location = New System.Drawing.Point(116, 19)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(128, 20)
        Me.dtpFechaDesde.TabIndex = 114
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaHasta.Location = New System.Drawing.Point(341, 19)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(130, 20)
        Me.dtpFechaHasta.TabIndex = 113
        '
        'btnLimpiarVenta
        '
        Me.btnLimpiarVenta.Location = New System.Drawing.Point(615, 19)
        Me.btnLimpiarVenta.Name = "btnLimpiarVenta"
        Me.btnLimpiarVenta.Size = New System.Drawing.Size(127, 27)
        Me.btnLimpiarVenta.TabIndex = 110
        Me.btnLimpiarVenta.Text = "&Limpiar"
        Me.btnLimpiarVenta.UseVisualStyleBackColor = True
        '
        'btnBuscarVenta
        '
        Me.btnBuscarVenta.Location = New System.Drawing.Point(477, 19)
        Me.btnBuscarVenta.Name = "btnBuscarVenta"
        Me.btnBuscarVenta.Size = New System.Drawing.Size(127, 27)
        Me.btnBuscarVenta.TabIndex = 108
        Me.btnBuscarVenta.Text = "&Buscar"
        Me.btnBuscarVenta.UseVisualStyleBackColor = True
        '
        'lblFechaDesde
        '
        Me.lblFechaDesde.Location = New System.Drawing.Point(6, 19)
        Me.lblFechaDesde.Name = "lblFechaDesde"
        Me.lblFechaDesde.Size = New System.Drawing.Size(107, 20)
        Me.lblFechaDesde.TabIndex = 111
        Me.lblFechaDesde.Text = "Fecha desde"
        Me.lblFechaDesde.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.Location = New System.Drawing.Point(253, 19)
        Me.lblFechaHasta.Name = "lblFechaHasta"
        Me.lblFechaHasta.Size = New System.Drawing.Size(82, 20)
        Me.lblFechaHasta.TabIndex = 112
        Me.lblFechaHasta.Text = "Fecha hasta"
        Me.lblFechaHasta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnNuevaVenta)
        Me.GroupBox2.Controls.Add(Me.dgVentas)
        Me.GroupBox2.Location = New System.Drawing.Point(28, 124)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(769, 329)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ventas"
        '
        'btnNuevaVenta
        '
        Me.btnNuevaVenta.Location = New System.Drawing.Point(14, 19)
        Me.btnNuevaVenta.Name = "btnNuevaVenta"
        Me.btnNuevaVenta.Size = New System.Drawing.Size(127, 27)
        Me.btnNuevaVenta.TabIndex = 98
        Me.btnNuevaVenta.Text = "&Nueva Venta"
        Me.btnNuevaVenta.UseVisualStyleBackColor = True
        '
        'dgVentas
        '
        Me.dgVentas.AllowUserToAddRows = False
        Me.dgVentas.AllowUserToDeleteRows = False
        Me.dgVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroVenta, Me.Cliente, Me.Fecha_Venta, Me.Total, Me.dgBtnModificarVenta})
        Me.dgVentas.Location = New System.Drawing.Point(14, 62)
        Me.dgVentas.Name = "dgVentas"
        Me.dgVentas.ReadOnly = True
        Me.dgVentas.RowHeadersVisible = False
        Me.dgVentas.Size = New System.Drawing.Size(736, 252)
        Me.dgVentas.TabIndex = 97
        '
        'NroVenta
        '
        Me.NroVenta.FillWeight = 50.0!
        Me.NroVenta.HeaderText = "NroVenta"
        Me.NroVenta.Name = "NroVenta"
        Me.NroVenta.ReadOnly = True
        '
        'Cliente
        '
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        '
        'Fecha_Venta
        '
        Me.Fecha_Venta.FillWeight = 90.0!
        Me.Fecha_Venta.HeaderText = "Fecha y Hora"
        Me.Fecha_Venta.Name = "Fecha_Venta"
        Me.Fecha_Venta.ReadOnly = True
        '
        'Total
        '
        Me.Total.FillWeight = 80.0!
        Me.Total.HeaderText = "Importe Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'dgBtnModificarVenta
        '
        Me.dgBtnModificarVenta.HeaderText = ""
        Me.dgBtnModificarVenta.Name = "dgBtnModificarVenta"
        Me.dgBtnModificarVenta.ReadOnly = True
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 465)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmVentas"
        Me.Text = "Ventas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnLimpiarVenta As System.Windows.Forms.Button
    Friend WithEvents btnBuscarVenta As System.Windows.Forms.Button
    Friend WithEvents lblFechaDesde As System.Windows.Forms.Label
    Friend WithEvents lblFechaHasta As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnNuevaVenta As System.Windows.Forms.Button
    Friend WithEvents dgVentas As System.Windows.Forms.DataGridView
    Friend WithEvents NroVenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha_Venta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgBtnModificarVenta As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents cmbCliente As System.Windows.Forms.ComboBox
End Class
