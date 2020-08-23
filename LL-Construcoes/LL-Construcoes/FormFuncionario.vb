Imports System.Data.OleDb
Imports System.IO

Public Class frmFuncionario
    Private Sub X_Click(sender As Object, e As EventArgs) Handles X.Click
        If MessageBox.Show("Deseja realmente sair?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
            Me.Close()
            frmMenu.Refresh()
            frmMenu.Visible = True
        End If
    End Sub

    Sub habilitar()
        TextBoxNomeFunc.Enabled = True
        MaskedTextBoxNascimentoFunc.Enabled = True
        MaskedTextBoxCPFFunc.Enabled = True
        MaskedTextBoxRGFunc.Enabled = True
        TextBoxEMAILFunc.Enabled = True
        MaskedTextBoxTEL1Func.Enabled = True
        MaskedTextBoxCEL1Func.Enabled = True
        TextBoxLoginFunc.Enabled = True
        TextBoxSenhaFunc.Enabled = True
        ComboBoxCargoFunc.Enabled = True
        TextBoxLogradouroFunc.Enabled = True
        TextBoxNUmENDFunc.Enabled = True
        TextBoxBairroFunc.Enabled = True
        TextBoxCompleFunc.Enabled = True
        MaskedTextBoxCEPFunc.Enabled = True
        TextBoxCidadeFunc.Enabled = True
        TextBoxUFFunc.Enabled = True
        ComboBoxBancoFunc.Enabled = True
        TextBoxAgenciaFunc.Enabled = True
        TextBoxContaBancoFunc.Enabled = True
        TextBoxOperacaoBancoFunc.Enabled = True
        TextBoxSalarioFunc.Enabled = True
        TextBoxComissaoFunc.Enabled = True
        TextBoxVendasFunc.Enabled = True
        ButtonAddFoto.Enabled = True
    End Sub

    Sub desabilitar()
        TextBoxNomeFunc.Enabled = False
        MaskedTextBoxNascimentoFunc.Enabled = False
        MaskedTextBoxCPFFunc.Enabled = False
        MaskedTextBoxRGFunc.Enabled = False
        TextBoxEMAILFunc.Enabled = False
        MaskedTextBoxTEL1Func.Enabled = False
        MaskedTextBoxCEL1Func.Enabled = False
        TextBoxLoginFunc.Enabled = False
        TextBoxSenhaFunc.Enabled = False
        ComboBoxCargoFunc.Enabled = False
        TextBoxLogradouroFunc.Enabled = False
        TextBoxNUmENDFunc.Enabled = False
        TextBoxBairroFunc.Enabled = False
        TextBoxCompleFunc.Enabled = False
        MaskedTextBoxCEPFunc.Enabled = False
        TextBoxCidadeFunc.Enabled = False
        TextBoxUFFunc.Enabled = False
        ComboBoxBancoFunc.Enabled = False
        TextBoxAgenciaFunc.Enabled = False
        TextBoxContaBancoFunc.Enabled = False
        TextBoxOperacaoBancoFunc.Enabled = False
        TextBoxSalarioFunc.Enabled = False
        TextBoxComissaoFunc.Enabled = False
        TextBoxVendasFunc.Enabled = False
        ButtonAddFoto.Enabled = False
    End Sub

    Sub limpar()
        TextBoxIdFunc.Text = ""
        TextBoxNomeFunc.Text = ""
        MaskedTextBoxNascimentoFunc.Text = ""
        MaskedTextBoxCPFFunc.Text = ""
        MaskedTextBoxRGFunc.Text = ""
        TextBoxEMAILFunc.Text = ""
        MaskedTextBoxTEL1Func.Text = ""
        MaskedTextBoxCEL1Func.Text = ""
        TextBoxLoginFunc.Text = ""
        TextBoxSenhaFunc.Text = ""
        ComboBoxCargoFunc.Text = ""
        TextBoxLogradouroFunc.Text = ""
        TextBoxNUmENDFunc.Text = ""
        TextBoxBairroFunc.Text = ""
        TextBoxCompleFunc.Text = ""
        MaskedTextBoxCEPFunc.Text = ""
        TextBoxCidadeFunc.Text = ""
        TextBoxUFFunc.Text = ""
        ComboBoxBancoFunc.Text = ""
        TextBoxAgenciaFunc.Text = ""
        TextBoxContaBancoFunc.Text = ""
        TextBoxOperacaoBancoFunc.Text = ""
        TextBoxSalarioFunc.Text = ""
        TextBoxComissaoFunc.Text = ""
        TextBoxVendasFunc.Text = ""
        PictureBoxFunc.Image = Nothing
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
        TextBoxSalarioFunc.Text = FormatCurrency("0,00")
    End Sub

    Private Sub btn_Salvar_Click(sender As Object, e As EventArgs) Handles btn_Salvar.Click
        PanelSelect.Location = New Point(0, 250)
        PanelSelect.Visible = True
        If TextBoxNomeFunc.Text = "" Or MaskedTextBoxNascimentoFunc.Text = "" Or MaskedTextBoxCPFFunc.Text = "" Or MaskedTextBoxRGFunc.Text = "" Or TextBoxEMAILFunc.Text = "" Or MaskedTextBoxTEL1Func.Text = "" Or MaskedTextBoxCEL1Func.Text = "" Or TextBoxLoginFunc.Text = "" Or TextBoxSenhaFunc.Text = "" Or ComboBoxCargoFunc.Text = "" Or TextBoxLogradouroFunc.Text = "" Or TextBoxNUmENDFunc.Text = "" Or TextBoxBairroFunc.Text = "" Or TextBoxCompleFunc.Text = "" Or MaskedTextBoxCEPFunc.Text = "" Or TextBoxCidadeFunc.Text = "" Or TextBoxUFFunc.Text = "" Or ComboBoxBancoFunc.Text = "" Or TextBoxAgenciaFunc.Text = "" Or TextBoxContaBancoFunc.Text = "" Or TextBoxOperacaoBancoFunc.Text = "" Or TextBoxSalarioFunc.Text = "" Or TextBoxComissaoFunc.Text = "" Or TextBoxVendasFunc.Text = "" Then
            MessageBox.Show("Preencha todos os campos!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBoxNomeFunc.Focus()
        Else

            Dim fs As FileStream
            fs = New FileStream(imgnome2, FileMode.Open, FileAccess.Read)
            Dim picbyte As Byte() = New Byte(fs.Length - 1) {}
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length))
            fs.Close()

            abrir()
            Try
                Dim cmd As OleDbCommand
                Dim sql As String

                sql = ("INSERT INTO Funcionarios (nome_Func, nascimento_Func, cpf_Func, rg_Func, email_Func, tel_Func, cel_Func, usuario_Func, senha_Func, cargo_Func, logradouro_Func, numeroEnd_Func, bairro_Func, complemento_Func, cep_Func, cidade_Func, uf_Func, banco_Func, agencia_Func, conta_Func, operacao_Func, salario_Func, comissao_Func, vendas_Func,  foto_Func) VALUES ('" & TextBoxNomeFunc.Text & "', '" & MaskedTextBoxNascimentoFunc.Text & "', '" & MaskedTextBoxCPFFunc.Text & "', '" & MaskedTextBoxRGFunc.Text & "', '" & TextBoxEMAILFunc.Text & "', '" & MaskedTextBoxTEL1Func.Text & "', '" & MaskedTextBoxCEL1Func.Text & "', '" & TextBoxLoginFunc.Text & "', '" & TextBoxSenhaFunc.Text & "', '" & ComboBoxCargoFunc.Text & "', '" & TextBoxLogradouroFunc.Text & "', '" & TextBoxNUmENDFunc.Text & "', '" & TextBoxBairroFunc.Text & "', '" & TextBoxCompleFunc.Text & "', '" & MaskedTextBoxCEPFunc.Text & "', '" & TextBoxCidadeFunc.Text & "', '" & TextBoxUFFunc.Text & "', '" & ComboBoxBancoFunc.Text & "', '" & TextBoxAgenciaFunc.Text & "', '" & TextBoxContaBancoFunc.Text & "', '" & TextBoxOperacaoBancoFunc.Text & "', '" & TextBoxSalarioFunc.Text & "', '" & TextBoxComissaoFunc.Text & "', '" & TextBoxVendasFunc.Text & "', " & " @img )")

                Dim param As New OleDbParameter
                param.OleDbType = OleDbType.Binary
                param.ParameterName = "img"
                param.Value = picbyte

                cmd = New OleDbCommand(sql, con)
                cmd.Parameters.Add(param)
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

                sql = "DELETE FROM Funcionarios WHERE id_Func =" + TextBoxIdFunc.Text
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
            If foto2 = True Then
                Try
                    Dim bytearray
                    Dim fs As FileStream

                    fs = New FileStream(imgnome2, FileMode.Open, FileAccess.Read)
                    Dim picByte As Byte() = New Byte(fs.Length - 1) {}
                    fs.Read(picByte, 0, System.Convert.ToInt32(fs.Length))
                    fs.Close()

                    abrir()
                    Dim cmd As OleDbCommand
                    Dim sql As String
                    Dim ms As New IO.MemoryStream
                    PictureBoxFunc.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                    bytearray = ms.ToArray

                    sql = "UPDATE Funcionarios SET nome_Func = '" & TextBoxNomeFunc.Text & "', nascimento_Func = '" & MaskedTextBoxNascimentoFunc.Text & "', cpf_Func = '" & MaskedTextBoxCPFFunc.Text & "', rg_Func = '" & MaskedTextBoxRGFunc.Text & "', email_Func = '" & TextBoxEMAILFunc.Text & "', tel_Func = '" & MaskedTextBoxTEL1Func.Text & "', cel_Func = '" & MaskedTextBoxCEL1Func.Text & "', usuario_Func = '" & TextBoxLoginFunc.Text & "', senha_Func = '" & TextBoxSenhaFunc.Text & "', cargo_Func = '" & ComboBoxCargoFunc.Text & "', logradouro_Func = '" & TextBoxLogradouroFunc.Text & "', numeroEnd_Func = '" & TextBoxNUmENDFunc.Text & "', bairro_Func = '" & TextBoxBairroFunc.Text & "', complemento_Func = '" & TextBoxCompleFunc.Text & "', cep_Func = '" & MaskedTextBoxCEPFunc.Text & "', cidade_Func = '" & TextBoxCidadeFunc.Text & "', uf_Func = '" & TextBoxUFFunc.Text & "', banco_Func = '" & ComboBoxBancoFunc.Text & "', agencia_Func = '" & TextBoxAgenciaFunc.Text & "', conta_Func = '" & TextBoxContaBancoFunc.Text & "', operacao_Func = '" & TextBoxOperacaoBancoFunc.Text & "', salario_Func = '" & TextBoxSalarioFunc.Text & "', comissao_Func = '" & TextBoxComissaoFunc.Text & "', foto_Func = @img, vendas_Func = '" & TextBoxVendasFunc.Text & "' WHERE id_Func = " + TextBoxIdFunc.Text

                    cmd = New OleDbCommand(sql, con)
                    cmd.Parameters.AddWithValue("img", bytearray)
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Dados atualizados com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    fechar()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    fechar()
                Finally
                    foto2 = False
                    fechar()
                End Try
                desabilitar()
                limpar()
                btn_Editar.Enabled = False
                btn_Novo.Enabled = True
                btn_Salvar.Enabled = False
                btn_Atualizar.Enabled = False
                btn_Excluir.Enabled = False
                btn_Relatório.Enabled = True
            Else
                Try
                    abrir()
                    Dim cmd As OleDbCommand
                    Dim sql As String

                    sql = "UPDATE Funcionarios SET nome_Func = '" & TextBoxNomeFunc.Text & "', nascimento_Func = '" & MaskedTextBoxNascimentoFunc.Text & "', cpf_Func = '" & MaskedTextBoxCPFFunc.Text & "', rg_Func = '" & MaskedTextBoxRGFunc.Text & "', email_Func = '" & TextBoxEMAILFunc.Text & "', tel_Func = '" & MaskedTextBoxTEL1Func.Text & "', cel_Func = '" & MaskedTextBoxCEL1Func.Text & "', usuario_Func = '" & TextBoxLoginFunc.Text & "', senha_Func = '" & TextBoxSenhaFunc.Text & "', cargo_Func = '" & ComboBoxCargoFunc.Text & "', logradouro_Func = '" & TextBoxLogradouroFunc.Text & "', numeroEnd_Func = '" & TextBoxNUmENDFunc.Text & "', bairro_Func = '" & TextBoxBairroFunc.Text & "', complemento_Func = '" & TextBoxCompleFunc.Text & "', cep_Func = '" & MaskedTextBoxCEPFunc.Text & "', cidade_Func = '" & TextBoxCidadeFunc.Text & "', uf_Func = '" & TextBoxUFFunc.Text & "', banco_Func = '" & ComboBoxBancoFunc.Text & "', agencia_Func = '" & TextBoxAgenciaFunc.Text & "', conta_Func = '" & TextBoxContaBancoFunc.Text & "', operacao_Func = '" & TextBoxOperacaoBancoFunc.Text & "', salario_Func = '" & TextBoxSalarioFunc.Text & "', comissao_Func = '" & TextBoxComissaoFunc.Text & "', vendas_Func = '" & TextBoxVendasFunc.Text & "' WHERE id_Func = " + TextBoxIdFunc.Text

                    cmd = New OleDbCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Dados atualizados com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cmd = New OleDbCommand(sql, con)
                    cmd.ExecuteNonQuery()
                    fechar()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    fechar()
                Finally
                    foto2 = False
                    fechar()
                End Try
                desabilitar()
                limpar()
                btn_Editar.Enabled = False
                btn_Novo.Enabled = True
                btn_Salvar.Enabled = False
                btn_Atualizar.Enabled = False
                btn_Excluir.Enabled = False
                btn_Relatório.Enabled = True
            End If
        End If
    End Sub

    Private Sub btn_Pesquisar_Click(sender As Object, e As EventArgs) Handles btn_Pesquisar.Click
        PanelSelect.Location = New Point(0, 574)
        PanelSelect.Visible = True
        frmPFunc.Show()
        desabilitar()
        btn_Editar.Enabled = True
        btn_Salvar.Enabled = False
    End Sub

    Private Sub btn_Relatório_Click(sender As Object, e As EventArgs) Handles btn_Relatório.Click
        PanelSelect.Location = New Point(0, 655)
        PanelSelect.Visible = True
    End Sub

    Private Sub frmFuncionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_Salvar.Enabled = False
        btn_Editar.Enabled = False
        btn_Excluir.Enabled = False
        btn_Atualizar.Enabled = False
        TextBoxSalarioFunc.Text = FormatCurrency("0,00")
    End Sub

    Private Sub ButtonAddFoto_Click(sender As Object, e As EventArgs) Handles ButtonAddFoto.Click
        Try
            foto2 = True
            Dim dlgimage As FileDialog = New OpenFileDialog
            dlgimage.Filter = "Image File(*.jpg; *.bmp; *.png) | *.jpg; *.bmp; *.png"
            If (dlgimage.ShowDialog) = DialogResult.OK Then
                imgnome2 = dlgimage.FileName
                Dim novaimg As New Bitmap(imgnome2)
                PictureBoxFunc.SizeMode = PictureBoxSizeMode.StretchImage
                PictureBoxFunc.Image = DirectCast(novaimg, Image)
            Else
                dlgimage = Nothing
            End If
        Catch ex As Exception
            imgnome2 = ""
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
End Class