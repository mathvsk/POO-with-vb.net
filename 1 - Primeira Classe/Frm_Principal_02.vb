Public Class Frm_Principal_02

    Dim ContaMatheus As New ContaCorrente
    Dim ContaIgor As New ContaCorrente

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        ' Incrementando na classe CONTA CORRENTE ( MATHEUS ) 
        ContaMatheus.titular = "Matheus Igor Viscki"
        ContaMatheus.agencia = 123
        ContaMatheus.conta = 1234567
        ContaMatheus.saldo = 1500

        ' Incrementando na classe CONTA CORRENTE ( IGOR ) 
        ContaIgor.titular = "Igor Viscki"
        ContaIgor.agencia = 321
        ContaIgor.conta = 7654321
        ContaIgor.saldo = 1000

        'FORMATANDO O WINDOWS FORM
        'CONTA MATHEUS --------
        Me.Text = "1 - Primeira Classe - Formulario 02"
        lbl_Principal02.Text = "1 - Primeira Classe - Formulario 02"
        lbl_Valor_Matheus.Text = "Valor"
        btm_Sacar_Matheus.Text = "Sacar"
        lbl_Saldo_Matheus.Text = "Novo Saldo"
        lbl_Resultado_Matheus.Text = "Resultado do saque"
        lbl_SaldoAtual_Matheus.Text = "Saldo Atual"
        txt_SaldoAtual_Matheus.Text = ContaMatheus.saldo.ToString
        lbl_BemVindo_Matheus.Text = $"Bem Vindo {ContaMatheus.titular}!!!"
        btm_Depositar_Matheus.Text = "Depositar"
        grp_Matheus.Text = "Conta Matheus"
        btm_Transferir_Matheus.Text = "Tranferir"

        txt_Saldo_Matheus.ReadOnly = True
        txt_SaldoAtual_Matheus.ReadOnly = True
        txt_Resultado_Matheus.ReadOnly = True
        txt_Extrato_Matheus.ReadOnly = True

        'CONTA IGOR --------
        Me.Text = "1 - Primeira Classe - Formulario 02"
        lbl_Principal02.Text = "1 - Primeira Classe - Formulario 02"
        lbl_Valor_Igor.Text = "Valor"
        btm_Depositar_Igor.Text = "Sacar"
        lbl_Saldo_Igor.Text = "Novo Saldo"
        lbl_Resultado_Igor.Text = "Resultado do saque"
        lbl_SaldoAtual_Igor.Text = "Saldo Atual"
        txt_SaldoAtual_Igor.Text = ContaIgor.saldo.ToString
        lbl_BemVindo_Igor.Text = $"Bem Vindo {ContaIgor.titular}!!!"
        btm_Depositar_Igor.Text = "Depositar"
        grp_Igor.Text = "Conta Igor"
        btm_Transferir_Igor.Text = "Tranferir"

        txt_Saldo_Igor.ReadOnly = True
        txt_SaldoAtual_Igor.ReadOnly = True
        txt_Resultado_Igor.ReadOnly = True
        txt_Extrato_Igor.ReadOnly = True



    End Sub

    Private Sub btm_Sacar_Click(sender As Object, e As EventArgs) Handles btm_Sacar_Matheus.Click

        txt_Saldo_Matheus.Text = ""
        txt_Resultado_Matheus.Text = ""

        Dim valorSacar As Double = Val(txt_Valor_Matheus.Text)

        Dim retornoSaque As Boolean = ContaMatheus.Sacar(valorSacar)

        If retornoSaque = False Then
            txt_Resultado_Matheus.Text = "Não é possivel realizar o saque"
        Else
            txt_Saldo_Matheus.Text = ContaMatheus.saldo.ToString
            txt_Resultado_Matheus.Text = "Saque realziado com sucesso"
            txt_SaldoAtual_Matheus.Text = ContaMatheus.saldo.ToString
            ContaMatheus.extrato += Now.ToString + $" Saque de {valorSacar.ToString}, saldo atual: {ContaMatheus.saldo.ToString}" + vbCrLf
            txt_Extrato_Matheus.Text = ContaMatheus.extrato
        End If
    End Sub

    Private Sub btm_Depositar_Click(sender As Object, e As EventArgs) Handles btm_Depositar_Matheus.Click

        txt_Saldo_Matheus.Text = ""
        txt_Resultado_Matheus.Text = ""

        Dim valorDepositar As Double = Val(txt_Valor_Matheus.Text)

        ContaMatheus.Depositar(valorDepositar)

        txt_Saldo_Matheus.Text = ContaMatheus.saldo.ToString
        txt_Resultado_Matheus.Text = "Depósito realziado com sucesso"
        txt_SaldoAtual_Matheus.Text = ContaMatheus.saldo.ToString
        ContaMatheus.extrato += Now.ToString + $" Depósito de {valorDepositar.ToString}, saldo atual: {ContaMatheus.saldo.ToString}" + vbCrLf


        txt_Extrato_Matheus.Text = ContaMatheus.extrato

    End Sub

    Private Sub brm_Sacar_Igor_Click(sender As Object, e As EventArgs) Handles brm_Sacar_Igor.Click
        txt_Saldo_Igor.Text = ""
        txt_Resultado_Igor.Text = ""

        Dim valorSacar As Double = Val(txt_Valor_Igor.Text)

        Dim retornoSaque As Boolean = ContaIgor.Sacar(valorSacar)

        If retornoSaque = False Then
            txt_Resultado_Igor.Text = "Não é possivel realizar o saque"
        Else
            txt_Saldo_Igor.Text = ContaIgor.saldo.ToString
            txt_Resultado_Igor.Text = "Saque realziado com sucesso"
            txt_SaldoAtual_Igor.Text = ContaIgor.saldo.ToString
            ContaIgor.extrato += Now.ToString + $" Saque de {valorSacar.ToString}, saldo atual: {ContaIgor.saldo.ToString}" + vbCrLf
            txt_Extrato_Igor.Text = ContaIgor.extrato
        End If
    End Sub

    Private Sub btm_Depositar_Igor_Click(sender As Object, e As EventArgs) Handles btm_Depositar_Igor.Click
        txt_Saldo_Igor.Text = ""
        txt_Resultado_Igor.Text = ""

        Dim valorDepositar As Double = Val(txt_Valor_Igor.Text)

        ContaIgor.Depositar(valorDepositar)

        txt_Saldo_Igor.Text = ContaIgor.saldo.ToString
        txt_Resultado_Igor.Text = "Depósito realziado com sucesso"
        txt_SaldoAtual_Igor.Text = ContaIgor.saldo.ToString
        ContaIgor.extrato += Now.ToString + $" Depósito de {valorDepositar.ToString}, saldo atual: {ContaIgor.saldo.ToString}" + vbCrLf


        txt_Extrato_Igor.Text = ContaIgor.extrato
    End Sub

    Private Sub btm_Transferir_Matheus_Click(sender As Object, e As EventArgs) Handles btm_Transferir_Matheus.Click

        txt_Saldo_Matheus.Text = ""
        txt_Resultado_Matheus.Text = ""

        Dim valorTranferir = Val(txt_Valor_Matheus.Text)
        Dim retornoTranferir As Boolean = ContaMatheus.Tranferir(valorTranferir, ContaIgor)

        If retornoTranferir = False Then
            txt_Resultado_Matheus.Text = "Não é possivel realizar a transferencia"
        Else
            txt_Saldo_Matheus.Text = ContaMatheus.saldo.ToString
            txt_Saldo_Igor.Text = ContaIgor.saldo.ToString

            txt_Resultado_Matheus.Text = "Transferencia realziada com sucesso"

            txt_SaldoAtual_Matheus.Text = ContaMatheus.saldo.ToString
            txt_SaldoAtual_Igor.Text = ContaIgor.saldo.ToString

            ContaMatheus.extrato += Now.ToString + $" Transferencia de {valorTranferir.ToString}, saldo atual: {ContaMatheus.saldo.ToString}" + vbCrLf
            ContaIgor.extrato += Now.ToString + $" Transferencia de {valorTranferir.ToString}, saldo atual: {ContaIgor.saldo.ToString}" + vbCrLf

            txt_Extrato_Matheus.Text = ContaMatheus.extrato
            txt_Extrato_Igor.Text = ContaIgor.extrato

        End If

    End Sub

    Private Sub btm_Transferir_Igor_Click(sender As Object, e As EventArgs) Handles btm_Transferir_Igor.Click

        txt_Saldo_Igor.Text = ""
        txt_Resultado_Igor.Text = ""

        Dim valorTranferir = Val(txt_Valor_Igor.Text)
        Dim retornoTranferir As Boolean = ContaIgor.Tranferir(valorTranferir, ContaMatheus)

        If retornoTranferir = False Then
            txt_Resultado_Igor.Text = "Não é possivel realizar a transferencia"
        Else
            txt_Saldo_Matheus.Text = ContaMatheus.saldo.ToString
            txt_Saldo_Igor.Text = ContaIgor.saldo.ToString

            txt_Resultado_Igor.Text = "Transferencia realziada com sucesso"

            txt_SaldoAtual_Matheus.Text = ContaMatheus.saldo.ToString
            txt_SaldoAtual_Igor.Text = ContaIgor.saldo.ToString

            ContaMatheus.extrato += Now.ToString + $" Transferencia de {valorTranferir.ToString}, saldo atual: {ContaMatheus.saldo.ToString}" + vbCrLf
            ContaIgor.extrato += Now.ToString + $" Transferencia de {valorTranferir.ToString}, saldo atual: {ContaIgor.saldo.ToString}" + vbCrLf

            txt_Extrato_Matheus.Text = ContaMatheus.extrato
            txt_Extrato_Igor.Text = ContaIgor.extrato

        End If

    End Sub
End Class

