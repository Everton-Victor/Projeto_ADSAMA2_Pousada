﻿Public Class frm_pacote_servico


    Private Sub frm_pacote_servico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If type_login = "admin" Then
            FuncionáriosToolStripMenuItem.Visible = True
        Else
            FuncionáriosToolStripMenuItem.Visible = False
        End If
    End Sub
End Class