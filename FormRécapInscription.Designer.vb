<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRécapInscription
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRécapInscription))
        Me.LabelNomC = New System.Windows.Forms.Label()
        Me.LabelPrénomC = New System.Windows.Forms.Label()
        Me.LabelAgeC = New System.Windows.Forms.Label()
        Me.LabelAdresseC = New System.Windows.Forms.Label()
        Me.LabelVilleC = New System.Windows.Forms.Label()
        Me.LabelRégionC = New System.Windows.Forms.Label()
        Me.LabelMatE = New System.Windows.Forms.Label()
        Me.LabelMatO = New System.Windows.Forms.Label()
        Me.ButtonEnrgInscr = New System.Windows.Forms.Button()
        Me.ButtonAnnulInscr = New System.Windows.Forms.Button()
        Me.ButtonRetrnModif = New System.Windows.Forms.Button()
        Me.LabelCPC = New System.Windows.Forms.Label()
        Me.LabelMatF = New System.Windows.Forms.Label()
        Me.LabelMatFacult = New System.Windows.Forms.Label()
        Me.LabelME1 = New System.Windows.Forms.Label()
        Me.LabelME2 = New System.Windows.Forms.Label()
        Me.Label2ME3 = New System.Windows.Forms.Label()
        Me.LabelME4 = New System.Windows.Forms.Label()
        Me.LabelMO1 = New System.Windows.Forms.Label()
        Me.LabelMO2 = New System.Windows.Forms.Label()
        Me.LabelMO3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelNomC
        '
        Me.LabelNomC.AutoSize = True
        Me.LabelNomC.Location = New System.Drawing.Point(260, 105)
        Me.LabelNomC.Name = "LabelNomC"
        Me.LabelNomC.Size = New System.Drawing.Size(81, 17)
        Me.LabelNomC.TabIndex = 0
        Me.LabelNomC.Text = "LabelNomC"
        '
        'LabelPrénomC
        '
        Me.LabelPrénomC.AutoSize = True
        Me.LabelPrénomC.Location = New System.Drawing.Point(260, 133)
        Me.LabelPrénomC.Name = "LabelPrénomC"
        Me.LabelPrénomC.Size = New System.Drawing.Size(101, 17)
        Me.LabelPrénomC.TabIndex = 1
        Me.LabelPrénomC.Text = "LabelPrénomC"
        '
        'LabelAgeC
        '
        Me.LabelAgeC.AutoSize = True
        Me.LabelAgeC.Location = New System.Drawing.Point(260, 165)
        Me.LabelAgeC.Name = "LabelAgeC"
        Me.LabelAgeC.Size = New System.Drawing.Size(77, 17)
        Me.LabelAgeC.TabIndex = 2
        Me.LabelAgeC.Text = "LabelAgeC"
        '
        'LabelAdresseC
        '
        Me.LabelAdresseC.AutoSize = True
        Me.LabelAdresseC.Location = New System.Drawing.Point(260, 197)
        Me.LabelAdresseC.Name = "LabelAdresseC"
        Me.LabelAdresseC.Size = New System.Drawing.Size(104, 17)
        Me.LabelAdresseC.TabIndex = 3
        Me.LabelAdresseC.Text = "LabelAdresseC"
        '
        'LabelVilleC
        '
        Me.LabelVilleC.AutoSize = True
        Me.LabelVilleC.Location = New System.Drawing.Point(260, 253)
        Me.LabelVilleC.Name = "LabelVilleC"
        Me.LabelVilleC.Size = New System.Drawing.Size(78, 17)
        Me.LabelVilleC.TabIndex = 4
        Me.LabelVilleC.Text = "LabelVilleC"
        '
        'LabelRégionC
        '
        Me.LabelRégionC.AutoSize = True
        Me.LabelRégionC.Location = New System.Drawing.Point(260, 286)
        Me.LabelRégionC.Name = "LabelRégionC"
        Me.LabelRégionC.Size = New System.Drawing.Size(97, 17)
        Me.LabelRégionC.TabIndex = 5
        Me.LabelRégionC.Text = "LabelRégionC"
        '
        'LabelMatE
        '
        Me.LabelMatE.AutoSize = True
        Me.LabelMatE.Location = New System.Drawing.Point(520, 68)
        Me.LabelMatE.Name = "LabelMatE"
        Me.LabelMatE.Size = New System.Drawing.Size(174, 17)
        Me.LabelMatE.TabIndex = 6
        Me.LabelMatE.Text = "Matières Ecrites Choisies :"
        '
        'LabelMatO
        '
        Me.LabelMatO.AutoSize = True
        Me.LabelMatO.Location = New System.Drawing.Point(520, 176)
        Me.LabelMatO.Name = "LabelMatO"
        Me.LabelMatO.Size = New System.Drawing.Size(173, 17)
        Me.LabelMatO.TabIndex = 9
        Me.LabelMatO.Text = "Matières Orales Choisies :"
        '
        'ButtonEnrgInscr
        '
        Me.ButtonEnrgInscr.Location = New System.Drawing.Point(252, 370)
        Me.ButtonEnrgInscr.Name = "ButtonEnrgInscr"
        Me.ButtonEnrgInscr.Size = New System.Drawing.Size(109, 51)
        Me.ButtonEnrgInscr.TabIndex = 10
        Me.ButtonEnrgInscr.Text = "Enregistrer"
        Me.ButtonEnrgInscr.UseVisualStyleBackColor = True
        '
        'ButtonAnnulInscr
        '
        Me.ButtonAnnulInscr.Location = New System.Drawing.Point(523, 370)
        Me.ButtonAnnulInscr.Name = "ButtonAnnulInscr"
        Me.ButtonAnnulInscr.Size = New System.Drawing.Size(109, 51)
        Me.ButtonAnnulInscr.TabIndex = 11
        Me.ButtonAnnulInscr.Text = "Annuler "
        Me.ButtonAnnulInscr.UseVisualStyleBackColor = True
        '
        'ButtonRetrnModif
        '
        Me.ButtonRetrnModif.Location = New System.Drawing.Point(803, 370)
        Me.ButtonRetrnModif.Name = "ButtonRetrnModif"
        Me.ButtonRetrnModif.Size = New System.Drawing.Size(109, 51)
        Me.ButtonRetrnModif.TabIndex = 12
        Me.ButtonRetrnModif.Text = "Modifier"
        Me.ButtonRetrnModif.UseVisualStyleBackColor = True
        '
        'LabelCPC
        '
        Me.LabelCPC.AutoSize = True
        Me.LabelCPC.Location = New System.Drawing.Point(260, 223)
        Me.LabelCPC.Name = "LabelCPC"
        Me.LabelCPC.Size = New System.Drawing.Size(70, 17)
        Me.LabelCPC.TabIndex = 3
        Me.LabelCPC.Text = "LabelCPC"
        '
        'LabelMatF
        '
        Me.LabelMatF.AutoSize = True
        Me.LabelMatF.Location = New System.Drawing.Point(523, 267)
        Me.LabelMatF.Name = "LabelMatF"
        Me.LabelMatF.Size = New System.Drawing.Size(171, 17)
        Me.LabelMatF.TabIndex = 13
        Me.LabelMatF.Text = "Matière facultative choisie"
        '
        'LabelMatFacult
        '
        Me.LabelMatFacult.AutoSize = True
        Me.LabelMatFacult.Location = New System.Drawing.Point(558, 297)
        Me.LabelMatFacult.Name = "LabelMatFacult"
        Me.LabelMatFacult.Size = New System.Drawing.Size(0, 17)
        Me.LabelMatFacult.TabIndex = 14
        '
        'LabelME1
        '
        Me.LabelME1.AutoSize = True
        Me.LabelME1.Location = New System.Drawing.Point(542, 100)
        Me.LabelME1.Name = "LabelME1"
        Me.LabelME1.Size = New System.Drawing.Size(51, 17)
        Me.LabelME1.TabIndex = 15
        Me.LabelME1.Text = "Label1"
        '
        'LabelME2
        '
        Me.LabelME2.AutoSize = True
        Me.LabelME2.Location = New System.Drawing.Point(542, 144)
        Me.LabelME2.Name = "LabelME2"
        Me.LabelME2.Size = New System.Drawing.Size(51, 17)
        Me.LabelME2.TabIndex = 15
        Me.LabelME2.Text = "Label1"
        '
        'Label2ME3
        '
        Me.Label2ME3.AutoSize = True
        Me.Label2ME3.Location = New System.Drawing.Point(760, 100)
        Me.Label2ME3.Name = "Label2ME3"
        Me.Label2ME3.Size = New System.Drawing.Size(51, 17)
        Me.Label2ME3.TabIndex = 15
        Me.Label2ME3.Text = "Label1"
        '
        'LabelME4
        '
        Me.LabelME4.AutoSize = True
        Me.LabelME4.Location = New System.Drawing.Point(760, 144)
        Me.LabelME4.Name = "LabelME4"
        Me.LabelME4.Size = New System.Drawing.Size(51, 17)
        Me.LabelME4.TabIndex = 15
        Me.LabelME4.Text = "Label1"
        '
        'LabelMO1
        '
        Me.LabelMO1.AutoSize = True
        Me.LabelMO1.Location = New System.Drawing.Point(542, 211)
        Me.LabelMO1.Name = "LabelMO1"
        Me.LabelMO1.Size = New System.Drawing.Size(51, 17)
        Me.LabelMO1.TabIndex = 15
        Me.LabelMO1.Text = "Label1"
        '
        'LabelMO2
        '
        Me.LabelMO2.AutoSize = True
        Me.LabelMO2.Location = New System.Drawing.Point(671, 211)
        Me.LabelMO2.Name = "LabelMO2"
        Me.LabelMO2.Size = New System.Drawing.Size(51, 17)
        Me.LabelMO2.TabIndex = 15
        Me.LabelMO2.Text = "Label1"
        '
        'LabelMO3
        '
        Me.LabelMO3.AutoSize = True
        Me.LabelMO3.Location = New System.Drawing.Point(816, 211)
        Me.LabelMO3.Name = "LabelMO3"
        Me.LabelMO3.Size = New System.Drawing.Size(51, 17)
        Me.LabelMO3.TabIndex = 15
        Me.LabelMO3.Text = "Label1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-102, -66)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1213, 678)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(28, 165)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(143, 138)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'FormRécapInscription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 476)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LabelME4)
        Me.Controls.Add(Me.Label2ME3)
        Me.Controls.Add(Me.LabelME2)
        Me.Controls.Add(Me.LabelMO3)
        Me.Controls.Add(Me.LabelMO2)
        Me.Controls.Add(Me.LabelMO1)
        Me.Controls.Add(Me.LabelME1)
        Me.Controls.Add(Me.LabelMatFacult)
        Me.Controls.Add(Me.LabelMatF)
        Me.Controls.Add(Me.ButtonRetrnModif)
        Me.Controls.Add(Me.ButtonAnnulInscr)
        Me.Controls.Add(Me.ButtonEnrgInscr)
        Me.Controls.Add(Me.LabelMatO)
        Me.Controls.Add(Me.LabelMatE)
        Me.Controls.Add(Me.LabelRégionC)
        Me.Controls.Add(Me.LabelVilleC)
        Me.Controls.Add(Me.LabelCPC)
        Me.Controls.Add(Me.LabelAdresseC)
        Me.Controls.Add(Me.LabelAgeC)
        Me.Controls.Add(Me.LabelPrénomC)
        Me.Controls.Add(Me.LabelNomC)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormRécapInscription"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRécapInscription"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelNomC As Label
    Friend WithEvents LabelPrénomC As Label
    Friend WithEvents LabelAgeC As Label
    Friend WithEvents LabelAdresseC As Label
    Friend WithEvents LabelVilleC As Label
    Friend WithEvents LabelRégionC As Label
    Friend WithEvents LabelMatE As Label
    Friend WithEvents LabelMatEcritesChoisis As Label
    Friend WithEvents LabelMatO As Label
    Friend WithEvents ButtonEnrgInscr As Button
    Friend WithEvents ButtonAnnulInscr As Button
    Friend WithEvents ButtonRetrnModif As Button
    Friend WithEvents LabelCPC As Label
    Friend WithEvents LabelMatF As Label
    Friend WithEvents LabelMatFacult As Label
    Friend WithEvents LabelME1 As Label
    Friend WithEvents LabelME2 As Label
    Friend WithEvents Label2ME3 As Label
    Friend WithEvents LabelME4 As Label
    Friend WithEvents LabelMO1 As Label
    Friend WithEvents LabelMO2 As Label
    Friend WithEvents LabelMO3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
