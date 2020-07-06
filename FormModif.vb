Public Class FormModif
    Dim ListC As New List(Of Candidat)
    Private Sub FormModif_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listCandModif As List(Of Candidat) = New List(Of Candidat)
        For Each C As Candidat In ModuleMain.GetCandidat
            ComboBoxCandidatsInscrit.Items.Add(CStr(C.nom) + " " + CStr(C.prénom) + " " + CStr(C.numCand))
        Next

        For Each C As Candidat In ModuleMain.GetCandidat
            ListC.Add(C)
        Next

    End Sub

    Private Sub ButtonModifInfCand_Click(sender As Object, e As EventArgs) Handles ButtonModifInfCand.Click
        Dim i As Integer = 0
        Dim midif As Boolean = False
        Dim cNew As Candidat
        Dim indice As Integer = 0

        If TextBoxModifC.Text <> "" Then
            For Each C As Candidat In ModuleMain.GetCandidat
                If TextBoxModifC.Text = C.numCand Then
                    midif = True
                    cNew = C
                    indice = i
                End If
                i += 1
            Next
            If midif Then
                cNew.modifié = True
                ModuleMain.modifCandidat(indice, cNew)
                ModuleMain.CréerForm2(cNew.FormRenC)
                ModuleMain.getRen.Show()
                ModuleMain.CréerForm(cNew.FormChoixC)
            End If
        End If

        If ComboBoxCandidatsInscrit.Text <> "" Then
            Dim s As New System.Text.StringBuilder
            For Each cs As Candidat In ListC
                s.Append(CStr(cs.nom) + " " + CStr(cs.prénom) + " " + CStr(cs.numCand))
                If s.ToString = ComboBoxCandidatsInscrit.Text Then
                    midif = True
                    cNew = cs
                    indice = i
                End If
                i += 1
            Next
            If midif Then
                cNew.modifié = True
                ModuleMain.modifCandidat(indice, cNew)
                ModuleMain.CréerForm2(cNew.FormRenC)
                ModuleMain.getRen.Show()
                ModuleMain.CréerForm(cNew.FormChoixC)
            End If
        End If

        For Each C As Candidat In ModuleMain.GetCandidat
            ComboBoxCandidatsInscrit.Items.Add(CStr(C.nom) + " " + CStr(C.prénom) + " " + CStr(C.numCand))
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormAccueil.Show()
        Me.Close()
    End Sub
End Class