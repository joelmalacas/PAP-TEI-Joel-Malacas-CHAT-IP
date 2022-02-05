<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmhtml
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmhtml))
        Me.btnfechar = New MetroFramework.Controls.MetroButton()
        Me.richHTML = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'btnfechar
        '
        Me.btnfechar.BackColor = System.Drawing.Color.Red
        Me.btnfechar.Location = New System.Drawing.Point(483, 348)
        Me.btnfechar.Name = "btnfechar"
        Me.btnfechar.Size = New System.Drawing.Size(77, 28)
        Me.btnfechar.TabIndex = 0
        Me.btnfechar.Text = "Fechar"
        Me.btnfechar.UseSelectable = True
        '
        'richHTML
        '
        Me.richHTML.Location = New System.Drawing.Point(2, 2)
        Me.richHTML.Name = "richHTML"
        Me.richHTML.ReadOnly = True
        Me.richHTML.Size = New System.Drawing.Size(567, 384)
        Me.richHTML.TabIndex = 1
        Me.richHTML.Text = ""
        '
        'frmhtml
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 388)
        Me.Controls.Add(Me.btnfechar)
        Me.Controls.Add(Me.richHTML)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmhtml"
        Me.Text = "HTML.exe"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnfechar As MetroFramework.Controls.MetroButton
    Friend WithEvents richHTML As RichTextBox
End Class
