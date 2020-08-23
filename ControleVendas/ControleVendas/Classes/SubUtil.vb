Imports GFT.Util
Imports GFT.Util.clsMsgBox
Public Module SubUtil
    Private Declare Auto Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal procHandle As IntPtr, ByVal min As Int32, byvalMax As Int32) As Boolean
#Region "Enums"
    '=======================================
    'Enums
    '=======================================
    Public Enum eTipoMovimentacao
        Entrada = 1
        Saida = 2
    End Enum
    Public Enum eTela

        Clientes
        Produtos
        Estoque
        Configuracao
        Vendas

        Usuario = 202
        Email = 203

        about = 210

    End Enum
    Public Enum eFormaPagamento
        Dinheiro = 1
        Debito = 2
        Credito = 3
    End Enum

    Public Enum eSimNao
        Sim = 1
        Nao = 2
    End Enum
    Public Enum Collor
        Preto = 1
        VerdeEscuro = 2
        VerdeClaro = 3
        Amarelo = 4
        Marrom = 5
        Branco = 6
        DarkTurquoise = 7
        DarkSlateGray = 8
        DimGray = 9
        CinzaMedio = 10
        CinzaAzulado = 11
        Gelo = 12
        Azul = 13
        Azul4 = 16
        Control
        Claro
        CinzaClaro
        CinzaBranco
        CinzaEscuro
        Rosa
        Nenhuma
    End Enum
    Public Enum eStatusDespesa
        Pago = 1
        Pendente = 2
        Atrasado = 3
    End Enum

    Public Enum eStatus
        Ativo = 1
        Inativo = 2
    End Enum
    Public Enum eTipoConta
        Corrente = 1
        Poupanca = 2
        Digital = 3
    End Enum

    Public Enum eTipoMensagem
        OK = 1
        Question = 2
        Erro = 3
    End Enum
    Public Enum eBanco
        Nubank = 1
        Santander = 2
        Bradesco = 3
        Itau = 4
        MercadoPago = 5
        PicPay = 6
        Stone = 7
        HSBC = 8
        Citibank = 9
        CaixaEconomica = 10
        Safra = 11
        original = 12
        Neon = 13
        Pan = 14
        Mercantil = 15
        Brasil = 16
        Daycoval = 17
        Crefisa = 18
        Cetelem = 19
        Bs2 = 20
        Bovespa = 21
        Agibank = 22
        [Next] = 23
        Inter = 24
        PagBank = 25
        Ame = 26
        PayPal = 27
    End Enum

    '=======================================
    'FIM --- Enums
    '=======================================
#End Region
#Region "Cores de Controles"
    '=======================================
    'Cores
    Public Sub Cor(ByRef Controle As Control, ByVal Cor As Collor)

        If Cor = Collor.Preto Then
            Controle.BackColor = Color.FromArgb(64, 62, 63)

        ElseIf Cor = Collor.VerdeEscuro Then
            Controle.BackColor = Color.FromArgb(28, 89, 54)

        ElseIf Cor = Collor.VerdeClaro Then
            Controle.BackColor = Color.FromArgb(3, 166, 74)

        ElseIf Cor = Collor.Amarelo Then

            'Controle.BackColor = Color.FromArgb(242, 192, 41)
            Controle.BackColor = Color.Goldenrod

        ElseIf Cor = Collor.Marrom Then
            Controle.BackColor = Color.FromArgb(115, 100, 56)

        ElseIf Cor = Collor.Claro Then
            Controle.BackColor = Color.FromArgb(241, 241, 241)

        ElseIf Cor = Collor.Control Then
            Controle.BackColor = SystemColors.Control

        ElseIf Cor = Collor.Branco Then
            Controle.BackColor = Color.White

        ElseIf Cor = Collor.DarkTurquoise Then
            Controle.BackColor = Color.DarkTurquoise

        ElseIf Cor = Collor.DarkSlateGray Then
            Controle.BackColor = Color.DarkSlateGray

        ElseIf Cor = Collor.CinzaMedio Then
            Controle.BackColor = Color.FromArgb(96, 122, 143)

        ElseIf Cor = Collor.CinzaAzulado Then
            Controle.BackColor = Color.FromArgb(113, 143, 168)

        ElseIf Cor = Collor.Azul Then
            Controle.BackColor = Color.FromArgb(0, 55, 105)

        ElseIf Cor = Collor.Azul4 Then
            Controle.BackColor = Color.Teal

        ElseIf Cor = Collor.CinzaClaro Then
            Controle.BackColor = Color.FromArgb(223, 223, 223)

        ElseIf Cor = Collor.CinzaBranco Then
            Controle.BackColor = Color.FromArgb(248, 248, 255)

        ElseIf Cor = Collor.CinzaEscuro Then
            Controle.BackColor = Color.FromArgb(80, 87, 86)

        ElseIf cor = Collor.Gelo Then
            Controle.BackColor = Color.WhiteSmoke

        ElseIf Cor = Collor.Rosa Then
            Controle.BackColor = Color.FromArgb(224, 36, 120)
        End If
    End Sub
    Public Sub CorButton(ByRef button As Button,
                         ByVal Cor As Collor,
                         ByVal corText As Color,
                         ByVal corHover As Color,
                         ByVal corDown As Color)

        button.ForeColor = corText
        button.FlatStyle = FlatStyle.Flat
        button.FlatAppearance.BorderSize = 0
        button.FlatAppearance.MouseOverBackColor = corHover
        button.FlatAppearance.MouseDownBackColor = corDown

        If Cor = Collor.DarkSlateGray Then
            button.BackColor = Color.DarkSlateGray

        ElseIf Cor = Collor.DarkTurquoise Then
            button.BackColor = Color.DarkTurquoise

        ElseIf Cor = Collor.VerdeEscuro Then
            button.BackColor = Color.FromArgb(28, 89, 54)

        ElseIf Cor = Collor.Amarelo Then
            button.BackColor = Color.FromArgb(242, 192, 41)

        ElseIf Cor = Collor.DimGray Then
            button.BackColor = Color.DimGray

        ElseIf Cor = Collor.Preto Then
            button.BackColor = Color.Black

        ElseIf Cor = Collor.CinzaMedio Then
            button.BackColor = Color.DarkGray

        ElseIf Cor = Collor.CinzaAzulado Then
            button.BackColor = Color.FromArgb(113, 143, 168)

        ElseIf Cor = Collor.Gelo Then
            button.BackColor = Color.WhiteSmoke

        ElseIf Cor = collor.Branco Then
            button.BackColor = Color.White

        ElseIf Cor = Collor.CinzaEscuro Then
            button.BackColor = Color.FromArgb(80, 87, 86)

        ElseIf Cor = Collor.Nenhuma Then
            button.BackColor = Color.Transparent

        ElseIf Cor = Collor.Rosa Then
            button.BackColor = Color.FromArgb(224, 36, 120)
        End If
    End Sub
    Public Sub CorList(ByRef lv As SuperLV)

        lv.BackColor = Color.WhiteSmoke
        lv.GridLines = False
        lv.FullRowSelect = True
        lv.Font = New Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular)

    End Sub

    Public Sub CorTab(ByRef tab As SuperTabControl, ByVal Cor As Collor)


        If Cor = Collor.CinzaEscuro Then
            For Each tabPage As TabPage In tab.TabPages

                tabPage.BackColor = Color.FromArgb(80, 87, 86)

            Next

            tab.SelectedTab.BackColor = Color.FromArgb(64, 62, 63)

        ElseIf Cor = Collor.CinzaAzulado Then
            For Each tabPage As TabPage In tab.TabPages

                tabPage.BackColor = SystemColors.InactiveBorder
            Next

        ElseIf Cor = Collor.CinzaClaro Then
            For Each tabPage As TabPage In tab.TabPages

                tab.BackColor = SystemColors.Control
            Next

        ElseIf Cor = Collor.Claro Then

            For Each tabpage As TabPage In tab.TabPages

                tabpage.BackColor = Color.FromArgb(241, 241, 241)
            Next
            'ElseIf Cor = Collor.Amarelo Then
            'tab.BackColor = Color.FromArgb(242, 192, 41)

            'ElseIf Cor = Collor.Marrom Then
            '    tab.BackColor = Color.FromArgb(115, 100, 56)

        End If
    End Sub

    '=======================================
    'FIM------Cores
    '=======================================
#End Region
    Public Function MinHora(ByVal _date As Date) As Date
        Dim data As Date
        Try
            data = New Date(_date.Year, _date.Month, _date.Day, 0, 0, 0)

            Return data

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function MaxHora(ByVal _data As Date) As Date
        Dim data As Date
        Try
            data = New Date(_data.Year, _data.Month, _data.Day, 23, 59, 59)
            Return data
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function
    'Public Function Banco(ByVal rBanco As String) As Bitmap
    '    Dim img As Bitmap = Nothing

    '    Try
    '        rBanco = rBanco.Replace(" ", "").ToUpper()

    '        If rBanco.Contains("NUBANK") Then

    '            img = My.Resources.iconNubank_fw

    '        ElseIf rBanco.Contains("BRADESCO") Then

    '            img = My.Resources.iconBradesco

    '        ElseIf rBanco.Contains("ITAU") Then

    '            img = My.Resources.iconItau_fw

    '        ElseIf rBanco.Contains("SANTANDER") Then

    '            img = My.Resources.iconSantander

    '        ElseIf rBanco.Contains("CAIXA") Then

    '            img = My.Resources.iconBankmini_fw

    '        ElseIf rBanco.Contains("AME") Then

    '            img = My.Resources.iconBankmini_fw

    '        ElseIf rBanco.Contains("PICPAY") Then

    '            img = My.Resources.iconPicPay

    '        ElseIf rBanco.Contains("MERCADOPAGO") Then

    '            img = My.Resources.iconMercadoPago_fw

    '        ElseIf rBanco.Contains("INTER") Then

    '            img = My.Resources.iconBankmini_fw

    '        ElseIf rBanco.Contains("HSBC") Then

    '            img = My.Resources.iconBankmini_fw

    '        ElseIf rBanco.Contains("AGIBANK") Then

    '            img = My.Resources.iconBankmini_fw

    '        ElseIf rBanco.Contains("BOVESPA") Then

    '            img = My.Resources.iconBankmini_fw

    '        ElseIf rBanco.Contains("SAFRA") Then

    '            img = My.Resources.iconBankmini_fw

    '        ElseIf rBanco.Contains("STONE") Then

    '            img = My.Resources.iconBankmini_fw

    '        ElseIf rBanco.Contains("ORIGINAL") Then

    '            img = My.Resources.iconBankmini_fw

    '        ElseIf rBanco.Contains("BRASIL") Then

    '            img = My.Resources.iconBankmini_fw

    '        ElseIf rBanco.Contains("CITIBANK") Then

    '            img = My.Resources.iconBankmini_fw

    '        ElseIf rBanco.Contains("CETELEM") Then

    '            img = My.Resources.iconBankmini_fw

    '        ElseIf rBanco.Contains("NEON") Then

    '            img = My.Resources.iconBankmini_fw

    '        ElseIf rBanco.Contains("NEXT") Then

    '            img = My.Resources.iconBankmini_fw

    '        ElseIf rBanco.Contains("BS2") Then

    '            img = My.Resources.iconBankmini_fw

    '        ElseIf rBanco.Contains("DAYCOVAL") Then

    '            img = My.Resources.iconBankmini_fw

    '        ElseIf rBanco.Contains("PAGBANK") Then

    '            img = My.Resources.iconBank

    '        ElseIf rBanco.Contains("MERCANTIL") Then

    '            img = My.Resources.iconBankmini_fw

    '        ElseIf rBanco.Contains("PAYPAL") Then

    '            img = My.Resources.iconBankmini_fw

    '        ElseIf rBanco.Contains("CREFISA") Then

    '            img = My.Resources.iconBankmini_fw

    '        ElseIf rBanco.Contains("PAN") Then

    '            img = My.Resources.iconBankmini_fw
    '        Else
    '            img = My.Resources.iconBankmini_fw
    '        End If

    '        Return img

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '        Return Nothing
    '    End Try
    'End Function

    Public Function StatusImage(ByVal cStatus As Decimal) As Bitmap
        Dim image As Bitmap = Nothing
        Try

            If cStatus = eStatusDespesa.Pendente Then

                'image = My.Resources.iconPendente

            ElseIf cStatus = eStatusDespesa.Pago Then

                'image = My.Resources.iconPago

            ElseIf cStatus = eStatusDespesa.Atrasado Then

                'image = My.Resources.iconStatusAtrasado_Alerta_

            End If

            Return image
        Catch ex As Exception
            LogaErro(ex.Message & "Metodo::. StatusImage - SUbUtil")
            Return Nothing
        End Try
    End Function
    Public Function SimNaoImage(ByVal rStatus As String) As Bitmap
        Dim image As Bitmap = Nothing
        Try

            If CBool(rStatus.ToUpper.Contains("NÃO")) Then

                'image = My.Resources.iconNao

            ElseIf CBool(rStatus.ToUpper.Contains("SIM")) Then

                'image = My.Resources.iconSim
            End If

            Return image
        Catch ex As Exception
            LogaErro(ex.Message & "Metodo::. SimNaoImage - SUbUtil")
            Return Nothing
        End Try
    End Function
    Public Sub AdicionaImgColumn(ByVal oDataset As SuperDataSet, ByVal column As String)
        Dim image As ImageConverter
        Try
            image = New ImageConverter()

            For Each linha As DataRow In oDataset.Tables(0).Rows

                'linha(column) = image.ConvertTo(Banco(linha.ItemArray(5).ToString),
                'System.Type.GetType("System.Byte[]"))

            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub SelecionarDataGrid(ByRef dtGrid As DataGridView, ByVal row As Integer,
                                  Optional ByVal _BackColor As Color = Nothing,
                                  Optional ByVal _ForeColor As Color = Nothing)
        Dim backColor As Color
        Dim foreColor As Color

        Try
            If _BackColor = Nothing Then
                backColor = SystemColors.ButtonFace
            Else
                backColor = _BackColor
            End If
            If _ForeColor = Nothing Then
                _ForeColor = Color.Black
            Else
                foreColor = _ForeColor
            End If

            If CInt(dtGrid.Rows(row).Index) <> -1 Then

                If Control.ModifierKeys = Keys.Control Or Control.ModifierKeys = Keys.None Then

                    If CBool(dtGrid.Rows(row).Cells(0).Value) = False Then

                        dtGrid.Rows(row).Cells(0).Value = True

                        dtGrid.Rows(row).Selected = True
                        dtGrid.Refresh()

                    ElseIf CBool(dtGrid.Rows(row).Cells(0).Value) = True Then

                        dtGrid.Rows(row).Selected = False
                        dtGrid.Rows(row).Cells(0).Value = False
                        dtGrid.Rows(row).DefaultCellStyle.BackColor = backColor
                        dtGrid.Rows(row).DefaultCellStyle.ForeColor = foreColor

                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Function Mensagem(ByVal tipoMsg As eTipoMensagem,
                             Optional checados As Integer = Nothing,
                             Optional ok As Integer = Nothing,
                             Optional erro As Integer = Nothing) As eRet
        Try
            If tipoMsg = eTipoMensagem.Question Then
                If checados = Nothing Then
                    If S_MsgBox("Deseja realmente deletar este registro?",
                               eBotoes.SimNao, "Exclusão de Registro",,
                               eImagens.Interrogacao) = eRet.Sim Then

                        Return eRet.Sim
                    Else
                        Return eRet.Nao
                    End If
                Else
                    If S_MsgBox("Deseja realmente deletar " & checados & " registros?",
                               eBotoes.SimNao, "Exclusão de Registros",,
                               eImagens.Interrogacao) = eRet.Sim Then
                        Return eRet.Sim
                    Else
                        Return eRet.Nao
                    End If
                End If

            ElseIf tipoMsg = eTipoMensagem.OK Then

                If checados = Nothing Or checados = 0 Then

                    S_MsgBox("Pronto, registro excluído com sucesso.",
                             eBotoes.Ok, "Exclusão de Registro.",
                             eImagens.Ok)
                Else
                    S_MsgBox("Pronto, registros excluídos com sucesso.",
                            eBotoes.Ok, "Exclusão de Registros.",
                            eImagens.Ok)
                End If

            ElseIf tipoMsg = eTipoMensagem.Erro Then
                If checados = Nothing Then
                    S_MsgBox("Desculpe, não foi possível deletar o registro.",
                             eBotoes.Ok, "Atenção: Houve um erro e o registro pode não ter sido deletado.",
                             eImagens.Cancel)
                Else
                    S_MsgBox("Registros excluídos: " & ok & vbNewLine &
                             "Registros que não foram excluídos: " & erro & vbNewLine &
                             "Total de Registros selecionados:" & checados,
                             eBotoes.Ok, "Atenção: Houve um erro e alguns registros podem não ter sido deletados.",
                             eImagens.Cancel)
                End If
                Return Nothing
            End If

            Return Nothing

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Sub restaurarMDI()
        Lixeiro()
        frmPrincipal.txtCaption.Text = "Dashboard"
    End Sub

    Public Sub Lixeiro()
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.WaitForFullGCComplete()
        GC.Collect()
        LiberaMemoria()
    End Sub
    Public Function LiberaMemoria() As Boolean
        Dim mem As Process = Process.GetCurrentProcess
        Try
            SetProcessWorkingSetSize(mem.Handle, -1, -1)
            'Lixeiro()
            Return True
        Catch ex As Exception
            mem.Dispose()
            Return False
        End Try
    End Function
    Public Sub alterarCaptionFormPrincipal(ByVal n_nova_tela As Integer)
        Dim arrstr As String()
        Dim strDescricaoForm As String

        Try
            arrstr = CType(collNomeTela(Int(n_nova_tela).ToString), String())
            strDescricaoForm = arrstr(1)

            frmPrincipal.txtCaption.Text = frmPrincipal.txtCaption.Text & "  »  " & strDescricaoForm

        Catch ex As Exception
            LogaErro("Erro em " & NomeMetodo("Util") & ": " & ex.Message)
        End Try

    End Sub

    '------------------------------------------------------------------------
    ' centralizarGrupoTab(ByVal oGrp As SuperTabControl)
    '------------------------------------------------------------------------
    Public Sub centralizarGrupoTab(ByVal oGrp As SuperTabControl)
        oGrp.Left = CInt((oGrp.Parent.Width / 2) - (oGrp.Width / 2))
    End Sub

    Public Sub centralizarGrupoTab(ByVal oGrp As TabControl)
        oGrp.Left = CInt((oGrp.Parent.Width / 2) - (oGrp.Width / 2))
    End Sub

    Public Sub centralizarGrupoBotoes(ByRef oGrp As GroupBox)
        oGrp.Left = CInt((oGrp.Parent.Width / 2) - (oGrp.Width / 2))
    End Sub

    Public Sub centralizarPainel(ByRef oGrp As Panel)
        oGrp.Left = CInt((oGrp.Parent.Width / 2) - (oGrp.Width / 2))
    End Sub

    Public Sub InicializaTelas()
        Try

            LogaErro("Iniciando strings telas...")

            collNomeTela = New Collection()

            collNomeTela.Add(New String() {" ", "Clientes"}, Int(eTela.Clientes).ToString)
            collNomeTela.Add(New String() {" ", "Produtos"}, Int(eTela.Produtos).ToString)
            collNomeTela.Add(New String() {" ", "Consulta de Estoque"}, Int(eTela.Estoque).ToString)
            collNomeTela.Add(New String() {" ", "Configurações"}, Int(eTela.Configuracao).ToString)
            collNomeTela.Add(New String() {" ", "Usuário"}, Int(eTela.Usuario).ToString)
            collNomeTela.Add(New String() {" ", "Envio de Email"}, Int(eTela.Email).ToString)
            collNomeTela.Add(New String() {" ", "Sobre"}, Int(eTela.about).ToString)
            collNomeTela.Add(New String() {" ", "Vendas"}, Int(eTela.Vendas).ToString)
        Catch ex As Exception
            LogaErro("Erro em " & NomeMetodo("Util") & ": " & ex.Message)
        End Try

    End Sub

End Module
