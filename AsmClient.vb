Imports IAPM_DIAZ.GestionBDD
Imports IAPM_DIAZ.GestionClient
Public Class AsmClient
    Dim position
    Private Sub AsmClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmStart
        Me.Left = 0
        Me.Top = 0
        DataGridView.DataSource = GestionClient.GetLesClients()
        Rafraichir()
        TextBoxIdClient.Enabled = False

    End Sub

    Public Sub Rafraichir()
        Dim MesClients As DataTable = GestionClient.GetLesClients()
        With MesClients.Rows(position)
            TextBoxIdClient.Text = .Item(0)
            TextBoxNomClient.Text = .Item(1)
            TextBoxPrenomClient.Text = .Item(2)
            TextBoxAdRueClient.Text = If(IsDBNull(.Item(3)), "", .Item(3))
            TextBoxAdCpClient.Text = If(IsDBNull(.Item(4)), "", .Item(4))
            TextBoxAdVilleClient.Text = If(IsDBNull(.Item(5)), "", .Item(5))
        End With
    End Sub



    Private Sub Quitter_Click(sender As Object, e As EventArgs) Handles Quitter.Click
        Me.Hide()
    End Sub

    Private Sub Btnsuiv_Click(sender As Object, e As EventArgs) Handles Btnsuiv.Click
        If (position < GestionClient.GetNBClients() - 1) Then
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
        position = GetNBClients() - 1
        Rafraichir()
    End Sub

    Private Sub btnAjout_Click(sender As Object, e As EventArgs) Handles btnAjout.Click
        If btnAjout.Text = "+" Then
            btnAjout.Text = "Valider"
            TextBoxIdClient.Text = ""
            TextBoxNomClient.Text = ""
            TextBoxPrenomClient.Text = ""
            TextBoxAdRueClient.Text = ""
            TextBoxAdCpClient.Text = ""
            TextBoxAdVilleClient.Text = ""
        Else
            Dim n, p, r, cp, v As String
            Dim answer As Integer
            answer = MsgBox("Voulez vous vraiment ajouter le client N° " & TextBoxIdClient.Text & " Ajouter", MessageBoxButtons.YesNo)
            If answer = vbYes Then
                MsgBox("Client n° " & TextBoxIdClient.Text & " Ajouter")
                n = TextBoxNomClient.Text
                p = TextBoxPrenomClient.Text
                r = TextBoxAdRueClient.Text
                cp = TextBoxAdCpClient.Text
                v = TextBoxAdVilleClient.Text
                AjouterClient(n, p, r, cp, v)
                btnAjout.Text = "+"
                DataGridView.DataSource = GestionClient.GetLesClients()
                Rafraichir()
            End If
        End If
    End Sub

    Private Sub btnSupr_Click(sender As Object, e As EventArgs) Handles btnSupr.Click
        Dim id As Integer
        Dim answer As Integer
        id = TextBoxIdClient.Text
        answer = MsgBox("Voulez vous vraiment suprimmer le client N° " & TextBoxIdClient.Text & " Supprimer", MessageBoxButtons.YesNo)
        If answer = vbYes Then
            MsgBox("Client n° " & TextBoxIdClient.Text & " Supprimer")
            SupprimerClient(id)
            DataGridView.DataSource = GestionClient.GetLesClients()
            position = 0
            Rafraichir()
        Else
        End If
    End Sub

    Private Sub btnModif_Click(sender As Object, e As EventArgs) Handles btnModif.Click
        Dim answer = MsgBox("Voulez vous vraiment modifier le client N° " & TextBoxIdClient.Text & " Modification", MessageBoxButtons.YesNo)
        If answer = vbYes Then
            Dim id As Integer
            Dim n, p, r, cp, v As String
            id = TextBoxIdClient.Text
            n = TextBoxNomClient.Text
            p = TextBoxPrenomClient.Text
            r = TextBoxAdRueClient.Text
            cp = TextBoxAdCpClient.Text
            v = TextBoxAdVilleClient.Text
            ModifierClient(id, n, p, r, cp, v)
            DataGridView.DataSource = GestionClient.GetLesClients()
            Rafraichir()
        End If
    End Sub

    Private Sub TextBoxRecherche_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRecherche.TextChanged
        Dim re As String
        Try
            re = TextBoxRecherche.Text
        Catch
            Exit Sub
        End Try
        DataGridView.DataSource = GestionClient.RechercherClient(re)
    End Sub

    Private Sub btnPDF_Click(sender As Object, e As EventArgs) Handles btnPDF.Click
        GestionPDF.genererpdfdepuisdatatable(" Liste des Client ", GetLesClients(), GetNBClients())
    End Sub
    Private Sub TextBoxNomClient_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxNomClient.LostFocus
        If GestionBDD.ValidNomPrenom(TextBoxNomClient.Text) = False Then
            Me.ErrorProvider1.SetError(Me.TextBoxNomClient, "le nom est invalide : présence de chiffre !!!")
            ErrorProvider1.Tag = 1
        Else
            Me.ErrorProvider1.SetError(Me.TextBoxNomClient, "")
            ErrorProvider1.Tag = 0
        End If
    End Sub
    Private Sub TextBoxPrenomClient_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxPrenomClient.LostFocus
        If GestionBDD.ValidNomPrenom(TextBoxPrenomClient.Text) = False Then
            Me.ErrorProvider1.SetError(Me.TextBoxPrenomClient, "le prenom est invalide : présence de chiffre !!!")
            ErrorProvider1.Tag = 1
        Else
            Me.ErrorProvider1.SetError(Me.TextBoxPrenomClient, "")
            ErrorProvider1.Tag = 0
        End If
    End Sub

    Private Sub TextBoxAdCpClient_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxAdCpClient.LostFocus
        If GestionBDD.ValidCP(TextBoxAdCpClient.Text) = False Then
            Me.ErrorProvider1.SetError(Me.TextBoxAdCpClient, "le code postal est invalide : présence de lettres ou valeur non compris entre 00000 et 99999 !!!")
            ErrorProvider1.Tag = 1
        Else
            Me.ErrorProvider1.SetError(Me.TextBoxAdCpClient, "")
            ErrorProvider1.Tag = 0
        End If
    End Sub
End Class