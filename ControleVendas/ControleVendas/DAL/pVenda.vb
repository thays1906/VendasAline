Imports GFT.Util.BancoDados
Imports GFT.Util.clsMsgBox
Imports GFT.Util

Public Class pVenda
    Private Const PROCEDURE As String = "pVenda"
    Private Shared Operacao As Campo = New Campo("Operacao", DbType.String, 4)

    Private Shared bDados As BancoDados = Nothing
    Private Shared oDataSet As SuperDataSet = Nothing

    Class pVenda
        Public Shared cVenda As Campo = New Campo("cVenda", DbType.Decimal, 10, 0)
        Public Shared cCliente As Campo = New Campo("cCliente", DbType.Decimal, 10, 0)
        Public Shared cValorTotal As Campo = New Campo("cValorTotal", DbType.Decimal, 18, 2)
        Public Shared dtVenda As Campo = New Campo("dtVenda", DbType.Date, 10, 0)
        Public Shared cFormaPagmto As Campo = New Campo("cFormaPagmto", DbType.Decimal, 1, 0)

    End Class

    Shared Function Incluir(ByVal _cCliente As Decimal,
                            ByVal _cValorTotal As Decimal,
                            ByVal _dtVenda As Date,
                            ByVal _cFormaPagmto As eFormaPagamento) As SuperDataSet
        Try
            bDados = New BancoDados()
            oDataSet = New SuperDataSet()

            bDados.LimpaParametros()

            bDados.AdicionaParametro(Operacao, "INSE")
            bDados.AdicionaParametro(pVenda.cCliente, _cCliente)
            bDados.AdicionaParametro(pVenda.cValorTotal, _cValorTotal)
            bDados.AdicionaParametro(pVenda.dtVenda, _dtVenda)
            bDados.AdicionaParametro(pVenda.cFormaPagmto, _cFormaPagmto)

            oDataSet = bDados.Obter(PROCEDURE)

            If oDataSet IsNot Nothing Then
                Return oDataSet
            Else
                Return Nothing
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message,
                    eBotoes.Ok,
                    "Erro no banco de dados.",,
                    eImagens.Cancel)
            Return Nothing
        End Try
    End Function

    Shared Function Alterar(ByVal _cVenda As Decimal,
                            ByVal _cCliente As Decimal,
                            ByVal _cValorTotal As Decimal,
                            ByVal _dtVenda As Date,
                            ByVal _cFormaPagmto As eFormaPagamento) As Boolean
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()

            bDados.AdicionaParametro(Operacao, "ALTE")
            bDados.AdicionaParametro(pVenda.cVenda, _cVenda)
            bDados.AdicionaParametro(pVenda.cCliente, _cCliente)
            bDados.AdicionaParametro(pVenda.cValorTotal, _cValorTotal)
            bDados.AdicionaParametro(pVenda.dtVenda, _dtVenda)
            bDados.AdicionaParametro(pVenda.cFormaPagmto, _cFormaPagmto)

            If bDados.Executar(PROCEDURE) Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message,
                    eBotoes.Ok,
                    "Erro no banco de dados.",,
                    eImagens.Cancel)
            Return False
        End Try
    End Function

    Shared Function Deletar(ByVal _cVenda As Decimal) As Boolean
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()

            bDados.AdicionaParametro(Operacao, "DELE")
            bDados.AdicionaParametro(pVenda.cVenda, _cVenda)

            If bDados.Executar(PROCEDURE) Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message,
                    eBotoes.Ok,
                    "Erro no banco de dados.",,
                    eImagens.Cancel)
            Return False
        End Try
    End Function

    Shared Function Obter(ByVal _cVenda As Decimal) As SuperDataSet
        Try
            bDados = New BancoDados()
            oDataSet = New SuperDataSet()

            bDados.LimpaParametros()

            bDados.AdicionaParametro(Operacao, "OBTE")
            bDados.AdicionaParametro(pVenda.cVenda, _cVenda)

            oDataSet = bDados.Obter(PROCEDURE)

            If oDataSet IsNot Nothing Then
                Return oDataSet
            Else
                Return Nothing
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message,
                    eBotoes.Ok,
                    "Erro no banco de dados.",,
                    eImagens.Cancel)
            Return Nothing
        End Try
    End Function

    Shared Function Pesquisar() As SuperDataSet
        Try
            bDados = New BancoDados()
            oDataSet = New SuperDataSet()

            bDados.LimpaParametros()

            bDados.AdicionaParametro(Operacao, "GRID")

            oDataSet = bDados.Obter(PROCEDURE)

            If oDataSet IsNot Nothing Then
                Return oDataSet
            Else
                Return Nothing
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message,
                    eBotoes.Ok,
                    "Erro no banco de dados.",,
                    eImagens.Cancel)
            Return Nothing
        End Try
    End Function
    Shared Function ObterTotal() As SuperDataSet
        Try
            bDados = New BancoDados()
            oDataSet = New SuperDataSet()

            bDados.LimpaParametros()

            bDados.AdicionaParametro(Operacao, "TOT")

            oDataSet = bDados.Obter(PROCEDURE)

            If oDataSet IsNot Nothing Then
                Return oDataSet
            Else
                Return Nothing
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message,
                    eBotoes.Ok,
                    "Erro no banco de dados.",,
                    eImagens.Cancel)
            Return Nothing
        End Try
    End Function


End Class
