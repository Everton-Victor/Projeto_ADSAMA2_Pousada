Module Geral
    Public usuario, senha, status, aux, aux2 As String
    Public diretorio, sql, resp, type_login As String
    Public db As New ADODB.Connection
    Public rs, rs_aux, rs2 As New ADODB.Recordset
    Public dir_foto, email_func, categ, email_func_g As String
    Public dirbanco = Application.StartupPath & "\banco\adsma2_banco_pousada.mdb"
    Public cont As Integer

    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & dirbanco)
        Catch ex As Exception
            MsgBox("Erro ao Conectar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub limpar_func()
        With frm_funcionarios
            .txt_nome.Clear()
            .txt_email.Clear()
            .txt_senha.Clear()
            .txt_confirmar_senha.Clear()
            .cmb_cargo.Text = ""
            .cmb_status_conta.Text = ""
            .cmb_tipo_conta.Text = ""
        End With
    End Sub

    Sub limpar_login()
        With frm_login
            .txt_email.Text = ""
            .txt_senha.Text = ""
            .txt_email.Focus()
        End With
    End Sub

    Sub limpar_pac_serv()
        With frm_pacote_servico
            .txt_nome.Clear()
            .txt_descricao.Clear()
            .txt_preco.Text = "R$ "
            .cmb_tipo.Text = ""
            .txt_cod_pac_serv.Text = ""
            .img_foto.Load(Application.StartupPath & "\icons\Add-Basket-icon-big.png")
            .txt_nome.Focus()
        End With
    End Sub

    Sub limpar_quarto()
        With frm_quartos
            .txt_num.Clear()
            .txt_desc.Clear()
            .txt_preco.Clear()
            .txt_preco.Text = "R$ "
            .cmb_tipo.Text = ""
            .img_foto.Load(Application.StartupPath & "\icons\room-big.png")
            .txt_num.Focus()
        End With
    End Sub

    Sub limpar_reserva()
        With frm_reserva
            .txt_celular_cli.Clear()
            .txt_cpf_acomp.Clear()
            .txt_cpf_acomp_cadastrado.Clear()
            .txt_cpf_cli.Clear()
            .txt_nome_acomp.Clear()
            .txt_nome_cli.Clear()
            .txt_num_reserva.Clear()
            .txt_valor_parcela.Clear()
            .cmb_cpf_acomp.Text = ""
            .cmb_cpf_acomp.Items.Clear()
            .txt_data_entrada.Value = "20/01/2021"
            .txt_data_saida.Value = "20/06/2022"
            .cmb_pacote_serv.SelectedIndex = 0
            .txt_total.Text = ""

            .txt_cpf_cli.Focus()
        End With
    End Sub

    Sub limpar_checkin()
        With frm_checkin
            .txt_cpf.Clear()
            .txt_num_reserva.Clear()
            .txt_nome.Clear()
            .txt_celular.Clear()
            .txt_nome_acomp.Clear()
            .txt_num_quarto.Clear()
            .txt_pac_serv.Clear()
            .cmb_cpf_acomp.Items.Clear()
            .cmb_num_reserva.Items.Clear()
            .cmb_cpf_acomp.Text = ""
            .cmb_num_reserva.Text = ""
        End With
    End Sub

    Sub limpar_checkout()
        With frm_checkout
            .txt_cpf.Clear()
            .txt_num_reserva.Clear()
            .txt_nome.Clear()
            .txt_celular.Clear()
            .txt_nome_acomp.Clear()
            .txt_num_quarto.Clear()
            .txt_pac_serv.Clear()
            .cmb_cpf_acomp.Items.Clear()
            .cmb_num_reserva.Items.Clear()
            .cmb_cpf_acomp.Text = ""
            .cmb_num_reserva.Text = ""
        End With
    End Sub

    Sub carregar_type_login()
        Try
            sql = "select * from tb_funcionario where email_func='" & email_func_g & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                If rs.Fields(4).Value = "admin" Then
                    type_login = "admin"
                Else
                    type_login = "user"
                End If
            Else

            End If
        Catch ex As Exception
            MsgBox("Erro de Processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try


    End Sub


    Sub carregar_dados_func()
        Try

            sql = "select * from tb_funcionario order by nome_func asc"
            rs = db.Execute(sql)
            cont = 1

            With frm_funcionarios.dgv_fun
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value, Nothing, Nothing)
                    rs.MoveNext()
                    cont += 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro de Processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_quartos()
        Try

            sql = "select * from tb_quartos order by num_quarto asc"
            rs = db.Execute(sql)
            With frm_quartos.dgv_quartos
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(4).Value, Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro de Processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_pacote_serv()
        Try

            sql = "select * from tb_pacote_servico order by cod_pac_serv asc"
            rs = db.Execute(sql)
            With frm_pacote_servico.dgv_pac_serv
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro de Processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_pac_serv_reserva()
        Try
            sql = "select * from tb_pacote_servico"
            rs = db.Execute(sql)

            With frm_reserva
                .cmb_pacote_serv.Items.Clear()
                .cmb_pacote_serv.Items.Add("")
                Do While rs.EOF = False
                    If rs.Fields(0).Value <> 0 Then
                        .cmb_pacote_serv.Items.Add(rs.Fields(0).Value & " - " & rs.Fields(1).Value)
                    End If
                    rs.MoveNext()
                Loop

                If .cmb_pacote_serv.Items.Count <> 0 Then
                    .cmb_pacote_serv.SelectedIndex = 0
                End If
            End With

        Catch ex As Exception
            MsgBox("Erro de Processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_quartos_reserva()
        Try
            sql = "select * from tb_quartos"
            rs = db.Execute(sql)

            With frm_reserva
                .cmb_quarto.Items.Clear()
                Do While rs.EOF = False
                    .cmb_quarto.Items.Add(rs.Fields(0).Value)
                    rs.MoveNext()
                Loop


                If .cmb_quarto.Items.Count <> 0 Then
                    .cmb_quarto.SelectedIndex = 0
                End If

            End With

        Catch ex As Exception
            MsgBox("Erro de Processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_acompanhante()
        Try
            With frm_reserva

                If .txt_cpf_cli.Text <> "" And .txt_num_reserva.Text <> "" Then
                    sql = "select * from tb_acompanhante where (num_reserva=" & .txt_num_reserva.Text & " and cpf_cliente='" & .txt_cpf_cli.Text & "')"
                    rs = db.Execute(sql)

                    .cmb_cpf_acomp.Text = ""
                    .txt_cpf_acomp_cadastrado.Text = ""
                    .cmb_cpf_acomp.Items.Clear()
                    Do While rs.EOF = False
                        .cmb_cpf_acomp.Items.Add(rs.Fields(0).Value)
                        rs.MoveNext()
                    Loop
                    If .cmb_cpf_acomp.Items.Count <> 0 Then
                        .cmb_cpf_acomp.SelectedIndex = 0
                    End If
                End If

            End With


        Catch ex As Exception
            MsgBox("Erro de Processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try


    End Sub

    Sub carregar_num_reserva()
        With frm_reserva
            sql = "select * from tb_reserva order by num_reserva asc"
            rs = db.Execute(sql)

            Do While rs.EOF = False
                cont = rs.Fields(0).Value
                rs.MoveNext()
            Loop

            .txt_num_reserva.Text = cont + 1
        End With
    End Sub

    Sub carregar_reserva()
        Try
            Dim dataInicial, dataFinal As String

            sql = "select * from tb_reserva order by num_reserva desc"
            rs = db.Execute(sql)

            With frm_reserva.dgv_reserva
                .Rows.Clear()
                Do While rs.EOF = False
                    aux = "select * from tb_checkin where num_reserva=" & rs.Fields(0).Value & ""
                    rs_aux = db.Execute(aux)
                    dataInicial = rs.Fields(1).Value
                    dataFinal = rs.Fields(3).Value

                    dataInicial = dataInicial.Replace("00:00:00", "")
                    dataFinal = dataFinal.Replace("00:00:00", "")
                    dataFinal.Trim()
                    dataInicial.Trim()

                    If rs_aux.EOF = True Then
                        If rs.Fields(8).Value <> 0 Then
                            .Rows.Add(rs.Fields(0).Value, rs.Fields(9).Value, rs.Fields(8).Value, rs.Fields(11).Value, dataInicial, dataFinal, rs.Fields(10).Value, Nothing, Nothing)
                        Else
                            .Rows.Add(rs.Fields(0).Value, rs.Fields(9).Value, Nothing, rs.Fields(11).Value, dataInicial, dataFinal, rs.Fields(10).Value, Nothing, Nothing)

                        End If
                    End If

                    rs.MoveNext()
                Loop
            End With




        Catch ex As Exception
            MsgBox("Erro de Processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_registro()
        Try
            sql = "select * from tb_reserva order by num_reserva desc"
            rs = db.Execute(sql)

            With frm_registro.dgv_registro
                .Rows.Clear()
                Do While rs.EOF = False
                    aux = "select * from tb_checkin where num_reserva=" & rs.Fields(0).Value & ""
                    rs_aux = db.Execute(aux)

                    aux2 = "select * from tb_checkout where num_reserva=" & rs.Fields(0).Value & ""
                    rs2 = db.Execute(aux2)

                    If rs_aux.EOF = False Then
                        If rs2.EOF = False Then
                            .Rows.Add(rs.Fields(11).Value, rs.Fields(0).Value, rs_aux.Fields(1).Value, rs_aux.Fields(2).Value, rs2.Fields(1).Value, rs2.Fields(2).Value)
                        ElseIf rs2.EOF = True Then
                            .Rows.Add(rs.Fields(11).Value, rs.Fields(0).Value, rs_aux.Fields(1).Value, rs_aux.Fields(2).Value, Nothing, Nothing)
                        End If
                    End If

                    rs.MoveNext()
                Loop
            End With




        Catch ex As Exception
            MsgBox("Erro de Processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub



    Sub carregar_tipo_conta()
        Try
            With frm_funcionarios.cmb_tipo_conta.Items
                .Clear()
                .Add("user")
                .Add("admin")
            End With
            frm_funcionarios.cmb_tipo_conta.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_status_conta()
        Try
            With frm_funcionarios.cmb_status_conta.Items
                .Clear
                .Add("Ativa")
                .Add("Bloqueada")
            End With
            frm_funcionarios.cmb_status_conta.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_cargo()
        Try
            With frm_funcionarios.cmb_cargo.Items
                .Clear()
                .Add("Gerente")
                .Add("Atendente")
                .Add("Caixa")
                .Add("Ajudante Geral")
                .Add("Supervisor")
            End With
            frm_funcionarios.cmb_cargo.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_tipo_pacote()
        Try
            With frm_pacote_servico.cmb_tipo.Items
                .Clear()
                .Add("Basico")
                .Add("Normal")
                .Add("Plus")
                .Add("Premium")
            End With
            frm_pacote_servico.cmb_tipo.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_tipo_quarto()
        Try
            With frm_quartos.cmb_tipo.Items
                .Clear()
                .Add("Basico")
                .Add("Normal")
                .Add("Plus")
                .Add("Premium")
            End With
            frm_quartos.cmb_tipo.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_forma_pagamanto()
        Try
            With frm_reserva.cmb_forma_pagamento.Items
                .Clear()
                .Add("Dinheiro")
                .Add("Cartão de Crédito")
                .Add("PIX")
            End With
            frm_reserva.cmb_forma_pagamento.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_parcela()
        Try
            With frm_reserva.cmb_parcela.Items
                .Clear()
                .Add("1")
                .Add("2")
                .Add("4")
                .Add("6")
                .Add("12")
                .Add("24")
            End With
            frm_reserva.cmb_forma_pagamento.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_catergoria_pesquisa()
        Try
            With frm_reserva.cmb_categoria.Items
                .Clear()
                .Add("Número da Reserva")
                .Add("CPF do Cliente")
                .Add("Código do Pacote de Serviço")
                .Add("Número do Quarto")
                .Add("E-mail do Funcionário")
            End With
            frm_reserva.cmb_categoria.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_catergoria_pesquisa_pac_serv()
        Try
            With frm_pacote_servico.cmb_categoria.Items
                .Clear()
                .Add("Código")
                .Add("Nome")
                .Add("Descrição")
                .Add("Tipo")
                .Add("Preço")
            End With
            frm_pacote_servico.cmb_categoria.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_catergoria_pesquisa_func()
        Try
            With frm_funcionarios.cmb_categoria.Items
                .Clear()
                .Add("E-mail")
                .Add("Nome")
                .Add("Cargo")
                .Add("Conta")
                .Add("Status")
            End With
            frm_funcionarios.cmb_categoria.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_catergoria_pesquisa_registro()
        Try
            With frm_registro.cmb_categoria.Items
                .Clear()
                .Add("Número da Reserva")
                .Add("CPF do Cliente")
            End With
            frm_registro.cmb_categoria.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_catergoria_pesquisa_quarto()
        Try
            With frm_quartos.cmb_categoria.Items
                .Clear()
                .Add("Número")
                .Add("Tipo")
                .Add("Descrição")
                .Add("Preço")
            End With
            frm_quartos.cmb_categoria.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_cliente()
        Try
            With frm_reserva
                If .txt_cpf_cli.Text <> "" Then
                    sql = "select * from tb_cliente where cpf_cliente='" & .txt_cpf_cli.Text & "'"
                    rs = db.Execute(sql)

                    If rs.EOF = False Then
                        .txt_nome_cli.Text = rs.Fields(1).Value
                        .txt_celular_cli.Text = rs.Fields(2).Value
                    End If
                End If
            End With

        Catch ex As Exception
            MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub Calcula_parcela()
        Dim num As String
        With frm_reserva
            If .txt_total.Text <> "" And .cmb_parcela.Text <> "" Then
                num = .txt_total.Text.Remove(0, 3)
                '.txt_total.Text = .txt_total.Text.Replace(".", "")
                '.txt_total.Text = .txt_total.Text.Replace(",", ".")
                .txt_valor_parcela.Text = FormatCurrency((Convert.ToDecimal(num) / Convert.ToDecimal(.cmb_parcela.Text)))
            End If
        End With
    End Sub

    Sub Calcula_total()
        Try
            With frm_reserva
                Dim num1, num2 As String
                Dim dtini As DateTime = .txt_data_entrada.Value
                Dim dtfim As DateTime = .txt_data_saida.Value
                Dim num3 As Integer

                If DateDiff(DateInterval.Day, dtini, dtfim) < 0 Then
                    MsgBox("Datas inválidas!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ALERTA")
                    .txt_total.Text = ""
                Else
                    If DateDiff(DateInterval.Day, dtini, dtfim) = 0 Then
                        num3 = 1
                    Else
                        num3 = Convert.ToDecimal(DateDiff(DateInterval.Day, dtini, dtfim))
                    End If
                    If .txt_preco_pac_serv.Text <> "" And .txt_preco_quarto.Text <> "" Then
                        num1 = .txt_preco_quarto.Text.Replace("R$ ", "")
                        num2 = .txt_preco_pac_serv.Text.Replace("R$ ", "")
                        .txt_total.Text = FormatCurrency((Convert.ToDecimal(num1) + Convert.ToDecimal(num2)) * num3)
                    End If
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Module
