﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAMUsuario
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
        Me.btnRestablecer = New System.Windows.Forms.Button()
        Me.lblusuario = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblDni = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgPatentes = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgAsignarPatente = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dgPatenteNegada = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.patente_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgFamilias = New System.Windows.Forms.DataGridView()
        Me.Nombre_Familia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.familia_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgAsignarFamilia = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblPatentes = New System.Windows.Forms.Label()
        Me.lblFamilias = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgPatentes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgFamilias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnRestablecer)
        Me.GroupBox1.Controls.Add(Me.lblusuario)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtApellido)
        Me.GroupBox1.Controls.Add(Me.txtDni)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.lblNombre)
        Me.GroupBox1.Controls.Add(Me.lblApellido)
        Me.GroupBox1.Controls.Add(Me.lblDni)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtUser)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(599, 132)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Usuario"
        '
        'btnRestablecer
        '
        Me.btnRestablecer.Location = New System.Drawing.Point(380, 15)
        Me.btnRestablecer.Name = "btnRestablecer"
        Me.btnRestablecer.Size = New System.Drawing.Size(201, 27)
        Me.btnRestablecer.TabIndex = 118
        Me.btnRestablecer.Text = "&Restablecer Contraseña"
        '
        'lblusuario
        '
        Me.lblusuario.AutoSize = True
        Me.lblusuario.Location = New System.Drawing.Point(12, 22)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(43, 13)
        Me.lblusuario.TabIndex = 111
        Me.lblusuario.Text = "Usuario"
        Me.lblusuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombre
        '
        Me.txtNombre.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNombre.Location = New System.Drawing.Point(62, 92)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(206, 20)
        Me.txtNombre.TabIndex = 105
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(62, 56)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(206, 20)
        Me.txtApellido.TabIndex = 104
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(380, 56)
        Me.txtDni.MaxLength = 8
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(201, 20)
        Me.txtDni.TabIndex = 106
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(380, 92)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(201, 20)
        Me.txtEmail.TabIndex = 107
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(12, 95)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 108
        Me.lblNombre.Text = "Nombre"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(12, 59)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(44, 13)
        Me.lblApellido.TabIndex = 109
        Me.lblApellido.Text = "Apellido"
        Me.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDni
        '
        Me.lblDni.AutoSize = True
        Me.lblDni.Location = New System.Drawing.Point(348, 59)
        Me.lblDni.Name = "lblDni"
        Me.lblDni.Size = New System.Drawing.Size(26, 13)
        Me.lblDni.TabIndex = 110
        Me.lblDni.Text = "DNI"
        Me.lblDni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(338, 95)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 13)
        Me.Label12.TabIndex = 112
        Me.Label12.Text = "E-Mail"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(62, 19)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(206, 20)
        Me.txtUser.TabIndex = 103
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.dgPatentes)
        Me.GroupBox2.Controls.Add(Me.dgFamilias)
        Me.GroupBox2.Controls.Add(Me.btnCancelar)
        Me.GroupBox2.Controls.Add(Me.btnAceptar)
        Me.GroupBox2.Controls.Add(Me.lblPatentes)
        Me.GroupBox2.Controls.Add(Me.lblFamilias)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 151)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(597, 409)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Familias y Patentes"
        '
        'dgPatentes
        '
        Me.dgPatentes.AllowUserToAddRows = False
        Me.dgPatentes.AllowUserToDeleteRows = False
        Me.dgPatentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgPatentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPatentes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.dgAsignarPatente, Me.dgPatenteNegada, Me.patente_id})
        Me.dgPatentes.Location = New System.Drawing.Point(62, 169)
        Me.dgPatentes.Margin = New System.Windows.Forms.Padding(2)
        Me.dgPatentes.Name = "dgPatentes"
        Me.dgPatentes.RowHeadersVisible = False
        Me.dgPatentes.RowTemplate.Height = 24
        Me.dgPatentes.Size = New System.Drawing.Size(519, 186)
        Me.dgPatentes.TabIndex = 102
        '
        'Nombre
        '
        Me.Nombre.FillWeight = 140.0!
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'dgAsignarPatente
        '
        Me.dgAsignarPatente.FillWeight = 70.0!
        Me.dgAsignarPatente.HeaderText = "Asignada"
        Me.dgAsignarPatente.Name = "dgAsignarPatente"
        '
        'dgPatenteNegada
        '
        Me.dgPatenteNegada.FillWeight = 70.0!
        Me.dgPatenteNegada.HeaderText = "Negada"
        Me.dgPatenteNegada.Name = "dgPatenteNegada"
        '
        'patente_id
        '
        Me.patente_id.HeaderText = ""
        Me.patente_id.Name = "patente_id"
        Me.patente_id.Visible = False
        '
        'dgFamilias
        '
        Me.dgFamilias.AllowUserToAddRows = False
        Me.dgFamilias.AllowUserToDeleteRows = False
        Me.dgFamilias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgFamilias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFamilias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre_Familia, Me.familia_id, Me.dgAsignarFamilia})
        Me.dgFamilias.Location = New System.Drawing.Point(62, 30)
        Me.dgFamilias.Margin = New System.Windows.Forms.Padding(2)
        Me.dgFamilias.Name = "dgFamilias"
        Me.dgFamilias.RowHeadersVisible = False
        Me.dgFamilias.RowTemplate.Height = 24
        Me.dgFamilias.Size = New System.Drawing.Size(519, 122)
        Me.dgFamilias.TabIndex = 103
        '
        'Nombre_Familia
        '
        Me.Nombre_Familia.FillWeight = 140.0!
        Me.Nombre_Familia.HeaderText = "Nombre"
        Me.Nombre_Familia.Name = "Nombre_Familia"
        Me.Nombre_Familia.ReadOnly = True
        '
        'familia_id
        '
        Me.familia_id.HeaderText = ""
        Me.familia_id.Name = "familia_id"
        Me.familia_id.Visible = False
        '
        'dgAsignarFamilia
        '
        Me.dgAsignarFamilia.FillWeight = 140.0!
        Me.dgAsignarFamilia.HeaderText = "Asignada"
        Me.dgAsignarFamilia.Name = "dgAsignarFamilia"
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(454, 376)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(127, 27)
        Me.btnCancelar.TabIndex = 105
        Me.btnCancelar.Text = "&Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(321, 376)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(127, 27)
        Me.btnAceptar.TabIndex = 104
        Me.btnAceptar.Text = "&Aceptar"
        '
        'lblPatentes
        '
        Me.lblPatentes.AutoSize = True
        Me.lblPatentes.Location = New System.Drawing.Point(6, 169)
        Me.lblPatentes.Name = "lblPatentes"
        Me.lblPatentes.Size = New System.Drawing.Size(49, 13)
        Me.lblPatentes.TabIndex = 100
        Me.lblPatentes.Text = "Patentes"
        '
        'lblFamilias
        '
        Me.lblFamilias.AutoSize = True
        Me.lblFamilias.Location = New System.Drawing.Point(40, -58)
        Me.lblFamilias.Name = "lblFamilias"
        Me.lblFamilias.Size = New System.Drawing.Size(44, 13)
        Me.lblFamilias.TabIndex = 101
        Me.lblFamilias.Text = "Familias"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Familias"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(318, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 119
        Me.Label2.Text = "Contraseña"
        '
        'frmAMUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 572)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAMUsuario"
        Me.Text = "Usuario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgPatentes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgFamilias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRestablecer As System.Windows.Forms.Button
    Friend WithEvents lblusuario As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtDni As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents lblDni As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgPatentes As System.Windows.Forms.DataGridView
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgAsignarPatente As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents dgPatenteNegada As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents patente_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgFamilias As System.Windows.Forms.DataGridView
    Friend WithEvents Nombre_Familia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents familia_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgAsignarFamilia As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents lblPatentes As System.Windows.Forms.Label
    Friend WithEvents lblFamilias As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class