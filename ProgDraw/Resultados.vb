'LIBRERIA PARA LAS CONSULTAS MYSQL
Imports MySql.Data.MySqlClient
Public Class Resultados
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (Form1.connection.State = ConnectionState.Closed) Then
            Form1.connection.Open()
        End If

        Dim sQRY As String = "UPDATE usuarios SET dibujando='0', asignado='0'"
        Dim qryCommandEx As New MySqlCommand(sQRY, Form1.connection)
        qryCommandEx.ExecuteNonQuery()

        sQRY = "DELETE FROM instrucciones"
        Dim qryCommandEx2 As New MySqlCommand(sQRY, Form1.connection)
        qryCommandEx2.ExecuteNonQuery()

        sQRY = "UPDATE dibujos SET actual='0'"
        Dim qryCommandEx4 As New MySqlCommand(sQRY, Form1.connection)
        qryCommandEx4.ExecuteNonQuery()

        Threading.Thread.Sleep(3000)

        sQRY = "DELETE FROM partidas"
        Dim qryCommandEx3 As New MySqlCommand(sQRY, Form1.connection)
        qryCommandEx3.ExecuteNonQuery()
        End
    End Sub

    Private Sub Resultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Form1.connection.State = ConnectionState.Closed) Then
            Form1.connection.Open()
        End If
        'Resultados del Jugador 1
        Dim qryCommand As New MySqlCommand("SELECT SUM(puntos) FROM partidas WHERE idUsuario='1'", Form1.connection)
        Dim Reader As MySqlDataReader
        Reader = qryCommand.ExecuteReader()
        While Reader.Read()
            Puntuacion1.Text = Reader(0).ToString()
            If Reader(0).ToString() = "" Then
                Puntuacion1.Text = "0"
            End If
        End While
        Reader.Close()

        'Resultados del Jugador 2
        Dim qryCommand2 As New MySqlCommand("SELECT SUM(puntos) FROM partidas WHERE idUsuario='2'", Form1.connection)
        Dim Reader2 As MySqlDataReader
        Reader2 = qryCommand2.ExecuteReader()
        While Reader2.Read()
            Puntuacion2.Text = Reader2(0).ToString()
            If Reader2(0).ToString() = "" Then
                Puntuacion2.Text = "0"
            End If
        End While
        Reader2.Close()

        'Resultados del Jugador 3
        Dim qryCommand3 As New MySqlCommand("SELECT SUM(puntos) FROM partidas WHERE idUsuario='3'", Form1.connection)
        Dim Reader3 As MySqlDataReader
        Reader3 = qryCommand3.ExecuteReader()
        While Reader3.Read()
            Puntuacion3.Text = Reader3(0).ToString()
            If Reader3(0).ToString() = "" Then
                Puntuacion3.Text = "0"
            End If
        End While
        Reader3.Close()

        Form1.connection.Close()
    End Sub
End Class