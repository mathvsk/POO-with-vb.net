
Public Class Form1
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Me.Text = "1 - Primeira Classe"
        lbl_Principal.Text = "1 - Primeira Classe"
        btm_Acao.Text = "Conta Gabriela"
        lbl_Saldo.Text = "Saldo"
        lbl_Incremento.Text = "Incremento"

    End Sub

    Private Sub btm_Acao_Click(sender As Object, e As EventArgs) Handles btm_Acao.Click

        Dim contaGab As New ContaCorrente()

        contaGab.titular = "Gabriela"
        contaGab.agencia = 863
        contaGab.conta = 863141
        contaGab.saldo = Val(txt_Saldo.Text)

        MsgBox($"O saldo da {contaGab.titular} é de {contaGab.saldo.ToString}")

        Dim vIncremento As Double = Val(txt_Incremento.Text)

        contaGab.saldo += vIncremento

        MsgBox($"voce adicionou {vIncremento} totalizando um saldo de {contaGab.saldo.ToString}")

    End Sub

End Class