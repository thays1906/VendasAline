Imports GFT.Util.clsMsgBox
Imports GFT.Util.SuperComboBox
Imports GFT.Util
Public Class frmVendas
    Public oForm As frmListaProdutos
    Public oDataSet As SuperDataSet = Nothing
    Public rsVenda As SuperDataSet = Nothing
    Public rItemVenda(4) As String
    Public cValorUn As Double = Nothing
    Public cValorTot As Double = Nothing
    Public cTotalVenda As Double = Nothing
    Public cQtde As Decimal = Nothing
    Public cCodigo As Decimal = Nothing
    Public cEstoque As Decimal = Nothing
    Public controleEstoque As Dictionary(Of Decimal, Decimal)
    Public bConsulta As Boolean = False
    Public qtdeControle As Decimal = Nothing
    Sub New(Optional ByVal _bConsulta As Boolean = False)

        InitializeComponent()

        If _bConsulta Then
            bConsulta = _bConsulta
        End If
    End Sub
    Private Sub frmVendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cor(Me, Collor.Control)
        Cor(CType(gbBotoes, Control), Collor.CinzaAzulado)

        CorButton(btnAdicionar, Collor.CinzaAzulado, Color.White, Color.SteelBlue, Color.Gray)
        CorButton(btnEditarItem, Collor.CinzaAzulado, Color.White, Color.SteelBlue, Color.Gray)
        CorButton(btnRemoverItem, Collor.CinzaAzulado, Color.White, Color.SteelBlue, Color.Gray)
        CorButton(btnFechar, Collor.Gelo, Color.White, Color.White, Color.WhiteSmoke)
        CorButton(btnFinalizaVenda, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnPesquisar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnEditar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnExcluir, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnExportar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnVoltar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)

        ListaCliente()
        ListaProduto()
        CarregaDataGrid()

        If bConsulta Then
            tabCtrlVenda.SelectedTab = tpConsulta
        End If
    End Sub

    Private Sub frmVendas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        restaurarMDI()
    End Sub

    Private Sub frmVendas_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        alterarCaptionFormPrincipal(eTela.Vendas)
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub ListaProduto()

        Try
            oDataSet = New SuperDataSet()
            oDataSet = pEstoque.Lista(Nothing)

            cbProduto.PreencheComboDS(oDataSet,
                                      "Produto",
                                      "id_cProduto",
                                      PrimeiroValor.Selecione)

            controleEstoque = New Dictionary(Of Decimal, Decimal)

            For Each prod As DataRow In oDataSet.Tables(0).Rows
                controleEstoque.Add(CInt(prod("id_cProduto")), CInt(prod("Estoque atual")))
            Next

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
            LogaErro(ex.Message)
        End Try
    End Sub
    Private Sub ListaCliente()
        Try
            oDataSet = New SuperDataSet()

            oDataSet = pCliente.Pesquisar(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

            cbCliente.PreencheComboDS(oDataSet,
                                      "as_Cliente",
                                      "id_cCliente",
                                      PrimeiroValor.Selecione)

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
            LogaErro(ex.Message)
        Finally
            oDataSet.Dispose()
        End Try
    End Sub
    Private Sub CarregaDataGrid()
        Dim col As Collection = Nothing
        Try
            col = New Collection()

            If oDataSet.TotalTabelas = 1 Then

                oDataSet.Tables.Add("Produto")

                oDataSet.Tables(1).Columns.Add("Nome do Produto")
                oDataSet.Tables(1).Columns.Add("Quantidade")
                oDataSet.Tables(1).Columns.Add("Valor Unitario")
                oDataSet.Tables(1).Columns.Add("Valor Total")
                oDataSet.Tables(1).Columns.Add("Id_cProduto")

                dgVenda.PreencheDataGrid(oDataSet, 1)

                dgVenda.Columns("Nome do Produto").Width = 500

                dgVenda.Columns("Quantidade").Width = 150
                dgVenda.Columns("Quantidade").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End If


            col.Add(New DuplaCombo(eFormaPagamento.Dinheiro, "Dinheiro"))
            col.Add(New DuplaCombo(eFormaPagamento.Debito, "Débito"))
            col.Add(New DuplaCombo(eFormaPagamento.Credito, "Crédito"))

            cbPagamento.PreencheComboColl(col, PrimeiroValor.Selecione)



        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
            LogaErro(ex.Message)
        Finally
            col.Clear()
        End Try
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        Try

            If cbProduto.ObterChaveCombo <> "0" Then

                If nudQuantidade.Value > cEstoque Then

                    S_MsgBox("Estoque insuficiente para essa venda." & vbNewLine &
                             "Estoque Disponível: " & cEstoque,
                            eBotoes.Ok,
                            "Quantidade adicionada, é maior que o estoque disponível.",,
                            eImagens.Atencao)
                    Exit Sub

                ElseIf nudQuantidade.Value = 0 Then
                    S_MsgBox("É necessário informar a Quantidade, para adicionar o produto.",
                            eBotoes.Ok,
                            "Picarruchas",,
                            eImagens.Atencao)
                    Exit Sub
                End If

                rItemVenda(0) = cbProduto.ObterDescricaoCombo
                rItemVenda(1) = nudQuantidade.Value.ToString
                rItemVenda(2) = txtValorUn.Text
                rItemVenda(3) = txtValorTotal.Text
                rItemVenda(4) = cCodigo.ToString



                oDataSet.Tables(1).Rows.Add(rItemVenda)

                cQtde = nudQuantidade.Value

                controleEstoque.Item(cCodigo) -= cQtde

                AdicionarItem()
            Else
                S_MsgBox("Nenhum produto selecionado.",
                         eBotoes.Ok,
                         "Picarruchas",,
                         eImagens.Info)

            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
            LogaErro(ex.Message)
        End Try
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemoverItem.Click
        Dim cChecados As Decimal = Nothing
        Try
            cQtde = 0
            cChecados = dgVenda.ObterTodosChecados

            If cChecados <> 0 Then

                If cChecados = 1 Then

                    cQtde = CDec(dgVenda.CurrentRow.Cells("Quantidade").Value)
                    cValorTot = CDec(dgVenda.CurrentRow.Cells("Valor Total").Value)
                    cCodigo = CDec(dgVenda.CurrentRow.Cells("id_cProduto").Value)

                    oDataSet.Tables(1).Rows.RemoveAt(dgVenda.CurrentRow.Index)

                    controleEstoque.Item(cCodigo) += cQtde

                ElseIf cChecados > 1 Then

                    For Each linha As DataGridViewRow In dgVenda.SelectedRows

                        cQtde += CDec(linha.Cells("Quantidade").Value)
                        cValorTot += CDec(linha.Cells("Valor Total").Value)
                        cCodigo = CDec(linha.Cells("id_cProduto").Value)

                        dgVenda.Rows.Remove(linha)

                        controleEstoque.Item(cCodigo) += CDec(linha.Cells("Quantidade").Value)

                    Next
                End If

                cTotalVenda = cTotalVenda - cValorTot
                btnSacola.Text = (CDec(btnSacola.Text) - cQtde).ToString
                btnTotalVenda.Text = cTotalVenda.ToString
            Else
                S_MsgBox("Nenhum produto selecionado.",
                         eBotoes.Ok,
                         "Picarruchas",,
                         eImagens.Info)
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
            LogaErro(ex.Message)
        End Try
    End Sub


    Private Sub btnPesquisarProd_Click(sender As Object, e As EventArgs) Handles btnPesquisarProd.Click
        Try
            cQtde = 0
            cValorTot = 0
            oForm = New frmListaProdutos
            oForm.ShowDialog()

            If oForm.listItens.Count <> 0 Then

                For Each item As ItemProduto In oForm.listItens

                    rItemVenda(0) = oDataSet("Produto", CInt(item.cCodigo)).ToString
                    rItemVenda(1) = item.cQuantidade.ToString
                    rItemVenda(2) = item.cValorUn.ToString("C2")
                    rItemVenda(3) = (item.cQuantidade * item.cValorUn).ToString("C2")
                    rItemVenda(4) = item.cCodigo.ToString

                    oDataSet.Tables(1).Rows.Add(rItemVenda)
                    cValorTot += CDec(rItemVenda(3))
                    cQtde += CDec(rItemVenda(1))

                    controleEstoque.Item(cCodigo) -= item.cQuantidade
                Next
                AdicionarItem()
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
            LogaErro(ex.Message)
        End Try
    End Sub
    Private Sub AdicionarItem(Optional ByVal bItemEditado As Boolean = False)
        Try
            If bItemEditado Then

                cQtde = 0
                cTotalVenda = 0

                For i = 0 To dgVenda.Rows.Count - 1

                    cQtde += CDec(dgVenda.Rows(i).Cells("Quantidade").Value)
                    cTotalVenda += CDec(dgVenda.Rows(i).Cells("Valor Total").Value)

                Next

                btnSacola.Text = cQtde.ToString
                btnTotalVenda.Text = Convert.ToDouble(cTotalVenda).ToString("C2")
            Else

                cTotalVenda += cValorTot

                btnSacola.Text = (CDec(btnSacola.Text) + cQtde).ToString

                btnTotalVenda.Text = btnTotalVenda.Text.Replace("R$", "")
                btnTotalVenda.Text = Convert.ToDouble(cTotalVenda).ToString("C2")
                LimpaCampos(0)

            End If






        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
            LogaErro(ex.Message)
        End Try
    End Sub
    Private Sub cbProduto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProduto.SelectedIndexChanged
        Try
            If cbProduto.ObterChaveCombo <> "0" Then

                nudQuantidade.Value = 1
                cValorUn = Convert.ToDouble(oDataSet("Valor Unitário", cbProduto.SelectedIndex - 1))
                txtValorUn.Text = cValorUn.ToString("C2")

                cValorTot = Convert.ToDouble(cValorUn * nudQuantidade.Value)
                txtValorTotal.Text = cValorTot.ToString("C2")

                cCodigo = CDec(oDataSet("Id_cProduto", cbProduto.SelectedIndex - 1))

                'cEstoque = CDec(oDataSet("Estoque atual", cbProduto.SelectedIndex - 1))

                cEstoque = controleEstoque.Item(cCodigo)



                lblEstoque.Text = "Disponível: " + cEstoque.ToString


            End If
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
            LogaErro(ex.Message)
        End Try
    End Sub

    Private Sub LimpaCampos(ByVal ok As Decimal)
        Try
            nudQuantidade.Value = 1
            txtValorTotal.Text = ""
            txtValorUn.Text = ""
            cbProduto.SelectedIndex = 0
            lblEstoque.Text = "Disponível: "
            cValorTot = 0
            cQtde = 0

            If ok <> 0 Then
                oDataSet.Tables(1).Clear()
                btnSacola.Text = "0"
                btnTotalVenda.Text = "0,00"
                cTotalVenda = 0
                cbCliente.SelectedIndex = 0
            End If

            For i = 0 To rItemVenda.Length - 1
                rItemVenda(i) = ""
            Next

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
            LogaErro(ex.Message)
        End Try
    End Sub


    Private Sub cbProduto_TextUpdate(sender As Object, e As EventArgs) Handles cbProduto.TextUpdate
        Try
            oDataSet = New SuperDataSet()

            oDataSet = pEstoque.Lista(cbProduto.ObterDescricaoCombo)

            cbProduto.PreencheComboDS(oDataSet, "Produto", "id_cProduto", PrimeiroValor.Selecione)

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
            LogaErro(ex.Message)
        End Try
    End Sub

    Private Sub nudQuantidade_ValueChanged(sender As Object, e As EventArgs) Handles nudQuantidade.ValueChanged
        Try
            If cbProduto.ObterChaveCombo <> "0" Then
                cQtde = nudQuantidade.Value

                If txtValorUn.Text <> "" Then
                    cValorUn = CDbl(txtValorUn.Text)
                    cValorTot = Convert.ToDouble(cQtde * cValorUn)
                    txtValorTotal.Text = cValorTot.ToString("C2")
                End If

                If cQtde > cEstoque And CDec(cbProduto.ObterChaveCombo) <> 0 Then
                    nudQuantidade.ForeColor = Color.Red
                Else
                    nudQuantidade.ForeColor = Color.Black
                End If
            End If


        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
            LogaErro(ex.Message)
        End Try
    End Sub

    Private Sub btnFinalizaVenda_Click(sender As Object, e As EventArgs) Handles btnFinalizaVenda.Click
        Dim rsCodVenda As SuperDataSet = Nothing
        Dim cVenda As Decimal = Nothing
        Dim cOk As Decimal = Nothing
        Dim cErro As Decimal = Nothing
        Dim rMsg As String = Nothing
        Dim oForm As frmVendaFinalizada
        Try

            If VerificarDados() Then



                rsCodVenda = New SuperDataSet()

                rsCodVenda = pVenda.Incluir(CDec(cbCliente.ObterChaveCombo),
                                           CDec(cTotalVenda),
                                           dtVenda.Value,
                                           CType(cbPagamento.ObterChaveCombo, eFormaPagamento))

                If rsCodVenda.TotalRegistros > 0 Then

                    cVenda = CDec(rsCodVenda("cVenda"))

                    For i = 0 To oDataSet.Tables(1).Rows.Count - 1

                        cCodigo = CDec(oDataSet("id_cProduto", i, 1))
                        cQtde = CDec(oDataSet("Quantidade", i, 1))
                        cValorTot = CDec(oDataSet("Valor Total", i, 1))

                        If pItensVenda.Incluir(cVenda, cCodigo, cQtde, CDec(cValorTot)) Then
                            cOk += 1

                            If pEstoque.Alterar(cCodigo, cQtde, Nothing, dtVenda.Value, 2) Then
                                rMsg = "O estoque foi atualizado."
                            End If
                        Else
                            cErro += 1
                        End If
                    Next

                    If cErro = 0 And cOk <> 0 Then
                        oForm = New frmVendaFinalizada(cVenda)
                        oForm.ShowDialog()
                        S_MsgBox("Lançamento efetuado com sucesso!" & vbNewLine &
                                 rMsg,
                                 eBotoes.Ok,
                                 "Venda efetivada",,
                                 eImagens.FileOK)
                        LimpaCampos(cOk)
                    ElseIf cErro <> 0 Then

                        S_MsgBox("Desculpe, houve uma falha na finalização da venda.",
                                 eBotoes.Ok,
                                 "Lançamento efetuado com erros",,
                                 eImagens.Cancel)

                    End If
                End If

            End If
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
            If cOk <> 0 Then
                oDataSet.Clear()
            End If
            LogaErro(ex.Message)
        End Try
    End Sub

    Private Function VerificarDados() As Boolean
        Try
            If cbCliente.VerificaObrigatorio = False Then
                Return False
            End If

            If oDataSet.Tables.Count = 1 OrElse oDataSet.Tables(1).Rows.Count = 0 Then
                S_MsgBox("Nenhum produto foi adicionado ao pedido, adicione um produto para concluir a venda.",
                         eBotoes.Ok,
                         "",,
                         eImagens.Atencao)
                Return False
            End If
            Return True
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
            LogaErro(ex.Message)
            Return False
        End Try
    End Function

    Private Sub btnEditarItem_Click(sender As Object, e As EventArgs) Handles btnEditarItem.Click
        Dim cChecados As Decimal = Nothing
        Dim iIndex As Integer = Nothing
        Dim frmItem As frmItemVenda
        Try
            cChecados = dgVenda.ObterTodosChecados

            If cChecados = 1 Then

                iIndex = dgVenda.CurrentCell.RowIndex

                rItemVenda(0) = oDataSet("Nome do Produto", iIndex, 1).ToString
                rItemVenda(1) = oDataSet("Quantidade", iIndex, 1).ToString
                rItemVenda(2) = oDataSet("Valor Unitario", iIndex, 1).ToString
                rItemVenda(3) = oDataSet("Valor Total", iIndex, 1).ToString
                cCodigo = CDec(oDataSet("id_cProduto", iIndex, 1))

                frmItem = New frmItemVenda(rItemVenda)
                frmItem.ShowDialog()

                If frmItem.DialogResult = DialogResult.Yes Then

                    dgVenda.Item(2, iIndex).Value = frmItem.rItensVenda(1)
                    dgVenda.Item(3, iIndex).Value = frmItem.rItensVenda(2)
                    dgVenda.Item(4, iIndex).Value = frmItem.rItensVenda(3)

                    dgVenda.Refresh()

                    controleEstoque.Item(cCodigo) = CDec(frmItem.rItensVenda(1))
                    AdicionarItem(True)

                End If
            End If


        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
            LogaErro(ex.Message)
        End Try
    End Sub
    Private Sub txtValorUn_Enter(sender As Object, e As EventArgs) Handles txtValorUn.Enter
        txtValorUn.Text = ""
    End Sub

    Private Sub dgVenda_SelectionChanged(sender As Object, e As EventArgs) Handles dgVenda.SelectionChanged
        Dim cChecados As Decimal = Nothing
        Try
            If dgVenda.bCarregado Then

                cChecados = dgVenda.ObterTodosChecados

                If cChecados = 1 Then

                    btnEditarItem.Enabled = True

                ElseIf cChecados > 1 Then

                    btnEditarItem.Enabled = False
                End If

            End If
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
            LogaErro(ex.Message)
        End Try
    End Sub


#Region "Consulta Vendas"
    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        tabCtrlVenda.SelectedIndex = 0
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Dim oXls As SuperXLS
        Try
            oXls = New SuperXLS("Vendas")

            oXls.Imprimir(rsVenda, "", True, False, True, False)

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
            LogaErro(ex.Message)
        End Try
    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Try
            rsVenda = New SuperDataSet()

            rsVenda = pVenda.Pesquisar()

            If rsVenda IsNot Nothing Then

                dgConsultaVenda.PreencheDataGrid(rsVenda,,, txtLetreiroVenda)

            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
            LogaErro(ex.Message)
        End Try
    End Sub

    Private Sub tabCtrlVenda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabCtrlVenda.SelectedIndexChanged
        Try
            If tabCtrlVenda.SelectedIndex = 1 Then
                btnPesquisar.PerformClick()
            End If
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
            LogaErro(ex.Message)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim oForm As frmVendaFinalizada
        Try
            cCodigo = dgConsultaVenda.ObterChave

            If cCodigo <> 0 Then
                oForm = New frmVendaFinalizada(cCodigo)
                oForm.ShowDialog()
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
            LogaErro(ex.Message)
        End Try
    End Sub



    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

    End Sub




#End Region
End Class