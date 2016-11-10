<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCambiarContrasena
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
        Me.lblConfirmarContresañaE = New System.Windows.Forms.Label()
        Me.lblContraseñaNuevaE = New System.Windows.Forms.Label()
        Me.lblContraseñaAnteriorE = New System.Windows.Forms.Label()
        Me.txtContraseñaAnterior = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtContraseñaNueva = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtContraseñaConfirmar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblContraseñaAnterior = New System.Windows.Forms.Label()
        Me.lblConfirmarContraseña = New System.Windows.Forms.Label()
        Me.lblNuevaContraseña = New System.Windows.Forms.Label()
        Me.GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.lblConfirmarContresañaE)
        Me.GroupBox.Controls.Add(Me.lblContraseñaNuevaE)
        Me.GroupBox.Controls.Add(Me.lblContraseñaAnteriorE)
        Me.GroupBox.Controls.Add(Me.txtContraseñaAnterior)
        Me.GroupBox.Controls.Add(Me.btnCancelar)
        Me.GroupBox.Controls.Add(Me.txtContraseñaNueva)
        Me.GroupBox.Controls.Add(Me.btnAceptar)
        Me.GroupBox.Controls.Add(Me.txtContraseñaConfirmar)
        Me.GroupBox.Controls.Add(Me.Label3)
        Me.GroupBox.Controls.Add(Me.lblContraseñaAnterior)
        Me.GroupBox.Controls.Add(Me.lblConfirmarContraseña)
        Me.GroupBox.Controls.Add(Me.lblNuevaContraseña)
        Me.GroupBox.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(433, 193)
        Me.GroupBox.TabIndex = 1
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "Contraseña"
        '
        'lblConfirmarContresañaE
        '
        Me.lblConfirmarContresañaE.AutoSize = True
        Me.lblConfirmarContresañaE.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.lblConfirmarContresañaE.ForeColor = System.Drawing.Color.Red
        Me.lblConfirmarContresañaE.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblConfirmarContresañaE.Location = New System.Drawing.Point(157, 120)
        Me.lblConfirmarContresañaE.Name = "lblConfirmarContresañaE"
        Me.lblConfirmarContresañaE.Size = New System.Drawing.Size(24, 12)
        Me.lblConfirmarContresañaE.TabIndex = 122
        Me.lblConfirmarContresañaE.Text = "error"
        Me.lblConfirmarContresañaE.Visible = False
        '
        'lblContraseñaNuevaE
        '
        Me.lblContraseñaNuevaE.AutoSize = True
        Me.lblContraseñaNuevaE.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.lblContraseñaNuevaE.ForeColor = System.Drawing.Color.Red
        Me.lblContraseñaNuevaE.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblContraseñaNuevaE.Location = New System.Drawing.Point(157, 82)
        Me.lblContraseñaNuevaE.Name = "lblContraseñaNuevaE"
        Me.lblContraseñaNuevaE.Size = New System.Drawing.Size(24, 12)
        Me.lblContraseñaNuevaE.TabIndex = 121
        Me.lblContraseñaNuevaE.Text = "error"
        Me.lblContraseñaNuevaE.Visible = False
        '
        'lblContraseñaAnteriorE
        '
        Me.lblContraseñaAnteriorE.AutoSize = True
        Me.lblContraseñaAnteriorE.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.lblContraseñaAnteriorE.ForeColor = System.Drawing.Color.Red
        Me.lblContraseñaAnteriorE.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblContraseñaAnteriorE.Location = New System.Drawing.Point(157, 45)
        Me.lblContraseñaAnteriorE.Name = "lblContraseñaAnteriorE"
        Me.lblContraseñaAnteriorE.Size = New System.Drawing.Size(24, 12)
        Me.lblContraseñaAnteriorE.TabIndex = 120
        Me.lblContraseñaAnteriorE.Text = "error"
        Me.lblContraseñaAnteriorE.Visible = False
        '
        'txtContraseñaAnterior
        '
        Me.txtContraseñaAnterior.Location = New System.Drawing.Point(159, 23)
        Me.txtContraseñaAnterior.Name = "txtContraseñaAnterior"
        Me.txtContraseñaAnterior.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseñaAnterior.Size = New System.Drawing.Size(260, 20)
        Me.txtContraseñaAnterior.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCancelar.Location = New System.Drawing.Point(292, 149)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(127, 27)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "&Cancelar"
        '
        'txtContraseñaNueva
        '
        Me.txtContraseñaNueva.Location = New System.Drawing.Point(159, 60)
        Me.txtContraseñaNueva.Name = "txtContraseñaNueva"
        Me.txtContraseñaNueva.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseñaNueva.Size = New System.Drawing.Size(260, 20)
        Me.txtContraseñaNueva.TabIndex = 1
        '
        'btnAceptar
        '
        Me.btnAceptar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAceptar.Location = New System.Drawing.Point(159, 149)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(127, 27)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "&Aceptar"
        '
        'txtContraseñaConfirmar
        '
        Me.txtContraseñaConfirmar.Location = New System.Drawing.Point(159, 97)
        Me.txtContraseñaConfirmar.Name = "txtContraseñaConfirmar"
        Me.txtContraseñaConfirmar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseñaConfirmar.Size = New System.Drawing.Size(260, 20)
        Me.txtContraseñaConfirmar.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(87, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 5
        '
        'lblContraseñaAnterior
        '
        Me.lblContraseñaAnterior.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblContraseñaAnterior.Location = New System.Drawing.Point(7, 17)
        Me.lblContraseñaAnterior.Name = "lblContraseñaAnterior"
        Me.lblContraseñaAnterior.Size = New System.Drawing.Size(147, 31)
        Me.lblContraseñaAnterior.TabIndex = 6
        Me.lblContraseñaAnterior.Text = "Contraseña Anterior"
        Me.lblContraseñaAnterior.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblConfirmarContraseña
        '
        Me.lblConfirmarContraseña.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblConfirmarContraseña.Location = New System.Drawing.Point(6, 90)
        Me.lblConfirmarContraseña.Name = "lblConfirmarContraseña"
        Me.lblConfirmarContraseña.Size = New System.Drawing.Size(148, 32)
        Me.lblConfirmarContraseña.TabIndex = 5
        Me.lblConfirmarContraseña.Text = "Confirmar Contraseña"
        Me.lblConfirmarContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNuevaContraseña
        '
        Me.lblNuevaContraseña.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNuevaContraseña.Location = New System.Drawing.Point(9, 57)
        Me.lblNuevaContraseña.Name = "lblNuevaContraseña"
        Me.lblNuevaContraseña.Size = New System.Drawing.Size(145, 26)
        Me.lblNuevaContraseña.TabIndex = 5
        Me.lblNuevaContraseña.Text = "Nueva Contraseña"
        Me.lblNuevaContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmCambiarContrasena
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(454, 212)
        Me.Controls.Add(Me.GroupBox)
        Me.MaximizeBox = False
        Me.Name = "frmCambiarContrasena"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cambiar Contraseña"
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents lblConfirmarContresañaE As System.Windows.Forms.Label
    Friend WithEvents lblContraseñaNuevaE As System.Windows.Forms.Label
    Friend WithEvents lblContraseñaAnteriorE As System.Windows.Forms.Label
    Friend WithEvents txtContraseñaAnterior As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtContraseñaNueva As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents txtContraseñaConfirmar As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblContraseñaAnterior As System.Windows.Forms.Label
    Friend WithEvents lblConfirmarContraseña As System.Windows.Forms.Label
    Friend WithEvents lblNuevaContraseña As System.Windows.Forms.Label
End Class
