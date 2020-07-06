Public Class FormSup


    Private Sub FormSup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each C As Candidat In ModuleMain.GetCandidat
            ComboBoxCandidatsInscrit.Items.Add(CStr(C.nom) + " " + CStr(C.prénom) + " " + CStr(C.numCand))
        Next

    End Sub

    Private Sub ButtonVoirCand_Click(sender As Object, e As EventArgs) Handles ButtonVoirCand.Click
        Dim s As New System.Text.StringBuilder
        Dim supValide As Boolean = False
        Dim candidatSup As Candidat
        If TextBoxCandRchr.Text <> "" Then
            For Each C As Candidat In ModuleMain.GetCandidat
                If TextBoxCandRchr.Text = C.numCand Then
                    candidatSup = C
                    supValide = True
                End If
            Next
        End If

        If ComboBoxCandidatsInscrit.Text <> "" Then
            For Each cs As Candidat In ModuleMain.GetCandidat
                s.Append(CStr(cs.nom) + " " + CStr(cs.prénom) + " " + CStr(cs.numCand))
                If s.ToString = ComboBoxCandidatsInscrit.Text Then
                    candidatSup = cs
                    supValide = True
                End If
                s.Clear()
            Next

        End If

        If supValide Then
            Dim choix = MsgBox("Nom : " + CStr(candidatSup.nom) + " Prénom : " + candidatSup.prénom + " Région : " + candidatSup.prénom & vbCrLf + " " + candidatSup.adresse + " " +
                           candidatSup.ville + " " + CStr(candidatSup.CP) + " " + candidatSup.age & vbCrLf + candidatSup.ListeME(0) + " " + candidatSup.ListeME(1) + " " + candidatSup.ListeME(2) + " " + candidatSup.ListeME(3) + " " + candidatSup.ListeMO(0) + "  " + candidatSup.ListeMO(1) + "  " + candidatSup.ListeMO(2), MsgBoxStyle.YesNo, " Voulez vous Supprimer ce Candidat ??")
            If choix = vbYes Then
                SupprimerCandidat(candidatSup)
            End If
            supValide = False
        End If

        ComboBoxCandidatsInscrit.Items.Clear()
        For Each C As Candidat In ModuleMain.GetCandidat
            ComboBoxCandidatsInscrit.Items.Add(CStr(C.nom) + " " + CStr(C.prénom) + " " + CStr(C.numCand))
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormAccueil.Show()
        Me.Close()
    End Sub


End Class