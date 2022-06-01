Public Class frm_funcionarios
    Private Sub frm_funcionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
End Class

