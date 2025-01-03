Public Class frmRelatorio
    Private Sub frmRelatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'ListaClientes.ClientesLista'. Você pode movê-la ou removê-la conforme necessário.
        Me.ClientesListaTableAdapter.Fill(Me.ListaClientes.ClientesLista)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class