Imports System.Data.OleDb
Imports System.IO

Public Class frmAddCarrinho
    Private Sub X_Click(sender As Object, e As EventArgs) Handles X.Click
        If MessageBox.Show("Deseja realmente sair?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
            Me.Close()
            frmCarrinho.Show()
        End If
    End Sub

    Private Sub listar()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As OleDbDataAdapter
            Dim sql As String

            sql = "SELECT * FROM Produtos ORDER By nome_Produto ASC"
            da = New OleDbDataAdapter(sql, con)

            da.Fill(dt)
            dgv_produto.DataSource = dt
            FormatarDG()
            ContarLinhas()
        Catch ex As Exception
            MsgBox(ex.Message)
            fechar()
        End Try
    End Sub

    Private Sub FormatarDG()
        dgv_produto.Columns(0).Visible = False
        dgv_produto.Columns(1).HeaderText = "Nome"
        dgv_produto.Columns(2).HeaderText = "Marca"
        dgv_produto.Columns(3).HeaderText = "Cor"
        dgv_produto.Columns(4).HeaderText = "Preço"
        dgv_produto.Columns(5).HeaderText = "Estoque"
        dgv_produto.Columns(6).HeaderText = "Categoria"
        dgv_produto.Columns(7).HeaderText = "SubCategoria"
    End Sub

    Private Sub ContarLinhas()
        Dim total As Integer = dgv_produto.Rows.Count
        Label3.Text = total - 1
    End Sub

    Private Sub buscarnome()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As OleDbDataAdapter
            Dim sql As String

            sql = "SELECT * FROM Produtos WHERE nome_Produto LIKE '" & mtb_procurar.Text & "%' ORDER BY nome_Produto ASC"
            da = New OleDbDataAdapter(sql, con)
            da.Fill(dt)
            dgv_produto.DataSource = dt
            FormatarDG()
            ContarLinhas()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub buscarmarca()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As OleDbDataAdapter
            Dim sql As String

            sql = "SELECT * FROM Produtos WHERE marca_Produto LIKE '" & mtb_procurar.Text & "%' ORDER BY marca_Produto ASC"
            da = New OleDbDataAdapter(sql, con)
            da.Fill(dt)
            dgv_produto.DataSource = dt
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

    Private Sub rbMarca_CheckedChanged(sender As Object, e As EventArgs) Handles rbMarca.CheckedChanged
        Me.mtb_procurar.UseSystemPasswordChar = False
        Me.mtb_procurar.Mask = ""
        Me.mtb_procurar.Focus()
    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        frmCarrinho.Show()
        Me.Close()
    End Sub

    Private Sub frmPProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbNome.Checked = True
        listar()
    End Sub

    Private Sub mtb_procurar_TextChanged(sender As Object, e As EventArgs) Handles mtb_procurar.TextChanged
        If rbNome.Checked = True Then
            buscarnome()
        End If

        If rbMarca.Checked = True Then
            buscarmarca()
        End If

    End Sub

    Private Sub dgv_produto_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgv_produto.MouseDoubleClick
        Dim id As Integer
        Dim nome As String
        Dim preco As String
        Dim estoque As Integer

        id = dgv_produto.CurrentRow.Cells(0).Value
        nome = dgv_produto.CurrentRow.Cells(1).Value
        preco = dgv_produto.CurrentRow.Cells(4).Value
        estoque = dgv_produto.CurrentRow.Cells(5).Value

        Dim img As Byte() = dgv_produto.CurrentRow.Cells(10).Value
        Dim ms As MemoryStream = New MemoryStream(img)
        frmCarrinho.PictureBoxProd.Image = System.Drawing.Image.FromStream(ms)
        frmCarrinho.PictureBoxProd.SizeMode = PictureBoxSizeMode.StretchImage

        If id <> 0 Then
            Dim form = New frmCarrinho()

            idproduto = id
            nome_p = nome
            preco_p = preco
            estoque_p = estoque

            frmCarrinho.tbCodProduto.Text = id
            frmCarrinho.tbProduto.Text = nome_p
            frmCarrinho.tbPreco.Text = preco_p
            frmCarrinho.tbestoque.Text = estoque_p

            frmCarrinho.tbquantidade.Text = ""
            frmCarrinho.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btn_Ok_Click(sender As Object, e As EventArgs) Handles btn_Ok.Click
        Dim id As Integer
        Dim nome As String
        Dim preco As String
        Dim estoque As Integer

        id = dgv_produto.CurrentRow.Cells(0).Value
        nome = dgv_produto.CurrentRow.Cells(1).Value
        preco = dgv_produto.CurrentRow.Cells(4).Value
        estoque = dgv_produto.CurrentRow.Cells(5).Value

        Dim img As Byte() = dgv_produto.CurrentRow.Cells(10).Value
        Dim ms As MemoryStream = New MemoryStream(img)
        frmCarrinho.PictureBoxProd.Image = System.Drawing.Image.FromStream(ms)
        frmCarrinho.PictureBoxProd.SizeMode = PictureBoxSizeMode.StretchImage

        If id <> 0 Then
            Dim form = New frmCarrinho()

            idproduto = id
            nome_p = nome
            preco_p = preco
            estoque_p = estoque

            frmCarrinho.tbCodProduto.Text = id
            frmCarrinho.tbProduto.Text = nome_p
            frmCarrinho.tbPreco.Text = preco_p
            frmCarrinho.tbestoque.Text = estoque_p

            frmCarrinho.tbquantidade.Text = ""
            frmCarrinho.Show()
            Me.Close()
        End If
    End Sub
End Class