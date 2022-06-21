Public Class frm_quartos
    Private Sub frm_quartos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        carregar_acompanhante()
        carregar_cargo()
        carregar_catergoria_pesquisa()
        carregar_cliente()
        carregar_dados_func()
        carregar_forma_pagamanto()
        carregar_pacote_serv()
        carregar_pac_serv_reserva()
        carregar_parcela()
        carregar_quartos()
        carregar_quartos_reserva()
        carregar_reserva()
        carregar_status_conta()
        carregar_tipo_conta()
        carregar_tipo_pacote()
        carregar_tipo_quarto()

        cmb_tipo.Text = ""
        type_login = "admin"
        If type_login = "admin" Then
            FuncionáriosToolStripMenuItem.Visible = True
            btn_entrar.Visible = True
            txt_num.Enabled = True
            txt_desc.Enabled = True
            txt_preco.Enabled = True
            cmb_tipo.Enabled = True
            img_foto.Enabled = True
        Else
            FuncionáriosToolStripMenuItem.Visible = False
            btn_entrar.Visible = False
            txt_num.Enabled = False
            txt_desc.Enabled = False
            txt_preco.Enabled = False
            cmb_tipo.Enabled = False
            img_foto.Enabled = False
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
                        txt_preco.Text = FormatCurrency(rs.Fields(4).Value)
                    End If
                ElseIf .CurrentRow.Cells(5).Selected And type_login = "admin" Then
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
        Me.Hide()
        frm_login.Visible = True

    End Sub


    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Try
            If txt_num.Text = "" Or txt_preco.Text = "" Or
                 txt_desc.Text = "" Or cmb_tipo.Text = "" Or img_foto.ImageLocation = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else
                Dim num1 As String
                sql = "select * from tb_quartos where num_quarto=" & txt_num.Text & ""
                rs = db.Execute(sql)

                If txt_preco.Text.Contains("R$ ") Then
                    num1 = txt_preco.Text.Remove(0, 3)
                Else
                    num1 = txt_preco.Text
                End If

                num1 = num1.Replace(".", "")
                num1 = num1.Replace(",", ".")


                If rs.EOF = False Then
                    resp = MsgBox("Deseja atualizar as informações do Quarto Nº" & rs.Fields(0).Value & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = vbYes Then
                        sql = "update tb_quartos set tipo_quarto='" & cmb_tipo.Text & "', desc_quarto='" & txt_desc.Text & "', foto_quarto='" & img_foto.ImageLocation & "', " &
                        "preco_quarto=" & num1 & " where num_quarto=" & txt_num.Text & ""
                        rs = db.Execute(sql)
                        aux = txt_num.Text
                        limpar_quarto()
                        MsgBox("Informações do Quarto Nº" & aux & " atualizada!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                        carregar_quartos()
                    End If
                Else
                    sql = "insert into tb_quartos values (" & txt_num.Text & ", '" & cmb_tipo.Text & "', '" & txt_desc.Text & "', '" & img_foto.ImageLocation & "'," &
                        " " & num1 & ")"

                    rs = db.Execute(sql)
                    limpar_quarto()
                    MsgBox("Quarto cadastrado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")

                    carregar_quartos()
                End If

            End If
        Catch ex As Exception
            MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub frm_quartos_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        conectar_banco()
        carregar_acompanhante()
        carregar_cargo()
        carregar_catergoria_pesquisa()
        carregar_cliente()
        carregar_dados_func()
        carregar_forma_pagamanto()
        carregar_pacote_serv()
        carregar_pac_serv_reserva()
        carregar_parcela()
        carregar_quartos()
        carregar_quartos_reserva()
        carregar_reserva()
        carregar_status_conta()
        carregar_tipo_conta()
        carregar_tipo_pacote()
        carregar_tipo_quarto()

        cmb_tipo.Text = ""

        If type_login = "admin" Then
            FuncionáriosToolStripMenuItem.Visible = True
        Else
            FuncionáriosToolStripMenuItem.Visible = False
        End If
    End Sub

    Private Sub CheckoutToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        Me.Hide()
        frm_reserva.Visible = True
    End Sub

    Private Sub txt_preco_LostFocus(sender As Object, e As EventArgs) Handles txt_preco.LostFocus
        If txt_preco.Text = "" Then
            txt_preco.Text = "R$ "
        End If
    End Sub
End Class