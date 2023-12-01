<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AsmClient
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
        Me.components = New System.ComponentModel.Container()
        Me.TextBoxNomClient = New System.Windows.Forms.TextBox()
        Me.TextBoxAdVilleClient = New System.Windows.Forms.TextBox()
        Me.TextBoxAdCpClient = New System.Windows.Forms.TextBox()
        Me.TextBoxAdRueClient = New System.Windows.Forms.TextBox()
        Me.TextBoxPrenomClient = New System.Windows.Forms.TextBox()
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
        Me.Quitter = New System.Windows.Forms.Button()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxIdClient = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxNomClient
        '
        Me.TextBoxNomClient.Location = New System.Drawing.Point(154, 67)
        Me.TextBoxNomClient.Name = "TextBoxNomClient"
        Me.TextBoxNomClient.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNomClient.TabIndex = 1
        '
        'TextBoxAdVilleClient
        '
        Me.TextBoxAdVilleClient.Location = New System.Drawing.Point(154, 240)
        Me.TextBoxAdVilleClient.Name = "TextBoxAdVilleClient"
        Me.TextBoxAdVilleClient.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxAdVilleClient.TabIndex = 2
        '
        'TextBoxAdCpClient
        '
        Me.TextBoxAdCpClient.Location = New System.Drawing.Point(154, 198)
        Me.TextBoxAdCpClient.Name = "TextBoxAdCpClient"
        Me.TextBoxAdCpClient.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxAdCpClient.TabIndex = 3
        '
        'TextBoxAdRueClient
        '
        Me.TextBoxAdRueClient.Location = New System.Drawing.Point(154, 163)
        Me.TextBoxAdRueClient.Name = "TextBoxAdRueClient"
        Me.TextBoxAdRueClient.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxAdRueClient.TabIndex = 4
        '
        'TextBoxPrenomClient
        '
        Me.TextBoxPrenomClient.Location = New System.Drawing.Point(154, 116)
        Me.TextBoxPrenomClient.Name = "TextBoxPrenomClient"
        Me.TextBoxPrenomClient.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPrenomClient.TabIndex = 5
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 308)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(932, 100)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gestion des Clients"
        '
        'btnPDF
        '
        Me.btnPDF.Location = New System.Drawing.Point(548, 65)
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.Size = New System.Drawing.Size(87, 24)
        Me.btnPDF.TabIndex = 35
        Me.btnPDF.Text = "PDF"
        Me.btnPDF.UseVisualStyleBackColor = True
        '
        'TextBoxRecherche
        '
        Me.TextBoxRecherche.Location = New System.Drawing.Point(699, 41)
        Me.TextBoxRecherche.Name = "TextBoxRecherche"
        Me.TextBoxRecherche.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxRecherche.TabIndex = 7
        '
        'btnModif
        '
        Me.btnModif.Location = New System.Drawing.Point(455, 65)
        Me.btnModif.Name = "btnModif"
        Me.btnModif.Size = New System.Drawing.Size(87, 24)
        Me.btnModif.TabIndex = 6
        Me.btnModif.Text = "Modifier"
        Me.btnModif.UseVisualStyleBackColor = True
        '
        'btnSupr
        '
        Me.btnSupr.Location = New System.Drawing.Point(512, 35)
        Me.btnSupr.Name = "btnSupr"
        Me.btnSupr.Size = New System.Drawing.Size(60, 24)
        Me.btnSupr.TabIndex = 5
        Me.btnSupr.Text = "-"
        Me.btnSupr.UseVisualStyleBackColor = True
        '
        'btnAjout
        '
        Me.btnAjout.Location = New System.Drawing.Point(437, 35)
        Me.btnAjout.Name = "btnAjout"
        Me.btnAjout.Size = New System.Drawing.Size(60, 24)
        Me.btnAjout.TabIndex = 4
        Me.btnAjout.Text = "+"
        Me.btnAjout.UseVisualStyleBackColor = True
        '
        'BtnFin
        '
        Me.BtnFin.Location = New System.Drawing.Point(306, 35)
        Me.BtnFin.Name = "BtnFin"
        Me.BtnFin.Size = New System.Drawing.Size(60, 24)
        Me.BtnFin.TabIndex = 3
        Me.BtnFin.Text = ">>"
        Me.BtnFin.UseVisualStyleBackColor = True
        '
        'Btnpre
        '
        Me.Btnpre.Location = New System.Drawing.Point(118, 35)
        Me.Btnpre.Name = "Btnpre"
        Me.Btnpre.Size = New System.Drawing.Size(60, 24)
        Me.Btnpre.TabIndex = 2
        Me.Btnpre.Text = "<"
        Me.Btnpre.UseVisualStyleBackColor = True
        '
        'Btnsuiv
        '
        Me.Btnsuiv.Location = New System.Drawing.Point(184, 35)
        Me.Btnsuiv.Name = "Btnsuiv"
        Me.Btnsuiv.Size = New System.Drawing.Size(60, 24)
        Me.Btnsuiv.TabIndex = 1
        Me.Btnsuiv.Text = ">"
        Me.Btnsuiv.UseVisualStyleBackColor = True
        '
        'BtnDeb
        '
        Me.BtnDeb.Location = New System.Drawing.Point(12, 35)
        Me.BtnDeb.Name = "BtnDeb"
        Me.BtnDeb.Size = New System.Drawing.Size(66, 24)
        Me.BtnDeb.TabIndex = 0
        Me.BtnDeb.Text = "<<"
        Me.BtnDeb.UseVisualStyleBackColor = True
        '
        'Quitter
        '
        Me.Quitter.Location = New System.Drawing.Point(414, 414)
        Me.Quitter.Name = "Quitter"
        Me.Quitter.Size = New System.Drawing.Size(104, 31)
        Me.Quitter.TabIndex = 26
        Me.Quitter.Text = "Fermer"
        Me.Quitter.UseVisualStyleBackColor = True
        '
        'DataGridView
        '
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Location = New System.Drawing.Point(387, 29)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.Size = New System.Drawing.Size(557, 262)
        Me.DataGridView.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Nom Client"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Prenom Client"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Rue Client"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Code Postal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 247)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Ville"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "ID Client"
        '
        'TextBoxIdClient
        '
        Me.TextBoxIdClient.Location = New System.Drawing.Point(154, 29)
        Me.TextBoxIdClient.Name = "TextBoxIdClient"
        Me.TextBoxIdClient.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxIdClient.TabIndex = 0
        '
        'AsmClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 454)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.Quitter)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBoxPrenomClient)
        Me.Controls.Add(Me.TextBoxAdRueClient)
        Me.Controls.Add(Me.TextBoxAdCpClient)
        Me.Controls.Add(Me.TextBoxAdVilleClient)
        Me.Controls.Add(Me.TextBoxNomClient)
        Me.Controls.Add(Me.TextBoxIdClient)
        Me.Name = "AsmClient"
        Me.Text = "Ajouter/Suprimer/Modifier client"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxNomClient As TextBox
    Friend WithEvents TextBoxAdVilleClient As TextBox
    Friend WithEvents TextBoxAdCpClient As TextBox
    Friend WithEvents TextBoxAdRueClient As TextBox
    Friend WithEvents TextBoxPrenomClient As TextBox
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents Quitter As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnModif As Button
    Friend WithEvents btnSupr As Button
    Friend WithEvents btnAjout As Button
    Friend WithEvents BtnFin As Button
    Friend WithEvents Btnpre As Button
    Friend WithEvents Btnsuiv As Button
    Friend WithEvents BtnDeb As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxRecherche As TextBox
    Friend WithEvents btnPDF As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxIdClient As TextBox
End Class
