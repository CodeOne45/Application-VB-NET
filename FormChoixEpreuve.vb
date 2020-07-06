
Public Class FormChoixEpreuve
    Dim Title As String = "Formulaire choix épreuves"
    Dim choixMaxEcrit As Integer = 4
    Dim choixMaxOral As Integer = 3
    Dim valide As Boolean = True
    '************* Load form ******************'

    '---------- Timer ---------------'

    Private Sub init(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Timer'

        monTimer2.Interval = 1000  ''toute les 1s''

        monTimer2.Start()

        labelChoixRestEcrit.Text = choixMaxEcrit
        labelChoixRestOral.Text = choixMaxOral

        'Ajouter les régions dans comboBox'

        For Each i In [Enum].GetValues(GetType(region))
            ComboBoxRégion.Items.Add(i)
        Next

        'Epreuves facultataifs '

        PanelEpFacultatif.Hide()
        RadioButtonEpFacult1.Checked = False
        RadioButtonEpFacult2.Checked = False

    End Sub

    Private Sub afficheHeure(sender As System.Object, e As System.EventArgs) Handles monTimer2.Tick
        Me.Text = Title & " " & TimeString
    End Sub
    Private Sub TimerClose2_Tick(sender As Object, e As EventArgs) Handles TimerClose2.Tick
        MsgBox("Le temps d'inscription est écoulé")
        FormAccueil.Show()
        Me.Close()
    End Sub

    '-----------------  Choix épreuves  ----------------'

    Dim nbOptionsMatE As Integer = 0
    Dim nbOptionsMatO As Integer = 0
    Private Sub CheckBoxEChanged(sender As Object, e As EventArgs) _
        Handles CheckBoxAlgorithmique.CheckedChanged,
    CheckBoxBasededonnees.CheckedChanged,
    CheckBoxDroit.CheckedChanged, CheckBoxExpression.CheckedChanged,
    CheckBoxGestion.CheckedChanged, CheckBoxLangageC.CheckedChanged, CheckBoxLangageJava.CheckedChanged,
    CheckBoxMathématiques.CheckedChanged, CheckBoxProgrammationweb.CheckedChanged,
    CheckBoxRéseau.CheckedChanged, CheckBoxSystème.CheckedChanged, CheckBoxVisualBasicNET.CheckedChanged

        If sender.Checked Then
            For Each b As CheckBox In panelEpOral.Controls
                If sender.Text = b.Text Then
                    b.Enabled = False
                End If
            Next
            nbOptionsMatE += 1
            labelChoixRestEcrit.Text = choixMaxEcrit - nbOptionsMatE
            If nbOptionsMatE > choixMaxEcrit Then
                MsgBox("Impossible de selectionner plus de 4 Matières à l'écrit")
                sender.Checked = False
                nbOptionsMatE -= 1
            End If

        Else
            labelChoixRestEcrit.Text += 1
            nbOptionsMatE -= 1
            For Each b As CheckBox In panelEpOral.Controls
                If sender.Text = b.Text Then
                    b.Enabled = True
                End If
            Next
        End If

        If labelChoixRestEcrit.Text = 0 And labelChoixRestOral.Text = 0 Then
            ComboBoxMatFacult.Hide()
            PanelEpFacultatif.Show()
            For Each x As CheckBox In paneEplEcrit.Controls
                If x.Checked = False Then
                    ComboBoxMatFacult.Items.Add(x.Text)
                End If
            Next
            For Each y As CheckBox In panelEpOral.Controls
                If y.Checked = False Then
                    ComboBoxMatFacult.Items.Add(y.Text)
                End If
            Next

        ElseIf RadioButtonEpFacult2.Checked = False Then
            PanelEpFacultatif.Hide()
        End If
    End Sub

    Private Sub CheckBoxOChanged(sender As Object, e As EventArgs) _
        Handles CheckBoxAnglais.CheckedChanged, CheckBoxChinois.CheckedChanged, CheckBoxEspagnol.CheckedChanged, CheckBoxGestionO.CheckedChanged,
        CheckBoxRéseauO.CheckedChanged, CheckBoxDroitO.CheckedChanged, CheckBoxSystèmeO.CheckedChanged,
        CheckBoxExpressionO.CheckedChanged, CheckBoxMathématiquesO.CheckedChanged
        If sender.Checked Then
            For Each b As CheckBox In paneEplEcrit.Controls
                If sender.Text = b.Text Then
                    b.Enabled = False
                End If
            Next

            nbOptionsMatO += 1
            labelChoixRestOral.Text = choixMaxOral - nbOptionsMatO
            If nbOptionsMatO > choixMaxOral Then
                MsgBox("Impossible de selectionner plus de 3 Matières à l'oral")
                sender.Checked = False
                nbOptionsMatO -= 1
            End If

        Else
            labelChoixRestOral.Text += 1
            nbOptionsMatO -= 1
            For Each b As CheckBox In paneEplEcrit.Controls
                If sender.Text = b.Text Then
                    b.Enabled = True
                End If
            Next
        End If

        If labelChoixRestEcrit.Text = 0 And labelChoixRestOral.Text = 0 Then
            ComboBoxMatFacult.Hide()
            PanelEpFacultatif.Show()
            For Each x As CheckBox In paneEplEcrit.Controls
                If x.Checked = False Then
                    ComboBoxMatFacult.Items.Add(x.Text)
                End If
            Next
            For Each y As CheckBox In panelEpOral.Controls
                If y.Checked = False Then
                    ComboBoxMatFacult.Items.Add(y.Text)
                End If
            Next

        ElseIf RadioButtonEpFacult2.Checked = False Then
            PanelEpFacultatif.Hide()
        End If

    End Sub

    '------ * Buttons * -------'

    Private Sub ButtonAbondon_Click(sender As Object, e As EventArgs) Handles ButtonAbondon.Click
        FormAccueil.Show()
        Me.Close()
    End Sub

    Private Sub ButtonValidEnrgIns_Click(sender As Object, e As EventArgs) Handles ButtonValidEnrgIns.Click
        LabelMatEpE.ForeColor = Color.Black
        LabelMatEpO.ForeColor = Color.Black
        Label4.ForeColor = Color.Black
        Label3.ForeColor = Color.Black
        valide = True

        If labelChoixRestEcrit.Text <> 0 And labelChoixRestOral.Text <> 0 And ComboBoxRégion.Text = "" Then
            LabelMatEpE.ForeColor = Color.Red
            LabelMatEpO.ForeColor = Color.Red
            Label4.ForeColor = Color.Red
            valide = False
            MsgBox("Veuillez choisir 4 matières pour l'écrit, 3 pour l'oral ainsi qu'une région")

        ElseIf labelChoixRestEcrit.Text <> 0 Then
            valide = False
            MsgBox("Veuillez choisir 4 matières pour l'écrit")
            LabelMatEpE.ForeColor = Color.Red
        ElseIf labelChoixRestOral.Text <> 0 Then
            valide = False
            MsgBox("Veuillez choisir 3 matières pour l'oral")
            LabelMatEpO.ForeColor = Color.Red

        ElseIf ComboBoxRégion.Text = "" Then
            valide = False
            MsgBox("Veuillez choisir une région")
            Label4.ForeColor = Color.Red
        ElseIf RadioButtonEpFacult1.Checked = False And RadioButtonEpFacult2.Checked = False Then
            valide = False
            MsgBox("Veuillez choisir ou non une matière facultative")
            Label3.ForeColor = Color.Red
        ElseIf RadioButtonEpFacult1.Checked = True And ComboBoxMatFacult.Text = "" Then
            valide = False
            MsgBox("Veuillez choisir une matière facultative")
            ComboBoxMatFacult.ForeColor = Color.Red
        Else
            valide = True

        End If



        If valide Then

            ''ouvrir FormRécapInscription'

            Dim f As New FormRécapInscription
            Dim tmatE(4), tmatO(3) As String
            Dim cpt As Integer = 0


            If ModuleMain.getChoix().RadioButtonEpFacult1.Checked = True Then
                f.LabelMatFacult.Text = ModuleMain.getChoix().ComboBoxMatFacult.Text
            End If

            f.LabelMatF.Visible = False
            f.LabelMatFacult.Visible = False

            If ModuleMain.getChoix().RadioButtonEpFacult1.Checked = True Then
                f.LabelMatF.Visible = True
                f.LabelMatFacult.Visible = True
            End If

            For Each ec As CheckBox In ModuleMain.getChoix().paneEplEcrit.Controls
                If ec.Checked Then
                    tmatE(cpt) = ec.Text
                    cpt += 1
                End If
            Next
            cpt = 0
            For Each o As CheckBox In ModuleMain.getChoix().panelEpOral.Controls
                If o.Checked Then
                    tmatO(cpt) = o.Text
                    cpt += 1
                End If
            Next

            f.LabelME1.Text = tmatE(0)
            f.LabelME2.Text = tmatE(1)
            f.Label2ME3.Text = tmatE(2)
            f.LabelME4.Text = tmatE(3)

            f.LabelMO1.Text = tmatO(0)
            f.LabelMO2.Text = tmatO(1)
            f.LabelMO3.Text = tmatO(2)

            f.LabelNomC.Text = ModuleMain.getRen().TextBoxNomC.Text
            f.LabelPrénomC.Text = ModuleMain.getRen().TextBoxPrenomC.Text
            f.LabelAgeC.Text = ModuleMain.getRen().ScrollBarAge.Value
            f.LabelAdresseC.Text = ModuleMain.getRen().TextBoxAdresseC.Text
            f.LabelVilleC.Text = ModuleMain.getRen().TextBoxVilleC.Text
            f.LabelRégionC.Text = ModuleMain.getChoix().ComboBoxRégion.Text
            f.LabelCPC.Text = ModuleMain.getRen().TextBoxCpC.Text

            f.Show()

            Me.Hide()
            monTimer2.Stop() 'Arrete le Timer
            TimerClose2.Stop()
        End If
    End Sub

    Private Sub RadioButtonEpFacult1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonEpFacult1.CheckedChanged
        ComboBoxMatFacult.Show()
    End Sub

    Private Sub RadioButtonEpFacult2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonEpFacult2.CheckedChanged
        ComboBoxMatFacult.Hide()
    End Sub

End Class