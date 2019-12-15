Public Class frm_Principal
    Public Sub atualiza_form()
        lblCliente.Text = cls_Cliente.totalCliente
    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        frm_Cliente.Show()
        Me.Enabled = False
    End Sub

    Private Sub frm_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        atualiza_form()
    End Sub

    Private Sub btnProduto_Click(sender As Object, e As EventArgs) Handles btnProduto.Click
        frm_Produto.Show()
        Me.Enabled = False
    End Sub

End Class