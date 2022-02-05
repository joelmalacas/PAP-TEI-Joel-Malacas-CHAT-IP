Imports System.Xml
Imports System.Net.Dns
Public Class frmIPWAN
    Private Sub frmIPWAN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrUPDATE.Enabled = True
        tmrUPDATE.Interval = 150
        '---
        textWANIPTESTE.ReadOnly = True
        btnOBTERINFO.Enabled = False
    End Sub

    <Obsolete>
    Private Sub btnOBTERINFO_Click(sender As Object, e As EventArgs) Handles btnOBTERINFO.Click
        Dim respostas As Integer
        Dim WC As New System.Net.WebClient
        Dim IP_WAN As String = "https://ipinfo.io/" + textIP.Text
        respostas = MsgBox("Deseja abrir o navegador para mais informações?", vbYesNo + vbQuestion + vbDefaultButton1, "IP.exe")
        If respostas = vbYes Then
            Try
                Process.Start(IP_WAN)
                textWANIPTESTE.Text = System.Text.Encoding.ASCII.GetString((WC.DownloadData("https://ipinfo.io/" + textIP.Text + vbNewLine)))
                WC.Dispose()
            Catch ex As Exception
                MessageBox.Show("Erro: " & ex.Message)
            End Try
        Else
            Try
                textWANIPTESTE.Text = System.Text.Encoding.ASCII.GetString((WC.DownloadData("https://ipinfo.io/" + textIP.Text + vbNewLine)))
                WC.Dispose()
            Catch ex As Exception
                MessageBox.Show("Erro: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub tmrUPDATE_Tick(sender As Object, e As EventArgs) Handles tmrUPDATE.Tick
        textWANIPTESTE.Update()
        '----------
        If textIP.Text.Length > 6 Then
            btnOBTERINFO.Enabled = True
        Else
            btnOBTERINFO.Enabled = False
        End If
    End Sub
End Class
