Imports System.Data.OleDb
Imports System.IO

Public Class frmFornecedores
    Private Sub X_Click(sender As Object, e As EventArgs) Handles X.Click
        If MessageBox.Show("Deseja realmente sair?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
            Me.Close()
            frmMenu.Refresh()
            frmMenu.Visible = True
        End If
    End Sub

    Sub habilitar()
        TextBoxNomeForne.Enabled = True
        MaskedTextBoxCNPJForne.Enabled = True
        TextBoxEMAILForn.Enabled = True
        MaskedTextBoxTEL1Forn.Enabled = True
        MaskedTextBoxCEL1Forn.Enabled = True
        TextBoxLogradouroForn.Enabled = True
        TextBoxNumForn.Enabled = True
        TextBoxBairroForn.Enabled = True
        TextBoxCompleForn.Enabled = True
        MaskedTextBoxCEPForn.Enabled = True
        TextBoxCidadeForn.Enabled = True
        ComboBoxUF.Enabled = True
        TextBoxinformacaoForn.Enabled = True
        TextBoxAgenciaForn.Enabled = True
        TextBoxContaBancoForn.Enabled = True
        TextBoxOperacaoBancoForn.Enabled = True
        ComboBoxBancoForn.Enabled = True
    End Sub

    Sub desabilitar()
        TextBoxNomeForne.Enabled = False
        MaskedTextBoxCNPJForne.Enabled = False
        TextBoxEMAILForn.Enabled = False
        MaskedTextBoxTEL1Forn.Enabled = False
        MaskedTextBoxCEL1Forn.Enabled = False
        TextBoxLogradouroForn.Enabled = False
        TextBoxNumForn.Enabled = False
        TextBoxBairroForn.Enabled = False
        TextBoxCompleForn.Enabled = False
        MaskedTextBoxCEPForn.Enabled = False
        TextBoxCidadeForn.Enabled = False
        ComboBoxUF.Enabled = False
        TextBoxinformacaoForn.Enabled = False
        TextBoxAgenciaForn.Enabled = False
        TextBoxContaBancoForn.Enabled = False
        TextBoxOperacaoBancoForn.Enabled = False
        ComboBoxBancoForn.Enabled = False
    End Sub

    Sub limpar()
        TextBoxIdForne.Text = ""
        TextBoxNomeForne.Text = ""
        MaskedTextBoxCNPJForne.Text = ""
        TextBoxEMAILForn.Text = ""
        MaskedTextBoxTEL1Forn.Text = ""
        MaskedTextBoxCEL1Forn.Text = ""
        TextBoxLogradouroForn.Text = ""
        TextBoxNumForn.Text = ""
        TextBoxBairroForn.Text = ""
        TextBoxCompleForn.Text = ""
        MaskedTextBoxCEPForn.Text = ""
        TextBoxCidadeForn.Text = ""
        ComboBoxUF.Text = Nothing
        TextBoxinformacaoForn.Text = ""
        TextBoxAgenciaForn.Text = ""
        TextBoxContaBancoForn.Text = ""
        TextBoxOperacaoBancoForn.Text = ""
        ComboBoxBancoForn.Text = Nothing
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
        If TextBoxNomeForne.Text = "" Or MaskedTextBoxCNPJForne.Text = "" Or TextBoxinformacaoForn.Text = "" Or TextBoxEMAILForn.Text = "" Or MaskedTextBoxTEL1Forn.Text = "" Or MaskedTextBoxCEL1Forn.Text = "" Or TextBoxLogradouroForn.Text = "" Or TextBoxNumForn.Text = "" Or TextBoxBairroForn.Text = "" Or TextBoxCidadeForn.Text = "" Or ComboBoxUF.Text = "" Or ComboBoxBancoForn.Text = "" Or TextBoxAgenciaForn.Text = "" Or TextBoxContaBancoForn.Text = "" Or TextBoxOperacaoBancoForn.Text = "" Then
            MessageBox.Show("Preencha todos os campos!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBoxNomeForne.Focus()
        Else
            abrir()
            Try
                Dim cmd As OleDbCommand
                Dim sql As String

                sql = ("INSERT INTO fornecedores (nome_Fornec, cnpj_Fornec, informacoes_ad_Fornec, email_Fornec, celular_Fornec, telefone_Fornec, logradouro_Fornec, numero_end_Fornec, bairro_Fornec, complemento_Fornec, cep_Fornec, cidade_Fornec, estado_Fornec, banco_Fornec, agencia_Fornec, conta_Fornec, operacao_Fornec) VALUES ('" & TextBoxNomeForne.Text & "', '" & MaskedTextBoxCNPJForne.Text & "', '" & TextBoxinformacaoForn.Text & "', '" & TextBoxEMAILForn.Text & "', '" & MaskedTextBoxCEL1Forn.Text & "', '" & MaskedTextBoxTEL1Forn.Text & "', '" & TextBoxLogradouroForn.Text & "', '" & TextBoxNumForn.Text & "', '" & TextBoxBairroForn.Text & "', '" & TextBoxCompleForn.Text & "', '" & MaskedTextBoxCEPForn.Text & "', '" & TextBoxCidadeForn.Text & "', '" & ComboBoxUF.Text & "', '" & ComboBoxBancoForn.Text & "', '" & TextBoxAgenciaForn.Text & "', '" & TextBoxContaBancoForn.Text & "','" & TextBoxOperacaoBancoForn.Text & "')")
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

                sql = "DELETE FROM Fornecedores WHERE id_Fornec =" + TextBoxIdForne.Text
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

                sql = "UPDATE Fornecedores SET nome_Fornec = '" & TextBoxNomeForne.Text & "', cnpj_Fornec = '" & MaskedTextBoxCNPJForne.Text & "', informacoes_ad_Fornec = '" & TextBoxinformacaoForn.Text & "', email_Fornec = '" & TextBoxEMAILForn.Text & "', celular_Fornec = '" & MaskedTextBoxCEL1Forn.Text & "', telefone_Fornec = '" & MaskedTextBoxTEL1Forn.Text & "', logradouro_Fornec = '" & TextBoxLogradouroForn.Text & "', numero_end_Fornec = '" & TextBoxNumForn.Text & "',  bairro_Fornec = '" & TextBoxBairroForn.Text & "',  complemento_Fornec = '" & TextBoxCompleForn.Text & "',  cep_Fornec = '" & MaskedTextBoxCEPForn.Text & "',  cidade_Fornec = '" & TextBoxCidadeForn.Text & "',  estado_Fornec = '" & ComboBoxUF.Text & "', agencia_Fornec = '" & TextBoxAgenciaForn.Text & "',  conta_Fornec = '" & TextBoxContaBancoForn.Text & "',  operacao_Fornec = '" & TextBoxOperacaoBancoForn.Text & "', banco_Fornec = '" & ComboBoxBancoForn.Text & "' WHERE id_Fornec = " + TextBoxIdForne.Text
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
        frmPFornec.Show()
        desabilitar()
        limpar()
        btn_Editar.Enabled = True
        btn_Salvar.Enabled = False
    End Sub

    Private Sub btn_Relatório_Click(sender As Object, e As EventArgs) Handles btn_Relatório.Click
        PanelSelect.Location = New Point(0, 655)
        PanelSelect.Visible = True
    End Sub

    Private Sub frmFornecedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_Salvar.Enabled = False
        btn_Editar.Enabled = False
        btn_Excluir.Enabled = False
        btn_Atualizar.Enabled = False
    End Sub
End Class