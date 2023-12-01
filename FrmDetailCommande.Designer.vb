<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDetailCommande
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
        Me.btnFermer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxMontant = New System.Windows.Forms.TextBox()
        Me.DataGridViewCommand = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxProduit = New System.Windows.Forms.ComboBox()
        Me.ComboBoxCategorie = New System.Windows.Forms.ComboBox()
        Me.TextBoxQuantite = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnRetirerCommande = New System.Windows.Forms.Button()
        Me.btnAjouterCommande = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxClient = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxDate = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxNumero = New System.Windows.Forms.TextBox()
        CType(Me.DataGridViewCommand, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnFermer
        '
        Me.btnFermer.Location = New System.Drawing.Point(242, 502)
        Me.btnFermer.Name = "btnFermer"
        Me.btnFermer.Size = New System.Drawing.Size(222, 34)
        Me.btnFermer.TabIndex = 14
        Me.btnFermer.Text = "Fermer"
        Me.btnFermer.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(334, 472)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Montant Hors Taxes de la Commande :"
        '
        'TextBoxMontant
        '
        Me.TextBoxMontant.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TextBoxMontant.Location = New System.Drawing.Point(531, 469)
        Me.TextBoxMontant.Name = "TextBoxMontant"
        Me.TextBoxMontant.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxMontant.TabIndex = 4
        '
        'DataGridViewCommand
        '
        Me.DataGridViewCommand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCommand.Location = New System.Drawing.Point(21, 19)
        Me.DataGridViewCommand.Name = "DataGridViewCommand"
        Me.DataGridViewCommand.Size = New System.Drawing.Size(543, 139)
        Me.DataGridViewCommand.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridViewCommand)
        Me.GroupBox3.Location = New System.Drawing.Point(36, 299)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(616, 164)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Récapitulatif des Produits commandés :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Produit :"
        '
        'ComboBoxProduit
        '
        Me.ComboBoxProduit.FormattingEnabled = True
        Me.ComboBoxProduit.Location = New System.Drawing.Point(102, 80)
        Me.ComboBoxProduit.Name = "ComboBoxProduit"
        Me.ComboBoxProduit.Size = New System.Drawing.Size(172, 21)
        Me.ComboBoxProduit.TabIndex = 2
        '
        'ComboBoxCategorie
        '
        Me.ComboBoxCategorie.FormattingEnabled = True
        Me.ComboBoxCategorie.Location = New System.Drawing.Point(102, 37)
        Me.ComboBoxCategorie.Name = "ComboBoxCategorie"
        Me.ComboBoxCategorie.Size = New System.Drawing.Size(172, 21)
        Me.ComboBoxCategorie.TabIndex = 1
        '
        'TextBoxQuantite
        '
        Me.TextBoxQuantite.Location = New System.Drawing.Point(102, 125)
        Me.TextBoxQuantite.Name = "TextBoxQuantite"
        Me.TextBoxQuantite.Size = New System.Drawing.Size(172, 20)
        Me.TextBoxQuantite.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Quantité :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Catégorie :"
        '
        'btnRetirerCommande
        '
        Me.btnRetirerCommande.Location = New System.Drawing.Point(353, 107)
        Me.btnRetirerCommande.Name = "btnRetirerCommande"
        Me.btnRetirerCommande.Size = New System.Drawing.Size(222, 34)
        Me.btnRetirerCommande.TabIndex = 12
        Me.btnRetirerCommande.Text = "Retirer de la Commande"
        Me.btnRetirerCommande.UseVisualStyleBackColor = True
        '
        'btnAjouterCommande
        '
        Me.btnAjouterCommande.Location = New System.Drawing.Point(353, 40)
        Me.btnAjouterCommande.Name = "btnAjouterCommande"
        Me.btnAjouterCommande.Size = New System.Drawing.Size(222, 34)
        Me.btnAjouterCommande.TabIndex = 13
        Me.btnAjouterCommande.Text = "Ajouter à la Commande "
        Me.btnAjouterCommande.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAjouterCommande)
        Me.GroupBox2.Controls.Add(Me.btnRetirerCommande)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TextBoxQuantite)
        Me.GroupBox2.Controls.Add(Me.ComboBoxCategorie)
        Me.GroupBox2.Controls.Add(Me.ComboBoxProduit)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(36, 128)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(616, 165)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ajouter / Gérer des Produits :"
        '
        'ComboBoxClient
        '
        Me.ComboBoxClient.FormattingEnabled = True
        Me.ComboBoxClient.Location = New System.Drawing.Point(443, 29)
        Me.ComboBoxClient.Name = "ComboBoxClient"
        Me.ComboBoxClient.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxClient.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Numéro :"
        '
        'TextBoxDate
        '
        Me.TextBoxDate.Location = New System.Drawing.Point(248, 30)
        Me.TextBoxDate.Name = "TextBoxDate"
        Me.TextBoxDate.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxDate.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(398, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Client :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBoxDate)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBoxNumero)
        Me.GroupBox1.Controls.Add(Me.ComboBoxClient)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(616, 72)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "La Commande :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(203, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Date :"
        '
        'TextBoxNumero
        '
        Me.TextBoxNumero.Location = New System.Drawing.Point(69, 30)
        Me.TextBoxNumero.Name = "TextBoxNumero"
        Me.TextBoxNumero.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNumero.TabIndex = 5
        '
        'FrmDetailCommande
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 539)
        Me.Controls.Add(Me.btnFermer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxMontant)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmDetailCommande"
        Me.Text = "Détail de Commande :"
        CType(Me.DataGridViewCommand, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFermer As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxMontant As TextBox
    Friend WithEvents DataGridViewCommand As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxProduit As ComboBox
    Friend WithEvents ComboBoxCategorie As ComboBox
    Friend WithEvents TextBoxQuantite As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnRetirerCommande As Button
    Friend WithEvents btnAjouterCommande As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBoxClient As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxDate As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxNumero As TextBox
End Class
