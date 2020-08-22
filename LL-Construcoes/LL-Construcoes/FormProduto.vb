Imports System.Data.OleDb
Imports System.IO

Public Class frmProduto
    Private Sub X_Click(sender As Object, e As EventArgs) Handles X.Click
        If MessageBox.Show("Deseja realmente sair?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
            Me.Close()
            frmMenu.Refresh()
            frmMenu.Visible = True
        End If
    End Sub

    Sub habilitar()
        TextBoxNomeProd.Enabled = True
        TextBoxMarcaProd.Enabled = True
        TextBoxCorProd.Enabled = True
        TextBoxPrecoProd.Enabled = True
        TextBoxEstoqueProd.Enabled = True
        ComboBoxCategoriaProd.Enabled = True
        ComboBoxSubCategoriaProd.Enabled = True
        TextBoxDescricaoProd.Enabled = True
        ButtonAddFornProd.Enabled = True
        ButtonAddFoto.Enabled = True
    End Sub

    Sub desabilitar()
        TextBoxNomeProd.Enabled = False
        TextBoxMarcaProd.Enabled = False
        TextBoxCorProd.Enabled = False
        TextBoxPrecoProd.Enabled = False
        TextBoxEstoqueProd.Enabled = False
        ComboBoxCategoriaProd.Enabled = False
        ComboBoxSubCategoriaProd.Enabled = False
        TextBoxDescricaoProd.Enabled = False
        ButtonAddFornProd.Enabled = False
        ButtonAddFoto.Enabled = False
    End Sub

    Sub limpar()
        TextBoxNomeProd.Text = ""
        TextBoxMarcaProd.Text = ""
        TextBoxCorProd.Text = ""
        TextBoxPrecoProd.Text = ""
        TextBoxEstoqueProd.Text = ""
        ComboBoxCategoriaProd.Text = ""
        ComboBoxSubCategoriaProd.Text = ""
        TextBoxDescricaoProd.Text = ""
        TextBoxIdProd.Text = ""
        TextBoxFornProd.Text = ""
        PictureBoxProduto.Image = Nothing
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
        TextBoxPrecoProd.Text = FormatCurrency("0,00")
    End Sub

    Private Sub btn_Salvar_Click(sender As Object, e As EventArgs) Handles btn_Salvar.Click
        PanelSelect.Location = New Point(0, 250)
        PanelSelect.Visible = True
        If TextBoxNomeProd.Text = "" Or TextBoxMarcaProd.Text = "" Or TextBoxCorProd.Text = "" Or TextBoxPrecoProd.Text = "" Or TextBoxEstoqueProd.Text = "" Or ComboBoxCategoriaProd.Text = "" Or ComboBoxSubCategoriaProd.Text = "" Or TextBoxDescricaoProd.Text = "" Or TextBoxFornProd.Text = "" Then
            MessageBox.Show("Preencha todos os campos!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBoxNomeProd.Focus()

        Else
            btn_Novo.Enabled = False
            btn_Salvar.Enabled = True
            btn_Editar.Enabled = False
            btn_Atualizar.Enabled = False
            btn_Excluir.Enabled = False
            btn_Pesquisar.Enabled = True
            btn_Relatório.Enabled = True

            Dim fs As FileStream

            fs = New FileStream(imgnome, FileMode.Open, FileAccess.Read)
            Dim picByte As Byte() = New Byte(fs.Length - 1) {}
            fs.Read(picByte, 0, System.Convert.ToInt32(fs.Length))
            fs.Close()

            abrir()
            Try
                Dim cmd As OleDbCommand
                Dim sql As String

                sql = ("INSERT INTO Produtos (nome_Produto, marca_Produto, cor_Produto, preco_Produto, estoque_Produto, categoria_Produto, subcategoria_Produto, fornecedor_Produto, descricao_Produto, foto_Produto) VALUES ( '" & TextBoxNomeProd.Text & "', '" & TextBoxMarcaProd.Text & "', '" & TextBoxCorProd.Text & "', '" & TextBoxPrecoProd.Text & "', '" & TextBoxEstoqueProd.Text & "', '" & ComboBoxCategoriaProd.Text & "', '" & ComboBoxSubCategoriaProd.Text & "', '" & TextBoxFornProd.Text & "', '" & TextBoxDescricaoProd.Text & "', " & " @img )")

                Dim param As New OleDbParameter
                param.OleDbType = OleDbType.Binary
                param.ParameterName = "img"
                param.Value = picByte

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

                sql = "DELETE FROM Produtos WHERE id_Produto =" + TextBoxIdProd.Text
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
            If foto1 = True Then
                Try
                    Dim bytearray
                    Dim fs As FileStream

                    fs = New FileStream(imgnome, FileMode.Open, FileAccess.Read)
                    Dim picByte As Byte() = New Byte(fs.Length - 1) {}
                    fs.Read(picByte, 0, System.Convert.ToInt32(fs.Length))
                    fs.Close()

                    abrir()
                    Dim cmd As OleDbCommand
                    Dim sql As String
                    Dim ms As New IO.MemoryStream
                    PictureBoxProduto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                    bytearray = ms.ToArray

                    sql = "UPDATE Produtos SET nome_Produto = '" & TextBoxNomeProd.Text & "', marca_Produto = '" & TextBoxMarcaProd.Text & "', cor_Produto = '" & TextBoxCorProd.Text & "', preco_Produto = '" & TextBoxPrecoProd.Text & "', estoque_Produto = '" & TextBoxEstoqueProd.Text & "', categoria_Produto = '" & ComboBoxCategoriaProd.Text & "', subcategoria_Produto = '" & ComboBoxSubCategoriaProd.Text & "', fornecedor_Produto = '" & TextBoxFornProd.Text & "', foto_Produto = @img, descricao_Produto = '" & TextBoxDescricaoProd.Text & "' WHERE id_Produto = " + TextBoxIdProd.Text

                    cmd = New OleDbCommand(sql, con)
                    cmd.Parameters.AddWithValue("img", bytearray)
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Dados atualizados com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    fechar()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    fechar()
                Finally
                    foto1 = False
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

                    sql = "UPDATE Produtos SET nome_Produto = '" & TextBoxNomeProd.Text & "', marca_Produto = '" & TextBoxMarcaProd.Text & "', cor_Produto = '" & TextBoxCorProd.Text & "', preco_Produto = '" & TextBoxPrecoProd.Text & "', estoque_Produto = '" & TextBoxEstoqueProd.Text & "', categoria_Produto = '" & ComboBoxCategoriaProd.Text & "', subcategoria_Produto = '" & ComboBoxSubCategoriaProd.Text & "', fornecedor_Produto = '" & TextBoxFornProd.Text & "', descricao_Produto = '" & TextBoxDescricaoProd.Text & "' WHERE id_Produto = " + TextBoxIdProd.Text

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
                    foto1 = False
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
        frmPProduto.Show()
        desabilitar()
        btn_Editar.Enabled = True
        btn_Salvar.Enabled = False
    End Sub

    Private Sub btn_Relatório_Click(sender As Object, e As EventArgs) Handles btn_Relatório.Click
        PanelSelect.Location = New Point(0, 655)
        PanelSelect.Visible = True
    End Sub

    Private Sub ButtonAddFoto_Click(sender As Object, e As EventArgs) Handles ButtonAddFoto.Click
        Try
            foto1 = True
            Dim dlgimage As FileDialog = New OpenFileDialog
            dlgimage.Filter = "Image File(*.jpg; *.bmp; *.png) | *.jpg; *.bmp; *.png"
            If (dlgimage.ShowDialog) = DialogResult.OK Then
                imgnome = dlgimage.FileName
                Dim novaimg As New Bitmap(imgnome)
                PictureBoxProduto.SizeMode = PictureBoxSizeMode.StretchImage
                PictureBoxProduto.Image = DirectCast(novaimg, Image)
            Else
                dlgimage = Nothing
            End If
        Catch ex As Exception
            imgnome = ""
        MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_Salvar.Enabled = False
        btn_Editar.Enabled = False
        btn_Excluir.Enabled = False
        btn_Atualizar.Enabled = False
        TextBoxPrecoProd.Text = FormatCurrency("0,00")
    End Sub

    Private Sub ButtonAddFornProd_Click(sender As Object, e As EventArgs) Handles ButtonAddFornProd.Click
        frmPFornec2.Show()
    End Sub
End Class