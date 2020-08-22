Imports System.Data.OleDb
Imports System.IO

Public Class frmPCliente
    Private Sub X_Click(sender As Object, e As EventArgs) Handles X.Click
        If MessageBox.Show("Deseja realmente sair?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
            Me.Close()
            frmCliente.Show()
        End If
    End Sub

    Private Sub listar()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As OleDbDataAdapter
            Dim sql As String

            sql = "SELECT * FROM Clientes ORDER By nome_Cliente ASC"
            da = New OleDbDataAdapter(sql, con)

            da.Fill(dt)
            dgv_cliente.DataSource = dt
            FormatarDG()
            ContarLinhas()
        Catch ex As Exception
            MsgBox(ex.Message)
            fechar()
        End Try
    End Sub

    Private Sub FormatarDG()

        dgv_cliente.Columns(0).Visible = False

        dgv_cliente.Columns(1).HeaderText = "Nome"
        dgv_cliente.Columns(2).HeaderText = "CPF"
        dgv_cliente.Columns(3).HeaderText = "RG"
        dgv_cliente.Columns(4).HeaderText = "Celular"
        dgv_cliente.Columns(5).HeaderText = "Telefone"
        dgv_cliente.Columns(6).HeaderText = "Data de Nascimento"
        dgv_cliente.Columns(7).HeaderText = "Email"
        dgv_cliente.Columns(8).HeaderText = "Logradouro"
        dgv_cliente.Columns(9).HeaderText = "Cidade"
        dgv_cliente.Columns(9).HeaderText = "Estado"
        dgv_cliente.Columns(9).HeaderText = "Complemento"
        dgv_cliente.Columns(9).HeaderText = "CEP"
        dgv_cliente.Columns(9).HeaderText = "Numero_Endereço"
        dgv_cliente.Columns(9).HeaderText = "Bairro"
    End Sub

    Private Sub ContarLinhas()
        Dim total As Integer = dgv_cliente.Rows.Count
        Label3.Text = total - 1
    End Sub

    Private Sub buscarnome()

        Try
            abrir()
            Dim dt As New DataTable
            Dim da As OleDbDataAdapter
            Dim sql As String

            sql = "SELECT * FROM Clientes WHERE nome_Cliente LIKE '" & mtb_procurar.Text & "%' ORDER BY nome_Cliente ASC"
            da = New OleDbDataAdapter(sql, con)

            da.Fill(dt)
            dgv_cliente.DataSource = dt
            FormatarDG()
            ContarLinhas()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BuscarCPF()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As OleDbDataAdapter
            Dim sql As String

            sql = "SELECT * FROM Clientes WHERE cpf_Cliente LIKE '" & mtb_procurar.Text & "%' ORDER BY nome_Cliente ASC"

            da = New OleDbDataAdapter(sql, con)

            da.Fill(dt)
            dgv_cliente.DataSource = dt
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

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        frmCliente.Show()
        Me.Close()
    End Sub

    Private Sub frmPCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbNome.Checked = True
        listar()
    End Sub

    Private Sub mtb_procurar_TextChanged(sender As Object, e As EventArgs) Handles mtb_procurar.TextChanged
        If rbNome.Checked = True Then
            buscarnome()
        End If

        If rbCPF.Checked = True Then
            BuscarCPF()
        End If

    End Sub

    Private Sub dgv_cliente_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgv_cliente.MouseDoubleClick
        Dim id As Integer
        Dim nome As String
        Dim cpf As String
        Dim rg As String
        Dim celular As String
        Dim telefone As String
        Dim data_nascimento As String
        Dim email As String
        Dim logradouro As String
        Dim cidade As String
        Dim estado As String
        Dim complemento As String
        Dim cep As String
        Dim numero As Integer
        Dim bairro As String

        id = dgv_cliente.CurrentRow.Cells(0).Value
        nome = dgv_cliente.CurrentRow.Cells(1).Value
        cpf = dgv_cliente.CurrentRow.Cells(2).Value
        rg = dgv_cliente.CurrentRow.Cells(3).Value
        celular = dgv_cliente.CurrentRow.Cells(4).Value
        telefone = dgv_cliente.CurrentRow.Cells(5).Value
        data_nascimento = dgv_cliente.CurrentRow.Cells(6).Value
        email = dgv_cliente.CurrentRow.Cells(7).Value
        logradouro = dgv_cliente.CurrentRow.Cells(8).Value
        cidade = dgv_cliente.CurrentRow.Cells(9).Value
        estado = dgv_cliente.CurrentRow.Cells(10).Value
        complemento = dgv_cliente.CurrentRow.Cells(11).Value
        cep = dgv_cliente.CurrentRow.Cells(12).Value
        numero = dgv_cliente.CurrentRow.Cells(13).Value
        bairro = dgv_cliente.CurrentRow.Cells(14).Value

        If id <> 0 Then
            Dim form = New frmCliente()

            nome_c = nome
            cpf_c = cpf
            rg_c = rg
            celular_c = celular
            telefone_c = telefone
            data_c = data_nascimento
            email_c = email
            logradouro_c = logradouro
            cidade_c = cidade
            estado_c = estado
            complemento_c = complemento
            cep_c = cep
            numero_c = numero
            bairro_c = bairro
            idcliente = id

            frmCliente.TextBoxIdCLI.Text = idcliente
            frmCliente.TextBoxNomeCLI.Text = nome_c
            frmCliente.MaskedTextBoxCPFCli.Text = cpf_c
            frmCliente.MaskedTextBoxRGCli.Text = rg_c
            frmCliente.MaskedTextBoxCEL1Cli.Text = celular_c
            frmCliente.MaskedTextBoxTEL1Cli.Text = telefone_c
            frmCliente.MaskedTextBoxNascimentoCli.Text = data_c
            frmCliente.TextBoxEMAILCLI.Text = email_c
            frmCliente.TextBoxLogradouroCLI.Text = logradouro_c
            frmCliente.TextBoxCidadeCLi.Text = cidade_c
            frmCliente.TextBoxUfCli.Text = estado_c
            frmCliente.TextBoxComplementoCli.Text = complemento_c
            frmCliente.MaskedTextBoxCEPCLI.Text = cep_c
            frmCliente.TextBoxNumCli.Text = numero_c
            frmCliente.TextBoxBairroCli.Text = bairro_c
            frmCliente.Show()
            id = dgv_cliente.CurrentRow().Cells(0).Value
            Me.Close()

        End If
    End Sub

    Private Sub btn_Ok_Click(sender As Object, e As EventArgs) Handles btn_Ok.Click
        Dim id As Integer
        Dim nome As String
        Dim cpf As String
        Dim rg As String
        Dim celular As String
        Dim telefone As String
        Dim data_nascimento As String
        Dim email As String
        Dim logradouro As String
        Dim cidade As String
        Dim estado As String
        Dim complemento As String
        Dim cep As String
        Dim numero As Integer
        Dim bairro As String

        id = dgv_cliente.CurrentRow.Cells(0).Value
        nome = dgv_cliente.CurrentRow.Cells(1).Value
        cpf = dgv_cliente.CurrentRow.Cells(2).Value
        rg = dgv_cliente.CurrentRow.Cells(3).Value
        celular = dgv_cliente.CurrentRow.Cells(4).Value
        telefone = dgv_cliente.CurrentRow.Cells(5).Value
        data_nascimento = dgv_cliente.CurrentRow.Cells(6).Value
        email = dgv_cliente.CurrentRow.Cells(7).Value
        logradouro = dgv_cliente.CurrentRow.Cells(8).Value
        cidade = dgv_cliente.CurrentRow.Cells(9).Value
        estado = dgv_cliente.CurrentRow.Cells(10).Value
        complemento = dgv_cliente.CurrentRow.Cells(11).Value
        cep = dgv_cliente.CurrentRow.Cells(12).Value
        numero = dgv_cliente.CurrentRow.Cells(13).Value
        bairro = dgv_cliente.CurrentRow.Cells(14).Value

        If id <> 0 Then
            Dim form = New frmCliente()

            nome_c = nome
            cpf_c = cpf
            rg_c = rg
            celular_c = celular
            telefone_c = telefone
            data_c = data_nascimento
            email_c = email
            logradouro_c = logradouro
            cidade_c = cidade
            estado_c = estado
            complemento_c = complemento
            cep_c = cep
            numero_c = numero
            bairro_c = bairro
            idcliente = id

            frmCliente.TextBoxIdCLI.Text = idcliente
            frmCliente.TextBoxNomeCLI.Text = nome_c
            frmCliente.MaskedTextBoxCPFCli.Text = cpf_c
            frmCliente.MaskedTextBoxRGCli.Text = rg_c
            frmCliente.MaskedTextBoxCEL1Cli.Text = celular_c
            frmCliente.MaskedTextBoxTEL1Cli.Text = telefone_c
            frmCliente.MaskedTextBoxNascimentoCli.Text = data_c
            frmCliente.TextBoxEMAILCLI.Text = email_c
            frmCliente.TextBoxLogradouroCLI.Text = logradouro_c
            frmCliente.TextBoxCidadeCLi.Text = cidade_c
            frmCliente.TextBoxUfCli.Text = estado_c
            frmCliente.TextBoxComplementoCli.Text = complemento_c
            frmCliente.MaskedTextBoxCEPCLI.Text = cep_c
            frmCliente.TextBoxNumCli.Text = numero_c
            frmCliente.TextBoxBairroCli.Text = bairro_c
            frmCliente.Show()
            id = dgv_cliente.CurrentRow().Cells(0).Value
            Me.Close()
        End If
    End Sub
End Class