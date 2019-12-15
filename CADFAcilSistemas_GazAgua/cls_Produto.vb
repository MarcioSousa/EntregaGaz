Imports System.Data.SqlClient

Public Class cls_Produto
    Private codigoproduto As Integer
    Private nomeproduto As String
    Private unidade As String
    Private fornecedor As String
    Private minimo As Integer
    Private precocompraproduto As Double
    Private precovendaproduto As Double
    Private marcaproduto As String
    Private datacadastroproduto As String
    Private qtdeminestoque As Integer
    Private qtdeatualestoque As Integer
    Private dataestoque As String
    Private dataultestproduto As String
    Private qtdeestocar As Integer
    Private qtdeinicial As Integer

    Public Property acodigoproduto
        Get
            Return codigoproduto
        End Get
        Set(ByVal value)
            codigoproduto = value
        End Set
    End Property
    Public Property anomeproduto()
        Get
            Return nomeproduto
        End Get
        Set(ByVal value)
            nomeproduto = value
        End Set
    End Property
    Public Property afornecedor
        Get
            Return fornecedor
        End Get
        Set(value)
            fornecedor = value
        End Set
    End Property
    Public Property aunidade
        Get
            Return unidade
        End Get
        Set(value)
            unidade = value
        End Set
    End Property
    Public Property aminimo
        Get
            Return minimo
        End Get
        Set(value)
            minimo = value
        End Set
    End Property
    Public Property aprecovendaprod
        Get
            Return precovendaproduto
        End Get
        Set(ByVal value)
            precovendaproduto = value
        End Set
    End Property
    Public Property aprecocompraprod
        Get
            Return precocompraproduto
        End Get
        Set(ByVal value)
            precocompraproduto = value
        End Set
    End Property
    Public Property adatacadastroproduto
        Get
            Return datacadastroproduto
        End Get
        Set(ByVal value)
            datacadastroproduto = Convert.ToDateTime(value).ToString("MM/dd/yyyy")
        End Set
    End Property
    Public Property aqtdeinicial
        Get
            Return qtdeinicial
        End Get
        Set(ByVal value)
            qtdeinicial = value
        End Set
    End Property

    Public Property adataultestoque
        Get
            Return dataultestproduto
        End Get
        Set(ByVal value)
            dataultestproduto = Convert.ToDateTime(value).ToString("MM/dd/yyyy")
        End Set
    End Property
    Public Property aqtdeatualestoque
        Get
            Return qtdeatualestoque
        End Get
        Set(ByVal value)
            qtdeatualestoque = value
        End Set
    End Property
    Public Property aqtdeminestoque
        Get
            Return qtdeminestoque
        End Get
        Set(ByVal value)
            qtdeminestoque = value
        End Set
    End Property

    Public Property adataestoque
        Get
            Return dataestoque
        End Get
        Set(ByVal value)
            dataestoque = Convert.ToDateTime(value).ToString("MM/dd/yyyy")
        End Set
    End Property
    Public Property aqtdeestocar
        Get
            Return qtdeestocar
        End Get
        Set(ByVal value)
            qtdeestocar = value
        End Set
    End Property

    '//CONECTANDO AO BANCO DE DADOS
    Private Shared Function AbrindoConexaoBanco() As SqlConnection
        Try
            Dim conString As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\marci\Documents\Visual Studio 2013\Projects\CADFAcilSistemas_GazAgua\CADFAcilSistemas_GazAgua\GazAgua.mdf';Integrated Security=True"
            Dim connection As SqlConnection = New SqlConnection(conSTring)
            connection.Open()
            Return connection
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    '//STRINGS DE ATUALIZAÇÃO DO BANCO DE DADOS
    Public Function stringBanco(ByVal acodprod As Integer, ByVal CUD As String)
        If CUD = 1 Then
            Return "INSERT INTO Produto (cod_prod, nome_prod, fornec_prod, unidade_prod, min_prod, precovend_prod, precocompra_prod, cadastro_prod, qtdeinicial_prod) VALUES ('" & acodprod & "','" & anomeproduto & "','" & afornecedor & "','" & aunidade & "','" & aminimo & "','" & Replace(CDbl(aprecovendaprod), ",", ".") & "','" & Replace(CDbl(precocompraproduto), ",", ".") & "','" & adatacadastroproduto & "','" & aqtdeinicial & "')"
            'ElseIf CUD = 2 Then
            '    Return "UPDATE Produto SET nomeser_prod = '" & anomeprodser & "', precocus_prod = '" & Replace(CDbl(aprecocustoprod), ",", ".") & "', precoven_prod = '" & Replace(CDbl(aprecovendaprod), ",", ".") & "', marca_prod = '" & amarcaprod & "', dtcad_prod = '" & adatacadastroprod & "', qtdeatualest_prod = '" & aqtdeatualestoque & "', qtdeminimoest_prod = '" & aqtdeminestoque & "' WHERE cod_prod = " & acodprodserest
            'ElseIf CUD = 3 Then
            '    Return "UPDATE Produto SET ativo_prod = 'n' WHERE cod_prod = " & acodprodserest
            'ElseIf CUD = 4 Then
            '    Return "INSERT INTO Produto (nomeser_prod, precoven_prod, ativo_prod, categ_prod) VALUES ('" & anomeprodser & "','" & Replace(CDbl(aprecovendaprod), ",", ".") & "','s','ser')"
            'ElseIf CUD = 5 Then
            '    Return "UPDATE Produto SET nomeser_prod = '" & anomeprodser & "', precoven_prod = '" & Replace(CDbl(aprecovendaprod), ",", ".") & "' WHERE cod_prod = " & acodprodserest
            'ElseIf CUD = 6 Then
            '    Return "INSERT INTO Estoque (codprod_est, dt_est, qtdeest_prod) VALUES ('" & acodprodserest & "','" & dataestoque & "','" & aqtdeestocar & "')"
            'ElseIf CUD = 7 Then
            '    Return "UPDATE Produto SET qtdeatualest_prod = '" & qtdeatualestoque & "' WHERE cod_prod = " & acodprodserest
            'Else
            '    Return "UPDATE Produto SET dtultest_prod = '" & dataestoque & "', qtdeatualest_prod = '" & aqtdeatualestoque & "' WHERE cod_prod = " & acodprodserest
        Else
            Return ""
        End If
    End Function

    '//ADICIONAR, EDITAR, EXCLUIR PRODUTO DO BANCO DE DADOS
    Public Sub CUDProdSer(ByVal acodprod As Integer, ByVal CUD As String)
        Using connection As SqlConnection = AbrindoConexaoBanco()
            Try
                Using Command As New SqlCommand(stringBanco(acodprod, CUD), connection)
                    Command.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Throw
            End Try
        End Using
    End Sub

    '//FAZ UM SELECT DOS PRODUTOS E CARREGA NO DATAGRID
    Public Shared Function ReadProduto() As DataTable
        Using connection As SqlConnection = AbrindoConexaoBanco()
            Try
                Dim dt As New DataTable
                Using Command As New SqlCommand("SELECT cod_prod, nome_prod, fornec_prod, unidade_prod, min_prod, precoven_prod, precocompra_prod, datacadastro_prod, qtdeinicial_prod FROM Produto", connection)
                    dt.Load(Command.ExecuteReader())
                    Return dt
                End Using
            Catch ex As Exception
                Throw
            End Try
        End Using
    End Function

    '    '//FAZ UM SELECT DOS SERVIÇOS E CARREGA NO DATAGRID
    '    Public Shared Function ReadServico() As DataTable
    '        Using connection As SqlCeConnection = AbrindoConexaoBanco()
    '            Try
    '                Dim dt As New DataTable
    '                Using Command As New SqlCeCommand("SELECT cod_prod, nomeser_prod, precoven_prod FROM Produto WHERE ativo_prod = 's' AND categ_prod = 'ser'", connection)
    '                    dt.Load(Command.ExecuteReader())
    '                    Return dt
    '                End Using
    '            Catch ex As Exception
    '                Throw
    '            End Try
    '        End Using
    '    End Function

    '    '//CARREGA O TEXBOX COM OS ARQUIVOS NAS QUAIS ESTÁ SENDO CADASTRADO
    '    Function CompletaTextProSer()
    '        Using connection As SqlCeConnection = AbrindoConexaoBanco()
    '            Try
    '                Dim dt As New DataTable
    '                Dim ds As New DataSet

    '                ds.Tables.Add(dt)

    '                Dim da As New SqlCeDataAdapter("SELECT nomeser_prod FROM Produto WHERE ativo_prod = 's'", connection)
    '                da.Fill(dt)

    '                Dim r As DataRow

    '                For Each r In dt.Rows
    '                    frm_Venda.txtProdSer.AutoCompleteCustomSource.Add(r.Item(0).ToString)
    '                Next

    '            Catch ex As Exception
    '                MessageBox.Show(ex.Message)
    '                Return False
    '            End Try
    '            Return True
    '        End Using

    '    End Function

    '    '//CARREGA TODOS OS CAMPOS DO FORMULÁRIO ANTES DE JOGAR NO DATAGRID
    '    Public Sub carregaCamposProduto(ByVal vnome As String, ByVal vcodigo As Integer)
    '        Using connection As SqlCeConnection = AbrindoConexaoBanco()
    '            Try
    '                Dim dt As SqlCeDataReader
    '                If vcodigo = 0 Then
    '                    Using Command As New SqlCeCommand("SELECT cod_prod, precoven_prod FROM Produto WHERE nomeser_prod = '" & vnome & "'", connection)
    '                        dt = Command.ExecuteReader()
    '                        dt.Read()
    '                        acodigoprod = dt("cod_prod")
    '                        aprecovendaprod = dt("precoven_prod")
    '                    End Using
    '                Else
    '                    Using Command As New SqlCeCommand("SELECT nomeser_prod, precoven_prod FROM Produto WHERE cod_prod = " & vcodigo, connection)
    '                        dt = Command.ExecuteReader()
    '                        dt.Read()
    '                        anomeprodser = dt("nomeser_prod")
    '                        aprecovendaprod = dt("precoven_prod")
    '                    End Using
    '                End If
    '            Catch ex As Exception
    '                MessageBox.Show("Valores Incorretos!! Digite novamente os valores acima!!" & " " & ex.Message)
    '                frm_Venda.txtCodProd.Text = ""
    '                frm_Venda.txtProdSer.Text = ""
    '                frm_Venda.txtValor.Text = ""
    '            End Try
    '        End Using
    '    End Sub

    '    '//CARREGA O DATAGRID DO FORMULÁRIO ESTOQUE
    '    Public Shared Function ReadPreencheGridEstoque() As DataTable
    '        Using connection As SqlCeConnection = AbrindoConexaoBanco()
    '            Try
    '                Dim dt As New DataTable
    '                Using Command As New SqlCeCommand("SELECT cod_prod, nomeser_prod, marca_prod, dtcad_prod, dtultest_prod, qtdeatualest_prod, qtdeminimoest_prod FROM Produto WHERE ativo_prod = 's' AND categ_prod = 'pro'", connection)
    '                    dt.Load(Command.ExecuteReader())
    '                    Return dt
    '                End Using
    '            Catch ex As Exception
    '                Throw
    '            End Try
    '        End Using
    '    End Function

    '    '//RETORNA A QUANTIDADE ATUAL DESSE DETERMINADO PRODUTO
    '    Public Shared Function ReadQtdeProduto(ByVal codigoproduto As Integer) As Object
    '        Using connection As SqlCeConnection = AbrindoConexaoBanco()
    '            Try
    '                Using Command As New SqlCeCommand("SELECT qtdeatualest_prod FROM Produto WHERE cod_prod = " & codigoproduto, connection)
    '                    Return Command.ExecuteScalar()
    '                End Using
    '            Catch ex As Exception
    '                MessageBox.Show(ex.Message)
    '                Throw
    '            End Try
    '        End Using
    '    End Function

    '    '//ADICIONA, EDITA, EXCLUI ESTOQUES DE PRODUTOS
    '    Public Sub CUDEstoque(ByVal acodEstoque As Integer, ByVal CUD As String)
    '        Using connection As SqlCeConnection = AbrindoConexaoBanco()
    '            Try
    '                Using Command As New SqlCeCommand(stringBanco(acodEstoque, CUD), connection)
    '                    Command.ExecuteNonQuery()
    '                End Using
    '            Catch ex As Exception
    '                Throw
    '            End Try
    '        End Using
    '    End Sub

    '    '//CARREGA PRODUTO NO CAMPO CLIENTE
    '    Public Shared Function carregaGridCliente(ByVal vcodigocliente As Integer) As DataTable
    '        Using connection As SqlCeConnection = AbrindoConexaoBanco()
    '            Try
    '                Dim dt As New DataTable
    '                Using Command As New SqlCeCommand("SELECT DISTINCT codcom_cai, datacompra_cai, tipopagam FROM Caixa WHERE codcli_cai = " & vcodigocliente & " AND ativo_cai = 's' ORDER BY datacompra_cai DESC", connection)
    '                    dt.Load(Command.ExecuteReader())
    '                    Return dt
    '                End Using
    '            Catch ex As Exception
    '                Throw
    '            End Try
    '        End Using
    '    End Function

    '    '//FAZ UMA VARREDURA NO BANCO SOMANDO A QUANTIDADE TOTAL DE PRODUTOS E SERVIÇOS CADASTRADOS
    '    Public Shared Function totalProduto() As Integer
    '        Using connection As SqlCeConnection = AbrindoConexaoBanco()
    '            Try
    '                Using Command As New SqlCeCommand("SELECT Count(cod_prod) FROM Produto WHERE ativo_prod = 's'", connection)
    '                    Return Command.ExecuteScalar
    '                End Using
    '            Catch ex As Exception
    '                Return 0
    '                MessageBox.Show(ex.Message)
    '            End Try
    '        End Using
    '    End Function

    '    '//CARREGA PRODUTO NO CAMPO CLIENTE
    '    Public Shared Function carregaEstoqueNeg() As DataTable
    '        Using connection As SqlCeConnection = AbrindoConexaoBanco()
    '            Try
    '                Dim dt As New DataTable
    '                Using Command As New SqlCeCommand("SELECT cod_prod, nomeser_prod, qtdeatualest_prod, qtdeminimoest_prod FROM Produto WHERE categ_prod = 'pro' AND qtdeatualest_prod <= qtdeminimoest_prod", connection)
    '                    dt.Load(Command.ExecuteReader())
    '                    Return dt
    '                End Using
    '            Catch ex As Exception
    '                Throw
    '            End Try
    '        End Using
    '    End Function
End Class
