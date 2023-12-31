﻿Imports IAPM_DIAZ

Public Class AsmProduit
    Dim position
    Private Sub AsmProduit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmStart
        Me.Left = 0
        Me.Top = 0
        DataGridView.DataSource = GestionProduit.GetLesProduitsDG()
        GestionInterface.AlimenterComboBox(ComboBoxFournisseur, GestionFournisseurs.GetLesFournisseurs, “Nom
isseur”, “idFournisseur”)
        GestionInterface.AlimenterComboBox(ComboBoxCategorieProduit, GestionCategorie.GetLesCategories, “LibelleCategorie”, “idCategorie”)
        Rafraichir()
        TextBoxCodeProduit.Enabled = False


    End Sub

    Public Sub Rafraichir()
        Dim MesProduits As DataTable = GestionProduit.GetLesProduits()
        TextBoxCodeProduit.Text = MesProduits.Rows(position).Item(0)
        TextBoxLibelleProduit.Text = MesProduits.Rows(position).Item(1)
        TextBoxPrixProduit.Text = MesProduits.Rows(position).Item(3)
        TextBoxQStockProduit.Text = MesProduits.Rows(position).Item(4)
        ComboBoxFournisseur.SelectedValue = MesProduits.Rows(position).Item(5)
        ComboBoxCategorieProduit.SelectedValue = MesProduits.Rows(position).Item(6)

        DataGridView.ClearSelection()
        DataGridView.Rows(position).Selected = True

    End Sub

    Private Sub Quitter_Click(sender As Object, e As EventArgs) Handles Quitter.Click
        Me.Hide()
    End Sub

    Private Sub Btnsuiv_Click(sender As Object, e As EventArgs) Handles Btnsuiv.Click
        If (position < GestionProduit.GetNBProduits() - 1) Then
            position = position + 1
        End If
        Rafraichir()
    End Sub

    Private Sub Btnpre_Click(sender As Object, e As EventArgs) Handles Btnpre.Click
        If (position > 0) Then
            position = position - 1
        End If
        Rafraichir()
    End Sub

    Private Sub BtnDeb_Click(sender As Object, e As EventArgs) Handles BtnDeb.Click
        position = 0
        Rafraichir()
    End Sub

    Private Sub BtnFin_Click(sender As Object, e As EventArgs) Handles BtnFin.Click
        position = GestionProduit.GetNBProduits() - 1
        Rafraichir()
    End Sub

    Private Sub btnAjout_Click(sender As Object, e As EventArgs) Handles btnAjout.Click
        If btnAjout.Text = "+" Then
            btnAjout.Text = "Valider"
            ComboBoxCategorieProduit.Enabled = True
            ComboBoxFournisseur.Enabled = True
            TextBoxCodeProduit.Text = ""
            TextBoxLibelleProduit.Text = ""
            TextBoxPrixProduit.Text = ""
            TextBoxQStockProduit.Text = ""
            ComboBoxFournisseur.Text = ""
            ComboBoxCategorieProduit.Text = ""
        Else
            Dim n, p, r, cp, v As String
            Dim answer As Integer
            answer = MsgBox("Voulez vous vraiment ajouter le produit N° " & TextBoxCodeProduit.Text & " Ajouter", MessageBoxButtons.YesNo)
            If answer = vbYes Then
                MsgBox("Produit n° " & TextBoxCodeProduit.Text & " Ajouter")
                n = TextBoxLibelleProduit.Text
                p = TextBoxPrixProduit.Text
                r = TextBoxQStockProduit.Text
                cp = ComboBoxFournisseur.SelectedValue
                v = ComboBoxCategorieProduit.SelectedValue
                GestionProduit.AjouterProduit(n, p, r, cp, v)
                btnAjout.Text = "+"
                ComboBoxCategorieProduit.Enabled = False
                ComboBoxFournisseur.Enabled = False
                DataGridView.DataSource = GestionProduit.GetLesProduitsDG()
                Rafraichir()
            End If
        End If
    End Sub

    Private Sub ComboBoxFournisseur_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxFournisseur.SelectedIndexChanged

    End Sub

    Private Sub btnSupr_Click(sender As Object, e As EventArgs) Handles btnSupr.Click
        Dim id As Integer
        Dim answer As Integer
        id = TextBoxCodeProduit.Text
        answer = MsgBox("Voulez vous vraiment suprimmer le client N° " & TextBoxCodeProduit.Text & " Supprimer", MessageBoxButtons.YesNo)
        If answer = vbYes Then
            MsgBox("Client n° " & TextBoxCodeProduit.Text & " Supprimer")
            GestionProduit.SupprimerProduit(id)
            DataGridView.DataSource = GestionProduit.GetLesProduitsDG()
            position = 0
            Rafraichir()
        Else
        End If
    End Sub

    Private Sub btnModif_Click(sender As Object, e As EventArgs) Handles btnModif.Click

        'If btnAjout.Text = "+" Then
        '    btnAjout.Text = "Valider"
        '    ComboBoxCategorieProduit.Enabled = True
        '    ComboBoxFournisseur.Enabled = True
        '    TextBoxCodeProduit.Text = Generer_Cle_Primaire("IdProduit", "Produit")
        '    TextBoxLibelleProduit.Text = ""
        '    TextBoxPrixProduit.Text = ""
        '    TextBoxQStockProduit.Text = ""
        '    ComboBoxFournisseur.Text = ""
        '    ComboBoxCategorieProduit.Text = ""
        'Else
        '    Dim n, p, r, cp, v As String
        '    Dim answer As Integer
        '    answer = MsgBox("Voulez vous vraiment ajouter le client N° " & TextBoxCodeProduit.Text & " Ajouter", MessageBoxButtons.YesNo)
        '    If answer = vbYes Then
        '        MsgBox("Client n° " & TextBoxCodeProduit.Text & " Ajouter")
        '        Dim id As Integer
        '        id = TextBoxCodeProduit.Text
        '        n = TextBoxLibelleProduit.Text
        '        p = TextBoxPrixProduit.Text
        '        r = TextBoxQStockProduit.Text
        '        cp = ComboBoxFournisseur.SelectedValue
        '        v = ComboBoxCategorieProduit.SelectedValue
        '        AjouterProduit(id, n, p, r, cp, v)
        '        btnAjout.Text = "+"
        '        ComboBoxCategorieProduit.Enabled = False
        '        ComboBoxFournisseur.Enabled = False
        '        DataGridView.DataSource = GestionProduit.GetLesProduitsDG()
        '        Rafraichir()
        '    End If
        'End If
        If btnModif.Text = "Modifier" Then
            btnModif.Text = "Valider"
            ComboBoxCategorieProduit.Enabled = True
            ComboBoxFournisseur.Enabled = True
        Else
            Dim answer = MsgBox("Voulez vous vraiment modifier le client N° " & TextBoxCodeProduit.Text & " Modification", MessageBoxButtons.YesNo)
            If answer = vbYes Then
                Dim id As Integer
                Dim n, p, r, cp, v As String
                id = TextBoxCodeProduit.Text
                n = TextBoxLibelleProduit.Text
                p = TextBoxPrixProduit.Text
                r = TextBoxQStockProduit.Text
                cp = ComboBoxFournisseur.SelectedValue
                v = ComboBoxCategorieProduit.SelectedValue
                GestionProduit.ModifierProduit(id, n, p, r, cp, v)
                ComboBoxCategorieProduit.Enabled = False
                ComboBoxFournisseur.Enabled = False
                btnModif.Text = "Modifier"
                DataGridView.DataSource = GestionProduit.GetLesProduitsDG()
                Rafraichir()
            End If
        End If

    End Sub

    Private Sub TextBoxRecherche_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRecherche.TextChanged
        Dim re As String
        Try
            re = TextBoxRecherche.Text
        Catch
            Exit Sub
        End Try
        DataGridView.DataSource = GestionProduit.RechercherProduit(re)
        Rafraichir()
    End Sub

    Private Sub btnPDF_Click(sender As Object, e As EventArgs) Handles btnPDF.Click
        GestionPDF.genererpdfdepuisdatatable(" Liste des Produits ", GestionProduit.GetLesProduitsDG(), GestionProduit.GetNBProduits())
    End Sub
    'Private Sub TextBoxNomClient_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxNomClient.LostFocus
    '    If GestionBDD.ValidNomPrenom(TextBoxNomClient.Text) = False Then
    '        Me.ErrorProvider1.SetError(Me.TextBoxNomClient, "le nom est invalide : présence de chiffre !!!")
    '        ErrorProvider1.Tag = 1
    '    Else
    '        Me.ErrorProvider1.SetError(Me.TextBoxNomClient, "")
    '        ErrorProvider1.Tag = 0
    '    End If
    'End Sub
    'Private Sub TextBoxPrenomClient_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxPrenomClient.LostFocus
    '    If GestionBDD.ValidNomPrenom(TextBoxPrenomClient.Text) = False Then
    '        Me.ErrorProvider1.SetError(Me.TextBoxPrenomClient, "le prenom est invalide : présence de chiffre !!!")
    '        ErrorProvider1.Tag = 1
    '    Else
    '        Me.ErrorProvider1.SetError(Me.TextBoxPrenomClient, "")
    '        ErrorProvider1.Tag = 0
    '    End If
    'End Sub

    'Private Sub TextBoxAdCpClient_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxAdCpClient.LostFocus
    '    If GestionBDD.ValidCP(TextBoxAdCpClient.Text) = False Then
    '        Me.ErrorProvider1.SetError(Me.TextBoxAdCpClient, "le code postal est invalide : présence de lettres ou valeur non compris entre 00000 et 99999 !!!")
    '        ErrorProvider1.Tag = 1
    '    Else
    '        Me.ErrorProvider1.SetError(Me.TextBoxAdCpClient, "")
    '        ErrorProvider1.Tag = 0
    '    End If
    'End Sub
End Class