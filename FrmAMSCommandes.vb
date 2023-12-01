Imports IAPM_DIAZ.GestionBDD
Imports IAPM_DIAZ.GestionCommandes
Imports IAPM_DIAZ.GestionInterface
Public Class FrmAMSCommandes
    Dim position 'variables affecter au DataGridView'
    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Me.Hide()
    End Sub

    Public Sub Rafraichir()
        Dim MesCommandes As DataTable = GestionCommandes.GetLesCommandes()
        TextBoxNumero.Text = MesCommandes.Rows(position).Item(0)
        TextBoxDate.Text = MesCommandes.Rows(position).Item(1)
        ComboBoxClient.Text = MesCommandes.Rows(position).Item(2)
        DataGridView1.ClearSelection()
        DataGridView1.Rows(position).Selected = True

    End Sub
    Private Sub FrmAMSCommandes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmStart
        Me.Left = 0
        Me.Top = 0
        GestionInterface.AlimenterComboBox(ComboBoxClient, GestionClient.GetLesClients, “NomUtilisateur”, “idUtilisateur”)
        DataGridView1.DataSource = GetLesCommandesDG()

        Rafraichir()
    End Sub

    Private Sub Btnsuiv_Click(sender As Object, e As EventArgs) Handles btnSuiv.Click
        If (position < GestionCommandes.GetNBCommandes() - 1) Then
            position = position + 1
        End If
        Rafraichir()
    End Sub

    Private Sub Btnpre_Click(sender As Object, e As EventArgs) Handles btnPre.Click
        If (position > 0) Then
            position = position - 1
        End If
        Rafraichir()
    End Sub

    Private Sub BtnDeb_Click(sender As Object, e As EventArgs) Handles btnDeb.Click
        position = 0
        Rafraichir()
    End Sub

    Private Sub BtnFin_Click(sender As Object, e As EventArgs) Handles btnFin.Click
        position = GetNBCommandes() - 1
        Rafraichir()
    End Sub

    Private Sub btnConsulterCommande_Click(sender As Object, e As EventArgs) Handles btnConsulterCommande.Click
        Dim idCom = TextBoxNumero.Text
        Dim datecom = TextBoxDate.Text
        Dim LS As New FrmDetailCommande(idCom, datecom)
        LS.Show()
    End Sub

    Private Sub btnSupprimerCommande_Click(sender As Object, e As EventArgs) Handles btnSupprimerCommande.Click

    End Sub

    Private Sub btnNouvelleCommande_Click(sender As Object, e As EventArgs) Handles btnNouvelleCommande.Click
        'Dim idcom As Integer = MesCommandes.Rows(position).Item(0)
        'Dim datecom As String = MesCommandes.Rows(position).Item(1)
        'Dim ls As New FrmNewCommande(idcom, datecom)
        'ls.Show()
    End Sub
End Class