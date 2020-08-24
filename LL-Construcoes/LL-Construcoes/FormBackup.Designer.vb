<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackup
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel_Backup = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.X = New System.Windows.Forms.Button()
        Me.PanelRestaurarBackup = New System.Windows.Forms.Panel()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel_Backup.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.PanelRestaurarBackup.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Backup
        '
        Me.Panel_Backup.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Panel_Backup.Controls.Add(Me.PictureBox5)
        Me.Panel_Backup.Controls.Add(Me.Label3)
        Me.Panel_Backup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel_Backup.Location = New System.Drawing.Point(12, 46)
        Me.Panel_Backup.Name = "Panel_Backup"
        Me.Panel_Backup.Size = New System.Drawing.Size(250, 150)
        Me.Panel_Backup.TabIndex = 18
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.LL_Construcoes.My.Resources.Resources.icons8_backup_de_dados_80
        Me.PictureBox5.Location = New System.Drawing.Point(91, 18)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 11
        Me.PictureBox5.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(92, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Backup"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel2.Controls.Add(Me.X)
        Me.Panel2.Location = New System.Drawing.Point(-2, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(306, 32)
        Me.Panel2.TabIndex = 19
        '
        'X
        '
        Me.X.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.X.FlatAppearance.BorderSize = 0
        Me.X.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed
        Me.X.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.X.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.X.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.X.ForeColor = System.Drawing.Color.White
        Me.X.Location = New System.Drawing.Point(244, 2)
        Me.X.Margin = New System.Windows.Forms.Padding(0)
        Me.X.Name = "X"
        Me.X.Size = New System.Drawing.Size(30, 30)
        Me.X.TabIndex = 42
        Me.X.Text = "X"
        Me.X.UseVisualStyleBackColor = True
        '
        'PanelRestaurarBackup
        '
        Me.PanelRestaurarBackup.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.PanelRestaurarBackup.Controls.Add(Me.PictureBox7)
        Me.PanelRestaurarBackup.Controls.Add(Me.Label7)
        Me.PanelRestaurarBackup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelRestaurarBackup.Location = New System.Drawing.Point(12, 202)
        Me.PanelRestaurarBackup.Name = "PanelRestaurarBackup"
        Me.PanelRestaurarBackup.Size = New System.Drawing.Size(250, 150)
        Me.PanelRestaurarBackup.TabIndex = 20
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.LL_Construcoes.My.Resources.Resources.icons8_backup_de_dados_80
        Me.PictureBox7.Location = New System.Drawing.Point(91, 18)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox7.TabIndex = 11
        Me.PictureBox7.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(42, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(178, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Restaurar Backup"
        '
        'frmBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 369)
        Me.Controls.Add(Me.PanelRestaurarBackup)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel_Backup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBackup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormBackup"
        Me.Panel_Backup.ResumeLayout(False)
        Me.Panel_Backup.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.PanelRestaurarBackup.ResumeLayout(False)
        Me.PanelRestaurarBackup.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Backup As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents X As Button
    Friend WithEvents PanelRestaurarBackup As Panel
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label7 As Label
End Class
