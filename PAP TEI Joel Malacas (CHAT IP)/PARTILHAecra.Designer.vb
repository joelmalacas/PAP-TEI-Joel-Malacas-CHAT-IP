<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPartilhaREC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPartilhaREC))
        Me.btnfechar = New MetroFramework.Controls.MetroButton()
        Me.PicECRA = New System.Windows.Forms.PictureBox()
        CType(Me.PicECRA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnfechar
        '
        Me.btnfechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnfechar.BackColor = System.Drawing.Color.Transparent
        Me.btnfechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnfechar.Location = New System.Drawing.Point(708, 412)
        Me.btnfechar.Name = "btnfechar"
        Me.btnfechar.Size = New System.Drawing.Size(80, 26)
        Me.btnfechar.TabIndex = 2
        Me.btnfechar.Text = "Fechar"
        Me.btnfechar.UseSelectable = True
        '
        'PicECRA
        '
        Me.PicECRA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PicECRA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicECRA.Image = Global.PAP_TEI_Joel_Malacas__CHAT_IP_.My.Resources.Resources._123
        Me.PicECRA.Location = New System.Drawing.Point(0, 0)
        Me.PicECRA.Name = "PicECRA"
        Me.PicECRA.Size = New System.Drawing.Size(800, 450)
        Me.PicECRA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicECRA.TabIndex = 1
        Me.PicECRA.TabStop = False
        '
        'frmPartilhaREC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnfechar)
        Me.Controls.Add(Me.PicECRA)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPartilhaREC"
        Me.Text = "Partilha de ecrã do parceiro.exe"
        CType(Me.PicECRA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PicECRA As PictureBox
    Friend WithEvents btnfechar As MetroFramework.Controls.MetroButton
End Class
