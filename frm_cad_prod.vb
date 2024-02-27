Public Class frm_cad_prod
    Private Sub frm_cad_prod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectar_banco()
        Call carregar_jogo()
        txt_cod.Enabled = False
    End Sub
    Private Sub btn_gerar_cod_Click_1(sender As Object, e As EventArgs) Handles btn_gerar_cod.Click
        cont = 1
        Dim x = 0
        Try
            sql = "select last(cod_produto) from tb_jogos"
            rs = db.Execute(sql)
            x = rs.Fields(0).Value + 1
            txt_cod.Text = x
        Catch ex As Exception
            MsgBox("ERRO!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try

    End Sub

    Private Sub btn_cad_prod_Click(sender As Object, e As EventArgs) Handles btn_cad_prod.Click
        sql = "select * from tb_jogos where cod_produto ='" & txt_cod.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = True Then
            sql = "insert into tb_jogos values ('" & txt_cod.Text & "', '" & txt_nprod.Text & "', '" & cmb_console.Text & "', '" & txt_preco.Text & "', '" & txt_qnt.Text & "')"
            rs = db.Execute(UCase(sql))
            MsgBox("Produto cadastrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            limpar()

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frm_almoxarife.Show()
        Me.Hide()
    End Sub
End Class