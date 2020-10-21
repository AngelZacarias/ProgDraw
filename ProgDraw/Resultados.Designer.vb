<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Resultados
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
        Me.PB3 = New System.Windows.Forms.PictureBox()
        Me.PB1 = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Puntuacion1 = New System.Windows.Forms.Label()
        Me.Puntuacion2 = New System.Windows.Forms.Label()
        Me.Puntuacion3 = New System.Windows.Forms.Label()
        CType(Me.PB3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(361, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 57)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "PROGDRAW"
        '
        'PB3
        '
        Me.PB3.Image = Global.ProgDraw.My.Resources.Resources._1471777855_right
        Me.PB3.Location = New System.Drawing.Point(828, 90)
        Me.PB3.Margin = New System.Windows.Forms.Padding(4)
        Me.PB3.Name = "PB3"
        Me.PB3.Size = New System.Drawing.Size(112, 145)
        Me.PB3.TabIndex = 15
        Me.PB3.TabStop = False
        '
        'PB1
        '
        Me.PB1.Image = Global.ProgDraw.My.Resources.Resources._1471777852_left
        Me.PB1.Location = New System.Drawing.Point(13, 90)
        Me.PB1.Margin = New System.Windows.Forms.Padding(4)
        Me.PB1.Name = "PB1"
        Me.PB1.Size = New System.Drawing.Size(112, 145)
        Me.PB1.TabIndex = 14
        Me.PB1.TabStop = False
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Agency FB", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.DarkRed
        Me.Button4.Location = New System.Drawing.Point(161, 263)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(621, 67)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "SALIR"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(187, 90)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(541, 41)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "JUGADOR 1........................................................."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(187, 131)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(542, 41)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "JUGADOR 2........................................................"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(190, 172)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(542, 41)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "JUGADOR 3........................................................"
        '
        'Puntuacion1
        '
        Me.Puntuacion1.AutoSize = True
        Me.Puntuacion1.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Puntuacion1.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Puntuacion1.Location = New System.Drawing.Point(723, 90)
        Me.Puntuacion1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Puntuacion1.Name = "Puntuacion1"
        Me.Puntuacion1.Size = New System.Drawing.Size(34, 41)
        Me.Puntuacion1.TabIndex = 22
        Me.Puntuacion1.Text = "0"
        '
        'Puntuacion2
        '
        Me.Puntuacion2.AutoSize = True
        Me.Puntuacion2.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Puntuacion2.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Puntuacion2.Location = New System.Drawing.Point(723, 131)
        Me.Puntuacion2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Puntuacion2.Name = "Puntuacion2"
        Me.Puntuacion2.Size = New System.Drawing.Size(34, 41)
        Me.Puntuacion2.TabIndex = 23
        Me.Puntuacion2.Text = "0"
        '
        'Puntuacion3
        '
        Me.Puntuacion3.AutoSize = True
        Me.Puntuacion3.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Puntuacion3.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Puntuacion3.Location = New System.Drawing.Point(723, 172)
        Me.Puntuacion3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Puntuacion3.Name = "Puntuacion3"
        Me.Puntuacion3.Size = New System.Drawing.Size(34, 41)
        Me.Puntuacion3.TabIndex = 24
        Me.Puntuacion3.Text = "0"
        '
        'Resultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(953, 363)
        Me.Controls.Add(Me.Puntuacion3)
        Me.Controls.Add(Me.Puntuacion2)
        Me.Controls.Add(Me.Puntuacion1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PB3)
        Me.Controls.Add(Me.PB1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Resultados"
        Me.Text = "Resultados"
        CType(Me.PB3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PB3 As PictureBox
    Friend WithEvents PB1 As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Puntuacion1 As Label
    Friend WithEvents Puntuacion2 As Label
    Friend WithEvents Puntuacion3 As Label
End Class
