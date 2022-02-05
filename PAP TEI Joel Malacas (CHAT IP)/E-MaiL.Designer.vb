<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMAIL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMAIL))
        Me.btnsair = New MetroFramework.Controls.MetroButton()
        Me.btnMENU = New MetroFramework.Controls.MetroButton()
        Me.btnENDERECO = New MetroFramework.Controls.MetroButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstAnexos = New System.Windows.Forms.ListBox()
        Me.btnAnexar = New MetroFramework.Controls.MetroButton()
        Me.txtAssunto = New System.Windows.Forms.TextBox()
        Me.btnEnviar = New MetroFramework.Controls.MetroButton()
        Me.btnVisualizar = New MetroFramework.Controls.MetroButton()
        Me.textPara = New System.Windows.Forms.TextBox()
        Me.textOrigem = New System.Windows.Forms.TextBox()
        Me.textAssunto = New System.Windows.Forms.TextBox()
        Me.tmrORIGEM = New System.Windows.Forms.Timer(Me.components)
        Me.btnREMOVE = New MetroFramework.Controls.MetroButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textCC = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.textbcc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnVIEW = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'btnsair
        '
        Me.btnsair.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnsair.Location = New System.Drawing.Point(787, 606)
        Me.btnsair.Name = "btnsair"
        Me.btnsair.Size = New System.Drawing.Size(140, 37)
        Me.btnsair.TabIndex = 0
        Me.btnsair.Text = "Sair"
        Me.btnsair.UseSelectable = True
        '
        'btnMENU
        '
        Me.btnMENU.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMENU.Location = New System.Drawing.Point(787, 563)
        Me.btnMENU.Name = "btnMENU"
        Me.btnMENU.Size = New System.Drawing.Size(140, 37)
        Me.btnMENU.TabIndex = 1
        Me.btnMENU.Text = "Ir para menu principal"
        Me.btnMENU.UseSelectable = True
        '
        'btnENDERECO
        '
        Me.btnENDERECO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnENDERECO.Location = New System.Drawing.Point(787, 520)
        Me.btnENDERECO.Name = "btnENDERECO"
        Me.btnENDERECO.Size = New System.Drawing.Size(140, 37)
        Me.btnENDERECO.TabIndex = 2
        Me.btnENDERECO.Text = "Mudar endereço eletrónico"
        Me.btnENDERECO.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Para:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Origem:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Assunto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Anexos:"
        '
        'lstAnexos
        '
        Me.lstAnexos.AllowDrop = True
        Me.lstAnexos.FormattingEnabled = True
        Me.lstAnexos.Location = New System.Drawing.Point(81, 133)
        Me.lstAnexos.Name = "lstAnexos"
        Me.lstAnexos.Size = New System.Drawing.Size(395, 69)
        Me.lstAnexos.TabIndex = 21
        '
        'btnAnexar
        '
        Me.btnAnexar.Location = New System.Drawing.Point(480, 133)
        Me.btnAnexar.Name = "btnAnexar"
        Me.btnAnexar.Size = New System.Drawing.Size(142, 42)
        Me.btnAnexar.TabIndex = 22
        Me.btnAnexar.Text = "Anexar Ficheiros"
        Me.btnAnexar.UseSelectable = True
        '
        'txtAssunto
        '
        Me.txtAssunto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtAssunto.Location = New System.Drawing.Point(81, 237)
        Me.txtAssunto.Multiline = True
        Me.txtAssunto.Name = "txtAssunto"
        Me.txtAssunto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAssunto.Size = New System.Drawing.Size(541, 363)
        Me.txtAssunto.TabIndex = 26
        '
        'btnEnviar
        '
        Me.btnEnviar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEnviar.Location = New System.Drawing.Point(81, 605)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(289, 38)
        Me.btnEnviar.TabIndex = 27
        Me.btnEnviar.Text = "Enviar E-Mail"
        Me.btnEnviar.UseSelectable = True
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnVisualizar.Location = New System.Drawing.Point(376, 605)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(246, 38)
        Me.btnVisualizar.TabIndex = 29
        Me.btnVisualizar.Text = "Visualizar"
        Me.btnVisualizar.UseSelectable = True
        '
        'textPara
        '
        Me.textPara.Location = New System.Drawing.Point(81, 51)
        Me.textPara.Name = "textPara"
        Me.textPara.Size = New System.Drawing.Size(395, 20)
        Me.textPara.TabIndex = 30
        '
        'textOrigem
        '
        Me.textOrigem.Location = New System.Drawing.Point(81, 25)
        Me.textOrigem.Name = "textOrigem"
        Me.textOrigem.Size = New System.Drawing.Size(395, 20)
        Me.textOrigem.TabIndex = 31
        '
        'textAssunto
        '
        Me.textAssunto.Location = New System.Drawing.Point(81, 208)
        Me.textAssunto.Name = "textAssunto"
        Me.textAssunto.Size = New System.Drawing.Size(541, 20)
        Me.textAssunto.TabIndex = 32
        '
        'tmrORIGEM
        '
        '
        'btnREMOVE
        '
        Me.btnREMOVE.Location = New System.Drawing.Point(480, 179)
        Me.btnREMOVE.Name = "btnREMOVE"
        Me.btnREMOVE.Size = New System.Drawing.Size(142, 23)
        Me.btnREMOVE.TabIndex = 33
        Me.btnREMOVE.Text = "Excluir anexos"
        Me.btnREMOVE.UseSelectable = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "CC:"
        '
        'textCC
        '
        Me.textCC.Location = New System.Drawing.Point(81, 82)
        Me.textCC.Name = "textCC"
        Me.textCC.Size = New System.Drawing.Size(395, 20)
        Me.textCC.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Bcc:"
        '
        'textbcc
        '
        Me.textbcc.Location = New System.Drawing.Point(81, 108)
        Me.textbcc.Name = "textbcc"
        Me.textbcc.Size = New System.Drawing.Size(395, 20)
        Me.textbcc.TabIndex = 37
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 240)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Mensagem:"
        '
        'btnVIEW
        '
        Me.btnVIEW.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVIEW.Location = New System.Drawing.Point(787, 477)
        Me.btnVIEW.Name = "btnVIEW"
        Me.btnVIEW.Size = New System.Drawing.Size(140, 37)
        Me.btnVIEW.TabIndex = 39
        Me.btnVIEW.Text = "Pré-visualização ficheiro"
        Me.btnVIEW.UseSelectable = True
        '
        'frmMAIL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(939, 655)
        Me.Controls.Add(Me.btnVIEW)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.textbcc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.textCC)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.textAssunto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnREMOVE)
        Me.Controls.Add(Me.textOrigem)
        Me.Controls.Add(Me.textPara)
        Me.Controls.Add(Me.btnVisualizar)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.txtAssunto)
        Me.Controls.Add(Me.btnAnexar)
        Me.Controls.Add(Me.lstAnexos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnENDERECO)
        Me.Controls.Add(Me.btnMENU)
        Me.Controls.Add(Me.btnsair)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMAIL"
        Me.Text = "E-Mail.exe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnsair As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMENU As MetroFramework.Controls.MetroButton
    Friend WithEvents btnENDERECO As MetroFramework.Controls.MetroButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lstAnexos As ListBox
    Friend WithEvents btnAnexar As MetroFramework.Controls.MetroButton
    Friend WithEvents txtAssunto As TextBox
    Friend WithEvents btnEnviar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnVisualizar As MetroFramework.Controls.MetroButton
    Friend WithEvents textPara As TextBox
    Friend WithEvents textOrigem As TextBox
    Friend WithEvents textAssunto As TextBox
    Friend WithEvents tmrORIGEM As Timer
    Friend WithEvents btnREMOVE As MetroFramework.Controls.MetroButton
    Friend WithEvents Label5 As Label
    Friend WithEvents textCC As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents textbcc As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnVIEW As MetroFramework.Controls.MetroButton
End Class
