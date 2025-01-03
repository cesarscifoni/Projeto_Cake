<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientes))
        Me.txt_CPFC = New System.Windows.Forms.TextBox()
        Me.btn_confirmaP = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_NomeC = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.data_C = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_CPFC
        '
        Me.txt_CPFC.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CPFC.Location = New System.Drawing.Point(106, 58)
        Me.txt_CPFC.MaxLength = 11
        Me.txt_CPFC.Name = "txt_CPFC"
        Me.txt_CPFC.Size = New System.Drawing.Size(240, 30)
        Me.txt_CPFC.TabIndex = 2
        '
        'btn_confirmaP
        '
        Me.btn_confirmaP.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Italic)
        Me.btn_confirmaP.Image = CType(resources.GetObject("btn_confirmaP.Image"), System.Drawing.Image)
        Me.btn_confirmaP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_confirmaP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_confirmaP.Location = New System.Drawing.Point(127, 143)
        Me.btn_confirmaP.Name = "btn_confirmaP"
        Me.btn_confirmaP.Size = New System.Drawing.Size(135, 42)
        Me.btn_confirmaP.TabIndex = 4
        Me.btn_confirmaP.Text = "    Confirmar"
        Me.btn_confirmaP.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 21)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "CPF:"
        '
        'txt_NomeC
        '
        Me.txt_NomeC.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NomeC.Location = New System.Drawing.Point(106, 22)
        Me.txt_NomeC.MaxLength = 20
        Me.txt_NomeC.Name = "txt_NomeC"
        Me.txt_NomeC.Size = New System.Drawing.Size(240, 30)
        Me.txt_NomeC.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 21)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Nome:"
        '
        'data_C
        '
        Me.data_C.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.data_C.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.data_C.Location = New System.Drawing.Point(146, 94)
        Me.data_C.Name = "data_C"
        Me.data_C.Size = New System.Drawing.Size(200, 30)
        Me.data_C.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 21)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Nascimento:"
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 196)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.data_C)
        Me.Controls.Add(Me.txt_NomeC)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_CPFC)
        Me.Controls.Add(Me.btn_confirmaP)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de clientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_CPFC As TextBox
    Friend WithEvents btn_confirmaP As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_NomeC As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents data_C As DateTimePicker
    Friend WithEvents Label2 As Label
End Class
