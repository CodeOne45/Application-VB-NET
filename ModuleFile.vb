Imports System.IO
Imports System.IO.FileStream
Module ModuleFile


    Public Sub read()
        Dim s As String
        Try
            Dim path As String = Application.StartupPath + "DataCandidat\dataCandidat.txt"

            Dim file As New StreamReader(Path)

            Do While file.Peek() >= 0
                Dim f = nouveauCandidat()
                Dim listString As List(Of String) = New List(Of String)
                s = file.ReadLine()

                Dim words As String() = s.Split(New Char() {"_"c})

                Dim word As String
                For Each word In words
                    listString.Add(word)
                Next

                f.modifié = False
                f.numCand = CInt(listString(0))
                f.nom = listString(1)
                f.prénom = listString(2)
                f.région = listString(3)
                f.ville = listString(4)
                f.CP = CInt(listString(5))
                f.adresse = listString(6)
                f.age = CInt(listString(7))
                f.ListeME.Add(listString(8))
                f.ListeME.Add(listString(9))
                f.ListeME.Add(listString(10))
                f.ListeME.Add(listString(11))
                f.ListeMO.Add(listString(12))
                f.ListeMO.Add(listString(13))
                f.ListeMO.Add(listString(14))
                f.matièreFacult = listString(15)

                InscrireCandidat(f)
                ModuleMain.KeepTotal()

                listString.Clear()
            Loop

            file.Close()
            Dim pathbis As String = Application.StartupPath + "DataCandidat\EtatInscriptionFile.txt"

            Dim filebis As New StreamReader(pathbis)
            Dim s2 As String
            Do While filebis.Peek >= 0
                s2 = filebis.ReadLine
                If s2.Trim() = "oui" Then
                    ModuleMain.setEtat()
                End If
            Loop

            filebis.Close()

        Catch ex As Exception
            MsgBox("Pour l'instant il n'y a aucun participant qui participe à ce concours!")
        End Try
    End Sub

    Sub saveCandidatToFile()
        Dim inputFile As StreamWriter
        If ModuleMain.getLengthInscription = 0 Then
            MsgBox("L'inscription est vide étant donné qu'aucun candidat n'a été enregistré")
        Else
            inputFile = File.CreateText(Application.StartupPath + "DataCandidat\dataCandidat.txt")

            For Each c As Candidat In ModuleMain.GetCandidat
                inputFile.WriteLine(CStr(c.numCand) + "_" + c.nom + "_" + c.prénom + "_" + c.région + "_" + c.ville + "_" + CStr(c.CP) +
                                   "_" + c.adresse + "_" + CStr(c.age) + "_" + c.ListeME(0) + "_" + c.ListeME(1) +
                                     "_" + c.ListeME(2) + "_" + c.ListeME(3) + "_" + c.ListeMO(0) + "_" + c.ListeMO(1) + "_" + c.ListeMO(2) + "_" + c.matièreFacult)
            Next
            inputFile.Close()
        End If
    End Sub

    Sub getEtatInscription()
        Dim fileb As StreamWriter
        fileb = File.CreateText(Application.StartupPath + "DataCandidat\EtatInscriptionFile.txt")
        fileb.WriteLine(ModuleMain.getEtat())
        fileb.Close()
    End Sub

    Public Sub listing()
        'Dim path As String = "C:\Users\malik\OneDrive\Bureau\Info DUT\Periode D\IHM\Projet\Nouveau_Archive_WinRAR_ZIP\Projet IHM v 24-05\Listing"
        'If Not Directory.Exists(path) Then
        'Directory.CreateDirectory(path)
        'End If


        For Each C As Candidat In GetCandidat()
            For Each m As String In C.ListeME
                For Each re As String In ModuleMain.getListeEpreuveE
                    If m = re Then
                        For Each reg As String In ModuleMain.getListeRegion
                            If reg = C.région Then
                                ModuleMain.ListingAdd(ModuleMain.getListeEpreuveE.IndexOf(m), ModuleMain.getListeRegion.IndexOf(reg), C)
                            End If
                        Next
                    End If
                Next
            Next

            For Each mp As String In C.ListeMO
                For Each ro As String In ModuleMain.getListeEOrale
                    If mp = ro Then
                        For Each regbis As String In ModuleMain.getListeRegion
                            If regbis = C.région Then
                                ModuleMain.ListingAdd(11 + ModuleMain.getListeEOrale.IndexOf(ro), ModuleMain.getListeRegion.IndexOf(regbis), C)
                            End If
                        Next
                    End If
                Next
                For Each re As String In ModuleMain.getListeEpreuveE

                    If mp = re Then
                        For Each reg As String In ModuleMain.getListeRegion
                            If reg = C.région Then
                                ModuleMain.ListingAdd(ModuleMain.getListeEpreuveE.IndexOf(re), ModuleMain.getListeRegion.IndexOf(reg), C)
                            End If
                        Next
                    End If
                Next
            Next

            If C.matièreFacult <> "" Then
                For Each ef As String In ModuleMain.getAllEpreuve
                    If ef = C.matièreFacult Then
                        ModuleMain.ListingAdd(ModuleMain.getAllEpreuve.IndexOf(ef), ModuleMain.getListeRegion.IndexOf(C.région), C)
                    End If
                Next

            End If
        Next

        ModuleMain.createListingFile()

    End Sub




End Module
