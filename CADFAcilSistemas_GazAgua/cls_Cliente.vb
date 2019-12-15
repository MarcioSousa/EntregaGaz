Imports System.Data.SqlClient

Public Class cls_Cliente
    Private codcliente As Integer
    Private nomecliente As String
    Private ruacliente As String
    Private numerocliente As String
    Private apartcliente As String
    Private cepcliente As String
    Private bairrocliente As String
    Private cidadecliente As String
    Private ufcliente As String
    Private datacadastrocliente As String
    Private telres As String
    Private telcel As String
    Private telcom As String

    Public Property acod
        Get
            Return codcliente
        End Get
        Set(ByVal value)
            codcliente = value
        End Set
    End Property
    Public Property anome
        Get
            Return nomecliente
        End Get
        Set(ByVal value)
            nomecliente = value
        End Set
    End Property
    Public Property arua
        Get
            Return ruacliente
        End Get
        Set(ByVal value)
            ruacliente = value
        End Set
    End Property
    Public Property anumero
        Get
            Return numerocliente
        End Get
        Set(ByVal value)
            numerocliente = value
        End Set
    End Property
    Public Property aapartamento
        Get
            Return apartcliente
        End Get
        Set(ByVal value)
            apartcliente = value
        End Set
    End Property
    Public Property acep
        Get
            Return cepcliente
        End Get
        Set(ByVal value)
            cepcliente = value
        End Set
    End Property
    Public Property abairro
        Get
            Return bairrocliente
        End Get
        Set(ByVal value)
            bairrocliente = value
        End Set
    End Property
    Public Property acidade
        Get
            Return cidadecliente
        End Get
        Set(ByVal value)
            cidadecliente = value
        End Set
    End Property
    Public Property auf
        Get
            Return ufcliente
        End Get
        Set(ByVal value)
            ufcliente = value
        End Set
    End Property
    Public Property adatacadastro
        Get
            Return datacadastrocliente
        End Get
        Set(ByVal value)
            datacadastrocliente = Convert.ToDateTime(value).ToString("MM/dd/yyyy")
        End Set
    End Property
    Public Property atelres
        Get
            Dim vResult As String
            vResult = telres
            vResult = vResult.Remove(9, 1)
            vResult = vResult.Remove(3, 2)
            vResult = vResult.Remove(0, 1)
            Return vResult
        End Get
        Set(value)
            telres = value
        End Set
    End Property
    Public Property atelcel
        Get
            Dim vResult As String
            vResult = telcel
            vResult = vResult.Remove(10, 1)
            vResult = vResult.Remove(5, 1)
            vResult = vResult.Remove(3, 1)
            vResult = vResult.Remove(0, 1)
            Return vResult
        End Get
        Set(value)
            telcel = value
        End Set
    End Property
    Public Property atelcom
        Get
            Dim vResult As String
            vResult = telcom
            vResult = vResult.Remove(9, 1)
            vResult = vResult.Remove(3, 2)
            vResult = vResult.Remove(0, 1)
            Return vResult
        End Get
        Set(value)
            telcom = value
        End Set
    End Property

    '//CONECTANDO AO BANCO DE DADOS
    Private Shared Function abrindoConexaoBanco() As SqlConnection
        Try
            Dim conString As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\marci\Documents\Visual Studio 2013\Projects\CADFAcilSistemas_GazAgua\CADFAcilSistemas_GazAgua\GazAgua.mdf';Integrated Security=True"
            'Dim conString As String = "Data Source= " & Application.StartupPath & "\ControleEstoque.sdf;Persist Security Info=False"
            Dim connection As SqlConnection = New SqlConnection(conString)
            connection.Open()
            Return connection
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    '//STRINGS DE ATUALIZAÇÃO DO BANCO DE DADOS
    Public Function stringBanco(ByVal acodcli As Integer, ByVal CUD As Integer)
        Try
            If CUD = 1 Then
                '=========================================================================================================================================================================================cod_cli,          nome_cli,      rua_cli,       num_cli,           apart_cli,         cep_cli,           bairro_cli,       cidade_cli,      uf_cli,         dtcad_cli,       ativo_cli, telres_cli,     telcel_cli,         telcom_cli
                Return "INSERT INTO Cliente (cod_cli, nome_cli, rua_cli, num_cli, apart_cli, cep_cli, bairro_cli, cidade_cli, uf_cli, dtcad_cli, ativo_cli, telres_cli, telcel_cli, telcom_cli) VALUES (" & acodcli & ",'" & anome & "','" & arua & "','" & anumero & "','" & aapartamento & "','" & acep & "','" & abairro & "','" & acidade & "','" & auf & "','" & adatacadastro & "','s','" & atelres & "','" & atelcel & "','" & atelcom & "')"
            ElseIf CUD = 2 Then
                Return "UPDATE Cliente SET nome_cli = '" & anome & "', rua_cli = '" & arua & "', num_cli = '" & anumero & "', apart_cli = '" & aapartamento & "', cep_cli = '" & acep & "', bairro_cli = '" & abairro & "', cidade_cli = '" & acidade & "', uf_cli = '" & auf & "', dtcad_cli = '" & adatacadastro & "', telres_cli = '" & telres & "', telcel_cli = '" & telcel & "', telcom_cli = '" & atelcom & "' WHERE cod_cli = " & acodcli
            Else
                Return "DELETE FROM Cliente WHERE cod_cli = " & acodcli
            End If
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    '//ADICIONAR, EDITAR, EXCLUIR PRODUTO DO BANCO DE DADOS
    Public Sub cudCliente(ByVal acodcli As Integer, ByVal CUD As Integer)
        Using connection As SqlConnection = abrindoConexaoBanco()
            Try
                Using Command As New SqlCommand(stringBanco(acodcli, CUD), connection)
                    Command.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Throw
            End Try
        End Using
    End Sub

    '//VERIFICA O CEP DO CLIENTE QUE ESTÁ SENDO FEITO O CADASTRO
    Public Sub verificaCep(ByVal vcep As String)
        Try
            Dim ds As New DataSet
            Dim xml As String = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", vcep)

            ds.ReadXml(xml)
            If ds.Tables(0).Rows(0)("resultado") Then
                arua = ds.Tables(0).Rows(0)("tipo_logradouro") & " " & ds.Tables(0).Rows(0)("logradouro")
                abairro = ds.Tables(0).Rows(0)("bairro")
                acidade = ds.Tables(0).Rows(0)("cidade")
                auf = ds.Tables(0).Rows(0)("uf")
                Return
            Else
                MessageBox.Show("Cep não localizado, tente novamente...")
            End If
        Catch ex As Exception
            MessageBox.Show("Erro : Verifique se seu computador está conectado a internet e tente novamente!", "Erro ao encotrar Endereço do CEP!")
        End Try
    End Sub

    '//FAZ UMA VARREDURA NO BANCO SOMANDO A QUANTIDADE TOTAL DE PRODUTOS CADASTRADOS
    Public Shared Function novo_Codigo() As String
        Using connection As SqlConnection = abrindoConexaoBanco()
            Try
                Using Command As New SqlCommand("SELECT MAX(cod_cli) FROM Cliente", connection)
                    Return Command.ExecuteScalar
                End Using
            Catch ex As Exception
                Return 1
            End Try
        End Using
    End Function

    '//FAZ UM SELECT DOS PRODUTOS E CARREGA NO DATAGRID
    Public Shared Function readCliente() As DataTable
        Using connection As SqlConnection = abrindoConexaoBanco()
            Try
                Dim dt As New DataTable
                Using Command As New SqlCommand("SELECT cod_cli, nome_cli, rua_cli, num_cli, apart_cli, cep_cli,bairro_cli,cidade_cli,uf_cli, dtcad_cli, telres_cli, telcel_cli, telcom_cli FROM Cliente ORDER BY cod_cli", connection)
                    dt.Load(Command.ExecuteReader())
                    Return dt
                End Using
            Catch ex As Exception
                Throw
            End Try
        End Using
    End Function

    '//FAZ UM SELECT DA TABELA ENTRADA DOS PRODUTOS E CARREGA NO DATAGRID
    Public Shared Function procura(ByVal vProcura As String) As DataTable
        Using connection As SqlConnection = abrindoConexaoBanco()
            Try
                Dim dt As New DataTable
                Using Command As New SqlCommand("SELECT cod_cli, nome_cli, rua_cli, num_cli, apart_cli, cep_cli, bairro_cli, cidade_cli, uf_cli, dtcad_cli, telres_cli, telcel_cli, telcom_cli FROM Cliente WHERE nome_cli LIKE '%" & vProcura & "%' OR telres_cli LIKE '%" & vProcura & "%' OR telcel_cli LIKE '%" & vProcura & "%' OR telcom_cli LIKE '%" & vProcura & "%' ORDER BY cod_cli", connection)
                    dt.Load(Command.ExecuteReader())
                    Return dt
                End Using
            Catch ex As Exception
                Throw
            End Try
        End Using
    End Function

    '//ME RETORNA O TOTAL DE CLIENTES
    Public Shared Function totalCliente() As Integer
        Using connection As SqlConnection = abrindoConexaoBanco()
            Try
                Using Command As New SqlCommand("SELECT COUNT(cod_cli) FROM Cliente", connection)
                    Return Command.ExecuteScalar
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Throw
            End Try
        End Using
    End Function

    ''//FAZ UM SELECT DA TABELA SAIDA DOS PRODUTOS E CARREGA NO DATAGRID
    'Public Shared Function readSaida() As DataTable
    '    Using connection As SqlCeConnection = abrindoConexaoBanco()
    '        Try
    '            Dim dt As New DataTable
    '            Using Command As New SqlCeCommand("SELECT A.cod_sai, A.codprod_sai, A.data_sai, A.qtde_sai, A.valor_sai, A.qtde_sai * A.valor_sai, B.fornec_prod, B.nome_prod, B.unid_prod FROM Saida A INNER JOIN Produto B ON A.codprod_sai = B.cod_prod ORDER BY cod_sai", connection)
    '                dt.Load(Command.ExecuteReader())
    '                Return dt
    '            End Using
    '        Catch ex As Exception
    '            Throw
    '        End Try
    '    End Using
    'End Function



    ''//RETORNA A DATA DE CADASTRO DO CLIENTE
    'Public Shared Function cadastro(ByVal codigo As Integer) As String
    '    Using connection As SqlCeConnection = abrindoConexaoBanco()
    '        Try
    '            Using Command As New SqlCeCommand("SELECT datacad_prod FROM Produto WHERE cod_prod = " & codigo, connection)
    '                Return Command.ExecuteScalar
    '            End Using
    '        Catch ex As Exception
    '            Throw
    '        End Try
    '    End Using
    'End Function

    ''//ME RETORNA O CODIGO DO PRODUTO DE ENTRADA COM MAIOR VALOR
    'Private Function novo_Codigo_Entrada() As String
    '    Using connection As SqlCeConnection = abrindoConexaoBanco()
    '        Try
    '            Using Command As New SqlCeCommand("SELECT MAX(cod_ent) FROM Entrada", connection)
    '                Return Command.ExecuteScalar
    '            End Using
    '        Catch ex As Exception
    '            Return 1
    '        End Try
    '    End Using
    'End Function

    ''//FAZ UM SELECT DOS PRODUTOS E RETORNA APENAS O PRODUTO DIGITADO NO CAMPO CODPROD
    'Public Function preencheCamposProduto(ByVal vcodprod As Integer) As cls_Produto
    '    Using connection As SqlCeConnection = abrindoConexaoBanco()
    '        Try
    '            Dim dr As SqlCeDataReader = Nothing
    '            Using Command As New SqlCeCommand("SELECT nome_prod, unid_prod, fornec_prod FROM Produto WHERE cod_prod = " & vcodprod, connection)
    '                dr = Command.ExecuteReader
    '                dr.Read()
    '                Try
    '                    anomeprod = dr("nome_prod")
    '                    aunidadeprod = dr("unid_prod")
    '                    afornecprod = dr("fornec_prod")
    '                Catch ex As Exception
    '                    anomeprod = ""
    '                    aunidadeprod = ""
    '                    afornecprod = ""
    '                    frm_Entrada.vPassou = True
    '                End Try
    '            End Using
    '        Catch ex As Exception
    '            Throw
    '        End Try
    '    End Using
    '    Return Me
    'End Function

    ''//ME RETORNA A SOMA DE UM PRODUTO DA TABELA ENTRADA
    'Public Function somaProdutoEntrada(ByVal codigoproduto As Integer) As Integer
    '    Using connection As SqlCeConnection = abrindoConexaoBanco()
    '        Try
    '            Using Command As New SqlCeCommand("SELECT SUM(qtde_ent) FROM Entrada WHERE codprod_ent = " & codigoproduto, connection)
    '                Try
    '                    Return Command.ExecuteScalar
    '                Catch ex As Exception
    '                    Return 0
    '                End Try
    '            End Using
    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message)
    '            Throw
    '        End Try
    '    End Using
    'End Function

    ''//ME RETORNA A SOMA DE UM PRODUTO NA TABELA SAIDA
    'Public Function somaProdutoSaida(ByVal codigoproduto As Integer) As Integer
    '    Using connection As SqlCeConnection = abrindoConexaoBanco()
    '        Try
    '            Using Command As New SqlCeCommand("SELECT SUM(qtde_sai) FROM Saida WHERE codprod_sai = " & codigoproduto, connection)
    '                Try
    '                    Return Command.ExecuteScalar
    '                Catch ex As Exception
    '                    Return 0
    '                End Try
    '            End Using
    '        Catch ex As Exception
    '            Return ex.Message
    '        End Try
    '    End Using
    'End Function

    ''//ME RETORNA A SOMA DE DO VALOR DO PRODUTO NA TABELA ENTRADA   
    'Public Function somaValorEntrada(ByVal codigoproduto As Integer, ByVal qtdetotal As Integer) As Integer
    '    Using connection As SqlCeConnection = abrindoConexaoBanco()
    '        Try
    '            Dim dr As SqlCeDataReader
    '            Dim somafinal As Integer = 0
    '            Using Command As New SqlCeCommand("SELECT qtde_ent, valor_ent FROM Entrada WHERE codprod_ent = " & codigoproduto, connection)
    '                dr = Command.ExecuteReader
    '                Do While dr.Read
    '                    somafinal = somafinal + (dr("qtde_ent") * dr("valor_ent"))
    '                Loop
    '                Return somafinal
    '            End Using
    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message)
    '            Throw
    '        End Try
    '    End Using
    'End Function

    ''//ME RETORNA A SOMA DE DO VALOR DO PRODUTO NA TABELA SAIDA  
    'Public Function somaValorSaida(ByVal codigoproduto As Integer, ByVal qtdetotal As Integer) As Integer
    '    Using connection As SqlCeConnection = abrindoConexaoBanco()
    '        Try
    '            Dim dr As SqlCeDataReader
    '            Dim somafinal As Integer = 0
    '            Using Command As New SqlCeCommand("SELECT qtde_sai, valor_sai FROM Saida WHERE codprod_sai = " & codigoproduto, connection)
    '                dr = Command.ExecuteReader
    '                Do While dr.Read
    '                    somafinal = somafinal + (dr("qtde_sai") * dr("valor_sai"))
    '                Loop
    '                Return somafinal
    '            End Using
    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message)
    '            Throw
    '        End Try
    '    End Using
    'End Function



    ''//ME RETORNA O TOTAL DE PRODUTOS DE SAÌDA
    'Public Shared Function totalProdutosSaida() As Integer
    '    Using connection As SqlCeConnection = abrindoConexaoBanco()
    '        Try
    '            Using Command As New SqlCeCommand("SELECT COUNT(cod_sai) FROM Saida", connection)
    '                Return Command.ExecuteScalar
    '            End Using
    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message)
    '            Throw
    '        End Try
    '    End Using
    'End Function

End Class
