Public Class frm_checkout

    Private Sub frm_checkout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If type_login = "admin" Then
            FuncionáriosToolStripMenuItem.Visible = True
        Else
            FuncionáriosToolStripMenuItem.Visible = False
        End If
    End Sub
End Class