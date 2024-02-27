Public Class frm_emitir_compra
    Private Sub frm_emitir_compra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

        Call conectar_banco()
        Call carregar_sacola()

    End Sub
    Public Shared Sub moeda(ByRef txt As TextBox)

        moeda1 = String.Empty
        moeda2 = 0
        Try
            moeda1 = txt.Text.Replace(",", "").Replace(".", "")
            If moeda1.Equals("") Then moeda1 = ""
            moeda1 = moeda1.PadLeft(3, "0")
            If moeda1.Length > 3 And moeda1.Substring(0, 1) = "0" Then moeda1 = moeda1.Substring(1, moeda1.Length - 1)
            moeda2 = Convert.ToDouble(moeda1) / 100
            txt.Text = String.Format("{0:N}", moeda2)
            txt.SelectionStart = txt.Text.Length
        Catch ex As Exception
            MsgBox("ERRO AO REALIZAR A MASCARA DO VALOR !!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÂO")
        End Try
    End Sub

    Private Sub lbl_preco_TextChanged(sender As Object, e As EventArgs)
        frm_emitir_compra.moeda(txt_preco)


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.ToString()
        TextBox2.Text = TimeOfDay

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Call carregar_sacola()
    End Sub

    Private Sub btn_emitir_venda_Click_1(sender As Object, e As EventArgs) Handles btn_emitir_venda.Click
        If txt_cod.Text = "" Or txt_quantidade.Text = "" Then
            MsgBox("Favor preencher todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
        Else
            sql = "select * from tb_prevendas"
            rs = db.Execute(sql)
            sql = "insert into tb_prevendas values('" & txt_cod.Text & "', '" & txt_nprod.Text & "', '" & txt_console.Text & "', '" & txt_preco.Text & "', '" & txt_quantidade.Text & "')"
            rs = db.Execute(sql)
            MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

            Dim sum As Integer = 0
            For i As Integer = 0 To dgv_sacola.Rows.Count() - 1 Step +1
                sum = sum + (dgv_sacola.Rows(i).Cells(4).Value * dgv_sacola.Rows(i).Cells(5).Value)
            Next
            txt_total.Text = sum.ToString("C")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frm_caixa.Show()
        Me.Hide()
    End Sub

    Private Sub btn_prosseguir_Click(sender As Object, e As EventArgs) Handles btn_prosseguir.Click
        frm_emitir_nota.Show()
        Me.Hide()

    End Sub

    Private Sub txt_cod_TextChanged_1(sender As Object, e As EventArgs) Handles txt_cod.TextChanged
        sql = "select * from tb_jogos where cod_produto= '" & txt_cod.Text & "'"
        rs = db.Execute(sql)

        If rs.EOF = False Then
            txt_nprod.Text = rs.Fields(1).Value
            txt_console.Text = rs.Fields(2).Value
            txt_preco.Text = rs.Fields(3).Value
        Else

        End If
    End Sub
End Class