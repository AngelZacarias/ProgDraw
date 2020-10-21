Public Class compilador

    Private Sub txtprograma_KeyDown(sender As Object, e As KeyEventArgs) Handles txtprograma.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Back Then
            Dim nlineas As Integer = txtprograma.Lines.Count
            Dim x As Integer = 0
            ListBox1.Items.Clear()
            While x <= nlineas
                ListBox1.Items.Add(x)
                x = x + 1
            End While
            ListBox1.Refresh()
        End If
    End Sub

    Private Sub btnatras_Click(sender As Object, e As EventArgs) Handles btnatras.Click
        txtprograma.Text = ""
        Me.Close()
    End Sub
End Class