<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNovoCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNovoCliente))
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.tabCtrlNovoCli = New System.Windows.Forms.TabControl()
        Me.tabCadastro = New System.Windows.Forms.TabPage()
        Me.gbDadosCliente = New System.Windows.Forms.GroupBox()
        Me.txtCliente = New GFT.Util.SuperTextBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.tabCtrlNovoCli.SuspendLayout()
        Me.tabCadastro.SuspendLayout()
        Me.gbDadosCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Image = Global.ControleVendas.My.Resources.Resources.iconClose
        Me.btnFechar.Location = New System.Drawing.Point(736, 3)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(62, 47)
        Me.btnFechar.TabIndex = 0
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSalvar.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.Location = New System.Drawing.Point(280, 384)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(203, 42)
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = " &Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'tabCtrlNovoCli
        '
        Me.tabCtrlNovoCli.Controls.Add(Me.tabCadastro)
        Me.tabCtrlNovoCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tabCtrlNovoCli.Location = New System.Drawing.Point(55, 54)
        Me.tabCtrlNovoCli.Name = "tabCtrlNovoCli"
        Me.tabCtrlNovoCli.SelectedIndex = 0
        Me.tabCtrlNovoCli.Size = New System.Drawing.Size(687, 311)
        Me.tabCtrlNovoCli.TabIndex = 2
        '
        'tabCadastro
        '
        Me.tabCadastro.Controls.Add(Me.gbDadosCliente)
        Me.tabCadastro.Location = New System.Drawing.Point(4, 34)
        Me.tabCadastro.Name = "tabCadastro"
        Me.tabCadastro.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCadastro.Size = New System.Drawing.Size(679, 273)
        Me.tabCadastro.TabIndex = 0
        Me.tabCadastro.Text = "Novo Cliente"
        Me.tabCadastro.UseVisualStyleBackColor = True
        '
        'gbDadosCliente
        '
        Me.gbDadosCliente.Controls.Add(Me.lblCliente)
        Me.gbDadosCliente.Controls.Add(Me.txtCliente)
        Me.gbDadosCliente.Location = New System.Drawing.Point(26, 20)
        Me.gbDadosCliente.Name = "gbDadosCliente"
        Me.gbDadosCliente.Size = New System.Drawing.Size(625, 230)
        Me.gbDadosCliente.TabIndex = 0
        Me.gbDadosCliente.TabStop = False
        '
        'txtCliente
        '
        Me.txtCliente.Alterado = False
        Me.txtCliente.BackColor = System.Drawing.Color.White
        Me.txtCliente.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtCliente.Location = New System.Drawing.Point(45, 85)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(460, 30)
        Me.txtCliente.SuperMascara = ""
        Me.txtCliente.SuperObrigatorio = False
        Me.txtCliente.SuperTravaErrors = False
        Me.txtCliente.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtCliente.SuperTxtObrigatorio = ""
        Me.txtCliente.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtCliente.TabIndex = 0
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(40, 57)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(79, 25)
        Me.lblCliente.TabIndex = 1
        Me.lblCliente.Text = "Cliente:"
        '
        'frmNovoCliente
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tabCtrlNovoCli)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnFechar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmNovoCliente"
        Me.Text = "frmNovoCliente"
        Me.tabCtrlNovoCli.ResumeLayout(False)
        Me.tabCadastro.ResumeLayout(False)
        Me.gbDadosCliente.ResumeLayout(False)
        Me.gbDadosCliente.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnFechar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents tabCtrlNovoCli As TabControl
    Friend WithEvents tabCadastro As TabPage
    Friend WithEvents gbDadosCliente As GroupBox
    Friend WithEvents lblCliente As Label
    Friend WithEvents txtCliente As GFT.Util.SuperTextBox
End Class
