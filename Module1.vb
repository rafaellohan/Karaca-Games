Module Module1
    Public diretorio, sql, resp, aux_cpf, aux_cod As String
    Public cont As Integer
    Public rn As New Random
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public dirbanco = Application.StartupPath & "\bancodados\bd_karaca_games.mdb"
    Public moeda1 As String
    Public moeda2 As Double


    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & dirbanco)
        Catch ex As Exception
            MsgBox("Conexão FALHOU!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

        End Try
    End Sub

    Sub carregar_funcao()
        Try
            With cad_usuario.cmb_funcao.Items
                .Add("CAIXA")
                .Add("ALMOXARIFE")
                .Add("GERENTE")

            End With
        Catch ex As Exception

        End Try

        With frm_list.cmb_funcao.Items
            .Add("CAIXA")
            .Add("ALMOXARIFE")
            .Add("GERENTE")
        End With
    End Sub
    Sub carregar_jogo()
        Try
            With frm_cad_prod.cmb_console.Items
                .Add("PLAYSTATION 1")
                .Add("PLAYSTATION 2")
                .Add("PLAYSTATION 3")
                .Add("PLAYSTATION 4")
                .Add("PLAYSTATION 5")
                .Add("XBOX SERIES X-S")
                .Add("XBOX ONE")
                .Add("XBOX 360")
                .Add("XBOX")
                .Add("NINTENDO WII")
            End With
        Catch ex As Exception

        End Try
    End Sub
    Sub limpar()
        With cad_usuario
            .txt_senha.Clear()
            .txt_nome.Clear()
            .txt_email.Clear()
            .txt_cpf.Clear()
            .txt_confsenha.Clear()
            .txt_chave.Clear()


        End With
        With frm_cad_prod
            .txt_qnt.Clear()
            .txt_preco.Clear()
            .txt_nprod.Clear()
            .txt_cod.Clear()
            .cmb_console.Items.Clear()

        End With

    End Sub

    Sub carregar_dados()
        Try
            sql = "select * from tb_funcionarios order by nome_fun asc"
            rs = db.Execute(sql)
            cont = 1
            With frm_list.dgv_listagem
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
    Sub carregar_sacola()
        sql = "select * from tb_prevendas order by cod_venda asc"
        rs = db.Execute(sql)
        cont = 1
        With frm_emitir_compra.dgv_sacola
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value)
                rs.MoveNext()
                cont = cont + 1
            Loop
        End With

    End Sub

    Sub carregar_comprovante()
        sql = "select * from tb_prevendas order by cod_venda asc"
        rs = db.Execute(sql)

        With frm_emitir_nota.dgv_teste
            .Rows.Clear()
            Do While rs.EOF = False

                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value)
                rs.MoveNext()
            Loop
        End With

    End Sub

    Sub relat_vendas()

        sql = "select * from tb_vendas order by cod_venda asc"
        rs = db.Execute(sql)
        With frm_relat_vendas.dgv_relat
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value)
                rs.MoveNext()

            Loop
        End With
    End Sub

    Sub tabela()
        sql = "select * from tb_jogos order by cod_produto asc"
        rs = db.Execute(sql)
        With frm_tabela_jogos.dgv_tabela
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(4).Value)
                rs.MoveNext()
            Loop

        End With
    End Sub

    Sub limpar_login()
        Novologin.txt_senha.Clear()
        Novologin.txt_chave.Clear()
    End Sub
End Module

