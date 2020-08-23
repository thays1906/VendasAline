Imports GFT.Util
Imports GFT.Util.clsMsgBox

Public Class frmNovoCliente
    Public oDataSet As SuperDataSet = Nothing
    Public cCliente As Decimal = Nothing
    Public cErro As Decimal = Nothing
    Public cOk As Decimal = Nothing
    Public bAlterado As Boolean = False
    Public rTelefone As String = Nothing
    Public cEstado As Decimal = Nothing
    Public cCidade As Decimal = Nothing
    Public rCpf As String = Nothing

    Sub New(ByVal _cCliente As Decimal)

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        cCliente = _cCliente
        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub
    Private Sub frmNovoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cor(Me, Collor.CinzaAzulado)

        CorButton(btnSalvar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnFechar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)

        CarregarCombo()

        If cCliente > 0 Then
            PreencheCampo()
        End If
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
        Dim rsCidade As SuperDataSet = Nothing
        Try
            rsCidade = New SuperDataSet()

            rsCidade = pCidade_Estado.ObterCidade(CDec(cbEstado.ObterChaveCombo))

            If rsCidade IsNot Nothing Then
                cbCidade.PreencheComboDS(rsCidade, "rCidade", "cCidade", SuperComboBox.PrimeiroValor.Selecione)
            Else
                cbCidade.Items.Clear()
                cbCidade.Adiciona(0, "::. Selecione um Estado .::")
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        Finally
            If rsCidade IsNot Nothing Then
                rsCidade.Dispose()
            End If
        End Try
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Salvar()
    End Sub

    Private Sub Salvar()
        Try
            If VerificarDados() Then

                If cCliente = 0 Then


                    If pCliente.Incluir(dtCadastro.Value,
                                         txtCliente.Text,
                                         rCpf,
                                         rTelefone,
                                         txtEmail.Text,
                                         txtRua.Text,
                                         txtNumero.Text,
                                         txtBairro.Text,
                                         cCidade,
                                         cEstado) Then

                        cOk += 1
                        bAlterado = True
                    Else
                        cErro += 1
                    End If
                Else

                    If pCliente.Alterar(cCliente,
                                        dtCadastro.Value,
                                        txtCliente.Text,
                                        rCpf,
                                        rTelefone,
                                        txtEmail.Text,
                                        txtRua.Text,
                                        txtNumero.Text, txtBairro.Text,
                                        cCidade,
                                        cEstado) Then
                        cOk += 1
                        bAlterado = True
                    Else
                        cErro += 1
                    End If

                End If

                If cErro = 0 And cOk <> 0 Then

                    If cCliente = 0 Then

                        S_MsgBox("Cliente cadastrado com sucesso!",
                                 eBotoes.Ok,
                                 "Picarruchas",,
                                 eImagens.FileOK)
                    Else
                        S_MsgBox("Dados alterado com sucesso!",
                                 eBotoes.Ok,
                                 "Picarruchas",,
                                 eImagens.FileOK)

                    End If

                Else

                    S_MsgBox("Desculpe, não foi possível realizar o cadastro.",
                             eBotoes.Ok,
                             "Falha",,
                             eImagens.Cancel)
                End If

                Me.bAlterado.ToString()
                Me.Close()
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub PreencheCampo()
        Try
            oDataSet = pCliente.Obter(cCliente)

            dtCadastro.Enabled = False

            If oDataSet.TotalRegistros > 0 Then

                tabCtrlNovoCli.TabPages(0).Text = "Dados do Cliente"
                btnSalvar.Text = "Salvar alterações"

                dtCadastro.Value = CDate(oDataSet("dtCadastro"))
                txtCliente.Text = oDataSet("rNome").ToString
                txtCpf.Text = oDataSet("rCpf").ToString
                txtTelefone.Text = oDataSet("rTelefone").ToString
                txtEmail.Text = oDataSet("rEmail").ToString
                txtRua.Text = oDataSet("rLogradouro").ToString
                txtNumero.Text = oDataSet("rNumero").ToString
                txtBairro.Text = oDataSet("rBairro").ToString
                cbEstado.PosicionaRegistroCombo(CDec(oDataSet("cEstado")))
                cbCidade.PosicionaRegistroCombo(CDec(oDataSet("cCidade")))
            Else
                S_MsgBox("Desculpe, não foi possível localizar registro.",
                         eBotoes.Ok,
                         "Houve um erro.",,
                         eImagens.Cancel)

                Me.Close()
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub
    Private Function VerificarDados() As Boolean
        Try
            If String.IsNullOrEmpty(txtCliente.Text) Then

                lblClienteObg.Text = "É necessário informar o nome do cliente, para realizar o cadastro."
                lblClienteObg.Visible = True

                Return False
            End If

            If cbEstado.SelectedIndex <> 0 Then
                cEstado = CDec(cbEstado.ObterChaveCombo)
            End If

            If cbCidade.SelectedIndex <> 0 Then
                cCidade = CDec(cbCidade.ObterChaveCombo)
            End If

            If txtCpf.MaskCompleted Then

                rCpf = txtCpf.Text

            Else

                txtCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals

                If txtCpf.Text <> "" Then

                    S_MsgBox("Campo CPF, não está preenchido corretamente.",
                             eBotoes.Ok,
                             "Picarruchas",,
                             eImagens.Atencao)
                    Return False
                End If
            End If

            If txtTelefone.MaskCompleted Then

                rTelefone = txtTelefone.Text

            Else

                txtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals

                If txtTelefone.Text <> "" Then
                    S_MsgBox("Campo Telefone, não está preenchido corretamente.",
                             eBotoes.Ok,
                             "Picarruchas",,
                             eImagens.Atencao)
                    Return False

                End If
            End If

            Return True

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
            Return False
        End Try
    End Function

    Private Sub txtCliente_Enter(sender As Object, e As EventArgs) Handles txtCliente.Enter
        lblClienteObg.Visible = False
    End Sub
End Class