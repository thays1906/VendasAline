Imports GFT.Util.BancoDados
Imports GFT.Util.clsMsgBox
Imports GFT.Util

Public Class pItensVenda
    Private Const PROCEDURE As String = "pItensVenda"
    Private Shared Operacao As Campo = New Campo("Operacao", DbType.String, 4)

    Private Shared bDados As BancoDados = Nothing
    Private Shared oDataSet As SuperDataSet = Nothing

    Class pItensVenda
        Public Shared cItensVenda As Campo = New Campo("cItensVenda", DbType.Decimal, 10, 0)
        Public Shared cVenda As Campo = New Campo("cVenda", DbType.Decimal, 10, 0)
        Public Shared cProduto As Campo = New Campo("cProduto", DbType.Decimal, 10, 0)
        Public Shared cQuantidade As Campo = New Campo("cQuantidade", DbType.Decimal, 18, 0)
        Public Shared cValor As Campo = New Campo("cValor", DbType.Decimal, 18, 2)
    End Class

    Shared Function Incluir(ByVal _cVenda As Decimal,
                            ByVal _cProduto As Decimal,
                            ByVal _cQuantidade As Decimal,
                            ByVal _cValor As Decimal) As Boolean
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()

            bDados.AdicionaParametro(Operacao, "INSE")
            bDados.AdicionaParametro(pItensVenda.cVenda, _cVenda)
            bDados.AdicionaParametro(pItensVenda.cProduto, _cProduto)
            bDados.AdicionaParametro(pItensVenda.cQuantidade, _cQuantidade)
            bDados.AdicionaParametro(pItensVenda.cValor, _cValor)

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
    Shared Function Alterar(ByVal _cItensVenda As Decimal,
                            ByVal _cVenda As Decimal,
                            ByVal _cProduto As Decimal,
                            ByVal _cQuantidade As Decimal,
                            ByVal _cValor As Decimal) As Boolean
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(Operacao, "ALTE")
            bDados.AdicionaParametro(pItensVenda.cItensVenda, _cItensVenda)
            bDados.AdicionaParametro(pItensVenda.cVenda, _cVenda)
            bDados.AdicionaParametro(pItensVenda.cProduto, _cProduto)
            bDados.AdicionaParametro(pItensVenda.cQuantidade, _cQuantidade)
            bDados.AdicionaParametro(pItensVenda.cValor, _cValor)
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

    Shared Function Deletar(ByVal _cItensVenda As Decimal) As Boolean
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(Operacao, "DELE")
            bDados.AdicionaParametro(pItensVenda.cItensVenda, _cItensVenda)

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

    Shared Function Obter(ByVal _cItensVenda As Decimal) As SuperDataSet
        Try
            bDados = New BancoDados()
            oDataSet = New SuperDataSet()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(Operacao, "OBTE")
            bDados.AdicionaParametro(pItensVenda.cItensVenda, _cItensVenda)

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

    Shared Function Pesquisar(ByVal _cVenda As Decimal) As SuperDataSet
        Try
            bDados = New BancoDados()
            oDataSet = New SuperDataSet()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(Operacao, "GRID")
            bDados.AdicionaParametro(pItensVenda.cVenda, _cVenda)

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
