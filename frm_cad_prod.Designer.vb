<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cad_prod
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cad_prod))
        Me.cmb_console = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_cod = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_gerar_cod = New FontAwesome.Sharp.IconButton()
        Me.btn_cad_prod = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_nprod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_qnt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txt_preco = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_console
        '
        Me.cmb_console.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.cmb_console.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_console.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_console.FormattingEnabled = True
        Me.cmb_console.Location = New System.Drawing.Point(163, 200)
        Me.cmb_console.Name = "cmb_console"
        Me.cmb_console.Size = New System.Drawing.Size(121, 24)
        Me.cmb_console.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(185, 120)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(39, 1)
        Me.Panel2.TabIndex = 36
        '
        'txt_cod
        '
        Me.txt_cod.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_cod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cod.ForeColor = System.Drawing.Color.White
        Me.txt_cod.Location = New System.Drawing.Point(185, 102)
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.Size = New System.Drawing.Size(39, 19)
        Me.txt_cod.TabIndex = 35
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(81, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 16)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Cód. Produto"
        '
        'btn_gerar_cod
        '
        Me.btn_gerar_cod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_gerar_cod.FlatAppearance.BorderSize = 2
        Me.btn_gerar_cod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_gerar_cod.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gerar_cod.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_gerar_cod.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.btn_gerar_cod.IconColor = System.Drawing.Color.Gainsboro
        Me.btn_gerar_cod.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_gerar_cod.IconSize = 28
        Me.btn_gerar_cod.Location = New System.Drawing.Point(230, 91)
        Me.btn_gerar_cod.Name = "btn_gerar_cod"
        Me.btn_gerar_cod.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_gerar_cod.Size = New System.Drawing.Size(153, 35)
        Me.btn_gerar_cod.TabIndex = 37
        Me.btn_gerar_cod.Text = "Gerar Cód."
        Me.btn_gerar_cod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_gerar_cod.UseVisualStyleBackColor = True
        '
        'btn_cad_prod
        '
        Me.btn_cad_prod.FlatAppearance.BorderSize = 2
        Me.btn_cad_prod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cad_prod.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cad_prod.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_cad_prod.IconChar = FontAwesome.Sharp.IconChar.CartPlus
        Me.btn_cad_prod.IconColor = System.Drawing.Color.Gainsboro
        Me.btn_cad_prod.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_cad_prod.IconSize = 32
        Me.btn_cad_prod.Location = New System.Drawing.Point(142, 343)
        Me.btn_cad_prod.Name = "btn_cad_prod"
        Me.btn_cad_prod.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_cad_prod.Size = New System.Drawing.Size(208, 45)
        Me.btn_cad_prod.TabIndex = 38
        Me.btn_cad_prod.Text = "Cadastrar Produto"
        Me.btn_cad_prod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cad_prod.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(185, 150)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(133, 1)
        Me.Panel1.TabIndex = 39
        '
        'txt_nprod
        '
        Me.txt_nprod.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_nprod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nprod.ForeColor = System.Drawing.Color.White
        Me.txt_nprod.Location = New System.Drawing.Point(185, 132)
        Me.txt_nprod.Name = "txt_nprod"
        Me.txt_nprod.Size = New System.Drawing.Size(133, 19)
        Me.txt_nprod.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(81, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 16)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Nome Prod."
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(185, 180)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(39, 1)
        Me.Panel3.TabIndex = 42
        '
        'txt_qnt
        '
        Me.txt_qnt.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_qnt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_qnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qnt.ForeColor = System.Drawing.Color.White
        Me.txt_qnt.Location = New System.Drawing.Point(185, 162)
        Me.txt_qnt.Name = "txt_qnt"
        Me.txt_qnt.Size = New System.Drawing.Size(39, 19)
        Me.txt_qnt.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(83, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Quantidade"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(83, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 16)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Console"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(163, 262)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(61, 1)
        Me.Panel5.TabIndex = 48
        '
        'txt_preco
        '
        Me.txt_preco.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_preco.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_preco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_preco.ForeColor = System.Drawing.Color.White
        Me.txt_preco.Location = New System.Drawing.Point(163, 244)
        Me.txt_preco.Name = "txt_preco"
        Me.txt_preco.Size = New System.Drawing.Size(61, 19)
        Me.txt_preco.TabIndex = 47
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(96, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 16)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Preço"
        '
        'frm_cad_prod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(490, 441)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.txt_preco)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.txt_qnt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_nprod)
        Me.Controls.Add(Me.btn_cad_prod)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_gerar_cod)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txt_cod)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmb_console)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_cad_prod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Produtos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_console As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_cod As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_gerar_cod As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_cad_prod As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_nprod As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txt_qnt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txt_preco As TextBox
    Friend WithEvents Label5 As Label
End Class
