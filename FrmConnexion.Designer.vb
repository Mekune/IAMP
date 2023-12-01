<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConnexion
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxServeur = New System.Windows.Forms.TextBox()
        Me.TextBoxBDD = New System.Windows.Forms.TextBox()
        Me.TextBoxLogin = New System.Windows.Forms.TextBox()
        Me.TextBoxMdp = New System.Windows.Forms.TextBox()
        Me.btnAuto = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom Du Serveur :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nom de la base de Données :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Login :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Mot De Passe :"
        '
        'TextBoxServeur
        '
        Me.TextBoxServeur.Location = New System.Drawing.Point(120, 24)
        Me.TextBoxServeur.Name = "TextBoxServeur"
        Me.TextBoxServeur.Size = New System.Drawing.Size(219, 20)
        Me.TextBoxServeur.TabIndex = 4
        Me.TextBoxServeur.Text = "Saisir ici votre Serveur : localhost / sxxxPxx"
        '
        'TextBoxBDD
        '
        Me.TextBoxBDD.Location = New System.Drawing.Point(172, 71)
        Me.TextBoxBDD.Name = "TextBoxBDD"
        Me.TextBoxBDD.Size = New System.Drawing.Size(167, 20)
        Me.TextBoxBDD.TabIndex = 5
        Me.TextBoxBDD.Text = "Saisir ici votre BDD : GestStage!"
        '
        'TextBoxLogin
        '
        Me.TextBoxLogin.Location = New System.Drawing.Point(90, 119)
        Me.TextBoxLogin.Name = "TextBoxLogin"
        Me.TextBoxLogin.Size = New System.Drawing.Size(249, 20)
        Me.TextBoxLogin.TabIndex = 6
        '
        'TextBoxMdp
        '
        Me.TextBoxMdp.Location = New System.Drawing.Point(90, 161)
        Me.TextBoxMdp.Name = "TextBoxMdp"
        Me.TextBoxMdp.Size = New System.Drawing.Size(249, 20)
        Me.TextBoxMdp.TabIndex = 7
        '
        'btnAuto
        '
        Me.btnAuto.Location = New System.Drawing.Point(382, 48)
        Me.btnAuto.Name = "btnAuto"
        Me.btnAuto.Size = New System.Drawing.Size(91, 144)
        Me.btnAuto.TabIndex = 8
        Me.btnAuto.Text = "Auto"
        Me.btnAuto.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(263, 215)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(94, 36)
        Me.btnReset.TabIndex = 9
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(32, 215)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(100, 36)
        Me.btnOK.TabIndex = 10
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'FrmConnexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 274)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnAuto)
        Me.Controls.Add(Me.TextBoxMdp)
        Me.Controls.Add(Me.TextBoxLogin)
        Me.Controls.Add(Me.TextBoxBDD)
        Me.Controls.Add(Me.TextBoxServeur)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmConnexion"
        Me.Text = "Connexion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxServeur As TextBox
    Friend WithEvents TextBoxBDD As TextBox
    Friend WithEvents TextBoxLogin As TextBox
    Friend WithEvents TextBoxMdp As TextBox
    Friend WithEvents btnAuto As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnOK As Button
End Class
