Public Class frm_reserva
    Private Sub frm_reversa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If type_login = "admin" Then
            FuncionáriosToolStripMenuItem.Visible = True
        Else
            FuncionáriosToolStripMenuItem.Visible = False
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
End Class
