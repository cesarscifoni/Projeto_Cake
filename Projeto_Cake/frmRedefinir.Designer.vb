<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRedefinir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRedefinir))
        Me.pchave = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_acesso = New System.Windows.Forms.Button()
        Me.txt_senhaNova = New System.Windows.Forms.TextBox()
        Me.lbl_senha = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'pchave
        '
        Me.pchave.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pchave.Location = New System.Drawing.Point(18, 50)
        Me.pchave.Name = "pchave"
        Me.pchave.Size = New System.Drawing.Size(219, 30)
        Me.pchave.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(223, 21)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Chave de recuperação:"
        '
        'btn_acesso
        '
        Me.btn_acesso.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_acesso.Location = New System.Drawing.Point(76, 189)
        Me.btn_acesso.Name = "btn_acesso"
        Me.btn_acesso.Size = New System.Drawing.Size(93, 32)
        Me.btn_acesso.TabIndex = 3
        Me.btn_acesso.Text = "Alterar"
        Me.btn_acesso.UseVisualStyleBackColor = True
        '
        'txt_senhaNova
        '
        Me.txt_senhaNova.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senhaNova.Location = New System.Drawing.Point(18, 118)
        Me.txt_senhaNova.Name = "txt_senhaNova"
        Me.txt_senhaNova.Size = New System.Drawing.Size(219, 30)
        Me.txt_senhaNova.TabIndex = 2
        '
        'lbl_senha
        '
        Me.lbl_senha.AutoSize = True
        Me.lbl_senha.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_senha.Location = New System.Drawing.Point(15, 94)
        Me.lbl_senha.Name = "lbl_senha"
        Me.lbl_senha.Size = New System.Drawing.Size(222, 21)
        Me.lbl_senha.TabIndex = 76
        Me.lbl_senha.Text = "Escolha a nova senha:"
        '
        'frmRedefinir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(251, 233)
        Me.Controls.Add(Me.lbl_senha)
        Me.Controls.Add(Me.txt_senhaNova)
        Me.Controls.Add(Me.btn_acesso)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.pchave)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRedefinir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Redefina sua senha"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pchave As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_acesso As Button
    Friend WithEvents txt_senhaNova As TextBox
    Friend WithEvents lbl_senha As Label
End Class
