Imports IAPM_DIAZ.GestionBDD
Public Class GestionCommandes
    Public Shared Function GetLesCommandesDG() As DataTable
        Return Executer_Requete_Select(“SELECT commande.idCommande, DateCommande, CONCAT( NomUtilisateur, ' ' , PrenomUtilisateur) AS Patronyme, SUM(QuantiteCom*PrixHTProduit) AS MontantHT FROM commande, utilisateur,client, lignedecommande, produit
                WHERE commande.idCli = client.idClient AND commande.idcommande = lignedecommande.idCommande AND lignedecommande.idProduit = produit.idProduit AND client.idUtilisateur = utilisateur.idUtilisateur
                GROUP BY commande.idCommande”)
    End Function
    Public Shared Function GetLesCommandes() As DataTable
        Return Executer_Requete_Select(“ select * from commande”)
    End Function
    Public Shared Function GetNBCommandes() As Integer
        Return GestionBDD.Executer_Requete_Scalaire("Select Count(*) From Commande")
    End Function


    Public Shared Function SupprimerCommande() As Integer
        Return GestionBDD.Executer_Requete_Scalaire("Select Count(*) From Commande")
    End Function
    Public Shared Function GetMontantHTByCommande(idcom As Integer) As Integer
        Return Executer_Requete_Scalaire(“SELECT Sum(PrixhtProduit * QuantiteCom) AS MontantLigneHT FROM produit, lignedecommande WHERE produit.idProduit = lignedecommande.idProduit AND idcommande =" & idcom)
    End Function


    'Public Shared Sub AjouterProduit(id As Integer, n As String, p As String, r As String, cp As String, v As String)
    '    GestionBDD.Executer_Requete_Action("Insert into produit values (" & id & " ,'" & n & "','" & p & "','" & r & "','" & cp & "','" & v & "')")
    'End Sub

    'Public Shared Sub SupprimerProduit(id As Integer)
    '    GestionBDD.Executer_Requete_Action("delete from produit where idProduit = " & id)
    'End Sub

    'Public Shared Sub ModifierProduit(id As Integer, n As String, p As String, r As String, cp As String, v As String)
    '    GestionBDD.Executer_Requete_Action("update produit set LibelleProduit = '" & n & "',PrixHTProduit = '" & p & "',QteStockProduit = '" & r & "',idFourn = '" & cp & "',idCat = '" & v & "' Where idProduit = " & id & "")
    'End Sub

    'Public Shared Function RechercherProduit(re As String)
    '    Return GestionBDD.Executer_Requete_Select("Select * FROM Produit where ((LibelleProduit LIKE '%" & re & "%') or (PrixHTProduit like '%" & re & "%') or (QteStockProduit like '%" & re & "%') or (idFourn like '%" & re & "%') or  (idCat like '%" & re & "%'))")
    'End Function

End Class