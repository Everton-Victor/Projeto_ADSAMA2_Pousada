Public Class frm_funcionarios
    Private Sub frm_funcionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
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

    End Sub
End Class

