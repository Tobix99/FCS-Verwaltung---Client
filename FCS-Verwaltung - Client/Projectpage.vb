Imports System.IO
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

        KeyPreview = True

    End Sub

    Private Sub fill_data()

        For Each row As database.projectsRow In Database1.projects.Rows

            If row.ID = Convert.ToInt32(id_for_pr) Then

                LProject.Text = row.Name

                Exit For

            End If

        Next

        For Each camera As database.cameraRow In Database1.camera.Rows

            Dim gitem As New TreeNode

            gitem.Name = camera.Name

            gitem.Text = camera.Name

            TVData.Nodes.Add(gitem)

        Next

    End Sub

    Private Sub check_for_data_Tick(sender As Object, e As EventArgs) Handles check_for_data.Tick


        If ierror >= 10 Then

            check_for_data.Stop()
            MessageBox.Show("Fehler beim Datenübertragen")

        End If

        If datafiles <> "" Then

            If datafiles = "empty" Then

                TVData.Nodes.Clear()

                Dim tvItem1 As New TreeNode

                tvItem1.Text = "Keine Daten vorhanden"

                TVData.Nodes.Add(tvItem1)

            Else

                Dim tempsplit As String() = datafiles.Split(CChar("°"))

                For Each item As String In tempsplit

                    If item = "" Then

                        Exit For

                    End If

                    Dim tempsplit2 As String() = item.Split(CChar("^"))

                    Dim cameraname As String = ""
                    Dim gitem As New ListViewGroup

                    For Each camera As database.cameraRow In Database1.camera.Rows

                        If camera.ID = Convert.ToInt32(tempsplit2(1)) Then

                            cameraname = camera.Name
                            Exit For

                        Else

                            cameraname = "Kamera nicht gefunden!"

                        End If

                    Next

                    Dim tmpNode() As TreeNode = TVData.Nodes.Find(cameraname, False)
                    'Assuming only one Match
                    tmpNode(0).Nodes.Add(tempsplit2(0))



                Next

            End If

            check_for_data.Stop()

            Label2.Text = "Fertig"

        Else

            ierror += 1

        End If

    End Sub

    Private Sub check_for_dataother_Tick(sender As Object, e As EventArgs) Handles check_for_dataother.Tick

        If ierrorother >= 10 Then

            check_for_dataother.Stop()
            MessageBox.Show("Fehler beim Datenübertragen")

        End If




        If dataotherfiles <> "" Then

            If dataotherfiles = "empty" Then

                LVDataOther.Items.Clear()

                Dim lvItem As ListViewItem

                Me.Invoke(Sub() lvItem = LVDataOther.Items.Add("Keine Daten vorhanden"))
                Me.Invoke(Sub() lvItem.SubItems.AddRange(New String() {"Keine Daten vorhanden"}))


            Else

                Dim tempsplit As String() = dataotherfiles.Split(CChar("°"))

                For Each item As String In tempsplit

                    If item = "" Then

                        Exit For

                    End If

                    Dim lvItem As ListViewItem

                    Me.Invoke(Sub() lvItem = LVDataOther.Items.Add(item))

                    Dim tempsplit2 As String() = item.Split(CChar("."))

                    Me.Invoke(Sub() lvItem.SubItems.AddRange(New String() {tempsplit2(1)}))

                    'change size to KB
                    Dim sizes As String() = {"B", "KB", "MB", "GB"}
                    Dim len As Double = New FileInfo(Hauptscreen.project_driveletter & ":\" & Format(Convert.ToInt32(id_for_pr), "000") & "\otherdata\" & item).Length
                    Dim order As Integer = 0
                    While len >= 1024 And order < sizes.Length

                        len = len / 1024
                        order += 1

                    End While

                    Dim filesizest As String = String.Format("{0:0.##} {1}", len, sizes(order))

                    'add size to listview
                    Me.Invoke(Sub() lvItem.SubItems.AddRange(New String() {filesizest}))

                Next

            End If

            check_for_dataother.Stop()

        Else

            ierrorother += 1


        End If

    End Sub

#Region "VideoPlayBack"

    'select video in QTPlayer
    Private Sub TVData_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TVData.AfterSelect

        Dim partennodetest As Boolean = False
        Dim cameraid As String = ""
        'check for node if its a camera
        For Each rowitem As database.cameraRow In Database1.camera.Rows

            If TVData.SelectedNode.Text = rowitem.Name Then

                partennodetest = True

            End If

        Next
        'checks if the node is a camera
        If partennodetest Then

            Exit Sub

        End If
        'converts cameraname to cameraid
        For Each rowitem As database.cameraRow In Database1.camera.Rows

            If TVData.SelectedNode.Parent.Text = rowitem.Name Then

                cameraid = rowitem.ID.ToString

            End If

        Next


        'select movie from Projectshare
        QTPlayer.URL = Hauptscreen.project_driveletter & ":\" & Format(Convert.ToInt32(id_for_pr), "000") & "\workfiles\" & Format(Convert.ToInt32(cameraid), "000") & "\" & TVData.SelectedNode.Text

    End Sub

    'switch Fullscreen at keypress ctrl+ü
    Private Sub Projectpage_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If (e.KeyCode And Not Keys.Modifiers) = 186 AndAlso e.Modifiers = Keys.Control Then

            If QTPlayer.FullScreen = True Then

                QTPlayer.FullScreen = False

                TopMost = False

            Else

                TopMost = True

                QTPlayer.FullScreen = True

                Focus()

            End If

        End If

    End Sub


#End Region

#Region "Datafile"

    Private Sub LVDataOther_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LVDataOther.SelectedIndexChanged

        For Each item As ListViewItem In LVDataOther.SelectedItems

            Dim STReader As StreamReader = New StreamReader(Hauptscreen.project_driveletter & ":\" & Format(Convert.ToInt32(id_for_pr), "000") & "\otherdata\" & item.Text)

            TBOtherData.Text = STReader.ReadToEnd
        Next


    End Sub

#End Region

End Class