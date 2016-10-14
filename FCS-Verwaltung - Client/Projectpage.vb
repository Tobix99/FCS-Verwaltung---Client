﻿Imports System.IO
Imports Microsoft.VisualBasic

Public Class Projectpage

    Public id_for_pr As String

    Public ip As String = Hauptscreen.Mainserverip
    Public Username As String = Hauptscreen.MainUsername
    Public password As String = Hauptscreen.MainHashedPassword

    Dim temppath As New DirectoryInfo(Path.GetTempPath & "\FCS\Client\")
    Dim tempfile As New FileInfo(temppath.FullName & "database.dafcs")

    Public dataotherfiles As String = ""
    Public datafiles As String = ""

    Dim ierror As Integer = 0
    Dim ierrorother As Integer = 0

    Private Sub Projectpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Database1.ReadXml(tempfile.FullName)

        fill_data()

        Hauptscreen.client.SendMessage(ip, Convert.ToInt32(My.Settings.Port), Username & ";" & password & ";dataother;" & Format(Convert.ToInt32(id_for_pr), "000"))

        check_for_data.Start()

        check_for_dataother.Start()

    End Sub

    Private Sub fill_data()

        For Each row As database.projectsRow In Database1.projects.Rows

            If row.ID = Convert.ToInt32(id_for_pr) Then

                LProject.Text = row.Name

                Exit For

            End If

        Next

    End Sub

    Private Sub check_for_data_Tick(sender As Object, e As EventArgs) Handles check_for_data.Tick


        If ierror >= 10 Then

            MessageBox.Show("Fehler beim Datenübertragen")
            check_for_data.Stop()
        End If

        If datafiles <> "" Then

            If datafiles = "empty" Then

                Dim lvItem1 As ListViewItem

                Me.Invoke(Sub() lvItem1 = LVDatafiles.Items.Add("Keine Daten vorhanden"))
                Me.Invoke(Sub() lvItem1.SubItems.AddRange(New String() {"Keine Daten vorhanden"}))

            Else

                Dim tempsplit As String() = datafiles.Split(CChar("°"))

                For Each item As String In tempsplit

                    Dim lvItem As ListViewItem

                    Me.Invoke(Sub() lvItem = LVDatafiles.Items.Add(item))

                    Dim tempsplit2 As String() = item.Split(CChar("."))

                    Me.Invoke(Sub() lvItem.SubItems.AddRange(New String() {tempsplit2(1)}))


                Next

            End If

            check_for_data.Stop()

        Else

            ierror += 1

        End If

    End Sub

    Private Sub check_for_dataother_Tick(sender As Object, e As EventArgs) Handles check_for_dataother.Tick

        If ierrorother >= 10 Then

            MessageBox.Show("Fehler beim Datenübertragen")
            check_for_dataother.Stop()

        End If




        If dataotherfiles <> "" Then

            MessageBox.Show(dataotherfiles)

            If dataotherfiles = "empty" Then

                Dim lvItem As ListViewItem

                Me.Invoke(Sub() lvItem = LVDataOther.Items.Add("Keine Daten vorhanden"))
                Me.Invoke(Sub() lvItem.SubItems.AddRange(New String() {"Keine Daten vorhanden"}))


            Else

                Dim tempsplit As String() = dataotherfiles.Split(CChar("°"))

                For Each item As String In tempsplit

                    Dim lvItem As ListViewItem

                    Me.Invoke(Sub() lvItem = LVDataOther.Items.Add(item))

                    Dim tempsplit2 As String() = item.Split(CChar("."))

                    Me.Invoke(Sub() lvItem.SubItems.AddRange(New String() {tempsplit2(1)}))

                Next

            End If

            check_for_dataother.Stop()

        Else

            ierrorother += 1


        End If

    End Sub
End Class