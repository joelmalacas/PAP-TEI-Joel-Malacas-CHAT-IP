Imports System.Windows.Forms

Public Class frmSuporte

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmSuporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ShowInTaskbar = True
        Me.CenterToScreen()
        txtSuporte.ReadOnly = True
    End Sub
End Class
