<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuporte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSuporte))
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.txtSuporte = New MetroFramework.Controls.MetroTextBox()
        Me.SuspendLayout()
        '
        'Cancel_Button
        '
        resources.ApplyResources(Me.Cancel_Button, "Cancel_Button")
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Name = "Cancel_Button"
        '
        'txtSuporte
        '
        resources.ApplyResources(Me.txtSuporte, "txtSuporte")
        '
        '
        '
        Me.txtSuporte.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription")
        Me.txtSuporte.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName")
        Me.txtSuporte.CustomButton.Anchor = CType(resources.GetObject("resource.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtSuporte.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize"), Boolean)
        Me.txtSuporte.CustomButton.AutoSizeMode = CType(resources.GetObject("resource.AutoSizeMode"), System.Windows.Forms.AutoSizeMode)
        Me.txtSuporte.CustomButton.BackgroundImage = CType(resources.GetObject("resource.BackgroundImage"), System.Drawing.Image)
        Me.txtSuporte.CustomButton.BackgroundImageLayout = CType(resources.GetObject("resource.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.txtSuporte.CustomButton.Dock = CType(resources.GetObject("resource.Dock"), System.Windows.Forms.DockStyle)
        Me.txtSuporte.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.txtSuporte.CustomButton.Font = CType(resources.GetObject("resource.Font"), System.Drawing.Font)
        Me.txtSuporte.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.txtSuporte.CustomButton.ImageAlign = CType(resources.GetObject("resource.ImageAlign"), System.Drawing.ContentAlignment)
        Me.txtSuporte.CustomButton.ImageIndex = CType(resources.GetObject("resource.ImageIndex"), Integer)
        Me.txtSuporte.CustomButton.ImageKey = resources.GetString("resource.ImageKey")
        Me.txtSuporte.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtSuporte.CustomButton.Location = CType(resources.GetObject("resource.Location"), System.Drawing.Point)
        Me.txtSuporte.CustomButton.MaximumSize = CType(resources.GetObject("resource.MaximumSize"), System.Drawing.Size)
        Me.txtSuporte.CustomButton.Name = ""
        Me.txtSuporte.CustomButton.RightToLeft = CType(resources.GetObject("resource.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtSuporte.CustomButton.Size = CType(resources.GetObject("resource.Size"), System.Drawing.Size)
        Me.txtSuporte.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSuporte.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex"), Integer)
        Me.txtSuporte.CustomButton.TextAlign = CType(resources.GetObject("resource.TextAlign"), System.Drawing.ContentAlignment)
        Me.txtSuporte.CustomButton.TextImageRelation = CType(resources.GetObject("resource.TextImageRelation"), System.Windows.Forms.TextImageRelation)
        Me.txtSuporte.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSuporte.CustomButton.UseSelectable = True
        Me.txtSuporte.CustomButton.Visible = CType(resources.GetObject("resource.Visible"), Boolean)
        Me.txtSuporte.Lines = New String(-1) {}
        Me.txtSuporte.MaxLength = 32767
        Me.txtSuporte.Multiline = True
        Me.txtSuporte.Name = "txtSuporte"
        Me.txtSuporte.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSuporte.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSuporte.SelectedText = ""
        Me.txtSuporte.SelectionLength = 0
        Me.txtSuporte.SelectionStart = 0
        Me.txtSuporte.ShortcutsEnabled = True
        Me.txtSuporte.UseSelectable = True
        Me.txtSuporte.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSuporte.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'frmSuporte
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.txtSuporte)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSuporte"
        Me.ShowInTaskbar = False
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents txtSuporte As MetroFramework.Controls.MetroTextBox
End Class
