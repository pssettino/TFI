<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVinosReporteFiltro
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
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.cmbBodega = New System.Windows.Forms.ComboBox()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblBodega = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.dgVinos = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bodega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.GroupBox.SuspendLayout()
        CType(Me.dgVinos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.cmbBodega)
        Me.GroupBox.Controls.Add(Me.btnlimpiar)
        Me.GroupBox.Controls.Add(Me.btnBuscar)
        Me.GroupBox.Controls.Add(Me.btnExportar)
        Me.GroupBox.Controls.Add(Me.btnCancelar)
        Me.GroupBox.Controls.Add(Me.lblBodega)
        Me.GroupBox.Controls.Add(Me.lblDescripcion)
        Me.GroupBox.Controls.Add(Me.dgVinos)
        Me.GroupBox.Controls.Add(Me.txtDescripcion)
        Me.GroupBox.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(693, 435)
        Me.GroupBox.TabIndex = 9
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "Reporte de Vinos"
        '
        'cmbBodega
        '
        Me.cmbBodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBodega.FormattingEnabled = True
        Me.cmbBodega.Location = New System.Drawing.Point(112, 66)
        Me.cmbBodega.Name = "cmbBodega"
        Me.cmbBodega.Size = New System.Drawing.Size(272, 21)
        Me.cmbBodega.TabIndex = 97
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Location = New System.Drawing.Point(546, 28)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(127, 27)
        Me.btnlimpiar.TabIndex = 96
        Me.btnlimpiar.Text = "&Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(413, 28)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(127, 27)
        Me.btnBuscar.TabIndex = 94
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Location = New System.Drawing.Point(413, 61)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(127, 27)
        Me.btnExportar.TabIndex = 94
        Me.btnExportar.Text = "&Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(546, 61)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(127, 27)
        Me.btnCancelar.TabIndex = 93
        Me.btnCancelar.Text = "&Cancelar"
        '
        'lblBodega
        '
        Me.lblBodega.AutoSize = True
        Me.lblBodega.Location = New System.Drawing.Point(16, 66)
        Me.lblBodega.Name = "lblBodega"
        Me.lblBodega.Size = New System.Drawing.Size(44, 13)
        Me.lblBodega.TabIndex = 12
        Me.lblBodega.Text = "Bodega"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(13, 31)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.lblDescripcion.TabIndex = 12
        Me.lblDescripcion.Text = "Descripcion"
        '
        'dgVinos
        '
        Me.dgVinos.AllowUserToAddRows = False
        Me.dgVinos.AllowUserToDeleteRows = False
        Me.dgVinos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgVinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVinos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Descripcion, Me.Bodega, Me.Cantidad, Me.Precio, Me.Eliminado})
        Me.dgVinos.Location = New System.Drawing.Point(13, 112)
        Me.dgVinos.Name = "dgVinos"
        Me.dgVinos.ReadOnly = True
        Me.dgVinos.RowHeadersVisible = False
        Me.dgVinos.Size = New System.Drawing.Size(660, 310)
        Me.dgVinos.TabIndex = 8
        '
        'id
        '
        Me.id.FillWeight = 40.0!
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'Bodega
        '
        Me.Bodega.HeaderText = "Bodega"
        Me.Bodega.Name = "Bodega"
        Me.Bodega.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'Eliminado
        '
        Me.Eliminado.HeaderText = "Activo"
        Me.Eliminado.Name = "Eliminado"
        Me.Eliminado.ReadOnly = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(112, 28)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(272, 20)
        Me.txtDescripcion.TabIndex = 0
        '
        'frmVinosReporteFiltro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(712, 452)
        Me.Controls.Add(Me.GroupBox)
        Me.MaximizeBox = False
        Me.Name = "frmVinosReporteFiltro"
        Me.ShowIcon = False
        Me.Text = "Reporte de Vinos"
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        CType(Me.dgVinos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents btnlimpiar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lblBodega As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents dgVinos As System.Windows.Forms.DataGridView
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents cmbBodega As System.Windows.Forms.ComboBox
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Bodega As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Eliminado As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
