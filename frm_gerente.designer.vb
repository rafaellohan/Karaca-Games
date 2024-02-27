<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_gerente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_gerente))
        Me.btn_listagem = New FontAwesome.Sharp.IconButton()
        Me.btn_cad_usu = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_listagem
        '
        Me.btn_listagem.FlatAppearance.BorderSize = 0
        Me.btn_listagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_listagem.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_listagem.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_listagem.IconChar = FontAwesome.Sharp.IconChar.List
        Me.btn_listagem.IconColor = System.Drawing.Color.Gainsboro
        Me.btn_listagem.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_listagem.IconSize = 32
        Me.btn_listagem.Location = New System.Drawing.Point(42, 177)
        Me.btn_listagem.Name = "btn_listagem"
        Me.btn_listagem.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_listagem.Size = New System.Drawing.Size(179, 48)
        Me.btn_listagem.TabIndex = 11
        Me.btn_listagem.Text = "Listagem Geral"
        Me.btn_listagem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_listagem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_listagem.UseVisualStyleBackColor = True
        '
        'btn_cad_usu
        '
        Me.btn_cad_usu.FlatAppearance.BorderSize = 0
        Me.btn_cad_usu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cad_usu.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cad_usu.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_cad_usu.IconChar = FontAwesome.Sharp.IconChar.AddressCard
        Me.btn_cad_usu.IconColor = System.Drawing.Color.Gainsboro
        Me.btn_cad_usu.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_cad_usu.IconSize = 32
        Me.btn_cad_usu.Location = New System.Drawing.Point(41, 231)
        Me.btn_cad_usu.Name = "btn_cad_usu"
        Me.btn_cad_usu.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_cad_usu.Size = New System.Drawing.Size(209, 48)
        Me.btn_cad_usu.TabIndex = 12
        Me.btn_cad_usu.Text = "Cadastro de Usuários"
        Me.btn_cad_usu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cad_usu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cad_usu.UseVisualStyleBackColor = True
        '
        'IconButton2
        '
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton2.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.InfoCircle
        Me.IconButton2.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 32
        Me.IconButton2.Location = New System.Drawing.Point(41, 285)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.IconButton2.Size = New System.Drawing.Size(208, 48)
        Me.IconButton2.TabIndex = 13
        Me.IconButton2.Text = "Relatório de Vendas"
        Me.IconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'IconButton1
        '
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight
        Me.IconButton1.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 32
        Me.IconButton1.Location = New System.Drawing.Point(75, 339)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.IconButton1.Size = New System.Drawing.Size(146, 48)
        Me.IconButton1.TabIndex = 14
        Me.IconButton1.Text = "Sair"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(282, 156)
        Me.Panel1.TabIndex = 15
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(75, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(129, 133)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frm_gerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(282, 441)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.IconButton2)
        Me.Controls.Add(Me.btn_cad_usu)
        Me.Controls.Add(Me.btn_listagem)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_gerente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Karaca Games - Gerente"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_listagem As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_cad_usu As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
