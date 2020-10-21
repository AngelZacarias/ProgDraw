Imports System
Imports System.IO
Imports System.Collections
'LIBRERIA PARA LAS CONSULTAS MYSQL
Imports MySql.Data.MySqlClient


Public Class Form1
    'Variables
    'Dim Lapiz As New Pen(Color.Black)
    Dim clickNumber = 0
    Public posactualX As Integer
    Public posactualY As Integer

    ':::::::::::::::::::::::::::::: Variables Para el manejo de SO ::::::::::::::::::::::::::::
    Public idJugador As Integer
    Public estoyDibujando As Boolean
    Public esMultijugador As Boolean
    Public comandoDibujo As String
    Dim terminoPartida As Boolean
    Public RecienAsignado As Boolean = False
    Public TiempoRestante As Integer
    Dim sDibujo As String
    Public connection As New MySqlConnection("datasource=remotemysql.com;port=3306;username=AhiNHywhWb;password=ZgI6LdIR2K;database=AhiNHywhWb;")

    'Structure donde se crean las variables
    Public Structure PointOfLines

        Public initialPos As Point
        Public finpos As Point
        Public lapiz As Pen


    End Structure
    Public colores As New Pen(Color.Black, 1)
    Public col As New Color
    Public gr As Integer
    'Creamos la lista de Puntos
    Public PuntosEnLista As New List(Of PointOfLines)
    'Variables para lectura de procedimientos
    Public sLine As String = ""
    Public arrText As New ArrayList()
    Public archivoabierto As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblx.Text = PBcursor.Location.X
        lbly.Text = PBcursor.Location.Y
        Me.Hide()
        Dim bConectado As Boolean
        ':::::::::::::::::::::: TRATAMOS DE CONECTAR :::::::::::::::::::
        Try
            connection.Open()
            bConectado = True
        Catch ex As Exception
            bConectado = False
            MessageBox.Show(ex.ToString())
        End Try
        ':::::::::::::::::::::: MOSTRAMOS EL SPLASH ::::::::::::::::::::
        Dim Misplash As New Splash
        With Misplash.Timer1
            .Interval = 200
            .Enabled = True
        End With
        Misplash.ShowDialog(Me)
        Misplash.Dispose()
        ':::::::::::::::::::::: MOSTRAMOS EL MENU 1 ::::::::::::::::::::
        Dim MiModoJuego As New ModoJuego
        If Not bConectado Then
            With MiModoJuego.Button1
                .Enabled = False
            End With
        End If
        MiModoJuego.ShowDialog(Me)
        MiModoJuego.Dispose()
        ':::::::::::::::::::::: MOSTRAMOS EL MENU 2 ::::::::::::::::::::
        If esMultijugador Then
            Dim MiSeleccionJugador As New Jugadores
            MiSeleccionJugador.ShowDialog(Me)
            MiSeleccionJugador.Dispose()
        End If
        ':::::::::::::::::::::: MOSTRAMOS EL PROGRAMA PRINCIPAL ::::::::::::::::::::
        Me.Show()
        ':::::::::::::::::::::: AJUSTAMOS CONFIGURACION DE LA PARTIDA ::::::::::::::::::::
        If esMultijugador Then
            If estoyDibujando Then
                txtcmd.Enabled = True
                btnejecutar.Enabled = True
                btnadivinar.Enabled = False
                txtDibujo.Enabled = False
            Else
                txtcmd.Enabled = False
                btnejecutar.Enabled = False
                btnadivinar.Enabled = True
                txtDibujo.Enabled = True
            End If
            terminoPartida = False
        Else
            txtDibujo.Visible = False
            btnadivinar.Visible = False
            lblTiempoRestante.Visible = False
            Label5.Visible = False
            Label3.Visible = False
        End If

        'Agregar a la lista
        Dim PuntosDeLineas As New PointOfLines
        posactualX = 285
        posactualY = 300

        'Punto Inicial
        PuntosDeLineas.initialPos = New Point(posactualX, posactualY)

        'Punto Final
        PuntosDeLineas.finpos = New Point(posactualX, posactualY)

        'Indicamos el grosor y color default
        PuntosDeLineas.lapiz = Pens.Black
        col = Color.Black
        gr = 1

        'agregamos los puntos a la list
        PuntosEnLista.Add(PuntosDeLineas)


        'Repinta el pictureBox
        Me.Panel1.Invalidate()

        '::::::::::::::::::::::::: Comenzamos la partida :::::::::::::::::::::::::::::::::::::
        If esMultijugador Then
            BackgroundWorker1.RunWorkerAsync()
        End If
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        End
    End Sub

    Public parametro As String = "" 'Variable Publica para guardar solo parametro

    Private Sub btnejecutar_Click(sender As Object, e As EventArgs) Handles btnejecutar.Click
        Dim Comando As String = txtcmd.Text
        ejecutar(Comando)
        If esMultijugador Then
            If idJugador = 1 Then
                'Insertamos en BD para jugador 2 y 3
                Dim sQRY As String = "INSERT INTO instrucciones(instruccion,idUsuario) VALUES('" + Comando + "','2')"
                Dim qryCommandEx As New MySqlCommand(sQRY, connection)
                qryCommandEx.ExecuteNonQuery()

                sQRY = "INSERT INTO instrucciones(instruccion,idUsuario) VALUES('" + Comando + "','3')"
                Dim qryCommandEx2 As New MySqlCommand(sQRY, connection)
                qryCommandEx2.ExecuteNonQuery()
            ElseIf idJugador = 2 Then
                'Insertamos en BD para jugador 1 y 3
                Dim sQRY As String = "INSERT INTO instrucciones(instruccion,idUsuario) VALUES('" + Comando + "','1')"
                Dim qryCommandEx As New MySqlCommand(sQRY, connection)
                qryCommandEx.ExecuteNonQuery()

                sQRY = "INSERT INTO instrucciones(instruccion,idUsuario) VALUES('" + Comando + "','3')"
                Dim qryCommandEx2 As New MySqlCommand(sQRY, connection)
                qryCommandEx2.ExecuteNonQuery()
            ElseIf idJugador = 3 Then
                'Insertamos en BD para jugador 1 y 2
                Dim sQRY As String = "INSERT INTO instrucciones(instruccion,idUsuario) VALUES('" + Comando + "','1')"
                Dim qryCommandEx As New MySqlCommand(sQRY, connection)
                qryCommandEx.ExecuteNonQuery()

                sQRY = "INSERT INTO instrucciones(instruccion,idUsuario) VALUES('" + Comando + "','2')"
                Dim qryCommandEx2 As New MySqlCommand(sQRY, connection)
                qryCommandEx2.ExecuteNonQuery()
            End If
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        ejecutar("limpiar<>")
    End Sub

    Private Sub InformaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformaciónToolStripMenuItem.Click
        AcercaDe.ShowDialog()
    End Sub

    Private Sub PBcursor_LocationChanged(sender As Object, e As EventArgs) Handles PBcursor.LocationChanged
        lblx.Text = PBcursor.Location.X
        lbly.Text = PBcursor.Location.Y
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        For Each getLines As PointOfLines In PuntosEnLista

            'crea un Nuevo graphics
            Dim gp As Graphics = e.Graphics

            'dibuja la linea desde la lista

            gp.DrawLine(getLines.lapiz, getLines.initialPos, getLines.finpos)

        Next
        Me.Invalidate()
    End Sub

    Private Sub OpcionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpcionesToolStripMenuItem.Click
        ejecutar("ayuda<>")
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Dim vFoto As New Bitmap(Panel1.Width, Panel1.Height)
        Panel1.DrawToBitmap(vFoto, New Rectangle(0, 0, Panel1.Width, Panel1.Height))
        'vFoto.Save("C:\archivo.jpeg", Imaging.ImageFormat.Jpeg)

        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif"
        saveFileDialog1.Title = "Save an Image File"
        saveFileDialog1.ShowDialog()

        ' If the file name is not an empty string open it for saving.
        If saveFileDialog1.FileName <> "" Then
            ' Saves the Image via a FileStream created by the OpenFile method.
            Dim fs As System.IO.FileStream = CType _
               (saveFileDialog1.OpenFile(), System.IO.FileStream)
            ' Saves the Image in the appropriate ImageFormat based upon the
            ' file type selected in the dialog box.
            ' NOTE that the FilterIndex property is one-based.
            Select Case saveFileDialog1.FilterIndex
                Case 1
                    vFoto.Save(fs,
                       System.Drawing.Imaging.ImageFormat.Jpeg)

                Case 2
                    vFoto.Save(fs,
                       System.Drawing.Imaging.ImageFormat.Bmp)

                Case 3
                    vFoto.Save(fs,
                       System.Drawing.Imaging.ImageFormat.Gif)
            End Select

            fs.Close()
            MsgBox("Imagen guardada correctamente", MsgBoxStyle.OkOnly)
        End If
    End Sub


    Private Sub txtcmd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcmd.KeyPress
        If e.KeyChar = Chr(13) Then

        End If
    End Sub

    Private Sub txtcmd_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcmd.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnejecutar.PerformClick()
        End If
    End Sub

    Private Sub ContactoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactoToolStripMenuItem.Click
        contacto.ShowDialog()
    End Sub

    Private Sub BackgroundWorker1_DoWork_1(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim connection2 As New MySqlConnection("datasource=remotemysql.com;port=3306;username=AhiNHywhWb;password=ZgI6LdIR2K;database=AhiNHywhWb;")
        While Not BackgroundWorker1.CancellationPending

            If estoyDibujando Then
                'Revisamos si ya se le asigno un dibujo
                If txtDibujo.Text = "" Then
                    'Revisamos la conexion
                    If (connection2.State = ConnectionState.Closed) Then
                        connection2.Open()
                    End If

                    'Seleccionamos un dibujo al azar
                    Dim sQRY As String
                    Dim id As Integer = (CInt(Math.Ceiling(Rnd() * 4)) + 1)
                    sQRY = "SELECT * FROM dibujos WHERE idDibujo='" + id.ToString() + "'"
                    Dim qryCommand As New MySqlCommand(sQRY, connection2)

                    Dim Reader As MySqlDataReader
                    Reader = qryCommand.ExecuteReader()

                    While Reader.Read()
                        sDibujo = Reader(1).ToString()
                    End While
                    Reader.Close()

                    'Asignamos este dibujo como el actual
                    sQRY = "UPDATE dibujos SET actual = '1' WHERE idDibujo = '" + id.ToString() + "'"
                    Dim qryCommandEx As New MySqlCommand(sQRY, connection2)
                    If Not qryCommandEx.ExecuteNonQuery() > 0 Then
                        sDibujo = ""
                    End If
                    RecienAsignado = False
                    BackgroundWorker1.ReportProgress(1)

                    'Asignamos la nueva partida
                    sQRY = "INSERT INTO partidas(idPartida,idUsuario,puntos,terminada) VALUES('0','0','0','0')"
                    Dim qryCommandEx2 As New MySqlCommand(sQRY, connection2)
                    qryCommandEx2.ExecuteNonQuery()

                    'Eliminamos Remanentes de Instrucciones
                    sQRY = "DELETE FROM instrucciones"
                    Dim qryCommandEx3 As New MySqlCommand(sQRY, connection2)
                    qryCommandEx3.ExecuteNonQuery()

                    'Renovamos tiempo
                    sQRY = "UPDATE Tiempo SET tiempo='30'"
                    Dim qryCommandEx4 As New MySqlCommand(sQRY, connection2)
                    qryCommandEx4.ExecuteNonQuery()
                Else
                    'Restamos Tiempo
                    Dim sQRY As String = "SELECT * FROM Tiempo"
                    Dim qryCommand As New MySqlCommand(sQRY, connection2)
                    Dim Reader As MySqlDataReader
                    Reader = qryCommand.ExecuteReader()

                    While Reader.Read()
                        TiempoRestante = Convert.ToInt32(Reader(0).ToString())
                    End While
                    Reader.Close()
                    TiempoRestante -= 1

                    sQRY = "UPDATE Tiempo SET tiempo='" + TiempoRestante.ToString() + "'"
                    Dim qryCommandEx3 As New MySqlCommand(sQRY, connection2)
                    qryCommandEx3.ExecuteNonQuery()
                    BackgroundWorker1.ReportProgress(1)
                    If TiempoRestante <= 0 Then
                        'Terminamos partida
                        sQRY = "UPDATE partidas SET terminada='1' WHERE terminada='0'"
                        Dim qryCommandEx As New MySqlCommand(sQRY, connection2)
                        qryCommandEx.ExecuteNonQuery()

                        'Quitamos el dibujo que estaba como actual
                        sQRY = "UPDATE dibujos SET actual='0'"
                        Dim qryCommandEx2 As New MySqlCommand(sQRY, connection2)
                        qryCommandEx2.ExecuteNonQuery()

                        'Ya no estoy dibujando
                        estoyDibujando = False
                        RecienAsignado = True

                        'Renovamos tiempo
                        sQRY = "UPDATE Tiempo SET tiempo='30'"
                        Dim qryCommandEx5 As New MySqlCommand(sQRY, connection2)
                        qryCommandEx5.ExecuteNonQuery()

                        'Asignamos que el que sigue esta dibujando
                        If idJugador = 1 Then
                            'Siguiente es el jugador 2
                            sQRY = "UPDATE usuarios SET dibujando='1' WHERE idUsuario='2'"
                            Dim qryCommandEx4 As New MySqlCommand(sQRY, connection2)
                            qryCommandEx4.ExecuteNonQuery()

                            sQRY = "UPDATE usuarios SET dibujando='0' WHERE idUsuario='1'"
                            Dim qryCommandEx30 As New MySqlCommand(sQRY, connection2)
                            qryCommandEx30.ExecuteNonQuery()

                        ElseIf idJugador = 2 Then
                            'Siguiente es el Jugador 3
                            sQRY = "UPDATE usuarios SET dibujando='1' WHERE idUsuario='3'"
                            Dim qryCommandEx4 As New MySqlCommand(sQRY, connection2)
                            qryCommandEx4.ExecuteNonQuery()

                            sQRY = "UPDATE usuarios SET dibujando='0' WHERE idUsuario='2'"
                            Dim qryCommandEx30 As New MySqlCommand(sQRY, connection2)
                            qryCommandEx30.ExecuteNonQuery()

                        ElseIf idJugador = 3 Then
                            'Ya no sigue nadie
                            sQRY = "UPDATE usuarios SET dibujando='0'"
                            Dim qryCommandEx30 As New MySqlCommand(sQRY, connection2)
                            qryCommandEx30.ExecuteNonQuery()
                            'TiempoRestante = 30
                        End If
                    End If
                End If
            Else
                'Revisamos la conexion
                If (connection2.State = ConnectionState.Closed) Then
                    connection2.Open()
                End If
                'Revisamos si hay alguien dibujando
                Dim sQRY As String = "SELECT * FROM usuarios WHERE dibujando='1'"
                Dim qryCommand As New MySqlCommand(sQRY, connection2)
                Dim bHayAlguienDibujando As Boolean = False
                Dim Reader As MySqlDataReader
                Reader = qryCommand.ExecuteReader()

                While Reader.Read()
                    bHayAlguienDibujando = True
                    If Reader(0).ToString = idJugador.ToString() Then
                        estoyDibujando = True
                        Exit While
                    End If
                End While
                Reader.Close()
                If estoyDibujando Then
                    RecienAsignado = True
                    BackgroundWorker1.ReportProgress(1)
                Else
                    'Si si hay entonces...
                    If bHayAlguienDibujando Then
                        terminoPartida = False
                        'Leemos Base de datos para sacar nuestras instrucciones
                        sQRY = "SELECT * FROM instrucciones WHERE idUsuario='" + idJugador.ToString() + "'"
                        Dim qryCommand2 As New MySqlCommand(sQRY, connection2)
                        Dim Reader2 As MySqlDataReader
                        Reader2 = qryCommand2.ExecuteReader()
                        Dim id As String
                        id = ""
                        'guardamos en string -> comandoDibujo
                        While Reader2.Read()
                            comandoDibujo = Reader2(1)
                            'Enviamos progreso del backgroundWorker
                            BackgroundWorker1.ReportProgress(1)
                            'Eliminamos de la base de datos
                            id = Reader2(0).ToString()
                        End While
                        Reader2.Close()

                        If Not id = "" Then
                            sQRY = "DELETE FROM instrucciones WHERE idInstruccion='" + id + "'"
                            Dim qryCommandEx1 As New MySqlCommand(sQRY, connection2)
                            qryCommandEx1.ExecuteNonQuery()
                        End If

                        'Restamos Tiempo
                        'TiempoRestante -= 1
                        sQRY = "SELECT * FROM Tiempo"
                        Dim qryCommandN As New MySqlCommand(sQRY, connection2)
                        Dim ReaderN As MySqlDataReader
                        ReaderN = qryCommandN.ExecuteReader()

                        While ReaderN.Read()
                            TiempoRestante = Convert.ToInt32(ReaderN(0).ToString())
                        End While
                        ReaderN.Close()

                        BackgroundWorker1.ReportProgress(1)
                        If TiempoRestante <= 0 Then
                            'Revisamos si ahora estoy dibujando
                            sQRY = "SELECT * FROM usuarios WHERE idUsuario='" + idJugador.ToString() + "'"
                            Dim qryCommand3 As New MySqlCommand(sQRY, connection2)
                            Dim Reader3 As MySqlDataReader
                            Reader3 = qryCommand3.ExecuteReader()

                            'guardamos en string -> comandoDibujo
                            While Reader3.Read()
                                If Reader3(3).ToString = "1" Then
                                    estoyDibujando = True
                                    'TiempoRestante = 30
                                    RecienAsignado = True
                                    sDibujo = ""
                                    Reader3.Close()
                                    BackgroundWorker1.ReportProgress(1)
                                    Exit While
                                Else
                                    'TiempoRestante = 30
                                    RecienAsignado = True
                                    BackgroundWorker1.ReportProgress(1)
                                    Reader3.Close()
                                    Exit While
                                End If
                            End While
                        End If
                    Else
                        terminoPartida = True
                        BackgroundWorker1.ReportProgress(1)
                        Exit While
                    End If
                End If
            End If
            Threading.Thread.Sleep(1000)
        End While
        connection2.Close()
        e.Cancel = True
    End Sub

    Private Sub Btnadivinar_Click(sender As Object, e As EventArgs) Handles btnadivinar.Click
        sDibujo = txtDibujo.Text
        If (connection.State = ConnectionState.Closed) Then
            connection.Open()
        End If
        'Verificamos que lo haya adivinado
        Dim sQRY As String = "SELECT * FROM dibujos WHERE descripcion='" + sDibujo + "' AND actual='1'"
        Dim qryCommand As New MySqlCommand(sQRY, connection)

        Dim Reader As MySqlDataReader

        Reader = qryCommand.ExecuteReader()

        Dim bCoincidencia As Boolean
        bCoincidencia = False

        While Reader.Read()
            bCoincidencia = True
        End While
        Reader.Close()
        connection.Close()

        If (connection.State = ConnectionState.Closed) Then
            connection.Open()
        End If

        If bCoincidencia Then
            'Actualizamos la tabla de partidas para indicar que ganó
            sQRY = "UPDATE partidas SET idUsuario = '" + idJugador.ToString() + "', puntos = '10' WHERE terminada = '0' AND idUsuario = '0'"
            Dim qryCommandEx As New MySqlCommand(sQRY, connection)
            qryCommandEx.ExecuteNonQuery()
            MessageBox.Show("Adivinaste el dibujo!")
            btnadivinar.Enabled = False
        Else
            MessageBox.Show("Erroneo")
        End If
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        'Actualizamos los controles, ejecutamos comandos, etc
        lblTiempoRestante.Text = TiempoRestante.ToString()
        If RecienAsignado Then
            If estoyDibujando Then
                txtDibujo.Text = ""
                RecienAsignado = False
                btnadivinar.Enabled = False
                txtDibujo.Enabled = False
                sDibujo = ""
                txtcmd.Enabled = True
                btnejecutar.Enabled = True
                txtcmd.Text = "limpiar<>"
                btnejecutar.PerformClick()
            Else
                RecienAsignado = False
                btnadivinar.Enabled = True
                txtDibujo.Enabled = True
                txtDibujo.Text = ""
                txtcmd.Text = ""
                txtcmd.Enabled = False
                btnejecutar.Enabled = False
                txtcmd.Text = "limpiar<>"
                btnejecutar.PerformClick()
            End If
        Else
            If estoyDibujando Then
                RecienAsignado = False
                btnadivinar.Enabled = False
                txtDibujo.Enabled = False
                txtDibujo.Text = sDibujo
                txtcmd.Enabled = True
                btnejecutar.Enabled = True
            Else
                If Not comandoDibujo = "" Then
                    ejecutar(comandoDibujo)
                    comandoDibujo = ""
                End If
            End If
        End If
        If terminoPartida Then
            'Terminamos BackgroundWorker
            BackgroundWorker1.CancelAsync()
        End If
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Me.Hide()
        Dim MisResultados As New Resultados
        MisResultados.ShowDialog(Me)
        MisResultados.Dispose()
    End Sub
End Class
