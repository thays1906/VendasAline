Imports GFT.Util.clsMsgBox
Imports GFT.Util

Public Class frmEntrada
    Public cProduto As Decimal = Nothing
    Public cLancamento As Decimal = Nothing
    Public bAlterado As Boolean = False
    Public bFormPrincipal As Boolean = False
    Sub New(ByVal _cProduto As Decimal,
            ByVal tipoLancamento As eTipoMovimentacao,
            Optional ByVal _bFormPrincipal As Boolean = False)

        InitializeComponent()

        cProduto = _cProduto
        cLancamento = tipoLancamento
        bFormPrincipal = _bFormPrincipal
    End Sub
    Private Sub frmEntrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cor(Me, Collor.CinzaAzulado)

        CorButton(btnSalvar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnFechar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)

        If cLancamento = eTipoMovimentacao.Entrada Then

            lblTitulo.Text = "Entrada de Produtos"
            lblData.Text = "Data de Entrada"

        ElseIf cLancamento = eTipoMovimentacao.Saida Then
            lblTitulo.Text = "Saída de Produtos"
            lblData.Text = "Data de Sáida"
        End If

        If bFormPrincipal Then
            CarregaCombo()
        End If
    End Sub
    Private Sub frmEntrada_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtQuantidade.Focus()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim cOk As Decimal = Nothing
        Dim cErro As Decimal = Nothing
        Try

            If txtQuantidade.VerificaObrigatorio = False Then

                Exit Sub

            Else

                If cLancamento = 1 Then
                    'Entrada
                    If bFormPrincipal Then

                        If cbProduto.SelectedIndex = 0 Then

                            lblProdutoObg.Visible = True
                            Exit Sub
                        End If
                    End If

                    If pEstoque.Alterar(cProduto,
                                        CDec(txtQuantidade.Text),
                                        dtEntrada.Value,
                                        Nothing, 1) Then
                        cOk += 1
                        bAlterado = True
                        DialogResult = DialogResult.OK
                    Else
                        cErro += 1
                    End If

                ElseIf cLancamento = 2 Then
                    'Saida
                    If pEstoque.Alterar(cProduto,
                                        CDec(txtQuantidade.Text),
                                        Nothing,
                                        dtEntrada.Value, 2) Then
                        cOk += 1
                        bAlterado = True
                        DialogResult = DialogResult.OK
                    Else
                        cErro += 1
                    End If

                End If

                If cErro = 0 And cOk <> 0 Then

                    S_MsgBox("Lançamento efetuado com sucesso!",
                        eBotoes.Ok,
                        "Estoque atualizado",,
                        eImagens.FileOK)
                    Me.bAlterado.ToString()
                Else
                    S_MsgBox("Desculpe, houve um erro",
                        eBotoes.Ok,
                        "Falha ao atualizar estoque",,
                        eImagens.FileOK)
                    Me.bAlterado.ToString()
                End If
                Me.Close()
            End If
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub
    Private Sub CarregaCombo()
        Dim oDataSet As SuperDataSet = Nothing
        Try
            oDataSet = New SuperDataSet()

            oDataSet = pEstoque.Lista(Nothing)

            If oDataSet IsNot Nothing OrElse oDataSet.TotalRegistros > 0 Then

                cbProduto.PreencheComboDS(oDataSet,
                                      "Produto",
                                      "id_cProduto",
                                      SuperComboBox.PrimeiroValor.Selecione)
                cbProduto.Visible = True
                lblProduto.Visible = True
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        Finally
            If oDataSet IsNot Nothing Then
                oDataSet.Dispose()
            End If
        End Try
    End Sub

    Private Sub cbProduto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProduto.SelectedIndexChanged
        Try
            If cbProduto.SelectedIndex <> 0 Then
                lblProdutoObg.Visible = False
                cProduto = CDec(cbProduto.ObterChaveCombo)
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub
End Class