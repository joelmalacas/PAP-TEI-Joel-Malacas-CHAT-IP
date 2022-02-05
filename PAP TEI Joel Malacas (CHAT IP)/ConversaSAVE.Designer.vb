<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConversa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConversa))
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.txtCHATSAVE = New MetroFramework.Controls.MetroTextBox()
        Me.SuspendLayout()
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(589, 317)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Fechar"
        '
        'txtCHATSAVE
        '
        '
        '
        '
        Me.txtCHATSAVE.CustomButton.Image = Nothing
        Me.txtCHATSAVE.CustomButton.Location = New System.Drawing.Point(315, 1)
        Me.txtCHATSAVE.CustomButton.Name = ""
        Me.txtCHATSAVE.CustomButton.Size = New System.Drawing.Size(347, 347)
        Me.txtCHATSAVE.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCHATSAVE.CustomButton.TabIndex = 1
        Me.txtCHATSAVE.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCHATSAVE.CustomButton.UseSelectable = True
        Me.txtCHATSAVE.CustomButton.Visible = False
        Me.txtCHATSAVE.Lines = New String(-1) {}
        Me.txtCHATSAVE.Location = New System.Drawing.Point(2, 2)
        Me.txtCHATSAVE.MaxLength = 32767
        Me.txtCHATSAVE.Multiline = True
        Me.txtCHATSAVE.Name = "txtCHATSAVE"
        Me.txtCHATSAVE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCHATSAVE.ReadOnly = True
        Me.txtCHATSAVE.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCHATSAVE.SelectedText = ""
        Me.txtCHATSAVE.SelectionLength = 0
        Me.txtCHATSAVE.SelectionStart = 0
        Me.txtCHATSAVE.ShortcutsEnabled = True
        Me.txtCHATSAVE.Size = New System.Drawing.Size(663, 349)
        Me.txtCHATSAVE.TabIndex = 2
        Me.txtCHATSAVE.UseSelectable = True
        Me.txtCHATSAVE.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCHATSAVE.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'frmConversa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(668, 352)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.txtCHATSAVE)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConversa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conversa Guardada"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents txtCHATSAVE As MetroFramework.Controls.MetroTextBox
End Class
