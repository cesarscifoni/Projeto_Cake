<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPedidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPedidos))
        Me.btn_confirmaP = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_pesoP = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_saborP = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_CPF = New System.Windows.Forms.TextBox()
        Me.txt_precoP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDesconto = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_confirmaP
        '
        Me.btn_confirmaP.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Italic)
        Me.btn_confirmaP.Image = CType(resources.GetObject("btn_confirmaP.Image"), System.Drawing.Image)
        Me.btn_confirmaP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_confirmaP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_confirmaP.Location = New System.Drawing.Point(99, 212)
        Me.btn_confirmaP.Name = "btn_confirmaP"
        Me.btn_confirmaP.Size = New System.Drawing.Size(135, 42)
        Me.btn_confirmaP.TabIndex = 5
        Me.btn_confirmaP.Text = "    Confirmar"
        Me.btn_confirmaP.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 21)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "CPF:"
        '
        'cmb_pesoP
        '
        Me.cmb_pesoP.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_pesoP.FormattingEnabled = True
        Me.cmb_pesoP.Location = New System.Drawing.Point(179, 100)
        Me.cmb_pesoP.Name = "cmb_pesoP"
        Me.cmb_pesoP.Size = New System.Drawing.Size(129, 29)
        Me.cmb_pesoP.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(175, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 21)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Peso:"
        '
        'cmb_saborP
        '
        Me.cmb_saborP.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_saborP.FormattingEnabled = True
        Me.cmb_saborP.Location = New System.Drawing.Point(29, 100)
        Me.cmb_saborP.Name = "cmb_saborP"
        Me.cmb_saborP.Size = New System.Drawing.Size(129, 29)
        Me.cmb_saborP.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 21)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Sabor:"
        '
        'txt_CPF
        '
        Me.txt_CPF.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CPF.Location = New System.Drawing.Point(25, 36)
        Me.txt_CPF.MaxLength = 11
        Me.txt_CPF.Name = "txt_CPF"
        Me.txt_CPF.Size = New System.Drawing.Size(283, 30)
        Me.txt_CPF.TabIndex = 1
        '
        'txt_precoP
        '
        Me.txt_precoP.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_precoP.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_precoP.Location = New System.Drawing.Point(179, 166)
        Me.txt_precoP.MaxLength = 11
        Me.txt_precoP.Name = "txt_precoP"
        Me.txt_precoP.ReadOnly = True
        Me.txt_precoP.Size = New System.Drawing.Size(129, 30)
        Me.txt_precoP.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(175, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 21)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "R$:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 21)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "Desconto %:"
        '
        'txtDesconto
        '
        Me.txtDesconto.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesconto.Location = New System.Drawing.Point(29, 166)
        Me.txtDesconto.MaxLength = 2
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.Size = New System.Drawing.Size(129, 30)
        Me.txtDesconto.TabIndex = 4
        Me.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 266)
        Me.Controls.Add(Me.txtDesconto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_precoP)
        Me.Controls.Add(Me.txt_CPF)
        Me.Controls.Add(Me.btn_confirmaP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmb_pesoP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_saborP)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Pedidos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_confirmaP As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_pesoP As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_saborP As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_CPF As TextBox
    Friend WithEvents txt_precoP As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDesconto As TextBox
End Class
