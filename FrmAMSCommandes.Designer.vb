<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAMSCommandes
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
        Me.btnDeb = New System.Windows.Forms.Button()
        Me.btnSuiv = New System.Windows.Forms.Button()
        Me.btnFin = New System.Windows.Forms.Button()
        Me.btnPre = New System.Windows.Forms.Button()
        Me.btnSupprimerCommande = New System.Windows.Forms.Button()
        Me.btnConsulterCommande = New System.Windows.Forms.Button()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.p = New System.Windows.Forms.GroupBox()
        Me.ComboBoxClient = New System.Windows.Forms.ComboBox()
        Me.TextBoxDate = New System.Windows.Forms.TextBox()
        Me.TextBoxNumero = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnNouvelleCommande = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.p.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDeb
        '
        Me.btnDeb.Location = New System.Drawing.Point(27, 43)
        Me.btnDeb.Name = "btnDeb"
        Me.btnDeb.Size = New System.Drawing.Size(75, 28)
        Me.btnDeb.TabIndex = 0
        Me.btnDeb.Text = "<<"
        Me.btnDeb.UseVisualStyleBackColor = True
        '
        'btnSuiv
        '
        Me.btnSuiv.Location = New System.Drawing.Point(411, 43)
        Me.btnSuiv.Name = "btnSuiv"
        Me.btnSuiv.Size = New System.Drawing.Size(75, 28)
        Me.btnSuiv.TabIndex = 1
        Me.btnSuiv.Text = ">"
        Me.btnSuiv.UseVisualStyleBackColor = True
        '
        'btnFin
        '
        Me.btnFin.Location = New System.Drawing.Point(492, 43)
        Me.btnFin.Name = "btnFin"
        Me.btnFin.Size = New System.Drawing.Size(75, 28)
        Me.btnFin.TabIndex = 2
        Me.btnFin.Text = ">>"
        Me.btnFin.UseVisualStyleBackColor = True
        '
        'btnPre
        '
        Me.btnPre.Location = New System.Drawing.Point(108, 43)
        Me.btnPre.Name = "btnPre"
        Me.btnPre.Size = New System.Drawing.Size(75, 28)
        Me.btnPre.TabIndex = 4
        Me.btnPre.Text = "<"
        Me.btnPre.UseVisualStyleBackColor = True
        '
        'btnSupprimerCommande
        '
        Me.btnSupprimerCommande.Location = New System.Drawing.Point(404, 89)
        Me.btnSupprimerCommande.Name = "btnSupprimerCommande"
        Me.btnSupprimerCommande.Size = New System.Drawing.Size(140, 38)
        Me.btnSupprimerCommande.TabIndex = 5
        Me.btnSupprimerCommande.Text = "- Supprimer la Commande"
        Me.btnSupprimerCommande.UseVisualStyleBackColor = True
        '
        'btnConsulterCommande
        '
        Me.btnConsulterCommande.Location = New System.Drawing.Point(404, 20)
        Me.btnConsulterCommande.Name = "btnConsulterCommande"
        Me.btnConsulterCommande.Size = New System.Drawing.Size(140, 38)
        Me.btnConsulterCommande.TabIndex = 6
        Me.btnConsulterCommande.Text = "Consulter la Commande"
        Me.btnConsulterCommande.UseVisualStyleBackColor = True
        '
        'btnQuitter
        '
        Me.btnQuitter.Location = New System.Drawing.Point(296, 412)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(75, 23)
        Me.btnQuitter.TabIndex = 7
        Me.btnQuitter.Text = "Fermer"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'p
        '
        Me.p.Controls.Add(Me.ComboBoxClient)
        Me.p.Controls.Add(Me.TextBoxDate)
        Me.p.Controls.Add(Me.TextBoxNumero)
        Me.p.Controls.Add(Me.Label3)
        Me.p.Controls.Add(Me.Label2)
        Me.p.Controls.Add(Me.Label1)
        Me.p.Controls.Add(Me.btnConsulterCommande)
        Me.p.Controls.Add(Me.btnSupprimerCommande)
        Me.p.Location = New System.Drawing.Point(39, 12)
        Me.p.Name = "p"
        Me.p.Size = New System.Drawing.Size(580, 136)
        Me.p.TabIndex = 8
        Me.p.TabStop = False
        Me.p.Text = "Commande Séléctionnée :"
        '
        'ComboBoxClient
        '
        Me.ComboBoxClient.FormattingEnabled = True
        Me.ComboBoxClient.Location = New System.Drawing.Point(101, 106)
        Me.ComboBoxClient.Name = "ComboBoxClient"
        Me.ComboBoxClient.Size = New System.Drawing.Size(162, 21)
        Me.ComboBoxClient.TabIndex = 12
        '
        'TextBoxDate
        '
        Me.TextBoxDate.Location = New System.Drawing.Point(101, 61)
        Me.TextBoxDate.Name = "TextBoxDate"
        Me.TextBoxDate.Size = New System.Drawing.Size(162, 20)
        Me.TextBoxDate.TabIndex = 11
        '
        'TextBoxNumero
        '
        Me.TextBoxNumero.Location = New System.Drawing.Point(101, 20)
        Me.TextBoxNumero.Name = "TextBoxNumero"
        Me.TextBoxNumero.Size = New System.Drawing.Size(162, 20)
        Me.TextBoxNumero.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Client :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Date :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Numéro :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnFin)
        Me.GroupBox2.Controls.Add(Me.btnDeb)
        Me.GroupBox2.Controls.Add(Me.btnSuiv)
        Me.GroupBox2.Controls.Add(Me.btnNouvelleCommande)
        Me.GroupBox2.Controls.Add(Me.btnPre)
        Me.GroupBox2.Location = New System.Drawing.Point(32, 154)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(587, 100)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rechercher une Commande :"
        '
        'btnNouvelleCommande
        '
        Me.btnNouvelleCommande.Location = New System.Drawing.Point(222, 43)
        Me.btnNouvelleCommande.Name = "btnNouvelleCommande"
        Me.btnNouvelleCommande.Size = New System.Drawing.Size(154, 28)
        Me.btnNouvelleCommande.TabIndex = 3
        Me.btnNouvelleCommande.Text = "+ Nouvelle Commande"
        Me.btnNouvelleCommande.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Location = New System.Drawing.Point(32, 284)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(587, 122)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Toutes les Commandes :"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(70, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(447, 97)
        Me.DataGridView1.TabIndex = 0
        '
        'FrmAMSCommandes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.p)
        Me.Controls.Add(Me.btnQuitter)
        Me.Name = "FrmAMSCommandes"
        Me.Text = "Liste des Commandes :"
        Me.p.ResumeLayout(False)
        Me.p.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDeb As Button
    Friend WithEvents btnSuiv As Button
    Friend WithEvents btnFin As Button
    Friend WithEvents btnPre As Button
    Friend WithEvents btnSupprimerCommande As Button
    Friend WithEvents btnConsulterCommande As Button
    Friend WithEvents btnQuitter As Button
    Friend WithEvents p As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnNouvelleCommande As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBoxClient As ComboBox
    Friend WithEvents TextBoxDate As TextBox
    Friend WithEvents TextBoxNumero As TextBox
End Class
