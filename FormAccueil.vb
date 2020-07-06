Public Class FormAccueil
    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Title As String = "ACCEUIL"
        Me.Text = Title

    End Sub

    Private Sub ButtonEnregistrerIns_Click(sender As Object, e As EventArgs) Handles ButtonEnregistrerIns.Click
        Me.Hide()
        ModuleMain.NewRen()
        ModuleMain.NewChoix()
        ModuleMain.getRen().Show()
    End Sub

    Private Sub ButtonModifInscription_Click(sender As Object, e As EventArgs) Handles ButtonModifInscription.Click
        Me.Hide()
        FormModif.Show()
    End Sub

    Private Sub ButtonSuppInscription_Click(sender As Object, e As EventArgs) Handles ButtonSuppInscription.Click
        Me.Hide()
        FormSup.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FetatI As New EtatInscription
        Me.Hide()
        FetatI.Show()
    End Sub

    Private Sub ButtonBilan_Click(sender As Object, e As EventArgs) Handles ButtonBilan.Click
        FormBilan.Show()

        Me.Hide()
    End Sub

    Private Sub ButtonCloseApp_Click(sender As Object, e As EventArgs) Handles ButtonCloseApp.Click
        ModuleFile.saveCandidatToFile()
        ModuleFile.getEtatInscription()
        Application.Exit()
    End Sub

    Private Sub ButtonFinInscriptions_Click(sender As Object, e As EventArgs) Handles ButtonFinInscriptions.Click
        'ModuleFile.saveCandidatToFile()
        ModuleMain.setEtat()
        ModuleFile.listing()
        ButtonEnregistrerIns.Enabled = False
        LabelEtat.Text = "Fermé"
        LabelEtat.BackColor = Color.Red
    End Sub
End Class
