Imports System.IO

Module ModuleMain
    '**************Etat inscription**************
    Dim inscriptionClos As Boolean = False

    Function setEtat()
        inscriptionClos = True
    End Function

    Function getEtat() As String
        If inscriptionClos Then
            Return "oui"
        End If
        Return "non"
    End Function

    '********** Donné sur candidat ***********
    Dim ListingListe As List(Of Candidat)(,)

    Function ListingAdd(i As Integer, j As Integer, c As Candidat)
        Dim cNew As Candidat = c
        ListingListe(i, j).Add(cNew)
    End Function

    Dim listEpreuveEcritOrale As List(Of String) = New List(Of String) From {
        "Gestion", "Droit", "Expression", "Mathématiques", "Réseau", "Système"
    }

    Public Sub createListingFile()
        Dim choixOrale As Boolean = False
        For i As Integer = 0 To 14
            For j As Integer = 0 To 9

                If i <= 11 Then
                    If ListingListe(i, j) IsNot Nothing Then
                        Dim sb As New System.Text.StringBuilder()
                        Dim stringOrderAlpha As New System.Text.StringBuilder()

                        sb.Append(listEpreuveEcrit.Item(i) + " " + listeRégion.Item(j) + ".txt")
                        Dim fich As StreamWriter
                        fich = File.CreateText(Application.StartupPath + "Listing\" + sb.ToString)
                        For Each c As Candidat In ListingListe(i, j)
                            For Each sOE As String In c.ListeMO
                                If sOE = listEpreuveEcrit.Item(i) Then
                                    fich.WriteLine(c.nom + " " + c.prénom + " " + CStr(c.numCand) + "|" + "O")
                                    choixOrale = True
                                End If
                            Next

                            If c.matièreFacult = listEpreuveEcrit.Item(i) Then
                                fich.WriteLine(c.nom + " " + c.prénom + " " + CStr(c.numCand) + "|" + "O")
                                choixOrale = True
                            End If

                            'i -j - -> Matière et Règion
                            If choixOrale = False Then
                                fich.WriteLine(c.nom + " " + c.prénom + " " + CStr(c.numCand))
                            End If

                            choixOrale = False
                        Next

                        fich.Close()

                        'Si fichier est vide 

                        If File.ReadAllText(Application.StartupPath + "Listing\" + sb.ToString).Length = 0 Then
                            File.Delete(Application.StartupPath + "Listing\" + sb.ToString)
                        End If

                    End If
                ElseIf i < 14 Then

                    If ListingListe(i, j) IsNot Nothing Then
                        Dim sb As New System.Text.StringBuilder()
                        sb.Append(listeEpreuveOrale.Item(i - 11) + " " + listeRégion.Item(j) + ".txt")
                        Dim fich As StreamWriter
                        fich = File.CreateText(Application.StartupPath + "Listing\" + sb.ToString)
                        For Each c As Candidat In ListingListe(i, j)
                            'i - j --> Matière et Règion
                            fich.WriteLine(c.nom + " " + c.prénom + " " + CStr(c.numCand))
                        Next
                        fich.Close()

                        'Si fichier est vide 

                        If File.ReadAllText(Application.StartupPath + "Listing\" + sb.ToString).Length = 0 Then
                            File.Delete(Application.StartupPath + "Listing\" + sb.ToString)
                        End If
                    End If
                End If

            Next

        Next
        MsgBox("Les inscriptions ont été clos! Le lsiting a été généré !")
        'Application.Exit()
    End Sub

    Function KeepTotal()
        ' Incrémenter numCand 
        Static Accumulate
        Accumulate = Accumulate + 1
        KeepTotal = Accumulate
    End Function

    Public Structure Candidat
        Public nom, prénom, adresse, ville, age, région, matièreFacult As String
        Public modifié As Boolean
        Public CP, numCand As Integer
        Public ListeME As List(Of String)
        Public ListeMO As List(Of String)
        Public FormRenC As FormRensCandidat
        Public FormChoixC As FormChoixEpreuve
    End Structure

    Dim listCandidat As List(Of Candidat) = New List(Of Candidat)

    Dim listEpreuveEcrit As List(Of String) = New List(Of String) From {
        "Algorithmique", "Base de données", "Droit", "Expression",
        "Gestion", "Langage C", "Langage Java", "Mathématiques",
        "Programmation web", "Réseau", "Système", "Visual Basic .NET"}

    Dim listEpreuve As List(Of String) = New List(Of String) From {
        "Algorithmique", "Base de données", "Droit", "Expression",
        "Gestion", "Langage C", "Langage Java", "Mathématiques",
        "Programmation web", "Réseau", "Système", "Visual Basic .NET",
        "Anglais", "Chinois", "Espagnol"}

    Function getAllEpreuve() As List(Of String)
        Return listEpreuve
    End Function

    Dim listeRégion As List(Of String) = New List(Of String) From {
       "Auvergne", "Nord",
        "Bordelais",
        "Normandie",
        "Bourgogne",
        "Paris",
        "Bretagne",
        "Poitou",
        "Corse",
        "Roussillon"
    }

    Function getListeRegion() As List(Of String)
        Return listeRégion
    End Function

    Function getListeEpreuveE() As List(Of String)
        Return listEpreuveEcrit
    End Function

    Dim listeEpreuveOrale As List(Of String) = New List(Of String) From {"Anglais", "Chinois", "Espagnol"}

    Function getListeEOrale() As List(Of String)
        Return listeEpreuveOrale
    End Function


    Enum region
        Auvergne
        Bordelais
        Bourgogne
        Bretagne
        Corse
        Nord
        Normandie
        Paris
        Poitou
        Roussillon
    End Enum

    '******** Opéreation sur Candidat *********

    Public Function nouveauCandidat() As Candidat
        Dim c As Candidat
        c.modifié = False
        c.ListeME = New List(Of String)
        c.ListeMO = New List(Of String)
        Return c
    End Function

    Dim cmpt As Integer = 0
    Function GetCandidat() As List(Of Candidat)
        Return listCandidat
    End Function

    Function getLengthInscription() As Integer
        Return listCandidat.Count
    End Function
    Sub InscrireCandidat(c As Candidat)
        listCandidat.Add(c)
    End Sub


    Sub SupprimerCandidat(c As Candidat)
        listCandidat.Remove(c)
    End Sub


    Function modifCandidat(i As Integer, c As Candidat)
        listCandidat(i) = c
    End Function
    '-------- Créer nouveau form -------
    Dim formBilan As New FormBilan
    Dim menus As New FormAccueil
    Dim FormRens As Form
    Dim FormChoix As Form

    Function getMenu() As FormAccueil
        Return menus
    End Function

    Function getBilan() As FormBilan
        Return formBilan
    End Function
    Function NewRen()
        FormRens = New FormRensCandidat
    End Function

    Function NewChoix()
        FormChoix = New FormChoixEpreuve
    End Function

    Function getRen() As FormRensCandidat
        Return FormRens
    End Function

    Function getChoix() As FormChoixEpreuve
        Return FormChoix
    End Function

    Function CréerForm(f As FormChoixEpreuve)
        FormChoix = f
    End Function

    Function CréerForm2(fr As FormRensCandidat)
        FormRens = fr
    End Function
    '------------------------------------

    '----------- Test affichage ---------
    Public Function displayMatierE(ByRef f As Candidat) As String
        Dim sb As New System.Text.StringBuilder()
        For Each e In f.ListeME
            sb.Append(e & ", ")
        Next
        Return sb.ToString
    End Function
    '------------------------------------

    '***** Inscription clos *****

    '******* MAIN ********
    Sub Main()
        ListingListe = New List(Of Candidat)(15, 10) {}
        For i As Integer = 0 To 15
            For j As Integer = 0 To 10
                ListingListe(i, j) = New List(Of Candidat)
            Next
        Next
        ModuleFile.read()
        ModuleFile.getEtatInscription()
        If inscriptionClos Then
            menus.LabelEtat.Text = "Fermé"
            menus.LabelEtat.BackColor = Color.Red
            menus.ButtonEnregistrerIns.Enabled = False
            menus.ButtonEnregistrerIns.BackColor = Color.Gray
            menus.PictureBox3.BackColor = Color.Gray
        Else
            menus.LabelEtat.BackColor = Color.Green
        End If
        Application.Run(menus)
    End Sub
End Module
