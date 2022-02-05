Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports FluentFTP
Imports FluentFTP.Rules
Imports System.Text
Imports System.Threading.Tasks
Imports System.Threading
Imports System.Collections.Generic

Public Class frmFTP
    Public Property Client As FluentFTP.FtpClient
    '-------------------
    Private Sub btnsair_Click(sender As Object, e As EventArgs) Handles btnsair.Click
        Dim resposta As Integer
        resposta = MsgBox("Tem a certeza que quer Sair do programa?", vbYesNo + vbQuestion + vbDefaultButton2, "SAIR")
        If resposta = vbYes Then
            My.Computer.FileSystem.WriteAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\verify.txt", "NO", False)
            Application.Exit()
        End If
    End Sub

    Private Sub btnMENU_Click(sender As Object, e As EventArgs) Handles btnMENU.Click
        Dim resposta As Integer
        resposta = MsgBox("Tem a certeza que quer ir para menu principal?", vbYesNo + vbQuestion + vbDefaultButton1, "SAIR")
        If resposta = vbYes Then
            If Client.IsConnected = True Then
                Client.Disconnect()
                Me.Close()
            Else
                Me.Close()
                frmMenu.Show()
            End If
        End If
    End Sub

    Private Sub frmFTP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        If My.Computer.Network.Ping("ftp.essb.pt") Then
            lblStatus.Text = "ONLINE"
            lblStatus.ForeColor = Color.Green
        Else
            lblStatus.Text = "OFFLINE"
            lblStatus.ForeColor = Color.Red
        End If
        verificar()
        '-----------------
        FTPServer.Text = "ftp.essb.pt"
        portaFTP.Text = "21"
        '-
        FTPServer.ReadOnly = True
        portaFTP.ReadOnly = True
        '-----------------
    End Sub

    Private Sub EnviaArquivo(ByVal local_arquivo As String, ByVal caminho_remoto As String, ByVal usuario As String, ByVal senha As String)

        Dim arquivo As New FileInfo(local_arquivo)
        Dim arquivo_remoto As String = caminho_remoto & arquivo.Name


        Dim request As FtpWebRequest = WebRequest.Create("ftp://ftp.essb.pt/FTP%20PAP/")
        request.Method = WebRequestMethods.Ftp.UploadFile

        request.PreAuthenticate = True
        request.Credentials = New NetworkCredential("aesb_alunos@aluno.agrupamentosabandeira.pt", "8D)@zlnRk{=n")
        request.EnableSsl = True

        Dim fonte_stream As New StreamReader(local_arquivo)
        Dim arquivo_bytes As Byte() = Encoding.UTF8.GetBytes(fonte_stream.ReadToEnd())
        fonte_stream.Close()
        request.ContentLength = arquivo_bytes.Length


        Dim requestStream As Stream = request.GetRequestStream()
        requestStream.Write(arquivo_bytes, 0, arquivo_bytes.Length)
        requestStream.Close()


        Dim resposta As FtpWebResponse = request.GetResponse()
        If Not resposta.StatusDescription.Contains("Arquivo transferido com sucesso") Then
            Dim msg As String = "Erro ao envira arquivo " & local_arquivo & vbCrLf & resposta.StatusDescription
            resposta.Close()
            Throw New Exception(msg)
        End If
        MsgBox("Arquivo transferido com sucesso!!!!", vbOKOnly + vbInformation + vbDefaultButton1, "Sucesso")
        resposta.Close()
    End Sub

    Private Sub btnADDFICHEIRO_Click(sender As Object, e As EventArgs) Handles btnADDFICHEIRO.Click
        Dim ofd1 As New OpenFileDialog
        If ofd1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            lstArquivos.Items.Add(ofd1.FileName)
            nome()
        End If
    End Sub

    Private Sub lstArquivos_DragDrop(sender As Object, e As DragEventArgs) Handles lstArquivos.DragDrop
        For Each filename As String In e.Data.GetData(DataFormats.FileDrop, True)
            If Not lstArquivos.Items.Contains(filename) Then
                lstArquivos.Items.Add(filename)
                nome()
            End If
        Next filename
    End Sub

    Private Sub lstArquivos_DragEnter(sender As Object, e As DragEventArgs) Handles lstArquivos.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles btnRemover.Click
        If lstArquivos.SelectedIndex > -1 Then
            lstArquivos.Items.RemoveAt(lstArquivos.SelectedIndex)
        End If
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Upload_Direct_files()
    End Sub

    Private Sub Upload_Direct_files()
        Dim nome = My.Computer.FileSystem.ReadAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\nomeCaminho.txt")
        Try
            Dim wrUpload As FtpWebRequest = DirectCast(WebRequest.Create _
                ("ftp://ftp.essb.pt/FTP_PAP/" + nome), FtpWebRequest)

            wrUpload.Credentials = New NetworkCredential("aesb_alunos@aluno.agrupamentosabandeira.pt", "8D)@zlnRk{=n")
            wrUpload.Method = WebRequestMethods.Ftp.UploadFile
            Dim btfile() As Byte = File.ReadAllBytes(lstArquivos.Items(0))
            Dim strFile As Stream = wrUpload.GetRequestStream()
            strFile.Write(btfile, 0, btfile.Length)
            strFile.Close()
            strFile.Dispose()
            MsgBox("Uploaded completo", MsgBoxStyle.Information)
        Catch
            MsgBox("Erro ao dar Upload ao ficheiro.")
        End Try
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles btnFTPExplorer.Click
        Process.Start("ftp://ftp.essb.pt/")
    End Sub

    Private Sub frmFTP_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Client.Disconnect()
        frmMenu.Show()
    End Sub

    Private Sub verificar()
        Try
            Client = New FluentFTP.FtpClient()
            Client.Host = "ftp.essb.pt"
            Client.Port = 21
            Client.Credentials = New System.Net.NetworkCredential("aesb_alunos@aluno.agrupamentosabandeira.pt", "8D)@zlnRk{=n")
            Client.Connect()
            lblStatus.Text = "ONLINE (verificado)"
            lblStatus.ForeColor = Color.Green
        Catch ex As Exception
            lblStatus.Text = "OFFLINE"
            lblStatus.ForeColor = Color.Red
            MsgBox(ex.Message, vbOKOnly + vbObjectError + vbDefaultButton1, "Erro")
        End Try
    End Sub

    Private Sub download()
        Dim nome = My.Computer.FileSystem.ReadAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\nomeCaminho.txt")
        Try
            Dim localFile As String = "C:\Users\" + System.Environment.UserName + "\Desktop\" + nome
            Dim remoteFile As String = "/FTP_PAP/" + nome
            Const host As String = "ftp://ftp.essb.pt"
            Const username As String = "aesb_alunos@aluno.agrupamentosabandeira.pt"
            Const password As String = "8D)@zlnRk{=n\"
            '------------------------------------------------
            Dim URI As String = host & remoteFile
            Dim ftp As System.Net.FtpWebRequest =
                CType(FtpWebRequest.Create(URI), FtpWebRequest)
            ftp.Credentials = New _
                System.Net.NetworkCredential(username, password)
            ftp.KeepAlive = False
            ftp.UseBinary = True
            ftp.Method = System.Net.WebRequestMethods.Ftp.DownloadFile
            Using response As System.Net.FtpWebResponse =
                  CType(ftp.GetResponse, System.Net.FtpWebResponse)
                Using responseStream As IO.Stream = response.GetResponseStream
                    Using fs As New IO.FileStream(localFile, IO.FileMode.Create)
                        Dim buffer(2047) As Byte
                        Dim read As Integer = 0
                        Do
                            read = responseStream.Read(buffer, 0, buffer.Length)
                            fs.Write(buffer, 0, read)
                        Loop Until read = 0
                        responseStream.Close()
                        fs.Flush()
                        fs.Close()
                    End Using
                    responseStream.Close()
                End Using
                response.Close()
            End Using
            MsgBox("Download Concluído," + vbNewLine + "Ficheiro guardado: " + localFile, vbOKOnly + vbInformation + vbDefaultButton1, "Download.exe")
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbObjectError + vbDefaultButton1, "Erro")
        End Try
    End Sub

    Private Sub btnDownloadFicheiro_Click(sender As Object, e As EventArgs) Handles btnDownloadFicheiro.Click
        download()
    End Sub

    Private Sub nome()
        Dim caminho As String
        Dim strCurDBName As String
        Dim obtemnomeFile As String
        Dim i As Integer
        caminho = lstArquivos.Items(0)
        strCurDBName = caminho
        For i = Len(strCurDBName) To 1 Step -1
            If Mid(strCurDBName, i, 1) = "\" Then
                obtemnomeFile = Mid(strCurDBName, i + 1)
                Exit For
            End If
        Next i
        My.Computer.FileSystem.WriteAllText("C:\PAP TEI 2021-20210531T114211Z-001\PAP TEI 2021\PAP TEI Joel Malacas (CHAT IP)\PAP TEI Joel Malacas (CHAT IP)\config\nomeCaminho.txt", obtemnomeFile, False)
    End Sub
End Class
