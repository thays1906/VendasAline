<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProdutos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProdutos))
        Me.tabCtrlProduto = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgProduto = New System.Windows.Forms.DataGridView()
        Me.gbFiltroProduto = New System.Windows.Forms.GroupBox()
        Me.txtFiltroProduto = New GFT.Util.SuperTextBox()
        Me.lblFiltroProduto = New System.Windows.Forms.Label()
        Me.gbBotoes = New System.Windows.Forms.GroupBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnCadastrar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.txtFiltroCor = New GFT.Util.SuperTextBox()
        Me.tabCtrlProduto.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFiltroProduto.SuspendLayout()
        Me.gbBotoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabCtrlProduto
        '
        Me.tabCtrlProduto.Controls.Add(Me.TabPage1)
        Me.tabCtrlProduto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabCtrlProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tabCtrlProduto.ImageList = Me.ImageList1
        Me.tabCtrlProduto.Location = New System.Drawing.Point(0, 0)
        Me.tabCtrlProduto.Name = "tabCtrlProduto"
        Me.tabCtrlProduto.Padding = New System.Drawing.Point(50, 10)
        Me.tabCtrlProduto.SelectedIndex = 0
        Me.tabCtrlProduto.Size = New System.Drawing.Size(1053, 719)
        Me.tabCtrlProduto.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgProduto)
        Me.TabPage1.Controls.Add(Me.gbFiltroProduto)
        Me.TabPage1.ImageIndex = 0
        Me.TabPage1.Location = New System.Drawing.Point(4, 69)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1045, 646)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Consulta"
        Me.TabPage1.UseVisualStyleBackColor = True
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
        Me.dgProduto.Location = New System.Drawing.Point(43, 148)
        Me.dgProduto.Name = "dgProduto"
        Me.dgProduto.RowHeadersWidth = 51
        Me.dgProduto.RowTemplate.Height = 24
        Me.dgProduto.Size = New System.Drawing.Size(946, 402)
        Me.dgProduto.TabIndex = 1
        '
        'gbFiltroProduto
        '
        Me.gbFiltroProduto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbFiltroProduto.Controls.Add(Me.txtFiltroCor)
        Me.gbFiltroProduto.Controls.Add(Me.txtFiltroProduto)
        Me.gbFiltroProduto.Controls.Add(Me.lblFiltroProduto)
        Me.gbFiltroProduto.Location = New System.Drawing.Point(43, 25)
        Me.gbFiltroProduto.Name = "gbFiltroProduto"
        Me.gbFiltroProduto.Size = New System.Drawing.Size(946, 117)
        Me.gbFiltroProduto.TabIndex = 0
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
        Me.txtFiltroProduto.Size = New System.Drawing.Size(188, 30)
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
        Me.lblFiltroProduto.Location = New System.Drawing.Point(70, 41)
        Me.lblFiltroProduto.Name = "lblFiltroProduto"
        Me.lblFiltroProduto.Size = New System.Drawing.Size(86, 25)
        Me.lblFiltroProduto.TabIndex = 0
        Me.lblFiltroProduto.Text = "Produto:"
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
        Me.gbBotoes.Location = New System.Drawing.Point(0, 625)
        Me.gbBotoes.Name = "gbBotoes"
        Me.gbBotoes.Size = New System.Drawing.Size(1053, 94)
        Me.gbBotoes.TabIndex = 1
        Me.gbBotoes.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "iconSapato.png")
        '
        'btnCadastrar
        '
        Me.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrar.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnCadastrar.Image = Global.ControleVendas.My.Resources.Resources.iconAddBlue
        Me.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCadastrar.Location = New System.Drawing.Point(221, 21)
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
        Me.btnExcluir.Location = New System.Drawing.Point(639, 21)
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
        Me.btnFechar.Location = New System.Drawing.Point(850, 21)
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
        Me.btnEditar.Location = New System.Drawing.Point(430, 21)
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
        Me.btnPesquisar.Location = New System.Drawing.Point(12, 21)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(203, 42)
        Me.btnPesquisar.TabIndex = 0
        Me.btnPesquisar.Text = " &Pesquisar"
        Me.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'txtFiltroCor
        '
        Me.txtFiltroCor.Alterado = False
        Me.txtFiltroCor.BackColor = System.Drawing.Color.White
        Me.txtFiltroCor.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtFiltroCor.Location = New System.Drawing.Point(285, 70)
        Me.txtFiltroCor.Name = "txtFiltroCor"
        Me.txtFiltroCor.Size = New System.Drawing.Size(188, 30)
        Me.txtFiltroCor.SuperMascara = ""
        Me.txtFiltroCor.SuperObrigatorio = False
        Me.txtFiltroCor.SuperTravaErrors = False
        Me.txtFiltroCor.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtFiltroCor.SuperTxtObrigatorio = ""
        Me.txtFiltroCor.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtFiltroCor.TabIndex = 2
        '
        'frmProdutos
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1053, 719)
        Me.Controls.Add(Me.gbBotoes)
        Me.Controls.Add(Me.tabCtrlProduto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProdutos"
        Me.Text = "frmProdutos"
        Me.tabCtrlProduto.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFiltroProduto.ResumeLayout(False)
        Me.gbFiltroProduto.PerformLayout()
        Me.gbBotoes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabCtrlProduto As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dgProduto As DataGridView
    Friend WithEvents gbFiltroProduto As GroupBox
    Friend WithEvents gbBotoes As GroupBox
    Friend WithEvents btnCadastrar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnFechar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents lblFiltroProduto As Label
    Friend WithEvents txtFiltroProduto As GFT.Util.SuperTextBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents txtFiltroCor As GFT.Util.SuperTextBox
End Class
