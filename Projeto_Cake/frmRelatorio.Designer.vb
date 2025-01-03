<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRelatorio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelatorio))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ListaClientes = New Projeto_Cake.ListaClientes()
        Me.ClientesListaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesListaTableAdapter = New Projeto_Cake.ListaClientesTableAdapters.ClientesListaTableAdapter()
        CType(Me.ListaClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesListaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "ListaClientes"
        ReportDataSource1.Value = Me.ClientesListaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Projeto_Cake.relatClientes.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(10, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(659, 336)
        Me.ReportViewer1.TabIndex = 0
        '
        'ListaClientes
        '
        Me.ListaClientes.DataSetName = "ListaClientes"
        Me.ListaClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesListaBindingSource
        '
        Me.ClientesListaBindingSource.DataMember = "ClientesLista"
        Me.ClientesListaBindingSource.DataSource = Me.ListaClientes
        '
        'ClientesListaTableAdapter
        '
        Me.ClientesListaTableAdapter.ClearBeforeFill = True
        '
        'frmRelatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 360)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRelatorio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório - Listagem de Clientes"
        CType(Me.ListaClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesListaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ListaClientes As ListaClientes
    Friend WithEvents ClientesListaBindingSource As BindingSource
    Friend WithEvents ClientesListaTableAdapter As ListaClientesTableAdapters.ClientesListaTableAdapter
End Class
