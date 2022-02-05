<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPartilhaEnviar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPartilhaEnviar))
        Me.btnConectar = New MetroFramework.Controls.MetroButton()
        Me.tmrEnviar = New System.Windows.Forms.Timer(Me.components)
        Me.btnParar = New MetroFramework.Controls.MetroButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.tmrCON = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCon = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnConectar
        '
        Me.btnConectar.Location = New System.Drawing.Point(12, 28)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(282, 53)
        Me.btnConectar.TabIndex = 0
        Me.btnConectar.Text = "Começar a partilha de ecrã"
        Me.btnConectar.UseSelectable = True
        '
        'tmrEnviar
        '
        Me.tmrEnviar.Interval = 10
        '
        'btnParar
        '
        Me.btnParar.Location = New System.Drawing.Point(12, 28)
        Me.btnParar.Name = "btnParar"
        Me.btnParar.Size = New System.Drawing.Size(282, 53)
        Me.btnParar.TabIndex = 1
        Me.btnParar.Text = "Parar a partilha"
        Me.btnParar.UseSelectable = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(184, 9)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Status:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.Control
        Me.lblStatus.Location = New System.Drawing.Point(228, 9)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 13)
        Me.lblStatus.TabIndex = 18
        '
        'tmrCON
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Tempo de Conexção:"
        '
        'lblCon
        '
        Me.lblCon.AutoSize = True
        Me.lblCon.ForeColor = System.Drawing.SystemColors.Control
        Me.lblCon.Location = New System.Drawing.Point(124, 9)
        Me.lblCon.Name = "lblCon"
        Me.lblCon.Size = New System.Drawing.Size(19, 13)
        Me.lblCon.TabIndex = 20
        Me.lblCon.Text = "00"
        '
        'frmPartilhaEnviar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(306, 93)
        Me.Controls.Add(Me.lblCon)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnConectar)
        Me.Controls.Add(Me.btnParar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPartilhaEnviar"
        Me.Text = "Enviar partilha.exe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConectar As MetroFramework.Controls.MetroButton
    Friend WithEvents tmrEnviar As Timer
    Friend WithEvents btnParar As MetroFramework.Controls.MetroButton
    Friend WithEvents Label4 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents tmrCON As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCon As Label
End Class
