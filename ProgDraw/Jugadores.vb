Imports MySql.Data.MySqlClient
Public Class Jugadores

    Dim bJugador1Activo As Boolean
    Dim bJugador2Activo As Boolean
    Dim bJugador3Activo As Boolean

    Private Sub Jugadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim qryCommand As New MySqlCommand("SELECT * FROM usuarios", Form1.connection)

        Dim Reader As MySqlDataReader
        Reader = qryCommand.ExecuteReader()

        While Reader.Read()
            Select Case Reader(0).ToString()'Revisa por idUsuario
                Case "1"
                    If Reader(2).ToString().Equals("1") Then 'Revisa por asignado
                        Jugador1.Enabled = False
                        Jugador1.Text = "Jugador 1 Conectado"
                    End If
                Case "2"
                    If Reader(2).ToString().Equals("1") Then
                        Jugador2.Enabled = False
                        Jugador2.Text = "Jugador 2 Conectado"
                    End If
                Case "3"
                    If Reader(2).ToString().Equals("1") Then
                        Jugador3.Enabled = False
                        Jugador3.Text = "Jugador 3 Conectado"
                    End If

                Case Else
            End Select
        End While
        Reader.Close()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub Jugador1_Click(sender As Object, e As EventArgs) Handles Jugador1.Click

        Dim sQRY As String
        sQRY = "SELECT * FROM usuarios WHERE idUsuario='1'"
        Dim qryCommand As New MySqlCommand(sQRY, Form1.connection)

        Dim Reader As MySqlDataReader
        Reader = qryCommand.ExecuteReader()

        Dim posibleConexion As Boolean

        While Reader.Read()
            If Reader(2).ToString().Equals("1") Then 'Revisa por asignado
                Jugador1.Enabled = False
                Jugador1.Text = "Jugador 1 Conectado"
                posibleConexion = False
            Else
                posibleConexion = True
            End If
        End While
        Reader.Close()

        If posibleConexion Then
            sQRY = "UPDATE usuarios SET asignado = '1', dibujando='1' WHERE idUsuario = '1'"
            Dim qryCommandEx As New MySqlCommand(sQRY, Form1.connection)
            If qryCommandEx.ExecuteNonQuery() > 0 Then
                Jugador1.Enabled = False
                Jugador1.Text = "Jugador 1 Conectado"
                Form1.idJugador = 1
                Form1.estoyDibujando = True
                Form1.RecienAsignado = True
                Form1.TiempoRestante = 30
            End If
        Else
            MessageBox.Show("Lo sentimos, alguien ya ha seleccionado a este jugador")
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        'Va a estar revisando la conexion de los demas cada 1 segundo
        While Not BackgroundWorker1.CancellationPending
            If (Form1.connection.State = ConnectionState.Closed) Then
                Form1.connection.Open()
            End If
            Dim qryCommand As New MySqlCommand("SELECT * FROM usuarios", Form1.connection)

            Dim Reader As MySqlDataReader
            Reader = qryCommand.ExecuteReader()

            While Reader.Read()
                Select Case Reader(0).ToString()'Revisa por idUsuario
                    Case "1"
                        If Reader(2).ToString().Equals("1") Then 'Revisa por asignado
                            bJugador1Activo = True
                        End If
                    Case "2"
                        If Reader(2).ToString().Equals("1") Then
                            bJugador2Activo = True
                        End If
                    Case "3"
                        If Reader(2).ToString().Equals("1") Then
                            bJugador3Activo = True
                        End If

                    Case Else
                End Select
            End While
            Reader.Close()
            BackgroundWorker1.ReportProgress(1)
            Threading.Thread.Sleep(1000)
        End While
        e.Cancel = True
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        If bJugador1Activo Then
            Jugador1.Enabled = False
            Jugador1.Text = "Jugador 1 Conectado"
        End If
        If bJugador2Activo Then
            Jugador2.Enabled = False
            Jugador2.Text = "Jugador 2 Conectado"
        End If
        If bJugador3Activo Then
            Jugador3.Enabled = False
            Jugador3.Text = "Jugador 3 Conectado"
        End If
        'Si todos estan asignados Comenzara la partida
        If bJugador1Activo And bJugador2Activo And bJugador3Activo And (Not Form1.idJugador = 0) Then
            BackgroundWorker1.CancelAsync()
            Me.Close()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Jugador2_Click(sender As Object, e As EventArgs) Handles Jugador2.Click
        Dim sQRY As String
        sQRY = "SELECT * FROM usuarios WHERE idUsuario='2'"
        Dim qryCommand As New MySqlCommand(sQRY, Form1.connection)

        Dim Reader As MySqlDataReader
        Reader = qryCommand.ExecuteReader()

        Dim posibleConexion As Boolean

        While Reader.Read()
            If Reader(2).ToString().Equals("1") Then 'Revisa por asignado
                Jugador2.Enabled = False
                Jugador2.Text = "Jugador 2 Conectado"
                posibleConexion = False
            Else
                posibleConexion = True
            End If
        End While
        Reader.Close()

        If posibleConexion Then
            sQRY = "UPDATE usuarios SET asignado = '1' WHERE idUsuario = '2'"
            Dim qryCommandEx As New MySqlCommand(sQRY, Form1.connection)
            If qryCommandEx.ExecuteNonQuery() > 0 Then
                Jugador2.Enabled = False
                Jugador2.Text = "Jugador 2 Conectado"
                Form1.idJugador = 2
                Form1.estoyDibujando = False
            End If
        Else
            MessageBox.Show("Lo sentimos, alguien ya ha seleccionado a este jugador")
        End If
    End Sub

    Private Sub Jugador3_Click(sender As Object, e As EventArgs) Handles Jugador3.Click
        Dim sQRY As String
        sQRY = "SELECT * FROM usuarios WHERE idUsuario='3'"
        Dim qryCommand As New MySqlCommand(sQRY, Form1.connection)

        Dim Reader As MySqlDataReader
        Reader = qryCommand.ExecuteReader()

        Dim posibleConexion As Boolean

        While Reader.Read()
            If Reader(2).ToString().Equals("1") Then 'Revisa por asignado
                Jugador3.Enabled = False
                Jugador3.Text = "Jugador 3 Conectado"
                posibleConexion = False
            Else
                posibleConexion = True
            End If
        End While
        Reader.Close()

        If posibleConexion Then
            sQRY = "UPDATE usuarios SET asignado = '1' WHERE idUsuario = '3'"
            Dim qryCommandEx As New MySqlCommand(sQRY, Form1.connection)
            If qryCommandEx.ExecuteNonQuery() > 0 Then
                Jugador3.Enabled = False
                Jugador3.Text = "Jugador 3 Conectado"
                Form1.idJugador = 3
                Form1.estoyDibujando = False
            End If
        Else
            MessageBox.Show("Lo sentimos, alguien ya ha seleccionado a este jugador")
        End If
    End Sub
End Class