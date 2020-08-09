Imports GFT.Util
Imports GFT.Util.clsMsgBox
Public Class frmProdutos

    Private produtoController As ProdutoController
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

        produtoController = New ProdutoController()
        dgProduto.DataSource = produtoController.Pesquisar("", "")


    End Sub


    Private Sub frmProdutos_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        alterarCaptionFormPrincipal(eTela.Produtos)
    End Sub

    Private Sub frmProdutos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        restaurarMDI()
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        Dim novo As frmNovoProduto
        novo = New frmNovoProduto
        novo.ShowDialog()
    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click

    End Sub

    Private Sub txtFiltroProduto_TextChanged(sender As Object, e As EventArgs) Handles txtFiltroProduto.TextChanged
        produtoController = New ProdutoController()
        dgProduto.DataSource = produtoController.Pesquisar(txtFiltroProduto.Text, txtFiltroCor.Text)
    End Sub
End Class