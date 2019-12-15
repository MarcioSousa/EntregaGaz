Public Class frm_Cliente
    Dim vCliente As New cls_Cliente
    Dim vEscolha As String
    Dim vPassou As Boolean = False

    Private Sub carrega_grid()
        dgvCliente.DataSource = cls_Cliente.readCliente
    End Sub

    Private Sub limpa_campos()
        txtNome.Text = ""
        txtCod.Text = ""
        mtbCep.Text = ""
        dtpCadastro.Text = Today
        txtRua.Text = ""
        txtNum.Text = ""
        txtApart.Text = ""
        txtBairro.Text = ""
        txtCidade.Text = ""
        cbxUf.Text = "SP"
        mtbTelRes.Text = ""
        mtbTelCel.Text = ""
        mtbTelCom.Text = ""
    End Sub

    Private Sub abre_campos()
        txtNome.Enabled = True
        txtNome.Enabled = True
        mtbCep.Enabled = True
        dtpCadastro.Enabled = True
        txtRua.Enabled = True
        txtNum.Enabled = True
        txtApart.Enabled = True
        txtBairro.Enabled = True
        txtCidade.Enabled = True
        cbxUf.Enabled = True
        mtbTelRes.Enabled = True
        mtbTelCel.Enabled = True
        mtbTelCom.Enabled = True
        btnPesquisa.Enabled = True
        txtPesquisa.Enabled = False
        dgvCliente.Enabled = False

        btnNovo.Enabled = False
        btnEditar.Enabled = False
        btnExcluir.Enabled = False

        btnConfirmar.Enabled = True
        btnCancelar.Enabled = True
    End Sub

    Private Sub fecha_campos()
        txtNome.Enabled = False
        txtNome.Enabled = False
        mtbCep.Enabled = False
        dtpCadastro.Enabled = False
        txtRua.Enabled = False
        txtNum.Enabled = False
        txtApart.Enabled = False
        txtBairro.Enabled = False
        txtCidade.Enabled = False
        cbxUf.Enabled = False
        mtbTelRes.Enabled = False
        mtbTelCel.Enabled = False
        mtbTelCom.Enabled = False
        btnPesquisa.Enabled = False
        txtPesquisa.Enabled = True
        dgvCliente.Enabled = True

        btnNovo.Enabled = True
        btnEditar.Enabled = True
        btnExcluir.Enabled = True

        btnConfirmar.Enabled = False
        btnCancelar.Enabled = False
    End Sub

    Private Sub carrega_campos()
        If dgvCliente.Rows.Count <> 0 Then
            txtCod.Text = dgvCliente.Rows(dgvCliente.CurrentRow.Index).Cells(0).Value
            txtNome.Text = dgvCliente.Rows(dgvCliente.CurrentRow.Index).Cells(1).Value
            txtRua.Text = dgvCliente.Rows(dgvCliente.CurrentRow.Index).Cells(2).Value
            txtNum.Text = dgvCliente.Rows(dgvCliente.CurrentRow.Index).Cells(3).Value
            txtApart.Text = dgvCliente.Rows(dgvCliente.CurrentRow.Index).Cells(4).Value
            mtbCep.Text = dgvCliente.Rows(dgvCliente.CurrentRow.Index).Cells(5).Value
            txtBairro.Text = dgvCliente.Rows(dgvCliente.CurrentRow.Index).Cells(6).Value
            txtCidade.Text = dgvCliente.Rows(dgvCliente.CurrentRow.Index).Cells(7).Value
            cbxUf.Text = dgvCliente.Rows(dgvCliente.CurrentRow.Index).Cells(8).Value
            dtpCadastro.Text = dgvCliente.Rows(dgvCliente.CurrentRow.Index).Cells(9).Value
            mtbTelRes.Text = dgvCliente.Rows(dgvCliente.CurrentRow.Index).Cells(10).Value
            mtbTelCel.Text = dgvCliente.Rows(dgvCliente.CurrentRow.Index).Cells(11).Value
            mtbTelCom.Text = dgvCliente.Rows(dgvCliente.CurrentRow.Index).Cells(12).Value
        Else
            limpa_campos()
            txtPesquisa.Enabled = False
        End If
    End Sub

    Private Sub verifica_campos()
        If txtNome.Text = "" Then
            MessageBox.Show("Campo Nome vazio. Digite o Nome do Cliente", "Cadastro de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            vPassou = True
            txtNome.Focus()
        End If
    End Sub

    Private Sub frm_Cliente_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frm_Principal.atualiza_form()
        frm_Principal.Enabled = True
    End Sub

    Private Sub btnPesquisa_Click(sender As Object, e As EventArgs) Handles btnPesquisa.Click
        vCliente.verificaCep(mtbCep.Text)
        txtRua.Text = vCliente.arua
        txtBairro.Text = vCliente.abairro
        txtCidade.Text = vCliente.acidade
        cbxUf.Text = vCliente.auf
        If cbxUf.Text = "" Then
            cbxUf.Text = "SP"
            mtbCep.Text = ""
            mtbCep.Focus()
        End If
    End Sub

    Private Sub frm_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carrega_grid()

        dgvCliente.Columns(0).Visible = False
        dgvCliente.Columns(2).Visible = False
        dgvCliente.Columns(3).Visible = False
        dgvCliente.Columns(4).Visible = False
        dgvCliente.Columns(5).Visible = False
        dgvCliente.Columns(6).Visible = False
        dgvCliente.Columns(7).Visible = False
        dgvCliente.Columns(8).Visible = False

        dgvCliente.Columns(10).Visible = False
        dgvCliente.Columns(11).Visible = False
        dgvCliente.Columns(12).Visible = False

        dgvCliente.Columns(1).Width = 235
        dgvCliente.Columns(9).Width = 90

        dgvCliente.Columns(1).HeaderText = "Nome do Cliente"
        dgvCliente.Columns(9).HeaderText = "Cadastro"

        If dgvCliente.Rows.Count <> 0 Then
            dgvCliente.CurrentCell = dgvCliente.Item(1, 0)
        Else
            'dgvCliente.Columns.Clear()
            txtPesquisa.Enabled = False
            btnEditar.Enabled = False
            btnExcluir.Enabled = False
        End If

    End Sub

    Private Sub dgvCliente_SelectionChanged(sender As Object, e As EventArgs) Handles dgvCliente.SelectionChanged
            carrega_campos()
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        abre_campos()
        limpa_campos()
        txtNome.Focus()
        If dgvCliente.Rows.Count <> 0 Then
            txtCod.Text = cls_Cliente.novo_Codigo + 1
        Else
            txtCod.Text = 1
        End If

        vEscolha = "N"
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        abre_campos()
        vEscolha = "E"
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        carrega_campos()
        fecha_campos()
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        verifica_campos()

        If vPassou = False Then
            vCliente.anome = txtNome.Text
            vCliente.acod = txtCod.Text
            vCliente.adatacadastro = dtpCadastro.Text
            vCliente.acep = mtbCep.Text
            vCliente.arua = txtRua.Text
            vCliente.anumero = txtNum.Text
            vCliente.aapartamento = txtApart.Text
            vCliente.abairro = txtBairro.Text
            vCliente.acidade = txtCidade.Text
            vCliente.auf = cbxUf.Text
            vCliente.atelres = mtbTelRes.Text
            vCliente.atelcel = mtbTelCel.Text
            vCliente.atelcom = mtbTelCom.Text
            If vEscolha = "N" Then
                vCliente.cudCliente(txtCod.Text, 1)
                carrega_grid()
                carrega_campos()
            Else
                vCliente.cudCliente(txtCod.Text, 2)
                dgvCliente.Rows(dgvCliente.CurrentRow.Index).Cells(1).Value = txtNome.Text
                dgvCliente.Rows(dgvCliente.CurrentRow.Index).Cells(9).Value = dtpCadastro.Text
            End If
            fecha_campos()
        End If
        vPassou = False
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If MessageBox.Show("Deseja deletar o Cliente " & dgvCliente.Rows(dgvCliente.CurrentRow.Index).Cells(1).Value & " de sua lista de Contatos?", "Exclusão de Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            vCliente.cudCliente(txtCod.Text, 3)
            MessageBox.Show("Cliente deletado com Sucesso", "Cliente Excluído", MessageBoxButtons.OK, MessageBoxIcon.Information)
            carrega_grid()
            carrega_campos()
            If dgvCliente.Rows.Count = 0 Then
                btnEditar.Enabled = False
                btnExcluir.Enabled = False
                'dgvCliente.Columns.Clear()
                txtPesquisa.Enabled = False
            End If
        End If
    End Sub

    Private Sub txtPesquisa_TextChanged(sender As Object, e As EventArgs) Handles txtPesquisa.TextChanged

        If txtPesquisa.Text <> "" Then
            dgvCliente.DataSource = cls_Cliente.procura(txtPesquisa.Text)
        Else
            dgvCliente.DataSource = cls_Cliente.readCliente
        End If

        If dgvCliente.Rows.Count = 0 Then
            limpa_campos()
        End If

    End Sub

End Class