<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCMD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCMD))
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.textCMD = New MetroFramework.Controls.MetroTextBox()
        Me.SuspendLayout()
        '
        'Cancel_Button
        '
        resources.ApplyResources(Me.Cancel_Button, "Cancel_Button")
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Name = "Cancel_Button"
        '
        'textCMD
        '
        resources.ApplyResources(Me.textCMD, "textCMD")
        Me.textCMD.BackColor = System.Drawing.Color.Black
        '
        '
        '
        Me.textCMD.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription")
        Me.textCMD.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName")
        Me.textCMD.CustomButton.Anchor = CType(resources.GetObject("resource.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.textCMD.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize"), Boolean)
        Me.textCMD.CustomButton.AutoSizeMode = CType(resources.GetObject("resource.AutoSizeMode"), System.Windows.Forms.AutoSizeMode)
        Me.textCMD.CustomButton.BackgroundImage = CType(resources.GetObject("resource.BackgroundImage"), System.Drawing.Image)
        Me.textCMD.CustomButton.BackgroundImageLayout = CType(resources.GetObject("resource.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.textCMD.CustomButton.Dock = CType(resources.GetObject("resource.Dock"), System.Windows.Forms.DockStyle)
        Me.textCMD.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.textCMD.CustomButton.Font = CType(resources.GetObject("resource.Font"), System.Drawing.Font)
        Me.textCMD.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.textCMD.CustomButton.ImageAlign = CType(resources.GetObject("resource.ImageAlign"), System.Drawing.ContentAlignment)
        Me.textCMD.CustomButton.ImageIndex = CType(resources.GetObject("resource.ImageIndex"), Integer)
        Me.textCMD.CustomButton.ImageKey = resources.GetString("resource.ImageKey")
        Me.textCMD.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode"), System.Windows.Forms.ImeMode)
        Me.textCMD.CustomButton.Location = CType(resources.GetObject("resource.Location"), System.Drawing.Point)
        Me.textCMD.CustomButton.MaximumSize = CType(resources.GetObject("resource.MaximumSize"), System.Drawing.Size)
        Me.textCMD.CustomButton.Name = ""
        Me.textCMD.CustomButton.RightToLeft = CType(resources.GetObject("resource.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.textCMD.CustomButton.Size = CType(resources.GetObject("resource.Size"), System.Drawing.Size)
        Me.textCMD.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.textCMD.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex"), Integer)
        Me.textCMD.CustomButton.TextAlign = CType(resources.GetObject("resource.TextAlign"), System.Drawing.ContentAlignment)
        Me.textCMD.CustomButton.TextImageRelation = CType(resources.GetObject("resource.TextImageRelation"), System.Windows.Forms.TextImageRelation)
        Me.textCMD.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.textCMD.CustomButton.UseSelectable = True
        Me.textCMD.CustomButton.Visible = CType(resources.GetObject("resource.Visible"), Boolean)
        Me.textCMD.ForeColor = System.Drawing.Color.Green
        Me.textCMD.Lines = New String(-1) {}
        Me.textCMD.MaxLength = 32767
        Me.textCMD.Multiline = True
        Me.textCMD.Name = "textCMD"
        Me.textCMD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.textCMD.ReadOnly = True
        Me.textCMD.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.textCMD.SelectedText = ""
        Me.textCMD.SelectionLength = 0
        Me.textCMD.SelectionStart = 0
        Me.textCMD.ShortcutsEnabled = True
        Me.textCMD.UseSelectable = True
        Me.textCMD.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.textCMD.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'frmCMD
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.textCMD)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCMD"
        Me.ShowInTaskbar = False
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Cancel_Button As Button
    Friend WithEvents textCMD As MetroFramework.Controls.MetroTextBox
End Class
