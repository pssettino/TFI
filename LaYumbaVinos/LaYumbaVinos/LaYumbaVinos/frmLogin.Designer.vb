<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblidioma = New System.Windows.Forms.Label()
        Me.lblcontraseña = New System.Windows.Forms.Label()
        Me.lblusuario = New System.Windows.Forms.Label()
        Me.cmbIdioma = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(31, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 130)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(338, 164)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(127, 27)
        Me.btnCancelar.TabIndex = 12
        Me.btnCancelar.Text = "&Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(201, 164)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(127, 27)
        Me.btnAceptar.TabIndex = 11
        Me.btnAceptar.Text = "&Aceptar"
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(245, 76)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(220, 20)
        Me.txtContraseña.TabIndex = 7
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(245, 33)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(220, 20)
        Me.txtUsuario.TabIndex = 5
        '
        'lblidioma
        '
        Me.lblidioma.Location = New System.Drawing.Point(198, 115)
        Me.lblidioma.Name = "lblidioma"
        Me.lblidioma.Size = New System.Drawing.Size(42, 23)
        Me.lblidioma.TabIndex = 9
        Me.lblidioma.Text = "Idioma"
        Me.lblidioma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblcontraseña
        '
        Me.lblcontraseña.Location = New System.Drawing.Point(178, 73)
        Me.lblcontraseña.Name = "lblcontraseña"
        Me.lblcontraseña.Size = New System.Drawing.Size(61, 23)
        Me.lblcontraseña.TabIndex = 10
        Me.lblcontraseña.Text = "Contraseña"
        Me.lblcontraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblusuario
        '
        Me.lblusuario.Location = New System.Drawing.Point(195, 31)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(44, 23)
        Me.lblusuario.TabIndex = 6
        Me.lblusuario.Text = "Usuario"
        Me.lblusuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbIdioma
        '
        Me.cmbIdioma.FormattingEnabled = True
        Me.cmbIdioma.Location = New System.Drawing.Point(245, 116)
        Me.cmbIdioma.Name = "cmbIdioma"
        Me.cmbIdioma.Size = New System.Drawing.Size(220, 21)
        Me.cmbIdioma.TabIndex = 13
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(496, 222)
        Me.Controls.Add(Me.cmbIdioma)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lblidioma)
        Me.Controls.Add(Me.lblcontraseña)
        Me.Controls.Add(Me.lblusuario)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lblidioma As System.Windows.Forms.Label
    Friend WithEvents lblcontraseña As System.Windows.Forms.Label
    Friend WithEvents lblusuario As System.Windows.Forms.Label
    Friend WithEvents cmbIdioma As System.Windows.Forms.ComboBox
End Class
