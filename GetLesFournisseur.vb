Imports IAPM_DIAZ.GestionBDD
Public Class GetLesFournisseur
    Public Shared Function GetLesFournisseurs(ComboBoxFournisseur) As DataTable
        Return Executer_Requete_Select(“Select * from Fournisseur”)
    End Function
End Class
