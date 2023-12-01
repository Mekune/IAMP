Imports IAPM_DIAZ
Public Class AsmFournisseur
    Dim position
    Private Sub AsmFournisseur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmStart
        Me.Left = 0
        Me.Top = 0
        DataGridView.DataSource = GestionFournisseurs.GetLesFournisseurs()
        Rafraichir()
    End Sub
    Public Sub Rafraichir()
        Dim MesFournisseurs As DataTable = GestionFournisseurs.GetLesFournisseurs()
        TextBoxID.Text = MesFournisseurs.Rows(position).Item(0)
        TextBoxNom.Text = MesFournisseurs.Rows(position).Item(1)
        TextBoxVille.Text = MesFournisseurs.Rows(position).Item(2)
        TextBoxCP.Text = MesFournisseurs.Rows(position).Item(3)
        DataGridView.ClearSelection()
        DataGridView.Rows(position).Selected = True
    End Sub
    Private Sub Quitter_Click(sender As Object, e As EventArgs) Handles Quitter.Click
        Me.Hide()
    End Sub
    Private Sub Btnsuiv_Click(sender As Object, e As EventArgs) Handles Btnsuiv.Click
        If (position < GestionFournisseurs.GetNBFournisseurs() - 1) Then
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
        position = GestionFournisseurs.GetNBFournisseurs() - 1
        Rafraichir()
    End Sub
    Private Sub btnAjout_Click(sender As Object, e As EventArgs) Handles btnAjout.Click
        If btnAjout.Text = "+" Then
            btnAjout.Text = "Valider"
            TextBoxID.Text = ""
            TextBoxNom.Text = ""
            TextBoxVille.Text = ""
            TextBoxCP.Text = ""
        Else
            Dim n, p, r As String
            Dim answer As Integer
            answer = MsgBox("Voulez vous vraiment ajouter le fournisseur N° " & TextBoxID.Text & " Ajouter", MessageBoxButtons.YesNo)
            If answer = vbYes Then
                MsgBox("Fournisseur n° " & TextBoxID.Text & " Ajouter")
                Dim id As Integer
                id = TextBoxID.Text
                n = TextBoxNom.Text
                p = TextBoxVille.Text
                r = TextBoxCP.Text
                GestionFournisseurs.AjouterFournisseur(id, n, p, r)
                btnAjout.Text = "+"
                DataGridView.DataSource = GestionFournisseurs.GetLesFournisseursDG()
                TextBoxID.Text = ""
                TextBoxNom.Text = ""
                TextBoxVille.Text = ""
                TextBoxCP.Text = ""
                Rafraichir()
            End If
        End If
    End Sub
    Private Sub btnSupr_Click(sender As Object, e As EventArgs) Handles btnSupr.Click
        Dim id As Integer
        Dim answer As Integer
        id = TextBoxID.Text
        answer = MsgBox("Voulez vous vraiment suprimmer le Fournisseur N° " & TextBoxID.Text & " Supprimer", MessageBoxButtons.YesNo)
        If answer = vbYes Then
            MsgBox("Fournisseur n° " & TextBoxID.Text & " Supprimer")
            GestionFournisseurs.SupprimerFournisseur(id)
            DataGridView.DataSource = GestionFournisseurs.GetLesFournisseursDG()
            position = 0
            Rafraichir()
        Else
        End If
    End Sub
    Private Sub btnModif_Click(sender As Object, e As EventArgs) Handles btnModif.Click
        If btnModif.Text = "Modifier" Then
            btnModif.Text = "Valider"
        Else
            Dim answer = MsgBox("Voulez vous vraiment modifier le founisseur N° " & TextBoxID.Text & " Modification", MessageBoxButtons.YesNo)
            If answer = vbYes Then
                Dim id As Integer
                Dim n, v, cp As String
                id = TextBoxID.Text
                n = TextBoxNom.Text
                v = TextBoxVille.Text
                cp = TextBoxCP.Text
                GestionFournisseurs.ModifierFournisseur(id, n, v, cp)
                btnModif.Text = "Modifier"
                DataGridView.DataSource = GestionFournisseurs.GetLesFournisseursDG()
                Rafraichir()
            End If
        End If

    End Sub
End Class


