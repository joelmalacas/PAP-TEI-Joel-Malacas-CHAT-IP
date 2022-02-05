Imports System.Net.Mail
Imports System.Net.Mime
Public Class frm_esq_passe
    Dim mail As New MailMessage()
    Dim path As String

    <Obsolete>
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim subject As String = My.Computer.FileSystem.ReadAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\Passe.txt")
        Dim mail_text As String = My.Computer.FileSystem.ReadAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\e-mail.txt")
        Dim SmtpServer As New SmtpClient()
        SmtpServer.Credentials = New Net.NetworkCredential("joelmalacas@gmail.com", "Cga40vJ3wKz6pbSf")
        SmtpServer.Port = 587
        SmtpServer.Host = "smtp-relay.sendinblue.com"
        SmtpServer.EnableSsl = True
        mail = New MailMessage()
        Dim addr() As String = textEnviar_email.Text.Split(",")
        If textEnviar_email.Text = mail_text Then
            Try
                mail.From = New MailAddress("joelmalacas@gmail.com", "RECUPERAÇÃO PASSWORD || CHAT IP ", System.Text.Encoding.UTF8)
                Dim i As Byte
                For i = 0 To addr.Length - 1
                    mail.To.Add(addr(i))
                Next
                mail.Body = "A solicitação da password foi concluída." + vbNewLine + "Password: " + subject
                mail.IsBodyHtml = True
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
                mail.ReplyTo = New MailAddress(textEnviar_email.Text)
                SmtpServer.Send(mail)
                MsgBox("E-Mail enviado com sucesso!!!", vbOKOnly + vbInformation + vbDefaultButton1, "Concluído")
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("O Endereço eletrónico não é reconhecido.", vbOKOnly + vbCritical + vbDefaultButton1, "ERRO")
            Me.Close()
        End If
    End Sub

    Private Sub frm_esq_passe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class
