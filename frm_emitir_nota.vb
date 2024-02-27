Public Class frm_emitir_nota
    Private Sub frm_emitir_nota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectar_banco()
        Call carregar_sacola()

        sql = "select * from tb_prevendas order by cod_venda asc"
        rs = db.Execute(sql)

        With dgv_teste
            .Rows.Clear()
            Do While rs.EOF = False

                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value)
                rs.MoveNext()
            Loop
        End With

        txt_empresa.Text = "Karaca Games LTDA"
        txt_cnpj.Text = "90773482000105"
        txt_cep.Text = "09581-420"
        txt_endereco.Text = " R. Bel Aliance, 225 - Jardim Sao Caetano"
        txt_cidade.Text = "São Caetano do Sul"
        txt_estado.Text = "SP"

        txt_empresa.Enabled = False
        txt_cnpj.Enabled = False
        txt_cep.Enabled = False
        txt_endereco.Enabled = False
        txt_cidade.Enabled = False
        txt_estado.Enabled = False


        ComboBox1.Items.Add("DINHEIRO")

        ComboBox1.Items.Add("CARTÃO - DÉBITO OU CRÉDITO")

        Dim sum As Integer = 0
        For i As Integer = 0 To dgv_teste.Rows.Count() - 1 Step +1
            sum = sum + (dgv_teste.Rows(i).Cells(3).Value * dgv_teste.Rows(i).Cells(4).Value)
        Next
        txt_total.Text = sum.ToString("C")

    End Sub

    Private Sub btn_emitir_nf_Click_1(sender As Object, e As EventArgs) Handles btn_emitir_nf.Click

        If txt_nome_cli.Text = "" Or
                txt_cpf_cli.Text = "" Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
            Exit Sub

        End If

        Dim cod = 0
        Dim data As String = Date.Now

        For i As Integer = 0 To dgv_teste.Rows.Count() - 1 Step +1
            sql = "select last(cod_venda) from tb_vendas"
            rs = db.Execute(sql)
            cod = rs.Fields(0).Value + 1
            sql = "insert into tb_vendas values('" & cod & "', '" & txt_nome_cli.Text & "', '" & txt_cpf_cli.Text & "' ,'" & dgv_teste.Rows(i).Cells(0).Value & "', '" & dgv_teste.Rows(i).Cells(4).Value & "', '" & data & "', '" & txt_total.Text & "')"
            rs = db.Execute(sql)
        Next
        sql = "delete from tb_prevendas"
        rs = db.Execute(sql)
        MsgBox("Comprovante emitido!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        frm_emitir_compra.txt_total.Clear()
        frm_emitir_compra.txt_cod.Clear()
        frm_emitir_compra.txt_console.Clear()
        frm_emitir_compra.txt_nprod.Clear()
        frm_emitir_compra.txt_quantidade.Clear()
        frm_emitir_compra.txt_preco.Clear()
        frm_emitir_compra.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frm_emitir_compra.Show()
        Me.Hide()
    End Sub

    Private Sub txt_total_TextChanged(sender As Object, e As EventArgs) Handles txt_total.TextChanged

    End Sub
End Class