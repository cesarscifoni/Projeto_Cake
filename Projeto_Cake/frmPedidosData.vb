Imports System.Configuration
Imports System.Data.OleDb

Public Class frmPedidosData
    Private Sub frmPedidosData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dataI = Convert.ToDateTime(data1).ToString("MM/dd/yyyy")
        Dim dataF = Convert.ToDateTime(data2).ToString("MM/dd/yyyy")

        Dim sql = "SELECT * FROM Pedidos WHERE data BETWEEN #" & dataI & "# AND #" & dataF & "# ORDER BY data"
        Try
            Using cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dirbanco) 'ConfigurationManager.ConnectionStrings("Projeto_Cake.My.MySettings.connBD").ConnectionString)
                cn.Open()
                Using da = New OleDbDataAdapter(sql, cn)
                    da.Fill(Me.BancoCakeDataSetLISTA.PedidosLista)
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Erro no carregar do formuário!")
        End Try
        Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("txtPeriodo", "Período de: " & data1 & " até " & data2))
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub frmPedidosData_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub
End Class