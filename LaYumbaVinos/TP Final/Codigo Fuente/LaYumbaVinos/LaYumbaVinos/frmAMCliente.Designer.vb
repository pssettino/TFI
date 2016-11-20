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
        Me.lblDireccionError = New System.Windows.Forms.Label()
        Me.lblLocalidadError = New System.Windows.Forms.Label()
        Me.lblProvinciaError = New System.Windows.Forms.Label()
        Me.lblEmailError = New System.Windows.Forms.Label()
        Me.lblTelefonoError = New System.Windows.Forms.Label()
        Me.lblDniError = New System.Windows.Forms.Label()
        Me.lblNombreError = New System.Windows.Forms.Label()
        Me.lblapellidoError = New System.Windows.Forms.Label()
        Me.cmbLocalidad = New System.Windows.Forms.ComboBox()
        Me.cmbProvincia = New System.Windows.Forms.ComboBox()
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
        Me.HelpProviderHG = New System.Windows.Forms.HelpProvider()
        Me.GroupBox_FrmCli.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox_FrmCli
        '
        Me.GroupBox_FrmCli.Controls.Add(Me.lblDireccionError)
        Me.GroupBox_FrmCli.Controls.Add(Me.lblLocalidadError)
        Me.GroupBox_FrmCli.Controls.Add(Me.lblProvinciaError)
        Me.GroupBox_FrmCli.Controls.Add(Me.lblEmailError)
        Me.GroupBox_FrmCli.Controls.Add(Me.lblTelefonoError)
        Me.GroupBox_FrmCli.Controls.Add(Me.lblDniError)
        Me.GroupBox_FrmCli.Controls.Add(Me.lblNombreError)
        Me.GroupBox_FrmCli.Controls.Add(Me.lblapellidoError)
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
        'lblDireccionError
        '
        Me.lblDireccionError.AutoSize = True
        Me.lblDireccionError.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionError.ForeColor = System.Drawing.Color.Red
        Me.lblDireccionError.Location = New System.Drawing.Point(87, 277)
        Me.lblDireccionError.Name = "lblDireccionError"
        Me.lblDireccionError.Size = New System.Drawing.Size(24, 12)
        Me.lblDireccionError.TabIndex = 122
        Me.lblDireccionError.Text = "error"
        Me.lblDireccionError.Visible = False
        '
        'lblLocalidadError
        '
        Me.lblLocalidadError.AutoSize = True
        Me.lblLocalidadError.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocalidadError.ForeColor = System.Drawing.Color.Red
        Me.lblLocalidadError.Location = New System.Drawing.Point(87, 239)
        Me.lblLocalidadError.Name = "lblLocalidadError"
        Me.lblLocalidadError.Size = New System.Drawing.Size(24, 12)
        Me.lblLocalidadError.TabIndex = 121
        Me.lblLocalidadError.Text = "error"
        Me.lblLocalidadError.Visible = False
        '
        'lblProvinciaError
        '
        Me.lblProvinciaError.AutoSize = True
        Me.lblProvinciaError.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProvinciaError.ForeColor = System.Drawing.Color.Red
        Me.lblProvinciaError.Location = New System.Drawing.Point(87, 197)
        Me.lblProvinciaError.Name = "lblProvinciaError"
        Me.lblProvinciaError.Size = New System.Drawing.Size(24, 12)
        Me.lblProvinciaError.TabIndex = 120
        Me.lblProvinciaError.Text = "error"
        Me.lblProvinciaError.Visible = False
        '
        'lblEmailError
        '
        Me.lblEmailError.AutoSize = True
        Me.lblEmailError.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailError.ForeColor = System.Drawing.Color.Red
        Me.lblEmailError.Location = New System.Drawing.Point(87, 154)
        Me.lblEmailError.Name = "lblEmailError"
        Me.lblEmailError.Size = New System.Drawing.Size(24, 12)
        Me.lblEmailError.TabIndex = 119
        Me.lblEmailError.Text = "error"
        Me.lblEmailError.Visible = False
        '
        'lblTelefonoError
        '
        Me.lblTelefonoError.AutoSize = True
        Me.lblTelefonoError.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoError.ForeColor = System.Drawing.Color.Red
        Me.lblTelefonoError.Location = New System.Drawing.Point(240, 116)
        Me.lblTelefonoError.Name = "lblTelefonoError"
        Me.lblTelefonoError.Size = New System.Drawing.Size(24, 12)
        Me.lblTelefonoError.TabIndex = 118
        Me.lblTelefonoError.Text = "error"
        Me.lblTelefonoError.Visible = False
        '
        'lblDniError
        '
        Me.lblDniError.AutoSize = True
        Me.lblDniError.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDniError.ForeColor = System.Drawing.Color.Red
        Me.lblDniError.Location = New System.Drawing.Point(87, 116)
        Me.lblDniError.Name = "lblDniError"
        Me.lblDniError.Size = New System.Drawing.Size(24, 12)
        Me.lblDniError.TabIndex = 117
        Me.lblDniError.Text = "error"
        Me.lblDniError.Visible = False
        '
        'lblNombreError
        '
        Me.lblNombreError.AutoSize = True
        Me.lblNombreError.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreError.ForeColor = System.Drawing.Color.Red
        Me.lblNombreError.Location = New System.Drawing.Point(87, 80)
        Me.lblNombreError.Name = "lblNombreError"
        Me.lblNombreError.Size = New System.Drawing.Size(24, 12)
        Me.lblNombreError.TabIndex = 116
        Me.lblNombreError.Text = "error"
        Me.lblNombreError.Visible = False
        '
        'lblapellidoError
        '
        Me.lblapellidoError.AutoSize = True
        Me.lblapellidoError.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblapellidoError.ForeColor = System.Drawing.Color.Red
        Me.lblapellidoError.Location = New System.Drawing.Point(87, 42)
        Me.lblapellidoError.Name = "lblapellidoError"
        Me.lblapellidoError.Size = New System.Drawing.Size(24, 12)
        Me.lblapellidoError.TabIndex = 115
        Me.lblapellidoError.Text = "error"
        Me.lblapellidoError.Visible = False
        '
        'cmbLocalidad
        '
        Me.cmbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLocalidad.FormattingEnabled = True
        Me.HelpProviderHG.SetHelpKeyword(Me.cmbLocalidad, "frmAMCliente_1.htm#lblLocalidad")
        Me.HelpProviderHG.SetHelpNavigator(Me.cmbLocalidad, System.Windows.Forms.HelpNavigator.Topic)
        Me.cmbLocalidad.Location = New System.Drawing.Point(89, 215)
        Me.cmbLocalidad.Name = "cmbLocalidad"
        Me.HelpProviderHG.SetShowHelp(Me.cmbLocalidad, True)
        Me.cmbLocalidad.Size = New System.Drawing.Size(269, 21)
        Me.cmbLocalidad.TabIndex = 10
        '
        'cmbProvincia
        '
        Me.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProvincia.FormattingEnabled = True
        Me.HelpProviderHG.SetHelpKeyword(Me.cmbProvincia, "frmAMCliente_1.htm#lblProvincia")
        Me.HelpProviderHG.SetHelpNavigator(Me.cmbProvincia, System.Windows.Forms.HelpNavigator.Topic)
        Me.cmbProvincia.Location = New System.Drawing.Point(89, 173)
        Me.cmbProvincia.Name = "cmbProvincia"
        Me.HelpProviderHG.SetShowHelp(Me.cmbProvincia, True)
        Me.cmbProvincia.Size = New System.Drawing.Size(268, 21)
        Me.cmbProvincia.TabIndex = 10
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.HelpProviderHG.SetHelpKeyword(Me.btnCancelar, "frmAMCliente_1.htm#btnCancelar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnCancelar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnCancelar.Location = New System.Drawing.Point(231, 303)
        Me.btnCancelar.Name = "btnCancelar"
        Me.HelpProviderHG.SetShowHelp(Me.btnCancelar, True)
        Me.btnCancelar.Size = New System.Drawing.Size(127, 27)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "&Cancelar"
        '
        'btnAceptar
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnAceptar, "frmAMCliente_1.htm#btnAceptar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnAceptar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnAceptar.Location = New System.Drawing.Point(98, 303)
        Me.btnAceptar.Name = "btnAceptar"
        Me.HelpProviderHG.SetShowHelp(Me.btnAceptar, True)
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
        Me.HelpProviderHG.SetHelpKeyword(Me.txtEmail, "frmAMCliente_1.htm#lblEmail")
        Me.HelpProviderHG.SetHelpNavigator(Me.txtEmail, System.Windows.Forms.HelpNavigator.Topic)
        Me.txtEmail.Location = New System.Drawing.Point(89, 131)
        Me.txtEmail.MaxLength = 100
        Me.txtEmail.Name = "txtEmail"
        Me.HelpProviderHG.SetShowHelp(Me.txtEmail, True)
        Me.txtEmail.Size = New System.Drawing.Size(266, 20)
        Me.txtEmail.TabIndex = 4
        '
        'txtNombre
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.txtNombre, "frmAMCliente_1.htm#lblNombre")
        Me.HelpProviderHG.SetHelpNavigator(Me.txtNombre, System.Windows.Forms.HelpNavigator.Topic)
        Me.txtNombre.Location = New System.Drawing.Point(89, 56)
        Me.txtNombre.MaxLength = 80
        Me.txtNombre.Name = "txtNombre"
        Me.HelpProviderHG.SetShowHelp(Me.txtNombre, True)
        Me.txtNombre.Size = New System.Drawing.Size(269, 20)
        Me.txtNombre.TabIndex = 1
        '
        'txtApellido
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.txtApellido, "frmAMCliente_1.htm#lblApellido")
        Me.HelpProviderHG.SetHelpNavigator(Me.txtApellido, System.Windows.Forms.HelpNavigator.Topic)
        Me.txtApellido.Location = New System.Drawing.Point(89, 19)
        Me.txtApellido.MaxLength = 80
        Me.txtApellido.Name = "txtApellido"
        Me.HelpProviderHG.SetShowHelp(Me.txtApellido, True)
        Me.txtApellido.Size = New System.Drawing.Size(269, 20)
        Me.txtApellido.TabIndex = 0
        '
        'txtTelefono
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.txtTelefono, "frmAMCliente_1.htm#lblTelefono")
        Me.HelpProviderHG.SetHelpNavigator(Me.txtTelefono, System.Windows.Forms.HelpNavigator.Topic)
        Me.txtTelefono.Location = New System.Drawing.Point(242, 95)
        Me.txtTelefono.MaxLength = 50
        Me.txtTelefono.Name = "txtTelefono"
        Me.HelpProviderHG.SetShowHelp(Me.txtTelefono, True)
        Me.txtTelefono.Size = New System.Drawing.Size(116, 20)
        Me.txtTelefono.TabIndex = 3
        '
        'txtDni
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.txtDni, "frmAMCliente_1.htm#lbldni")
        Me.HelpProviderHG.SetHelpNavigator(Me.txtDni, System.Windows.Forms.HelpNavigator.Topic)
        Me.txtDni.Location = New System.Drawing.Point(89, 95)
        Me.txtDni.MaxLength = 8
        Me.txtDni.Name = "txtDni"
        Me.HelpProviderHG.SetShowHelp(Me.txtDni, True)
        Me.txtDni.Size = New System.Drawing.Size(93, 20)
        Me.txtDni.TabIndex = 2
        '
        'txtDireccion
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.txtDireccion, "frmAMCliente_1.htm#lblDireccion")
        Me.HelpProviderHG.SetHelpNavigator(Me.txtDireccion, System.Windows.Forms.HelpNavigator.Topic)
        Me.txtDireccion.Location = New System.Drawing.Point(89, 254)
        Me.txtDireccion.MaxLength = 255
        Me.txtDireccion.Name = "txtDireccion"
        Me.HelpProviderHG.SetShowHelp(Me.txtDireccion, True)
        Me.txtDireccion.Size = New System.Drawing.Size(269, 20)
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
        'HelpProviderHG
        '
        Me.HelpProviderHG.HelpNamespace = "LaYumbaVinos.chm"
        '
        'frmAMCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(393, 365)
        Me.Controls.Add(Me.GroupBox_FrmCli)
        Me.HelpProviderHG.SetHelpKeyword(Me, "frmAMCliente_1.htm")
        Me.HelpProviderHG.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.Topic)
        Me.Name = "frmAMCliente"
        Me.HelpProviderHG.SetShowHelp(Me, True)
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
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
    Friend WithEvents lblDireccionError As System.Windows.Forms.Label
    Friend WithEvents lblLocalidadError As System.Windows.Forms.Label
    Friend WithEvents lblProvinciaError As System.Windows.Forms.Label
    Friend WithEvents lblEmailError As System.Windows.Forms.Label
    Friend WithEvents lblTelefonoError As System.Windows.Forms.Label
    Friend WithEvents lblDniError As System.Windows.Forms.Label
    Friend WithEvents lblNombreError As System.Windows.Forms.Label
    Friend WithEvents lblapellidoError As System.Windows.Forms.Label
    Friend WithEvents HelpProviderHG As System.Windows.Forms.HelpProvider
End Class
