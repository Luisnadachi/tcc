Imports System.Data.OleDb
Imports System.IO

Public Class frmPFunc
    Private Sub X_Click(sender As Object, e As EventArgs) Handles X.Click
        If MessageBox.Show("Deseja realmente sair?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
            Me.Close()
            frmFuncionario.Show()
        End If
    End Sub

    Private Sub listar()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As OleDbDataAdapter
            Dim sql As String

            sql = "SELECT * FROM Funcionarios ORDER By nome_Func ASC"
            da = New OleDbDataAdapter(sql, con)

            da.Fill(dt)
            dgv_func.DataSource = dt
            FormatarDG()
            ContarLinhas()
        Catch ex As Exception
            MsgBox(ex.Message)
            fechar()
        End Try
    End Sub

    Private Sub FormatarDG()
        dgv_func.Columns(0).Visible = False
        dgv_func.Columns(1).HeaderText = "Nome"
        dgv_func.Columns(2).HeaderText = "Data de Nascimento"
        dgv_func.Columns(3).HeaderText = "CPF"
        dgv_func.Columns(4).HeaderText = "RG"
        dgv_func.Columns(5).HeaderText = "Email"
        dgv_func.Columns(6).HeaderText = "Telefone"
        dgv_func.Columns(7).HeaderText = "Celular"
        dgv_func.Columns(8).HeaderText = "Usuário"
        dgv_func.Columns(9).HeaderText = "Senha"
        dgv_func.Columns(10).HeaderText = "Cargo"
        dgv_func.Columns(11).HeaderText = "Logradouro"
        dgv_func.Columns(12).HeaderText = "Número_Endereço"
        dgv_func.Columns(13).HeaderText = "Bairro"
        dgv_func.Columns(14).HeaderText = "Complemento"
        dgv_func.Columns(15).HeaderText = "CEP"
        dgv_func.Columns(16).HeaderText = "Cidade"
        dgv_func.Columns(17).HeaderText = "Estado"
        dgv_func.Columns(18).HeaderText = "Banco"
        dgv_func.Columns(19).HeaderText = "Agência"
        dgv_func.Columns(20).HeaderText = "Conta"
        dgv_func.Columns(21).HeaderText = "Operação"
        dgv_func.Columns(22).HeaderText = "Salario"
        dgv_func.Columns(23).HeaderText = "Vendas"
        dgv_func.Columns(24).HeaderText = "Foto"
    End Sub

    Private Sub ContarLinhas()
        Dim total As Integer = dgv_func.Rows.Count
        Label3.Text = total - 1
    End Sub

    Private Sub buscarnome()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As OleDbDataAdapter
            Dim sql As String

            sql = "SELECT * FROM Funcionarios WHERE nome_Func LIKE '" & mtb_procurar.Text & "%' ORDER BY nome_Func"
            da = New OleDbDataAdapter(sql, con)
            da.Fill(dt)
            dgv_func.DataSource = dt
            FormatarDG()
            ContarLinhas()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub buscarcpf()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As OleDbDataAdapter
            Dim sql As String

            sql = "SELECT * FROM Funcionarios WHERE cpf_Func LIKE '" & mtb_procurar.Text & "%' ORDER BY cpf_Func ASC"
            da = New OleDbDataAdapter(sql, con)
            da.Fill(dt)
            dgv_func.DataSource = dt
            FormatarDG()
            ContarLinhas()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rbCPF_CheckedChanged(sender As Object, e As EventArgs) Handles rbCPF.CheckedChanged
        Me.mtb_procurar.UseSystemPasswordChar = False
        Me.mtb_procurar.Mask = ""
        Me.mtb_procurar.Focus()
    End Sub

    Private Sub rbNome_CheckedChanged(sender As Object, e As EventArgs) Handles rbNome.CheckedChanged
        Me.mtb_procurar.UseSystemPasswordChar = False
        Me.mtb_procurar.Mask = ""
        Me.mtb_procurar.Focus()
    End Sub

    Private Sub frmPFunc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbNome.Checked = True
        listar()
    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        frmFuncionario.Show()
        Me.Close()
    End Sub

    Private Sub mtb_procurar_TextChanged(sender As Object, e As EventArgs) Handles mtb_procurar.TextChanged
        If rbNome.Checked = True Then
            buscarnome()
        End If

        If rbCPF.Checked = True Then
            buscarcpf()
        End If

    End Sub

    Private Sub dgv_func_DoubleClick(sender As Object, e As EventArgs) Handles dgv_func.DoubleClick
        Dim id As Integer
        Dim nome As String
        Dim data As String
        Dim cpf As String
        Dim rg As String
        Dim email As String
        Dim tel As String
        Dim cel As String
        Dim usuario As String
        Dim senha As String
        Dim cargo As String
        Dim logradouro As String
        Dim numEnd As String
        Dim bairro As String
        Dim complemento As String
        Dim cep As String
        Dim cidade As String
        Dim uf As String
        Dim banco As String
        Dim agencia As String
        Dim conta As String
        Dim operacao As String
        Dim salario As Double
        Dim vendas As String

        id = dgv_func.CurrentRow.Cells(0).Value
        nome = dgv_func.CurrentRow.Cells(1).Value
        data = dgv_func.CurrentRow.Cells(2).Value
        cpf = dgv_func.CurrentRow.Cells(3).Value
        rg = dgv_func.CurrentRow.Cells(4).Value
        email = dgv_func.CurrentRow.Cells(5).Value
        tel = dgv_func.CurrentRow.Cells(6).Value
        cel = dgv_func.CurrentRow.Cells(7).Value
        usuario = dgv_func.CurrentRow.Cells(8).Value
        senha = dgv_func.CurrentRow.Cells(9).Value
        cargo = dgv_func.CurrentRow.Cells(10).Value
        logradouro = dgv_func.CurrentRow.Cells(11).Value
        numEnd = dgv_func.CurrentRow.Cells(12).Value
        bairro = dgv_func.CurrentRow.Cells(13).Value
        complemento = dgv_func.CurrentRow.Cells(14).Value
        cep = dgv_func.CurrentRow.Cells(15).Value
        cidade = dgv_func.CurrentRow.Cells(16).Value
        uf = dgv_func.CurrentRow.Cells(17).Value
        banco = dgv_func.CurrentRow.Cells(18).Value
        agencia = dgv_func.CurrentRow.Cells(19).Value
        conta = dgv_func.CurrentRow.Cells(20).Value
        operacao = dgv_func.CurrentRow.Cells(21).Value
        salario = dgv_func.CurrentRow.Cells(22).Value
        vendas = dgv_func.CurrentRow.Cells(23).Value

        Dim img As Byte() = dgv_func.CurrentRow.Cells(24).Value
        Dim ms As MemoryStream = New MemoryStream(img)
        frmFuncionario.PictureBoxFunc.Image = System.Drawing.Image.FromStream(ms)
        frmFuncionario.PictureBoxFunc.SizeMode = PictureBoxSizeMode.StretchImage

        If id <> 0 Then
            Dim form = New frmFuncionario()

            nome_func = nome
            data_func = data
            cpf_func = cpf
            rg_func = rg
            email_func = email
            tel_func = tel
            cel_func = cel
            usuario_func = usuario
            senha_func = senha
            cargo_func = cargo
            logradouro_func = logradouro
            numEnd_func = numEnd
            bairro_func = bairro
            complemento_func = complemento
            cep_func = cep
            cidade_func = cidade
            uf_func = uf
            banco_func = banco
            agencia_func = agencia
            conta_func = conta
            operacao_func = operacao
            salario_func = salario
            vendas_func = vendas
            idfunc = id

            frmFuncionario.TextBoxIdFunc.Text = idfunc
            frmFuncionario.TextBoxNomeFunc.Text = nome_func
            frmFuncionario.MaskedTextBoxNascimentoFunc.Text = data_func
            frmFuncionario.MaskedTextBoxCPFFunc.Text = cpf_func
            frmFuncionario.MaskedTextBoxRGFunc.Text = rg_func
            frmFuncionario.TextBoxEMAILFunc.Text = email_func
            frmFuncionario.MaskedTextBoxTEL1Func.Text = tel_func
            frmFuncionario.MaskedTextBoxCEL1Func.Text = cel_func
            frmFuncionario.TextBoxLoginFunc.Text = usuario_func
            frmFuncionario.TextBoxSenhaFunc.Text = senha_func
            frmFuncionario.ComboBoxCargoFunc.Text = cargo_func
            frmFuncionario.TextBoxLogradouroFunc.Text = logradouro_func
            frmFuncionario.TextBoxNUmENDFunc.Text = numEnd_func
            frmFuncionario.TextBoxBairroFunc.Text = bairro_func
            frmFuncionario.TextBoxCompleFunc.Text = complemento_func
            frmFuncionario.MaskedTextBoxCEPFunc.Text = cep_func
            frmFuncionario.TextBoxCidadeFunc.Text = cidade_func
            frmFuncionario.TextBoxUFFunc.Text = uf_func
            frmFuncionario.ComboBoxBancoFunc.Text = banco_func
            frmFuncionario.TextBoxAgenciaFunc.Text = agencia_func
            frmFuncionario.TextBoxContaBancoFunc.Text = conta_func
            frmFuncionario.TextBoxOperacaoBancoFunc.Text = operacao_func
            frmFuncionario.TextBoxSalarioFunc.Text = FormatCurrency(salario_func)
            frmFuncionario.TextBoxVendasFunc.Text = vendas_func

            frmFuncionario.Show()
            id = dgv_func.CurrentRow.Cells(0).Value
            Me.Close()
        End If
    End Sub

    Private Sub btn_Ok_Click(sender As Object, e As EventArgs) Handles btn_Ok.Click
        Dim id As Integer
        Dim nome As String
        Dim data As String
        Dim cpf As String
        Dim rg As String
        Dim email As String
        Dim tel As String
        Dim cel As String
        Dim usuario As String
        Dim senha As String
        Dim cargo As String
        Dim logradouro As String
        Dim numEnd As String
        Dim bairro As String
        Dim complemento As String
        Dim cep As String
        Dim cidade As String
        Dim uf As String
        Dim banco As String
        Dim agencia As String
        Dim conta As String
        Dim operacao As String
        Dim salario As Double
        Dim vendas As String

        id = dgv_func.CurrentRow.Cells(0).Value
        nome = dgv_func.CurrentRow.Cells(1).Value
        data = dgv_func.CurrentRow.Cells(2).Value
        cpf = dgv_func.CurrentRow.Cells(3).Value
        rg = dgv_func.CurrentRow.Cells(4).Value
        email = dgv_func.CurrentRow.Cells(5).Value
        tel = dgv_func.CurrentRow.Cells(6).Value
        cel = dgv_func.CurrentRow.Cells(7).Value
        usuario = dgv_func.CurrentRow.Cells(8).Value
        senha = dgv_func.CurrentRow.Cells(9).Value
        cargo = dgv_func.CurrentRow.Cells(10).Value
        logradouro = dgv_func.CurrentRow.Cells(11).Value
        numEnd = dgv_func.CurrentRow.Cells(12).Value
        bairro = dgv_func.CurrentRow.Cells(13).Value
        complemento = dgv_func.CurrentRow.Cells(14).Value
        cep = dgv_func.CurrentRow.Cells(15).Value
        cidade = dgv_func.CurrentRow.Cells(16).Value
        uf = dgv_func.CurrentRow.Cells(17).Value
        banco = dgv_func.CurrentRow.Cells(18).Value
        agencia = dgv_func.CurrentRow.Cells(19).Value
        conta = dgv_func.CurrentRow.Cells(20).Value
        operacao = dgv_func.CurrentRow.Cells(21).Value
        salario = dgv_func.CurrentRow.Cells(22).Value
        vendas = dgv_func.CurrentRow.Cells(23).Value

        Dim img As Byte() = dgv_func.CurrentRow.Cells(24).Value
        Dim ms As MemoryStream = New MemoryStream(img)
        frmFuncionario.PictureBoxFunc.Image = System.Drawing.Image.FromStream(ms)
        frmFuncionario.PictureBoxFunc.SizeMode = PictureBoxSizeMode.StretchImage

        If id <> 0 Then
            Dim form = New frmFuncionario()

            nome_func = nome
            data_func = data
            cpf_func = cpf
            rg_func = rg
            email_func = email
            tel_func = tel
            cel_func = cel
            usuario_func = usuario
            senha_func = senha
            cargo_func = cargo
            logradouro_func = logradouro
            numEnd_func = numEnd
            bairro_func = bairro
            complemento_func = complemento
            cep_func = cep
            cidade_func = cidade
            uf_func = uf
            banco_func = banco
            agencia_func = agencia
            conta_func = conta
            operacao_func = operacao
            salario_func = salario
            vendas_func = vendas
            idfunc = id

            frmFuncionario.TextBoxIdFunc.Text = idfunc
            frmFuncionario.TextBoxNomeFunc.Text = nome_func
            frmFuncionario.MaskedTextBoxNascimentoFunc.Text = data_func
            frmFuncionario.MaskedTextBoxCPFFunc.Text = cpf_func
            frmFuncionario.MaskedTextBoxRGFunc.Text = rg_func
            frmFuncionario.TextBoxEMAILFunc.Text = email_func
            frmFuncionario.MaskedTextBoxTEL1Func.Text = tel_func
            frmFuncionario.MaskedTextBoxCEL1Func.Text = cel_func
            frmFuncionario.TextBoxLoginFunc.Text = usuario_func
            frmFuncionario.TextBoxSenhaFunc.Text = senha_func
            frmFuncionario.ComboBoxCargoFunc.Text = cargo_func
            frmFuncionario.TextBoxLogradouroFunc.Text = logradouro_func
            frmFuncionario.TextBoxNUmENDFunc.Text = numEnd_func
            frmFuncionario.TextBoxBairroFunc.Text = bairro_func
            frmFuncionario.TextBoxCompleFunc.Text = complemento_func
            frmFuncionario.MaskedTextBoxCEPFunc.Text = cep_func
            frmFuncionario.TextBoxCidadeFunc.Text = cidade_func
            frmFuncionario.TextBoxUFFunc.Text = uf_func
            frmFuncionario.ComboBoxBancoFunc.Text = banco_func
            frmFuncionario.TextBoxAgenciaFunc.Text = agencia_func
            frmFuncionario.TextBoxContaBancoFunc.Text = conta_func
            frmFuncionario.TextBoxOperacaoBancoFunc.Text = operacao_func
            frmFuncionario.TextBoxSalarioFunc.Text = FormatCurrency(salario_func)
            frmFuncionario.TextBoxVendasFunc.Text = vendas_func

            frmFuncionario.Show()
            id = dgv_func.CurrentRow.Cells(0).Value
            Me.Close()
        End If
    End Sub
End Class