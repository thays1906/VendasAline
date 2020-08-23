<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNovoProduto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNovoProduto))
        Me.tabCtrlCadastroProd = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.pnlProduto = New System.Windows.Forms.Panel()
        Me.lblProdObg = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAddImg = New System.Windows.Forms.Button()
        Me.lblTamanho = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picProduto = New System.Windows.Forms.PictureBox()
        Me.btnCalculadora = New System.Windows.Forms.Button()
        Me.cbTamanho = New GFT.Util.SuperComboBox()
        Me.lblData = New System.Windows.Forms.Label()
        Me.dtEntrada = New GFT.Util.SuperDatePicker()
        Me.lblEstoqueMin = New System.Windows.Forms.Label()
        Me.txtEstoqueMin = New GFT.Util.SuperTextBox()
        Me.lblCusto = New System.Windows.Forms.Label()
        Me.txtCusto = New GFT.Util.SuperTextBox()
        Me.lblCor = New System.Windows.Forms.Label()
        Me.txtCor = New GFT.Util.SuperTextBox()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.txtValor = New GFT.Util.SuperTextBox()
        Me.lblEstoqueIdeal = New System.Windows.Forms.Label()
        Me.txtEstoqueIdeal = New GFT.Util.SuperTextBox()
        Me.txtProduto = New GFT.Util.SuperTextBox()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.tpHistorico = New System.Windows.Forms.TabPage()
        Me.ImageListNovoProduto = New System.Windows.Forms.ImageList(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.tabCtrlCadastroProd.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.pnlProduto.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.picProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabCtrlCadastroProd
        '
        Me.tabCtrlCadastroProd.Controls.Add(Me.TabPage1)
        Me.tabCtrlCadastroProd.Controls.Add(Me.tpHistorico)
        Me.tabCtrlCadastroProd.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.tabCtrlCadastroProd.ImageList = Me.ImageListNovoProduto
        Me.tabCtrlCadastroProd.Location = New System.Drawing.Point(44, 39)
        Me.tabCtrlCadastroProd.Name = "tabCtrlCadastroProd"
        Me.tabCtrlCadastroProd.Padding = New System.Drawing.Point(50, 6)
        Me.tabCtrlCadastroProd.SelectedIndex = 0
        Me.tabCtrlCadastroProd.Size = New System.Drawing.Size(943, 518)
        Me.tabCtrlCadastroProd.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage1.Controls.Add(Me.pnlProduto)
        Me.TabPage1.ImageIndex = 0
        Me.TabPage1.Location = New System.Drawing.Point(4, 61)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(935, 453)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Novo Produto"
        '
        'pnlProduto
        '
        Me.pnlProduto.AutoScroll = True
        Me.pnlProduto.BackColor = System.Drawing.SystemColors.Control
        Me.pnlProduto.Controls.Add(Me.lblProdObg)
        Me.pnlProduto.Controls.Add(Me.btnRemove)
        Me.pnlProduto.Controls.Add(Me.btnAddImg)
        Me.pnlProduto.Controls.Add(Me.lblTamanho)
        Me.pnlProduto.Controls.Add(Me.Panel1)
        Me.pnlProduto.Controls.Add(Me.btnCalculadora)
        Me.pnlProduto.Controls.Add(Me.cbTamanho)
        Me.pnlProduto.Controls.Add(Me.lblData)
        Me.pnlProduto.Controls.Add(Me.dtEntrada)
        Me.pnlProduto.Controls.Add(Me.lblEstoqueMin)
        Me.pnlProduto.Controls.Add(Me.txtEstoqueMin)
        Me.pnlProduto.Controls.Add(Me.lblCusto)
        Me.pnlProduto.Controls.Add(Me.txtCusto)
        Me.pnlProduto.Controls.Add(Me.lblCor)
        Me.pnlProduto.Controls.Add(Me.txtCor)
        Me.pnlProduto.Controls.Add(Me.lblValor)
        Me.pnlProduto.Controls.Add(Me.txtValor)
        Me.pnlProduto.Controls.Add(Me.lblEstoqueIdeal)
        Me.pnlProduto.Controls.Add(Me.txtEstoqueIdeal)
        Me.pnlProduto.Controls.Add(Me.txtProduto)
        Me.pnlProduto.Controls.Add(Me.lblProduto)
        Me.pnlProduto.Location = New System.Drawing.Point(34, 29)
        Me.pnlProduto.Name = "pnlProduto"
        Me.pnlProduto.Size = New System.Drawing.Size(868, 405)
        Me.pnlProduto.TabIndex = 0
        '
        'lblProdObg
        '
        Me.lblProdObg.AutoSize = True
        Me.lblProdObg.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdObg.ForeColor = System.Drawing.Color.Red
        Me.lblProdObg.Location = New System.Drawing.Point(6, 145)
        Me.lblProdObg.Name = "lblProdObg"
        Me.lblProdObg.Size = New System.Drawing.Size(65, 20)
        Me.lblProdObg.TabIndex = 38
        Me.lblProdObg.Text = "Label1"
        Me.lblProdObg.Visible = False
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemove.BackColor = System.Drawing.Color.Transparent
        Me.btnRemove.FlatAppearance.BorderSize = 0
        Me.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Image = CType(resources.GetObject("btnRemove.Image"), System.Drawing.Image)
        Me.btnRemove.Location = New System.Drawing.Point(818, 346)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(47, 43)
        Me.btnRemove.TabIndex = 10
        Me.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRemove.UseVisualStyleBackColor = False
        Me.btnRemove.Visible = False
        '
        'btnAddImg
        '
        Me.btnAddImg.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnAddImg.FlatAppearance.BorderSize = 0
        Me.btnAddImg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnAddImg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btnAddImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddImg.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddImg.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnAddImg.Image = CType(resources.GetObject("btnAddImg.Image"), System.Drawing.Image)
        Me.btnAddImg.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAddImg.Location = New System.Drawing.Point(577, 346)
        Me.btnAddImg.Name = "btnAddImg"
        Me.btnAddImg.Size = New System.Drawing.Size(240, 43)
        Me.btnAddImg.TabIndex = 9
        Me.btnAddImg.Text = " &Selecionar imagem"
        Me.btnAddImg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddImg.UseVisualStyleBackColor = False
        '
        'lblTamanho
        '
        Me.lblTamanho.AutoSize = True
        Me.lblTamanho.Location = New System.Drawing.Point(262, 168)
        Me.lblTamanho.Name = "lblTamanho"
        Me.lblTamanho.Size = New System.Drawing.Size(103, 25)
        Me.lblTamanho.TabIndex = 34
        Me.lblTamanho.Text = "Tamanho"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.picProduto)
        Me.Panel1.Location = New System.Drawing.Point(577, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(288, 263)
        Me.Panel1.TabIndex = 37
        '
        'picProduto
        '
        Me.picProduto.ErrorImage = Global.ControleVendas.My.Resources.Resources.iconSapato256
        Me.picProduto.Image = Global.ControleVendas.My.Resources.Resources.iconSapato256
        Me.picProduto.Location = New System.Drawing.Point(0, 0)
        Me.picProduto.Name = "picProduto"
        Me.picProduto.Size = New System.Drawing.Size(256, 256)
        Me.picProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picProduto.TabIndex = 36
        Me.picProduto.TabStop = False
        '
        'btnCalculadora
        '
        Me.btnCalculadora.FlatAppearance.BorderSize = 0
        Me.btnCalculadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculadora.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculadora.Image = Global.ControleVendas.My.Resources.Resources.iconCalculadora
        Me.btnCalculadora.Location = New System.Drawing.Point(476, 323)
        Me.btnCalculadora.Name = "btnCalculadora"
        Me.btnCalculadora.Size = New System.Drawing.Size(45, 45)
        Me.btnCalculadora.TabIndex = 8
        Me.btnCalculadora.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCalculadora.UseVisualStyleBackColor = True
        '
        'cbTamanho
        '
        Me.cbTamanho.Alterado = False
        Me.cbTamanho.CorFundo = System.Drawing.Color.White
        Me.cbTamanho.CorFundoSelecionado = System.Drawing.Color.White
        Me.cbTamanho.CorTexto = System.Drawing.Color.Black
        Me.cbTamanho.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbTamanho.FormattingEnabled = True
        Me.cbTamanho.Location = New System.Drawing.Point(267, 193)
        Me.cbTamanho.Name = "cbTamanho"
        Me.cbTamanho.Size = New System.Drawing.Size(167, 33)
        Me.cbTamanho.SuperObrigatorio = False
        Me.cbTamanho.SuperTxtObrigatorio = ""
        Me.cbTamanho.TabIndex = 3
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(5, 6)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(182, 25)
        Me.lblData.TabIndex = 33
        Me.lblData.Text = "Data de cadastro"
        '
        'dtEntrada
        '
        Me.dtEntrada.Alterado = False
        Me.dtEntrada.BackColor = System.Drawing.Color.White
        Me.dtEntrada.CustomFormat = "dd/MM/yyyy h:m"
        Me.dtEntrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtEntrada.Location = New System.Drawing.Point(10, 34)
        Me.dtEntrada.Name = "dtEntrada"
        Me.dtEntrada.Size = New System.Drawing.Size(168, 32)
        Me.dtEntrada.TabIndex = 0
        '
        'lblEstoqueMin
        '
        Me.lblEstoqueMin.AutoSize = True
        Me.lblEstoqueMin.Location = New System.Drawing.Point(262, 238)
        Me.lblEstoqueMin.Name = "lblEstoqueMin"
        Me.lblEstoqueMin.Size = New System.Drawing.Size(172, 25)
        Me.lblEstoqueMin.TabIndex = 32
        Me.lblEstoqueMin.Text = "Estoque Mínimo"
        '
        'txtEstoqueMin
        '
        Me.txtEstoqueMin.Alterado = False
        Me.txtEstoqueMin.BackColor = System.Drawing.Color.White
        Me.txtEstoqueMin.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEstoqueMin.Location = New System.Drawing.Point(267, 266)
        Me.txtEstoqueMin.Name = "txtEstoqueMin"
        Me.txtEstoqueMin.Size = New System.Drawing.Size(203, 32)
        Me.txtEstoqueMin.SuperMascara = ""
        Me.txtEstoqueMin.SuperObrigatorio = False
        Me.txtEstoqueMin.SuperTravaErrors = False
        Me.txtEstoqueMin.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtEstoqueMin.SuperTxtObrigatorio = ""
        Me.txtEstoqueMin.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosInteiros
        Me.txtEstoqueMin.TabIndex = 5
        '
        'lblCusto
        '
        Me.lblCusto.AutoSize = True
        Me.lblCusto.Location = New System.Drawing.Point(262, 308)
        Me.lblCusto.Name = "lblCusto"
        Me.lblCusto.Size = New System.Drawing.Size(78, 25)
        Me.lblCusto.TabIndex = 31
        Me.lblCusto.Text = "Custo:"
        '
        'txtCusto
        '
        Me.txtCusto.Alterado = False
        Me.txtCusto.BackColor = System.Drawing.Color.White
        Me.txtCusto.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCusto.Location = New System.Drawing.Point(267, 336)
        Me.txtCusto.Name = "txtCusto"
        Me.txtCusto.Size = New System.Drawing.Size(203, 32)
        Me.txtCusto.SuperMascara = ""
        Me.txtCusto.SuperObrigatorio = False
        Me.txtCusto.SuperTravaErrors = False
        Me.txtCusto.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtCusto.SuperTxtObrigatorio = ""
        Me.txtCusto.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosReais
        Me.txtCusto.TabIndex = 7
        Me.txtCusto.Text = "R$ 0,00"
        '
        'lblCor
        '
        Me.lblCor.AutoSize = True
        Me.lblCor.Location = New System.Drawing.Point(5, 165)
        Me.lblCor.Name = "lblCor"
        Me.lblCor.Size = New System.Drawing.Size(56, 25)
        Me.lblCor.TabIndex = 29
        Me.lblCor.Text = "Cor:"
        '
        'txtCor
        '
        Me.txtCor.Alterado = False
        Me.txtCor.BackColor = System.Drawing.Color.White
        Me.txtCor.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCor.Location = New System.Drawing.Point(10, 193)
        Me.txtCor.Name = "txtCor"
        Me.txtCor.Size = New System.Drawing.Size(203, 32)
        Me.txtCor.SuperMascara = ""
        Me.txtCor.SuperObrigatorio = False
        Me.txtCor.SuperTravaErrors = False
        Me.txtCor.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtCor.SuperTxtObrigatorio = ""
        Me.txtCor.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtCor.TabIndex = 2
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(5, 308)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(173, 25)
        Me.lblValor.TabIndex = 26
        Me.lblValor.Text = "Valor de Venda:"
        '
        'txtValor
        '
        Me.txtValor.Alterado = False
        Me.txtValor.BackColor = System.Drawing.Color.White
        Me.txtValor.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValor.Location = New System.Drawing.Point(10, 336)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(203, 32)
        Me.txtValor.SuperMascara = ""
        Me.txtValor.SuperObrigatorio = False
        Me.txtValor.SuperTravaErrors = False
        Me.txtValor.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtValor.SuperTxtObrigatorio = ""
        Me.txtValor.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosReais
        Me.txtValor.TabIndex = 6
        Me.txtValor.Text = "R$ 0,00"
        '
        'lblEstoqueIdeal
        '
        Me.lblEstoqueIdeal.AutoSize = True
        Me.lblEstoqueIdeal.Location = New System.Drawing.Point(5, 238)
        Me.lblEstoqueIdeal.Name = "lblEstoqueIdeal"
        Me.lblEstoqueIdeal.Size = New System.Drawing.Size(149, 25)
        Me.lblEstoqueIdeal.TabIndex = 23
        Me.lblEstoqueIdeal.Text = "Estoque Ideal"
        '
        'txtEstoqueIdeal
        '
        Me.txtEstoqueIdeal.Alterado = False
        Me.txtEstoqueIdeal.BackColor = System.Drawing.Color.White
        Me.txtEstoqueIdeal.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEstoqueIdeal.Location = New System.Drawing.Point(10, 266)
        Me.txtEstoqueIdeal.Name = "txtEstoqueIdeal"
        Me.txtEstoqueIdeal.Size = New System.Drawing.Size(203, 32)
        Me.txtEstoqueIdeal.SuperMascara = ""
        Me.txtEstoqueIdeal.SuperObrigatorio = False
        Me.txtEstoqueIdeal.SuperTravaErrors = False
        Me.txtEstoqueIdeal.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtEstoqueIdeal.SuperTxtObrigatorio = ""
        Me.txtEstoqueIdeal.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosInteiros
        Me.txtEstoqueIdeal.TabIndex = 4
        '
        'txtProduto
        '
        Me.txtProduto.Alterado = False
        Me.txtProduto.BackColor = System.Drawing.Color.White
        Me.txtProduto.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtProduto.Location = New System.Drawing.Point(10, 112)
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.Size = New System.Drawing.Size(460, 32)
        Me.txtProduto.SuperMascara = ""
        Me.txtProduto.SuperObrigatorio = False
        Me.txtProduto.SuperTravaErrors = False
        Me.txtProduto.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtProduto.SuperTxtObrigatorio = ""
        Me.txtProduto.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtProduto.TabIndex = 1
        '
        'lblProduto
        '
        Me.lblProduto.AutoSize = True
        Me.lblProduto.Location = New System.Drawing.Point(5, 84)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(110, 25)
        Me.lblProduto.TabIndex = 17
        Me.lblProduto.Text = "Produto *"
        '
        'tpHistorico
        '
        Me.tpHistorico.ImageIndex = 1
        Me.tpHistorico.Location = New System.Drawing.Point(4, 61)
        Me.tpHistorico.Name = "tpHistorico"
        Me.tpHistorico.Padding = New System.Windows.Forms.Padding(3)
        Me.tpHistorico.Size = New System.Drawing.Size(935, 453)
        Me.tpHistorico.TabIndex = 1
        Me.tpHistorico.Text = "Histórico"
        Me.tpHistorico.UseVisualStyleBackColor = True
        '
        'ImageListNovoProduto
        '
        Me.ImageListNovoProduto.ImageStream = CType(resources.GetObject("ImageListNovoProduto.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListNovoProduto.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListNovoProduto.Images.SetKeyName(0, "iconSapato.png")
        Me.ImageListNovoProduto.Images.SetKeyName(1, "iconSearchFile.png")
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Title = "Selecione uma Imagem (tamanho ideal 256x256)"
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSalvar.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.btnSalvar.Image = Global.ControleVendas.My.Resources.Resources.iconSalvar1
        Me.btnSalvar.Location = New System.Drawing.Point(400, 559)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(203, 42)
        Me.btnSalvar.TabIndex = 10
        Me.btnSalvar.Text = " &Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFechar.BackColor = System.Drawing.Color.Transparent
        Me.btnFechar.FlatAppearance.BorderSize = 0
        Me.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.Image = Global.ControleVendas.My.Resources.Resources.iconClose
        Me.btnFechar.Location = New System.Drawing.Point(964, -1)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(70, 56)
        Me.btnFechar.TabIndex = 11
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'frmNovoProduto
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1032, 609)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.tabCtrlCadastroProd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmNovoProduto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmNovoProduto"
        Me.tabCtrlCadastroProd.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.pnlProduto.ResumeLayout(False)
        Me.pnlProduto.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabCtrlCadastroProd As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnFechar As Button
    Friend WithEvents ImageListNovoProduto As ImageList
    Friend WithEvents btnSalvar As Button
    Friend WithEvents tpHistorico As TabPage
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents pnlProduto As Panel
    Friend WithEvents picProduto As PictureBox
    Friend WithEvents btnAddImg As Button
    Friend WithEvents cbTamanho As GFT.Util.SuperComboBox
    Friend WithEvents btnCalculadora As Button
    Friend WithEvents lblTamanho As Label
    Friend WithEvents lblData As Label
    Friend WithEvents dtEntrada As GFT.Util.SuperDatePicker
    Friend WithEvents lblEstoqueMin As Label
    Friend WithEvents txtEstoqueMin As GFT.Util.SuperTextBox
    Friend WithEvents lblCusto As Label
    Friend WithEvents txtCusto As GFT.Util.SuperTextBox
    Friend WithEvents lblCor As Label
    Friend WithEvents txtCor As GFT.Util.SuperTextBox
    Friend WithEvents lblValor As Label
    Friend WithEvents txtValor As GFT.Util.SuperTextBox
    Friend WithEvents lblEstoqueIdeal As Label
    Friend WithEvents txtEstoqueIdeal As GFT.Util.SuperTextBox
    Friend WithEvents txtProduto As GFT.Util.SuperTextBox
    Friend WithEvents lblProduto As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRemove As Button
    Friend WithEvents lblProdObg As Label
End Class
