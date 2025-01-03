Public Class frmRedefinir
    Private Sub btn_acesso_Click(sender As Object, e As EventArgs) Handles btn_acesso.Click
        Dim Sql
        Try
            Sql = "SELECT * FROM Contas WHERE usuario='" & frmLogin.txt_login.Text & "' and pchave= '" & pchave.Text & "'"
            rs = db.Execute(LCase(Sql))

            If rs.EOF = True Then
                MsgBox("Palavra chave inválida! procure um admnistrador!", MsgBoxStyle.Exclamation, "Aviso")
                pchave.Clear()
                txt_senhaNova.Clear()
                pchave.Focus()
            Else
                Sql = "UPDATE Contas set senha='" & txt_senhaNova.Text & "' WHERE usuario='" & frmLogin.txt_login.Text & "'"
                rs = db.Execute(LCase(Sql))
                MsgBox("Senha alterada com sucesso!", MsgBoxStyle.Information, "Aviso")
                Me.Close()
            End If
        Catch
            MsgBox("Erro no esqueci senha")
        End Try
    End Sub
End Class