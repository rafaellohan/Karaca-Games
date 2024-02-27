Public Class frm_list
    Private Sub frm_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectar_banco()
        Call carregar_dados()
        Call carregar_funcao()


    End Sub
    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        Try
            sql = "select * from tb_funcionarios where cpf_fun like '" & txt_busca.Text & "%'"
            rs = db.Execute(sql)
            cont = 1
            With dgv_listagem
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(4).Value, rs.Fields(7).Value)
                    rs.MoveNext()
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("ERRO DE PROCESSAMENTO!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")

        End Try
    End Sub


    Private Sub dgv_listagem_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_listagem.CellContentClick
        Try
            With dgv_listagem
                If .CurrentRow.Cells(6).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(3).Value
                    sql = "select * from tb_funcionarios where cpf_fun ='" & aux_cpf & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        TabControl1.SelectTab(0)
                        txt_chave.Text = rs.Fields(0).Value
                        txt_nome.Text = rs.Fields(1).Value
                        txt_cpf.Text = rs.Fields(2).Value
                        txt_email.Text = rs.Fields(3).Value
                        cmb_funcao.Text = rs.Fields(4).Value
                        img_foto.Load(rs.Fields(6).Value)

                    End If
                ElseIf .CurrentRow.Cells(7).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(3).Value
                    resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                                "O CPF: " & aux_cpf & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = "delete * from tb_funcionarios where cpf_fun='" & aux_cpf & "'"
                        rs = db.Execute(sql)
                        carregar_dados()

                    End If
                End If
                If .CurrentRow.Cells(8).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(3).Value
                    sql = "update tb_funcionarios set status_fun= 'BLOQUEADO' "
                    rs = db.Execute(sql)
                    carregar_dados()
                    MsgBox("BLOQUEADO", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)

                End If
                If .CurrentRow.Cells(9).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(3).Value
                    sql = "update tb_funcionarios set status_fun= 'ATIVO' "
                    rs = db.Execute(sql)
                    carregar_dados()
                    MsgBox("ATIVO", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                End If



            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub img_foto_Click(sender As Object, e As EventArgs)
        Try
            With OpenFileDialog1
                .InitialDirectory = Application.StartupPath & "\fotos"
                .Title = "SELECIONE UMA FOTO"
                .ShowDialog()
                diretorio = .FileName
                img_foto.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btn_att_Click_1(sender As Object, e As EventArgs) Handles btn_att.Click
        Try
            sql = "select * from tb_funcionarios where cpf_fun='" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                sql = "update tb_funcionarios set nome_fun='" & txt_nome.Text & "', " &
                    "email_fun='" & txt_email.Text & "', funcao_fun='" & cmb_funcao.Text & "'," &
                    "chave_fun = '" & txt_chave.Text & "' where cpf_fun='" & txt_cpf.Text & "'"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                carregar_dados()
                limpar()


            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmb_funcao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_funcao.SelectedIndexChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frm_gerente.Show()
        Me.Hide()
    End Sub
End Class