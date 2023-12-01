Imports IAPM_DIAZ.GestionBDD
Public Class GestionCategorie
    Public Shared Function GetLesCategories() As DataTable
        Return Executer_Requete_Select(“Select * from categorie”)
    End Function
End Class
