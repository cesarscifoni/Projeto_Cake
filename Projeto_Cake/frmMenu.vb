Public Class frmMenu
    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        frmLogin.Show()
        Me.Close()
        adm = False
        ativo = False
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If adm = False Then
            btn_cadastro.Enabled = False
            btn_relat.Enabled = False
            btn_usuario.Enabled = False
        Else
            btn_cadastro.Enabled = True
            btn_relat.Enabled = True
            btn_usuario.Enabled = True
        End If
    End Sub

    Private Sub btn_usuario_Click(sender As Object, e As EventArgs) Handles btn_usuario.Click
        frmUsuarios.ShowDialog()
    End Sub

    Private Sub btn_pedido_Click(sender As Object, e As EventArgs) Handles btn_pedido.Click
        frmPedidos.ShowDialog()
    End Sub

    Private Sub btn_cadastro_Click(sender As Object, e As EventArgs) Handles btn_cadastro.Click
        frmProdutos.ShowDialog()
    End Sub

    Private Sub btn_cliente_Click(sender As Object, e As EventArgs) Handles btn_cliente.Click
        frmClientes.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_relat.Click
        Process.Start(Application.StartupPath & "\BANCOS DE DADOS\bancoCake.mdb")
    End Sub
End Class
