<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.pb_visualL = New System.Windows.Forms.PictureBox()
        Me.btn_acesso = New System.Windows.Forms.Button()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.txt_login = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.link_esqueci = New System.Windows.Forms.LinkLabel()
        CType(Me.pb_visualL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb_visualL
        '
        Me.pb_visualL.Image = CType(resources.GetObject("pb_visualL.Image"), System.Drawing.Image)
        Me.pb_visualL.Location = New System.Drawing.Point(378, 58)
        Me.pb_visualL.Name = "pb_visualL"
        Me.pb_visualL.Size = New System.Drawing.Size(30, 27)
        Me.pb_visualL.TabIndex = 74
        Me.pb_visualL.TabStop = False
        '
        'btn_acesso
        '
        Me.btn_acesso.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_acesso.Location = New System.Drawing.Point(315, 91)
        Me.btn_acesso.Name = "btn_acesso"
        Me.btn_acesso.Size = New System.Drawing.Size(93, 32)
        Me.btn_acesso.TabIndex = 3
        Me.btn_acesso.Text = "Login"
        Me.btn_acesso.UseVisualStyleBackColor = True
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(135, 55)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txt_senha.Size = New System.Drawing.Size(233, 30)
        Me.txt_senha.TabIndex = 2
        '
        'txt_login
        '
        Me.txt_login.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_login.Location = New System.Drawing.Point(135, 22)
        Me.txt_login.Name = "txt_login"
        Me.txt_login.Size = New System.Drawing.Size(273, 30)
        Me.txt_login.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 21)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Login:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 21)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Senha:"
        '
        'btn_sair
        '
        Me.btn_sair.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Italic)
        Me.btn_sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_sair.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_sair.Location = New System.Drawing.Point(216, 91)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(93, 32)
        Me.btn_sair.TabIndex = 75
        Me.btn_sair.Text = "Sair"
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'link_esqueci
        '
        Me.link_esqueci.AutoSize = True
        Me.link_esqueci.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_esqueci.Location = New System.Drawing.Point(26, 101)
        Me.link_esqueci.Name = "link_esqueci"
        Me.link_esqueci.Size = New System.Drawing.Size(128, 16)
        Me.link_esqueci.TabIndex = 76
        Me.link_esqueci.TabStop = True
        Me.link_esqueci.Text = "ESQUECI A SENHA"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 129)
        Me.ControlBox = False
        Me.Controls.Add(Me.link_esqueci)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.pb_visualL)
        Me.Controls.Add(Me.btn_acesso)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.txt_login)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Faça login para acessar"
        CType(Me.pb_visualL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pb_visualL As PictureBox
    Friend WithEvents btn_acesso As Button
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents txt_login As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_sair As Button
    Friend WithEvents link_esqueci As LinkLabel
End Class
