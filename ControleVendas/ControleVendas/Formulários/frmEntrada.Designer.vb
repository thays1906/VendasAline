<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntrada
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlEntrada = New System.Windows.Forms.Panel()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.cbProduto = New GFT.Util.SuperComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtEntrada = New System.Windows.Forms.DateTimePicker()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.txtQuantidade = New GFT.Util.SuperTextBox()
        Me.pnlTela = New System.Windows.Forms.Panel()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.lblProdutoObg = New System.Windows.Forms.Label()
        Me.pnlEntrada.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlTela.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlEntrada
        '
        Me.pnlEntrada.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlEntrada.BackColor = System.Drawing.SystemColors.Control
        Me.pnlEntrada.Controls.Add(Me.lblProdutoObg)
        Me.pnlEntrada.Controls.Add(Me.lblProduto)
        Me.pnlEntrada.Controls.Add(Me.cbProduto)
        Me.pnlEntrada.Controls.Add(Me.Panel1)
        Me.pnlEntrada.Location = New System.Drawing.Point(-2, 51)
        Me.pnlEntrada.Name = "pnlEntrada"
        Me.pnlEntrada.Size = New System.Drawing.Size(770, 271)
        Me.pnlEntrada.TabIndex = 1
        '
        'lblProduto
        '
        Me.lblProduto.AutoSize = True
        Me.lblProduto.Location = New System.Drawing.Point(127, 24)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(99, 25)
        Me.lblProduto.TabIndex = 9
        Me.lblProduto.Text = "Produto:"
        Me.lblProduto.Visible = False
        '
        'cbProduto
        '
        Me.cbProduto.Alterado = False
        Me.cbProduto.CorFundo = System.Drawing.Color.White
        Me.cbProduto.CorFundoSelecionado = System.Drawing.Color.White
        Me.cbProduto.CorTexto = System.Drawing.Color.Black
        Me.cbProduto.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbProduto.FormattingEnabled = True
        Me.cbProduto.Location = New System.Drawing.Point(232, 21)
        Me.cbProduto.Name = "cbProduto"
        Me.cbProduto.Size = New System.Drawing.Size(406, 33)
        Me.cbProduto.SuperObrigatorio = False
        Me.cbProduto.SuperTxtObrigatorio = ""
        Me.cbProduto.TabIndex = 8
        Me.cbProduto.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Panel1.Controls.Add(Me.dtEntrada)
        Me.Panel1.Controls.Add(Me.lblQuantidade)
        Me.Panel1.Controls.Add(Me.lblData)
        Me.Panel1.Controls.Add(Me.txtQuantidade)
        Me.Panel1.Location = New System.Drawing.Point(132, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(506, 175)
        Me.Panel1.TabIndex = 8
        '
        'dtEntrada
        '
        Me.dtEntrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtEntrada.Location = New System.Drawing.Point(212, 14)
        Me.dtEntrada.Name = "dtEntrada"
        Me.dtEntrada.Size = New System.Drawing.Size(180, 32)
        Me.dtEntrada.TabIndex = 4
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Location = New System.Drawing.Point(68, 111)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(128, 25)
        Me.lblQuantidade.TabIndex = 7
        Me.lblQuantidade.Text = "Quantidade"
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.BackColor = System.Drawing.Color.Transparent
        Me.lblData.Location = New System.Drawing.Point(30, 21)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(176, 25)
        Me.lblData.TabIndex = 5
        Me.lblData.Text = "Data de Entrada"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Alterado = False
        Me.txtQuantidade.BackColor = System.Drawing.Color.White
        Me.txtQuantidade.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtQuantidade.Location = New System.Drawing.Point(212, 104)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(180, 32)
        Me.txtQuantidade.SuperMascara = ""
        Me.txtQuantidade.SuperObrigatorio = True
        Me.txtQuantidade.SuperTravaErrors = False
        Me.txtQuantidade.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtQuantidade.SuperTxtObrigatorio = "Quantidade"
        Me.txtQuantidade.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosInteiros
        Me.txtQuantidade.TabIndex = 6
        '
        'pnlTela
        '
        Me.pnlTela.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.pnlTela.Controls.Add(Me.btnFechar)
        Me.pnlTela.Controls.Add(Me.lblTitulo)
        Me.pnlTela.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTela.Location = New System.Drawing.Point(0, 0)
        Me.pnlTela.Name = "pnlTela"
        Me.pnlTela.Size = New System.Drawing.Size(767, 53)
        Me.pnlTela.TabIndex = 2
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFechar.Image = Global.ControleVendas.My.Resources.Resources.iconClose
        Me.btnFechar.Location = New System.Drawing.Point(706, 0)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(62, 53)
        Me.btnFechar.TabIndex = 4
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblTitulo.Location = New System.Drawing.Point(237, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(303, 34)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Entrada de Produtos"
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSalvar.Image = Global.ControleVendas.My.Resources.Resources.iconSalvar1
        Me.btnSalvar.Location = New System.Drawing.Point(272, 333)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(203, 42)
        Me.btnSalvar.TabIndex = 3
        Me.btnSalvar.Text = " &Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'lblProdutoObg
        '
        Me.lblProdutoObg.AutoSize = True
        Me.lblProdutoObg.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdutoObg.ForeColor = System.Drawing.Color.Red
        Me.lblProdutoObg.Location = New System.Drawing.Point(128, 241)
        Me.lblProdutoObg.Name = "lblProdutoObg"
        Me.lblProdutoObg.Size = New System.Drawing.Size(496, 20)
        Me.lblProdutoObg.TabIndex = 10
        Me.lblProdutoObg.Text = "Selecione um produto, para fazer alterações no estoque."
        Me.lblProdutoObg.Visible = False
        '
        'frmEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 387)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.pnlTela)
        Me.Controls.Add(Me.pnlEntrada)
        Me.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmEntrada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmEntrada"
        Me.pnlEntrada.ResumeLayout(False)
        Me.pnlEntrada.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlTela.ResumeLayout(False)
        Me.pnlTela.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlEntrada As Panel
    Friend WithEvents pnlTela As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnFechar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtEntrada As DateTimePicker
    Friend WithEvents lblQuantidade As Label
    Friend WithEvents lblData As Label
    Friend WithEvents txtQuantidade As GFT.Util.SuperTextBox
    Friend WithEvents lblProduto As Label
    Friend WithEvents cbProduto As GFT.Util.SuperComboBox
    Friend WithEvents lblProdutoObg As Label
End Class
