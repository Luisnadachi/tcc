<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCarrinho
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCarrinho))
        Me.tbDescontoVenda = New System.Windows.Forms.TextBox()
        Me.tbTotalProd = New System.Windows.Forms.TextBox()
        Me.cbFormaPagamentoVenda = New System.Windows.Forms.ComboBox()
        Me.tbSubTotalVendas = New System.Windows.Forms.TextBox()
        Me.DgvProdutosVenda = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.X = New System.Windows.Forms.Button()
        Me.PanelSelect = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Relatório = New System.Windows.Forms.Button()
        Me.btn_Pesquisar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_Nova = New System.Windows.Forms.Button()
        Me.btn_Finalizar = New System.Windows.Forms.Button()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.TextBoxIdVenda = New System.Windows.Forms.TextBox()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbTotalCompra = New System.Windows.Forms.TextBox()
        Me.tbValorReceb = New System.Windows.Forms.TextBox()
        Me.tbTroco = New System.Windows.Forms.TextBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbCodProduto = New System.Windows.Forms.TextBox()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbProduto = New System.Windows.Forms.TextBox()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbCliente = New System.Windows.Forms.TextBox()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbquantidade = New System.Windows.Forms.TextBox()
        Me.tbPreco = New System.Windows.Forms.TextBox()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbestoque = New System.Windows.Forms.TextBox()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnProcurarProd = New System.Windows.Forms.Button()
        Me.PictureBoxProd = New System.Windows.Forms.PictureBox()
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        CType(Me.DgvProdutosVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel16.SuspendLayout()
        CType(Me.PictureBoxProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbDescontoVenda
        '
        Me.tbDescontoVenda.Enabled = False
        Me.tbDescontoVenda.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDescontoVenda.Location = New System.Drawing.Point(1211, 286)
        Me.tbDescontoVenda.Multiline = True
        Me.tbDescontoVenda.Name = "tbDescontoVenda"
        Me.tbDescontoVenda.Size = New System.Drawing.Size(194, 43)
        Me.tbDescontoVenda.TabIndex = 14
        '
        'tbTotalProd
        '
        Me.tbTotalProd.Enabled = False
        Me.tbTotalProd.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTotalProd.Location = New System.Drawing.Point(1211, 118)
        Me.tbTotalProd.Multiline = True
        Me.tbTotalProd.Name = "tbTotalProd"
        Me.tbTotalProd.Size = New System.Drawing.Size(194, 38)
        Me.tbTotalProd.TabIndex = 12
        '
        'cbFormaPagamentoVenda
        '
        Me.cbFormaPagamentoVenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFormaPagamentoVenda.Enabled = False
        Me.cbFormaPagamentoVenda.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFormaPagamentoVenda.FormattingEnabled = True
        Me.cbFormaPagamentoVenda.Items.AddRange(New Object() {"Dinheiro", "Cartão de crédito", "Cartão de débito"})
        Me.cbFormaPagamentoVenda.Location = New System.Drawing.Point(1211, 643)
        Me.cbFormaPagamentoVenda.Name = "cbFormaPagamentoVenda"
        Me.cbFormaPagamentoVenda.Size = New System.Drawing.Size(194, 26)
        Me.cbFormaPagamentoVenda.TabIndex = 10
        '
        'tbSubTotalVendas
        '
        Me.tbSubTotalVendas.Enabled = False
        Me.tbSubTotalVendas.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSubTotalVendas.Location = New System.Drawing.Point(1211, 202)
        Me.tbSubTotalVendas.Multiline = True
        Me.tbSubTotalVendas.Name = "tbSubTotalVendas"
        Me.tbSubTotalVendas.Size = New System.Drawing.Size(196, 38)
        Me.tbSubTotalVendas.TabIndex = 8
        '
        'DgvProdutosVenda
        '
        Me.DgvProdutosVenda.AllowUserToAddRows = False
        Me.DgvProdutosVenda.AllowUserToDeleteRows = False
        Me.DgvProdutosVenda.AllowUserToResizeColumns = False
        Me.DgvProdutosVenda.AllowUserToResizeRows = False
        Me.DgvProdutosVenda.BackgroundColor = System.Drawing.Color.White
        Me.DgvProdutosVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvProdutosVenda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column4, Me.Column5, Me.Column2})
        Me.DgvProdutosVenda.Enabled = False
        Me.DgvProdutosVenda.Location = New System.Drawing.Point(269, 118)
        Me.DgvProdutosVenda.Name = "DgvProdutosVenda"
        Me.DgvProdutosVenda.ShowEditingIcon = False
        Me.DgvProdutosVenda.Size = New System.Drawing.Size(352, 512)
        Me.DgvProdutosVenda.TabIndex = 2
        Me.DgvProdutosVenda.TabStop = False
        '
        'Column1
        '
        Me.Column1.FillWeight = 89.32039!
        Me.Column1.HeaderText = "Produto"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 80
        '
        'Column4
        '
        Me.Column4.FillWeight = 126.5421!
        Me.Column4.HeaderText = "Quantidade"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.FillWeight = 124.0068!
        Me.Column5.HeaderText = "Valor Total"
        Me.Column5.Name = "Column5"
        '
        'Column2
        '
        Me.Column2.FillWeight = 60.1307!
        Me.Column2.HeaderText = "X"
        Me.Column2.Name = "Column2"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Location = New System.Drawing.Point(82, 98)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 24)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Carrinho"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel2.Controls.Add(Me.X)
        Me.Panel2.Location = New System.Drawing.Point(261, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1188, 32)
        Me.Panel2.TabIndex = 84
        '
        'X
        '
        Me.X.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.X.FlatAppearance.BorderSize = 0
        Me.X.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed
        Me.X.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.X.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.X.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.X.ForeColor = System.Drawing.Color.White
        Me.X.Location = New System.Drawing.Point(1147, 2)
        Me.X.Margin = New System.Windows.Forms.Padding(0)
        Me.X.Name = "X"
        Me.X.Size = New System.Drawing.Size(30, 30)
        Me.X.TabIndex = 42
        Me.X.Text = "X"
        Me.X.UseVisualStyleBackColor = True
        '
        'PanelSelect
        '
        Me.PanelSelect.BackColor = System.Drawing.Color.White
        Me.PanelSelect.Location = New System.Drawing.Point(3, 694)
        Me.PanelSelect.Name = "PanelSelect"
        Me.PanelSelect.Size = New System.Drawing.Size(18, 53)
        Me.PanelSelect.TabIndex = 16
        Me.PanelSelect.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_Relatório)
        Me.Panel1.Controls.Add(Me.btn_Pesquisar)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.PanelSelect)
        Me.Panel1.Controls.Add(Me.btn_Nova)
        Me.Panel1.Controls.Add(Me.btn_Finalizar)
        Me.Panel1.Controls.Add(Me.btn_Cancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(263, 900)
        Me.Panel1.TabIndex = 83
        '
        'btn_Relatório
        '
        Me.btn_Relatório.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btn_Relatório.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Relatório.FlatAppearance.BorderSize = 0
        Me.btn_Relatório.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btn_Relatório.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btn_Relatório.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Relatório.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Relatório.ForeColor = System.Drawing.Color.White
        Me.btn_Relatório.Image = Global.LL_Construcoes.My.Resources.Resources.icons8_relatório_gráfico_24
        Me.btn_Relatório.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Relatório.Location = New System.Drawing.Point(24, 533)
        Me.btn_Relatório.Name = "btn_Relatório"
        Me.btn_Relatório.Size = New System.Drawing.Size(236, 53)
        Me.btn_Relatório.TabIndex = 20
        Me.btn_Relatório.Text = "        Relatório"
        Me.btn_Relatório.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Relatório.UseVisualStyleBackColor = False
        '
        'btn_Pesquisar
        '
        Me.btn_Pesquisar.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btn_Pesquisar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Pesquisar.FlatAppearance.BorderSize = 0
        Me.btn_Pesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btn_Pesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btn_Pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Pesquisar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Pesquisar.ForeColor = System.Drawing.Color.White
        Me.btn_Pesquisar.Image = Global.LL_Construcoes.My.Resources.Resources.icons8_pesquisar_24
        Me.btn_Pesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Pesquisar.Location = New System.Drawing.Point(24, 442)
        Me.btn_Pesquisar.Name = "btn_Pesquisar"
        Me.btn_Pesquisar.Size = New System.Drawing.Size(236, 53)
        Me.btn_Pesquisar.TabIndex = 19
        Me.btn_Pesquisar.Text = "        Pesquisar"
        Me.btn_Pesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Pesquisar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LL_Construcoes.My.Resources.Resources.icons8_carrinho_de_compras_80
        Me.PictureBox1.Location = New System.Drawing.Point(87, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'btn_Nova
        '
        Me.btn_Nova.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btn_Nova.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Nova.FlatAppearance.BorderSize = 0
        Me.btn_Nova.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btn_Nova.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btn_Nova.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Nova.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Nova.ForeColor = System.Drawing.Color.White
        Me.btn_Nova.Image = Global.LL_Construcoes.My.Resources.Resources.icons8_novo_por_cópia_24
        Me.btn_Nova.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Nova.Location = New System.Drawing.Point(27, 169)
        Me.btn_Nova.Name = "btn_Nova"
        Me.btn_Nova.Size = New System.Drawing.Size(236, 53)
        Me.btn_Nova.TabIndex = 9
        Me.btn_Nova.Text = "        Nova Venda"
        Me.btn_Nova.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Nova.UseVisualStyleBackColor = False
        '
        'btn_Finalizar
        '
        Me.btn_Finalizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btn_Finalizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Finalizar.FlatAppearance.BorderSize = 0
        Me.btn_Finalizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btn_Finalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btn_Finalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Finalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Finalizar.ForeColor = System.Drawing.Color.White
        Me.btn_Finalizar.Image = Global.LL_Construcoes.My.Resources.Resources.icons8_salvar_24
        Me.btn_Finalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Finalizar.Location = New System.Drawing.Point(27, 260)
        Me.btn_Finalizar.Name = "btn_Finalizar"
        Me.btn_Finalizar.Size = New System.Drawing.Size(236, 53)
        Me.btn_Finalizar.TabIndex = 10
        Me.btn_Finalizar.Text = "        Finalizar Venda"
        Me.btn_Finalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Finalizar.UseVisualStyleBackColor = False
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Cancelar.FlatAppearance.BorderSize = 0
        Me.btn_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btn_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancelar.ForeColor = System.Drawing.Color.White
        Me.btn_Cancelar.Image = Global.LL_Construcoes.My.Resources.Resources.icons8_excluir_24
        Me.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Cancelar.Location = New System.Drawing.Point(27, 351)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(236, 53)
        Me.btn_Cancelar.TabIndex = 11
        Me.btn_Cancelar.Text = "        Cancelar Venda"
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = False
        '
        'TextBoxIdVenda
        '
        Me.TextBoxIdVenda.Enabled = False
        Me.TextBoxIdVenda.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIdVenda.Location = New System.Drawing.Point(273, 654)
        Me.TextBoxIdVenda.Name = "TextBoxIdVenda"
        Me.TextBoxIdVenda.Size = New System.Drawing.Size(91, 26)
        Me.TextBoxIdVenda.TabIndex = 90
        Me.TextBoxIdVenda.Visible = False
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label83.Location = New System.Drawing.Point(269, 633)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(27, 22)
        Me.Label83.TabIndex = 89
        Me.Label83.Text = "Id"
        Me.Label83.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(269, 74)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(352, 34)
        Me.Panel3.TabIndex = 93
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 19)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "ITENS ADICIONADOS"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(1211, 74)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(194, 34)
        Me.Panel4.TabIndex = 95
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 18)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "TOTAL"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Location = New System.Drawing.Point(1211, 162)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(194, 34)
        Me.Panel5.TabIndex = 96
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 18)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "SUB TOTAL"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Location = New System.Drawing.Point(1211, 246)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(194, 34)
        Me.Panel6.TabIndex = 97
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 18)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "DESCONTO"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.ForestGreen
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Location = New System.Drawing.Point(1211, 335)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(194, 34)
        Me.Panel7.TabIndex = 98
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 18)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "TOTAL DA COMPRA"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Panel8.Controls.Add(Me.Label6)
        Me.Panel8.Location = New System.Drawing.Point(1211, 424)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(194, 34)
        Me.Panel8.TabIndex = 99
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 18)
        Me.Label6.TabIndex = 94
        Me.Label6.Text = "VALOR RECEBIDO"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.DarkRed
        Me.Panel9.Controls.Add(Me.Label7)
        Me.Panel9.Location = New System.Drawing.Point(1211, 513)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(194, 34)
        Me.Panel9.TabIndex = 100
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(3, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 18)
        Me.Label7.TabIndex = 94
        Me.Label7.Text = "TROCO"
        '
        'tbTotalCompra
        '
        Me.tbTotalCompra.Enabled = False
        Me.tbTotalCompra.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTotalCompra.Location = New System.Drawing.Point(1211, 375)
        Me.tbTotalCompra.Multiline = True
        Me.tbTotalCompra.Name = "tbTotalCompra"
        Me.tbTotalCompra.Size = New System.Drawing.Size(194, 43)
        Me.tbTotalCompra.TabIndex = 101
        '
        'tbValorReceb
        '
        Me.tbValorReceb.Enabled = False
        Me.tbValorReceb.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbValorReceb.Location = New System.Drawing.Point(1211, 464)
        Me.tbValorReceb.Multiline = True
        Me.tbValorReceb.Name = "tbValorReceb"
        Me.tbValorReceb.Size = New System.Drawing.Size(194, 43)
        Me.tbValorReceb.TabIndex = 102
        '
        'tbTroco
        '
        Me.tbTroco.Enabled = False
        Me.tbTroco.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTroco.Location = New System.Drawing.Point(1211, 555)
        Me.tbTroco.Multiline = True
        Me.tbTroco.Name = "tbTroco"
        Me.tbTroco.Size = New System.Drawing.Size(194, 43)
        Me.tbTroco.TabIndex = 103
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Panel10.Controls.Add(Me.Label8)
        Me.Panel10.Location = New System.Drawing.Point(1211, 603)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(194, 34)
        Me.Panel10.TabIndex = 101
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(3, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(185, 18)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "FORMA DE PAGAMENTO"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Panel11.Controls.Add(Me.Label9)
        Me.Panel11.Location = New System.Drawing.Point(635, 74)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(536, 34)
        Me.Panel11.TabIndex = 95
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(3, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(186, 19)
        Me.Label9.TabIndex = 94
        Me.Label9.Text = "CÓDIGO DO PRODUTO"
        '
        'tbCodProduto
        '
        Me.tbCodProduto.Enabled = False
        Me.tbCodProduto.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCodProduto.Location = New System.Drawing.Point(635, 118)
        Me.tbCodProduto.Multiline = True
        Me.tbCodProduto.Name = "tbCodProduto"
        Me.tbCodProduto.Size = New System.Drawing.Size(488, 43)
        Me.tbCodProduto.TabIndex = 104
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Panel12.Controls.Add(Me.Label11)
        Me.Panel12.Location = New System.Drawing.Point(635, 169)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(536, 34)
        Me.Panel12.TabIndex = 96
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(3, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 19)
        Me.Label11.TabIndex = 94
        Me.Label11.Text = "PRODUTO"
        '
        'tbProduto
        '
        Me.tbProduto.Enabled = False
        Me.tbProduto.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbProduto.Location = New System.Drawing.Point(635, 209)
        Me.tbProduto.Multiline = True
        Me.tbProduto.Name = "tbProduto"
        Me.tbProduto.Size = New System.Drawing.Size(536, 43)
        Me.tbProduto.TabIndex = 105
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Panel13.Controls.Add(Me.Label12)
        Me.Panel13.Location = New System.Drawing.Point(635, 258)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(536, 34)
        Me.Panel13.TabIndex = 97
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(3, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 19)
        Me.Label12.TabIndex = 94
        Me.Label12.Text = "CLIENTE"
        '
        'tbCliente
        '
        Me.tbCliente.Enabled = False
        Me.tbCliente.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCliente.Location = New System.Drawing.Point(635, 298)
        Me.tbCliente.Multiline = True
        Me.tbCliente.Name = "tbCliente"
        Me.tbCliente.Size = New System.Drawing.Size(488, 43)
        Me.tbCliente.TabIndex = 106
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Panel14.Controls.Add(Me.Label13)
        Me.Panel14.Location = New System.Drawing.Point(635, 351)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(163, 34)
        Me.Panel14.TabIndex = 98
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(3, 7)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(116, 19)
        Me.Label13.TabIndex = 94
        Me.Label13.Text = "QUANTIDADE"
        '
        'tbquantidade
        '
        Me.tbquantidade.Enabled = False
        Me.tbquantidade.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbquantidade.Location = New System.Drawing.Point(635, 391)
        Me.tbquantidade.Multiline = True
        Me.tbquantidade.Name = "tbquantidade"
        Me.tbquantidade.Size = New System.Drawing.Size(163, 43)
        Me.tbquantidade.TabIndex = 107
        '
        'tbPreco
        '
        Me.tbPreco.Enabled = False
        Me.tbPreco.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPreco.Location = New System.Drawing.Point(635, 482)
        Me.tbPreco.Multiline = True
        Me.tbPreco.Name = "tbPreco"
        Me.tbPreco.Size = New System.Drawing.Size(163, 43)
        Me.tbPreco.TabIndex = 109
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Panel15.Controls.Add(Me.Label14)
        Me.Panel15.Location = New System.Drawing.Point(635, 442)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(163, 34)
        Me.Panel15.TabIndex = 108
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(3, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(148, 19)
        Me.Label14.TabIndex = 94
        Me.Label14.Text = "PREÇO UNITÁRIO"
        '
        'tbestoque
        '
        Me.tbestoque.Enabled = False
        Me.tbestoque.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbestoque.Location = New System.Drawing.Point(635, 571)
        Me.tbestoque.Multiline = True
        Me.tbestoque.Name = "tbestoque"
        Me.tbestoque.Size = New System.Drawing.Size(163, 43)
        Me.tbestoque.TabIndex = 111
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Panel16.Controls.Add(Me.Label15)
        Me.Panel16.Location = New System.Drawing.Point(635, 531)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(163, 34)
        Me.Panel16.TabIndex = 110
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(3, 7)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 19)
        Me.Label15.TabIndex = 94
        Me.Label15.Text = "ESTOQUE"
        '
        'btnProcurarProd
        '
        Me.btnProcurarProd.BackColor = System.Drawing.Color.Transparent
        Me.btnProcurarProd.Enabled = False
        Me.btnProcurarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarProd.Image = CType(resources.GetObject("btnProcurarProd.Image"), System.Drawing.Image)
        Me.btnProcurarProd.Location = New System.Drawing.Point(1129, 118)
        Me.btnProcurarProd.Name = "btnProcurarProd"
        Me.btnProcurarProd.Size = New System.Drawing.Size(42, 43)
        Me.btnProcurarProd.TabIndex = 113
        Me.btnProcurarProd.UseVisualStyleBackColor = False
        '
        'PictureBoxProd
        '
        Me.PictureBoxProd.Location = New System.Drawing.Point(815, 352)
        Me.PictureBoxProd.Name = "PictureBoxProd"
        Me.PictureBoxProd.Size = New System.Drawing.Size(308, 262)
        Me.PictureBoxProd.TabIndex = 112
        Me.PictureBoxProd.TabStop = False
        '
        'btnCliente
        '
        Me.btnCliente.BackColor = System.Drawing.Color.Transparent
        Me.btnCliente.Enabled = False
        Me.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCliente.Image = CType(resources.GetObject("btnCliente.Image"), System.Drawing.Image)
        Me.btnCliente.Location = New System.Drawing.Point(1129, 298)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(42, 43)
        Me.btnCliente.TabIndex = 12
        Me.btnCliente.UseVisualStyleBackColor = False
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(273, 683)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(56, 13)
        Me.lblData.TabIndex = 114
        Me.lblData.Text = "LabelData"
        Me.lblData.Visible = False
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Location = New System.Drawing.Point(276, 716)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(56, 13)
        Me.lblHora.TabIndex = 115
        Me.lblHora.Text = "LabelHora"
        Me.lblHora.Visible = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(467, 673)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(54, 69)
        Me.ListBox1.TabIndex = 116
        '
        'frmCarrinho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1448, 900)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.btnProcurarProd)
        Me.Controls.Add(Me.PictureBoxProd)
        Me.Controls.Add(Me.tbestoque)
        Me.Controls.Add(Me.Panel16)
        Me.Controls.Add(Me.tbPreco)
        Me.Controls.Add(Me.Panel15)
        Me.Controls.Add(Me.tbquantidade)
        Me.Controls.Add(Me.Panel14)
        Me.Controls.Add(Me.tbCliente)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.tbProduto)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.tbCodProduto)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.tbTroco)
        Me.Controls.Add(Me.tbValorReceb)
        Me.Controls.Add(Me.tbTotalCompra)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.btnCliente)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.tbDescontoVenda)
        Me.Controls.Add(Me.tbTotalProd)
        Me.Controls.Add(Me.TextBoxIdVenda)
        Me.Controls.Add(Me.Label83)
        Me.Controls.Add(Me.cbFormaPagamentoVenda)
        Me.Controls.Add(Me.tbSubTotalVendas)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DgvProdutosVenda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmCarrinho"
        Me.Text = "FormCarrinho"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DgvProdutosVenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        CType(Me.PictureBoxProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCliente As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_Nova As Button
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents btn_Finalizar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents X As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelSelect As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBoxIdVenda As TextBox
    Friend WithEvents Label83 As Label
    Friend WithEvents tbDescontoVenda As TextBox
    Friend WithEvents tbTotalProd As TextBox
    Friend WithEvents cbFormaPagamentoVenda As ComboBox
    Friend WithEvents tbSubTotalVendas As TextBox
    Friend WithEvents DgvProdutosVenda As DataGridView
    Friend WithEvents btn_Relatório As Button
    Friend WithEvents btn_Pesquisar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents tbTotalCompra As TextBox
    Friend WithEvents tbValorReceb As TextBox
    Friend WithEvents tbTroco As TextBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents tbCodProduto As TextBox
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents tbProduto As TextBox
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents tbCliente As TextBox
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents tbquantidade As TextBox
    Friend WithEvents tbPreco As TextBox
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents tbestoque As TextBox
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents PictureBoxProd As PictureBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents btnProcurarProd As Button
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents lblData As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents ListBox1 As ListBox
End Class
