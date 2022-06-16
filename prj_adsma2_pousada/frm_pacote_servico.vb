Public Class frm_pacote_servico
    Private Sub frm_pacote_servico_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conectar_banco()
        carregar_tipo_pacote()
        carregar_pacote_serv()

        cmb_tipo.Text = ""

        If type_login = "admin" Then
            FuncionáriosToolStripMenuItem.Visible = True
        Else
            FuncionáriosToolStripMenuItem.Visible = False
        End If
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

    Private Sub dgv_pac_serv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pac_serv.CellContentClick
        Try
            With dgv_pac_serv
                If .CurrentRow.Cells(5).Selected Then
                    aux = .CurrentRow.Cells(0).Value
                    sql = "select * from tb_pacote_servico where cod_pac_serv=" & aux & ""
                    rs = db.Execute(sql)

                    If rs.EOF = False Then
                        TabControl1.SelectTab(0)
                        txt_nome.Text = rs.Fields(1).Value
                        img_foto.Load(rs.Fields(2).Value)
                        txt_descricao.Text = rs.Fields(3).Value
                        cmb_tipo.Text = rs.Fields(4).Value
                        txt_preco.Text = rs.Fields(5).Value
                    End If
                ElseIf .CurrentRow.Cells(6).Selected Then
                    aux = .CurrentRow.Cells(0).Value
                    resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                            "Pacote de Serviço: " & aux & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = "delete * from tb_pacote_servico where cod_pac_serv=" & aux & ""
                        rs = db.Execute(sql)
                        carregar_pacote_serv()
                    End If
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txt_nome_DoubleClick(sender As Object, e As EventArgs) Handles txt_nome.DoubleClick
        Try
            limpar_pac_serv()
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

    Private Sub CheckoutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frm_reserva.Visible = True
    End Sub
End Class