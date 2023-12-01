Public Class FrmConnexion
    Private Sub FrmConnexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmStart
        Me.Left = 0
        Me.Top = 0

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        TextBoxServeur.Text = "Saisir ici votre Serveur : localhost / sxxxPxx"
        TextBoxBDD.Text = "Saisir ici votre BDD : GestStage!"
        TextBoxLogin.Text = ""
        TextBoxMdp.Text = ""
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Connexion()
    End Sub

    Private Sub TextBoxBDD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxBDD.KeyPress
        If e.KeyChar = Chr(13) Then
            Connexion()
        End If

    End Sub

    Public Sub Connexion()
        Try

            GestionBDD.SeConnecter(TextBoxServeur.Text, TextBoxBDD.Text, TextBoxLogin.Text, TextBoxMdp.Text)
            FrmStart.ClientToolStripMenuItem.Enabled = True
            FrmStart.ProduitToolStripMenuItem.Enabled = True
            FrmStart.CommandeToolStripMenuItem.Enabled = True
            FrmStart.FournisseurToolStripMenuItem.Enabled = True
            FrmStart.CatégorieToolStripMenuItem.Enabled = True
            FrmStart.StatistiquesToolStripMenuItem.Enabled = True
            FrmStart.AProposToolStripMenuItem.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Erreur dans les paramètres de connection : Serveur / BDD / Login / Mdp")
            Exit Sub
        End Try

        Me.Close()
    End Sub

    Private Sub btnAuto_Click(sender As Object, e As EventArgs) Handles btnAuto.Click
        TextBoxServeur.Text = "localhost"
        TextBoxBDD.Text = "ppe_marchand_diaz"
        TextBoxLogin.Text = "root"
        TextBoxMdp.Text = "root"
    End Sub
End Class