Imports GFT.Util
Imports GFT.Util.BancoDados

Public Class pCliente
    Private Const PROCEDURE As String = "pCliente"
    Private Shared OPERACAO As Campo = New Campo("Operacao", DbType.String, 4)

    Private Shared bDados As BancoDados = Nothing
    Private Shared oDataSet As SuperDataSet = Nothing

    Class pCliente
        Public Shared cCliente As Campo = New Campo("cCliente", DbType.Decimal, 10, 0)
        Public Shared dtCadastro As Campo = New Campo("dtCadastro", DbType.Date, 10, 0)
        Public Shared rNome As Campo = New Campo("rNome", DbType.String, 100)
        Public Shared rCpf As Campo = New Campo("rCpf", DbType.String, 14)
        Public Shared rTelefone As Campo = New Campo("rTelefone", DbType.String, 14)
        Public Shared rEmail As Campo = New Campo("rEmail", DbType.String, 50)
        Public Shared rLogradouro As Campo = New Campo("rLogradouro", DbType.String, 100)
        Public Shared rNumero As Campo = New Campo("rNumero", DbType.String, 20)
        Public Shared rBairro As Campo = New Campo("rBairro", DbType.String, 60)
        Public Shared cCidade As Campo = New Campo("cCidade", DbType.Decimal, 10, 0)
        Public Shared cEstado As Campo = New Campo("cEstado", DbType.Decimal, 2, 0)
        Public Shared dtCadFim As Campo = New Campo("dtCadFim", DbType.Date, 10, 0)
    End Class

    Shared Function Incluir(ByVal _dtCadastro As Date,
                            ByVal _rNome As String,
                            ByVal _rCpf As String,
                            ByVal _rTelefone As String,
                            ByVal _rEmail As String,
                            ByVal _rLogradouro As String,
                            ByVal _rNumero As String,
                            ByVal _rBairro As String,
                            ByVal _cCidade As Decimal,
                            ByVal _cEstado As Decimal) As Boolean
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()

            bDados.AdicionaParametro(OPERACAO, "INSE")
            bDados.AdicionaParametro(pCliente.dtCadastro, _dtCadastro)
            bDados.AdicionaParametro(pCliente.rNome, _rNome)
            bDados.AdicionaParametro(pCliente.rCpf, _rCpf)
            bDados.AdicionaParametro(pCliente.rTelefone, _rTelefone)
            bDados.AdicionaParametro(pCliente.rEmail, _rEmail)
            bDados.AdicionaParametro(pCliente.rLogradouro, _rLogradouro)
            bDados.AdicionaParametro(pCliente.rNumero, _rNumero)
            bDados.AdicionaParametro(pCliente.rBairro, _rBairro)
            bDados.AdicionaParametro(pCliente.cCidade, _cCidade)
            bDados.AdicionaParametro(pCliente.cEstado, _cEstado)

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

    Shared Function Alterar(ByVal _cCliente As Decimal,
                            ByVal _dtCadastro As Date,
                            ByVal _rNome As String,
                            ByVal _rCpf As String,
                            ByVal _rTelefone As String,
                            ByVal _rEmail As String,
                            ByVal _rLogradouro As String,
                            ByVal _rNumero As String,
                            ByVal _rBairro As String,
                            ByVal _cCidade As Decimal,
                            ByVal _cEstado As Decimal) As Boolean
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()

            bDados.AdicionaParametro(OPERACAO, "ALTE")

            bDados.AdicionaParametro(pCliente.cCliente, _cCliente)
            bDados.AdicionaParametro(pCliente.dtCadastro, _dtCadastro)
            bDados.AdicionaParametro(pCliente.rNome, _rNome)
            bDados.AdicionaParametro(pCliente.rCpf, _rCpf)
            bDados.AdicionaParametro(pCliente.rTelefone, _rTelefone)
            bDados.AdicionaParametro(pCliente.rEmail, _rEmail)
            bDados.AdicionaParametro(pCliente.rLogradouro, _rLogradouro)
            bDados.AdicionaParametro(pCliente.rNumero, _rNumero)
            bDados.AdicionaParametro(pCliente.rBairro, _rBairro)
            bDados.AdicionaParametro(pCliente.cCidade, _cCidade)
            bDados.AdicionaParametro(pCliente.cEstado, _cEstado)

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

    Shared Function Deletar(ByVal _cCliente As Decimal) As Boolean
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()

            bDados.AdicionaParametro(OPERACAO, "DELE")
            bDados.AdicionaParametro(pCliente.cCliente, _cCliente)

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

    Shared Function Pesquisar(ByVal _rNome As String,
                              ByVal _cEstado As Decimal,
                              ByVal _cCidade As Decimal,
                              ByRef chk As CheckBox,
                              ByVal _dtInicio As Date,
                              ByVal _dtFim As Date) As SuperDataSet
        Try
            bDados = New BancoDados()
            oDataSet = New SuperDataSet()

            bDados.LimpaParametros()

            bDados.AdicionaParametro(OPERACAO, "GRID")

            bDados.AdicionaParametro(pCliente.rNome, IIf(_rNome <> Nothing, _rNome, Nothing))
            bDados.AdicionaParametro(pCliente.cCidade, _cCidade)
            bDados.AdicionaParametro(pCliente.cEstado, _cEstado)

            If chk IsNot Nothing Then
                If chk.Checked Then
                    bDados.AdicionaParametro(pCliente.dtCadastro, _dtInicio)
                    bDados.AdicionaParametro(pCliente.dtCadFim, _dtFim)
                End If

            End If
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

    Shared Function Obter(ByVal _cCliente As Decimal) As SuperDataSet
        Try
            bDados = New BancoDados()
            oDataSet = New SuperDataSet()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "OBTE")
            bDados.AdicionaParametro(pCliente.cCliente, _cCliente)


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

End Class
