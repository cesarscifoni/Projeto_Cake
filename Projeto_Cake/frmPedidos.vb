Public Class frmPedidos
    Private Sub btn_confirmaP_Click(sender As Object, e As EventArgs) Handles btn_confirmaP.Click
        Dim valorFinal

        If CamposOk() = True Then
            If txtDesconto.Text = "" Then
                valorFinal = CDbl(txt_precoP.Text)
            Else
                Dim desconto = CDbl(txtDesconto.Text) / 100
                Dim preco = CDbl(txt_precoP.Text)
                valorFinal = preco - (desconto * preco)
            End If
            Try
                Dim sql = "INSERT INTO Pedidos (cpf, sabor, peso, valorTotal, data) VALUES ('" & txt_CPF.Text & "', " &
                                                                                        "'" & cmb_saborP.SelectedItem & "', " &
                                                                                        "'" & cmb_pesoP.SelectedItem & "', " &
                                                                                        "'" & valorFinal & "', " &
                                                                                        "'" & Now.Date & "')"
                rs = db.Execute(LCase(sql))
                MsgBox("Pedido cadastrado com sucesso!", MsgBoxStyle.Information, "Aviso")

                'Limpando campos
                txt_CPF.Clear()
                txt_precoP.Clear()
                txtDesconto.Clear()
                cmb_saborP.SelectedIndex = -1
                cmb_pesoP.SelectedIndex = -1
            Catch ex As Exception
                MsgBox("Erro no formuário Pedidos. Contate o administrador!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End Try
        End If
    End Sub

    Private Function CamposOk() As Boolean
        Dim result As Boolean
        If txt_CPF.TextLength < 11 Or cmb_pesoP.SelectedIndex = -1 Or cmb_saborP.SelectedIndex = -1 Then
            MsgBox("É necessário completar todos os campos")
            Return result
            End
        Else
            result = True
        End If
        Try
            Dim sql = "SELECT * FROM Clientes WHERE cpf='" & txt_CPF.Text & "'"
            rs = db.Execute(LCase(sql))
            If rs.EOF = True Then
                MsgBox("Esse CPF não está cadastrado no banco de clientes! Cadastre para prosseguir.", MsgBoxStyle.Exclamation, "Aviso")
                With frmClientes.txt_CPFC
                    .Text = txt_CPF.Text
                End With
                frmClientes.ShowDialog()
                Me.Close()
            Else
                result = True
            End If
        Catch
            MsgBox("Erro no formuário Pedidos. Contate o administrador!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
        Return result
    End Function

    Private Sub frmPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_sabores()
    End Sub

    Private Sub txt_CPF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_CPF.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmPedidos_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub

    Private Sub carregar_opcoes()
        Try
            Dim sql = "SELECT * FROM Produtos WHERE sabor='" & cmb_saborP.Text & "'"
            rs = db.Execute(LCase(sql))
            Do While rs.EOF = False
                If cmb_pesoP.Items.Contains(rs.Fields(2).Value) Then
                    rs.MoveNext()
                Else
                    cmb_pesoP.Items.Add(rs.Fields(2).Value)
                    rs.MoveNext()
                End If
            Loop
        Catch
            MsgBox("Erro no formuário Pedidos. Contate o administrador!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub carregar_sabores()
        Try
            Dim sql = "SELECT * FROM Produtos WHERE sabor<>'" & "" & "'"
            rs = db.Execute(LCase(sql))
            Do While rs.EOF = False
                If cmb_saborP.Items.Contains(rs.Fields(1).Value) Then
                    rs.MoveNext()
                Else
                    cmb_saborP.Items.Add(rs.Fields(1).Value)
                    rs.MoveNext()
                End If
            Loop
        Catch
            MsgBox("Erro no formuário Pedidos. Contate o administrador!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub cmb_pesoP_TextChanged(sender As Object, e As EventArgs) Handles cmb_pesoP.TextChanged
        If cmb_pesoP.SelectedIndex <> -1 Then
            Try
                Dim sql = "SELECT * FROM Produtos WHERE sabor='" & cmb_saborP.Text & "' and peso='" & cmb_pesoP.Text & "'"
                rs = db.Execute(LCase(sql))
                If rs.EOF = False Then
                    txt_precoP.Text = rs.Fields(3).Value
                Else
                    MsgBox("Produto não encontrado no registro de produtos!", MsgBoxStyle.Exclamation, "Aviso")
                    txt_precoP.Text = ""
                End If
            Catch ex As Exception
                MsgBox("Erro no formuário Pedidos. Contate o administrador!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End Try
        End If
    End Sub

    Private Sub cmb_saborP_TextChanged(sender As Object, e As EventArgs) Handles cmb_saborP.TextChanged
        cmb_pesoP.SelectedIndex = -1
        cmb_pesoP.Items.Clear()
        txt_precoP.Text = ""
        carregar_opcoes()
    End Sub

    Private Sub txtDesconto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDesconto.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class