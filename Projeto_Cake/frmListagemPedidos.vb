Public Class frmListagemPedidos
    Private Sub frmListagemPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("titulo2", "Dados da matriz"))

        Me.PedidosListaTableAdapter.Fill(Me.BancoCakeDataSetLISTA.PedidosLista)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class