Imports System.Data.OleDb
Imports System.IO

Public Class frmPFornec
    Private Sub X_Click(sender As Object, e As EventArgs) Handles X.Click
        If MessageBox.Show("Deseja realmente sair?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
            Me.Close()
            frmFornecedores.Show()
        End If
    End Sub

    Private Sub listar()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As OleDbDataAdapter
            Dim sql As String

            sql = "SELECT * FROM Fornecedores ORDER By nome_Fornec ASC"
            da = New OleDbDataAdapter(sql, con)

            da.Fill(dt)
            dgv_fornec.DataSource = dt
            FormatarDG()
            ContarLinhas()
        Catch ex As Exception
            MsgBox(ex.Message)
            fechar()
        End Try
    End Sub

    Private Sub FormatarDG()
        dgv_fornec.Columns(0).Visible = False
        dgv_fornec.Columns(1).HeaderText = "Nome"
        dgv_fornec.Columns(2).HeaderText = "CNPJ"
        dgv_fornec.Columns(3).HeaderText = "Informações adicionais"
        dgv_fornec.Columns(4).HeaderText = "Email"
        dgv_fornec.Columns(5).HeaderText = "Celular"
        dgv_fornec.Columns(6).HeaderText = "Telefone"
        dgv_fornec.Columns(7).HeaderText = "Logradouro"
        dgv_fornec.Columns(8).HeaderText = "Número_Endereço"
        dgv_fornec.Columns(9).HeaderText = "Bairro"
        dgv_fornec.Columns(9).HeaderText = "Complemento"
        dgv_fornec.Columns(9).HeaderText = "CEP"
        dgv_fornec.Columns(9).HeaderText = "Cidade"
        dgv_fornec.Columns(9).HeaderText = "Estado"
        dgv_fornec.Columns(10).HeaderText = "Banco"
        dgv_fornec.Columns(11).HeaderText = "Agência"
        dgv_fornec.Columns(12).HeaderText = "Conta"
        dgv_fornec.Columns(13).HeaderText = "Operação"
    End Sub

    Private Sub ContarLinhas()
        Dim total As Integer = dgv_fornec.Rows.Count
        Label3.Text = total - 1
    End Sub

    Private Sub buscarnome()

        Try
            abrir()
            Dim dt As New DataTable
            Dim da As OleDbDataAdapter
            Dim sql As String

            sql = "SELECT * FROM Fornecedores WHERE nome_Fornec LIKE '" & mtb_procurar.Text & "%' ORDER BY nome_Fornec ASC"
            da = New OleDbDataAdapter(sql, con)

            da.Fill(dt)
            dgv_fornec.DataSource = dt
            FormatarDG()
            ContarLinhas()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BuscarCNPJ()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As OleDbDataAdapter
            Dim sql As String

            sql = "SELECT * FROM Fornecedores WHERE cnpj_Fornec LIKE '" & mtb_procurar.Text & "%' ORDER BY nome_Fornec ASC"

            da = New OleDbDataAdapter(sql, con)

            da.Fill(dt)
            dgv_fornec.DataSource = dt
            FormatarDG()
            ContarLinhas()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub rbNome_CheckedChanged(sender As Object, e As EventArgs) Handles rbNome.CheckedChanged
        Me.mtb_procurar.UseSystemPasswordChar = False
        Me.mtb_procurar.Mask = ""
        Me.mtb_procurar.Focus()
    End Sub

    Private Sub rbCNPJ_CheckedChanged(sender As Object, e As EventArgs) Handles rbCNPJ.CheckedChanged
        Me.mtb_procurar.UseSystemPasswordChar = False
        Me.mtb_procurar.Mask = ""
        Me.mtb_procurar.Focus()
    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        frmFornecedores.Show()
        Me.Close()
    End Sub

    Private Sub frmPFornec_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbNome.Checked = True
        listar()
    End Sub

    Private Sub mtb_procurar_TextChanged(sender As Object, e As EventArgs) Handles mtb_procurar.TextChanged
        If rbNome.Checked = True Then
            buscarnome()
        End If

        If rbCNPJ.Checked = True Then
            BuscarCNPJ()
        End If

    End Sub

    Private Sub dgv_fornec_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgv_fornec.MouseDoubleClick

        Dim id As Integer
        Dim nome As String
        Dim cnpj As String
        Dim infoad As String
        Dim email As String
        Dim celular As String
        Dim telefone As String
        Dim logradouro As String
        Dim numero As Integer
        Dim bairro As String
        Dim complemento As String
        Dim cep As String
        Dim cidade As String
        Dim estado As String
        Dim banco As String
        Dim agencia As String
        Dim conta As String
        Dim operacao As String


        id = dgv_fornec.CurrentRow.Cells(0).Value
        nome = dgv_fornec.CurrentRow.Cells(1).Value
        cnpj = dgv_fornec.CurrentRow.Cells(2).Value
        infoad = dgv_fornec.CurrentRow.Cells(3).Value
        email = dgv_fornec.CurrentRow.Cells(4).Value
        celular = dgv_fornec.CurrentRow.Cells(5).Value
        telefone = dgv_fornec.CurrentRow.Cells(6).Value
        logradouro = dgv_fornec.CurrentRow.Cells(7).Value
        numero = dgv_fornec.CurrentRow.Cells(8).Value
        bairro = dgv_fornec.CurrentRow.Cells(9).Value
        complemento = dgv_fornec.CurrentRow.Cells(10).Value
        cep = dgv_fornec.CurrentRow.Cells(11).Value
        cidade = dgv_fornec.CurrentRow.Cells(12).Value
        estado = dgv_fornec.CurrentRow.Cells(13).Value
        banco = dgv_fornec.CurrentRow.Cells(14).Value
        agencia = dgv_fornec.CurrentRow.Cells(15).Value
        conta = dgv_fornec.CurrentRow.Cells(16).Value
        operacao = dgv_fornec.CurrentRow.Cells(17).Value

        If id <> 0 Then
            Dim form = New frmFornecedores()

            idfornec = id
            nome_f = nome
            cnpj_f = cnpj
            infoad_f = infoad
            email_f = email
            celular_f = celular
            telefone_f = telefone
            logradouro_f = logradouro
            numero_f = numero
            bairro_f = bairro
            complemento_f = complemento
            cep_f = cep
            cidade_f = cidade
            estado_f = estado
            banco_f = banco
            agencia_f = agencia
            conta_f = conta
            operacao_f = operacao

            frmFornecedores.TextBoxIdForne.Text = idfornec
            frmFornecedores.TextBoxNomeForne.Text = nome_f
            frmFornecedores.MaskedTextBoxCNPJForne.Text = cnpj_f
            frmFornecedores.TextBoxinformacaoForn.Text = infoad_f
            frmFornecedores.TextBoxEMAILForn.Text = email_f
            frmFornecedores.MaskedTextBoxCEL1Forn.Text = celular_f
            frmFornecedores.MaskedTextBoxTEL1Forn.Text = telefone_f
            frmFornecedores.TextBoxLogradouroForn.Text = logradouro_f
            frmFornecedores.TextBoxNumForn.Text = numero_f
            frmFornecedores.TextBoxBairroForn.Text = bairro_f
            frmFornecedores.TextBoxCompleForn.Text = complemento_f
            frmFornecedores.MaskedTextBoxCEPForn.Text = cep_f
            frmFornecedores.TextBoxCidadeForn.Text = cidade_f
            frmFornecedores.ComboBoxUF.Text = estado_f
            frmFornecedores.ComboBoxBancoForn.Text = banco_f
            frmFornecedores.TextBoxAgenciaForn.Text = agencia_f
            frmFornecedores.TextBoxContaBancoForn.Text = conta_f
            frmFornecedores.TextBoxOperacaoBancoForn.Text = operacao_f

            frmFornecedores.Show()
            id = dgv_fornec.CurrentRow().Cells(0).Value
            Me.Close()
        End If
    End Sub

    Private Sub btn_Ok_Click(sender As Object, e As EventArgs) Handles btn_Ok.Click

        Dim id As Integer
        Dim nome As String
        Dim cnpj As String
        Dim infoad As String
        Dim email As String
        Dim celular As String
        Dim telefone As String
        Dim logradouro As String
        Dim numero As Integer
        Dim bairro As String
        Dim complemento As String
        Dim cep As String
        Dim cidade As String
        Dim estado As String
        Dim banco As String
        Dim agencia As String
        Dim conta As String
        Dim operacao As String


        id = dgv_fornec.CurrentRow.Cells(0).Value
        nome = dgv_fornec.CurrentRow.Cells(1).Value
        cnpj = dgv_fornec.CurrentRow.Cells(2).Value
        infoad = dgv_fornec.CurrentRow.Cells(3).Value
        email = dgv_fornec.CurrentRow.Cells(4).Value
        celular = dgv_fornec.CurrentRow.Cells(5).Value
        telefone = dgv_fornec.CurrentRow.Cells(6).Value
        logradouro = dgv_fornec.CurrentRow.Cells(7).Value
        numero = dgv_fornec.CurrentRow.Cells(8).Value
        bairro = dgv_fornec.CurrentRow.Cells(9).Value
        complemento = dgv_fornec.CurrentRow.Cells(10).Value
        cep = dgv_fornec.CurrentRow.Cells(11).Value
        cidade = dgv_fornec.CurrentRow.Cells(12).Value
        estado = dgv_fornec.CurrentRow.Cells(13).Value
        banco = dgv_fornec.CurrentRow.Cells(14).Value
        agencia = dgv_fornec.CurrentRow.Cells(15).Value
        conta = dgv_fornec.CurrentRow.Cells(16).Value
        operacao = dgv_fornec.CurrentRow.Cells(17).Value

        If id <> 0 Then
            Dim form = New frmFornecedores()

            idfornec = id
            nome_f = nome
            cnpj_f = cnpj
            infoad_f = infoad
            email_f = email
            celular_f = celular
            telefone_f = telefone
            logradouro_f = logradouro
            numero_f = numero
            bairro_f = bairro
            complemento_f = complemento
            cep_f = cep
            cidade_f = cidade
            estado_f = estado
            banco_f = banco
            agencia_f = agencia
            conta_f = conta
            operacao_f = operacao

            frmFornecedores.TextBoxIdForne.Text = idfornec
            frmFornecedores.TextBoxNomeForne.Text = nome_f
            frmFornecedores.MaskedTextBoxCNPJForne.Text = cnpj_f
            frmFornecedores.TextBoxinformacaoForn.Text = infoad_f
            frmFornecedores.TextBoxEMAILForn.Text = email_f
            frmFornecedores.MaskedTextBoxCEL1Forn.Text = celular_f
            frmFornecedores.MaskedTextBoxTEL1Forn.Text = telefone_f
            frmFornecedores.TextBoxLogradouroForn.Text = logradouro_f
            frmFornecedores.TextBoxNumForn.Text = numero_f
            frmFornecedores.TextBoxBairroForn.Text = bairro_f
            frmFornecedores.TextBoxCompleForn.Text = complemento_f
            frmFornecedores.MaskedTextBoxCEPForn.Text = cep_f
            frmFornecedores.TextBoxCidadeForn.Text = cidade_f
            frmFornecedores.ComboBoxUF.Text = estado_f
            frmFornecedores.ComboBoxBancoForn.Text = banco_f
            frmFornecedores.TextBoxAgenciaForn.Text = agencia_f
            frmFornecedores.TextBoxContaBancoForn.Text = conta_f
            frmFornecedores.TextBoxOperacaoBancoForn.Text = operacao_f

            frmFornecedores.Show()
            id = dgv_fornec.CurrentRow().Cells(0).Value
            Me.Close()
        End If
    End Sub
End Class