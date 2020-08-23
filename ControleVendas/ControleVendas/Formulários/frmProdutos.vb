Imports GFT.Util
Imports GFT.Util.SuperComboBox
Imports GFT.Util.clsMsgBox
Public Class frmProdutos
    Public oDataSet As SuperDataSet = Nothing
    Public novoProd As frmNovoProduto
    Public cProduto As Decimal = Nothing
    Public cChecados As Decimal = Nothing
    Public bChk As Boolean = False
    Private Sub frmProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        centralizarGrupoBotoes(gbBotoes)
        centralizarGrupoTab(tabCtrlProduto)

        Cor(Me, Collor.Control)

        Cor(CType(gbBotoes, Control), Collor.CinzaMedio)

        CorButton(btnPesquisar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnCadastrar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnEditar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnExcluir, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnFechar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnFiltrar, Collor.CinzaAzulado, Color.White, Color.SteelBlue, Color.Gray)
        CorButton(btnLimpaFiltro, Collor.CinzaAzulado, Color.White, Color.SteelBlue, Color.Gray)

    End Sub
    Private Sub frmProdutos_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        alterarCaptionFormPrincipal(eTela.Produtos)
    End Sub

    Private Sub frmProdutos_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Try
            CarregarCombo()
            Pesquisar()
            ControleBotoes()
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub
    Private Sub frmProdutos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        restaurarMDI()
    End Sub
    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        Try
            novoProd = New frmNovoProduto(0)
            novoProd.ShowDialog()

            If novoProd.bAlterado Then
                CarregarCombo()
                Pesquisar()
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Pesquisar()
    End Sub

    Private Sub Pesquisar()
        Dim cTamanho As Decimal = Nothing
        Dim rCor As String = Nothing
        Try
            oDataSet = New SuperDataSet

            If cbTamanho.ObterChaveCombo = "0" Then
                cTamanho = Nothing
            Else
                cTamanho = CDec(cbTamanho.ObterDescricaoCombo)
            End If

            If cbCor.ObterChaveCombo = "" Then
                rCor = Nothing
            Else
                rCor = cbCor.ObterDescricaoCombo
            End If

            If txtFiltroProduto.Text = "" Then
                txtFiltroProduto.Text = Nothing
            End If

            oDataSet = pProduto.Pesquisar(txtFiltroProduto.Text,
                                          cTamanho,
                                          rCor)

            dgProduto.PreencheDataGrid(oDataSet,,, txtLetreiro)

            If oDataSet.TotalRegistros = 0 Then
                S_MsgBox("Nenhum registro encontrado.",
                         eBotoes.Ok, "",,
                         eImagens.Info)
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            cChecados = dgProduto.ObterTodosChecados

            If cChecados > 0 Then

                cProduto = dgProduto.ObterChave
                novoProd = New frmNovoProduto(cProduto)
                novoProd.ShowDialog()

                If novoProd.bAlterado Then
                    CarregarCombo()
                    Pesquisar()
                End If

            End If
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim rProduto As String = Nothing
        Dim cOk As Integer = Nothing
        Dim cErro As Integer = Nothing
        Dim cImagem As Decimal = Nothing
        Try
            oDataSet = New SuperDataSet()

            cChecados = dgProduto.ObterTodosChecados

            If cChecados > 1 Then

                If Mensagem(eTipoMensagem.Question, CInt(cChecados)) = eRet.Sim Then

                    rProduto = dgProduto.ObterTodasChaves

                    If rProduto <> "" Then

                        For Each codigo In rProduto.Split(CChar(";"))

                            'Obtendo codigo da imagem, se tiver.
                            oDataSet = pProduto.Obter(CDec(codigo))

                            If oDataSet.TotalRegistros > 0 Then

                                If CDec(oDataSet("cImagem")) <> 0 Then
                                    cImagem = CDec(oDataSet("cImagem"))
                                End If
                            End If

                            If pProduto.Deletar(CDec(codigo)) Then

                                cOk += 1
                                pImagem.Deletar(cImagem)
                            Else
                                cErro += 1
                            End If
                        Next
                    End If
                End If

                If cErro = 0 And cOk <> 0 Then

                    Mensagem(eTipoMensagem.OK,, cOk)
                    CarregarCombo()
                    Pesquisar()

                ElseIf cErro <> 0 Then

                    Mensagem(eTipoMensagem.Erro, CInt(cChecados), cOk, cErro)

                End If
            Else
                If cChecados = 1 Then
                    cProduto = dgProduto.ObterChave
                End If

                If cProduto <> 0 Then

                    If Mensagem(eTipoMensagem.Question) = eRet.Sim Then

                        'Obtendo cod da imagem, se possuir.
                        oDataSet = pProduto.Obter(cProduto)

                        If oDataSet.TotalRegistros > 0 Then
                            If CDec(oDataSet("cImagem")) <> 0 Then
                                cImagem = CDec(oDataSet("cImagem"))
                            End If
                        End If

                        If pProduto.Deletar(cProduto) Then
                            cOk += 1
                            pImagem.Deletar(cImagem)
                        Else
                            cErro += 1
                        End If
                    End If
                End If

                If cErro = 0 And cOk <> 0 Then

                    Mensagem(eTipoMensagem.OK)
                    CarregarCombo()
                    Pesquisar()

                ElseIf cErro <> 0 Then
                    Mensagem(eTipoMensagem.Erro)
                End If
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub


    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        btnPesquisar.PerformClick()
    End Sub

    Private Sub btnLimpaFiltro_Click(sender As Object, e As EventArgs) Handles btnLimpaFiltro.Click
        Try

            txtFiltroProduto.Text = ""
            cbTamanho.SelectedIndex = 0
            cbCor.SelectedIndex = 0


        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub CarregarCombo()
        Dim col As Collection = Nothing
        Try
            oDataSet = New SuperDataSet()
            col = New Collection

            oDataSet = pProduto.ObterCombo

            If oDataSet.TotalRegistros > 0 Then
                cbCor.PreencheComboDS(oDataSet, "rCor", "rCor", PrimeiroValor.Todos)
            End If

            For i = 33 To 41
                col.Add(New DuplaCombo(i, i.ToString))
            Next

            cbTamanho.PreencheComboColl(col, PrimeiroValor.Todos)

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        Finally
            If oDataSet IsNot Nothing Then
                oDataSet.Dispose()
            End If
            col.Clear()
        End Try
    End Sub

    Private Sub txtFiltroProduto_KeyUp(sender As Object, e As KeyEventArgs) Handles txtFiltroProduto.KeyUp
        Pesquisar()
    End Sub

    Private Sub chkTodos_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodos.CheckedChanged
        Try

            dgProduto.MarcaDesmarcaTodos(chkTodos)

            ControleBotoes()

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub ControleBotoes()
        Try

            btnEditar.Enabled = False
            btnExcluir.Enabled = False

            cChecados = dgProduto.ObterTodosChecados

            If cChecados = 1 Then

                btnEditar.Enabled = True
                btnExcluir.Enabled = True

            ElseIf cChecados > 1 Then
                btnEditar.Enabled = False
                btnExcluir.Enabled = True
            End If


        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub dgProduto_SelectionChanged(sender As Object, e As EventArgs) Handles dgProduto.SelectionChanged
        Try

            If dgProduto.bCarregado And chkTodos.Checked = False Then
                ControleBotoes()
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Dim oXls As SuperXLS = Nothing
        Try
            If oDataSet IsNot Nothing Then

                oXls = New SuperXLS("Lista de Produtos")

                oXls.Imprimir(oDataSet, "", True, True, True, False)

            Else
                S_MsgBox("Desculpe, dados não encontrado para exportar. ",
                          eBotoes.Ok,
                          "Exportação sem êxito.",,
                          eImagens.Info)
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        Finally
            If oDataSet IsNot Nothing Then
                oDataSet.Dispose()
            End If
        End Try
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

    Private Sub cbCor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCor.SelectedIndexChanged
        Try
            If cbCor.Items.Count > 0 Then
                Pesquisar()
            End If
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub
End Class