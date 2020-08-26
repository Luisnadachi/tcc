<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFornecedores
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxBancoForn = New System.Windows.Forms.ComboBox()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.TextBoxOperacaoBancoForn = New System.Windows.Forms.TextBox()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.TextBoxContaBancoForn = New System.Windows.Forms.TextBox()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.TextBoxAgenciaForn = New System.Windows.Forms.TextBox()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.TextBoxEMAILForn = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.MaskedTextBoxTEL1Forn = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.X = New System.Windows.Forms.Button()
        Me.PanelSelect = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Atualizar = New System.Windows.Forms.Button()
        Me.btn_Relatório = New System.Windows.Forms.Button()
        Me.btn_Pesquisar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_Novo = New System.Windows.Forms.Button()
        Me.btn_Excluir = New System.Windows.Forms.Button()
        Me.btn_Salvar = New System.Windows.Forms.Button()
        Me.btn_Editar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBoxinformacaoForn = New System.Windows.Forms.TextBox()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.MaskedTextBoxCNPJForne = New System.Windows.Forms.MaskedTextBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.TextBoxNomeForne = New System.Windows.Forms.TextBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.MaskedTextBoxCEL1Forn = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBoxUfForn = New System.Windows.Forms.TextBox()
        Me.TextBoxCidadeForn = New System.Windows.Forms.TextBox()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.TextBoxCompleForn = New System.Windows.Forms.TextBox()
        Me.MaskedTextBoxCEPForn = New System.Windows.Forms.MaskedTextBox()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.TextBoxBairroForn = New System.Windows.Forms.TextBox()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.TextBoxNumForn = New System.Windows.Forms.TextBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.TextBoxLogradouroForn = New System.Windows.Forms.TextBox()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBoxIdForne = New System.Windows.Forms.TextBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ComboBoxBancoForn)
        Me.GroupBox4.Controls.Add(Me.Label77)
        Me.GroupBox4.Controls.Add(Me.TextBoxOperacaoBancoForn)
        Me.GroupBox4.Controls.Add(Me.Label76)
        Me.GroupBox4.Controls.Add(Me.TextBoxContaBancoForn)
        Me.GroupBox4.Controls.Add(Me.Label75)
        Me.GroupBox4.Controls.Add(Me.TextBoxAgenciaForn)
        Me.GroupBox4.Controls.Add(Me.Label74)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(926, 448)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(499, 242)
        Me.GroupBox4.TabIndex = 78
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Dados Bancários:"
        '
        'ComboBoxBancoForn
        '
        Me.ComboBoxBancoForn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBancoForn.Enabled = False
        Me.ComboBoxBancoForn.FormattingEnabled = True
        Me.ComboBoxBancoForn.Items.AddRange(New Object() {"Bradesco", "Caixa", "Itaú", "Santander"})
        Me.ComboBoxBancoForn.Location = New System.Drawing.Point(13, 53)
        Me.ComboBoxBancoForn.Name = "ComboBoxBancoForn"
        Me.ComboBoxBancoForn.Size = New System.Drawing.Size(148, 30)
        Me.ComboBoxBancoForn.TabIndex = 69
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Location = New System.Drawing.Point(13, 94)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(94, 22)
        Me.Label77.TabIndex = 67
        Me.Label77.Text = "Operação"
        '
        'TextBoxOperacaoBancoForn
        '
        Me.TextBoxOperacaoBancoForn.Enabled = False
        Me.TextBoxOperacaoBancoForn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxOperacaoBancoForn.Location = New System.Drawing.Point(13, 119)
        Me.TextBoxOperacaoBancoForn.Name = "TextBoxOperacaoBancoForn"
        Me.TextBoxOperacaoBancoForn.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxOperacaoBancoForn.TabIndex = 22
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Location = New System.Drawing.Point(299, 32)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(60, 22)
        Me.Label76.TabIndex = 63
        Me.Label76.Text = "Conta"
        '
        'TextBoxContaBancoForn
        '
        Me.TextBoxContaBancoForn.Enabled = False
        Me.TextBoxContaBancoForn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxContaBancoForn.Location = New System.Drawing.Point(297, 55)
        Me.TextBoxContaBancoForn.Name = "TextBoxContaBancoForn"
        Me.TextBoxContaBancoForn.Size = New System.Drawing.Size(148, 26)
        Me.TextBoxContaBancoForn.TabIndex = 21
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Location = New System.Drawing.Point(179, 32)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(79, 22)
        Me.Label75.TabIndex = 61
        Me.Label75.Text = "Agência"
        '
        'TextBoxAgenciaForn
        '
        Me.TextBoxAgenciaForn.Enabled = False
        Me.TextBoxAgenciaForn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAgenciaForn.Location = New System.Drawing.Point(179, 55)
        Me.TextBoxAgenciaForn.Name = "TextBoxAgenciaForn"
        Me.TextBoxAgenciaForn.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxAgenciaForn.TabIndex = 20
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Location = New System.Drawing.Point(13, 32)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(64, 22)
        Me.Label74.TabIndex = 59
        Me.Label74.Text = "Banco"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(6, 94)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(89, 22)
        Me.Label40.TabIndex = 46
        Me.Label40.Text = "Telefone "
        '
        'TextBoxEMAILForn
        '
        Me.TextBoxEMAILForn.Enabled = False
        Me.TextBoxEMAILForn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEMAILForn.Location = New System.Drawing.Point(6, 55)
        Me.TextBoxEMAILForn.Name = "TextBoxEMAILForn"
        Me.TextBoxEMAILForn.Size = New System.Drawing.Size(493, 26)
        Me.TextBoxEMAILForn.TabIndex = 9
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(6, 32)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(63, 22)
        Me.Label46.TabIndex = 44
        Me.Label46.Text = "E-mail"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(6, 155)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(74, 22)
        Me.Label37.TabIndex = 48
        Me.Label37.Text = "Celular "
        '
        'MaskedTextBoxTEL1Forn
        '
        Me.MaskedTextBoxTEL1Forn.Enabled = False
        Me.MaskedTextBoxTEL1Forn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBoxTEL1Forn.Location = New System.Drawing.Point(6, 119)
        Me.MaskedTextBoxTEL1Forn.Mask = "(99) 9999-9999"
        Me.MaskedTextBoxTEL1Forn.Name = "MaskedTextBoxTEL1Forn"
        Me.MaskedTextBoxTEL1Forn.Size = New System.Drawing.Size(121, 26)
        Me.MaskedTextBoxTEL1Forn.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Location = New System.Drawing.Point(57, 98)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(141, 24)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Fornecedores"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel2.Controls.Add(Me.X)
        Me.Panel2.Location = New System.Drawing.Point(261, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1188, 32)
        Me.Panel2.TabIndex = 75
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
        Me.Panel1.Controls.Add(Me.btn_Atualizar)
        Me.Panel1.Controls.Add(Me.btn_Relatório)
        Me.Panel1.Controls.Add(Me.btn_Pesquisar)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.PanelSelect)
        Me.Panel1.Controls.Add(Me.btn_Novo)
        Me.Panel1.Controls.Add(Me.btn_Excluir)
        Me.Panel1.Controls.Add(Me.btn_Salvar)
        Me.Panel1.Controls.Add(Me.btn_Editar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(263, 900)
        Me.Panel1.TabIndex = 74
        '
        'btn_Atualizar
        '
        Me.btn_Atualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btn_Atualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Atualizar.FlatAppearance.BorderSize = 0
        Me.btn_Atualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btn_Atualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btn_Atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Atualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Atualizar.ForeColor = System.Drawing.Color.White
        Me.btn_Atualizar.Image = Global.LL_Construcoes.My.Resources.Resources.icons8_17387_0_73139_atualizar_esquerda_32_setas_24
        Me.btn_Atualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Atualizar.Location = New System.Drawing.Point(27, 493)
        Me.btn_Atualizar.Name = "btn_Atualizar"
        Me.btn_Atualizar.Size = New System.Drawing.Size(236, 53)
        Me.btn_Atualizar.TabIndex = 20
        Me.btn_Atualizar.Text = "        Atualizar"
        Me.btn_Atualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Atualizar.UseVisualStyleBackColor = False
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
        Me.btn_Relatório.Location = New System.Drawing.Point(27, 655)
        Me.btn_Relatório.Name = "btn_Relatório"
        Me.btn_Relatório.Size = New System.Drawing.Size(236, 53)
        Me.btn_Relatório.TabIndex = 5
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
        Me.btn_Pesquisar.Location = New System.Drawing.Point(27, 574)
        Me.btn_Pesquisar.Name = "btn_Pesquisar"
        Me.btn_Pesquisar.Size = New System.Drawing.Size(236, 53)
        Me.btn_Pesquisar.TabIndex = 4
        Me.btn_Pesquisar.Text = "        Pesquisar"
        Me.btn_Pesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Pesquisar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LL_Construcoes.My.Resources.Resources.icons8_fornecedor_80__1_
        Me.PictureBox1.Location = New System.Drawing.Point(87, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'btn_Novo
        '
        Me.btn_Novo.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btn_Novo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Novo.FlatAppearance.BorderSize = 0
        Me.btn_Novo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btn_Novo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btn_Novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Novo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Novo.ForeColor = System.Drawing.Color.White
        Me.btn_Novo.Image = Global.LL_Construcoes.My.Resources.Resources.icons8_novo_por_cópia_24
        Me.btn_Novo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Novo.Location = New System.Drawing.Point(27, 169)
        Me.btn_Novo.Name = "btn_Novo"
        Me.btn_Novo.Size = New System.Drawing.Size(236, 53)
        Me.btn_Novo.TabIndex = 0
        Me.btn_Novo.Text = "        Novo"
        Me.btn_Novo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Novo.UseVisualStyleBackColor = False
        '
        'btn_Excluir
        '
        Me.btn_Excluir.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btn_Excluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Excluir.FlatAppearance.BorderSize = 0
        Me.btn_Excluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btn_Excluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btn_Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Excluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Excluir.ForeColor = System.Drawing.Color.White
        Me.btn_Excluir.Image = Global.LL_Construcoes.My.Resources.Resources.icons8_excluir_24
        Me.btn_Excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Excluir.Location = New System.Drawing.Point(27, 412)
        Me.btn_Excluir.Name = "btn_Excluir"
        Me.btn_Excluir.Size = New System.Drawing.Size(236, 53)
        Me.btn_Excluir.TabIndex = 3
        Me.btn_Excluir.Text = "        Excluir"
        Me.btn_Excluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Excluir.UseVisualStyleBackColor = False
        '
        'btn_Salvar
        '
        Me.btn_Salvar.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btn_Salvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Salvar.FlatAppearance.BorderSize = 0
        Me.btn_Salvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btn_Salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btn_Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Salvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Salvar.ForeColor = System.Drawing.Color.White
        Me.btn_Salvar.Image = Global.LL_Construcoes.My.Resources.Resources.icons8_salvar_24
        Me.btn_Salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Salvar.Location = New System.Drawing.Point(27, 250)
        Me.btn_Salvar.Name = "btn_Salvar"
        Me.btn_Salvar.Size = New System.Drawing.Size(236, 53)
        Me.btn_Salvar.TabIndex = 1
        Me.btn_Salvar.Text = "        Salvar"
        Me.btn_Salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Salvar.UseVisualStyleBackColor = False
        '
        'btn_Editar
        '
        Me.btn_Editar.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btn_Editar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Editar.FlatAppearance.BorderSize = 0
        Me.btn_Editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btn_Editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Editar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Editar.ForeColor = System.Drawing.Color.White
        Me.btn_Editar.Image = Global.LL_Construcoes.My.Resources.Resources.icons8_editar_24
        Me.btn_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Editar.Location = New System.Drawing.Point(27, 331)
        Me.btn_Editar.Name = "btn_Editar"
        Me.btn_Editar.Size = New System.Drawing.Size(236, 53)
        Me.btn_Editar.TabIndex = 2
        Me.btn_Editar.Text = "        Editar"
        Me.btn_Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Editar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxinformacaoForn)
        Me.GroupBox1.Controls.Add(Me.Label70)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBoxCNPJForne)
        Me.GroupBox1.Controls.Add(Me.Label59)
        Me.GroupBox1.Controls.Add(Me.TextBoxNomeForne)
        Me.GroupBox1.Controls.Add(Me.Label58)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(286, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(618, 321)
        Me.GroupBox1.TabIndex = 76
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados Pessoais:"
        '
        'TextBoxinformacaoForn
        '
        Me.TextBoxinformacaoForn.Enabled = False
        Me.TextBoxinformacaoForn.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.TextBoxinformacaoForn.Location = New System.Drawing.Point(8, 179)
        Me.TextBoxinformacaoForn.Multiline = True
        Me.TextBoxinformacaoForn.Name = "TextBoxinformacaoForn"
        Me.TextBoxinformacaoForn.Size = New System.Drawing.Size(456, 108)
        Me.TextBoxinformacaoForn.TabIndex = 8
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Location = New System.Drawing.Point(8, 157)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(208, 22)
        Me.Label70.TabIndex = 31
        Me.Label70.Text = "Informações Adicionais"
        '
        'MaskedTextBoxCNPJForne
        '
        Me.MaskedTextBoxCNPJForne.Enabled = False
        Me.MaskedTextBoxCNPJForne.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBoxCNPJForne.Location = New System.Drawing.Point(8, 118)
        Me.MaskedTextBoxCNPJForne.Mask = "99,999,999/9999-99"
        Me.MaskedTextBoxCNPJForne.Name = "MaskedTextBoxCNPJForne"
        Me.MaskedTextBoxCNPJForne.Size = New System.Drawing.Size(152, 26)
        Me.MaskedTextBoxCNPJForne.TabIndex = 7
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(8, 93)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(60, 22)
        Me.Label59.TabIndex = 18
        Me.Label59.Text = "CNPJ"
        '
        'TextBoxNomeForne
        '
        Me.TextBoxNomeForne.Enabled = False
        Me.TextBoxNomeForne.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNomeForne.Location = New System.Drawing.Point(8, 48)
        Me.TextBoxNomeForne.Name = "TextBoxNomeForne"
        Me.TextBoxNomeForne.Size = New System.Drawing.Size(378, 26)
        Me.TextBoxNomeForne.TabIndex = 6
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(8, 26)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(61, 22)
        Me.Label58.TabIndex = 16
        Me.Label58.Text = "Nome"
        '
        'MaskedTextBoxCEL1Forn
        '
        Me.MaskedTextBoxCEL1Forn.Enabled = False
        Me.MaskedTextBoxCEL1Forn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBoxCEL1Forn.Location = New System.Drawing.Point(6, 177)
        Me.MaskedTextBoxCEL1Forn.Mask = "(99) 9 9999-9999"
        Me.MaskedTextBoxCEL1Forn.Name = "MaskedTextBoxCEL1Forn"
        Me.MaskedTextBoxCEL1Forn.Size = New System.Drawing.Size(134, 26)
        Me.MaskedTextBoxCEL1Forn.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBoxUfForn)
        Me.GroupBox2.Controls.Add(Me.TextBoxCidadeForn)
        Me.GroupBox2.Controls.Add(Me.Label65)
        Me.GroupBox2.Controls.Add(Me.Label64)
        Me.GroupBox2.Controls.Add(Me.TextBoxCompleForn)
        Me.GroupBox2.Controls.Add(Me.MaskedTextBoxCEPForn)
        Me.GroupBox2.Controls.Add(Me.Label67)
        Me.GroupBox2.Controls.Add(Me.Label62)
        Me.GroupBox2.Controls.Add(Me.TextBoxBairroForn)
        Me.GroupBox2.Controls.Add(Me.Label66)
        Me.GroupBox2.Controls.Add(Me.TextBoxNumForn)
        Me.GroupBox2.Controls.Add(Me.Label68)
        Me.GroupBox2.Controls.Add(Me.TextBoxLogradouroForn)
        Me.GroupBox2.Controls.Add(Me.Label63)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(926, 121)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(499, 321)
        Me.GroupBox2.TabIndex = 77
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Endereço:"
        '
        'TextBoxUfForn
        '
        Me.TextBoxUfForn.Enabled = False
        Me.TextBoxUfForn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUfForn.Location = New System.Drawing.Point(305, 242)
        Me.TextBoxUfForn.Name = "TextBoxUfForn"
        Me.TextBoxUfForn.Size = New System.Drawing.Size(152, 26)
        Me.TextBoxUfForn.TabIndex = 18
        '
        'TextBoxCidadeForn
        '
        Me.TextBoxCidadeForn.Enabled = False
        Me.TextBoxCidadeForn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCidadeForn.Location = New System.Drawing.Point(26, 242)
        Me.TextBoxCidadeForn.Name = "TextBoxCidadeForn"
        Me.TextBoxCidadeForn.Size = New System.Drawing.Size(153, 26)
        Me.TextBoxCidadeForn.TabIndex = 17
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Location = New System.Drawing.Point(26, 221)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(71, 22)
        Me.Label65.TabIndex = 32
        Me.Label65.Text = "Cidade"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Location = New System.Drawing.Point(305, 221)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(70, 22)
        Me.Label64.TabIndex = 31
        Me.Label64.Text = "Estado"
        '
        'TextBoxCompleForn
        '
        Me.TextBoxCompleForn.Enabled = False
        Me.TextBoxCompleForn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCompleForn.Location = New System.Drawing.Point(26, 179)
        Me.TextBoxCompleForn.Name = "TextBoxCompleForn"
        Me.TextBoxCompleForn.Size = New System.Drawing.Size(152, 26)
        Me.TextBoxCompleForn.TabIndex = 15
        '
        'MaskedTextBoxCEPForn
        '
        Me.MaskedTextBoxCEPForn.Enabled = False
        Me.MaskedTextBoxCEPForn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBoxCEPForn.Location = New System.Drawing.Point(305, 180)
        Me.MaskedTextBoxCEPForn.Mask = "99999-999"
        Me.MaskedTextBoxCEPForn.Name = "MaskedTextBoxCEPForn"
        Me.MaskedTextBoxCEPForn.Size = New System.Drawing.Size(95, 26)
        Me.MaskedTextBoxCEPForn.TabIndex = 16
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(26, 157)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(130, 22)
        Me.Label67.TabIndex = 28
        Me.Label67.Text = "Complemento"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(305, 157)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(50, 22)
        Me.Label62.TabIndex = 27
        Me.Label62.Text = "CEP"
        '
        'TextBoxBairroForn
        '
        Me.TextBoxBairroForn.Enabled = False
        Me.TextBoxBairroForn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBairroForn.Location = New System.Drawing.Point(305, 118)
        Me.TextBoxBairroForn.Name = "TextBoxBairroForn"
        Me.TextBoxBairroForn.Size = New System.Drawing.Size(152, 26)
        Me.TextBoxBairroForn.TabIndex = 14
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(305, 93)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(60, 22)
        Me.Label66.TabIndex = 25
        Me.Label66.Text = "Bairro"
        '
        'TextBoxNumForn
        '
        Me.TextBoxNumForn.Enabled = False
        Me.TextBoxNumForn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNumForn.Location = New System.Drawing.Point(26, 118)
        Me.TextBoxNumForn.Name = "TextBoxNumForn"
        Me.TextBoxNumForn.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxNumForn.TabIndex = 13
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Location = New System.Drawing.Point(26, 93)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(77, 22)
        Me.Label68.TabIndex = 23
        Me.Label68.Text = "Número"
        '
        'TextBoxLogradouroForn
        '
        Me.TextBoxLogradouroForn.Enabled = False
        Me.TextBoxLogradouroForn.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.TextBoxLogradouroForn.Location = New System.Drawing.Point(26, 47)
        Me.TextBoxLogradouroForn.Name = "TextBoxLogradouroForn"
        Me.TextBoxLogradouroForn.Size = New System.Drawing.Size(431, 26)
        Me.TextBoxLogradouroForn.TabIndex = 12
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(26, 25)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(108, 22)
        Me.Label63.TabIndex = 21
        Me.Label63.Text = "Logradouro"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.MaskedTextBoxCEL1Forn)
        Me.GroupBox3.Controls.Add(Me.Label37)
        Me.GroupBox3.Controls.Add(Me.MaskedTextBoxTEL1Forn)
        Me.GroupBox3.Controls.Add(Me.Label40)
        Me.GroupBox3.Controls.Add(Me.TextBoxEMAILForn)
        Me.GroupBox3.Controls.Add(Me.Label46)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(294, 455)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(618, 235)
        Me.GroupBox3.TabIndex = 79
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Contato:"
        '
        'TextBoxIdForne
        '
        Me.TextBoxIdForne.Enabled = False
        Me.TextBoxIdForne.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIdForne.Location = New System.Drawing.Point(288, 80)
        Me.TextBoxIdForne.Name = "TextBoxIdForne"
        Me.TextBoxIdForne.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxIdForne.TabIndex = 82
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.Location = New System.Drawing.Point(288, 55)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(27, 22)
        Me.Label57.TabIndex = 81
        Me.Label57.Text = "Id"
        '
        'frmFornecedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1448, 900)
        Me.Controls.Add(Me.TextBoxIdForne)
        Me.Controls.Add(Me.Label57)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmFornecedores"
        Me.Text = "FormFornecedores"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label77 As Label
    Friend WithEvents TextBoxOperacaoBancoForn As TextBox
    Friend WithEvents Label76 As Label
    Friend WithEvents TextBoxContaBancoForn As TextBox
    Friend WithEvents Label75 As Label
    Friend WithEvents TextBoxAgenciaForn As TextBox
    Friend WithEvents Label74 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents TextBoxEMAILForn As TextBox
    Friend WithEvents Label46 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents MaskedTextBoxTEL1Forn As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents X As Button
    Friend WithEvents PanelSelect As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MaskedTextBoxCEL1Forn As MaskedTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents MaskedTextBoxCNPJForne As MaskedTextBox
    Friend WithEvents Label59 As Label
    Friend WithEvents TextBoxNomeForne As TextBox
    Friend WithEvents Label58 As Label
    Friend WithEvents TextBoxLogradouroForn As TextBox
    Friend WithEvents Label63 As Label
    Friend WithEvents TextBoxIdForne As TextBox
    Friend WithEvents Label57 As Label
    Friend WithEvents TextBoxBairroForn As TextBox
    Friend WithEvents Label66 As Label
    Friend WithEvents TextBoxNumForn As TextBox
    Friend WithEvents Label68 As Label
    Friend WithEvents TextBoxCompleForn As TextBox
    Friend WithEvents MaskedTextBoxCEPForn As MaskedTextBox
    Friend WithEvents Label67 As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents TextBoxUfForn As TextBox
    Friend WithEvents TextBoxCidadeForn As TextBox
    Friend WithEvents Label65 As Label
    Friend WithEvents Label64 As Label
    Friend WithEvents TextBoxinformacaoForn As TextBox
    Friend WithEvents Label70 As Label
    Friend WithEvents btn_Novo As Button
    Friend WithEvents btn_Excluir As Button
    Friend WithEvents btn_Salvar As Button
    Friend WithEvents btn_Editar As Button
    Friend WithEvents btn_Relatório As Button
    Friend WithEvents btn_Pesquisar As Button
    Friend WithEvents btn_Atualizar As Button
    Friend WithEvents ComboBoxBancoForn As ComboBox
End Class
