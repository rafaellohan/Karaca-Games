<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_almoxarife
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_almoxarife))
        Me.btn_cad_produto = New FontAwesome.Sharp.IconButton()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tabela_jogos = New FontAwesome.Sharp.IconButton()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_cad_produto
        '
        Me.btn_cad_produto.FlatAppearance.BorderSize = 0
        Me.btn_cad_produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cad_produto.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cad_produto.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_cad_produto.IconChar = FontAwesome.Sharp.IconChar.CartPlus
        Me.btn_cad_produto.IconColor = System.Drawing.Color.Gainsboro
        Me.btn_cad_produto.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_cad_produto.IconSize = 32
        Me.btn_cad_produto.Location = New System.Drawing.Point(54, 256)
        Me.btn_cad_produto.Name = "btn_cad_produto"
        Me.btn_cad_produto.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_cad_produto.Size = New System.Drawing.Size(160, 48)
        Me.btn_cad_produto.TabIndex = 8
        Me.btn_cad_produto.Text = "Cadastrar Produto"
        Me.btn_cad_produto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cad_produto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cad_produto.UseVisualStyleBackColor = True
        '
        'IconButton3
        '
        Me.IconButton3.FlatAppearance.BorderSize = 0
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton3.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight
        Me.IconButton3.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.IconSize = 32
        Me.IconButton3.Location = New System.Drawing.Point(54, 310)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.IconButton3.Size = New System.Drawing.Size(160, 48)
        Me.IconButton3.TabIndex = 11
        Me.IconButton3.Text = "Sair"
        Me.IconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton3.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(265, 156)
        Me.Panel1.TabIndex = 16
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
        'tabela_jogos
        '
        Me.tabela_jogos.FlatAppearance.BorderSize = 0
        Me.tabela_jogos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tabela_jogos.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabela_jogos.ForeColor = System.Drawing.Color.Gainsboro
        Me.tabela_jogos.IconChar = FontAwesome.Sharp.IconChar.Gamepad
        Me.tabela_jogos.IconColor = System.Drawing.Color.Gainsboro
        Me.tabela_jogos.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.tabela_jogos.IconSize = 32
        Me.tabela_jogos.Location = New System.Drawing.Point(39, 202)
        Me.tabela_jogos.Name = "tabela_jogos"
        Me.tabela_jogos.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.tabela_jogos.Size = New System.Drawing.Size(185, 48)
        Me.tabela_jogos.TabIndex = 17
        Me.tabela_jogos.Text = "Tabela de Jogos"
        Me.tabela_jogos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tabela_jogos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.tabela_jogos.UseVisualStyleBackColor = True
        '
        'frm_almoxarife
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(265, 451)
        Me.Controls.Add(Me.tabela_jogos)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.IconButton3)
        Me.Controls.Add(Me.btn_cad_produto)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_almoxarife"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Karaca Games - Almoxarife"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_cad_produto As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tabela_jogos As FontAwesome.Sharp.IconButton
End Class
