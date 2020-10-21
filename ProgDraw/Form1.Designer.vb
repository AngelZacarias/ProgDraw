<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PBcursor = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblcmd = New System.Windows.Forms.Label()
        Me.txtcmd = New System.Windows.Forms.TextBox()
        Me.ListBoxinstrucciones = New System.Windows.Forms.ListBox()
        Me.btnejecutar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblx = New System.Windows.Forms.Label()
        Me.lbly = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.txtDibujo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnadivinar = New System.Windows.Forms.Button()
        Me.lblTiempoRestante = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel1.SuspendLayout()
        CType(Me.PBcursor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PBcursor)
        Me.Panel1.Location = New System.Drawing.Point(17, 48)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1268, 480)
        Me.Panel1.TabIndex = 0
        '
        'PBcursor
        '
        Me.PBcursor.Image = Global.ProgDraw.My.Resources.Resources._1471777691_edit
        Me.PBcursor.Location = New System.Drawing.Point(608, 220)
        Me.PBcursor.Margin = New System.Windows.Forms.Padding(4)
        Me.PBcursor.Name = "PBcursor"
        Me.PBcursor.Size = New System.Drawing.Size(21, 20)
        Me.PBcursor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBcursor.TabIndex = 0
        Me.PBcursor.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.OpcionesToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1294, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.ToolStripMenuItem2, Me.ToolStripMenuItem1, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(89, 24)
        Me.ArchivoToolStripMenuItem.Text = "&ProgDraw"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(145, 26)
        Me.NuevoToolStripMenuItem.Text = "&Nuevo"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(145, 26)
        Me.ToolStripMenuItem2.Text = "&Guardar"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(142, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(145, 26)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(65, 24)
        Me.OpcionesToolStripMenuItem.Text = "Ay&uda"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformaciónToolStripMenuItem, Me.ContactoToolStripMenuItem})
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(91, 24)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca &De"
        '
        'InformaciónToolStripMenuItem
        '
        Me.InformaciónToolStripMenuItem.Name = "InformaciónToolStripMenuItem"
        Me.InformaciónToolStripMenuItem.Size = New System.Drawing.Size(172, 26)
        Me.InformaciónToolStripMenuItem.Text = "Información"
        '
        'ContactoToolStripMenuItem
        '
        Me.ContactoToolStripMenuItem.Name = "ContactoToolStripMenuItem"
        Me.ContactoToolStripMenuItem.Size = New System.Drawing.Size(172, 26)
        Me.ContactoToolStripMenuItem.Text = "Contacto"
        '
        'lblcmd
        '
        Me.lblcmd.AutoSize = True
        Me.lblcmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcmd.Location = New System.Drawing.Point(16, 539)
        Me.lblcmd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcmd.Name = "lblcmd"
        Me.lblcmd.Size = New System.Drawing.Size(132, 29)
        Me.lblcmd.TabIndex = 2
        Me.lblcmd.Text = "Comando:"
        '
        'txtcmd
        '
        Me.txtcmd.Location = New System.Drawing.Point(152, 542)
        Me.txtcmd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcmd.Name = "txtcmd"
        Me.txtcmd.Size = New System.Drawing.Size(967, 22)
        Me.txtcmd.TabIndex = 3
        '
        'ListBoxinstrucciones
        '
        Me.ListBoxinstrucciones.FormattingEnabled = True
        Me.ListBoxinstrucciones.ItemHeight = 16
        Me.ListBoxinstrucciones.Location = New System.Drawing.Point(17, 633)
        Me.ListBoxinstrucciones.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBoxinstrucciones.Name = "ListBoxinstrucciones"
        Me.ListBoxinstrucciones.Size = New System.Drawing.Size(1102, 100)
        Me.ListBoxinstrucciones.TabIndex = 4
        Me.ListBoxinstrucciones.TabStop = False
        '
        'btnejecutar
        '
        Me.btnejecutar.Location = New System.Drawing.Point(1128, 538)
        Me.btnejecutar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnejecutar.Name = "btnejecutar"
        Me.btnejecutar.Size = New System.Drawing.Size(144, 28)
        Me.btnejecutar.TabIndex = 5
        Me.btnejecutar.Text = "Ejecutar"
        Me.btnejecutar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(751, 740)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Posicion X:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1003, 740)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Posicion Y:"
        '
        'lblx
        '
        Me.lblx.AutoSize = True
        Me.lblx.Location = New System.Drawing.Point(839, 740)
        Me.lblx.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblx.Name = "lblx"
        Me.lblx.Size = New System.Drawing.Size(16, 17)
        Me.lblx.TabIndex = 8
        Me.lblx.Text = "0"
        '
        'lbly
        '
        Me.lbly.AutoSize = True
        Me.lbly.Location = New System.Drawing.Point(1091, 740)
        Me.lbly.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbly.Name = "lbly"
        Me.lbly.Size = New System.Drawing.Size(16, 17)
        Me.lbly.TabIndex = 9
        Me.lbly.Text = "0"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1294, 766)
        Me.ShapeContainer1.TabIndex = 10
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 853
        Me.LineShape1.X2 = 940
        Me.LineShape1.Y1 = 508
        Me.LineShape1.Y2 = 508
        '
        'txtDibujo
        '
        Me.txtDibujo.Location = New System.Drawing.Point(152, 591)
        Me.txtDibujo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDibujo.Name = "txtDibujo"
        Me.txtDibujo.Size = New System.Drawing.Size(967, 22)
        Me.txtDibujo.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 588)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 29)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Dibujo:"
        '
        'btnadivinar
        '
        Me.btnadivinar.Location = New System.Drawing.Point(1128, 587)
        Me.btnadivinar.Name = "btnadivinar"
        Me.btnadivinar.Size = New System.Drawing.Size(145, 30)
        Me.btnadivinar.TabIndex = 13
        Me.btnadivinar.Text = "Adivinar"
        Me.btnadivinar.UseVisualStyleBackColor = True
        '
        'lblTiempoRestante
        '
        Me.lblTiempoRestante.AutoSize = True
        Me.lblTiempoRestante.Font = New System.Drawing.Font("Agency FB", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiempoRestante.Location = New System.Drawing.Point(1168, 674)
        Me.lblTiempoRestante.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTiempoRestante.Name = "lblTiempoRestante"
        Me.lblTiempoRestante.Size = New System.Drawing.Size(88, 72)
        Me.lblTiempoRestante.TabIndex = 14
        Me.lblTiempoRestante.Text = "30"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1127, 654)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Tiempo Restante"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1294, 766)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblTiempoRestante)
        Me.Controls.Add(Me.btnadivinar)
        Me.Controls.Add(Me.txtDibujo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbly)
        Me.Controls.Add(Me.lblx)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnejecutar)
        Me.Controls.Add(Me.ListBoxinstrucciones)
        Me.Controls.Add(Me.txtcmd)
        Me.Controls.Add(Me.lblcmd)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProgDraw"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PBcursor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents lblcmd As System.Windows.Forms.Label
    Friend WithEvents txtcmd As System.Windows.Forms.TextBox
    Friend WithEvents ListBoxinstrucciones As System.Windows.Forms.ListBox
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnejecutar As System.Windows.Forms.Button
    Friend WithEvents PBcursor As System.Windows.Forms.PictureBox
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContactoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblx As System.Windows.Forms.Label
    Friend WithEvents lbly As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents txtDibujo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnadivinar As Button
    Private WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Private WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents lblTiempoRestante As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
