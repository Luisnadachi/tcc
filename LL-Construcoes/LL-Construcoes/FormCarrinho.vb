Imports System.Data.OleDb
Imports System.IO

Public Class frmCarrinho
    Dim idFuncVenda As Integer
    Public estoqueAtual As Integer

    Private Sub valorInicial()

        tbTotalProd.Text = FormatCurrency("0")
        tbPreco.Text = FormatCurrency("0")
        tbSubTotalVendas.Text = FormatCurrency("0")
        tbDescontoVenda.Text = FormatCurrency("0")
        tbTotalCompra.Text = FormatCurrency("0")
        tbValorReceb.Text = FormatCurrency("0")
        tbTroco.Text = FormatCurrency("0")
    End Sub

    Private Sub X_Click(sender As Object, e As EventArgs) Handles X.Click
        If MessageBox.Show("Deseja realmente sair?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
            Me.Close()
            frmMenu.Refresh()
            frmMenu.Visible = True
        End If
    End Sub

    Sub habilitar()
        DgvProdutosVenda.Enabled = True
        tbquantidade.Enabled = True
        tbValorReceb.Enabled = True
        cbFormaPagamentoVenda.Enabled = True
        btnCliente.Enabled = True
        btnProcurarProd.Enabled = True
    End Sub

    Sub desabilitar()
        DgvProdutosVenda.Enabled = False
        tbCodProduto.Enabled = False
        tbProduto.Enabled = False
        tbquantidade.Enabled = False
        tbTotalProd.Enabled = False
        tbSubTotalVendas.Enabled = False
        tbDescontoVenda.Enabled = False
        tbTotalCompra.Enabled = False
        tbValorReceb.Enabled = False
        tbTroco.Enabled = False
        cbFormaPagamentoVenda.Enabled = False
        btnCliente.Enabled = False
        btnProcurarProd.Enabled = False
    End Sub

    Sub limpar()
        TextBoxIdVenda.Text = ""
        DgvProdutosVenda.Rows.Clear()
        tbCodProduto.Text = ""
        tbProduto.Text = ""
        tbquantidade.Text = ""
        tbTotalProd.Text = ""
        tbSubTotalVendas.Text = ""
        tbDescontoVenda.Text = ""
        tbTotalCompra.Text = ""
        tbValorReceb.Text = ""
        tbTroco.Text = ""
        tbPreco.Text = ""
        tbestoque.Text = ""
        cbFormaPagamentoVenda.Text = ""
        PictureBoxProd.Image = Nothing
    End Sub

    Private Sub btn_Nova_Click(sender As Object, e As EventArgs) Handles btn_Nova.Click
        PanelSelect.Location = New Point(0, 169)
        PanelSelect.Visible = True
        habilitar()
        limpar()
        valorInicial()
        btn_Finalizar.Enabled = True
        btn_Cancelar.Enabled = True
        btn_Relatório.Enabled = False
        btn_Pesquisar.Enabled = False
    End Sub

    Private Sub btn_Finalizar_Click(sender As Object, e As EventArgs) Handles btn_Finalizar.Click
        PanelSelect.Location = New Point(0, 266)
        PanelSelect.Visible = True
        BuscarIdFunc()
        AddVendaFunc()
        MsgBox("Venda Finalizada!")
    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        PanelSelect.Location = New Point(0, 351)
        PanelSelect.Visible = True
        desabilitar()
        Me.Cursor = Cursors.WaitCursor
        AtualizarEstoqueVendasCancelada()
        limpar()
        Me.Cursor = Cursors.Default
        btn_Finalizar.Enabled = False
        btn_Cancelar.Enabled = False
        btn_Relatório.Enabled = True
        btn_Pesquisar.Enabled = True
    End Sub

    Private Sub btn_Pesquisar_Click(sender As Object, e As EventArgs) Handles btn_Pesquisar.Click
        PanelSelect.Location = New Point(0, 442)
        PanelSelect.Visible = True
    End Sub

    Private Sub btn_Relatório_Click(sender As Object, e As EventArgs) Handles btn_Relatório.Click
        PanelSelect.Location = New Point(0, 533)
        PanelSelect.Visible = True
    End Sub

    Private Sub frmCarrinho_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_Finalizar.Enabled = False
        btn_Cancelar.Enabled = False
        DgvProdutosVenda.ReadOnly = True
        valorInicial()
        buscarDataHora()
    End Sub

    Private Sub btnProcurarProd_Click(sender As Object, e As EventArgs) Handles btnProcurarProd.Click
        frmAddCarrinho.Show()
    End Sub

    Private Sub frmCarrinho_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            debitaestoque()
            Total_produto()
            DgvProdutosVenda.Rows.Add(tbProduto.Text, tbquantidade.Text, tbTotalProd.Text, "X")
            SomarValor()
            tbquantidade.Text = ""
        End If
    End Sub

    Public Sub SomarValor()
        Dim total_compra As Double = 0

        For Each linha As DataGridViewRow In DgvProdutosVenda.Rows
            total_compra = total_compra + linha.Cells(2).Value
        Next
        tbSubTotalVendas.Text = FormatCurrency(total_compra)
        tbTotalCompra.Text = FormatCurrency(total_compra)
    End Sub

    Private Sub Total_produto()
        Dim quantidade As Integer = 0
        Dim preco_U As Double = 0
        Dim total As Double = 0
        preco_U = tbPreco.Text
        quantidade = tbquantidade.Text
        total = preco_U * quantidade
        tbTotalProd.Text = FormatCurrency(total)
    End Sub


    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        frmPCliente2.Show()
    End Sub

    Private Sub tbValorReceb_Leave(sender As Object, e As EventArgs) Handles tbValorReceb.Leave
        Dim valor_total As Double
        Dim valor_recebido As Double
        Dim troco As Double

        valor_total = tbTotalCompra.Text
        valor_recebido = tbValorReceb.Text

        troco = valor_recebido - valor_total
        tbTroco.Text = FormatCurrency(troco)
    End Sub

    Private Sub cbFormaPagamentoVenda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFormaPagamentoVenda.SelectedIndexChanged
        Dim valor_total As Double
        Dim desconto As Double
        Dim valor_desconto As Double

        valor_total = tbTotalCompra.Text

        If cbFormaPagamentoVenda.Text = "Dinheiro" Then
            desconto = valor_total * 0.15
            valor_desconto = valor_total - desconto
            tbDescontoVenda.Text = FormatCurrency(desconto)
            tbTotalCompra.Text = FormatCurrency(valor_desconto)
        ElseIf cbFormaPagamentoVenda.Text = "Cartão de crédito" Then
            desconto = "0.00"
            tbDescontoVenda.Text = FormatCurrency(desconto)
            tbTotalCompra.Text = FormatCurrency(tbSubTotalVendas.Text)
        End If
    End Sub

    Public Sub debitaestoque() 'Debita do estoque a quantidade de produtos escolhida na compra
        Dim cmd As OleDbCommand
        Dim sql As String

        Try
            abrir()
            Dim qtde As Integer
            Dim qtd_menos_estoque = ("SELECT estoque_Produto FROM Produtos WHERE id_Produto =") & idproduto

            cmd = New OleDbCommand(qtd_menos_estoque, con)
            qtd_menos_estoque = CInt(cmd.ExecuteScalar)

            Dim baixaest As Integer
            Dim autcodprod = tbCodProduto.Text
            qtde = Val(tbquantidade.Text)
            baixaest = qtd_menos_estoque - qtde

            sql = "UPDATE Produtos SET estoque_Produto = '" & Val(baixaest) & "' WHERE id_produto = " & Val(autcodprod)
            cmd = New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
        Finally
            fechar()
            cmd = Nothing
        End Try
    End Sub


    Private Sub DgvProdutosVenda_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvProdutosVenda.RowHeaderMouseClick
        DgvProdutosVenda.Rows.RemoveAt(DgvProdutosVenda.CurrentRow.Index)
        SomarValor()
    End Sub

    Sub BuscarIdFunc() 'Busca o ID do funcionário
        Dim cmdUser As New OleDbCommand
        Dim reader As OleDbDataReader
        Dim sql As String

        Try
            Dim nomePesquisa As String = frmMenu.LabelNomeFunc.Text
            fechar()
            abrir()

            sql = "SELECT id_Func FROM Funcionarios WHERE nome_Func = '" & nomePesquisa & "'"
            cmdUser = New OleDbCommand(sql, con)
            reader = cmdUser.ExecuteReader
            reader.Read()
            idFuncVenda = reader.GetInt32(0)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Sub AddVendaFunc() 'Adiciona venda para o funcionário
        Dim cmd As OleDbCommand
        Dim sql As String

        Try
            abrir()
            Dim qtde As Integer = 1
            Dim qtd_venda_Func = ("SELECT vendas_Func FROM Funcionarios WHERE id_Func =") & idFuncVenda

            cmd = New OleDbCommand(qtd_venda_Func, con)
            qtd_venda_Func = CInt(cmd.ExecuteScalar)

            Dim addestoque As Integer
            Dim autcodfunc = idFuncVenda

            addestoque = qtd_venda_Func + qtde

            sql = "UPDATE Funcionarios SET vendas_Func = '" & Val(addestoque) & "' WHERE id_Func = " & Val(autcodfunc)
            cmd = New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
        Finally
            fechar()
            cmd = Nothing
        End Try
    End Sub

    Sub BuscarEstoqueAtual() 'Busca o estoque atual
        Dim cmdUser As New OleDbCommand
        Dim reader As OleDbDataReader
        Dim sql As String

        Try
            fechar()
            abrir()

            sql = "SELECT estoque_Produto FROM Produtos WHERE id_Produto = " & tbCodProduto.Text
            cmdUser = New OleDbCommand(sql, con)
            reader = cmdUser.ExecuteReader
            reader.Read()
            estoqueAtual = reader.GetString(0)

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Sub BuscarEstoqueVendaCancelada(nome As String) 'Busca o estoque 
        Dim cmdUser As New OleDbCommand
        Dim reader As OleDbDataReader
        Dim sql As String

        Try
            fechar()
            abrir()

            sql = "SELECT estoque_Produto FROM Produtos WHERE nome_Produto = '" & nome & "'"

            cmdUser = New OleDbCommand(sql, con)
            reader = cmdUser.ExecuteReader
            reader.Read()
            estoqueAtual = reader.GetString(0)

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Sub AtualizarEstoqueVendasCancelada() 'Atualiza o estoque quando a venda é cancelada
        Dim nome As String
        Dim qntProd As Integer
        Dim cmdUser As New OleDbCommand
        Dim sql As String

        For Each col As DataGridViewRow In DgvProdutosVenda.Rows
            nome = col.Cells(0).Value.ToString
            qntProd = col.Cells(1).Value.ToString

            BuscarEstoqueVendaCancelada(nome)

            Try
                fechar()
                abrir()

                sql = "UPDATE Produtos SET estoque_Produto = " & estoqueAtual + qntProd & " WHERE nome_Produto = '" & nome & "'"
                cmdUser = New OleDbCommand(sql, con)
                cmdUser.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                fechar()
            End Try
        Next
    End Sub

    Sub AtualizarEstoqueProdutoCancelado()
        Dim nome As String
        Dim qntProd As Integer
        Dim cmdUser As New OleDbCommand
        Dim sql As String

        nome = DgvProdutosVenda.CurrentRow.Cells(0).Value.ToString
        qntProd = DgvProdutosVenda.CurrentRow.Cells(1).Value.ToString

        BuscarEstoqueVendaCancelada(nome)

        Try
            fechar()
            abrir()

            sql = "UPDATE Produtos SET estoque_Produto = " & estoqueAtual + qntProd & " WHERE nome_Produto = '" & nome & "'"
            cmdUser = New OleDbCommand(sql, con)
            cmdUser.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            fechar()
        End Try
    End Sub

    Private Sub DgvProdutosVenda_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvProdutosVenda.CellContentClick
        If DgvProdutosVenda.CurrentCell.Value.ToString = "X" Then

            AtualizarEstoqueProdutoCancelado()
            DgvProdutosVenda.Rows.RemoveAt(DgvProdutosVenda.CurrentRow.Index)
        End If
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    Sub buscarDataHora()
        lblData.Text = Now.ToShortDateString
        lblHora.Text = Now.ToShortTimeString
    End Sub
End Class