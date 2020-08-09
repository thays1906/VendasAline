Imports GFT.Util
Imports GFT.Util.clsMsgBox

Public Class frmClientes
    Public novoCliente As frmNovoCliente

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub frmClientes_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        restaurarMDI()
    End Sub

    Private Sub frmClientes_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        alterarCaptionFormPrincipal(eTela.Clientes)
    End Sub

    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Cor(Me, Collor.Control)
        Cor(CType(gbBotoes, Control), Collor.CinzaEscuro)

        CorTab(tabCTrlCliente, Collor.DimGray)

        CorButton(btnPesquisar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnCadastrar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnEditar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnExcluir, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnFechar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnExportar, Collor.Nenhuma, Color.Black, Color.Gainsboro, Color.DimGray)

    End Sub

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        novoCliente = New frmNovoCliente(0)
        novoCliente.ShowDialog()
    End Sub

    Private Sub CarregarCombo()
        Dim oDataSet As SuperDataSet = Nothing
        Try
            'oDataSet = pCidade_Estado.ObterEstado()



        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Pesquisar()
    End Sub
    Private Sub Pesquisar()
        Try

            pCliente.Pesquisar(Nothing, Nothing, Nothing)

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub
End Class