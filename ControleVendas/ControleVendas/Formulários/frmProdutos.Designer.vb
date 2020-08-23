<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProdutos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProdutos))
        Me.tabCtrlProduto = New System.Windows.Forms.TabControl()
        Me.tabConsulta = New System.Windows.Forms.TabPage()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.txtLetreiro = New GFT.Util.SuperLetreiro()
        Me.dgProduto = New GFT.Util.SuperDataGridView()
        Me.gbFiltroProduto = New System.Windows.Forms.GroupBox()
        Me.btnLimpaFiltro = New System.Windows.Forms.Button()
        Me.lblTamanho = New System.Windows.Forms.Label()
        Me.cbTamanho = New GFT.Util.SuperComboBox()
        Me.cbCor = New GFT.Util.SuperComboBox()
        Me.lblCor = New System.Windows.Forms.Label()
        Me.txtFiltroProduto = New GFT.Util.SuperTextBox()
        Me.lblFiltroProduto = New System.Windows.Forms.Label()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.imgListProdutos = New System.Windows.Forms.ImageList(Me.components)
        Me.gbBotoes = New System.Windows.Forms.GroupBox()
        Me.btnCadastrar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.tabCtrlProduto.SuspendLayout()
        Me.tabConsulta.SuspendLayout()
        CType(Me.dgProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFiltroProduto.SuspendLayout()
        Me.gbBotoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabCtrlProduto
        '
        Me.tabCtrlProduto.Controls.Add(Me.tabConsulta)
        Me.tabCtrlProduto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabCtrlProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tabCtrlProduto.ImageList = Me.imgListProdutos
        Me.tabCtrlProduto.Location = New System.Drawing.Point(0, 0)
        Me.tabCtrlProduto.Name = "tabCtrlProduto"
        Me.tabCtrlProduto.Padding = New System.Drawing.Point(50, 10)
        Me.tabCtrlProduto.SelectedIndex = 0
        Me.tabCtrlProduto.Size = New System.Drawing.Size(1138, 667)
        Me.tabCtrlProduto.TabIndex = 0
        '
        'tabConsulta
        '
        Me.tabConsulta.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.tabConsulta.Controls.Add(Me.btnExportar)
        Me.tabConsulta.Controls.Add(Me.chkTodos)
        Me.tabConsulta.Controls.Add(Me.txtLetreiro)
        Me.tabConsulta.Controls.Add(Me.dgProduto)
        Me.tabConsulta.Controls.Add(Me.gbFiltroProduto)
        Me.tabConsulta.ImageIndex = 0
        Me.tabConsulta.Location = New System.Drawing.Point(4, 69)
        Me.tabConsulta.Name = "tabConsulta"
        Me.tabConsulta.Padding = New System.Windows.Forms.Padding(3)
        Me.tabConsulta.Size = New System.Drawing.Size(1130, 594)
        Me.tabConsulta.TabIndex = 0
        Me.tabConsulta.Text = "Consulta de Produtos"
        '
        'chkTodos
        '
        Me.chkTodos.AutoSize = True
        Me.chkTodos.Location = New System.Drawing.Point(49, 169)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(188, 29)
        Me.chkTodos.TabIndex = 3
        Me.chkTodos.Text = "Selecionar Todos"
        Me.chkTodos.UseVisualStyleBackColor = True
        '
        'txtLetreiro
        '
        Me.txtLetreiro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtLetreiro.CorSombraTexto = System.Drawing.Color.White
        Me.txtLetreiro.Location = New System.Drawing.Point(40, 554)
        Me.txtLetreiro.Name = "txtLetreiro"
        Me.txtLetreiro.RolagemLetreiro = GFT.Util.SuperLetreiro.Direcao.Esquerda
        Me.txtLetreiro.Size = New System.Drawing.Size(227, 24)
        Me.txtLetreiro.TabIndex = 2
        Me.txtLetreiro.TextoLetreiro = "0,00 Registros"
        Me.txtLetreiro.VelocidadeRolagem = 1
        '
        'dgProduto
        '
        Me.dgProduto.AdicionarCheckBox = True
        Me.dgProduto.AllowUserToAddRows = False
        Me.dgProduto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgProduto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgProduto.BackgroundColor = System.Drawing.Color.White
        Me.dgProduto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgProduto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.dgProduto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.LightSlateGray
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgProduto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgProduto.ColumnHeadersHeight = 50
        Me.dgProduto.CorDoFundoCabeçalho = System.Drawing.Color.LightSlateGray
        Me.dgProduto.CorTextoCabeçalho = System.Drawing.Color.White
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgProduto.DefaultCellStyle = DataGridViewCellStyle14
        Me.dgProduto.EnableHeadersVisualStyles = False
        Me.dgProduto.Location = New System.Drawing.Point(40, 199)
        Me.dgProduto.Name = "dgProduto"
        Me.dgProduto.ReadOnly = True
        Me.dgProduto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgProduto.RowHeadersVisible = False
        Me.dgProduto.RowHeadersWidth = 51
        Me.dgProduto.RowTemplate.Height = 24
        Me.dgProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgProduto.Size = New System.Drawing.Size(1034, 349)
        Me.dgProduto.TabIndex = 1
        '
        'gbFiltroProduto
        '
        Me.gbFiltroProduto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbFiltroProduto.BackColor = System.Drawing.SystemColors.Control
        Me.gbFiltroProduto.Controls.Add(Me.btnLimpaFiltro)
        Me.gbFiltroProduto.Controls.Add(Me.lblTamanho)
        Me.gbFiltroProduto.Controls.Add(Me.cbTamanho)
        Me.gbFiltroProduto.Controls.Add(Me.cbCor)
        Me.gbFiltroProduto.Controls.Add(Me.lblCor)
        Me.gbFiltroProduto.Controls.Add(Me.txtFiltroProduto)
        Me.gbFiltroProduto.Controls.Add(Me.lblFiltroProduto)
        Me.gbFiltroProduto.Controls.Add(Me.btnFiltrar)
        Me.gbFiltroProduto.Location = New System.Drawing.Point(40, 16)
        Me.gbFiltroProduto.Name = "gbFiltroProduto"
        Me.gbFiltroProduto.Size = New System.Drawing.Size(1034, 147)
        Me.gbFiltroProduto.TabIndex = 0
        Me.gbFiltroProduto.TabStop = False
        Me.gbFiltroProduto.Text = "Filtrar"
        '
        'btnLimpaFiltro
        '
        Me.btnLimpaFiltro.Image = Global.ControleVendas.My.Resources.Resources.iconFIlterRemove
        Me.btnLimpaFiltro.Location = New System.Drawing.Point(818, 72)
        Me.btnLimpaFiltro.Name = "btnLimpaFiltro"
        Me.btnLimpaFiltro.Size = New System.Drawing.Size(174, 38)
        Me.btnLimpaFiltro.TabIndex = 7
        Me.btnLimpaFiltro.Text = " &Limpar Filtro"
        Me.btnLimpaFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimpaFiltro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLimpaFiltro.UseVisualStyleBackColor = True
        '
        'lblTamanho
        '
        Me.lblTamanho.AutoSize = True
        Me.lblTamanho.Location = New System.Drawing.Point(284, 52)
        Me.lblTamanho.Name = "lblTamanho"
        Me.lblTamanho.Size = New System.Drawing.Size(96, 25)
        Me.lblTamanho.TabIndex = 6
        Me.lblTamanho.Text = "Tamanho"
        '
        'cbTamanho
        '
        Me.cbTamanho.Alterado = False
        Me.cbTamanho.CorFundo = System.Drawing.Color.White
        Me.cbTamanho.CorFundoSelecionado = System.Drawing.Color.White
        Me.cbTamanho.CorTexto = System.Drawing.Color.Black
        Me.cbTamanho.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbTamanho.FormattingEnabled = True
        Me.cbTamanho.Location = New System.Drawing.Point(289, 77)
        Me.cbTamanho.Name = "cbTamanho"
        Me.cbTamanho.Size = New System.Drawing.Size(133, 33)
        Me.cbTamanho.SuperObrigatorio = False
        Me.cbTamanho.SuperTxtObrigatorio = ""
        Me.cbTamanho.TabIndex = 5
        '
        'cbCor
        '
        Me.cbCor.Alterado = False
        Me.cbCor.CorFundo = System.Drawing.Color.White
        Me.cbCor.CorFundoSelecionado = System.Drawing.Color.White
        Me.cbCor.CorTexto = System.Drawing.Color.Black
        Me.cbCor.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbCor.FormattingEnabled = True
        Me.cbCor.Location = New System.Drawing.Point(434, 77)
        Me.cbCor.Name = "cbCor"
        Me.cbCor.Size = New System.Drawing.Size(198, 33)
        Me.cbCor.SuperObrigatorio = False
        Me.cbCor.SuperTxtObrigatorio = ""
        Me.cbCor.TabIndex = 4
        '
        'lblCor
        '
        Me.lblCor.AutoSize = True
        Me.lblCor.Location = New System.Drawing.Point(429, 52)
        Me.lblCor.Name = "lblCor"
        Me.lblCor.Size = New System.Drawing.Size(44, 25)
        Me.lblCor.TabIndex = 3
        Me.lblCor.Text = "Cor"
        '
        'txtFiltroProduto
        '
        Me.txtFiltroProduto.Alterado = False
        Me.txtFiltroProduto.BackColor = System.Drawing.Color.White
        Me.txtFiltroProduto.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFiltroProduto.Location = New System.Drawing.Point(14, 80)
        Me.txtFiltroProduto.Name = "txtFiltroProduto"
        Me.txtFiltroProduto.Size = New System.Drawing.Size(269, 30)
        Me.txtFiltroProduto.SuperMascara = ""
        Me.txtFiltroProduto.SuperObrigatorio = False
        Me.txtFiltroProduto.SuperTravaErrors = False
        Me.txtFiltroProduto.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtFiltroProduto.SuperTxtObrigatorio = ""
        Me.txtFiltroProduto.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtFiltroProduto.TabIndex = 1
        '
        'lblFiltroProduto
        '
        Me.lblFiltroProduto.AutoSize = True
        Me.lblFiltroProduto.Location = New System.Drawing.Point(9, 52)
        Me.lblFiltroProduto.Name = "lblFiltroProduto"
        Me.lblFiltroProduto.Size = New System.Drawing.Size(80, 25)
        Me.lblFiltroProduto.TabIndex = 0
        Me.lblFiltroProduto.Text = "Produto"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Image = Global.ControleVendas.My.Resources.Resources.iconFilter
        Me.btnFiltrar.Location = New System.Drawing.Point(638, 72)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(174, 38)
        Me.btnFiltrar.TabIndex = 8
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'imgListProdutos
        '
        Me.imgListProdutos.ImageStream = CType(resources.GetObject("imgListProdutos.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgListProdutos.TransparentColor = System.Drawing.Color.Transparent
        Me.imgListProdutos.Images.SetKeyName(0, "iconSapato.png")
        '
        'gbBotoes
        '
        Me.gbBotoes.BackColor = System.Drawing.Color.Transparent
        Me.gbBotoes.Controls.Add(Me.btnCadastrar)
        Me.gbBotoes.Controls.Add(Me.btnExcluir)
        Me.gbBotoes.Controls.Add(Me.btnFechar)
        Me.gbBotoes.Controls.Add(Me.btnEditar)
        Me.gbBotoes.Controls.Add(Me.btnPesquisar)
        Me.gbBotoes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbBotoes.Location = New System.Drawing.Point(0, 667)
        Me.gbBotoes.Name = "gbBotoes"
        Me.gbBotoes.Size = New System.Drawing.Size(1138, 67)
        Me.gbBotoes.TabIndex = 1
        Me.gbBotoes.TabStop = False
        '
        'btnCadastrar
        '
        Me.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrar.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnCadastrar.Image = Global.ControleVendas.My.Resources.Resources.iconAddBlue
        Me.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCadastrar.Location = New System.Drawing.Point(264, 15)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(203, 42)
        Me.btnCadastrar.TabIndex = 4
        Me.btnCadastrar.Text = " &Cadastrar"
        Me.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCadastrar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnExcluir.Image = Global.ControleVendas.My.Resources.Resources.iconExcluir
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExcluir.Location = New System.Drawing.Point(682, 15)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(203, 42)
        Me.btnExcluir.TabIndex = 3
        Me.btnExcluir.Text = " &Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnFechar.Image = Global.ControleVendas.My.Resources.Resources.iconClose
        Me.btnFechar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFechar.Location = New System.Drawing.Point(893, 15)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(203, 42)
        Me.btnFechar.TabIndex = 2
        Me.btnFechar.Text = " &Fechar"
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnEditar.Image = Global.ControleVendas.My.Resources.Resources.iconEditar
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEditar.Location = New System.Drawing.Point(473, 15)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(203, 42)
        Me.btnEditar.TabIndex = 1
        Me.btnEditar.Text = " &Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPesquisar.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnPesquisar.Image = Global.ControleVendas.My.Resources.Resources.iconePesquisar
        Me.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPesquisar.Location = New System.Drawing.Point(55, 15)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(203, 42)
        Me.btnPesquisar.TabIndex = 0
        Me.btnPesquisar.Text = " &Pesquisar"
        Me.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportar.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnExportar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnExportar.FlatAppearance.BorderSize = 2
        Me.btnExportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.btnExportar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportar.Image = Global.ControleVendas.My.Resources.Resources.iconExcel
        Me.btnExportar.Location = New System.Drawing.Point(1011, 552)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(63, 40)
        Me.btnExportar.TabIndex = 4
        Me.btnExportar.UseVisualStyleBackColor = False
        '
        'frmProdutos
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1138, 734)
        Me.Controls.Add(Me.tabCtrlProduto)
        Me.Controls.Add(Me.gbBotoes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProdutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmProdutos"
        Me.tabCtrlProduto.ResumeLayout(False)
        Me.tabConsulta.ResumeLayout(False)
        Me.tabConsulta.PerformLayout()
        CType(Me.dgProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFiltroProduto.ResumeLayout(False)
        Me.gbFiltroProduto.PerformLayout()
        Me.gbBotoes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabCtrlProduto As TabControl
    Friend WithEvents tabConsulta As TabPage
    Friend WithEvents gbFiltroProduto As GroupBox
    Friend WithEvents gbBotoes As GroupBox
    Friend WithEvents btnCadastrar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnFechar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents lblFiltroProduto As Label
    Friend WithEvents txtFiltroProduto As GFT.Util.SuperTextBox
    Friend WithEvents imgListProdutos As ImageList
    Friend WithEvents dgProduto As GFT.Util.SuperDataGridView
    Friend WithEvents txtLetreiro As GFT.Util.SuperLetreiro
    Friend WithEvents btnLimpaFiltro As Button
    Friend WithEvents lblTamanho As Label
    Friend WithEvents cbTamanho As GFT.Util.SuperComboBox
    Friend WithEvents cbCor As GFT.Util.SuperComboBox
    Friend WithEvents lblCor As Label
    Friend WithEvents btnFiltrar As Button
    Friend WithEvents chkTodos As CheckBox
    Friend WithEvents btnExportar As Button
End Class
