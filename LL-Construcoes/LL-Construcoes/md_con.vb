Imports System.Data.OleDb

Module md_con

    Public con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = LLConstrucoes.mdb;")

    Sub abrir()
        If con.State = 0 Then
            con.Open()
        End If
    End Sub

    Sub fechar()
        If con.State = 1 Then
            con.Close()
        End If
    End Sub
End Module

