Imports IAPM_DIAZ.GestionBDD
Public Class GestionClient
    Public Shared Function GetLesClients() As DataTable
        Return Executer_Requete_Select(“Select idUtilisateur,nomUtilisateur,prenomUtilisateur,adRueUtilisateur,adCPUtilisateur,adVilleUtilisateur from Utilisateur”)

    End Function

    Public Shared Function GetPatronymeClient() As DataTable
        Return Executer_Requete_Select("SELECT idUtilisateur,CONCAT(nomUtilisateur,' ',prenomUtilisateur) As Patronyme FROM Utilisateur")
    End Function
    Public Shared Function GetNBClients() As Integer
        Return GestionBDD.Executer_Requete_Scalaire("Select Count(*) From Utilisateur")
    End Function

    Public Shared Sub AjouterClient(n As String, p As String, r As String, cp As String, v As String)
        GestionBDD.Executer_Requete_Action("Insert into Utilisateur (nomUtilisateur,prenomUtilisateur,adRueUtilisateur,adCPUtilisateur,adVilleUtilisateur) values ('" & n & "','" & p & "','" & r & "','" & cp & "','" & v & "')")
    End Sub

    Public Shared Sub SupprimerClient(id As Integer)
        GestionBDD.Executer_Requete_Action("delete from Client where idUtilisateur = " & id)
        GestionBDD.Executer_Requete_Action("delete from Utilisateur where idUtilisateur = " & id)
    End Sub

    Public Shared Sub ModifierClient(id As Integer, n As String, p As String, r As String, cp As String, v As String)
        GestionBDD.Executer_Requete_Action("update client set NomUtilisateur = '" & n & "',PrenomUtilisateur = '" & p & "',AdRueUtilisateur = '" & r & "',AdCpUtilisateur = '" & cp & "',AdVilleUtilisateur = '" & v & "' Where idUtilisateur = " & id & "")
    End Sub

    Public Shared Function RechercherClient(re As String)
        Return GestionBDD.Executer_Requete_Select("Select * FROM Utilisateur where ((NomUtilisateur LIKE '%" & re & "%') or (PrenomUtilisateur like '%" & re & "%') or (AdRueClient like '%" & re & "%') or (AdCpClient like '%" & re & "%') or  (AdVilleClient like '%" & re & "%'))")
    End Function
    Public Shared Function GetClientById(id As Integer) As DataTable
        Return GestionBDD.Executer_Requete_Select("Select client.idUtilisateur,CONCAT( nomUtilisateur, ' ' , prenomUtilisateur) AS Patronyme From client,commande,utilisateur WHERE (client.idUtilisateur = utilisateur.idUtilisateur) and (client.idClient = commande.idCli) and idcommande LIKE ('" & id & "')")
    End Function
End Class