Public Class Novologin

    Private Sub Novologin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectar_banco()

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_login.Click



        sql = "select * from tb_funcionarios where(chave_fun='" & txt_chave.Text & "' and senha_fun='" & txt_senha.Text & "')and status_fun = 'ATIVO'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            MsgBox("LOGIN OK!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End If
        sql = "select * from tb_funcionarios where(chave_fun='" & txt_chave.Text & "' and senha_fun='" & txt_senha.Text & "')and status_fun = 'BLOQUEADO'"
        rs = db.Execute(sql)
        If rs.EOF = False Then

            MsgBox("Conta bloqueada. Contate o gerente!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End If

        sql = "select * from tb_funcionarios where chave_fun='" & txt_chave.Text & "' and senha_fun='" & txt_senha.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = True Then
            MsgBox("Conta inválida", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End If

        sql = "select * from tb_funcionarios where(chave_fun='" & txt_chave.Text & "' and senha_fun='" & txt_senha.Text & "')and funcao_fun = 'ALMOXARIFE' and status_fun= 'ATIVO'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            frm_almoxarife.Show()
            Me.Hide()
        End If
        sql = "select * from tb_funcionarios where(chave_fun='" & txt_chave.Text & "' and senha_fun='" & txt_senha.Text & "')and funcao_fun = 'CAIXA' and status_fun= 'ATIVO'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            frm_caixa.Show()
            Me.Hide()
        End If
        sql = "select * from tb_funcionarios where(chave_fun='" & txt_chave.Text & "' and senha_fun='" & txt_senha.Text & "')and funcao_fun = 'GERENTE' and status_fun= 'ATIVO'"
        rs = db.Execute(sql)
        If rs.EOF = False Then

            frm_gerente.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles btn_login.MouseHover
        btn_login.BackColor = Color.Gray
    End Sub

    Private Sub btn_login_MouseLeave(sender As Object, e As EventArgs) Handles btn_login.MouseLeave
        btn_login.BackColor = Color.Gray
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()

    End Sub

    Private Sub Label4_MouseHover(sender As Object, e As EventArgs) Handles Label4.MouseHover
        Label4.BackColor = Color.Red

    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        Label4.BackColor = Color.FromArgb(322930)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class