Imports _2___ByteBank.ByteBank

Public Class ContaCorrente
#Region "CONSTRUTORES"

    Public Sub New(m_Saldo As Double)
        Saldo = m_Saldo
    End Sub

#End Region

#Region "PROPRIEDADES"


    Private m_titular As Cliente
    Private m_agencia As Integer
    Private m_conta As Integer
    Private m_saldo As Double
    Private m_extrato As String = ""

    Public Property Titular As Cliente

        Get
            Return m_titular
        End Get
        Set(value As Cliente)
            m_titular = value
        End Set

    End Property

    Public Property Agencia As Integer

        Get
            Return m_agencia
        End Get
        Set(value As Integer)
            m_agencia = value
        End Set

    End Property

    Public Property Conta As Integer

        Get
            Return m_conta
        End Get
        Set(value As Integer)
            m_conta = value
        End Set

    End Property

    Public Property Saldo As Double

        Get

            Return m_saldo

        End Get
        Set(value As Double)

            If value < 0 Then
                m_saldo = 0
            Else
                m_saldo = value
            End If

        End Set


#End Region

    End Property

    Public Property Extrato As String

        Get
            Return m_extrato
        End Get
        Set(value As String)
            m_extrato = value
        End Set

    End Property


#Region "MÉTODOS"


    'CRIANDO UMA FUNCAO
    'FUNCAO COM RETORNO SE ESCREVE ( PUBLIC ) E RETORNA UM ( BOOLEAN )
    'ATO DE RETORNAR VALOR === FUNCAO
    Public Function Sacar(valorSacar As Double) As Boolean

        Dim podeSacar As Boolean

        If m_saldo <= valorSacar Then
            podeSacar = False
        Else
            m_saldo -= valorSacar
            podeSacar = True
        End If
        Return podeSacar

    End Function

    'FUNCAO SEM RETORNO ESCREVE ( SUB ) 
    'ATO QUE NAO RETORNA ALGUM VALOR === MÉTODO
    Public Sub Depositar(valorDepositar As Double)
        m_saldo += valorDepositar
    End Sub

    Public Function Tranferir(valorTranferir As Double, ByRef contaDestino As ContaCorrente) As Boolean

        If m_saldo < valorTranferir Then
            Return False
        Else
            m_saldo -= valorTranferir
            contaDestino.Depositar(valorTranferir)
            Return True
        End If

    End Function


#End Region

End Class
