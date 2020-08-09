Imports GFT.Util
Imports GFT.Util.clsMsgBox
Public Class frmPrincipal
    Public oform As Form
    Private Sub ProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutosToolStripMenuItem.Click
        Try
            gbPrincipal.Visible = False
            oform = New frmProdutos
            controleFormulario(Me, oform, eTela.Produtos)
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Falha::.",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCaptionHora.Text = ""
        InicializaTelas()
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
End Class
