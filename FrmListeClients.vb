Imports IAPM_DIAZ.GestionBDD
Public Class FrmListeClients
    Private Sub FrmListeClients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmStart
        Me.Left = 0
        Me.Top = 0
        DataGridClients.DataSource = GestionClient.GetLesClients()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class