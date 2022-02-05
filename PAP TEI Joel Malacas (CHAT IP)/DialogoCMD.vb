Imports System.Windows.Forms

Public Class frmCMD

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmCMD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ForeColor = Color.Green
        Me.BackColor = Color.Black
        textCMD.ForeColor = Color.Green
        textCMD.BackColor = Color.Black
    End Sub
End Class
