Public Class frm1
    Private Sub frm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        lbl1.Visible = True
        lbl2.Visible = False
        lbl3.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl1.Text = "A iniciar Programa..."
        lbl1.Visible = True
        lbl2.Visible = False
        lbl3.Visible = False
        '---------------------- label // Timer -------------------
        Timer1.Enabled = False
        Timer2.Enabled = True
        Timer3.Enabled = False
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lbl2.Text = "A preparar menu..."
        lbl1.Visible = False
        lbl2.Visible = True
        lbl3.Visible = False
        '---------------------- label // Timer -------------------
        Timer3.Enabled = True
        Timer1.Enabled = False
        Timer2.Enabled = False
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        lbl3.Text = "Pronto..."
        lbl1.Visible = False
        lbl2.Visible = False
        lbl3.Visible = True
        '---------------------- FORMS ----------------------------
        Me.Hide()
        frmMenu.Show()
        '---------------------- label // Timer -------------------
        Timer3.Enabled = False
        Timer1.Enabled = False
        Timer2.Enabled = False

    End Sub
End Class
