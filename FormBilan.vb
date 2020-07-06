Public Class FormBilan
    Private Sub FormBilan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelNbIns.Text = ModuleMain.getLengthInscription()

        For Each NomME As String In ModuleMain.getListeEpreuveE()
            ComboBoxM.Items.Add(NomME)
        Next
        For Each NomMO As String In ModuleMain.getListeEOrale()
            ComboBoxM.Items.Add(NomMO)
        Next

        For Each C As Candidat In ModuleMain.GetCandidat
            ComboBoxNPC.Items.Add(CStr(C.nom) + " " + CStr(C.prénom))
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ModuleMain.getMenu().Show()
        Me.Close()
    End Sub

    Private Sub ButtonBI_Click(sender As Object, e As EventArgs) Handles ButtonBI.Click

        Dim f As New FormBilanIndC
        f.Labelfacult.Visible = False
        f.Label17.Visible = False

        Dim s As New System.Text.StringBuilder
        For Each c As Candidat In ModuleMain.GetCandidat
            s.Append(CStr(c.nom) + " " + CStr(c.prénom))
            If ComboBoxNPC.Text = s.ToString Then
                f.LabelNom.Text = c.nom
                f.LabelPre.Text = c.prénom
                f.LabelAge.Text = c.age
                f.LabelReg.Text = c.région
                f.LabelVille.Text = c.ville
                f.LabelCP.Text = c.CP
                f.LabelAdresse.Text = c.adresse
                f.Label7.Text = c.ListeME(0)
                f.Label8.Text = c.ListeME(1)
                f.Label9.Text = c.ListeME(2)
                f.Label10.Text = c.ListeME(3)

                f.Label11.Text = c.ListeMO(0)
                f.Label12.Text = c.ListeMO(1)
                f.Label13.Text = c.ListeMO(2)

                If c.matièreFacult <> "" Then
                    f.Labelfacult.Visible = True
                    f.Label17.Visible = True
                    f.Labelfacult.Text = c.matièreFacult

                End If

                f.Show()
            End If
            s.Clear()
        Next



    End Sub

    Private Sub ButtonBM_Click(sender As Object, e As EventArgs) Handles ButtonBM.Click
        If ComboBoxM.Text <> "" Then
            Dim bMatière As New FormBilanMatière

            For Each c As Candidat In ModuleMain.GetCandidat()
                For Each mEcrite As String In c.ListeME
                    If mEcrite = ComboBoxM.Text Then
                        bMatière.ListBoxCandidatParM.Items.Add(c.région + " " + c.nom + " " + c.prénom)
                    End If
                Next
                For Each mEcrite As String In c.ListeMO
                    If mEcrite = ComboBoxM.Text Then
                        bMatière.ListBoxCandidatParM.Items.Add(c.région + " " + c.nom + " " + c.prénom)
                    End If
                Next
                If c.matièreFacult = ComboBoxM.Text Then
                    bMatière.ListBoxCandidatParM.Items.Add(c.région + " " + c.nom + " " + c.prénom)
                End If

            Next

            bMatière.Show()
            Me.Hide()
        Else
            MsgBox("Voulez chosir un candidat présent dans la liste !")
        End If
    End Sub


End Class