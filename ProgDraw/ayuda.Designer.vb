<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ayuda
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnatras = New System.Windows.Forms.PictureBox()
        Me.lblayuda = New System.Windows.Forms.Label()
        CType(Me.btnatras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(190, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ayuda"
        '
        'btnatras
        '
        Me.btnatras.Image = Global.ProgDraw.My.Resources.Resources._1474318114_undo
        Me.btnatras.Location = New System.Drawing.Point(356, 443)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(70, 70)
        Me.btnatras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnatras.TabIndex = 5
        Me.btnatras.TabStop = False
        '
        'lblayuda
        '
        Me.lblayuda.AutoSize = True
        Me.lblayuda.Location = New System.Drawing.Point(13, 47)
        Me.lblayuda.Name = "lblayuda"
        Me.lblayuda.Size = New System.Drawing.Size(10, 13)
        Me.lblayuda.TabIndex = 6
        Me.lblayuda.Text = "."
        '
        'ayuda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 516)
        Me.Controls.Add(Me.lblayuda)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ayuda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ayuda"
        CType(Me.btnatras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnatras As System.Windows.Forms.PictureBox
    Friend WithEvents lblayuda As System.Windows.Forms.Label
End Class
