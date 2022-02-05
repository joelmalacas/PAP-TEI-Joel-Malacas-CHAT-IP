Public Class frmhtml
    Dim ofd1 As New OpenFileDialog()

    Private Sub btnfechar_Click(sender As Object, e As EventArgs) Handles btnfechar.Click
        Me.Close()
    End Sub

    Private Sub frmhtml_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        '---------
        Dim ficheiro As String = frmMAIL.lstAnexos.Items.Add(ofd1.FileName)
        '-------
        richHTML.Text = "De: " + frmMAIL.textOrigem.Text + vbNewLine + vbNewLine + "Para: " & frmMAIL.textPara.Text & vbNewLine + vbNewLine & "CC: " & frmMAIL.textCC.Text & vbNewLine + vbNewLine & "Bcc: " & frmMAIL.textbcc.Text & vbNewLine & vbNewLine & "Assunto: " & frmMAIL.textAssunto.Text & vbNewLine & vbNewLine &
        "Ficheiros Enviados: " & ficheiro & vbNewLine & vbNewLine & "Mensagem Enviada: " & frmMAIL.txtAssunto.Text
    End Sub
End Class
