<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVendaFinalizada
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVendaFinalizada))
        Me.txtImpressao = New GFT.Util.SuperTextBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.pnlCima = New System.Windows.Forms.Panel()
        Me.pnlBaixo = New System.Windows.Forms.Panel()
        Me.pnlCima.SuspendLayout()
        Me.pnlBaixo.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtImpressao
        '
        Me.txtImpressao.Alterado = False
        Me.txtImpressao.BackColor = System.Drawing.Color.White
        Me.txtImpressao.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtImpressao.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpressao.Location = New System.Drawing.Point(34, 56)
        Me.txtImpressao.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtImpressao.Multiline = True
        Me.txtImpressao.Name = "txtImpressao"
        Me.txtImpressao.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtImpressao.Size = New System.Drawing.Size(536, 285)
        Me.txtImpressao.SuperMascara = ""
        Me.txtImpressao.SuperObrigatorio = False
        Me.txtImpressao.SuperTravaErrors = False
        Me.txtImpressao.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtImpressao.SuperTxtObrigatorio = ""
        Me.txtImpressao.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtImpressao.TabIndex = 0
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnImprimir.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = Global.ControleVendas.My.Resources.Resources.iconPrint
        Me.btnImprimir.Location = New System.Drawing.Point(229, 5)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(166, 38)
        Me.btnImprimir.TabIndex = 1
        Me.btnImprimir.Text = " &Imprimir"
        Me.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFechar.Image = CType(resources.GetObject("btnFechar.Image"), System.Drawing.Image)
        Me.btnFechar.Location = New System.Drawing.Point(562, 0)
        Me.btnFechar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(56, 43)
        Me.btnFechar.TabIndex = 11
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'pnlCima
        '
        Me.pnlCima.Controls.Add(Me.btnFechar)
        Me.pnlCima.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCima.Location = New System.Drawing.Point(0, 0)
        Me.pnlCima.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlCima.Name = "pnlCima"
        Me.pnlCima.Size = New System.Drawing.Size(618, 43)
        Me.pnlCima.TabIndex = 12
        '
        'pnlBaixo
        '
        Me.pnlBaixo.Controls.Add(Me.btnImprimir)
        Me.pnlBaixo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBaixo.Location = New System.Drawing.Point(0, 372)
        Me.pnlBaixo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlBaixo.Name = "pnlBaixo"
        Me.pnlBaixo.Size = New System.Drawing.Size(618, 47)
        Me.pnlBaixo.TabIndex = 13
        '
        'frmVendaFinalizada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 419)
        Me.Controls.Add(Me.pnlCima)
        Me.Controls.Add(Me.txtImpressao)
        Me.Controls.Add(Me.pnlBaixo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmVendaFinalizada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmVendaFinalizada"
        Me.pnlCima.ResumeLayout(False)
        Me.pnlBaixo.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtImpressao As GFT.Util.SuperTextBox
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnFechar As Button
    Friend WithEvents pnlCima As Panel
    Friend WithEvents pnlBaixo As Panel
End Class
