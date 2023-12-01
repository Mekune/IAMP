<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AsmFournisseur
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPDF = New System.Windows.Forms.Button()
        Me.TextBoxRecherche = New System.Windows.Forms.TextBox()
        Me.btnModif = New System.Windows.Forms.Button()
        Me.btnSupr = New System.Windows.Forms.Button()
        Me.btnAjout = New System.Windows.Forms.Button()
        Me.BtnFin = New System.Windows.Forms.Button()
        Me.Btnpre = New System.Windows.Forms.Button()
        Me.Btnsuiv = New System.Windows.Forms.Button()
        Me.BtnDeb = New System.Windows.Forms.Button()
        Me.ComboBoxFournisseur = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Quitter = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.TextBoxCP = New System.Windows.Forms.TextBox()
        Me.TextBoxVille = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxNom = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView
        '
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Location = New System.Drawing.Point(374, 43)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.Size = New System.Drawing.Size(539, 235)
        Me.DataGridView.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnPDF)
        Me.GroupBox1.Controls.Add(Me.TextBoxRecherche)
        Me.GroupBox1.Controls.Add(Me.btnModif)
        Me.GroupBox1.Controls.Add(Me.btnSupr)
        Me.GroupBox1.Controls.Add(Me.btnAjout)
        Me.GroupBox1.Controls.Add(Me.BtnFin)
        Me.GroupBox1.Controls.Add(Me.Btnpre)
        Me.GroupBox1.Controls.Add(Me.Btnsuiv)
        Me.GroupBox1.Controls.Add(Me.BtnDeb)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 284)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(907, 123)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gestion des fournisseurs"
        '
        'btnPDF
        '
        Me.btnPDF.Location = New System.Drawing.Point(544, 89)
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.Size = New System.Drawing.Size(87, 24)
        Me.btnPDF.TabIndex = 61
        Me.btnPDF.Text = "PDF"
        Me.btnPDF.UseVisualStyleBackColor = True
        '
        'TextBoxRecherche
        '
        Me.TextBoxRecherche.Location = New System.Drawing.Point(690, 59)
        Me.TextBoxRecherche.Name = "TextBoxRecherche"
        Me.TextBoxRecherche.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxRecherche.TabIndex = 60
        '
        'btnModif
        '
        Me.btnModif.Location = New System.Drawing.Point(451, 89)
        Me.btnModif.Name = "btnModif"
        Me.btnModif.Size = New System.Drawing.Size(87, 24)
        Me.btnModif.TabIndex = 59
        Me.btnModif.Text = "Modifier"
        Me.btnModif.UseVisualStyleBackColor = True
        '
        'btnSupr
        '
        Me.btnSupr.Location = New System.Drawing.Point(508, 59)
        Me.btnSupr.Name = "btnSupr"
        Me.btnSupr.Size = New System.Drawing.Size(60, 24)
        Me.btnSupr.TabIndex = 58
        Me.btnSupr.Text = "-"
        Me.btnSupr.UseVisualStyleBackColor = True
        '
        'btnAjout
        '
        Me.btnAjout.Location = New System.Drawing.Point(433, 59)
        Me.btnAjout.Name = "btnAjout"
        Me.btnAjout.Size = New System.Drawing.Size(60, 24)
        Me.btnAjout.TabIndex = 57
        Me.btnAjout.Text = "+"
        Me.btnAjout.UseVisualStyleBackColor = True
        '
        'BtnFin
        '
        Me.BtnFin.Location = New System.Drawing.Point(302, 59)
        Me.BtnFin.Name = "BtnFin"
        Me.BtnFin.Size = New System.Drawing.Size(60, 24)
        Me.BtnFin.TabIndex = 56
        Me.BtnFin.Text = ">>"
        Me.BtnFin.UseVisualStyleBackColor = True
        '
        'Btnpre
        '
        Me.Btnpre.Location = New System.Drawing.Point(114, 59)
        Me.Btnpre.Name = "Btnpre"
        Me.Btnpre.Size = New System.Drawing.Size(60, 24)
        Me.Btnpre.TabIndex = 55
        Me.Btnpre.Text = "<"
        Me.Btnpre.UseVisualStyleBackColor = True
        '
        'Btnsuiv
        '
        Me.Btnsuiv.Location = New System.Drawing.Point(180, 59)
        Me.Btnsuiv.Name = "Btnsuiv"
        Me.Btnsuiv.Size = New System.Drawing.Size(60, 24)
        Me.Btnsuiv.TabIndex = 54
        Me.Btnsuiv.Text = ">"
        Me.Btnsuiv.UseVisualStyleBackColor = True
        '
        'BtnDeb
        '
        Me.BtnDeb.Location = New System.Drawing.Point(8, 59)
        Me.BtnDeb.Name = "BtnDeb"
        Me.BtnDeb.Size = New System.Drawing.Size(66, 24)
        Me.BtnDeb.TabIndex = 53
        Me.BtnDeb.Text = "<<"
        Me.BtnDeb.UseVisualStyleBackColor = True
        '
        'ComboBoxFournisseur
        '
        Me.ComboBoxFournisseur.Enabled = False
        Me.ComboBoxFournisseur.FormattingEnabled = True
        Me.ComboBoxFournisseur.Location = New System.Drawing.Point(174, 248)
        Me.ComboBoxFournisseur.Name = "ComboBoxFournisseur"
        Me.ComboBoxFournisseur.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxFournisseur.TabIndex = 52
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 251)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Fournisseur :"
        '
        'Quitter
        '
        Me.Quitter.Location = New System.Drawing.Point(374, 413)
        Me.Quitter.Name = "Quitter"
        Me.Quitter.Size = New System.Drawing.Size(104, 31)
        Me.Quitter.TabIndex = 62
        Me.Quitter.Text = "Fermer"
        Me.Quitter.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "ID :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Ville :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Code Postal :"
        '
        'TextBoxID
        '
        Me.TextBoxID.Location = New System.Drawing.Point(174, 40)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxID.TabIndex = 67
        '
        'TextBoxCP
        '
        Me.TextBoxCP.Location = New System.Drawing.Point(174, 188)
        Me.TextBoxCP.Name = "TextBoxCP"
        Me.TextBoxCP.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCP.TabIndex = 68
        '
        'TextBoxVille
        '
        Me.TextBoxVille.Location = New System.Drawing.Point(174, 137)
        Me.TextBoxVille.Name = "TextBoxVille"
        Me.TextBoxVille.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxVille.TabIndex = 69
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Nom :"
        '
        'TextBoxNom
        '
        Me.TextBoxNom.Location = New System.Drawing.Point(174, 81)
        Me.TextBoxNom.Name = "TextBoxNom"
        Me.TextBoxNom.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNom.TabIndex = 70
        '
        'AsmFournisseur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 450)
        Me.Controls.Add(Me.TextBoxNom)
        Me.Controls.Add(Me.TextBoxVille)
        Me.Controls.Add(Me.TextBoxCP)
        Me.Controls.Add(Me.TextBoxID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Quitter)
        Me.Controls.Add(Me.ComboBoxFournisseur)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView)
        Me.Name = "AsmFournisseur"
        Me.Text = "Gestion Fournisseur"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBoxFournisseur As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnPDF As Button
    Friend WithEvents TextBoxRecherche As TextBox
    Friend WithEvents btnModif As Button
    Friend WithEvents btnSupr As Button
    Friend WithEvents btnAjout As Button
    Friend WithEvents BtnFin As Button
    Friend WithEvents Btnpre As Button
    Friend WithEvents Btnsuiv As Button
    Friend WithEvents BtnDeb As Button
    Friend WithEvents Quitter As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents TextBoxCP As TextBox
    Friend WithEvents TextBoxVille As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxNom As TextBox
End Class
