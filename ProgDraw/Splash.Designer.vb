<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Splash))
        Me.ProBar = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PB3 = New System.Windows.Forms.PictureBox()
        Me.PB2 = New System.Windows.Forms.PictureBox()
        Me.PB1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.PB3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProBar
        '
        Me.ProBar.Location = New System.Drawing.Point(16, 272)
        Me.ProBar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ProBar.Name = "ProBar"
        Me.ProBar.Size = New System.Drawing.Size(656, 28)
        Me.ProBar.TabIndex = 0
        '
        'Timer1
        '
        '
        'PB3
        '
        Me.PB3.Image = Global.ProgDraw.My.Resources.Resources._1471777855_right
        Me.PB3.Location = New System.Drawing.Point(484, 94)
        Me.PB3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PB3.Name = "PB3"
        Me.PB3.Size = New System.Drawing.Size(172, 145)
        Me.PB3.TabIndex = 3
        Me.PB3.TabStop = False
        '
        'PB2
        '
        Me.PB2.Image = Global.ProgDraw.My.Resources.Resources._1471777691_edit
        Me.PB2.Location = New System.Drawing.Point(257, 94)
        Me.PB2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PB2.Name = "PB2"
        Me.PB2.Size = New System.Drawing.Size(172, 145)
        Me.PB2.TabIndex = 2
        Me.PB2.TabStop = False
        '
        'PB1
        '
        Me.PB1.Image = Global.ProgDraw.My.Resources.Resources._1471777852_left
        Me.PB1.Location = New System.Drawing.Point(33, 94)
        Me.PB1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PB1.Name = "PB1"
        Me.PB1.Size = New System.Drawing.Size(172, 145)
        Me.PB1.TabIndex = 1
        Me.PB1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(239, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 57)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "PROGDRAW"
        '
        'Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 321)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PB3)
        Me.Controls.Add(Me.PB2)
        Me.Controls.Add(Me.PB1)
        Me.Controls.Add(Me.ProBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Splash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Splash"
        CType(Me.PB3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProBar As System.Windows.Forms.ProgressBar
    Friend WithEvents PB1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PB2 As System.Windows.Forms.PictureBox
    Friend WithEvents PB3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
