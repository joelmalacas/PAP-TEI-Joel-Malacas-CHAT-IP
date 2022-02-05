Public Class LoginFrm

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim user As String = My.Computer.FileSystem.ReadAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\e-mail.txt")
        Dim pass As String = My.Computer.FileSystem.ReadAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\Passe.txt")
        Dim erro As String = My.Computer.FileSystem.ReadAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\TENTATIVA.txt")
        '----------------
        If UsernameTextBox.Text = user And PasswordTextBox.Text = pass Then
            MsgBox("Login com sucesso!!!", vbOKOnly + vbInformation + vbDefaultButton1, "LOGIN.exe")
            '----------------
            Me.Close()
            frmMenu.Show()
            frmMenu.WindowState = FormWindowState.Normal
        Else
            MsgBox("ERRO CREDENCIAIS ERRADAS, TENTE NOVAMENTE!!!", vbOKOnly + vbCritical + vbDefaultButton1, "ERRO")
            My.Computer.FileSystem.WriteAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\TENTATIVA.txt", +1, False)
            UsernameTextBox.Clear()
            PasswordTextBox.Clear()
            If erro = 3 Then
                MsgBox("JÁ FORAM MUITAS TENTATIVAS DE LOGIN, TENTE NOVAMENTE MAIS TARDE!!!", vbOKOnly + vbCritical + vbDefaultButton1, "ERRO LOGIN.exe")
                End
            End If
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
        End
    End Sub

    Private Sub LoginFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim leitura As String = My.Computer.FileSystem.ReadAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\verify.txt")
        My.Computer.FileSystem.WriteAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\TENTATIVA.txt", 0, False)
        Me.CenterToScreen()
        frmMenu.Hide()
        '------------
        If leitura = "YES" Then
            Me.Close()
            frmMenu.Show()
        Else
            Me.Show()
        End If
        '------------
        Dim nopass As String = My.Computer.FileSystem.ReadAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\Passe.txt")
            If nopass = "NOPASS" Then
                Me.Close()
                frmMenu.Show()
            End If
    End Sub

    Private Sub MetroCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles checkpasse.CheckedChanged
        If checkpasse.Checked = True Then
            PasswordTextBox.PasswordChar = ""
        Else
            PasswordTextBox.PasswordChar = "*"
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frm_esq_passe.Show()
    End Sub
End Class
