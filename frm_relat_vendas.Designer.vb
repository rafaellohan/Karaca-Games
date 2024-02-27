<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_relat_vendas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_relat_vendas))
        Me.dgv_relat = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_busca = New System.Windows.Forms.ToolStripTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgv_relat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_relat
        '
        Me.dgv_relat.AllowUserToAddRows = False
        Me.dgv_relat.AllowUserToDeleteRows = False
        Me.dgv_relat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_relat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_relat.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.dgv_relat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_relat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_relat.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dgv_relat.GridColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.dgv_relat.Location = New System.Drawing.Point(0, 32)
        Me.dgv_relat.Name = "dgv_relat"
        Me.dgv_relat.ReadOnly = True
        Me.dgv_relat.Size = New System.Drawing.Size(776, 486)
        Me.dgv_relat.TabIndex = 0
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
        Me.Column2.HeaderText = "Cliente"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 77
        '
        'Column3
        '
        Me.Column3.HeaderText = "CPF"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 58
        '
        'Column4
        '
        Me.Column4.HeaderText = "Produto"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 82
        '
        'Column5
        '
        Me.Column5.HeaderText = "Quantidade"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 106
        '
        'Column6
        '
        Me.Column6.HeaderText = "Data/Hora"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 97
        '
        'Column7
        '
        Me.Column7.HeaderText = "Total"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 64
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txt_busca})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(700, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(260, 22)
        Me.ToolStripLabel1.Text = "DIGITE UM CPF PARA BUSCA"
        '
        'txt_busca
        '
        Me.txt_busca.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.txt_busca.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_busca.Name = "txt_busca"
        Me.txt_busca.Size = New System.Drawing.Size(100, 25)
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(636, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'frm_relat_vendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(700, 519)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgv_relat)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_relat_vendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Vendas"
        CType(Me.dgv_relat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_relat As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents txt_busca As ToolStripTextBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents PictureBox1 As PictureBox
End Class
