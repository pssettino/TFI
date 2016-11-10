<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Me.dgUsuarios = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido_Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgUsuarioBtnModificar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dgUsuarioBtnEliminado = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dgUsuarioBtnBloqueado = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.bloqueado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.btnNuevoUsuario = New System.Windows.Forms.Button()
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgUsuarios
        '
        Me.dgUsuarios.AllowUserToAddRows = False
        Me.dgUsuarios.AllowUserToDeleteRows = False
        Me.dgUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Nombre_Usuario, Me.Apellido_Nombre, Me.Email, Me.dgUsuarioBtnModificar, Me.dgUsuarioBtnEliminado, Me.dgUsuarioBtnBloqueado, Me.bloqueado, Me.Eliminado})
        Me.dgUsuarios.Location = New System.Drawing.Point(13, 67)
        Me.dgUsuarios.Name = "dgUsuarios"
        Me.dgUsuarios.ReadOnly = True
        Me.dgUsuarios.RowHeadersVisible = False
        Me.dgUsuarios.Size = New System.Drawing.Size(735, 294)
        Me.dgUsuarios.TabIndex = 0
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'Nombre_Usuario
        '
        Me.Nombre_Usuario.HeaderText = "Usuario"
        Me.Nombre_Usuario.Name = "Nombre_Usuario"
        Me.Nombre_Usuario.ReadOnly = True
        '
        'Apellido_Nombre
        '
        Me.Apellido_Nombre.FillWeight = 200.0!
        Me.Apellido_Nombre.HeaderText = "Apellido y Nombre"
        Me.Apellido_Nombre.Name = "Apellido_Nombre"
        Me.Apellido_Nombre.ReadOnly = True
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        '
        'dgUsuarioBtnModificar
        '
        Me.dgUsuarioBtnModificar.HeaderText = ""
        Me.dgUsuarioBtnModificar.Name = "dgUsuarioBtnModificar"
        Me.dgUsuarioBtnModificar.ReadOnly = True
        Me.dgUsuarioBtnModificar.Text = "Modificar"
        Me.dgUsuarioBtnModificar.UseColumnTextForButtonValue = True
        '
        'dgUsuarioBtnEliminado
        '
        Me.dgUsuarioBtnEliminado.HeaderText = ""
        Me.dgUsuarioBtnEliminado.Name = "dgUsuarioBtnEliminado"
        Me.dgUsuarioBtnEliminado.ReadOnly = True
        Me.dgUsuarioBtnEliminado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgUsuarioBtnEliminado.Text = "Eliminar"
        Me.dgUsuarioBtnEliminado.UseColumnTextForButtonValue = True
        '
        'dgUsuarioBtnBloqueado
        '
        Me.dgUsuarioBtnBloqueado.HeaderText = ""
        Me.dgUsuarioBtnBloqueado.Name = "dgUsuarioBtnBloqueado"
        Me.dgUsuarioBtnBloqueado.ReadOnly = True
        Me.dgUsuarioBtnBloqueado.Text = "Bloquear"
        Me.dgUsuarioBtnBloqueado.UseColumnTextForButtonValue = True
        '
        'bloqueado
        '
        Me.bloqueado.HeaderText = ""
        Me.bloqueado.Name = "bloqueado"
        Me.bloqueado.ReadOnly = True
        Me.bloqueado.Visible = False
        '
        'Eliminado
        '
        Me.Eliminado.HeaderText = ""
        Me.Eliminado.Name = "Eliminado"
        Me.Eliminado.ReadOnly = True
        Me.Eliminado.Visible = False
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.dgUsuarios)
        Me.GroupBox.Controls.Add(Me.btnNuevoUsuario)
        Me.GroupBox.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(763, 376)
        Me.GroupBox.TabIndex = 90
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "Usuarios"
        '
        'btnNuevoUsuario
        '
        Me.btnNuevoUsuario.Location = New System.Drawing.Point(13, 34)
        Me.btnNuevoUsuario.Name = "btnNuevoUsuario"
        Me.btnNuevoUsuario.Size = New System.Drawing.Size(127, 27)
        Me.btnNuevoUsuario.TabIndex = 91
        Me.btnNuevoUsuario.Text = "&Nuevo Usuario"
        Me.btnNuevoUsuario.UseVisualStyleBackColor = True
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(785, 396)
        Me.Controls.Add(Me.GroupBox)
        Me.MaximizeBox = False
        Me.Name = "frmUsuarios"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Usuarios"
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents btnNuevoUsuario As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido_Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgUsuarioBtnModificar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents dgUsuarioBtnEliminado As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents dgUsuarioBtnBloqueado As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents bloqueado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Eliminado As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
