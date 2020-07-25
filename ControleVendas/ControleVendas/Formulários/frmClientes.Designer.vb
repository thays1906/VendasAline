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
        Me.tabCtrlCliente = New System.Windows.Forms.TabControl()
        Me.tabConsulta = New System.Windows.Forms.TabPage()
        Me.gbBotoes = New System.Windows.Forms.GroupBox()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnCadastrar = New System.Windows.Forms.Button()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.dgProduto = New System.Windows.Forms.DataGridView()
        Me.gbFiltroProduto = New System.Windows.Forms.GroupBox()
        Me.txtFiltroProduto = New GFT.Util.SuperTextBox()
        Me.lblFiltroCliente = New System.Windows.Forms.Label()
        Me.Produto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Custo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstoqueMin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabCtrlCliente.SuspendLayout()
        Me.tabConsulta.SuspendLayout()
        Me.gbBotoes.SuspendLayout()
        CType(Me.dgProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFiltroProduto.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabCtrlCliente
        '
        Me.tabCtrlCliente.Controls.Add(Me.tabConsulta)
        Me.tabCtrlCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabCtrlCliente.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.tabCtrlCliente.Location = New System.Drawing.Point(0, 0)
        Me.tabCtrlCliente.Name = "tabCtrlCliente"
        Me.tabCtrlCliente.Padding = New System.Drawing.Point(50, 10)
        Me.tabCtrlCliente.SelectedIndex = 0
        Me.tabCtrlCliente.Size = New System.Drawing.Size(1222, 714)
        Me.tabCtrlCliente.TabIndex = 0
        '
        'tabConsulta
        '
        Me.tabConsulta.Controls.Add(Me.dgProduto)
        Me.tabConsulta.Controls.Add(Me.gbFiltroProduto)
        Me.tabConsulta.Location = New System.Drawing.Point(4, 48)
        Me.tabConsulta.Name = "tabConsulta"
        Me.tabConsulta.Padding = New System.Windows.Forms.Padding(3)
        Me.tabConsulta.Size = New System.Drawing.Size(1214, 662)
        Me.tabConsulta.TabIndex = 0
        Me.tabConsulta.Text = "Consulta"
        Me.tabConsulta.UseVisualStyleBackColor = True
        '
        'gbBotoes
        '
        Me.gbBotoes.Controls.Add(Me.btnFechar)
        Me.gbBotoes.Controls.Add(Me.btnExcluir)
        Me.gbBotoes.Controls.Add(Me.btnEditar)
        Me.gbBotoes.Controls.Add(Me.btnCadastrar)
        Me.gbBotoes.Controls.Add(Me.btnPesquisar)
        Me.gbBotoes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbBotoes.Location = New System.Drawing.Point(0, 614)
        Me.gbBotoes.Name = "gbBotoes"
        Me.gbBotoes.Size = New System.Drawing.Size(1222, 100)
        Me.gbBotoes.TabIndex = 1
        Me.gbBotoes.TabStop = False
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnFechar.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.btnFechar.Image = Global.ControleVendas.My.Resources.Resources.iconClose
        Me.btnFechar.Location = New System.Drawing.Point(924, 41)
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
        Me.btnExcluir.Location = New System.Drawing.Point(715, 41)
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
        Me.btnEditar.Location = New System.Drawing.Point(503, 41)
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
        Me.btnCadastrar.Location = New System.Drawing.Point(294, 41)
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
        Me.btnPesquisar.Location = New System.Drawing.Point(85, 41)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(203, 42)
        Me.btnPesquisar.TabIndex = 0
        Me.btnPesquisar.Text = " &Pesquisar"
        Me.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'dgProduto
        '
        Me.dgProduto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgProduto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgProduto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.dgProduto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProduto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Produto, Me.Quantidade, Me.Valor, Me.Custo, Me.EstoqueMin})
        Me.dgProduto.Location = New System.Drawing.Point(61, 145)
        Me.dgProduto.Name = "dgProduto"
        Me.dgProduto.RowHeadersWidth = 51
        Me.dgProduto.RowTemplate.Height = 24
        Me.dgProduto.Size = New System.Drawing.Size(1092, 415)
        Me.dgProduto.TabIndex = 3
        '
        'gbFiltroProduto
        '
        Me.gbFiltroProduto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbFiltroProduto.Controls.Add(Me.txtFiltroProduto)
        Me.gbFiltroProduto.Controls.Add(Me.lblFiltroCliente)
        Me.gbFiltroProduto.Location = New System.Drawing.Point(61, 22)
        Me.gbFiltroProduto.Name = "gbFiltroProduto"
        Me.gbFiltroProduto.Size = New System.Drawing.Size(1092, 117)
        Me.gbFiltroProduto.TabIndex = 2
        Me.gbFiltroProduto.TabStop = False
        Me.gbFiltroProduto.Text = "Filtrar"
        '
        'txtFiltroProduto
        '
        Me.txtFiltroProduto.Alterado = False
        Me.txtFiltroProduto.BackColor = System.Drawing.Color.White
        Me.txtFiltroProduto.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtFiltroProduto.Location = New System.Drawing.Point(75, 70)
        Me.txtFiltroProduto.Name = "txtFiltroProduto"
        Me.txtFiltroProduto.Size = New System.Drawing.Size(270, 32)
        Me.txtFiltroProduto.SuperMascara = ""
        Me.txtFiltroProduto.SuperObrigatorio = False
        Me.txtFiltroProduto.SuperTravaErrors = False
        Me.txtFiltroProduto.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtFiltroProduto.SuperTxtObrigatorio = ""
        Me.txtFiltroProduto.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtFiltroProduto.TabIndex = 1
        '
        'lblFiltroCliente
        '
        Me.lblFiltroCliente.AutoSize = True
        Me.lblFiltroCliente.Location = New System.Drawing.Point(70, 41)
        Me.lblFiltroCliente.Name = "lblFiltroCliente"
        Me.lblFiltroCliente.Size = New System.Drawing.Size(92, 25)
        Me.lblFiltroCliente.TabIndex = 0
        Me.lblFiltroCliente.Text = "Cliente:"
        '
        'Produto
        '
        Me.Produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Produto.HeaderText = "Cliente"
        Me.Produto.MinimumWidth = 6
        Me.Produto.Name = "Produto"
        '
        'Quantidade
        '
        Me.Quantidade.HeaderText = "Telefone"
        Me.Quantidade.MinimumWidth = 6
        Me.Quantidade.Name = "Quantidade"
        '
        'Valor
        '
        Me.Valor.HeaderText = "Endereço"
        Me.Valor.MinimumWidth = 6
        Me.Valor.Name = "Valor"
        '
        'Custo
        '
        Me.Custo.HeaderText = "Status"
        Me.Custo.MinimumWidth = 6
        Me.Custo.Name = "Custo"
        '
        'EstoqueMin
        '
        Me.EstoqueMin.HeaderText = "Nivel"
        Me.EstoqueMin.MinimumWidth = 6
        Me.EstoqueMin.Name = "EstoqueMin"
        '
        'frmClientes
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1222, 714)
        Me.Controls.Add(Me.gbBotoes)
        Me.Controls.Add(Me.tabCtrlCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmClientes"
        Me.tabCtrlCliente.ResumeLayout(False)
        Me.tabConsulta.ResumeLayout(False)
        Me.gbBotoes.ResumeLayout(False)
        CType(Me.dgProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFiltroProduto.ResumeLayout(False)
        Me.gbFiltroProduto.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabCtrlCliente As TabControl
    Friend WithEvents tabConsulta As TabPage
    Friend WithEvents gbBotoes As GroupBox
    Friend WithEvents btnFechar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnCadastrar As Button
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents dgProduto As DataGridView
    Friend WithEvents Produto As DataGridViewTextBoxColumn
    Friend WithEvents Quantidade As DataGridViewTextBoxColumn
    Friend WithEvents Valor As DataGridViewTextBoxColumn
    Friend WithEvents Custo As DataGridViewTextBoxColumn
    Friend WithEvents EstoqueMin As DataGridViewTextBoxColumn
    Friend WithEvents gbFiltroProduto As GroupBox
    Friend WithEvents txtFiltroProduto As GFT.Util.SuperTextBox
    Friend WithEvents lblFiltroCliente As Label
End Class
