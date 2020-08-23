Imports GFT.Util
Imports GFT.Util.clsMsgBox
Imports GFT.Util.SuperComboBox
Imports System.IO
Public Class frmNovoProduto
    Public cProduto As Decimal = Nothing
    Public cValor As Decimal = Nothing
    Public cCusto As Decimal = Nothing
    Public cQtde As Decimal = Nothing
    Public cTamanho As Decimal = Nothing
    Public cEstoqueMin As Decimal = Nothing
    Public cImagem As Decimal = Nothing
    Public bAlterado As Boolean = False
    Public pathImg As String = Nothing
    Public img As Byte() = Nothing
    Public rCor As String = Nothing
    Sub New(ByVal _cProduto As Decimal)

        InitializeComponent()

        cProduto = _cProduto

    End Sub
    Private Sub frmNovoProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CorButton(btnSalvar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnFechar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        Cor(Me, Collor.CinzaAzulado)

        CarregarCombo()

        If cProduto > 0 Then
            PreencheCombo()
            tpHistorico.Enabled = True
        Else
            tpHistorico.Enabled = False
            btnSalvar.Text = "Salvar"
        End If
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Salvar()
    End Sub

    Private Sub CarregarCombo()
        Dim col As Collection = Nothing
        Try
            col = New Collection

            For i = 33 To 41
                col.Add(New DuplaCombo(i, i.ToString))
            Next

            cbTamanho.PreencheComboColl(col, PrimeiroValor.Selecione)

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        Finally
            col.Clear()
        End Try
    End Sub
    Private Sub Salvar()
        Dim cOk As Integer = Nothing
        Dim cErro As Integer = Nothing
        Dim oDataSet As SuperDataSet = Nothing
        Try

            If VerificarCampos() Then

                'Inserindo imagem, se adiconou.
                pathImg = OpenFileDialog1.FileName

                If pathImg <> "" Then

                    img = File.ReadAllBytes(pathImg)

                    If img IsNot Nothing Then

                        If cImagem = 0 Then

                            oDataSet = pImagem.Incluir(pathImg, img)

                            If oDataSet.TotalRegistros > 0 Then
                                cImagem = CDec(oDataSet("ID"))
                            End If

                        Else

                            pImagem.Alterar(cImagem, pathImg, img)
                        End If
                    End If
                End If

                If cProduto = 0 Then

                    oDataSet = pProduto.Incluir(dtEntrada.Value,
                                            txtProduto.Text,
                                            cValor,
                                            cTamanho,
                                            txtCor.Text,
                                            cQtde,
                                            cEstoqueMin,
                                            cCusto,
                                            cImagem)

                    If oDataSet.TotalRegistros > 0 Then

                        cOk += 1
                        bAlterado = True

                        cProduto = CDec(oDataSet("cProduto"))

                        pEstoque.Incluir(cProduto)
                        cProduto = 0
                    Else
                        cErro += 1
                    End If
                Else
                    If pProduto.Alterar(cProduto,
                                 dtEntrada.Value,
                                 txtProduto.Text,
                                 cValor,
                                 CDec(cbTamanho.ObterChaveCombo),
                                 rCor,
                                 cQtde,
                                 CDec(txtEstoqueMin.Text),
                                 cCusto,
                                 cImagem) Then

                        cOk += 1
                        bAlterado = True

                    Else
                        cErro += 1
                    End If
                End If

                If cErro = 0 And cOk <> 0 Then

                    If cProduto = 0 Then

                        S_MsgBox("Produto incluído com sucesso!",
                         eBotoes.Ok,
                         "Novo Produto",,
                         eImagens.FileOK)
                    Else
                        S_MsgBox("Dados do produto alterados com sucesso!",
                         eBotoes.Ok,
                         "Alteração de Dados",,
                         eImagens.FileOK)

                    End If

                ElseIf cErro <> 0 Then
                    If cProduto = 0 Then
                        S_MsgBox("Desculpe, não foi possível cadastrar produto.",
                         eBotoes.Ok,
                         "Falha ao incluir Produto",,
                         eImagens.Cancel)
                    Else
                        S_MsgBox("Desculpe, falha ao alterar dados do produto.",
                         eBotoes.Ok,
                         "Alteração de dados não efetivada.",,
                         eImagens.Cancel)


                    End If
                End If

                Me.bAlterado.ToString()
                Me.Close()
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
            If oDataSet IsNot Nothing Then
                oDataSet.Dispose()
            End If
        End Try
    End Sub
    Private Function VerificarCampos() As Boolean
        Try

            If txtProduto.Text = "" Then
                lblProdObg.Text = "É necessário informar um produto, para cadastrar."
                lblProdObg.Visible = True
                Return False
            End If

            If txtCor.Text <> "" Then
                rCor = txtCor.Text
            End If

            If txtEstoqueIdeal.Text <> "" Then
                cQtde = CDec(txtEstoqueIdeal.Text)
            End If

            If txtEstoqueMin.Text <> "" Then
                cEstoqueMin = CDec(txtEstoqueMin.Text)
            End If

            Return True
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
            Return False
        End Try
    End Function
    Private Sub PreencheCombo()
        Dim oDataSet As SuperDataSet = Nothing
        Dim mStream As New MemoryStream
        Dim _Img As Bitmap = Nothing
        Dim byteImg As Byte() = Nothing
        Try

            oDataSet = New SuperDataSet()

            oDataSet = pProduto.Obter(cProduto)

            btnSalvar.Text = "Salvar alterações"

            If oDataSet.TotalRegistros > 0 Then

                tabCtrlCadastroProd.TabPages(0).Text = "Dados do Produto"

                dtEntrada.Value = CDate(oDataSet("dtEntrada"))
                txtProduto.Text = oDataSet("rProduto").ToString
                cbTamanho.PosicionaRegistroCombo(CInt(oDataSet("cTamanho")))
                txtCor.Text = oDataSet("rCor").ToString
                txtEstoqueIdeal.Text = oDataSet("cEstoqueIdeal").ToString
                txtEstoqueMin.Text = oDataSet("cEstoqueMin").ToString

                cValor = CDec(oDataSet("cValor"))
                txtValor.Text = Convert.ToDouble(cValor).ToString("C2")

                txtCusto.Text = Convert.ToDouble(oDataSet("cCusto")).ToString("C2")

                If CDec(oDataSet("cImagem")) <> 0 Then

                    cImagem = CDec(oDataSet("cImagem"))

                    oDataSet = pImagem.Obter(cImagem)

                    If oDataSet.TotalRegistros > 0 Then
                        mStream = New MemoryStream()

                        byteImg = CType(oDataSet("bTamanho"), Byte())

                        mStream.Write(byteImg, 0, Convert.ToInt32(byteImg.Length))

                        _Img = New Bitmap(mStream, False)

                        picProduto.Image = _Img
                    End If
                End If
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        Finally
            oDataSet.Dispose()
        End Try
    End Sub

    Private Sub txtValor_Leave(sender As Object, e As EventArgs) Handles txtValor.Leave
        Try

            If txtValor.Text.Contains("R$") Then
                txtValor.Text = txtValor.Text.Replace("R$", "")
            End If

            If IsNumeric(txtValor.Text) Then
                cValor = CDec(txtValor.Text)
                txtValor.Text = Convert.ToDouble(txtValor.Text).ToString("C2")
            End If


        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub txtCusto_Leave(sender As Object, e As EventArgs) Handles txtCusto.Leave
        Try

            If txtCusto.Text.Contains("R$") Then
                txtCusto.Text = txtCusto.Text.Replace("R$", "")
            End If

            If IsNumeric(txtCusto.Text) Then
                cCusto = CDec(txtCusto.Text)
                txtCusto.Text = Convert.ToDouble(txtCusto.Text).ToString("C2")
            End If


        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try

    End Sub

    Private Sub btnAddImg_Click(sender As Object, e As EventArgs) Handles btnAddImg.Click
        Dim oDataSet As SuperDataSet = Nothing
        Try
            '"Imagens (*.jpeg |*.jpeg  *.jpg)|*.jpg  *.png)| *.png "
            'OpenFileDialog1.Filter = "Imagens (*.jpg) | *.jpg |Todas imagens (*.*) |*.* "

            OpenFileDialog1.ShowDialog()

            pathImg = OpenFileDialog1.FileName

            If pathImg <> "" Then

                picProduto.ImageLocation = pathImg
                picProduto.Load()
                PosicionaImage()
                btnRemove.Visible = True
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub txtCusto_MouseDown(sender As Object, e As MouseEventArgs) Handles txtCusto.MouseDown
        Try
            txtCusto.Text = ""
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub txtValor_MouseDown(sender As Object, e As MouseEventArgs) Handles txtValor.MouseDown
        Try
            txtValor.Text = ""
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub PosicionaImage()
        Try
            If picProduto.Image.Width >= 200 Then
                picProduto.Location = New Point(0, 0)
            ElseIf picProduto.Image.Width <= 150 Then
                picProduto.Location = New Point(100, 100)
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub
    Private Sub btnCalculadora_Click(sender As Object, e As EventArgs) Handles btnCalculadora.Click
        Try
            Process.Start("Calc.exe")
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub cbTamanho_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTamanho.SelectedIndexChanged
        Try
            If cbTamanho.SelectedIndex <> 0 Then
                cTamanho = CDec(cbTamanho.ObterChaveCombo)
            End If
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Try
            picProduto.Image = Nothing
            OpenFileDialog1.FileName = Nothing
            pathImg = Nothing
            img = Nothing
            btnRemove.Visible = False
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try

    End Sub

    Private Sub txtProduto_Enter(sender As Object, e As EventArgs) Handles txtProduto.Enter
        lblProdObg.Visible = False
    End Sub
End Class