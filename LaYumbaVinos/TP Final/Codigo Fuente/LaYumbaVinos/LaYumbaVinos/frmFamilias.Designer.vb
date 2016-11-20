<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFamilias
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
        Me.GroupBox_ListFam = New System.Windows.Forms.GroupBox()
        Me.dgFamilias = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgBtnModificar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dgBtnEliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.HelpProviderHG = New System.Windows.Forms.HelpProvider()
        Me.GroupBox_ListFam.SuspendLayout()
        CType(Me.dgFamilias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox_ListFam
        '
        Me.GroupBox_ListFam.Controls.Add(Me.dgFamilias)
        Me.GroupBox_ListFam.Location = New System.Drawing.Point(12, 45)
        Me.GroupBox_ListFam.Name = "GroupBox_ListFam"
        Me.GroupBox_ListFam.Size = New System.Drawing.Size(531, 211)
        Me.GroupBox_ListFam.TabIndex = 2
        Me.GroupBox_ListFam.TabStop = False
        Me.GroupBox_ListFam.Text = "Familias"
        '
        'dgFamilias
        '
        Me.dgFamilias.AllowUserToAddRows = False
        Me.dgFamilias.AllowUserToDeleteRows = False
        Me.dgFamilias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFamilias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Nombre, Me.Descripcion, Me.dgBtnModificar, Me.dgBtnEliminar})
        Me.HelpProviderHG.SetHelpKeyword(Me.dgFamilias, "frmFamilias_1.htm#dgFamilias")
        Me.HelpProviderHG.SetHelpNavigator(Me.dgFamilias, System.Windows.Forms.HelpNavigator.Topic)
        Me.dgFamilias.Location = New System.Drawing.Point(15, 19)
        Me.dgFamilias.Name = "dgFamilias"
        Me.dgFamilias.ReadOnly = True
        Me.dgFamilias.RowHeadersVisible = False
        Me.HelpProviderHG.SetShowHelp(Me.dgFamilias, True)
        Me.dgFamilias.Size = New System.Drawing.Size(504, 186)
        Me.dgFamilias.TabIndex = 2
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Visible = False
        Me.Id.Width = 50
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 200
        '
        'dgBtnModificar
        '
        Me.dgBtnModificar.HeaderText = ""
        Me.dgBtnModificar.Name = "dgBtnModificar"
        Me.dgBtnModificar.ReadOnly = True
        Me.dgBtnModificar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgBtnModificar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgBtnModificar.Text = "Modificar"
        Me.dgBtnModificar.ToolTipText = "Modificar"
        Me.dgBtnModificar.UseColumnTextForButtonValue = True
        '
        'dgBtnEliminar
        '
        Me.dgBtnEliminar.HeaderText = ""
        Me.dgBtnEliminar.Name = "dgBtnEliminar"
        Me.dgBtnEliminar.ReadOnly = True
        Me.dgBtnEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgBtnEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgBtnEliminar.Text = "Eliminar"
        Me.dgBtnEliminar.ToolTipText = "Eliminar"
        Me.dgBtnEliminar.UseColumnTextForButtonValue = True
        '
        'btnRegistrar
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnRegistrar, "frmFamilias_1.htm#btnRegistrar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnRegistrar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnRegistrar.Location = New System.Drawing.Point(12, 12)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.HelpProviderHG.SetShowHelp(Me.btnRegistrar, True)
        Me.btnRegistrar.Size = New System.Drawing.Size(127, 27)
        Me.btnRegistrar.TabIndex = 6
        Me.btnRegistrar.Text = "&Nueva Familia"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'HelpProviderHG
        '
        Me.HelpProviderHG.HelpNamespace = "LaYumbaVinos.chm"
        '
        'frmFamilias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(549, 265)
        Me.Controls.Add(Me.GroupBox_ListFam)
        Me.Controls.Add(Me.btnRegistrar)
        Me.HelpProviderHG.SetHelpKeyword(Me, "frmFamilias_1.htm")
        Me.HelpProviderHG.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.Topic)
        Me.MaximizeBox = False
        Me.Name = "frmFamilias"
        Me.HelpProviderHG.SetShowHelp(Me, True)
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Familias"
        Me.GroupBox_ListFam.ResumeLayout(False)
        CType(Me.dgFamilias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox_ListFam As System.Windows.Forms.GroupBox
    Friend WithEvents dgFamilias As System.Windows.Forms.DataGridView
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgBtnModificar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents dgBtnEliminar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents HelpProviderHG As System.Windows.Forms.HelpProvider
End Class
