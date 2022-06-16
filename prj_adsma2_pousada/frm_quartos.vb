Public Class frm_quartos
    Private Sub frm_quartos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        carregar_quartos()
        If type_login = "admin" Then
            FuncionáriosToolStripMenuItem.Visible = True
        Else
            FuncionáriosToolStripMenuItem.Visible = False
        End If
    End Sub

    Private Sub dgv_quartos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_quartos.CellContentClick
        Try
            With dgv_quartos
                If .CurrentRow.Cells(4).Selected Then
                    aux = .CurrentRow.Cells(0).Value
                    sql = "select * from tb_quartos where num_quarto=" & aux & ""
                    rs = db.Execute(sql)

                    If rs.EOF = False Then
                        TabControl1.SelectTab(0)
                        txt_num.Text = rs.Fields(0).Value
                        cmb_tipo.Text = rs.Fields(1).Value
                        txt_desc.Text = rs.Fields(2).Value
                        img_foto.Load(rs.Fields(3).Value)
                        txt_preco.Text = rs.Fields(4).Value
                    End If
                ElseIf .CurrentRow.Cells(5).Selected Then
                    aux = .CurrentRow.Cells(0).Value
                    resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                            "Quarto: " & aux & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = "delete * from tb_quartos where num_quarto=" & aux & ""
                        rs = db.Execute(sql)
                        carregar_quartos()
                    End If
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione uma foto"
                .InitialDirectory = Application.StartupPath & "\fotos"
                .ShowDialog()
                dir_foto = .FileName
                img_foto.Load(dir_foto)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub txt_num_DoubleClick(sender As Object, e As EventArgs) Handles txt_num.DoubleClick
        Try
            limpar_quarto()
        Catch ex As Exception
            MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub CheckinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckinToolStripMenuItem.Click
        Me.Hide()
        frm_checkin.Visible = True
    End Sub

    Private Sub CheckoutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CheckoutToolStripMenuItem1.Click
        Me.Hide()
        frm_checkout.Visible = True
    End Sub

    Private Sub PacoteDeServiçosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PacoteDeServiçosToolStripMenuItem.Click
        Me.Hide()
        frm_pacote_servico.Visible = True
    End Sub


    Private Sub FuncionáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuncionáriosToolStripMenuItem.Click
        Me.Hide()
        frm_funcionarios.Visible = True
    End Sub

    Private Sub EncerrarSessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarSessToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub CheckoutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frm_reserva.Visible = True
    End Sub
End Class