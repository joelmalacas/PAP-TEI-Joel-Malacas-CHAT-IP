<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDEF
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDEF))
        Me.btnfechar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnOsk = New MetroFramework.Controls.MetroButton()
        Me.checkNOTIFIC = New MetroFramework.Controls.MetroCheckBox()
        Me.checkArranque = New MetroFramework.Controls.MetroCheckBox()
        Me.btnCHECKINTERNET = New MetroFramework.Controls.MetroButton()
        Me.checkATALHO = New MetroFramework.Controls.MetroCheckBox()
        Me.btnINFOLOCALHOST = New MetroFramework.Controls.MetroButton()
        Me.btnIPWAN = New MetroFramework.Controls.MetroButton()
        Me.btnAlterar = New MetroFramework.Controls.MetroButton()
        Me.seguranca = New MetroFramework.Controls.MetroCheckBox()
        Me.btnping = New MetroFramework.Controls.MetroButton()
        Me.txtIP_GEOLOCATOR = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.textPERSONAL_NOME = New MetroFramework.Controls.MetroTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.CbNome = New MetroFramework.Controls.MetroComboBox()
        Me.cbCCHAT = New MetroFramework.Controls.MetroComboBox()
        Me.cbcolor = New MetroFramework.Controls.MetroComboBox()
        Me.cbtema = New MetroFramework.Controls.MetroComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAplic = New System.Windows.Forms.Button()
        Me.btndefault = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tmrUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.TextPORTACP = New MetroFramework.Controls.MetroTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnfechar
        '
        Me.btnfechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnfechar.BackColor = System.Drawing.Color.Red
        Me.btnfechar.Location = New System.Drawing.Point(413, 315)
        Me.btnfechar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnfechar.Name = "btnfechar"
        Me.btnfechar.Size = New System.Drawing.Size(82, 35)
        Me.btnfechar.TabIndex = 0
        Me.btnfechar.Text = "Fechar"
        Me.btnfechar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnOsk)
        Me.GroupBox1.Controls.Add(Me.checkNOTIFIC)
        Me.GroupBox1.Controls.Add(Me.checkArranque)
        Me.GroupBox1.Controls.Add(Me.btnCHECKINTERNET)
        Me.GroupBox1.Controls.Add(Me.checkATALHO)
        Me.GroupBox1.Controls.Add(Me.btnINFOLOCALHOST)
        Me.GroupBox1.Controls.Add(Me.btnIPWAN)
        Me.GroupBox1.Controls.Add(Me.btnAlterar)
        Me.GroupBox1.Controls.Add(Me.seguranca)
        Me.GroupBox1.Controls.Add(Me.btnping)
        Me.GroupBox1.Controls.Add(Me.txtIP_GEOLOCATOR)
        Me.GroupBox1.Controls.Add(Me.MetroLabel2)
        Me.GroupBox1.Controls.Add(Me.textPERSONAL_NOME)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.Controls.Add(Me.CbNome)
        Me.GroupBox1.Controls.Add(Me.cbCCHAT)
        Me.GroupBox1.Controls.Add(Me.cbcolor)
        Me.GroupBox1.Controls.Add(Me.cbtema)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(489, 301)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Definições"
        '
        'btnOsk
        '
        Me.btnOsk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOsk.Location = New System.Drawing.Point(347, 158)
        Me.btnOsk.Name = "btnOsk"
        Me.btnOsk.Size = New System.Drawing.Size(137, 29)
        Me.btnOsk.TabIndex = 30
        Me.btnOsk.Text = "Abrir teclado virtual"
        Me.btnOsk.UseSelectable = True
        '
        'checkNOTIFIC
        '
        Me.checkNOTIFIC.AutoSize = True
        Me.checkNOTIFIC.Location = New System.Drawing.Point(4, 204)
        Me.checkNOTIFIC.Name = "checkNOTIFIC"
        Me.checkNOTIFIC.Size = New System.Drawing.Size(135, 15)
        Me.checkNOTIFIC.TabIndex = 29
        Me.checkNOTIFIC.Text = "Ativar as notificações"
        Me.checkNOTIFIC.UseSelectable = True
        '
        'checkArranque
        '
        Me.checkArranque.AutoSize = True
        Me.checkArranque.Location = New System.Drawing.Point(4, 224)
        Me.checkArranque.Name = "checkArranque"
        Me.checkArranque.Size = New System.Drawing.Size(156, 15)
        Me.checkArranque.TabIndex = 28
        Me.checkArranque.Text = "Ativar opção de arranque"
        Me.checkArranque.UseSelectable = True
        '
        'btnCHECKINTERNET
        '
        Me.btnCHECKINTERNET.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCHECKINTERNET.Location = New System.Drawing.Point(347, 122)
        Me.btnCHECKINTERNET.Name = "btnCHECKINTERNET"
        Me.btnCHECKINTERNET.Size = New System.Drawing.Size(137, 29)
        Me.btnCHECKINTERNET.TabIndex = 27
        Me.btnCHECKINTERNET.Text = "Verificar conexção INTERNET"
        Me.btnCHECKINTERNET.UseSelectable = True
        '
        'checkATALHO
        '
        Me.checkATALHO.AutoSize = True
        Me.checkATALHO.Location = New System.Drawing.Point(4, 183)
        Me.checkATALHO.Name = "checkATALHO"
        Me.checkATALHO.Size = New System.Drawing.Size(87, 15)
        Me.checkATALHO.TabIndex = 26
        Me.checkATALHO.Text = "Criar atalho "
        Me.checkATALHO.UseSelectable = True
        '
        'btnINFOLOCALHOST
        '
        Me.btnINFOLOCALHOST.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnINFOLOCALHOST.Location = New System.Drawing.Point(347, 87)
        Me.btnINFOLOCALHOST.Name = "btnINFOLOCALHOST"
        Me.btnINFOLOCALHOST.Size = New System.Drawing.Size(137, 29)
        Me.btnINFOLOCALHOST.TabIndex = 25
        Me.btnINFOLOCALHOST.Text = "IP & DNS || LOCALHOST"
        Me.btnINFOLOCALHOST.UseSelectable = True
        '
        'btnIPWAN
        '
        Me.btnIPWAN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIPWAN.Location = New System.Drawing.Point(347, 52)
        Me.btnIPWAN.Name = "btnIPWAN"
        Me.btnIPWAN.Size = New System.Drawing.Size(137, 29)
        Me.btnIPWAN.TabIndex = 24
        Me.btnIPWAN.Text = "Geolocalizador"
        Me.btnIPWAN.UseSelectable = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAlterar.Location = New System.Drawing.Point(347, 17)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(137, 29)
        Me.btnAlterar.TabIndex = 23
        Me.btnAlterar.Text = "Alterar palavra-passe"
        Me.btnAlterar.UseSelectable = True
        '
        'seguranca
        '
        Me.seguranca.AutoSize = True
        Me.seguranca.Location = New System.Drawing.Point(4, 245)
        Me.seguranca.Name = "seguranca"
        Me.seguranca.Size = New System.Drawing.Size(272, 15)
        Me.seguranca.TabIndex = 21
        Me.seguranca.Text = "Ativar segurança de palavra-passe no arranque "
        Me.seguranca.UseSelectable = True
        '
        'btnping
        '
        Me.btnping.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnping.BackColor = System.Drawing.Color.LimeGreen
        Me.btnping.Location = New System.Drawing.Point(324, 266)
        Me.btnping.Margin = New System.Windows.Forms.Padding(2)
        Me.btnping.Name = "btnping"
        Me.btnping.Size = New System.Drawing.Size(160, 23)
        Me.btnping.TabIndex = 20
        Me.btnping.Text = "PING"
        Me.btnping.UseSelectable = True
        '
        'txtIP_GEOLOCATOR
        '
        Me.txtIP_GEOLOCATOR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtIP_GEOLOCATOR.CustomButton.Image = Nothing
        Me.txtIP_GEOLOCATOR.CustomButton.Location = New System.Drawing.Point(119, 1)
        Me.txtIP_GEOLOCATOR.CustomButton.Name = ""
        Me.txtIP_GEOLOCATOR.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtIP_GEOLOCATOR.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtIP_GEOLOCATOR.CustomButton.TabIndex = 1
        Me.txtIP_GEOLOCATOR.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtIP_GEOLOCATOR.CustomButton.UseSelectable = True
        Me.txtIP_GEOLOCATOR.CustomButton.Visible = False
        Me.txtIP_GEOLOCATOR.Lines = New String(-1) {}
        Me.txtIP_GEOLOCATOR.Location = New System.Drawing.Point(135, 266)
        Me.txtIP_GEOLOCATOR.MaxLength = 32767
        Me.txtIP_GEOLOCATOR.Name = "txtIP_GEOLOCATOR"
        Me.txtIP_GEOLOCATOR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIP_GEOLOCATOR.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtIP_GEOLOCATOR.SelectedText = ""
        Me.txtIP_GEOLOCATOR.SelectionLength = 0
        Me.txtIP_GEOLOCATOR.SelectionStart = 0
        Me.txtIP_GEOLOCATOR.ShortcutsEnabled = True
        Me.txtIP_GEOLOCATOR.Size = New System.Drawing.Size(141, 23)
        Me.txtIP_GEOLOCATOR.TabIndex = 19
        Me.txtIP_GEOLOCATOR.UseSelectable = True
        Me.txtIP_GEOLOCATOR.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtIP_GEOLOCATOR.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(6, 270)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(123, 19)
        Me.MetroLabel2.TabIndex = 18
        Me.MetroLabel2.Text = "Inserir IP para Ping:"
        '
        'textPERSONAL_NOME
        '
        '
        '
        '
        Me.textPERSONAL_NOME.CustomButton.Image = Nothing
        Me.textPERSONAL_NOME.CustomButton.Location = New System.Drawing.Point(68, 2)
        Me.textPERSONAL_NOME.CustomButton.Margin = New System.Windows.Forms.Padding(2)
        Me.textPERSONAL_NOME.CustomButton.Name = ""
        Me.textPERSONAL_NOME.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.textPERSONAL_NOME.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.textPERSONAL_NOME.CustomButton.TabIndex = 1
        Me.textPERSONAL_NOME.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.textPERSONAL_NOME.CustomButton.UseSelectable = True
        Me.textPERSONAL_NOME.CustomButton.Visible = False
        Me.textPERSONAL_NOME.Lines = New String(-1) {}
        Me.textPERSONAL_NOME.Location = New System.Drawing.Point(135, 142)
        Me.textPERSONAL_NOME.Margin = New System.Windows.Forms.Padding(2)
        Me.textPERSONAL_NOME.MaxLength = 32767
        Me.textPERSONAL_NOME.Name = "textPERSONAL_NOME"
        Me.textPERSONAL_NOME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.textPERSONAL_NOME.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.textPERSONAL_NOME.SelectedText = ""
        Me.textPERSONAL_NOME.SelectionLength = 0
        Me.textPERSONAL_NOME.SelectionStart = 0
        Me.textPERSONAL_NOME.ShortcutsEnabled = True
        Me.textPERSONAL_NOME.Size = New System.Drawing.Size(96, 30)
        Me.textPERSONAL_NOME.TabIndex = 17
        Me.textPERSONAL_NOME.UseSelectable = True
        Me.textPERSONAL_NOME.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.textPERSONAL_NOME.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(2, 150)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Nome Personalizado:"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(0, 179)
        Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(0, 0)
        Me.MetroLabel1.TabIndex = 15
        '
        'CbNome
        '
        Me.CbNome.FormattingEnabled = True
        Me.CbNome.ItemHeight = 23
        Me.CbNome.Items.AddRange(New Object() {"Vermelho", "Amarelo", "Verde", "Cinzento", "Branco", "Azul", "Preto"})
        Me.CbNome.Location = New System.Drawing.Point(136, 80)
        Me.CbNome.Margin = New System.Windows.Forms.Padding(2)
        Me.CbNome.Name = "CbNome"
        Me.CbNome.Size = New System.Drawing.Size(95, 29)
        Me.CbNome.TabIndex = 14
        Me.CbNome.UseSelectable = True
        '
        'cbCCHAT
        '
        Me.cbCCHAT.FormattingEnabled = True
        Me.cbCCHAT.ItemHeight = 23
        Me.cbCCHAT.Items.AddRange(New Object() {"Vermelho", "Amarelo", "Verde", "Cinzento", "Branco", "Azul", "Preto"})
        Me.cbCCHAT.Location = New System.Drawing.Point(136, 49)
        Me.cbCCHAT.Margin = New System.Windows.Forms.Padding(2)
        Me.cbCCHAT.Name = "cbCCHAT"
        Me.cbCCHAT.Size = New System.Drawing.Size(95, 29)
        Me.cbCCHAT.TabIndex = 13
        Me.cbCCHAT.UseSelectable = True
        '
        'cbcolor
        '
        Me.cbcolor.FormattingEnabled = True
        Me.cbcolor.ItemHeight = 23
        Me.cbcolor.Items.AddRange(New Object() {"Vermelho", "Amarelo", "Verde", "Cinzento", "Branco", "Azul", "Azul-Claro"})
        Me.cbcolor.Location = New System.Drawing.Point(136, 17)
        Me.cbcolor.Margin = New System.Windows.Forms.Padding(2)
        Me.cbcolor.Name = "cbcolor"
        Me.cbcolor.Size = New System.Drawing.Size(95, 29)
        Me.cbcolor.TabIndex = 12
        Me.cbcolor.UseSelectable = True
        '
        'cbtema
        '
        Me.cbtema.FormattingEnabled = True
        Me.cbtema.ItemHeight = 23
        Me.cbtema.Items.AddRange(New Object() {"Modo escuro", "Modo Claro", "Nenhum"})
        Me.cbtema.Location = New System.Drawing.Point(136, 109)
        Me.cbtema.Margin = New System.Windows.Forms.Padding(2)
        Me.cbtema.Name = "cbtema"
        Me.cbtema.Size = New System.Drawing.Size(95, 29)
        Me.cbtema.TabIndex = 11
        Me.cbtema.UseSelectable = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 111)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Mudar Cor do Tema:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 82)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Mudar a Cor do Texto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 51)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mudar Cor da Conversa:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mudar Cor do Backgroud:"
        '
        'btnAplic
        '
        Me.btnAplic.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAplic.BackColor = System.Drawing.Color.Lime
        Me.btnAplic.Location = New System.Drawing.Point(333, 315)
        Me.btnAplic.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAplic.Name = "btnAplic"
        Me.btnAplic.Size = New System.Drawing.Size(73, 35)
        Me.btnAplic.TabIndex = 2
        Me.btnAplic.Text = "Aplicar"
        Me.btnAplic.UseVisualStyleBackColor = False
        '
        'btndefault
        '
        Me.btndefault.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btndefault.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btndefault.Location = New System.Drawing.Point(255, 315)
        Me.btndefault.Margin = New System.Windows.Forms.Padding(2)
        Me.btndefault.Name = "btndefault"
        Me.btndefault.Size = New System.Drawing.Size(74, 35)
        Me.btndefault.TabIndex = 3
        Me.btndefault.Text = "Default"
        Me.btndefault.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(147, 326)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(93, 13)
        Me.LinkLabel1.TabIndex = 5
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Precisa de Ajuda?"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1, 326)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "PORTA:"
        '
        'tmrUpdate
        '
        '
        'TextPORTACP
        '
        Me.TextPORTACP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.TextPORTACP.CustomButton.Image = Nothing
        Me.TextPORTACP.CustomButton.Location = New System.Drawing.Point(60, 1)
        Me.TextPORTACP.CustomButton.Margin = New System.Windows.Forms.Padding(2)
        Me.TextPORTACP.CustomButton.Name = ""
        Me.TextPORTACP.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.TextPORTACP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TextPORTACP.CustomButton.TabIndex = 1
        Me.TextPORTACP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TextPORTACP.CustomButton.UseSelectable = True
        Me.TextPORTACP.CustomButton.Visible = False
        Me.TextPORTACP.Lines = New String(-1) {}
        Me.TextPORTACP.Location = New System.Drawing.Point(51, 322)
        Me.TextPORTACP.Margin = New System.Windows.Forms.Padding(2)
        Me.TextPORTACP.MaxLength = 32767
        Me.TextPORTACP.Name = "TextPORTACP"
        Me.TextPORTACP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextPORTACP.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TextPORTACP.SelectedText = ""
        Me.TextPORTACP.SelectionLength = 0
        Me.TextPORTACP.SelectionStart = 0
        Me.TextPORTACP.ShortcutsEnabled = True
        Me.TextPORTACP.Size = New System.Drawing.Size(76, 17)
        Me.TextPORTACP.TabIndex = 6
        Me.TextPORTACP.UseSelectable = True
        Me.TextPORTACP.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TextPORTACP.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'frmDEF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 354)
        Me.Controls.Add(Me.TextPORTACP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.btndefault)
        Me.Controls.Add(Me.btnAplic)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnfechar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmDEF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnfechar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAplic As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btndefault As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents tmrUpdate As Timer
    Friend WithEvents cbtema As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CbNome As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cbCCHAT As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cbcolor As MetroFramework.Controls.MetroComboBox
    Friend WithEvents TextPORTACP As MetroFramework.Controls.MetroTextBox
    Friend WithEvents textPERSONAL_NOME As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnping As MetroFramework.Controls.MetroButton
    Friend WithEvents txtIP_GEOLOCATOR As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents seguranca As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents btnAlterar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnIPWAN As MetroFramework.Controls.MetroButton
    Friend WithEvents btnINFOLOCALHOST As MetroFramework.Controls.MetroButton
    Friend WithEvents checkATALHO As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents btnCHECKINTERNET As MetroFramework.Controls.MetroButton
    Friend WithEvents checkArranque As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents checkNOTIFIC As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents btnOsk As MetroFramework.Controls.MetroButton
End Class
