<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ConfiguraçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JanelasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusCima = New System.Windows.Forms.StatusStrip()
        Me.txtCaption = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusBaixo = New System.Windows.Forms.StatusStrip()
        Me.txtCaptionHora = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.gbPrincipal = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblTotalVendas = New System.Windows.Forms.Label()
        Me.btnTotalVendaPrincipal = New System.Windows.Forms.Button()
        Me.pnlEstoqueMin = New System.Windows.Forms.Panel()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnEstoqueMin = New System.Windows.Forms.Button()
        Me.dgEstoqueBaixo = New GFT.Util.SuperDataGridView()
        Me.gbAcessoRapido = New System.Windows.Forms.GroupBox()
        Me.btnSaidaPrincipal = New System.Windows.Forms.Button()
        Me.btnNovoClientePrincipal = New System.Windows.Forms.Button()
        Me.btnEntradaPrincipal = New System.Windows.Forms.Button()
        Me.btnConsultaVendaPrincipal = New System.Windows.Forms.Button()
        Me.btnNovoProdutoPrincipal = New System.Windows.Forms.Button()
        Me.ToolTipPrincipal = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusCima.SuspendLayout()
        Me.StatusBaixo.SuspendLayout()
        Me.gbPrincipal.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlEstoqueMin.SuspendLayout()
        CType(Me.dgEstoqueBaixo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAcessoRapido.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AllowItemReorder = True
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfiguraçõesToolStripMenuItem, Me.ProdutosToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.VendasToolStripMenuItem, Me.EstoqueToolStripMenuItem, Me.JanelasToolStripMenuItem, Me.SobreToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.JanelasToolStripMenuItem
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.ShowItemToolTips = True
        Me.MenuStrip1.Size = New System.Drawing.Size(1525, 75)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ConfiguraçõesToolStripMenuItem
        '
        Me.ConfiguraçõesToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfiguraçõesToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ConfiguraçõesToolStripMenuItem.Image = Global.ControleVendas.My.Resources.Resources.iconEngrenagem
        Me.ConfiguraçõesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ConfiguraçõesToolStripMenuItem.Name = "ConfiguraçõesToolStripMenuItem"
        Me.ConfiguraçõesToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded
        Me.ConfiguraçõesToolStripMenuItem.Size = New System.Drawing.Size(194, 71)
        Me.ConfiguraçõesToolStripMenuItem.Text = "Configurações"
        '
        'ProdutosToolStripMenuItem
        '
        Me.ProdutosToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdutosToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ProdutosToolStripMenuItem.Image = CType(resources.GetObject("ProdutosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProdutosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ProdutosToolStripMenuItem.Name = "ProdutosToolStripMenuItem"
        Me.ProdutosToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded
        Me.ProdutosToolStripMenuItem.Size = New System.Drawing.Size(148, 71)
        Me.ProdutosToolStripMenuItem.Text = "Produtos"
        Me.ProdutosToolStripMenuItem.ToolTipText = "Clique aqui, para cadastrar ou consultar produtos."
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClientesToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ClientesToolStripMenuItem.Image = CType(resources.GetObject("ClientesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClientesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(137, 71)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        Me.ClientesToolStripMenuItem.ToolTipText = "Clique aqui, para cadastrar ou consultar clientes"
        '
        'VendasToolStripMenuItem
        '
        Me.VendasToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VendasToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.VendasToolStripMenuItem.Image = CType(resources.GetObject("VendasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VendasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.VendasToolStripMenuItem.Name = "VendasToolStripMenuItem"
        Me.VendasToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded
        Me.VendasToolStripMenuItem.Size = New System.Drawing.Size(133, 71)
        Me.VendasToolStripMenuItem.Text = "Vendas"
        Me.VendasToolStripMenuItem.ToolTipText = "Clique aqui, para realizar uma venda, ou consultar."
        '
        'EstoqueToolStripMenuItem
        '
        Me.EstoqueToolStripMenuItem.Image = Global.ControleVendas.My.Resources.Resources.iconProduct
        Me.EstoqueToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EstoqueToolStripMenuItem.Name = "EstoqueToolStripMenuItem"
        Me.EstoqueToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded
        Me.EstoqueToolStripMenuItem.Size = New System.Drawing.Size(134, 71)
        Me.EstoqueToolStripMenuItem.Text = "Estoque"
        Me.EstoqueToolStripMenuItem.ToolTipText = "Clique aqui, para consultar o estoque, lançar entrada/saída."
        '
        'JanelasToolStripMenuItem
        '
        Me.JanelasToolStripMenuItem.Image = Global.ControleVendas.My.Resources.Resources.iconJanelas
        Me.JanelasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.JanelasToolStripMenuItem.Name = "JanelasToolStripMenuItem"
        Me.JanelasToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded
        Me.JanelasToolStripMenuItem.Size = New System.Drawing.Size(129, 71)
        Me.JanelasToolStripMenuItem.Text = "Janelas"
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SobreToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.SobreToolStripMenuItem.Image = Global.ControleVendas.My.Resources.Resources.iconAbout
        Me.SobreToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(120, 71)
        Me.SobreToolStripMenuItem.Text = "Sobre"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.LogoutToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.LogoutToolStripMenuItem.Image = Global.ControleVendas.My.Resources.Resources.iconLogout_48
        Me.LogoutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(129, 71)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'StatusCima
        '
        Me.StatusCima.AutoSize = False
        Me.StatusCima.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.StatusCima.Dock = System.Windows.Forms.DockStyle.Top
        Me.StatusCima.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusCima.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtCaption})
        Me.StatusCima.Location = New System.Drawing.Point(0, 75)
        Me.StatusCima.Name = "StatusCima"
        Me.StatusCima.Size = New System.Drawing.Size(1525, 44)
        Me.StatusCima.SizingGrip = False
        Me.StatusCima.TabIndex = 3
        Me.StatusCima.Text = "StatusStrip1"
        '
        'txtCaption
        '
        Me.txtCaption.AutoSize = False
        Me.txtCaption.BackColor = System.Drawing.Color.Transparent
        Me.txtCaption.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
        Me.txtCaption.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.txtCaption.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaption.ForeColor = System.Drawing.Color.White
        Me.txtCaption.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtCaption.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.txtCaption.Margin = New System.Windows.Forms.Padding(10, 3, 0, 2)
        Me.txtCaption.Name = "txtCaption"
        Me.txtCaption.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCaption.Size = New System.Drawing.Size(1500, 39)
        Me.txtCaption.Spring = True
        Me.txtCaption.Text = "Dashboard"
        Me.txtCaption.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.txtCaption.ToolTipText = "Você esta aqui"
        '
        'StatusBaixo
        '
        Me.StatusBaixo.AutoSize = False
        Me.StatusBaixo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.StatusBaixo.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusBaixo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtCaptionHora})
        Me.StatusBaixo.Location = New System.Drawing.Point(0, 619)
        Me.StatusBaixo.Name = "StatusBaixo"
        Me.StatusBaixo.Size = New System.Drawing.Size(1525, 44)
        Me.StatusBaixo.SizingGrip = False
        Me.StatusBaixo.TabIndex = 4
        Me.StatusBaixo.Text = "StatusStrip1"
        '
        'txtCaptionHora
        '
        Me.txtCaptionHora.BackColor = System.Drawing.Color.Transparent
        Me.txtCaptionHora.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
        Me.txtCaptionHora.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.txtCaptionHora.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaptionHora.ForeColor = System.Drawing.Color.White
        Me.txtCaptionHora.Name = "txtCaptionHora"
        Me.txtCaptionHora.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCaptionHora.Size = New System.Drawing.Size(1510, 39)
        Me.txtCaptionHora.Spring = True
        Me.txtCaptionHora.Text = "Data/Hora"
        Me.txtCaptionHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 1000
        '
        'gbPrincipal
        '
        Me.gbPrincipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbPrincipal.Controls.Add(Me.Panel1)
        Me.gbPrincipal.Controls.Add(Me.gbAcessoRapido)
        Me.gbPrincipal.Location = New System.Drawing.Point(0, 103)
        Me.gbPrincipal.Name = "gbPrincipal"
        Me.gbPrincipal.Size = New System.Drawing.Size(1525, 513)
        Me.gbPrincipal.TabIndex = 5
        Me.gbPrincipal.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.pnlEstoqueMin)
        Me.Panel1.Location = New System.Drawing.Point(7, 125)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1506, 382)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.Controls.Add(Me.lblTotalVendas)
        Me.Panel2.Controls.Add(Me.btnTotalVendaPrincipal)
        Me.Panel2.Location = New System.Drawing.Point(5, 81)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(257, 149)
        Me.Panel2.TabIndex = 2
        '
        'lblTotalVendas
        '
        Me.lblTotalVendas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lblTotalVendas.AutoSize = True
        Me.lblTotalVendas.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalVendas.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblTotalVendas.Location = New System.Drawing.Point(56, 79)
        Me.lblTotalVendas.Name = "lblTotalVendas"
        Me.lblTotalVendas.Size = New System.Drawing.Size(113, 32)
        Me.lblTotalVendas.TabIndex = 4
        Me.lblTotalVendas.Text = "R$ 0,00"
        '
        'btnTotalVendaPrincipal
        '
        Me.btnTotalVendaPrincipal.BackColor = System.Drawing.Color.Transparent
        Me.btnTotalVendaPrincipal.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTotalVendaPrincipal.FlatAppearance.BorderSize = 0
        Me.btnTotalVendaPrincipal.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotalVendaPrincipal.Image = Global.ControleVendas.My.Resources.Resources.iconRefresh
        Me.btnTotalVendaPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.btnTotalVendaPrincipal.Name = "btnTotalVendaPrincipal"
        Me.btnTotalVendaPrincipal.Size = New System.Drawing.Size(257, 53)
        Me.btnTotalVendaPrincipal.TabIndex = 3
        Me.btnTotalVendaPrincipal.Text = "Total de Vendas"
        Me.btnTotalVendaPrincipal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTipPrincipal.SetToolTip(Me.btnTotalVendaPrincipal, "Clique para atualizar.")
        Me.btnTotalVendaPrincipal.UseVisualStyleBackColor = False
        '
        'pnlEstoqueMin
        '
        Me.pnlEstoqueMin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlEstoqueMin.AutoScroll = True
        Me.pnlEstoqueMin.AutoSize = True
        Me.pnlEstoqueMin.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pnlEstoqueMin.Controls.Add(Me.lblTotal)
        Me.pnlEstoqueMin.Controls.Add(Me.txtTotal)
        Me.pnlEstoqueMin.Controls.Add(Me.btnEstoqueMin)
        Me.pnlEstoqueMin.Controls.Add(Me.dgEstoqueBaixo)
        Me.pnlEstoqueMin.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlEstoqueMin.Location = New System.Drawing.Point(268, 81)
        Me.pnlEstoqueMin.Name = "pnlEstoqueMin"
        Me.pnlEstoqueMin.Size = New System.Drawing.Size(798, 301)
        Me.pnlEstoqueMin.TabIndex = 1
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(10, 53)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(152, 18)
        Me.lblTotal.TabIndex = 2
        Me.lblTotal.Text = "Total de Produtos"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtTotal.Location = New System.Drawing.Point(13, 74)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(149, 27)
        Me.txtTotal.TabIndex = 1
        Me.ToolTipPrincipal.SetToolTip(Me.txtTotal, "Total de Produtos com estoque baixo.")
        '
        'btnEstoqueMin
        '
        Me.btnEstoqueMin.BackColor = System.Drawing.Color.Transparent
        Me.btnEstoqueMin.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEstoqueMin.FlatAppearance.BorderSize = 0
        Me.btnEstoqueMin.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEstoqueMin.Location = New System.Drawing.Point(0, 0)
        Me.btnEstoqueMin.Name = "btnEstoqueMin"
        Me.btnEstoqueMin.Size = New System.Drawing.Size(798, 45)
        Me.btnEstoqueMin.TabIndex = 0
        Me.btnEstoqueMin.Text = "Estoque Mínimo"
        Me.btnEstoqueMin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTipPrincipal.SetToolTip(Me.btnEstoqueMin, "Clique para acessar o Estoque")
        Me.btnEstoqueMin.UseVisualStyleBackColor = False
        '
        'dgEstoqueBaixo
        '
        Me.dgEstoqueBaixo.AdicionarCheckBox = False
        Me.dgEstoqueBaixo.AllowUserToAddRows = False
        Me.dgEstoqueBaixo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgEstoqueBaixo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgEstoqueBaixo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgEstoqueBaixo.BackgroundColor = System.Drawing.Color.White
        Me.dgEstoqueBaixo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgEstoqueBaixo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.dgEstoqueBaixo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSlateGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgEstoqueBaixo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgEstoqueBaixo.ColumnHeadersHeight = 50
        Me.dgEstoqueBaixo.CorDoFundoCabeçalho = System.Drawing.Color.LightSlateGray
        Me.dgEstoqueBaixo.CorTextoCabeçalho = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgEstoqueBaixo.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgEstoqueBaixo.EnableHeadersVisualStyles = False
        Me.dgEstoqueBaixo.Location = New System.Drawing.Point(3, 107)
        Me.dgEstoqueBaixo.Name = "dgEstoqueBaixo"
        Me.dgEstoqueBaixo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgEstoqueBaixo.RowHeadersVisible = False
        Me.dgEstoqueBaixo.RowHeadersWidth = 51
        Me.dgEstoqueBaixo.RowTemplate.Height = 24
        Me.dgEstoqueBaixo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgEstoqueBaixo.Size = New System.Drawing.Size(795, 191)
        Me.dgEstoqueBaixo.TabIndex = 0
        Me.ToolTipPrincipal.SetToolTip(Me.dgEstoqueBaixo, "Lista de Produtos abaixo do estoque mínimo")
        '
        'gbAcessoRapido
        '
        Me.gbAcessoRapido.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.gbAcessoRapido.Controls.Add(Me.btnSaidaPrincipal)
        Me.gbAcessoRapido.Controls.Add(Me.btnNovoClientePrincipal)
        Me.gbAcessoRapido.Controls.Add(Me.btnEntradaPrincipal)
        Me.gbAcessoRapido.Controls.Add(Me.btnConsultaVendaPrincipal)
        Me.gbAcessoRapido.Controls.Add(Me.btnNovoProdutoPrincipal)
        Me.gbAcessoRapido.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbAcessoRapido.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAcessoRapido.ForeColor = System.Drawing.Color.White
        Me.gbAcessoRapido.Location = New System.Drawing.Point(3, 16)
        Me.gbAcessoRapido.Name = "gbAcessoRapido"
        Me.gbAcessoRapido.Size = New System.Drawing.Size(1519, 100)
        Me.gbAcessoRapido.TabIndex = 0
        Me.gbAcessoRapido.TabStop = False
        Me.gbAcessoRapido.Text = "Acesso Rápido"
        Me.ToolTipPrincipal.SetToolTip(Me.gbAcessoRapido, "Atalhos")
        '
        'btnSaidaPrincipal
        '
        Me.btnSaidaPrincipal.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnSaidaPrincipal.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaidaPrincipal.Image = Global.ControleVendas.My.Resources.Resources.iconSaida
        Me.btnSaidaPrincipal.Location = New System.Drawing.Point(1180, 32)
        Me.btnSaidaPrincipal.Name = "btnSaidaPrincipal"
        Me.btnSaidaPrincipal.Size = New System.Drawing.Size(223, 53)
        Me.btnSaidaPrincipal.TabIndex = 4
        Me.btnSaidaPrincipal.Text = " &Saída"
        Me.btnSaidaPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSaidaPrincipal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaidaPrincipal.UseVisualStyleBackColor = False
        '
        'btnNovoClientePrincipal
        '
        Me.btnNovoClientePrincipal.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnNovoClientePrincipal.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovoClientePrincipal.Image = Global.ControleVendas.My.Resources.Resources.iconAddBlue
        Me.btnNovoClientePrincipal.Location = New System.Drawing.Point(389, 32)
        Me.btnNovoClientePrincipal.Name = "btnNovoClientePrincipal"
        Me.btnNovoClientePrincipal.Size = New System.Drawing.Size(223, 53)
        Me.btnNovoClientePrincipal.TabIndex = 3
        Me.btnNovoClientePrincipal.Text = " Cliente"
        Me.btnNovoClientePrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNovoClientePrincipal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNovoClientePrincipal.UseVisualStyleBackColor = False
        '
        'btnEntradaPrincipal
        '
        Me.btnEntradaPrincipal.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnEntradaPrincipal.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntradaPrincipal.Image = Global.ControleVendas.My.Resources.Resources.iconeEntrada
        Me.btnEntradaPrincipal.Location = New System.Drawing.Point(929, 32)
        Me.btnEntradaPrincipal.Name = "btnEntradaPrincipal"
        Me.btnEntradaPrincipal.Size = New System.Drawing.Size(223, 53)
        Me.btnEntradaPrincipal.TabIndex = 2
        Me.btnEntradaPrincipal.Text = " &Entrada"
        Me.btnEntradaPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEntradaPrincipal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEntradaPrincipal.UseVisualStyleBackColor = False
        '
        'btnConsultaVendaPrincipal
        '
        Me.btnConsultaVendaPrincipal.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnConsultaVendaPrincipal.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultaVendaPrincipal.Image = Global.ControleVendas.My.Resources.Resources.iconePesquisar
        Me.btnConsultaVendaPrincipal.Location = New System.Drawing.Point(637, 32)
        Me.btnConsultaVendaPrincipal.Name = "btnConsultaVendaPrincipal"
        Me.btnConsultaVendaPrincipal.Size = New System.Drawing.Size(265, 53)
        Me.btnConsultaVendaPrincipal.TabIndex = 1
        Me.btnConsultaVendaPrincipal.Text = " &Consultar Vendas"
        Me.btnConsultaVendaPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConsultaVendaPrincipal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConsultaVendaPrincipal.UseVisualStyleBackColor = False
        '
        'btnNovoProdutoPrincipal
        '
        Me.btnNovoProdutoPrincipal.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovoProdutoPrincipal.Image = Global.ControleVendas.My.Resources.Resources.iconAddBlue
        Me.btnNovoProdutoPrincipal.Location = New System.Drawing.Point(137, 32)
        Me.btnNovoProdutoPrincipal.Name = "btnNovoProdutoPrincipal"
        Me.btnNovoProdutoPrincipal.Size = New System.Drawing.Size(223, 53)
        Me.btnNovoProdutoPrincipal.TabIndex = 0
        Me.btnNovoProdutoPrincipal.Text = " Produto"
        Me.btnNovoProdutoPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNovoProdutoPrincipal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTipPrincipal.SetToolTip(Me.btnNovoProdutoPrincipal, "Clique aqui, para cadastrar um produto.")
        Me.btnNovoProdutoPrincipal.UseVisualStyleBackColor = True
        '
        'ToolTipPrincipal
        '
        Me.ToolTipPrincipal.IsBalloon = True
        Me.ToolTipPrincipal.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'frmPrincipal
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1525, 663)
        Me.Controls.Add(Me.StatusBaixo)
        Me.Controls.Add(Me.StatusCima)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.gbPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Picarruchas::."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusCima.ResumeLayout(False)
        Me.StatusCima.PerformLayout()
        Me.StatusBaixo.ResumeLayout(False)
        Me.StatusBaixo.PerformLayout()
        Me.gbPrincipal.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlEstoqueMin.ResumeLayout(False)
        Me.pnlEstoqueMin.PerformLayout()
        CType(Me.dgEstoqueBaixo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAcessoRapido.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ConfiguraçõesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProdutosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SobreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusCima As StatusStrip
    Friend WithEvents txtCaption As ToolStripStatusLabel
    Friend WithEvents StatusBaixo As StatusStrip
    Friend WithEvents txtCaptionHora As ToolStripStatusLabel
    Friend WithEvents Timer As Timer
    Friend WithEvents JanelasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents gbPrincipal As GroupBox
    Friend WithEvents EstoqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgEstoqueBaixo As GFT.Util.SuperDataGridView
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents pnlEstoqueMin As Panel
    Friend WithEvents btnEstoqueMin As Button
    Friend WithEvents gbAcessoRapido As GroupBox
    Friend WithEvents btnNovoProdutoPrincipal As Button
    Friend WithEvents ToolTipPrincipal As ToolTip
    Friend WithEvents btnSaidaPrincipal As Button
    Friend WithEvents btnNovoClientePrincipal As Button
    Friend WithEvents btnEntradaPrincipal As Button
    Friend WithEvents btnConsultaVendaPrincipal As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnTotalVendaPrincipal As Button
    Friend WithEvents lblTotalVendas As Label
End Class
