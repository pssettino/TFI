﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAMRecepcionVino
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
        Me.txtCantidad = New System.Windows.Forms.NumericUpDown()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.GroupBox_FrmMed = New System.Windows.Forms.GroupBox()
        Me.cmbBodega = New System.Windows.Forms.ComboBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblLaboratorio = New System.Windows.Forms.Label()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_FrmMed.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(65, 56)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCantidad.Maximum = New Decimal(New Integer() {32767, 0, 0, 0})
        Me.txtCantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(110, 20)
        Me.txtCantidad.TabIndex = 114
        Me.txtCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(11, 56)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(49, 13)
        Me.lblCantidad.TabIndex = 2
        Me.lblCantidad.Text = "Cantidad"
        Me.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox_FrmMed
        '
        Me.GroupBox_FrmMed.Controls.Add(Me.cmbBodega)
        Me.GroupBox_FrmMed.Controls.Add(Me.txtCantidad)
        Me.GroupBox_FrmMed.Controls.Add(Me.btnCancelar)
        Me.GroupBox_FrmMed.Controls.Add(Me.btnAceptar)
        Me.GroupBox_FrmMed.Controls.Add(Me.lblCantidad)
        Me.GroupBox_FrmMed.Controls.Add(Me.lblLaboratorio)
        Me.GroupBox_FrmMed.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox_FrmMed.Name = "GroupBox_FrmMed"
        Me.GroupBox_FrmMed.Size = New System.Drawing.Size(353, 161)
        Me.GroupBox_FrmMed.TabIndex = 10
        Me.GroupBox_FrmMed.TabStop = False
        Me.GroupBox_FrmMed.Text = "Ingreso de Vino"
        '
        'cmbBodega
        '
        Me.cmbBodega.FormattingEnabled = True
        Me.cmbBodega.Location = New System.Drawing.Point(65, 19)
        Me.cmbBodega.Name = "cmbBodega"
        Me.cmbBodega.Size = New System.Drawing.Size(242, 21)
        Me.cmbBodega.TabIndex = 115
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(180, 116)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(127, 27)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "&Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(47, 116)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(127, 27)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "&Aceptar"
        '
        'lblLaboratorio
        '
        Me.lblLaboratorio.AutoSize = True
        Me.lblLaboratorio.Location = New System.Drawing.Point(15, 27)
        Me.lblLaboratorio.Name = "lblLaboratorio"
        Me.lblLaboratorio.Size = New System.Drawing.Size(28, 13)
        Me.lblLaboratorio.TabIndex = 2
        Me.lblLaboratorio.Text = "Vino"
        Me.lblLaboratorio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmAMRecepcionVino
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 184)
        Me.Controls.Add(Me.GroupBox_FrmMed)
        Me.Name = "frmAMRecepcionVino"
        Me.Text = "Recepcion de Vinos"
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_FrmMed.ResumeLayout(False)
        Me.GroupBox_FrmMed.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtCantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents GroupBox_FrmMed As System.Windows.Forms.GroupBox
    Friend WithEvents cmbBodega As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents lblLaboratorio As System.Windows.Forms.Label
End Class