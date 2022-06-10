Public Class frm_funcionarios
    Private Sub frm_funcionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        carregar_dados_func()
        carregar_cargo()
        carregar_status_conta()
        carregar_tipo_conta()
        cmb_cargo.Text = ""
        cmb_status_conta.Text = ""
        cmb_tipo_conta.Text = ""
    End Sub

    Private Sub btn_ver_senha_Click(sender As Object, e As EventArgs) Handles btn_ver_senha.Click
        If txt_senha.PasswordChar = "*" Then
            txt_senha.PasswordChar = ""
        Else
            txt_senha.PasswordChar = "*"
        End If
    End Sub

    Private Sub btn_ver_confirmar_senha_Click(sender As Object, e As EventArgs) Handles btn_ver_confirmar_senha.Click
        If txt_confirmar_senha.PasswordChar = "*" Then
            txt_confirmar_senha.PasswordChar = ""
        Else
            txt_confirmar_senha.PasswordChar = "*"
        End If
    End Sub

    Private Sub dgv_fun_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_fun.CellContentClick
        Try
            With dgv_fun
                If .CurrentRow.Cells(6).Selected Then
                    aux = .CurrentRow.Cells(1).Value
                    sql = "select * from tb_funcionario where email_func='" & aux & "'"
                    rs = db.Execute(sql)

                    If rs.EOF = False Then
                        TabControl1.SelectTab(0)
                        txt_email.Text = rs.Fields(0).Value
                        txt_nome.Text = rs.Fields(2).Value
                        cmb_cargo.Text = rs.Fields(3).Value
                        cmb_tipo_conta.Text = rs.Fields(4).Value
                        cmb_status_conta.Text = rs.Fields(5).Value
                    End If
                ElseIf .CurrentRow.Cells(7).Selected Then
                    aux = .CurrentRow.Cells(1).Value
                    resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                            "Conta: " & aux & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = "delete * from tb_funcionario where email_func='" & aux & "'"
                        rs = db.Execute(sql)
                        carregar_dados_func()
                    End If
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class

