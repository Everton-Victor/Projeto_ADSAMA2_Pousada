﻿Module Geral
    Public usuario, senha, status, aux As String
    Public diretorio, sql, resp, type_login As String
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public dir_foto As String
    Public dirbanco = Application.StartupPath & "\banco\adsma2_banco_pousada.mdb"
    Public cont As Integer

    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & dirbanco)
        Catch ex As Exception
            MsgBox("Erro ao Conectar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub limpar_func()
        With frm_funcionarios
            .txt_nome.Clear()
            .txt_email.Clear()
            .txt_senha.Clear()
            .txt_confirmar_senha.Clear()
            .cmb_cargo.Text = ""
            .cmb_status_conta.Text = ""
            .cmb_tipo_conta.Text = ""
        End With
    End Sub

    Sub limpar_login()
        With frm_login
            .txt_email.Text = ""
            .txt_senha.Text = ""
            .txt_email.Focus()
        End With
    End Sub

    Sub limpar_pac_serv()
        With frm_pacote_servico
            .txt_nome.Clear()
            .txt_descricao.Clear()
            .txt_preco.Clear()
            .cmb_tipo.Text = ""
            .img_foto.Load(Application.StartupPath & "\icons\Add-Basket-icon-big.png")
            .txt_nome.Focus()
        End With
    End Sub

    Sub limpar_quarto()
        With frm_quartos
            .txt_num.Clear()
            .txt_desc.Clear()
            .txt_preco.Clear()
            .cmb_tipo.Text = ""
            .img_foto.Load(Application.StartupPath & "\icons\room-big.png")
            .txt_num.Focus()
        End With
    End Sub

    Sub carregar_dados_func()
        Try

            sql = "select * from tb_funcionario order by nome_func asc"
            rs = db.Execute(sql)
            cont = 1

            With frm_funcionarios.dgv_fun
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value, Nothing, Nothing)
                    rs.MoveNext()
                    cont += 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro de Processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_quartos()
        Try

            sql = "select * from tb_quartos order by num_quarto asc"
            rs = db.Execute(sql)
            With frm_quartos.dgv_quartos
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(4).Value, Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro de Processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_pacote_serv()
        Try

            sql = "select * from tb_pacote_servico order by cod_pac_serv asc"
            rs = db.Execute(sql)
            With frm_pacote_servico.dgv_pac_serv
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro de Processamento", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_tipo_conta()
        Try
            With frm_funcionarios.cmb_tipo_conta.Items
                .Add("user")
                .Add("admin")
            End With
            frm_funcionarios.cmb_tipo_conta.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_status_conta()
        Try
            With frm_funcionarios.cmb_status_conta.Items
                .Add("Ativa")
                .Add("Bloqueada")
            End With
            frm_funcionarios.cmb_status_conta.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_cargo()
        Try
            With frm_funcionarios.cmb_cargo.Items
                .Add("Gerente")
                .Add("Atendente")
                .Add("Caixa")
                .Add("Ajudante Geral")
                .Add("Supervisor")
            End With
            frm_funcionarios.cmb_cargo.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_tipo_pacote()
        Try
            With frm_pacote_servico.cmb_tipo.Items
                .Add("Basic")
                .Add("Normal")
                .Add("Plus")
                .Add("Premium")
            End With
            frm_pacote_servico.cmb_tipo.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Module
