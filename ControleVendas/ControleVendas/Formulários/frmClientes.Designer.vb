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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbBotoes = New System.Windows.Forms.GroupBox()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnCadastrar = New System.Windows.Forms.Button()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.tabCTrlCliente = New GFT.Util.SuperTabControl()
        Me.tpConsulta = New System.Windows.Forms.TabPage()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.txtLetreiro = New GFT.Util.SuperLetreiro()
        Me.dgCliente = New GFT.Util.SuperDataGridView()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.gbFiltroProduto = New System.Windows.Forms.GroupBox()
        Me.lblFiltroCliente = New System.Windows.Forms.Label()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txtCliente = New GFT.Util.SuperTextBox()
        Me.gbBotoes.SuspendLayout()
        Me.tabCTrlCliente.SuspendLayout()
        Me.tpConsulta.SuspendLayout()
        CType(Me.dgCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFiltroProduto.SuspendLayout()
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
        Me.gbBotoes.Size = New System.Drawing.Size(1222, 64)
        Me.gbBotoes.TabIndex = 1
        Me.gbBotoes.TabStop = False
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnFechar.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.btnFechar.Image = Global.ControleVendas.My.Resources.Resources.iconClose
        Me.btnFechar.Location = New System.Drawing.Point(972, 10)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(203, 42)
        Me.btnFechar.TabIndex = 4
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
        Me.btnExcluir.Location = New System.Drawing.Point(740, 10)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(203, 42)
        Me.btnExcluir.TabIndex = 3
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
        Me.btnEditar.Location = New System.Drawing.Point(506, 10)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(203, 42)
        Me.btnEditar.TabIndex = 2
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
        Me.btnCadastrar.Location = New System.Drawing.Point(267, 11)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(203, 42)
        Me.btnCadastrar.TabIndex = 1
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
        Me.btnPesquisar.Location = New System.Drawing.Point(29, 11)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(203, 42)
        Me.btnPesquisar.TabIndex = 0
        Me.btnPesquisar.Text = " &Pesquisar"
        Me.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'tabCTrlCliente
        '
        Me.tabCTrlCliente.Controls.Add(Me.tpConsulta)
        Me.tabCTrlCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabCTrlCliente.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabCTrlCliente.Location = New System.Drawing.Point(0, 0)
        Me.tabCTrlCliente.Name = "tabCTrlCliente"
        Me.tabCTrlCliente.Padding = New System.Drawing.Point(100, 10)
        Me.tabCTrlCliente.SelectedIndex = 0
        Me.tabCTrlCliente.Size = New System.Drawing.Size(1222, 650)
        Me.tabCTrlCliente.TabIndex = 2
        '
        'tpConsulta
        '
        Me.tpConsulta.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.tpConsulta.Controls.Add(Me.CheckBox1)
        Me.tpConsulta.Controls.Add(Me.btnExportar)
        Me.tpConsulta.Controls.Add(Me.txtLetreiro)
        Me.tpConsulta.Controls.Add(Me.dgCliente)
        Me.tpConsulta.Controls.Add(Me.gbFiltroProduto)
        Me.tpConsulta.Location = New System.Drawing.Point(4, 48)
        Me.tpConsulta.Name = "tpConsulta"
        Me.tpConsulta.Padding = New System.Windows.Forms.Padding(3)
        Me.tpConsulta.Size = New System.Drawing.Size(1214, 598)
        Me.tpConsulta.TabIndex = 0
        Me.tpConsulta.Text = "Clientes"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(25, 151)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(260, 29)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "Marcar/Desmcar todos"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportar.FlatAppearance.BorderSize = 0
        Me.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportar.Image = Global.ControleVendas.My.Resources.Resources.iconExcel
        Me.btnExportar.Location = New System.Drawing.Point(1135, 146)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(55, 41)
        Me.btnExportar.TabIndex = 7
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'txtLetreiro
        '
        Me.txtLetreiro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtLetreiro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLetreiro.CorSombraTexto = System.Drawing.Color.White
        Me.txtLetreiro.Location = New System.Drawing.Point(25, 558)
        Me.txtLetreiro.Name = "txtLetreiro"
        Me.txtLetreiro.RolagemLetreiro = GFT.Util.SuperLetreiro.Direcao.Direita
        Me.txtLetreiro.Size = New System.Drawing.Size(306, 27)
        Me.txtLetreiro.TabIndex = 6
        Me.txtLetreiro.TextoLetreiro = ""
        Me.txtLetreiro.VelocidadeRolagem = 5
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSlateGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn2, Me.DataGridViewCheckBoxColumn1})
        Me.dgCliente.CorDoFundoCabeçalho = System.Drawing.Color.LightSlateGray
        Me.dgCliente.CorTextoCabeçalho = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgCliente.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgCliente.EnableHeadersVisualStyles = False
        Me.dgCliente.Location = New System.Drawing.Point(26, 189)
        Me.dgCliente.Name = "dgCliente"
        Me.dgCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgCliente.RowHeadersVisible = False
        Me.dgCliente.RowHeadersWidth = 51
        Me.dgCliente.RowTemplate.Height = 24
        Me.dgCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCliente.Size = New System.Drawing.Size(1164, 359)
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
        Me.gbFiltroProduto.Controls.Add(Me.txtCliente)
        Me.gbFiltroProduto.Controls.Add(Me.lblFiltroCliente)
        Me.gbFiltroProduto.Location = New System.Drawing.Point(26, 30)
        Me.gbFiltroProduto.Name = "gbFiltroProduto"
        Me.gbFiltroProduto.Size = New System.Drawing.Size(1164, 117)
        Me.gbFiltroProduto.TabIndex = 4
        Me.gbFiltroProduto.TabStop = False
        Me.gbFiltroProduto.Text = "Filtrar"
        '
        'lblFiltroCliente
        '
        Me.lblFiltroCliente.AutoSize = True
        Me.lblFiltroCliente.Location = New System.Drawing.Point(70, 40)
        Me.lblFiltroCliente.Name = "lblFiltroCliente"
        Me.lblFiltroCliente.Size = New System.Drawing.Size(92, 25)
        Me.lblFiltroCliente.TabIndex = 0
        Me.lblFiltroCliente.Text = "Cliente:"
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Selecionar"
        Me.DataGridViewCheckBoxColumn2.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Width = 50
        '
        'txtCliente
        '
        Me.txtCliente.Alterado = False
        Me.txtCliente.BackColor = System.Drawing.Color.White
        Me.txtCliente.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtCliente.Location = New System.Drawing.Point(67, 74)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(409, 32)
        Me.txtCliente.SuperMascara = ""
        Me.txtCliente.SuperObrigatorio = False
        Me.txtCliente.SuperTravaErrors = False
        Me.txtCliente.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtCliente.SuperTxtObrigatorio = ""
        Me.txtCliente.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtCliente.TabIndex = 1
        '
        'frmClientes
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1222, 714)
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
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents btnExportar As Button
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents txtCliente As GFT.Util.SuperTextBox
End Class
