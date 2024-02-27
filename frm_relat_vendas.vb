Public Class frm_relat_vendas
    Private Sub frm_relat_vendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectar_banco()
        Call relat_vendas()

    End Sub
    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        Try
            sql = "select * from tb_vendas where cpf_cliente like '" & txt_busca.Text & "%'"
            rs = db.Execute(sql)

            With dgv_relat
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value)
                    rs.MoveNext()

                Loop
            End With
        Catch ex As Exception
            MsgBox("ERRO DE PROCESSAMENTO!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")

        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frm_gerente.Show()
        Me.Hide()
    End Sub
End Class