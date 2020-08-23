Imports GFT.Util
Imports GFT.Util.clsMsgBox
Public Class frmListaProdutos
    Public oDataSet As SuperDataSet = Nothing
    Public listItens As List(Of ItemProduto) = Nothing
    Public bEnter As Boolean = False
    Private Sub frmListaProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarProduto()



        CorButton(btnAdicionar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnFechar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)

        Cor(CType(pnlCima, Control), Collor.Rosa)
        Cor(CType(pnlBaixo, Control), Collor.Rosa)
    End Sub
    Private Sub CarregarProduto()
        Try
            oDataSet = pEstoque.Lista(Nothing)
            If oDataSet IsNot Nothing Then

                oDataSet.Tables(0).Columns.Add("Quantidade")

                dgTodosProd.PreencheDataGrid(oDataSet,,, txtLetreiroListaProd)

                dgTodosProd.Columns("Quantidade").DisplayIndex = 1
                dgTodosProd.Columns("Quantidade").Width = 150
                dgTodosProd.Columns("Produto").Width = 450

            End If


        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        Finally
            oDataSet.Dispose()
        End Try
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        listItens = New List(Of ItemProduto)
        Me.listItens.ToString()
        Me.Close()
    End Sub

    Private Sub txtProdutoFiltro_KeyUp(sender As Object, e As KeyEventArgs) Handles txtProdutoFiltro.KeyUp
        Try
            oDataSet = New SuperDataSet()

            oDataSet = pEstoque.Lista(txtProdutoFiltro.Text)

            If oDataSet.TotalRegistros > 0 Then
                dgTodosProd.PreencheDataGrid(oDataSet,,, txtLetreiroListaProd)
            End If


        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        Dim cQtde As Decimal = Nothing
        Dim rProduto As String = Nothing
        Try
            listItens = New List(Of ItemProduto)

            For i = 0 To dgTodosProd.Rows.Count - 1
                cQtde = dgTodosProd.ObterTodosChecados

                If dgTodosProd.Rows(i).Selected Or
                    CBool(dgTodosProd.Rows(i).Cells("chkDataGrid").Value) = True Then


                    cQtde = CDec(dgTodosProd.Rows(i).Cells("Quantidade").Value)

                    If cQtde > CDec(dgTodosProd.Rows(i).Cells("Estoque atual").Value) Then

                        rProduto = dgTodosProd.Rows(i).Cells("Produto").Value.ToString

                        S_MsgBox("Estoque insuficiente." & vbNewLine &
                                  "Produto: " & rProduto,
                                  eBotoes.Ok,
                                  "Quantidade adicionada, é maior que o estoque disponível.",,
                                  eImagens.Atencao)
                        Exit Sub

                    End If

                    listItens.Add(New ItemProduto(
                                      CDec(dgTodosProd.Rows(i).Cells("id_cProduto").Value),
                                      cQtde,
                                      CDec(dgTodosProd.Rows(i).Cells("Valor Unitário").Value)))

                End If
            Next

            Me.listItens.ToString()
            Me.Close()

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
            LogaErro(ex.Message)
        End Try
    End Sub



    Private Sub dgTodosProd_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgTodosProd.CellLeave
        Try
            If dgTodosProd.bCarregado Then

                dgTodosProd.bUserEdit = True
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
            LogaErro(ex.Message)
        End Try
    End Sub



    Private Sub frmListaProdutos_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Try
            dgTodosProd.ClearSelection()
            dgTodosProd.Rows(0).Cells("chkDataGrid").Value = False
            dgTodosProd.EndEdit()

        Catch ex As Exception
        End Try
    End Sub



    Private Sub dgTodosProd_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgTodosProd.CellEnter
        Try
            If bEnter Then
                dgTodosProd.Rows(e.RowIndex).Selected = True
                dgTodosProd.Rows(e.RowIndex).Cells("chkDataGrid").Value = True

            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
            LogaErro(ex.Message)
        End Try
    End Sub

    Private Sub dgTodosProd_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgTodosProd.CellBeginEdit
        Try
            If dgTodosProd.bCarregado And MouseButtons <> MouseButtons.Left Then
                dgTodosProd.Rows(e.RowIndex).Selected = True
                dgTodosProd.Rows(e.RowIndex).Cells("chkDataGrid").Value = True
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
            LogaErro(ex.Message)
        End Try

    End Sub

    Private Sub chkTodos_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodos.CheckedChanged
        Try

            dgTodosProd.MarcaDesmarcaTodos(chkTodos)

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
            LogaErro(ex.Message)
        End Try
    End Sub
End Class