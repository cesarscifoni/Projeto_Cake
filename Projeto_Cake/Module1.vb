Module Module1
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public dirbanco = Application.StartupPath & "\BANCOS DE DADOS\bancoCake.mdb"

    Public adm = False
    Public ativo = False
    Public conectado = False

    Public visualL = 0, visualC = 0

    Public cpf As String

    Sub conecta_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & dirbanco)
            MsgBox("Conexão OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao Conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub carregar_dados()
        Try
            Dim cont = 0
            Dim sql = "select * from Contas where usuario<>'" & "" & "'"
            rs = db.Execute(sql)
            cont = 1
            With frmUsuarios.dgv_lista
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value)
                    rs.MoveNext()
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_produtos()
        Dim cont = 0
        Dim sql = "select * from Produtos where sabor<>'" & "" & "'"
        Try
            rs = db.Execute(sql)
            cont = 1
            With frmProdutos.dgv_prod
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value)
                    rs.MoveNext()
                    cont = cont + 1
                Loop
            End With
        Catch
            MsgBox("Erro ao carregar produtos", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Module
