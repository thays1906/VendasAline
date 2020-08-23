<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEstoque
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEstoque))
        Me.tabCtrlEstoque = New System.Windows.Forms.TabControl()
        Me.tpConsulta = New System.Windows.Forms.TabPage()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.gbEstoqueFiltro = New GFT.Util.SuperGroupBox()
        Me.gbMovimentacao = New System.Windows.Forms.GroupBox()
        Me.gbSaida = New System.Windows.Forms.GroupBox()
        Me.lblSaidaInicial = New System.Windows.Forms.Label()
        Me.lblSaidaFinal = New System.Windows.Forms.Label()
        Me.dtSaidaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtSaidaInicial = New System.Windows.Forms.DateTimePicker()
        Me.chkSaida = New System.Windows.Forms.CheckBox()
        Me.gbEntrada = New System.Windows.Forms.GroupBox()
        Me.lblEntradaInicial = New System.Windows.Forms.Label()
        Me.lblEntradaFinal = New System.Windows.Forms.Label()
        Me.dtEntradaInicial = New System.Windows.Forms.DateTimePicker()
        Me.chkEntrada = New System.Windows.Forms.CheckBox()
        Me.dtEntradaFinal = New System.Windows.Forms.DateTimePicker()
        Me.lblTamanho = New System.Windows.Forms.Label()
        Me.cbTamanho = New GFT.Util.SuperComboBox()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.txtProduto = New GFT.Util.SuperTextBox()
        Me.dgEstoque = New GFT.Util.SuperDataGridView()
        Me.txtLetreiro = New GFT.Util.SuperLetreiro()
        Me.imgListEstoque = New System.Windows.Forms.ImageList(Me.components)
        Me.gbBotoes = New GFT.Util.SuperGroupBox()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnSaida = New System.Windows.Forms.Button()
        Me.btnEntrada = New System.Windows.Forms.Button()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.tabCtrlEstoque.SuspendLayout()
        Me.tpConsulta.SuspendLayout()
        Me.gbEstoqueFiltro.SuspendLayout()
        Me.gbMovimentacao.SuspendLayout()
        Me.gbSaida.SuspendLayout()
        Me.gbEntrada.SuspendLayout()
        CType(Me.dgEstoque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBotoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabCtrlEstoque
        '
        Me.tabCtrlEstoque.Controls.Add(Me.tpConsulta)
        Me.tabCtrlEstoque.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabCtrlEstoque.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabCtrlEstoque.ImageList = Me.imgListEstoque
        Me.tabCtrlEstoque.Location = New System.Drawing.Point(0, 0)
        Me.tabCtrlEstoque.Name = "tabCtrlEstoque"
        Me.tabCtrlEstoque.Padding = New System.Drawing.Point(50, 10)
        Me.tabCtrlEstoque.SelectedIndex = 0
        Me.tabCtrlEstoque.Size = New System.Drawing.Size(1281, 693)
        Me.tabCtrlEstoque.TabIndex = 0
        '
        'tpConsulta
        '
        Me.tpConsulta.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.tpConsulta.Controls.Add(Me.btnExportar)
        Me.tpConsulta.Controls.Add(Me.gbEstoqueFiltro)
        Me.tpConsulta.Controls.Add(Me.dgEstoque)
        Me.tpConsulta.Controls.Add(Me.txtLetreiro)
        Me.tpConsulta.ImageIndex = 0
        Me.tpConsulta.Location = New System.Drawing.Point(4, 69)
        Me.tpConsulta.Name = "tpConsulta"
        Me.tpConsulta.Padding = New System.Windows.Forms.Padding(3)
        Me.tpConsulta.Size = New System.Drawing.Size(1273, 620)
        Me.tpConsulta.TabIndex = 0
        Me.tpConsulta.Text = "Consulta de Estoque"
        '
        'btnExportar
        '
        Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportar.BackColor = System.Drawing.Color.White
        Me.btnExportar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnExportar.FlatAppearance.BorderSize = 2
        Me.btnExportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportar.Image = Global.ControleVendas.My.Resources.Resources.iconExcel
        Me.btnExportar.Location = New System.Drawing.Point(1184, 565)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(63, 45)
        Me.btnExportar.TabIndex = 6
        Me.btnExportar.Text = " &Exportar"
        Me.btnExportar.UseVisualStyleBackColor = False
        '
        'gbEstoqueFiltro
        '
        Me.gbEstoqueFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbEstoqueFiltro.BackColor = System.Drawing.SystemColors.Control
        Me.gbEstoqueFiltro.BorderCollor = System.Drawing.Color.Empty
        Me.gbEstoqueFiltro.Controls.Add(Me.gbMovimentacao)
        Me.gbEstoqueFiltro.Controls.Add(Me.lblTamanho)
        Me.gbEstoqueFiltro.Controls.Add(Me.cbTamanho)
        Me.gbEstoqueFiltro.Controls.Add(Me.lblProduto)
        Me.gbEstoqueFiltro.Controls.Add(Me.txtProduto)
        Me.gbEstoqueFiltro.Location = New System.Drawing.Point(25, 6)
        Me.gbEstoqueFiltro.Name = "gbEstoqueFiltro"
        Me.gbEstoqueFiltro.Size = New System.Drawing.Size(1222, 175)
        Me.gbEstoqueFiltro.TabIndex = 2
        Me.gbEstoqueFiltro.TabStop = False
        Me.gbEstoqueFiltro.Text = "Filtrar"
        '
        'gbMovimentacao
        '
        Me.gbMovimentacao.BackColor = System.Drawing.Color.Gainsboro
        Me.gbMovimentacao.Controls.Add(Me.gbSaida)
        Me.gbMovimentacao.Controls.Add(Me.gbEntrada)
        Me.gbMovimentacao.Location = New System.Drawing.Point(540, 14)
        Me.gbMovimentacao.Name = "gbMovimentacao"
        Me.gbMovimentacao.Size = New System.Drawing.Size(682, 155)
        Me.gbMovimentacao.TabIndex = 4
        Me.gbMovimentacao.TabStop = False
        Me.gbMovimentacao.Text = "Por Movimentação"
        '
        'gbSaida
        '
        Me.gbSaida.BackColor = System.Drawing.Color.Transparent
        Me.gbSaida.Controls.Add(Me.lblSaidaInicial)
        Me.gbSaida.Controls.Add(Me.lblSaidaFinal)
        Me.gbSaida.Controls.Add(Me.dtSaidaFinal)
        Me.gbSaida.Controls.Add(Me.dtSaidaInicial)
        Me.gbSaida.Controls.Add(Me.chkSaida)
        Me.gbSaida.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbSaida.Location = New System.Drawing.Point(321, 31)
        Me.gbSaida.Name = "gbSaida"
        Me.gbSaida.Size = New System.Drawing.Size(307, 124)
        Me.gbSaida.TabIndex = 11
        Me.gbSaida.TabStop = False
        '
        'lblSaidaInicial
        '
        Me.lblSaidaInicial.AutoSize = True
        Me.lblSaidaInicial.Location = New System.Drawing.Point(20, 49)
        Me.lblSaidaInicial.Name = "lblSaidaInicial"
        Me.lblSaidaInicial.Size = New System.Drawing.Size(39, 25)
        Me.lblSaidaInicial.TabIndex = 9
        Me.lblSaidaInicial.Text = "De"
        '
        'lblSaidaFinal
        '
        Me.lblSaidaFinal.AutoSize = True
        Me.lblSaidaFinal.Location = New System.Drawing.Point(21, 87)
        Me.lblSaidaFinal.Name = "lblSaidaFinal"
        Me.lblSaidaFinal.Size = New System.Drawing.Size(46, 25)
        Me.lblSaidaFinal.TabIndex = 10
        Me.lblSaidaFinal.Text = "Até"
        '
        'dtSaidaFinal
        '
        Me.dtSaidaFinal.Checked = False
        Me.dtSaidaFinal.Enabled = False
        Me.dtSaidaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtSaidaFinal.Location = New System.Drawing.Point(73, 80)
        Me.dtSaidaFinal.Name = "dtSaidaFinal"
        Me.dtSaidaFinal.Size = New System.Drawing.Size(203, 32)
        Me.dtSaidaFinal.TabIndex = 5
        '
        'dtSaidaInicial
        '
        Me.dtSaidaInicial.Checked = False
        Me.dtSaidaInicial.Enabled = False
        Me.dtSaidaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtSaidaInicial.Location = New System.Drawing.Point(73, 42)
        Me.dtSaidaInicial.Name = "dtSaidaInicial"
        Me.dtSaidaInicial.Size = New System.Drawing.Size(203, 32)
        Me.dtSaidaInicial.TabIndex = 4
        '
        'chkSaida
        '
        Me.chkSaida.AutoSize = True
        Me.chkSaida.Location = New System.Drawing.Point(6, 6)
        Me.chkSaida.Name = "chkSaida"
        Me.chkSaida.Size = New System.Drawing.Size(90, 29)
        Me.chkSaida.TabIndex = 7
        Me.chkSaida.Text = "Saída"
        Me.chkSaida.UseVisualStyleBackColor = True
        '
        'gbEntrada
        '
        Me.gbEntrada.BackColor = System.Drawing.Color.Transparent
        Me.gbEntrada.Controls.Add(Me.lblEntradaInicial)
        Me.gbEntrada.Controls.Add(Me.lblEntradaFinal)
        Me.gbEntrada.Controls.Add(Me.dtEntradaInicial)
        Me.gbEntrada.Controls.Add(Me.chkEntrada)
        Me.gbEntrada.Controls.Add(Me.dtEntradaFinal)
        Me.gbEntrada.Location = New System.Drawing.Point(6, 31)
        Me.gbEntrada.Name = "gbEntrada"
        Me.gbEntrada.Size = New System.Drawing.Size(309, 118)
        Me.gbEntrada.TabIndex = 8
        Me.gbEntrada.TabStop = False
        '
        'lblEntradaInicial
        '
        Me.lblEntradaInicial.AutoSize = True
        Me.lblEntradaInicial.Location = New System.Drawing.Point(6, 49)
        Me.lblEntradaInicial.Name = "lblEntradaInicial"
        Me.lblEntradaInicial.Size = New System.Drawing.Size(39, 25)
        Me.lblEntradaInicial.TabIndex = 9
        Me.lblEntradaInicial.Text = "De"
        '
        'lblEntradaFinal
        '
        Me.lblEntradaFinal.AutoSize = True
        Me.lblEntradaFinal.Location = New System.Drawing.Point(6, 87)
        Me.lblEntradaFinal.Name = "lblEntradaFinal"
        Me.lblEntradaFinal.Size = New System.Drawing.Size(46, 25)
        Me.lblEntradaFinal.TabIndex = 10
        Me.lblEntradaFinal.Text = "Até"
        '
        'dtEntradaInicial
        '
        Me.dtEntradaInicial.Checked = False
        Me.dtEntradaInicial.Enabled = False
        Me.dtEntradaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtEntradaInicial.Location = New System.Drawing.Point(58, 42)
        Me.dtEntradaInicial.Name = "dtEntradaInicial"
        Me.dtEntradaInicial.Size = New System.Drawing.Size(203, 32)
        Me.dtEntradaInicial.TabIndex = 2
        '
        'chkEntrada
        '
        Me.chkEntrada.AutoSize = True
        Me.chkEntrada.Location = New System.Drawing.Point(6, 0)
        Me.chkEntrada.Name = "chkEntrada"
        Me.chkEntrada.Size = New System.Drawing.Size(113, 29)
        Me.chkEntrada.TabIndex = 7
        Me.chkEntrada.Text = "Entrada"
        Me.chkEntrada.UseVisualStyleBackColor = True
        '
        'dtEntradaFinal
        '
        Me.dtEntradaFinal.Checked = False
        Me.dtEntradaFinal.Enabled = False
        Me.dtEntradaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtEntradaFinal.Location = New System.Drawing.Point(58, 80)
        Me.dtEntradaFinal.Name = "dtEntradaFinal"
        Me.dtEntradaFinal.Size = New System.Drawing.Size(203, 32)
        Me.dtEntradaFinal.TabIndex = 3
        '
        'lblTamanho
        '
        Me.lblTamanho.AutoSize = True
        Me.lblTamanho.Location = New System.Drawing.Point(313, 58)
        Me.lblTamanho.Name = "lblTamanho"
        Me.lblTamanho.Size = New System.Drawing.Size(103, 25)
        Me.lblTamanho.TabIndex = 3
        Me.lblTamanho.Text = "Tamanho"
        '
        'cbTamanho
        '
        Me.cbTamanho.Alterado = False
        Me.cbTamanho.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbTamanho.CorFundo = System.Drawing.Color.White
        Me.cbTamanho.CorFundoSelecionado = System.Drawing.Color.White
        Me.cbTamanho.CorTexto = System.Drawing.Color.Black
        Me.cbTamanho.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbTamanho.FormattingEnabled = True
        Me.cbTamanho.Location = New System.Drawing.Point(318, 90)
        Me.cbTamanho.Name = "cbTamanho"
        Me.cbTamanho.Size = New System.Drawing.Size(181, 33)
        Me.cbTamanho.SuperObrigatorio = False
        Me.cbTamanho.SuperTxtObrigatorio = ""
        Me.cbTamanho.TabIndex = 1
        '
        'lblProduto
        '
        Me.lblProduto.AutoSize = True
        Me.lblProduto.Location = New System.Drawing.Point(6, 58)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(90, 25)
        Me.lblProduto.TabIndex = 1
        Me.lblProduto.Text = "Produto"
        '
        'txtProduto
        '
        Me.txtProduto.Alterado = False
        Me.txtProduto.BackColor = System.Drawing.Color.White
        Me.txtProduto.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtProduto.Location = New System.Drawing.Point(11, 90)
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.Size = New System.Drawing.Size(301, 32)
        Me.txtProduto.SuperMascara = ""
        Me.txtProduto.SuperObrigatorio = False
        Me.txtProduto.SuperTravaErrors = False
        Me.txtProduto.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtProduto.SuperTxtObrigatorio = ""
        Me.txtProduto.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtProduto.TabIndex = 0
        '
        'dgEstoque
        '
        Me.dgEstoque.AdicionarCheckBox = True
        Me.dgEstoque.AllowUserToAddRows = False
        Me.dgEstoque.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgEstoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgEstoque.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgEstoque.BackgroundColor = System.Drawing.Color.White
        Me.dgEstoque.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgEstoque.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.dgEstoque.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSlateGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgEstoque.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgEstoque.ColumnHeadersHeight = 50
        Me.dgEstoque.CorDoFundoCabeçalho = System.Drawing.Color.LightSlateGray
        Me.dgEstoque.CorTextoCabeçalho = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgEstoque.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgEstoque.EnableHeadersVisualStyles = False
        Me.dgEstoque.Location = New System.Drawing.Point(25, 187)
        Me.dgEstoque.MultiSelect = False
        Me.dgEstoque.Name = "dgEstoque"
        Me.dgEstoque.ReadOnly = True
        Me.dgEstoque.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgEstoque.RowHeadersVisible = False
        Me.dgEstoque.RowHeadersWidth = 51
        Me.dgEstoque.RowTemplate.Height = 24
        Me.dgEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgEstoque.Size = New System.Drawing.Size(1222, 360)
        Me.dgEstoque.TabIndex = 1
        '
        'txtLetreiro
        '
        Me.txtLetreiro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtLetreiro.CorSombraTexto = System.Drawing.Color.White
        Me.txtLetreiro.Location = New System.Drawing.Point(25, 578)
        Me.txtLetreiro.Name = "txtLetreiro"
        Me.txtLetreiro.RolagemLetreiro = GFT.Util.SuperLetreiro.Direcao.Esquerda
        Me.txtLetreiro.Size = New System.Drawing.Size(242, 32)
        Me.txtLetreiro.TabIndex = 0
        Me.txtLetreiro.TextoLetreiro = "0,0"
        Me.txtLetreiro.VelocidadeRolagem = 1
        '
        'imgListEstoque
        '
        Me.imgListEstoque.ImageStream = CType(resources.GetObject("imgListEstoque.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgListEstoque.TransparentColor = System.Drawing.Color.Transparent
        Me.imgListEstoque.Images.SetKeyName(0, "iconProduct.png")
        '
        'gbBotoes
        '
        Me.gbBotoes.BackColor = System.Drawing.SystemColors.Control
        Me.gbBotoes.BorderCollor = System.Drawing.Color.Empty
        Me.gbBotoes.Controls.Add(Me.btnFechar)
        Me.gbBotoes.Controls.Add(Me.btnSaida)
        Me.gbBotoes.Controls.Add(Me.btnEntrada)
        Me.gbBotoes.Controls.Add(Me.btnPesquisar)
        Me.gbBotoes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbBotoes.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBotoes.Location = New System.Drawing.Point(0, 693)
        Me.gbBotoes.Name = "gbBotoes"
        Me.gbBotoes.Size = New System.Drawing.Size(1281, 79)
        Me.gbBotoes.TabIndex = 3
        Me.gbBotoes.TabStop = False
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnFechar.Image = Global.ControleVendas.My.Resources.Resources.iconClose
        Me.btnFechar.Location = New System.Drawing.Point(937, 20)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(223, 53)
        Me.btnFechar.TabIndex = 10
        Me.btnFechar.Text = " &Fechar"
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'btnSaida
        '
        Me.btnSaida.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSaida.Image = Global.ControleVendas.My.Resources.Resources.iconSaida
        Me.btnSaida.Location = New System.Drawing.Point(684, 20)
        Me.btnSaida.Name = "btnSaida"
        Me.btnSaida.Size = New System.Drawing.Size(223, 53)
        Me.btnSaida.TabIndex = 9
        Me.btnSaida.Text = " &Saida"
        Me.btnSaida.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSaida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaida.UseVisualStyleBackColor = True
        '
        'btnEntrada
        '
        Me.btnEntrada.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnEntrada.Image = Global.ControleVendas.My.Resources.Resources.iconeEntrada
        Me.btnEntrada.Location = New System.Drawing.Point(427, 20)
        Me.btnEntrada.Name = "btnEntrada"
        Me.btnEntrada.Size = New System.Drawing.Size(223, 53)
        Me.btnEntrada.TabIndex = 8
        Me.btnEntrada.Text = " &Entrada"
        Me.btnEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEntrada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEntrada.UseVisualStyleBackColor = True
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnPesquisar.Image = Global.ControleVendas.My.Resources.Resources.iconePesquisar
        Me.btnPesquisar.Location = New System.Drawing.Point(167, 20)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(223, 53)
        Me.btnPesquisar.TabIndex = 7
        Me.btnPesquisar.Text = " &Pesquisar"
        Me.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'frmEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1281, 772)
        Me.Controls.Add(Me.tabCtrlEstoque)
        Me.Controls.Add(Me.gbBotoes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEstoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmEstoque"
        Me.tabCtrlEstoque.ResumeLayout(False)
        Me.tpConsulta.ResumeLayout(False)
        Me.gbEstoqueFiltro.ResumeLayout(False)
        Me.gbEstoqueFiltro.PerformLayout()
        Me.gbMovimentacao.ResumeLayout(False)
        Me.gbSaida.ResumeLayout(False)
        Me.gbSaida.PerformLayout()
        Me.gbEntrada.ResumeLayout(False)
        Me.gbEntrada.PerformLayout()
        CType(Me.dgEstoque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBotoes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabCtrlEstoque As TabControl
    Friend WithEvents tpConsulta As TabPage
    Friend WithEvents dgEstoque As GFT.Util.SuperDataGridView
    Friend WithEvents txtLetreiro As GFT.Util.SuperLetreiro
    Friend WithEvents imgListEstoque As ImageList
    Friend WithEvents gbEstoqueFiltro As GFT.Util.SuperGroupBox
    Friend WithEvents gbBotoes As GFT.Util.SuperGroupBox
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents btnExportar As Button
    Friend WithEvents btnSaida As Button
    Friend WithEvents btnEntrada As Button
    Friend WithEvents btnFechar As Button
    Friend WithEvents gbMovimentacao As GroupBox
    Friend WithEvents lblTamanho As Label
    Friend WithEvents cbTamanho As GFT.Util.SuperComboBox
    Friend WithEvents lblProduto As Label
    Friend WithEvents txtProduto As GFT.Util.SuperTextBox
    Friend WithEvents dtSaidaFinal As DateTimePicker
    Friend WithEvents dtSaidaInicial As DateTimePicker
    Friend WithEvents dtEntradaInicial As DateTimePicker
    Friend WithEvents gbSaida As GroupBox
    Friend WithEvents lblSaidaInicial As Label
    Friend WithEvents lblSaidaFinal As Label
    Friend WithEvents chkSaida As CheckBox
    Friend WithEvents gbEntrada As GroupBox
    Friend WithEvents lblEntradaInicial As Label
    Friend WithEvents lblEntradaFinal As Label
    Friend WithEvents chkEntrada As CheckBox
    Friend WithEvents dtEntradaFinal As DateTimePicker
End Class
