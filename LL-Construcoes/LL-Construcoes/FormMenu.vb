﻿Imports System.IO

Public Class frmMenu

    Private Sub Panel_Cliente_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel_Cliente.MouseClick
        frmCliente.Show()
        Me.Visible = False
    End Sub

    Private Sub Panel4_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel_Produto.MouseClick
        frmProduto.Show()
        Me.Visible = False
    End Sub

    Private Sub Panel_Func_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel_Func.MouseClick
        frmFuncionario.Show()
        Me.Visible = False
    End Sub

    Private Sub Panel_Fornec_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel_Fornec.MouseClick
        frmFornecedores.Show()
        Me.Visible = False
    End Sub

    Private Sub Panel_Carrinho_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel_Carrinho.MouseClick
        frmCarrinho.Show()
        Me.Visible = False
    End Sub

    Private Sub X_Click(sender As Object, e As EventArgs) Handles X.Click
        If MessageBox.Show("Deseja realmente sair?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
            Me.Close()
            frmLogin.Refresh()
            frmLogin.Visible = True
        End If
    End Sub

    Private Sub Panel_Backup_Click(sender As Object, e As EventArgs) Handles Panel_Backup.Click
        frmBackup.Show()
    End Sub

    Private Sub PictureBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseClick
        frmCliente.Show()
        Me.Visible = False
    End Sub

    Private Sub PictureBox2_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseClick
        frmProduto.Show()
        Me.Visible = False
    End Sub

    Private Sub PictureBox3_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseClick
        frmFuncionario.Show()
        Me.Visible = False
    End Sub

    Private Sub PictureBox4_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseClick
        frmFornecedores.Show()
        Me.Visible = False
    End Sub

    Private Sub PictureBox6_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox6.MouseClick
        frmCarrinho.Show()
        Me.Visible = False
    End Sub

    Private Sub PictureBox5_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox5.MouseClick
        frmBackup.Show()
    End Sub

End Class