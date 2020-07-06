Public Class FormRensCandidat
    Dim Title As String = "Formulaire Rensignement Candidiat"

    '------------ Timer ------------'

    Private Sub init(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        monTimer.Interval = 1000  ''toute les 1s''
        monTimer.Start()
        ScrollBarAge.Minimum = 18
        ScrollBarAge.Maximum = 64
        ScrollBarAge.Value = 18
        LabelAge.AutoSize = True
        LabelAge.Text = ScrollBarAge.Value
        Label7.Font = New Font("Comic Sans MS", 12, FontStyle.Italic Or FontStyle.Underline)
    End Sub
    Private Sub afficheHeure(sender As System.Object, e As System.EventArgs) Handles monTimer.Tick
        Me.Text = Title & " " & TimeString
    End Sub

    Private Sub TimerClose_Tick(sender As Object, e As EventArgs) Handles TimerClose.Tick
        MsgBox("Le temps d'inscription s'est écoulé")
        FormAccueil.Show()
        Me.Close()
    End Sub

    '------------*** Données ***------------ '

    '----Que des lettre ou des nombres----'

    Private Sub TextNom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNomC.KeyPress, TextBoxPrenomC.KeyPress, TextBoxVilleC.KeyPress

        If Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(Keys.Back) Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCpC.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(Keys.Back) Then
            e.Handled = False
        End If
    End Sub

    '----1ère lettre en maj----'

    Private Sub TextNom_LostFocus(sender As Object, e As EventArgs) Handles TextBoxNomC.LostFocus, TextBoxAdresseC.LostFocus, TextBoxPrenomC.LostFocus, TextBoxVilleC.LostFocus
        TextBoxNomC.Text = StrConv(TextBoxNomC.Text, vbProperCase)
        TextBoxPrenomC.Text = StrConv(TextBoxPrenomC.Text, vbProperCase)
        TextBoxAdresseC.Text = StrConv(TextBoxAdresseC.Text, vbProperCase)
        TextBoxVilleC.Text = StrConv(TextBoxVilleC.Text, vbProperCase)
    End Sub

    Private Sub ScrollBarAge_Scroll(sender As Object, e As ScrollEventArgs) Handles ScrollBarAge.Scroll
        LabelAge.Text = ScrollBarAge.Value

    End Sub


    Private Sub ButtonPassageCM_Click(sender As Object, e As EventArgs) Handles ButtonPassageCM.Click
        Dim valid As Boolean = True
        Dim nom, pre, cp, vile, adress, age As String
        Label1.ForeColor = Color.Black
        Label2.ForeColor = Color.Black
        Label3.ForeColor = Color.Black
        Label4.ForeColor = Color.Black
        Label5.ForeColor = Color.Black

        If TextBoxNomC.TextLength = 0 Then
            Label1.ForeColor = Color.Red
            valid = False
        Else
            nom = TextBoxNomC.Text
        End If

        If TextBoxPrenomC.TextLength = 0 Then
            Label2.ForeColor = Color.Red
            valid = False
        Else
            pre = TextBoxPrenomC.Text
        End If

        If TextBoxAdresseC.TextLength = 0 Then
            Label3.ForeColor = Color.Red
            valid = False
        Else
            adress = TextBoxAdresseC.Text
        End If

        If TextBoxCpC.TextLength = 0 And TextBoxCpC.Text.Substring(0, 2) = "00" Then
            Label4.ForeColor = Color.Red
            valid = False
        Else
            cp = TextBoxCpC.Text
        End If

        If TextBoxVilleC.TextLength = 0 Then
            Label5.ForeColor = Color.Red
            valid = False
        Else
            vile = TextBoxVilleC.Text
        End If

        If valid Then

            Me.Hide()
            monTimer.Stop()  'Arrete le Timer'
            TimerClose.Stop()
            ModuleMain.getChoix().labelPrenomC.Text = TextBoxPrenomC.Text
            ModuleMain.getChoix().LabelNomC.Text = TextBoxNomC.Text
            ModuleMain.getChoix().Show()

        End If
    End Sub

    Private Sub ButtonQuit_Click(sender As Object, e As EventArgs) Handles ButtonQuit.Click
        If MsgBox("Voulez-vous confirmer l'arrêt de l'inscription ?", vbYesNo, "Arrêt") = 6 Then
            FormAccueil.Show()
            Me.Close()
        End If
    End Sub
End Class
