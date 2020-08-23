Imports GFT.Util.BancoDados
Imports GFT.Util
Imports GFT.Util.clsMsgBox

Public Class pImagem
    Private Const PROCEDURE As String = "pImagem"
    Private Shared Operacao As Campo = New Campo("Operacao", DbType.String, 4)

    Private Shared bDados As BancoDados = Nothing
    Private Shared oDataSet As SuperDataSet = Nothing

    Class pImagem
        Public Shared cImagem As Campo = New Campo("cImagem", DbType.Decimal, 10, 0)
        Public Shared rFileName As Campo = New Campo("rFileName", DbType.String, -1)
        Public Shared bTamanho As Campo = New Campo("bTamanho", DbType.Binary, -1, -1)
    End Class

    Shared Function Incluir(ByVal _fileName As String,
                            ByVal _tamanho As Byte()) As SuperDataSet
        Try
            bDados = New BancoDados()
            oDataSet = Nothing

            bDados.LimpaParametros()

            bDados.AdicionaParametro(Operacao, "INSE")
            bDados.AdicionaParametro(pImagem.rFileName, _fileName)
            bDados.AdicionaParametro(pImagem.bTamanho, _tamanho)

            oDataSet = bDados.Obter(PROCEDURE)

            If oDataSet IsNot Nothing And oDataSet.TotalRegistros > 0 Then
                Return oDataSet
            Else
                Return Nothing
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message,
                     eBotoes.Ok,
                     "Houve uma falha no banco de dados",,
                     eImagens.Cancel)
            Return Nothing
        End Try
    End Function
    Shared Function Alterar(ByVal _cImagem As Decimal,
                            ByVal _fileName As String,
                            ByVal _tamanho As Byte()) As Boolean
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()

            bDados.AdicionaParametro(Operacao, "ALTE")
            bDados.AdicionaParametro(pImagem.cImagem, _cImagem)
            bDados.AdicionaParametro(pImagem.rFileName, _fileName)
            bDados.AdicionaParametro(pImagem.bTamanho, _tamanho)


            If bDados.Executar(PROCEDURE) Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message,
                     eBotoes.Ok,
                     "Houve uma falha no banco de dados",,
                     eImagens.Cancel)
            Return False
        End Try
    End Function

    Shared Function Deletar(ByVal _cImagem As Decimal) As Boolean
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(Operacao, "DELE")
            bDados.AdicionaParametro(pImagem.cImagem, _cImagem)

            If bDados.Executar(PROCEDURE) Then
                Return True
            Else
                Return False

            End If

        Catch ex As Exception

            S_MsgBox(ex.Message,
                     eBotoes.Ok,
                     "Houve uma falha no banco de dados",,
                     eImagens.Cancel)

            Return False
        End Try
    End Function
    Shared Function Obter(ByVal _cImagem As Decimal) As SuperDataSet
        Try
            bDados = New BancoDados()

            oDataSet = New SuperDataSet()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(Operacao, "OBTE")
            bDados.AdicionaParametro(pImagem.cImagem, _cImagem)

            oDataSet = bDados.Obter(PROCEDURE)

            If oDataSet IsNot Nothing Then
                Return oDataSet
            Else
                Return oDataSet

            End If

        Catch ex As Exception

            S_MsgBox(ex.Message,
                     eBotoes.Ok,
                     "Houve uma falha no banco de dados",,
                     eImagens.Cancel)
            Return Nothing
        End Try
    End Function

End Class
