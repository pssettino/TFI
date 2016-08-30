<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIntegridadDB
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnRecalcularDV = New System.Windows.Forms.Button()
        Me.Problema = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tabla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Columna = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Registro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRecalcularDV)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(617, 444)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Problemas de integridad"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Problema, Me.Tabla, Me.Columna, Me.Registro})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 52)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(605, 375)
        Me.DataGridView1.TabIndex = 0
        '
        'btnRecalcularDV
        '
        Me.btnRecalcularDV.Location = New System.Drawing.Point(6, 19)
        Me.btnRecalcularDV.Name = "btnRecalcularDV"
        Me.btnRecalcularDV.Size = New System.Drawing.Size(139, 27)
        Me.btnRecalcularDV.TabIndex = 1
        Me.btnRecalcularDV.Text = "Recalcular DV"
        Me.btnRecalcularDV.UseVisualStyleBackColor = True
        '
        'Problema
        '
        Me.Problema.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Problema.HeaderText = "Descripción del Problema"
        Me.Problema.Name = "Problema"
        Me.Problema.ReadOnly = True
        '
        'Tabla
        '
        Me.Tabla.HeaderText = "Tabla"
        Me.Tabla.Name = "Tabla"
        Me.Tabla.ReadOnly = True
        '
        'Columna
        '
        Me.Columna.HeaderText = "Columna"
        Me.Columna.Name = "Columna"
        Me.Columna.ReadOnly = True
        '
        'Registro
        '
        Me.Registro.HeaderText = "Registro"
        Me.Registro.Name = "Registro"
        Me.Registro.ReadOnly = True
        '
        'frmIntegridadDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 468)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmIntegridadDB"
        Me.Text = "Integridad de la base de datos"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnRecalcularDV As System.Windows.Forms.Button
    Friend WithEvents Problema As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tabla As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Columna As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Registro As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
