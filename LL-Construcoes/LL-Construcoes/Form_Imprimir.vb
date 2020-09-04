Public Class Form_Imprimir
    Private Sub Form_Imprimir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'LLConstrucoesDataSet.Clientes'. Você pode movê-la ou removê-la conforme necessário.
        Me.ClientesTableAdapter.Fill(Me.LLConstrucoesDataSet.Clientes)

        Me.ReportViewer1.RefreshReport()
    End Sub

End Class