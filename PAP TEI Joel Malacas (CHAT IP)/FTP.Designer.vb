<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFTP
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFTP))
        Me.btnsair = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRemover = New MetroFramework.Controls.MetroButton()
        Me.lstArquivos = New System.Windows.Forms.ListBox()
        Me.btnADDFICHEIRO = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.textSTATUS = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.portaFTP = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.FTPServer = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.btnMENU = New MetroFramework.Controls.MetroButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnEnviar = New MetroFramework.Controls.MetroButton()
        Me.btnFTPExplorer = New MetroFramework.Controls.MetroButton()
        Me.btnDownloadFicheiro = New MetroFramework.Controls.MetroButton()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnsair
        '
        Me.btnsair.Location = New System.Drawing.Point(640, 301)
        Me.btnsair.Margin = New System.Windows.Forms.Padding(2)
        Me.btnsair.Name = "btnsair"
        Me.btnsair.Size = New System.Drawing.Size(130, 32)
        Me.btnsair.TabIndex = 0
        Me.btnsair.Text = "Sair"
        Me.btnsair.UseSelectable = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRemover)
        Me.GroupBox1.Controls.Add(Me.lstArquivos)
        Me.GroupBox1.Controls.Add(Me.btnADDFICHEIRO)
        Me.GroupBox1.Controls.Add(Me.MetroLabel4)
        Me.GroupBox1.Controls.Add(Me.lblStatus)
        Me.GroupBox1.Controls.Add(Me.textSTATUS)
        Me.GroupBox1.Controls.Add(Me.MetroLabel3)
        Me.GroupBox1.Controls.Add(Me.portaFTP)
        Me.GroupBox1.Controls.Add(Me.MetroLabel2)
        Me.GroupBox1.Controls.Add(Me.FTPServer)
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(769, 288)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FTP CLIENTE"
        '
        'btnRemover
        '
        Me.btnRemover.Location = New System.Drawing.Point(605, 163)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(118, 81)
        Me.btnRemover.TabIndex = 17
        Me.btnRemover.Text = "Remover Ficheiro"
        Me.btnRemover.UseSelectable = True
        '
        'lstArquivos
        '
        Me.lstArquivos.AllowDrop = True
        Me.lstArquivos.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstArquivos.FormattingEnabled = True
        Me.lstArquivos.IntegralHeight = False
        Me.lstArquivos.ItemHeight = 20
        Me.lstArquivos.Location = New System.Drawing.Point(118, 54)
        Me.lstArquivos.Name = "lstArquivos"
        Me.lstArquivos.Size = New System.Drawing.Size(481, 190)
        Me.lstArquivos.TabIndex = 16
        '
        'btnADDFICHEIRO
        '
        Me.btnADDFICHEIRO.Location = New System.Drawing.Point(605, 54)
        Me.btnADDFICHEIRO.Name = "btnADDFICHEIRO"
        Me.btnADDFICHEIRO.Size = New System.Drawing.Size(118, 103)
        Me.btnADDFICHEIRO.TabIndex = 11
        Me.btnADDFICHEIRO.Text = "Adicionar Ficheiro"
        Me.btnADDFICHEIRO.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(-3, 58)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(115, 19)
        Me.MetroLabel4.TabIndex = 9
        Me.MetroLabel4.Text = "Caminho Ficheiro:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(663, 31)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 13)
        Me.lblStatus.TabIndex = 8
        '
        'textSTATUS
        '
        Me.textSTATUS.AutoSize = True
        Me.textSTATUS.Location = New System.Drawing.Point(666, 27)
        Me.textSTATUS.Name = "textSTATUS"
        Me.textSTATUS.Size = New System.Drawing.Size(0, 0)
        Me.textSTATUS.TabIndex = 7
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel3.Location = New System.Drawing.Point(569, 25)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(88, 19)
        Me.MetroLabel3.TabIndex = 6
        Me.MetroLabel3.Text = "Server Status:"
        '
        'portaFTP
        '
        '
        '
        '
        Me.portaFTP.CustomButton.Image = Nothing
        Me.portaFTP.CustomButton.Location = New System.Drawing.Point(122, 1)
        Me.portaFTP.CustomButton.Name = ""
        Me.portaFTP.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.portaFTP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.portaFTP.CustomButton.TabIndex = 1
        Me.portaFTP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.portaFTP.CustomButton.UseSelectable = True
        Me.portaFTP.CustomButton.Visible = False
        Me.portaFTP.Lines = New String(-1) {}
        Me.portaFTP.Location = New System.Drawing.Point(395, 25)
        Me.portaFTP.MaxLength = 32767
        Me.portaFTP.Name = "portaFTP"
        Me.portaFTP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.portaFTP.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.portaFTP.SelectedText = ""
        Me.portaFTP.SelectionLength = 0
        Me.portaFTP.SelectionStart = 0
        Me.portaFTP.ShortcutsEnabled = True
        Me.portaFTP.Size = New System.Drawing.Size(144, 23)
        Me.portaFTP.TabIndex = 5
        Me.portaFTP.UseSelectable = True
        Me.portaFTP.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.portaFTP.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(319, 26)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(70, 19)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "Porta FTP:"
        '
        'FTPServer
        '
        '
        '
        '
        Me.FTPServer.CustomButton.Image = Nothing
        Me.FTPServer.CustomButton.Location = New System.Drawing.Point(122, 1)
        Me.FTPServer.CustomButton.Name = ""
        Me.FTPServer.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.FTPServer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.FTPServer.CustomButton.TabIndex = 1
        Me.FTPServer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.FTPServer.CustomButton.UseSelectable = True
        Me.FTPServer.CustomButton.Visible = False
        Me.FTPServer.Lines = New String(-1) {}
        Me.FTPServer.Location = New System.Drawing.Point(112, 25)
        Me.FTPServer.MaxLength = 32767
        Me.FTPServer.Name = "FTPServer"
        Me.FTPServer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FTPServer.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.FTPServer.SelectedText = ""
        Me.FTPServer.SelectionLength = 0
        Me.FTPServer.SelectionStart = 0
        Me.FTPServer.ShortcutsEnabled = True
        Me.FTPServer.Size = New System.Drawing.Size(144, 23)
        Me.FTPServer.TabIndex = 3
        Me.FTPServer.UseSelectable = True
        Me.FTPServer.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FTPServer.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(6, 27)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(88, 19)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Servidor FTP:"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(600, 301)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(0, 0)
        Me.MetroButton1.TabIndex = 0
        Me.MetroButton1.Text = "MetroButton1"
        Me.MetroButton1.UseSelectable = True
        '
        'btnMENU
        '
        Me.btnMENU.BackColor = System.Drawing.Color.Gold
        Me.btnMENU.Location = New System.Drawing.Point(481, 301)
        Me.btnMENU.Name = "btnMENU"
        Me.btnMENU.Size = New System.Drawing.Size(154, 32)
        Me.btnMENU.TabIndex = 0
        Me.btnMENU.Text = "Voltar para Menu Principal"
        Me.btnMENU.UseSelectable = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnEnviar
        '
        Me.btnEnviar.BackColor = System.Drawing.Color.Gold
        Me.btnEnviar.Location = New System.Drawing.Point(1, 301)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(154, 32)
        Me.btnEnviar.TabIndex = 2
        Me.btnEnviar.Text = "Enviar ficheiro"
        Me.btnEnviar.UseSelectable = True
        '
        'btnFTPExplorer
        '
        Me.btnFTPExplorer.BackColor = System.Drawing.Color.Gold
        Me.btnFTPExplorer.Location = New System.Drawing.Point(321, 301)
        Me.btnFTPExplorer.Name = "btnFTPExplorer"
        Me.btnFTPExplorer.Size = New System.Drawing.Size(154, 32)
        Me.btnFTPExplorer.TabIndex = 3
        Me.btnFTPExplorer.Text = "Abrir FTP (Browser)"
        Me.btnFTPExplorer.UseSelectable = True
        '
        'btnDownloadFicheiro
        '
        Me.btnDownloadFicheiro.Location = New System.Drawing.Point(161, 301)
        Me.btnDownloadFicheiro.Name = "btnDownloadFicheiro"
        Me.btnDownloadFicheiro.Size = New System.Drawing.Size(154, 32)
        Me.btnDownloadFicheiro.TabIndex = 4
        Me.btnDownloadFicheiro.Text = "Download Ficheiro"
        Me.btnDownloadFicheiro.UseSelectable = True
        '
        'frmFTP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 339)
        Me.Controls.Add(Me.btnDownloadFicheiro)
        Me.Controls.Add(Me.btnFTPExplorer)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.btnMENU)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.btnsair)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmFTP"
        Me.Text = "Ftp.exe"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnsair As MetroFramework.Controls.MetroButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMENU As MetroFramework.Controls.MetroButton
    Friend WithEvents FTPServer As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents portaFTP As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents textSTATUS As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblStatus As Label
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnADDFICHEIRO As MetroFramework.Controls.MetroButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lstArquivos As ListBox
    Friend WithEvents btnRemover As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEnviar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnFTPExplorer As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDownloadFicheiro As MetroFramework.Controls.MetroButton
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
