<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmIPWAN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIPWAN))
        Me.btnOBTERINFO = New MetroFramework.Controls.MetroButton()
        Me.textIP = New MetroFramework.Controls.MetroTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textWANIPTESTE = New System.Windows.Forms.TextBox()
        Me.tmrUPDATE = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnOBTERINFO
        '
        Me.btnOBTERINFO.Location = New System.Drawing.Point(12, 69)
        Me.btnOBTERINFO.Name = "btnOBTERINFO"
        Me.btnOBTERINFO.Size = New System.Drawing.Size(337, 31)
        Me.btnOBTERINFO.TabIndex = 0
        Me.btnOBTERINFO.Text = "Obter inforamação IP WAN"
        Me.btnOBTERINFO.UseSelectable = True
        '
        'textIP
        '
        '
        '
        '
        Me.textIP.CustomButton.Image = Nothing
        Me.textIP.CustomButton.Location = New System.Drawing.Point(315, 1)
        Me.textIP.CustomButton.Name = ""
        Me.textIP.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.textIP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.textIP.CustomButton.TabIndex = 1
        Me.textIP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.textIP.CustomButton.UseSelectable = True
        Me.textIP.CustomButton.Visible = False
        Me.textIP.Lines = New String(-1) {}
        Me.textIP.Location = New System.Drawing.Point(12, 40)
        Me.textIP.MaxLength = 32767
        Me.textIP.Name = "textIP"
        Me.textIP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.textIP.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.textIP.SelectedText = ""
        Me.textIP.SelectionLength = 0
        Me.textIP.SelectionStart = 0
        Me.textIP.ShortcutsEnabled = True
        Me.textIP.Size = New System.Drawing.Size(337, 23)
        Me.textIP.TabIndex = 1
        Me.textIP.UseSelectable = True
        Me.textIP.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.textIP.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Inserir IP:"
        '
        'textWANIPTESTE
        '
        Me.textWANIPTESTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textWANIPTESTE.Location = New System.Drawing.Point(12, 106)
        Me.textWANIPTESTE.Multiline = True
        Me.textWANIPTESTE.Name = "textWANIPTESTE"
        Me.textWANIPTESTE.Size = New System.Drawing.Size(337, 283)
        Me.textWANIPTESTE.TabIndex = 6
        '
        'tmrUPDATE
        '
        '
        'frmIPWAN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 401)
        Me.Controls.Add(Me.textWANIPTESTE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.textIP)
        Me.Controls.Add(Me.btnOBTERINFO)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmIPWAN"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOBTERINFO As MetroFramework.Controls.MetroButton
    Friend WithEvents textIP As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents textWANIPTESTE As TextBox
    Friend WithEvents tmrUPDATE As Timer
End Class
