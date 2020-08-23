Imports GFT.Util
Imports GFT.Util.clsMsgBox
Imports GFT.Util.BancoDados

Public Class pEstoque
    Private Const PROCEDURE As String = "pEstoque"
    Private Shared OPERACAO As Campo = New Campo("Operacao", DbType.String, 4)
    Private Shared bDados As BancoDados = Nothing
    Private Shared oDataSet As SuperDataSet = Nothing
    Class pEstoque
        Public Shared cEstoqueProd As Campo = New Campo("cEstoqueProd", DbType.Decimal, 10, 0)
        Public Shared cProduto As Campo = New Campo("cProduto", DbType.Decimal, 10, 0)
        Public Shared cEstoqueAtual As Campo = New Campo("cEstoqueAtual", DbType.Decimal, 18, 0)
        Public Shared UltimaEntrada As Campo = New Campo("UltimaEntrada", DbType.Date, 10, 0)
        Public Shared UltimaSaida As Campo = New Campo("UltimaSaida", DbType.Date, 10, 0)
        Public Shared cTipo As Campo = New Campo("cTipo", DbType.Decimal, 1, 0)
        Public Shared rProduto As Campo = New Campo("rProduto", DbType.String, 100)
        Public Shared dtEntradaFinal As Campo = New Campo("dtEntradaFinal", DbType.Date, 10, 0)
        Public Shared dtSaidaFinal As Campo = New Campo("dtSaidaFinal", DbType.Date, 10, 0)
        Public Shared cTamanho As Campo = New Campo("cTamanho", DbType.Decimal, 4, 0)
    End Class

    Shared Sub Incluir(ByVal _cProduto As Decimal)
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "INSE")
            bDados.AdicionaParametro(pEstoque.cProduto, _cProduto)

            bDados.Executar(PROCEDURE)

        Catch ex As Exception
            S_MsgBox(ex.Message,
                     eBotoes.Ok,
                     "Erro no banco de dados",,
                     eImagens.Cancel)
        End Try
    End Sub
    Shared Function Alterar(ByVal _cProduto As Decimal,
                            ByVal _cQuantidade As Decimal,
                            ByVal _dtEntrada As Date,
                            ByVal _dtSaida As Date,
                            ByVal _cTipo As Decimal) As Boolean
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "ALTE")
            bDados.AdicionaParametro(pEstoque.cProduto, _cProduto)
            bDados.AdicionaParametro(pEstoque.cEstoqueAtual, _cQuantidade)

            If _dtEntrada <> Nothing Then
                bDados.AdicionaParametro(pEstoque.UltimaEntrada, _dtEntrada)
            End If

            If _dtSaida <> Nothing Then
                bDados.AdicionaParametro(pEstoque.UltimaSaida, _dtSaida)
            End If

            bDados.AdicionaParametro(pEstoque.cTipo, _cTipo)

            If bDados.Executar(PROCEDURE) Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message,
                     eBotoes.Ok,
                     "Erro no banco de dados",,
                     eImagens.Cancel)
            Return False
        End Try
    End Function
    Shared Function Obter(ByVal _cProduto As Decimal) As SuperDataSet
        Try
            bDados = New BancoDados()
            oDataSet = New SuperDataSet()

            bDados.LimpaParametros()

            bDados.AdicionaParametro(OPERACAO, "OBTE")
            bDados.AdicionaParametro(pEstoque.cEstoqueProd, _cProduto)

            oDataSet = bDados.Obter(PROCEDURE)

            If oDataSet IsNot Nothing Then
                Return oDataSet
            Else
                Return Nothing
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message,
                     eBotoes.Ok,
                     "Erro no banco de dados",,
                     eImagens.Cancel)
            Return Nothing
        End Try
    End Function
    Shared Function Pesquisar(ByVal _rProduto As String,
                              ByVal _cTamanho As Decimal,
                              ByVal _dtInicial As Date,
                              ByVal _dtFinal As Date,
                              ByVal _tipoMovimentacao As eTipoMovimentacao) As SuperDataSet
        Try
            bDados = New BancoDados()
            oDataSet = New SuperDataSet()

            bDados.LimpaParametros()

            bDados.AdicionaParametro(OPERACAO, "GRID")
            bDados.AdicionaParametro(pEstoque.rProduto, _rProduto)
            bDados.AdicionaParametro(pEstoque.cTamanho, _cTamanho)

            If _tipoMovimentacao = eTipoMovimentacao.Entrada Then
                bDados.AdicionaParametro(pEstoque.UltimaEntrada, _dtInicial)
                bDados.AdicionaParametro(pEstoque.dtEntradaFinal, _dtFinal)

            ElseIf _tipoMovimentacao = eTipoMovimentacao.Saida Then
                bDados.AdicionaParametro(pEstoque.UltimaSaida, _dtInicial)
                bDados.AdicionaParametro(pEstoque.dtSaidaFinal, _dtFinal)
            End If

            oDataSet = bDados.Obter(PROCEDURE)

            If oDataSet IsNot Nothing Then
                Return oDataSet
            Else
                Return Nothing
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message,
                     eBotoes.Ok,
                     "Erro no banco de dados",,
                     eImagens.Cancel)
            Return Nothing
        End Try
    End Function

    Shared Sub ConfirmaInsert()
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "CHEK")


            bDados.Executar(PROCEDURE)

        Catch ex As Exception
            S_MsgBox(ex.Message,
                     eBotoes.Ok,
                     "Erro no banco de dados",,
                     eImagens.Cancel)
        End Try
    End Sub

    Shared Function Lista(ByVal _rProduto As String) As SuperDataSet
        Try
            bDados = New BancoDados()
            oDataSet = New SuperDataSet()

            bDados.LimpaParametros()

            bDados.AdicionaParametro(OPERACAO, "LIST")
            bDados.AdicionaParametro(pEstoque.rProduto, _rProduto)
            oDataSet = bDados.Obter(PROCEDURE)

            If oDataSet IsNot Nothing Then
                Return oDataSet
            Else
                Return Nothing
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message,
                     eBotoes.Ok,
                     "Erro no banco de dados",,
                     eImagens.Cancel)
            Return Nothing
        End Try
    End Function

    Shared Function PesquisarEstoqueMin() As SuperDataSet
        Try
            bDados = New BancoDados()
            oDataSet = New SuperDataSet()

            bDados.LimpaParametros()

            bDados.AdicionaParametro(OPERACAO, "ESTO")

            oDataSet = bDados.Obter(PROCEDURE)

            If oDataSet IsNot Nothing Then
                Return oDataSet
            Else
                Return Nothing
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message,
                     eBotoes.Ok,
                     "Erro no banco de dados",,
                     eImagens.Cancel)
            Return Nothing
        End Try
    End Function

End Class
