

Public Class frmLogin
    Private Sub btn_acesso_Click(sender As Object, e As EventArgs) Handles btn_acesso.Click

        Dim sql = ""
        Try
            sql = "SELECT * FROM Contas WHERE usuario='" & txt_login.Text & "' and senha= '" & txt_senha.Text & "'"
            rs = db.Execute(LCase(sql))
            If rs.EOF = False Then
                If verificarAdm() Then
                    adm = True
                End If
                If verificarAtivo() Then
                    ativo = True
                End If
                If ativo = True Then
                    MsgBox("Conta logada com sucesso!", MsgBoxStyle.Information, "Aviso")
                    frmMenu.Show()
                    Me.Close()
                Else
                    MsgBox("Conta desativada! Contate o suporte.", MsgBoxStyle.Critical, "Aviso")
                    txt_login.Clear()
                    txt_senha.Clear()
                End If
            Else
                MsgBox("Conta inválida!", vbExclamation, "Aviso")
                txt_login.Clear()
                txt_senha.Clear()
            End If
        Catch ex As Exception
            MsgBox("Erro no formuário Login. Contate o administrador!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Function verificarAdm() As Boolean

        Dim resultAdm As Boolean
        Try
            Dim sqlAdm = "SELECT * FROM Contas WHERE usuario='" & txt_login.Text & "' and senha= '" & txt_senha.Text & "' and adm='" & "sim" & "'"
            rs = db.Execute(LCase(sqlAdm))
            If rs.EOF = False Then
                resultAdm = True
            Else
                resultAdm = False
            End If
        Catch
            MsgBox("Erro no formuário Pedidos. Contate o administrador!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
        Return resultAdm
    End Function

    Private Function verificarAtivo() As Boolean
        Dim resultAtivo As Boolean
        Dim sqlAtivo = "SELECT * FROM Contas WHERE usuario='" & txt_login.Text & "' and senha= '" & txt_senha.Text & "' and ativo='" & "ativa" & "'"
        rs = db.Execute(LCase(sqlAtivo))
        If rs.EOF = False Then
            resultAtivo = True
        Else
            resultAtivo = False
        End If
        Return resultAtivo
    End Function

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conectado = False Then
            conecta_banco()
            conectado = True
        End If
    End Sub

    Private Sub pb_visualL_Click(sender As Object, e As EventArgs) Handles pb_visualL.Click

        If visualL = 0 Then
            pb_visualL.Image = Image.FromFile(Application.StartupPath & "\Icones\show.png")
            visualL = True
            txt_senha.PasswordChar = ""
        Else
            pb_visualL.Image = Image.FromFile(Application.StartupPath & "\Icones\hide.png")
            visualL = False
            txt_senha.PasswordChar = "●"
        End If
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Application.Exit()
    End Sub

    Private Sub link_esqueci_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link_esqueci.LinkClicked
        If txt_login.Text = "" Then
            MsgBox("É necessário que o login esteja com o nome da sua conta!", MsgBoxStyle.Exclamation, "Aviso")
            Exit Sub
        Else
            frmRedefinir.Show()
        End If
    End Sub
End Class