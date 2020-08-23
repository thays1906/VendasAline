<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVendas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVendas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tabCtrlVenda = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.gbDados = New System.Windows.Forms.GroupBox()
        Me.cbPagamento = New GFT.Util.SuperComboBox()
        Me.lblPagamento = New System.Windows.Forms.Label()
        Me.cbCliente = New GFT.Util.SuperComboBox()
        Me.dtVenda = New System.Windows.Forms.DateTimePicker()
        Me.lblDataVenda = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.gbProduto = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuperTextBox1 = New GFT.Util.SuperTextBox()
        Me.lblEstoque = New System.Windows.Forms.Label()
        Me.nudQuantidade = New System.Windows.Forms.NumericUpDown()
        Me.cbProduto = New GFT.Util.SuperComboBox()
        Me.btnPesquisarProd = New System.Windows.Forms.Button()
        Me.lblValorTotal = New System.Windows.Forms.Label()
        Me.txtValorTotal = New GFT.Util.SuperTextBox()
        Me.lblValorUn = New System.Windows.Forms.Label()
        Me.txtValorUn = New GFT.Util.SuperTextBox()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.btnEditarItem = New System.Windows.Forms.Button()
        Me.btnRemoverItem = New System.Windows.Forms.Button()
        Me.dgVenda = New GFT.Util.SuperDataGridView()
        Me.pnlTotal = New System.Windows.Forms.Panel()
        Me.btnTotalVenda = New System.Windows.Forms.Button()
        Me.btnFinalizaVenda = New System.Windows.Forms.Button()
        Me.btnSacola = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.tpConsulta = New System.Windows.Forms.TabPage()
        Me.gbBotoes = New System.Windows.Forms.GroupBox()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.gbFiltroVenda = New System.Windows.Forms.GroupBox()
        Me.lblDataFimFiltro = New System.Windows.Forms.Label()
        Me.lblDataInicioFiltro = New System.Windows.Forms.Label()
        Me.dtInicioFiltro = New System.Windows.Forms.DateTimePicker()
        Me.dtFimFiltro = New System.Windows.Forms.DateTimePicker()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.lblAnoFiltro = New System.Windows.Forms.Label()
        Me.cbAno = New GFT.Util.SuperComboBox()
        Me.lblMesFiltro = New System.Windows.Forms.Label()
        Me.cbMesFiltro = New GFT.Util.SuperComboBox()
        Me.dgConsultaVenda = New GFT.Util.SuperDataGridView()
        Me.txtLetreiroVenda = New GFT.Util.SuperLetreiro()
        Me.imgListVenda = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTipVenda = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.tabCtrlVenda.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gbDados.SuspendLayout()
        Me.gbProduto.SuspendLayout()
        CType(Me.nudQuantidade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTotal.SuspendLayout()
        Me.tpConsulta.SuspendLayout()
        Me.gbBotoes.SuspendLayout()
        Me.gbFiltroVenda.SuspendLayout()
        CType(Me.dgConsultaVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabCtrlVenda
        '
        Me.tabCtrlVenda.Controls.Add(Me.TabPage1)
        Me.tabCtrlVenda.Controls.Add(Me.tpConsulta)
        Me.tabCtrlVenda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabCtrlVenda.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabCtrlVenda.ImageList = Me.imgListVenda
        Me.tabCtrlVenda.Location = New System.Drawing.Point(0, 0)
        Me.tabCtrlVenda.Name = "tabCtrlVenda"
        Me.tabCtrlVenda.Padding = New System.Drawing.Point(100, 10)
        Me.tabCtrlVenda.SelectedIndex = 0
        Me.tabCtrlVenda.Size = New System.Drawing.Size(1391, 807)
        Me.tabCtrlVenda.TabIndex = 0
        Me.ToolTipVenda.SetToolTip(Me.tabCtrlVenda, "Aqui você realiza suas vendas.")
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TabPage1.Controls.Add(Me.gbDados)
        Me.TabPage1.Controls.Add(Me.btnEditarItem)
        Me.TabPage1.Controls.Add(Me.btnRemoverItem)
        Me.TabPage1.Controls.Add(Me.dgVenda)
        Me.TabPage1.Controls.Add(Me.pnlTotal)
        Me.TabPage1.ImageIndex = 2
        Me.TabPage1.Location = New System.Drawing.Point(4, 69)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1383, 734)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Vendas"
        '
        'gbDados
        '
        Me.gbDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDados.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbDados.Controls.Add(Me.cbPagamento)
        Me.gbDados.Controls.Add(Me.lblPagamento)
        Me.gbDados.Controls.Add(Me.cbCliente)
        Me.gbDados.Controls.Add(Me.dtVenda)
        Me.gbDados.Controls.Add(Me.lblDataVenda)
        Me.gbDados.Controls.Add(Me.lblCliente)
        Me.gbDados.Controls.Add(Me.gbProduto)
        Me.gbDados.Location = New System.Drawing.Point(6, 5)
        Me.gbDados.Name = "gbDados"
        Me.gbDados.Size = New System.Drawing.Size(1371, 277)
        Me.gbDados.TabIndex = 15
        Me.gbDados.TabStop = False
        Me.gbDados.Text = "Dados da Venda"
        '
        'cbPagamento
        '
        Me.cbPagamento.Alterado = False
        Me.cbPagamento.CorFundo = System.Drawing.Color.White
        Me.cbPagamento.CorFundoSelecionado = System.Drawing.Color.White
        Me.cbPagamento.CorTexto = System.Drawing.Color.Black
        Me.cbPagamento.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbPagamento.FormattingEnabled = True
        Me.cbPagamento.Location = New System.Drawing.Point(701, 65)
        Me.cbPagamento.Name = "cbPagamento"
        Me.cbPagamento.Size = New System.Drawing.Size(221, 26)
        Me.cbPagamento.SuperObrigatorio = True
        Me.cbPagamento.SuperTxtObrigatorio = "Cliente"
        Me.cbPagamento.TabIndex = 17
        Me.ToolTipVenda.SetToolTip(Me.cbPagamento, "Selecione a forma de pagamento.")
        '
        'lblPagamento
        '
        Me.lblPagamento.AutoSize = True
        Me.lblPagamento.Location = New System.Drawing.Point(696, 38)
        Me.lblPagamento.Name = "lblPagamento"
        Me.lblPagamento.Size = New System.Drawing.Size(182, 18)
        Me.lblPagamento.TabIndex = 18
        Me.lblPagamento.Text = "Forma de Pagamento"
        '
        'cbCliente
        '
        Me.cbCliente.Alterado = False
        Me.cbCliente.CorFundo = System.Drawing.Color.White
        Me.cbCliente.CorFundoSelecionado = System.Drawing.Color.White
        Me.cbCliente.CorTexto = System.Drawing.Color.Black
        Me.cbCliente.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbCliente.FormattingEnabled = True
        Me.cbCliente.Location = New System.Drawing.Point(226, 65)
        Me.cbCliente.Name = "cbCliente"
        Me.cbCliente.Size = New System.Drawing.Size(434, 26)
        Me.cbCliente.SuperObrigatorio = True
        Me.cbCliente.SuperTxtObrigatorio = "Cliente"
        Me.cbCliente.TabIndex = 14
        Me.ToolTipVenda.SetToolTip(Me.cbCliente, "Aqui, você seleciona um cliente para a venda atual.")
        '
        'dtVenda
        '
        Me.dtVenda.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtVenda.Location = New System.Drawing.Point(18, 66)
        Me.dtVenda.Name = "dtVenda"
        Me.dtVenda.Size = New System.Drawing.Size(197, 27)
        Me.dtVenda.TabIndex = 13
        '
        'lblDataVenda
        '
        Me.lblDataVenda.AutoSize = True
        Me.lblDataVenda.Location = New System.Drawing.Point(13, 38)
        Me.lblDataVenda.Name = "lblDataVenda"
        Me.lblDataVenda.Size = New System.Drawing.Size(129, 18)
        Me.lblDataVenda.TabIndex = 16
        Me.lblDataVenda.Text = "Data da Venda"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(221, 37)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(66, 18)
        Me.lblCliente.TabIndex = 15
        Me.lblCliente.Text = "Cliente"
        '
        'gbProduto
        '
        Me.gbProduto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbProduto.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbProduto.Controls.Add(Me.Label1)
        Me.gbProduto.Controls.Add(Me.SuperTextBox1)
        Me.gbProduto.Controls.Add(Me.lblEstoque)
        Me.gbProduto.Controls.Add(Me.nudQuantidade)
        Me.gbProduto.Controls.Add(Me.cbProduto)
        Me.gbProduto.Controls.Add(Me.btnPesquisarProd)
        Me.gbProduto.Controls.Add(Me.lblValorTotal)
        Me.gbProduto.Controls.Add(Me.txtValorTotal)
        Me.gbProduto.Controls.Add(Me.lblValorUn)
        Me.gbProduto.Controls.Add(Me.txtValorUn)
        Me.gbProduto.Controls.Add(Me.lblQuantidade)
        Me.gbProduto.Controls.Add(Me.btnAdicionar)
        Me.gbProduto.Controls.Add(Me.lblProduto)
        Me.gbProduto.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbProduto.Location = New System.Drawing.Point(2, 104)
        Me.gbProduto.Name = "gbProduto"
        Me.gbProduto.Size = New System.Drawing.Size(1363, 173)
        Me.gbProduto.TabIndex = 4
        Me.gbProduto.TabStop = False
        Me.gbProduto.Text = "Pesquisar Produto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(892, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 18)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Descontos"
        '
        'SuperTextBox1
        '
        Me.SuperTextBox1.Alterado = False
        Me.SuperTextBox1.BackColor = System.Drawing.Color.White
        Me.SuperTextBox1.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SuperTextBox1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTextBox1.Location = New System.Drawing.Point(895, 59)
        Me.SuperTextBox1.Name = "SuperTextBox1"
        Me.SuperTextBox1.Size = New System.Drawing.Size(176, 27)
        Me.SuperTextBox1.SuperMascara = ""
        Me.SuperTextBox1.SuperObrigatorio = False
        Me.SuperTextBox1.SuperTravaErrors = False
        Me.SuperTextBox1.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.SuperTextBox1.SuperTxtObrigatorio = ""
        Me.SuperTextBox1.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosReais
        Me.SuperTextBox1.TabIndex = 13
        Me.SuperTextBox1.Text = "-R$ 0,00"
        Me.SuperTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTipVenda.SetToolTip(Me.SuperTextBox1, "Descontos para o Item selecionado.")
        '
        'lblEstoque
        '
        Me.lblEstoque.AutoEllipsis = True
        Me.lblEstoque.BackColor = System.Drawing.SystemColors.Window
        Me.lblEstoque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblEstoque.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstoque.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblEstoque.Image = Global.ControleVendas.My.Resources.Resources.iconEstoque32x
        Me.lblEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblEstoque.Location = New System.Drawing.Point(14, 89)
        Me.lblEstoque.Name = "lblEstoque"
        Me.lblEstoque.Size = New System.Drawing.Size(230, 32)
        Me.lblEstoque.TabIndex = 12
        Me.lblEstoque.Text = "Disponível:      "
        Me.lblEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTipVenda.SetToolTip(Me.lblEstoque, "Este é o estoque disponível do produto selecionado no momento.")
        '
        'nudQuantidade
        '
        Me.nudQuantidade.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudQuantidade.Location = New System.Drawing.Point(436, 59)
        Me.nudQuantidade.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.nudQuantidade.Name = "nudQuantidade"
        Me.nudQuantidade.Size = New System.Drawing.Size(85, 27)
        Me.nudQuantidade.TabIndex = 7
        Me.nudQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudQuantidade.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cbProduto
        '
        Me.cbProduto.Alterado = False
        Me.cbProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.cbProduto.CorFundo = System.Drawing.Color.White
        Me.cbProduto.CorFundoSelecionado = System.Drawing.Color.White
        Me.cbProduto.CorTexto = System.Drawing.Color.Black
        Me.cbProduto.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbProduto.DropDownWidth = 520
        Me.cbProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbProduto.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProduto.FormattingEnabled = True
        Me.cbProduto.ItemHeight = 18
        Me.cbProduto.Location = New System.Drawing.Point(16, 60)
        Me.cbProduto.MaxDropDownItems = 20
        Me.cbProduto.Name = "cbProduto"
        Me.cbProduto.Size = New System.Drawing.Size(344, 26)
        Me.cbProduto.SuperObrigatorio = False
        Me.cbProduto.SuperTxtObrigatorio = ""
        Me.cbProduto.TabIndex = 9
        Me.ToolTipVenda.SetToolTip(Me.cbProduto, "Selecione aqui um produto para adicionar ao carrinho.")
        '
        'btnPesquisarProd
        '
        Me.btnPesquisarProd.FlatAppearance.BorderSize = 0
        Me.btnPesquisarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPesquisarProd.Image = Global.ControleVendas.My.Resources.Resources.iconCestaSearch48
        Me.btnPesquisarProd.Location = New System.Drawing.Point(372, 46)
        Me.btnPesquisarProd.Name = "btnPesquisarProd"
        Me.btnPesquisarProd.Size = New System.Drawing.Size(50, 40)
        Me.btnPesquisarProd.TabIndex = 3
        Me.btnPesquisarProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPesquisarProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTipVenda.SetToolTip(Me.btnPesquisarProd, "Clique aqui, para adicionar vários itens ao carrinho ou pesquisar produtos.")
        Me.btnPesquisarProd.UseVisualStyleBackColor = True
        '
        'lblValorTotal
        '
        Me.lblValorTotal.AutoSize = True
        Me.lblValorTotal.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorTotal.Location = New System.Drawing.Point(708, 39)
        Me.lblValorTotal.Name = "lblValorTotal"
        Me.lblValorTotal.Size = New System.Drawing.Size(93, 18)
        Me.lblValorTotal.TabIndex = 11
        Me.lblValorTotal.Text = "Total Item"
        '
        'txtValorTotal
        '
        Me.txtValorTotal.Alterado = False
        Me.txtValorTotal.BackColor = System.Drawing.Color.White
        Me.txtValorTotal.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValorTotal.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorTotal.Location = New System.Drawing.Point(713, 59)
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.Size = New System.Drawing.Size(176, 27)
        Me.txtValorTotal.SuperMascara = ""
        Me.txtValorTotal.SuperObrigatorio = False
        Me.txtValorTotal.SuperTravaErrors = False
        Me.txtValorTotal.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtValorTotal.SuperTxtObrigatorio = ""
        Me.txtValorTotal.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosReais
        Me.txtValorTotal.TabIndex = 6
        Me.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTipVenda.SetToolTip(Me.txtValorTotal, "Valor Total do Item selecionado no momento.")
        '
        'lblValorUn
        '
        Me.lblValorUn.AutoSize = True
        Me.lblValorUn.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorUn.Location = New System.Drawing.Point(526, 39)
        Me.lblValorUn.Name = "lblValorUn"
        Me.lblValorUn.Size = New System.Drawing.Size(120, 18)
        Me.lblValorUn.TabIndex = 9
        Me.lblValorUn.Text = "Valor Unitário"
        '
        'txtValorUn
        '
        Me.txtValorUn.Alterado = False
        Me.txtValorUn.BackColor = System.Drawing.Color.White
        Me.txtValorUn.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValorUn.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorUn.Location = New System.Drawing.Point(531, 59)
        Me.txtValorUn.Name = "txtValorUn"
        Me.txtValorUn.Size = New System.Drawing.Size(176, 27)
        Me.txtValorUn.SuperMascara = ""
        Me.txtValorUn.SuperObrigatorio = False
        Me.txtValorUn.SuperTravaErrors = False
        Me.txtValorUn.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtValorUn.SuperTxtObrigatorio = ""
        Me.txtValorUn.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosReais
        Me.txtValorUn.TabIndex = 5
        Me.txtValorUn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTipVenda.SetToolTip(Me.txtValorUn, "Valor Unitário do Item.")
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantidade.Location = New System.Drawing.Point(433, 39)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(54, 18)
        Me.lblQuantidade.TabIndex = 7
        Me.lblQuantidade.Text = "Qtde."
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdicionar.Image = Global.ControleVendas.My.Resources.Resources.iconCestaAdd48
        Me.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAdicionar.Location = New System.Drawing.Point(330, 108)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(215, 59)
        Me.btnAdicionar.TabIndex = 4
        Me.btnAdicionar.Text = " &Adicionar"
        Me.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTipVenda.SetToolTip(Me.btnAdicionar, "Clique aqui, para adicionar um item ao carrinho.")
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'lblProduto
        '
        Me.lblProduto.AutoSize = True
        Me.lblProduto.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProduto.Location = New System.Drawing.Point(11, 39)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(71, 18)
        Me.lblProduto.TabIndex = 4
        Me.lblProduto.Text = "Produto"
        '
        'btnEditarItem
        '
        Me.btnEditarItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditarItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnEditarItem.FlatAppearance.BorderSize = 0
        Me.btnEditarItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnEditarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarItem.Image = CType(resources.GetObject("btnEditarItem.Image"), System.Drawing.Image)
        Me.btnEditarItem.Location = New System.Drawing.Point(1329, 288)
        Me.btnEditarItem.Name = "btnEditarItem"
        Me.btnEditarItem.Size = New System.Drawing.Size(54, 50)
        Me.btnEditarItem.TabIndex = 13
        Me.ToolTipVenda.SetToolTip(Me.btnEditarItem, "Clique aqui, para alterar valores do item no carrinho.")
        Me.btnEditarItem.UseVisualStyleBackColor = False
        '
        'btnRemoverItem
        '
        Me.btnRemoverItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoverItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnRemoverItem.FlatAppearance.BorderSize = 0
        Me.btnRemoverItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnRemoverItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoverItem.Image = Global.ControleVendas.My.Resources.Resources.iconCestaRemove48
        Me.btnRemoverItem.Location = New System.Drawing.Point(1329, 346)
        Me.btnRemoverItem.Name = "btnRemoverItem"
        Me.btnRemoverItem.Size = New System.Drawing.Size(54, 50)
        Me.btnRemoverItem.TabIndex = 8
        Me.ToolTipVenda.SetToolTip(Me.btnRemoverItem, "Clique aqui, para remover um ou vários itens do carrinho.")
        Me.btnRemoverItem.UseVisualStyleBackColor = False
        '
        'dgVenda
        '
        Me.dgVenda.AdicionarCheckBox = True
        Me.dgVenda.AllowUserToAddRows = False
        Me.dgVenda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgVenda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgVenda.BackgroundColor = System.Drawing.Color.White
        Me.dgVenda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgVenda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.dgVenda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSlateGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgVenda.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgVenda.ColumnHeadersHeight = 50
        Me.dgVenda.CorDoFundoCabeçalho = System.Drawing.Color.LightSlateGray
        Me.dgVenda.CorTextoCabeçalho = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgVenda.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgVenda.EnableHeadersVisualStyles = False
        Me.dgVenda.Location = New System.Drawing.Point(3, 288)
        Me.dgVenda.Name = "dgVenda"
        Me.dgVenda.ReadOnly = True
        Me.dgVenda.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgVenda.RowHeadersVisible = False
        Me.dgVenda.RowHeadersWidth = 51
        Me.dgVenda.RowTemplate.Height = 24
        Me.dgVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgVenda.Size = New System.Drawing.Size(1320, 358)
        Me.dgVenda.TabIndex = 0
        '
        'pnlTotal
        '
        Me.pnlTotal.BackColor = System.Drawing.Color.LightSlateGray
        Me.pnlTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTotal.Controls.Add(Me.btnTotalVenda)
        Me.pnlTotal.Controls.Add(Me.btnFinalizaVenda)
        Me.pnlTotal.Controls.Add(Me.btnSacola)
        Me.pnlTotal.Controls.Add(Me.lblTotal)
        Me.pnlTotal.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlTotal.Location = New System.Drawing.Point(3, 665)
        Me.pnlTotal.Name = "pnlTotal"
        Me.pnlTotal.Size = New System.Drawing.Size(1377, 66)
        Me.pnlTotal.TabIndex = 1
        '
        'btnTotalVenda
        '
        Me.btnTotalVenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTotalVenda.BackColor = System.Drawing.Color.Transparent
        Me.btnTotalVenda.FlatAppearance.BorderSize = 0
        Me.btnTotalVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btnTotalVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTotalVenda.Font = New System.Drawing.Font("Verdana", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotalVenda.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnTotalVenda.Image = Global.ControleVendas.My.Resources.Resources.iconCestaMoney48
        Me.btnTotalVenda.Location = New System.Drawing.Point(1129, 3)
        Me.btnTotalVenda.Name = "btnTotalVenda"
        Me.btnTotalVenda.Size = New System.Drawing.Size(244, 57)
        Me.btnTotalVenda.TabIndex = 10
        Me.btnTotalVenda.Text = "R$ 0,00"
        Me.btnTotalVenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTotalVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTipVenda.SetToolTip(Me.btnTotalVenda, "Esta é o valor total da venda.")
        Me.btnTotalVenda.UseVisualStyleBackColor = False
        '
        'btnFinalizaVenda
        '
        Me.btnFinalizaVenda.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnFinalizaVenda.Image = Global.ControleVendas.My.Resources.Resources.iconSim
        Me.btnFinalizaVenda.Location = New System.Drawing.Point(565, 6)
        Me.btnFinalizaVenda.Name = "btnFinalizaVenda"
        Me.btnFinalizaVenda.Size = New System.Drawing.Size(234, 50)
        Me.btnFinalizaVenda.TabIndex = 9
        Me.btnFinalizaVenda.Text = " &Finalizar Venda"
        Me.btnFinalizaVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFinalizaVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTipVenda.SetToolTip(Me.btnFinalizaVenda, "Clique aqui, para finalizar sua venda.")
        Me.btnFinalizaVenda.UseVisualStyleBackColor = True
        '
        'btnSacola
        '
        Me.btnSacola.BackColor = System.Drawing.Color.Transparent
        Me.btnSacola.FlatAppearance.BorderSize = 0
        Me.btnSacola.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btnSacola.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSacola.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnSacola.Image = Global.ControleVendas.My.Resources.Resources.iconCesta48
        Me.btnSacola.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnSacola.Location = New System.Drawing.Point(20, 6)
        Me.btnSacola.Name = "btnSacola"
        Me.btnSacola.Size = New System.Drawing.Size(96, 57)
        Me.btnSacola.TabIndex = 9
        Me.btnSacola.Text = "0"
        Me.btnSacola.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnSacola.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTipVenda.SetToolTip(Me.btnSacola, "Esta é a quantidade de itens no carrinho.")
        Me.btnSacola.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTotal.Location = New System.Drawing.Point(993, 18)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(130, 34)
        Me.lblTotal.TabIndex = 1
        Me.lblTotal.Text = "TOTAL"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tpConsulta
        '
        Me.tpConsulta.Controls.Add(Me.gbBotoes)
        Me.tpConsulta.Controls.Add(Me.gbFiltroVenda)
        Me.tpConsulta.Controls.Add(Me.dgConsultaVenda)
        Me.tpConsulta.Controls.Add(Me.txtLetreiroVenda)
        Me.tpConsulta.ImageIndex = 1
        Me.tpConsulta.Location = New System.Drawing.Point(4, 69)
        Me.tpConsulta.Name = "tpConsulta"
        Me.tpConsulta.Padding = New System.Windows.Forms.Padding(3)
        Me.tpConsulta.Size = New System.Drawing.Size(1383, 734)
        Me.tpConsulta.TabIndex = 1
        Me.tpConsulta.Text = "Consulta de Vendas"
        Me.ToolTipVenda.SetToolTip(Me.tpConsulta, "Aqui você visualiza todas suas vendas finalizadas.")
        Me.tpConsulta.UseVisualStyleBackColor = True
        '
        'gbBotoes
        '
        Me.gbBotoes.Controls.Add(Me.btnVoltar)
        Me.gbBotoes.Controls.Add(Me.btnExportar)
        Me.gbBotoes.Controls.Add(Me.btnExcluir)
        Me.gbBotoes.Controls.Add(Me.btnEditar)
        Me.gbBotoes.Controls.Add(Me.btnPesquisar)
        Me.gbBotoes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbBotoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbBotoes.Location = New System.Drawing.Point(3, 661)
        Me.gbBotoes.Name = "gbBotoes"
        Me.gbBotoes.Size = New System.Drawing.Size(1377, 70)
        Me.gbBotoes.TabIndex = 2
        Me.gbBotoes.TabStop = False
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnVoltar.Image = Global.ControleVendas.My.Resources.Resources.icon_Voltar
        Me.btnVoltar.Location = New System.Drawing.Point(1043, 16)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(222, 48)
        Me.btnVoltar.TabIndex = 9
        Me.btnVoltar.Text = " &Voltar"
        Me.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVoltar.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExportar.Image = Global.ControleVendas.My.Resources.Resources.iconExcel
        Me.btnExportar.Location = New System.Drawing.Point(784, 16)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(222, 48)
        Me.btnExportar.TabIndex = 8
        Me.btnExportar.Text = " &Exportar"
        Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExcluir.Image = Global.ControleVendas.My.Resources.Resources.iconExcluir
        Me.btnExcluir.Location = New System.Drawing.Point(523, 16)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(222, 48)
        Me.btnExcluir.TabIndex = 7
        Me.btnExcluir.Text = " &Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnEditar.Image = Global.ControleVendas.My.Resources.Resources.iconViewFile
        Me.btnEditar.Location = New System.Drawing.Point(261, 16)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(222, 48)
        Me.btnEditar.TabIndex = 6
        Me.btnEditar.Text = " &Visualizar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnPesquisar.Image = Global.ControleVendas.My.Resources.Resources.iconePesquisar
        Me.btnPesquisar.Location = New System.Drawing.Point(6, 16)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(222, 48)
        Me.btnPesquisar.TabIndex = 5
        Me.btnPesquisar.Text = " &Pesquisar"
        Me.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'gbFiltroVenda
        '
        Me.gbFiltroVenda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbFiltroVenda.BackColor = System.Drawing.SystemColors.Control
        Me.gbFiltroVenda.Controls.Add(Me.lblDataFimFiltro)
        Me.gbFiltroVenda.Controls.Add(Me.lblDataInicioFiltro)
        Me.gbFiltroVenda.Controls.Add(Me.dtInicioFiltro)
        Me.gbFiltroVenda.Controls.Add(Me.dtFimFiltro)
        Me.gbFiltroVenda.Controls.Add(Me.CheckBox1)
        Me.gbFiltroVenda.Controls.Add(Me.lblAnoFiltro)
        Me.gbFiltroVenda.Controls.Add(Me.cbAno)
        Me.gbFiltroVenda.Controls.Add(Me.lblMesFiltro)
        Me.gbFiltroVenda.Controls.Add(Me.cbMesFiltro)
        Me.gbFiltroVenda.Location = New System.Drawing.Point(71, 17)
        Me.gbFiltroVenda.Name = "gbFiltroVenda"
        Me.gbFiltroVenda.Size = New System.Drawing.Size(1214, 108)
        Me.gbFiltroVenda.TabIndex = 1
        Me.gbFiltroVenda.TabStop = False
        Me.gbFiltroVenda.Text = "Filtro"
        '
        'lblDataFimFiltro
        '
        Me.lblDataFimFiltro.AutoSize = True
        Me.lblDataFimFiltro.Location = New System.Drawing.Point(1047, 42)
        Me.lblDataFimFiltro.Name = "lblDataFimFiltro"
        Me.lblDataFimFiltro.Size = New System.Drawing.Size(36, 18)
        Me.lblDataFimFiltro.TabIndex = 8
        Me.lblDataFimFiltro.Text = "Até"
        '
        'lblDataInicioFiltro
        '
        Me.lblDataInicioFiltro.AutoSize = True
        Me.lblDataInicioFiltro.Location = New System.Drawing.Point(885, 42)
        Me.lblDataInicioFiltro.Name = "lblDataInicioFiltro"
        Me.lblDataInicioFiltro.Size = New System.Drawing.Size(30, 18)
        Me.lblDataInicioFiltro.TabIndex = 7
        Me.lblDataInicioFiltro.Text = "De"
        '
        'dtInicioFiltro
        '
        Me.dtInicioFiltro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtInicioFiltro.Location = New System.Drawing.Point(890, 70)
        Me.dtInicioFiltro.Name = "dtInicioFiltro"
        Me.dtInicioFiltro.Size = New System.Drawing.Size(156, 27)
        Me.dtInicioFiltro.TabIndex = 3
        '
        'dtFimFiltro
        '
        Me.dtFimFiltro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFimFiltro.Location = New System.Drawing.Point(1052, 70)
        Me.dtFimFiltro.Name = "dtFimFiltro"
        Me.dtFimFiltro.Size = New System.Drawing.Size(156, 27)
        Me.dtFimFiltro.TabIndex = 4
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(735, 73)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(120, 22)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "Por Período"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'lblAnoFiltro
        '
        Me.lblAnoFiltro.AutoSize = True
        Me.lblAnoFiltro.Location = New System.Drawing.Point(378, 32)
        Me.lblAnoFiltro.Name = "lblAnoFiltro"
        Me.lblAnoFiltro.Size = New System.Drawing.Size(39, 18)
        Me.lblAnoFiltro.TabIndex = 3
        Me.lblAnoFiltro.Text = "Ano"
        '
        'cbAno
        '
        Me.cbAno.Alterado = False
        Me.cbAno.CorFundo = System.Drawing.Color.White
        Me.cbAno.CorFundoSelecionado = System.Drawing.Color.White
        Me.cbAno.CorTexto = System.Drawing.Color.Black
        Me.cbAno.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbAno.FormattingEnabled = True
        Me.cbAno.Location = New System.Drawing.Point(383, 60)
        Me.cbAno.Name = "cbAno"
        Me.cbAno.Size = New System.Drawing.Size(147, 26)
        Me.cbAno.SuperObrigatorio = False
        Me.cbAno.SuperTxtObrigatorio = ""
        Me.cbAno.TabIndex = 1
        '
        'lblMesFiltro
        '
        Me.lblMesFiltro.AutoSize = True
        Me.lblMesFiltro.Location = New System.Drawing.Point(15, 32)
        Me.lblMesFiltro.Name = "lblMesFiltro"
        Me.lblMesFiltro.Size = New System.Drawing.Size(40, 18)
        Me.lblMesFiltro.TabIndex = 1
        Me.lblMesFiltro.Text = "Mês"
        '
        'cbMesFiltro
        '
        Me.cbMesFiltro.Alterado = False
        Me.cbMesFiltro.CorFundo = System.Drawing.Color.White
        Me.cbMesFiltro.CorFundoSelecionado = System.Drawing.Color.White
        Me.cbMesFiltro.CorTexto = System.Drawing.Color.Black
        Me.cbMesFiltro.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbMesFiltro.FormattingEnabled = True
        Me.cbMesFiltro.Location = New System.Drawing.Point(20, 60)
        Me.cbMesFiltro.Name = "cbMesFiltro"
        Me.cbMesFiltro.Size = New System.Drawing.Size(357, 26)
        Me.cbMesFiltro.SuperObrigatorio = False
        Me.cbMesFiltro.SuperTxtObrigatorio = ""
        Me.cbMesFiltro.TabIndex = 0
        '
        'dgConsultaVenda
        '
        Me.dgConsultaVenda.AdicionarCheckBox = True
        Me.dgConsultaVenda.AllowUserToAddRows = False
        Me.dgConsultaVenda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgConsultaVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgConsultaVenda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgConsultaVenda.BackgroundColor = System.Drawing.Color.White
        Me.dgConsultaVenda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgConsultaVenda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.dgConsultaVenda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSlateGray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgConsultaVenda.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgConsultaVenda.ColumnHeadersHeight = 50
        Me.dgConsultaVenda.CorDoFundoCabeçalho = System.Drawing.Color.LightSlateGray
        Me.dgConsultaVenda.CorTextoCabeçalho = System.Drawing.Color.White
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgConsultaVenda.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgConsultaVenda.EnableHeadersVisualStyles = False
        Me.dgConsultaVenda.Location = New System.Drawing.Point(77, 144)
        Me.dgConsultaVenda.Name = "dgConsultaVenda"
        Me.dgConsultaVenda.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgConsultaVenda.RowHeadersVisible = False
        Me.dgConsultaVenda.RowHeadersWidth = 51
        Me.dgConsultaVenda.RowTemplate.Height = 24
        Me.dgConsultaVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgConsultaVenda.Size = New System.Drawing.Size(1209, 422)
        Me.dgConsultaVenda.TabIndex = 0
        '
        'txtLetreiroVenda
        '
        Me.txtLetreiroVenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtLetreiroVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLetreiroVenda.CorSombraTexto = System.Drawing.Color.White
        Me.txtLetreiroVenda.Location = New System.Drawing.Point(77, 572)
        Me.txtLetreiroVenda.Name = "txtLetreiroVenda"
        Me.txtLetreiroVenda.RolagemLetreiro = GFT.Util.SuperLetreiro.Direcao.Direita
        Me.txtLetreiroVenda.Size = New System.Drawing.Size(371, 40)
        Me.txtLetreiroVenda.TabIndex = 3
        Me.txtLetreiroVenda.TextoLetreiro = ""
        Me.txtLetreiroVenda.VelocidadeRolagem = 5
        '
        'imgListVenda
        '
        Me.imgListVenda.ImageStream = CType(resources.GetObject("imgListVenda.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgListVenda.TransparentColor = System.Drawing.Color.Transparent
        Me.imgListVenda.Images.SetKeyName(0, "iconVenda.png")
        Me.imgListVenda.Images.SetKeyName(1, "iconConsulta.png")
        Me.imgListVenda.Images.SetKeyName(2, "iconCaixa.png")
        '
        'ToolTipVenda
        '
        Me.ToolTipVenda.AutomaticDelay = 800
        Me.ToolTipVenda.IsBalloon = True
        Me.ToolTipVenda.ShowAlways = True
        Me.ToolTipVenda.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFechar.Image = CType(resources.GetObject("btnFechar.Image"), System.Drawing.Image)
        Me.btnFechar.Location = New System.Drawing.Point(1316, -1)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(76, 64)
        Me.btnFechar.TabIndex = 10
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTipVenda.SetToolTip(Me.btnFechar, "Clique aqui, para fechar esta janela.")
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'frmVendas
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1391, 807)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.tabCtrlVenda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmVendas"
        Me.Text = "Vendas"
        Me.tabCtrlVenda.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.gbDados.ResumeLayout(False)
        Me.gbDados.PerformLayout()
        Me.gbProduto.ResumeLayout(False)
        Me.gbProduto.PerformLayout()
        CType(Me.nudQuantidade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgVenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTotal.ResumeLayout(False)
        Me.tpConsulta.ResumeLayout(False)
        Me.gbBotoes.ResumeLayout(False)
        Me.gbFiltroVenda.ResumeLayout(False)
        Me.gbFiltroVenda.PerformLayout()
        CType(Me.dgConsultaVenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabCtrlVenda As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents tpConsulta As TabPage
    Friend WithEvents dgVenda As GFT.Util.SuperDataGridView
    Friend WithEvents lblTotal As Label
    Friend WithEvents pnlTotal As Panel
    Friend WithEvents gbFiltroVenda As GroupBox
    Friend WithEvents dgConsultaVenda As GFT.Util.SuperDataGridView
    Friend WithEvents imgListVenda As ImageList
    Friend WithEvents btnSacola As Button
    Friend WithEvents btnRemoverItem As Button
    Friend WithEvents btnFinalizaVenda As Button
    Friend WithEvents gbBotoes As GroupBox
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents btnVoltar As Button
    Friend WithEvents btnExportar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents lblDataFimFiltro As Label
    Friend WithEvents lblDataInicioFiltro As Label
    Friend WithEvents dtInicioFiltro As DateTimePicker
    Friend WithEvents dtFimFiltro As DateTimePicker
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents lblAnoFiltro As Label
    Friend WithEvents cbAno As GFT.Util.SuperComboBox
    Friend WithEvents lblMesFiltro As Label
    Friend WithEvents cbMesFiltro As GFT.Util.SuperComboBox
    Friend WithEvents txtLetreiroVenda As GFT.Util.SuperLetreiro
    Friend WithEvents btnEditarItem As Button
    Friend WithEvents gbDados As GroupBox
    Friend WithEvents cbCliente As GFT.Util.SuperComboBox
    Friend WithEvents dtVenda As DateTimePicker
    Friend WithEvents lblDataVenda As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents gbProduto As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SuperTextBox1 As GFT.Util.SuperTextBox
    Friend WithEvents lblEstoque As Label
    Friend WithEvents nudQuantidade As NumericUpDown
    Friend WithEvents cbProduto As GFT.Util.SuperComboBox
    Friend WithEvents btnPesquisarProd As Button
    Friend WithEvents lblValorTotal As Label
    Friend WithEvents txtValorTotal As GFT.Util.SuperTextBox
    Friend WithEvents lblValorUn As Label
    Friend WithEvents txtValorUn As GFT.Util.SuperTextBox
    Friend WithEvents lblQuantidade As Label
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents lblProduto As Label
    Friend WithEvents btnFechar As Button
    Friend WithEvents btnTotalVenda As Button
    Friend WithEvents cbPagamento As GFT.Util.SuperComboBox
    Friend WithEvents lblPagamento As Label
    Friend WithEvents ToolTipVenda As ToolTip
End Class
