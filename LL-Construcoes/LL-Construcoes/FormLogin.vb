Imports System.Data.OleDb
Imports System.IO

Public Class frmLogin
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
        abrir()
        Try
            Dim cmdUser As New OleDbCommand
            Dim reader As OleDbDataReader
            Dim sql As String

            sql = "SELECT usuario_Func, senha_Func, cargo_Func FROM Funcionarios WHERE usuario_Func = '" & txtuser.Text & "' AND senha_Func = '" & txtpassword.Text & "'"
            cmdUser = New OleDbCommand(sql, con)
            reader = cmdUser.ExecuteReader

            If reader.Read Then
                permissao = reader.GetString(2)
                txtuser.Text = "Usuário"
                txtpassword.Text = "Senha"
                If permissao = "Gerente" Then
                    frmMenu.Show()
                    Me.Visible = False
                Else
                    frmMenu.Show()
                    Me.Visible = False
                    frmMenu.Panel_Func.Visible = False
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
            abrir()
            Try
                Dim cmdUser As New OleDbCommand
                Dim reader As OleDbDataReader
                Dim sql As String

                sql = "SELECT * FROM Funcionarios WHERE usuario_Func = '" & txtuser.Text & "' AND senha_Func = '" & txtpassword.Text & "'"
                cmdUser = New OleDbCommand(sql, con)
                reader = cmdUser.ExecuteReader

                If reader.Read Then
                    permissao = reader.GetString(2)
                    txtuser.Text = "Usuário"
                    txtpassword.Text = "Senha"
                    If permissao = "Gerente" Then
                        frmMenu.Show()
                        Me.Visible = False
                    Else
                        frmMenu.Show()
                        Me.Visible = False
                        frmMenu.Panel_Func.Visible = False
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
End Class
