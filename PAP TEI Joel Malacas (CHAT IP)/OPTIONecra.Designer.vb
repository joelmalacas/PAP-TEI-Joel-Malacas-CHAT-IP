<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPartilha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPartilha))
        Me.checkPartilhar = New MetroFramework.Controls.MetroCheckBox()
        Me.checkAssistir = New MetroFramework.Controls.MetroCheckBox()
        Me.btnAplicar = New MetroFramework.Controls.MetroButton()
        Me.btncancelar = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'checkPartilhar
        '
        Me.checkPartilhar.AutoSize = True
        Me.checkPartilhar.Location = New System.Drawing.Point(12, 25)
        Me.checkPartilhar.Name = "checkPartilhar"
        Me.checkPartilhar.Size = New System.Drawing.Size(92, 15)
        Me.checkPartilhar.TabIndex = 27
        Me.checkPartilhar.Text = "Partilhar ecrã"
        Me.checkPartilhar.UseSelectable = True
        '
        'checkAssistir
        '
        Me.checkAssistir.AutoSize = True
        Me.checkAssistir.Location = New System.Drawing.Point(12, 57)
        Me.checkAssistir.Name = "checkAssistir"
        Me.checkAssistir.Size = New System.Drawing.Size(144, 15)
        Me.checkAssistir.TabIndex = 28
        Me.checkAssistir.Text = "Assistir partilha de ecrã"
        Me.checkAssistir.UseSelectable = True
        '
        'btnAplicar
        '
        Me.btnAplicar.Location = New System.Drawing.Point(120, 81)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(80, 19)
        Me.btnAplicar.TabIndex = 29
        Me.btnAplicar.Text = "Aplicar"
        Me.btnAplicar.UseSelectable = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(34, 81)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(80, 19)
        Me.btncancelar.TabIndex = 30
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseSelectable = True
        '
        'frmPartilha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(212, 112)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnAplicar)
        Me.Controls.Add(Me.checkAssistir)
        Me.Controls.Add(Me.checkPartilhar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPartilha"
        Me.Text = "Ecra.exe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents checkPartilhar As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents checkAssistir As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents btnAplicar As MetroFramework.Controls.MetroButton
    Friend WithEvents btncancelar As MetroFramework.Controls.MetroButton
End Class
