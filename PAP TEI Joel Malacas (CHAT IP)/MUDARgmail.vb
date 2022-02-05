Public Class frmENDERECO
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub btnaplicar_Click(sender As Object, e As EventArgs) Handles btnaplicar.Click
        My.Computer.FileSystem.WriteAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\e-mailSMTP.txt", email.Text, False)
        MsgBox("E-mail alterado com sucesso!!!", vbOKOnly + vbInformation + vbDefaultButton1, "GMAIL.exe")
        Me.Close()
    End Sub

    Private Sub frmENDERECO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class
