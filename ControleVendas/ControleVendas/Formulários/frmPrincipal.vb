Imports GFT.Util
Imports GFT.Util.clsMsgBox
Public Class frmPrincipal
    Public oForm As Form

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCaptionHora.Text = ""
        InicializaTelas()
        CorButton(btnEstoqueMin, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnTotalVendaPrincipal, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnNovoProdutoPrincipal, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnNovoClientePrincipal, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnConsultaVendaPrincipal, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnEntradaPrincipal, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnSaidaPrincipal, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)



        Cor(CType(gbAcessoRapido, Control), Collor.CinzaAzulado)
    End Sub
    Private Sub ProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutosToolStripMenuItem.Click
        Try
            gbPrincipal.Visible = False
            oform = New frmProdutos
            controleFormulario(Me, oform, eTela.Produtos)
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Falha::.",, eImagens.Cancel)
        End Try
    End Sub
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Try
            txtCaptionHora.Text = Now.ToString
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Falha::.",, eImagens.Cancel)
        End Try
    End Sub
    Private Sub txtCaption_TextChanged(sender As Object, e As EventArgs) Handles txtCaption.TextChanged
        If txtCaption.Text <> "Dashboard" Then
            gbPrincipal.Visible = False
        Else
            gbPrincipal.Visible = True
        End If

    End Sub
    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        gbPrincipal.Visible = False
        oform = New frmClientes
        controleFormulario(Me, oform, eTela.Clientes)
    End Sub
    Private Sub EstoqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstoqueToolStripMenuItem.Click
        oform = New frmEstoque
        controleFormulario(Me, oform, eTela.Estoque)
    End Sub
    Private Sub VendasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendasToolStripMenuItem.Click
        oform = New frmVendas
        controleFormulario(Me, oform, eTela.Vendas)
    End Sub
    Private Sub SobreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobreToolStripMenuItem.Click
        oform = New frmAbout
        oform.ShowDialog()
    End Sub
    Private Sub PesquisarEstoqueMin()
        Dim oDataSet As SuperDataSet = Nothing
        Dim style As DataGridViewCellStyle
        Try
            style = New DataGridViewCellStyle
            style.Alignment = DataGridViewContentAlignment.MiddleCenter

            oDataSet = pEstoque.PesquisarEstoqueMin

            If oDataSet IsNot Nothing Then

                dgEstoqueBaixo.PreencheDataGrid(oDataSet)
                txtTotal.Text = oDataSet.TotalRegistros.ToString

                For i = 1 To dgEstoqueBaixo.Columns.Count - 1

                    dgEstoqueBaixo.Columns(i).HeaderCell.Style = style
                    dgEstoqueBaixo.Columns(i).DefaultCellStyle = style

                Next

                For i = 0 To dgEstoqueBaixo.Rows.Count - 1

                    dgEstoqueBaixo.Rows(i).Cells("Estoque Atual").Style.ForeColor = Color.Red

                Next
            End If
            pnlEstoqueMin.Refresh()
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Falha::.",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub frmPrincipal_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        PesquisarEstoqueMin()
        PesquisarTotalVenda()
    End Sub

    Private Sub btnEstoqueMin_Click(sender As Object, e As EventArgs) Handles btnEstoqueMin.Click
        oform = New frmEstoque()
        controleFormulario(Me, oform, eTela.Estoque)
    End Sub
    Private Sub PesquisarTotalVenda()
        Dim oDataSet As SuperDataSet = Nothing
        Try
            oDataSet = New SuperDataSet()

            oDataSet = pVenda.ObterTotal()

            If oDataSet IsNot Nothing Then
                lblTotalVendas.Text = oDataSet("TOTAL").ToString
            End If


        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Falha::.",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnTotalVendaPrincipal_Click(sender As Object, e As EventArgs) Handles btnTotalVendaPrincipal.Click
        PesquisarTotalVenda()
    End Sub

    Private Sub btnEntradaPrincipal_Click(sender As Object, e As EventArgs) Handles btnEntradaPrincipal.Click
        Dim bAlterado As Integer = Nothing
        Try
            oForm = New frmEntrada(0, eTipoMovimentacao.Entrada, True)

            bAlterado = oForm.ShowDialog()

            If bAlterado = 1 Then
                PesquisarEstoqueMin()
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Falha::.",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnConsultaVendaPrincipal_Click(sender As Object, e As EventArgs) Handles btnConsultaVendaPrincipal.Click
        Try
            oForm = New frmVendas(True)
            controleFormulario(Me, oForm, eTela.Vendas)

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Falha::.",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnNovoProdutoPrincipal_Click(sender As Object, e As EventArgs) Handles btnNovoProdutoPrincipal.Click
        Try
            oForm = New frmNovoProduto(0)
            oForm.ShowDialog()

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Falha::.",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnNovoClientePrincipal_Click(sender As Object, e As EventArgs) Handles btnNovoClientePrincipal.Click
        Try
            oForm = New frmNovoCliente(0)
            oForm.ShowDialog()


        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Falha::.",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnSaidaPrincipal_Click(sender As Object, e As EventArgs) Handles btnSaidaPrincipal.Click
        Dim bAlterado As Integer = Nothing
        Try
            oForm = New frmEntrada(0, eTipoMovimentacao.Saida, True)

            bAlterado = oForm.ShowDialog()

            If bAlterado = 1 Then
                PesquisarEstoqueMin()
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Falha::.",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub MenuStrip1_SizeChanged(sender As Object, e As EventArgs) Handles MenuStrip1.SizeChanged
        MenuStrip1.CanOverflow = True
    End Sub
End Class
