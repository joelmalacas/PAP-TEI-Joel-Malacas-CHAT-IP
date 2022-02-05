Imports System.Net.Mail
Imports System.Net.Mime

Public Class frmMAIL
    Dim mail As New MailMessage()
    Dim path As String

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim leitura As String = My.Computer.FileSystem.ReadAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\e-mailSMTP.txt")
        Me.CenterToScreen()
        '---------------
        textOrigem.Text = leitura
        textOrigem.ReadOnly = True
        btnVIEW.Enabled = False
        '---------------
        If textOrigem.Text = "" Then
            frmENDERECO.Show()
        Else
            frmENDERECO.Close()
        End If
        '---------------
        tmrORIGEM.Start()
        tmrORIGEM.Interval = 150
        '---------------
    End Sub

    Private Sub btnsair_Click(sender As Object, e As EventArgs) Handles btnsair.Click
        Dim resposta As Integer
        resposta = MsgBox("Tem a certeza que quer sair?", vbYesNo + vbQuestion + vbDefaultButton1, "SAIR")
        If resposta = vbYes Then
            My.Computer.FileSystem.WriteAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\verify.txt", "NO", False)
            Application.Exit()
        End If
    End Sub

    Private Sub btnMENU_Click(sender As Object, e As EventArgs) Handles btnMENU.Click
        Dim resposta As Integer
        resposta = MsgBox("Tem a certeza que quer ir para Menu Principal?" + vbNewLine + "Os dados não são guardados!", vbYesNo + vbQuestion + vbDefaultButton1, "MENU")
        If resposta = vbYes Then
            Me.Close()
            frmMenu.Show()
        End If
    End Sub

    Private Sub btnENDERECO_Click(sender As Object, e As EventArgs) Handles btnENDERECO.Click
        frmENDERECO.Show()
    End Sub

    Private Sub btnENDERECO_MouseMove(sender As Object, e As MouseEventArgs) Handles btnENDERECO.MouseMove
        Dim Tooltip_info As New ToolTip()
        Tooltip_info.AutoPopDelay = 2000
        Tooltip_info.InitialDelay = 1500
        Tooltip_info.ReshowDelay = 1000
        Tooltip_info.ShowAlways = True
        '----
        Tooltip_info.SetToolTip(Me.btnENDERECO, "Mudar endereço eletrónico")
    End Sub

    Private Sub tmrORIGEM_Tick(sender As Object, e As EventArgs) Handles tmrORIGEM.Tick
        Dim leitura As String = My.Computer.FileSystem.ReadAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\e-mailSMTP.txt")
        textOrigem.Text = leitura
        '---------
        If lstAnexos.Items.Count > 0 Then
            btnVIEW.Enabled = True
        Else
            btnVIEW.Enabled = False
        End If
        '--------
        If txtAssunto.Text = Nothing Then
            btnVisualizar.Enabled = False
        Else
            btnVisualizar.Enabled = True
        End If
    End Sub

    Private Sub btnAnexar_Click(sender As Object, e As EventArgs) Handles btnAnexar.Click
        Dim ofd1 As New OpenFileDialog()
        If ofd1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            lstAnexos.Items.Add(ofd1.FileName)
            My.Computer.FileSystem.WriteAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\anexo.txt", ofd1.FileName, False)
        End If
    End Sub

    <Obsolete>
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim leitura As String = My.Computer.FileSystem.ReadAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\anexo.txt")
        Dim SmtpServer As New SmtpClient()
        SmtpServer.Credentials = New Net.NetworkCredential(textOrigem.Text, "Cga40vJ3wKz6pbSf")
        SmtpServer.Port = 587
        SmtpServer.Host = "smtp-relay.sendinblue.com"
        SmtpServer.EnableSsl = True
        mail = New MailMessage()
        Dim addr() As String = textPara.Text.Split(",")
        Dim resposta As Integer
        '---------VERIFICAR TEXT BOX's-------
        If textPara.Text = Nothing Then
            MsgBox("Selecione o destinatário!!!", vbOKOnly + vbCritical + vbDefaultButton1, "GMAIL.exe")
        ElseIf textOrigem.Text = Nothing Then
            MsgBox("Selecione um remetente!!!", vbOKOnly + vbCritical + vbDefaultButton1, "GMAIl.exe")
        ElseIf textAssunto.Text = Nothing Then
            MsgBox("Erro, o assunto não contém nenhum conteúdo!!!", vbOKOnly + vbCritical + vbDefaultButton1, "GMAIl.exe")
        End If
        Try
                    mail.From = New MailAddress(textOrigem.Text, textAssunto.Text, System.Text.Encoding.UTF8)
                    Dim i As Byte
                    For i = 0 To addr.Length - 1
                        mail.To.Add(addr(i))
                    Next
                    mail.Body = txtAssunto.Text
                    mail.IsBodyHtml = True
                    '----ADICIONAR ANEXOS----
                    For i = 0 To lstAnexos.Items.Count - 1
                        mail.Attachments.Add(New Attachment(lstAnexos.Items(i)))
                    Next
            '------------------------
            mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
                    mail.ReplyTo = New MailAddress(textPara.Text)
                    If textCC.Text <> Nothing Then
                        mail.CC.Add(New MailAddress(textCC.Text))
                    End If
                    If textbcc.Text <> Nothing Then
                        mail.Bcc.Add(New MailAddress(textbcc.Text))
                    End If
                    SmtpServer.Send(mail)
                    MsgBox("E-Mail enviado com sucesso!!!", vbOKOnly + vbInformation + vbDefaultButton1, "Concluído")
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Me.Close()
                End Try
        If textPara.Text = Nothing Then
            MsgBox("Tem que adicionar um endereço eletrónico para enviar e-mail.", vbOKOnly + vbInformation + vbDefaultButton1, "GMAIL.exe")
        End If
    End Sub

    Private Sub btnREMOVE_Click(sender As Object, e As EventArgs) Handles btnREMOVE.Click
        '----REMOVER ANEXOS-----
        If lstAnexos.SelectedIndex > -1 Then
            lstAnexos.Items.RemoveAt(lstAnexos.SelectedIndex)
        End If
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles btnVisualizar.Click
        frmhtml.Show()
    End Sub

    Private Sub lstAnexos_DragDrop(sender As Object, e As DragEventArgs) Handles lstAnexos.DragDrop
        For Each filename As String In e.Data.GetData(DataFormats.FileDrop, True)
            If Not lstAnexos.Items.Contains(filename) Then
                lstAnexos.Items.Add(filename)
            End If
        Next filename
    End Sub

    Private Sub lstAnexos_DragEnter(sender As Object, e As DragEventArgs) Handles lstAnexos.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub btnVIEW_Click(sender As Object, e As EventArgs) Handles btnVIEW.Click
        Try
            Process.Start(lstAnexos.SelectedItem)
        Catch ex As Exception
            MsgBox("Selecione o ficheiro que quer visualizar", vbOKOnly + vbObjectError + vbDefaultButton1, "ERRO.exe")
        End Try
    End Sub
End Class
