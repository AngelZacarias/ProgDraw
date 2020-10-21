<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class compilador
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.txtprograma = New System.Windows.Forms.TextBox()
        Me.btncompilar = New System.Windows.Forms.PictureBox()
        Me.btnatras = New System.Windows.Forms.PictureBox()
        Me.btnguardar = New System.Windows.Forms.PictureBox()
        Me.btnabrir = New System.Windows.Forms.PictureBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.btncompilar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnatras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnguardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnabrir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Programa"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"0"})
        Me.ListBox1.Location = New System.Drawing.Point(12, 42)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ListBox1.Size = New System.Drawing.Size(31, 368)
        Me.ListBox1.TabIndex = 8
        Me.ListBox1.TabStop = False
        '
        'txtprograma
        '
        Me.txtprograma.Location = New System.Drawing.Point(49, 44)
        Me.txtprograma.Multiline = True
        Me.txtprograma.Name = "txtprograma"
        Me.txtprograma.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtprograma.Size = New System.Drawing.Size(320, 366)
        Me.txtprograma.TabIndex = 9
        '
        'btncompilar
        '
        Me.btncompilar.Image = Global.ProgDraw.My.Resources.Resources._1479121325_code
        Me.btncompilar.Location = New System.Drawing.Point(386, 44)
        Me.btncompilar.Name = "btncompilar"
        Me.btncompilar.Size = New System.Drawing.Size(70, 70)
        Me.btncompilar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btncompilar.TabIndex = 15
        Me.btncompilar.TabStop = False
        Me.btncompilar.Tag = "Guardar Procedimiento"
        '
        'btnatras
        '
        Me.btnatras.Image = Global.ProgDraw.My.Resources.Resources._1474318114_undo
        Me.btnatras.Location = New System.Drawing.Point(386, 333)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(70, 70)
        Me.btnatras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnatras.TabIndex = 13
        Me.btnatras.TabStop = False
        Me.btnatras.Tag = "Regresar"
        '
        'btnguardar
        '
        Me.btnguardar.Image = Global.ProgDraw.My.Resources.Resources._1474316642_save_as
        Me.btnguardar.Location = New System.Drawing.Point(386, 235)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(70, 70)
        Me.btnguardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnguardar.TabIndex = 11
        Me.btnguardar.TabStop = False
        Me.btnguardar.Tag = "Guardar Procedimiento"
        '
        'btnabrir
        '
        Me.btnabrir.Image = Global.ProgDraw.My.Resources.Resources._1474317954_folder
        Me.btnabrir.Location = New System.Drawing.Point(386, 138)
        Me.btnabrir.Name = "btnabrir"
        Me.btnabrir.Size = New System.Drawing.Size(70, 70)
        Me.btnabrir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnabrir.TabIndex = 10
        Me.btnabrir.TabStop = False
        Me.btnabrir.Tag = "Abrir Procedimiento"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Items.AddRange(New Object() {"0"})
        Me.ListBox2.Location = New System.Drawing.Point(12, 446)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ListBox2.Size = New System.Drawing.Size(31, 69)
        Me.ListBox2.TabIndex = 16
        Me.ListBox2.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(49, 445)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(407, 70)
        Me.TextBox1.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 422)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Errores"
        '
        'compilador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 531)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btncompilar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btnabrir)
        Me.Controls.Add(Me.txtprograma)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "compilador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compilador"
        CType(Me.btncompilar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnatras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnguardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnabrir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents btnatras As System.Windows.Forms.PictureBox
    Friend WithEvents btnguardar As System.Windows.Forms.PictureBox
    Friend WithEvents btnabrir As System.Windows.Forms.PictureBox
    Friend WithEvents txtprograma As System.Windows.Forms.TextBox
    Friend WithEvents btncompilar As System.Windows.Forms.PictureBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
