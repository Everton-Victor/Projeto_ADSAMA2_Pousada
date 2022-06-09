Public Class frm_login
    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()

    End Sub

    Private Sub btn_ver_senha_Click(sender As Object, e As EventArgs) Handles btn_ver_senha.Click
        If txt_senha.PasswordChar = "*" Then
            txt_senha.PasswordChar = ""
        Else
            txt_senha.PasswordChar = "*"
        End If
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

                    If rs.Fields(5).Value = "Ativa" Then
                        type_login = rs.Fields(4).Value
                        Me.Hide()
                        frm_reserva.ShowDialog()
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
End Class