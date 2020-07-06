Public Class EtatInscription
    Private Sub ButtonBackMenu_Click(sender As Object, e As EventArgs) Handles ButtonBackMenu.Click
        ModuleMain.getMenu.Show()
        Me.Close()
    End Sub

    Private Sub EtatInscription_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim s1 As New System.Text.StringBuilder
        Dim s2 As New System.Text.StringBuilder

        For Each C As Candidat In ModuleMain.GetCandidat

            ListBoxNumC.Items.Add(C.numCand)
            ListBoxNomC.Items.Add(C.nom)
            ListBoxPrenomC.Items.Add(C.prénom)

            For Each se As String In C.ListeME
                s1.Append(UCase(se.Substring(0, 3)) + ",")
            Next
            For Each so As String In C.ListeMO
                s2.Append(UCase(so.Substring(0, 3)) + ",")
            Next

            ListBoxMEC.Items.Add(s1)
            ListBoxMOC.Items.Add(s2)
            ListBoxMFC.Items.Add(C.matièreFacult)

            s1.Clear()
            s2.Clear()
        Next

    End Sub

    Private Sub ListBoxNumC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxNumC.SelectedIndexChanged
        If ListBoxNumC.SelectedIndex > -1 Then
            ListBoxNomC.SelectedIndex = ListBoxNumC.SelectedIndex
            ListBoxPrenomC.SelectedIndex = ListBoxNumC.SelectedIndex
            ListBoxMEC.SelectedIndex = ListBoxNumC.SelectedIndex
            ListBoxMOC.SelectedIndex = ListBoxNumC.SelectedIndex
            ListBoxMFC.SelectedIndex = ListBoxNumC.SelectedIndex
        End If
    End Sub

    Private Sub ListBoxNomC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxNomC.SelectedIndexChanged
        If ListBoxNomC.SelectedIndex > -1 Then
            ListBoxNumC.SelectedIndex = ListBoxNomC.SelectedIndex
            ListBoxPrenomC.SelectedIndex = ListBoxNomC.SelectedIndex
            ListBoxMEC.SelectedIndex = ListBoxNomC.SelectedIndex
            ListBoxMOC.SelectedIndex = ListBoxNomC.SelectedIndex
            ListBoxMFC.SelectedIndex = ListBoxNomC.SelectedIndex
        End If
    End Sub

    Private Sub ListBoxPrenomC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxPrenomC.SelectedIndexChanged
        If ListBoxPrenomC.SelectedIndex > -1 Then
            ListBoxNumC.SelectedIndex = ListBoxPrenomC.SelectedIndex
            ListBoxNomC.SelectedIndex = ListBoxPrenomC.SelectedIndex
            ListBoxMEC.SelectedIndex = ListBoxPrenomC.SelectedIndex
            ListBoxMOC.SelectedIndex = ListBoxPrenomC.SelectedIndex
            ListBoxMFC.SelectedIndex = ListBoxPrenomC.SelectedIndex
        End If
    End Sub

    Private Sub ListBoxMEC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxMEC.SelectedIndexChanged
        If ListBoxMEC.SelectedIndex > -1 Then
            ListBoxNumC.SelectedIndex = ListBoxMEC.SelectedIndex
            ListBoxNomC.SelectedIndex = ListBoxMEC.SelectedIndex
            ListBoxPrenomC.SelectedIndex = ListBoxMEC.SelectedIndex
            ListBoxMOC.SelectedIndex = ListBoxMEC.SelectedIndex
            ListBoxMFC.SelectedIndex = ListBoxMEC.SelectedIndex
        End If
    End Sub

    Private Sub ListBoxMOC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxMOC.SelectedIndexChanged
        If ListBoxMOC.SelectedIndex > -1 Then
            ListBoxNumC.SelectedIndex = ListBoxMOC.SelectedIndex
            ListBoxNomC.SelectedIndex = ListBoxMOC.SelectedIndex
            ListBoxPrenomC.SelectedIndex = ListBoxMOC.SelectedIndex
            ListBoxMEC.SelectedIndex = ListBoxMOC.SelectedIndex
            ListBoxMFC.SelectedIndex = ListBoxMOC.SelectedIndex
        End If
    End Sub

    Private Sub ListBoxMFC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxMFC.SelectedIndexChanged
        If ListBoxMFC.SelectedIndex > -1 Then
            ListBoxNumC.SelectedIndex = ListBoxMFC.SelectedIndex
            ListBoxNomC.SelectedIndex = ListBoxMFC.SelectedIndex
            ListBoxPrenomC.SelectedIndex = ListBoxMFC.SelectedIndex
            ListBoxMEC.SelectedIndex = ListBoxMFC.SelectedIndex
            ListBoxMOC.SelectedIndex = ListBoxMFC.SelectedIndex
        End If
    End Sub
End Class