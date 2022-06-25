Public Class frm_registro
    Private Sub frm_registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try
            conectar_banco()
            carregar_registro()
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
            carregar_catergoria_pesquisa_registro()

            If type_login = "admin" Then
                FuncionáriosToolStripMenuItem.Visible = True
            Else
                FuncionáriosToolStripMenuItem.Visible = False
            End If
        Catch ex As Exception
            MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")

        End Try

    End Sub

    Private Sub frm_registro_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged

        Try
            conectar_banco()
            carregar_registro()
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
            carregar_catergoria_pesquisa_registro()

            If type_login = "admin" Then
                FuncionáriosToolStripMenuItem.Visible = True
            Else
                FuncionáriosToolStripMenuItem.Visible = False
            End If
        Catch ex As Exception
            MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")

        End Try

    End Sub

    Private Sub txt_pesquisa_TextChanged(sender As Object, e As EventArgs) Handles txt_pesquisa.TextChanged
        Try
            If cmb_categoria.Text <> "" Then
                If cmb_categoria.Text = "Número da Reserva" Then
                    categ = "num_reserva"
                ElseIf cmb_categoria.Text = "CPF do Cliente" Then
                    categ = "cpf_cliente"
                End If


                sql = "select * from tb_reserva where " & categ & " Like '" & txt_pesquisa.Text & "%'" 'Busca pela letra inicial %
                rs = db.Execute(sql)

                With dgv_registro
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

            End If
        Catch ex As Exception
            MsgBox("Erro ao carregar dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub ReservaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ReservaToolStripMenuItem1.Click
        Me.Hide()
        frm_reserva.Visible = True
    End Sub

    Private Sub CheckinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckinToolStripMenuItem.Click
        Me.Hide()
        frm_checkin.Visible = True
    End Sub

    Private Sub CheckoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckoutToolStripMenuItem.Click
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
End Class