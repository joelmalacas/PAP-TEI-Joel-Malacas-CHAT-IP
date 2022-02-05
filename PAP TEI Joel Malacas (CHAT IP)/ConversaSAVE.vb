Imports System.Windows.Forms

Public Class frmConversa

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmConversa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ShowInTaskbar = True
    End Sub
End Class
