Imports System
Imports System.Globalization
Imports System.NotImplementedException
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Text.RegularExpressions.Regex

Public Class frmMUDAR_PASS
    Private Sub frmMUDAR_PASS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mail As String = My.Computer.FileSystem.ReadAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\e-mail.txt")
        textemail.Text = mail
        Me.CenterToScreen()
    End Sub

    Private Sub MetroButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton1.Click
        Dim verificar_MAIL As String = My.Computer.FileSystem.ReadAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\e-mail.txt")
        '-----
        If verificar_MAIL <> textemail.Text Then
            If Validar.IsValidEmail(textemail.Text) Then
                MessageBox.Show("Email valido...", "VÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                My.Computer.FileSystem.WriteAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\e-mail.txt", textemail.Text, False)
            Else
                MessageBox.Show("Email inválido...", "INVÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        '-----------
        If text_CHANGE_PASS.Text = TEXT_CHANGE_PASS_2.Text Then
            My.Computer.FileSystem.WriteAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\Passe.txt", text_CHANGE_PASS.Text, False)
            MsgBox("Aleração com sucesso!!!", vbOKOnly + vbInformation + vbDefaultButton1, "PASSE.exe")
            frmDEF.btnAlterar.Enabled = True
            Me.Close()
        Else
            MsgBox("Alteração não foi realizada com sucesso !!!", vbOKOnly + vbCritical + vbDefaultButton1, "Passe.exe")
        End If
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Me.Close()
        MsgBox("Alteração não foi efetuada com sucesso!!!", vbOKOnly + vbCritical + vbDefaultButton1, "Passe.exe")
    End Sub
End Class
