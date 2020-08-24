Imports System.IO

Public Class frmBackup
    Private Sub X_Click(sender As Object, e As EventArgs) Handles X.Click
        If MessageBox.Show("Deseja realmente sair?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
            Me.Close()
            frmLogin.Refresh()
            frmLogin.Visible = True
        End If
    End Sub

    Private Sub Panel_Backup_Click(sender As Object, e As EventArgs) Handles Panel_Backup.Click
        Try
            Dim fdb As New FolderBrowserDialog
            If fdb.ShowDialog() = vbOK Then
                File.Copy("LLConstrucoes.mdb", fdb.SelectedPath & "\LLConstrucoes.mdb")
                MsgBox("Backup feito com sucesso!")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PanelRestaurarBackup_Click(sender As Object, e As EventArgs) Handles PanelRestaurarBackup.Click
        Try
            Dim fdb As New FolderBrowserDialog
            If fdb.ShowDialog() = vbOK Then
                File.Delete("LLConstrucoes.mdb")
                File.Copy(fdb.SelectedPath & "\LLConstrucoes.mdb", "LLConstrucoes.mdb")
                MsgBox("Restauração feita com sucesso!")
                Application.Restart()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class