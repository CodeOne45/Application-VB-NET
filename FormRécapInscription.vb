Public Class FormRécapInscription


    Private Sub ButtonEnrgInscr_Click(sender As Object, e As EventArgs) Handles ButtonEnrgInscr.Click
        Dim candidatExicte As Boolean = False
        Dim compteur As Integer = 0
        Dim indice As Integer = 0
        Dim num As Integer = 0

        Dim c = ModuleMain.nouveauCandidat()
        c.nom = LabelNomC.Text
        c.prénom = LabelPrénomC.Text
        c.ville = LabelVilleC.Text
        c.adresse = LabelAdresseC.Text
        c.age = LabelAgeC.Text
        c.région = LabelRégionC.Text
        c.CP = LabelCPC.Text
        c.numCand = ModuleMain.KeepTotal()
        c.matièreFacult = LabelMatFacult.Text


        c.ListeME.Add(LabelME1.Text)
        c.ListeME.Add(LabelME2.Text)
        c.ListeME.Add(Label2ME3.Text)
        c.ListeME.Add(LabelME4.Text)

        c.ListeMO.Add(LabelMO1.Text)
        c.ListeMO.Add(LabelMO2.Text)
        c.ListeMO.Add(LabelMO3.Text)

        c.FormRenC = ModuleMain.getRen
        c.FormChoixC = ModuleMain.getChoix


        For Each cm As Candidat In ModuleMain.GetCandidat

            If cm.modifié = True Then
                candidatExicte = True
                indice = compteur
                num = cm.numCand
            End If
            compteur += 1
        Next

        If candidatExicte = False Then

            ModuleMain.InscrireCandidat(c)

            MsgBox("Le numéro de candidat est: " + CStr(c.numCand))
        Else
            c.numCand = num
            ModuleMain.modifCandidat(indice, c)
            MsgBox("L'inscription a été modifié ! ")
        End If

        FormAccueil.Show()
        Me.Close()

    End Sub

    Private Sub ButtonAnnulInscr_Click(sender As Object, e As EventArgs) Handles ButtonAnnulInscr.Click
        Me.Close()
        FormAccueil.Show()
    End Sub

    Private Sub ButtonRetrnModif_Click(sender As Object, e As EventArgs) Handles ButtonRetrnModif.Click
        ModuleMain.getRen().Show()
        Me.Close()
    End Sub

End Class