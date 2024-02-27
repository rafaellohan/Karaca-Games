<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_emitir_compra
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_emitir_compra))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgv_sacola = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QUANTIDADE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_cod = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_nprod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_console = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txt_preco = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txt_quantidade = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_emitir_venda = New FontAwesome.Sharp.IconButton()
        Me.btn_prosseguir = New FontAwesome.Sharp.IconButton()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_sacola, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'dgv_sacola
        '
        Me.dgv_sacola.AllowUserToAddRows = False
        Me.dgv_sacola.AllowUserToDeleteRows = False
        Me.dgv_sacola.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_sacola.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_sacola.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.dgv_sacola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_sacola.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.QUANTIDADE})
        Me.dgv_sacola.Location = New System.Drawing.Point(388, 17)
        Me.dgv_sacola.Name = "dgv_sacola"
        Me.dgv_sacola.ReadOnly = True
        Me.dgv_sacola.Size = New System.Drawing.Size(469, 294)
        Me.dgv_sacola.TabIndex = 12
        '
        'Column1
        '
        Me.Column1.HeaderText = "N"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.Width = 40
        '
        'Column2
        '
        Me.Column2.HeaderText = "CÓDIGO"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 74
        '
        'Column3
        '
        Me.Column3.HeaderText = "NOME"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 64
        '
        'Column4
        '
        Me.Column4.HeaderText = "CONSOLE"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 83
        '
        'Column5
        '
        Me.Column5.HeaderText = "PREÇO"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 69
        '
        'QUANTIDADE
        '
        Me.QUANTIDADE.HeaderText = "QUANTIDADE"
        Me.QUANTIDADE.Name = "QUANTIDADE"
        Me.QUANTIDADE.ReadOnly = True
        Me.QUANTIDADE.Width = 103
        '
        'Timer1
        '
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(725, 409)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 17
        Me.TextBox2.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(179, 71)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(39, 1)
        Me.Panel3.TabIndex = 45
        '
        'txt_cod
        '
        Me.txt_cod.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_cod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cod.ForeColor = System.Drawing.Color.White
        Me.txt_cod.Location = New System.Drawing.Point(179, 53)
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.Size = New System.Drawing.Size(39, 19)
        Me.txt_cod.TabIndex = 44
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(77, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 16)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Cód. Produto"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(179, 97)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(177, 1)
        Me.Panel1.TabIndex = 48
        '
        'txt_nprod
        '
        Me.txt_nprod.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_nprod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nprod.ForeColor = System.Drawing.Color.White
        Me.txt_nprod.Location = New System.Drawing.Point(179, 78)
        Me.txt_nprod.Name = "txt_nprod"
        Me.txt_nprod.Size = New System.Drawing.Size(177, 19)
        Me.txt_nprod.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(117, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Nome:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(179, 125)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(177, 1)
        Me.Panel2.TabIndex = 51
        '
        'txt_console
        '
        Me.txt_console.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_console.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_console.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_console.ForeColor = System.Drawing.Color.White
        Me.txt_console.Location = New System.Drawing.Point(179, 107)
        Me.txt_console.Name = "txt_console"
        Me.txt_console.Size = New System.Drawing.Size(177, 19)
        Me.txt_console.TabIndex = 50
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(101, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 16)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Console:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(176, 155)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(177, 1)
        Me.Panel4.TabIndex = 54
        '
        'txt_preco
        '
        Me.txt_preco.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_preco.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_preco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_preco.ForeColor = System.Drawing.Color.White
        Me.txt_preco.Location = New System.Drawing.Point(176, 137)
        Me.txt_preco.Name = "txt_preco"
        Me.txt_preco.Size = New System.Drawing.Size(177, 19)
        Me.txt_preco.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(117, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Preço:"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(176, 184)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(88, 1)
        Me.Panel5.TabIndex = 57
        '
        'txt_quantidade
        '
        Me.txt_quantidade.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_quantidade.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_quantidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_quantidade.ForeColor = System.Drawing.Color.White
        Me.txt_quantidade.Location = New System.Drawing.Point(176, 166)
        Me.txt_quantidade.Name = "txt_quantidade"
        Me.txt_quantidade.Size = New System.Drawing.Size(88, 19)
        Me.txt_quantidade.TabIndex = 56
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(82, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Quantidade"
        '
        'btn_emitir_venda
        '
        Me.btn_emitir_venda.FlatAppearance.BorderSize = 2
        Me.btn_emitir_venda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_emitir_venda.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_emitir_venda.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_emitir_venda.IconChar = FontAwesome.Sharp.IconChar.CartPlus
        Me.btn_emitir_venda.IconColor = System.Drawing.Color.Gainsboro
        Me.btn_emitir_venda.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_emitir_venda.IconSize = 32
        Me.btn_emitir_venda.Location = New System.Drawing.Point(85, 245)
        Me.btn_emitir_venda.Name = "btn_emitir_venda"
        Me.btn_emitir_venda.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_emitir_venda.Size = New System.Drawing.Size(220, 48)
        Me.btn_emitir_venda.TabIndex = 58
        Me.btn_emitir_venda.Text = "Adicionar na sacola"
        Me.btn_emitir_venda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_emitir_venda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_emitir_venda.UseVisualStyleBackColor = True
        '
        'btn_prosseguir
        '
        Me.btn_prosseguir.FlatAppearance.BorderSize = 2
        Me.btn_prosseguir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_prosseguir.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_prosseguir.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_prosseguir.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight
        Me.btn_prosseguir.IconColor = System.Drawing.Color.Gainsboro
        Me.btn_prosseguir.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_prosseguir.IconSize = 32
        Me.btn_prosseguir.Location = New System.Drawing.Point(311, 369)
        Me.btn_prosseguir.Name = "btn_prosseguir"
        Me.btn_prosseguir.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_prosseguir.Size = New System.Drawing.Size(221, 48)
        Me.btn_prosseguir.TabIndex = 59
        Me.btn_prosseguir.Text = "Prosseguir"
        Me.btn_prosseguir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_prosseguir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_prosseguir.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(548, 348)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(88, 1)
        Me.Panel6.TabIndex = 62
        '
        'txt_total
        '
        Me.txt_total.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.ForeColor = System.Drawing.Color.White
        Me.txt_total.Location = New System.Drawing.Point(548, 330)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(88, 19)
        Me.txt_total.TabIndex = 61
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(494, 330)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Total:"
        '
        'frm_emitir_compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(896, 441)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_prosseguir)
        Me.Controls.Add(Me.btn_emitir_venda)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.txt_quantidade)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.txt_preco)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txt_console)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_nprod)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.txt_cod)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.dgv_sacola)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_emitir_compra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Emitir Compra"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_sacola, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Public WithEvents dgv_sacola As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents QUANTIDADE As DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txt_cod As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_nprod As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_console As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txt_preco As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txt_quantidade As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_emitir_venda As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_prosseguir As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txt_total As TextBox
    Friend WithEvents Label5 As Label
End Class
