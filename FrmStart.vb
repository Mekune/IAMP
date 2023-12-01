Imports IAPM_DIAZ.GestionBDD
Public Class FrmStart
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClientToolStripMenuItem.Enabled = False
        ProduitToolStripMenuItem.Enabled = False
        CommandeToolStripMenuItem.Enabled = False
        FournisseurToolStripMenuItem.Enabled = False
        CatégorieToolStripMenuItem.Enabled = False
        StatistiquesToolStripMenuItem.Enabled = False
        AProposToolStripMenuItem.Enabled = False
    End Sub

    Private Sub ListeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeToolStripMenuItem.Click
        Dim LS As New FrmListeClients
        LS.Show()
    End Sub

    Private Sub AjoutSuprModifToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjoutSuprModifToolStripMenuItem.Click
        Dim LS As New AsmClient
        LS.Show()
    End Sub

    Private Sub AjoutSuprModifToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AjoutSuprModifToolStripMenuItem1.Click
        Dim LS As New AsmProduit
        LS.Show()
    End Sub

    Private Sub ConnexionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnexionToolStripMenuItem.Click
        Dim LS As New FrmConnexion
        LS.Show()
    End Sub

    Private Sub AjoutSuprModifToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AjoutSuprModifToolStripMenuItem2.Click
        Dim LS As New FrmAMSCommandes
        LS.Show()
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AjoutSuprModifToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles AjoutSuprModifToolStripMenuItem3.Click
        Dim LS As New AsmFournisseur
        LS.Show()
    End Sub
End Class
