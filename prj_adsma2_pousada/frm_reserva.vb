Public Class frm_reserva


    Private Sub frm_reversa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
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
            carregar_num_reserva()

            txt_data_entrada.CustomFormat = "dd/MM/yyyy"
            txt_data_saida.CustomFormat = "dd/MM/yyyy"
            txt_hora_entrada.CustomFormat = "HH:mm"
            txt_hora_saida.CustomFormat = "HH:mm"

            txt_data_entrada.Value = "20/01/2022"
            txt_data_saida.Value = "20/06/2022"

            If type_login = "admin" Then
                FuncionáriosToolStripMenuItem.Visible = True
            Else
                FuncionáriosToolStripMenuItem.Visible = False
            End If
        Catch ex As Exception
            MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")

        End Try

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

    Private Sub FuncionáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuncionáriosToolStripMenuItem.Click
        Me.Hide()
        frm_funcionarios.Visible = True

    End Sub

    Private Sub EncerrarSessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarSessToolStripMenuItem.Click
        Me.Hide()
        frm_login.Visible = True
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_reserva.CellContentClick
        'Try
        With dgv_reserva
                'Editar
                If dgv_reserva.Rows.Count <> 0 Then
                If .CurrentRow.Cells(7).Selected Then
                    limpar_reserva()
                    aux = .CurrentRow.Cells(0).Value
                    TabControl1.SelectTab(0)
                    sql = "SELECT * FROM tb_reserva WHERE num_reserva=" & aux & ""
                    rs = db.Execute(sql)

                    If rs.EOF = False Then
                        txt_cpf_cli.Text = rs.Fields(11).Value
                        txt_num_reserva.Text = rs.Fields(0).Value

                        sql = "SELECT * FROM tb_reserva WHERE num_reserva=" & txt_num_reserva.Text & ""
                        rs = db.Execute(sql)

                        If rs.EOF = False Then
                            txt_data_entrada.Text = rs.Fields(1).Value
                            txt_hora_entrada.Text = rs.Fields(2).Value
                            txt_data_saida.Text = rs.Fields(3).Value
                            txt_hora_saida.Text = rs.Fields(4).Value

                            sql = "SELECT * FROM tb_reserva WHERE num_reserva=" & txt_num_reserva.Text & ""
                            rs = db.Execute(sql)

                            If rs.EOF = False Then

                                cmb_quarto.Text = rs.Fields(9).Value

                                sql = "SELECT * FROM tb_reserva WHERE num_reserva=" & txt_num_reserva.Text & ""
                                rs = db.Execute(sql)

                                If rs.EOF = False Then
                                    cmb_forma_pagamento.Text = rs.Fields(6).Value
                                    cmb_parcela.Text = rs.Fields(7).Value

                                    sql = "SELECT * FROM tb_reserva WHERE num_reserva=" & txt_num_reserva.Text & ""
                                    rs = db.Execute(sql)

                                    If rs.EOF = False Then
                                        txt_total.Text = rs.Fields(5).Value

                                        If rs.Fields(8).Value <> 0 Then
                                            sql = "SELECT * FROM tb_pacote_servico WHERE cod_pac_serv=" & rs.Fields(8).Value & ""
                                            rs = db.Execute(sql)

                                            If rs.EOF = False Then
                                                cmb_pacote_serv.Text = rs.Fields(0).Value & " - " & rs.Fields(1).Value & ""
                                            End If

                                        End If


                                    End If
                                End If


                            End If
                            End If
                    End If





                ElseIf .CurrentRow.Cells(8).Selected Then
                    aux = .CurrentRow.Cells(0).Value
                        resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                        "Reserva: " & aux & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                        If resp = MsgBoxResult.Yes Then
                            sql = "delete * from tb_reserva where num_reserva=" & aux & ""
                            rs = db.Execute(sql)

                            sql = "delete * from tb_checkin where num_reserva=" & aux & ""
                            rs = db.Execute(sql)

                            sql = "delete * from tb_checkout where num_reserva=" & aux & ""
                            rs = db.Execute(sql)

                            sql = "delete * from tb_acompanhante where (cpf_cliente='" & .CurrentRow.Cells(3).Value & "' and num_reserva=" & aux & ")"
                        rs = db.Execute(sql)
                    End If
                    End If

                    Calcula_total()
                    Calcula_parcela()
                    carregar_cliente()
                    carregar_acompanhante()
                    carregar_reserva()
                End If
            End With
            'Catch ex As Exception
        'MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        'End Try
    End Sub

    Private Sub frm_reserva_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Try
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
            carregar_num_reserva()


            txt_data_entrada.CustomFormat = "dd/MM/yyyy"
            txt_data_saida.CustomFormat = "dd/MM/yyyy"
            txt_hora_entrada.CustomFormat = "HH:mm"
            txt_hora_saida.CustomFormat = "HH:mm"

            txt_data_entrada.Value = "20/01/2022"
            txt_data_saida.Value = "20/06/2022"


            If type_login = "admin" Then
                FuncionáriosToolStripMenuItem.Visible = True
            Else
                FuncionáriosToolStripMenuItem.Visible = False
            End If

        Catch ex As Exception
            MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")

        End Try


    End Sub

    Private Sub cmb_pacote_serv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_pacote_serv.SelectedIndexChanged
        Dim pac_serv As String
        Dim pos As Integer

        If cmb_pacote_serv.Text <> "" Then

            pac_serv = cmb_pacote_serv.Text
            pos = pac_serv.IndexOf("-")
            pac_serv = pac_serv.Remove(pos)
            pac_serv = pac_serv.Trim()

            sql = "select * from tb_pacote_servico where cod_pac_serv=" & pac_serv & ""
            rs = db.Execute(sql)




            If rs.EOF = False Then
                txt_preco_pac_serv.Text = FormatCurrency(rs.Fields(5).Value)
            End If
        Else
            txt_preco_pac_serv.Text = FormatCurrency(0)

        End If

        Calcula_total()
        Calcula_parcela()
    End Sub

    Private Sub cmb_quarto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_quarto.SelectedIndexChanged
        If cmb_quarto.Text <> "" Then
            sql = "select * from tb_quartos where num_quarto=" & cmb_quarto.Text & ""
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_preco_quarto.Text = FormatCurrency(rs.Fields(4).Value)
            End If
        Else
            txt_preco_quarto.Text = FormatCurrency(0)
        End If
        Calcula_total()
        Calcula_parcela()
    End Sub

    Private Sub cmb_forma_pagamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_forma_pagamento.SelectedIndexChanged
        If cmb_forma_pagamento.Text = "Cartão de Crédito" Then
            cmb_parcela.Enabled = True
            cmb_parcela.SelectedIndex = 0
        Else
            cmb_parcela.Text = ""
            txt_valor_parcela.Text = ""
            cmb_parcela.Enabled = False

        End If
    End Sub

    Private Sub cmb_parcela_TextChanged(sender As Object, e As EventArgs) Handles cmb_parcela.TextChanged
        Calcula_total()
        Calcula_parcela()

    End Sub

    Private Sub cmb_cpf_acomp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_cpf_acomp.SelectedIndexChanged
        If cmb_cpf_acomp.Text <> "" Then
            sql = "select * from tb_acompanhante where (cpf_acomp='" & cmb_cpf_acomp.Text & "' and num_reserva=" & txt_num_reserva.Text & ")"
            rs = db.Execute(sql)

            If rs.EOF = False Then
                txt_cpf_acomp_cadastrado.Text = rs.Fields(1).Value
            End If
        End If
    End Sub

    Private Sub btn_remover_Click(sender As Object, e As EventArgs) Handles btn_remover.Click
        If txt_cpf_acomp_cadastrado.Text <> "" Then
            sql = "delete * from tb_acompanhante where (cpf_acomp='" & cmb_cpf_acomp.Text & "' and num_reserva=" & txt_num_reserva.Text & ")"
            rs = db.Execute(sql)
            carregar_acompanhante()
        End If
    End Sub

    Private Sub btn_inserir_Click(sender As Object, e As EventArgs) Handles btn_inserir.Click
        If txt_cpf_acomp.Text <> "" And txt_nome_acomp.Text <> "" And txt_cpf_cli.Text <> "" Then
            sql = "select * from tb_acompanhante where (cpf_acomp='" & txt_cpf_acomp.Text & "' and num_reserva=" & txt_num_reserva.Text & ")"
            rs = db.Execute(sql)

            If rs.EOF = False Then
                MsgBox("Já existe um Acompanhante com esse CPF: " & txt_cpf_acomp.Text & "!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else
                sql = "insert into tb_acompanhante (cpf_acomp, nome_acomp, cpf_cliente, num_reserva)" &
                    " values ('" & txt_cpf_acomp.Text & "', '" & txt_nome_acomp.Text & "', '" & txt_cpf_cli.Text & "', " & txt_num_reserva.Text & ")"
                rs = db.Execute(sql)
                txt_cpf_acomp.Clear()
                txt_nome_acomp.Clear()
                carregar_acompanhante()
            End If
        End If
    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Dim num, pac_serv, res1, res2 As String
        Dim pos As Integer
        'Try
        Calcula_total()
            Calcula_parcela()
            If txt_cpf_cli.Text = "" Or txt_nome_cli.Text = "" Or txt_celular_cli.Text = "" Or txt_total.Text = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else
                sql = "select * from tb_reserva where (data_entrada between #" & txt_data_entrada.Text & "# and #" & txt_data_saida.Text & "# " &
                    " and num_quarto =" & cmb_quarto.Text & ") and num_reserva <> " & cmb_quarto.Text & " ORDER BY data_entrada"
                rs = db.Execute(sql)

                If rs.EOF = False Then
                    res1 = rs.Fields(0).Value
                Else
                    res1 = txt_num_reserva.Text
                End If



                If rs.EOF = False And res1 <> txt_num_reserva.Text Then
                    MsgBox("Já existe uma reserva nestas datas com esse quarto!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Else
                    aux = "select * from tb_reserva where (data_saida between #" & txt_data_entrada.Text & "# and #" & txt_data_saida.Text & "# " &
                   " and num_quarto =" & cmb_quarto.Text & " ) and num_reserva <> " & txt_num_reserva.Text & " ORDER BY data_saida"
                    rs2 = db.Execute(aux)

                    If rs2.EOF = False Then
                        res2 = rs2.Fields(0).Value
                    Else
                        res2 = txt_num_reserva.Text
                    End If

                    If rs2.EOF = False And res2 <> txt_num_reserva.Text Then
                        MsgBox("Já existe uma reserva nestas datas com esse quarto!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    Else
                        If cmb_pacote_serv.Text <> "" Then
                            sql = "Select * from tb_reserva where num_reserva=" & txt_num_reserva.Text & ""
                            rs = db.Execute(sql)

                            pac_serv = cmb_pacote_serv.Text
                            pos = pac_serv.IndexOf("-")
                            pac_serv = pac_serv.Remove(pos)
                            pac_serv = pac_serv.Trim()

                            If rs.EOF = False Then
                                resp = MsgBox("Deseja atualizar As informações da reserva com Nº" & txt_num_reserva.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ALERTA")
                                If resp = vbYes Then
                                    num = txt_total.Text.Replace("R$ ", "")
                                    num = num.Replace(".", "")
                                    num = num.Replace(",", ".")
                                    sql = "update tb_reserva set data_entrada='" & txt_data_entrada.Text & "', hora_entrada='" & txt_hora_entrada.Text & "', data_saida='" & txt_data_saida.Text & "', " &
                                    "hora_saida='" & txt_hora_saida.Text & "', preco_reserva=" & num & ", forma_pagamento_reserva='" & cmb_forma_pagamento.Text & "', " &
                                    "parcelas='" & cmb_parcela.Text & "', cod_pac_serv=" & pac_serv & ", num_quarto=" & cmb_quarto.Text & ", email_func='" & email_func & "', " &
                                    "cpf_cliente='" & txt_cpf_cli.Text & "' where num_reserva=" & txt_num_reserva.Text & ""
                                    rs = db.Execute(sql)

                                    sql = "update tb_cliente set nome_cliente='" & txt_nome_cli.Text & "', celular_cliente='" & txt_celular_cli.Text & "' where cpf_cliente='" & txt_cpf_cli.Text & "'"
                                    rs = db.Execute(sql)
                                    limpar_reserva()
                                    carregar_reserva()
                                    carregar_num_reserva()
                                    MsgBox("Reserva atualizada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                                End If
                            Else
                                num = txt_total.Text.Replace("R$ ", "")
                                num = num.Replace(".", "")
                                num = num.Replace(",", ".")
                                sql = "insert into tb_reserva (num_reserva, data_entrada, hora_entrada, data_saida, hora_saida, preco_reserva, forma_pagamento_reserva, parcelas, cod_pac_serv, num_quarto, email_func, cpf_cliente)" &
                                    " values (" & txt_num_reserva.Text & ", '" & txt_data_entrada.Text & "', '" & txt_hora_entrada.Text & "', '" & txt_data_saida.Text & "', '" & txt_hora_saida.Text & "', " & num &
                                    ", '" & cmb_forma_pagamento.Text & "', '" & cmb_parcela.Text & "', " & pac_serv & ", " & cmb_quarto.Text & ", '" & email_func & "', '" & txt_cpf_cli.Text & "')"
                                rs = db.Execute(sql)

                                sql = "select * from tb_cliente where cpf_cliente='" & txt_cpf_cli.Text & "'"
                                rs = db.Execute(sql)

                                If rs.EOF = True Then
                                    sql = "insert into tb_cliente values ('" & txt_cpf_cli.Text & "', '" & txt_nome_cli.Text & "', '" & txt_celular_cli.Text & "')"
                                    rs = db.Execute(sql)
                                    carregar_reserva()
                                    limpar_reserva()
                                    carregar_num_reserva()
                                    MsgBox("Reserva cadastrada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                                Else
                                    sql = "update tb_cliente set nome_cliente='" & txt_nome_cli.Text & "', celular_cliente='" & txt_celular_cli.Text & "' where cpf_cliente='" & txt_cpf_cli.Text & "'"
                                    rs = db.Execute(sql)
                                    carregar_reserva()
                                    limpar_reserva()
                                    carregar_num_reserva()
                                    MsgBox("Reserva cadastrada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                                End If
                            End If
                        Else
                            sql = "Select * from tb_reserva where num_reserva=" & txt_num_reserva.Text & ""
                            rs = db.Execute(sql)
                            If rs.EOF = False Then
                                resp = MsgBox("Deseja atualizar As informações da reserva com Nº" & txt_num_reserva.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ALERTA")
                                If resp = vbYes Then
                                    num = txt_total.Text.Replace("R$ ", "")
                                    num = num.Replace(".", "")
                                    num = num.Replace(",", ".")
                                    sql = "update tb_reserva set data_entrada='" & txt_data_entrada.Text & "', hora_entrada='" & txt_hora_entrada.Text & "', data_saida='" & txt_data_saida.Text & "', " &
                            "hora_saida='" & txt_hora_saida.Text & "', preco_reserva=" & num & ", forma_pagamento_reserva='" & cmb_forma_pagamento.Text & "', " &
                            "parcelas='" & cmb_parcela.Text & "', cod_pac_serv=0, num_quarto=" & cmb_quarto.Text & ", email_func='" & email_func & "', " &
                            "cpf_cliente='" & txt_cpf_cli.Text & "' where num_reserva=" & txt_num_reserva.Text & ""
                                    rs = db.Execute(sql)

                                    sql = "update tb_cliente set nome_cliente='" & txt_nome_cli.Text & "', celular_cliente='" & txt_celular_cli.Text & "' where cpf_cliente='" & txt_cpf_cli.Text & "'"
                                    rs = db.Execute(sql)
                                    limpar_reserva()
                                    carregar_reserva()
                                    carregar_num_reserva()
                                    MsgBox("Reserva atualizada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                                End If
                            Else
                                num = txt_total.Text.Replace("R$ ", "")
                                num = num.Replace(".", "")
                                num = num.Replace(",", ".")
                                sql = "insert into tb_reserva (num_reserva, data_entrada, hora_entrada, data_saida, hora_saida, preco_reserva, forma_pagamento_reserva, parcelas, cod_pac_serv, num_quarto, email_func, cpf_cliente)" &
                            " values (" & txt_num_reserva.Text & ", '" & txt_data_entrada.Text & "', '" & txt_hora_entrada.Text & "', '" & txt_data_saida.Text & "', '" & txt_hora_saida.Text & "', " & num &
                            ", '" & cmb_forma_pagamento.Text & "', '" & cmb_parcela.Text & "', 0, " & cmb_quarto.Text & ", '" & email_func & "', '" & txt_cpf_cli.Text & "')"
                                rs = db.Execute(sql)

                                sql = "select * from tb_cliente where cpf_cliente='" & txt_cpf_cli.Text & "'"
                                rs = db.Execute(sql)

                                If rs.EOF = True Then
                                    sql = "insert into tb_cliente values ('" & txt_cpf_cli.Text & "', '" & txt_nome_cli.Text & "', '" & txt_celular_cli.Text & "')"
                                    rs = db.Execute(sql)
                                    carregar_reserva()
                                    limpar_reserva()
                                    carregar_num_reserva()
                                    MsgBox("Reserva cadastrada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                                Else
                                    sql = "update tb_cliente set nome_cliente='" & txt_nome_cli.Text & "', celular_cliente='" & txt_celular_cli.Text & "' where cpf_cliente='" & txt_cpf_cli.Text & "'"
                                    rs = db.Execute(sql)
                                    carregar_reserva()
                                    limpar_reserva()
                                    carregar_num_reserva()
                                    MsgBox("Reserva cadastrada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                                End If




                            End If



                        End If


                    End If
                End If
            End If

        ' Catch ex As Exception
        'MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        'End Try

    End Sub

    Private Sub txt_cpf_cli_DoubleClick(sender As Object, e As EventArgs) Handles txt_cpf_cli.DoubleClick
        limpar_reserva()
        carregar_num_reserva()
    End Sub

    Private Sub txt_pesquisa_TextChanged(sender As Object, e As EventArgs) Handles txt_pesquisa.TextChanged
        Try
            Dim datainicial, dataFinal As String
            If cmb_categoria.Text <> "" Then
                If cmb_categoria.Text = "Número da Reserva" Then
                    categ = "num_reserva"
                ElseIf cmb_categoria.Text = "CPF do Cliente" Then
                    categ = "cpf_cliente"
                ElseIf cmb_categoria.Text = "Código do Pacote de Serviço" Then
                    categ = "cod_pac_serv"
                ElseIf cmb_categoria.Text = "Número do Quarto" Then
                    categ = "num_quarto"
                ElseIf cmb_categoria.Text = "E-mail do Funcionário" Then
                    categ = "email_func"
                End If

                sql = "select * from tb_reserva where " & categ & " like '" & txt_pesquisa.Text & "%'" 'Busca pela letra inicial %
                rs = db.Execute(sql)

                If rs.EOF = False Then
                    aux = "select * from tb_checkin where num_reserva=" & rs.Fields(0).Value & ""
                    rs_aux = db.Execute(aux)

                    If rs_aux.EOF = True Then
                        With dgv_reserva
                            .Rows.Clear()
                            Do While rs.EOF = False
                                dataInicial = rs.Fields(1).Value
                                dataFinal = rs.Fields(3).Value

                                dataInicial = dataInicial.Replace("00:00:00", "")
                                dataFinal = dataFinal.Replace("00:00:00", "")
                                dataFinal.Trim()
                                dataInicial.Trim()

                                If rs.Fields(8).Value <> 0 Then
                                    .Rows.Add(rs.Fields(0).Value, rs.Fields(9).Value, rs.Fields(8).Value, rs.Fields(11).Value, datainicial, dataFinal, rs.Fields(10).Value, Nothing, Nothing)
                                Else
                                    .Rows.Add(rs.Fields(0).Value, rs.Fields(9).Value, Nothing, rs.Fields(11).Value, datainicial, dataFinal, rs.Fields(10).Value, Nothing, Nothing)
                                End If
                                rs.MoveNext()
                            Loop
                        End With
                    End If
                End If


            End If
        Catch ex As Exception
            MsgBox("Erro ao carregar dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txt_cpf_cli_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf_cli.LostFocus
        carregar_cliente()
    End Sub

    Private Sub txt_pesquisa_DoubleClick(sender As Object, e As EventArgs) Handles txt_pesquisa.DoubleClick
        txt_pesquisa.Clear()
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        Calcula_total()
    End Sub

    Private Sub txt_data_entrada_TextChanged(sender As Object, e As EventArgs) Handles txt_data_entrada.TextChanged
        Calcula_total()
    End Sub

    Private Sub txt_data_saida_TextChanged(sender As Object, e As EventArgs) Handles txt_data_saida.TextChanged
        Calcula_total()
    End Sub

    Private Sub txt_hora_entrada_TextChanged(sender As Object, e As EventArgs) Handles txt_hora_entrada.TextChanged
        Calcula_total()
    End Sub

    Private Sub txt_hora_saida_TextChanged(sender As Object, e As EventArgs) Handles txt_hora_saida.TextChanged
        Calcula_total()
    End Sub

    Private Sub RegistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroToolStripMenuItem.Click
        Me.Hide()
        frm_registro.Visible = True
    End Sub

End Class
