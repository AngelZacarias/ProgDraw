Imports System
Imports System.IO
Imports System.Collections

Public Class ayuda

    Private Sub ayuda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.arrText.Clear()
        Try
            Dim objReader As New StreamReader(Application.StartupPath & "\ayuda\ayuda.txt")
            Do
                Form1.sLine = objReader.ReadLine()
                If Not Form1.sLine Is Nothing Then
                    Form1.arrText.Add(Form1.sLine)
                End If
            Loop Until Form1.sLine Is Nothing
            objReader.Close()
            For Each Form1.sLine In Form1.arrText
                lblayuda.Text = lblayuda.Text + Form1.sLine + vbCrLf
            Next
        Catch ex As Exception
            MsgBox("Algo salió mal", MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub btnatras_Click(sender As Object, e As EventArgs) Handles btnatras.Click
        Me.Close()
    End Sub
End Class