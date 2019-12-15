<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Produto
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvProduto = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtQtdeAtual = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtQtdeMinima = New System.Windows.Forms.TextBox()
        Me.lblPorcLucro = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtValorVenda = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtValorCusto = New System.Windows.Forms.TextBox()
        Me.txtCodProd = New System.Windows.Forms.TextBox()
        Me.txtNomeProd = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpCadastro = New System.Windows.Forms.DateTimePicker()
        Me.txtMarcaProd = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        CType(Me.dgvProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvProduto
        '
        Me.dgvProduto.AllowUserToAddRows = False
        Me.dgvProduto.AllowUserToDeleteRows = False
        Me.dgvProduto.AllowUserToResizeColumns = False
        Me.dgvProduto.AllowUserToResizeRows = False
        Me.dgvProduto.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduto.Location = New System.Drawing.Point(12, 203)
        Me.dgvProduto.MultiSelect = False
        Me.dgvProduto.Name = "dgvProduto"
        Me.dgvProduto.RowHeadersVisible = False
        Me.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProduto.Size = New System.Drawing.Size(508, 220)
        Me.dgvProduto.TabIndex = 36
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtQtdeAtual)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtQtdeMinima)
        Me.Panel2.Controls.Add(Me.lblPorcLucro)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtValorVenda)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtValorCusto)
        Me.Panel2.Controls.Add(Me.txtCodProd)
        Me.Panel2.Controls.Add(Me.txtNomeProd)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.dtpCadastro)
        Me.Panel2.Controls.Add(Me.txtMarcaProd)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(508, 156)
        Me.Panel2.TabIndex = 27
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(386, 70)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(107, 23)
        Me.TextBox1.TabIndex = 48
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(383, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 16)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Unidade"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(231, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 16)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Qtde Inicial"
        '
        'txtQtdeAtual
        '
        Me.txtQtdeAtual.Enabled = False
        Me.txtQtdeAtual.Location = New System.Drawing.Point(234, 115)
        Me.txtQtdeAtual.MaxLength = 8
        Me.txtQtdeAtual.Name = "txtQtdeAtual"
        Me.txtQtdeAtual.Size = New System.Drawing.Size(86, 23)
        Me.txtQtdeAtual.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(326, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 16)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Qtde Mínima"
        '
        'txtQtdeMinima
        '
        Me.txtQtdeMinima.Enabled = False
        Me.txtQtdeMinima.Location = New System.Drawing.Point(326, 115)
        Me.txtQtdeMinima.MaxLength = 8
        Me.txtQtdeMinima.Name = "txtQtdeMinima"
        Me.txtQtdeMinima.Size = New System.Drawing.Size(86, 23)
        Me.txtQtdeMinima.TabIndex = 7
        '
        'lblPorcLucro
        '
        Me.lblPorcLucro.AutoSize = True
        Me.lblPorcLucro.Location = New System.Drawing.Point(427, 118)
        Me.lblPorcLucro.Name = "lblPorcLucro"
        Me.lblPorcLucro.Size = New System.Drawing.Size(29, 16)
        Me.lblPorcLucro.TabIndex = 43
        Me.lblPorcLucro.Text = "0%"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(440, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Lucro"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(120, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 16)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Valor (venda)"
        '
        'txtValorVenda
        '
        Me.txtValorVenda.Enabled = False
        Me.txtValorVenda.Location = New System.Drawing.Point(120, 115)
        Me.txtValorVenda.Name = "txtValorVenda"
        Me.txtValorVenda.Size = New System.Drawing.Size(100, 23)
        Me.txtValorVenda.TabIndex = 5
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(11, 96)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(94, 16)
        Me.Label18.TabIndex = 38
        Me.Label18.Text = "Valor (custo)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Cod.Prod."
        '
        'txtValorCusto
        '
        Me.txtValorCusto.Enabled = False
        Me.txtValorCusto.Location = New System.Drawing.Point(14, 115)
        Me.txtValorCusto.Name = "txtValorCusto"
        Me.txtValorCusto.Size = New System.Drawing.Size(100, 23)
        Me.txtValorCusto.TabIndex = 4
        '
        'txtCodProd
        '
        Me.txtCodProd.Enabled = False
        Me.txtCodProd.Location = New System.Drawing.Point(14, 25)
        Me.txtCodProd.Name = "txtCodProd"
        Me.txtCodProd.Size = New System.Drawing.Size(100, 23)
        Me.txtCodProd.TabIndex = 0
        '
        'txtNomeProd
        '
        Me.txtNomeProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomeProd.Enabled = False
        Me.txtNomeProd.Location = New System.Drawing.Point(14, 70)
        Me.txtNomeProd.Name = "txtNomeProd"
        Me.txtNomeProd.Size = New System.Drawing.Size(366, 23)
        Me.txtNomeProd.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 16)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Nome do Produto"
        '
        'dtpCadastro
        '
        Me.dtpCadastro.Enabled = False
        Me.dtpCadastro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCadastro.Location = New System.Drawing.Point(386, 25)
        Me.dtpCadastro.Name = "dtpCadastro"
        Me.dtpCadastro.Size = New System.Drawing.Size(107, 23)
        Me.dtpCadastro.TabIndex = 2
        '
        'txtMarcaProd
        '
        Me.txtMarcaProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaProd.Enabled = False
        Me.txtMarcaProd.Location = New System.Drawing.Point(120, 25)
        Me.txtMarcaProd.Name = "txtMarcaProd"
        Me.txtMarcaProd.Size = New System.Drawing.Size(260, 23)
        Me.txtMarcaProd.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(383, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 16)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Dt. Cadastro"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(120, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(125, 16)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Marca do Produto"
        '
        'btnNovo
        '
        Me.btnNovo.Location = New System.Drawing.Point(12, 174)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(75, 23)
        Me.btnNovo.TabIndex = 37
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(93, 174)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 38
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(174, 174)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluir.TabIndex = 39
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(364, 174)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirmar.TabIndex = 40
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(445, 174)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 41
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frm_Produto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 433)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.dgvProduto)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Produto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Produtos"
        CType(Me.dgvProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvProduto As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtQtdeAtual As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtQtdeMinima As System.Windows.Forms.TextBox
    Friend WithEvents lblPorcLucro As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtValorVenda As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtValorCusto As System.Windows.Forms.TextBox
    Friend WithEvents txtCodProd As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeProd As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpCadastro As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtMarcaProd As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
