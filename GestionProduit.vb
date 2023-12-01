Imports IAPM_DIAZ.GestionBDD
Public Class GestionProduit
    Public Shared Function GetLesProduits() As DataTable
        Return Executer_Requete_Select(“Select * from Produit”)
    End Function
    Public Shared Function GetLesProduitsDG() As DataTable
        Return Executer_Requete_Select(“Select idProduit,LibelleProduit,PrixHTProduit,QteStockProduit,NomFournisseur,LibelleCategorie from Produit,categorie,fournisseur WHERE (Fournisseur.idFournisseur = Produit.idFournisseur) and (Produit.idCategorie = Categorie.idCategorie)”)
    End Function
    Public Shared Function GetNBProduits() As Integer
        Return GestionBDD.Executer_Requete_Scalaire("Select Count(*) From Produit")
    End Function

    Public Shared Sub AjouterProduit(n As String, p As String, r As String, cp As String, v As String)
        GestionBDD.Executer_Requete_Action("Insert into produit (LibelleProduit,PrixHTProduit,QteStockProduit,idFournisseur,idCategorie) values ('" & n & "','" & p & "','" & r & "','" & cp & "','" & v & "')")
    End Sub

    Public Shared Sub SupprimerProduit(id As Integer)
        GestionBDD.Executer_Requete_Action("delete from produit where idProduit = " & id)
    End Sub

    Public Shared Sub ModifierProduit(id As Integer, n As String, p As String, r As String, cp As String, v As String)
        GestionBDD.Executer_Requete_Action("update produit set LibelleProduit = '" & n & "',PrixHTProduit = '" & p & "',QteStockProduit = '" & r & "',idFournisseur = '" & cp & "',idCategorie = '" & v & "' Where idProduit = " & id & "")
    End Sub

    Public Shared Function RechercherProduit(re As String)
        Return GestionBDD.Executer_Requete_Select("Select LibelleProduit,PrixHTProduit,QteStockProduit,NomFournisseur,LibelleCategorie from Produit,categorie,fournisseur where ((LibelleProduit LIKE '%" & re & "%') or (PrixHTProduit like '%" & re & "%') or (QteStockProduit like '%" & re & "%') or (fournisseur.NomFournisseur like '%" & re & "%') or  (categorie.LibelleCategorie like '%" & re & "%')) and (Fournisseur.idFournisseur = Produit.idFournisseur) and (Produit.idCategorie = Categorie.idCategorie)")
    End Function
    Public Shared Function RechercherIdProduit(re As String)
        Return GestionBDD.Executer_Requete_Select("Select * FROM Produit where ((idCategorie like '%" & re & "%'))")
    End Function

    Public Shared Function ProduitParCategorie(libelleProduit As String) As DataTable
        Return GestionBDD.Executer_Requete_Select("Select * from Produit,Categorie WHERE  LibelleCategorie = '" & libelleProduit & "' and (Produit.idCategorie = Categorie.idCategorie)")
    End Function
    Public Shared Function AjouterProduit(idcom As Integer, prod As Integer, qte As Integer)
        GestionBDD.Executer_Requete_Action("Insert into lignedecommande values (" & idcom & ",'" & prod & "','" & qte & "')")
    End Function

    Public Shared Function SupprimerProduit(idC As Integer, prod As Integer)
        GestionBDD.Executer_Requete_Action("delete from lignedecommande where idCommande = " & idC & " and idProduit = " & prod)
    End Function

    Public Shared Function GetLesProduitsByIdCommande(id As Integer) As DataTable
        Return Executer_Requete_Select(“SELECT Produit.idProduit,libelleProduit,PrixHTProduit,QuantiteCom,(PrixHTProduit*QuantiteCom) AS MontantLigneHT 
FROM produit,commande,lignedecommande
WHERE (produit.idProduit = lignedecommande.idProduit) AND (lignedecommande.idCommande = commande.idCommande) AND commande.idCommande = " & id & "”)
    End Function
End Class