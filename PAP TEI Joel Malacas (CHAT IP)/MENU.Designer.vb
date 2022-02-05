<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.lblchat = New System.Windows.Forms.Label()
        Me.lblFTP = New System.Windows.Forms.Label()
        Me.btnsair = New MetroFramework.Controls.MetroButton()
        Me.tmrPASSE = New System.Windows.Forms.Timer(Me.components)
        Me.lblGMAIL = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnMAIL = New MetroFramework.Controls.MetroButton()
        Me.btnFTP = New MetroFramework.Controls.MetroButton()
        Me.btnCHATIP = New MetroFramework.Controls.MetroButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblchat
        '
        Me.lblchat.AutoSize = True
        Me.lblchat.Location = New System.Drawing.Point(360, 386)
        Me.lblchat.Name = "lblchat"
        Me.lblchat.Size = New System.Drawing.Size(392, 13)
        Me.lblchat.TabIndex = 3
        Me.lblchat.Text = "NOTA: Ao clicar no ""CHAT IP"" irá para um chat de conversação por endereço IP"
        '
        'lblFTP
        '
        Me.lblFTP.AutoSize = True
        Me.lblFTP.Location = New System.Drawing.Point(359, 386)
        Me.lblFTP.Name = "lblFTP"
        Me.lblFTP.Size = New System.Drawing.Size(393, 13)
        Me.lblFTP.TabIndex = 4
        Me.lblFTP.Text = "NOTA: Ao clicar no ""FTP"" irá para uma transferência de ficheiros por endereço IP"
        '
        'btnsair
        '
        Me.btnsair.BackColor = System.Drawing.Color.Red
        Me.btnsair.Location = New System.Drawing.Point(982, 404)
        Me.btnsair.Margin = New System.Windows.Forms.Padding(2)
        Me.btnsair.Name = "btnsair"
        Me.btnsair.Size = New System.Drawing.Size(84, 35)
        Me.btnsair.TabIndex = 7
        Me.btnsair.Text = "Sair"
        Me.btnsair.UseSelectable = True
        '
        'tmrPASSE
        '
        '
        'lblGMAIL
        '
        Me.lblGMAIL.AutoSize = True
        Me.lblGMAIL.Location = New System.Drawing.Point(360, 386)
        Me.lblGMAIL.Name = "lblGMAIL"
        Me.lblGMAIL.Size = New System.Drawing.Size(245, 13)
        Me.lblGMAIL.TabIndex = 9
        Me.lblGMAIL.Text = "NOTA: AO clicar no ""GMAIL"" poderá enviar e-mail"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PAP_TEI_Joel_Malacas__CHAT_IP_.My.Resources.Resources._2699
        Me.PictureBox1.Location = New System.Drawing.Point(945, 413)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 26)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'btnMAIL
        '
        Me.btnMAIL.BackgroundImage = Global.PAP_TEI_Joel_Malacas__CHAT_IP_.My.Resources.Resources.gmail_new_logo_icon_159149
        Me.btnMAIL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnMAIL.Location = New System.Drawing.Point(386, 101)
        Me.btnMAIL.Name = "btnMAIL"
        Me.btnMAIL.Size = New System.Drawing.Size(314, 230)
        Me.btnMAIL.TabIndex = 8
        Me.btnMAIL.UseSelectable = True
        '
        'btnFTP
        '
        Me.btnFTP.BackgroundImage = Global.PAP_TEI_Joel_Malacas__CHAT_IP_.My.Resources.Resources.kftpgrabber
        Me.btnFTP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnFTP.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnFTP.Location = New System.Drawing.Point(733, 101)
        Me.btnFTP.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFTP.Name = "btnFTP"
        Me.btnFTP.Size = New System.Drawing.Size(314, 230)
        Me.btnFTP.TabIndex = 6
        Me.btnFTP.UseSelectable = True
        '
        'btnCHATIP
        '
        Me.btnCHATIP.BackgroundImage = Global.PAP_TEI_Joel_Malacas__CHAT_IP_.My.Resources.Resources.chat_128
        Me.btnCHATIP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCHATIP.Location = New System.Drawing.Point(33, 101)
        Me.btnCHATIP.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCHATIP.Name = "btnCHATIP"
        Me.btnCHATIP.Size = New System.Drawing.Size(314, 230)
        Me.btnCHATIP.TabIndex = 5
        Me.btnCHATIP.UseSelectable = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1077, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblGMAIL)
        Me.Controls.Add(Me.btnMAIL)
        Me.Controls.Add(Me.btnsair)
        Me.Controls.Add(Me.btnFTP)
        Me.Controls.Add(Me.btnCHATIP)
        Me.Controls.Add(Me.lblFTP)
        Me.Controls.Add(Me.lblchat)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Ferramentas Transmissão IP"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblchat As Label
    Friend WithEvents lblFTP As Label
    Friend WithEvents btnCHATIP As MetroFramework.Controls.MetroButton
    Friend WithEvents btnFTP As MetroFramework.Controls.MetroButton
    Friend WithEvents btnsair As MetroFramework.Controls.MetroButton
    Friend WithEvents tmrPASSE As Timer
    Friend WithEvents btnMAIL As MetroFramework.Controls.MetroButton
    Friend WithEvents lblGMAIL As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
