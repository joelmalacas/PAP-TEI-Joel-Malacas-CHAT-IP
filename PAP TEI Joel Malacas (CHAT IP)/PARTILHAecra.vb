Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Imports System.Runtime.Serialization.Formatters.Binary

Public Class frmPartilhaREC
    <Obsolete>
    Dim server As New TcpListener(9987)
    Dim client As New TcpClient
    Dim nstream As NetworkStream
    <Obsolete>
    Dim listening As New Thread(AddressOf Listen)
    Dim getImagem As New Thread(AddressOf ReceberImagem)

    <Obsolete>
    Private Sub Listen()
        While client.Connected = False
            server.Start()
            client = server.AcceptTcpClient
        End While
        getImagem.Start()
    End Sub

    <Obsolete>
    Private Sub ReceberImagem()
        Dim bf As New BinaryFormatter
        Try
            While client.Connected = True
                nstream = client.GetStream
                PicECRA.Image = bf.Deserialize(nstream)
            End While
        Catch ex As Exception
            MsgBox("Erro: " + "A partilha de ecrã fechada com sucesso!", vbOKOnly + vbInformation + vbDefaultButton1, "ERRO.exe")
            client.Close()
            server.Stop()
            Me.Close()
        End Try
    End Sub

    <Obsolete>
    Private Sub frmPartilhaREC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listening.Start()
        '------
        Me.CenterToScreen()
        Me.Size = New Size(999, 720)
    End Sub

    Private Sub btnfechar_Click(sender As Object, e As EventArgs) Handles btnfechar.Click
        Me.Close()
    End Sub
End Class
