Public Class frm_tabela_jogos
    Private Sub frm_tabela_jogos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectar_banco()
        Call tabela()
        txt_console.Enabled = False
        txt_qtda.Enabled = False
        txt_nprod.Enabled = False
        txt_cod.Enabled = False
    End Sub

    Private Sub dgv_tabela_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_tabela.CellContentClick
        With dgv_tabela
            If .CurrentRow.Cells(3).Selected = True Then
                aux_cod = .CurrentRow.Cells(0).Value
                sql = "select * from tb_jogos where cod_produto='" & aux_cod & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    TabControl1.SelectTab(1)
                    txt_cod.Text = rs.Fields(0).Value
                    txt_nprod.Text = rs.Fields(1).Value
                    txt_console.Text = rs.Fields(2).Value
                    txt_qtda.Text = rs.Fields(4).Value

                End If
            End If

        End With
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click

        If txt_qnt.Text = "" Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Exit Sub
        End If

        Try


            sql = "select * from tb_jogos where cod_produto= '" & txt_cod.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                sql = "update tb_jogos set qtd_produto='" & txt_qnt.Text & "' where cod_produto='" & txt_cod.Text & "'"
                rs = db.Execute(sql)
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar()
                TabControl1.SelectTab(0)


            End If
        Catch ex As Exception
            MsgBox("Erro ao Gravar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")

        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TabControl1.SelectTab(0)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        frm_almoxarife.Show()
        Me.Hide()

    End Sub
End Class