Public Class frmPartilha
    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAplicar_Click(sender As Object, e As EventArgs) Handles btnAplicar.Click
        If checkAssistir.Checked = True Then
            frmPartilhaREC.Show()
            Me.Close()
        ElseIf checkPartilhar.Checked = True Then
            frmPartilhaEnviar.Show()
            Me.Close()
        End If
    End Sub

    Private Sub checkPartilhar_CheckedChanged(sender As Object, e As EventArgs) Handles checkPartilhar.CheckedChanged
        checkAssistir.Checked = False
    End Sub

    Private Sub checkAssistir_CheckedChanged(sender As Object, e As EventArgs) Handles checkAssistir.CheckedChanged
        checkPartilhar.Checked = False
    End Sub
End Class
