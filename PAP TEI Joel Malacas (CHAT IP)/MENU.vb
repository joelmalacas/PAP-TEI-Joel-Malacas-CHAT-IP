Public Class frmMenu

    Private Sub btnCHATIP_Click_1(sender As Object, e As EventArgs) Handles btnCHATIP.MouseMove
        lblchat.Visible = True
        lblFTP.Visible = False
        lblGMAIL.Visible = False
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim verificado As String = My.Computer.FileSystem.ReadAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\certificado.txt")
        My.Computer.FileSystem.WriteAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\user.txt", System.Environment.UserName, False)
        '---------SEGURANÇA-----------
        If verificado = "yes" Then
            tmrPASSE.Enabled = True
            tmrPASSE.Interval = 1000
            Me.WindowState = FormWindowState.Minimized
            LoginFrm.Show()
        End If
        '-----------------------------

        '-----------------------------
        lblchat.Visible = False
        lblFTP.Visible = False
        lblGMAIL.Visible = False
    End Sub

    Private Sub btnFTP_Click_1(sender As Object, e As EventArgs) Handles btnFTP.MouseMove
        lblFTP.Visible = True
        lblchat.Visible = False
        lblGMAIL.Visible = False
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btnCHATIP.Click
        Me.Close()
        frmCHATIP.Show()
    End Sub

    Private Sub btnsair_Click(sender As Object, e As EventArgs) Handles btnsair.Click
        Dim resposta As Integer
        resposta = MsgBox("Tem a certeza que quer sair?", vbYesNo + vbQuestion + vbDefaultButton2, "SAIR")
        If resposta = vbYes Then
            End
        End If
    End Sub

    Private Sub btnFTP_Click(sender As Object, e As EventArgs) Handles btnFTP.Click
        Me.Close()
        frmFTP.Show()
    End Sub

    Private Sub tmrPASSE_Tick(sender As Object, e As EventArgs) Handles tmrPASSE.Tick
        If LoginFrm.Visible = False Then
            Me.WindowState = FormWindowState.Normal
            LoginFrm.Hide()
            tmrPASSE.Enabled = False
        Else
            LoginFrm.Show()
            Me.Hide()
            tmrPASSE.Enabled = False
        End If
    End Sub

    Private Sub btnMAIL_Click(sender As Object, e As EventArgs) Handles btnMAIL.Click
        Me.Close()
        frmMAIL.Show()
    End Sub

    Private Sub btnMAIL_MouseMove(sender As Object, e As MouseEventArgs) Handles btnMAIL.MouseMove
        lblGMAIL.Visible = True
        lblFTP.Visible = False
        lblchat.Visible = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmDEF.Size = New Size(640, 420)
        frmDEF.Show()
    End Sub
End Class
