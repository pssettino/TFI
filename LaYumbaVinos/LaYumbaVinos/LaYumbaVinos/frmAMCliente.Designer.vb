<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAMCliente
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
        Me.GroupBox_FrmCli = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblProvincia = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lbldni = New System.Windows.Forms.Label()
        Me.lblLocalidad = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.cmbProvincia = New System.Windows.Forms.ComboBox()
        Me.cmbLocalidad = New System.Windows.Forms.ComboBox()
        Me.GroupBox_FrmCli.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox_FrmCli
        '
        Me.GroupBox_FrmCli.Controls.Add(Me.cmbLocalidad)
        Me.GroupBox_FrmCli.Controls.Add(Me.cmbProvincia)
        Me.GroupBox_FrmCli.Controls.Add(Me.btnCancelar)
        Me.GroupBox_FrmCli.Controls.Add(Me.btnAceptar)
        Me.GroupBox_FrmCli.Controls.Add(Me.lblEmail)
        Me.GroupBox_FrmCli.Controls.Add(Me.lblNombre)
        Me.GroupBox_FrmCli.Controls.Add(Me.txtEmail)
        Me.GroupBox_FrmCli.Controls.Add(Me.txtNombre)
        Me.GroupBox_FrmCli.Controls.Add(Me.txtApellido)
        Me.GroupBox_FrmCli.Controls.Add(Me.txtTelefono)
        Me.GroupBox_FrmCli.Controls.Add(Me.txtDni)
        Me.GroupBox_FrmCli.Controls.Add(Me.txtDireccion)
        Me.GroupBox_FrmCli.Controls.Add(Me.lblProvincia)
        Me.GroupBox_FrmCli.Controls.Add(Me.lblApellido)
        Me.GroupBox_FrmCli.Controls.Add(Me.lblTelefono)
        Me.GroupBox_FrmCli.Controls.Add(Me.lbldni)
        Me.GroupBox_FrmCli.Controls.Add(Me.lblLocalidad)
        Me.GroupBox_FrmCli.Controls.Add(Me.lblDireccion)
        Me.GroupBox_FrmCli.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox_FrmCli.Name = "GroupBox_FrmCli"
        Me.GroupBox_FrmCli.Size = New System.Drawing.Size(374, 345)
        Me.GroupBox_FrmCli.TabIndex = 13
        Me.GroupBox_FrmCli.TabStop = False
        Me.GroupBox_FrmCli.Text = "Cliente"
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(231, 303)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(127, 27)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "&Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(98, 303)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(127, 27)
        Me.btnAceptar.TabIndex = 8
        Me.btnAceptar.Text = "&Aceptar"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(29, 138)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 1
        Me.lblEmail.Text = "E-mail"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(20, 59)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(73, 135)
        Me.txtEmail.MaxLength = 100
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(285, 20)
        Me.txtEmail.TabIndex = 4
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(73, 56)
        Me.txtNombre.MaxLength = 80
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(285, 20)
        Me.txtNombre.TabIndex = 1
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(73, 19)
        Me.txtApellido.MaxLength = 80
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(285, 20)
        Me.txtApellido.TabIndex = 0
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(242, 95)
        Me.txtTelefono.MaxLength = 50
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(116, 20)
        Me.txtTelefono.TabIndex = 3
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(73, 95)
        Me.txtDni.MaxLength = 8
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(109, 20)
        Me.txtDni.TabIndex = 2
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(73, 254)
        Me.txtDireccion.MaxLength = 255
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(285, 20)
        Me.txtDireccion.TabIndex = 5
        '
        'lblProvincia
        '
        Me.lblProvincia.AutoSize = True
        Me.lblProvincia.Location = New System.Drawing.Point(13, 176)
        Me.lblProvincia.Name = "lblProvincia"
        Me.lblProvincia.Size = New System.Drawing.Size(51, 13)
        Me.lblProvincia.TabIndex = 1
        Me.lblProvincia.Text = "Provincia"
        Me.lblProvincia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(20, 22)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(44, 13)
        Me.lblApellido.TabIndex = 1
        Me.lblApellido.Text = "Apellido"
        Me.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(188, 98)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.lblTelefono.TabIndex = 1
        Me.lblTelefono.Text = "Teléfono"
        Me.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbldni
        '
        Me.lbldni.AutoSize = True
        Me.lbldni.Location = New System.Drawing.Point(38, 98)
        Me.lbldni.Name = "lbldni"
        Me.lbldni.Size = New System.Drawing.Size(26, 13)
        Me.lbldni.TabIndex = 1
        Me.lbldni.Text = "DNI"
        Me.lbldni.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLocalidad
        '
        Me.lblLocalidad.AutoSize = True
        Me.lblLocalidad.Location = New System.Drawing.Point(13, 218)
        Me.lblLocalidad.Name = "lblLocalidad"
        Me.lblLocalidad.Size = New System.Drawing.Size(53, 13)
        Me.lblLocalidad.TabIndex = 1
        Me.lblLocalidad.Text = "Localidad"
        Me.lblLocalidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(13, 257)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(52, 13)
        Me.lblDireccion.TabIndex = 1
        Me.lblDireccion.Text = "Dirección"
        Me.lblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbProvincia
        '
        Me.cmbProvincia.FormattingEnabled = True
        Me.cmbProvincia.Location = New System.Drawing.Point(70, 173)
        Me.cmbProvincia.Name = "cmbProvincia"
        Me.cmbProvincia.Size = New System.Drawing.Size(287, 21)
        Me.cmbProvincia.TabIndex = 10
        '
        'cmbLocalidad
        '
        Me.cmbLocalidad.FormattingEnabled = True
        Me.cmbLocalidad.Location = New System.Drawing.Point(71, 215)
        Me.cmbLocalidad.Name = "cmbLocalidad"
        Me.cmbLocalidad.Size = New System.Drawing.Size(287, 21)
        Me.cmbLocalidad.TabIndex = 10
        '
        'frmAMCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 365)
        Me.Controls.Add(Me.GroupBox_FrmCli)
        Me.Name = "frmAMCliente"
        Me.Text = "Cliente"
        Me.GroupBox_FrmCli.ResumeLayout(False)
        Me.GroupBox_FrmCli.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox_FrmCli As System.Windows.Forms.GroupBox
    Friend WithEvents cmbLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents cmbProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtDni As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents lblProvincia As System.Windows.Forms.Label
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents lbldni As System.Windows.Forms.Label
    Friend WithEvents lblLocalidad As System.Windows.Forms.Label
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
End Class
