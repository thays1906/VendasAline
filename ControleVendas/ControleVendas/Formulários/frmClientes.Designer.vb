<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientes))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbBotoes = New System.Windows.Forms.GroupBox()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnCadastrar = New System.Windows.Forms.Button()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.imgListCliente = New System.Windows.Forms.ImageList(Me.components)
        Me.tabCTrlCliente = New GFT.Util.SuperTabControl()
        Me.tpConsulta = New System.Windows.Forms.TabPage()
        Me.chkMarcaTodos = New System.Windows.Forms.CheckBox()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.txtLetreiro = New GFT.Util.SuperLetreiro()
        Me.dgCliente = New GFT.Util.SuperDataGridView()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.gbFiltroProduto = New System.Windows.Forms.GroupBox()
        Me.chkFiltrarPorData = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtFim = New GFT.Util.SuperDatePicker()
        Me.dtInicio = New GFT.Util.SuperDatePicker()
        Me.lblDataFimFiltro = New System.Windows.Forms.Label()
        Me.lblDataInicioFiltro = New System.Windows.Forms.Label()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.cbCidade = New GFT.Util.SuperComboBox()
        Me.cbEstado = New GFT.Util.SuperComboBox()
        Me.txtCliente = New GFT.Util.SuperTextBox()
        Me.lblFiltroCliente = New System.Windows.Forms.Label()
        Me.gbBotoes.SuspendLayout()
        Me.tabCTrlCliente.SuspendLayout()
        Me.tpConsulta.SuspendLayout()
        CType(Me.dgCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFiltroProduto.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbBotoes
        '
        Me.gbBotoes.Controls.Add(Me.btnFechar)
        Me.gbBotoes.Controls.Add(Me.btnExcluir)
        Me.gbBotoes.Controls.Add(Me.btnEditar)
        Me.gbBotoes.Controls.Add(Me.btnCadastrar)
        Me.gbBotoes.Controls.Add(Me.btnPesquisar)
        Me.gbBotoes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbBotoes.Location = New System.Drawing.Point(0, 650)
        Me.gbBotoes.Name = "gbBotoes"
        Me.gbBotoes.Size = New System.Drawing.Size(1326, 64)
        Me.gbBotoes.TabIndex = 1
        Me.gbBotoes.TabStop = False
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnFechar.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.btnFechar.Image = Global.ControleVendas.My.Resources.Resources.iconClose
        Me.btnFechar.Location = New System.Drawing.Point(1024, 10)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(203, 42)
        Me.btnFechar.TabIndex = 12
        Me.btnFechar.Text = " &Fechar"
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExcluir.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.btnExcluir.Image = Global.ControleVendas.My.Resources.Resources.iconExcluir
        Me.btnExcluir.Location = New System.Drawing.Point(792, 10)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(203, 42)
        Me.btnExcluir.TabIndex = 11
        Me.btnExcluir.Text = " &Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnEditar.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.btnEditar.Image = Global.ControleVendas.My.Resources.Resources.iconEditar
        Me.btnEditar.Location = New System.Drawing.Point(558, 10)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(203, 42)
        Me.btnEditar.TabIndex = 10
        Me.btnEditar.Text = " &Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnCadastrar
        '
        Me.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCadastrar.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.btnCadastrar.Image = Global.ControleVendas.My.Resources.Resources.iconAddBlue
        Me.btnCadastrar.Location = New System.Drawing.Point(319, 11)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(203, 42)
        Me.btnCadastrar.TabIndex = 9
        Me.btnCadastrar.Text = " &Cadastrar"
        Me.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCadastrar.UseVisualStyleBackColor = True
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnPesquisar.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.btnPesquisar.Image = Global.ControleVendas.My.Resources.Resources.iconePesquisar
        Me.btnPesquisar.Location = New System.Drawing.Point(81, 11)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(203, 42)
        Me.btnPesquisar.TabIndex = 8
        Me.btnPesquisar.Text = " &Pesquisar"
        Me.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'imgListCliente
        '
        Me.imgListCliente.ImageStream = CType(resources.GetObject("imgListCliente.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgListCliente.TransparentColor = System.Drawing.Color.Transparent
        Me.imgListCliente.Images.SetKeyName(0, "iconCliente.png")
        '
        'tabCTrlCliente
        '
        Me.tabCTrlCliente.Controls.Add(Me.tpConsulta)
        Me.tabCTrlCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabCTrlCliente.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabCTrlCliente.ImageList = Me.imgListCliente
        Me.tabCTrlCliente.Location = New System.Drawing.Point(0, 0)
        Me.tabCTrlCliente.Name = "tabCTrlCliente"
        Me.tabCTrlCliente.Padding = New System.Drawing.Point(100, 10)
        Me.tabCTrlCliente.SelectedIndex = 0
        Me.tabCTrlCliente.Size = New System.Drawing.Size(1326, 650)
        Me.tabCTrlCliente.TabIndex = 2
        '
        'tpConsulta
        '
        Me.tpConsulta.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.tpConsulta.Controls.Add(Me.chkMarcaTodos)
        Me.tpConsulta.Controls.Add(Me.btnExportar)
        Me.tpConsulta.Controls.Add(Me.txtLetreiro)
        Me.tpConsulta.Controls.Add(Me.dgCliente)
        Me.tpConsulta.Controls.Add(Me.gbFiltroProduto)
        Me.tpConsulta.ImageIndex = 0
        Me.tpConsulta.Location = New System.Drawing.Point(4, 69)
        Me.tpConsulta.Name = "tpConsulta"
        Me.tpConsulta.Padding = New System.Windows.Forms.Padding(3)
        Me.tpConsulta.Size = New System.Drawing.Size(1318, 577)
        Me.tpConsulta.TabIndex = 0
        Me.tpConsulta.Text = "Clientes"
        '
        'chkMarcaTodos
        '
        Me.chkMarcaTodos.AutoSize = True
        Me.chkMarcaTodos.Location = New System.Drawing.Point(25, 160)
        Me.chkMarcaTodos.Name = "chkMarcaTodos"
        Me.chkMarcaTodos.Size = New System.Drawing.Size(281, 29)
        Me.chkMarcaTodos.TabIndex = 6
        Me.chkMarcaTodos.Text = "Marcar/Desmarcar todos"
        Me.chkMarcaTodos.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExportar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnExportar.FlatAppearance.BorderSize = 2
        Me.btnExportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.btnExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportar.Image = Global.ControleVendas.My.Resources.Resources.iconExcel
        Me.btnExportar.Location = New System.Drawing.Point(1239, 530)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(55, 41)
        Me.btnExportar.TabIndex = 7
        Me.btnExportar.UseVisualStyleBackColor = False
        '
        'txtLetreiro
        '
        Me.txtLetreiro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtLetreiro.CorSombraTexto = System.Drawing.Color.White
        Me.txtLetreiro.Location = New System.Drawing.Point(25, 537)
        Me.txtLetreiro.Name = "txtLetreiro"
        Me.txtLetreiro.RolagemLetreiro = GFT.Util.SuperLetreiro.Direcao.Esquerda
        Me.txtLetreiro.Size = New System.Drawing.Size(306, 27)
        Me.txtLetreiro.TabIndex = 6
        Me.txtLetreiro.TextoLetreiro = "0,00 Registros"
        Me.txtLetreiro.VelocidadeRolagem = 1
        '
        'dgCliente
        '
        Me.dgCliente.AdicionarCheckBox = True
        Me.dgCliente.AllowUserToAddRows = False
        Me.dgCliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgCliente.BackgroundColor = System.Drawing.Color.White
        Me.dgCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.dgCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.LightSlateGray
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgCliente.ColumnHeadersHeight = 50
        Me.dgCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1})
        Me.dgCliente.CorDoFundoCabeçalho = System.Drawing.Color.LightSlateGray
        Me.dgCliente.CorTextoCabeçalho = System.Drawing.Color.White
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgCliente.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgCliente.EnableHeadersVisualStyles = False
        Me.dgCliente.Location = New System.Drawing.Point(26, 189)
        Me.dgCliente.Name = "dgCliente"
        Me.dgCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgCliente.RowHeadersVisible = False
        Me.dgCliente.RowHeadersWidth = 51
        Me.dgCliente.RowTemplate.Height = 24
        Me.dgCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCliente.Size = New System.Drawing.Size(1268, 338)
        Me.dgCliente.TabIndex = 5
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Selecionar"
        Me.DataGridViewCheckBoxColumn1.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 50
        '
        'gbFiltroProduto
        '
        Me.gbFiltroProduto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbFiltroProduto.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.gbFiltroProduto.Controls.Add(Me.chkFiltrarPorData)
        Me.gbFiltroProduto.Controls.Add(Me.GroupBox1)
        Me.gbFiltroProduto.Controls.Add(Me.lblCidade)
        Me.gbFiltroProduto.Controls.Add(Me.lblEstado)
        Me.gbFiltroProduto.Controls.Add(Me.cbCidade)
        Me.gbFiltroProduto.Controls.Add(Me.cbEstado)
        Me.gbFiltroProduto.Controls.Add(Me.txtCliente)
        Me.gbFiltroProduto.Controls.Add(Me.lblFiltroCliente)
        Me.gbFiltroProduto.Location = New System.Drawing.Point(26, 3)
        Me.gbFiltroProduto.Name = "gbFiltroProduto"
        Me.gbFiltroProduto.Size = New System.Drawing.Size(1268, 142)
        Me.gbFiltroProduto.TabIndex = 4
        Me.gbFiltroProduto.TabStop = False
        Me.gbFiltroProduto.Text = "Filtrar"
        '
        'chkFiltrarPorData
        '
        Me.chkFiltrarPorData.AutoSize = True
        Me.chkFiltrarPorData.Location = New System.Drawing.Point(874, 16)
        Me.chkFiltrarPorData.Name = "chkFiltrarPorData"
        Me.chkFiltrarPorData.Size = New System.Drawing.Size(241, 29)
        Me.chkFiltrarPorData.TabIndex = 3
        Me.chkFiltrarPorData.Text = "Por data de cadastro"
        Me.chkFiltrarPorData.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtFim)
        Me.GroupBox1.Controls.Add(Me.dtInicio)
        Me.GroupBox1.Controls.Add(Me.lblDataFimFiltro)
        Me.GroupBox1.Controls.Add(Me.lblDataInicioFiltro)
        Me.GroupBox1.Location = New System.Drawing.Point(874, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(388, 103)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'dtFim
        '
        Me.dtFim.Alterado = False
        Me.dtFim.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtFim.BackColor = System.Drawing.Color.White
        Me.dtFim.Enabled = False
        Me.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFim.Location = New System.Drawing.Point(211, 50)
        Me.dtFim.Name = "dtFim"
        Me.dtFim.Size = New System.Drawing.Size(171, 32)
        Me.dtFim.TabIndex = 5
        '
        'dtInicio
        '
        Me.dtInicio.Alterado = False
        Me.dtInicio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtInicio.BackColor = System.Drawing.Color.White
        Me.dtInicio.Enabled = False
        Me.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtInicio.Location = New System.Drawing.Point(23, 51)
        Me.dtInicio.Name = "dtInicio"
        Me.dtInicio.Size = New System.Drawing.Size(171, 32)
        Me.dtInicio.TabIndex = 4
        '
        'lblDataFimFiltro
        '
        Me.lblDataFimFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDataFimFiltro.AutoSize = True
        Me.lblDataFimFiltro.Location = New System.Drawing.Point(206, 26)
        Me.lblDataFimFiltro.Name = "lblDataFimFiltro"
        Me.lblDataFimFiltro.Size = New System.Drawing.Size(46, 25)
        Me.lblDataFimFiltro.TabIndex = 9
        Me.lblDataFimFiltro.Text = "Até"
        '
        'lblDataInicioFiltro
        '
        Me.lblDataInicioFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDataInicioFiltro.AutoSize = True
        Me.lblDataInicioFiltro.Location = New System.Drawing.Point(18, 26)
        Me.lblDataInicioFiltro.Name = "lblDataInicioFiltro"
        Me.lblDataInicioFiltro.Size = New System.Drawing.Size(39, 25)
        Me.lblDataInicioFiltro.TabIndex = 8
        Me.lblDataInicioFiltro.Text = "De"
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Location = New System.Drawing.Point(575, 55)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(80, 25)
        Me.lblCidade.TabIndex = 5
        Me.lblCidade.Text = "Cidade"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(441, 55)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(39, 25)
        Me.lblEstado.TabIndex = 4
        Me.lblEstado.Text = "UF"
        '
        'cbCidade
        '
        Me.cbCidade.Alterado = False
        Me.cbCidade.CorFundo = System.Drawing.Color.White
        Me.cbCidade.CorFundoSelecionado = System.Drawing.Color.White
        Me.cbCidade.CorTexto = System.Drawing.Color.Black
        Me.cbCidade.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbCidade.FormattingEnabled = True
        Me.cbCidade.Location = New System.Drawing.Point(580, 83)
        Me.cbCidade.MaxDropDownItems = 10
        Me.cbCidade.Name = "cbCidade"
        Me.cbCidade.Size = New System.Drawing.Size(278, 33)
        Me.cbCidade.SuperObrigatorio = False
        Me.cbCidade.SuperTxtObrigatorio = ""
        Me.cbCidade.TabIndex = 2
        '
        'cbEstado
        '
        Me.cbEstado.Alterado = False
        Me.cbEstado.CorFundo = System.Drawing.Color.White
        Me.cbEstado.CorFundoSelecionado = System.Drawing.Color.White
        Me.cbEstado.CorTexto = System.Drawing.Color.Black
        Me.cbEstado.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Location = New System.Drawing.Point(446, 83)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(116, 33)
        Me.cbEstado.SuperObrigatorio = False
        Me.cbEstado.SuperTxtObrigatorio = ""
        Me.cbEstado.TabIndex = 1
        '
        'txtCliente
        '
        Me.txtCliente.Alterado = False
        Me.txtCliente.BackColor = System.Drawing.Color.White
        Me.txtCliente.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCliente.Location = New System.Drawing.Point(21, 84)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(409, 32)
        Me.txtCliente.SuperMascara = ""
        Me.txtCliente.SuperObrigatorio = False
        Me.txtCliente.SuperTravaErrors = False
        Me.txtCliente.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtCliente.SuperTxtObrigatorio = ""
        Me.txtCliente.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtCliente.TabIndex = 0
        '
        'lblFiltroCliente
        '
        Me.lblFiltroCliente.AutoSize = True
        Me.lblFiltroCliente.Location = New System.Drawing.Point(16, 55)
        Me.lblFiltroCliente.Name = "lblFiltroCliente"
        Me.lblFiltroCliente.Size = New System.Drawing.Size(92, 25)
        Me.lblFiltroCliente.TabIndex = 0
        Me.lblFiltroCliente.Text = "Cliente:"
        '
        'frmClientes
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1326, 714)
        Me.Controls.Add(Me.tabCTrlCliente)
        Me.Controls.Add(Me.gbBotoes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmClientes"
        Me.gbBotoes.ResumeLayout(False)
        Me.tabCTrlCliente.ResumeLayout(False)
        Me.tpConsulta.ResumeLayout(False)
        Me.tpConsulta.PerformLayout()
        CType(Me.dgCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFiltroProduto.ResumeLayout(False)
        Me.gbFiltroProduto.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbBotoes As GroupBox
    Friend WithEvents btnFechar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnCadastrar As Button
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents tabCTrlCliente As GFT.Util.SuperTabControl
    Friend WithEvents tpConsulta As TabPage
    Friend WithEvents txtLetreiro As GFT.Util.SuperLetreiro
    Friend WithEvents dgCliente As GFT.Util.SuperDataGridView
    Friend WithEvents gbFiltroProduto As GroupBox
    Friend WithEvents lblFiltroCliente As Label
    Friend WithEvents chkMarcaTodos As CheckBox
    Friend WithEvents btnExportar As Button
    Friend WithEvents txtCliente As GFT.Util.SuperTextBox
    Friend WithEvents chkFiltrarPorData As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtFim As GFT.Util.SuperDatePicker
    Friend WithEvents dtInicio As GFT.Util.SuperDatePicker
    Friend WithEvents lblDataFimFiltro As Label
    Friend WithEvents lblDataInicioFiltro As Label
    Friend WithEvents lblCidade As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents cbCidade As GFT.Util.SuperComboBox
    Friend WithEvents cbEstado As GFT.Util.SuperComboBox
    Friend WithEvents imgListCliente As ImageList
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
End Class
