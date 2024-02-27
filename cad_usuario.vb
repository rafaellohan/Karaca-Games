Public Class cad_usuario

	Private Sub cad_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Call carregar_funcao()
		Call conectar_banco()
		txt_chave.Enabled = False


	End Sub



	Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
		Try
			With OpenFileDialog1
				.InitialDirectory = Application.StartupPath
				.Title = "SELECIONE UMA FOTO"
				.ShowDialog()
				diretorio = .FileName
				img_foto.Load(diretorio)
			End With
		Catch ex As Exception
			Exit Sub
		End Try
	End Sub


	Private Sub btn_cadastrar_Click_1(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
		If txt_nome.Text = "" Or
				txt_cpf.Text = "" Or
				txt_email.Text = "" Or
				cmb_funcao.Text = "" Or
				txt_senha.Text = "" Or
				txt_chave.Text = "" Then
			MsgBox("Preencha todos os campos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
			Exit Sub
		ElseIf txt_senha.Text <> txt_confsenha.Text Then
			MsgBox("Senhas não conferem!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
			Exit Sub
		End If

		Try
			sql = "select * from tb_funcionarios where cpf_fun='" & txt_cpf.Text & "'"
			rs = db.Execute(sql)
			If rs.EOF = True Then
				sql = "insert into tb_funcionarios values ('" & txt_chave.Text & "', " &
					"'" & txt_nome.Text & "', '" & txt_cpf.Text & "', '" & txt_email.Text & "', " &
					"'" & cmb_funcao.Text & "', '" & txt_senha.Text & "', '" & diretorio & "', 'ATIVO')"
				rs = db.Execute(UCase(sql))
				MsgBox("Funcionário cadastrado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
				limpar()

			Else
				MsgBox("Funcionário já está cadastrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

			End If
		Catch ex As Exception
			MsgBox("ERRO!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
			limpar()

		End Try

	End Sub

	Private Sub btn_gerar_Click(sender As Object, e As EventArgs) Handles btn_gerar.Click
		Randomize()
		Dim value As Integer = CInt(Int((100000 * Rnd()) + 1))
		txt_chave.Text = value

	End Sub

	Private Sub cmb_funcao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_funcao.SelectedIndexChanged

	End Sub

	Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
		frm_gerente.Show()
		Me.Hide()

	End Sub
End Class