Public Class frm_checkout

    Private Sub frm_checkout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If type_login = "admin" Then
            FuncionáriosToolStripMenuItem.Visible = True
        Else
            FuncionáriosToolStripMenuItem.Visible = False
        End If
    End Sub

    Private Sub CheckinToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frm_checkin.Visible = True
    End Sub


    Private Sub PacoteDeServiçosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frm_pacote_servico.Visible = True
    End Sub

    Private Sub QuartosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frm_quartos.Visible = True
    End Sub

    Private Sub FuncionáriosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frm_funcionarios.Visible = True
    End Sub



    Private Sub ReservaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frm_reserva.Visible = True
    End Sub

    Private Sub ToolStripDropDownButton1_Click(sender As Object, e As EventArgs) Handles ToolStripDropDownButton1.Click

    End Sub
End Class