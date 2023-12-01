Imports IAPM_DIAZ.GestionBDD
Imports IAPM_DIAZ.GestionProduit
Imports IAPM_DIAZ.GestionClient
Imports IAPM_DIAZ.GestionCommandes
Imports IAPM_DIAZ.GestionInterface

Public Class FrmDetailCommande

    Public Sub New(idcom As Integer, datecom As String)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()
        TextBoxNumero.Text = idcom
        TextBoxDate.Text = datecom

        TextBoxMontant.Text = GetMontantHTByCommande(idcom)
        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

    End Sub
    Private Sub FrmDetailCommande_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmStart
        Me.Left = 0
        Me.Top = 0
        ComboBoxClient.Enabled = False
        GestionInterface.AlimenterComboBox(ComboBoxCategorie, GestionCategorie.GetLesCategories, "LibelleCategorie", "idCategorie")
        GestionInterface.AlimenterComboBox(ComboBoxProduit, GestionProduit.GetLesProduits, "LibelleProduit", "idProduit")
        DataGridViewCommand.DataSource = GestionProduit.GetLesProduitsByIdCommande(TextBoxNumero.Text)
        GestionInterface.AlimenterComboBox(ComboBoxClient, GetClientById(TextBoxNumero.Text), “NomUtilisateur”, “idUtilisateur”)
        Rafraichir()

    End Sub
    Dim position

    Public Sub Rafraichir()
        Dim MesCommandesDG As DataTable = GestionProduit.GetLesProduitsByIdCommande(TextBoxNumero.Text)
        DataGridViewCommand.DataSource = GestionProduit.GetLesProduitsByIdCommande(TextBoxNumero.Text)
        TextBoxNumero.Text = MesCommandesDG.Rows(position).Item(0)
        TextBoxDate.Text = MesCommandesDG.Rows(position).Item(1)
        GestionInterface.AlimenterComboBox(ComboBoxClient, GetClientById(TextBoxNumero.Text), “NomUtilisateur”, “idUtilisateur”)



        TextBoxMontant.Text = GestionCommandes.GetMontantHTByCommande(TextBoxNumero.Text)
        DataGridViewCommand.ClearSelection()
        DataGridViewCommand.Rows(position).Selected = True

    End Sub

    Private Sub btnFermer_Click(sender As Object, e As EventArgs) Handles btnFermer.Click
        Me.Hide()
    End Sub

    Private Sub ComboBoxCategorie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCategorie.SelectedIndexChanged
        GestionInterface.AlimenterComboBox(ComboBoxProduit, GestionProduit.ProduitParCategorie(ComboBoxCategorie.Text), "LibelleProduit", "idProduit")
    End Sub

    Private Sub btnRetirerCommande_Click(sender As Object, e As EventArgs) Handles btnRetirerCommande.Click
        Try
            GestionProduit.SupprimerProduit(TextBoxNumero.Text, DataGridViewCommand.CurrentRow.Cells(0).Value)
        Catch ex As Exception
            MessageBox.Show("erreur de suppression de produit:" & ex.Message)
        End Try

    End Sub

    Private Sub btnAjouterCommande_Click(sender As Object, e As EventArgs) Handles btnAjouterCommande.Click
        Try
            GestionProduit.AjouterProduit(TextBoxNumero.Text, ComboBoxProduit.SelectedValue, TextBoxQuantite.Text)
        Catch ex As Exception
            MessageBox.Show("erreur d'insertion de produit:" & ex.Message)
        End Try
        Rafraichir()
    End Sub
End Class