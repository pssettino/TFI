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
        Me.grboxBodega = New System.Windows.Forms.GroupBox()
        Me.cmbProvincia = New System.Windows.Forms.ComboBox()
        Me.cmbLocalidad = New System.Windows.Forms.ComboBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblRazonSocial = New System.Windows.Forms.Label()
        Me.lblLocalidad = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.TextTelefono = New System.Windows.Forms.TextBox()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.txtCuit = New System.Windows.Forms.TextBox()
        Me.grboxBodega.SuspendLayout()
        Me.SuspendLayout()
        '
        'grboxBodega
        '
        Me.grboxBodega.Controls.Add(Me.cmbProvincia)
        Me.grboxBodega.Controls.Add(Me.cmbLocalidad)
        Me.grboxBodega.Controls.Add(Me.btnCancelar)
        Me.grboxBodega.Controls.Add(Me.btnAceptar)
        Me.grboxBodega.Controls.Add(Me.Label1)
        Me.grboxBodega.Controls.Add(Me.Label2)
        Me.grboxBodega.Controls.Add(Me.lblRazonSocial)
        Me.grboxBodega.Controls.Add(Me.lblLocalidad)
        Me.grboxBodega.Controls.Add(Me.lblNombre)
        Me.grboxBodega.Controls.Add(Me.TextTelefono)
        Me.grboxBodega.Controls.Add(Me.txtRazonSocial)
        Me.grboxBodega.Controls.Add(Me.txtCuit)
        Me.grboxBodega.Location = New System.Drawing.Point(12, 12)
        Me.grboxBodega.Name = "grboxBodega"
        Me.grboxBodega.Size = New System.Drawing.Size(353, 305)
        Me.grboxBodega.TabIndex = 10
        Me.grboxBodega.TabStop = False
        Me.grboxBodega.Text = "Bodega"
        '
        'cmbProvincia
        '
        Me.cmbProvincia.FormattingEnabled = True
        Me.cmbProvincia.Location = New System.Drawing.Point(89, 177)
        Me.cmbProvincia.Name = "cmbProvincia"
        Me.cmbProvincia.Size = New System.Drawing.Size(258, 21)
        Me.cmbProvincia.TabIndex = 115
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
        'lblRazonSocial
        '
        Me.lblRazonSocial.AutoSize = True
        Me.lblRazonSocial.Location = New System.Drawing.Point(13, 80)
        Me.lblRazonSocial.Name = "lblRazonSocial"
        Me.lblRazonSocial.Size = New System.Drawing.Size(70, 13)
        Me.lblRazonSocial.TabIndex = 2
        Me.lblRazonSocial.Text = "Razón Social"
        Me.lblRazonSocial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLocalidad
        '
        Me.lblLocalidad.AutoSize = True
        Me.lblLocalidad.Location = New System.Drawing.Point(33, 230)
        Me.lblLocalidad.Name = "lblLocalidad"
        Me.lblLocalidad.Size = New System.Drawing.Size(53, 13)
        Me.lblLocalidad.TabIndex = 2
        Me.lblLocalidad.Text = "Localidad"
        Me.lblLocalidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'TextTelefono
        '
        Me.TextTelefono.Location = New System.Drawing.Point(89, 126)
        Me.TextTelefono.Name = "TextTelefono"
        Me.TextTelefono.Size = New System.Drawing.Size(125, 20)
        Me.TextTelefono.TabIndex = 3
        Me.TextTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        'frmAMBodega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 329)
        Me.Controls.Add(Me.grboxBodega)
        Me.Name = "frmAMBodega"
        Me.Text = "Bodega"
        Me.grboxBodega.ResumeLayout(False)
        Me.grboxBodega.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grboxBodega As System.Windows.Forms.GroupBox
    Friend WithEvents cmbLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents lblRazonSocial As System.Windows.Forms.Label
    Friend WithEvents lblLocalidad As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents txtCuit As System.Windows.Forms.TextBox
    Friend WithEvents cmbProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextTelefono As System.Windows.Forms.TextBox
End Class
