Public Class frm_pacote_servico
    Private Sub Frm_pacote_servico_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
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
            carregar_type_login()
            carregar_catergoria_pesquisa_pac_serv()


            If type_login = "admin" Then
                FuncionáriosToolStripMenuItem.Visible = True
                txt_nome.Enabled = True
                txt_preco.Enabled = True
                txt_descricao.Enabled = True
                btn_cadastrar.Visible = True
                cmb_tipo.Enabled = True
                img_foto.Enabled = True
            Else
                FuncionáriosToolStripMenuItem.Visible = False
                txt_nome.Enabled = False
                txt_preco.Enabled = False
                txt_descricao.Enabled = False
                btn_cadastrar.Visible = False
                cmb_tipo.Enabled = False
                img_foto.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try


    End Sub

    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click, img_foto.Click
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

    Private Sub dgv_pac_serv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pac_serv.CellContentClick, dgv_pac_serv.CellContentClick
        Try
            With dgv_pac_serv
                If dgv_pac_serv.Rows.Count <> 0 Then
                    If .CurrentRow.Cells(5).Selected Then
                        aux = .CurrentRow.Cells(0).Value
                        sql = "select * from tb_pacote_servico where cod_pac_serv=" & aux & ""
                        rs = db.Execute(sql)

                        If rs.EOF = False Then
                            TabControl1.SelectTab(0)
                            txt_cod_pac_serv.Text = rs.Fields(0).Value
                            txt_nome.Text = rs.Fields(1).Value
                            If rs.Fields(2).Value <> "" And rs.Fields(2).Value <> "OpenFileDialog1" Then
                                img_foto.Load(rs.Fields(2).Value)
                            Else
                                img_foto.Load(Application.StartupPath & "\icons\Add-Basket-icon-big.png")
                            End If

                            txt_descricao.Text = rs.Fields(3).Value
                            cmb_tipo.Text = rs.Fields(4).Value
                            txt_preco.Text = FormatCurrency(rs.Fields(5).Value)
                        End If
                    ElseIf .CurrentRow.Cells(6).Selected And type_login = "admin" Then
                        aux = .CurrentRow.Cells(0).Value
                        resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                                "Pacote de Serviço: " & aux & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                        If resp = MsgBoxResult.Yes Then
                            sql = "delete * from tb_pacote_servico where cod_pac_serv=" & aux & ""
                            rs = db.Execute(sql)
                            carregar_pacote_serv()
                        End If
                    End If
                End If

            End With
        Catch ex As Exception
            MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txt_nome_DoubleClick(sender As Object, e As EventArgs) Handles txt_nome.DoubleClick, txt_nome.DoubleClick
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


    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Try
            If txt_nome.Text = "" Or txt_preco.Text = "" Or
         txt_descricao.Text = "" Or cmb_tipo.Text = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")

            Else
                If txt_cod_pac_serv.Text = "" Then
                    Dim num1 As String
                    If txt_preco.Text.Contains("R$ ") Then
                        num1 = txt_preco.Text.Replace("R$ ", "")
                    Else
                        num1 = txt_preco.Text
                    End If

                    num1 = num1.Replace(".", "")
                    num1 = num1.Replace(",", ".")

                    If img_foto.ImageLocation = "OpenFileDialog1" Then
                        img_foto.ImageLocation = ""
                    End If

                    sql = "select * from tb_pacote_servico where (nome_pac_serv='" & txt_nome.Text & "' and desc_pac_serv='" & txt_descricao.Text & "' " &
                        "and tipo_pac_serv='" & cmb_tipo.Text & "')"

                    rs = db.Execute(sql)

                    If rs.EOF = True Then
                        sql = "insert into tb_pacote_servico (nome_pac_serv, foto_pac_serv, desc_pac_serv, tipo_pac_serv, preco_pac_serv) " &
                  "values ('" & txt_nome.Text & "', '" & img_foto.ImageLocation & "', '" & txt_descricao.Text & "', '" & cmb_tipo.Text & "', " &
                  num1 & ")"
                        rs = db.Execute(sql)
                        carregar_pacote_serv()
                        limpar_pac_serv()
                        MsgBox("Pacote de Serviço Cadastrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    Else
                        MsgBox("Já existe um Cacote de Serviço com essas definições!" + vbNewLine &
                               "Consulte o Pacote de Serviço com Cód: " & rs.Fields(0).Value & "", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    End If


                Else
                        resp = MsgBox("Deseja atualizar o Pacote de Serviço?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = vbYes Then
                        sql = "select * from tb_pacote_servico where (nome_pac_serv='" & txt_nome.Text & "' and desc_pac_serv='" & txt_descricao.Text & "' " &
                        "and tipo_pac_serv='" & cmb_tipo.Text & "') and cod_pac_serv <> " & txt_cod_pac_serv.Text & ""

                        rs = db.Execute(sql)

                        If rs.EOF = True Then
                            Dim num1 As String
                            If txt_preco.Text.Contains("R$ ") Then
                                num1 = txt_preco.Text.Replace("R$ ", "")
                            Else
                                num1 = txt_preco.Text
                            End If

                            num1 = num1.Replace(".", "")
                            num1 = num1.Replace(",", ".")
                            sql = "update tb_pacote_servico set nome_pac_serv='" & txt_nome.Text & "', foto_pac_serv='" & img_foto.ImageLocation &
                            "', desc_pac_serv='" & txt_descricao.Text & "', tipo_pac_serv='" & cmb_tipo.Text & "'" &
                            ", preco_pac_serv=" & num1 & " where cod_pac_serv=" & txt_cod_pac_serv.Text & ""
                            rs = db.Execute(sql)
                            carregar_pacote_serv()
                            limpar_pac_serv()
                            MsgBox("Pacote de Serviço Atualizado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                        Else
                            MsgBox("Já existe um Cacote de Serviço com essas definições!" + vbNewLine &
                               "Consulte o Pacote de Serviço com Cód: " & rs.Fields(0).Value & "", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")

                        End If


                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try

    End Sub

    Private Sub frm_pacote_servico_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged

        Try
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
            carregar_type_login()
            carregar_catergoria_pesquisa_pac_serv()

            cmb_tipo.Text = ""
            txt_cod_pac_serv.Text = ""

            If type_login = "admin" Then
                FuncionáriosToolStripMenuItem.Visible = True
                txt_nome.Enabled = True
                txt_preco.Enabled = True
                txt_descricao.Enabled = True
                btn_cadastrar.Visible = True
                cmb_tipo.Enabled = True
                img_foto.Enabled = True
            Else
                FuncionáriosToolStripMenuItem.Visible = False
                txt_nome.Enabled = False
                txt_preco.Enabled = False
                txt_descricao.Enabled = False
                btn_cadastrar.Visible = False
                cmb_tipo.Enabled = False
                img_foto.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try

    End Sub

    Private Sub EncerrarSessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarSessToolStripMenuItem.Click
        Me.Hide()
        frm_login.Visible = True
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

    Private Sub RegistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroToolStripMenuItem.Click
        Me.Hide()
        frm_registro.Visible = True
    End Sub

    Private Sub txt_pesquisa_TextChanged(sender As Object, e As EventArgs) Handles txt_pesquisa.TextChanged
        Try
            If cmb_categoria.Text <> "" Then
                If cmb_categoria.Text = "Código" Then
                    categ = "cod_pac_serv"
                ElseIf cmb_categoria.Text = "Nome" Then
                    categ = "nome_pac_serv"
                ElseIf cmb_categoria.Text = "Descrição" Then
                    categ = "desc_pac_serv"
                ElseIf cmb_categoria.Text = "Tipo" Then
                    categ = "tipo_pac_serv"
                ElseIf cmb_categoria.Text = "Preço" Then
                    categ = "preco_pac_serv"
                End If

                sql = "select * from tb_pacote_servico where " & categ & " like '" & txt_pesquisa.Text & "%'" 'Busca pela letra inicial %
                rs = db.Execute(sql)

                With dgv_pac_serv
                    .Rows.Clear()
                    Do While rs.EOF = False
                        .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, Nothing, Nothing)
                        rs.MoveNext()
                    Loop
                End With
            End If
        Catch ex As Exception
            MsgBox("Erro ao carregar dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class