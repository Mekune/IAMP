<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStart
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnexionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjoutSuprModifToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProduitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjoutSuprModifToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommandeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjoutSuprModifToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FournisseurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjoutSuprModifToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatégorieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjoutSuprModifToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatistiquesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AProposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.ClientToolStripMenuItem, Me.ProduitToolStripMenuItem, Me.CommandeToolStripMenuItem, Me.FournisseurToolStripMenuItem, Me.CatégorieToolStripMenuItem, Me.StatistiquesToolStripMenuItem, Me.AProposToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1084, 24)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitterToolStripMenuItem, Me.ConnexionToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FichierToolStripMenuItem.Text = "Fichier"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'ConnexionToolStripMenuItem
        '
        Me.ConnexionToolStripMenuItem.Name = "ConnexionToolStripMenuItem"
        Me.ConnexionToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ConnexionToolStripMenuItem.Text = "Connexion"
        '
        'ClientToolStripMenuItem
        '
        Me.ClientToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListeToolStripMenuItem, Me.AjoutSuprModifToolStripMenuItem})
        Me.ClientToolStripMenuItem.Name = "ClientToolStripMenuItem"
        Me.ClientToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.ClientToolStripMenuItem.Text = "Client"
        '
        'ListeToolStripMenuItem
        '
        Me.ListeToolStripMenuItem.Name = "ListeToolStripMenuItem"
        Me.ListeToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ListeToolStripMenuItem.Text = "Liste"
        '
        'AjoutSuprModifToolStripMenuItem
        '
        Me.AjoutSuprModifToolStripMenuItem.Name = "AjoutSuprModifToolStripMenuItem"
        Me.AjoutSuprModifToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.AjoutSuprModifToolStripMenuItem.Text = "Ajout/Supr/Modif"
        '
        'ProduitToolStripMenuItem
        '
        Me.ProduitToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjoutSuprModifToolStripMenuItem1})
        Me.ProduitToolStripMenuItem.Name = "ProduitToolStripMenuItem"
        Me.ProduitToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.ProduitToolStripMenuItem.Text = "Produit"
        '
        'AjoutSuprModifToolStripMenuItem1
        '
        Me.AjoutSuprModifToolStripMenuItem1.Name = "AjoutSuprModifToolStripMenuItem1"
        Me.AjoutSuprModifToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.AjoutSuprModifToolStripMenuItem1.Text = "Ajout/Supr/Modif"
        '
        'CommandeToolStripMenuItem
        '
        Me.CommandeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjoutSuprModifToolStripMenuItem2})
        Me.CommandeToolStripMenuItem.Name = "CommandeToolStripMenuItem"
        Me.CommandeToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.CommandeToolStripMenuItem.Text = "Commande"
        '
        'AjoutSuprModifToolStripMenuItem2
        '
        Me.AjoutSuprModifToolStripMenuItem2.Name = "AjoutSuprModifToolStripMenuItem2"
        Me.AjoutSuprModifToolStripMenuItem2.Size = New System.Drawing.Size(169, 22)
        Me.AjoutSuprModifToolStripMenuItem2.Text = "Ajout/Supr/Modif"
        '
        'FournisseurToolStripMenuItem
        '
        Me.FournisseurToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjoutSuprModifToolStripMenuItem3})
        Me.FournisseurToolStripMenuItem.Name = "FournisseurToolStripMenuItem"
        Me.FournisseurToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.FournisseurToolStripMenuItem.Text = "Fournisseur"
        '
        'AjoutSuprModifToolStripMenuItem3
        '
        Me.AjoutSuprModifToolStripMenuItem3.Name = "AjoutSuprModifToolStripMenuItem3"
        Me.AjoutSuprModifToolStripMenuItem3.Size = New System.Drawing.Size(169, 22)
        Me.AjoutSuprModifToolStripMenuItem3.Text = "Ajout/Supr/Modif"
        '
        'CatégorieToolStripMenuItem
        '
        Me.CatégorieToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListeToolStripMenuItem4, Me.AjoutSuprModifToolStripMenuItem4})
        Me.CatégorieToolStripMenuItem.Name = "CatégorieToolStripMenuItem"
        Me.CatégorieToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.CatégorieToolStripMenuItem.Text = "Catégorie"
        '
        'ListeToolStripMenuItem4
        '
        Me.ListeToolStripMenuItem4.Name = "ListeToolStripMenuItem4"
        Me.ListeToolStripMenuItem4.Size = New System.Drawing.Size(180, 22)
        Me.ListeToolStripMenuItem4.Text = "Liste"
        '
        'AjoutSuprModifToolStripMenuItem4
        '
        Me.AjoutSuprModifToolStripMenuItem4.Name = "AjoutSuprModifToolStripMenuItem4"
        Me.AjoutSuprModifToolStripMenuItem4.Size = New System.Drawing.Size(180, 22)
        Me.AjoutSuprModifToolStripMenuItem4.Text = "Ajout/Supr/Modif"
        '
        'StatistiquesToolStripMenuItem
        '
        Me.StatistiquesToolStripMenuItem.Name = "StatistiquesToolStripMenuItem"
        Me.StatistiquesToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.StatistiquesToolStripMenuItem.Text = "Statistiques"
        '
        'AProposToolStripMenuItem
        '
        Me.AProposToolStripMenuItem.Name = "AProposToolStripMenuItem"
        Me.AProposToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.AProposToolStripMenuItem.Text = "A Propos"
        '
        'FrmStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 561)
        Me.Controls.Add(Me.MenuStrip2)
        Me.IsMdiContainer = True
        Me.Name = "FrmStart"
        Me.Text = "FrmStart"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents FichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjoutSuprModifToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProduitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjoutSuprModifToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CommandeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjoutSuprModifToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents FournisseurToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjoutSuprModifToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents CatégorieToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListeToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents AjoutSuprModifToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents StatistiquesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AProposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConnexionToolStripMenuItem As ToolStripMenuItem
End Class
