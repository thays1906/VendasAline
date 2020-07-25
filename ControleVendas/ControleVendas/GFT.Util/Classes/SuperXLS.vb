Option Explicit On
Option Strict On

Imports System.IO
'Imports OfficeOpenXml
'Imports OfficeOpenXml.Drawing 'use to load image inside excel document
'Imports OfficeOpenXml.Style
Imports System.Drawing
Imports GFT.Util.clsMsgBox

Public Class SuperXLS

    Structure sPropriedadeCelula

        Enum eAlinhamento
            General = 0
            Left = 1
            Center = 2
            CenterContinuous = 3
            Right = 4
            Fill = 5
            Distributed = 6
            Justify = 7
        End Enum

        Sub New(ByVal _Linha As Integer,
                ByVal _Coluna As Integer,
                ByVal _Valor As Object,
                ByVal _Fonte As Font,
                ByVal _Cor As Color,
                ByVal _Negrito As Boolean,
                Optional ByVal _Numberformat As String = "",
                Optional ByVal _Alinhamento As eAlinhamento = eAlinhamento.General,
                Optional ByVal _Titulo As Boolean = False)

            Linha = _Linha
            Coluna = _Coluna
            Valor = _Valor
            Fonte = _Fonte
            Cor = _Cor
            Negrito = _Negrito
            Alinhamento = _Alinhamento
            Titulo = _Titulo
            Numberformat = _Numberformat

        End Sub

        Dim Linha As Integer
        Dim Coluna As Integer
        Dim Valor As Object
        Dim TamanhoCelula As Integer
        Dim Fonte As Font
        Dim Cor As Color
        Dim Negrito As Boolean
        Dim Alinhamento As eAlinhamento
        Dim Titulo As Boolean
        Dim FundoBradesco As Boolean
        Dim Numberformat As String
    End Structure

    Private strArquivoXLS As String = ""
    Private strAba As String = "BRADESCO"
    Private strTitulo As String = "RPAD - Relatório"
    Private strAutor As String = "DOC"
    Private strComentario As String = "Garantia de Veículo - Boleto de Sinistro"
    Private strCompania As String = "Bradesco S/A"

    Const LINHA_CABECALHO_BRADESCO As Integer = 1
    Const LINHA_CABECALHO_RELATORIO As Integer = 3
    Const LINHA_CABECALHO_TABELA As Integer = 4
    Const COLUNA_INICIAL_DADOS As Integer = 1

    Private Pacote As ExcelPackage
    Private Planilha As ExcelWorksheet

    Sub New(ByVal _strArquivo As String)
        Me.Arquivo = _strArquivo
    End Sub

    Sub New()
    End Sub

#Region "Get_Set"
    Public Property Arquivo() As String
        Get
            Return strArquivoXLS
        End Get
        Set(ByVal Value As String)
            strArquivoXLS = Value
        End Set
    End Property

    Public Property Aba() As String
        Get
            Return strAba
        End Get
        Set(ByVal Value As String)
            strAba = Value
        End Set
    End Property

    Public Property Titulo() As String
        Get
            Return strTitulo
        End Get
        Set(ByVal Value As String)
            strTitulo = Value
        End Set
    End Property

    Public Property Autor() As String
        Get
            Return strAutor
        End Get
        Set(ByVal Value As String)
            strAutor = Value
        End Set
    End Property

    Public Property Comentario() As String
        Get
            Return strComentario
        End Get
        Set(ByVal Value As String)
            strComentario = Value
        End Set
    End Property

    Public Property Compania() As String
        Get
            Return strCompania
        End Get
        Set(ByVal Value As String)
            strCompania = Value
        End Set
    End Property
#End Region

    Public Function Imprimir(ByVal oDataset As SuperDataSet,
                             ByVal sNomeRelatorio As String,
                             Optional ByVal bAbrir As Boolean = False,
                             Optional ByVal bAutoFiltro As Boolean = True,
                             Optional ByVal bCongelarPainel As Boolean = True,
                             Optional ByVal bFundoBradesco As Boolean = True,
                             Optional ByVal bHabilitaGrade As Boolean = False) As Boolean

        Dim oArquivo As FileInfo
        Dim strCampo As String
        Dim iRow As Integer
        Dim iCol As Integer
        Dim ValorCampo As Object
        Dim sCabecalho As String
        Dim iTotalColunasDetalhe As Integer
        Dim sCaminhoRelat As String
        Dim CorSim As Color = System.Drawing.ColorTranslator.FromHtml("#F3F3F3")
        Dim CorNao As Color = System.Drawing.ColorTranslator.FromHtml("#FFFFFF")

        Try

            Me.Arquivo = Me.Arquivo & "." & Format(Now, "yyyy.MM.dd-hh.mm.ss") & ".xlsx"

            sCaminhoRelat = Path.Combine(Environment.GetEnvironmentVariable("Temp"), "_AcordoDescumprido_PRINT")
            ChecaCriaDiretorio(sCaminhoRelat)
            Me.Arquivo = Path.Combine(sCaminhoRelat, Me.Arquivo)

            If ExisteArquivo(Me.Arquivo) Then
                If S_MsgBox("Já existe o arquivo [" & Me.Arquivo & "]." & vbNewLine &
                         "Deseja sobrescrever?.", eBotoes.SimNao, , , eImagens.Interrogacao) = eRet.Nao Then
                    Return False
                Else
                    ApagaArquivo(Me.Arquivo)
                End If
            End If

            oArquivo = New FileInfo(Me.Arquivo)
            Pacote = New ExcelPackage(oArquivo)

            'Ajusta cabeçalho
            sCabecalho = sNomeRelatorio & " (" & Format(Now, "dd/MM/yyyy hh:mm:ss") & ")"

            Planilha = Pacote.Workbook.Worksheets.Add(Me.Aba)

            'Planilha.Cells("A1:AB1").Style.Font.Bold = True
            iCol = COLUNA_INICIAL_DADOS

            'Guarda o total de colunas
            iTotalColunasDetalhe = 0

            ''#############################################
            ''#####     FOR pra montar as colunas.    #####
            ''#############################################
            For i = 0 To oDataset.TotalColunas() - 1 'FieldCount() - 1
                strCampo = oDataset.NomeColuna(i)
                If (strCampo.Substring(0, 3) = "as_") Or
                   (strCampo.Substring(0, 3) = "me_") Or
                   (strCampo.Substring(0, 3) = "nu_") Then
                    strCampo = FormataColuna(strCampo)
                    Planilha.Cells(LINHA_CABECALHO_TABELA, iCol).Value = strCampo
                    Planilha.Cells(LINHA_CABECALHO_TABELA, iCol).Style.Font.Bold = True
                    Planilha.Cells(LINHA_CABECALHO_TABELA, iCol).Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid
                    Planilha.Cells(LINHA_CABECALHO_TABELA, iCol).Style.Fill.BackgroundColor.SetColor(Color.LightGray)
                    Planilha.Cells(LINHA_CABECALHO_TABELA, iCol).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center
                    iCol = iCol + 1
                    iTotalColunasDetalhe += 1
                End If
            Next i

            If bAutoFiltro = True Then
                Planilha.Cells(LINHA_CABECALHO_TABELA, COLUNA_INICIAL_DADOS, LINHA_CABECALHO_TABELA, iCol - 1).AutoFilter = bAutoFiltro
            End If

            If bCongelarPainel = True Then
                Planilha.View.FreezePanes(LINHA_CABECALHO_TABELA + 1, COLUNA_INICIAL_DADOS)
            End If

            iRow = LINHA_CABECALHO_TABELA + 1

            '################################################
            '#####     FOR pra Preencher as colunas.    #####
            '################################################
            For posReg = 0 To (oDataset.TotalRegistros() - 1) Step 1
                iCol = COLUNA_INICIAL_DADOS
                For i = 0 To (oDataset.TotalColunas() - 1)

                    strCampo = oDataset.NomeColuna(i)

                    If (strCampo.Substring(0, 3) = "as_") Or
                       (strCampo.Substring(0, 3) = "me_") Or
                       (strCampo.Substring(0, 3) = "nu_") Then

                        ValorCampo = oDataset.ValorCampo(i, posReg)

                        Planilha.Cells(iRow, iCol).Value = ValorCampo

                        Planilha.Cells(iRow, iCol).Style.Fill.PatternType = ExcelFillStyle.Solid

                        If iRow Mod 2 = 0 Then
                            Planilha.Cells(iRow, iCol).Style.Fill.BackgroundColor.SetColor(CorSim)
                        Else
                            Planilha.Cells(iRow, iCol).Style.Fill.BackgroundColor.SetColor(CorNao)
                        End If



                        If (oDataset.TipoDadosColuna(i) Is GetType(Decimal)) Or
                            (oDataset.TipoDadosColuna(i) Is GetType(Integer)) Then
                            Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Right
                        ElseIf (oDataset.TipoDadosColuna(i) Is GetType(DateTime)) Then
                            Planilha.Cells(iRow, iCol).Style.Numberformat.Format = "dd/MM/yyyy"
                            Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Center
                        Else
                            Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Left
                        End If

                        iCol = iCol + 1
                    End If
                Next i
                iRow = iRow + 1
            Next posReg
            '################################################
            '#####  FIM FOR pra Preencher as colunas.   #####
            '################################################

            'Autoajuste das colunas
            For iCol = COLUNA_INICIAL_DADOS To COLUNA_INICIAL_DADOS + iTotalColunasDetalhe - 1
                Planilha.Column(iCol).AutoFit()
            Next

            'Coloca o cabeçalho do Bradesco
            Planilha.Cells(LINHA_CABECALHO_BRADESCO, COLUNA_INICIAL_DADOS).Value = "BRADESCO"
            Planilha.Cells(LINHA_CABECALHO_BRADESCO, COLUNA_INICIAL_DADOS).Style.Font.Color.SetColor(Color.White)
            Planilha.Cells(LINHA_CABECALHO_BRADESCO, COLUNA_INICIAL_DADOS).Style.Font.Bold = True
            Planilha.Cells(LINHA_CABECALHO_BRADESCO, COLUNA_INICIAL_DADOS).Style.Font.Size = 22

            'Ajuste da Cor da linha de cabeçalho bradesco das colunas
            For iCol = COLUNA_INICIAL_DADOS To COLUNA_INICIAL_DADOS + iTotalColunasDetalhe - 1
                Planilha.Cells(LINHA_CABECALHO_BRADESCO, iCol).Style.Fill.PatternType = Style.ExcelFillStyle.Solid
                Planilha.Cells(LINHA_CABECALHO_BRADESCO, iCol).Style.Fill.BackgroundColor.SetColor(Color.DarkRed)
            Next iCol

            'Coloca o cabeçalho do relatório
            Planilha.Cells(LINHA_CABECALHO_RELATORIO, COLUNA_INICIAL_DADOS).Value = sCabecalho
            AgrupaCelulaTitulo(LINHA_CABECALHO_RELATORIO)
            Planilha.Cells(LINHA_CABECALHO_RELATORIO, COLUNA_INICIAL_DADOS).Style.Font.Bold = True
            Planilha.Cells(LINHA_CABECALHO_RELATORIO, COLUNA_INICIAL_DADOS).Style.Font.Color.SetColor(Color.DarkBlue)
            Planilha.Cells(LINHA_CABECALHO_RELATORIO, COLUNA_INICIAL_DADOS).Style.Font.Size = 16

            'If bFundoBradesco = True Then
            '   Planilha.BackgroundImage.Image = My.Resources.SuperLV
            'End If

            Planilha.View.ShowGridLines = bHabilitaGrade
            Pacote.Workbook.Properties.Title = Me.Titulo
            Pacote.Workbook.Properties.Author = Me.Autor
            Pacote.Workbook.Properties.Comments = Me.Comentario
            Pacote.Workbook.Properties.Company = Me.Compania

            Pacote.Workbook.Properties.SetCustomPropertyValue("Criado em", Now.ToString)

            Pacote.Save()

            If bAbrir = True Then
                Me.Visualizar()
            End If

            Return True

        Catch ex As Exception
            LogaErro("Erro em SuperXLS::Imprimir: " & ex.Message)
            Return False
        Finally
            Pacote.Dispose()
            Planilha = Nothing
            Pacote = Nothing
        End Try

    End Function

    Public Function ImprimirListaDataSet(ByVal listoDataset As List(Of SuperDataSet),
                                         ByVal sNomeRelatorio As String,
                                         Optional ByVal bAbrir As Boolean = False,
                                         Optional ByVal bAutoFiltro As Boolean = True,
                                         Optional ByVal bCongelarPainel As Boolean = True,
                                         Optional ByVal bFundoBradesco As Boolean = True,
                                         Optional ByVal bHabilitaGrade As Boolean = False) As Boolean

        Dim oArquivo As FileInfo
        Dim strCampo As String
        Dim iRow As Integer
        Dim iCol As Integer
        Dim ValorCampo As Object
        Dim sCabecalho As String
        Dim iTotalColunasDetalhe As Integer
        Dim sCaminhoRelat As String
        Dim CorSim As Color = System.Drawing.ColorTranslator.FromHtml("#F3F3F3")
        Dim CorNao As Color = System.Drawing.ColorTranslator.FromHtml("#FFFFFF")

        Try

            Me.Arquivo = Me.Arquivo & "." & Format(Now, "yyyy.MM.dd-hh.mm.ss") & ".xlsx"

            sCaminhoRelat = Path.Combine(Environment.GetEnvironmentVariable("Temp"), "_RPAD_PRINT")
            ChecaCriaDiretorio(sCaminhoRelat)
            Me.Arquivo = Path.Combine(sCaminhoRelat, Me.Arquivo)

            If ExisteArquivo(Me.Arquivo) Then
                If S_MsgBox("Já existe o arquivo [" & Me.Arquivo & "]." & vbNewLine &
                         "Deseja sobrescrever?.", eBotoes.SimNao, , , eImagens.Interrogacao) = eRet.Nao Then
                    Return False
                Else
                    ApagaArquivo(Me.Arquivo)
                End If
            End If

            oArquivo = New FileInfo(Me.Arquivo)
            Pacote = New ExcelPackage(oArquivo)

            'Ajusta cabeçalho
            sCabecalho = sNomeRelatorio & " (" & Format(Now, "dd/MM/yyyy hh:mm:ss") & ")"

            Planilha = Pacote.Workbook.Worksheets.Add(Me.Aba)

            'Planilha.Cells("A1:AB1").Style.Font.Bold = True
            iCol = COLUNA_INICIAL_DADOS

            'Guarda o total de colunas
            iTotalColunasDetalhe = 0

            ''#############################################
            ''#####     FOR pra montar as colunas.    #####
            ''#############################################
            For Each oDataset In listoDataset


                For i = 0 To oDataset.TotalColunas() - 1 'FieldCount() - 1
                    strCampo = oDataset.NomeColuna(i)
                    If (strCampo.Substring(0, 3) = "as_") Or
                       (strCampo.Substring(0, 3) = "me_") Or
                       (strCampo.Substring(0, 3) = "nu_") Then
                        strCampo = FormataColuna(strCampo)
                        Planilha.Cells(LINHA_CABECALHO_TABELA, iCol).Value = strCampo
                        Planilha.Cells(LINHA_CABECALHO_TABELA, iCol).Style.Font.Bold = True
                        Planilha.Cells(LINHA_CABECALHO_TABELA, iCol).Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid
                        Planilha.Cells(LINHA_CABECALHO_TABELA, iCol).Style.Fill.BackgroundColor.SetColor(Color.LightGray)
                        Planilha.Cells(LINHA_CABECALHO_TABELA, iCol).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center
                        iCol = iCol + 1
                        iTotalColunasDetalhe += 1
                    End If
                Next i
                Exit For
            Next
            If bAutoFiltro = True Then
                Planilha.Cells(LINHA_CABECALHO_TABELA, COLUNA_INICIAL_DADOS, LINHA_CABECALHO_TABELA, iCol - 1).AutoFilter = bAutoFiltro
            End If

            If bCongelarPainel = True Then
                Planilha.View.FreezePanes(LINHA_CABECALHO_TABELA + 1, COLUNA_INICIAL_DADOS)
            End If

            iRow = LINHA_CABECALHO_TABELA + 1

            '################################################
            '#####     FOR pra Preencher as colunas.    #####
            '################################################
            For Each oDataset In listoDataset


                For posReg = 0 To (oDataset.TotalRegistros() - 1) Step 1
                    iCol = COLUNA_INICIAL_DADOS
                    For i = 0 To (oDataset.TotalColunas() - 1)

                        strCampo = oDataset.NomeColuna(i)

                        If (strCampo.Substring(0, 3) = "as_") Or
                       (strCampo.Substring(0, 3) = "me_") Or
                       (strCampo.Substring(0, 3) = "nu_") Then

                            ValorCampo = oDataset.ValorCampo(i, posReg)

                            Planilha.Cells(iRow, iCol).Value = ValorCampo

                            Planilha.Cells(iRow, iCol).Style.Fill.PatternType = ExcelFillStyle.Solid

                            If iRow Mod 2 = 0 Then
                                Planilha.Cells(iRow, iCol).Style.Fill.BackgroundColor.SetColor(CorSim)
                            Else
                                Planilha.Cells(iRow, iCol).Style.Fill.BackgroundColor.SetColor(CorNao)
                            End If



                            If (oDataset.TipoDadosColuna(i) Is GetType(Decimal)) Or
                            (oDataset.TipoDadosColuna(i) Is GetType(Integer)) Then
                                Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Right
                            ElseIf (oDataset.TipoDadosColuna(i) Is GetType(DateTime)) Then
                                Planilha.Cells(iRow, iCol).Style.Numberformat.Format = "dd/MM/yyyy"
                                Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Center
                            Else
                                Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Left
                            End If

                            iCol = iCol + 1
                        End If
                    Next i
                    iRow = iRow + 1
                Next posReg
            Next
            '################################################
            '#####  FIM FOR pra Preencher as colunas.   #####
            '################################################

            'Autoajuste das colunas
            For iCol = COLUNA_INICIAL_DADOS To COLUNA_INICIAL_DADOS + iTotalColunasDetalhe - 1
                Planilha.Column(iCol).AutoFit()
            Next

            'Coloca o cabeçalho do Bradesco
            Planilha.Cells(LINHA_CABECALHO_BRADESCO, COLUNA_INICIAL_DADOS).Value = "BRADESCO"
            Planilha.Cells(LINHA_CABECALHO_BRADESCO, COLUNA_INICIAL_DADOS).Style.Font.Color.SetColor(Color.White)
            Planilha.Cells(LINHA_CABECALHO_BRADESCO, COLUNA_INICIAL_DADOS).Style.Font.Bold = True
            Planilha.Cells(LINHA_CABECALHO_BRADESCO, COLUNA_INICIAL_DADOS).Style.Font.Size = 22

            'Ajuste da Cor da linha de cabeçalho bradesco das colunas
            For iCol = COLUNA_INICIAL_DADOS To COLUNA_INICIAL_DADOS + iTotalColunasDetalhe - 1
                Planilha.Cells(LINHA_CABECALHO_BRADESCO, iCol).Style.Fill.PatternType = Style.ExcelFillStyle.Solid
                Planilha.Cells(LINHA_CABECALHO_BRADESCO, iCol).Style.Fill.BackgroundColor.SetColor(Color.DarkRed)
            Next iCol

            'Coloca o cabeçalho do relatório
            Planilha.Cells(LINHA_CABECALHO_RELATORIO, COLUNA_INICIAL_DADOS).Value = sCabecalho
            AgrupaCelulaTitulo(LINHA_CABECALHO_RELATORIO)
            Planilha.Cells(LINHA_CABECALHO_RELATORIO, COLUNA_INICIAL_DADOS).Style.Font.Bold = True
            Planilha.Cells(LINHA_CABECALHO_RELATORIO, COLUNA_INICIAL_DADOS).Style.Font.Color.SetColor(Color.DarkBlue)
            Planilha.Cells(LINHA_CABECALHO_RELATORIO, COLUNA_INICIAL_DADOS).Style.Font.Size = 16

            'If bFundoBradesco = True Then
            '   Planilha.BackgroundImage.Image = My.Resources.SuperLV
            'End If

            Planilha.View.ShowGridLines = bHabilitaGrade
            Pacote.Workbook.Properties.Title = Me.Titulo
            Pacote.Workbook.Properties.Author = Me.Autor
            Pacote.Workbook.Properties.Comments = Me.Comentario
            Pacote.Workbook.Properties.Company = Me.Compania

            Pacote.Workbook.Properties.SetCustomPropertyValue("Criado em", Now.ToString)

            Pacote.Save()

            If bAbrir = True Then
                Me.Visualizar()
            End If

            Return True

        Catch ex As Exception
            LogaErro("Erro em SuperXLS::Imprimir: " & ex.Message)
            Return False
        Finally
            Pacote.Dispose()
            Planilha = Nothing
            Pacote = Nothing
        End Try

    End Function

    Public Function ImprimirPopDet(ByVal oDataset As SuperDataSet,
                                   ByVal sNomeRelatorio As String,
                                   Optional ByVal Desc As String = "",
                                   Optional ByVal bAbrir As Boolean = False,
                                   Optional ByVal bAutoFiltro As Boolean = True,
                                   Optional ByVal bCongelarPainel As Boolean = True,
                                   Optional ByVal bFundoBradesco As Boolean = True,
                                   Optional ByVal bHabilitaGrade As Boolean = False) As Boolean

        Dim oArquivo As FileInfo
        Dim strCampo As String
        Dim iRow As Integer
        Dim iCol As Integer
        Dim ValorCampo As Object
        Dim sCabecalho As String
        Dim iTotalColunasDetalhe As Integer
        Dim sCaminhoRelat As String

        Try

            Me.Arquivo = Me.Arquivo & "." & Format(Now, "yyyy.MM.dd-hh.mm.ss") & ".xlsx"

            sCaminhoRelat = Path.Combine(Environment.GetEnvironmentVariable("Temp"), "_RPAD_PRINT")
            ChecaCriaDiretorio(sCaminhoRelat)
            Me.Arquivo = Path.Combine(sCaminhoRelat, Me.Arquivo)

            If ExisteArquivo(Me.Arquivo) Then
                If S_MsgBox("Já existe o arquivo [" & Me.Arquivo & "]." & vbNewLine &
                         "Deseja sobrescrever?.", eBotoes.SimNao, , , eImagens.Interrogacao) = eRet.Nao Then
                    Return False
                Else
                    ApagaArquivo(Me.Arquivo)
                End If
            End If

            oArquivo = New FileInfo(Me.Arquivo)
            Pacote = New ExcelPackage(oArquivo)

            'Ajusta cabeçalho
            sCabecalho = sNomeRelatorio & " (" & Format(Now, "dd/MM/yyyy hh:mm:ss") & ")"

            Planilha = Pacote.Workbook.Worksheets.Add(Me.Aba)

            iCol = COLUNA_INICIAL_DADOS

            'Guarda o total de colunas
            iTotalColunasDetalhe = 0
            ''TAB 1
            ''#############################################
            ''#####     FOR pra montar as colunas.    #####
            ''#############################################
            For i = 0 To oDataset.TotalColunas() - 1 'FieldCount() - 1
                strCampo = oDataset.NomeColuna(i)
                If (strCampo.Substring(0, 3) = "as_") Or
                   (strCampo.Substring(0, 3) = "me_") Or
                   (strCampo.Substring(0, 3) = "nu_") Then
                    strCampo = FormataColuna(strCampo)
                    Planilha.Cells(LINHA_CABECALHO_TABELA, iCol).Value = strCampo
                    Planilha.Cells(LINHA_CABECALHO_TABELA, iCol).Style.Font.Bold = True
                    Planilha.Cells(LINHA_CABECALHO_TABELA, iCol).Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid
                    Planilha.Cells(LINHA_CABECALHO_TABELA, iCol).Style.Fill.BackgroundColor.SetColor(Color.LightGray)
                    Planilha.Cells(LINHA_CABECALHO_TABELA, iCol).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center
                    iCol = iCol + 1
                    iTotalColunasDetalhe += 1
                End If
            Next i

            iRow = LINHA_CABECALHO_TABELA + 1

            '################################################
            '#####     FOR pra Preencher as colunas.    #####
            '################################################
            For posReg = 0 To (oDataset.TotalRegistros() - 1) Step 1
                iCol = COLUNA_INICIAL_DADOS
                For i = 0 To (oDataset.TotalColunas() - 1)

                    strCampo = oDataset.NomeColuna(i)

                    If (strCampo.Substring(0, 3) = "as_") Or
                       (strCampo.Substring(0, 3) = "me_") Or
                       (strCampo.Substring(0, 3) = "nu_") Then

                        ValorCampo = oDataset.ValorCampo(i, posReg)

                        Planilha.Cells(iRow, iCol).Value = ValorCampo

                        If (oDataset.TipoDadosColuna(i) Is GetType(Decimal)) Or
                            (oDataset.TipoDadosColuna(i) Is GetType(Integer)) Then
                            Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Right
                        ElseIf (oDataset.TipoDadosColuna(i) Is GetType(DateTime)) Then
                            Planilha.Cells(iRow, iCol).Style.Numberformat.Format = "dd/MM/yyyy"
                            Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Center
                        Else
                            Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Left
                        End If

                        iCol = iCol + 1
                    End If
                Next i
                iRow = iRow + 1
            Next posReg
            '################################################
            '#####  FIM FOR pra Preencher as colunas.   #####
            '################################################
            ''TAB2
            iCol = COLUNA_INICIAL_DADOS

            'Guarda o total de colunas
            iTotalColunasDetalhe = 0
            ''#############################################
            ''#####     FOR pra montar as colunas.    #####
            ''#############################################
            For i = 0 To oDataset.TotalColunas(1) - 1 'FieldCount() - 1
                strCampo = oDataset.NomeColuna(i, 1)
                If (strCampo.Substring(0, 3) = "as_") Or
                   (strCampo.Substring(0, 3) = "me_") Or
                   (strCampo.Substring(0, 3) = "nu_") Then
                    strCampo = FormataColuna(strCampo)
                    Planilha.Cells(iRow, iCol).Value = strCampo
                    Planilha.Cells(iRow, iCol).Style.Font.Bold = True
                    Planilha.Cells(iRow, iCol).Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid
                    Planilha.Cells(iRow, iCol).Style.Fill.BackgroundColor.SetColor(Color.LightGray)
                    Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center
                    iCol = iCol + 1
                    iTotalColunasDetalhe += 1
                End If
            Next i

            iRow += 1

            '################################################
            '#####     FOR pra Preencher as colunas.    #####
            '################################################
            For posReg = 0 To (oDataset.TotalRegistros(1) - 1) Step 1
                iCol = COLUNA_INICIAL_DADOS
                For i = 0 To (oDataset.TotalColunas(1) - 1)

                    strCampo = oDataset.NomeColuna(i, 1)

                    If (strCampo.Substring(0, 3) = "as_") Or
                       (strCampo.Substring(0, 3) = "me_") Or
                       (strCampo.Substring(0, 3) = "nu_") Then

                        ValorCampo = oDataset.ValorCampo(i, posReg, 1)

                        Planilha.Cells(iRow, iCol).Value = ValorCampo

                        If (oDataset.TipoDadosColuna(i, 1) Is GetType(Decimal)) Or
                            (oDataset.TipoDadosColuna(i, 1) Is GetType(Integer)) Then
                            Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Right
                        ElseIf (oDataset.TipoDadosColuna(i, 1) Is GetType(DateTime)) Then
                            Planilha.Cells(iRow, iCol).Style.Numberformat.Format = "dd/MM/yyyy"
                            Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Center
                        Else
                            Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Left
                        End If

                        iCol = iCol + 1
                    End If
                Next i
                iRow = iRow + 1
            Next posReg
            '################################################
            '#####  FIM FOR pra Preencher as colunas.   #####
            '################################################

            'Autoajuste das colunas
            For iCol = COLUNA_INICIAL_DADOS To COLUNA_INICIAL_DADOS + iTotalColunasDetalhe - 1
                Planilha.Column(iCol).AutoFit()
            Next

            ''TAB3
            iCol = COLUNA_INICIAL_DADOS

            'Guarda o total de colunas
            iTotalColunasDetalhe = 0
            ''#############################################
            ''#####     FOR pra montar as colunas.    #####
            ''#############################################
            For i = 0 To oDataset.TotalColunas(2) - 1 'FieldCount() - 1
                strCampo = oDataset.NomeColuna(i, 2)
                If (strCampo.Substring(0, 3) = "as_") Or
                   (strCampo.Substring(0, 3) = "me_") Or
                   (strCampo.Substring(0, 3) = "nu_") Then
                    strCampo = FormataColuna(strCampo)
                    Planilha.Cells(iRow, iCol).Value = strCampo
                    Planilha.Cells(iRow, iCol).Style.Font.Bold = True
                    Planilha.Cells(iRow, iCol).Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid
                    Planilha.Cells(iRow, iCol).Style.Fill.BackgroundColor.SetColor(Color.LightGray)
                    Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center
                    iCol = iCol + 1
                    iTotalColunasDetalhe += 1
                End If
            Next i

            iRow += 1

            '################################################
            '#####     FOR pra Preencher as colunas.    #####
            '################################################
            For posReg = 0 To (oDataset.TotalRegistros(2) - 1) Step 1
                iCol = COLUNA_INICIAL_DADOS
                For i = 0 To (oDataset.TotalColunas(2) - 1)

                    strCampo = oDataset.NomeColuna(i, 2)

                    If (strCampo.Substring(0, 3) = "as_") Or
                       (strCampo.Substring(0, 3) = "me_") Or
                       (strCampo.Substring(0, 3) = "nu_") Then

                        ValorCampo = oDataset.ValorCampo(i, posReg, 2)

                        Planilha.Cells(iRow, iCol).Value = ValorCampo

                        If (oDataset.TipoDadosColuna(i, 2) Is GetType(Decimal)) Or
                            (oDataset.TipoDadosColuna(i, 2) Is GetType(Integer)) Then
                            Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Right
                        ElseIf (oDataset.TipoDadosColuna(i, 2) Is GetType(DateTime)) Then
                            Planilha.Cells(iRow, iCol).Style.Numberformat.Format = "dd/MM/yyyy"
                            Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Center
                        Else
                            Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Left
                        End If

                        iCol = iCol + 1
                    End If
                Next i
                iRow = iRow + 1
            Next posReg
            '################################################
            '#####  FIM FOR pra Preencher as colunas.   #####
            '################################################

            'Coloca o cabeçalho do Bradesco
            Planilha.Cells(LINHA_CABECALHO_BRADESCO, COLUNA_INICIAL_DADOS).Value = "BRADESCO - " & sNomeRelatorio & " | " & Desc
            Planilha.Cells(LINHA_CABECALHO_BRADESCO, COLUNA_INICIAL_DADOS).Style.Font.Color.SetColor(Color.White)
            Planilha.Cells(LINHA_CABECALHO_BRADESCO, COLUNA_INICIAL_DADOS).Style.Font.Bold = True
            Planilha.Cells(LINHA_CABECALHO_BRADESCO, COLUNA_INICIAL_DADOS).Style.Font.Size = 22

            'Ajuste da Cor da linha de cabeçalho bradesco das colunas
            For iCol = COLUNA_INICIAL_DADOS To COLUNA_INICIAL_DADOS + iTotalColunasDetalhe - 1
                Planilha.Cells(LINHA_CABECALHO_BRADESCO, iCol).Style.Fill.PatternType = Style.ExcelFillStyle.Solid
                Planilha.Cells(LINHA_CABECALHO_BRADESCO, iCol).Style.Fill.BackgroundColor.SetColor(Color.DarkRed)
            Next iCol

            'Coloca o cabeçalho do relatório
            Planilha.Cells(LINHA_CABECALHO_RELATORIO, COLUNA_INICIAL_DADOS).Value = sCabecalho
            AgrupaCelulaTitulo(LINHA_CABECALHO_RELATORIO)
            Planilha.Cells(LINHA_CABECALHO_RELATORIO, COLUNA_INICIAL_DADOS).Style.Font.Bold = True
            Planilha.Cells(LINHA_CABECALHO_RELATORIO, COLUNA_INICIAL_DADOS).Style.Font.Color.SetColor(Color.DarkBlue)
            Planilha.Cells(LINHA_CABECALHO_RELATORIO, COLUNA_INICIAL_DADOS).Style.Font.Size = 16

            Planilha.View.ShowGridLines = bHabilitaGrade
            Pacote.Workbook.Properties.Title = Me.Titulo
            Pacote.Workbook.Properties.Author = Me.Autor
            Pacote.Workbook.Properties.Comments = Me.Comentario
            Pacote.Workbook.Properties.Company = Me.Compania

            Pacote.Workbook.Properties.SetCustomPropertyValue("Criado em", Now.ToString)

            Pacote.Save()

            If bAbrir = True Then
                Me.Visualizar()
            End If

            Return True

        Catch ex As Exception
            LogaErro("Erro em SuperXLS::Imprimir: " & ex.Message)
            Return False
        Finally
            Pacote.Dispose()
            Planilha = Nothing
            Pacote = Nothing
        End Try

    End Function


    Public Function ImpFluxCom(ByVal oDataset As SuperDataSet,
                               ByVal oDataset2 As SuperDataSet,
                               ByVal sNomeRelatorio As String,
                               Optional ByVal bAbrir As Boolean = False,
                               Optional ByVal bAutoFiltro As Boolean = True,
                               Optional ByVal bCongelarPainel As Boolean = True,
                               Optional ByVal bFundoBradesco As Boolean = True,
                               Optional ByVal bHabilitaGrade As Boolean = False) As Boolean

        Dim oArquivo As FileInfo
        Dim strCampo As String
        Dim iRow As Integer
        Dim iCol As Integer
        Dim ValorCampo As Object = New Object()
        Dim sCabecalho As String
        Dim iTotalColunasDetalhe As Integer
        Dim sCaminhoRelat As String

        Try

            Me.Arquivo = Me.Arquivo & "." & Format(Now, "yyyy.MM.dd-hh.mm.ss") & ".xlsx"

            sCaminhoRelat = Path.Combine(Environment.GetEnvironmentVariable("Temp"), "_RPAD_PRINT")
            ChecaCriaDiretorio(sCaminhoRelat)
            Me.Arquivo = Path.Combine(sCaminhoRelat, Me.Arquivo)

            If ExisteArquivo(Me.Arquivo) Then
                If S_MsgBox("Já existe o arquivo [" & Me.Arquivo & "]." & vbNewLine &
                         "Deseja sobrescrever?.", eBotoes.SimNao, , , eImagens.Interrogacao) = eRet.Nao Then
                    Return False
                Else
                    ApagaArquivo(Me.Arquivo)
                End If
            End If

            oArquivo = New FileInfo(Me.Arquivo)
            Pacote = New ExcelPackage(oArquivo)

            'Ajusta cabeçalho
            sCabecalho = sNomeRelatorio & " (" & Format(Now, "dd/MM/yyyy hh:mm:ss") & ")"

            Planilha = Pacote.Workbook.Worksheets.Add(Me.Aba)

            'Planilha.Cells("A1:AB1").Style.Font.Bold = True
            iCol = COLUNA_INICIAL_DADOS

            'Guarda o total de colunas
            iTotalColunasDetalhe = 0

            ''#######################################################
            ''#####     FOR pra montar as colunas Cabeçalho.    #####
            ''#######################################################
            For i = 0 To 7


                strCampo = FormataColuna("")
                Planilha.Cells(LINHA_CABECALHO_TABELA, iCol).Value = strCampo
                Planilha.Cells(LINHA_CABECALHO_TABELA, iCol).Style.Font.Bold = True
                Planilha.Cells(LINHA_CABECALHO_TABELA, iCol).Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid
                Planilha.Cells(LINHA_CABECALHO_TABELA, iCol).Style.Fill.BackgroundColor.SetColor(Color.LightGray)
                Planilha.Cells(LINHA_CABECALHO_TABELA, iCol).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center
                iCol = iCol + 1
                iTotalColunasDetalhe += 1


            Next i

            iRow = LINHA_CABECALHO_TABELA + 1

            Planilha.Cells(LINHA_CABECALHO_TABELA, COLUNA_INICIAL_DADOS).Value = "FLUXO DE COMISSÃO DE FIANÇA"
            Planilha.Cells(LINHA_CABECALHO_TABELA, COLUNA_INICIAL_DADOS).Style.Font.Color.SetColor(Color.Blue)
            Planilha.Cells(LINHA_CABECALHO_TABELA, COLUNA_INICIAL_DADOS).Style.Font.Bold = True
            Planilha.Cells(LINHA_CABECALHO_TABELA, COLUNA_INICIAL_DADOS).Style.Font.Size = 14
            AgrupaCelulaTitulo(LINHA_CABECALHO_TABELA)

            '##########################################################
            '#####      FOR pra Preencher as tabelas  Fiança.     ##### 
            '##########################################################
            'Preenche 1º tabela cabeçalho 
            For i = 0 To (oDataset.TotalColunas() - 1)
                strCampo = oDataset.NomeColuna(i)
                iCol = COLUNA_INICIAL_DADOS
                Select Case i

                    Case 0
                        ValorCampo = "AFIANÇADA"
                    Case 1
                        ValorCampo = "BENEFICIÁRIA"
                    Case 2
                        ValorCampo = "FIANÇA"
                    Case 3
                        ValorCampo = "INICIO"
                    Case 4
                        ValorCampo = "VENCIMENTO"
                    Case 5
                        ValorCampo = "VALOR ORIGINAL"
                    Case 6
                        ValorCampo = "COMISSÃO "
                    Case 7
                        ValorCampo = "PERIODICIDADE"
                    Case 8
                        ValorCampo = "AGÊNCIA"
                    Case 9
                        ValorCampo = "C/C"
                End Select
                Planilha.Cells(iRow, iCol).Style.Font.Color.SetColor(Color.Blue)
                Planilha.Cells(iRow, iCol).Style.Font.Bold = True
                Planilha.Cells(iRow, iCol).Value = ValorCampo

                If (strCampo.Substring(0, 3) = "as_") Or
                   (strCampo.Substring(0, 3) = "me_") Or
                   (strCampo.Substring(0, 3) = "nu_") Then

                    ValorCampo = oDataset.ValorCampo(i, 0)

                    Planilha.Cells(iRow, iCol + 1).Value = ValorCampo
                    Planilha.Cells(iRow, iCol + 1).Style.Font.Color.SetColor(Color.Blue)

                    If (oDataset.TipoDadosColuna(i) Is GetType(Decimal)) Or
                        (oDataset.TipoDadosColuna(i) Is GetType(Integer)) Then
                        Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Right
                    ElseIf (oDataset.TipoDadosColuna(i) Is GetType(DateTime)) Then
                        Planilha.Cells(iRow, iCol).Style.Numberformat.Format = "dd/MM/yyyy"
                        Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Center
                    Else
                        Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Left
                    End If

                    iRow += 1
                End If
            Next i
            If bCongelarPainel = True Then
                Planilha.View.FreezePanes(iRow + 2, COLUNA_INICIAL_DADOS)
            End If

            'Preenche tabela extrato
            For posReg = 0 To (oDataset2.TotalRegistros() - 1) Step 1
                iCol = COLUNA_INICIAL_DADOS
                For i = 0 To (oDataset2.TotalColunas() - 1)

                    strCampo = oDataset2.NomeColuna(i)
                    If posReg = 0 Then 'ASSEGURANDO ENTRAR UMA ÚNICA VEZ PARA CRIAR TEXTO CABEÇALHO TABELA EXTRATO
                        If (strCampo.Substring(0, 3) = "as_") Or
                           (strCampo.Substring(0, 3) = "me_") Or
                           (strCampo.Substring(0, 3) = "nu_") Then

                            strCampo = FormataColuna(strCampo)
                            Planilha.Cells(iRow, iCol).Value = strCampo

                            For j = 0 To 1 'CAREGA AS DUAS LINHAS DO CABEÇALHO EXTRATO E SEUS PARÂMETROS 
                                Planilha.Cells(iRow + j, iCol).Style.Font.Bold = True
                                Planilha.Cells(iRow + j, iCol).Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid
                                Planilha.Cells(iRow + j, iCol).Style.Fill.BackgroundColor.SetColor(Color.LightGray)
                                Planilha.Cells(iRow + j, iCol).Style.VerticalAlignment = Style.ExcelVerticalAlignment.Top
                                Planilha.Cells(iRow + j, iCol).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center
                                Planilha.Cells(iRow + j, iCol).Style.Font.Color.SetColor(Color.Blue)
                                Planilha.Cells(iRow + j, iCol).Style.Border.BorderAround(ExcelBorderStyle.Thin)
                                Planilha.Cells(iRow + j, iCol).Style.WrapText = True
                            Next
                            'MESCLANDO AS DUAS LINHAS CABEÇALHO EXTRATO
                            Planilha.Cells(ConLetra(iCol) & CStr(iRow) & ":" & ConLetra(iCol) & (iRow + 1)).Merge = True
                        End If
                    End If

                    'POPULANDO TABELA EXTRATO
                    ValorCampo = oDataset2.ValorCampo(i, posReg)

                    Planilha.Cells(iRow + 2, iCol).Value = ValorCampo
                    Planilha.Cells(iRow + 2, iCol).Style.Font.Color.SetColor(Color.Blue)
                    Planilha.Cells(iRow + 2, iCol).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center
                    Planilha.Cells(iRow + 2, iCol).Style.Border.Left.Style = ExcelBorderStyle.Thin
                    Planilha.Cells(iRow + 2, iCol).Style.Border.Right.Style = ExcelBorderStyle.Thin
                    If iCol = 7 Or iCol = 8 Then
                        Planilha.Cells(iRow + 2, iCol).Style.Font.Bold = True
                    End If
                    'Criando bordas no entrono dos extratos
                    If Not ValorCampo Is DBNull.Value Then
                        If CBool(Trim(CStr(ValorCampo)) = "DEVIDA") Or CBool(Trim(CStr(ValorCampo)) = "PAGA") Then
                            Dim tLin1, tCol1, tLin2, tCol2 As Integer
                            If Not tLin1 = 0 Then
                                tLin2 = iRow + 1
                                tCol2 = iCol
                            Else
                                tLin1 = iRow + 2
                                tCol1 = 1

                            End If
                            If tLin1 > 0 And tLin2 > 0 Then
                                Planilha.Cells(ConLetra(tCol1) & (tLin1) & ":" &
                                               ConLetra(tCol2) & (tLin2)).Style.Border.BorderAround(ExcelBorderStyle.Thin)
                                tLin1 = iRow + 2
                                tLin2 = 0
                            End If
                        End If
                    End If

                    If (iCol = 2 Or iCol = 7) Then
                        Planilha.Cells(iRow + 2, iCol).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Right
                    ElseIf Not (iCol = 8) Then
                        Planilha.Cells(iRow + 2, iCol).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Center
                    Else
                        Planilha.Cells(iRow + 2, iCol).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Left
                    End If

                    iCol += 1
                Next i
                iRow += 1
            Next posReg
            '#######################################################
            '#####  FIM FOR pra Preencher colunas Cabeçalho.   #####
            '#######################################################

            'MSG RODA PÉ E PARÂMETROS
            iCol = COLUNA_INICIAL_DADOS
            ValorCampo = "Obs.: 10 dias antes do lançamento, o sistema informará no campo ""Lançamentos Futuros"" do extrato" &
                " de c/c, a data e o valor do débito."
            Planilha.Cells(iRow + 2, iCol).Value = ValorCampo
            Planilha.Cells(iRow + 2, iCol).Style.Font.Color.SetColor(Color.Blue)
            Planilha.Cells(iRow + 2, iCol).Style.Font.Bold = True
            Planilha.Cells(ConLetra(iCol) & (iRow + 2) & ":" & ConLetra(iTotalColunasDetalhe) & (iRow + 3)).Merge = True
            Planilha.Cells(iRow + 2, iCol).Style.WrapText = True
            Planilha.Cells(iRow + 2, iCol).Style.VerticalAlignment = Style.ExcelVerticalAlignment.Top
            Planilha.Cells(ConLetra(iCol) & (iRow + 2) & ":" &
                           ConLetra(iTotalColunasDetalhe) & (iRow + 3)).Style.Border.BorderAround(ExcelBorderStyle.Thin)

            'Autoajuste das colunas
            For iCol = COLUNA_INICIAL_DADOS To COLUNA_INICIAL_DADOS + iTotalColunasDetalhe - 1
                Planilha.Column(iCol).AutoFit()
                If iCol = 2 Or iCol = 7 Then
                    Planilha.Column(iCol).Width = 18
                End If
            Next

            'Coloca o cabeçalho do Bradesco
            Planilha.Cells(LINHA_CABECALHO_BRADESCO, COLUNA_INICIAL_DADOS).Value = "BRADESCO"
            Planilha.Cells(LINHA_CABECALHO_BRADESCO, COLUNA_INICIAL_DADOS).Style.Font.Color.SetColor(Color.White)
            Planilha.Cells(LINHA_CABECALHO_BRADESCO, COLUNA_INICIAL_DADOS).Style.Font.Bold = True
            Planilha.Cells(LINHA_CABECALHO_BRADESCO, COLUNA_INICIAL_DADOS).Style.Font.Size = 22


            'Ajuste da Cor da linha de cabeçalho bradesco das colunas
            For iCol = COLUNA_INICIAL_DADOS To COLUNA_INICIAL_DADOS + iTotalColunasDetalhe - 1
                Planilha.Cells(LINHA_CABECALHO_BRADESCO, iCol).Style.Fill.PatternType = Style.ExcelFillStyle.Solid
                Planilha.Cells(LINHA_CABECALHO_BRADESCO, iCol).Style.Fill.BackgroundColor.SetColor(Color.DarkRed)
            Next iCol

            'Coloca o cabeçalho do relatório
            Planilha.Cells(LINHA_CABECALHO_RELATORIO, COLUNA_INICIAL_DADOS).Value = sCabecalho
            AgrupaCelulaTitulo(LINHA_CABECALHO_RELATORIO)
            Planilha.Cells(LINHA_CABECALHO_RELATORIO, COLUNA_INICIAL_DADOS).Style.Font.Bold = True
            Planilha.Cells(LINHA_CABECALHO_RELATORIO, COLUNA_INICIAL_DADOS).Style.Font.Color.SetColor(Color.DarkBlue)
            Planilha.Cells(LINHA_CABECALHO_RELATORIO, COLUNA_INICIAL_DADOS).Style.Font.Size = 16

            Planilha.View.ShowGridLines = bHabilitaGrade
            Pacote.Workbook.Properties.Title = Me.Titulo
            Pacote.Workbook.Properties.Author = Me.Autor
            Pacote.Workbook.Properties.Company = Me.Compania

            Pacote.Workbook.Properties.SetCustomPropertyValue("Criado em", Now.ToString)

            Pacote.Save()

            If bAbrir = True Then
                Me.Visualizar()
            End If

            Return True

        Catch ex As Exception
            LogaErro("Erro em SuperXLS::Imprimir: " & ex.Message)
            Return False
        Finally
            Pacote.Dispose()
            Planilha = Nothing
            Pacote = Nothing
        End Try

    End Function

    Public Function ImprimirRelGarantia(ByVal oDataset As SuperDataSet,
                                        ByVal oDataset2 As SuperDataSet,
                                        ByVal oDataset3 As SuperDataSet,
                                        ByVal oDataset4 As SuperDataSet,
                                        ByVal oDataset5 As SuperDataSet,
                                        ByVal oDataset6 As SuperDataSet,
                                        ByVal sNomeRelatorio As String,
                                        Optional ByVal bAbrir As Boolean = False,
                                        Optional ByVal bAutoFiltro As Boolean = True,
                                        Optional ByVal bCongelarPainel As Boolean = True,
                                        Optional ByVal bFundoBradesco As Boolean = True,
                                        Optional ByVal bHabilitaGrade As Boolean = False) As Boolean

        Dim oArquivo As FileInfo
        Dim strCampo As String
        Dim iRow As Integer
        Dim iCol As Integer
        Dim ValorCampo As Object = New Object()
        Dim sCabecalho As String
        Dim iTotalColunasDetalhe As Integer
        Dim sCaminhoRelat As String

        Try

            Me.Arquivo = Me.Arquivo & "." & Format(Now, "yyyy.MM.dd-hh.mm.ss") & ".xlsx"

            sCaminhoRelat = Path.Combine(Environment.GetEnvironmentVariable("Temp"), "_RPAD_PRINT")
            ChecaCriaDiretorio(sCaminhoRelat)
            Me.Arquivo = Path.Combine(sCaminhoRelat, Me.Arquivo)

            If ExisteArquivo(Me.Arquivo) Then
                If S_MsgBox("Já existe o arquivo [" & Me.Arquivo & "]." & vbNewLine &
                         "Deseja sobrescrever?.", eBotoes.SimNao, , , eImagens.Interrogacao) = eRet.Nao Then
                    Return False
                Else
                    ApagaArquivo(Me.Arquivo)
                End If
            End If

            oArquivo = New FileInfo(Me.Arquivo)
            Pacote = New ExcelPackage(oArquivo)

            'Ajusta cabeçalho
            sCabecalho = sNomeRelatorio & " (" & Format(Now, "dd/MM/yyyy hh:mm:ss") & ")"

            For posReg = 0 To (oDataset.TotalRegistros() - 1) Step 1
                Planilha = Pacote.Workbook.Worksheets.Add(CStr(oDataset("as_Solicitação#200", posReg)))

                iCol = COLUNA_INICIAL_DADOS

                'Guarda o total de colunas
                iTotalColunasDetalhe = 0

                ''#######################################################
                ''#####     FOR pra montar as colunas Cabeçalho.    #####
                ''#######################################################
                For i = 0 To 7

                    strCampo = FormataColuna("")
                    Planilha.Cells(LINHA_CABECALHO_TABELA, iCol).Value = strCampo
                    Planilha.Cells(LINHA_CABECALHO_TABELA, iCol).Style.Font.Bold = True
                    Planilha.Cells(LINHA_CABECALHO_TABELA, iCol).Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid
                    Planilha.Cells(LINHA_CABECALHO_TABELA, iCol).Style.Fill.BackgroundColor.SetColor(Color.LightGray)
                    Planilha.Cells(LINHA_CABECALHO_TABELA, iCol).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center
                    iCol = iCol + 1
                    iTotalColunasDetalhe += 1

                Next i

                iRow = LINHA_CABECALHO_TABELA + 1

                Planilha.Cells(LINHA_CABECALHO_TABELA, COLUNA_INICIAL_DADOS).Value = "DADOS PROCESSO / SOLICITAÇÃO"
                Planilha.Cells(LINHA_CABECALHO_TABELA, COLUNA_INICIAL_DADOS).Style.Font.Color.SetColor(Color.Black)
                Planilha.Cells(LINHA_CABECALHO_TABELA, COLUNA_INICIAL_DADOS).Style.Font.Bold = True
                Planilha.Cells(LINHA_CABECALHO_TABELA, COLUNA_INICIAL_DADOS).Style.Font.Size = 14
                AgrupaCelulaTitulo(LINHA_CABECALHO_TABELA)
                '##########################################################
                '#####      FOR pra Preencher as tabelas .     ##### 
                '##########################################################
                'Preenche 1º tabela cabeçalho 
                For i = 0 To (oDataset.TotalColunas() - 1)
                    strCampo = oDataset.NomeColuna(i)
                    iCol = COLUNA_INICIAL_DADOS
                    Select Case i
                        Case 0
                            ValorCampo = "TIPO"
                        Case 1
                            ValorCampo = "SOLICITAÇÃO"
                        Case 2
                            ValorCampo = "ETAPA"
                        Case 3
                            ValorCampo = "DATA SALDO DEVEDOR"
                        Case 4
                            ValorCampo = "DATA SGSS"
                        Case 5
                            ValorCampo = "PRODUTO EMPF"
                        Case 6
                            ValorCampo = "DATA SALDO"
                        Case 7
                            ValorCampo = "SINISTRO"
                        Case 8
                            ValorCampo = "TIPO CALCULO"
                    End Select
                    Planilha.Cells(iRow, iCol).Style.Font.Color.SetColor(Color.Black)
                    Planilha.Cells(iRow, iCol).Style.Font.Bold = True
                    Planilha.Cells(iRow, iCol).Value = ValorCampo
                    Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Right

                    If (strCampo.Substring(0, 3) = "as_") Or
                       (strCampo.Substring(0, 3) = "me_") Or
                       (strCampo.Substring(0, 3) = "nu_") Then

                        ValorCampo = oDataset.ValorCampo(i, 0)

                        Planilha.Cells(iRow, iCol + 1).Value = ValorCampo
                        Planilha.Cells(iRow, iCol + 1).Style.Font.Color.SetColor(Color.Black)

                        If (oDataset.TipoDadosColuna(i) Is GetType(Decimal)) Or
                            (oDataset.TipoDadosColuna(i) Is GetType(Integer)) Then
                            Planilha.Cells(iRow, iCol + 1).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Right
                        ElseIf (oDataset.TipoDadosColuna(i) Is GetType(DateTime)) Then
                            Planilha.Cells(iRow, iCol).Style.Numberformat.Format = "dd/MM/yyyy"
                            Planilha.Cells(iRow, iCol + 1).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Center
                        Else
                            Planilha.Cells(iRow, iCol + 1).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Left
                        End If

                        iRow += 1
                    End If
                Next i
                For i = 0 To 7

                    Planilha.Cells(iRow, iCol).Style.Font.Bold = True
                    Planilha.Cells(iRow, iCol).Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid
                    Planilha.Cells(iRow, iCol).Style.Fill.BackgroundColor.SetColor(Color.LightGray)
                    Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center
                    iCol = iCol + 1

                Next i

                Planilha.Cells(iRow, COLUNA_INICIAL_DADOS).Value = "DADOS DO CLIENTE"
                Planilha.Cells(iRow, COLUNA_INICIAL_DADOS).Style.Font.Color.SetColor(Color.Black)
                Planilha.Cells(iRow, COLUNA_INICIAL_DADOS).Style.Font.Bold = True
                Planilha.Cells(iRow, COLUNA_INICIAL_DADOS).Style.Font.Size = 14
                AgrupaCelulaTitulo2(iRow)
                iRow += 1
                For i = 0 To (oDataset2.TotalColunas() - 1)
                    strCampo = oDataset2.NomeColuna(i)
                    iCol = COLUNA_INICIAL_DADOS
                    Select Case i
                        Case 0
                            ValorCampo = "NOME"
                        Case 1
                            ValorCampo = "PESSOA"
                        Case 2
                            ValorCampo = "CPF/CNPJ"
                        Case 3
                            ValorCampo = "AGÊNCIA"
                        Case 4
                            ValorCampo = "Nº CONTA CORRENTE"
                        Case 5
                            ValorCampo = "E-MAIL"
                        Case 6
                            ValorCampo = "ENDEREÇO"
                    End Select
                    Planilha.Cells(iRow, iCol).Style.Font.Color.SetColor(Color.Black)
                    Planilha.Cells(iRow, iCol).Style.Font.Bold = True
                    Planilha.Cells(iRow, iCol).Value = ValorCampo
                    Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Right

                    If (strCampo.Substring(0, 3) = "as_") Or
                       (strCampo.Substring(0, 3) = "me_") Or
                       (strCampo.Substring(0, 3) = "nu_") Then

                        ValorCampo = oDataset2.ValorCampo(i, 0)

                        Planilha.Cells(iRow, iCol + 1).Value = ValorCampo
                        Planilha.Cells(iRow, iCol + 1).Style.Font.Color.SetColor(Color.Black)

                        If (oDataset2.TipoDadosColuna(i) Is GetType(Decimal)) Or
                            (oDataset2.TipoDadosColuna(i) Is GetType(Integer)) Then
                            Planilha.Cells(iRow, iCol + 1).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Right
                        ElseIf (oDataset2.TipoDadosColuna(i) Is GetType(DateTime)) Then
                            Planilha.Cells(iRow, iCol + 1).Style.Numberformat.Format = "dd/MM/yyyy"
                            Planilha.Cells(iRow, iCol + 1).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Center
                        Else
                            Planilha.Cells(iRow, iCol + 1).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Left
                        End If

                        iRow += 1
                    End If
                Next i
                For i = 0 To 7

                    Planilha.Cells(iRow, iCol).Style.Font.Bold = True
                    Planilha.Cells(iRow, iCol).Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid
                    Planilha.Cells(iRow, iCol).Style.Fill.BackgroundColor.SetColor(Color.LightGray)
                    Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center
                    iCol = iCol + 1

                Next i
                Planilha.Cells(iRow, COLUNA_INICIAL_DADOS).Value = "DADOS DO CONTRATO"
                Planilha.Cells(iRow, COLUNA_INICIAL_DADOS).Style.Font.Color.SetColor(Color.Black)
                Planilha.Cells(iRow, COLUNA_INICIAL_DADOS).Style.Font.Bold = True
                Planilha.Cells(iRow, COLUNA_INICIAL_DADOS).Style.Font.Size = 14
                AgrupaCelulaTitulo2(iRow)
                iRow += 1
                For i = 0 To (oDataset3.TotalColunas() - 1)
                    strCampo = oDataset3.NomeColuna(i)
                    iCol = COLUNA_INICIAL_DADOS
                    Select Case i
                        Case 0
                            ValorCampo = "PRODUTO"
                        Case 1
                            ValorCampo = "SUB PRODUTO"
                        Case 2
                            ValorCampo = "DATA DE CELEBRAÇÃO"
                        Case 3
                            ValorCampo = "DATA 1º PARCELA VENC."
                        Case 4
                            ValorCampo = "DIAS EM ATRAZO"
                        Case 5
                            ValorCampo = "TAXA DIÁRIA"
                        Case 6
                            ValorCampo = "TAXA JUROS"
                        Case 7
                            ValorCampo = "CARTEIRA"
                        Case 8
                            ValorCampo = "CONTRATO"
                        Case 9
                            ValorCampo = "OPERAÇÃO"
                        Case 10
                            ValorCampo = "SALDO A VENCER"
                        Case 11
                            ValorCampo = "SALDO DEVEDOR"
                        Case 12
                            ValorCampo = "DATA BLOQ. DE"
                        Case 13
                            ValorCampo = "DATA BLOQ. ATÉ"
                        Case 14
                            ValorCampo = "VALOR DOC."
                        Case 15
                            ValorCampo = "VALOR MORA"
                    End Select
                    Planilha.Cells(iRow, iCol).Style.Font.Color.SetColor(Color.Black)
                    Planilha.Cells(iRow, iCol).Style.Font.Bold = True
                    Planilha.Cells(iRow, iCol).Value = ValorCampo
                    Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Right

                    If (strCampo.Substring(0, 3) = "as_") Or
                       (strCampo.Substring(0, 3) = "me_") Or
                       (strCampo.Substring(0, 3) = "nu_") Then

                        ValorCampo = oDataset3.ValorCampo(i, 0)

                        Planilha.Cells(iRow, iCol + 1).Value = ValorCampo
                        Planilha.Cells(iRow, iCol + 1).Style.Font.Color.SetColor(Color.Black)

                        If (oDataset3.TipoDadosColuna(i) Is GetType(Decimal)) Or
                            (oDataset3.TipoDadosColuna(i) Is GetType(Integer)) Then
                            Planilha.Cells(iRow, iCol + 1).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Right
                        ElseIf (oDataset3.TipoDadosColuna(i) Is GetType(DateTime)) Then
                            Planilha.Cells(iRow, iCol + 1).Style.Numberformat.Format = "dd/MM/yyyy"
                            Planilha.Cells(iRow, iCol + 1).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Center
                        Else
                            Planilha.Cells(iRow, iCol + 1).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Left
                        End If

                        iRow += 1
                    End If
                Next i
                For i = 0 To 7

                    Planilha.Cells(iRow, iCol).Style.Font.Bold = True
                    Planilha.Cells(iRow, iCol).Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid
                    Planilha.Cells(iRow, iCol).Style.Fill.BackgroundColor.SetColor(Color.LightGray)
                    Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center
                    iCol = iCol + 1

                Next i
                Planilha.Cells(iRow, COLUNA_INICIAL_DADOS).Value = "DADOS DO VEÍCULO"
                Planilha.Cells(iRow, COLUNA_INICIAL_DADOS).Style.Font.Color.SetColor(Color.Black)
                Planilha.Cells(iRow, COLUNA_INICIAL_DADOS).Style.Font.Bold = True
                Planilha.Cells(iRow, COLUNA_INICIAL_DADOS).Style.Font.Size = 14
                AgrupaCelulaTitulo2(iRow)
                iRow += 1
                For i = 0 To (oDataset4.TotalColunas() - 1)
                    strCampo = oDataset4.NomeColuna(i)
                    iCol = COLUNA_INICIAL_DADOS
                    Select Case i
                        Case 0
                            ValorCampo = "PLACA"
                        Case 1
                            ValorCampo = "COR"
                        Case 2
                            ValorCampo = "ANO DE FABRICAÇÃO"
                        Case 3
                            ValorCampo = "ANO MODELO"
                        Case 4
                            ValorCampo = "RENAVAN"
                        Case 5
                            ValorCampo = "CHASSI"
                        Case 6
                            ValorCampo = "MARCA"
                        Case 7
                            ValorCampo = "MODELO"
                        Case 8
                            ValorCampo = "UF"
                    End Select
                    Planilha.Cells(iRow, iCol).Style.Font.Color.SetColor(Color.Black)
                    Planilha.Cells(iRow, iCol).Style.Font.Bold = True
                    Planilha.Cells(iRow, iCol).Value = ValorCampo
                    Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Right

                    If (strCampo.Substring(0, 3) = "as_") Or
                       (strCampo.Substring(0, 3) = "me_") Or
                       (strCampo.Substring(0, 3) = "nu_") Then

                        ValorCampo = oDataset4.ValorCampo(i, 0)

                        Planilha.Cells(iRow, iCol + 1).Value = ValorCampo
                        Planilha.Cells(iRow, iCol + 1).Style.Font.Color.SetColor(Color.Black)

                        If (oDataset4.TipoDadosColuna(i) Is GetType(Decimal)) Or
                            (oDataset4.TipoDadosColuna(i) Is GetType(Integer)) Then
                            Planilha.Cells(iRow, iCol + 1).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Right
                        ElseIf (oDataset4.TipoDadosColuna(i) Is GetType(DateTime)) Then
                            Planilha.Cells(iRow, iCol + 1).Style.Numberformat.Format = "dd/MM/yyyy"
                            Planilha.Cells(iRow, iCol + 1).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Center
                        Else
                            Planilha.Cells(iRow, iCol + 1).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Left
                        End If

                        iRow += 1
                    End If
                Next i
                For i = 0 To 7

                    Planilha.Cells(iRow, iCol).Style.Font.Bold = True
                    Planilha.Cells(iRow, iCol).Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid
                    Planilha.Cells(iRow, iCol).Style.Fill.BackgroundColor.SetColor(Color.LightGray)
                    Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center
                    iCol = iCol + 1

                Next i
                Planilha.Cells(iRow, COLUNA_INICIAL_DADOS).Value = "PARCELAS"
                Planilha.Cells(iRow, COLUNA_INICIAL_DADOS).Style.Font.Color.SetColor(Color.Black)
                Planilha.Cells(iRow, COLUNA_INICIAL_DADOS).Style.Font.Bold = True
                Planilha.Cells(iRow, COLUNA_INICIAL_DADOS).Style.Font.Size = 14
                AgrupaCelulaTitulo2(iRow)
                iRow += 1
                iCol = 1
                For i = 0 To oDataset5.TotalColunas() - 1 'FieldCount() - 1
                    strCampo = oDataset5.NomeColuna(i)
                    If (strCampo.Substring(0, 3) = "as_") Or
                       (strCampo.Substring(0, 3) = "me_") Or
                       (strCampo.Substring(0, 3) = "nu_") Then
                        strCampo = FormataColuna(strCampo)
                        Planilha.Cells(iRow, iCol).Value = strCampo
                        Planilha.Cells(iRow, iCol).Style.Font.Bold = True
                        Planilha.Cells(iRow, iCol).Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid
                        Planilha.Cells(iRow, iCol).Style.Fill.BackgroundColor.SetColor(Color.LightGray)
                        Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center
                        iCol = iCol + 1
                        iTotalColunasDetalhe += 1
                    End If
                Next i
                iRow += 1
                '################################################
                '#####     FOR pra Preencher as colunas.    #####
                '################################################
                For posReg1 = 0 To (oDataset5.TotalRegistros() - 1) Step 1
                    iCol = COLUNA_INICIAL_DADOS
                    For i = 0 To (oDataset5.TotalColunas() - 1)

                        strCampo = oDataset5.NomeColuna(i)

                        If (strCampo.Substring(0, 3) = "as_") Or
                           (strCampo.Substring(0, 3) = "me_") Or
                           (strCampo.Substring(0, 3) = "nu_") Then

                            ValorCampo = oDataset5.ValorCampo(i, posReg1)

                            Planilha.Cells(iRow, iCol).Value = ValorCampo

                            If (oDataset5.TipoDadosColuna(i) Is GetType(Decimal)) Or
                                (oDataset5.TipoDadosColuna(i) Is GetType(Integer)) Then
                                Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Right
                            ElseIf (oDataset5.TipoDadosColuna(i) Is GetType(DateTime)) Then
                                Planilha.Cells(iRow, iCol).Style.Numberformat.Format = "dd/MM/yyyy"
                                Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Center
                            Else
                                Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Left
                            End If

                            iCol = iCol + 1
                        End If
                    Next i
                    iRow = iRow + 1
                Next posReg1
                '################################################
                '#####  FIM FOR pra Preencher as colunas.   #####
                '################################################
                iCol = 1
                For i = 0 To 7

                    Planilha.Cells(iRow, iCol).Style.Font.Bold = True
                    Planilha.Cells(iRow, iCol).Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid
                    Planilha.Cells(iRow, iCol).Style.Fill.BackgroundColor.SetColor(Color.LightGray)
                    Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center
                    iCol = iCol + 1

                Next i
                Planilha.Cells(iRow, COLUNA_INICIAL_DADOS).Value = "DADOS LPCL"
                Planilha.Cells(iRow, COLUNA_INICIAL_DADOS).Style.Font.Color.SetColor(Color.Black)
                Planilha.Cells(iRow, COLUNA_INICIAL_DADOS).Style.Font.Bold = True
                Planilha.Cells(iRow, COLUNA_INICIAL_DADOS).Style.Font.Size = 14
                AgrupaCelulaTitulo2(iRow)
                iRow += 1
                iCol = 1
                For i = 0 To oDataset6.TotalColunas() - 1 'FieldCount() - 1
                    strCampo = oDataset6.NomeColuna(i)
                    If (strCampo.Substring(0, 3) = "as_") Or
                       (strCampo.Substring(0, 3) = "me_") Or
                       (strCampo.Substring(0, 3) = "nu_") Then
                        strCampo = FormataColuna(strCampo)
                        Planilha.Cells(iRow, iCol).Value = strCampo
                        Planilha.Cells(iRow, iCol).Style.Font.Bold = True
                        Planilha.Cells(iRow, iCol).Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid
                        Planilha.Cells(iRow, iCol).Style.Fill.BackgroundColor.SetColor(Color.LightGray)
                        Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center
                        iCol = iCol + 1
                        iTotalColunasDetalhe += 1
                    End If
                Next i
                iRow += 1
                '################################################
                '#####     FOR pra Preencher as colunas.    #####
                '################################################
                For posReg1 = 0 To (oDataset6.TotalRegistros() - 1) Step 1
                    iCol = COLUNA_INICIAL_DADOS
                    For i = 0 To (oDataset6.TotalColunas() - 1)

                        strCampo = oDataset6.NomeColuna(i)

                        If (strCampo.Substring(0, 3) = "as_") Or
                           (strCampo.Substring(0, 3) = "me_") Or
                           (strCampo.Substring(0, 3) = "nu_") Then

                            ValorCampo = oDataset6.ValorCampo(i, posReg1)

                            Planilha.Cells(iRow, iCol).Value = ValorCampo

                            If (oDataset6.TipoDadosColuna(i) Is GetType(Decimal)) Or
                                (oDataset6.TipoDadosColuna(i) Is GetType(Integer)) Then
                                Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Right
                            ElseIf (oDataset6.TipoDadosColuna(i) Is GetType(DateTime)) Then
                                Planilha.Cells(iRow, iCol).Style.Numberformat.Format = "dd/MM/yyyy"
                                Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Center
                            Else
                                Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Left
                            End If

                            iCol = iCol + 1
                        End If
                    Next i
                    iRow = iRow + 1
                Next posReg1
                '#######################################################
                '#####  FIM FOR pra Preencher colunas Cabeçalho.   #####
                '#######################################################

                iCol = COLUNA_INICIAL_DADOS

                For iCol = COLUNA_INICIAL_DADOS To COLUNA_INICIAL_DADOS + iTotalColunasDetalhe - 2
                    Planilha.Column(iCol).AutoFit()
                    If iCol = 2 Or iCol = 7 Then
                        Planilha.Column(iCol).Width = 18
                    End If
                Next

                'Coloca o cabeçalho do Bradesco
                Planilha.Cells(LINHA_CABECALHO_BRADESCO, COLUNA_INICIAL_DADOS).Value = "BRADESCO"
                Planilha.Cells(LINHA_CABECALHO_BRADESCO, COLUNA_INICIAL_DADOS).Style.Font.Color.SetColor(Color.White)
                Planilha.Cells(LINHA_CABECALHO_BRADESCO, COLUNA_INICIAL_DADOS).Style.Font.Bold = True
                Planilha.Cells(LINHA_CABECALHO_BRADESCO, COLUNA_INICIAL_DADOS).Style.Font.Size = 22


                'Ajuste da Cor da linha de cabeçalho bradesco das colunas
                For iCol = COLUNA_INICIAL_DADOS To COLUNA_INICIAL_DADOS + iTotalColunasDetalhe - 1
                    Planilha.Cells(LINHA_CABECALHO_BRADESCO, iCol).Style.Fill.PatternType = Style.ExcelFillStyle.Solid
                    Planilha.Cells(LINHA_CABECALHO_BRADESCO, iCol).Style.Fill.BackgroundColor.SetColor(Color.DarkRed)
                Next iCol

                'Coloca o cabeçalho do relatório
                Planilha.Cells(LINHA_CABECALHO_RELATORIO, COLUNA_INICIAL_DADOS).Value = sCabecalho
                AgrupaCelulaTitulo(LINHA_CABECALHO_RELATORIO)
                Planilha.Cells(LINHA_CABECALHO_RELATORIO, COLUNA_INICIAL_DADOS).Style.Font.Bold = True
                Planilha.Cells(LINHA_CABECALHO_RELATORIO, COLUNA_INICIAL_DADOS).Style.Font.Color.SetColor(Color.DarkBlue)
                Planilha.Cells(LINHA_CABECALHO_RELATORIO, COLUNA_INICIAL_DADOS).Style.Font.Size = 16

                Planilha.View.ShowGridLines = bHabilitaGrade

            Next posReg

            Pacote.Workbook.Properties.Title = Me.Titulo
            Pacote.Workbook.Properties.Author = Me.Autor
            Pacote.Workbook.Properties.Company = Me.Compania
            Pacote.Workbook.Properties.SetCustomPropertyValue("Criado em ", Now.ToString)

            Pacote.Save()

            If bAbrir = True Then
                Me.Visualizar()
            End If

            Return True

        Catch ex As Exception
            LogaErro("Erro em SuperXLS::Imprimir: " & ex.Message)
            Return False
        Finally
            Pacote.Dispose()
            Planilha = Nothing
            Pacote = Nothing
        End Try

    End Function

    '################################################
    '###CONVERTE O VALOR DO NÚMERO EM LETRA COLUNA###
    '################################################
    Function ConLetra(iNum As Integer) As String
        Dim iAlpha As Integer
        Dim iRemainder As Integer
        Dim Resul As String = ""
        iAlpha = iNum \ 27
        iRemainder = iNum - (iAlpha * 26)
        If iAlpha > 0 Then
            Resul = Chr(iAlpha + 64)
        End If
        If iRemainder > 0 Then
            Resul += Chr(iRemainder + 64)
        End If
        Return Resul
    End Function

    Public Function ImprimirTudo(ByVal oDataset As SuperDataSet,
                                 ByVal sNomeRelatorio As String,
                                 Optional ByVal bAbrir As Boolean = False,
                                 Optional ByVal bAutoFiltro As Boolean = True,
                                 Optional ByVal bCongelarPainel As Boolean = True,
                                 Optional ByVal bFundoBradesco As Boolean = True,
                                 Optional ByVal bHabilitaGrade As Boolean = False) As Boolean

        Dim oArquivo As FileInfo
        Dim strCampo As String
        'Dim iLinha As Integer = 1
        'Dim iColuna As Integer = 1
        Dim iRow As Integer
        Dim iCol As Integer
        Dim ValorCampo As Object
        Dim sCabecalho As String
        Dim iTotalColunasDetalhe As Integer
        Dim sCaminhoRelat As String

        Try

            Me.Arquivo = Me.Arquivo & "." & Format(Now, "yyyy.MM.dd-hh.mm.ss") & ".xlsx"

            sCaminhoRelat = Path.Combine(Environment.GetEnvironmentVariable("Temp"), "_RPAD_PRINT")
            ChecaCriaDiretorio(sCaminhoRelat)

            Me.Arquivo = Path.Combine(sCaminhoRelat, Me.Arquivo)

            If ExisteArquivo(Me.Arquivo) Then
                If S_MsgBox("Já existe o arquivo [" & Me.Arquivo & "]." & vbNewLine &
                         "Deseja sobrescrever?.", eBotoes.SimNao, , , eImagens.Interrogacao) = eRet.Nao Then
                    Return False
                Else
                    ApagaArquivo(Me.Arquivo)
                End If
            End If

            oArquivo = New FileInfo(Me.Arquivo)
            Pacote = New ExcelPackage(oArquivo)

            'Ajusta cabeçalho
            sCabecalho = sNomeRelatorio & " (" & Format(Now, "dd/MM/yyyy hh:mm:ss") & ")"

            Planilha = Pacote.Workbook.Worksheets.Add(Me.Aba)

            'Planilha.Cells("A1:AB1").Style.Font.Bold = True
            iCol = COLUNA_INICIAL_DADOS

            'Guarda o total de colunas
            iTotalColunasDetalhe = 0

            ''#############################################
            ''#####     FOR pra montar as colunas.    #####
            ''#############################################
            For i = 0 To oDataset.TotalColunas() - 1 'FieldCount() - 1
                strCampo = oDataset.NomeColuna(i)
                'strCampo = Formata_Coluna(strCampo)
                Planilha.Cells(LINHA_CABECALHO_TABELA, iCol).Value = strCampo
                Planilha.Cells(LINHA_CABECALHO_TABELA, iCol).Style.Font.Bold = True
                Planilha.Cells(LINHA_CABECALHO_TABELA, iCol).Style.Fill.PatternType = Style.ExcelFillStyle.Solid
                Planilha.Cells(LINHA_CABECALHO_TABELA, iCol).Style.Fill.BackgroundColor.SetColor(Color.LightGray)
                Planilha.Cells(LINHA_CABECALHO_TABELA, iCol).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Center
                iCol = iCol + 1
                iTotalColunasDetalhe += 1
            Next i

            If bAutoFiltro = True Then
                Planilha.Cells(LINHA_CABECALHO_TABELA, COLUNA_INICIAL_DADOS, LINHA_CABECALHO_TABELA, iCol - 1).AutoFilter = bAutoFiltro
            End If

            If bCongelarPainel = True Then
                Planilha.View.FreezePanes(LINHA_CABECALHO_TABELA + 1, COLUNA_INICIAL_DADOS)
            End If

            iRow = LINHA_CABECALHO_TABELA + 1

            '################################################
            '#####     FOR pra Preencher as colunas.    #####
            '################################################
            For posReg = 0 To (oDataset.TotalRegistros() - 1) Step 1
                iCol = COLUNA_INICIAL_DADOS
                For i = 0 To (oDataset.TotalColunas() - 1)

                    strCampo = oDataset.NomeColuna(i)



                    ValorCampo = oDataset.ValorCampo(i, posReg)

                    Planilha.Cells(iRow, iCol).Value = ValorCampo

                    If (oDataset.TipoDadosColuna(i) Is GetType(Decimal)) Or
                        (oDataset.TipoDadosColuna(i) Is GetType(Integer)) Then
                        Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Right
                    ElseIf (oDataset.TipoDadosColuna(i) Is GetType(DateTime)) Then
                        Planilha.Cells(iRow, iCol).Style.Numberformat.Format = "dd/MM/yyyy"
                        Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Center
                    Else
                        Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Left
                    End If

                    iCol = iCol + 1

                Next i
                iRow = iRow + 1
            Next posReg
            '################################################
            '#####  FIM FOR pra Preencher as colunas.   #####
            '################################################

            'Autoajuste das colunas
            For iCol = COLUNA_INICIAL_DADOS To COLUNA_INICIAL_DADOS + iTotalColunasDetalhe - 1
                Planilha.Column(iCol).AutoFit()
            Next

            'Coloca o cabeçalho do Bradesco
            Planilha.Cells(LINHA_CABECALHO_BRADESCO, COLUNA_INICIAL_DADOS).Value = "BRADESCO"
            Planilha.Cells(LINHA_CABECALHO_BRADESCO, COLUNA_INICIAL_DADOS).Style.Font.Color.SetColor(Color.White)
            Planilha.Cells(LINHA_CABECALHO_BRADESCO, COLUNA_INICIAL_DADOS).Style.Font.Bold = True
            Planilha.Cells(LINHA_CABECALHO_BRADESCO, COLUNA_INICIAL_DADOS).Style.Font.Size = 22

            'Ajuste da Cor da linha de cabeçalho bradesco das colunas
            For iCol = COLUNA_INICIAL_DADOS To COLUNA_INICIAL_DADOS + iTotalColunasDetalhe - 1
                Planilha.Cells(LINHA_CABECALHO_BRADESCO, iCol).Style.Fill.PatternType = Style.ExcelFillStyle.Solid
                Planilha.Cells(LINHA_CABECALHO_BRADESCO, iCol).Style.Fill.BackgroundColor.SetColor(Color.DarkRed)
            Next iCol

            'Coloca o cabeçalho do relatório
            Planilha.Cells(LINHA_CABECALHO_RELATORIO, COLUNA_INICIAL_DADOS).Value = sCabecalho
            AgrupaCelulaTitulo(LINHA_CABECALHO_RELATORIO)
            Planilha.Cells(LINHA_CABECALHO_RELATORIO, COLUNA_INICIAL_DADOS).Style.Font.Bold = True
            Planilha.Cells(LINHA_CABECALHO_RELATORIO, COLUNA_INICIAL_DADOS).Style.Font.Color.SetColor(Color.DarkBlue)
            Planilha.Cells(LINHA_CABECALHO_RELATORIO, COLUNA_INICIAL_DADOS).Style.Font.Size = 16

            If bFundoBradesco = True Then
                Planilha.BackgroundImage.Image = My.Resources.SuperLV
            End If

            Planilha.View.ShowGridLines = bHabilitaGrade
            Pacote.Workbook.Properties.Title = Me.Titulo
            Pacote.Workbook.Properties.Author = Me.Autor
            Pacote.Workbook.Properties.Comments = Me.Comentario
            Pacote.Workbook.Properties.Company = Me.Compania

            Pacote.Workbook.Properties.SetCustomPropertyValue("Criado em", Now.ToString)

            Pacote.Save()

            If bAbrir = True Then
                Me.Visualizar()
            End If

            Return True

        Catch ex As Exception
            LogaErro("Erro em SuperXLS::Imprimir: " & ex.Message)
            Return False
        Finally
            Pacote.Dispose()
            Planilha = Nothing
            Pacote = Nothing
        End Try

    End Function

    Public Function ImprimirDSColl(ByVal oDataset As SuperDataSet,
                                   ByVal iLinhaDataset As Integer,
                                   ByVal iColunaDataSet As Integer,
                                   ByVal colDados As Collection,
                                   ByVal sNomeRelatorio As String,
                                   Optional ByVal bAbrir As Boolean = False,
                                   Optional ByVal bFundoBradesco As Boolean = True,
                                   Optional ByVal bHabilitaGrade As Boolean = False) As Boolean

        Dim oArquivo As FileInfo
        Dim strCampo As String
        'Dim iLinha As Integer = 1
        'Dim iColuna As Integer = 1
        Dim iRow As Integer
        Dim iCol As Integer
        Dim ValorCampo As Object
        'Dim sCabecalho As String
        Dim iTotalColunasDetalhe As Integer
        Dim sCaminhoRelat As String
        Dim xTemp As sPropriedadeCelula

        Try

            Me.Arquivo = Me.Arquivo & "." & Format(Now, "yyyy.MM.dd-hh.mm.ss") & ".xlsx"

            sCaminhoRelat = Path.Combine(Environment.GetEnvironmentVariable("Temp"), "_RPAD_PRINT")
            ChecaCriaDiretorio(sCaminhoRelat)

            Me.Arquivo = Path.Combine(sCaminhoRelat, Me.Arquivo)

            If ExisteArquivo(Me.Arquivo) Then
                If S_MsgBox("Já existe o arquivo [" & Me.Arquivo & "]." & vbNewLine &
                         "Deseja sobrescrever?.", eBotoes.SimNao, , , eImagens.Interrogacao) = eRet.Nao Then
                    Return False
                Else
                    ApagaArquivo(Me.Arquivo)
                End If
            End If

            oArquivo = New FileInfo(Me.Arquivo)
            Pacote = New ExcelPackage(oArquivo)

            'Ajusta cabeçalho
            'sCabecalho = sNomeRelatorio & " (" & Format(Now, "dd/MM/yyyy hh:mm:ss") & ")"

            Planilha = Pacote.Workbook.Worksheets.Add(Me.Aba)

            'Planilha.Cells("A1:AB1").Style.Font.Bold = True
            iCol = iColunaDataSet

            'Guarda o total de colunas
            iTotalColunasDetalhe = 0

            ''#############################################
            ''#####     FOR pra montar as colunas.    #####
            ''#############################################
            For i = 0 To oDataset.TotalColunas() - 1 'FieldCount() - 1
                strCampo = oDataset.NomeColuna(i)
                If (strCampo.Substring(0, 3) = "as_") Or
                   (strCampo.Substring(0, 3) = "me_") Or
                   (strCampo.Substring(0, 3) = "nu_") Then
                    strCampo = FormataColuna(strCampo)
                    Planilha.Cells(iLinhaDataset, iCol).Value = strCampo
                    Planilha.Cells(iLinhaDataset, iCol).Style.Font.Bold = True
                    Planilha.Cells(iLinhaDataset, iCol).Style.Fill.PatternType = Style.ExcelFillStyle.Solid
                    Planilha.Cells(iLinhaDataset, iCol).Style.Fill.BackgroundColor.SetColor(Color.LightGray)
                    Planilha.Cells(iLinhaDataset, iCol).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Center
                    iCol = iCol + 1
                    iTotalColunasDetalhe += 1
                End If
            Next i

            'If bAutoFiltro = True Then
            'Planilha.Cells(LINHA_CABECALHO_TABELA, COLUNA_INICIAL_DADOS, LINHA_CABECALHO_TABELA, iCol - 1).AutoFilter = bAutoFiltro
            'End If

            'If bCongelarPainel = True Then
            ' Planilha.View.FreezePanes(LINHA_CABECALHO_TABELA + 1, COLUNA_INICIAL_DADOS)
            ' End If

            iRow = iLinhaDataset + 1

            'Dim bBorder = Planilha.Cells(iRow - 1, iColunaDataSet, iRow + oDataset.TotalRegistros() - 1, iColunaDataSet + oDataset.TotalColunas() - 2).Style.Border
            Dim bBorder = Planilha.Cells(iRow - 1, iColunaDataSet, iRow + oDataset.TotalRegistros() - 1, iColunaDataSet + iTotalColunasDetalhe - 1).Style.Border

            bBorder.Bottom.Style = ExcelBorderStyle.Thin
            bBorder.Top.Style = ExcelBorderStyle.Thin
            bBorder.Left.Style = ExcelBorderStyle.Thin
            bBorder.Right.Style = ExcelBorderStyle.Thin


            '################################################
            '#####     FOR pra Preencher as colunas.    #####
            '################################################
            For posReg = 0 To (oDataset.TotalRegistros() - 1) Step 1
                iCol = iColunaDataSet
                For i = 0 To (oDataset.TotalColunas() - 1)

                    strCampo = oDataset.NomeColuna(i)

                    If (strCampo.Substring(0, 3) = "as_") Or
                       (strCampo.Substring(0, 3) = "me_") Or
                       (strCampo.Substring(0, 3) = "nu_") Then


                        If (strCampo.Substring(0, 3) = "me_") Then
                            Planilha.Cells(iRow, iCol).Style.Numberformat.Format = "#,##0.00"
                        End If

                        ValorCampo = oDataset.ValorCampo(i, posReg)

                        Planilha.Cells(iRow, iCol).Value = ValorCampo

                        If (oDataset.TipoDadosColuna(i) Is GetType(Decimal)) Or
                            (oDataset.TipoDadosColuna(i) Is GetType(Integer)) Then
                            Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Right
                        ElseIf (oDataset.TipoDadosColuna(i) Is GetType(DateTime)) Then
                            Planilha.Cells(iRow, iCol).Style.Numberformat.Format = "dd/MM/yyyy"
                            Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Center
                        Else
                            Planilha.Cells(iRow, iCol).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Left
                        End If

                        iCol = iCol + 1
                    End If
                Next i
                iRow = iRow + 1
            Next posReg

            'Se veio algo...
            If Not colDados Is Nothing Then

                '####INICIO LOOP PERCORRE COLLECTION#########################################
                For i = 1 To colDados.Count Step 1

                    xTemp = CType(colDados.Item(i), sPropriedadeCelula)

                    'Pega a coluna maxima com dados
                    If iTotalColunasDetalhe < xTemp.Coluna Then
                        iTotalColunasDetalhe = xTemp.Coluna
                    End If


                    Planilha.Cells(xTemp.Linha, xTemp.Coluna).Value = xTemp.Valor
                    Planilha.Cells(xTemp.Linha, xTemp.Coluna).Style.Font.Color.SetColor(xTemp.Cor)

                    Planilha.Cells(xTemp.Linha, xTemp.Coluna).Style.Font.Size = xTemp.Fonte.Size
                    Planilha.Cells(xTemp.Linha, xTemp.Coluna).Style.Font.Name = xTemp.Fonte.Name
                    Planilha.Cells(xTemp.Linha, xTemp.Coluna).Style.Font.Bold = xTemp.Negrito


                    If xTemp.Numberformat <> "" Then
                        Planilha.Cells(xTemp.Linha, xTemp.Coluna).Style.Numberformat.Format = xTemp.Numberformat
                    End If



                    If xTemp.Alinhamento <> sPropriedadeCelula.eAlinhamento.General Then
                        Planilha.Cells(xTemp.Linha, xTemp.Coluna).Style.HorizontalAlignment = CType(xTemp.Alinhamento, ExcelHorizontalAlignment)
                    End If

                    If xTemp.Titulo = True Then
                        AgrupaCelulaTitulo(xTemp.Linha)
                    End If

                    'Planilha.Cells(xTemp.Linha, xTemp.Coluna).????? = xTemp.TamanhoCelula

                Next i
                '####FIM LOOP PERCORRE COLLECTION#########################################
            End If

            ''Autoajuste das colunas
            For iCol = iColunaDataSet To iColunaDataSet + iTotalColunasDetalhe - 1
                Planilha.Column(iCol).AutoFit()
            Next


            If bFundoBradesco = True Then
                Planilha.BackgroundImage.Image = My.Resources.SuperLV
            End If

            Planilha.View.ShowGridLines = bHabilitaGrade
            Pacote.Workbook.Properties.Title = Me.Titulo
            Pacote.Workbook.Properties.Author = Me.Autor
            Pacote.Workbook.Properties.Comments = Me.Comentario
            Pacote.Workbook.Properties.Company = Me.Compania

            Pacote.Workbook.Properties.SetCustomPropertyValue("Criado em", Now.ToString)

            Pacote.Save()

            If bAbrir = True Then
                Me.Visualizar()
            End If

            Return True

        Catch ex As Exception
            LogaErro("Erro em SuperXLS::Imprimir: " & ex.Message)
            Return False
        Finally
            Pacote.Dispose()
            Planilha = Nothing
            Pacote = Nothing
        End Try

    End Function


    Function NumeroParaColuna(ByVal Numero As Integer) As String
        Try

            Numero = Numero - 1

            If Numero < 0 Or Numero >= 27 * 26 Then
                NumeroParaColuna = "-" 'Invalido, retorna nada
            Else
                If Numero < 26 Then 'uma letra, apenas retorna a letra corresp.
                    NumeroParaColuna = Chr(Numero + 65)
                Else 'duas letras, obtem letra baseado no modulo e divisao de inteiro
                    NumeroParaColuna = Chr(Numero \ 26 + 64) + Chr(Numero Mod 26 + 65)
                End If
            End If
        Catch ex As Exception
            LogaErro("Erro em SuperXLS::NumeroParaColuna: " & ex.Message)
            Return ""
        End Try
    End Function

    Sub Visualizar()
        Process.Start(Me.Arquivo)
    End Sub


    Private Function FormataColunaImp(ByVal sString As String,
                                      Optional ByVal id As Integer = 0) As String


        Try

            sString = sString.Substring(3, sString.Length - 3)
            sString = sString.Replace("_", " ")

            Return sString

        Catch ex As Exception
            LogaErro("Erro em Util::Formata_Coluna: " & ex.ToString())
            Return ""
        End Try

    End Function


    'se id <> 0, a coluna eh do tipo id_ (codigo)
    Private Function FormataColuna(ByVal sString As String,
                                    Optional ByVal id As Integer = 0) As String
        Try
            Dim nCerquilha As Integer
            Dim sstring2 As String

            If id = 0 Then
                sstring2 = Replace(xRight(sString, Len(sString) - 3), "_", " ")
            Else
                sstring2 = xRight(sString, Len(sString) - 3)
            End If

            nCerquilha = InStr(sstring2, "#")

            If nCerquilha > 0 Then
                sstring2 = xLeft(sstring2, nCerquilha - 1)
            End If

            Return sstring2
        Catch ex As Exception
            LogaErro("Erro em Util::Formata_Coluna: " & ex.ToString())
            Return ""
        End Try

    End Function

    Public Function xRight(ByVal s As String, ByVal n As Integer) As String
        If n > s.Length Then
            Return s
        ElseIf n < 1 Then
            Return ""
        Else
            Return s.Substring(s.Length - n, n)
        End If
    End Function

    Public Function xLeft(ByVal s As String, ByVal n As Integer) As String
        If n > s.Length Then
            Return s
        ElseIf n < 1 Then
            Return ""
        Else
            Return s.Substring(0, n)
        End If
    End Function

    Private Sub AgrupaCelulaTitulo(ByVal linha As Integer)

        Dim posColLinhaInicial As String
        Dim posColunaFinal As String
        Try

            ' retorna a coluna e linha do titulo(A1).
            posColLinhaInicial = Planilha.Dimension.Start.Address.ToString
            ' retorna a última coluna preenchida no excel(A).
            posColunaFinal = ConLetra(Planilha.Dimension.End.Column)
            'posColunaFinal = Planilha.Dimension.End.Address.First.ToString'' não pega coluna com dua ou mais letra AA, AAA, etc
            'Planilha.Cells("A1:A2").Merge = True
            Planilha.Cells(posColLinhaInicial & ":" & posColunaFinal & CStr(linha)).Merge = True
            Planilha.Cells(posColLinhaInicial & ":" & posColunaFinal & CStr(linha)).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Center


        Catch ex As Exception
            LogaErro("Erro em SuperXLS::AgrupaCelulaTitulo: " & ex.Message)
        End Try
    End Sub

    Private Sub AgrupaCelulaTitulo2(ByVal linha As Integer)

        Dim posColLinhaInicial As String
        Dim posColunaFinal As String
        Try

            ' retorna a coluna e linha do titulo(A1).
            posColLinhaInicial = ConLetra(Planilha.Dimension.Start.Column)
            ' retorna a última coluna preenchida no excel(A).
            posColunaFinal = ConLetra(Planilha.Dimension.End.Column)
            'posColunaFinal = Planilha.Dimension.End.Address.First.ToString'' não pega coluna com dua ou mais letra AA, AAA, etc
            'Planilha.Cells("A1:A2").Merge = True
            Planilha.Cells(posColLinhaInicial & CStr(linha) & ":" & posColunaFinal & CStr(linha)).Merge = True
            Planilha.Cells(posColLinhaInicial & CStr(linha) & ":" & posColunaFinal & CStr(linha)).Style.HorizontalAlignment = Style.ExcelHorizontalAlignment.Center


        Catch ex As Exception
            LogaErro("Erro em SuperXLS::AgrupaCelulaTitulo: " & ex.Message)
        End Try
    End Sub
    Protected Overrides Sub Finalize()

        If Not Pacote Is Nothing Then
            Pacote.Dispose()
        End If
        Pacote = Nothing

        Planilha = Nothing

        MyBase.Finalize()

        Lixeiro()

    End Sub

    Public Sub Lixeiro()
        GC.SuppressFinalize(Me)
        GC.Collect()
    End Sub

    Public Enum eStatusFianca
        DESCONHECIDO = 0
        ATIVO = 1
        BAIXADA = 2
    End Enum

    Public Function GerarPlanilhaFluxoComissao(ByVal rsDadosRegAtual As SuperDataSet,
                                               ByVal rsCobranca As SuperDataSet,
                                               Optional bAbrir As Boolean = True) As Boolean


        Dim oArquivo As FileInfo
        Dim strCampo As String
        Dim iRow As Integer = 1
        Dim iCol As Integer = 1
        Dim ValorCampo As Object = New Object()
        Dim sCabecalho As String
        Dim iTotalColunasDetalhe As Integer
        Dim sCaminhoRelat As String
        Dim bAtivo As Boolean


        Dim iLinhaDataset As Integer = 0 '16
        Dim iColunaDataSet As Integer = 1


        Dim sNomeRelatorio As String = "xxx"
        Dim tp As String

        Dim iLinhaAtual As Integer = 0


        Try

            Me.Arquivo = Me.Arquivo &
                        Now.Year().ToString("0000") &
                        Now.Month().ToString("00") &
                        Now.Day().ToString("00") & "_" &
                        Now.Hour().ToString("00") &
                        Now.Minute().ToString("00") &
                        Now.Second().ToString("00") &
                        ".xlsx"

            sCaminhoRelat = Path.Combine(Environment.GetEnvironmentVariable("Temp"), "_RPAD_PRINT")
            ChecaCriaDiretorio(sCaminhoRelat)
            Me.Arquivo = Path.Combine(sCaminhoRelat, Me.Arquivo)

            If ExisteArquivo(Me.Arquivo) Then
                If S_MsgBox("Já existe o arquivo [" & Me.Arquivo & "]." & vbNewLine &
                         "Deseja sobrescrever?.", eBotoes.SimNao, , , eImagens.Interrogacao) = eRet.Nao Then
                    Return False
                Else
                    ApagaArquivo(Me.Arquivo)
                End If
            End If

            oArquivo = New FileInfo(Me.Arquivo)
            Pacote = New ExcelPackage(oArquivo)

            'Ajusta cabeçalho
            sCabecalho = "FLUXO DE COMISSÃO DE FIANÇA" 'sNomeRelatorio & " (" & Format(Now, "dd/MM/yyyy hh:mm:ss") & ")"


            Planilha = Pacote.Workbook.Worksheets.Add(CDec(rsDadosRegAtual("cNumFianca")).ToString("0,000,000"))

            Planilha.View.ShowGridLines = False

            'CABECALHO
            Planilha.Column(1).Width = CorrigeWidth(21.43)
            Planilha.Column(2).Width = CorrigeWidth(16.57)
            Planilha.Column(3).Width = CorrigeWidth(6.71)
            Planilha.Column(4).Width = CorrigeWidth(11.86)
            Planilha.Column(5).Width = CorrigeWidth(11.86)
            Planilha.Column(6).Width = CorrigeWidth(9.71)
            Planilha.Column(7).Width = CorrigeWidth(12.57)
            Planilha.Column(8).Width = CorrigeWidth(20.29)

            '16
            Planilha.Cells(1, 1, rsCobranca.TotalRegistros + 16, 8).Style.Fill.PatternType = ExcelFillStyle.Solid
            Planilha.Cells(1, 1, rsCobranca.TotalRegistros + 16, 8).Style.Fill.BackgroundColor.SetColor(Color.White)

            'FLUXO DE COMISSÃO DE FIANÇA				
            Planilha.Cells(1, 1, 1, 8).Merge = True
            CelulaDetalhada(1, 1, "FLUXO DE COMISSÃO DE FIANÇA", "Tahoma", 14, True, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Center)

            Dim rSituacao As String = ""

            bAtivo = False

            Select Case CDec(rsDadosRegAtual("cSituacao"))
                Case eStatusFianca.DESCONHECIDO
                    rSituacao = "DESCONHECIDO"
                Case eStatusFianca.ATIVO
                    rSituacao = "ATIVO"
                    bAtivo = True
                Case eStatusFianca.BAIXADA
                    rSituacao = "BAIXADO"
                Case Else
                    rSituacao = CDec(rsDadosRegAtual("cSituacao")).ToString & " - DESCONHECIDO"
            End Select

            iLinhaAtual = 3

            CelulaDetalhada(iLinhaAtual, 1, "SITUAÇÃO", "Tahoma", 10, True, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            CelulaDetalhada(iLinhaAtual, 2, rSituacao, "Tahoma", 10, True, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            iLinhaAtual += 1

            'AFIANÇADA	            CELEBRETE EMPREENDIMENTOS S.A.                  ok - FIVA0070/FIVA2030
            CelulaDetalhada(iLinhaAtual, 1, "AFIANÇADA", "Tahoma", 10, True, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            CelulaDetalhada(iLinhaAtual, 2, rsDadosRegAtual("rAfiancada").ToString, "Tahoma", 10, False, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            iLinhaAtual += 1

            'BENEFICIÁRIA	        FUNDAÇÃO ECONOMIÁRIOS FEDERAIS - FUNCEF         ok - FIVA0070/FIVA2030
            CelulaDetalhada(iLinhaAtual, 1, "BENEFICIÁRIA", "Tahoma", 10, True, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            CelulaDetalhada(iLinhaAtual, 2, rsDadosRegAtual("rBeneficiaria").ToString, "Tahoma", 10, False, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            iLinhaAtual += 1

            'FIANÇA	                2.061.366                                       ok - FIVA0070/FIVA2030
            CelulaDetalhada(iLinhaAtual, 1, "FIANÇA", "Tahoma", 10, True, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            CelulaDetalhada(iLinhaAtual, 2, CDec(rsDadosRegAtual("cNumFianca")).ToString("0,000,000"), "Tahoma", 10, False, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            iLinhaAtual += 1

            'INICIO	                22/10/2012						                ok - FIVA0070/FIVA2030
            CelulaDetalhada(iLinhaAtual, 1, "INICIO", "Tahoma", 10, True, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            CelulaDetalhada(iLinhaAtual, 2, CDate(rsDadosRegAtual("dtInicFianca")).ToShortDateString, "Tahoma", 10, False, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            iLinhaAtual += 1

            'VENCIMENTO	            11/05/2014						                ok - FIVA0070/FIVA2030
            CelulaDetalhada(iLinhaAtual, 1, "VENCIMENTO", "Tahoma", 10, True, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            CelulaDetalhada(iLinhaAtual, 2, CDate(rsDadosRegAtual("dtVencFianca")).ToShortDateString, "Tahoma", 10, False, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            iLinhaAtual += 1

            'VALOR ORIGINAL	        R$ 20.371.742,16						        ok - FIVA0070/FIVA2030
            CelulaDetalhada(iLinhaAtual, 1, "VALOR ORIGINAL", "Tahoma", 10, True, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            CelulaDetalhada(iLinhaAtual, 2, "R$ " & CDec(rsDadosRegAtual("vFiancaOrig")).ToString("0,000.00"), "Tahoma", 10, False, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            iLinhaAtual += 1

            'VALOR ATUAL							                                ok - FIVA0070/FIVA2030
            CelulaDetalhada(iLinhaAtual, 1, "VALOR ATUAL", "Tahoma", 10, True, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            CelulaDetalhada(iLinhaAtual, 2, "R$ " & CDec(rsDadosRegAtual("vFiancaAtual")).ToString("0,000.00"), "Tahoma", 10, False, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            iLinhaAtual += 1

            'COMISSÃO 	            2,20%						                    ok - FIVA0070/FIVA2030
            CelulaDetalhada(iLinhaAtual, 1, "COMISSÃO", "Tahoma", 10, True, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            CelulaDetalhada(iLinhaAtual, 2, CDec(rsDadosRegAtual("TxUtlzd")).ToString("0.00") & "%", "Tahoma", 10, False, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            iLinhaAtual += 1

            'PERIODICIDADE	        Trimestral Antecipada						    OK - 3 campos FIVA2030, join com tPeriodicidade
            CelulaDetalhada(iLinhaAtual, 1, "PERIODICIDADE", "Tahoma", 10, True, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            CelulaDetalhada(iLinhaAtual, 2, rsDadosRegAtual("rPeriodicidade").ToString, "Tahoma", 10, False, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            iLinhaAtual += 1

            'Moeda	                R$						                        OK - JOIN tMoeda
            CelulaDetalhada(iLinhaAtual, 1, "MOEDA", "Tahoma", 10, True, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            CelulaDetalhada(iLinhaAtual, 2, rsDadosRegAtual("rMoeda").ToString, "Tahoma", 10, False, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            iLinhaAtual += 1

            'AGÊNCIA	            2372/Pl. Oper. PJ Paulista						ok - FIVA0070/FIVA2030 Join tAg (sgss)
            CelulaDetalhada(iLinhaAtual, 1, "AGÊNCIA", "Tahoma", 10, True, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            CelulaDetalhada(iLinhaAtual, 2, CDec(rsDadosRegAtual("cAg")).ToString("0000"), "Tahoma", 10, False, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            iLinhaAtual += 1

            'C/C	                5.691-P						                    ok - FIVA0070
            CelulaDetalhada(iLinhaAtual, 1, "C/C", "Tahoma", 10, True, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            CelulaDetalhada(iLinhaAtual, 2, CDec(rsDadosRegAtual("cConta")).ToString("000,000") & "-" & rsDadosRegAtual("cDigConta").ToString, "Tahoma", 10, False, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            iLinhaAtual += 1

            'rsCobranca
            iLinhaDataset = iLinhaAtual + 1

            ''#############################################
            ''#####     FOR pra montar as colunas.    #####
            ''#############################################
            For i = 0 To rsCobranca.TotalColunas() - 1 'FieldCount() - 1

                strCampo = rsCobranca.NomeColuna(i)

                tp = strCampo.Substring(0, 3).ToUpper

                strCampo = FormataColunaImp(strCampo)

                Select Case tp
                    Case "AS_", "ME_", "NU_", "DT_"
                        CelulaDetalhada(iLinhaDataset, iCol, strCampo, "Tahoma", 10, True, Color.Blue, Color.FromArgb(192, 192, 192), ExcelHorizontalAlignment.Center)
                        Planilha.Cells(iLinhaDataset, iCol).Style.WrapText = True
                        iCol = iCol + 1
                        iTotalColunasDetalhe += 1
                    Case Else

                End Select

            Next i

            iRow = iLinhaDataset + 1

            ''Dim bBorder = Planilha.Cells(iRow - 1, iColunaDataSet, iRow + oDataset.TotalRegistros() - 1, iColunaDataSet + oDataset.TotalColunas() - 2).Style.Border
            Dim bBorder = Planilha.Cells(iRow - 1, iColunaDataSet, iRow + rsCobranca.TotalRegistros() - 1, iColunaDataSet + iTotalColunasDetalhe - 1).Style.Border
            bBorder.Bottom.Style = ExcelBorderStyle.Thin
            bBorder.Top.Style = ExcelBorderStyle.Thin
            bBorder.Left.Style = ExcelBorderStyle.Thin
            bBorder.Right.Style = ExcelBorderStyle.Thin

            '################################################
            '#####     FOR pra Preencher as linhas.    #####
            '################################################
            For posReg = 0 To (rsCobranca.TotalRegistros() - 1) Step 1

                iCol = iColunaDataSet

                For i = 0 To (rsCobranca.TotalColunas() - 1)

                    strCampo = rsCobranca.NomeColuna(i)

                    tp = strCampo.Substring(0, 3).ToUpper

                    Select Case tp
                        Case "AS_"
                            ValorCampo = rsCobranca.ValorCampo(i, posReg)
                            CelulaDetalhada(iRow, iCol, ValorCampo.ToString, "Tahoma", 10, False, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
                            iCol = iCol + 1
                        Case "ME_"
                            ValorCampo = rsCobranca.ValorCampo(i, posReg)
                            CelulaDetalhada(iRow, iCol, ValorCampo.ToString, "Tahoma", 10, False, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Right, "#,##0.00")
                            iCol = iCol + 1
                        Case "NU_"
                            ValorCampo = rsCobranca.ValorCampo(i, posReg)
                            CelulaDetalhada(iRow, iCol, ValorCampo.ToString, "Tahoma", 10, False, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Center)
                            iCol = iCol + 1
                        Case "DT_"
                            ValorCampo = rsCobranca.ValorCampo(i, posReg)
                            CelulaDetalhada(iRow, iCol, ValorCampo.ToString, "Tahoma", 10, False, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Center, "dd/MM/yyyy")
                            iCol = iCol + 1

                        Case Else

                    End Select

                Next i
                iRow = iRow + 1

            Next posReg

            'Conforme informado pela Carla esta Obs só ocorre quando a fiança estiver Ativa
            If bAtivo = True Then
                Planilha.Cells(iRow, 1, iRow, 8).Merge = True
                CelulaDetalhada(iRow, 1, "Obs.: 10 dias antes do lançamento, o sistema informará no campo ""Lançamentos Futuros"" no extrato de c/c  a data e o valor do débito.", "Tahoma", 10, False, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            End If

            Pacote.Workbook.Properties.Title = Me.Titulo
            Pacote.Workbook.Properties.Author = Me.Autor
            Pacote.Workbook.Properties.Company = Me.Compania
            Pacote.Workbook.Properties.SetCustomPropertyValue("Criado em ", Now.ToString)

            Pacote.Save()

            If bAbrir = True Then
                Me.Visualizar()
            End If

            Return True

        Catch ex As Exception
            LogaErro("Erro em SuperXLS::Imprimir: " & ex.Message)
            Return False
        Finally
            Pacote.Dispose()
            Planilha = Nothing
            Pacote = Nothing
        End Try


    End Function

    Public Enum e_cSttusComis
        AGUARDANDO_PROC = 1
        PAGA = 2
        DEVIDA = 3
        PAGTO_PARCIAL = 4
        PAGTO_SD_ACRESCIDO_DE_MORA = 5
        PREVISTA = 6
    End Enum

    Public Function GerarPlanilhaFluxoComissaoX(ByVal rsDadosRegAtual As SuperDataSet,
                                                ByVal rsCobranca As SuperDataSet,
                                                Optional bAbrir As Boolean = True) As Boolean

        Dim cSttusComis As e_cSttusComis = e_cSttusComis.AGUARDANDO_PROC
        Dim TxUtlzd As Decimal = 0
        Dim cProcFluxoComisCobrPai As Decimal = 0

        Dim oArquivo As FileInfo
        'Dim strCampo As String
        'Dim iRow As Integer = 1
        Dim iCol As Integer = 1
        Dim ValorCampo As Object = New Object()
        Dim sCabecalho As String
        'Dim iTotalColunasDetalhe As Integer
        Dim sCaminhoRelat As String
        Dim bAtivo As Boolean


        Dim iLinhaDataset As Integer = 0 '16
        Dim iColunaDataSet As Integer = 1


        Dim sNomeRelatorio As String = "xxx"
        'Dim tp As String

        Dim iLinhaAtual As Integer = 0


        Try

            Me.Arquivo = Me.Arquivo &
                         Now.Year().ToString("0000") &
                         Now.Month().ToString("00") &
                         Now.Day().ToString("00") & "_" &
                         Now.Hour().ToString("00") &
                         Now.Minute().ToString("00") &
                         Now.Second().ToString("00") &
                         ".xlsx"

            sCaminhoRelat = Path.Combine(Environment.GetEnvironmentVariable("Temp"), "_RPAD_PRINT")
            ChecaCriaDiretorio(sCaminhoRelat)
            Me.Arquivo = Path.Combine(sCaminhoRelat, Me.Arquivo)

            If ExisteArquivo(Me.Arquivo) Then
                If S_MsgBox("Já existe o arquivo [" & Me.Arquivo & "]." & vbNewLine &
                         "Deseja sobrescrever?.", eBotoes.SimNao, , , eImagens.Interrogacao) = eRet.Nao Then
                    Return False
                Else
                    ApagaArquivo(Me.Arquivo)
                End If
            End If

            oArquivo = New FileInfo(Me.Arquivo)
            Pacote = New ExcelPackage(oArquivo)

            'Ajusta cabeçalho
            sCabecalho = "FLUXO DE COMISSÃO DE FIANÇA" 'sNomeRelatorio & " (" & Format(Now, "dd/MM/yyyy hh:mm:ss") & ")"


            Planilha = Pacote.Workbook.Worksheets.Add(CDec(rsDadosRegAtual("cNumFianca")).ToString("0,000,000"))

            Planilha.View.ShowGridLines = False

            'CABECALHO
            Planilha.Column(1).Width = CorrigeWidth(21.43)
            Planilha.Column(2).Width = CorrigeWidth(16.57)
            Planilha.Column(3).Width = CorrigeWidth(6.71)
            Planilha.Column(4).Width = CorrigeWidth(11.86)
            Planilha.Column(5).Width = CorrigeWidth(11.86)
            Planilha.Column(6).Width = CorrigeWidth(9.71)
            Planilha.Column(7).Width = CorrigeWidth(12.57)
            Planilha.Column(8).Width = CorrigeWidth(20.29)

            '16
            Planilha.Cells(1, 1, rsCobranca.TotalRegistros + 16, 8).Style.Fill.PatternType = ExcelFillStyle.Solid
            Planilha.Cells(1, 1, rsCobranca.TotalRegistros + 16, 8).Style.Fill.BackgroundColor.SetColor(Color.White)

            'FLUXO DE COMISSÃO DE FIANÇA				
            Planilha.Cells(1, 1, 1, 8).Merge = True
            CelulaDetalhada(1, 1, "FLUXO DE COMISSÃO DE FIANÇA", "Tahoma", 14, True, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Center)

            Dim rSituacao As String = ""

            bAtivo = False

            Select Case CDec(rsDadosRegAtual("cSituacao"))
                Case eStatusFianca.DESCONHECIDO
                    rSituacao = "DESCONHECIDO"
                Case eStatusFianca.ATIVO
                    rSituacao = "ATIVO"
                    bAtivo = True
                Case eStatusFianca.BAIXADA
                    rSituacao = "BAIXADO"
                Case Else
                    rSituacao = CDec(rsDadosRegAtual("cSituacao")).ToString & " - DESCONHECIDO"
            End Select

            iLinhaAtual = 3

            CelulaDetalhada(iLinhaAtual, 1, "SITUAÇÃO", "Tahoma", 10, True, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            Planilha.Cells(iLinhaAtual, 2, iLinhaAtual, 8).Merge = True
            CelulaDetalhada(iLinhaAtual, 2, rSituacao, "Tahoma", 10, True, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            iLinhaAtual += 1

            'AFIANÇADA	            CELEBRETE EMPREENDIMENTOS S.A.                  ok - FIVA0070/FIVA2030
            CelulaDetalhada(iLinhaAtual, 1, "AFIANÇADA", "Tahoma", 10, True, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            Planilha.Cells(iLinhaAtual, 2, iLinhaAtual, 8).Merge = True
            CelulaDetalhada(iLinhaAtual, 2, rsDadosRegAtual("rAfiancada").ToString, "Tahoma", 10, False, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            iLinhaAtual += 1

            'BENEFICIÁRIA	        FUNDAÇÃO ECONOMIÁRIOS FEDERAIS - FUNCEF         ok - FIVA0070/FIVA2030
            CelulaDetalhada(iLinhaAtual, 1, "BENEFICIÁRIA", "Tahoma", 10, True, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            Planilha.Cells(iLinhaAtual, 2, iLinhaAtual, 8).Merge = True
            CelulaDetalhada(iLinhaAtual, 2, rsDadosRegAtual("rBeneficiaria").ToString, "Tahoma", 10, False, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            iLinhaAtual += 1

            'FIANÇA	                2.061.366                                       ok - FIVA0070/FIVA2030
            CelulaDetalhada(iLinhaAtual, 1, "FIANÇA", "Tahoma", 10, True, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            Planilha.Cells(iLinhaAtual, 2, iLinhaAtual, 8).Merge = True
            CelulaDetalhada(iLinhaAtual, 2, CDec(rsDadosRegAtual("cNumFianca")).ToString("0,000,000"), "Tahoma", 10, True, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            iLinhaAtual += 1

            'INICIO	                22/10/2012						                ok - FIVA0070/FIVA2030
            CelulaDetalhada(iLinhaAtual, 1, "INICIO", "Tahoma", 10, True, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            Planilha.Cells(iLinhaAtual, 2, iLinhaAtual, 8).Merge = True
            CelulaDetalhada(iLinhaAtual, 2, CDate(rsDadosRegAtual("dtInicFianca")).ToShortDateString, "Tahoma", 10, False, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            iLinhaAtual += 1

            'VENCIMENTO	            11/05/2014						                ok - FIVA0070/FIVA2030
            CelulaDetalhada(iLinhaAtual, 1, "VENCIMENTO", "Tahoma", 10, True, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            Planilha.Cells(iLinhaAtual, 2, iLinhaAtual, 8).Merge = True
            CelulaDetalhada(iLinhaAtual, 2, CDate(rsDadosRegAtual("dtVencFianca")).ToShortDateString, "Tahoma", 10, False, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            iLinhaAtual += 1

            'VALOR ORIGINAL	        R$ 20.371.742,16						        ok - FIVA0070/FIVA2030
            CelulaDetalhada(iLinhaAtual, 1, "VALOR ORIGINAL", "Tahoma", 10, True, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            Planilha.Cells(iLinhaAtual, 2, iLinhaAtual, 8).Merge = True
            CelulaDetalhada(iLinhaAtual, 2, "R$ " & CDec(rsDadosRegAtual("vFiancaOrig")).ToString("0,000.00"), "Tahoma", 10, False, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            iLinhaAtual += 1

            'VALOR ATUAL							                                ok - FIVA0070/FIVA2030
            CelulaDetalhada(iLinhaAtual, 1, "VALOR ATUAL", "Tahoma", 10, True, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            Planilha.Cells(iLinhaAtual, 2, iLinhaAtual, 8).Merge = True
            CelulaDetalhada(iLinhaAtual, 2, "R$ " & CDec(rsDadosRegAtual("vFiancaAtual")).ToString("0,000.00"), "Tahoma", 10, False, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            iLinhaAtual += 1

            'COMISSÃO 	            2,20%						                    ok - FIVA0070/FIVA2030
            CelulaDetalhada(iLinhaAtual, 1, "COMISSÃO", "Tahoma", 10, True, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            Planilha.Cells(iLinhaAtual, 2, iLinhaAtual, 8).Merge = True
            CelulaDetalhada(iLinhaAtual, 2, CDec(rsDadosRegAtual("TxUtlzd")).ToString("0.00") & "%", "Tahoma", 10, False, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            iLinhaAtual += 1

            'PERIODICIDADE	        Trimestral Antecipada						    OK - 3 campos FIVA2030, join com tPeriodicidade
            CelulaDetalhada(iLinhaAtual, 1, "PERIODICIDADE", "Tahoma", 10, True, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            Planilha.Cells(iLinhaAtual, 2, iLinhaAtual, 8).Merge = True
            CelulaDetalhada(iLinhaAtual, 2, rsDadosRegAtual("rPeriodicidade").ToString, "Tahoma", 10, False, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            iLinhaAtual += 1

            'Moeda	                R$						                        OK - JOIN tMoeda
            CelulaDetalhada(iLinhaAtual, 1, "MOEDA", "Tahoma", 10, True, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            Planilha.Cells(iLinhaAtual, 2, iLinhaAtual, 8).Merge = True
            CelulaDetalhada(iLinhaAtual, 2, rsDadosRegAtual("rMoeda").ToString, "Tahoma", 10, False, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            iLinhaAtual += 1

            'AGÊNCIA	            2372/Pl. Oper. PJ Paulista						ok - FIVA0070/FIVA2030 Join tAg (sgss)
            CelulaDetalhada(iLinhaAtual, 1, "AGÊNCIA", "Tahoma", 10, True, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            Planilha.Cells(iLinhaAtual, 2, iLinhaAtual, 8).Merge = True
            CelulaDetalhada(iLinhaAtual, 2, CDec(rsDadosRegAtual("cAg")).ToString("0000"), "Tahoma", 10, False, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            iLinhaAtual += 1

            'C/C	                5.691-P						                    ok - FIVA0070
            CelulaDetalhada(iLinhaAtual, 1, "C/C", "Tahoma", 10, True, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            Planilha.Cells(iLinhaAtual, 2, iLinhaAtual, 8).Merge = True
            CelulaDetalhada(iLinhaAtual, 2, CDec(rsDadosRegAtual("cConta")).ToString("000,000") & "-" & rsDadosRegAtual("cDigConta").ToString, "Tahoma", 10, False, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            iLinhaAtual += 1

            'rsCobranca
            iLinhaDataset = iLinhaAtual + 1


            'Cabeçalho dos detalhes...
            CelulaDetalhada(iLinhaDataset, 1, "Data Prevista de Cobrança", "Tahoma", 10, True, Color.Blue, Color.FromArgb(192, 192, 192), ExcelHorizontalAlignment.Center)
            CelulaDetalhada(iLinhaDataset, 2, "Saldo da Fiança", "Tahoma", 10, True, Color.Blue, Color.FromArgb(192, 192, 192), ExcelHorizontalAlignment.Center)
            CelulaDetalhada(iLinhaDataset, 3, "Taxa", "Tahoma", 10, True, Color.Blue, Color.FromArgb(192, 192, 192), ExcelHorizontalAlignment.Center)

            Planilha.Cells(iLinhaDataset, 4, iLinhaDataset, 5).Merge = True
            CelulaDetalhada(iLinhaDataset, 4, "Periodo", "Tahoma", 10, True, Color.Blue, Color.FromArgb(192, 192, 192), ExcelHorizontalAlignment.Center)

            CelulaDetalhada(iLinhaDataset, 6, "Prazo", "Tahoma", 10, True, Color.Blue, Color.FromArgb(192, 192, 192), ExcelHorizontalAlignment.Center)
            CelulaDetalhada(iLinhaDataset, 7, "Comissão", "Tahoma", 10, True, Color.Blue, Color.FromArgb(192, 192, 192), ExcelHorizontalAlignment.Center)
            CelulaDetalhada(iLinhaDataset, 8, "Status", "Tahoma", 10, True, Color.Blue, Color.FromArgb(192, 192, 192), ExcelHorizontalAlignment.Center)

            iLinhaDataset = iLinhaDataset + 1

            Dim LinhaInicialQuadrado As Decimal = 0
            Dim totReg As Integer = 0
            Dim i As Integer

            totReg = rsCobranca.TotalRegistros()
            '####################################################
            '#####     FOR pra montar os dados do recordset #####
            '####################################################
            For i = 0 To totReg - 1 'FieldCount() - 1

                'cSttus,
                'cProcFluxoComisCobrPai()

                'igual = nao mudou
                'diferente = mudou...

                If cProcFluxoComisCobrPai <> CDec(rsCobranca("cProcFluxoComisCobrPai", i)) Then
                    LinhaInicialQuadrado = iLinhaDataset
                End If

                cSttusComis = CType(rsCobranca("cSttus", i), e_cSttusComis)

                If cSttusComis <> e_cSttusComis.PAGTO_PARCIAL Then
                    CelulaDetalhada(iLinhaDataset, 1, rsCobranca("dtPrevtCobr", i).ToString, "Tahoma", 10, False, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Center)
                End If

                If cSttusComis = e_cSttusComis.PAGA Or
                   cSttusComis = e_cSttusComis.DEVIDA Or
                   cSttusComis = e_cSttusComis.PREVISTA Then

                    If IsDBNull(rsCobranca("vSldFianca", i)) = False Then
                        CelulaDetalhada(iLinhaDataset, 2, CDec(rsCobranca("vSldFianca", i)).ToString("#,##0.00"), "Tahoma", 10, False, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Right)
                    End If

                    If IsDBNull(rsCobranca("TxUtlzd", i)) = False Then
                        TxUtlzd = CDec(rsCobranca("TxUtlzd", i))
                        If TxUtlzd = 999.99 Then
                            TxUtlzd = 0
                        End If
                        CelulaDetalhada(iLinhaDataset, 3, TxUtlzd.ToString("#0.00") & "%", "Tahoma", 10, False, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Center)
                    End If

                    If IsDBNull(rsCobranca("dtPerInic", i)) = False Then CelulaDetalhada(iLinhaDataset, 4, rsCobranca("dtPerInic", i).ToString, "Tahoma", 10, False, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Center)

                    If IsDBNull(rsCobranca("dtPerFnal", i)) = False Then CelulaDetalhada(iLinhaDataset, 5, rsCobranca("dtPerFnal", i).ToString, "Tahoma", 10, False, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Center)

                    If IsDBNull(rsCobranca("nPrz", i)) = False Then CelulaDetalhada(iLinhaDataset, 6, rsCobranca("nPrz", i).ToString, "Tahoma", 10, False, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Center)

                End If

                If IsDBNull(rsCobranca("vComis", i)) = False Then CelulaDetalhada(iLinhaDataset, 7, CDec(rsCobranca("vComis", i)).ToString("#,##0.00"), "Tahoma", 10, False, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Right)
                If IsDBNull(rsCobranca("dsStatus", i)) = False Then CelulaDetalhada(iLinhaDataset, 8, rsCobranca("dsStatus", i).ToString, "Tahoma", 10, False, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
                iLinhaDataset = iLinhaDataset + 1


                'Ver se existe proximo registro
                '    'se nao tiver desenha
                '    'se tiver ver se mudou status
                '    '     se mudou desenha

                If i = totReg - 1 Then 'Ultimo registro



                End If


            Next i

            'iRow = iLinhaDataset + 1
            '
            '''Dim bBorder = Planilha.Cells(iRow - 1, iColunaDataSet, iRow + oDataset.TotalRegistros() - 1, iColunaDataSet + oDataset.TotalColunas() - 2).Style.Border
            'Dim bBorder = Planilha.Cells(iRow - 1, iColunaDataSet, iRow + rsCobranca.TotalRegistros() - 1, iColunaDataSet + iTotalColunasDetalhe - 1).Style.Border
            'bBorder.Bottom.Style = ExcelBorderStyle.Thin
            'bBorder.Top.Style = ExcelBorderStyle.Thin
            'bBorder.Left.Style = ExcelBorderStyle.Thin
            'bBorder.Right.Style = ExcelBorderStyle.Thin
            '
            ''################################################
            ''#####     FOR pra Preencher as linhas.    #####
            ''################################################
            'For posReg = 0 To (rsCobranca.TotalRegistros() - 1) Step 1
            '
            '    iCol = iColunaDataSet
            '
            '    For i = 0 To (rsCobranca.TotalColunas() - 1)
            '
            '        strCampo = rsCobranca.NomeColuna(i)
            '
            '        tp = strCampo.Substring(0, 3).ToUpper
            '
            '        Select Case tp
            '            Case "AS_"
            '                ValorCampo = rsCobranca.ValorCampo(i, posReg)
            '                CelulaDetalhada(iRow, iCol, ValorCampo.ToString, "Tahoma", 10, False, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            '                iCol = iCol + 1
            '            Case "ME_"
            '                ValorCampo = rsCobranca.ValorCampo(i, posReg)
            '                CelulaDetalhada(iRow, iCol, ValorCampo.ToString, "Tahoma", 10, False, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Right, "#,##0.00")
            '                iCol = iCol + 1
            '            Case "NU_"
            '                ValorCampo = rsCobranca.ValorCampo(i, posReg)
            '                CelulaDetalhada(iRow, iCol, ValorCampo.ToString, "Tahoma", 10, False, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Center)
            '                iCol = iCol + 1
            '            Case "DT_"
            '                ValorCampo = rsCobranca.ValorCampo(i, posReg)
            '                CelulaDetalhada(iRow, iCol, ValorCampo.ToString, "Tahoma", 10, False, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Center, "dd/MM/yyyy")
            '                iCol = iCol + 1
            '
            '            Case Else
            '
            '        End Select
            '
            '    Next i
            '    iRow = iRow + 1
            '
            'Next posReg

            'Conforme informado pela Carla esta Obs só ocorre quando a fiança estiver Ativa
            If bAtivo = True Then
                Planilha.Cells(iLinhaDataset, 1, iLinhaDataset, 8).Merge = True
                CelulaDetalhada(iLinhaDataset, 1, "Obs.: 10 dias antes do lançamento, o sistema informará no campo ""Lançamentos Futuros"" no extrato de c/c  a data e o valor do débito.", "Tahoma", 10, False, Color.Blue, Color.Transparent, ExcelHorizontalAlignment.Left)
            End If

            Pacote.Workbook.Properties.Title = Me.Titulo
            Pacote.Workbook.Properties.Author = Me.Autor
            Pacote.Workbook.Properties.Company = Me.Compania
            Pacote.Workbook.Properties.SetCustomPropertyValue("Criado em ", Now.ToString)

            Pacote.Save()

            If bAbrir = True Then
                Me.Visualizar()
            End If

            Return True

        Catch ex As Exception
            LogaErro("Erro em SuperXLS::Imprimir: " & ex.Message)
            Return False
        Finally
            Pacote.Dispose()
            Planilha = Nothing
            Pacote = Nothing
        End Try


    End Function


    Private Sub CelulaDetalhada(ByVal _nLinha As Integer,
                                ByVal _Coluna As Integer,
                                ByVal _Texto As String,
                                ByVal _Fonte As String,
                                ByVal _TamFonte As Single,
                                ByVal _Negrito As Boolean,
                                ByVal _CorFonte As Color,
                                ByVal _CorFundo As Color,
                                ByVal _Alinhamento As ExcelHorizontalAlignment,
                                Optional ByVal _Formato As String = "")

        Planilha.Cells(_nLinha, _Coluna).Value = _Texto
        Planilha.Cells(_nLinha, _Coluna).Style.Font.Name = _Fonte
        Planilha.Cells(_nLinha, _Coluna).Style.Font.Size = _TamFonte
        Planilha.Cells(_nLinha, _Coluna).Style.Font.Bold = _Negrito
        Planilha.Cells(_nLinha, _Coluna).Style.Font.Color.SetColor(_CorFonte)
        Planilha.Cells(_nLinha, _Coluna).Style.Fill.PatternType = ExcelFillStyle.Solid
        Planilha.Cells(_nLinha, _Coluna).Style.Fill.BackgroundColor.SetColor(_CorFundo)
        Planilha.Cells(_nLinha, _Coluna).Style.WrapText = True

        Planilha.Cells(_nLinha, _Coluna).Style.VerticalAlignment = ExcelVerticalAlignment.Top

        Planilha.Cells(_nLinha, _Coluna).Style.HorizontalAlignment = _Alinhamento

        If _Formato <> "" Then
            Planilha.Cells(_nLinha, _Coluna).Style.Numberformat.Format = _Formato
        End If


    End Sub

    Public Shared Function CorrigeWidth(width As Double) As Double

        'Nao copiei da internet, magina....

        'DEDUCE WHAT THE COLUMN WIDTH WOULD REALLY GET SET TO
        Dim z As Double = 1.0
        If width >= (1 + 2 / 3) Then
            z = Math.Round((Math.Round(7 * (width - 1 / 256), 0) - 5) / 7, 2)
        Else
            z = Math.Round((Math.Round(12 * (width - 1 / 256), 0) - Math.Round(5 * width, 0)) / 12, 2)
        End If

        'HOW FAR OFF? (WILL BE LESS THAN 1)
        Dim errorAmt As Double = width - z

        'CALCULATE WHAT AMOUNT TO TACK ONTO THE ORIGINAL AMOUNT TO RESULT IN THE CLOSEST POSSIBLE SETTING 
        Dim adj As Double = 0.0
        If width >= (1 + 2 / 3) Then
            adj = (Math.Round(7 * errorAmt - 7 / 256, 0)) / 7
        Else
            adj = ((Math.Round(12 * errorAmt - 12 / 256, 0)) / 12) + (2 / 12)
        End If

        'RETURN A SCALED-VALUE THAT SHOULD RESULT IN THE NEAREST POSSIBLE VALUE TO THE TRUE DESIRED SETTING
        If z > 0 Then
            Return width + adj
        End If

        Return 0.0

    End Function


End Class
