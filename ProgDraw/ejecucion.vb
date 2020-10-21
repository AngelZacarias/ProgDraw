Imports System
Imports System.IO
Imports System.Collections

Module ejecucion

    Public Sub ejecutar(ByVal cadena)
        Dim cmd As String = ""
        Dim i As Integer = 0
        cmd = Trim(cadena) 'Guardamos el comando sin espacios iniciales o finales
        Dim filtro As String = ""
        Dim comando As String = "" 'Variable para guardar solo comando
        Form1.archivoabierto = 0
        Form1.parametro = ""
        Dim er2 As Integer
        Dim er As Integer = 0
        Try
            'Quitamos espacios
            For i = 0 To Len(cmd) - 1
                If (cmd(i) <> " ") Then
                    filtro = filtro + cmd(i)
                End If
            Next

            'Tomamos comando
            i = 0
            While filtro(i) <> "<" And i <> Len(filtro)
                If (i = Len(filtro) - 1) Then
                    er = 1
                Else
                    comando = comando + filtro(i)
                End If

                i = i + 1
            End While

            i = i + 1

            'Tomamos parametro
            While filtro(i) <> ">" And i <> Len(filtro)
                If (i = Len(filtro) - 1) Then
                    er = 2
                Else
                    Form1.parametro = Form1.parametro + filtro(i)
                End If
                i = i + 1
            End While

            'Compureba que tenga parametro valido
            If (Form1.parametro <> "" Or comando = "limpiar" Or comando = "ayuda" Or comando = "procedimientos" Or comando = "programa") Then
                Dim PuntosDeLineas As New Form1.PointOfLines 'Lista puntos de lineas
                PuntosDeLineas.lapiz = New Pen(Form1.col, Form1.gr)
                Dim x1 As Integer = Form1.PBcursor.Location.X 'Posicion x de la imagen
                Dim y1 As Integer = Form1.PBcursor.Location.Y + 16 'Posicion y de la imagen tomando en cuenta la punta
                Dim yabs As Integer = Form1.PBcursor.Location.Y 'Posicion y de la imagen absoluta
                Dim yfinal As Integer = Form1.PBcursor.Location.Y
                Dim xfinal As Integer = Form1.PBcursor.Location.X
                Dim Paneldibujo As Graphics = Form1.Panel1.CreateGraphics 'Hacemos el panel un grafico
                PuntosDeLineas.initialPos = New Point(x1, y1)
                Select Case comando
                    Case "arriba"
                        Form1.PBcursor.Location = New Point(x1, yabs - Form1.parametro)
                        yfinal = Form1.PBcursor.Location.Y + 16 'Punto final del cursor
                        Paneldibujo.DrawLine(PuntosDeLineas.lapiz, x1, y1, xfinal, yfinal)
                        PuntosDeLineas.finpos = New Point(xfinal, yfinal)
                        Form1.ListBoxinstrucciones.Items.Add(comando + "<" + Form1.parametro + ">")
                        Form1.PuntosEnLista.Add(PuntosDeLineas)
                        Form1.Panel1.Invalidate()
                        Form1.txtcmd.Clear()
                        Form1.txtcmd.Focus()
                    Case "abajo"
                        Form1.PBcursor.Location = New Point(x1, yabs + Form1.parametro)
                        yfinal = Form1.PBcursor.Location.Y + 16 'Punto final del cursor
                        Paneldibujo.DrawLine(PuntosDeLineas.lapiz, x1, y1, xfinal, yfinal)
                        PuntosDeLineas.finpos = New Point(xfinal, yfinal)
                        Form1.ListBoxinstrucciones.Items.Add(comando + "<" + Form1.parametro + ">")
                        Form1.PuntosEnLista.Add(PuntosDeLineas)
                        Form1.Panel1.Invalidate()
                        Form1.txtcmd.Clear()
                        Form1.txtcmd.Focus()
                    Case "derecha"
                        Form1.PBcursor.Location = New Point(x1 + Form1.parametro, yabs)
                        xfinal = Form1.PBcursor.Location.X 'Punto final del cursor
                        yfinal = y1
                        Paneldibujo.DrawLine(PuntosDeLineas.lapiz, x1, y1, xfinal, yfinal)
                        PuntosDeLineas.finpos = New Point(xfinal, yfinal)
                        Form1.ListBoxinstrucciones.Items.Add(comando + "<" + Form1.parametro + ">")
                        Form1.PuntosEnLista.Add(PuntosDeLineas)
                        Form1.Panel1.Invalidate()
                        Form1.txtcmd.Clear()
                        Form1.txtcmd.Focus()
                    Case "izquierda"
                        Form1.PBcursor.Location = New Point(x1 - Form1.parametro, yabs)
                        xfinal = Form1.PBcursor.Location.X 'Punto final del cursor
                        yfinal = y1
                        Paneldibujo.DrawLine(PuntosDeLineas.lapiz, x1, y1, xfinal, yfinal)
                        PuntosDeLineas.finpos = New Point(xfinal, yfinal)
                        Form1.ListBoxinstrucciones.Items.Add(comando + "<" + Form1.parametro + ">")
                        Form1.PuntosEnLista.Add(PuntosDeLineas)
                        Form1.Panel1.Invalidate()
                        Form1.txtcmd.Clear()
                        Form1.txtcmd.Focus()
                    Case "limpiar"
                        Form1.PBcursor.Location = New Point(456, 179)
                        Form1.PuntosEnLista.Clear()
                        Form1.Panel1.Refresh()
                        Form1.ListBoxinstrucciones.Items.Clear()
                        Form1.ListBoxinstrucciones.Items.Add(comando + "<>")
                        Form1.txtcmd.Clear()
                        Form1.txtcmd.Focus()
                    Case "moverx"
                        Form1.PBcursor.Location = New Point(Form1.parametro, Form1.PBcursor.Location.Y)
                        Form1.ListBoxinstrucciones.Items.Add(comando + "<" + Form1.parametro + ">")
                        Form1.txtcmd.Clear()
                        Form1.txtcmd.Focus()
                    Case "movery"
                        Form1.PBcursor.Location = New Point(Form1.PBcursor.Location.X, Form1.parametro)
                        Form1.ListBoxinstrucciones.Items.Add(comando + "<" + Form1.parametro + ">")
                        Form1.txtcmd.Clear()
                        Form1.txtcmd.Focus()
                    Case "color"
                        'cambiar el color de la pluma, agregar switch case para seleccionar colores predeterminados
                        Select Case Form1.parametro
                            Case 1
                                Form1.colores = New Pen(Color.Black)
                                Form1.col = Color.Black
                            Case 2
                                Form1.colores = New Pen(Color.Blue)
                                Form1.col = Color.Blue
                            Case 3
                                Form1.colores = New Pen(Color.Red)
                                Form1.col = Color.Red
                            Case 4
                                Form1.colores = New Pen(Color.Orange)
                                Form1.col = Color.Orange
                            Case 5
                                Form1.colores = New Pen(Color.Purple)
                                Form1.col = Color.Purple
                            Case 6
                                Form1.colores = New Pen(Color.Pink)
                                Form1.col = Color.Pink
                            Case 7
                                Form1.colores = New Pen(Color.DeepSkyBlue)
                                Form1.col = Color.DeepSkyBlue
                            Case 8
                                Form1.colores = New Pen(Color.Green)
                                Form1.col = Color.Green
                            Case 9
                                Form1.colores = New Pen(Color.SeaShell)
                                Form1.col = Color.SeaShell
                            Case 0
                                Form1.colores = New Pen(Color.White)
                                Form1.col = Color.White
                        End Select
                        'Form1.LineShape1.BorderColor = Form1.col
                        Form1.ListBoxinstrucciones.Items.Add(comando + "<" + Form1.parametro + ">")
                        Form1.txtcmd.Clear()
                        Form1.txtcmd.Focus()
                        Form1.Panel1.Invalidate()
                    Case "ayuda"
                        ayuda.ShowDialog()
                    Case "grosor"
                        Form1.gr = Form1.parametro
                        Select Case Form1.parametro
                            Case 1
                                Form1.colores = New Pen(Form1.col, 1)
                                'Form1.LineShape1.BorderWidth = Form1.gr
                            Case 2
                                Form1.colores = New Pen(Form1.col, 2)
                                'Form1.LineShape1.BorderWidth = Form1.gr
                            Case 3
                                Form1.colores = New Pen(Form1.col, 3)
                                'Form1.LineShape1.BorderWidth = Form1.gr
                            Case 4
                                Form1.colores = New Pen(Form1.col, 4)
                               'Form1.LineShape1.BorderWidth = Form1.gr
                            Case 5
                                Form1.colores = New Pen(Form1.col, 5)
                                'Form1.LineShape1.BorderWidth = Form1.gr
                            Case 6
                                Form1.colores = New Pen(Form1.col, 6)
                                'Form1.LineShape1.BorderWidth = Form1.gr
                            Case 7
                                Form1.colores = New Pen(Form1.col, 7)
                                'Form1.LineShape1.BorderWidth = Form1.gr
                            Case 8
                                Form1.colores = New Pen(Form1.col, 8)
                                'Form1.LineShape1.BorderWidth = Form1.gr
                            Case 9
                                Form1.colores = New Pen(Form1.col, 9)
                                'Form1.LineShape1.BorderWidth = Form1.gr
                            Case 10
                                Form1.colores = New Pen(Form1.col, 10)
                                'Form1.LineShape1.BorderWidth = Form1.gr
                        End Select
                        Form1.ListBoxinstrucciones.Items.Add(comando + "<" + Form1.parametro + ">")
                        Form1.txtcmd.Clear()
                        Form1.txtcmd.Focus()
                        'Me.Panel1.Invalidate()
                    Case "procedimientos"
                        procedimintos.ShowDialog()
                    Case "programa"
                        compilador.ShowDialog()
                    Case "nprocedimiento"
                        Form1.archivoabierto = 2
                        procedimintos.ShowDialog()
                    Case "aprocedimiento"
                        Form1.arrText.Clear()
                        Try
                            Dim objReader As New StreamReader(Application.StartupPath & "\procedimientos\" & Form1.parametro & ".txt")
                            Do
                                Form1.sLine = objReader.ReadLine()
                                If Not Form1.sLine Is Nothing Then
                                    Form1.arrText.Add(Form1.sLine)
                                End If
                            Loop Until Form1.sLine Is Nothing
                            objReader.Close()
                            Form1.archivoabierto = 1
                            procedimintos.ShowDialog()
                        Catch ex As Exception
                            MsgBox("El procedimiento no existe", MsgBoxStyle.Critical, "ERROR")
                        End Try

                    Case "eprocedimiento"
                        Try
                            My.Computer.FileSystem.DeleteFile(
                          Application.StartupPath & "\procedimientos\" & Form1.parametro & ".txt",
                          FileIO.UIOption.AllDialogs,
                          FileIO.RecycleOption.SendToRecycleBin,
                          FileIO.UICancelOption.DoNothing)
                            Form1.txtcmd.Text = ""
                        Catch ex As Exception
                            MsgBox("El procedimiento no existe", MsgBoxStyle.Critical, "ERROR")
                        End Try
                    Case "ejecutar"

                        Form1.arrText.Clear()


                        Try
                            Dim objReader As New StreamReader(Application.StartupPath & "\procedimientos\" & Form1.parametro & ".txt")
                            Do
                                Form1.sLine = objReader.ReadLine()
                                If Not Form1.sLine Is Nothing Then
                                    Form1.arrText.Add(Form1.sLine)
                                End If
                            Loop Until Form1.sLine Is Nothing
                            objReader.Close()
                            For Each Form1.sLine In Form1.arrText
                                If (Form1.sLine <> "" And er2 = 0) Then
                                    ejecutar(Form1.sLine)
                                End If
                            Next
                        Catch ex As Exception
                            MsgBox("El procedimiento no existe", MsgBoxStyle.Critical, "ERROR")
                        End Try
                    Case Else
                        MsgBox("Error, ese comando no existe")
                        Form1.txtcmd.Clear()
                        Form1.txtcmd.Focus()
                End Select
                Form1.ListBoxinstrucciones.SelectedIndex = Form1.ListBoxinstrucciones.Items.Count - 1
            Else
                If (Form1.parametro = "") Then
                    MsgBox("Error, falta el parametro")
                    Form1.txtcmd.Focus()
                Else
                    MsgBox("Error, parametro invalido")
                    Form1.txtcmd.Focus()
                End If
            End If

        Catch ex As Exception 'Errores
            er2 = er
            Select Case er
                Case 0
                    MsgBox("Error, ingrese comando")
                    Form1.txtcmd.Focus()
                Case 1
                    MsgBox("Error, falta ""<"" para el parametro")
                    Form1.txtcmd.Focus()
                Case 2
                    MsgBox("Error, falta "">"" para el parametro")
                    Form1.txtcmd.Focus()
            End Select

        End Try
    End Sub
End Module
