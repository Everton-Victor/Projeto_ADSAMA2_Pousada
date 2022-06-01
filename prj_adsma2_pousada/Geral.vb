Module Geral
    Public usuario, senha, status As String
    Public diretorio, sql, resp As String
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public dirbanco = Application.StartupPath & "\banco\adsma2_banco_pousada.mdb"
    Public cont As Integer

    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & dirbanco)
            MsgBox("Conexão bem sucedida!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao Conectar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub


    Sub limpar_login()
        With frm_login
            .txt_email.Text = ""
            .txt_senha.Text = ""
            .txt_email.Focus()
        End With
    End Sub
End Module
