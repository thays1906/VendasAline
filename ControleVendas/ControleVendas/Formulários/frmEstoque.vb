Imports GFT.Util.clsMsgBox
Imports GFT.Util
Imports GFT.Util.SuperComboBox

Public Class frmEstoque
    Private oDataSet As SuperDataSet = Nothing
    Private cProduto As Decimal = Nothing
    Private oForm As frmEntrada
    Private Sub frmEstoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Cor(Me, Collor.Control)
        Cor(CType(gbBotoes, Control), Collor.CinzaMedio)

        CorButton(btnPesquisar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnEntrada, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnSaida, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnFechar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CarregarCombo()
    End Sub
    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Pesquisar()
    End Sub
    Private Sub Pesquisar()
        Dim _tipoMovimentacao As eTipoMovimentacao
        Dim dtInicial As Date = Nothing
        Dim dtFinal As Date = Nothing
        Dim cTamanho As Decimal = Nothing
        Try
            oDataSet = New SuperDataSet()

            pEstoque.ConfirmaInsert()

            If chkEntrada.Checked Then

                dtInicial = dtEntradaInicial.Value
                dtFinal = dtEntradaFinal.Value
                _tipoMovimentacao = eTipoMovimentacao.Entrada

            ElseIf chkSaida.Checked Then

                dtInicial = dtSaidaInicial.Value
                dtFinal = dtSaidaFinal.Value
                _tipoMovimentacao = eTipoMovimentacao.Saida

            End If

            If cbTamanho.SelectedIndex <> 0 Then
                cTamanho = CDec(cbTamanho.ObterChaveCombo)
            End If

            oDataSet = pEstoque.Pesquisar(txtProduto.Text,
                                          cTamanho,
                                          dtInicial,
                                          dtFinal,
                                          _tipoMovimentacao)

            dgEstoque.PreencheDataGrid(oDataSet,,, txtLetreiro)


        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub


    Private Sub frmEstoque_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        alterarCaptionFormPrincipal(eTela.Estoque)
    End Sub

    Private Sub frmEstoque_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        restaurarMDI()
    End Sub

    Private Sub btnEntrada_Click(sender As Object, e As EventArgs) Handles btnEntrada.Click
        Try
            If dgEstoque.ObterTodosChecados > 0 Then
                cProduto = dgEstoque.ObterChave
                oForm = New frmEntrada(cProduto, eTipoMovimentacao.Entrada)
                oForm.ShowDialog()

                If oForm.bAlterado Then
                    Pesquisar()
                End If
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub frmEstoque_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Try
            Pesquisar()
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnSaida_Click(sender As Object, e As EventArgs) Handles btnSaida.Click
        Try
            If dgEstoque.ObterTodosChecados > 0 Then

                cProduto = dgEstoque.ObterChave

                If cProduto <> 0 Then

                    oForm = New frmEntrada(cProduto, eTipoMovimentacao.Saida)
                    oForm.ShowDialog()

                    If oForm.bAlterado Then
                        Pesquisar()
                    End If
                Else
                    S_MsgBox("Desculpe, ocorreu um erro inesperado. Tente novamente.",
                         eBotoes.Ok, "",,
                         eImagens.Info)
                End If

            Else
                S_MsgBox("Nenhum registro selecionado.",
                         eBotoes.Ok, "",,
                         eImagens.Info)
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub
    Private Sub ControleBotoes()
        Try

            If dgEstoque.ObterTodosChecados > 0 Then
                btnEntrada.Enabled = True
                btnSaida.Enabled = True
            Else
                btnEntrada.Enabled = False
                btnSaida.Enabled = False
            End If
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub dgEstoque_SelectionChanged(sender As Object, e As EventArgs) Handles dgEstoque.SelectionChanged
        Try
            If dgEstoque.bCarregado Then
                ControleBotoes()
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub dtEntradaInicial_Enter(sender As Object, e As EventArgs) Handles dtEntradaInicial.Enter
        Try
            dtSaidaFinal.Checked = False
            dtSaidaInicial.Checked = False
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub chkEntrada_CheckedChanged(sender As Object, e As EventArgs) Handles chkEntrada.CheckedChanged
        Try
            If chkEntrada.Checked Then
                dtEntradaInicial.Enabled = True
                dtEntradaFinal.Enabled = True
                chkSaida.Checked = False
            Else
                dtEntradaInicial.Enabled = False
                dtEntradaFinal.Enabled = False
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub chkSaida_CheckedChanged(sender As Object, e As EventArgs) Handles chkSaida.CheckedChanged
        Try
            If chkSaida.Checked Then
                dtSaidaInicial.Enabled = True
                dtSaidaFinal.Enabled = True
                chkEntrada.Checked = False
            Else
                dtSaidaInicial.Enabled = False
                dtSaidaFinal.Enabled = False
            End If


        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub
    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Dim oXls As SuperXLS
        Try
            oXls = New SuperXLS("Estoque")
            If oDataSet IsNot Nothing Then
                oXls.Imprimir(oDataSet, "", True, True, True, False)
            Else
                S_MsgBox("Nenhum registro para exportar.",
                         eBotoes.Ok,
                         "Picarruchas",,
                         eImagens.Info)
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        Finally
            oDataSet.Dispose()
        End Try
    End Sub
    Private Sub CarregarCombo()
        Dim col As Collection = Nothing
        Try
            col = New Collection()

            For i = 33 To 41
                col.Add(New DuplaCombo(i, i.ToString))
            Next

            cbTamanho.PreencheComboColl(col, PrimeiroValor.Todos)

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        Finally
            col.Clear()
        End Try
    End Sub

    Private Sub txtProduto_KeyUp(sender As Object, e As KeyEventArgs) Handles txtProduto.KeyUp
        Pesquisar()
    End Sub

    Private Sub cbTamanho_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTamanho.SelectedIndexChanged
        Try
            If cbTamanho.Items.Count > 0 Then
                Pesquisar()
            End If
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub
End Class