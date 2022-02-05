Imports System.Net.Sockets
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Net.Dns
Imports System.Collections

Public Class frmPartilhaEnviar
    Dim cliente As New TcpClient
    Dim nstream As NetworkStream

    Private Sub tmrEnviar_Tick(sender As Object, e As EventArgs) Handles tmrEnviar.Tick
        EnviarImagem()
        '--------
        If cliente.Connected Then
            lblStatus.Text = "Online"
            lblStatus.ForeColor = Color.Green
        Else
            lblStatus.Text = "OFFLINE"
            lblStatus.ForeColor = Color.Red
        End If
    End Sub

    Public Function CapturaTelaDesktop() As Image
        Dim b As Bitmap = New Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
        Dim limites As Rectangle = Nothing
        Dim tela As Bitmap = Nothing
        Dim grafico As Graphics = Nothing
        limites = Screen.PrimaryScreen.Bounds
        tela = New Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
        grafico = Graphics.FromImage(tela)
        grafico.CopyFromScreen(limites.X, limites.Y, 0, 0, limites.Size, CopyPixelOperation.SourceCopy)

        Return tela

    End Function

    Private Sub EnviarImagem()
        Try
            Dim bf As New BinaryFormatter
            nstream = cliente.GetStream
            bf.Serialize(nstream, CapturaTelaDesktop())
            Windows.Forms.Cursor.Show()
        Catch ex As Exception
            tmrEnviar.Stop()
            MsgBox("A partilha de ecrã foi desativada!", vbOKOnly + vbInformation + vbDefaultButton1, "Ecra.exe")
            cliente.Close()
            Me.Close()
        End Try
    End Sub

    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        Try
            tmrEnviar.Start()
            cliente.Connect(frmCHATIP.textIP.Text, 9987)
            btnConectar.Visible = False
            btnParar.Visible = True
            tmrCON.Start()
            tmrCON.Interval = 1000
            MsgBox("Partilha de ecrã concluída!", vbOKOnly + vbInformation + vbDefaultButton1, "Ecra.exe")
        Catch ex As Exception
            MsgBox("Erro: " + ex.Message)
            Me.Close()
            tmrEnviar.Stop()
            tmrCON.Stop()
        End Try
    End Sub

    Private Sub frmPartilhaEnviar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnParar.Visible = False
        btnConectar.Visible = True
        '-----
        lblStatus.Text = "Esperar ligação"
        lblStatus.ForeColor = Color.Yellow
        lblCon.Text = "00:00:00"
        '---
        tmrEnviar.Interval = 1
    End Sub

    Private Sub btnParar_Click(sender As Object, e As EventArgs) Handles btnParar.Click
        cliente.Close()
        Me.Close()
    End Sub

    Private Sub tmrCON_Tick(sender As Object, e As EventArgs) Handles tmrCON.Tick
        tmrCON.Interval = 1000
        Dim h, min, seg As String
        h = Split(lblCon.Text, ":")(0)
        min = Split(lblCon.Text, ":")(1)
        seg = Split(lblCon.Text, ":")(2)
        If Int(seg) < 59 Then
            seg = Int(seg) + "01"
        Else
            min = Int(min) + "01"
            seg = "00"
        End If
        If Int(min) > 59 Then
            h = Int(h) + "01"
            min = "00"
        End If
        lblCon.Text = h & ":" & min & ":" & seg
    End Sub
End Class
