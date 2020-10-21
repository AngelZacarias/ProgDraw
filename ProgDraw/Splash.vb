Public Class Splash

    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProBar.Value = ProBar.Value + 10
        If ProBar.Value = 100 Then
            Timer1.Stop()
            Me.Close()
        End If
    End Sub
End Class