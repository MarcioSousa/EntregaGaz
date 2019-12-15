Public Class frm_Produto
    Dim vpassou = True
    Dim apassou As Boolean = False

    Private Sub limpa_campos()
        txtCodProd.Text = ""
        txtMarcaProd.Text = ""
        dtpCadastro.Text = ""
        txtNomeProd.Text = ""
        txtValorCusto.Text = ""
        txtValorVenda.Text = ""
        lblPorcLucro.Text = 0
        txtQtdeAtual.Text = 0
        txtQtdeMinima.Text = 0
        txtMarcaProd.Focus()
    End Sub

    Private Sub desabilita_campos()
        txtMarcaProd.Enabled = False
        dtpCadastro.Enabled = False
        txtNomeProd.Enabled = False
        txtValorCusto.Enabled = False
        txtValorVenda.Enabled = False
        txtQtdeAtual.Enabled = False
        txtQtdeMinima.Enabled = False
        btnConfirmar.Enabled = False
        btnCancelar.Enabled = False
        dgvProduto.Enabled = True
        btnNovo.Enabled = True
    End Sub

    Private Sub habilita_campos()
        txtMarcaProd.Enabled = True
        dtpCadastro.Enabled = True
        txtNomeProd.Enabled = True
        txtValorCusto.Enabled = True
        txtValorVenda.Enabled = True
        btnConfirmar.Enabled = True
        btnCancelar.Enabled = True
        txtQtdeAtual.Enabled = True
        txtQtdeMinima.Enabled = True

        btnEditar.Enabled = False
        btnNovo.Enabled = False
        btnExcluir.Enabled = False
        dgvProduto.Enabled = False

        If dgvProduto.Rows.Count <> 0 Then
            txtValorCusto.Text = dgvProduto.Rows(dgvProduto.CurrentRow.Index).Cells(2).Value
            txtValorVenda.Text = dgvProduto.Rows(dgvProduto.CurrentRow.Index).Cells(3).Value
        End If

    End Sub

    Private Sub carrega_grid()
        Try
            dgvProduto.Columns.Clear()
            dgvProduto.DataSource = cls_Produto.ReadProduto
            dgvProduto.Columns.Add("vVenda", "Venda")

            For t = 0 To dgvProduto.Rows.Count - 1
                dgvProduto.Rows(t).Cells(8).Value = String.Format("{0:C}", dgvProduto.Rows(t).Cells(3).Value)
            Next

            dgvProduto.Columns(0).Width = 50
            dgvProduto.Columns(1).Width = 300
            dgvProduto.Columns(8).Width = 138
            dgvProduto.Columns(2).Visible = False
            dgvProduto.Columns(3).Visible = False
            dgvProduto.Columns(4).Visible = False
            dgvProduto.Columns(5).Visible = False
            dgvProduto.Columns(6).Visible = False
            dgvProduto.Columns(7).Visible = False
            dgvProduto.Columns(0).HeaderText = "Cod"
            dgvProduto.Columns(1).HeaderText = "Nome do Produto"
            dgvProduto.Columns(0).ReadOnly = True
            dgvProduto.Columns(1).ReadOnly = True
            dgvProduto.Columns(8).ReadOnly = True
            dgvProduto.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
            dgvProduto.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
            dgvProduto.Columns(8).SortMode = DataGridViewColumnSortMode.NotSortable

            If dgvProduto.Rows.Count = 0 Then
                btnEditar.Enabled = False
                btnExcluir.Enabled = False
                txtCodProd.Text = "0"
                txtMarcaProd.Text = "0"
                dtpCadastro.Value = Today.Date
                txtNomeProd.Text = "NÃO HÁ PRODUTOS CADASTRADOS NO MOMENTO!!!"
                txtValorCusto.Text = ""
                txtValorVenda.Text = ""
                lblPorcLucro.Text = 0%
            Else
                btnEditar.Enabled = True
                btnExcluir.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub verifica_campos()

        If txtMarcaProd.Text = "" Then
            MessageBox.Show("Campo 'Marca do Produto' está vazio, digite a marca do produto no campo acima!!'", "Campo não preenchido!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtMarcaProd.Focus()
            vpassou = False
        ElseIf txtNomeProd.Text = "" Then
            MessageBox.Show("Campo 'Nome do Produto' está vazio, digite o nome do produto no campo acima!!'", "Campo não preenchido!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNomeProd.Focus()
            vpassou = False
        ElseIf txtValorCusto.Text = "" Then
            MessageBox.Show("Campo 'Valor (custo)' está vazio, digite o valor de custo no campo acima!!'", "Campo não preenchido!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtValorCusto.Focus()
            vpassou = False
        ElseIf txtValorVenda.Text = "" Then
            MessageBox.Show("Campo 'Valor (venda)' está vazio, digite o valor de venda no campo acima!!'", "Campo não preenchido!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtValorVenda.Focus()
            vpassou = False
        ElseIf txtQtdeAtual.Text = "" Then
            MessageBox.Show("Campo 'Qtde Atual' está vazio, digite a quantidade Atual desse determinado Produto!!'", "Campo não preenchido!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtQtdeAtual.Focus()
            vpassou = False
        ElseIf txtQtdeMinima.Text = "" Then
            MessageBox.Show("Campo 'Qtde Minima' está vazio, digite a quantidade Mínima desse determinado Produto!!'", "Campo não preenchido!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtQtdeMinima.Focus()
            vpassou = False
        Else
            vpassou = True
        End If

    End Sub

    Private Sub frm_Produto_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frm_Principal.Enabled = True
    End Sub

    'Private Sub frm_Produto_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
    '    frm_Principal.Enabled = True
    '    frm_Principal.carregass()
    'End Sub



    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        verifica_campos()

        Try
            If vpassou = True Then
                Dim vProduto As New cls_Produto
                If txtCodProd.Text = "" Then
                    vProduto.acodigoproduto = 0
                Else
                    vProduto.acodigoproduto = txtCodProd.Text
                End If
                vProduto.anomeproduto = txtNomeProd.Text
                vProduto.adatacadastroproduto = dtpCadastro.Text
                vProduto.afornecedor = txtMarcaProd.Text
                vProduto.aprecocompraprod = txtValorCusto.Text
                vProduto.aprecovendaprod = txtValorVenda.Text
                vProduto.aqtdeatualestoque = txtQtdeAtual.Text
                vProduto.aqtdeminestoque = txtQtdeMinima.Text

                If txtCodProd.Text = "" Then
                    vProduto.CUDProdSer(0, 1)
                    desabilita_campos()
                    carrega_grid()
                Else
                    vProduto.CUDProdSer(txtCodProd.Text, 2)
                    carrega_grid()
                    desabilita_campos()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frm_Produto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carrega_grid()
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        habilita_campos()
        limpa_campos()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        desabilita_campos()
        carrega_grid()
    End Sub

    Private Sub dgvProduto_SelectionChanged(sender As Object, e As EventArgs) Handles dgvProduto.SelectionChanged
        Try
            txtCodProd.Text = dgvProduto.Rows(dgvProduto.CurrentRow.Index).Cells(0).Value
            txtMarcaProd.Text = dgvProduto.Rows(dgvProduto.CurrentRow.Index).Cells(4).Value
            dtpCadastro.Text = dgvProduto.Rows(dgvProduto.CurrentRow.Index).Cells(5).Value
            txtNomeProd.Text = dgvProduto.Rows(dgvProduto.CurrentRow.Index).Cells(1).Value
            txtValorCusto.Text = String.Format("{0:C}", dgvProduto.Rows(dgvProduto.CurrentRow.Index).Cells(2).Value)
            txtValorVenda.Text = String.Format("{0:C}", dgvProduto.Rows(dgvProduto.CurrentRow.Index).Cells(3).Value)
            lblPorcLucro.Text = String.Format("{0:f2}", ((CDec(txtValorVenda.Text) - CDec(txtValorCusto.Text)) * 100) / CDec(txtValorCusto.Text)) & "%"
            txtQtdeAtual.Text = dgvProduto.Rows(dgvProduto.CurrentRow.Index).Cells(6).Value
            txtQtdeMinima.Text = dgvProduto.Rows(dgvProduto.CurrentRow.Index).Cells(7).Value
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Try
            If MessageBox.Show("Deseja Deletar o Produto " & txtNomeProd.Text & " de seu Banco de Dados?", "Exclusão de Produto!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                Dim vProduto As New cls_Produto
                vProduto.CUDProdSer(txtCodProd.Text, 3)
                MessageBox.Show("Produto deletado com Sucesso!!!", "Exclusão de Produto!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                carrega_grid()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        habilita_campos()
        btnConfirmar.Enabled = True
        btnCancelar.Enabled = True
        btnNovo.Enabled = False
        btnEditar.Enabled = False
        btnExcluir.Enabled = False
    End Sub

    Private Sub txtMarcaProd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMarcaProd.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtValorVenda_LostFocus(sender As Object, e As EventArgs) Handles txtValorVenda.LostFocus
        Try
            If txtValorCusto.Text <> "" And txtValorVenda.Text <> "" Then
                lblPorcLucro.Text = String.Format("{0:f2}", ((CDec(txtValorVenda.Text) - CDec(txtValorCusto.Text)) * 100) / CDec(txtValorCusto.Text)) & "%"
            Else
                lblPorcLucro.Text = 0%
            End If
        Catch ex As Exception
            If apassou = False Then
                apassou = True
                MessageBox.Show("Valor incorreto, digite novamente o valor do Formulário!!" & " " & ex.Message)
                txtValorVenda.Text = ""
                txtValorCusto.Text = ""
                txtValorCusto.Focus()
                apassou = False
            Else
                apassou = False
            End If
        End Try
    End Sub

    Private Sub txtValorCusto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValorCusto.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
            Exit Sub
        End If
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            If e.KeyChar <> "," Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtQtdeMinima_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQtdeMinima.KeyPress, txtQtdeAtual.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

End Class