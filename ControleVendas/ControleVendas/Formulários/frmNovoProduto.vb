Public Class frmNovoProduto

    Private controller As ProdutoController
    Private Sub frmNovoProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CorButton(btnSalvar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnFechar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        Cor(Me, Collor.CinzaEscuro)
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Dim prod As Produto

        Try
            prod = New Produto()

            controller = New ProdutoController()

            '  controller.Delete(1)

            prod.rNome = txtProduto.Text
            prod.cQuantidade = Convert.ToDecimal(txtQtde.Text)
            prod.cEstoqueMin = Convert.ToDecimal(txtEstoqueMin.Text)
            prod.cValor = Convert.ToDecimal(txtValor.Text)
            prod.cCusto = Convert.ToDecimal(txtCusto.Text)
            prod.rCor = txtCor.Text

            'controller.Alterar(2, prod)

            If controller.Incluir(prod) Then
                MessageBox.Show("Sucesso")
            Else
                MessageBox.Show("Erro")
            End If


        Catch ex As Exception

        End Try


    End Sub
End Class