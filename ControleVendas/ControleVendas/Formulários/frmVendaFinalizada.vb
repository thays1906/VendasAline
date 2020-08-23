Imports GFT.Util.clsMsgBox
Imports GFT.Util
Public Class frmVendaFinalizada
    Public oForm As frmMsg
    Public rsItens As SuperDataSet = Nothing
    Public cVenda As Decimal = Nothing
    Public rsVenda As SuperDataSet = Nothing

    Sub New(ByVal _cVenda As Decimal)

        InitializeComponent()

        cVenda = _cVenda

    End Sub
    Private Sub frmVendaFinalizada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cor(CType(pnlCima, Control), Collor.Rosa)
        Cor(CType(pnlBaixo, Control), Collor.Rosa)
        CorButton(btnImprimir, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnFechar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
    End Sub


    Private Sub frmVendaFinalizada_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'oForm = New frmMsg
        'oForm.ShowDialog()
        CarregarDados()
    End Sub

    Private Sub CarregarDados()
        Dim rFormaPag As String = Nothing
        Try
            rsItens = New SuperDataSet()
            rsVenda = New SuperDataSet()

            If cVenda <> 0 Then

                rsVenda = pVenda.Obter(cVenda)
                rsItens = pItensVenda.Pesquisar(cVenda)

                txtImpressao.Text = "Data da Venda:" & vbTab &
                                    "Total de Itens" &
                                    vbNewLine &
                                    rsVenda("dtVenda").ToString & vbTab &
                                    rsVenda("TOT ITENS").ToString &
                                    vbNewLine & vbNewLine &
                                    "Cliente:" & vbTab &
                                    rsVenda("CLIENTE").ToString & vbTab &
                                    "CPF: " &
                                    rsVenda("CPF").ToString & vbNewLine

                txtImpressao.AppendText("-----------------------------------" &
                                        "-----------------------------------" & vbNewLine)

                txtImpressao.AppendText("Qtde." &
                                        vbTab &
                                        "Vl. Item Total" &
                                        vbTab &
                                        "Produto" & vbNewLine)

                txtImpressao.AppendText("-----------------------------------" &
                                        "-----------------------------------" & vbNewLine)

                If rsItens.TotalRegistros > 0 Then
                    For i = 0 To rsItens.TotalRegistros - 1


                        txtImpressao.AppendText(rsItens("Quantidade", i).ToString &
                                                vbTab &
                                                rsItens("Valor", i).ToString &
                                                 vbTab & vbTab &
                                                rsItens("Produto", i).ToString())

                        txtImpressao.AppendText(vbNewLine)
                    Next
                    txtImpressao.AppendText("-----------------------------------" &
                                            "-----------------------------------" &
                                            vbNewLine & vbNewLine)

                    If CType(rsVenda("Forma"), eFormaPagamento) = eFormaPagamento.Dinheiro Then

                        rFormaPag = "Dinheiro"

                    ElseIf CType(rsVenda("Forma"), eFormaPagamento) = eFormaPagamento.Debito Then
                        rFormaPag = "Débito"

                    ElseIf CType(rsVenda("Forma"), eFormaPagamento) = eFormaPagamento.Credito Then
                        rFormaPag = "Crédito"
                    Else
                        rFormaPag = ""
                    End If

                    txtImpressao.AppendText("Valor Total: " &
                                            rsVenda("TOTAL").ToString &
                                            vbTab &
                                            "Forma de Pagamento: " & rFormaPag)

                End If

                End If
            btnImprimir.Focus()


        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
            LogaErro(ex.Message)
        End Try
    End Sub



    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim txt As System.IO.File
        Dim read As IO.StreamWriter
        Dim dtVenda As DateTime = Nothing

        Try
            dtVenda = CDate(rsVenda("dtVenda"))

            read = My.Computer.FileSystem.OpenTextFileWriter("c:\temp\Picarruchas.txt", True)

            read.WriteLine(txtImpressao.ToString)
            read.Close()


        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
            LogaErro(ex.Message)
        End Try
    End Sub
End Class