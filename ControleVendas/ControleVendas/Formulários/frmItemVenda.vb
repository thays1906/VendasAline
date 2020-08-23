Imports GFT.Util.clsMsgBox
Imports GFT.Util

Public Class frmItemVenda
    Public rItensVenda(3) As String
    Public bQtdeAlterado As Boolean = False
    Sub New(ByVal _rItensVenda() As String)

        InitializeComponent()

        For i = 0 To _rItensVenda.Length - 2
            rItensVenda(i) = _rItensVenda(i)
        Next
    End Sub
    Private Sub frmItemVenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Cor(Me, Collor.CinzaAzulado)

        CorButton(btnSalvar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnFechar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)

        PreencheCampo(rItensVenda)

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Salvar()
    End Sub

    Public Sub Salvar()
        Try

            If Not IsNumeric(txtValorUn.Text) Then
                If S_MsgBox("O campo 'Valor Unitário' está vazio, deseja prosseguir? ",
                            eBotoes.SimNao, "Picarruchas",, eImagens.Interrogacao) = eRet.Nao Then
                    Exit Sub
                End If
            End If

            If nudQuantidade.Value = 0 Then

                lblQtdeObg.Text = "O campo 'Quantidade', deve ser maior que 0."
                lblQtdeObg.Visible = True
                Exit Sub
            End If

            DialogResult = DialogResult.Yes

            rItensVenda(0) = txtProduto.Text
            rItensVenda(1) = nudQuantidade.Value.ToString
            rItensVenda(2) = txtValorUn.Text
            rItensVenda(3) = txtValorTotal.Text

            Me.rItensVenda.ToString()
            Me.DialogResult.ToString()
            Me.Close()


        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
            LogaErro(ex.Message)
        End Try
    End Sub
    Private Sub PreencheCampo(ByVal rItens() As String)
        Try

            txtProduto.Text = rItens(0)
            nudQuantidade.Value = CDec(rItens(1))
            txtValorUn.Text = rItens(2).ToString
            txtValorTotal.Text = rItens(3).ToString
            nudQuantidade.Focus()

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
            LogaErro(ex.Message)

        End Try
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Try
            If txtValorUn.Alterado Or
               txtValorTotal.Alterado Or
                        bQtdeAlterado Then

                If S_MsgBox("Deseja sair e descartar as alterações?",
                         eBotoes.SimNao,
                         "Picarruchas",,
                         eImagens.Interrogacao) = eRet.Nao Then

                    Exit Sub
                Else
                    DialogResult = DialogResult.No
                End If
            End If

            LimparCampos()
            Me.Close()


        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
            LogaErro(ex.Message)
        End Try
    End Sub

    Private Sub nudQuantidade_ValueChanged(sender As Object, e As EventArgs) Handles nudQuantidade.ValueChanged
        Static Dim count As Integer = Nothing
        Try
            count += 1

            If count > 1 Then
                bQtdeAlterado = True

                If IsNumeric(txtValorUn.Text) Then
                    txtValorTotal.Text = ""
                    txtValorTotal.Text = Convert.ToDouble(nudQuantidade.Value * CDec(txtValorUn.Text)).ToString("C2")
                End If
            End If


        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
            LogaErro(ex.Message)
        End Try
    End Sub
    Private Sub LimparCampos()
        Try

            txtProduto.Text = ""
            nudQuantidade.Value = 0
            txtValorUn.Text = ""
            txtValorTotal.Text = ""
            Array.Clear(rItensVenda, 0, 4)

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
            LogaErro(ex.Message)
        End Try
    End Sub



    Private Sub txtValorUn_Leave(sender As Object, e As EventArgs) Handles txtValorUn.Leave
        Try

            If IsNumeric(txtValorUn.Text) Then
                txtValorUn.Text = txtValorUn.Text.Replace("R$", "")
                txtValorUn.Text = Convert.ToDouble(txtValorUn.Text).ToString("C2")
            End If
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
            LogaErro(ex.Message)
        End Try
    End Sub

    Private Sub btnCalculadora_Click(sender As Object, e As EventArgs) Handles btnCalculadora.Click
        Try
            Process.Start("calc.exe")
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
            LogaErro(ex.Message)
        End Try
    End Sub

    Private Sub txtValorUn_MouseDown(sender As Object, e As MouseEventArgs) Handles txtValorUn.MouseDown
        txtValorUn.Text = ""
    End Sub

    Private Sub txtValorUn_KeyUp(sender As Object, e As KeyEventArgs) Handles txtValorUn.KeyUp
        Try

            If IsNumeric(txtValorUn.Text) Then

                txtValorUn.Text = txtValorUn.Text.Replace("R$", "")
                txtValorTotal.Text = ""
                txtValorTotal.Text =
                    Convert.ToDouble(nudQuantidade.Value * CDec(txtValorUn.Text)).ToString("C2")

            End If


        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
            LogaErro(ex.Message)
        End Try
    End Sub

    Private Sub txtValorTotal_Leave(sender As Object, e As EventArgs) Handles txtValorTotal.Leave
        Try
            If txtValorTotal.Alterado Then
                txtValorTotal.Text = txtValorTotal.Text.Replace("R$", "")
                txtValorTotal.Text = Convert.ToDouble(txtValorTotal.Text).ToString("C2")
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
            LogaErro(ex.Message)
        End Try
    End Sub



    Private Sub nudQuantidade_Enter(sender As Object, e As EventArgs) Handles nudQuantidade.Enter
        lblQtdeObg.Visible = False
    End Sub
End Class