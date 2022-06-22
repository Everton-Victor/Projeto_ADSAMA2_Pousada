Public Class frm_login
    Private Sub Frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Catch ex As Exception
            MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ALERTA")

        End Try

    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Try
            If txt_email.Text = "" Or txt_senha.Text = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                limpar_login()
            Else
                sql = "select * from tb_funcionario where (email_func='" & txt_email.Text & "' and senha_func='" & txt_senha.Text & "')"
                rs = db.Execute(sql)

                If rs.EOF = False Then
                    email_func = txt_email.Text
                    email_func_g = txt_email.Text

                    If rs.Fields(5).Value = "Ativa" Then
                        type_login = rs.Fields(4).Value
                        Me.Hide()
                        limpar_login()
                        frm_reserva.Visible = True
                    Else
                        MsgBox("Conta bloqueada!" &
                               "Entre em contato com Administrador do Sistema.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ALERTA")

                    End If

                Else
                    MsgBox("E-mail ou Senha inválido!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ALERTA")
                    limpar_login()
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ALERTA")
        End Try

    End Sub
    Private Sub Txt_senha_DoubleClick(sender As Object, e As EventArgs) Handles txt_senha.DoubleClick
        If txt_senha.PasswordChar = "*" Then
            txt_senha.PasswordChar = ""
        Else
            txt_senha.PasswordChar = "*"
        End If
    End Sub

    Private Sub Txt_email_DoubleClick(sender As Object, e As EventArgs) Handles txt_email.DoubleClick
        limpar_login()
    End Sub

    Private Sub frm_login_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
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
        Catch ex As Exception
            MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ALERTA")

        End Try


    End Sub
End Class