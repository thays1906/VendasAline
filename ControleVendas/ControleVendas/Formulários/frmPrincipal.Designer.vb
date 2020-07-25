<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ConfiguraçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JanelasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusCima = New System.Windows.Forms.StatusStrip()
        Me.txtCaption = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusBaixo = New System.Windows.Forms.StatusStrip()
        Me.txtCaptionHora = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.gbPrincipal = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.tabCtrlProduto = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusCima.SuspendLayout()
        Me.StatusBaixo.SuspendLayout()
        Me.gbPrincipal.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCtrlProduto.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MenuStrip1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfiguraçõesToolStripMenuItem, Me.ProdutosToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.VendasToolStripMenuItem, Me.JanelasToolStripMenuItem, Me.SobreToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1202, 75)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ConfiguraçõesToolStripMenuItem
        '
        Me.ConfiguraçõesToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfiguraçõesToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ConfiguraçõesToolStripMenuItem.Image = Global.ControleVendas.My.Resources.Resources.iconEngrenagem
        Me.ConfiguraçõesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ConfiguraçõesToolStripMenuItem.Name = "ConfiguraçõesToolStripMenuItem"
        Me.ConfiguraçõesToolStripMenuItem.Size = New System.Drawing.Size(233, 71)
        Me.ConfiguraçõesToolStripMenuItem.Text = "Configurações"
        '
        'ProdutosToolStripMenuItem
        '
        Me.ProdutosToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdutosToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ProdutosToolStripMenuItem.Image = CType(resources.GetObject("ProdutosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProdutosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ProdutosToolStripMenuItem.Name = "ProdutosToolStripMenuItem"
        Me.ProdutosToolStripMenuItem.Size = New System.Drawing.Size(176, 71)
        Me.ProdutosToolStripMenuItem.Text = "Produtos"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClientesToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ClientesToolStripMenuItem.Image = CType(resources.GetObject("ClientesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClientesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(163, 71)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'VendasToolStripMenuItem
        '
        Me.VendasToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VendasToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.VendasToolStripMenuItem.Image = Global.ControleVendas.My.Resources.Resources.iconVenda
        Me.VendasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.VendasToolStripMenuItem.Name = "VendasToolStripMenuItem"
        Me.VendasToolStripMenuItem.Size = New System.Drawing.Size(155, 71)
        Me.VendasToolStripMenuItem.Text = "Vendas"
        '
        'JanelasToolStripMenuItem
        '
        Me.JanelasToolStripMenuItem.Image = Global.ControleVendas.My.Resources.Resources.iconJanelas
        Me.JanelasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.JanelasToolStripMenuItem.Name = "JanelasToolStripMenuItem"
        Me.JanelasToolStripMenuItem.Size = New System.Drawing.Size(148, 71)
        Me.JanelasToolStripMenuItem.Text = "Janelas"
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SobreToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.SobreToolStripMenuItem.Image = Global.ControleVendas.My.Resources.Resources.iconAbout
        Me.SobreToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(139, 71)
        Me.SobreToolStripMenuItem.Text = "Sobre"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.LogoutToolStripMenuItem.Image = Global.ControleVendas.My.Resources.Resources.iconLogout_48
        Me.LogoutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(152, 71)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'StatusCima
        '
        Me.StatusCima.AutoSize = False
        Me.StatusCima.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.StatusCima.Dock = System.Windows.Forms.DockStyle.Top
        Me.StatusCima.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusCima.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtCaption})
        Me.StatusCima.Location = New System.Drawing.Point(0, 75)
        Me.StatusCima.Name = "StatusCima"
        Me.StatusCima.Size = New System.Drawing.Size(1202, 44)
        Me.StatusCima.SizingGrip = False
        Me.StatusCima.TabIndex = 3
        Me.StatusCima.Text = "StatusStrip1"
        '
        'txtCaption
        '
        Me.txtCaption.AutoSize = False
        Me.txtCaption.BackColor = System.Drawing.Color.Transparent
        Me.txtCaption.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
        Me.txtCaption.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.txtCaption.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaption.ForeColor = System.Drawing.Color.White
        Me.txtCaption.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtCaption.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.txtCaption.Margin = New System.Windows.Forms.Padding(10, 3, 0, 2)
        Me.txtCaption.Name = "txtCaption"
        Me.txtCaption.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCaption.Size = New System.Drawing.Size(1177, 39)
        Me.txtCaption.Spring = True
        Me.txtCaption.Text = "Home"
        Me.txtCaption.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.txtCaption.ToolTipText = "Você esta aqui"
        '
        'StatusBaixo
        '
        Me.StatusBaixo.AutoSize = False
        Me.StatusBaixo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.StatusBaixo.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusBaixo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtCaptionHora})
        Me.StatusBaixo.Location = New System.Drawing.Point(0, 498)
        Me.StatusBaixo.Name = "StatusBaixo"
        Me.StatusBaixo.Size = New System.Drawing.Size(1202, 44)
        Me.StatusBaixo.SizingGrip = False
        Me.StatusBaixo.TabIndex = 4
        Me.StatusBaixo.Text = "StatusStrip1"
        '
        'txtCaptionHora
        '
        Me.txtCaptionHora.BackColor = System.Drawing.Color.Transparent
        Me.txtCaptionHora.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
        Me.txtCaptionHora.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.txtCaptionHora.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaptionHora.ForeColor = System.Drawing.Color.White
        Me.txtCaptionHora.Name = "txtCaptionHora"
        Me.txtCaptionHora.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCaptionHora.Size = New System.Drawing.Size(1187, 38)
        Me.txtCaptionHora.Spring = True
        Me.txtCaptionHora.Text = "Data/Hora"
        Me.txtCaptionHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 1000
        '
        'gbPrincipal
        '
        Me.gbPrincipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbPrincipal.Controls.Add(Me.TabControl1)
        Me.gbPrincipal.Controls.Add(Me.tabCtrlProduto)
        Me.gbPrincipal.Location = New System.Drawing.Point(0, 122)
        Me.gbPrincipal.Name = "gbPrincipal"
        Me.gbPrincipal.Size = New System.Drawing.Size(1202, 373)
        Me.gbPrincipal.TabIndex = 5
        Me.gbPrincipal.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.TabControl1.Location = New System.Drawing.Point(520, 44)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(198, 5)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(517, 203)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage2.Controls.Add(Me.Chart1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 38)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(509, 161)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Fluxo de Caixa"
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Gainsboro
        Me.Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Sunken
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(6, 6)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Me.Chart1.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.Fuchsia}
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(497, 152)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        Me.Chart1.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal
        '
        'tabCtrlProduto
        '
        Me.tabCtrlProduto.Controls.Add(Me.TabPage1)
        Me.tabCtrlProduto.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.tabCtrlProduto.Location = New System.Drawing.Point(27, 44)
        Me.tabCtrlProduto.Name = "tabCtrlProduto"
        Me.tabCtrlProduto.Padding = New System.Drawing.Point(190, 5)
        Me.tabCtrlProduto.SelectedIndex = 0
        Me.tabCtrlProduto.Size = New System.Drawing.Size(451, 203)
        Me.tabCtrlProduto.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 38)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(443, 161)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Estoque baixo"
        '
        'TextBox2
        '
        Me.TextBox2.ForeColor = System.Drawing.Color.Red
        Me.TextBox2.Location = New System.Drawing.Point(314, 53)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 32)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Text = "230"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(309, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Sapatilha"
        '
        'TextBox1
        '
        Me.TextBox1.ForeColor = System.Drawing.Color.Red
        Me.TextBox1.Location = New System.Drawing.Point(23, 53)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 32)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "500"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total de Items"
        '
        'frmPrincipal
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1202, 542)
        Me.Controls.Add(Me.StatusBaixo)
        Me.Controls.Add(Me.StatusCima)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.gbPrincipal)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Picarruchas::."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusCima.ResumeLayout(False)
        Me.StatusCima.PerformLayout()
        Me.StatusBaixo.ResumeLayout(False)
        Me.StatusBaixo.PerformLayout()
        Me.gbPrincipal.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCtrlProduto.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ConfiguraçõesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProdutosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SobreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusCima As StatusStrip
    Friend WithEvents txtCaption As ToolStripStatusLabel
    Friend WithEvents StatusBaixo As StatusStrip
    Friend WithEvents txtCaptionHora As ToolStripStatusLabel
    Friend WithEvents Timer As Timer
    Friend WithEvents JanelasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents gbPrincipal As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents tabCtrlProduto As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
End Class
