<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmListagemPedidos
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListagemPedidos))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BancoCakeDataSetLISTA = New Projeto_Cake.bancoCakeDataSetLISTA()
        Me.PedidosListaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PedidosListaTableAdapter = New Projeto_Cake.bancoCakeDataSetLISTATableAdapters.PedidosListaTableAdapter()
        CType(Me.BancoCakeDataSetLISTA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidosListaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.PedidosListaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Projeto_Cake.relatListagemPedidos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(645, 399)
        Me.ReportViewer1.TabIndex = 0
        '
        'BancoCakeDataSetLISTA
        '
        Me.BancoCakeDataSetLISTA.DataSetName = "bancoCakeDataSetLISTA"
        Me.BancoCakeDataSetLISTA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PedidosListaBindingSource
        '
        Me.PedidosListaBindingSource.DataMember = "PedidosLista"
        Me.PedidosListaBindingSource.DataSource = Me.BancoCakeDataSetLISTA
        '
        'PedidosListaTableAdapter
        '
        Me.PedidosListaTableAdapter.ClearBeforeFill = True
        '
        'frmListagemPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 399)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListagemPedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório - Listagem de Pedidos"
        CType(Me.BancoCakeDataSetLISTA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidosListaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BancoCakeDataSetLISTA As bancoCakeDataSetLISTA
    Friend WithEvents PedidosListaBindingSource As BindingSource
    Friend WithEvents PedidosListaTableAdapter As bancoCakeDataSetLISTATableAdapters.PedidosListaTableAdapter
End Class
