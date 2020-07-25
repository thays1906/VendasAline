Imports GFT.Util
Public Module SubUtil
    Private Declare Auto Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal procHandle As IntPtr, ByVal min As Int32, byvalMax As Int32) As Boolean

    '=======================================
    'Enums
    '=======================================
    Public Enum eTela
        Clientes = 100
        Produtos = 101
        Vendas = 102
        Configuracoes = 103
        About = 104

    End Enum
    Public Enum eCadastroCategoria
        FormaPagamento = 1
        CategoriaDespesa = 2
        CategoriaReceita = 3
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
        CinzaClaro
        CinzaBranco
        CinzaEscuro
        RosaGirl
        RosaEscuro
        Nenhuma
    End Enum
    Public Enum eStatusDespesa
        Pago = 1
        Pendente = 2
        Atrasado = 3
    End Enum
    Public Enum eDespesaFixa
        Diario = 1
        Semanal = 7
        Quinzenal = 15
        Mensal = 30
        Bimestral = 60
        Trimestral = 90
        Semestral = 182
        Anual = 365
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
    Public Enum eAcao
        Novo = 1
        Editar = 2
        Excluir = 3
    End Enum
    Public Enum eTipoMensagem
        OK = 1
        Question = 2
        Erro = 3
    End Enum
    '=======================================
    'FIM --- Enums
    '=======================================
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
            Controle.BackColor = Color.FromArgb(242, 192, 41)
            Controle.BackColor = Color.Goldenrod

        ElseIf Cor = Collor.Marrom Then
            Controle.BackColor = Color.FromArgb(115, 100, 56)
        ElseIf Cor = Collor.Branco Then
            Controle.BackColor = Color.WhiteSmoke
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

        ElseIf Cor = Collor.RosaGirl Then
            Controle.BackColor = Color.FromArgb(227, 100, 151)
        ElseIf Cor = Collor.RosaEscuro Then
            Controle.BackColor = Color.FromArgb(173, 28, 93)


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
            button.BackColor = Color.FromArgb(96, 122, 143)
        ElseIf Cor = Collor.CinzaAzulado Then
            button.BackColor = Color.FromArgb(113, 143, 168)
        ElseIf Cor = Collor.Gelo Then
            button.BackColor = Color.WhiteSmoke
        ElseIf Cor = collor.Branco Then
            button.BackColor = Color.White
        ElseIf Cor = Collor.Nenhuma Then
            button.BackColor = Color.Transparent
        End If
    End Sub
    Public Sub CorList(ByRef lv As SuperLV)

        lv.BackColor = Color.WhiteSmoke
        lv.GridLines = False
        lv.FullRowSelect = True
        lv.Font = New Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular)

    End Sub

    'Public Sub CorTab(ByRef tab As TabControl, ByVal Cor As Collor)
    '    If Cor = Collor.Preto Then
    '        tab.s
    '        '    tab.SelectedTab.BackColor = Color.FromArgb(64, 62, 63)

    '        'ElseIf Cor = Collor.VerdeEscuro Then
    '        '    tab.BackColor = Color.FromArgb(28, 89, 54)

    '        'ElseIf Cor = Collor.VerdeClaro Then
    '        '    tab.BackColor = Color.FromArgb(3, 166, 74)

    '        'ElseIf Cor = Collor.Amarelo Then
    '        '    tab.BackColor = Color.FromArgb(242, 192, 41)

    '        'ElseIf Cor = Collor.Marrom Then
    '        '    tab.BackColor = Color.FromArgb(115, 100, 56)

    '    End If
    'End Sub
    '=======================================
    'FIM------Cores
    '=======================================


    Public Sub restaurarMDI()
        Lixeiro()
        frmPrincipal.txtCaption.Text = "Home"
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
            frmPrincipal.txtCaption.Text = strDescricaoForm
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

            collNomeTela.Add(New String() {"frmProdutos", "Produtos"}, Int(eTela.Produtos).ToString)
            collNomeTela.Add(New String() {"frmClientes", "Clientes"}, Int(eTela.Clientes).ToString)
            collNomeTela.Add(New String() {"frmVendas", "Vendas"}, Int(eTela.Vendas).ToString)


        Catch ex As Exception
            LogaErro("Erro em " & NomeMetodo("Util") & ": " & ex.Message)
        End Try

    End Sub

End Module
