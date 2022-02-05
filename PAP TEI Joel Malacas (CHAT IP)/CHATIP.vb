Imports System.IO
Imports System.Net.Dns
Imports System.Net
Imports System.Text
Imports Tulpep.NotificationWindow
Imports System.ComponentModel
Imports System.Net.Sockets
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO.FileNotFoundException
Imports System.ComponentModel.Win32Exception
Imports System.Diagnostics


Public Class frmCHATIP
    Private Const APP_NAME As String = "CHAT IP"
    Private TabTipProcess As Process
    WithEvents SendSock As New Winsock2005DLL.Winsock
    WithEvents ReceiveSock As New Winsock2005DLL.Winsock
    Dim resposta As Integer
    Dim client As New TcpClient
    Dim nstream As NetworkStream
    Private tdbConfig As Object
    Private WithEvents NIcon As New NotifyIcon

    Public Class ObtemIP
        <Obsolete>
        Shared Function ObtemEnderecoIP() As String
            Dim oEndereco As System.Net.IPAddress
            Dim sEndereco As String
            With GetHostByName(GetHostName)
                oEndereco = New System.Net.IPAddress(.AddressList(0).Address)
                sEndereco = oEndereco.ToString
            End With
            ObtemEnderecoIP = sEndereco
        End Function
        Private Function GetMyIP() As IPAddress
            Using wc As New WebClient
                Return IPAddress.Parse(Encoding.ASCII.GetString(wc.DownloadData("http://ipinfo.io/")))
            End Using
        End Function
    End Class

    Private Sub btnsair_Click(sender As Object, e As EventArgs) Handles btnsair.Click
        resposta = MsgBox("Tem a certeza que quer sair do programa?", vbYesNo + vbQuestion + vbDefaultButton2, "SAIR")
        If resposta = vbYes Then
            Try
                RichTextCHAT.Text = RichTextCHAT.Text & "<" & Now & ">" & textNome.Text & ":" & "desconectou-se"
                SendSock.Send(RichTextCHAT.Text)
                '-------DISCONECTADO---
                MUSIC_DISCONNECTED()
                '----------------------
                textCHAT.Clear()
                NOTIF_SCROLL()
                Me.SendSock.Close()
                Me.ReceiveSock.Close()
                End
            Catch ex As Exception
                MUSIC_DISCONNECTED()
                Me.SendSock.Close()
                Me.ReceiveSock.Close()
                Application.Exit()
            End Try
            Application.Exit()
        End If
    End Sub

    Private Sub btnmenu_Click(sender As Object, e As EventArgs) Handles btnmenu.Click
        resposta = MsgBox("Tem a certeza que quer ir para o Menu principal?", vbYesNo + vbQuestion + vbDefaultButton2, "SAIR PARA MENU")
        If resposta = vbYes Then
            Me.Hide()
            frmMenu.Show()
            My.Computer.FileSystem.WriteAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\verify.txt", "NO", False)
        End If
    End Sub

    Private Sub frmCHATIP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        textporta.Enabled = False
        RichTextCHAT.Enabled = True
        lbloffline.Visible = True
        lblonline.Visible = False
        lblwait.Visible = False
        textConPorta.Visible = True
        textporta.Visible = True
        Label1.Visible = True
        btnligar.Visible = True
        btnDisconnect.Visible = False
        textConPorta.Visible = False
        textporta.Visible = False
        Label1.Visible = False
        Label4.Visible = False
        textCPIP.Visible = True
        btnenviar.Visible = False
        textNome.ReadOnly = True
        textCPIP.ReadOnly = True
        tmrUPDATE.Start()
        '-----------------------------------------
        textporta.MaxLength = 4
        textporta.Text = 9987
        textConPorta.Text = 9987
        '-----------------------------------------
        textNome.Text = System.Environment.UserName
        textCPIP.Text = GetHostName()
        '----------------------Programar a porta para comunicar--------------------------------------
        Try
            ReceiveSock.Listen(Val(textporta.Text))
            lblwait.Visible = True
            lbloffline.Visible = False
            lblonline.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
            lblwait.Visible = False
            lblonline.Visible = False
            lbloffline.Visible = True
        End Try
        If textporta.Text = "" Then
            MsgBox("Insira uma porta Aleatoriamente clicando no botão onde diz: Adiconar Porta automaticamente, de seguida clique em ligar a porta e conectar.", vbOKOnly + vbCritical + vbDefaultButton1, "ERRO")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        '----------------------Programar a porta para comunicar--------------------------------------
        Try
            ReceiveSock.Listen(Val(textporta.Text))
            lblwait.Visible = True
            lbloffline.Visible = False
            lblonline.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
            lblwait.Visible = False
            lblonline.Visible = False
            lbloffline.Visible = True
        End Try
        If textporta.Text = "" Then
            MsgBox("Insira uma porta Aleatoriamente clicando no botão onde diz: Adiconar Porta automaticamente, de seguida clique em ligar a porta e conectar.", vbOKOnly + vbCritical + vbDefaultButton1, "ERRO")
        End If
    End Sub

    <Obsolete>
    Private Sub ReceiveSock_ConnectionRequest(sender As Object, e As Winsock2005DLL.WinsockClientReceivedEventArgs) Handles ReceiveSock.ConnectionRequest
        Dim DNS As String = "192.168.1.131"
        Dim resposta As Integer
        resposta = MsgBox("Detetamos que um dispositivo quer comunicar, ACEITA?", vbYesNo + vbInformation + vbDefaultButton1, "CONFIRMAÇÃO")
        If resposta = vbYes Then
            Try
                ReceiveSock.Accept(e.Client)
                If My.Computer.Network.Ping(DNS) Then
                    textIP.Text = My.Computer.FileSystem.ReadAllText("\\192.168.1.131\Users\Public\Documents\connectionTCPIP.txt")
                    If My.Computer.Network.Ping(textIP.Text) Then
                        '----
                        lblonline.Visible = True
                        lbloffline.Visible = False
                        lblwait.Visible = False
                        '----MUSICA CONNECTED----
                        MUSIC_CONNECTED()
                        '------------------------
                        MsgBox("Conexção Concluída." + vbNewLine + "--> " + textIP.Text, vbOKOnly + vbInformation + vbDefaultButton1, "Informação")
                    Else
                        RichTextCHAT.Text = "Não foi possível conectar: " + textIP.Text + " devido a não ter conseguido mandar dados" + vbNewLine
                        MUSIC_CONNECTIONLOST()
                        lblonline.Visible = False
                        lbloffline.Visible = True
                        lblwait.Visible = False
                        btnligar.Visible = False
                        btnDisconnect.Visible = True
                    End If
                Else
                    MsgBox("Não foi possível, transmitir o DNS para o dispositivo!!!", vbOKOnly + vbInformation + vbDefaultButton1, "INFO.exe")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Me.SendSock.Close()
            Me.ReceiveSock.Close()
            lbloffline.Visible = True
            lblonline.Visible = False
            lblwait.Visible = False
            '--
            btnDisconnect.Visible = False
            btnligar.Visible = True
            btnligar.Enabled = False
            '--
            MsgBox("Erro ao conectar com o Dispositivo!", vbOKOnly + vbCritical + vbDefaultButton1, "ERRO")
        End If
    End Sub

    Private Sub ReceiveSock_DataArrival(sender As Object, e As Winsock2005DLL.WinsockDataArrivalEventArgs) Handles ReceiveSock.DataArrival
        Dim DataReceived As String = " "
        Dim noti = My.Computer.FileSystem.ReadAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\notificacao.txt")
        Dim hidden = My.Computer.FileSystem.ReadAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\notificacao.txt")
        '-------------------------------------------------------------
        Try
            '-----------
            If noti = "YES" Then
                NIcon.Icon = Me.Icon
                NIcon.Visible = True
                NIcon.Text = "Recebeste uma nova mensagem!!!"
                DisparaInfo()
            End If
            '-----------
            ReceiveSock.Get(DataReceived)
            RichTextCHAT.Text = DataReceived & vbNewLine
            MUSIC_MENSAGEM_IN()
            NOTIF_SCROLL()
        Catch ex As Exception
            MUSIC_CONNECTIONLOST()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub textCHAT_keyPressed(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textCHAT.KeyPress
        Dim Nome As String = ":"
        Dim nada As String = " "
        Dim resposta As Integer
        Dim IP As String = ""
        If AscW(e.KeyChar) = 13 Then
            Try
                If textCHAT.Text = "" Then
                    MsgBox("ERRO AO ENVIAR MENSAGEM DEVIDO A NÃO TER NENHUM CONTEXTO!!!", vbOKOnly + vbCritical + vbDefaultButton2, "ERRO")
                Else
                    RichTextCHAT.Text = RichTextCHAT.Text & "<" & Now & ">" & " " & textNome.Text & Nome & nada & textCHAT.Text & vbNewLine
                    SendSock.Send(RichTextCHAT.Text)
                    textCHAT.Clear()
                    NOTIF_SCROLL()
                    MUSIC_MENSAGEM_OUT()
                End If
                e.Handled = True
            Catch ex As Exception
                MUSIC_CONNECTIONLOST()
                RichTextCHAT.Clear()
                MsgBox(ex.Message)
            End Try
        End If
        '-----------------------------------------------------------------------------------------------------------
        If textCHAT.Text = "/clear" Then
            RichTextCHAT.Clear()
        ElseIf textCHAT.Text = "/exit" Then
            resposta = MsgBox("Tem a certeza que quer sair?", vbYesNo + vbQuestion + vbDefaultButton2, "SAIR")
            If resposta = vbYes Then
                Try
                    MUSIC_DISCONNECTED()
                    SendSock.Send(RichTextCHAT.Text)
                    RichTextCHAT.Text = RichTextCHAT.Text & "<" & Now & ">" & textNome.Text & Nome & nada & "desconectou-se"
                    textCHAT.Clear()
                    NOTIF_SCROLL()
                    End
                Catch ex As Exception
                    MUSIC_CONNECTIONLOST()
                    MsgBox(ex.Message)
                    Application.Exit()
                End Try
            End If
        End If
    End Sub

    Private Sub RichTextCHAT_TextChanged(sender As Object, e As EventArgs) Handles RichTextCHAT.TextChanged
        Dim Nome As String = ":"
        Dim nada As String = " "
        '-------------------------------------------------------------------------------------------------------
        If textCHAT.Text = "/clear" Then
            RichTextCHAT.Clear()
        ElseIf textCHAT.Text = "/exit" Then
            resposta = MsgBox("Tem a certeza que quer sair?", vbYesNo + vbQuestion + vbDefaultButton2, "SAIR")
            If resposta = vbYes Then
                Try
                    MUSIC_DISCONNECTED()
                    RichTextCHAT.Text = RichTextCHAT.Text & "<" & Now & ">" & " " & textNome.Text & ":" & " " & "desconectou-se"
                    SendSock.Send(RichTextCHAT.Text)
                    NOTIF_SCROLL()
                    textCHAT.Clear()
                    End
                Catch ex As Exception
                    MUSIC_CONNECTIONLOST()
                    MsgBox(ex.Message)
                    Application.Exit()
                End Try
            End If
        ElseIf textCHAT.Text = "/disconnect" Then
            Try
                SendSock.Send(RichTextCHAT.Text)
                RichTextCHAT.Text = RichTextCHAT.Text & "<" & Now & ">" & textNome.Text & Nome & nada & "desconectou-se"
                NOTIF_SCROLL()
                textCHAT.Clear()
                MUSIC_DISCONNECTED()
                Me.SendSock.Close()
                Me.ReceiveSock.Close()
                Application.Restart()
            Catch ex As Exception
                MUSIC_CONNECTIONLOST()
                MsgBox(ex.Message)
                Application.Exit()
            End Try
        End If
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btnligar.Click
        '----------------------Programar a Ligação---------------------------------------------------    
        Try
            SendSock.Connect(textIP.Text, textConPorta.Text)
            lblonline.Visible = True
            lbloffline.Visible = False
            lblwait.Visible = False
            btnligar.Visible = False
            btnDisconnect.Visible = True
            My.Computer.FileSystem.WriteAllText("\\192.168.1.131\Users\Public\Documents\connectionTCPIP.txt", textCPIP.Text, False)
        Catch ex As Exception
            MsgBox(ex.Message)
            textCHAT.Clear()
            RichTextCHAT.Text = "Não foi possível conectar ao endereço IP: " + textIP.Text + " esperado" + vbNewLine
        End Try
        '--------------------------------------------------------------------------------------------
        If textIP.Text = "" Or textporta.Text = "" Or textConPorta.Text = "" Then
            MsgBox("A porta ou o endereço IP não são válidos ou não estão introduzidos, por favor introduza uma porta ou um endereço válido, e tente novamente.", vbOKOnly + vbCritical + vbDefaultButton1, "ERRO")
        End If
    End Sub

    Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
        Dim resposta As Integer
        resposta = MsgBox("Deseja encerrar o programa?", vbYesNo + vbQuestion + vbDefaultButton2, "END.exe")
        If resposta = vbYes Then
            Try
                RichTextCHAT.Text = RichTextCHAT.Text & "<" & Now & ">" & " " & textNome.Text & ":" & " " & "desconectou-se"
                SendSock.Send(RichTextCHAT.Text)
                '------MUSICA DISCONNECT----
                MUSIC_DISCONNECTED()
                '---------------------------
                textCHAT.Clear()
                NOTIF_SCROLL()
                Application.Exit()
            Catch ex As Exception
                MUSIC_CONNECTIONLOST()
                Application.Exit()
            End Try
        Else
            Try
                RichTextCHAT.Text = RichTextCHAT.Text & "<" & Now & ">" & " " & textNome.Text & ":" & " " & "desconectou-se"
                SendSock.Send(RichTextCHAT.Text)
                '------MUSICA DISCONNECT----
                MUSIC_DISCONNECTED()
                '---------------------------
                textCHAT.Clear()
                NOTIF_SCROLL()
                Application.Restart()
            Catch ex As Exception
                MUSIC_CONNECTIONLOST()
                Application.Restart()
            End Try
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles btnenviar.Click
        '-----------------------Programar Botão enviar e condições-----------------------------------
        Dim Nome As String = ":"
        Dim nada As String = " "
        Dim resposta As Integer
        Try
            If textCHAT.Text = "" Then
                MsgBox("ERRO AO ENVIAR MENSAGEM DEVIDO A NÃO TER NENHUM CONTEXTO!!!", vbOKOnly + vbCritical + vbDefaultButton2, "ERRO")
            Else
                RichTextCHAT.Text = RichTextCHAT.Text & "<" & Now & ">" & " " & textNome.Text & Nome & nada & textCHAT.Text & vbNewLine
                SendSock.Send(RichTextCHAT.Text)
                textCHAT.Clear()
                RichTextCHAT.ScrollToCaret()
            End If
        Catch ex As Exception
            textCHAT.Clear()
            MsgBox(ex.Message)
        End Try
        '-----------------------------------------------------------------------------------------------------------
        If textCHAT.Text = "/clear" Then
            RichTextCHAT.Clear()
        ElseIf textCHAT.Text = "/exit" Then
            resposta = MsgBox("Tem a certeza que quer sair?", vbYesNo + vbQuestion + vbDefaultButton2, "SAIR")
            If resposta = vbYes Then
                Try
                    RichTextCHAT.Text = RichTextCHAT.Text & "<" & Now & ">" & " " & textNome.Text & Nome & nada & "desconectou-se"
                    SendSock.Send(RichTextCHAT.Text)
                    textCHAT.Clear()
                    RichTextCHAT.ScrollToCaret()
                    End
                Catch ex As Exception
                    MsgBox(ex.Message)
                    textCHAT.Clear()
                    End
                End Try
            End If
        End If
    End Sub

    Private Sub btnenviar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnenviar.MouseMove
        Dim Tooltip_info As New ToolTip()
        Tooltip_info.AutoPopDelay = 3000
        Tooltip_info.InitialDelay = 1500
        Tooltip_info.ReshowDelay = 1000
        Tooltip_info.ShowAlways = True
        '----
        Tooltip_info.SetToolTip(Me.btnenviar, "Enviar Mensagem")
        Tooltip_info.SetToolTip(Me.btnguardar, "Guardar Conversa")
        Tooltip_info.SetToolTip(Me.btnOPEN_FILE, "Abrir Conversa")
        Tooltip_info.SetToolTip(Me.btndef, "Definições")
    End Sub

    Private Sub MetroButton1_Click_1(sender As Object, e As EventArgs) Handles btnCHAT.Click
        Dim resposta As Integer
        resposta = MsgBox("Tem a certeza que quer limpar o CHAT?", vbYesNo + vbQuestion + vbDefaultButton2, "LIMPAR")
        If resposta = vbYes Then
            RichTextCHAT.ResetText()
            textCHAT.Clear()
        End If
    End Sub

    Private Sub MetroButton1_Click_2(sender As Object, e As EventArgs) Handles btnOPEN_FILE.Click
        Dim frmConversa As frmConversa = New frmConversa
        Try
            If OpenFileDialog1.ShowDialog = vbCancel Then
                MsgBox("Erro a abrir mensagem", vbOKOnly + vbCritical + vbDefaultButton1, "ERRO")
            Else
                frmConversa.Show()
                frmConversa.txtCHATSAVE.Text = File.ReadAllText(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox("ERRO ao abrir mensagem", vbOKOnly + vbCritical + vbDefaultButton1, "ERRO")
        End Try
    End Sub

    Private Sub MetroButton1_Click_3(sender As Object, e As EventArgs) Handles btnguardar.Click
        '---------------GUARDAR CONVERSA RICH TEXT CHAT PARA TXT--------------------
        Try
            If RichTextCHAT.Text.Length > 0 Then
                SaveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
                SaveFileDialog1.ShowDialog()
                SaveFileDialog1.FilterIndex = 2
                System.IO.File.WriteAllText(SaveFileDialog1.FileName, RichTextCHAT.Text)
            End If
            MsgBox("Guardado com Sucesso!!!", vbOKOnly + vbInformation + vbDefaultButton1, "INFO")
        Catch ex As Exception
            textCHAT.Clear()
            MsgBox("ERRO A GUARDAR A MENSAGEM", vbOKOnly + vbCritical + vbDefaultButton1, "")
        End Try
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles btndef.Click
        Dim frmDEF As frmDEF = New frmDEF
        frmDEF.Show()
    End Sub

    Private Sub textIP_keyPressed(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textIP.KeyPress
        Const DNS = "192.168.1.131"
        Dim Nome As String = ":"
        Dim nada As String = " "
        Dim IP As String = ""
        If AscW(e.KeyChar) = 13 Then
            '----------------------Programar a Ligação---------------------------------------------------    
            Try
                SendSock.Connect(textIP.Text, textConPorta.Text)
                btnligar.Visible = False
                btnDisconnect.Visible = True
                If My.Computer.Network.Ping(DNS) Then
                    My.Computer.FileSystem.WriteAllText("\\192.168.1.131\Users\Public\Documents\connectionTCPIP.txt", textCPIP.Text, False)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            '--------------------------------------------------------------------------------------------
            If textIP.Text = "" Or textporta.Text = "" Or textConPorta.Text = "" Then
                MsgBox("A porta ou o endereço IP não são válidos ou não estão introduzidos, por favor introduza uma porta ou um endereço válido, e tente novamente.", vbOKOnly + vbCritical + vbDefaultButton1, "ERRO")
            End If
        End If
    End Sub

    Private Sub frmCHATIP_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            RichTextCHAT.Text = RichTextCHAT.Text & "<" & Now & ">" & ":" & textNome.Text & " " & "desconectou-se"
            SendSock.Send(RichTextCHAT.Text)
            textCHAT.Clear()
            RichTextCHAT.ScrollToCaret()
            Me.SendSock.Close()
            Me.ReceiveSock.Close()
            '-------MUSIC DISCONNECT-----
            My.Computer.Audio.Play("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\MUSIC\disconnected.wav", AudioPlayMode.Background)
            '----------------------------
            Me.Close()
        Catch ex As Exception
            MUSIC_DISCONNECTED()
            End
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tmrUPDATE_Tick(sender As Object, e As EventArgs) Handles tmrUPDATE.Tick
        Dim notificacao = New PopupNotifier()
        tmrUPDATE.Interval = 100
        If RichTextCHAT.Text.Length < 10 Then
            btnguardar.Enabled = False
        Else
            btnguardar.Enabled = True
        End If
        '----------
        If textCHAT.Text.Length > 0 Then
            btnenviar.Visible = True
        Else
            btnenviar.Visible = False
        End If
        '---------
        If textIP.Text.Length > 7 Then
            picEcra.Enabled = True
        Else
            picEcra.Enabled = False
        End If
    End Sub

    Private Sub MUSIC_CONNECTED()
        My.Computer.Audio.Play("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\MUSIC\connected.wav", AudioPlayMode.Background)
    End Sub

    Private Sub MUSIC_DISCONNECTED()
        My.Computer.Audio.Play("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\MUSIC\disconnected.wav", AudioPlayMode.WaitToComplete)
    End Sub

    Private Sub MUSIC_MENSAGEM_IN()
        My.Computer.Audio.Play("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\MUSIC\chat_message_inbound.wav", AudioPlayMode.Background)
    End Sub

    Private Sub MUSIC_MENSAGEM_OUT()
        My.Computer.Audio.Play("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\MUSIC\chat_message_outbound.wav", AudioPlayMode.Background)
    End Sub

    Private Sub MUSIC_CONNECTIONLOST()
        My.Computer.Audio.Play("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\MUSIC\connection_lost.wav", AudioPlayMode.WaitToComplete)
    End Sub

    Private Sub textCHAT_MouseMove(sender As Object, e As MouseEventArgs) Handles textCHAT.MouseMove
        Dim Tooltip_info As New ToolTip()
        Tooltip_info.AutoPopDelay = 3000
        Tooltip_info.InitialDelay = 1500
        Tooltip_info.ReshowDelay = 1000
        Tooltip_info.ShowAlways = True
        '----
        Tooltip_info.SetToolTip(Me.textCHAT, "DIGITE ALGUMA COISA..." + vbNewLine + "PARA LIMPAR CHAT FAÇA /clear , PARA SAIR FAÇA /sair , PARA DISCONECTAR FAÇA /disconnect")
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles picEcra.Click
        '---OPÇOES PARTILHA DE ECRA-----
        frmPartilha.Show()
    End Sub

    Private Sub picEcra_MouseMove(sender As Object, e As MouseEventArgs) Handles picEcra.MouseMove
        Dim Tooltip_info As New ToolTip()
        Tooltip_info.AutoPopDelay = 3000
        Tooltip_info.InitialDelay = 1500
        Tooltip_info.ReshowDelay = 1000
        Tooltip_info.ShowAlways = True
        '----
        Tooltip_info.SetToolTip(Me.picEcra, "Clique aqui para partilhar ecrã")
    End Sub

    Private Sub NOTIFIC()
        Dim notificacao As New PopupNotifier()
        notificacao.TitleText = "Uma notificação..."
        notificacao.ContentText = "Recebeste uma nova mensagem" & vbNewLine
        notificacao.ShowCloseButton = True
        notificacao.ContentColor = Color.Black
        notificacao.Popup()
    End Sub

    Private Sub tmrNOTIFIC_Tick(sender As Object, e As EventArgs) Handles tmrNOTIFIC.Tick
        tmrNOTIFIC.Stop()
        NOTIFIC()
    End Sub

    Private Sub NOTIF_SCROLL()
        RichTextCHAT.SelectionLength = 0
        RichTextCHAT.SelectionStart = RichTextCHAT.Text.Length
        RichTextCHAT.ScrollToCaret()
    End Sub

    Private Sub DisparaInfo()
        If Me.WindowState = Windows.Forms.FormWindowState.Minimized Then
            NIcon.BalloonTipIcon = ToolTipIcon.Info
            NIcon.BalloonTipTitle = "Recebeste uma nova mensagem!!!"
            NIcon.BalloonTipText = "Nova notificação!!!"
            NIcon.ShowBalloonTip(1500)
        Else
            NIcon.BalloonTipIcon = ToolTipIcon.Info
            NIcon.BalloonTipTitle = "Recebeste uma nova mensagem!!!"
            NIcon.BalloonTipText = "Nova notificação!!!"
            NIcon.ShowBalloonTip(1500)
        End If
    End Sub
End Class
