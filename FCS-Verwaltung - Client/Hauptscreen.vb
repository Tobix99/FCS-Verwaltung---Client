Option Strict On
Imports TobixLibs.Net
Imports System.IO
Imports Microsoft.VisualBasic.Strings

Public Class Hauptscreen

    Public version As String = "0.1.0"

    Public MainUsername As String = ""
    Public MainHashedPassword As String = ""
    Public Mainserverip As String = ""
    Public Port As Integer = Convert.ToInt32(My.Settings.Port)

    Public currentversion As String = "0.0.0"
    Public WithEvents Server As ServerClass
    Public client As New ClientClass
    Dim temppath As New DirectoryInfo(Path.GetTempPath & "\FCS\Client\")
    Dim tempfile As New FileInfo(temppath.FullName & "database.dafcs")
    Dim net_password As String = My.Settings.net_password
    Dim net_username As String = "/user:" & My.Settings.net_computer & "\" & My.Settings.net_username
    Public import_driveletter As String = ""
    Public project_driveletter As String = ""
    Public music_import_driveletter As String = ""
    Public music_pool_driveletter As String = ""
    Public availableDriveLetters As New List(Of String)
    Public import_clipnumber As Integer = 0
    Public admin As Boolean = False
    Dim static_ip_bo As Boolean = My.Settings.static_ip_bo
    Dim static_ip_st As String = My.Settings.staic_ip_st
    Dim premiere_Path As String = My.Settings.Premiere_Path
    Public music_form_active As Boolean = False

    Dim WithEvents premiereProcess As Process = New Process()


    Private Sub Hauptscreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.KeyPreview = True

        Server = New ServerClass(Convert.ToInt32(My.Settings.Port), True, static_ip_bo, static_ip_st)
        ' Server = New ServerClass(Port, True, True, "192.168.178.72")

        Server.StartServer()

        TSServerIP.Text = Mainserverip
        TSSOwnIP.Text = Server.LocalIP

        Login.Close()
        LUsername.Text = MainUsername

        create_listview()
        LVPro.Items.Clear()

        If Not temppath.Exists Then

            temppath.Create()

        End If

        If Not tempfile.Exists Then

            Dim sw As StreamWriter = tempfile.CreateText

            sw.WriteLine("")

            sw.Flush()

            sw.Close()

        End If

        Dim test As Boolean = False

        Do

            Try

                Database1.WriteXml(tempfile.FullName)
                test = True
            Catch ex As Exception

            End Try

        Loop Until test = True

        mount_drives()

        If admin = False Then

            NetzwerkToolStripMenuItem.Visible = False
            ConsoleToolStripMenuItem.Visible = False
            ToolStripSeparator3.Visible = False
            ClientToolStripMenuItem.Visible = False
            GroupBox6.Visible = False

        Else

            NetzwerkToolStripMenuItem.Visible = True
            ConsoleToolStripMenuItem.Visible = True
            ToolStripSeparator3.Visible = True
            ClientToolStripMenuItem.Visible = True
            GroupBox6.Visible = True


        End If

        message_to_server("askupdateauto;" & version)

    End Sub

#Region "TSI"

    Private Sub TSINew_Click(sender As Object, e As EventArgs) Handles TSINew.Click

        create.Show()

    End Sub

    Private Sub TSIEdit_click(sender As Object, e As EventArgs) Handles TSIEdit.Click

        edit_form.Show()

    End Sub

    Private Sub TSIDelte_Click(sender As Object, e As EventArgs) Handles TSIDelte.Click

        remove_form.Show()

    End Sub

    Private Sub TSIRef_Click(sender As Object, e As EventArgs) Handles TSIRef.Click

        message_to_server("refresh")

    End Sub

    Private Sub TSIReload_Click(sender As Object, e As EventArgs) Handles TSIReload.Click

        message_to_server("reload")

    End Sub

    Private Sub TSIRestart_Click(sender As Object, e As EventArgs) Handles TSIRestart.Click

        message_to_server("restart")

    End Sub

    Private Sub TSIExit_Click(sender As Object, e As EventArgs) Handles TSIExit.Click

        Application.Exit()

    End Sub

    Private Sub TSIImport_Click(sender As Object, e As EventArgs) Handles TSIImport.Click

        Import_form.Show()

    End Sub

    Private Sub TSIImportOtherData_Click(sender As Object, e As EventArgs) Handles TSIImportOtherData.Click

        import_form_other.Show()

    End Sub

    Private Sub TSINetworkusername_Click(sender As Object, e As EventArgs) Handles TSINetworkusername.Click

        input_dialog.mode = 0
        input_dialog.Show()

    End Sub

    Private Sub TSINetworkpassword_Click(sender As Object, e As EventArgs) Handles TSINetworkpassword.Click

        input_dialog.mode = 1
        input_dialog.Show()

    End Sub

    Private Sub TSINetworkComputer_Click(sender As Object, e As EventArgs) Handles TSINetworkComputer.Click

        input_dialog.mode = 2
        input_dialog.Show()

    End Sub

    Private Sub TSIStaticIP_Click(sender As Object, e As EventArgs) Handles TSIStaticIP.Click

        input_dialog.mode = 3
        input_dialog.Show()

    End Sub

    Private Sub TSIUpdates_Click(sender As Object, e As EventArgs) Handles TSIUpdates.Click

        message_to_server("askupdate;" & version)

    End Sub

    Private Sub TSIMusic_Click(sender As Object, e As EventArgs) Handles TSIMusic.Click

        music_form_active = True

        music_form.Show()

    End Sub

    Private Sub TSIStopMachine_Click(sender As Object, e As EventArgs) Handles TSIStopMachine.Click

        message_to_server("stopmachine")

    End Sub

    Private Sub TSICurrentClientVersion_Click(sender As Object, e As EventArgs) Handles TSICurrentClientVersion.Click

        input_version.ShowDialog()

    End Sub

    Private Sub AuditionsPfadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AuditionsPfadToolStripMenuItem.Click

        input_dialog.mode = 5
        input_dialog.Show()

    End Sub

    Private Sub PremierePfadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PremierePfadToolStripMenuItem.Click

        input_dialog.mode = 4
        input_dialog.Show()

    End Sub

#End Region

    Private Sub OnIncomingMessage(ByVal Args As ServerClass.InMessEvArgs) Handles Server.IncomingMessage

        If Not Args.senderIP = Mainserverip Then

            errormessage("ServerIP und EmpfangsIP stimmen nicht überein! Programm wird beendet!")

            Application.Exit()

        End If

        Dim data As String = Args.message

        Dim temparray As String() = data.Split(CChar(";"))

        Select Case True

            Case temparray(0) = "logincorrect"
                If temparray(1) = "true" Then

                    'errormessage("Erfolgreich neu Verbunden!")

                Else

                    errormessage("Fehler beim neu verbinden! Anwendung wird beendet!")
                    Application.Exit()

                End If

            Case temparray(0) = "addProject"
                If temparray(1) = "NO" Then
                    Dim lvItem As ListViewItem

                    Me.Invoke(Sub() lvItem = LVPro.Items.Add("0"))
                    Me.Invoke(Sub() lvItem.SubItems.AddRange(New String() {"Keine Projekte gefunden"}))

                    Exit Sub
                End If
                add_projects_to_listview(temparray(1), temparray(2), temparray(3), temparray(4), temparray(5))

            Case temparray(0) = "addCategory"
                If temparray(1) = "NO" Then
                    Dim lvItem As ListViewItem

                    Me.Invoke(Sub() lvItem = LVCat.Items.Add("0"))
                    Me.Invoke(Sub() lvItem.SubItems.AddRange(New String() {"Keine Kategorien gefunden"}))

                    Exit Sub
                End If
                add_category_to_listview(temparray(1), temparray(2), temparray(3))

            Case temparray(0) = "addCamera"
                If temparray(1) = "NO" Then
                    Dim lvItem As ListViewItem

                    Me.Invoke(Sub() lvItem = LVCam.Items.Add("0"))
                    Me.Invoke(Sub() lvItem.SubItems.AddRange(New String() {"Keine Kameras gefunden"}))

                    Exit Sub
                End If
                add_camera_to_listview(temparray(1), temparray(2), temparray(3))

            Case temparray(0) = "addUser"
                If temparray(1) = "NO" Then
                    Dim lvItem As ListViewItem

                    Me.Invoke(Sub() lvItem = LVUser.Items.Add("0"))
                    Me.Invoke(Sub() lvItem.SubItems.AddRange(New String() {"Keine Benutzer gefunden"}))

                    Exit Sub
                End If
                add_user_to_listview(temparray(1), temparray(2), temparray(3), temparray(4), temparray(5))

            Case temparray(0) = "addUsergroup"
                If temparray(1) = "NO" Then
                    Dim lvItem As ListViewItem

                    Me.Invoke(Sub() lvItem = LVUserGroups.Items.Add("0"))
                    Me.Invoke(Sub() lvItem.SubItems.AddRange(New String() {"Keine Benutzergruppen gefunden"}))

                    Exit Sub
                End If
                add_usergroup_to_listview(temparray(1), temparray(2), temparray(3), temparray(4))

            Case temparray(0) = "addMusic"

                If temparray(1) = "NO" Then

                Else

                    add_music_to_database(Convert.ToInt32(temparray(1)), temparray(2), temparray(3), temparray(4), temparray(5), temparray(6), temparray(7), temparray(8), temparray(9))

                End If

            Case temparray(0) = "addTemplate"
                If temparray(1) = "NO" Then



                Else

                    Dim row As database.templatesRow

                    row = Database1.templates.NewtemplatesRow

                    row.ID = Convert.ToInt32(temparray(1))
                    row.Name = temparray(2)
                    row.Info = temparray(3)
                    row.Group = temparray(4)
                    row.Res = temparray(5)

                    Database1.templates.Rows.Add(row)

                End If

            Case temparray(0) = "addTemplateGroup"
                If temparray(1) = "NO" Then



                Else

                    Dim row As database.template_groupsRow

                    row = Database1.template_groups.Newtemplate_groupsRow

                    row.ID = Convert.ToInt32(temparray(1))
                    row.Name = temparray(2)


                    Database1.template_groups.Rows.Add(row)

                    save_database()


                End If


            Case temparray(0) = "removeProject"

                remove_project(temparray(1))

                Exit Sub

            Case temparray(0) = "removeCategory"

                remove_category(temparray(1))

                Exit Sub

            Case temparray(0) = "removeCamera"

                remove_camera(temparray(1))

                Exit Sub

            Case temparray(0) = "removeUser"

                remove_user(temparray(1))

                Exit Sub

            Case temparray(0) = "removeUsergroup"

                remove_usergroup(temparray(1))

                Exit Sub

            Case temparray(0) = "removeMusic"
                Try

                    Me.Invoke(Sub() music_form.remove_music_from_lv(temparray(1)))

                Catch ex As Exception

                End Try

            Case temparray(0) = "clear"
                clear()

            Case temparray(0) = "serverrestart"
                clear()
                serverrestart.RunWorkerAsync()

            Case temparray(0) = "serverstop"

                If MessageBox.Show("Der Verwaltungsserver wurde gestoppt! Es wird versucht eine Verbindung aufzubauen!", "Fehler!", MessageBoxButtons.RetryCancel) = DialogResult.Cancel Then

                    'OFFLINEMODE einebauen

                Else

                    Me.Invoke(Sub() Me.Enabled = False)
                    serverstop.RunWorkerAsync()

                End If

            Case temparray(0) = "FileImport"
                Dim filearray As String() = temparray(1).Split(CChar(":"))
                Me.Invoke(Sub() TSSImportFile.Text = filearray(0))

            Case temparray(0) = "FileEncoding"
                Dim filearray As String() = temparray(1).Split(CChar(":"))
                Me.Invoke(Sub() TSSImportFile.Text = filearray(0) & ", ")

            Case temparray(0) = "update"

                If temparray(1) = "True" Then

                    Dim update_dia As DialogResult = MessageBox.Show("Neues Update verfügbar", "Update!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

                    If update_dia = DialogResult.OK Then

                        get_update()

                    End If

                ElseIf temparray(1) = "False" Then

                    MessageBox.Show("Kein neues Update verfügbar", "Kein Update!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If

                currentversion = temparray(2)

            Case temparray(0) = "autoupdate"

                If temparray(1) = "True" Then

                    Dim update_dia As DialogResult = MessageBox.Show("Neues Update verfügbar", "Update!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

                    If update_dia = DialogResult.OK Then

                        get_update()

                    End If

                End If

                currentversion = temparray(2)

            Case temparray(0) = "dataotherfiles"
                Me.Invoke(Sub() Projectpage.dataotherfiles = temparray(1))

            Case temparray(0) = "datafiles"
                Me.Invoke(Sub() Projectpage.datafiles = temparray(1))


            Case temparray(0) = "log"

                Dim time As String = Format(My.Computer.Clock.LocalTime.Hour, "00") & ":" & Format(My.Computer.Clock.LocalTime.Minute, "00") & ":" & Format(My.Computer.Clock.LocalTime.Second, "00")

                Select Case True

                    Case temparray(1) = "createProject"
                        Invoke(Sub() LBLog.Items.Add(time & " Benutzer " & temparray(2) & " hat ein neues Projekt erstellt: " & temparray(3)))

                    Case temparray(1) = "editProject"
                        Invoke(Sub() LBLog.Items.Add(time & " Benutzer " & temparray(2) & " hat ein Projekt bearbeitet: " & temparray(3)))

                    Case temparray(1) = "deleteProject"
                        Invoke(Sub() LBLog.Items.Add(time & " Benutzer " & temparray(2) & " hat ein Projekt gelöscht: " & temparray(3)))

                    Case temparray(1) = "createCategory"
                        Invoke(Sub() LBLog.Items.Add(time & " Benutzer " & temparray(2) & " hat eine neue Kategorie erstellt: " & temparray(3)))

                    Case temparray(1) = "editCategory"
                        Invoke(Sub() LBLog.Items.Add(time & " Benutzer " & temparray(2) & " hat eine Kategorie bearbeitet: " & temparray(3)))

                    Case temparray(1) = "deleteCategory"
                        Invoke(Sub() LBLog.Items.Add(time & " Benutzer " & temparray(2) & " hat eine Kategorie gelöscht: " & temparray(3)))

                    Case temparray(1) = "createCamera"
                        Invoke(Sub() LBLog.Items.Add(time & " Benutzer " & temparray(2) & " hat eine neue Kamera erstellt: " & temparray(3)))

                    Case temparray(1) = "editCamera"
                        Invoke(Sub() LBLog.Items.Add(time & " Benutzer " & temparray(2) & " hat eine Kamera bearbeitet: " & temparray(3)))

                    Case temparray(1) = "deleteCamera"
                        Invoke(Sub() LBLog.Items.Add(time & " Benutzer " & temparray(2) & " hat eine Kamera gelöscht: " & temparray(3)))

                    Case temparray(1) = "createUser"
                        Invoke(Sub() LBLog.Items.Add(time & " Benutzer " & temparray(2) & " hat einen neuen Benutzer erstellt: " & temparray(3)))

                    Case temparray(1) = "editUser"
                        Invoke(Sub() LBLog.Items.Add(time & " Benutzer " & temparray(2) & " hat einen Benutzer bearbeitet: " & temparray(3)))

                    Case temparray(1) = "deleteUser"
                        Invoke(Sub() LBLog.Items.Add(time & " Benutzer " & temparray(2) & " hat einen Benutzer gelöscht: " & temparray(3)))

                    Case temparray(1) = "createUsergroup"
                        Invoke(Sub() LBLog.Items.Add(time & " Benutzer " & temparray(2) & " hat eine neue Benutzergruppe erstellt: " & temparray(3)))

                    Case temparray(1) = "editUsergroup"
                        Invoke(Sub() LBLog.Items.Add(time & " Benutzer " & temparray(2) & " hat eine Benutzergruppe bearbeitet: " & temparray(3)))

                    Case temparray(1) = "deleteUsergroup"
                        Invoke(Sub() LBLog.Items.Add(time & " Benutzer " & temparray(2) & " hat eine Benutzergruppe gelöscht: " & temparray(3)))

                    Case temparray(1) = "createMusic"
                        Invoke(Sub() LBLog.Items.Add(time & " Benutzer " & temparray(2) & " hat einen neuen Song erstellt: " & temparray(3)))

                    Case temparray(1) = "editMusic"
                        Invoke(Sub() LBLog.Items.Add(time & " Benutzer " & temparray(2) & " hat einen Song bearbeitet: " & temparray(3)))

                    Case temparray(1) = "deleteMusic"
                        Invoke(Sub() LBLog.Items.Add(time & " Benutzer " & temparray(2) & " hat einen Song gelöscht: " & temparray(3)))

                End Select

            Case Else

                errormessage("Es wurde ein flascher Wert übermittelt! Programm wird beendent")

                errormessage(data)

                'Application.Exit()

        End Select

    End Sub

#Region "add to lV and Database"

    Private Sub add_projects_to_listview(ID As String, Name As String, Categorie_ID As String, description As String, archived As String)

        Try

            Me.LVPro.Invoke(Sub()

                                For Each listItem As ListViewItem In LVPro.Items

                                    If listItem.SubItems.Item(1).Text = "Keine Projekte gefunden" Then
                                        LVPro.Items.Clear()
                                    End If

                                Next

                            End Sub)

        Catch ex As Exception

        End Try

        If archived.Equals("False") Then

            archived = "Nein"

        Else

            archived = "Ja"

        End If

        Dim category As String = get_name_from_categoryID(Categorie_ID)

        Dim lvItem As ListViewItem

        Me.Invoke(Sub() lvItem = LVPro.Items.Add(ID))
        Me.Invoke(Sub() lvItem.SubItems.AddRange(New String() {Name, category, description, archived}))

        Dim row As database.projectsRow

        row = Database1.projects.NewprojectsRow

        row.ID = Convert.ToInt32(ID)
        row.Name = Name
        row.CategoryID = Categorie_ID
        row.Category = category
        row.Description = description
        row.Archived = archived

        Database1.projects.Rows.Add(row)

        save_database()

    End Sub

    Private Sub add_category_to_listview(ID As String, Name As String, description As String)

        Try

            Me.LVCat.Invoke(Sub()

                                For Each listItem As ListViewItem In LVCat.Items

                                    If listItem.SubItems.Item(1).Text = "Keine Kategorie gefunden" Then
                                        LVCat.Items.Clear()
                                    End If

                                Next

                            End Sub)

        Catch ex As Exception

        End Try

        Dim lvItem As ListViewItem

        Me.Invoke(Sub() lvItem = LVCat.Items.Add(ID))
        Me.Invoke(Sub() lvItem.SubItems.AddRange(New String() {Name, description}))

        Dim row As database.categoryRow

        row = Database1.category.NewcategoryRow

        row.ID = Convert.ToInt32(ID)
        row.Name = Name
        row.Description = description

        Database1.category.Rows.Add(row)

        save_database()

    End Sub

    Private Sub add_camera_to_listview(ID As String, Name As String, description As String)

        Try

            Me.LVCam.Invoke(Sub()

                                For Each listItem As ListViewItem In LVCam.Items

                                    If listItem.SubItems.Item(1).Text = "Keine Kameras gefunden" Then
                                        LVCam.Items.Clear()
                                    End If

                                Next

                            End Sub)

        Catch ex As Exception

        End Try


        Dim lvItem As ListViewItem

        Me.Invoke(Sub() lvItem = LVCam.Items.Add(ID))
        Me.Invoke(Sub() lvItem.SubItems.AddRange(New String() {Name, description}))

        Dim row As database.cameraRow

        row = Database1.camera.NewcameraRow

        row.ID = Convert.ToInt32(ID)
        row.Name = Name
        row.Description = description

        Database1.camera.Rows.Add(row)

        save_database()

    End Sub

    Private Sub add_user_to_listview(id As String, name As String, groupid As String, enabled As String, admin As String)

        Try

            Me.LVUser.Invoke(Sub()

                                 For Each listItem As ListViewItem In LVUser.Items

                                     If listItem.SubItems.Item(1).Text = "Keine Benutzer gefunden" Then
                                         LVUser.Items.Clear()
                                     End If

                                 Next

                             End Sub)

        Catch ex As Exception

        End Try

        If enabled = "False" Then

            enabled = "Nein"

        Else

            enabled = "Ja"

        End If

        If admin = "False" Then

            admin = "Nein"

        Else

            admin = "Ja"

        End If

        Dim lvItem As ListViewItem

        Dim group As String = get_name_from_groupID(groupid)

        Me.Invoke(Sub() lvItem = LVUser.Items.Add(id))
        Me.Invoke(Sub() lvItem.SubItems.AddRange(New String() {name, group, enabled, admin}))

        Dim row As database.UserRow

        row = Database1.User.NewUserRow

        row.ID = Convert.ToInt32(id)
        row.Name = name
        row.GroupID = groupid
        row.group = group
        row.enabled = enabled
        row.admin = admin

        Database1.User.Rows.Add(row)

        save_database()

    End Sub

    Private Sub add_usergroup_to_listview(id As String, name As String, description As String, permissions As String)

        Try

            Me.LVUserGroups.Invoke(Sub()

                                       For Each listItem As ListViewItem In LVUserGroups.Items

                                           If listItem.SubItems.Item(1).Text = "Keine Benutzergruppen gefunden" Then
                                               LVUserGroups.Items.Clear()
                                           End If

                                       Next

                                   End Sub)

        Catch ex As Exception

        End Try

        Dim lvItem As ListViewItem

        Me.Invoke(Sub() lvItem = LVUserGroups.Items.Add(id))
        Me.Invoke(Sub() lvItem.SubItems.AddRange(New String() {name, description, "Rechte beim bearbeiten einsehen"}))

        Dim row As database.UsergroupRow

        row = Database1.Usergroup.NewUsergroupRow

        row.ID = Convert.ToInt32(id)
        row.Name = name
        row.Description = description
        row.Permissions = permissions

        Database1.Usergroup.Rows.Add(row)

    End Sub

    Private Sub add_music_to_database(id As Integer, name As String, interpret As String, album As String, year As String, genre As String, comment As String, ext As String, time As String)

        Dim row As database.musicRow

        row = Database1.music.NewmusicRow

        row.ID = id
        row.Name = name
        row.Interpret = interpret
        row.Album = album
        row.Year = year
        row.Genre = genre
        row.Comment = comment
        row._Format_ext = ext
        row.Time = time

        Database1.music.Rows.Add(row)

        save_database()

        If music_form_active Then

            Invoke(Sub() music_form.reload())

        End If

    End Sub

#End Region

#Region "remove from lv and Database"

    Private Function remove_project(name As String) As Boolean

        Me.LVPro.Invoke(Sub()

                            For Each listItem As ListViewItem In LVPro.Items

                                If listItem.SubItems.Item(1).Text = name Then
                                    listItem.Remove()
                                End If

                            Next

                            If LVPro.Items.Count = 0 Then

                                Dim lvItem As ListViewItem

                                lvItem = LVPro.Items.Add("0")
                                lvItem.SubItems.AddRange(New String() {"Keine Projekte gefunden"})

                            End If

                        End Sub)

        Dim abfrage As String = "Name = '" & name & "'"

        Dim foundrows() As DataRow = Database1.projects.Select(abfrage)

        For i = 0 To foundrows.GetUpperBound(0)

            Database1.projects.Rows.Remove(foundrows(i))

        Next

        save_database()

    End Function

    Private Function remove_category(name As String) As Boolean

        Me.LVCat.Invoke(Sub()

                            For Each listItem As ListViewItem In LVCat.Items

                                If listItem.SubItems.Item(1).Text = name Then
                                    listItem.Remove()
                                End If

                            Next

                            If LVCat.Items.Count = 0 Then

                                Dim lvItem As ListViewItem

                                lvItem = LVCat.Items.Add("0")
                                lvItem.SubItems.AddRange(New String() {"Keine Kategorien gefunden"})

                            End If

                        End Sub)

        Dim abfrage As String = "Name = '" & name & "'"

        Dim foundrows() As DataRow = Database1.category.Select(abfrage)

        For i = 0 To foundrows.GetUpperBound(0)

            Database1.category.Rows.Remove(foundrows(i))

        Next

        save_database()

    End Function

    Private Function remove_camera(name As String) As Boolean

        Me.LVCam.Invoke(Sub()

                            For Each listItem As ListViewItem In LVCam.Items

                                If listItem.SubItems.Item(1).Text = name Then
                                    listItem.Remove()
                                End If

                            Next

                            If LVCam.Items.Count = 0 Then

                                Dim lvItem As ListViewItem

                                lvItem = LVCam.Items.Add("0")
                                lvItem.SubItems.AddRange(New String() {"Keine Kameras gefunden"})

                            End If

                        End Sub)

        Dim abfrage As String = "Name = '" & name & "'"

        Dim foundrows() As DataRow = Database1.camera.Select(abfrage)

        For i = 0 To foundrows.GetUpperBound(0)

            Database1.camera.Rows.Remove(foundrows(i))

        Next

        save_database()

    End Function

    Private Function remove_user(name As String) As Boolean

        Me.LVUser.Invoke(Sub()

                             For Each listItem As ListViewItem In LVUser.Items

                                 If listItem.SubItems.Item(1).Text = name Then
                                     listItem.Remove()
                                 End If

                             Next

                             If LVUser.Items.Count = 0 Then

                                 Dim lvItem As ListViewItem

                                 lvItem = LVUser.Items.Add("0")
                                 lvItem.SubItems.AddRange(New String() {"Keine Benutzer gefunden"})

                             End If

                         End Sub)

        Dim abfrage As String = "Name = '" & name & "'"

        Dim foundrows() As DataRow = Database1.User.Select(abfrage)

        For i = 0 To foundrows.GetUpperBound(0)

            Database1.User.Rows.Remove(foundrows(i))

        Next

        save_database()

    End Function

    Private Function remove_usergroup(name As String) As Boolean

        Me.LVUserGroups.Invoke(Sub()

                                   For Each listItem As ListViewItem In LVUserGroups.Items

                                       If listItem.SubItems.Item(1).Text = name Then
                                           listItem.Remove()
                                       End If

                                   Next

                                   If LVUserGroups.Items.Count = 0 Then

                                       Dim lvItem As ListViewItem

                                       lvItem = LVUserGroups.Items.Add("0")
                                       lvItem.SubItems.AddRange(New String() {"Keine Benutzergruppen gefunden"})

                                   End If

                               End Sub)


        Dim abfrage As String = "Name = '" & name & "'"

        Dim foundrows() As DataRow = Database1.Usergroup.Select(abfrage)

        For i = 0 To foundrows.GetUpperBound(0)

            Database1.Usergroup.Rows.Remove(foundrows(i))

        Next

        save_database()

    End Function

#End Region

    Private Sub create_listview()

        Dim lvColumnHeader As ColumnHeader

        'Projects
        LVPro.View = View.Details

        lvColumnHeader = LVPro.Columns.Add("ID")
        lvColumnHeader.Width = 50

        lvColumnHeader = LVPro.Columns.Add("Name")
        lvColumnHeader.Width = 100

        lvColumnHeader = LVPro.Columns.Add("Kategorie")
        lvColumnHeader.Width = 100

        lvColumnHeader = LVPro.Columns.Add("Beschreibung")
        lvColumnHeader.Width = 150

        lvColumnHeader = LVPro.Columns.Add("Archiviert")
        lvColumnHeader.Width = 70

        LVPro.MultiSelect = False
        LVPro.FullRowSelect = True

        'Category
        LVCat.View = View.Details

        lvColumnHeader = LVCat.Columns.Add("ID")
        lvColumnHeader.Width = 50

        lvColumnHeader = LVCat.Columns.Add("Name")
        lvColumnHeader.Width = 150

        lvColumnHeader = LVCat.Columns.Add("Beschreibung")
        lvColumnHeader.Width = 200

        LVCat.MultiSelect = False
        LVCat.FullRowSelect = True

        'Camera
        LVCam.View = View.Details

        lvColumnHeader = LVCam.Columns.Add("ID")
        lvColumnHeader.Width = 50

        lvColumnHeader = LVCam.Columns.Add("Name")
        lvColumnHeader.Width = 150

        lvColumnHeader = LVCam.Columns.Add("Beschreibung")
        lvColumnHeader.Width = 220

        LVCam.MultiSelect = False
        LVCam.FullRowSelect = True

        'User
        LVUser.View = View.Details

        lvColumnHeader = LVUser.Columns.Add("ID")
        lvColumnHeader.Width = 50

        lvColumnHeader = LVUser.Columns.Add("Benutzername")
        lvColumnHeader.Width = 100

        lvColumnHeader = LVUser.Columns.Add("Gruppe")
        lvColumnHeader.Width = 100

        lvColumnHeader = LVUser.Columns.Add("Aktiviert")
        lvColumnHeader.Width = 70

        lvColumnHeader = LVUser.Columns.Add("Admin")
        lvColumnHeader.Width = 70

        LVUser.MultiSelect = False
        LVUser.FullRowSelect = True

        'Usergroups
        LVUser.View = View.Details

        lvColumnHeader = LVUserGroups.Columns.Add("ID")
        lvColumnHeader.Width = 50

        lvColumnHeader = LVUserGroups.Columns.Add("Gruppenname")
        lvColumnHeader.Width = 100

        lvColumnHeader = LVUserGroups.Columns.Add("Beschreibung")
        lvColumnHeader.Width = 100

        lvColumnHeader = LVUserGroups.Columns.Add("Rechte")
        lvColumnHeader.Width = 180

        LVUserGroups.MultiSelect = False
        LVUserGroups.FullRowSelect = True


    End Sub

    Private Function get_name_from_categoryID(id As String) As String

        Dim abfrage As String = "ID ='" & id & "'"

        Dim foundrow As DataRow() = Database1.Tables("category").Select(abfrage)

        Dim i As Integer = 0

        For i = 0 To foundrow.GetUpperBound(0)

            Return foundrow(i)(1).ToString
            Exit Function

        Next

        Return "Kategorie nicht vorhanden!"

    End Function

    Private Function get_name_from_groupID(id As String) As String

        Dim abfrage As String = "ID ='" & id & "'"

        Dim foundrow As DataRow() = Database1.Usergroup.Select(abfrage)

        Dim i As Integer = 0

        For i = 0 To foundrow.GetUpperBound(0)

            Return foundrow(i)(1).ToString
            Exit Function

        Next

        Return "Benutzer-Gruppe nicht vorhanden!"

    End Function

    Private Sub clear()

        Database1.Clear()
        save_database()

        Invoke(Sub() LVCam.Items.Clear())

        Invoke(Sub() LVCat.Items.Clear())

        Invoke(Sub() LVPro.Items.Clear())

        Invoke(Sub() LVUser.Items.Clear())

        Invoke(Sub() LVUserGroups.Items.Clear())

    End Sub

    Private Sub message_to_server(message As String)

        client.SendMessage(Mainserverip, Convert.ToInt32(My.Settings.Port), MainUsername & ";" & MainHashedPassword & ";" & message)

    End Sub

    Private Sub Hauptscreen_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If music_form_active Then

            e.Cancel = True

            MessageBox.Show("Bitte erst alle anderen Fenster schlißen")

            Exit Sub

        End If

        Try

            client.SendMessage(Mainserverip, Convert.ToInt32(My.Settings.Port), MainUsername & ";" & MainHashedPassword & ";logout")

        Catch ex As Exception

        End Try

        cmd_process("net use " & import_driveletter & ": /delete /YES", "", False)

        cmd_process("net use " & project_driveletter & ": /delete /YES", "", False)

        cmd_process("net use " & music_import_driveletter & ": /delete /YES", "", False)

        cmd_process("net use " & music_pool_driveletter & ": /delete /YES", "", False)

    End Sub

    Private Sub get_update()


        File.Copy("\\" & Mainserverip & "\update_share\client.exe", Application.StartupPath & "\update.exe", True)
        File.Copy("\\" & Mainserverip & "\update_share\update.bat", Application.StartupPath & "\update.bat", True)

        Dim command = "update.bat"

        cmd_process(command, "", False)

        Application.Exit()

    End Sub

#Region "Context_menu"

#Region "create"

    Private Sub TSMCreatePro_Click(sender As Object, e As EventArgs) Handles TSMCreatePro.Click

        create.mode = 0

        create.context = True

        create.Show()

    End Sub

    Private Sub TSMCreateCat_Click(sender As Object, e As EventArgs) Handles TSMCreateCat.Click

        create.mode = 1

        create.context = True

        create.Show()

    End Sub

    Private Sub TSMCreateCam_Click(sender As Object, e As EventArgs) Handles TSMCreateCam.Click

        create.mode = 2

        create.context = True

        create.Show()

    End Sub

    Private Sub TSMCreateUsr_Click(sender As Object, e As EventArgs) Handles TSMCreateUsr.Click

        create.mode = 3

        create.context = True

        create.Show()

    End Sub

    Private Sub TSMCreateUsG_Click(sender As Object, e As EventArgs) Handles TSMCreateUsG.Click

        create.mode = 4

        create.context = True

        create.Show()

    End Sub

#End Region

#Region "edit"

    Private Sub TSMEditPro_Click(sender As Object, e As EventArgs) Handles TSMEditPro.Click

        Dim id As String = ""

        Try

            id = LVPro.SelectedItems(0).SubItems(0).Text

        Catch ex As Exception

        End Try

        If id <> "" Then

            edit_form.mode = 0

            edit_form.id_to_edit_Pro = Convert.ToInt32(id)

            edit_form.context = True

            edit_form.Show()

        Else

            edit_form.mode = 0

            edit_form.context = True

            edit_form.Show()

        End If

    End Sub

    Private Sub TSMCatEdit_Click(sender As Object, e As EventArgs) Handles TSMCatEdit.Click

        Dim id As String = ""

        Try

            id = LVCat.SelectedItems(0).SubItems(0).Text

        Catch ex As Exception

        End Try

        If id <> "" Then

            edit_form.mode = 1

            edit_form.id_to_edit_Cat = Convert.ToInt32(id)

            edit_form.context = True

            edit_form.Show()

        Else

            edit_form.mode = 1

            edit_form.context = True

            edit_form.Show()

        End If

    End Sub

    Private Sub TSMCamEdit_Click(sender As Object, e As EventArgs) Handles TSMCamEdit.Click

        Dim id As String = ""

        Try

            id = LVCam.SelectedItems(0).SubItems(0).Text

        Catch ex As Exception

        End Try

        If id <> "" Then

            edit_form.mode = 2

            edit_form.id_to_edit_Cam = Convert.ToInt32(id)

            edit_form.context = True

            edit_form.Show()

        Else

            edit_form.mode = 2

            edit_form.context = True

            edit_form.Show()

        End If

    End Sub

    Private Sub TSMUsrEdit_Click(sender As Object, e As EventArgs) Handles TSMUsrEdit.Click

        Dim id As String = ""

        Try

            id = LVUser.SelectedItems(0).SubItems(0).Text

        Catch ex As Exception

        End Try

        If id <> "" Then

            edit_form.mode = 3

            edit_form.id_to_edit_Usr = Convert.ToInt32(id)

            edit_form.context = True

            edit_form.Show()

        Else

            edit_form.mode = 3

            edit_form.context = True

            edit_form.Show()

        End If

    End Sub

    Private Sub TSMUsGEdit_Click(sender As Object, e As EventArgs) Handles TSMUsGEdit.Click

        Dim id As String = ""

        Try

            id = LVUserGroups.SelectedItems(0).SubItems(0).Text

        Catch ex As Exception

        End Try

        If id <> "" Then

            edit_form.mode = 4

            edit_form.id_to_edit_UsG = Convert.ToInt32(id)

            edit_form.context = True

            edit_form.Show()

        Else

            edit_form.mode = 4

            edit_form.context = True

            edit_form.Show()

        End If

    End Sub

#End Region

#Region "Delete"

    Private Sub TSMDelPro_Click(sender As Object, e As EventArgs) Handles TSMDelPro.Click

        Dim id As String = ""

        Try

            id = LVPro.SelectedItems(0).SubItems(0).Text

        Catch ex As Exception

        End Try

        If id <> "" Then

            remove_form.mode = 0

            remove_form.id_to_remove_Pro = Convert.ToInt32(id)

            remove_form.context = True

            remove_form.Show()

        Else

            remove_form.mode = 0

            remove_form.context = True

            remove_form.Show()

        End If

    End Sub

    Private Sub TSMDelCat_Click(sender As Object, e As EventArgs) Handles TSMDelCat.Click

        Dim id As String = ""

        Try

            id = LVCat.SelectedItems(0).SubItems(0).Text

        Catch ex As Exception

        End Try

        If id <> "" Then

            remove_form.mode = 1

            remove_form.id_to_remove_Cat = Convert.ToInt32(id)

            remove_form.context = True

            remove_form.Show()

        Else

            remove_form.mode = 1

            remove_form.context = True

            remove_form.Show()

        End If

    End Sub

    Private Sub TSMCamDelete_Click(sender As Object, e As EventArgs) Handles TSMCamDelete.Click

        Dim id As String = ""

        Try

            id = LVCam.SelectedItems(0).SubItems(0).Text

        Catch ex As Exception

        End Try

        If id <> "" Then

            remove_form.mode = 2

            remove_form.id_to_remove_Cam = Convert.ToInt32(id)

            remove_form.context = True

            remove_form.Show()

        Else

            remove_form.mode = 2

            remove_form.context = True

            remove_form.Show()

        End If

    End Sub

    Private Sub TSMDelUsr_Click(sender As Object, e As EventArgs) Handles TSMDelUsr.Click

        Dim id As String = ""

        Try

            id = LVUser.SelectedItems(0).SubItems(0).Text

        Catch ex As Exception

        End Try

        If id <> "" Then

            remove_form.mode = 3

            remove_form.id_to_remove_Usr = Convert.ToInt32(id)

            remove_form.context = True

            remove_form.Show()

        Else

            remove_form.mode = 3

            remove_form.context = True

            remove_form.Show()

        End If

    End Sub

    Private Sub TSMDelUsG_Click(sender As Object, e As EventArgs) Handles TSMDelUsG.Click

        Dim id As String = ""

        Try

            id = LVUserGroups.SelectedItems(0).SubItems(0).Text

        Catch ex As Exception

        End Try

        If id <> "" Then

            remove_form.mode = 4

            remove_form.id_to_remove_UsG = Convert.ToInt32(id)

            remove_form.context = True

            remove_form.Show()

        Else

            remove_form.mode = 4

            remove_form.context = True

            remove_form.Show()

        End If

    End Sub

#End Region

#End Region

    Private Sub serverrestart_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles serverrestart.DoWork

        Threading.Thread.Sleep(2000)

        errormessage("Server wurde neu gestartet! Daten werden neu eingelesen!")

        Try

            client.SendMessage(Mainserverip, Port, MainUsername & ";" & MainHashedPassword & ";login")

        Catch ex As Exception



        End Try

    End Sub

    Private Sub serverstop_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles serverstop.DoWork

        Dim con As Boolean = False

        Do While con = False

            Threading.Thread.Sleep(3000)

            Try

                client.SendMessage(Mainserverip, Port, MainUsername & ";" & MainHashedPassword & ";login")

                clear()

                errormessage("Verbindung wiederhergestellt!")

                Me.Invoke(Sub() Me.Enabled = True)

                con = True

            Catch ex As Exception

            End Try

        Loop

    End Sub

    Private Function errormessage(message As String) As DialogResult

        Dim box = MessageBox.Show(message, "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Return box

    End Function

    Private Sub mount_drives()

#Region "unused drives"

        For x As Integer = 65 To 90
            availableDriveLetters.Add(Chr(x))
        Next
        For Each d As String In System.IO.Directory.GetLogicalDrives()
            availableDriveLetters.Remove(d.Replace(":\", ""))
        Next

        import_driveletter = availableDriveLetters(0)

        project_driveletter = availableDriveLetters(1)

        music_import_driveletter = availableDriveLetters(2)

        music_pool_driveletter = availableDriveLetters(3)

#End Region

        Dim command As String = "net use " & import_driveletter & ": \\" & Mainserverip & "\import_share " & net_password & " " & net_username

        cmd_process(command, "", False)

        command = "net use " & project_driveletter & ": \\" & Mainserverip & "\project_share " & net_password & " " & net_username

        cmd_process(command, "", False)

        command = "net use " & music_import_driveletter & ": \\" & Mainserverip & "\music_import_share " & net_password & " " & net_username

        cmd_process(command, "", False)

        command = "net use " & music_pool_driveletter & ": \\" & Mainserverip & "\music_pool_share " & net_password & " " & net_username

        cmd_process(command, "", False)

    End Sub

    Private Function cmd_process(command As String, arguments As String, permanent As Boolean) As Boolean

        Dim p As Process = New Process()
        Dim pi As ProcessStartInfo = New ProcessStartInfo()
        pi.Arguments = " " + If(permanent = True, "/K", "/C") + " " + command + " " + arguments
        pi.FileName = "cmd.exe"
        pi.WindowStyle = ProcessWindowStyle.Hidden
        p.StartInfo = pi
        p.Start()

        Return True

    End Function

    Private Function premiere_process(arguments As String) As Boolean


        Dim pi As ProcessStartInfo = New ProcessStartInfo()
        pi.Arguments = " " + arguments
        pi.FileName = "C:\Program Files\Adobe\Adobe Premiere Pro CS6\Adobe Premiere Pro.exe"
        pi.WindowStyle = ProcessWindowStyle.Normal
        premiereProcess.StartInfo = pi
        premiereProcess.EnableRaisingEvents = True
        premiereProcess.Start()

        Return True

    End Function

    Private Sub openinPremiere_Click(sender As Object, e As EventArgs) Handles openinPremiere.Click
        Dim selected_Projectname As String
        Dim projectid As Integer

        Dim index As String

        Try

            index = LVPro.SelectedItems(0).SubItems(0).Text

        Catch ex As Exception

            MessageBox.Show("Bitte Projekt auswählen!")
            Exit Sub

        End Try

        selected_Projectname = LVPro.SelectedItems.Item(0).SubItems.Item(1).Text
        'projectid = LVPro.SelectedItems.Item(0).SubItems.Item(0).Text

        projectid = Convert.ToInt32(LVPro.SelectedItems(0).SubItems(0).Text)

        Dim command As String = project_driveletter & ":\" & String.Format("{0:000}", projectid) & "\projectfiles\" & selected_Projectname & ".prproj"

        premiere_process(command)

    End Sub

    Private Sub openPremiere_Click(sender As Object, e As EventArgs) Handles openPremiere.Click

        openinPremiere.Enabled = True


        premiere_process("")

    End Sub

    Private Sub BTFolderOpen_click(sender As Object, e As EventArgs) Handles BTFolderOpen.Click

        Dim selitemlv As String = ""

        For Each SelItem As ListViewItem In LVPro.SelectedItems

            selitemlv = SelItem.Text

            Exit For

        Next


        For Each projectrow As database.projectsRow In Database1.projects

            'If projectrow.ID.ToString = selitemlv Then

            Process.Start("explorer.exe", project_driveletter & ":\" & Format(projectrow.ID, "000") & """")

            'End If

        Next

    End Sub

    Private Sub premiereClosed() Handles premiereProcess.Exited

        Me.Invoke(Sub() Label1.Text = "AHHH")

    End Sub

    Public Function save_database() As Boolean

        Dim baum As Integer = 0

        Do

            Try

                Database1.WriteXml(tempfile.FullName)
                baum = 1
                Return True

            Catch ex As Exception

            End Try

        Loop Until baum = 1

        Return False

    End Function

    Private Sub Hauptscreen_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyData = Keys.F5 Then

            message_to_server("refresh")

        End If

    End Sub

    Private Sub LVPro_MouseDown(sender As Object, e As MouseEventArgs) Handles LVPro.MouseDown

        If e.Button = MouseButtons.Left Then

            If e.Clicks = 2 Then

                Dim id As String = ""

                Try

                    id = LVPro.SelectedItems(0).SubItems(0).Text

                Catch ex As Exception

                End Try

                Projectpage.id_for_pr = id

                Projectpage.Show()

            End If

        End If

    End Sub

End Class