Public Class GestionInterface
    Public Shared Sub AlimenterComboBox(ByRef macombo As ComboBox, masource As DataTable, mondisplay As String, mavaleur As String)
        macombo.DataSource = masource
        macombo.DisplayMember = mondisplay
        If mavaleur <> "" Then
            macombo.ValueMember = mavaleur
        End If
    End Sub
End Class
