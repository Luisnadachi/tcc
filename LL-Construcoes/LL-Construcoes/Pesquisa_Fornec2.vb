Imports System.Data.OleDb
Imports System.IO

Public Class frmPFornec2
    Private Sub X_Click(sender As Object, e As EventArgs) Handles X.Click
        If MessageBox.Show("Deseja realmente sair?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
            Me.Close()
            frmProduto.Show()
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
        frmProduto.Show()
        Me.Close()
    End Sub

    Private Sub frmPFornec2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        id = dgv_fornec.CurrentRow.Cells(0).Value
        nome = dgv_fornec.CurrentRow.Cells(1).Value

        If id <> 0 Then
            Dim form = New frmProduto()

            nome_f = nome

            frmProduto.TextBoxFornProd.Text = nome_f

            frmProduto.Show()
            id = dgv_fornec.CurrentRow().Cells(0).Value
            Me.Close()
        End If
    End Sub

    Private Sub btn_Ok_Click(sender As Object, e As EventArgs) Handles btn_Ok.Click

        Dim id As Integer
        Dim nome As String

        id = dgv_fornec.CurrentRow.Cells(0).Value
        nome = dgv_fornec.CurrentRow.Cells(1).Value

        If id <> 0 Then
            Dim form = New frmProduto()

            nome_f = nome

            frmProduto.TextBoxFornProd.Text = nome_f

            frmProduto.Show()
            id = dgv_fornec.CurrentRow().Cells(0).Value
            Me.Close()
        End If
    End Sub
End Class