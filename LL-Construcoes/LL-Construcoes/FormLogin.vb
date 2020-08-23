Imports System.Data.OleDb
Imports System.IO

Public Class frmLogin
    Dim login As String
    Dim senha As String
    Dim fotoFuncionario As Bitmap

    Private Sub X_Click(sender As Object, e As EventArgs) Handles X.Click
        Application.Exit()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        'Permite visualizar/esconder a senha
        If (CheckBox1.Checked) Then
            txtpassword.PasswordChar = ""
        Else
            txtpassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Entrar.Click
        login = txtuser.Text()
        senha = txtpassword.Text()
        abrir()
        Try
            Dim cmdUser As New OleDbCommand
            Dim reader As OleDbDataReader
            Dim sql As String

            sql = "SELECT usuario_Func, senha_Func, cargo_Func FROM Funcionarios WHERE usuario_Func = '" & login & "' AND senha_Func = '" & senha & "'"
            cmdUser = New OleDbCommand(sql, con)
            reader = cmdUser.ExecuteReader

            If reader.Read Then
                permissao = reader.GetString(2)
                txtuser.Text = "Usuário"
                txtpassword.Text = "Senha"
                If permissao = "Gerente" Then
                    PermissaoAdmin()
                Else
                    PermissaoVendedor()
                End If
            Else
                MsgBox("Dados Incorretos!")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtuser_Leave(sender As Object, e As EventArgs) Handles txtuser.Leave
        If (txtuser.Text = "") Then
            txtuser.Text = "Usuário"
        End If
    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles txtuser.Enter
        If (txtuser.Text = "Usuário") Then
            txtuser.Text = ""
        End If
    End Sub

    Private Sub txtpassword_Leave(sender As Object, e As EventArgs) Handles txtpassword.Leave
        If (txtpassword.Text = "") Then
            txtpassword.PasswordChar = ""
            txtpassword.Text = "Senha"
        End If
    End Sub

    Private Sub txtpassword_Enter(sender As Object, e As EventArgs) Handles txtpassword.Enter
        If (CheckBox1.Checked = False) Then
            txtpassword.PasswordChar = "*"
        End If

        If (txtpassword.Text = "Senha") Then
            txtpassword.Text = ""
        End If
    End Sub

    Private Sub frmLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            login = txtuser.Text()
            senha = txtpassword.Text()
            abrir()
            Try
                Dim cmdUser As New OleDbCommand
                Dim reader As OleDbDataReader
                Dim sql As String

                sql = "SELECT usuario_Func, senha_Func, cargo_Func FROM Funcionarios WHERE usuario_Func = '" & login & "' AND senha_Func = '" & senha & "'"
                cmdUser = New OleDbCommand(sql, con)
                reader = cmdUser.ExecuteReader

                If reader.Read Then
                    permissao = reader.GetString(2)
                    txtuser.Text = "Usuário"
                    txtpassword.Text = "Senha"

                    If permissao = "Gerente" Then
                        PermissaoAdmin()
                    ElseIf permissao = "Funcionario" Then
                        PermissaoVendedor()
                    Else
                        MsgBox("Você não tem permissão suficiente para logar no sistema")
                    End If
                Else
                    MsgBox("Dados Incorretos!")
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtuser.Select()
    End Sub

    Sub PermissaoAdmin()
        frmMenu.Show()
        Me.Visible = False
        CarregarFoto()
        BuscarNome()
    End Sub

    Sub PermissaoVendedor()
        frmMenu.Show()
        Me.Visible = False
        frmMenu.Panel_Func.Visible = False
        CarregarFoto()
        BuscarNome()
    End Sub

    Sub BuscarNome()
        Dim cmdUser As New OleDbCommand
        Dim reader As OleDbDataReader
        Dim sql As String

        fechar()
        abrir()
        Try
            sql = "SELECT nome_Func FROM Funcionarios WHERE usuario_Func = '" & login & "' AND senha_Func = '" & senha & "'"
            cmdUser = New OleDbCommand(sql, con)
            reader = cmdUser.ExecuteReader
            reader.Read()
            frmMenu.LabelNomeFunc.Text = reader.GetString(0)
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        fechar()
    End Sub

    Sub CarregarFoto()
        Dim cmdUser As New OleDbCommand
        Dim reader As OleDbDataReader
        Dim sql As String

        Try
            sql = "SELECT foto_Func FROM Funcionarios WHERE usuario_Func = '" & login & "' AND senha_Func = '" & senha & "'"
            cmdUser = New OleDbCommand(sql, con)
            reader = cmdUser.ExecuteReader

            If reader.HasRows Then
                reader.Read()

                Dim blob As Byte() = DirectCast(reader.Item("foto_Func"), Byte())
                Using ms = New MemoryStream(blob)
                    fotoFuncionario = New Bitmap(ms)
                End Using
                frmMenu.FotoFuncPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
                frmMenu.FotoFuncPictureBox.Image = fotoFuncionario
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
