<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFiltroData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFiltroData))
        Me.mskDataInicial = New System.Windows.Forms.MaskedTextBox()
        Me.mskDataFinal = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_confirmaF = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'mskDataInicial
        '
        Me.mskDataInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskDataInicial.Location = New System.Drawing.Point(141, 30)
        Me.mskDataInicial.Mask = "00/00/0000"
        Me.mskDataInicial.Name = "mskDataInicial"
        Me.mskDataInicial.Size = New System.Drawing.Size(100, 26)
        Me.mskDataInicial.TabIndex = 0
        Me.mskDataInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mskDataFinal
        '
        Me.mskDataFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskDataFinal.Location = New System.Drawing.Point(141, 81)
        Me.mskDataFinal.Mask = "00/00/0000"
        Me.mskDataFinal.Name = "mskDataFinal"
        Me.mskDataFinal.Size = New System.Drawing.Size(100, 26)
        Me.mskDataFinal.TabIndex = 1
        Me.mskDataFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Período de:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Até:"
        '
        'btn_confirmaF
        '
        Me.btn_confirmaF.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Italic)
        Me.btn_confirmaF.Image = CType(resources.GetObject("btn_confirmaF.Image"), System.Drawing.Image)
        Me.btn_confirmaF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_confirmaF.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_confirmaF.Location = New System.Drawing.Point(59, 131)
        Me.btn_confirmaF.Name = "btn_confirmaF"
        Me.btn_confirmaF.Size = New System.Drawing.Size(135, 42)
        Me.btn_confirmaF.TabIndex = 5
        Me.btn_confirmaF.Text = "    Confirmar"
        Me.btn_confirmaF.UseVisualStyleBackColor = True
        '
        'frmFiltroData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(253, 185)
        Me.Controls.Add(Me.btn_confirmaF)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mskDataFinal)
        Me.Controls.Add(Me.mskDataInicial)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFiltroData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filtro de Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mskDataInicial As MaskedTextBox
    Friend WithEvents mskDataFinal As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_confirmaF As Button
End Class
