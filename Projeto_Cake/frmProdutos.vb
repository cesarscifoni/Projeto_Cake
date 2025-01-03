Public Class frmProdutos
    Private Sub frmProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_produtos()
    End Sub


    Private Function camposOk() As Boolean
        Dim result = False
        If txt_sabor.Text = "" Or txt_peso.Text = "" Or mtxt_preco.Text = "" Then
            result = False
        Else
            result = True
        End If
        Return result
    End Function

    Private Sub btn_confirmaProd_Click(sender As Object, e As EventArgs) Handles btn_confirmaProd.Click
        If camposOk() = True Then
            Try
                Dim sql = "select * from Produtos where sabor='" & txt_sabor.Text & "' and peso='" & txt_peso.Text & "g" & "'"
                rs = db.Execute(LCase(sql))
                If rs.EOF = True Then
                    sql = "INSERT INTO Produtos (sabor, peso, valor) VALUES ('" & txt_sabor.Text & "', '" & txt_peso.Text + "g" & "', '" & CDbl(mtxt_preco.Text) & "')"
                    rs = db.Execute(LCase(sql))
                    MsgBox("Produto cadastrado com sucesso!", MsgBoxStyle.Information, "Aviso")
                    carregar_produtos()
                    txt_peso.Clear()
                    txt_sabor.Clear()
                    mtxt_preco.Clear()
                Else
                    MsgBox("Produto já cadastrado!", MsgBoxStyle.Information, "Aviso")
                End If
            Catch ex As Exception
                MsgBox("Erro no formuário Produtos. Contate o administrador!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End Try
        End If
    End Sub

    Private Sub mtxt_preco_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtxt_preco.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 44 Then
            e.Handled = True
        End If
    End Sub

    Private Sub dgv_prod_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_prod.CellContentClick
        Try
            With dgv_prod
                If .CurrentRow.Cells(4).Selected Then
                    Dim sabor = .CurrentRow.Cells(1).Value
                    Dim peso = .CurrentRow.Cells(2).Value
                    Dim sql = "DELETE FROM Produtos WHERE sabor='" & sabor & "' and peso='" & peso & "'"
                    MsgBox("Produto apagado com sucesso!", MsgBoxStyle.Information, "Aviso")
                    rs = db.Execute(LCase(sql))
                    carregar_produtos()
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_peso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_peso.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 44 Then
            e.Handled = True
        End If
    End Sub

    Private Sub mtxt_preco_TextChanged(sender As Object, e As EventArgs) Handles mtxt_preco.TextChanged

    End Sub
End Class