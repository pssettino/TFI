<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAMVino
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
        Me.grboxVino = New System.Windows.Forms.GroupBox()
        Me.lblPrecioError = New System.Windows.Forms.Label()
        Me.lblBodegaError = New System.Windows.Forms.Label()
        Me.lblDescripcionError = New System.Windows.Forms.Label()
        Me.cmbBodega = New System.Windows.Forms.ComboBox()
        Me.txtCantidad = New System.Windows.Forms.NumericUpDown()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblBodega = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.HelpProviderHG = New System.Windows.Forms.HelpProvider()
        Me.grboxVino.SuspendLayout()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grboxVino
        '
        Me.grboxVino.Controls.Add(Me.lblPrecioError)
        Me.grboxVino.Controls.Add(Me.lblBodegaError)
        Me.grboxVino.Controls.Add(Me.lblDescripcionError)
        Me.grboxVino.Controls.Add(Me.cmbBodega)
        Me.grboxVino.Controls.Add(Me.txtCantidad)
        Me.grboxVino.Controls.Add(Me.btnCancelar)
        Me.grboxVino.Controls.Add(Me.btnAceptar)
        Me.grboxVino.Controls.Add(Me.lblPrecio)
        Me.grboxVino.Controls.Add(Me.lblCantidad)
        Me.grboxVino.Controls.Add(Me.lblBodega)
        Me.grboxVino.Controls.Add(Me.lblDescripcion)
        Me.grboxVino.Controls.Add(Me.txtPrecio)
        Me.grboxVino.Controls.Add(Me.txtDescripcion)
        Me.grboxVino.Location = New System.Drawing.Point(12, 12)
        Me.grboxVino.Name = "grboxVino"
        Me.grboxVino.Size = New System.Drawing.Size(353, 244)
        Me.grboxVino.TabIndex = 9
        Me.grboxVino.TabStop = False
        Me.grboxVino.Text = "Vino"
        '
        'lblPrecioError
        '
        Me.lblPrecioError.AutoSize = True
        Me.lblPrecioError.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioError.ForeColor = System.Drawing.Color.Red
        Me.lblPrecioError.Location = New System.Drawing.Point(97, 169)
        Me.lblPrecioError.Name = "lblPrecioError"
        Me.lblPrecioError.Size = New System.Drawing.Size(24, 12)
        Me.lblPrecioError.TabIndex = 119
        Me.lblPrecioError.Text = "error"
        Me.lblPrecioError.Visible = False
        '
        'lblBodegaError
        '
        Me.lblBodegaError.AutoSize = True
        Me.lblBodegaError.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBodegaError.ForeColor = System.Drawing.Color.Red
        Me.lblBodegaError.Location = New System.Drawing.Point(97, 90)
        Me.lblBodegaError.Name = "lblBodegaError"
        Me.lblBodegaError.Size = New System.Drawing.Size(24, 12)
        Me.lblBodegaError.TabIndex = 117
        Me.lblBodegaError.Text = "error"
        Me.lblBodegaError.Visible = False
        '
        'lblDescripcionError
        '
        Me.lblDescripcionError.AutoSize = True
        Me.lblDescripcionError.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcionError.ForeColor = System.Drawing.Color.Red
        Me.lblDescripcionError.Location = New System.Drawing.Point(97, 51)
        Me.lblDescripcionError.Name = "lblDescripcionError"
        Me.lblDescripcionError.Size = New System.Drawing.Size(24, 12)
        Me.lblDescripcionError.TabIndex = 116
        Me.lblDescripcionError.Text = "error"
        Me.lblDescripcionError.Visible = False
        '
        'cmbBodega
        '
        Me.cmbBodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBodega.FormattingEnabled = True
        Me.HelpProviderHG.SetHelpKeyword(Me.cmbBodega, "frmAMVino_1.htm#lblBodega")
        Me.HelpProviderHG.SetHelpNavigator(Me.cmbBodega, System.Windows.Forms.HelpNavigator.Topic)
        Me.cmbBodega.Location = New System.Drawing.Point(99, 66)
        Me.cmbBodega.Name = "cmbBodega"
        Me.HelpProviderHG.SetShowHelp(Me.cmbBodega, True)
        Me.cmbBodega.Size = New System.Drawing.Size(226, 21)
        Me.cmbBodega.TabIndex = 115
        '
        'txtCantidad
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.txtCantidad, "frmAMVino_1.htm#txtCantidad")
        Me.HelpProviderHG.SetHelpNavigator(Me.txtCantidad, System.Windows.Forms.HelpNavigator.Topic)
        Me.txtCantidad.Location = New System.Drawing.Point(99, 107)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCantidad.Maximum = New Decimal(New Integer() {32767, 0, 0, 0})
        Me.txtCantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtCantidad.Name = "txtCantidad"
        Me.HelpProviderHG.SetShowHelp(Me.txtCantidad, True)
        Me.txtCantidad.Size = New System.Drawing.Size(94, 20)
        Me.txtCantidad.TabIndex = 114
        Me.txtCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.HelpProviderHG.SetHelpKeyword(Me.btnCancelar, "frmAMVino_1.htm#btnCancelar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnCancelar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnCancelar.Location = New System.Drawing.Point(198, 203)
        Me.btnCancelar.Name = "btnCancelar"
        Me.HelpProviderHG.SetShowHelp(Me.btnCancelar, True)
        Me.btnCancelar.Size = New System.Drawing.Size(127, 27)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "&Cancelar"
        '
        'btnAceptar
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.btnAceptar, "frmAMVino_1.htm#btnAceptar")
        Me.HelpProviderHG.SetHelpNavigator(Me.btnAceptar, System.Windows.Forms.HelpNavigator.Topic)
        Me.btnAceptar.Location = New System.Drawing.Point(65, 203)
        Me.btnAceptar.Name = "btnAceptar"
        Me.HelpProviderHG.SetShowHelp(Me.btnAceptar, True)
        Me.btnAceptar.Size = New System.Drawing.Size(127, 27)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "&Aceptar"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(32, 146)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(37, 13)
        Me.lblPrecio.TabIndex = 2
        Me.lblPrecio.Text = "Precio"
        Me.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(20, 107)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(49, 13)
        Me.lblCantidad.TabIndex = 2
        Me.lblCantidad.Text = "Cantidad"
        Me.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBodega
        '
        Me.lblBodega.AutoSize = True
        Me.lblBodega.Location = New System.Drawing.Point(25, 69)
        Me.lblBodega.Name = "lblBodega"
        Me.lblBodega.Size = New System.Drawing.Size(44, 13)
        Me.lblBodega.TabIndex = 2
        Me.lblBodega.Text = "Bodega"
        Me.lblBodega.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(6, 31)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.lblDescripcion.TabIndex = 2
        Me.lblDescripcion.Text = "Descripción"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPrecio
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.txtPrecio, "frmAMVino_1.htm#lblPrecio")
        Me.HelpProviderHG.SetHelpNavigator(Me.txtPrecio, System.Windows.Forms.HelpNavigator.Topic)
        Me.txtPrecio.Location = New System.Drawing.Point(99, 146)
        Me.txtPrecio.Name = "txtPrecio"
        Me.HelpProviderHG.SetShowHelp(Me.txtPrecio, True)
        Me.txtPrecio.Size = New System.Drawing.Size(93, 20)
        Me.txtPrecio.TabIndex = 3
        Me.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDescripcion
        '
        Me.HelpProviderHG.SetHelpKeyword(Me.txtDescripcion, "frmAMVino_1.htm#lblDescripcion")
        Me.HelpProviderHG.SetHelpNavigator(Me.txtDescripcion, System.Windows.Forms.HelpNavigator.Topic)
        Me.txtDescripcion.Location = New System.Drawing.Point(99, 28)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.HelpProviderHG.SetShowHelp(Me.txtDescripcion, True)
        Me.txtDescripcion.Size = New System.Drawing.Size(226, 20)
        Me.txtDescripcion.TabIndex = 0
        '
        'HelpProviderHG
        '
        Me.HelpProviderHG.HelpNamespace = "LaYumbaVinos.chm"
        '
        'frmAMVino
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(374, 266)
        Me.Controls.Add(Me.grboxVino)
        Me.HelpProviderHG.SetHelpKeyword(Me, "frmAMVino_1.htm")
        Me.HelpProviderHG.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.Topic)
        Me.MaximizeBox = False
        Me.Name = "frmAMVino"
        Me.HelpProviderHG.SetShowHelp(Me, True)
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Vino"
        Me.grboxVino.ResumeLayout(False)
        Me.grboxVino.PerformLayout()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grboxVino As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents lblPrecio As System.Windows.Forms.Label
    Friend WithEvents lblBodega As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents cmbBodega As System.Windows.Forms.ComboBox
    Friend WithEvents txtCantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents lblPrecioError As System.Windows.Forms.Label
    Friend WithEvents lblBodegaError As System.Windows.Forms.Label
    Friend WithEvents lblDescripcionError As System.Windows.Forms.Label
    Friend WithEvents HelpProviderHG As System.Windows.Forms.HelpProvider
End Class
