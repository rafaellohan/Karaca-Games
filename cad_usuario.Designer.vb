<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cad_usuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cad_usuario))
        Me.cmb_funcao = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_cadastrar = New FontAwesome.Sharp.IconButton()
        Me.btn_gerar = New FontAwesome.Sharp.IconButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_cpf = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txt_confsenha = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txt_chave = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_funcao
        '
        Me.cmb_funcao.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.cmb_funcao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_funcao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmb_funcao.FormattingEnabled = True
        Me.cmb_funcao.Location = New System.Drawing.Point(167, 140)
        Me.cmb_funcao.Name = "cmb_funcao"
        Me.cmb_funcao.Size = New System.Drawing.Size(179, 24)
        Me.cmb_funcao.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'img_foto
        '
        Me.img_foto.Image = CType(resources.GetObject("img_foto.Image"), System.Drawing.Image)
        Me.img_foto.Location = New System.Drawing.Point(416, 74)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(139, 127)
        Me.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.img_foto.TabIndex = 19
        Me.img_foto.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.FlatAppearance.BorderSize = 2
        Me.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cadastrar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_cadastrar.IconChar = FontAwesome.Sharp.IconChar.IdBadge
        Me.btn_cadastrar.IconColor = System.Drawing.Color.Gainsboro
        Me.btn_cadastrar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_cadastrar.IconSize = 32
        Me.btn_cadastrar.Location = New System.Drawing.Point(193, 351)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_cadastrar.Size = New System.Drawing.Size(188, 48)
        Me.btn_cadastrar.TabIndex = 20
        Me.btn_cadastrar.Text = "Cadastrar"
        Me.btn_cadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cadastrar.UseVisualStyleBackColor = True
        '
        'btn_gerar
        '
        Me.btn_gerar.FlatAppearance.BorderSize = 2
        Me.btn_gerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_gerar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gerar.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_gerar.IconChar = FontAwesome.Sharp.IconChar.Key
        Me.btn_gerar.IconColor = System.Drawing.Color.Gainsboro
        Me.btn_gerar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_gerar.IconSize = 32
        Me.btn_gerar.Location = New System.Drawing.Point(391, 248)
        Me.btn_gerar.Name = "btn_gerar"
        Me.btn_gerar.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_gerar.Size = New System.Drawing.Size(164, 37)
        Me.btn_gerar.TabIndex = 21
        Me.btn_gerar.Text = "Gerar Chave"
        Me.btn_gerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_gerar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(105, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 16)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Nome"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(113, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 16)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "CPF:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label9.Location = New System.Drawing.Point(98, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "E-mail:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label10.Location = New System.Drawing.Point(91, 141)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 16)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Função:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label11.Location = New System.Drawing.Point(98, 180)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 16)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Senha:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label12.Location = New System.Drawing.Point(34, 215)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(124, 16)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Confirmar senha:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label13.Location = New System.Drawing.Point(34, 254)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 16)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Chave de Login:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(168, 64)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(178, 1)
        Me.Panel2.TabIndex = 30
        '
        'txt_nome
        '
        Me.txt_nome.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.ForeColor = System.Drawing.Color.White
        Me.txt_nome.Location = New System.Drawing.Point(168, 43)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(178, 19)
        Me.txt_nome.TabIndex = 29
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(167, 95)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(178, 1)
        Me.Panel1.TabIndex = 32
        '
        'txt_cpf
        '
        Me.txt_cpf.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.ForeColor = System.Drawing.Color.White
        Me.txt_cpf.Location = New System.Drawing.Point(167, 74)
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(178, 19)
        Me.txt_cpf.TabIndex = 31
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(167, 125)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(178, 1)
        Me.Panel3.TabIndex = 34
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.ForeColor = System.Drawing.Color.White
        Me.txt_email.Location = New System.Drawing.Point(167, 104)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(178, 19)
        Me.txt_email.TabIndex = 33
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(167, 198)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(178, 1)
        Me.Panel4.TabIndex = 36
        '
        'txt_senha
        '
        Me.txt_senha.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_senha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.ForeColor = System.Drawing.Color.White
        Me.txt_senha.Location = New System.Drawing.Point(167, 177)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha.Size = New System.Drawing.Size(178, 19)
        Me.txt_senha.TabIndex = 35
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(164, 233)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(178, 1)
        Me.Panel5.TabIndex = 38
        '
        'txt_confsenha
        '
        Me.txt_confsenha.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_confsenha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_confsenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_confsenha.ForeColor = System.Drawing.Color.White
        Me.txt_confsenha.Location = New System.Drawing.Point(164, 212)
        Me.txt_confsenha.Name = "txt_confsenha"
        Me.txt_confsenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_confsenha.Size = New System.Drawing.Size(178, 19)
        Me.txt_confsenha.TabIndex = 37
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(167, 270)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(178, 1)
        Me.Panel6.TabIndex = 40
        '
        'txt_chave
        '
        Me.txt_chave.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_chave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_chave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_chave.ForeColor = System.Drawing.Color.White
        Me.txt_chave.Location = New System.Drawing.Point(167, 251)
        Me.txt_chave.Name = "txt_chave"
        Me.txt_chave.Size = New System.Drawing.Size(178, 19)
        Me.txt_chave.TabIndex = 39
        '
        'cad_usuario
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(633, 441)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.txt_chave)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.txt_confsenha)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btn_gerar)
        Me.Controls.Add(Me.btn_cadastrar)
        Me.Controls.Add(Me.img_foto)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmb_funcao)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "cad_usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Usuários"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_funcao As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_cadastrar As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_gerar As FontAwesome.Sharp.IconButton
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_cpf As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txt_confsenha As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txt_chave As TextBox
End Class
