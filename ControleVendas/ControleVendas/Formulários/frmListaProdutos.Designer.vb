<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaProdutos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaProdutos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlCima = New System.Windows.Forms.Panel()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.gbFiltroListProd = New System.Windows.Forms.GroupBox()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.pnlBaixo = New System.Windows.Forms.Panel()
        Me.txtProdutoFiltro = New GFT.Util.SuperTextBox()
        Me.dgTodosProd = New GFT.Util.SuperDataGridView()
        Me.txtLetreiroListaProd = New GFT.Util.SuperLetreiro()
        Me.pnlCima.SuspendLayout()
        Me.gbFiltroListProd.SuspendLayout()
        Me.pnlBaixo.SuspendLayout()
        CType(Me.dgTodosProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlCima
        '
        Me.pnlCima.Controls.Add(Me.btnFechar)
        Me.pnlCima.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCima.Location = New System.Drawing.Point(0, 0)
        Me.pnlCima.Margin = New System.Windows.Forms.Padding(5)
        Me.pnlCima.Name = "pnlCima"
        Me.pnlCima.Size = New System.Drawing.Size(1039, 50)
        Me.pnlCima.TabIndex = 1
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFechar.Image = CType(resources.GetObject("btnFechar.Image"), System.Drawing.Image)
        Me.btnFechar.Location = New System.Drawing.Point(983, 0)
        Me.btnFechar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(56, 50)
        Me.btnFechar.TabIndex = 14
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'gbFiltroListProd
        '
        Me.gbFiltroListProd.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.gbFiltroListProd.Controls.Add(Me.lblProduto)
        Me.gbFiltroListProd.Controls.Add(Me.txtProdutoFiltro)
        Me.gbFiltroListProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbFiltroListProd.Location = New System.Drawing.Point(0, 54)
        Me.gbFiltroListProd.Name = "gbFiltroListProd"
        Me.gbFiltroListProd.Size = New System.Drawing.Size(1039, 93)
        Me.gbFiltroListProd.TabIndex = 3
        Me.gbFiltroListProd.TabStop = False
        Me.gbFiltroListProd.Text = "Filtrar"
        '
        'lblProduto
        '
        Me.lblProduto.AutoSize = True
        Me.lblProduto.Location = New System.Drawing.Point(91, 18)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(90, 25)
        Me.lblProduto.TabIndex = 1
        Me.lblProduto.Text = "Produto"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAdicionar.Image = Global.ControleVendas.My.Resources.Resources.iconAddBlue
        Me.btnAdicionar.Location = New System.Drawing.Point(417, 4)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(226, 50)
        Me.btnAdicionar.TabIndex = 4
        Me.btnAdicionar.Text = " &Adicionar"
        Me.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'chkTodos
        '
        Me.chkTodos.AutoSize = True
        Me.chkTodos.BackColor = System.Drawing.Color.Transparent
        Me.chkTodos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkTodos.Location = New System.Drawing.Point(12, 154)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(234, 29)
        Me.chkTodos.TabIndex = 5
        Me.chkTodos.Text = "Marcar / Desmarcar"
        Me.chkTodos.UseVisualStyleBackColor = False
        '
        'pnlBaixo
        '
        Me.pnlBaixo.Controls.Add(Me.btnAdicionar)
        Me.pnlBaixo.Controls.Add(Me.txtLetreiroListaProd)
        Me.pnlBaixo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBaixo.Location = New System.Drawing.Point(0, 496)
        Me.pnlBaixo.Name = "pnlBaixo"
        Me.pnlBaixo.Size = New System.Drawing.Size(1039, 59)
        Me.pnlBaixo.TabIndex = 6
        '
        'txtProdutoFiltro
        '
        Me.txtProdutoFiltro.Alterado = False
        Me.txtProdutoFiltro.BackColor = System.Drawing.Color.White
        Me.txtProdutoFiltro.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtProdutoFiltro.Location = New System.Drawing.Point(96, 46)
        Me.txtProdutoFiltro.Name = "txtProdutoFiltro"
        Me.txtProdutoFiltro.Size = New System.Drawing.Size(387, 32)
        Me.txtProdutoFiltro.SuperMascara = ""
        Me.txtProdutoFiltro.SuperObrigatorio = False
        Me.txtProdutoFiltro.SuperTravaErrors = False
        Me.txtProdutoFiltro.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtProdutoFiltro.SuperTxtObrigatorio = ""
        Me.txtProdutoFiltro.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtProdutoFiltro.TabIndex = 0
        '
        'dgTodosProd
        '
        Me.dgTodosProd.AdicionarCheckBox = True
        Me.dgTodosProd.AllowUserToAddRows = False
        Me.dgTodosProd.AllowUserToDeleteRows = False
        Me.dgTodosProd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgTodosProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgTodosProd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgTodosProd.BackgroundColor = System.Drawing.Color.White
        Me.dgTodosProd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgTodosProd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.dgTodosProd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSlateGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 12.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgTodosProd.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgTodosProd.ColumnHeadersHeight = 50
        Me.dgTodosProd.CorDoFundoCabeçalho = System.Drawing.Color.LightSlateGray
        Me.dgTodosProd.CorTextoCabeçalho = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 12.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgTodosProd.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgTodosProd.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgTodosProd.EnableHeadersVisualStyles = False
        Me.dgTodosProd.Location = New System.Drawing.Point(0, 187)
        Me.dgTodosProd.Margin = New System.Windows.Forms.Padding(5)
        Me.dgTodosProd.Name = "dgTodosProd"
        Me.dgTodosProd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgTodosProd.RowHeadersVisible = False
        Me.dgTodosProd.RowHeadersWidth = 51
        Me.dgTodosProd.RowTemplate.Height = 24
        Me.dgTodosProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTodosProd.Size = New System.Drawing.Size(1039, 289)
        Me.dgTodosProd.TabIndex = 0
        '
        'txtLetreiroListaProd
        '
        Me.txtLetreiroListaProd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtLetreiroListaProd.CorSombraTexto = System.Drawing.Color.White
        Me.txtLetreiroListaProd.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLetreiroListaProd.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.txtLetreiroListaProd.Location = New System.Drawing.Point(14, 5)
        Me.txtLetreiroListaProd.Margin = New System.Windows.Forms.Padding(5)
        Me.txtLetreiroListaProd.Name = "txtLetreiroListaProd"
        Me.txtLetreiroListaProd.RolagemLetreiro = GFT.Util.SuperLetreiro.Direcao.Direita
        Me.txtLetreiroListaProd.Size = New System.Drawing.Size(232, 29)
        Me.txtLetreiroListaProd.TabIndex = 2
        Me.txtLetreiroListaProd.TextoLetreiro = ""
        Me.txtLetreiroListaProd.VelocidadeRolagem = 5
        '
        'frmListaProdutos
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1039, 555)
        Me.Controls.Add(Me.gbFiltroListProd)
        Me.Controls.Add(Me.chkTodos)
        Me.Controls.Add(Me.pnlCima)
        Me.Controls.Add(Me.dgTodosProd)
        Me.Controls.Add(Me.pnlBaixo)
        Me.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmListaProdutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmListaProdutos"
        Me.pnlCima.ResumeLayout(False)
        Me.gbFiltroListProd.ResumeLayout(False)
        Me.gbFiltroListProd.PerformLayout()
        Me.pnlBaixo.ResumeLayout(False)
        CType(Me.dgTodosProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgTodosProd As GFT.Util.SuperDataGridView
    Friend WithEvents pnlCima As Panel
    Friend WithEvents btnFechar As Button
    Friend WithEvents txtLetreiroListaProd As GFT.Util.SuperLetreiro
    Friend WithEvents gbFiltroListProd As GroupBox
    Friend WithEvents lblProduto As Label
    Friend WithEvents txtProdutoFiltro As GFT.Util.SuperTextBox
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents chkTodos As CheckBox
    Friend WithEvents pnlBaixo As Panel
End Class
