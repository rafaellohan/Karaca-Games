Public Class frm_caixa
    Private Sub btn_cad_produto_Click(sender As Object, e As EventArgs) Handles btn_cad_produto.Click
        frm_emitir_compra.Show()
        Me.Hide()
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        Call limpar_login()
        Novologin.Show()
        Me.Hide()

    End Sub
End Class