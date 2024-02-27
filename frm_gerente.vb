Public Class frm_gerente
    Private Sub btn_cad_usu_Click(sender As Object, e As EventArgs)
        cad_usuario.Show()
        Me.Hide()
    End Sub
    Private Sub btn_listagem_Click(sender As Object, e As EventArgs) Handles btn_listagem.Click
        frm_list.Show()
        Me.Hide()
    End Sub

    Private Sub btn_cad_usu_Click_1(sender As Object, e As EventArgs) Handles btn_cad_usu.Click
        cad_usuario.Show()
        Me.Hide()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Call limpar_login()
        Novologin.Show()
        Me.Hide()
    End Sub

    Private Sub btn_listagem_MouseHover(sender As Object, e As EventArgs) Handles btn_listagem.MouseHover
        btn_cad_usu.BackColor = Color.FromArgb(616161)
    End Sub

    Private Sub btn_cad_usu_MouseHover(sender As Object, e As EventArgs) Handles btn_cad_usu.MouseHover
        btn_cad_usu.BackColor = Color.FromArgb(616161)

    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        frm_relat_vendas.Show()
        Me.Hide()
    End Sub

    Private Sub IconButton2_MouseHover(sender As Object, e As EventArgs) Handles IconButton2.MouseHover
        btn_cad_usu.BackColor = Color.FromArgb(616161)

    End Sub

    Private Sub IconButton1_MouseHover(sender As Object, e As EventArgs) Handles IconButton1.MouseHover
        btn_cad_usu.BackColor = Color.FromArgb(616161)

    End Sub
End Class