<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAccueil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAccueil))
        Me.ButtonEnregistrerIns = New System.Windows.Forms.Button()
        Me.ButtonModifInscription = New System.Windows.Forms.Button()
        Me.ButtonSuppInscription = New System.Windows.Forms.Button()
        Me.ButtonBilan = New System.Windows.Forms.Button()
        Me.ButtonFinInscriptions = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonCloseApp = New System.Windows.Forms.Button()
        Me.LabelEtat = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonEnregistrerIns
        '
        Me.ButtonEnregistrerIns.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonEnregistrerIns.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonEnregistrerIns.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEnregistrerIns.ForeColor = System.Drawing.Color.Black
        Me.ButtonEnregistrerIns.Location = New System.Drawing.Point(61, 93)
        Me.ButtonEnregistrerIns.Name = "ButtonEnregistrerIns"
        Me.ButtonEnregistrerIns.Size = New System.Drawing.Size(284, 51)
        Me.ButtonEnregistrerIns.TabIndex = 0
        Me.ButtonEnregistrerIns.Text = "Enregistrer une Inscription"
        Me.ButtonEnregistrerIns.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonEnregistrerIns.UseVisualStyleBackColor = False
        '
        'ButtonModifInscription
        '
        Me.ButtonModifInscription.BackColor = System.Drawing.Color.RoyalBlue
        Me.ButtonModifInscription.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonModifInscription.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonModifInscription.Location = New System.Drawing.Point(535, 93)
        Me.ButtonModifInscription.Name = "ButtonModifInscription"
        Me.ButtonModifInscription.Size = New System.Drawing.Size(307, 51)
        Me.ButtonModifInscription.TabIndex = 1
        Me.ButtonModifInscription.Text = "Modifier une Inscription  "
        Me.ButtonModifInscription.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonModifInscription.UseVisualStyleBackColor = False
        '
        'ButtonSuppInscription
        '
        Me.ButtonSuppInscription.BackColor = System.Drawing.Color.Coral
        Me.ButtonSuppInscription.FlatAppearance.BorderSize = 0
        Me.ButtonSuppInscription.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonSuppInscription.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSuppInscription.Location = New System.Drawing.Point(61, 212)
        Me.ButtonSuppInscription.Name = "ButtonSuppInscription"
        Me.ButtonSuppInscription.Size = New System.Drawing.Size(284, 51)
        Me.ButtonSuppInscription.TabIndex = 2
        Me.ButtonSuppInscription.Text = "Supprimer une inscription"
        Me.ButtonSuppInscription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSuppInscription.UseVisualStyleBackColor = False
        '
        'ButtonBilan
        '
        Me.ButtonBilan.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.ButtonBilan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonBilan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBilan.Location = New System.Drawing.Point(535, 212)
        Me.ButtonBilan.Name = "ButtonBilan"
        Me.ButtonBilan.Size = New System.Drawing.Size(307, 51)
        Me.ButtonBilan.TabIndex = 3
        Me.ButtonBilan.Text = "Bilan "
        Me.ButtonBilan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonBilan.UseVisualStyleBackColor = False
        '
        'ButtonFinInscriptions
        '
        Me.ButtonFinInscriptions.BackColor = System.Drawing.Color.Orange
        Me.ButtonFinInscriptions.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonFinInscriptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFinInscriptions.Location = New System.Drawing.Point(535, 321)
        Me.ButtonFinInscriptions.Name = "ButtonFinInscriptions"
        Me.ButtonFinInscriptions.Size = New System.Drawing.Size(307, 51)
        Me.ButtonFinInscriptions.TabIndex = 4
        Me.ButtonFinInscriptions.Text = "Mettre fin aux Inscriptions"
        Me.ButtonFinInscriptions.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonFinInscriptions.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(61, 321)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(284, 51)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Etat actuel des inscription"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ButtonCloseApp
        '
        Me.ButtonCloseApp.BackColor = System.Drawing.Color.Gray
        Me.ButtonCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonCloseApp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCloseApp.Location = New System.Drawing.Point(334, 431)
        Me.ButtonCloseApp.Name = "ButtonCloseApp"
        Me.ButtonCloseApp.Size = New System.Drawing.Size(221, 44)
        Me.ButtonCloseApp.TabIndex = 3
        Me.ButtonCloseApp.Text = "Fermer l'application "
        Me.ButtonCloseApp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonCloseApp.UseVisualStyleBackColor = False
        '
        'LabelEtat
        '
        Me.LabelEtat.AutoSize = True
        Me.LabelEtat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEtat.ForeColor = System.Drawing.Color.White
        Me.LabelEtat.Location = New System.Drawing.Point(411, 21)
        Me.LabelEtat.Name = "LabelEtat"
        Me.LabelEtat.Size = New System.Drawing.Size(60, 18)
        Me.LabelEtat.TabIndex = 6
        Me.LabelEtat.Text = "Ouverte"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-8, -4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(927, 535)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.LightGray
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(397, 194)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(102, 99)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(293, 102)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(35, 34)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.RoyalBlue
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(562, 99)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(41, 38)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 10
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Coral
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(291, 219)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(37, 36)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 11
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(560, 214)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(48, 44)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 12
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Gold
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(290, 325)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(38, 41)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 13
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Orange
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(564, 326)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(44, 43)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 14
        Me.PictureBox8.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Gray
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(348, 438)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 15
        Me.PictureBox9.TabStop = False
        '
        'FormAccueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 503)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LabelEtat)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonFinInscriptions)
        Me.Controls.Add(Me.ButtonCloseApp)
        Me.Controls.Add(Me.ButtonBilan)
        Me.Controls.Add(Me.ButtonSuppInscription)
        Me.Controls.Add(Me.ButtonModifInscription)
        Me.Controls.Add(Me.ButtonEnregistrerIns)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormAccueil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonEnregistrerIns As Button
    Friend WithEvents ButtonModifInscription As Button
    Friend WithEvents ButtonSuppInscription As Button
    Friend WithEvents ButtonBilan As Button
    Friend WithEvents ButtonFinInscriptions As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ButtonCloseApp As Button
    Friend WithEvents LabelEtat As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
End Class
