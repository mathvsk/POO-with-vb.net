Public Class ContaCorrente

    Public titular As String
    Public agencia As Integer
    Public conta As Integer
    Public saldo As Double
    Public extrato As String = ""

    'CRIANDO UMA FUNCAO
    'FUNCAO COM RETORNO SE ESCREVE ( PUBLIC ) E RETORNA UM ( BOOLEAN )
    'ATO DE RETORNAR VALOR === FUNCAO
    Public Function Sacar(valorSacar As Double) As Boolean

        Dim podeSacar As Boolean

        If saldo <= valorSacar Then
            podeSacar = False
        Else
            saldo -= valorSacar
            podeSacar = True
        End If
        Return podeSacar

    End Function

    'FUNCAO SEM RETORNO ESCREVE ( SUB ) 
    'ATO QUE NAO RETORNA ALGUM VALOR === MÉTODO
    Public Sub Depositar(valorDepositar As Double)
        saldo += valorDepositar
    End Sub

    Public Function Tranferir(valorTranferir As Double, ByRef contaDestino As ContaCorrente) As Boolean

        If saldo < valorTranferir Then
            Return False
        Else
            saldo -= valorTranferir
            contaDestino.Depositar(valorTranferir)
            Return True
        End If

    End Function
End Class
