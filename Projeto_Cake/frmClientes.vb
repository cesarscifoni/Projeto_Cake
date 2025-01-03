Imports System.ComponentModel

Public Class frmClientes
    Private Sub btn_confirmaP_Click(sender As Object, e As EventArgs) Handles btn_confirmaP.Click
        Try
            Dim sql = "SELECT * FROM Clientes WHERE cpf='" & txt_CPFC.Text & "'"
            rs = db.Execute(LCase(sql))

            If rs.EOF = True Then
                sql = "INSERT INTO Clientes (cpf, nome, data_nascimento, desde) VALUES ('" & txt_CPFC.Text & "', '" & txt_NomeC.Text & "', " &
                                                                                        "'" & data_C.Value.Date & "', '" & Now.Date & "')"
                rs = db.Execute(LCase(sql))
                MsgBox("Cliente cadastrado com sucesso!", MsgBoxStyle.Information, "Aviso")
                Me.Close()
            Else
                MsgBox("Esse cliente já está cadastrado no banco de clientes!", MsgBoxStyle.Exclamation, "Aviso")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Erro no formuário Clientes. Contate o administrador!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmClientes_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub
End Class