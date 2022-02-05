<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_esq_passe
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_esq_passe))
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.textEnviar_email = New MetroFramework.Controls.MetroTextBox()
        Me.btnEnviar = New MetroFramework.Controls.MetroButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(12, 38)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(50, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "E-Mail:"
        '
        'textEnviar_email
        '
        '
        '
        '
        Me.textEnviar_email.CustomButton.Image = Nothing
        Me.textEnviar_email.CustomButton.Location = New System.Drawing.Point(185, 1)
        Me.textEnviar_email.CustomButton.Name = ""
        Me.textEnviar_email.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.textEnviar_email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.textEnviar_email.CustomButton.TabIndex = 1
        Me.textEnviar_email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.textEnviar_email.CustomButton.UseSelectable = True
        Me.textEnviar_email.CustomButton.Visible = False
        Me.textEnviar_email.Lines = New String(-1) {}
        Me.textEnviar_email.Location = New System.Drawing.Point(68, 38)
        Me.textEnviar_email.MaxLength = 32767
        Me.textEnviar_email.Name = "textEnviar_email"
        Me.textEnviar_email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.textEnviar_email.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.textEnviar_email.SelectedText = ""
        Me.textEnviar_email.SelectionLength = 0
        Me.textEnviar_email.SelectionStart = 0
        Me.textEnviar_email.ShortcutsEnabled = True
        Me.textEnviar_email.Size = New System.Drawing.Size(207, 23)
        Me.textEnviar_email.TabIndex = 1
        Me.textEnviar_email.UseSelectable = True
        Me.textEnviar_email.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.textEnviar_email.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(98, 92)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(134, 23)
        Me.btnEnviar.TabIndex = 2
        Me.btnEnviar.Text = "Enviar palavra-passe"
        Me.btnEnviar.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "(Insere o E-Mail que selecionaste nas defenições)"
        '
        'frm_esq_passe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 127)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.textEnviar_email)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_esq_passe"
        Me.Text = "Passe.exe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents textEnviar_email As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnEnviar As MetroFramework.Controls.MetroButton
    Friend WithEvents Label1 As Label
End Class
