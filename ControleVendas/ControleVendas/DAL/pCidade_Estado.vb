Imports GFT.Util
Imports GFT.Util.BancoDados

Public Class pCidade_Estado
    Private Shared oDataSet As SuperDataSet = Nothing
    Private Shared bDados As BancoDados

    Private Shared Operacao As Campo = New Campo("Operacao", DbType.String, 4)
    Private Shared cEstado As Campo = New Campo("cEstado", DbType.Decimal, 2, 0)
    Private Const pCidade As String = "pCidade"
    Private Const pEstado As String = "pEstado"

    Shared Function ObterCidade(ByVal _codEstado As Decimal) As SuperDataSet
        Try
            oDataSet = New SuperDataSet()
            bDados = New BancoDados()

            bDados.AdicionaParametro(Operacao, "COMB")
            bDados.AdicionaParametro(cEstado, _codEstado)

            oDataSet = bDados.Obter(pCidade)

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

    Shared Function ObterEstado() As SuperDataSet
        Try
            oDataSet = New SuperDataSet()
            bDados = New BancoDados()

            bDados.AdicionaParametro(Operacao, "COMB")

            oDataSet = bDados.Obter(pEstado)

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

End Class
