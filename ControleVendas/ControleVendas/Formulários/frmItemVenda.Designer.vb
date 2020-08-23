<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemVenda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItemVenda))
        Me.lblValorTotal = New System.Windows.Forms.Label()
        Me.txtValorTotal = New GFT.Util.SuperTextBox()
        Me.lblValorUn = New System.Windows.Forms.Label()
        Me.txtValorUn = New GFT.Util.SuperTextBox()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.nudQuantidade = New System.Windows.Forms.NumericUpDown()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.gbDados = New System.Windows.Forms.GroupBox()
        Me.lblQtdeObg = New System.Windows.Forms.Label()
        Me.btnCalculadora = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.txtProduto = New System.Windows.Forms.TextBox()
        CType(Me.nudQuantidade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDados.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblValorTotal
        '
        Me.lblValorTotal.AutoSize = True
        Me.lblValorTotal.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorTotal.Location = New System.Drawing.Point(347, 161)
        Me.lblValorTotal.Name = "lblValorTotal"
        Me.lblValorTotal.Size = New System.Drawing.Size(67, 25)
        Me.lblValorTotal.TabIndex = 16
        Me.lblValorTotal.Text = "Total "
        '
        'txtValorTotal
        '
        Me.txtValorTotal.Alterado = False
        Me.txtValorTotal.BackColor = System.Drawing.Color.White
        Me.txtValorTotal.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValorTotal.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorTotal.Location = New System.Drawing.Point(352, 196)
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.Size = New System.Drawing.Size(174, 32)
        Me.txtValorTotal.SuperMascara = ""
        Me.txtValorTotal.SuperObrigatorio = False
        Me.txtValorTotal.SuperTravaErrors = False
        Me.txtValorTotal.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtValorTotal.SuperTxtObrigatorio = ""
        Me.txtValorTotal.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosReais
        Me.txtValorTotal.TabIndex = 3
        Me.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblValorUn
        '
        Me.lblValorUn.AutoSize = True
        Me.lblValorUn.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorUn.Location = New System.Drawing.Point(150, 161)
        Me.lblValorUn.Name = "lblValorUn"
        Me.lblValorUn.Size = New System.Drawing.Size(152, 25)
        Me.lblValorUn.TabIndex = 15
        Me.lblValorUn.Text = "Valor Unitário"
        '
        'txtValorUn
        '
        Me.txtValorUn.Alterado = False
        Me.txtValorUn.BackColor = System.Drawing.Color.White
        Me.txtValorUn.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValorUn.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorUn.Location = New System.Drawing.Point(155, 196)
        Me.txtValorUn.Name = "txtValorUn"
        Me.txtValorUn.Size = New System.Drawing.Size(176, 32)
        Me.txtValorUn.SuperMascara = ""
        Me.txtValorUn.SuperObrigatorio = False
        Me.txtValorUn.SuperTravaErrors = False
        Me.txtValorUn.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtValorUn.SuperTxtObrigatorio = ""
        Me.txtValorUn.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosReais
        Me.txtValorUn.TabIndex = 2
        Me.txtValorUn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblProduto
        '
        Me.lblProduto.AutoSize = True
        Me.lblProduto.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProduto.Location = New System.Drawing.Point(41, 67)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(90, 25)
        Me.lblProduto.TabIndex = 12
        Me.lblProduto.Text = "Produto"
        '
        'nudQuantidade
        '
        Me.nudQuantidade.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudQuantidade.Location = New System.Drawing.Point(46, 196)
        Me.nudQuantidade.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.nudQuantidade.Name = "nudQuantidade"
        Me.nudQuantidade.Size = New System.Drawing.Size(85, 32)
        Me.nudQuantidade.TabIndex = 1
        Me.nudQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudQuantidade.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantidade.Location = New System.Drawing.Point(41, 161)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(67, 25)
        Me.lblQuantidade.TabIndex = 18
        Me.lblQuantidade.Text = "Qtde."
        '
        'gbDados
        '
        Me.gbDados.BackColor = System.Drawing.SystemColors.Control
        Me.gbDados.Controls.Add(Me.txtProduto)
        Me.gbDados.Controls.Add(Me.lblQtdeObg)
        Me.gbDados.Controls.Add(Me.btnCalculadora)
        Me.gbDados.Controls.Add(Me.nudQuantidade)
        Me.gbDados.Controls.Add(Me.lblQuantidade)
        Me.gbDados.Controls.Add(Me.lblValorTotal)
        Me.gbDados.Controls.Add(Me.txtValorTotal)
        Me.gbDados.Controls.Add(Me.lblValorUn)
        Me.gbDados.Controls.Add(Me.txtValorUn)
        Me.gbDados.Controls.Add(Me.lblProduto)
        Me.gbDados.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbDados.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDados.Location = New System.Drawing.Point(78, 69)
        Me.gbDados.Name = "gbDados"
        Me.gbDados.Size = New System.Drawing.Size(616, 296)
        Me.gbDados.TabIndex = 20
        Me.gbDados.TabStop = False
        Me.gbDados.Text = "Dados do Item"
        '
        'lblQtdeObg
        '
        Me.lblQtdeObg.AutoSize = True
        Me.lblQtdeObg.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtdeObg.ForeColor = System.Drawing.Color.Red
        Me.lblQtdeObg.Location = New System.Drawing.Point(42, 231)
        Me.lblQtdeObg.Name = "lblQtdeObg"
        Me.lblQtdeObg.Size = New System.Drawing.Size(65, 20)
        Me.lblQtdeObg.TabIndex = 19
        Me.lblQtdeObg.Text = "Label1"
        Me.lblQtdeObg.Visible = False
        '
        'btnCalculadora
        '
        Me.btnCalculadora.FlatAppearance.BorderSize = 0
        Me.btnCalculadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculadora.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculadora.Image = Global.ControleVendas.My.Resources.Resources.iconCalculadora
        Me.btnCalculadora.Location = New System.Drawing.Point(549, 183)
        Me.btnCalculadora.Name = "btnCalculadora"
        Me.btnCalculadora.Size = New System.Drawing.Size(45, 45)
        Me.btnCalculadora.TabIndex = 4
        Me.btnCalculadora.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCalculadora.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSalvar.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.Image = Global.ControleVendas.My.Resources.Resources.iconEditar
        Me.btnSalvar.Location = New System.Drawing.Point(237, 387)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(255, 50)
        Me.btnSalvar.TabIndex = 5
        Me.btnSalvar.Text = " &Salvar alterações"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFechar.Image = CType(resources.GetObject("btnFechar.Image"), System.Drawing.Image)
        Me.btnFechar.Location = New System.Drawing.Point(697, -1)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(76, 64)
        Me.btnFechar.TabIndex = 6
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'txtProduto
        '
        Me.txtProduto.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtProduto.Location = New System.Drawing.Point(50, 101)
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.Size = New System.Drawing.Size(475, 29)
        Me.txtProduto.TabIndex = 20
        '
        'frmItemVenda
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(772, 458)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.gbDados)
        Me.Controls.Add(Me.btnSalvar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmItemVenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmItemVenda"
        CType(Me.nudQuantidade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDados.ResumeLayout(False)
        Me.gbDados.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblValorTotal As Label
    Friend WithEvents txtValorTotal As GFT.Util.SuperTextBox
    Friend WithEvents lblValorUn As Label
    Friend WithEvents txtValorUn As GFT.Util.SuperTextBox
    Friend WithEvents lblProduto As Label
    Friend WithEvents nudQuantidade As NumericUpDown
    Friend WithEvents lblQuantidade As Label
    Friend WithEvents gbDados As GroupBox
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnFechar As Button
    Friend WithEvents btnCalculadora As Button
    Friend WithEvents lblQtdeObg As Label
    Friend WithEvents txtProduto As TextBox
End Class
