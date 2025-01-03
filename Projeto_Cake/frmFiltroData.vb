Public Class frmFiltroData
    Private Sub btn_confirmaF_Click(sender As Object, e As EventArgs) Handles btn_confirmaF.Click
        If validarForm() Then
            data1 = mskDataInicial.Text
            data2 = mskDataFinal.Text
            frmPedidosData.ShowDialog()
            Me.Close()
        End If
    End Sub
    Private Function validarForm() As Boolean
        If Not IsDate(mskDataInicial.Text) Then
            MsgBox("Data inicial inválida!", MsgBoxStyle.Exclamation, "Aviso")
            mskDataInicial.Focus()
            Return False
        ElseIf Not IsDate(mskDataFinal.Text) Then
            MsgBox("Data final inválida!", MsgBoxStyle.Exclamation, "Aviso")
            mskDataInicial.Focus()
            Return False
        ElseIf Convert.ToDateTime(mskDataInicial.Text).ToString("yyyyMMdd") > Convert.ToDateTime(mskDataFinal.Text).ToString("yyyyMMdd") Then
            MsgBox("Período inválido!", MsgBoxStyle.Exclamation, "Aviso")
            mskDataInicial.Focus()
            Return False
        Else
            Return True
        End If
    End Function
End Class