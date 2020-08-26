Imports System.Data.OleDb
Imports System.IO

Public Class frmCliente

    Sub habilitar()
        TextBoxNomeCLI.Enabled = True
        MaskedTextBoxNascimentoCli.Enabled = True
        MaskedTextBoxCPFCli.Enabled = True
        MaskedTextBoxRGCli.Enabled = True
        TextBoxEMAILCLI.Enabled = True
        MaskedTextBoxTEL1Cli.Enabled = True
        MaskedTextBoxCEL1Cli.Enabled = True
        TextBoxLogradouroCLI.Enabled = True
        TextBoxNumCli.Enabled = True
        TextBoxBairroCli.Enabled = True
        TextBoxComplementoCli.Enabled = True
        MaskedTextBoxCEPCLI.Enabled = True
        TextBoxCidadeCLi.Enabled = True
        ComboBoxUF.Enabled = True
    End Sub

    Sub desabilitar()
        TextBoxNomeCLI.Enabled = False
        MaskedTextBoxNascimentoCli.Enabled = False
        MaskedTextBoxCPFCli.Enabled = False
        MaskedTextBoxRGCli.Enabled = False
        TextBoxEMAILCLI.Enabled = False
        MaskedTextBoxTEL1Cli.Enabled = False
        MaskedTextBoxCEL1Cli.Enabled = False
        TextBoxLogradouroCLI.Enabled = False
        TextBoxNumCli.Enabled = False
        TextBoxBairroCli.Enabled = False
        TextBoxComplementoCli.Enabled = False
        MaskedTextBoxCEPCLI.Enabled = False
        TextBoxCidadeCLi.Enabled = False
        ComboBoxUF.Enabled = False
    End Sub

    Sub limpar()
        TextBoxNomeCLI.Text = ""
        MaskedTextBoxNascimentoCli.Text = ""
        MaskedTextBoxRGCli.Text = ""
        MaskedTextBoxCPFCli.Text = ""
        TextBoxEMAILCLI.Text = ""
        MaskedTextBoxTEL1Cli.Text = ""
        MaskedTextBoxCEL1Cli.Text = ""
        TextBoxLogradouroCLI.Text = ""
        TextBoxNumCli.Text = ""
        TextBoxBairroCli.Text = ""
        TextBoxComplementoCli.Text = ""
        MaskedTextBoxCEPCLI.Text = ""
        TextBoxCidadeCLi.Text = ""
        ComboBoxUF.Text = Nothing
        TextBoxIdCLI.Text = ""
    End Sub

    Private Sub X_Click(sender As Object, e As EventArgs) Handles X.Click
        If MessageBox.Show("Deseja realmente sair?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
            Me.Close()
            frmMenu.Refresh()
            frmMenu.Visible = True
        End If
    End Sub

    Private Sub btn_Novo_Click(sender As Object, e As EventArgs) Handles btn_Novo.Click
        PanelSelect.Location = New Point(0, 169)
        PanelSelect.Visible = True
        habilitar()
        limpar()
        btn_Salvar.Enabled = True
        btn_Pesquisar.Enabled = True
        btn_Relatório.Enabled = False
        btn_Editar.Enabled = False
    End Sub

    Private Sub btn_Salvar_Click(sender As Object, e As EventArgs) Handles btn_Salvar.Click
        PanelSelect.Location = New Point(0, 250)
        PanelSelect.Visible = True

        If TextBoxNomeCLI.Text = "" Or MaskedTextBoxNascimentoCli.Text = "" Or MaskedTextBoxCPFCli.Text = "" Or MaskedTextBoxRGCli.Text = "" Or TextBoxEMAILCLI.Text = "" Or MaskedTextBoxTEL1Cli.Text = "" Or MaskedTextBoxCEL1Cli.Text = "" Or TextBoxLogradouroCLI.Text = "" Or TextBoxNumCli.Text = "" Or TextBoxBairroCli.Text = "" Or TextBoxComplementoCli.Text = "" Or MaskedTextBoxCEPCLI.Text = "" Or TextBoxCidadeCLi.Text = "" Or ComboBoxUF.Text = "" Then
            MessageBox.Show("Preencha todos os campos!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBoxNomeCLI.Focus()

        Else

            abrir()
            Try
                Dim cmd As OleDbCommand
                Dim sql As String

                sql = ("INSERT INTO Clientes (nome_Cliente, cpf_Cliente, rg_Cliente, celular_Cliente, telefone_Cliente, data_Nascimento_Cliente, email_Cliente, logradouro_Cliente, cidade_Cliente, estado_Cliente, complemento_Cliente, cep_Cliente, numero_end_Cliente, bairro_Cliente) VALUES ('" & TextBoxNomeCLI.Text & "', '" & MaskedTextBoxCPFCli.Text & "', '" & MaskedTextBoxRGCli.Text & "', '" & MaskedTextBoxCEL1Cli.Text & "', '" & MaskedTextBoxTEL1Cli.Text & "', '" & MaskedTextBoxNascimentoCli.Text & "', '" & TextBoxEMAILCLI.Text & "', '" & TextBoxLogradouroCLI.Text & "', '" & TextBoxCidadeCLi.Text & "', '" & ComboBoxUF.Text & "', '" & TextBoxComplementoCli.Text & "', '" & MaskedTextBoxCEPCLI.Text & "', '" & TextBoxNumCli.Text & "', '" & TextBoxBairroCli.Text & "')")

                cmd = New OleDbCommand(sql, con)
                cmd.ExecuteNonQuery()

                MessageBox.Show("Cadastro realizado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information)
                fechar()
                desabilitar()
                limpar()
                btn_Novo.Enabled = True
                btn_Editar.Enabled = False
                btn_Excluir.Enabled = False
                btn_Salvar.Enabled = False
                btn_Pesquisar.Enabled = True
                btn_Relatório.Enabled = True
            Catch ex As Exception
                MsgBox(ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        PanelSelect.Location = New Point(0, 331)
        PanelSelect.Visible = True
        habilitar()
        btn_Novo.Enabled = False
        btn_Salvar.Enabled = False
        btn_Excluir.Enabled = True
        btn_Atualizar.Enabled = True
        btn_Pesquisar.Enabled = True
        btn_Relatório.Enabled = False
    End Sub

    Private Sub btn_Excluir_Click(sender As Object, e As EventArgs) Handles btn_Excluir.Click
        PanelSelect.Location = New Point(0, 412)
        PanelSelect.Visible = True

        If MessageBox.Show("Você tem certeza que deseja excluir esse cadastro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = DialogResult.Yes Then
            abrir()
            Try
                Dim cmd As OleDbCommand
                Dim sql As String

                sql = "DELETE FROM Clientes WHERE id_Cliente =" + TextBoxIdCLI.Text
                cmd = New OleDbCommand(sql, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Cadastro excluido com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information)
                fechar()
                desabilitar()
                limpar()
                btn_Editar.Enabled = False
                btn_Novo.Enabled = True
                btn_Salvar.Enabled = False
                btn_Atualizar.Enabled = False
                btn_Excluir.Enabled = False
                btn_Relatório.Enabled = True
            Catch ex As Exception
                MsgBox(ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btn_Atualizar_Click(sender As Object, e As EventArgs) Handles btn_Atualizar.Click
        PanelSelect.Location = New Point(0, 493)
        PanelSelect.Visible = True
        If MessageBox.Show("Você tem certeza que deseja atualizar esse cadastro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = DialogResult.Yes Then
            abrir()
            Try
                Dim cmd As OleDbCommand
                Dim sql As String

                sql = "UPDATE Clientes SET nome_Cliente = '" & TextBoxNomeCLI.Text & "', cpf_Cliente = '" & MaskedTextBoxCPFCli.Text & "', rg_Cliente = '" & MaskedTextBoxRGCli.Text & "', celular_Cliente = '" & MaskedTextBoxCEL1Cli.Text & "', telefone_Cliente = '" & MaskedTextBoxTEL1Cli.Text & "', data_Nascimento_Cliente = '" & MaskedTextBoxNascimentoCli.Text & "', email_Cliente = '" & TextBoxEMAILCLI.Text & "', logradouro_Cliente = '" & TextBoxLogradouroCLI.Text & "', cidade_Cliente= '" & TextBoxCidadeCLi.Text & "', estado_Cliente = '" & ComboBoxUF.Text & "', complemento_Cliente = '" & TextBoxComplementoCli.Text & "', cep_Cliente = '" & MaskedTextBoxCEPCLI.Text & "', numero_end_Cliente = '" & TextBoxNumCli.Text & "', bairro_Cliente = '" & TextBoxBairroCli.Text & "' WHERE id_Cliente = " + TextBoxIdCLI.Text
                MessageBox.Show("Atualização feita com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmd = New OleDbCommand(sql, con)
                cmd.ExecuteNonQuery()
                fechar()
                desabilitar()
                limpar()

            Catch ex As Exception
                MsgBox(ex.Message)
                fechar()
            End Try
            btn_Editar.Enabled = False
            btn_Novo.Enabled = True
            btn_Salvar.Enabled = False
            btn_Atualizar.Enabled = False
            btn_Excluir.Enabled = False
            btn_Relatório.Enabled = True
        End If
    End Sub

    Private Sub btn_Pesquisar_Click(sender As Object, e As EventArgs) Handles btn_Pesquisar.Click
        PanelSelect.Location = New Point(0, 574)
        PanelSelect.Visible = True
        frmPCliente.Show()
        desabilitar()
        limpar()
        btn_Editar.Enabled = True
        btn_Salvar.Enabled = False
    End Sub

    Private Sub btn_Relatório_Click(sender As Object, e As EventArgs) Handles btn_Relatório.Click
        PanelSelect.Location = New Point(0, 655)
        PanelSelect.Visible = True
    End Sub

    Private Sub frmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_Salvar.Enabled = False
        btn_Editar.Enabled = False
        btn_Excluir.Enabled = False
        btn_Atualizar.Enabled = False
    End Sub
End Class