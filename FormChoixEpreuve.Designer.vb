<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormChoixEpreuve
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormChoixEpreuve))
        Me.LabelNomC = New System.Windows.Forms.Label()
        Me.labelPrenomC = New System.Windows.Forms.Label()
        Me.ComboBoxRégion = New System.Windows.Forms.ComboBox()
        Me.paneEplEcrit = New System.Windows.Forms.Panel()
        Me.CheckBoxLangageC = New System.Windows.Forms.CheckBox()
        Me.CheckBoxBasededonnees = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSystème = New System.Windows.Forms.CheckBox()
        Me.CheckBoxVisualBasicNET = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMathématiques = New System.Windows.Forms.CheckBox()
        Me.CheckBoxExpression = New System.Windows.Forms.CheckBox()
        Me.CheckBoxLangageJava = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDroit = New System.Windows.Forms.CheckBox()
        Me.CheckBoxRéseau = New System.Windows.Forms.CheckBox()
        Me.CheckBoxProgrammationweb = New System.Windows.Forms.CheckBox()
        Me.CheckBoxGestion = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAlgorithmique = New System.Windows.Forms.CheckBox()
        Me.panelEpOral = New System.Windows.Forms.Panel()
        Me.CheckBoxMathématiquesO = New System.Windows.Forms.CheckBox()
        Me.CheckBoxExpressionO = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSystèmeO = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDroitO = New System.Windows.Forms.CheckBox()
        Me.CheckBoxRéseauO = New System.Windows.Forms.CheckBox()
        Me.CheckBoxGestionO = New System.Windows.Forms.CheckBox()
        Me.CheckBoxEspagnol = New System.Windows.Forms.CheckBox()
        Me.CheckBoxChinois = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAnglais = New System.Windows.Forms.CheckBox()
        Me.LabelMatEpE = New System.Windows.Forms.Label()
        Me.LabelMatEpO = New System.Windows.Forms.Label()
        Me.TimerClose2 = New System.Windows.Forms.Timer(Me.components)
        Me.monTimer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labelChoixRestEcrit = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.labelChoixRestOral = New System.Windows.Forms.Label()
        Me.ButtonAbondon = New System.Windows.Forms.Button()
        Me.ButtonValidEnrgIns = New System.Windows.Forms.Button()
        Me.RadioButtonEpFacult1 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonEpFacult2 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelEpFacultatif = New System.Windows.Forms.Panel()
        Me.ComboBoxMatFacult = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.paneEplEcrit.SuspendLayout()
        Me.panelEpOral.SuspendLayout()
        Me.PanelEpFacultatif.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelNomC
        '
        Me.LabelNomC.AutoSize = True
        Me.LabelNomC.Location = New System.Drawing.Point(83, 70)
        Me.LabelNomC.Name = "LabelNomC"
        Me.LabelNomC.Size = New System.Drawing.Size(76, 17)
        Me.LabelNomC.TabIndex = 0
        Me.LabelNomC.Text = "labelNomC"
        '
        'labelPrenomC
        '
        Me.labelPrenomC.AutoSize = True
        Me.labelPrenomC.Location = New System.Drawing.Point(165, 70)
        Me.labelPrenomC.Name = "labelPrenomC"
        Me.labelPrenomC.Size = New System.Drawing.Size(96, 17)
        Me.labelPrenomC.TabIndex = 1
        Me.labelPrenomC.Text = "labelPrenomC"
        '
        'ComboBoxRégion
        '
        Me.ComboBoxRégion.FormattingEnabled = True
        Me.ComboBoxRégion.Location = New System.Drawing.Point(65, 124)
        Me.ComboBoxRégion.Name = "ComboBoxRégion"
        Me.ComboBoxRégion.Size = New System.Drawing.Size(223, 24)
        Me.ComboBoxRégion.TabIndex = 2
        '
        'paneEplEcrit
        '
        Me.paneEplEcrit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.paneEplEcrit.Controls.Add(Me.CheckBoxLangageC)
        Me.paneEplEcrit.Controls.Add(Me.CheckBoxBasededonnees)
        Me.paneEplEcrit.Controls.Add(Me.CheckBoxSystème)
        Me.paneEplEcrit.Controls.Add(Me.CheckBoxVisualBasicNET)
        Me.paneEplEcrit.Controls.Add(Me.CheckBoxMathématiques)
        Me.paneEplEcrit.Controls.Add(Me.CheckBoxExpression)
        Me.paneEplEcrit.Controls.Add(Me.CheckBoxLangageJava)
        Me.paneEplEcrit.Controls.Add(Me.CheckBoxDroit)
        Me.paneEplEcrit.Controls.Add(Me.CheckBoxRéseau)
        Me.paneEplEcrit.Controls.Add(Me.CheckBoxProgrammationweb)
        Me.paneEplEcrit.Controls.Add(Me.CheckBoxGestion)
        Me.paneEplEcrit.Controls.Add(Me.CheckBoxAlgorithmique)
        Me.paneEplEcrit.Location = New System.Drawing.Point(371, 66)
        Me.paneEplEcrit.Name = "paneEplEcrit"
        Me.paneEplEcrit.Size = New System.Drawing.Size(203, 326)
        Me.paneEplEcrit.TabIndex = 3
        '
        'CheckBoxLangageC
        '
        Me.CheckBoxLangageC.AutoSize = True
        Me.CheckBoxLangageC.Location = New System.Drawing.Point(32, 104)
        Me.CheckBoxLangageC.Name = "CheckBoxLangageC"
        Me.CheckBoxLangageC.Size = New System.Drawing.Size(99, 21)
        Me.CheckBoxLangageC.TabIndex = 11
        Me.CheckBoxLangageC.Text = "Langage C"
        Me.CheckBoxLangageC.UseVisualStyleBackColor = True
        '
        'CheckBoxBasededonnees
        '
        Me.CheckBoxBasededonnees.AutoSize = True
        Me.CheckBoxBasededonnees.Location = New System.Drawing.Point(32, 84)
        Me.CheckBoxBasededonnees.Name = "CheckBoxBasededonnees"
        Me.CheckBoxBasededonnees.Size = New System.Drawing.Size(141, 21)
        Me.CheckBoxBasededonnees.TabIndex = 10
        Me.CheckBoxBasededonnees.Text = "Base de données"
        Me.CheckBoxBasededonnees.UseVisualStyleBackColor = True
        '
        'CheckBoxSystème
        '
        Me.CheckBoxSystème.AutoSize = True
        Me.CheckBoxSystème.Location = New System.Drawing.Point(32, 212)
        Me.CheckBoxSystème.Name = "CheckBoxSystème"
        Me.CheckBoxSystème.Size = New System.Drawing.Size(84, 21)
        Me.CheckBoxSystème.TabIndex = 15
        Me.CheckBoxSystème.Text = "Système"
        Me.CheckBoxSystème.UseVisualStyleBackColor = True
        '
        'CheckBoxVisualBasicNET
        '
        Me.CheckBoxVisualBasicNET.AutoSize = True
        Me.CheckBoxVisualBasicNET.Location = New System.Drawing.Point(32, 293)
        Me.CheckBoxVisualBasicNET.Name = "CheckBoxVisualBasicNET"
        Me.CheckBoxVisualBasicNET.Size = New System.Drawing.Size(142, 21)
        Me.CheckBoxVisualBasicNET.TabIndex = 18
        Me.CheckBoxVisualBasicNET.Text = "Visual Basic .NET"
        Me.CheckBoxVisualBasicNET.UseVisualStyleBackColor = True
        '
        'CheckBoxMathématiques
        '
        Me.CheckBoxMathématiques.AutoSize = True
        Me.CheckBoxMathématiques.Location = New System.Drawing.Point(32, 266)
        Me.CheckBoxMathématiques.Name = "CheckBoxMathématiques"
        Me.CheckBoxMathématiques.Size = New System.Drawing.Size(126, 21)
        Me.CheckBoxMathématiques.TabIndex = 17
        Me.CheckBoxMathématiques.Text = "Mathématiques"
        Me.CheckBoxMathématiques.UseVisualStyleBackColor = True
        '
        'CheckBoxExpression
        '
        Me.CheckBoxExpression.AutoSize = True
        Me.CheckBoxExpression.Location = New System.Drawing.Point(32, 239)
        Me.CheckBoxExpression.Name = "CheckBoxExpression"
        Me.CheckBoxExpression.Size = New System.Drawing.Size(99, 21)
        Me.CheckBoxExpression.TabIndex = 16
        Me.CheckBoxExpression.Text = "Expression"
        Me.CheckBoxExpression.UseVisualStyleBackColor = True
        '
        'CheckBoxLangageJava
        '
        Me.CheckBoxLangageJava.AutoSize = True
        Me.CheckBoxLangageJava.Location = New System.Drawing.Point(32, 185)
        Me.CheckBoxLangageJava.Name = "CheckBoxLangageJava"
        Me.CheckBoxLangageJava.Size = New System.Drawing.Size(120, 21)
        Me.CheckBoxLangageJava.TabIndex = 14
        Me.CheckBoxLangageJava.Text = "Langage Java"
        Me.CheckBoxLangageJava.UseVisualStyleBackColor = True
        '
        'CheckBoxDroit
        '
        Me.CheckBoxDroit.AutoSize = True
        Me.CheckBoxDroit.Location = New System.Drawing.Point(32, 158)
        Me.CheckBoxDroit.Name = "CheckBoxDroit"
        Me.CheckBoxDroit.Size = New System.Drawing.Size(60, 21)
        Me.CheckBoxDroit.TabIndex = 13
        Me.CheckBoxDroit.Text = "Droit"
        Me.CheckBoxDroit.UseVisualStyleBackColor = True
        '
        'CheckBoxRéseau
        '
        Me.CheckBoxRéseau.AutoSize = True
        Me.CheckBoxRéseau.Location = New System.Drawing.Point(32, 131)
        Me.CheckBoxRéseau.Name = "CheckBoxRéseau"
        Me.CheckBoxRéseau.Size = New System.Drawing.Size(79, 21)
        Me.CheckBoxRéseau.TabIndex = 12
        Me.CheckBoxRéseau.Text = "Réseau"
        Me.CheckBoxRéseau.UseVisualStyleBackColor = True
        '
        'CheckBoxProgrammationweb
        '
        Me.CheckBoxProgrammationweb.AutoSize = True
        Me.CheckBoxProgrammationweb.Location = New System.Drawing.Point(32, 57)
        Me.CheckBoxProgrammationweb.Name = "CheckBoxProgrammationweb"
        Me.CheckBoxProgrammationweb.Size = New System.Drawing.Size(155, 21)
        Me.CheckBoxProgrammationweb.TabIndex = 9
        Me.CheckBoxProgrammationweb.Text = "Programmation web"
        Me.CheckBoxProgrammationweb.UseVisualStyleBackColor = True
        '
        'CheckBoxGestion
        '
        Me.CheckBoxGestion.AutoSize = True
        Me.CheckBoxGestion.Location = New System.Drawing.Point(32, 30)
        Me.CheckBoxGestion.Name = "CheckBoxGestion"
        Me.CheckBoxGestion.Size = New System.Drawing.Size(79, 21)
        Me.CheckBoxGestion.TabIndex = 8
        Me.CheckBoxGestion.Text = "Gestion"
        Me.CheckBoxGestion.UseVisualStyleBackColor = True
        '
        'CheckBoxAlgorithmique
        '
        Me.CheckBoxAlgorithmique.AutoSize = True
        Me.CheckBoxAlgorithmique.Location = New System.Drawing.Point(32, 3)
        Me.CheckBoxAlgorithmique.Name = "CheckBoxAlgorithmique"
        Me.CheckBoxAlgorithmique.Size = New System.Drawing.Size(116, 21)
        Me.CheckBoxAlgorithmique.TabIndex = 7
        Me.CheckBoxAlgorithmique.Text = "Algorithmique"
        Me.CheckBoxAlgorithmique.UseVisualStyleBackColor = True
        '
        'panelEpOral
        '
        Me.panelEpOral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelEpOral.Controls.Add(Me.CheckBoxMathématiquesO)
        Me.panelEpOral.Controls.Add(Me.CheckBoxExpressionO)
        Me.panelEpOral.Controls.Add(Me.CheckBoxSystèmeO)
        Me.panelEpOral.Controls.Add(Me.CheckBoxDroitO)
        Me.panelEpOral.Controls.Add(Me.CheckBoxRéseauO)
        Me.panelEpOral.Controls.Add(Me.CheckBoxGestionO)
        Me.panelEpOral.Controls.Add(Me.CheckBoxEspagnol)
        Me.panelEpOral.Controls.Add(Me.CheckBoxChinois)
        Me.panelEpOral.Controls.Add(Me.CheckBoxAnglais)
        Me.panelEpOral.Location = New System.Drawing.Point(614, 66)
        Me.panelEpOral.Name = "panelEpOral"
        Me.panelEpOral.Size = New System.Drawing.Size(200, 326)
        Me.panelEpOral.TabIndex = 4
        '
        'CheckBoxMathématiquesO
        '
        Me.CheckBoxMathématiquesO.AutoSize = True
        Me.CheckBoxMathématiquesO.Location = New System.Drawing.Point(42, 289)
        Me.CheckBoxMathématiquesO.Name = "CheckBoxMathématiquesO"
        Me.CheckBoxMathématiquesO.Size = New System.Drawing.Size(126, 21)
        Me.CheckBoxMathématiquesO.TabIndex = 16
        Me.CheckBoxMathématiquesO.Text = "Mathématiques"
        Me.CheckBoxMathématiquesO.UseVisualStyleBackColor = True
        '
        'CheckBoxExpressionO
        '
        Me.CheckBoxExpressionO.AutoSize = True
        Me.CheckBoxExpressionO.Location = New System.Drawing.Point(42, 253)
        Me.CheckBoxExpressionO.Name = "CheckBoxExpressionO"
        Me.CheckBoxExpressionO.Size = New System.Drawing.Size(99, 21)
        Me.CheckBoxExpressionO.TabIndex = 15
        Me.CheckBoxExpressionO.Text = "Expression"
        Me.CheckBoxExpressionO.UseVisualStyleBackColor = True
        '
        'CheckBoxSystèmeO
        '
        Me.CheckBoxSystèmeO.AutoSize = True
        Me.CheckBoxSystèmeO.Location = New System.Drawing.Point(42, 212)
        Me.CheckBoxSystèmeO.Name = "CheckBoxSystèmeO"
        Me.CheckBoxSystèmeO.Size = New System.Drawing.Size(84, 21)
        Me.CheckBoxSystèmeO.TabIndex = 14
        Me.CheckBoxSystèmeO.Text = "Système"
        Me.CheckBoxSystèmeO.UseVisualStyleBackColor = True
        '
        'CheckBoxDroitO
        '
        Me.CheckBoxDroitO.AutoSize = True
        Me.CheckBoxDroitO.Location = New System.Drawing.Point(42, 169)
        Me.CheckBoxDroitO.Name = "CheckBoxDroitO"
        Me.CheckBoxDroitO.Size = New System.Drawing.Size(60, 21)
        Me.CheckBoxDroitO.TabIndex = 13
        Me.CheckBoxDroitO.Text = "Droit"
        Me.CheckBoxDroitO.UseVisualStyleBackColor = True
        '
        'CheckBoxRéseauO
        '
        Me.CheckBoxRéseauO.AutoSize = True
        Me.CheckBoxRéseauO.Location = New System.Drawing.Point(42, 131)
        Me.CheckBoxRéseauO.Name = "CheckBoxRéseauO"
        Me.CheckBoxRéseauO.Size = New System.Drawing.Size(79, 21)
        Me.CheckBoxRéseauO.TabIndex = 12
        Me.CheckBoxRéseauO.Text = "Réseau"
        Me.CheckBoxRéseauO.UseVisualStyleBackColor = True
        '
        'CheckBoxGestionO
        '
        Me.CheckBoxGestionO.AutoSize = True
        Me.CheckBoxGestionO.Location = New System.Drawing.Point(42, 95)
        Me.CheckBoxGestionO.Name = "CheckBoxGestionO"
        Me.CheckBoxGestionO.Size = New System.Drawing.Size(79, 21)
        Me.CheckBoxGestionO.TabIndex = 11
        Me.CheckBoxGestionO.Text = "Gestion"
        Me.CheckBoxGestionO.UseVisualStyleBackColor = True
        '
        'CheckBoxEspagnol
        '
        Me.CheckBoxEspagnol.AutoSize = True
        Me.CheckBoxEspagnol.Location = New System.Drawing.Point(42, 57)
        Me.CheckBoxEspagnol.Name = "CheckBoxEspagnol"
        Me.CheckBoxEspagnol.Size = New System.Drawing.Size(89, 21)
        Me.CheckBoxEspagnol.TabIndex = 10
        Me.CheckBoxEspagnol.Text = "Espagnol"
        Me.CheckBoxEspagnol.UseVisualStyleBackColor = True
        '
        'CheckBoxChinois
        '
        Me.CheckBoxChinois.AutoSize = True
        Me.CheckBoxChinois.Location = New System.Drawing.Point(42, 30)
        Me.CheckBoxChinois.Name = "CheckBoxChinois"
        Me.CheckBoxChinois.Size = New System.Drawing.Size(76, 21)
        Me.CheckBoxChinois.TabIndex = 9
        Me.CheckBoxChinois.Text = "Chinois"
        Me.CheckBoxChinois.UseVisualStyleBackColor = True
        '
        'CheckBoxAnglais
        '
        Me.CheckBoxAnglais.AutoSize = True
        Me.CheckBoxAnglais.Location = New System.Drawing.Point(42, 3)
        Me.CheckBoxAnglais.Name = "CheckBoxAnglais"
        Me.CheckBoxAnglais.Size = New System.Drawing.Size(76, 21)
        Me.CheckBoxAnglais.TabIndex = 8
        Me.CheckBoxAnglais.Text = "Anglais"
        Me.CheckBoxAnglais.UseVisualStyleBackColor = True
        '
        'LabelMatEpE
        '
        Me.LabelMatEpE.AutoSize = True
        Me.LabelMatEpE.Location = New System.Drawing.Point(381, 35)
        Me.LabelMatEpE.Name = "LabelMatEpE"
        Me.LabelMatEpE.Size = New System.Drawing.Size(173, 17)
        Me.LabelMatEpE.TabIndex = 5
        Me.LabelMatEpE.Text = "Matières Epreuves Ecrites"
        '
        'LabelMatEpO
        '
        Me.LabelMatEpO.AutoSize = True
        Me.LabelMatEpO.Location = New System.Drawing.Point(615, 35)
        Me.LabelMatEpO.Name = "LabelMatEpO"
        Me.LabelMatEpO.Size = New System.Drawing.Size(172, 17)
        Me.LabelMatEpO.TabIndex = 6
        Me.LabelMatEpO.Text = "Matières Epreuves Orales"
        '
        'TimerClose2
        '
        Me.TimerClose2.Enabled = True
        Me.TimerClose2.Interval = 90000
        '
        'monTimer2
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(368, 404)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Choix restant (écrit):"
        '
        'labelChoixRestEcrit
        '
        Me.labelChoixRestEcrit.AutoSize = True
        Me.labelChoixRestEcrit.Location = New System.Drawing.Point(509, 404)
        Me.labelChoixRestEcrit.Name = "labelChoixRestEcrit"
        Me.labelChoixRestEcrit.Size = New System.Drawing.Size(0, 17)
        Me.labelChoixRestEcrit.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(624, 404)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Choix restant (oral):"
        '
        'labelChoixRestOral
        '
        Me.labelChoixRestOral.AutoSize = True
        Me.labelChoixRestOral.Location = New System.Drawing.Point(762, 404)
        Me.labelChoixRestOral.Name = "labelChoixRestOral"
        Me.labelChoixRestOral.Size = New System.Drawing.Size(0, 17)
        Me.labelChoixRestOral.TabIndex = 9
        '
        'ButtonAbondon
        '
        Me.ButtonAbondon.Location = New System.Drawing.Point(108, 458)
        Me.ButtonAbondon.Name = "ButtonAbondon"
        Me.ButtonAbondon.Size = New System.Drawing.Size(250, 54)
        Me.ButtonAbondon.TabIndex = 10
        Me.ButtonAbondon.Text = "Abondoner"
        Me.ButtonAbondon.UseVisualStyleBackColor = True
        '
        'ButtonValidEnrgIns
        '
        Me.ButtonValidEnrgIns.Location = New System.Drawing.Point(548, 461)
        Me.ButtonValidEnrgIns.Name = "ButtonValidEnrgIns"
        Me.ButtonValidEnrgIns.Size = New System.Drawing.Size(299, 49)
        Me.ButtonValidEnrgIns.TabIndex = 11
        Me.ButtonValidEnrgIns.Text = "Valider"
        Me.ButtonValidEnrgIns.UseVisualStyleBackColor = True
        '
        'RadioButtonEpFacult1
        '
        Me.RadioButtonEpFacult1.AutoSize = True
        Me.RadioButtonEpFacult1.Location = New System.Drawing.Point(52, 36)
        Me.RadioButtonEpFacult1.Name = "RadioButtonEpFacult1"
        Me.RadioButtonEpFacult1.Size = New System.Drawing.Size(51, 21)
        Me.RadioButtonEpFacult1.TabIndex = 12
        Me.RadioButtonEpFacult1.TabStop = True
        Me.RadioButtonEpFacult1.Text = "Oui"
        Me.RadioButtonEpFacult1.UseVisualStyleBackColor = True
        '
        'RadioButtonEpFacult2
        '
        Me.RadioButtonEpFacult2.AutoSize = True
        Me.RadioButtonEpFacult2.Location = New System.Drawing.Point(52, 63)
        Me.RadioButtonEpFacult2.Name = "RadioButtonEpFacult2"
        Me.RadioButtonEpFacult2.Size = New System.Drawing.Size(55, 21)
        Me.RadioButtonEpFacult2.TabIndex = 13
        Me.RadioButtonEpFacult2.TabStop = True
        Me.RadioButtonEpFacult2.Text = "Non"
        Me.RadioButtonEpFacult2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Epreuves facultatifs ?"
        '
        'PanelEpFacultatif
        '
        Me.PanelEpFacultatif.Controls.Add(Me.ComboBoxMatFacult)
        Me.PanelEpFacultatif.Controls.Add(Me.Label3)
        Me.PanelEpFacultatif.Controls.Add(Me.RadioButtonEpFacult2)
        Me.PanelEpFacultatif.Controls.Add(Me.RadioButtonEpFacult1)
        Me.PanelEpFacultatif.Location = New System.Drawing.Point(41, 204)
        Me.PanelEpFacultatif.Name = "PanelEpFacultatif"
        Me.PanelEpFacultatif.Size = New System.Drawing.Size(284, 150)
        Me.PanelEpFacultatif.TabIndex = 15
        '
        'ComboBoxMatFacult
        '
        Me.ComboBoxMatFacult.FormattingEnabled = True
        Me.ComboBoxMatFacult.Location = New System.Drawing.Point(109, 36)
        Me.ComboBoxMatFacult.Name = "ComboBoxMatFacult"
        Me.ComboBoxMatFacult.Size = New System.Drawing.Size(138, 24)
        Me.ComboBoxMatFacult.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(67, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Région:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-64, -72)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1151, 615)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(865, 162)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(117, 119)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'FormChoixEpreuve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 538)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PanelEpFacultatif)
        Me.Controls.Add(Me.ButtonValidEnrgIns)
        Me.Controls.Add(Me.ButtonAbondon)
        Me.Controls.Add(Me.labelChoixRestOral)
        Me.Controls.Add(Me.labelChoixRestEcrit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelMatEpO)
        Me.Controls.Add(Me.LabelMatEpE)
        Me.Controls.Add(Me.panelEpOral)
        Me.Controls.Add(Me.paneEplEcrit)
        Me.Controls.Add(Me.ComboBoxRégion)
        Me.Controls.Add(Me.labelPrenomC)
        Me.Controls.Add(Me.LabelNomC)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormChoixEpreuve"
        Me.Text = "FormChoixEpreuve"
        Me.paneEplEcrit.ResumeLayout(False)
        Me.paneEplEcrit.PerformLayout()
        Me.panelEpOral.ResumeLayout(False)
        Me.panelEpOral.PerformLayout()
        Me.PanelEpFacultatif.ResumeLayout(False)
        Me.PanelEpFacultatif.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelNomC As Label
    Friend WithEvents labelPrenomC As Label
    Friend WithEvents ComboBoxRégion As ComboBox
    Friend WithEvents paneEplEcrit As Panel
    Friend WithEvents CheckBoxLangageC As CheckBox
    Friend WithEvents CheckBoxBasededonnees As CheckBox
    Friend WithEvents CheckBoxSystème As CheckBox
    Friend WithEvents CheckBoxVisualBasicNET As CheckBox
    Friend WithEvents CheckBoxMathématiques As CheckBox
    Friend WithEvents CheckBoxExpression As CheckBox
    Friend WithEvents CheckBoxLangageJava As CheckBox
    Friend WithEvents CheckBoxDroit As CheckBox
    Friend WithEvents CheckBoxRéseau As CheckBox
    Friend WithEvents CheckBoxGestion As CheckBox
    Friend WithEvents CheckBoxAlgorithmique As CheckBox
    Friend WithEvents panelEpOral As Panel
    Friend WithEvents CheckBoxMathématiquesO As CheckBox
    Friend WithEvents CheckBoxExpressionO As CheckBox
    Friend WithEvents CheckBoxSystèmeO As CheckBox
    Friend WithEvents CheckBoxDroitO As CheckBox
    Friend WithEvents CheckBoxRéseauO As CheckBox
    Friend WithEvents CheckBoxGestionO As CheckBox
    Friend WithEvents CheckBoxEspagnol As CheckBox
    Friend WithEvents CheckBoxChinois As CheckBox
    Friend WithEvents CheckBoxAnglais As CheckBox
    Friend WithEvents LabelMatEpE As Label
    Friend WithEvents LabelMatEpO As Label
    Friend WithEvents CheckBoxProgrammationweb As CheckBox
    Friend WithEvents TimerClose2 As Timer
    Friend WithEvents monTimer2 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents labelChoixRestEcrit As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents labelChoixRestOral As Label
    Friend WithEvents ButtonAbondon As Button
    Friend WithEvents ButtonValidEnrgIns As Button
    Friend WithEvents RadioButtonEpFacult1 As RadioButton
    Friend WithEvents RadioButtonEpFacult2 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelEpFacultatif As Panel
    Friend WithEvents ComboBoxMatFacult As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
