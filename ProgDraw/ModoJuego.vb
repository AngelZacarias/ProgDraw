Public Class ModoJuego
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.esMultijugador = False
        Form1.idJugador = 1
        Form1.estoyDibujando = True
        Form1.comandoDibujo = ""
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.esMultijugador = True
        Form1.idJugador = 0
        Form1.estoyDibujando = False
        Form1.comandoDibujo = ""
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class