Public Class frm_almoxarife
	Private Sub frm_almoxarife_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectar_banco()

    End Sub
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles btn_cad_produto.Click
        frm_cad_prod.Show()
        Me.Hide()
    End Sub

    Private Sub IconButton1_MouseHover(sender As Object, e As EventArgs) Handles btn_cad_produto.MouseHover
        btn_cad_produto.BackColor = Color.FromArgb(616161)

    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        Call limpar_login()
        Novologin.Show()
        Me.Hide()
    End Sub
    Private Sub tabela_jogos_Click(sender As Object, e As EventArgs) Handles tabela_jogos.Click
        frm_tabela_jogos.Show()
        Me.Hide()

    End Sub
End Class