<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class procedimintos
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
        Me.txtprocedimiento = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.btnatras = New System.Windows.Forms.PictureBox()
        Me.btnejecutar = New System.Windows.Forms.PictureBox()
        Me.btnguardar = New System.Windows.Forms.PictureBox()
        Me.btnabrir = New System.Windows.Forms.PictureBox()
        CType(Me.btnatras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnejecutar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnguardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnabrir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtprocedimiento
        '
        Me.txtprocedimiento.Location = New System.Drawing.Point(49, 49)
        Me.txtprocedimiento.Multiline = True
        Me.txtprocedimiento.Name = "txtprocedimiento"
        Me.txtprocedimiento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtprocedimiento.Size = New System.Drawing.Size(320, 432)
        Me.txtprocedimiento.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"0"})
        Me.ListBox1.Location = New System.Drawing.Point(12, 47)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ListBox1.Size = New System.Drawing.Size(31, 433)
        Me.ListBox1.TabIndex = 0
        Me.ListBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Procedimiento:"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Location = New System.Drawing.Point(148, 27)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(10, 13)
        Me.lblname.TabIndex = 8
        Me.lblname.Text = "-"
        '
        'btnatras
        '
        Me.btnatras.Image = Global.ProgDraw.My.Resources.Resources._1474318114_undo
        Me.btnatras.Location = New System.Drawing.Point(386, 411)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(70, 70)
        Me.btnatras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnatras.TabIndex = 4
        Me.btnatras.TabStop = False
        Me.btnatras.Tag = "Regresar"
        '
        'btnejecutar
        '
        Me.btnejecutar.Image = Global.ProgDraw.My.Resources.Resources._1474847808_play_circle
        Me.btnejecutar.Location = New System.Drawing.Point(386, 220)
        Me.btnejecutar.Name = "btnejecutar"
        Me.btnejecutar.Size = New System.Drawing.Size(70, 70)
        Me.btnejecutar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnejecutar.TabIndex = 3
        Me.btnejecutar.TabStop = False
        Me.btnejecutar.Tag = "Ejecutar Procedimiento"
        '
        'btnguardar
        '
        Me.btnguardar.Image = Global.ProgDraw.My.Resources.Resources._1474316642_save_as
        Me.btnguardar.Location = New System.Drawing.Point(386, 121)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(70, 70)
        Me.btnguardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnguardar.TabIndex = 2
        Me.btnguardar.TabStop = False
        Me.btnguardar.Tag = "Guardar Procedimiento"
        '
        'btnabrir
        '
        Me.btnabrir.Image = Global.ProgDraw.My.Resources.Resources._1474317954_folder
        Me.btnabrir.Location = New System.Drawing.Point(386, 21)
        Me.btnabrir.Name = "btnabrir"
        Me.btnabrir.Size = New System.Drawing.Size(70, 70)
        Me.btnabrir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnabrir.TabIndex = 1
        Me.btnabrir.TabStop = False
        Me.btnabrir.Tag = "Abrir Procedimiento"
        '
        'procedimintos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 493)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.btnejecutar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btnabrir)
        Me.Controls.Add(Me.txtprocedimiento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "procedimintos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Procedimientos"
        CType(Me.btnatras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnejecutar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnguardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnabrir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtprocedimiento As System.Windows.Forms.TextBox
    Friend WithEvents btnabrir As System.Windows.Forms.PictureBox
    Friend WithEvents btnguardar As System.Windows.Forms.PictureBox
    Friend WithEvents btnejecutar As System.Windows.Forms.PictureBox
    Friend WithEvents btnatras As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
End Class
