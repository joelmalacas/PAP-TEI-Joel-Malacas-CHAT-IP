Imports System
Imports System.ComponentModel
Imports System.Net
Imports System.Net.Dns
Imports System.IO

Public Class frmDEF
    Private Const APP_NAME As String = "CHAT IP"
    Private psi As ProcessStartInfo
    Private cmd As Process
    Private Delegate Sub InovekWithString(ByVal text As String)
    '-----------CMD------
    Function ActionNet(ByVal File As String, ByVal text As String)
        Dim Gstart As New Process()
        Gstart.StartInfo.FileName = File
        Gstart.StartInfo.Arguments = text

        Gstart.StartInfo.RedirectStandardError = True
        Gstart.StartInfo.RedirectStandardOutput = True
        Gstart.EnableRaisingEvents = True

        Application.DoEvents()
        Gstart.StartInfo.CreateNoWindow = True
        Gstart.StartInfo.UseShellExecute = False

        AddHandler Gstart.ErrorDataReceived, AddressOf Gstart_OutputData
        AddHandler Gstart.OutputDataReceived, AddressOf Gstart_OutputData

        Gstart.Start()
        Gstart.BeginErrorReadLine()
        Gstart.BeginOutputReadLine()
        Return File
    End Function

    Delegate Sub UpdateTextBoxDelg(ByVal text As String)
    Dim myDelegate As UpdateTextBoxDelg = New UpdateTextBoxDelg(AddressOf UpdateTbox)

    Public Sub UpdateTbox(ByVal text As String)
        frmCMD.textCMD.AppendText(text & System.Environment.NewLine)
    End Sub
    Public Sub Gstart_OutputData(ByVal sender As Object, e As DataReceivedEventArgs)
        If Me.InvokeRequired Then
            Me.Invoke(myDelegate, e.Data)
        Else
            UpdateTbox(e.Data)
        End If
    End Sub

    Private Sub btnfechar_Click(sender As Object, e As EventArgs) Handles btnfechar.Click
        SaveSetting(APP_NAME, "Settings", "Criar atalho no ambiente de trabalho", checkATALHO.Checked)
        Me.Close()
    End Sub

    Private Class frmDEF
        Public frmCHATIP As frmCHATIP
        '-----------CMD------
        Function ActionNet(ByVal File As String, ByVal text As String)
            Dim Gstart As New Process()
            Gstart.StartInfo.FileName = File
            Gstart.StartInfo.Arguments = text

            Gstart.StartInfo.RedirectStandardError = True
            Gstart.StartInfo.RedirectStandardOutput = True
            Gstart.EnableRaisingEvents = True

            Application.DoEvents()
            Gstart.StartInfo.CreateNoWindow = True
            Gstart.StartInfo.UseShellExecute = False

            AddHandler Gstart.ErrorDataReceived, AddressOf Gstart_OutputData
            AddHandler Gstart.OutputDataReceived, AddressOf Gstart_OutputData

            Gstart.Start()
            Gstart.BeginErrorReadLine()
            Gstart.BeginOutputReadLine()
            Return File
        End Function

        Delegate Sub UpdateTextBoxDelg(ByVal text As String)
        Dim myDelegate As UpdateTextBoxDelg = New UpdateTextBoxDelg(AddressOf UpdateTbox)

        Public Sub UpdateTbox(ByVal text As String)
            frmCMD.textCMD.AppendText(text & System.Environment.NewLine)
        End Sub
        Public Sub Gstart_OutputData(ByVal sender As Object, e As DataReceivedEventArgs)
            If Me.InvokeRequired Then
                Me.Invoke(myDelegate, e.Data)
            Else
                UpdateTbox(e.Data)
            End If
        End Sub

        Private Sub Invoke(myDelegate As UpdateTextBoxDelg, data As String)
            Throw New NotImplementedException()
        End Sub

        Private Function InvokeRequired() As Boolean
            Throw New NotImplementedException()
        End Function
    End Class

    Private Sub btnAplic_Click(sender As Object, e As EventArgs) Handles btnAplic.Click
        '-----
        Dim arranque As String = "C:\users\" + System.Environment.UserName + "\Appdata\Roaming\Microsoft\Windows\Start Menu\Programs\Startup"
        Dim user As String = System.Environment.UserName
        Dim WsShell
        Dim DestkopFolder As String = "C:\Users\" + user + "\Desktop"
        Dim FileShortcut
        WsShell = CreateObject("Wscript.Shell")
        DestkopFolder = WsShell.SpecialFolders("Desktop")
        '-----
        Dim passe_verify As String = My.Computer.FileSystem.ReadAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\Passe.txt")
        '---------------------------------------------
        '------------MUDAR COR BACKGROUND DO FRMCHATIP
        If cbcolor.Text = "Vermelho" Then
            frmCHATIP.BackColor = Color.Red
        ElseIf cbcolor.Text = "Amarelo" Then
            frmCHATIP.BackColor = Color.Yellow
        ElseIf cbcolor.Text = "Verde" Then
            frmCHATIP.BackColor = Color.Green
        ElseIf cbcolor.Text = "Cinzento" Then
            frmCHATIP.BackColor = Color.Gray
        ElseIf cbcolor.Text = "Branco" Then
            frmCHATIP.BackColor = Color.White
        ElseIf cbcolor.Text = "Azul" Then
            frmCHATIP.BackColor = Color.Blue
        ElseIf cbcolor.Text = "Azul-Claro" Then
            frmCHATIP.BackColor = Color.SteelBlue
        End If
        '-------------MUDAR COR DO RICHTEXTCHAT----------
        If cbCCHAT.Text = "Vermelho" Then
            frmCHATIP.RichTextCHAT.BackColor = Color.Red
        ElseIf cbCCHAT.Text = "Amarelo" Then
            frmCHATIP.RichTextCHAT.BackColor = Color.Yellow
        ElseIf cbCCHAT.Text = "Verde" Then
            frmCHATIP.RichTextCHAT.BackColor = Color.Green
        ElseIf cbCCHAT.Text = "Cinzento" Then
            frmCHATIP.RichTextCHAT.BackColor = Color.Gray
        ElseIf cbCCHAT.Text = "Branco" Then
            frmCHATIP.RichTextCHAT.BackColor = Color.White
        ElseIf cbCCHAT.Text = "Azul" Then
            frmCHATIP.RichTextCHAT.BackColor = Color.Blue
        ElseIf cbCCHAT.Text = "Preto" Then
            frmCHATIP.RichTextCHAT.BackColor = Color.Black
        End If
        '----------MUDAR A COR DO TEXTO PELA TEXTBOX-------
        If CbNome.Text = "Vermelho" Then
            frmCHATIP.RichTextCHAT.ForeColor = Color.Red
        ElseIf CbNome.Text = "Amarelo" Then
            frmCHATIP.RichTextCHAT.ForeColor = Color.Yellow
        ElseIf CbNome.Text = "Verde" Then
            frmCHATIP.RichTextCHAT.ForeColor = Color.Green
        ElseIf CbNome.Text = "Cinzento" Then
            frmCHATIP.RichTextCHAT.ForeColor = Color.Gray
        ElseIf CbNome.Text = "Branco" Then
            frmCHATIP.RichTextCHAT.ForeColor = Color.White
        ElseIf CbNome.Text = "Azul" Then
            frmCHATIP.RichTextCHAT.ForeColor = Color.Blue
        ElseIf CbNome.Text = "Preto" Then
            frmCHATIP.RichTextCHAT.ForeColor = Color.Black
        End If
        '-------------MUDAR TEMA ESCURO // CLARO----------
        If cbtema.Text = "Modo escuro" Then
            frmCHATIP.BackColor = Color.Gray
        ElseIf cbtema.Text = "Modo Claro" Then
            frmCHATIP.BackColor = Color.WhiteSmoke
        ElseIf cbtema.Text = "Nenhum" Then
            frmCHATIP.BackColor = Color.SteelBlue
        End If
        '--------------CRIAR NOME PERSONALIZADO------------
        Try
            If seguranca.Checked = True And passe_verify = "NOPASS" Then
                My.Computer.FileSystem.WriteAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\certificado.txt", "yes", False)
                frmMUDAR_PASS.Show()
            Else
                frmMUDAR_PASS.Hide()
                btnAlterar.Enabled = False
                My.Computer.FileSystem.WriteAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\certificado.txt", "no", False)
            End If
            '--------------------------------------------
            If textPERSONAL_NOME.Text = "" Then
                frmCHATIP.textNome.Text = System.Environment.UserName
            Else
                frmCHATIP.textNome.Text = textPERSONAL_NOME.Text
            End If
            If seguranca.Checked = True Then
                frmMUDAR_PASS.Show()
            End If
            MsgBox("Alteração com Sucesso!", vbOKOnly + vbInformation + vbDefaultButton1, "Alteração com Sucesso!")
        Catch ex As Exception
            MsgBox("ERRO AO ALTERAR NOME", vbOKOnly + vbCritical + vbDefaultButton1, "ERRO_NOME")
        End Try
        '-----ATALHO----
        If checkATALHO.Checked = True Then
            FileShortcut = WsShell.CreateShortcut(DestkopFolder & "\PAP TEI Joel Malacas (CHAT IP) - Atalho.lnk")
            FileShortcut.TargetPath = "C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\bin\Debug\PAP TEI Joel Malacas (CHAT IP) - Atalho.lnk"
            FileShortcut.IconLocation = "C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\imagens\ip_network_outline_icon_139439.ico"
            FileShortcut.Hotkey = "CTRL+ALT+R"
            FileShortcut.Save
            My.Computer.FileSystem.WriteAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\Atalho.txt", "TRUE", False)
        Else
            My.Computer.FileSystem.WriteAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\Atalho.txt", "FALSE", False)
            File.Delete("C:\Users\" + user + "\Desktop\PAP TEI Joel Malacas (CHAT IP) - Atalho.lnk")
        End If
        '---------------
        If checkArranque.Checked = True Then
            FileShortcut = WsShell.CreateShortcut(arranque & "\PAP TEI Joel Malacas (CHAT IP) - Atalho.lnk")
            FileShortcut.TargetPath = "C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\bin\Debug\PAP TEI Joel Malacas (CHAT IP) - Atalho.lnk"
            FileShortcut.IconLocation = "C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\imagens\ip_network_outline_icon_139439.ico"
            FileShortcut.Hotkey = "CTRL+ALT+R"
            FileShortcut.Save
            My.Computer.FileSystem.WriteAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\arranque.txt", "TRUE", False)
        Else
            My.Computer.FileSystem.WriteAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\arranque.txt", "FALSE", False)
            File.Delete(arranque + "\PAP TEI Joel Malacas (CHAT IP) - Atalho.lnk")
        End If
        '---------------
        If checkNOTIFIC.Checked = True Then
            My.Computer.FileSystem.WriteAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\notificacao.txt", "YES", False)
        Else
            My.Computer.FileSystem.WriteAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\notificacao.txt", "NO", False)
        End If
    End Sub

    Private Sub btndefault_Click(sender As Object, e As EventArgs) Handles btndefault.Click
        Dim resposta As Integer
        resposta = MsgBox("Tem a certeza que quer pôr as definições no default?", vbYesNo + vbQuestion + vbDefaultButton2, "INFO")
        If resposta = vbYes Then
            cbCCHAT.Text = "Branco"
            cbcolor.Text = "Azul-Claro"
            CbNome.Text = "Preto"
            cbtema.Text = "Nenhum"
            textPERSONAL_NOME.Text = System.Environment.UserName
            '------------------
            frmCHATIP.textNome.Text = System.Environment.UserName
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim frmSuporte As frmSuporte = New frmSuporte
        frmSuporte.Show()
        'Process.Start("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\Support.txt")
        frmSuporte.txtSuporte.Text = My.Computer.FileSystem.ReadAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\Support.txt")
    End Sub

    Private Sub frmDEF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextPORTACP.Text = frmCHATIP.textporta.Text
        Dim NOTIFICA = My.Computer.FileSystem.ReadAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\notificacao.txt")
        Dim leitura = My.Computer.FileSystem.ReadAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\Atalho.txt")
        Dim arranque = My.Computer.FileSystem.ReadAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\arranque.txt")
        Me.Update()
        tmrUpdate.Enabled = True
        btnping.Visible = False
        '------------
        If seguranca.Checked = False Then
            My.Computer.FileSystem.WriteAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\Passe.txt", "NOPASS", False)
            btnAlterar.Enabled = False
        End If
        '------------
        If My.Computer.FileSystem.ReadAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\certificado.txt") = "yes" Then
            seguranca.Checked = True
        Else
            seguranca.Checked = False
        End If
        '------------
        If leitura = "TRUE" Then
            checkATALHO.Checked = True
        Else
            checkATALHO.Checked = False
        End If
        '-----------
        If arranque = "TRUE" Then
            checkArranque.Checked = True
        Else
            checkArranque.Checked = False
        End If
        '-----------
        If NOTIFICA = "YES" Then
            checkNOTIFIC.Checked = True
        Else
            checkNOTIFIC.Checked = False
        End If
        '------------LOAD SETTING-------------
        textPERSONAL_NOME.Text = GetSetting(APP_NAME, "Settings", "Texto Personalizado", "")
        cbtema.Text = GetSetting(APP_NAME, "Settings", "Mudar cor do tema", "")
        cbcolor.Text = GetSetting(APP_NAME, "Settings", "Mudar cor do Background", "")
    End Sub

    Private Sub tmrUpdate_Tick(sender As Object, e As EventArgs) Handles tmrUpdate.Tick
        TextPORTACP.Text = frmCHATIP.textporta.Text
        Me.Update()
        '-------------CORRIGIR BUG DO BOTAO PING-------
        If txtIP_GEOLOCATOR.Text.Length > 4 Then
            btnping.Visible = True
        Else
            btnping.Visible = False
        End If
    End Sub

    Private Sub btn_LOCATOR_Click(sender As Object, e As EventArgs) Handles btnping.Click
        frmCMD.textCMD.Clear()
        frmCMD.textCMD.ForeColor = Color.Green
        frmCMD.textCMD.BackColor = Color.Black
        ActionNet("ping", txtIP_GEOLOCATOR.Text)
        frmCMD.textCMD.Focus()
        frmCMD.Show()
        Try
            If My.Computer.Network.Ping(txtIP_GEOLOCATOR.Text) Then
                MsgBox("ONLINE", vbOKOnly + vbInformation + vbDefaultButton1, "PING")
            Else
                MsgBox("OFFLINE", vbOKOnly + vbCritical + vbDefaultButton1, "PING ERRO")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        frmMUDAR_PASS.Show()
    End Sub

    Private Sub seguranca_CheckedChanged(sender As Object, e As EventArgs) Handles seguranca.CheckedChanged
        If seguranca.Checked = True Then
            btnAlterar.Enabled = True
        Else
            btnAlterar.Enabled = False
        End If
    End Sub

    Private Sub btnIPWAN_Click(sender As Object, e As EventArgs) Handles btnIPWAN.Click
        frmIPWAN.Show()
    End Sub

    Private Sub btnIPWAN_MouseMove(sender As Object, e As MouseEventArgs) Handles btnIPWAN.MouseMove
        Dim Tooltip_info As New ToolTip()
        Tooltip_info.AutoPopDelay = 2000
        Tooltip_info.InitialDelay = 1500
        Tooltip_info.ReshowDelay = 1000
        Tooltip_info.ShowAlways = True
        '----
        Tooltip_info.SetToolTip(Me.btnIPWAN, "Clique aqui para Localizar um endereço IP")
    End Sub

    <Obsolete>
    Private Sub btnINFOLOCALHOST_Click(sender As Object, e As EventArgs) Handles btnINFOLOCALHOST.Click
        GetIPAddress()
    End Sub
    '---
    <Obsolete>
    Private Sub GetIPAddress()
        Dim strHostName As String
        Dim strIPAddress As String
        strHostName = System.Net.Dns.GetHostName()
        strIPAddress = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        MsgBox("HOST: " + strHostName + " ; IP: " + strIPAddress, vbOKOnly + vbInformation + vbDefaultButton1, "INFOIP.exe")
    End Sub

    Private Sub frmDEF_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        '--------------------LOAD DAS SETTINGS----------
        SaveSetting(APP_NAME, "Settings", "Texto Personalizado", textPERSONAL_NOME.Text)
        SaveSetting(APP_NAME, "Settings", "Mudar a cor do tema", cbtema.Text)
        SaveSetting(APP_NAME, "Settings", "Mudar a cor do Background", cbcolor.Text)
        SaveSetting(APP_NAME, "Settings", "Ativar as notificações", checkNOTIFIC.Checked)
    End Sub

    Private Sub btnCHECKINTERNET_Click(sender As Object, e As EventArgs) Handles btnCHECKINTERNET.Click
        Dim IP As String = "8.8.8.8"
        If My.Computer.Network.Ping(IP) Then
            MsgBox("VERIFICAÇÃO À INTERNET CONCLUÍDA.", vbOKOnly + vbInformation + vbDefaultButton1, "IP.exe")
        Else
            MsgBox("VERIFICAÇÃO À INTERNET NÃO CONCLUÍDA.", vbOKOnly + vbCritical + vbDefaultButton1, "IP.exe")
        End If
    End Sub

    Private Sub btnOsk_Click(sender As Object, e As EventArgs) Handles btnOsk.Click
        frmCHATIP.Location = New Point(25, 0)
        Me.Location = New Point(125, 45)
        '-------------------CHAMAR TECLADO VIRTUAL PELO PYTHON NO C:\-------
        Try
            Shell("C:/Users/Joel Malacas TEI3/AppData/Local/Microsoft/WindowsApps/python3.10.exe c:/PythonTeclado/PythonTeclado/PythonTeclado.py")
        Catch ex As Exception
            MsgBox("ERRO, python não encontrado, necessita de instalar o PYTHON", vbOKOnly + vbInformation + vbDefaultButton1, "ERRO.exe")
        End Try
    End Sub
End Class
