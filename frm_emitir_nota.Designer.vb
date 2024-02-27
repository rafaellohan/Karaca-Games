<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_emitir_nota
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_emitir_nota))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgv_teste = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_empresa = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_cnpj = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_cep = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txt_endereco = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txt_cidade = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txt_estado = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txt_nome_cli = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.txt_cpf_cli = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_emitir_nf = New FontAwesome.Sharp.IconButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_teste, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'dgv_teste
        '
        Me.dgv_teste.AllowUserToAddRows = False
        Me.dgv_teste.AllowUserToDeleteRows = False
        Me.dgv_teste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_teste.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_teste.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.dgv_teste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_teste.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgv_teste.Location = New System.Drawing.Point(82, 12)
        Me.dgv_teste.Name = "dgv_teste"
        Me.dgv_teste.ReadOnly = True
        Me.dgv_teste.Size = New System.Drawing.Size(439, 150)
        Me.dgv_teste.TabIndex = 71
        '
        'Column1
        '
        Me.Column1.HeaderText = "CÓDIGO"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 74
        '
        'Column2
        '
        Me.Column2.HeaderText = "NOME"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 64
        '
        'Column3
        '
        Me.Column3.HeaderText = "CONSOLE"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 83
        '
        'Column4
        '
        Me.Column4.HeaderText = "PREÇO"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 69
        '
        'Column5
        '
        Me.Column5.HeaderText = "QUANTIDADE"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 103
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(106, 198)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(187, 1)
        Me.Panel2.TabIndex = 75
        '
        'txt_empresa
        '
        Me.txt_empresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_empresa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_empresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_empresa.ForeColor = System.Drawing.Color.White
        Me.txt_empresa.Location = New System.Drawing.Point(106, 177)
        Me.txt_empresa.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_empresa.Name = "txt_empresa"
        Me.txt_empresa.Size = New System.Drawing.Size(187, 19)
        Me.txt_empresa.TabIndex = 74
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(24, 180)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 16)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Empresa:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(106, 235)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(187, 1)
        Me.Panel1.TabIndex = 78
        '
        'txt_cnpj
        '
        Me.txt_cnpj.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_cnpj.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cnpj.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cnpj.ForeColor = System.Drawing.Color.White
        Me.txt_cnpj.Location = New System.Drawing.Point(106, 214)
        Me.txt_cnpj.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_cnpj.Name = "txt_cnpj"
        Me.txt_cnpj.Size = New System.Drawing.Size(187, 19)
        Me.txt_cnpj.TabIndex = 77
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(47, 217)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "CNPJ:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(106, 272)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(187, 1)
        Me.Panel3.TabIndex = 81
        '
        'txt_cep
        '
        Me.txt_cep.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_cep.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cep.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cep.ForeColor = System.Drawing.Color.White
        Me.txt_cep.Location = New System.Drawing.Point(106, 251)
        Me.txt_cep.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.Size = New System.Drawing.Size(187, 19)
        Me.txt_cep.TabIndex = 80
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(56, 257)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 16)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "CEP:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(106, 303)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(187, 1)
        Me.Panel4.TabIndex = 84
        '
        'txt_endereco
        '
        Me.txt_endereco.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_endereco.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_endereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_endereco.ForeColor = System.Drawing.Color.White
        Me.txt_endereco.Location = New System.Drawing.Point(106, 282)
        Me.txt_endereco.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.Size = New System.Drawing.Size(187, 19)
        Me.txt_endereco.TabIndex = 83
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(19, 285)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Endereço:"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(106, 332)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(187, 1)
        Me.Panel5.TabIndex = 87
        '
        'txt_cidade
        '
        Me.txt_cidade.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_cidade.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cidade.ForeColor = System.Drawing.Color.White
        Me.txt_cidade.Location = New System.Drawing.Point(106, 311)
        Me.txt_cidade.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_cidade.Name = "txt_cidade"
        Me.txt_cidade.Size = New System.Drawing.Size(187, 19)
        Me.txt_cidade.TabIndex = 86
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(36, 317)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 16)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "Cidade:"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(106, 365)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(187, 1)
        Me.Panel6.TabIndex = 90
        '
        'txt_estado
        '
        Me.txt_estado.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_estado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_estado.ForeColor = System.Drawing.Color.White
        Me.txt_estado.Location = New System.Drawing.Point(106, 344)
        Me.txt_estado.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_estado.Name = "txt_estado"
        Me.txt_estado.Size = New System.Drawing.Size(187, 19)
        Me.txt_estado.TabIndex = 89
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(37, 347)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 16)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "Estado:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(305, 188)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 16)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "Pagamento:"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(404, 180)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox1.TabIndex = 92
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(431, 238)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(121, 1)
        Me.Panel7.TabIndex = 95
        '
        'txt_total
        '
        Me.txt_total.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.ForeColor = System.Drawing.Color.White
        Me.txt_total.Location = New System.Drawing.Point(435, 220)
        Me.txt_total.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(121, 19)
        Me.txt_total.TabIndex = 94
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label9.Location = New System.Drawing.Point(379, 220)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 16)
        Me.Label9.TabIndex = 93
        Me.Label9.Text = "Total:"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel8.Location = New System.Drawing.Point(431, 278)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(121, 1)
        Me.Panel8.TabIndex = 98
        '
        'txt_nome_cli
        '
        Me.txt_nome_cli.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_nome_cli.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nome_cli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_cli.ForeColor = System.Drawing.Color.White
        Me.txt_nome_cli.Location = New System.Drawing.Point(431, 257)
        Me.txt_nome_cli.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_nome_cli.Name = "txt_nome_cli"
        Me.txt_nome_cli.Size = New System.Drawing.Size(121, 19)
        Me.txt_nome_cli.TabIndex = 97
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label10.Location = New System.Drawing.Point(367, 257)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 16)
        Me.Label10.TabIndex = 96
        Me.Label10.Text = "Cliente:"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel9.Location = New System.Drawing.Point(431, 309)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(121, 1)
        Me.Panel9.TabIndex = 101
        '
        'txt_cpf_cli
        '
        Me.txt_cpf_cli.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_cpf_cli.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cpf_cli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf_cli.ForeColor = System.Drawing.Color.White
        Me.txt_cpf_cli.Location = New System.Drawing.Point(431, 288)
        Me.txt_cpf_cli.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_cpf_cli.Name = "txt_cpf_cli"
        Me.txt_cpf_cli.Size = New System.Drawing.Size(121, 19)
        Me.txt_cpf_cli.TabIndex = 100
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label7.Location = New System.Drawing.Point(386, 294)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 16)
        Me.Label7.TabIndex = 99
        Me.Label7.Text = "CPF:"
        '
        'btn_emitir_nf
        '
        Me.btn_emitir_nf.FlatAppearance.BorderSize = 2
        Me.btn_emitir_nf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_emitir_nf.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_emitir_nf.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_emitir_nf.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.btn_emitir_nf.IconColor = System.Drawing.Color.Gainsboro
        Me.btn_emitir_nf.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_emitir_nf.IconSize = 32
        Me.btn_emitir_nf.Location = New System.Drawing.Point(177, 383)
        Me.btn_emitir_nf.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_emitir_nf.Name = "btn_emitir_nf"
        Me.btn_emitir_nf.Padding = New System.Windows.Forms.Padding(13, 0, 13, 0)
        Me.btn_emitir_nf.Size = New System.Drawing.Size(213, 46)
        Me.btn_emitir_nf.TabIndex = 102
        Me.btn_emitir_nf.Text = "Emitir Comprovante"
        Me.btn_emitir_nf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_emitir_nf.UseVisualStyleBackColor = True
        '
        'frm_emitir_nota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(568, 441)
        Me.Controls.Add(Me.btn_emitir_nf)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.txt_cpf_cli)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.txt_nome_cli)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.txt_estado)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.txt_cidade)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.txt_endereco)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.txt_cep)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_cnpj)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_empresa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgv_teste)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_emitir_nota"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Emitir Comprovante de Venda"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_teste, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgv_teste As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_empresa As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_cnpj As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txt_cep As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txt_endereco As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txt_cidade As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txt_estado As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txt_total As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txt_nome_cli As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents txt_cpf_cli As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_emitir_nf As FontAwesome.Sharp.IconButton
End Class
