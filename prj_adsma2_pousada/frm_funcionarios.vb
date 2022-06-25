Public Class frm_funcionarios
    Private Sub frm_funcionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        carregar_acompanhante()
        carregar_cargo()
        carregar_catergoria_pesquisa()
        carregar_cliente()
        carregar_dados_func()
        carregar_forma_pagamanto()
        carregar_pacote_serv()
        carregar_pac_serv_reserva()
        carregar_parcela()
        carregar_quartos()
        carregar_quartos_reserva()
        carregar_reserva()
        carregar_status_conta()
        carregar_tipo_conta()
        carregar_tipo_pacote()
        carregar_tipo_quarto()
        carregar_catergoria_pesquisa_func()
        cmb_cargo.Text = ""
        cmb_status_conta.Text = ""
        cmb_tipo_conta.Text = ""
    End Sub

    Private Sub dgv_fun_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_fun.CellContentClick
        Try
            With dgv_fun
                If .CurrentRow.Cells(7).Selected Then
                    aux = .CurrentRow.Cells(0).Value
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
                ElseIf .CurrentRow.Cells(8).Selected Then
                    aux = .CurrentRow.Cells(0).Value

                    If email_func_g = "root@fshm.com" Then
                        If aux <> "root@fshm.com" Then
                            resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                                "Conta: " & aux & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                            If resp = MsgBoxResult.Yes Then

                                sql = "delete * from tb_funcionario where email_func='" & aux & "'"
                                rs = db.Execute(sql)
                                carregar_dados_func()
                                limpar_func()
                            End If
                        Else
                            MsgBox("Não é possível excluir essa conta por motivos de segurança!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                        End If
                    Else
                        If .CurrentRow.Cells(3).Value <> "admin" Then
                            resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                               "Conta: " & aux & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                            If resp = MsgBoxResult.Yes Then

                                sql = "delete * from tb_funcionario where email_func='" & aux & "'"
                                rs = db.Execute(sql)
                                carregar_dados_func()
                                limpar_func()
                            End If
                        Else
                            MsgBox("Apenas Root pode deletar conta admin!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                        End If
                    End If
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Dim datahoraAtual As DateTime = Now
        Try
            If txt_email.Text = "" Or txt_nome.Text = "" Or txt_senha.Text = "" Or txt_confirmar_senha.Text = "" Or
           cmb_cargo.Text = "" Or cmb_status_conta.Text = "" Or cmb_tipo_conta.Text = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            ElseIf txt_senha.Text <> txt_confirmar_senha.Text Then
                MsgBox("Senhas diferentes!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else
                sql = "select * from tb_funcionario where email_func='" & txt_email.Text & "'"
                rs = db.Execute(sql)

                If rs.EOF = False Then
                    If email_func_g = "root@fshm.com" Then
                        resp = MsgBox("Deseja atualizar os dados do funcionário?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                        If resp = vbYes Then
                            Dim estado As String

                            If txt_email.Text = "root@fshm.com" Then
                                estado = "Ativa"
                            Else
                                estado = cmb_status_conta.Text
                            End If

                            sql = "update tb_funcionario set senha_func='" & txt_senha.Text & "', nome_func='" & txt_nome.Text & "', cargo_func=" &
                                   "'" & cmb_cargo.Text & "', tipo_conta_func='" & cmb_tipo_conta.Text & "', status_conta_func='" & estado & "', " &
                                   "data_hora_alteracao_conta='" & datahoraAtual & "' where email_func ='" & txt_email.Text & "'"
                            rs = db.Execute(sql)
                            MsgBox("Dados atualizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                            carregar_dados_func()
                            limpar_func()
                        End If

                    Else
                        sql = "select * from tb_funcionario where email_func='" & txt_email.Text & "'"
                        rs = db.Execute(sql)
                        aux = rs.Fields(4).Value


                        If aux = "user" And cmb_tipo_conta.Text = "user" Then
                            sql = "update tb_funcionario set senha_func='" & txt_senha.Text & "', nome_func='" & txt_nome.Text & "', cargo_func=" &
                    "'" & cmb_cargo.Text & "', tipo_conta_func='" & cmb_tipo_conta.Text & "', status_conta_func='" & cmb_status_conta.Text & "', " &
                    "data_hora_alteracao_conta='" & datahoraAtual & "' where email_func ='" & txt_email.Text & "'"
                            rs = db.Execute(sql)
                            MsgBox("Dados atualizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                            carregar_dados_func()
                            limpar_func()
                        Else
                            MsgBox("Apenas conta Root pode alterar Admin!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                        End If
                    End If

                Else

                    If email_func = "root@fshm.com" Then
                        sql = "insert into tb_funcionario values ('" & txt_email.Text & "', '" & txt_senha.Text & "', '" & txt_nome.Text & "', '" &
                        "" & cmb_cargo.Text & "', '" & cmb_tipo_conta.Text & "', '" & cmb_status_conta.Text & "', '" & datahoraAtual & "', '" & datahoraAtual & "')"
                        rs = db.Execute(sql)
                        MsgBox("Funcionário cadastrado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                        carregar_dados_func()
                        limpar_func()
                    ElseIf cmb_tipo_conta.Text <> "admin" And email_func <> "root@fshm.com" Then
                        sql = "insert into tb_funcionario values ('" & txt_email.Text & "', '" & txt_senha.Text & "', '" & txt_nome.Text & "', '" &
                        "" & cmb_cargo.Text & "', '" & cmb_tipo_conta.Text & "', '" & cmb_status_conta.Text & "', '" & datahoraAtual & "', '" & datahoraAtual & "')"
                        rs = db.Execute(sql)
                        MsgBox("Funcionário cadastrado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                        carregar_dados_func()
                        limpar_func()
                    Else
                        MsgBox("Apenas conta Root pode criar Admin!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    End If
                End If

            End If
        Catch ex As Exception
            MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ALERTA")
        End Try

    End Sub

    Private Sub txt_email_DoubleClick(sender As Object, e As EventArgs) Handles txt_email.DoubleClick
        Try
            limpar_func()
        Catch ex As Exception
            MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ALERTA")
        End Try
    End Sub



    Private Sub txt_senha_DoubleClick(sender As Object, e As EventArgs) Handles txt_senha.DoubleClick
        If txt_senha.PasswordChar = "*" Then
            txt_senha.PasswordChar = ""
        Else
            txt_senha.PasswordChar = "*"
        End If
    End Sub

    Private Sub txt_confirmar_senha_DoubleClick(sender As Object, e As EventArgs) Handles txt_confirmar_senha.DoubleClick
        If txt_confirmar_senha.PasswordChar = "*" Then
            txt_confirmar_senha.PasswordChar = ""
        Else
            txt_confirmar_senha.PasswordChar = "*"
        End If
    End Sub

    Private Sub CheckinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckinToolStripMenuItem.Click
        Me.Hide()
        frm_checkin.Visible = True
    End Sub

    Private Sub CheckoutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CheckoutToolStripMenuItem1.Click
        Me.Hide()
        frm_checkout.Visible = True
    End Sub

    Private Sub PacoteDeServiçosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PacoteDeServiçosToolStripMenuItem.Click
        Me.Hide()
        frm_pacote_servico.Visible = True
    End Sub

    Private Sub QuartosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuartosToolStripMenuItem.Click
        Me.Hide()
        frm_quartos.Visible = True
    End Sub

    Private Sub EncerrarSessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarSessToolStripMenuItem.Click
        Me.Hide()
        frm_login.Visible = True

    End Sub

    Private Sub frm_funcionarios_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        conectar_banco()
        carregar_acompanhante()
        carregar_cargo()
        carregar_catergoria_pesquisa()
        carregar_cliente()
        carregar_dados_func()
        carregar_forma_pagamanto()
        carregar_pacote_serv()
        carregar_pac_serv_reserva()
        carregar_parcela()
        carregar_quartos()
        carregar_quartos_reserva()
        carregar_reserva()
        carregar_status_conta()
        carregar_tipo_conta()
        carregar_tipo_pacote()
        carregar_tipo_quarto()
        carregar_catergoria_pesquisa_func()
        cmb_cargo.Text = ""
        cmb_status_conta.Text = ""
        cmb_tipo_conta.Text = ""
    End Sub

    Private Sub CheckoutToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        Me.Hide()
        frm_reserva.Visible = True
    End Sub

    Private Sub RegistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroToolStripMenuItem.Click
        Me.Hide()
        frm_registro.Visible = True
    End Sub

    Private Sub txt_pesquisa_TextChanged(sender As Object, e As EventArgs) Handles txt_pesquisa.TextChanged
        Try
            If cmb_categoria.Text <> "" Then
                If cmb_categoria.Text = "E-mail" Then
                    categ = "email_func"
                ElseIf cmb_categoria.Text = "Nome" Then
                    categ = "nome_func"
                ElseIf cmb_categoria.Text = "Cargo" Then
                    categ = "cargo_func"
                ElseIf cmb_categoria.Text = "Conta" Then
                    categ = "tipo_conta_func"
                ElseIf cmb_categoria.Text = "Status" Then
                    categ = "status_conta_func"
                End If

                sql = "select * from tb_funcionario where " & categ & " like '" & txt_pesquisa.Text & "%'" 'Busca pela letra inicial %
                rs = db.Execute(sql)

                With dgv_fun
                    .Rows.Clear()
                    Do While rs.EOF = False
                        .Rows.Add(rs.Fields(0).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value, Nothing, Nothing)
                        rs.MoveNext()
                    Loop
                End With
            End If
        Catch ex As Exception
            MsgBox("Erro ao carregar dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class

