<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPedidosData
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPedidosData))
        Me.PedidosListaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BancoCakeDataSetLISTA = New Projeto_Cake.bancoCakeDataSetLISTA()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PedidosListaTableAdapter = New Projeto_Cake.bancoCakeDataSetLISTATableAdapters.PedidosListaTableAdapter()
        CType(Me.PedidosListaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancoCakeDataSetLISTA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PedidosListaBindingSource
        '
        Me.PedidosListaBindingSource.DataMember = "PedidosLista"
        Me.PedidosListaBindingSource.DataSource = Me.BancoCakeDataSetLISTA
        '
        'BancoCakeDataSetLISTA
        '
        Me.BancoCakeDataSetLISTA.DataSetName = "bancoCakeDataSetLISTA"
        Me.BancoCakeDataSetLISTA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet_FiltroPedidos"
        ReportDataSource2.Value = Me.PedidosListaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Projeto_Cake.relatPedidosPeriodo.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(646, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'PedidosListaTableAdapter
        '
        Me.PedidosListaTableAdapter.ClearBeforeFill = True
        '
        'frmPedidosData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPedidosData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Pedidos - Filtro Data"
        CType(Me.PedidosListaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancoCakeDataSetLISTA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BancoCakeDataSetLISTA As bancoCakeDataSetLISTA
    Friend WithEvents PedidosListaBindingSource As BindingSource
    Friend WithEvents PedidosListaTableAdapter As bancoCakeDataSetLISTATableAdapters.PedidosListaTableAdapter
End Class
