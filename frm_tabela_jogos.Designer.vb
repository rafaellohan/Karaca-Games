<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_tabela_jogos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_tabela_jogos))
        Me.dgv_tabela = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_confirmar = New FontAwesome.Sharp.IconButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txt_qnt = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_qtda = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_console = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nprod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_cod = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.dgv_tabela, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_tabela
        '
        Me.dgv_tabela.AllowUserToAddRows = False
        Me.dgv_tabela.AllowUserToDeleteRows = False
        Me.dgv_tabela.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_tabela.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_tabela.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.dgv_tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_tabela.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgv_tabela.Location = New System.Drawing.Point(0, 0)
        Me.dgv_tabela.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgv_tabela.Name = "dgv_tabela"
        Me.dgv_tabela.ReadOnly = True
        Me.dgv_tabela.Size = New System.Drawing.Size(684, 474)
        Me.dgv_tabela.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 77
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nome"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 70
        '
        'Column3
        '
        Me.Column3.HeaderText = "Quantidade"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 106
        '
        'Column4
        '
        Me.Column4.HeaderText = "Editar"
        Me.Column4.Image = CType(resources.GetObject("Column4.Image"), System.Drawing.Image)
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 51
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Editar"
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(3, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(690, 505)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.PictureBox2)
        Me.TabPage1.Controls.Add(Me.dgv_tabela)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(682, 477)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Produtos"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(597, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.PictureBox1)
        Me.TabPage2.Controls.Add(Me.btn_confirmar)
        Me.TabPage2.Controls.Add(Me.Panel5)
        Me.TabPage2.Controls.Add(Me.txt_qnt)
        Me.TabPage2.Controls.Add(Me.Panel4)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.txt_qtda)
        Me.TabPage2.Controls.Add(Me.Panel3)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.txt_console)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txt_nprod)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Controls.Add(Me.txt_cod)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(682, 477)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Baixa Estoque"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(593, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.TabIndex = 63
        Me.PictureBox1.TabStop = False
        '
        'btn_confirmar
        '
        Me.btn_confirmar.FlatAppearance.BorderSize = 2
        Me.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_confirmar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirmar.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_confirmar.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.btn_confirmar.IconColor = System.Drawing.Color.Gainsboro
        Me.btn_confirmar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_confirmar.IconSize = 32
        Me.btn_confirmar.Location = New System.Drawing.Point(273, 313)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_confirmar.Size = New System.Drawing.Size(188, 48)
        Me.btn_confirmar.TabIndex = 62
        Me.btn_confirmar.Text = "Confirmar"
        Me.btn_confirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_confirmar.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(389, 258)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(55, 1)
        Me.Panel5.TabIndex = 61
        '
        'txt_qnt
        '
        Me.txt_qnt.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_qnt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_qnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qnt.ForeColor = System.Drawing.Color.White
        Me.txt_qnt.Location = New System.Drawing.Point(386, 240)
        Me.txt_qnt.Name = "txt_qnt"
        Me.txt_qnt.Size = New System.Drawing.Size(58, 19)
        Me.txt_qnt.TabIndex = 60
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(341, 195)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(120, 1)
        Me.Panel4.TabIndex = 58
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(292, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Quantidade"
        '
        'txt_qtda
        '
        Me.txt_qtda.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_qtda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_qtda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qtda.ForeColor = System.Drawing.Color.White
        Me.txt_qtda.Location = New System.Drawing.Point(341, 177)
        Me.txt_qtda.Name = "txt_qtda"
        Me.txt_qtda.Size = New System.Drawing.Size(120, 19)
        Me.txt_qtda.TabIndex = 57
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(341, 163)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(178, 1)
        Me.Panel3.TabIndex = 55
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(208, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 16)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Quantidade Atual"
        '
        'txt_console
        '
        Me.txt_console.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_console.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_console.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_console.ForeColor = System.Drawing.Color.White
        Me.txt_console.Location = New System.Drawing.Point(341, 145)
        Me.txt_console.Name = "txt_console"
        Me.txt_console.Size = New System.Drawing.Size(178, 19)
        Me.txt_console.TabIndex = 54
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(341, 128)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(178, 1)
        Me.Panel1.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(270, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 16)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Console"
        '
        'txt_nprod
        '
        Me.txt_nprod.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_nprod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nprod.ForeColor = System.Drawing.Color.White
        Me.txt_nprod.Location = New System.Drawing.Point(341, 107)
        Me.txt_nprod.Name = "txt_nprod"
        Me.txt_nprod.Size = New System.Drawing.Size(178, 19)
        Me.txt_nprod.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(228, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 16)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Nome Produto"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(341, 91)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(39, 1)
        Me.Panel2.TabIndex = 49
        '
        'txt_cod
        '
        Me.txt_cod.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_cod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cod.ForeColor = System.Drawing.Color.White
        Me.txt_cod.Location = New System.Drawing.Point(341, 73)
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.Size = New System.Drawing.Size(39, 19)
        Me.txt_cod.TabIndex = 48
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(237, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 16)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Cód. Produto"
        '
        'frm_tabela_jogos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(692, 519)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frm_tabela_jogos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Controle de Estoque"
        CType(Me.dgv_tabela, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_tabela As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btn_confirmar As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txt_qnt As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_qtda As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_console As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_nprod As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_cod As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
