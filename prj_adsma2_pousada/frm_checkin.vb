Public Class frm_checkin
    Private Sub Frm_checkin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Try
            Dim datahoraAtual As DateTime = Now
            txt_data.Text = datahoraAtual.ToShortDateString
            txt_hora.Text = datahoraAtual.ToShortTimeString

            If type_login = "admin" Then
                FuncionáriosToolStripMenuItem.Visible = True
            Else
                FuncionáriosToolStripMenuItem.Visible = False
            End If
        Catch ex As Exception
            MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ALERTA")
        End Try

    End Sub


    Private Sub PacoteDeServiçosToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles PacoteDeServiçosToolStripMenuItem.Click
        Me.Hide()
        frm_pacote_servico.Visible = True
    End Sub

    Private Sub QuartosToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles QuartosToolStripMenuItem.Click
        Me.Hide()
        frm_quartos.Visible = True
    End Sub

    Private Sub FuncionáriosToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles FuncionáriosToolStripMenuItem.Click
        Me.Hide()
        frm_funcionarios.Visible = True
    End Sub

    Private Sub EncerrarSessToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles EncerrarSessToolStripMenuItem.Click
        Me.Hide()
        frm_login.Visible = True
    End Sub


    Private Sub txt_cpf_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf.LostFocus
        Try
            Dim datahoraAtual As DateTime = Now
            txt_data.Text = datahoraAtual.ToShortDateString
            txt_hora.Text = datahoraAtual.ToShortTimeString

            If txt_cpf.Text <> "" Then
                sql = "select * from tb_reserva where cpf_cliente='" & txt_cpf.Text & "'"
                rs = db.Execute(sql)
                cmb_num_reserva.Items.Clear()

                Do While rs.EOF = False
                    cmb_num_reserva.Items.Add(rs.Fields(0).Value)
                    rs.MoveNext()
                Loop

                If cmb_num_reserva.Items.Count <> 0 Then
                    cmb_num_reserva.SelectedIndex = 0

                    sql = "select * from tb_cliente where cpf_cliente='" & txt_cpf.Text & "'"
                    rs = db.Execute(sql)

                    If rs.EOF = False Then
                        txt_nome.Text = rs.Fields(1).Value
                        txt_celular.Text = rs.Fields(2).Value
                    End If
                End If


            End If

        Catch ex As Exception
            MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ALERTA")
        End Try

    End Sub

    Private Sub Txt_num_reserva_LostFocus(sender As Object, e As EventArgs) Handles txt_num_reserva.LostFocus
        Try
            Dim datahoraAtual As DateTime = Now
            txt_data.Text = datahoraAtual.ToShortDateString
            txt_hora.Text = datahoraAtual.ToShortTimeString

            If txt_num_reserva.Text <> "" Then
                cmb_cpf_acomp.Items.Clear()
                sql = "select * from tb_reserva where num_reserva=" & txt_num_reserva.Text & ""
                rs = db.Execute(sql)

                If rs.EOF = False Then
                    cmb_num_reserva.Text = rs.Fields(0).Value
                    If rs.Fields(8).Value <> 0 Then
                        txt_pac_serv.Text = rs.Fields(8).Value
                    End If

                    txt_num_quarto.Text = rs.Fields(9).Value
                    txt_cpf.Text = rs.Fields(11).Value

                    sql = "select * from tb_cliente where cpf_cliente='" & txt_cpf.Text & "'"
                    rs = db.Execute(sql)

                    If rs.EOF = False Then
                        txt_nome.Text = rs.Fields(1).Value
                        txt_celular.Text = rs.Fields(2).Value
                    End If

                    sql = "select * from tb_acompanhante where (cpf_cliente='" & txt_cpf.Text & "' and num_reserva=" & cmb_num_reserva.Text & ")"
                    rs = db.Execute(sql)

                    Do While rs.EOF = False
                        cmb_cpf_acomp.Items.Add(rs.Fields(0).Value)
                        rs.MoveNext()
                    Loop
                Else
                    MsgBox("Não existe essa reserva no Banco de dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ALERTA")
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ALERTA")
        End Try

    End Sub

    Private Sub cmb_cpf_acomp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_cpf_acomp.SelectedIndexChanged
        Try
            If cmb_cpf_acomp.Text <> "" Then
                sql = "select * from tb_acompanhante where (cpf_cliente='" & txt_cpf.Text & "' and num_reserva=" & cmb_num_reserva.Text & ")"
                rs = db.Execute(sql)

                If rs.EOF = False Then
                    txt_nome_acomp.Text = rs.Fields(1).Value
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ALERTA")
        End Try

    End Sub


    Private Sub cmb_num_reserva_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_num_reserva.SelectedIndexChanged
        Try
            If cmb_num_reserva.Text <> "" Then
                cmb_cpf_acomp.Items.Clear()
                txt_nome_acomp.Text = ""
                cmb_cpf_acomp.Text = ""
                sql = "select * from tb_reserva where num_reserva=" & cmb_num_reserva.Text & ""
                rs = db.Execute(sql)

                If rs.EOF = False Then
                    txt_num_reserva.Text = rs.Fields(0).Value
                    If rs.Fields(8).Value <> 0 Then
                        txt_pac_serv.Text = rs.Fields(8).Value
                    End If

                    txt_num_quarto.Text = rs.Fields(9).Value
                    txt_cpf.Text = rs.Fields(11).Value

                    sql = "select * from tb_cliente where cpf_cliente='" & rs.Fields(11).Value & "'"
                    rs = db.Execute(sql)

                    If rs.EOF = False Then
                        txt_nome.Text = rs.Fields(1).Value
                        txt_celular.Text = rs.Fields(2).Value


                        sql = "select * from tb_acompanhante where (cpf_cliente='" & txt_cpf.Text & "' and num_reserva=" & cmb_num_reserva.Text & ")"
                        rs = db.Execute(sql)

                        Do While rs.EOF = False
                            cmb_cpf_acomp.Items.Add(rs.Fields(0).Value)
                            rs.MoveNext()
                        Loop

                    End If

                End If
            End If
        Catch ex As Exception
            MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ALERTA")
        End Try
    End Sub

    Private Sub txt_num_reserva_DoubleClick(sender As Object, e As EventArgs) Handles txt_num_reserva.DoubleClick
        Try
            limpar_checkin()
        Catch ex As Exception
            MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ALERTA")
        End Try
    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Try
            If txt_cpf.Text = "" Or txt_num_reserva.Text = "" Or txt_nome.Text = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else
                sql = "select * from tb_reserva where num_reserva=" & txt_num_reserva.Text & ""
                rs = db.Execute(sql)

                If rs.EOF = False Then
                    sql = "select * from tb_checkin where num_reserva=" & txt_num_reserva.Text & ""
                    rs = db.Execute(sql)
                    If rs.EOF = True Then
                        sql = "insert into tb_checkin (data_checkin, hora_checkin, num_reserva) values ('" & txt_data.Text & "', '" & txt_hora.Text & "', '" & txt_num_reserva.Text & "')"
                        rs = db.Execute(sql)
                        MsgBox("Check-in efetuado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                        limpar_checkin()
                    Else
                        MsgBox("A Reserva sob o Nº" & txt_num_reserva.Text & " já efetuou check-in " & vbNewLine &
                               "Data: " & rs.Fields(1).Value & " - Hora: " & rs.Fields(2).Value & "", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ALERTA")
                    End If
                Else
                    MsgBox("Essa reserva não existe na base de dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ALERTA")
                End If

            End If
        Catch ex As Exception
            MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ALERTA")
        End Try

    End Sub

    Private Sub frm_checkin_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
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
        Try
            Dim datahoraAtual As DateTime = Now
            txt_data.Text = datahoraAtual.ToShortDateString
            txt_hora.Text = datahoraAtual.ToShortTimeString

            If type_login = "admin" Then
                FuncionáriosToolStripMenuItem.Visible = True
            Else
                FuncionáriosToolStripMenuItem.Visible = False
            End If
        Catch ex As Exception
            MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ALERTA")
        End Try
    End Sub

    Private Sub ReservaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ReservaToolStripMenuItem1.Click
        Me.Hide()
        frm_reserva.Visible = True
    End Sub

    Private Sub CheckoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckoutToolStripMenuItem.Click
        Me.Hide()
        frm_checkout.Visible = True
    End Sub

    Private Sub RegistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroToolStripMenuItem.Click
        Me.Hide()
        frm_registro.Visible = True
    End Sub

    Private Sub txt_cpf_DoubleClick(sender As Object, e As EventArgs) Handles txt_cpf.DoubleClick
        Try
            limpar_checkin()
        Catch ex As Exception
            MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ALERTA")
        End Try
    End Sub
End Class