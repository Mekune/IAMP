Imports IAPM_DIAZ.GestionBDD
Public Class GetLesCategories
    Public Shared Function GetLesCategorie(ComboBoxCategorie) As DataTable
        Return Executer_Requete_Select(“Select * from Categorie”)
    End Function
End Class
