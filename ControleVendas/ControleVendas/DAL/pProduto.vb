Imports GFT.Util
Imports GFT.Util.BancoDados

Public Class pProduto
    Private Const PROCEDURE As String = "pProduto"
    Private Shared Operacao As Campo = New Campo("Operacao", DbType.String, 4)

    Private Shared bDados As BancoDados = Nothing
    Private Shared oDataSet As SuperDataSet = Nothing

    Class pProduto
        Public Shared cProduto As Campo = New Campo("cProduto", DbType.Decimal, 10, 0)
        Public Shared dtEntrada As Campo = New Campo("dtEntrada", DbType.Date, 10, 0)
        Public Shared rProduto As Campo = New Campo("rProduto", DbType.String, 100)
        Public Shared cValor As Campo = New Campo("cValor", DbType.Decimal, 4, 0)
        Public Shared cTamanho As Campo = New Campo("cTamanho", DbType.Decimal, 18, 0)
        Public Shared rCor As Campo = New Campo("rCor", DbType.String, 50)
        Public Shared cEstoqueIdeal As Campo = New Campo("cEstoqueIdeal", DbType.Decimal, 18, 0)
        Public Shared cEstoqueMin As Campo = New Campo("cEstoqueMin", DbType.Decimal, 18, 0)
        Public Shared cCusto As Campo = New Campo("cCusto", DbType.Decimal, 18, 2)
        Public Shared cImagem As Campo = New Campo("cImagem", DbType.Decimal, 10, 0)
    End Class

    Shared Function Incluir(ByVal _dtEntrada As Date,
                       ByVal _rProduto As String,
                       ByVal _cValor As Decimal,
                       ByVal _cTamanho As Decimal,
                       ByVal _rCor As String,
                       ByVal _cQuantidade As Decimal,
                       ByVal _cEstoqueMin As Decimal,
                       ByVal _cCusto As Decimal,
                       ByVal _cImagem As Decimal) As SuperDataSet
        Try
            bDados = New BancoDados()
            oDataSet = New SuperDataSet()

            bDados.LimpaParametros()

            bDados.AdicionaParametro(Operacao, "INSE")
            bDados.AdicionaParametro(pProduto.dtEntrada, _dtEntrada)
            bDados.AdicionaParametro(pProduto.rProduto, _rProduto)
            bDados.AdicionaParametro(pProduto.cValor, _cValor)
            bDados.AdicionaParametro(pProduto.cTamanho, _cTamanho)
            bDados.AdicionaParametro(pProduto.rCor, _rCor)
            bDados.AdicionaParametro(pProduto.cEstoqueIdeal, _cQuantidade)
            bDados.AdicionaParametro(pProduto.cEstoqueMin, _cEstoqueMin)
            bDados.AdicionaParametro(pProduto.cCusto, _cCusto)
            bDados.AdicionaParametro(pProduto.cImagem, _cImagem)

            oDataSet = bDados.Obter(PROCEDURE)

            If oDataSet IsNot Nothing Then
                Return oDataSet
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function
    Shared Function Alterar(ByVal _cProduto As Decimal,
                            ByVal _dtEntrada As Date,
                            ByVal _rProduto As String,
                            ByVal _cValor As Decimal,
                            ByVal _cTamanho As Decimal,
                            ByVal _rCor As String,
                            ByVal _cQuantidade As Decimal,
                            ByVal _cEstoqueMin As Decimal,
                            ByVal _cCusto As Decimal,
                            ByVal _cImagem As Decimal) As Boolean
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()

            bDados.AdicionaParametro(Operacao, "ALTE")
            bDados.AdicionaParametro(pProduto.cProduto, _cProduto)
            bDados.AdicionaParametro(pProduto.dtEntrada, _dtEntrada)
            bDados.AdicionaParametro(pProduto.rProduto, _rProduto)
            bDados.AdicionaParametro(pProduto.cValor, _cValor)
            bDados.AdicionaParametro(pProduto.cTamanho, _cTamanho)
            bDados.AdicionaParametro(pProduto.rCor, _rCor)
            bDados.AdicionaParametro(pProduto.cEstoqueIdeal, _cQuantidade)
            bDados.AdicionaParametro(pProduto.cEstoqueMin, _cEstoqueMin)
            bDados.AdicionaParametro(pProduto.cCusto, _cCusto)
            bDados.AdicionaParametro(pProduto.cImagem, _cImagem)

            If bDados.Executar(PROCEDURE) Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Shared Function Deletar(ByVal _cProduto As Decimal) As Boolean
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()

            bDados.AdicionaParametro(Operacao, "DELE")

            bDados.AdicionaParametro(pProduto.cProduto, _cProduto)

            If bDados.Executar(PROCEDURE) Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function
    Shared Function Obter(ByVal _cProduto As Decimal) As SuperDataSet
        Try
            oDataSet = New SuperDataSet()

            bDados = New BancoDados()

            bDados.LimpaParametros()

            bDados.AdicionaParametro(Operacao, "OBTE")

            bDados.AdicionaParametro(pProduto.cProduto, _cProduto)

            oDataSet = bDados.Obter(PROCEDURE)

            If oDataSet.TotalRegistros > 0 Then
                Return oDataSet
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function
    Shared Function Pesquisar(ByVal _rProduto As String,
                              ByVal _cTamanho As Decimal,
                              ByVal _rCor As String) As SuperDataSet
        Try
            oDataSet = New SuperDataSet()

            bDados = New BancoDados()

            bDados.LimpaParametros()

            bDados.AdicionaParametro(Operacao, "GRID")

            bDados.AdicionaParametro(pProduto.rProduto, _rProduto)
            bDados.AdicionaParametro(pProduto.cTamanho, _cTamanho)
            bDados.AdicionaParametro(pProduto.rCor, _rCor)

            oDataSet = bDados.Obter(PROCEDURE)

            If oDataSet IsNot Nothing Then
                Return oDataSet
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Shared Function ObterCombo() As SuperDataSet
        Try
            oDataSet = New SuperDataSet()

            bDados = New BancoDados()

            bDados.LimpaParametros()

            bDados.AdicionaParametro(Operacao, "COMB")


            oDataSet = bDados.Obter(PROCEDURE)

            If oDataSet IsNot Nothing Then
                Return oDataSet
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

End Class
