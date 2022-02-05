<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCHATIP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCHATIP))
        Me.btnsair = New System.Windows.Forms.Button()
        Me.btnmenu = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.textCPIP = New System.Windows.Forms.TextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.btnligar = New MetroFramework.Controls.MetroButton()
        Me.textConPorta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.textNome = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblonline = New System.Windows.Forms.Label()
        Me.lblwait = New System.Windows.Forms.Label()
        Me.lbloffline = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textIP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textporta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDisconnect = New MetroFramework.Controls.MetroButton()
        Me.RichTextCHAT = New System.Windows.Forms.RichTextBox()
        Me.textCHAT = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.NotifyIcon_RECEIVE = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.tooltip_INFO = New MetroFramework.Components.MetroToolTip()
        Me.btnCHAT = New MetroFramework.Controls.MetroButton()
        Me.btnOPEN_FILE = New MetroFramework.Controls.MetroButton()
        Me.btnguardar = New MetroFramework.Controls.MetroButton()
        Me.btndef = New MetroFramework.Controls.MetroButton()
        Me.tmrUPDATE = New System.Windows.Forms.Timer(Me.components)
        Me.picEcra = New System.Windows.Forms.PictureBox()
        Me.btnenviar = New System.Windows.Forms.PictureBox()
        Me.tmrNOTIFIC = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.picEcra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnenviar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnsair
        '
        Me.btnsair.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnsair.BackColor = System.Drawing.Color.Brown
        Me.btnsair.ForeColor = System.Drawing.SystemColors.Menu
        Me.btnsair.Location = New System.Drawing.Point(681, 344)
        Me.btnsair.Name = "btnsair"
        Me.btnsair.Size = New System.Drawing.Size(85, 39)
        Me.btnsair.TabIndex = 0
        Me.btnsair.Text = "Sair do programa"
        Me.btnsair.UseVisualStyleBackColor = False
        '
        'btnmenu
        '
        Me.btnmenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmenu.BackColor = System.Drawing.Color.Yellow
        Me.btnmenu.Location = New System.Drawing.Point(681, 302)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(85, 39)
        Me.btnmenu.TabIndex = 1
        Me.btnmenu.Text = "Ir para menu principal"
        Me.btnmenu.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.textCPIP)
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.Controls.Add(Me.btnligar)
        Me.GroupBox1.Controls.Add(Me.textConPorta)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.textNome)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblonline)
        Me.GroupBox1.Controls.Add(Me.lblwait)
        Me.GroupBox1.Controls.Add(Me.lbloffline)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.textIP)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.textporta)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnDisconnect)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(618, 72)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Conexão Chat IP"
        '
        'textCPIP
        '
        Me.textCPIP.Location = New System.Drawing.Point(278, 50)
        Me.textCPIP.Margin = New System.Windows.Forms.Padding(2)
        Me.textCPIP.Name = "textCPIP"
        Me.textCPIP.Size = New System.Drawing.Size(152, 20)
        Me.textCPIP.TabIndex = 15
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(204, 50)
        Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(70, 19)
        Me.MetroLabel1.TabIndex = 18
        Me.MetroLabel1.Text = "Nome PC:"
        '
        'btnligar
        '
        Me.btnligar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnligar.Location = New System.Drawing.Point(440, 18)
        Me.btnligar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnligar.Name = "btnligar"
        Me.btnligar.Size = New System.Drawing.Size(151, 51)
        Me.btnligar.Style = MetroFramework.MetroColorStyle.Green
        Me.btnligar.TabIndex = 16
        Me.btnligar.Text = "Ligar"
        Me.btnligar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnligar.UseSelectable = True
        '
        'textConPorta
        '
        Me.textConPorta.Location = New System.Drawing.Point(596, 32)
        Me.textConPorta.Name = "textConPorta"
        Me.textConPorta.Size = New System.Drawing.Size(18, 20)
        Me.textConPorta.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(492, 54)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Porta do Parceiro:"
        '
        'textNome
        '
        Me.textNome.Location = New System.Drawing.Point(278, 21)
        Me.textNome.MaxLength = 20
        Me.textNome.Name = "textNome"
        Me.textNome.Size = New System.Drawing.Size(152, 20)
        Me.textNome.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Estado:"
        '
        'lblonline
        '
        Me.lblonline.AutoSize = True
        Me.lblonline.ForeColor = System.Drawing.Color.Green
        Me.lblonline.Location = New System.Drawing.Point(54, 54)
        Me.lblonline.Name = "lblonline"
        Me.lblonline.Size = New System.Drawing.Size(37, 13)
        Me.lblonline.TabIndex = 11
        Me.lblonline.Text = "Online"
        '
        'lblwait
        '
        Me.lblwait.AutoSize = True
        Me.lblwait.ForeColor = System.Drawing.Color.Yellow
        Me.lblwait.Location = New System.Drawing.Point(54, 54)
        Me.lblwait.Name = "lblwait"
        Me.lblwait.Size = New System.Drawing.Size(96, 13)
        Me.lblwait.TabIndex = 10
        Me.lblwait.Text = "Esperar a conexão"
        '
        'lbloffline
        '
        Me.lbloffline.AutoSize = True
        Me.lbloffline.ForeColor = System.Drawing.Color.Red
        Me.lbloffline.Location = New System.Drawing.Point(54, 54)
        Me.lbloffline.Name = "lbloffline"
        Me.lbloffline.Size = New System.Drawing.Size(37, 13)
        Me.lbloffline.TabIndex = 9
        Me.lbloffline.Text = "Offilne"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(232, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "NOME:"
        '
        'textIP
        '
        Me.textIP.Location = New System.Drawing.Point(30, 21)
        Me.textIP.Name = "textIP"
        Me.textIP.Size = New System.Drawing.Size(183, 20)
        Me.textIP.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "IP:"
        '
        'textporta
        '
        Me.textporta.Location = New System.Drawing.Point(592, 21)
        Me.textporta.Name = "textporta"
        Me.textporta.Size = New System.Drawing.Size(21, 20)
        Me.textporta.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(578, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Porta:"
        '
        'btnDisconnect
        '
        Me.btnDisconnect.BackColor = System.Drawing.Color.Red
        Me.btnDisconnect.Location = New System.Drawing.Point(440, 18)
        Me.btnDisconnect.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(151, 51)
        Me.btnDisconnect.TabIndex = 17
        Me.btnDisconnect.Text = "Disconectar"
        Me.btnDisconnect.UseSelectable = True
        '
        'RichTextCHAT
        '
        Me.RichTextCHAT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RichTextCHAT.Location = New System.Drawing.Point(34, 99)
        Me.RichTextCHAT.Name = "RichTextCHAT"
        Me.RichTextCHAT.ReadOnly = True
        Me.RichTextCHAT.Size = New System.Drawing.Size(619, 286)
        Me.RichTextCHAT.TabIndex = 3
        Me.RichTextCHAT.Text = ""
        '
        'textCHAT
        '
        Me.textCHAT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textCHAT.Location = New System.Drawing.Point(34, 399)
        Me.textCHAT.Name = "textCHAT"
        Me.textCHAT.Size = New System.Drawing.Size(619, 20)
        Me.textCHAT.TabIndex = 4
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "Guardar Conversa.txt"
        Me.OpenFileDialog1.InitialDirectory = "C:\"
        '
        'NotifyIcon_RECEIVE
        '
        Me.NotifyIcon_RECEIVE.Text = "NotifyIcon1"
        Me.NotifyIcon_RECEIVE.Visible = True
        '
        'tooltip_INFO
        '
        Me.tooltip_INFO.Style = MetroFramework.MetroColorStyle.Blue
        Me.tooltip_INFO.StyleManager = Nothing
        Me.tooltip_INFO.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'btnCHAT
        '
        Me.btnCHAT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCHAT.Location = New System.Drawing.Point(681, 118)
        Me.btnCHAT.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCHAT.Name = "btnCHAT"
        Me.btnCHAT.Size = New System.Drawing.Size(85, 29)
        Me.btnCHAT.TabIndex = 11
        Me.btnCHAT.Text = "Limpar CHAT"
        Me.btnCHAT.UseSelectable = True
        '
        'btnOPEN_FILE
        '
        Me.btnOPEN_FILE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOPEN_FILE.Location = New System.Drawing.Point(681, 152)
        Me.btnOPEN_FILE.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOPEN_FILE.Name = "btnOPEN_FILE"
        Me.btnOPEN_FILE.Size = New System.Drawing.Size(85, 37)
        Me.btnOPEN_FILE.TabIndex = 12
        Me.btnOPEN_FILE.Text = "Abrir Conversa"
        Me.btnOPEN_FILE.UseSelectable = True
        '
        'btnguardar
        '
        Me.btnguardar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnguardar.Location = New System.Drawing.Point(681, 194)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(85, 52)
        Me.btnguardar.TabIndex = 13
        Me.btnguardar.Text = "Guardar Conversa"
        Me.btnguardar.UseSelectable = True
        '
        'btndef
        '
        Me.btndef.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btndef.Location = New System.Drawing.Point(681, 251)
        Me.btndef.Margin = New System.Windows.Forms.Padding(2)
        Me.btndef.Name = "btndef"
        Me.btndef.Size = New System.Drawing.Size(85, 46)
        Me.btndef.TabIndex = 14
        Me.btndef.Text = "Definições"
        Me.btndef.UseSelectable = True
        '
        'tmrUPDATE
        '
        '
        'picEcra
        '
        Me.picEcra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picEcra.Image = Global.PAP_TEI_Joel_Malacas__CHAT_IP_.My.Resources.Resources.display_103578
        Me.picEcra.Location = New System.Drawing.Point(703, 55)
        Me.picEcra.Margin = New System.Windows.Forms.Padding(2)
        Me.picEcra.Name = "picEcra"
        Me.picEcra.Size = New System.Drawing.Size(36, 37)
        Me.picEcra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEcra.TabIndex = 15
        Me.picEcra.TabStop = False
        '
        'btnenviar
        '
        Me.btnenviar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnenviar.Image = Global.PAP_TEI_Joel_Malacas__CHAT_IP_.My.Resources.Resources.pngtree_send_icon_png_image_3581535
        Me.btnenviar.Location = New System.Drawing.Point(681, 390)
        Me.btnenviar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnenviar.Name = "btnenviar"
        Me.btnenviar.Size = New System.Drawing.Size(36, 37)
        Me.btnenviar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnenviar.TabIndex = 10
        Me.btnenviar.TabStop = False
        '
        'tmrNOTIFIC
        '
        '
        'frmCHATIP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(796, 436)
        Me.Controls.Add(Me.picEcra)
        Me.Controls.Add(Me.btndef)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btnOPEN_FILE)
        Me.Controls.Add(Me.btnCHAT)
        Me.Controls.Add(Me.btnenviar)
        Me.Controls.Add(Me.textCHAT)
        Me.Controls.Add(Me.RichTextCHAT)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnmenu)
        Me.Controls.Add(Me.btnsair)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCHATIP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CHAT IP.exe"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picEcra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnenviar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnsair As Button
    Friend WithEvents btnmenu As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents textporta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents textIP As TextBox
    Friend WithEvents textConPorta As TextBox
    Friend WithEvents textNome As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RichTextCHAT As RichTextBox
    Friend WithEvents textCHAT As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblonline As Label
    Friend WithEvents lblwait As Label
    Friend WithEvents lbloffline As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Label4 As Label
    Friend WithEvents NotifyIcon_RECEIVE As NotifyIcon
    Friend WithEvents btnligar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDisconnect As MetroFramework.Controls.MetroButton
    Friend WithEvents btnenviar As PictureBox
    Friend WithEvents tooltip_INFO As MetroFramework.Components.MetroToolTip
    Friend WithEvents btnCHAT As MetroFramework.Controls.MetroButton
    Friend WithEvents btnOPEN_FILE As MetroFramework.Controls.MetroButton
    Friend WithEvents btnguardar As MetroFramework.Controls.MetroButton
    Friend WithEvents btndef As MetroFramework.Controls.MetroButton
    Friend WithEvents textCPIP As TextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tmrUPDATE As Timer
    Friend WithEvents picEcra As PictureBox
    Friend WithEvents tmrNOTIFIC As Timer
End Class
