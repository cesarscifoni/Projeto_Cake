Imports System.Data.OleDb

Public Class frmUsuarios
    Private Sub btn_voltarCadU_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_confirmaCad_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub camposOk()
        If txt_loginCad.Text = "" Or
            txt_senhaCad.Text = "" Or
            pchave.Text = "" Then
            MsgBox("Preencha todos os campos para cadastrar a conta!", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If
    End Sub

    Private Sub CamposClear()
        txt_loginCad.Clear()
        txt_senhaCad.Clear()
        chk_admCad.Checked = False
        chk_ativoCad.Checked = True
        pchave.Clear()
    End Sub

    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_dados()
    End Sub

    Private Sub btn_confirmaCad_Click_1(sender As Object, e As EventArgs) Handles btn_confirmaCad.Click
        Try
            camposOk()
            Dim sql = "SELECT * FROM Contas WHERE usuario='" & txt_loginCad.Text & "'"
            rs = db.Execute(LCase(sql))
            If rs.EOF = True Then
                sql = "INSERT INTO Contas (usuario, senha, adm, ativo, pchave) VALUES ('" & txt_loginCad.Text & "', '" & txt_senhaCad.Text & "', " &
                          "'" & IIf(chk_admCad.Checked, "sim", "nao") & "', '" & IIf(chk_ativoCad.Checked, "ativa", "desativa") & "', '" & pchave.Text & "')"
                rs = db.Execute(LCase(sql))
                MsgBox("Conta criada com sucesso!", MsgBoxStyle.Information, "Aviso")
                CamposClear()
                carregar_dados()
            Else
                sql = "UPDATE Contas set senha='" & txt_senhaCad.Text & "', " &
                      "adm='" & IIf(chk_admCad.Checked, "sim", "nao") & "', ativo='" & IIf(chk_ativoCad.Checked, "ativa", "desativa") & "', pchave='" & pchave.Text & "'WHERE usuario='" & txt_loginCad.Text & "'"
                rs = db.Execute(LCase(sql))
                MsgBox("Conta alterada com sucesso!", MsgBoxStyle.Information, "Aviso")
                CamposClear()
                carregar_dados()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_voltarCadU_Click_1(sender As Object, e As EventArgs)
    End Sub

    Private Sub pb_visualL_Click(sender As Object, e As EventArgs) Handles pb_visualC.Click
        If visualL = 0 Then
            pb_visualC.Image = Image.FromFile(Application.StartupPath & "\Icones\show.png")
            visualL = True
            txt_senhaCad.PasswordChar = ""
        Else
            pb_visualC.Image = Image.FromFile(Application.StartupPath & "\Icones\hide.png")
            visualL = False
            txt_senhaCad.PasswordChar = "●"
        End If
    End Sub

    Private Sub dgv_lista_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_lista.CellContentClick
        Try
            With dgv_lista
                If .CurrentRow.Cells(6).Selected Then
                    Dim user = .CurrentRow.Cells(1).Value
                    Dim sql = "SELECT * FROM Contas WHERE usuario='" & user & "'"
                    rs = db.Execute(LCase(sql))
                    If rs.EOF = False Then
                        TabControl1.SelectTab(0)
                        txt_loginCad.Text = rs.Fields(0).Value
                        txt_senhaCad.Text = rs.Fields(1).Value
                        pchave.Text = rs.Fields(4).Value
                    End If
                ElseIf .CurrentRow.Cells(4).Selected Then
                    Dim user = .CurrentRow.Cells(1).Value
                    Dim sql = "update Contas set senha='" & .CurrentRow.Cells(2).Value & "', " &
                                            "adm='" & .CurrentRow.Cells(3).Value & "', " &
                                            "ativo='" & IIf(.CurrentRow.Cells(4).Value = "ativa", "desativa", "ativa") & "' where usuario='" & user & "'"
                    rs = db.Execute(LCase(sql))
                    MsgBox("Status alterado com sucesso!")
                    carregar_dados()
                ElseIf .CurrentRow.Cells(7).Selected Then
                    Dim user = .CurrentRow.Cells(1).Value
                    Dim Sql = "DELETE FROM Contas WHERE usuario='" & user & "'"
                    rs = db.Execute(LCase(Sql))
                    MsgBox("Essa conta foi apagada com sucesso!", MsgBoxStyle.Information, "Aviso")
                    carregar_dados()
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro no editar")
        End Try
    End Sub

    Private Sub chk_ativoCad_CheckedChanged(sender As Object, e As EventArgs) Handles chk_ativoCad.CheckedChanged

    End Sub
End Class