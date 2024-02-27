<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_list
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_list))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.btn_att = New FontAwesome.Sharp.IconButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txt_chave = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_funcao = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_cpf = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_listagem = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_busca = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_listagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 28)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(862, 374)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.img_foto)
        Me.TabPage1.Controls.Add(Me.btn_att)
        Me.TabPage1.Controls.Add(Me.Panel4)
        Me.TabPage1.Controls.Add(Me.txt_chave)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.cmb_funcao)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Controls.Add(Me.txt_email)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.txt_cpf)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txt_nome)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.ForeColor = System.Drawing.Color.Black
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage1.Size = New System.Drawing.Size(854, 346)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ATUALIZAR"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(747, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'img_foto
        '
        Me.img_foto.Image = CType(resources.GetObject("img_foto.Image"), System.Drawing.Image)
        Me.img_foto.Location = New System.Drawing.Point(555, 63)
        Me.img_foto.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(169, 158)
        Me.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.img_foto.TabIndex = 48
        Me.img_foto.TabStop = False
        '
        'btn_att
        '
        Me.btn_att.FlatAppearance.BorderSize = 2
        Me.btn_att.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_att.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_att.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_att.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.btn_att.IconColor = System.Drawing.Color.Gainsboro
        Me.btn_att.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_att.IconSize = 32
        Me.btn_att.Location = New System.Drawing.Point(286, 272)
        Me.btn_att.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_att.Name = "btn_att"
        Me.btn_att.Padding = New System.Windows.Forms.Padding(13, 0, 13, 0)
        Me.btn_att.Size = New System.Drawing.Size(152, 53)
        Me.btn_att.TabIndex = 47
        Me.btn_att.Text = "Atualizar"
        Me.btn_att.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_att.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(170, 226)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(193, 1)
        Me.Panel4.TabIndex = 41
        '
        'txt_chave
        '
        Me.txt_chave.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_chave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_chave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_chave.ForeColor = System.Drawing.Color.White
        Me.txt_chave.Location = New System.Drawing.Point(170, 205)
        Me.txt_chave.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_chave.Name = "txt_chave"
        Me.txt_chave.Size = New System.Drawing.Size(193, 19)
        Me.txt_chave.TabIndex = 40
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(72, 163)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 16)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Função:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(76, 205)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Chave:"
        '
        'cmb_funcao
        '
        Me.cmb_funcao.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.cmb_funcao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_funcao.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_funcao.FormattingEnabled = True
        Me.cmb_funcao.Location = New System.Drawing.Point(170, 163)
        Me.cmb_funcao.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmb_funcao.Name = "cmb_funcao"
        Me.cmb_funcao.Size = New System.Drawing.Size(160, 24)
        Me.cmb_funcao.TabIndex = 45
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(170, 140)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(357, 1)
        Me.Panel3.TabIndex = 44
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.ForeColor = System.Drawing.Color.White
        Me.txt_email.Location = New System.Drawing.Point(170, 119)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(357, 19)
        Me.txt_email.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(72, 119)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "E-mail:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(170, 103)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(268, 1)
        Me.Panel1.TabIndex = 41
        '
        'txt_cpf
        '
        Me.txt_cpf.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.ForeColor = System.Drawing.Color.White
        Me.txt_cpf.Location = New System.Drawing.Point(170, 83)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(268, 19)
        Me.txt_cpf.TabIndex = 40
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(170, 63)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(357, 1)
        Me.Panel2.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(72, 83)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 16)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "CPF:"
        '
        'txt_nome
        '
        Me.txt_nome.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.ForeColor = System.Drawing.Color.White
        Me.txt_nome.Location = New System.Drawing.Point(170, 42)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(357, 19)
        Me.txt_nome.TabIndex = 37
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(72, 42)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 16)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Nome:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgv_listagem)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage2.Size = New System.Drawing.Size(854, 346)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "FUNCIONÁRIOS"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgv_listagem
        '
        Me.dgv_listagem.AllowUserToAddRows = False
        Me.dgv_listagem.AllowUserToDeleteRows = False
        Me.dgv_listagem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_listagem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_listagem.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.dgv_listagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_listagem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewImageColumn1, Me.DataGridViewImageColumn2, Me.DataGridViewImageColumn3, Me.Column1})
        Me.dgv_listagem.GridColor = System.Drawing.Color.CadetBlue
        Me.dgv_listagem.Location = New System.Drawing.Point(8, 7)
        Me.dgv_listagem.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgv_listagem.Name = "dgv_listagem"
        Me.dgv_listagem.ReadOnly = True
        Me.dgv_listagem.Size = New System.Drawing.Size(815, 342)
        Me.dgv_listagem.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "N"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 42
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "CHAVE"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 76
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "NOME"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 73
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "CPF"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 58
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "FUNÇÃO"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 87
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "STATUS"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 84
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "EDITAR"
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Width = 62
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "EXCLUIR"
        Me.DataGridViewImageColumn2.Image = CType(resources.GetObject("DataGridViewImageColumn2.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        Me.DataGridViewImageColumn2.Width = 72
        '
        'DataGridViewImageColumn3
        '
        Me.DataGridViewImageColumn3.HeaderText = "BLOQUEAR"
        Me.DataGridViewImageColumn3.Image = CType(resources.GetObject("DataGridViewImageColumn3.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        Me.DataGridViewImageColumn3.ReadOnly = True
        Me.DataGridViewImageColumn3.Width = 87
        '
        'Column1
        '
        Me.Column1.HeaderText = "ATIVAR"
        Me.Column1.Image = CType(resources.GetObject("Column1.Image"), System.Drawing.Image)
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 59
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txt_busca, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(815, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(240, 22)
        Me.ToolStripLabel1.Text = "DIGITE UM CPF PARA BUSCA"
        '
        'txt_busca
        '
        Me.txt_busca.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.txt_busca.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_busca.Name = "txt_busca"
        Me.txt_busca.Size = New System.Drawing.Size(132, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frm_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 399)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frm_list"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listagem Geral"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv_listagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txt_busca As ToolStripTextBox
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents dgv_listagem As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn3 As DataGridViewImageColumn
    Friend WithEvents Column1 As DataGridViewImageColumn
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_cpf As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txt_chave As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_funcao As ComboBox
    Friend WithEvents btn_att As FontAwesome.Sharp.IconButton
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
