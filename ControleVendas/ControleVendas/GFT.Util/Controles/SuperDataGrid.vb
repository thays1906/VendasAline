Option Explicit On
Option Strict On

Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Public Class SuperDataGridView
    Inherits DataGridView

    Public ultimaRow As Integer = 0

    Public bCarregado As Boolean = False
    Public bImage As Boolean = False
    Private ID As String = Nothing
    Private btnEditar As Boolean = False
    Private btnExcluir As Boolean = False

    'Cores de Seleção backgroundColor/textColor
    Private bgCorSelecionado As Color = SystemColors.ControlDarkDark
    Private ColorTextSelecionado As Color = Color.White
    Private bgCorNaoSelecionado As Color = SystemColors.ButtonFace
    Private ColorTextNaoSelecionado As Color = Color.Black

    'BackgroundColor DataGrid
    Private bgColor As Color = Color.White

    'ColumnCheckBox
    Private checkbox As DataGridViewCheckBoxColumn
    Public bChkBox As Boolean


    'Cabeçalho
    Private bgColorHeader As Color = Color.LightSlateGray
    Private fontText As Font = New Font("Verdana", 12)
    Private colorText As Color = Color.White

#Region "Propriedades"

    Public Property CorDoFundoCabeçalho As Color
        Get
            Return bgColorHeader

        End Get
        Set(value As Color)
            bgColorHeader = value
        End Set
    End Property

    Public Property CorTextoCabeçalho As Color
        Get
            Return colorText
        End Get
        Set(value As Color)
            colorText = value
        End Set
    End Property
    <Description("Adiciona uma coluna com CheckBox")>
    Public Property AdicionarCheckBox As Boolean

        Get
            Return bChkBox

        End Get
        Set(value As Boolean)
            bChkBox = value
            AdicionaCheckBoxColumn()
            Me.Invalidate()
        End Set
    End Property
#End Region

    Sub New()
        Me.MultiSelect = True
        Me.AllowUserToAddRows = False

        Me.EnableHeadersVisualStyles = False
        Me.Anchor = (AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Bottom)


        'Define a distribuição das colunas no DataGrid
        Me.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill     'Redimensiona as colunas para ocupar todo o DatGrid
        Me.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells 'Redimensiona as rows
        Me.SelectionMode = DataGridViewSelectionMode.FullRowSelect        'Select row inteira

        'Define a borda/grade das colunas
        Me.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        Me.BackgroundColor = bgColor

        'Style Columns
        Me.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.ColumnHeadersDefaultCellStyle.BackColor = bgColorHeader
        Me.ColumnHeadersDefaultCellStyle.Font = fontText
        Me.ColumnHeadersDefaultCellStyle.ForeColor = colorText
        Me.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.SteelBlue
        Me.ColumnHeadersDefaultCellStyle.SelectionForeColor = SystemColors.HighlightText

        'Style Rows
        Me.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken
        Me.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal
        Me.BorderStyle = BorderStyle.None
        Me.DefaultCellStyle.BackColor = SystemColors.ButtonFace
        Me.DefaultCellStyle.ForeColor = Color.Black
        Me.DefaultCellStyle.Font = fontText
        Me.DefaultCellStyle.SelectionBackColor = SystemColors.ControlDarkDark
        Me.DefaultCellStyle.SelectionForeColor = Color.White
        Me.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.RowHeadersVisible = False


        'If Me.bChkBox Then
        '    AdicionaCheckBoxColumn()
        'End If

    End Sub

    Private Sub AdicionaCheckBoxColumn(Optional remove As Boolean = False)
        Dim list = New List(Of DataGridViewCheckBoxColumn)
        Try
            'Adiciona uma coluna de checkbox no DataGrid.
            If bChkBox = True Then
                If remove Then
                    'Tratamento de erro (caso gere mais de uma column)

                    For Each check As DataGridViewCheckBoxColumn In
                        Me.Columns.OfType(Of System.Windows.Forms.DataGridViewCheckBoxColumn)

                        If check.Name <> "chkDataGrid" Then
                            list.Add(check)
                        End If

                    Next

                    For Each chk In list

                        Me.Columns.Remove(chk)

                    Next
                End If

                If Not Me.Columns.Contains(checkbox) Then

                    checkbox = New DataGridViewCheckBoxColumn()
                    checkbox.Name = "chkDataGrid"
                    checkbox.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                    checkbox.HeaderText = "Selecionar"
                    checkbox.Width = 50
                    checkbox.DisplayIndex = 0
                    checkbox.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Me.Columns.Add(checkbox)

                End If

                'Me.Rows.Add()

                'Else
                '    'Me.Columns.Remove(checkbox)
                '    checkbox.Name = "chkDataGrid"
                '    checkbox.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                '    checkbox.HeaderText = "Selecionar"
                '    checkbox.DisplayIndex = 0

                '    Me.Columns.Add(checkbox)


            ElseIf bChkBox = False Then
                'Remove column checkbox quando altera a propriedade no Design
                Me.Columns.Remove(checkbox)
            End If



        Catch ex As Exception
            LogaErro("Erro em Util::AdicionaCheckBoxColumn: " & ex.ToString())
        Finally
            If Not checkbox Is Nothing Then
                checkbox.Dispose()
            End If
        End Try
    End Sub

    Public Sub PreencheDataGrid(ByVal oDataSet As SuperDataSet,
                                Optional ByVal nTable As Integer = 0,
                                Optional ByVal posicaoId As Integer = Nothing,
                                Optional ByRef letreiro As SuperLetreiro = Nothing,
                                Optional ByVal txtHeaderCheck As String = Nothing,
                                Optional removeTxtColumnImg As Boolean = False)

        Dim column As String = Nothing
        Dim width As Integer = Nothing
        Try

            Me.DoubleBuffered = True
            Dim a = Me.Rows.Count
            If a <> 0 Then
                Dim linha = Me.Rows(0)
                Me.Rows.Remove(linha)
            End If


            For i = 0 To oDataSet.TotalColunas - 1

                column = oDataSet.NomeColuna(i, nTable)

                If column.Substring(0, 3) = "as_" Or
                       column.Substring(0, 3) = "me_" Or
                       column.Substring(0, 3) = "nu_" Then

                    column = column.Substring(3)
                    If column.Contains("#") Then
                        width = CInt(column.Substring(column.IndexOf("#") + 1))
                        column = column.Substring(0, column.IndexOf("#"))
                    End If
                    If column.Contains("_") Then
                        column = column.Replace("_", " ")
                    End If

                ElseIf column.Substring(0, 3) = "id_" Then
                    ID = column
                End If

                oDataSet.Tables(0).Columns(i).ColumnName = column
                Me.DataSource = oDataSet.Tables(0)

                If width <> Nothing Then
                    Me.Columns(column).Width = width

                    Me.Columns(column).FillWeight = width
                End If

                If bChkBox Then

                    'Se escolheu adicionar coluna com checkbox, ignora o text do cabeçalho primeira coluna.
                    If CInt(Me.Columns.OfType(Of System.Windows.Forms.DataGridViewCheckBoxColumn).Count) > 1 Then
                        AdicionaCheckBoxColumn(True)
                    End If

                    'If column <> Nothing Then
                    '    If Not column.Contains("id_") Then
                    '        Me.Columns(i + 1).HeaderText = column
                    '    End If
                    'End If

                Else
                    If column <> Nothing Then
                        Me.Columns(i).HeaderText = column
                    End If
                End If

                bCarregado = False

            Next

            'Chamando o evento DataBindingComplete (DataGrid está carregado)
            bCarregado = True
            SuperDataGridView_DataBindingComplete(New EventArgs(), New DataGridViewBindingCompleteEventArgs(ListChangedType.ItemChanged))

            If ID Is Nothing Then
                'Se não encontrou coluna 'id_' no dataSet.
                'Verifica se foi informado no parâmetro.

                If posicaoId <> Nothing Then

                    ID = posicaoId.ToString

                    Me.Columns(ID).Visible = False
                End If

            Else
                Me.Columns(ID).Visible = False
            End If


            If bChkBox Then
                If txtHeaderCheck Is Nothing Then
                    'Removendo texto da coluna checkbox
                    Me.Columns("chkDataGrid").HeaderText = ""
                Else
                    Me.Columns("chkDataGrid").HeaderText = txtHeaderCheck

                End If
            End If

            If bImage Then

                If removeTxtColumnImg Then

                    'Remove text da coluna de imagens

                    For Each col As DataGridViewImageColumn In Me.Columns.OfType(Of DataGridViewImageColumn)

                        col.HeaderText = ""
                    Next

                End If

            End If

            If Not letreiro Is Nothing Then
                letreiro.TextoLetreiro = oDataSet.InfoPesquisa
            End If

            If oDataSet.TotalRegistros = 0 Then
                LogaErro("SuperLV::PreencheDataGrid [" & Me.Name & "] - ATENÇÃO: RecordSet=Nothing, por favor, verifique.")
                Exit Sub
            End If


            'Me.Refresh()

        Catch ex As Exception
            LogaErro("Erro em Util::PreencheDataGrid: " & ex.ToString())
        End Try
    End Sub

    Public Function ObterTodasChaves() As String 'bCarregado
        Dim rChave As String = Nothing
        Try

            For Each x As DataGridViewRow In Me.SelectedRows
                rChave += String.Concat(x.Cells(ID).Value.ToString, ";")
            Next

            rChave = rChave.Substring(0, rChave.LastIndexOf(";"))



            Return rChave

        Catch ex As Exception
            LogaErro("Erro em Util::ObterTodasChaves: " & ex.ToString())
            Return Nothing
        End Try

    End Function
    Public Function ObterChave() As Decimal 'bCarregado
        Dim cChave As Decimal = Nothing
        Try

            For Each item As DataGridViewRow In Me.Rows

                If CBool(item.Selected) = True Then

                    cChave = CDec(item.Cells(ID).Value)

                    Exit For

                End If
            Next

            Return cChave

        Catch ex As Exception
            LogaErro("Erro em Util::ObterChave: " & ex.ToString())
            Return Nothing
        End Try
    End Function

    Public Sub AdicionaImageColumn(ByRef oDataset As SuperDataSet,
                                   ByVal column As String,
                                   ByVal img As Bitmap,
                                   Optional imgIgual As Boolean = True,
                                   Optional totalCol As Integer = 1)

        Dim image As ImageConverter
        Dim dataRow As DataRow
        Static col As Integer = Nothing
        Try
            bImage = True

            image = New ImageConverter()

            'Adiciona uma coluna do tipo ImageColumn no DataSet (antes de carregar o DataGrid )

            If Not CBool(oDataset.Tables(0).Columns.Contains(column)) Then
                ultimaRow = 0
                oDataset.Tables(0).Columns.Add(column, System.Type.GetType("System.Byte[]"))

            End If

            If imgIgual Then
                For Each linha As DataRow In oDataset.Tables(0).Rows

                    'Seta a mesma Imagem em todas colunas.

                    linha(column) = image.ConvertTo(img, System.Type.GetType("System.Byte[]"))

                Next

            Else
                If totalCol = 1 Then
                    For i = ultimaRow To oDataset.TotalRegistros - 1
                        'Seta uma Image por linha.

                        dataRow = oDataset.Tables(0).Rows(i)

                        dataRow(column) = image.ConvertTo(img, System.Type.GetType("System.Byte[]"))

                        ultimaRow += 1

                        Exit For
                    Next
                Else
                    For i = ultimaRow To oDataset.TotalRegistros - 1
                        'Seta uma Image por linha.
                        col += 1
                        If totalCol = col Then
                            col = 0
                            ultimaRow += 1

                        Else
                            ultimaRow = ultimaRow
                        End If

                        dataRow = oDataset.Tables(0).Rows(i)

                        dataRow(column) = image.ConvertTo(img, System.Type.GetType("System.Byte[]"))


                        Exit For
                    Next
                End If
            End If



        Catch ex As Exception
            LogaErro("Erro em Util::AdicionaImgColumn: " & ex.ToString())
        End Try
    End Sub


    Public Sub MarcaDesmarcaTodos(ByRef chkTodos As CheckBox) 'bCarregado
        Try
            'Seleciona/ Desmarca todos os CheckBox do DataGRid
            If Me.MultiSelect Then

                If Me.Rows.Count > 0 Then


                    If chkTodos.Checked Then

                        If Me.SelectedRows.Count = Me.Rows.Count Then

                            For i = 0 To Rows.Count - 1

                                Me.Rows(i).Selected = False
                                Me.Rows(i).DefaultCellStyle.BackColor = bgCorNaoSelecionado
                                Me.Rows(i).DefaultCellStyle.ForeColor = ColorTextNaoSelecionado

                                If bChkBox Then
                                    Me.Rows(i).Cells(0).Value = False
                                End If

                            Next
                            chkTodos.Checked = False
                        Else

                            For i = 0 To Me.Rows.Count - 1

                                Me.Rows(i).Selected = True

                                If bChkBox Then
                                    Me.Rows(i).Cells(0).Value = True
                                End If
                            Next
                        End If

                    Else
                        For i = 0 To Me.Rows.Count - 1
                            Me.Rows(i).Selected = False
                            Me.Rows(i).DefaultCellStyle.BackColor = bgCorNaoSelecionado
                            Me.Rows(i).DefaultCellStyle.ForeColor = ColorTextNaoSelecionado

                            If bChkBox Then
                                Me.Rows(i).Cells(0).Value = False
                            End If
                        Next


                        Me.ClearSelection()
                    End If
                End If
            End If

        Catch ex As Exception
            LogaErro("Erro em Util::SelecionaTodosCheck: " & ex.ToString())
        End Try
    End Sub

    Private Sub SelectRowLeave_CheckBox(sender As Object, e As DataGridViewCellEventArgs) Handles Me.RowLeave 'bCarregado

        Try
            'Mantém a linha selecionada, quando clicar em outra linha.
            If bCarregado Then

                If bChkBox Then

                    If Me.MultiSelect Then

                        If CBool(Me.Rows(e.RowIndex).Cells("chkDatagrid").Value) = True Then

                            Me.Rows(e.RowIndex).Selected = True
                            Me.Rows(e.RowIndex).DefaultCellStyle.BackColor = bgCorSelecionado
                            Me.Rows(e.RowIndex).DefaultCellStyle.ForeColor = ColorTextSelecionado
                        End If

                    Else
                        If CBool(Me.Rows(e.RowIndex).Cells("chkDatagrid").Value) = True Then

                            Me.Rows(e.RowIndex).Cells(0).Value = False
                        End If
                    End If
                End If
            End If

        Catch ex As Exception
            LogaErro("Erro em Util::SelectRowLeave_CheckBox: " & ex.ToString())
        End Try
    End Sub

    Public Function ObterTodosChecados() As Decimal
        Dim total As Decimal = 0
        Try
            If bCarregado Then
                OnCurrentCellChanged(EventArgs.Empty)

                For Each row As DataGridViewRow In Me.Rows
                    If row.Selected = True Then
                        total += 1
                    End If
                Next

                Return total

            End If
            Return Nothing
        Catch ex As Exception
            LogaErro("Erro em Util::ObterTodosChecados: " & ex.ToString())
            Return Nothing
        End Try
    End Function

    Public Sub HabilitarDesabilitarEdicao(Optional ByRef SuperEditar As SuperButton = Nothing,
                                          Optional ByRef btnEditar As Button = Nothing)
        Try
            If SuperEditar Is Nothing And btnEditar Is Nothing Then

                LogaErro("SuperDataGridView::HabilitarDesabilitarEditar [" & Me.Name & "] - ATENÇÃO: Nenhum botao informado no parâmetro, por favor, informe.")

            Else
                If SuperEditar IsNot Nothing Then

                    If Me.SelectedRows.Count = 1 Then

                        SuperEditar.Enabled = True
                    Else
                        SuperEditar.Enabled = False

                    End If

                ElseIf btnEditar IsNot Nothing Then

                    If Me.SelectedRows.Count = 1 Then

                        btnEditar.Enabled = True
                    Else
                        btnEditar.Enabled = False

                    End If
                End If
            End If

        Catch ex As Exception
            LogaErro("Erro em Util::HabilitarDesabilitarEdicao: " & ex.ToString())
        End Try
    End Sub
    Public Sub HabilitarDesabilitarExclusao(Optional ByRef SuperExcluir As SuperButton = Nothing,
                                            Optional ByRef btnExcluir As Button = Nothing)
        Try
            If SuperExcluir Is Nothing And btnExcluir Is Nothing Then

                LogaErro("SuperDataGridView::HabilitarDesabilitarExclusao [" & Me.Name & "] - ATENÇÃO: Nenhum botao informado no parâmetro, por favor, informe.")
            Else
                If SuperExcluir IsNot Nothing Then

                    If Me.MultiSelect = True Then
                        If Me.SelectedRows.Count >= 1 Then
                            SuperExcluir.Enabled = True
                        Else
                            SuperExcluir.Enabled = False
                        End If

                    Else
                        If Me.SelectedRows.Count = 1 Then
                            SuperExcluir.Enabled = True
                        Else
                            SuperExcluir.Enabled = False
                        End If

                    End If

                ElseIf btnExcluir IsNot Nothing Then

                    If Me.MultiSelect = True Then

                        If Me.SelectedRows.Count >= 1 Then
                            btnExcluir.Enabled = True
                        Else
                            btnExcluir.Enabled = False
                        End If

                    Else
                        If Me.SelectedRows.Count = 1 Then
                            btnExcluir.Enabled = True
                        Else
                            btnExcluir.Enabled = False
                        End If
                    End If

                End If
            End If
        Catch ex As Exception
            LogaErro("Erro em Util::HabilitarDesabilitarExclusao: " & ex.ToString())
        End Try
    End Sub

    Private Sub SuperDataGridView_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles Me.DataBindingComplete 'bCarregado
        Try
            'Quando o DataGrid estiver carregado, desmarca a linha que estiver selecionada.
            If bCarregado Then
                For i = 0 To Me.Rows.Count - 1

                    If Me.Rows(i).Selected Then

                        If bChkBox Then

                            Me.Rows(i).Cells("chkDataGrid").Value = False

                        End If

                        Me.ClearSelection()

                        'Ativa ReadOnly para todas as células, exceto a coluna do checkbox.
                        'For l = 0 To Me.Columns.Count - 1
                        '    If bChkBox Then
                        '        If Not Me.Columns(l).Name = "chkDataGrid" Then

                        '            Me.Columns(l)..ReadOnly = True
                        '        End If
                        '    Else
                        '        Me.Columns(l).ReadOnly = True
                        '    End If
                        'Next
                    End If
                Next


                ultimaRow = 0
            End If
        Catch ex As Exception
            LogaErro("Erro em Util::SuperDataGridView_DataBindingComplete: " & ex.ToString())
        End Try
    End Sub

    Private Sub SuperDataGridView_CurrentCellChanged(sender As Object, e As EventArgs) Handles Me.CurrentCellChanged 'bCarregado
        Try
            'Caso tenha checkbox no DataGrid, ativa o select na linha que estiver selecionada.
            If bCarregado = True Then

                If bChkBox Then
                    If Me.MultiSelect Then
                        For i = 0 To Me.Rows.Count - 1

                            If CBool(Me.Rows(i).Cells("chkDataGrid").Value) = True Then
                                Me.Rows(i).Selected = True
                            Else
                                Me.Rows(i).Selected = False

                            End If
                        Next
                    End If
                End If
            End If


        Catch ex As Exception
            LogaErro("Erro em Util::SuperDataGridView_CurrentCellChanged: " & ex.ToString())
        End Try
    End Sub

    Private Sub SuperDataGridView_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Me.CellMouseClick 'bCarregado
        Try
            'Seleciona a linha, checkbox, e altera cor da linha selecionada.

            If e.RowIndex <> -1 Then

                'Se o click for com Ctrl pressionado ou sem.


                If Control.ModifierKeys = Keys.Control Or Control.ModifierKeys = Keys.None Then

                    If bChkBox Then

                        If CBool(Me.Rows(e.RowIndex).Cells("chkDataGrid").Value) = False Then

                            Me.Rows(e.RowIndex).Cells("chkDataGrid").Value = True
                            Me.Rows(e.RowIndex).Selected = True

                            Me.Refresh()

                        ElseIf CBool(Me.Rows(e.RowIndex).Cells("chkDataGrid").Value) = True Then
                            Me.ClearSelection()
                            Me.Rows(e.RowIndex).Selected = False
                            Me.Rows(e.RowIndex).Cells("chkDataGrid").Value = False
                            Me.Rows(e.RowIndex).DefaultCellStyle.BackColor = bgCorNaoSelecionado
                            Me.Rows(e.RowIndex).DefaultCellStyle.ForeColor = ColorTextNaoSelecionado
                            Me.Refresh()
                        End If
                    End If
                End If
                If MultiSelect Then
                    SuperDataGridView_CurrentCellChanged(sender, e)
                End If
            End If
        Catch ex As Exception
            LogaErro("Erro em Util::SelecionarCheckBoxDataGrid: " & ex.ToString())
        End Try
    End Sub
    Protected Overrides Sub OnGotFocus(ByVal e As System.EventArgs)
        Try
            MyBase.OnGotFocus(e)
        Catch ex As Exception
            LogaErro("Erro em SuperLV::OnGotFocus: " & CStr(ex.ToString()))
        End Try
    End Sub

    Protected Overrides Sub OnLostFocus(ByVal e As System.EventArgs)
        Try
            MyBase.OnLostFocus(e)
        Catch ex As Exception
            LogaErro("Erro em SuperLV::OnLostFocus: " & CStr(ex.ToString()))
        End Try
    End Sub

    'Private Sub SuperDataGridView_Validated(sender As Object, e As EventArgs) Handles Me.Validated
    '    Try
    '        AdicionaCheckBoxColumn(True)
    '    Catch ex As Exception

    '    End Try
    'End Sub
    Public Function ObterTotalLinhas() As Integer
        Try
            Return Me.Rows.Count

        Catch ex As Exception
            LogaErro("Erro em SuperDataGrid::ObterTotalLinhas: " & CStr(ex.ToString()))
            Return Nothing
        End Try
    End Function
End Class
