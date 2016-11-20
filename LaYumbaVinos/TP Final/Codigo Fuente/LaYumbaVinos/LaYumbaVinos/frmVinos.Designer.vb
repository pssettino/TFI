<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVinos
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
        Me.cmbVinos = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnNuevoVino = New System.Windows.Forms.Button()
        Me.dgVinos = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bodega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgBtnModificar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dgBtnEliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Eliminado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HelpProviderHG = New System.Windows.Forms.HelpProvider()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgVinos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbVinos)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblDescripcion)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(794, 95)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro"
        '
        'cmbVinos
        '
        Me.cmbVinos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVinos.FormattingEnabled = True
        Me.HelpProviderHG.SetHelpKeyword(Me.cmbVinos, "frmVinos_1.htm#Label1")
        Me.HelpProviderHG.SetHelpNavigator(Me.cmbVinos, System.Windows.Forms.HelpNavigator.Topic)
        Me.cmbVinos.Location = New System.Drawing.Point(515, 46)
        Me.cmbVinos.Name = "cmbVinos"
        Me.HelpProviderHG.SetShowHelp(Me.cmbVinos, True)
        Me.cmbVinos.Size = New System.Drawing.Size(261, 21)
        Me.cmbVinos.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(436, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Bodega"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(6, 46)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.lblDescripcion.TabIndex = 16
        Me.lblDescripcion.Text = "Descripcion"
        '
        'txtDescripcion
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.txtDescripcion, "frmVinos_1.htm#lblDescripcion")
        Me.HelpProviderHG.SetHelpNavigator(Me.txtDescripcion, System.Windows.Forms.HelpNavigator.Topic)
        Me.txtDescripcion.Location = New System.Drawing.Point(87, 46)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.HelpProviderHG.SetShowHelp(Me.txtDescripcion, True)
        Me.txtDescripcion.Size = New System.Drawing.Size(327, 20)
        Me.txtDescripcion.TabIndex = 13
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnNuevoVino)
        Me.GroupBox2.Controls.Add(Me.dgVinos)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 113)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(794, 313)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Vinos"
        '
        'btnNuevoVino
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnNuevoVino, "frmVinos_1.htm#btnNuevoVino")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnNuevoVino, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnNuevoVino.Location = New System.Drawing.Point(9, 19)
        Me.btnNuevoVino.Name = "btnNuevoVino"
        Me.HelpProviderHG.SetShowHelp(Me.btnNuevoVino, True)
        Me.btnNuevoVino.Size = New System.Drawing.Size(127, 27)
        Me.btnNuevoVino.TabIndex = 99
        Me.btnNuevoVino.Text = "&Nuevo Vino"
        Me.btnNuevoVino.UseVisualStyleBackColor = True
        '
        'dgVinos
        '
        Me.dgVinos.AllowUserToAddRows = False
        Me.dgVinos.AllowUserToDeleteRows = False
        Me.dgVinos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgVinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVinos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Descripcion, Me.Bodega, Me.Cantidad, Me.Precio, Me.dgBtnModificar, Me.dgBtnEliminar, Me.Eliminado})
        Me.HelpProviderHG.SetHelpKeyword(Me.dgVinos, "frmVinos_1.htm#dgVinos")
        Me.HelpProviderHG.SetHelpNavigator(Me.dgVinos, System.Windows.Forms.HelpNavigator.Topic)
        Me.dgVinos.Location = New System.Drawing.Point(6, 57)
        Me.dgVinos.Name = "dgVinos"
        Me.dgVinos.ReadOnly = True
        Me.dgVinos.RowHeadersVisible = False
        Me.HelpProviderHG.SetShowHelp(Me.dgVinos, True)
        Me.dgVinos.Size = New System.Drawing.Size(783, 250)
        Me.dgVinos.TabIndex = 9
        '
        'id
        '
        Me.id.FillWeight = 40.0!
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
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
        'dgBtnModificar
        '
        Me.dgBtnModificar.HeaderText = ""
        Me.dgBtnModificar.Name = "dgBtnModificar"
        Me.dgBtnModificar.ReadOnly = True
        Me.dgBtnModificar.Text = "Modificar"
        Me.dgBtnModificar.UseColumnTextForButtonValue = True
        '
        'dgBtnEliminar
        '
        Me.dgBtnEliminar.HeaderText = ""
        Me.dgBtnEliminar.Name = "dgBtnEliminar"
        Me.dgBtnEliminar.ReadOnly = True
        Me.dgBtnEliminar.Text = "Eliminar"
        Me.dgBtnEliminar.UseColumnTextForButtonValue = True
        '
        'Eliminado
        '
        Me.Eliminado.HeaderText = ""
        Me.Eliminado.Name = "Eliminado"
        Me.Eliminado.ReadOnly = True
        Me.Eliminado.Visible = False
        '
        'HelpProviderHG
        '
        Me.HelpProviderHG.HelpNamespace = "LaYumbaVinos.chm"
        '
        'frmVinos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(825, 438)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.HelpProviderHG.SetHelpKeyword(Me, "frmVinos_1.htm")
        Me.HelpProviderHG.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.Topic)
        Me.MaximizeBox = False
        Me.Name = "frmVinos"
        Me.HelpProviderHG.SetShowHelp(Me, True)
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Vinos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgVinos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbVinos As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgVinos As System.Windows.Forms.DataGridView
    Friend WithEvents btnNuevoVino As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Bodega As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgBtnModificar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents dgBtnEliminar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Eliminado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HelpProviderHG As System.Windows.Forms.HelpProvider
End Class
