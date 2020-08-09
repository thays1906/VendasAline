<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNovoProduto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNovoProduto))
        Me.tabCtrlCadastroProd = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbDadosProd = New System.Windows.Forms.GroupBox()
        Me.lblEstoqueMin = New System.Windows.Forms.Label()
        Me.txtEstoqueMin = New GFT.Util.SuperTextBox()
        Me.lblCusto = New System.Windows.Forms.Label()
        Me.txtCusto = New GFT.Util.SuperTextBox()
        Me.lblCor = New System.Windows.Forms.Label()
        Me.txtCor = New GFT.Util.SuperTextBox()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.txtValor = New GFT.Util.SuperTextBox()
        Me.lblQtde = New System.Windows.Forms.Label()
        Me.txtQtde = New GFT.Util.SuperTextBox()
        Me.txtProduto = New GFT.Util.SuperTextBox()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.tabCtrlCadastroProd.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDadosProd.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabCtrlCadastroProd
        '
        Me.tabCtrlCadastroProd.Controls.Add(Me.TabPage1)
        Me.tabCtrlCadastroProd.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.tabCtrlCadastroProd.ImageList = Me.ImageList1
        Me.tabCtrlCadastroProd.Location = New System.Drawing.Point(47, 51)
        Me.tabCtrlCadastroProd.Name = "tabCtrlCadastroProd"
        Me.tabCtrlCadastroProd.Padding = New System.Drawing.Point(50, 6)
        Me.tabCtrlCadastroProd.SelectedIndex = 0
        Me.tabCtrlCadastroProd.Size = New System.Drawing.Size(892, 345)
        Me.tabCtrlCadastroProd.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.gbDadosProd)
        Me.TabPage1.ImageIndex = 0
        Me.TabPage1.Location = New System.Drawing.Point(4, 61)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(884, 280)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Novo Produto"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(256, 256)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'gbDadosProd
        '
        Me.gbDadosProd.Controls.Add(Me.lblEstoqueMin)
        Me.gbDadosProd.Controls.Add(Me.txtEstoqueMin)
        Me.gbDadosProd.Controls.Add(Me.lblCusto)
        Me.gbDadosProd.Controls.Add(Me.txtCusto)
        Me.gbDadosProd.Controls.Add(Me.lblCor)
        Me.gbDadosProd.Controls.Add(Me.txtCor)
        Me.gbDadosProd.Controls.Add(Me.lblValor)
        Me.gbDadosProd.Controls.Add(Me.txtValor)
        Me.gbDadosProd.Controls.Add(Me.lblQtde)
        Me.gbDadosProd.Controls.Add(Me.txtQtde)
        Me.gbDadosProd.Controls.Add(Me.txtProduto)
        Me.gbDadosProd.Controls.Add(Me.lblProduto)
        Me.gbDadosProd.Location = New System.Drawing.Point(262, 43)
        Me.gbDadosProd.Name = "gbDadosProd"
        Me.gbDadosProd.Size = New System.Drawing.Size(609, 192)
        Me.gbDadosProd.TabIndex = 0
        Me.gbDadosProd.TabStop = False
        Me.gbDadosProd.Text = "Dados do Produto"
        '
        'lblEstoqueMin
        '
        Me.lblEstoqueMin.AutoSize = True
        Me.lblEstoqueMin.Location = New System.Drawing.Point(239, 116)
        Me.lblEstoqueMin.Name = "lblEstoqueMin"
        Me.lblEstoqueMin.Size = New System.Drawing.Size(151, 25)
        Me.lblEstoqueMin.TabIndex = 11
        Me.lblEstoqueMin.Text = "Estoque Mín.:"
        '
        'txtEstoqueMin
        '
        Me.txtEstoqueMin.Alterado = False
        Me.txtEstoqueMin.BackColor = System.Drawing.Color.White
        Me.txtEstoqueMin.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtEstoqueMin.Location = New System.Drawing.Point(244, 144)
        Me.txtEstoqueMin.Name = "txtEstoqueMin"
        Me.txtEstoqueMin.Size = New System.Drawing.Size(132, 32)
        Me.txtEstoqueMin.SuperMascara = ""
        Me.txtEstoqueMin.SuperObrigatorio = False
        Me.txtEstoqueMin.SuperTravaErrors = False
        Me.txtEstoqueMin.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtEstoqueMin.SuperTxtObrigatorio = ""
        Me.txtEstoqueMin.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosInteiros
        Me.txtEstoqueMin.TabIndex = 10
        '
        'lblCusto
        '
        Me.lblCusto.AutoSize = True
        Me.lblCusto.Location = New System.Drawing.Point(395, 116)
        Me.lblCusto.Name = "lblCusto"
        Me.lblCusto.Size = New System.Drawing.Size(78, 25)
        Me.lblCusto.TabIndex = 9
        Me.lblCusto.Text = "Custo:"
        '
        'txtCusto
        '
        Me.txtCusto.Alterado = False
        Me.txtCusto.BackColor = System.Drawing.Color.White
        Me.txtCusto.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtCusto.Location = New System.Drawing.Point(400, 144)
        Me.txtCusto.Name = "txtCusto"
        Me.txtCusto.Size = New System.Drawing.Size(203, 32)
        Me.txtCusto.SuperMascara = ""
        Me.txtCusto.SuperObrigatorio = False
        Me.txtCusto.SuperTravaErrors = False
        Me.txtCusto.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtCusto.SuperTxtObrigatorio = ""
        Me.txtCusto.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosReais
        Me.txtCusto.TabIndex = 8
        '
        'lblCor
        '
        Me.lblCor.AutoSize = True
        Me.lblCor.Location = New System.Drawing.Point(1, 116)
        Me.lblCor.Name = "lblCor"
        Me.lblCor.Size = New System.Drawing.Size(56, 25)
        Me.lblCor.TabIndex = 7
        Me.lblCor.Text = "Cor:"
        '
        'txtCor
        '
        Me.txtCor.Alterado = False
        Me.txtCor.BackColor = System.Drawing.Color.White
        Me.txtCor.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtCor.Location = New System.Drawing.Point(6, 144)
        Me.txtCor.Name = "txtCor"
        Me.txtCor.Size = New System.Drawing.Size(215, 32)
        Me.txtCor.SuperMascara = ""
        Me.txtCor.SuperObrigatorio = False
        Me.txtCor.SuperTravaErrors = False
        Me.txtCor.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtCor.SuperTxtObrigatorio = ""
        Me.txtCor.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtCor.TabIndex = 6
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(395, 42)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(173, 25)
        Me.lblValor.TabIndex = 5
        Me.lblValor.Text = "Valor de Venda:"
        '
        'txtValor
        '
        Me.txtValor.Alterado = False
        Me.txtValor.BackColor = System.Drawing.Color.White
        Me.txtValor.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtValor.Location = New System.Drawing.Point(400, 70)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(203, 32)
        Me.txtValor.SuperMascara = ""
        Me.txtValor.SuperObrigatorio = False
        Me.txtValor.SuperTravaErrors = False
        Me.txtValor.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtValor.SuperTxtObrigatorio = ""
        Me.txtValor.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosReais
        Me.txtValor.TabIndex = 4
        '
        'lblQtde
        '
        Me.lblQtde.AutoSize = True
        Me.lblQtde.Location = New System.Drawing.Point(239, 42)
        Me.lblQtde.Name = "lblQtde"
        Me.lblQtde.Size = New System.Drawing.Size(137, 25)
        Me.lblQtde.TabIndex = 3
        Me.lblQtde.Text = "Quantidade:"
        '
        'txtQtde
        '
        Me.txtQtde.Alterado = False
        Me.txtQtde.BackColor = System.Drawing.Color.White
        Me.txtQtde.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtQtde.Location = New System.Drawing.Point(244, 70)
        Me.txtQtde.Name = "txtQtde"
        Me.txtQtde.Size = New System.Drawing.Size(132, 32)
        Me.txtQtde.SuperMascara = ""
        Me.txtQtde.SuperObrigatorio = False
        Me.txtQtde.SuperTravaErrors = False
        Me.txtQtde.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtQtde.SuperTxtObrigatorio = ""
        Me.txtQtde.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosInteiros
        Me.txtQtde.TabIndex = 2
        '
        'txtProduto
        '
        Me.txtProduto.Alterado = False
        Me.txtProduto.BackColor = System.Drawing.Color.White
        Me.txtProduto.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtProduto.Location = New System.Drawing.Point(6, 70)
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.Size = New System.Drawing.Size(215, 32)
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
        Me.lblProduto.Location = New System.Drawing.Point(1, 42)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(99, 25)
        Me.lblProduto.TabIndex = 0
        Me.lblProduto.Text = "Produto:"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "iconSapato.png")
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSalvar.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.btnSalvar.Image = Global.ControleVendas.My.Resources.Resources.iconSalvar
        Me.btnSalvar.Location = New System.Drawing.Point(360, 416)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(203, 42)
        Me.btnSalvar.TabIndex = 2
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
        Me.btnFechar.Location = New System.Drawing.Point(920, -1)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(70, 56)
        Me.btnFechar.TabIndex = 1
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'frmNovoProduto
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(988, 470)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.tabCtrlCadastroProd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmNovoProduto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmNovoProduto"
        Me.tabCtrlCadastroProd.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDadosProd.ResumeLayout(False)
        Me.gbDadosProd.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabCtrlCadastroProd As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnFechar As Button
    Friend WithEvents gbDadosProd As GroupBox
    Friend WithEvents lblCor As Label
    Friend WithEvents txtCor As GFT.Util.SuperTextBox
    Friend WithEvents lblValor As Label
    Friend WithEvents txtValor As GFT.Util.SuperTextBox
    Friend WithEvents lblQtde As Label
    Friend WithEvents txtQtde As GFT.Util.SuperTextBox
    Friend WithEvents txtProduto As GFT.Util.SuperTextBox
    Friend WithEvents lblProduto As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents btnSalvar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblCusto As Label
    Friend WithEvents txtCusto As GFT.Util.SuperTextBox
    Friend WithEvents lblEstoqueMin As Label
    Friend WithEvents txtEstoqueMin As GFT.Util.SuperTextBox
End Class
