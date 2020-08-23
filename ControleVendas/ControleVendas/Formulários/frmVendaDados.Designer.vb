<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVendaDados
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
        Me.pnlTopo = New System.Windows.Forms.Panel()
        Me.pnlDados = New System.Windows.Forms.Panel()
        Me.lblTituloForm = New System.Windows.Forms.Label()
        Me.dtData = New System.Windows.Forms.DateTimePicker()
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblItens = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.txtItens = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblFormaPagmto = New System.Windows.Forms.Label()
        Me.txtFormaPagmto = New System.Windows.Forms.TextBox()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.pnlTopo.SuspendLayout()
        Me.pnlDados.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTopo
        '
        Me.pnlTopo.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pnlTopo.Controls.Add(Me.lblTituloForm)
        Me.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopo.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopo.Name = "pnlTopo"
        Me.pnlTopo.Size = New System.Drawing.Size(696, 42)
        Me.pnlTopo.TabIndex = 0
        '
        'pnlDados
        '
        Me.pnlDados.AutoScroll = True
        Me.pnlDados.Controls.Add(Me.txtFormaPagmto)
        Me.pnlDados.Controls.Add(Me.lblFormaPagmto)
        Me.pnlDados.Controls.Add(Me.txtTotal)
        Me.pnlDados.Controls.Add(Me.Label3)
        Me.pnlDados.Controls.Add(Me.txtItens)
        Me.pnlDados.Controls.Add(Me.txtCliente)
        Me.pnlDados.Controls.Add(Me.lblCliente)
        Me.pnlDados.Controls.Add(Me.lblItens)
        Me.pnlDados.Controls.Add(Me.lblData)
        Me.pnlDados.Controls.Add(Me.dtData)
        Me.pnlDados.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlDados.Location = New System.Drawing.Point(63, 86)
        Me.pnlDados.Name = "pnlDados"
        Me.pnlDados.Size = New System.Drawing.Size(565, 381)
        Me.pnlDados.TabIndex = 1
        '
        'lblTituloForm
        '
        Me.lblTituloForm.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTituloForm.AutoSize = True
        Me.lblTituloForm.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloForm.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTituloForm.Location = New System.Drawing.Point(289, 11)
        Me.lblTituloForm.Name = "lblTituloForm"
        Me.lblTituloForm.Size = New System.Drawing.Size(141, 18)
        Me.lblTituloForm.TabIndex = 12
        Me.lblTituloForm.Text = "Dados da Venda"
        '
        'dtData
        '
        Me.dtData.Enabled = False
        Me.dtData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtData.Location = New System.Drawing.Point(20, 38)
        Me.dtData.Name = "dtData"
        Me.dtData.Size = New System.Drawing.Size(143, 27)
        Me.dtData.TabIndex = 0
        '
        'lblData
        '
        Me.lblData.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblData.AutoSize = True
        Me.lblData.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblData.Location = New System.Drawing.Point(17, 17)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(129, 18)
        Me.lblData.TabIndex = 13
        Me.lblData.Text = "Data da Venda"
        '
        'lblItens
        '
        Me.lblItens.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblItens.AutoSize = True
        Me.lblItens.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItens.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblItens.Location = New System.Drawing.Point(17, 111)
        Me.lblItens.Name = "lblItens"
        Me.lblItens.Size = New System.Drawing.Size(133, 18)
        Me.lblItens.TabIndex = 14
        Me.lblItens.Text = "Itens da Venda"
        '
        'lblCliente
        '
        Me.lblCliente.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCliente.Location = New System.Drawing.Point(198, 17)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(66, 18)
        Me.lblCliente.TabIndex = 15
        Me.lblCliente.Text = "Cliente"
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtCliente.Location = New System.Drawing.Point(201, 41)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(336, 27)
        Me.txtCliente.TabIndex = 16
        '
        'txtItens
        '
        Me.txtItens.Location = New System.Drawing.Point(20, 132)
        Me.txtItens.Multiline = True
        Me.txtItens.Name = "txtItens"
        Me.txtItens.ReadOnly = True
        Me.txtItens.Size = New System.Drawing.Size(532, 173)
        Me.txtItens.TabIndex = 17
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtTotal.Location = New System.Drawing.Point(361, 334)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(191, 27)
        Me.txtTotal.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(358, 313)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 18)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Total da Venda"
        '
        'lblFormaPagmto
        '
        Me.lblFormaPagmto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblFormaPagmto.AutoSize = True
        Me.lblFormaPagmto.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormaPagmto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFormaPagmto.Location = New System.Drawing.Point(17, 313)
        Me.lblFormaPagmto.Name = "lblFormaPagmto"
        Me.lblFormaPagmto.Size = New System.Drawing.Size(182, 18)
        Me.lblFormaPagmto.TabIndex = 20
        Me.lblFormaPagmto.Text = "Forma de Pagamento"
        '
        'txtFormaPagmto
        '
        Me.txtFormaPagmto.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtFormaPagmto.Location = New System.Drawing.Point(20, 334)
        Me.txtFormaPagmto.Name = "txtFormaPagmto"
        Me.txtFormaPagmto.ReadOnly = True
        Me.txtFormaPagmto.Size = New System.Drawing.Size(191, 27)
        Me.txtFormaPagmto.TabIndex = 21
        '
        'btnFechar
        '
        Me.btnFechar.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Image = Global.ControleVendas.My.Resources.Resources.iconClose
        Me.btnFechar.Location = New System.Drawing.Point(230, 482)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(213, 40)
        Me.btnFechar.TabIndex = 2
        Me.btnFechar.Text = " &Fechar"
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'frmVendaDados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 534)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.pnlDados)
        Me.Controls.Add(Me.pnlTopo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmVendaDados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmVendaDados"
        Me.pnlTopo.ResumeLayout(False)
        Me.pnlTopo.PerformLayout()
        Me.pnlDados.ResumeLayout(False)
        Me.pnlDados.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTopo As Panel
    Friend WithEvents pnlDados As Panel
    Friend WithEvents lblTituloForm As Label
    Friend WithEvents txtItens As TextBox
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents lblCliente As Label
    Friend WithEvents lblItens As Label
    Friend WithEvents lblData As Label
    Friend WithEvents dtData As DateTimePicker
    Friend WithEvents btnFechar As Button
    Friend WithEvents txtFormaPagmto As TextBox
    Friend WithEvents lblFormaPagmto As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label3 As Label
End Class
