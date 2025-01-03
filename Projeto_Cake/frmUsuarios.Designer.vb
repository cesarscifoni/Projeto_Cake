<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuarios))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.pchave = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pb_visualC = New System.Windows.Forms.PictureBox()
        Me.txt_loginCad = New System.Windows.Forms.TextBox()
        Me.btn_confirmaCad = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chk_ativoCad = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chk_admCad = New System.Windows.Forms.CheckBox()
        Me.txt_senhaCad = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_lista = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Chave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ContasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.pb_visualC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_lista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(1, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(460, 256)
        Me.TabControl1.TabIndex = 82
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.pb_visualC)
        Me.TabPage1.Controls.Add(Me.txt_loginCad)
        Me.TabPage1.Controls.Add(Me.btn_confirmaCad)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.chk_ativoCad)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.chk_admCad)
        Me.TabPage1.Controls.Add(Me.txt_senhaCad)
        Me.TabPage1.Controls.Add(Me.pchave)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(452, 230)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cadastro"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'pchave
        '
        Me.pchave.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pchave.Location = New System.Drawing.Point(125, 107)
        Me.pchave.MaxLength = 20
        Me.pchave.Name = "pchave"
        Me.pchave.Size = New System.Drawing.Size(285, 30)
        Me.pchave.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 21)
        Me.Label1.TabIndex = 93
        Me.Label1.Text = "Chave"
        '
        'pb_visualC
        '
        Me.pb_visualC.Image = CType(resources.GetObject("pb_visualC.Image"), System.Drawing.Image)
        Me.pb_visualC.Location = New System.Drawing.Point(380, 69)
        Me.pb_visualC.Name = "pb_visualC"
        Me.pb_visualC.Size = New System.Drawing.Size(30, 27)
        Me.pb_visualC.TabIndex = 91
        Me.pb_visualC.TabStop = False
        '
        'txt_loginCad
        '
        Me.txt_loginCad.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_loginCad.Location = New System.Drawing.Point(125, 30)
        Me.txt_loginCad.Name = "txt_loginCad"
        Me.txt_loginCad.Size = New System.Drawing.Size(285, 30)
        Me.txt_loginCad.TabIndex = 1
        '
        'btn_confirmaCad
        '
        Me.btn_confirmaCad.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Italic)
        Me.btn_confirmaCad.Image = CType(resources.GetObject("btn_confirmaCad.Image"), System.Drawing.Image)
        Me.btn_confirmaCad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_confirmaCad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_confirmaCad.Location = New System.Drawing.Point(275, 182)
        Me.btn_confirmaCad.Name = "btn_confirmaCad"
        Me.btn_confirmaCad.Size = New System.Drawing.Size(135, 42)
        Me.btn_confirmaCad.TabIndex = 6
        Me.btn_confirmaCad.Text = "    Confirmar"
        Me.btn_confirmaCad.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(42, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 21)
        Me.Label7.TabIndex = 86
        Me.Label7.Text = "Senha"
        '
        'chk_ativoCad
        '
        Me.chk_ativoCad.AutoSize = True
        Me.chk_ativoCad.Checked = True
        Me.chk_ativoCad.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_ativoCad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_ativoCad.Location = New System.Drawing.Point(349, 148)
        Me.chk_ativoCad.Name = "chk_ativoCad"
        Me.chk_ativoCad.Size = New System.Drawing.Size(61, 20)
        Me.chk_ativoCad.TabIndex = 5
        Me.chk_ativoCad.Text = "Ativo"
        Me.chk_ativoCad.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(51, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 21)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "Login"
        '
        'chk_admCad
        '
        Me.chk_admCad.AutoSize = True
        Me.chk_admCad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_admCad.Location = New System.Drawing.Point(125, 148)
        Me.chk_admCad.Name = "chk_admCad"
        Me.chk_admCad.Size = New System.Drawing.Size(122, 20)
        Me.chk_admCad.TabIndex = 4
        Me.chk_admCad.Text = "Administrador"
        Me.chk_admCad.UseVisualStyleBackColor = True
        '
        'txt_senhaCad
        '
        Me.txt_senhaCad.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senhaCad.Location = New System.Drawing.Point(125, 66)
        Me.txt_senhaCad.Name = "txt_senhaCad"
        Me.txt_senhaCad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txt_senhaCad.Size = New System.Drawing.Size(246, 30)
        Me.txt_senhaCad.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgv_lista)
        Me.TabPage2.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(452, 230)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Consulta"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgv_lista
        '
        Me.dgv_lista.AllowUserToAddRows = False
        Me.dgv_lista.AllowUserToDeleteRows = False
        Me.dgv_lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_lista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_lista.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.dgv_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_lista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Chave, Me.Column6, Me.Column7})
        Me.dgv_lista.Location = New System.Drawing.Point(6, 6)
        Me.dgv_lista.Name = "dgv_lista"
        Me.dgv_lista.ReadOnly = True
        Me.dgv_lista.Size = New System.Drawing.Size(440, 218)
        Me.dgv_lista.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "N"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 41
        '
        'Column2
        '
        Me.Column2.HeaderText = "Usuario"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 81
        '
        'Column3
        '
        Me.Column3.HeaderText = "Senha"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 70
        '
        'Column4
        '
        Me.Column4.HeaderText = "Admin"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 71
        '
        'Column5
        '
        Me.Column5.HeaderText = "Ativo"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 65
        '
        'Chave
        '
        Me.Chave.HeaderText = "Chave"
        Me.Chave.Name = "Chave"
        Me.Chave.ReadOnly = True
        Me.Chave.Width = 72
        '
        'Column6
        '
        Me.Column6.HeaderText = "Editar"
        Me.Column6.Image = CType(resources.GetObject("Column6.Image"), System.Drawing.Image)
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column6.Width = 67
        '
        'Column7
        '
        Me.Column7.HeaderText = "Apagar"
        Me.Column7.Image = CType(resources.GetObject("Column7.Image"), System.Drawing.Image)
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 56
        '
        'ContasBindingSource
        '
        Me.ContasBindingSource.DataMember = "Contas"
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 262)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUsuarios"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Controle de Usuários"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.pb_visualC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv_lista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txt_loginCad As TextBox
    Friend WithEvents btn_confirmaCad As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents chk_ativoCad As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents chk_admCad As CheckBox
    Friend WithEvents txt_senhaCad As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ContasBindingSource As BindingSource
    Friend WithEvents dgv_lista As DataGridView
    Friend WithEvents pb_visualC As PictureBox
    Friend WithEvents pchave As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Chave As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewImageColumn
    Friend WithEvents Column7 As DataGridViewImageColumn
End Class
