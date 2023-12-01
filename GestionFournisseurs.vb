Imports IAPM_DIAZ.GestionBDD
Public Class GestionFournisseurs
    Public Shared Function GetLesFournisseurs() As DataTable
        Return Executer_Requete_Select(“Select * from fournisseur”)
    End Function
    Public Shared Function GetNBFournisseurs() As Integer
        Return GestionBDD.Executer_Requete_Scalaire("Select Count(*) From Fournisseur")
    End Function
    Public Shared Function GetLesFournisseursDG() As DataTable
        Return Executer_Requete_Select(“Select * from fournisseur ”)
    End Function
    Public Shared Sub AjouterFournisseur(id As Integer, n As String, p As String, r As String)
        GestionBDD.Executer_Requete_Action("Insert into Fournisseur values (" & id & " ,'" & n & "','" & p & "','" & r & "')")
    End Sub
    Public Shared Sub SupprimerFournisseur(id As Integer)
        GestionBDD.Executer_Requete_Action("delete from fournisseur where idFournisseur = " & id)
    End Sub
    Public Shared Sub ModifierFournisseur(id As Integer, n As String, v As String, cp As String)
        GestionBDD.Executer_Requete_Action("update fournisseur set NomFournisseur = '" & n & "',VilleFournisseur = '" & v & "',CPFournisseur = '" & cp & "'Where idFournisseur = " & id & "")
    End Sub
End Class
