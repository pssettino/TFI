<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAMBodega
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
        Me.GroupBox_FrmMed = New System.Windows.Forms.GroupBox()
        Me.cmbLocalidad = New System.Windows.Forms.ComboBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblLaboratorio = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.txtCuit = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbProvincia = New System.Windows.Forms.ComboBox()
        Me.TextTelefono = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox_FrmMed.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox_FrmMed
        '
        Me.GroupBox_FrmMed.Controls.Add(Me.cmbProvincia)
        Me.GroupBox_FrmMed.Controls.Add(Me.cmbLocalidad)
        Me.GroupBox_FrmMed.Controls.Add(Me.btnCancelar)
        Me.GroupBox_FrmMed.Controls.Add(Me.btnAceptar)
        Me.GroupBox_FrmMed.Controls.Add(Me.Label1)
        Me.GroupBox_FrmMed.Controls.Add(Me.Label2)
        Me.GroupBox_FrmMed.Controls.Add(Me.lblPrecio)
        Me.GroupBox_FrmMed.Controls.Add(Me.lblLaboratorio)
        Me.GroupBox_FrmMed.Controls.Add(Me.lblNombre)
        Me.GroupBox_FrmMed.Controls.Add(Me.TextTelefono)
        Me.GroupBox_FrmMed.Controls.Add(Me.txtRazonSocial)
        Me.GroupBox_FrmMed.Controls.Add(Me.txtCuit)
        Me.GroupBox_FrmMed.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox_FrmMed.Name = "GroupBox_FrmMed"
        Me.GroupBox_FrmMed.Size = New System.Drawing.Size(353, 305)
        Me.GroupBox_FrmMed.TabIndex = 10
        Me.GroupBox_FrmMed.TabStop = False
        Me.GroupBox_FrmMed.Text = "Bodega"
        '
        'cmbLocalidad
        '
        Me.cmbLocalidad.FormattingEnabled = True
        Me.cmbLocalidad.Location = New System.Drawing.Point(87, 230)
        Me.cmbLocalidad.Name = "cmbLocalidad"
        Me.cmbLocalidad.Size = New System.Drawing.Size(258, 21)
        Me.cmbLocalidad.TabIndex = 115
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(220, 272)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(127, 27)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "&Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(87, 272)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(127, 27)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "&Aceptar"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(13, 80)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(70, 13)
        Me.lblPrecio.TabIndex = 2
        Me.lblPrecio.Text = "Razón Social"
        Me.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLaboratorio
        '
        Me.lblLaboratorio.AutoSize = True
        Me.lblLaboratorio.Location = New System.Drawing.Point(33, 230)
        Me.lblLaboratorio.Name = "lblLaboratorio"
        Me.lblLaboratorio.Size = New System.Drawing.Size(53, 13)
        Me.lblLaboratorio.TabIndex = 2
        Me.lblLaboratorio.Text = "Localidad"
        Me.lblLaboratorio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(51, 31)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(32, 13)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "CUIT"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.Location = New System.Drawing.Point(89, 77)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(258, 20)
        Me.txtRazonSocial.TabIndex = 3
        Me.txtRazonSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCuit
        '
        Me.txtCuit.Location = New System.Drawing.Point(89, 28)
        Me.txtCuit.Name = "txtCuit"
        Me.txtCuit.Size = New System.Drawing.Size(125, 20)
        Me.txtCuit.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Provincia"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbProvincia
        '
        Me.cmbProvincia.FormattingEnabled = True
        Me.cmbProvincia.Location = New System.Drawing.Point(89, 177)
        Me.cmbProvincia.Name = "cmbProvincia"
        Me.cmbProvincia.Size = New System.Drawing.Size(258, 21)
        Me.cmbProvincia.TabIndex = 115
        '
        'TextTelefono
        '
        Me.TextTelefono.Location = New System.Drawing.Point(89, 126)
        Me.TextTelefono.Name = "TextTelefono"
        Me.TextTelefono.Size = New System.Drawing.Size(125, 20)
        Me.TextTelefono.TabIndex = 3
        Me.TextTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Teléfono"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmAMBodega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 329)
        Me.Controls.Add(Me.GroupBox_FrmMed)
        Me.Name = "frmAMBodega"
        Me.Text = "Bodega"
        Me.GroupBox_FrmMed.ResumeLayout(False)
        Me.GroupBox_FrmMed.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox_FrmMed As System.Windows.Forms.GroupBox
    Friend WithEvents cmbLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents lblPrecio As System.Windows.Forms.Label
    Friend WithEvents lblLaboratorio As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents txtCuit As System.Windows.Forms.TextBox
    Friend WithEvents cmbProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextTelefono As System.Windows.Forms.TextBox
End Class
