﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAMFamilia
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
        Me.dgPatentes = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgAsignarPatente = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.patente_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblpatentes = New System.Windows.Forms.Label()
        Me.lbldescripcion = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.GroupBox.SuspendLayout()
        CType(Me.dgPatentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.dgPatentes)
        Me.GroupBox.Controls.Add(Me.lblpatentes)
        Me.GroupBox.Controls.Add(Me.lbldescripcion)
        Me.GroupBox.Controls.Add(Me.btnCancelar)
        Me.GroupBox.Controls.Add(Me.lblnombre)
        Me.GroupBox.Controls.Add(Me.btnAceptar)
        Me.GroupBox.Controls.Add(Me.txtDescripcion)
        Me.GroupBox.Controls.Add(Me.txtNombre)
        Me.GroupBox.Location = New System.Drawing.Point(6, 12)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(438, 364)
        Me.GroupBox.TabIndex = 4
        Me.GroupBox.TabStop = False
        '
        'dgPatentes
        '
        Me.dgPatentes.AllowUserToAddRows = False
        Me.dgPatentes.AllowUserToDeleteRows = False
        Me.dgPatentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgPatentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPatentes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.dgAsignarPatente, Me.patente_id})
        Me.dgPatentes.Location = New System.Drawing.Point(82, 99)
        Me.dgPatentes.Margin = New System.Windows.Forms.Padding(2)
        Me.dgPatentes.Name = "dgPatentes"
        Me.dgPatentes.RowHeadersVisible = False
        Me.dgPatentes.RowTemplate.Height = 24
        Me.dgPatentes.Size = New System.Drawing.Size(344, 217)
        Me.dgPatentes.TabIndex = 51
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
        'patente_id
        '
        Me.patente_id.HeaderText = ""
        Me.patente_id.Name = "patente_id"
        Me.patente_id.Visible = False
        '
        'lblpatentes
        '
        Me.lblpatentes.AutoSize = True
        Me.lblpatentes.Location = New System.Drawing.Point(24, 104)
        Me.lblpatentes.Name = "lblpatentes"
        Me.lblpatentes.Size = New System.Drawing.Size(49, 13)
        Me.lblpatentes.TabIndex = 10
        Me.lblpatentes.Text = "Patentes"
        '
        'lbldescripcion
        '
        Me.lbldescripcion.AutoSize = True
        Me.lbldescripcion.Location = New System.Drawing.Point(10, 64)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.Size = New System.Drawing.Size(63, 13)
        Me.lbldescripcion.TabIndex = 10
        Me.lbldescripcion.Text = "Descripcion"
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(299, 327)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(127, 27)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "&Cancelar"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(29, 22)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(44, 13)
        Me.lblnombre.TabIndex = 10
        Me.lblnombre.Text = "Nombre"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(166, 327)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(127, 27)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "&Aceptar"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(82, 61)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(344, 20)
        Me.txtDescripcion.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(82, 19)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(344, 20)
        Me.txtNombre.TabIndex = 0
        '
        'frmAMFamilia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 381)
        Me.Controls.Add(Me.GroupBox)
        Me.Name = "frmAMFamilia"
        Me.Text = "Familia"
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        CType(Me.dgPatentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents dgPatentes As System.Windows.Forms.DataGridView
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgAsignarPatente As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents patente_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblpatentes As System.Windows.Forms.Label
    Friend WithEvents lbldescripcion As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
End Class