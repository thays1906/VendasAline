Imports GFT.Util
Imports GFT.Util.clsMsgBox

Public Class frmClientes
    Public novoCliente As frmNovoCliente
    Public oDataSet As SuperDataSet = Nothing
    Public cChecados As Decimal = Nothing

    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Cor(Me, Collor.Control)
        Cor(CType(gbBotoes, Control), Collor.CinzaMedio)
        Cor(CType(gbFiltroProduto, Control), Collor.Claro)

        CorButton(btnPesquisar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnCadastrar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnEditar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnExcluir, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnFechar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)

        CarregarCombo()

    End Sub
    Private Sub frmClientes_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        restaurarMDI()
    End Sub

    Private Sub frmClientes_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        alterarCaptionFormPrincipal(eTela.Clientes)
    End Sub
    Private Sub frmClientes_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Pesquisar()
        ControleBotoes()
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        novoCliente = New frmNovoCliente(0)
        novoCliente.ShowDialog()

        If novoCliente.bAlterado Then
            Pesquisar()
        End If
    End Sub

    Private Sub CarregarCombo()
        Try
            oDataSet = New SuperDataSet()

            oDataSet = pCidade_Estado.ObterEstado()

            If oDataSet.TotalRegistros > 0 Then
                cbEstado.PreencheComboDS(oDataSet, "rEstado", "cEStado", SuperComboBox.PrimeiroValor.Todos)
            End If

            oDataSet = pCidade_Estado.ObterCidade(25)

            If oDataSet.TotalRegistros > 0 Then
                cbCidade.PreencheComboDS(oDataSet, "rCidade", "cCidade", SuperComboBox.PrimeiroValor.Todos)
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        Finally
            If oDataSet IsNot Nothing Then
                oDataSet.Dispose()
            End If
        End Try
    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Pesquisar()
    End Sub
    Private Sub Pesquisar()
        Dim cidade As Decimal = Nothing
        Dim estado As Decimal = Nothing

        Try
            oDataSet = New SuperDataSet()

            If cbEstado.ObterDescricaoCombo.Contains("Todos") Then
                estado = 0
            Else
                estado = CDec(cbEstado.ObterChaveCombo())
            End If
            If cbCidade.ObterDescricaoCombo.Contains("Todos") Then
                cidade = 0
            Else
                cidade = CDec(cbCidade.ObterChaveCombo)
            End If


            oDataSet = pCliente.Pesquisar(txtCliente.Text,
                                          estado,
                                          cidade,
                                          chkFiltrarPorData,
                                          dtInicio.Value,
                                          dtFim.Value)

            dgCliente.PreencheDataGrid(oDataSet,,, txtLetreiro)


            If oDataSet Is Nothing OrElse oDataSet.TotalRegistros = 0 Then
                S_MsgBox("Nenhum registro encontrado.",
                         eBotoes.Ok,
                         "Consulta sem resultados.",,
                         eImagens.Info)
            End If
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub chkMarcaTodos_CheckedChanged(sender As Object, e As EventArgs) Handles chkMarcaTodos.CheckedChanged
        Try
            dgCliente.MarcaDesmarcaTodos(chkMarcaTodos)

            ControleBotoes()

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub txtCliente_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCliente.KeyUp
        Pesquisar()
    End Sub

    Private Sub chkFiltrarPorData_CheckedChanged(sender As Object, e As EventArgs) Handles chkFiltrarPorData.CheckedChanged
        If chkFiltrarPorData.Checked Then
            dtInicio.Enabled = True
            dtFim.Enabled = True
        Else
            dtInicio.Enabled = False
            dtFim.Enabled = False
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim cCliente As Decimal = Nothing

        Try

            If dgCliente.ObterTodosChecados > 0 Then

                cCliente = dgCliente.ObterChave

                novoCliente = New frmNovoCliente(cCliente)
                novoCliente.ShowDialog()

                If novoCliente.bAlterado Then
                    Pesquisar()
                End If

            End If


        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim rCliente As String = Nothing
        Dim cOk As Integer = Nothing
        Dim cErro As Integer = Nothing
        Try

            cChecados = dgCliente.ObterTodosChecados

            If cChecados > 1 Then
                If Mensagem(eTipoMensagem.Question, CInt(cChecados)) = eRet.Sim Then

                    rCliente = dgCliente.ObterTodasChaves()

                    If rCliente <> "" Then
                        For Each codigo In rCliente.Split(CChar(";"))

                            If pCliente.Deletar(CDec(codigo)) Then

                                cOk += 1
                            Else
                                cErro += 1

                            End If
                        Next
                    End If
                End If

                If cErro = 0 And cOk <> 0 Then
                    Mensagem(eTipoMensagem.OK, CInt(cChecados))
                    Pesquisar()
                Else
                    Mensagem(eTipoMensagem.Erro, CInt(cChecados), cOk, cErro)
                    Pesquisar()
                End If

            Else
                If cChecados = 1 Then
                    rCliente = dgCliente.ObterChave.ToString
                    If Mensagem(eTipoMensagem.Question) = eRet.Sim Then

                        If pCliente.Deletar(CDec(rCliente)) Then
                            cOk += 1
                        Else
                            cErro += 1
                        End If
                    End If
                End If

                If cErro = 0 And cOk <> 0 Then
                    Mensagem(eTipoMensagem.OK)
                    Pesquisar()
                Else
                    Mensagem(eTipoMensagem.Erro)
                    Pesquisar()
                End If
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub
    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Dim oXls As SuperXLS = Nothing
        Try
            oXls = New SuperXLS("Lista de Clientes")

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
            If oDataSet IsNot Nothing Then
                oDataSet.Dispose()
            End If
        End Try
    End Sub

    Private Sub ControleBotoes()
        Try

            btnEditar.Enabled = False
            btnExcluir.Enabled = False

            cChecados = dgCliente.ObterTodosChecados

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

    Private Sub dgCliente_SelectionChanged(sender As Object, e As EventArgs) Handles dgCliente.SelectionChanged
        Try

            If dgCliente.bCarregado And chkMarcaTodos.Checked = False Or
                            dgCliente.ObterTodosChecados < 2 Then
                ControleBotoes()
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub
End Class