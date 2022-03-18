<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.lbl_Principal = New System.Windows.Forms.Label()
        Me.btm_Acao = New System.Windows.Forms.Button()
        Me.lbl_Saldo = New System.Windows.Forms.Label()
        Me.lbl_Incremento = New System.Windows.Forms.Label()
        Me.txt_Saldo = New System.Windows.Forms.TextBox()
        Me.txt_Incremento = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbl_Principal
        '
        Me.lbl_Principal.AutoSize = True
        Me.lbl_Principal.Location = New System.Drawing.Point(13, 13)
        Me.lbl_Principal.Name = "lbl_Principal"
        Me.lbl_Principal.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Principal.TabIndex = 0
        Me.lbl_Principal.Text = "Label1"
        '
        'btm_Acao
        '
        Me.btm_Acao.Location = New System.Drawing.Point(16, 55)
        Me.btm_Acao.Name = "btm_Acao"
        Me.btm_Acao.Size = New System.Drawing.Size(193, 94)
        Me.btm_Acao.TabIndex = 1
        Me.btm_Acao.Text = "Button1"
        Me.btm_Acao.UseVisualStyleBackColor = True
        '
        'lbl_Saldo
        '
        Me.lbl_Saldo.AutoSize = True
        Me.lbl_Saldo.Location = New System.Drawing.Point(16, 174)
        Me.lbl_Saldo.Name = "lbl_Saldo"
        Me.lbl_Saldo.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Saldo.TabIndex = 2
        Me.lbl_Saldo.Text = "Label1"
        '
        'lbl_Incremento
        '
        Me.lbl_Incremento.AutoSize = True
        Me.lbl_Incremento.Location = New System.Drawing.Point(127, 174)
        Me.lbl_Incremento.Name = "lbl_Incremento"
        Me.lbl_Incremento.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Incremento.TabIndex = 3
        Me.lbl_Incremento.Text = "Label2"
        '
        'txt_Saldo
        '
        Me.txt_Saldo.Location = New System.Drawing.Point(19, 200)
        Me.txt_Saldo.Name = "txt_Saldo"
        Me.txt_Saldo.Size = New System.Drawing.Size(79, 20)
        Me.txt_Saldo.TabIndex = 4
        '
        'txt_Incremento
        '
        Me.txt_Incremento.Location = New System.Drawing.Point(130, 200)
        Me.txt_Incremento.Name = "txt_Incremento"
        Me.txt_Incremento.Size = New System.Drawing.Size(79, 20)
        Me.txt_Incremento.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_Incremento)
        Me.Controls.Add(Me.txt_Saldo)
        Me.Controls.Add(Me.lbl_Incremento)
        Me.Controls.Add(Me.lbl_Saldo)
        Me.Controls.Add(Me.btm_Acao)
        Me.Controls.Add(Me.lbl_Principal)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Principal As Label
    Friend WithEvents btm_Acao As Button
    Friend WithEvents lbl_Saldo As Label
    Friend WithEvents lbl_Incremento As Label
    Friend WithEvents txt_Saldo As TextBox
    Friend WithEvents txt_Incremento As TextBox
End Class
