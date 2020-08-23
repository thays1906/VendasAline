<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.SScima = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SSbaixo = New System.Windows.Forms.StatusStrip()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.txtLei = New System.Windows.Forms.TextBox()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnLogo = New System.Windows.Forms.Button()
        Me.SScima.SuspendLayout()
        Me.SuspendLayout()
        '
        'SScima
        '
        Me.SScima.AutoSize = False
        Me.SScima.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.SScima.Dock = System.Windows.Forms.DockStyle.Top
        Me.SScima.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.SScima.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.SScima.Location = New System.Drawing.Point(0, 0)
        Me.SScima.Name = "SScima"
        Me.SScima.Size = New System.Drawing.Size(795, 52)
        Me.SScima.SizingGrip = False
        Me.SScima.TabIndex = 0
        Me.SScima.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(387, 46)
        Me.ToolStripStatusLabel1.Text = "Sobre::. Finances Management 2020"
        '
        'SSbaixo
        '
        Me.SSbaixo.AutoSize = False
        Me.SSbaixo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.SSbaixo.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.SSbaixo.Location = New System.Drawing.Point(0, 453)
        Me.SSbaixo.Name = "SSbaixo"
        Me.SSbaixo.Size = New System.Drawing.Size(795, 50)
        Me.SSbaixo.TabIndex = 1
        Me.SSbaixo.Text = "StatusStrip2"
        '
        'lblCopyright
        '
        Me.lblCopyright.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.lblCopyright.Location = New System.Drawing.Point(75, 423)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(619, 25)
        Me.lblCopyright.TabIndex = 2
        Me.lblCopyright.Text = "© 2020 Finances Management. Todos os direitos resevados."
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(736, 259)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "v 1.0"
        '
        'btnInfo
        '
        Me.btnInfo.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.btnInfo.Location = New System.Drawing.Point(50, 274)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(248, 34)
        Me.btnInfo.TabIndex = 6
        Me.btnInfo.Text = "Informações do Sistema..."
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'txtLei
        '
        Me.txtLei.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtLei.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.txtLei.Location = New System.Drawing.Point(50, 314)
        Me.txtLei.Multiline = True
        Me.txtLei.Name = "txtLei"
        Me.txtLei.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLei.Size = New System.Drawing.Size(595, 90)
        Me.txtLei.TabIndex = 8
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFechar.BackColor = System.Drawing.Color.Transparent
        Me.btnFechar.FlatAppearance.BorderSize = 0
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconClose
        Me.btnFechar.Location = New System.Drawing.Point(739, 0)
        Me.btnFechar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(56, 52)
        Me.btnFechar.TabIndex = 12
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'btnLogo
        '
        Me.btnLogo.BackColor = System.Drawing.Color.Transparent
        Me.btnLogo.FlatAppearance.BorderSize = 0
        Me.btnLogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogo.Image = CType(resources.GetObject("btnLogo.Image"), System.Drawing.Image)
        Me.btnLogo.Location = New System.Drawing.Point(0, 55)
        Me.btnLogo.Name = "btnLogo"
        Me.btnLogo.Size = New System.Drawing.Size(795, 201)
        Me.btnLogo.TabIndex = 4
        Me.btnLogo.UseVisualStyleBackColor = False
        '
        'frmAbout
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(795, 503)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.txtLei)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLogo)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.SSbaixo)
        Me.Controls.Add(Me.SScima)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAbout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmAbout"
        Me.SScima.ResumeLayout(False)
        Me.SScima.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SScima As StatusStrip
    Friend WithEvents SSbaixo As StatusStrip
    Friend WithEvents lblCopyright As Label
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents btnLogo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnInfo As Button
    Friend WithEvents txtLei As TextBox
    Friend WithEvents btnFechar As Button
End Class
