﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNovoCliente))
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.tabCtrlNovoCli = New System.Windows.Forms.TabControl()
        Me.tabCadastro = New System.Windows.Forms.TabPage()
        Me.pnlDadosCliente = New System.Windows.Forms.Panel()
        Me.txtCpf = New System.Windows.Forms.MaskedTextBox()
        Me.txtTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.gbEndereco = New System.Windows.Forms.GroupBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.cbEstado = New GFT.Util.SuperComboBox()
        Me.cbCidade = New GFT.Util.SuperComboBox()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.txtBairro = New GFT.Util.SuperTextBox()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.txtNumero = New GFT.Util.SuperTextBox()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.txtRua = New GFT.Util.SuperTextBox()
        Me.lblRua = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.dtCadastro = New System.Windows.Forms.DateTimePicker()
        Me.lblCpf = New System.Windows.Forms.Label()
        Me.txtEmail = New GFT.Util.SuperTextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblTelefone = New System.Windows.Forms.Label()
        Me.txtCliente = New GFT.Util.SuperTextBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblClienteObg = New System.Windows.Forms.Label()
        Me.ImageListNovoCliente = New System.Windows.Forms.ImageList(Me.components)
        Me.tabCtrlNovoCli.SuspendLayout()
        Me.tabCadastro.SuspendLayout()
        Me.pnlDadosCliente.SuspendLayout()
        Me.gbEndereco.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Image = Global.ControleVendas.My.Resources.Resources.iconClose
        Me.btnFechar.Location = New System.Drawing.Point(839, -1)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(65, 51)
        Me.btnFechar.TabIndex = 11
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSalvar.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnSalvar.Image = Global.ControleVendas.My.Resources.Resources.iconSalvar1
        Me.btnSalvar.Location = New System.Drawing.Point(347, 570)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(203, 42)
        Me.btnSalvar.TabIndex = 10
        Me.btnSalvar.Text = " &Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'tabCtrlNovoCli
        '
        Me.tabCtrlNovoCli.Controls.Add(Me.tabCadastro)
        Me.tabCtrlNovoCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tabCtrlNovoCli.ImageList = Me.ImageListNovoCliente
        Me.tabCtrlNovoCli.Location = New System.Drawing.Point(51, 31)
        Me.tabCtrlNovoCli.Name = "tabCtrlNovoCli"
        Me.tabCtrlNovoCli.Padding = New System.Drawing.Point(100, 10)
        Me.tabCtrlNovoCli.SelectedIndex = 0
        Me.tabCtrlNovoCli.Size = New System.Drawing.Size(791, 518)
        Me.tabCtrlNovoCli.TabIndex = 2
        '
        'tabCadastro
        '
        Me.tabCadastro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabCadastro.Controls.Add(Me.pnlDadosCliente)
        Me.tabCadastro.ImageIndex = 0
        Me.tabCadastro.Location = New System.Drawing.Point(4, 69)
        Me.tabCadastro.Name = "tabCadastro"
        Me.tabCadastro.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCadastro.Size = New System.Drawing.Size(783, 445)
        Me.tabCadastro.TabIndex = 0
        Me.tabCadastro.Text = "Novo Cliente"
        '
        'pnlDadosCliente
        '
        Me.pnlDadosCliente.BackColor = System.Drawing.SystemColors.Control
        Me.pnlDadosCliente.Controls.Add(Me.lblClienteObg)
        Me.pnlDadosCliente.Controls.Add(Me.txtCpf)
        Me.pnlDadosCliente.Controls.Add(Me.txtTelefone)
        Me.pnlDadosCliente.Controls.Add(Me.gbEndereco)
        Me.pnlDadosCliente.Controls.Add(Me.lblData)
        Me.pnlDadosCliente.Controls.Add(Me.dtCadastro)
        Me.pnlDadosCliente.Controls.Add(Me.lblCpf)
        Me.pnlDadosCliente.Controls.Add(Me.txtEmail)
        Me.pnlDadosCliente.Controls.Add(Me.lblEmail)
        Me.pnlDadosCliente.Controls.Add(Me.lblTelefone)
        Me.pnlDadosCliente.Controls.Add(Me.txtCliente)
        Me.pnlDadosCliente.Controls.Add(Me.lblCliente)
        Me.pnlDadosCliente.Location = New System.Drawing.Point(45, 32)
        Me.pnlDadosCliente.Name = "pnlDadosCliente"
        Me.pnlDadosCliente.Size = New System.Drawing.Size(691, 402)
        Me.pnlDadosCliente.TabIndex = 1
        '
        'txtCpf
        '
        Me.txtCpf.BeepOnError = True
        Me.txtCpf.HidePromptOnLeave = True
        Me.txtCpf.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtCpf.Location = New System.Drawing.Point(493, 111)
        Me.txtCpf.Mask = "000,000,000-00"
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.RejectInputOnFirstFailure = True
        Me.txtCpf.Size = New System.Drawing.Size(183, 30)
        Me.txtCpf.TabIndex = 2
        '
        'txtTelefone
        '
        Me.txtTelefone.AllowPromptAsInput = False
        Me.txtTelefone.BeepOnError = True
        Me.txtTelefone.HidePromptOnLeave = True
        Me.txtTelefone.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert
        Me.txtTelefone.Location = New System.Drawing.Point(15, 193)
        Me.txtTelefone.Mask = "(00)00000-9999"
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.RejectInputOnFirstFailure = True
        Me.txtTelefone.Size = New System.Drawing.Size(183, 30)
        Me.txtTelefone.TabIndex = 3
        '
        'gbEndereco
        '
        Me.gbEndereco.Controls.Add(Me.lblEstado)
        Me.gbEndereco.Controls.Add(Me.cbEstado)
        Me.gbEndereco.Controls.Add(Me.cbCidade)
        Me.gbEndereco.Controls.Add(Me.lblCidade)
        Me.gbEndereco.Controls.Add(Me.txtBairro)
        Me.gbEndereco.Controls.Add(Me.lblBairro)
        Me.gbEndereco.Controls.Add(Me.txtNumero)
        Me.gbEndereco.Controls.Add(Me.lblNumero)
        Me.gbEndereco.Controls.Add(Me.txtRua)
        Me.gbEndereco.Controls.Add(Me.lblRua)
        Me.gbEndereco.Location = New System.Drawing.Point(3, 239)
        Me.gbEndereco.Name = "gbEndereco"
        Me.gbEndereco.Size = New System.Drawing.Size(685, 160)
        Me.gbEndereco.TabIndex = 3
        Me.gbEndereco.TabStop = False
        Me.gbEndereco.Text = "Endereço"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.BackColor = System.Drawing.Color.Transparent
        Me.lblEstado.Location = New System.Drawing.Point(7, 93)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(38, 25)
        Me.lblEstado.TabIndex = 30
        Me.lblEstado.Text = "UF"
        '
        'cbEstado
        '
        Me.cbEstado.Alterado = False
        Me.cbEstado.CorFundo = System.Drawing.Color.White
        Me.cbEstado.CorFundoSelecionado = System.Drawing.Color.White
        Me.cbEstado.CorTexto = System.Drawing.Color.Black
        Me.cbEstado.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Location = New System.Drawing.Point(12, 121)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(118, 33)
        Me.cbEstado.SuperObrigatorio = False
        Me.cbEstado.SuperTxtObrigatorio = ""
        Me.cbEstado.TabIndex = 7
        '
        'cbCidade
        '
        Me.cbCidade.Alterado = False
        Me.cbCidade.CorFundo = System.Drawing.Color.White
        Me.cbCidade.CorFundoSelecionado = System.Drawing.Color.White
        Me.cbCidade.CorTexto = System.Drawing.Color.Black
        Me.cbCidade.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbCidade.FormattingEnabled = True
        Me.cbCidade.Location = New System.Drawing.Point(153, 121)
        Me.cbCidade.Name = "cbCidade"
        Me.cbCidade.Size = New System.Drawing.Size(319, 33)
        Me.cbCidade.SuperObrigatorio = False
        Me.cbCidade.SuperTxtObrigatorio = ""
        Me.cbCidade.TabIndex = 8
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.BackColor = System.Drawing.Color.Transparent
        Me.lblCidade.Location = New System.Drawing.Point(148, 93)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(75, 25)
        Me.lblCidade.TabIndex = 27
        Me.lblCidade.Text = "Cidade"
        '
        'txtBairro
        '
        Me.txtBairro.Alterado = False
        Me.txtBairro.BackColor = System.Drawing.Color.White
        Me.txtBairro.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtBairro.Location = New System.Drawing.Point(490, 124)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(189, 30)
        Me.txtBairro.SuperMascara = ""
        Me.txtBairro.SuperObrigatorio = False
        Me.txtBairro.SuperTravaErrors = False
        Me.txtBairro.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtBairro.SuperTxtObrigatorio = ""
        Me.txtBairro.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtBairro.TabIndex = 9
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.BackColor = System.Drawing.Color.Transparent
        Me.lblBairro.Location = New System.Drawing.Point(485, 93)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(63, 25)
        Me.lblBairro.TabIndex = 26
        Me.lblBairro.Text = "Bairro"
        '
        'txtNumero
        '
        Me.txtNumero.Alterado = False
        Me.txtNumero.BackColor = System.Drawing.Color.White
        Me.txtNumero.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtNumero.Location = New System.Drawing.Point(490, 60)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(128, 30)
        Me.txtNumero.SuperMascara = ""
        Me.txtNumero.SuperObrigatorio = False
        Me.txtNumero.SuperTravaErrors = False
        Me.txtNumero.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtNumero.SuperTxtObrigatorio = ""
        Me.txtNumero.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtNumero.TabIndex = 6
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.BackColor = System.Drawing.Color.Transparent
        Me.lblNumero.Location = New System.Drawing.Point(485, 32)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(33, 25)
        Me.lblNumero.TabIndex = 24
        Me.lblNumero.Text = "Nº"
        '
        'txtRua
        '
        Me.txtRua.Alterado = False
        Me.txtRua.BackColor = System.Drawing.Color.White
        Me.txtRua.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtRua.Location = New System.Drawing.Point(12, 60)
        Me.txtRua.Name = "txtRua"
        Me.txtRua.Size = New System.Drawing.Size(460, 30)
        Me.txtRua.SuperMascara = ""
        Me.txtRua.SuperObrigatorio = False
        Me.txtRua.SuperTravaErrors = False
        Me.txtRua.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtRua.SuperTxtObrigatorio = ""
        Me.txtRua.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtRua.TabIndex = 5
        '
        'lblRua
        '
        Me.lblRua.AutoSize = True
        Me.lblRua.BackColor = System.Drawing.Color.Transparent
        Me.lblRua.Location = New System.Drawing.Point(7, 32)
        Me.lblRua.Name = "lblRua"
        Me.lblRua.Size = New System.Drawing.Size(112, 25)
        Me.lblRua.TabIndex = 22
        Me.lblRua.Text = "Logradouro"
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.BackColor = System.Drawing.Color.Transparent
        Me.lblData.Location = New System.Drawing.Point(10, 7)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(160, 25)
        Me.lblData.TabIndex = 9
        Me.lblData.Text = "Data de cadastro"
        '
        'dtCadastro
        '
        Me.dtCadastro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtCadastro.Location = New System.Drawing.Point(15, 35)
        Me.dtCadastro.Name = "dtCadastro"
        Me.dtCadastro.Size = New System.Drawing.Size(166, 30)
        Me.dtCadastro.TabIndex = 0
        '
        'lblCpf
        '
        Me.lblCpf.AutoSize = True
        Me.lblCpf.BackColor = System.Drawing.Color.Transparent
        Me.lblCpf.Location = New System.Drawing.Point(488, 83)
        Me.lblCpf.Name = "lblCpf"
        Me.lblCpf.Size = New System.Drawing.Size(52, 25)
        Me.lblCpf.TabIndex = 7
        Me.lblCpf.Text = "CPF"
        '
        'txtEmail
        '
        Me.txtEmail.Alterado = False
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(233, 193)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(242, 30)
        Me.txtEmail.SuperMascara = ""
        Me.txtEmail.SuperObrigatorio = False
        Me.txtEmail.SuperTravaErrors = False
        Me.txtEmail.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtEmail.SuperTxtObrigatorio = ""
        Me.txtEmail.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtEmail.TabIndex = 4
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Location = New System.Drawing.Point(228, 165)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(67, 25)
        Me.lblEmail.TabIndex = 5
        Me.lblEmail.Text = "E-mail"
        '
        'lblTelefone
        '
        Me.lblTelefone.AutoSize = True
        Me.lblTelefone.BackColor = System.Drawing.Color.Transparent
        Me.lblTelefone.Location = New System.Drawing.Point(10, 165)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(89, 25)
        Me.lblTelefone.TabIndex = 3
        Me.lblTelefone.Text = "Telefone"
        '
        'txtCliente
        '
        Me.txtCliente.Alterado = False
        Me.txtCliente.BackColor = System.Drawing.Color.White
        Me.txtCliente.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtCliente.Location = New System.Drawing.Point(15, 111)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(460, 30)
        Me.txtCliente.SuperMascara = ""
        Me.txtCliente.SuperObrigatorio = False
        Me.txtCliente.SuperTravaErrors = False
        Me.txtCliente.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtCliente.SuperTxtObrigatorio = ""
        Me.txtCliente.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtCliente.TabIndex = 1
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.BackColor = System.Drawing.Color.Transparent
        Me.lblCliente.Location = New System.Drawing.Point(10, 83)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(81, 25)
        Me.lblCliente.TabIndex = 1
        Me.lblCliente.Text = "Cliente*"
        '
        'lblClienteObg
        '
        Me.lblClienteObg.AutoSize = True
        Me.lblClienteObg.BackColor = System.Drawing.Color.Transparent
        Me.lblClienteObg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClienteObg.ForeColor = System.Drawing.Color.Red
        Me.lblClienteObg.Location = New System.Drawing.Point(14, 144)
        Me.lblClienteObg.Name = "lblClienteObg"
        Me.lblClienteObg.Size = New System.Drawing.Size(13, 20)
        Me.lblClienteObg.TabIndex = 10
        Me.lblClienteObg.Text = "."
        Me.lblClienteObg.Visible = False
        '
        'ImageListNovoCliente
        '
        Me.ImageListNovoCliente.ImageStream = CType(resources.GetObject("ImageListNovoCliente.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListNovoCliente.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListNovoCliente.Images.SetKeyName(0, "iconCliente.png")
        '
        'frmNovoCliente
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(903, 635)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.tabCtrlNovoCli)
        Me.Controls.Add(Me.btnSalvar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmNovoCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmNovoCliente"
        Me.tabCtrlNovoCli.ResumeLayout(False)
        Me.tabCadastro.ResumeLayout(False)
        Me.pnlDadosCliente.ResumeLayout(False)
        Me.pnlDadosCliente.PerformLayout()
        Me.gbEndereco.ResumeLayout(False)
        Me.gbEndereco.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnFechar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents tabCtrlNovoCli As TabControl
    Friend WithEvents tabCadastro As TabPage
    Friend WithEvents lblCliente As Label
    Friend WithEvents txtCliente As GFT.Util.SuperTextBox
    Friend WithEvents pnlDadosCliente As Panel
    Friend WithEvents lblCpf As Label
    Friend WithEvents txtEmail As GFT.Util.SuperTextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblTelefone As Label
    Friend WithEvents dtCadastro As DateTimePicker
    Friend WithEvents gbEndereco As GroupBox
    Friend WithEvents lblData As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents cbEstado As GFT.Util.SuperComboBox
    Friend WithEvents cbCidade As GFT.Util.SuperComboBox
    Friend WithEvents lblCidade As Label
    Friend WithEvents txtBairro As GFT.Util.SuperTextBox
    Friend WithEvents lblBairro As Label
    Friend WithEvents txtNumero As GFT.Util.SuperTextBox
    Friend WithEvents lblNumero As Label
    Friend WithEvents txtRua As GFT.Util.SuperTextBox
    Friend WithEvents lblRua As Label
    Friend WithEvents txtTelefone As MaskedTextBox
    Friend WithEvents txtCpf As MaskedTextBox
    Friend WithEvents lblClienteObg As Label
    Friend WithEvents ImageListNovoCliente As ImageList
End Class
