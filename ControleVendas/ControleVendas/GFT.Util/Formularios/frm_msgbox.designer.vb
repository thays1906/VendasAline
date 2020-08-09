<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_msgbox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_msgbox))
        Me.lblTexto = New System.Windows.Forms.Label()
        Me.imgMsgBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn3 = New GFT.Util.SuperButton()
        Me.btn2 = New GFT.Util.SuperButton()
        Me.btn1 = New GFT.Util.SuperButton()
        CType(Me.imgMsgBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTexto
        '
        Me.lblTexto.BackColor = System.Drawing.Color.Transparent
        Me.lblTexto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTexto.Location = New System.Drawing.Point(3, 62)
        Me.lblTexto.Name = "lblTexto"
        Me.lblTexto.Size = New System.Drawing.Size(497, 125)
        Me.lblTexto.TabIndex = 1
        Me.lblTexto.Text = "Texto label messagebox"
        Me.lblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'imgMsgBox
        '
        Me.imgMsgBox.BackColor = System.Drawing.Color.Transparent
        Me.imgMsgBox.Image = Global.GFT.Util.My.Resources.Resources.btnOk
        Me.imgMsgBox.Location = New System.Drawing.Point(12, 90)
        Me.imgMsgBox.Name = "imgMsgBox"
        Me.imgMsgBox.Size = New System.Drawing.Size(53, 53)
        Me.imgMsgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.imgMsgBox.TabIndex = 6
        Me.imgMsgBox.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(-23, 230)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1100, 35)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(164, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(507, 56)
        Me.Panel1.TabIndex = 7
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btn3.BackgroundImage = Global.GFT.Util.My.Resources.Resources.botao2
        Me.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn3.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.btn3.ForeColor = System.Drawing.Color.Black
        Me.btn3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn3.Location = New System.Drawing.Point(306, 198)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(78, 26)
        Me.btn3.TabIndex = 4
        Me.btn3.Text = "Botão 3"
        Me.btn3.UseCompatibleTextRendering = True
        Me.btn3.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btn2.BackgroundImage = Global.GFT.Util.My.Resources.Resources.botao2
        Me.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn2.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.btn2.ForeColor = System.Drawing.Color.Black
        Me.btn2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn2.Location = New System.Drawing.Point(222, 198)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(78, 26)
        Me.btn2.TabIndex = 3
        Me.btn2.Text = "Botão 2"
        Me.btn2.UseCompatibleTextRendering = True
        Me.btn2.UseVisualStyleBackColor = False
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btn1.BackgroundImage = Global.GFT.Util.My.Resources.Resources.botao2a
        Me.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.btn1.ForeColor = System.Drawing.Color.Black
        Me.btn1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn1.Location = New System.Drawing.Point(138, 198)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(78, 26)
        Me.btn1.TabIndex = 2
        Me.btn1.Text = "Botão 1"
        Me.btn1.UseCompatibleTextRendering = True
        Me.btn1.UseVisualStyleBackColor = False
        '
        'frm_msgbox
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(507, 266)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.imgMsgBox)
        Me.Controls.Add(Me.lblTexto)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_msgbox"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Texto messagebox!"
        CType(Me.imgMsgBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Public WithEvents lblTexto As System.Windows.Forms.Label
    Friend WithEvents imgMsgBox As System.Windows.Forms.PictureBox
    Friend WithEvents btn3 As GFT.Util.SuperButton
    Friend WithEvents btn2 As GFT.Util.SuperButton
    Friend WithEvents btn1 As GFT.Util.SuperButton
    Friend WithEvents Panel1 As Panel
End Class
