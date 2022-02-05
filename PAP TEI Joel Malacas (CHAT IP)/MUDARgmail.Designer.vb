<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmENDERECO
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmENDERECO))
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnaplicar = New System.Windows.Forms.Button()
        Me.email = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(299, 101)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 0
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnaplicar
        '
        Me.btnaplicar.Location = New System.Drawing.Point(218, 101)
        Me.btnaplicar.Name = "btnaplicar"
        Me.btnaplicar.Size = New System.Drawing.Size(75, 23)
        Me.btnaplicar.TabIndex = 1
        Me.btnaplicar.Text = "Aplicar"
        Me.btnaplicar.UseVisualStyleBackColor = True
        '
        'email
        '
        '
        '
        '
        Me.email.CustomButton.Image = Nothing
        Me.email.CustomButton.Location = New System.Drawing.Point(194, 1)
        Me.email.CustomButton.Name = ""
        Me.email.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.email.CustomButton.TabIndex = 1
        Me.email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.email.CustomButton.UseSelectable = True
        Me.email.CustomButton.Visible = False
        Me.email.Lines = New String(-1) {}
        Me.email.Location = New System.Drawing.Point(128, 38)
        Me.email.MaxLength = 32767
        Me.email.Name = "email"
        Me.email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.email.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.email.SelectedText = ""
        Me.email.SelectionLength = 0
        Me.email.SelectionStart = 0
        Me.email.ShortcutsEnabled = True
        Me.email.Size = New System.Drawing.Size(216, 23)
        Me.email.TabIndex = 2
        Me.email.UseSelectable = True
        Me.email.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.email.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(12, 42)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(110, 19)
        Me.MetroLabel1.TabIndex = 3
        Me.MetroLabel1.Text = "Mudar endereço:"
        '
        'frmENDERECO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 136)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.btnaplicar)
        Me.Controls.Add(Me.btncancelar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmENDERECO"
        Me.Text = "GMAIL.exe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btncancelar As Button
    Friend WithEvents btnaplicar As Button
    Friend WithEvents email As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
End Class
