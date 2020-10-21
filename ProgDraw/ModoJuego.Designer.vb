<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModoJuego
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PB3 = New System.Windows.Forms.PictureBox()
        Me.PB2 = New System.Windows.Forms.PictureBox()
        Me.PB1 = New System.Windows.Forms.PictureBox()
        CType(Me.PB3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(296, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 57)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "PROGDRAW"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Agency FB", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(96, 236)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(621, 67)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "UN SOLO JUGADOR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Agency FB", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(94, 309)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(621, 67)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "MULTIJUGADOR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Agency FB", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.DarkRed
        Me.Button3.Location = New System.Drawing.Point(94, 409)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(621, 67)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "SALIR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PB3
        '
        Me.PB3.Image = Global.ProgDraw.My.Resources.Resources._1471777855_right
        Me.PB3.Location = New System.Drawing.Point(545, 66)
        Me.PB3.Margin = New System.Windows.Forms.Padding(4)
        Me.PB3.Name = "PB3"
        Me.PB3.Size = New System.Drawing.Size(172, 145)
        Me.PB3.TabIndex = 7
        Me.PB3.TabStop = False
        '
        'PB2
        '
        Me.PB2.Image = Global.ProgDraw.My.Resources.Resources._1471777691_edit
        Me.PB2.Location = New System.Drawing.Point(318, 66)
        Me.PB2.Margin = New System.Windows.Forms.Padding(4)
        Me.PB2.Name = "PB2"
        Me.PB2.Size = New System.Drawing.Size(172, 145)
        Me.PB2.TabIndex = 6
        Me.PB2.TabStop = False
        '
        'PB1
        '
        Me.PB1.Image = Global.ProgDraw.My.Resources.Resources._1471777852_left
        Me.PB1.Location = New System.Drawing.Point(94, 66)
        Me.PB1.Margin = New System.Windows.Forms.Padding(4)
        Me.PB1.Name = "PB1"
        Me.PB1.Size = New System.Drawing.Size(172, 145)
        Me.PB1.TabIndex = 5
        Me.PB1.TabStop = False
        '
        'ModoJuego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 488)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PB3)
        Me.Controls.Add(Me.PB2)
        Me.Controls.Add(Me.PB1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ModoJuego"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModoJuego"
        CType(Me.PB3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PB3 As PictureBox
    Friend WithEvents PB2 As PictureBox
    Friend WithEvents PB1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
