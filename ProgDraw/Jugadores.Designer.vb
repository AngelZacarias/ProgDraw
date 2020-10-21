<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jugadores
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
        Me.Jugador1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PB3 = New System.Windows.Forms.PictureBox()
        Me.PB2 = New System.Windows.Forms.PictureBox()
        Me.PB1 = New System.Windows.Forms.PictureBox()
        Me.Jugador2 = New System.Windows.Forms.Button()
        Me.Jugador3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.PB3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Jugador1
        '
        Me.Jugador1.Font = New System.Drawing.Font("Agency FB", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Jugador1.Location = New System.Drawing.Point(86, 237)
        Me.Jugador1.Name = "Jugador1"
        Me.Jugador1.Size = New System.Drawing.Size(621, 67)
        Me.Jugador1.TabIndex = 14
        Me.Jugador1.Text = "JUGADOR 1"
        Me.Jugador1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(286, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 57)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "PROGDRAW"
        '
        'PB3
        '
        Me.PB3.Image = Global.ProgDraw.My.Resources.Resources._1471777855_right
        Me.PB3.Location = New System.Drawing.Point(535, 67)
        Me.PB3.Margin = New System.Windows.Forms.Padding(4)
        Me.PB3.Name = "PB3"
        Me.PB3.Size = New System.Drawing.Size(172, 145)
        Me.PB3.TabIndex = 12
        Me.PB3.TabStop = False
        '
        'PB2
        '
        Me.PB2.Image = Global.ProgDraw.My.Resources.Resources._1471777691_edit
        Me.PB2.Location = New System.Drawing.Point(308, 67)
        Me.PB2.Margin = New System.Windows.Forms.Padding(4)
        Me.PB2.Name = "PB2"
        Me.PB2.Size = New System.Drawing.Size(172, 145)
        Me.PB2.TabIndex = 11
        Me.PB2.TabStop = False
        '
        'PB1
        '
        Me.PB1.Image = Global.ProgDraw.My.Resources.Resources._1471777852_left
        Me.PB1.Location = New System.Drawing.Point(84, 67)
        Me.PB1.Margin = New System.Windows.Forms.Padding(4)
        Me.PB1.Name = "PB1"
        Me.PB1.Size = New System.Drawing.Size(172, 145)
        Me.PB1.TabIndex = 10
        Me.PB1.TabStop = False
        '
        'Jugador2
        '
        Me.Jugador2.Font = New System.Drawing.Font("Agency FB", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Jugador2.Location = New System.Drawing.Point(84, 309)
        Me.Jugador2.Name = "Jugador2"
        Me.Jugador2.Size = New System.Drawing.Size(621, 67)
        Me.Jugador2.TabIndex = 15
        Me.Jugador2.Text = "JUGADOR 2"
        Me.Jugador2.UseVisualStyleBackColor = True
        '
        'Jugador3
        '
        Me.Jugador3.Font = New System.Drawing.Font("Agency FB", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Jugador3.Location = New System.Drawing.Point(84, 382)
        Me.Jugador3.Name = "Jugador3"
        Me.Jugador3.Size = New System.Drawing.Size(621, 67)
        Me.Jugador3.TabIndex = 16
        Me.Jugador3.Text = "JUGADOR 3"
        Me.Jugador3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Agency FB", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.DarkRed
        Me.Button4.Location = New System.Drawing.Point(86, 529)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(621, 67)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "SALIR"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'Jugadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 617)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Jugador3)
        Me.Controls.Add(Me.Jugador2)
        Me.Controls.Add(Me.Jugador1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PB3)
        Me.Controls.Add(Me.PB2)
        Me.Controls.Add(Me.PB1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Jugadores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jugadores"
        CType(Me.PB3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Jugador1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PB3 As PictureBox
    Friend WithEvents PB2 As PictureBox
    Friend WithEvents PB1 As PictureBox
    Friend WithEvents Jugador2 As Button
    Friend WithEvents Jugador3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
