﻿Imports System.Data.OleDb
Imports System.IO

Public Class frmCarrinho

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
    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        PanelSelect.Location = New Point(0, 351)
        PanelSelect.Visible = True
        desabilitar()
        adicionarestoque()
        limpar()
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
        valorInicial()
    End Sub

    Private Sub btnProcurarProd_Click(sender As Object, e As EventArgs) Handles btnProcurarProd.Click
        frmAddCarrinho.Show()
    End Sub

    Private Sub frmCarrinho_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            debitaestoque()
            Total_produto()
            DgvProdutosVenda.Rows.Add(tbProduto.Text, tbquantidade.Text, tbTotalProd.Text)
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

    Public Sub debitaestoque()
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

    Public Sub adicionarestoque() 'Em Desenvolvimento'
        Dim cmd As OleDbCommand
        Dim sql As String

        Try
            abrir()
            Dim qtde As Integer
            Dim qtd_mais_estoque = ("SELECT estoque_Produto FROM Produtos WHERE id_Produto =") & idproduto

            cmd = New OleDbCommand(qtd_mais_estoque, con)
            qtd_mais_estoque = CInt(cmd.ExecuteScalar)

            Dim addestoque As Integer
            Dim autcodprod = tbCodProduto.Text
            qtde = DgvProdutosVenda.CurrentRow.Cells(1).Value
            addestoque = qtd_mais_estoque + qtde

            sql = "UPDATE Produtos SET estoque_Produto = '" & Val(addestoque) & "' WHERE id_produto = " & Val(autcodprod)
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
        adicionarestoque()
    End Sub
End Class