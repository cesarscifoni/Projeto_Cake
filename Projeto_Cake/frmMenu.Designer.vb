<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.btn_usuario = New System.Windows.Forms.Button()
        Me.btn_cliente = New System.Windows.Forms.Button()
        Me.btn_pedido = New System.Windows.Forms.Button()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.btn_cadastro = New System.Windows.Forms.Button()
        Me.btn_relat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_usuario
        '
        Me.btn_usuario.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Italic)
        Me.btn_usuario.Image = CType(resources.GetObject("btn_usuario.Image"), System.Drawing.Image)
        Me.btn_usuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_usuario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_usuario.Location = New System.Drawing.Point(212, 86)
        Me.btn_usuario.Name = "btn_usuario"
        Me.btn_usuario.Size = New System.Drawing.Size(178, 65)
        Me.btn_usuario.TabIndex = 4
        Me.btn_usuario.Text = "    Gerenciar"
        Me.btn_usuario.UseVisualStyleBackColor = True
        '
        'btn_cliente
        '
        Me.btn_cliente.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Italic)
        Me.btn_cliente.Image = CType(resources.GetObject("btn_cliente.Image"), System.Drawing.Image)
        Me.btn_cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_cliente.Location = New System.Drawing.Point(13, 86)
        Me.btn_cliente.Name = "btn_cliente"
        Me.btn_cliente.Size = New System.Drawing.Size(178, 65)
        Me.btn_cliente.TabIndex = 2
        Me.btn_cliente.Text = "      Cad Cliente"
        Me.btn_cliente.UseVisualStyleBackColor = True
        '
        'btn_pedido
        '
        Me.btn_pedido.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Italic)
        Me.btn_pedido.Image = CType(resources.GetObject("btn_pedido.Image"), System.Drawing.Image)
        Me.btn_pedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_pedido.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_pedido.Location = New System.Drawing.Point(13, 15)
        Me.btn_pedido.Name = "btn_pedido"
        Me.btn_pedido.Size = New System.Drawing.Size(178, 65)
        Me.btn_pedido.TabIndex = 1
        Me.btn_pedido.Text = "    Pedidos"
        Me.btn_pedido.UseVisualStyleBackColor = True
        '
        'btn_sair
        '
        Me.btn_sair.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Italic)
        Me.btn_sair.Image = CType(resources.GetObject("btn_sair.Image"), System.Drawing.Image)
        Me.btn_sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_sair.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_sair.Location = New System.Drawing.Point(12, 157)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(178, 65)
        Me.btn_sair.TabIndex = 5
        Me.btn_sair.Text = "    Sair"
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'btn_cadastro
        '
        Me.btn_cadastro.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Italic)
        Me.btn_cadastro.Image = CType(resources.GetObject("btn_cadastro.Image"), System.Drawing.Image)
        Me.btn_cadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cadastro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_cadastro.Location = New System.Drawing.Point(212, 15)
        Me.btn_cadastro.Name = "btn_cadastro"
        Me.btn_cadastro.Size = New System.Drawing.Size(178, 65)
        Me.btn_cadastro.TabIndex = 3
        Me.btn_cadastro.Text = "    Cad Produto"
        Me.btn_cadastro.UseVisualStyleBackColor = True
        '
        'btn_relat
        '
        Me.btn_relat.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Italic)
        Me.btn_relat.Image = CType(resources.GetObject("btn_relat.Image"), System.Drawing.Image)
        Me.btn_relat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_relat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_relat.Location = New System.Drawing.Point(212, 157)
        Me.btn_relat.Name = "btn_relat"
        Me.btn_relat.Size = New System.Drawing.Size(178, 65)
        Me.btn_relat.TabIndex = 20
        Me.btn_relat.Text = "    Relatórios"
        Me.btn_relat.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 237)
        Me.Controls.Add(Me.btn_relat)
        Me.Controls.Add(Me.btn_usuario)
        Me.Controls.Add(Me.btn_cliente)
        Me.Controls.Add(Me.btn_pedido)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.btn_cadastro)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_usuario As Button
    Friend WithEvents btn_cliente As Button
    Friend WithEvents btn_pedido As Button
    Friend WithEvents btn_sair As Button
    Friend WithEvents btn_cadastro As Button
    Friend WithEvents btn_relat As Button
End Class
