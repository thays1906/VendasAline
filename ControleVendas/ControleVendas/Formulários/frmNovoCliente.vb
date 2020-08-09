Imports GFT.Util
Imports GFT.Util.clsMsgBox

Public Class frmNovoCliente
    Public oDataSet As SuperDataSet = Nothing
    Public cCliente As Decimal = Nothing
    Public cErro As Decimal = Nothing
    Public cOk As Decimal = Nothing

    Sub New(ByVal _cCliente As Decimal)

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        cCliente = _cCliente
        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub
    Private Sub frmNovoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cor(Me, Collor.CinzaEscuro)

        CorButton(btnSalvar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnFechar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)

        CarregarCombo()
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub CarregarCombo()
        Try
            oDataSet = New SuperDataSet()

            oDataSet = pCidade_Estado.ObterEstado()

            cbEstado.PreencheComboDS(oDataSet, "rEstado", "cEstado", SuperComboBox.PrimeiroValor.Selecione)


        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        Finally
            If oDataSet IsNot Nothing Then
                oDataSet.Dispose()
            End If
        End Try
    End Sub

    Private Sub cbEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEstado.SelectedIndexChanged
        Try
            oDataSet = New SuperDataSet()

            oDataSet = pCidade_Estado.ObterCidade(CDec(cbEstado.ObterChaveCombo))

            If oDataSet IsNot Nothing Then
                cbCidade.PreencheComboDS(oDataSet, "rCidade", "cCidade", SuperComboBox.PrimeiroValor.Selecione)
            Else
                cbCidade.Items.Clear()
                cbCidade.Adiciona(0, "::. Selecione um Estado .::")
                cbCidade.PosicionaRegistroCombo(0)
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        Finally
            If oDataSet IsNot Nothing Then
                oDataSet.Dispose()
            End If
        End Try
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Salvar()
    End Sub

    Private Sub Salvar()
        Dim tel As String = Nothing
        Try
            If txtCliente.Text <> "" Then
                If cCliente = 0 Then
                    tel = txtTelefone.Text.Replace("(", "")
                    tel = tel.Replace(")", "")
                    tel = tel.Replace("-", "")


                    If pCliente.Incluir(dtCadastro.Value,
                                     txtCliente.Text,
                                     txtCpf.Text,
                                     tel,
                                     txtEmail.Text,
                                     txtRua.Text,
                                     txtNumero.Text, txtBairro.Text,
                                     CDec(cbCidade.ObterChaveCombo),
                                     CDec(cbEstado.ObterChaveCombo)) Then

                        cOk += 1
                    Else
                        cErro += 1
                    End If
                Else
                    If pCliente.Alterar(cCliente,
                                        dtCadastro.Value,
                                        txtCliente.Text,
                                        txtCpf.Text,
                                        txtTelefone.Text,
                                        txtEmail.Text,
                                        txtRua.Text,
                                        txtNumero.Text, txtBairro.Text,
                                        CDec(cbCidade.ObterChaveCombo),
                                        CDec(cbEstado.ObterChaveCombo)) Then
                        cOk += 1
                    Else
                        cErro += 1
                    End If

                End If

                If cErro = 0 Then

                    S_MsgBox("Cliente cadastrado com sucesso!",
                         eBotoes.Ok,
                         "Picarruchas",,
                         eImagens.FileOK)
                Else

                    S_MsgBox("Desculpe, não foi possível realizar o cadastro.",
                         eBotoes.Ok,
                         "Falha",,
                         eImagens.Cancel)

                End If

            Else
                S_MsgBox("Por favor, informe o nome do cliente.",
                         eBotoes.Ok,
                         "Necessário o nome.",,
                         eImagens.Atencao)
            End If



        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub
End Class