Public Class frm_checkout

    Private Sub frm_checkout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If type_login = "admin" Then
            FuncionáriosToolStripMenuItem.Visible = True
        Else
            FuncionáriosToolStripMenuItem.Visible = False
        End If
    End Sub

    Private Sub CheckinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckinToolStripMenuItem.Click
        Me.Hide()
        frm_checkin.Visible = True
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
        Me.Close()

    End Sub

    Private Sub ReservaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservaToolStripMenuItem.Click
        Me.Hide()
        frm_reserva.Visible = True
    End Sub
End Class