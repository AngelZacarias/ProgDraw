Imports System.IO
Public Class procedimintos

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles btnabrir.Click
        Dim myStream As Stream = Nothing
        Dim openFileDialog1 As New OpenFileDialog()
        OpenFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        openFileDialog1.InitialDirectory = Application.StartupPath & "\procedimientos"

        txtprocedimiento.Text = ""

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            lblname.Text = openFileDialog1.FileName
            Form1.arrText.Clear()
            Dim objReader As New StreamReader(openFileDialog1.FileName)
            Do
                Form1.sLine = objReader.ReadLine()
                If Not Form1.sLine Is Nothing Then
                    Form1.arrText.Add(Form1.sLine)
                End If
            Loop Until Form1.sLine Is Nothing
            objReader.Close()
            For Each Form1.sLine In Form1.arrText
                txtprocedimiento.Text = txtprocedimiento.Text + Form1.sLine + vbCrLf
            Next

        End If
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim Archivo As StreamWriter = File.CreateText(Application.StartupPath & "\procedimientos\" & Form1.parametro & ".txt")
        Archivo.WriteLine(txtprocedimiento.Text)
        Archivo.Flush()
        Archivo.Close()
        MsgBox("Archivo guardado", MsgBoxStyle.Information, "Exito")
        btnatras.Focus()
    End Sub

    Private Sub btnatras_Click(sender As Object, e As EventArgs) Handles btnatras.Click
        txtprocedimiento.Text = ""
        Me.Close()
    End Sub

    Private Sub txtprocedimiento_KeyDown(sender As Object, e As KeyEventArgs) Handles txtprocedimiento.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Back Then
            Dim nlineas As Integer = txtprocedimiento.Lines.Count
            Dim x As Integer = 0
            ListBox1.Items.Clear()
            While x <= nlineas
                ListBox1.Items.Add(x)
                x = x + 1
            End While
            ListBox1.Refresh()
        End If
    End Sub

    Private Sub procedimintos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.archivoabierto = 1 Then
            lblname.Text = Form1.parametro
            For Each Form1.sLine In Form1.arrText
                txtprocedimiento.Text = txtprocedimiento.Text + Form1.sLine + vbCrLf
            Next
        Else
            If Form1.archivoabierto = 2 Then
                lblname.Text = Form1.parametro
            End If
        End If
    End Sub

    Private Sub btnejecutar_Click(sender As Object, e As EventArgs) Handles btnejecutar.Click

        Dim nlineas As Integer = txtprocedimiento.Lines.Count
        Dim arr As Array = txtprocedimiento.Lines.ToArray()
        Dim x As Integer = 0
        While x < nlineas
            If arr(x) <> "" Then
                ejecutar(arr(x))
            End If
            x = x + 1
        End While

    End Sub
End Class