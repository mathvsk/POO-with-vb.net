Imports _2___ByteBank.ByteBank
Public Class Frm_Principal_02

    Dim ContaMatheus As New ContaCorrente(0)
    Dim ContaIgor As New ContaCorrente(2500)
    Dim Matheus As New Cliente("Matheus", "123654987")
    Dim Igor As New Cliente("Igor", "12345")



    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        'FORMATANDO O WINDOWS FORM
        'CONTA MATHEUS --------
        Matheus.cidade = "Curitiba"
        Matheus.Profissao = "Dev"

        ContaMatheus.titular = Matheus
        ContaMatheus.agencia = 123
        ContaMatheus.conta = 1234567

        Me.Text = "1 - Primeira Classe - Formulario 02"
        lbl_Principal02.Text = "1 - Primeira Classe - Formulario 02"
        lbl_Valor_Matheus.Text = "Valor"
        btm_Sacar_Matheus.Text = "Sacar"
        lbl_Saldo_Matheus.Text = "Novo Saldo"
        lbl_Resultado_Matheus.Text = "Resultado do saque"
        lbl_SaldoAtual_Matheus.Text = "Saldo Atual"
        txt_SaldoAtual_Matheus.Text = ContaMatheus.Saldo().ToString
        lbl_BemVindo_Matheus.Text = $"Bem Vindo {ContaMatheus.Titular.Nome}!!! CPF: {Matheus.CPF}"
        btm_Depositar_Matheus.Text = "Depositar"
        grp_Matheus.Text = "Conta Matheus"
        btm_Transferir_Matheus.Text = "Tranferir"
        lbl_Nome_Matheus.Text = "Nome"
        btm_Nome_Matheus.Text = "..."
        lbl_Numero_Clientes.Text = $"Número de cliente é: {Cliente.NumeroClientes}"

        txt_Saldo_Matheus.ReadOnly = True
        txt_SaldoAtual_Matheus.ReadOnly = True
        txt_Resultado_Matheus.ReadOnly = True
        txt_Extrato_Matheus.ReadOnly = True

        'CONTA IGOR --------
        Igor.cidade = "Curitiba"
        Igor.Profissao = "Dev"

        ContaIgor.titular = Igor
        ContaIgor.agencia = 321
        ContaIgor.conta = 7654321

        Me.Text = "1 - Primeira Classe - Formulario 02"
        lbl_Principal02.Text = "1 - Primeira Classe - Formulario 02"
        lbl_Valor_Igor.Text = "Valor"
        btm_Depositar_Igor.Text = "Sacar"
        lbl_Saldo_Igor.Text = "Novo Saldo"
        lbl_Resultado_Igor.Text = "Resultado do saque"
        lbl_SaldoAtual_Igor.Text = "Saldo Atual"
        txt_SaldoAtual_Igor.Text = ContaIgor.Saldo().ToString
        lbl_BemVindo_Igor.Text = $"Bem Vindo {ContaIgor.Titular.Nome}!!! CPF: {Igor.CPF}"
        btm_Depositar_Igor.Text = "Depositar"
        grp_Igor.Text = "Conta Igor"
        btm_Transferir_Igor.Text = "Tranferir"
        lbl_Nome_Igor.Text = "Nome"
        btm_Nome_Igor.Text = "..."

        txt_Saldo_Igor.ReadOnly = True
        txt_SaldoAtual_Igor.ReadOnly = True
        txt_Resultado_Igor.ReadOnly = True
        txt_Extrato_Igor.ReadOnly = True

    End Sub

    Private Sub btm_Sacar_Matheus_Click(sender As Object, e As EventArgs) Handles btm_Sacar_Matheus.Click

        txt_Saldo_Matheus.Text = ""
        txt_Resultado_Matheus.Text = ""

        Dim valorSacar As Double = Val(txt_Valor_Matheus.Text)

        Dim retornoSaque As Boolean = ContaMatheus.Sacar(valorSacar)

        If retornoSaque = False Then
            txt_Resultado_Matheus.Text = "Não é possivel realizar o saque"
        Else
            txt_Saldo_Matheus.Text = ContaMatheus.Saldo().ToString
            txt_Resultado_Matheus.Text = "Saque realziado com sucesso"
            txt_SaldoAtual_Matheus.Text = ContaMatheus.Saldo().ToString
            ContaMatheus.extrato += Now.ToString + $" Saque de {valorSacar.ToString}, saldo atual: {ContaMatheus.Saldo().ToString}" + vbCrLf
            txt_Extrato_Matheus.Text = ContaMatheus.extrato
        End If


    End Sub

    Private Sub btm_Depositar_Matheus_Click(sender As Object, e As EventArgs) Handles btm_Depositar_Matheus.Click

        txt_Saldo_Matheus.Text = ""
        txt_Resultado_Matheus.Text = ""

        Dim valorDepositar As Double = Val(txt_Valor_Matheus.Text)

        ContaMatheus.Depositar(valorDepositar)

        txt_Saldo_Matheus.Text = ContaMatheus.Saldo().ToString
        txt_Resultado_Matheus.Text = "Depósito realizado com sucesso"
        txt_SaldoAtual_Matheus.Text = ContaMatheus.Saldo().ToString
        ContaMatheus.extrato += Now.ToString + $" Depósito de {valorDepositar.ToString}, saldo atual: {ContaMatheus.Saldo().ToString}" + vbCrLf


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
            txt_Saldo_Igor.Text = ContaIgor.Saldo().ToString
            txt_Resultado_Igor.Text = "Saque realziado com sucesso"
            txt_SaldoAtual_Igor.Text = ContaIgor.Saldo().ToString
            ContaIgor.extrato += Now.ToString + $" Saque de {valorSacar.ToString}, saldo atual: {ContaIgor.Saldo().ToString}" + vbCrLf
            txt_Extrato_Igor.Text = ContaIgor.extrato
        End If

    End Sub

    Private Sub btm_Depositar_Igor_Click(sender As Object, e As EventArgs) Handles btm_Depositar_Igor.Click

        txt_Saldo_Igor.Text = ""
        txt_Resultado_Igor.Text = ""

        Dim valorDepositar As Double = Val(txt_Valor_Igor.Text)

        ContaIgor.Depositar(valorDepositar)

        txt_Saldo_Igor.Text = ContaIgor.Saldo().ToString
        txt_Resultado_Igor.Text = "Depósito realziado com sucesso"
        txt_SaldoAtual_Igor.Text = ContaIgor.Saldo().ToString
        ContaIgor.extrato += Now.ToString + $" Depósito de {valorDepositar.ToString}, saldo atual: {ContaIgor.Saldo().ToString}" + vbCrLf


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
            txt_Saldo_Matheus.Text = ContaMatheus.Saldo().ToString
            txt_Saldo_Igor.Text = ContaIgor.Saldo().ToString

            txt_Resultado_Matheus.Text = "Transferencia realziada com sucesso"

            txt_SaldoAtual_Matheus.Text = ContaMatheus.Saldo().ToString
            txt_SaldoAtual_Igor.Text = ContaIgor.Saldo().ToString

            ContaMatheus.extrato += Now.ToString + $" Transferencia de {valorTranferir.ToString}, saldo atual: {ContaMatheus.Saldo().ToString}" + vbCrLf
            ContaIgor.extrato += Now.ToString + $" Transferencia de {valorTranferir.ToString}, saldo atual: {ContaIgor.Saldo().ToString}" + vbCrLf

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
            txt_Saldo_Matheus.Text = ContaMatheus.Saldo().ToString
            txt_Saldo_Igor.Text = ContaIgor.Saldo().ToString

            txt_Resultado_Igor.Text = "Transferencia realziada com sucesso"

            txt_SaldoAtual_Matheus.Text = ContaMatheus.Saldo().ToString
            txt_SaldoAtual_Igor.Text = ContaIgor.Saldo().ToString

            ContaMatheus.extrato += Now.ToString + $" Transferencia de {valorTranferir.ToString}, saldo atual: {ContaMatheus.Saldo().ToString}" + vbCrLf
            ContaIgor.extrato += Now.ToString + $" Transferencia de {valorTranferir.ToString}, saldo atual: {ContaIgor.Saldo().ToString}" + vbCrLf

            txt_Extrato_Matheus.Text = ContaMatheus.extrato
            txt_Extrato_Igor.Text = ContaIgor.extrato

        End If

    End Sub

    Private Sub btm_Nome_Matheus_Click(sender As Object, e As EventArgs) Handles btm_Nome_Matheus.Click

        Dim vNome As String = txt_Nome_Matheus.Text
        Matheus.Nome = vNome

        lbl_BemVindo_Matheus.Text = $"Bem Vindo {vNome}!!!"

    End Sub

    Private Sub btm_Nome_Igor_Click(sender As Object, e As EventArgs) Handles btm_Nome_Igor.Click

        Dim vNome As String = txt_Nome_Igor.Text
        Igor.Nome = vNome

        lbl_BemVindo_Igor.Text = $"Bem Vindo {vNome}!!!"

    End Sub
End Class
