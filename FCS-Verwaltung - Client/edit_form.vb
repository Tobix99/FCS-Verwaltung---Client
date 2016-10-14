Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class edit_form

    Public ip As String = Hauptscreen.Mainserverip
    Public Username As String = Hauptscreen.MainUsername
    Public password As String = Hauptscreen.MainHashedPassword

    Dim newsalt As String
    Public context As Boolean = False

    Dim temppath As New DirectoryInfo(Path.GetTempPath & "\FCS\Client\")
    Dim tempfile As New FileInfo(temppath.FullName & "database.dafcs")

    Public mode As Integer = 0
    Private mode1 As Integer = 0

    Public id_to_edit_Pro As Integer = -1
    Public id_to_edit_Cat As Integer = -1
    Public id_to_edit_Cam As Integer = -1
    Public id_to_edit_Usr As Integer = -1
    Public id_to_edit_UsG As Integer = -1

    Private Sub edit_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mainloc As Point = Hauptscreen.Location

        Me.Location = New Point(mainloc.X + 1063, mainloc.Y)

        Database1.ReadXml(tempfile.FullName)

        If Hauptscreen.admin = True Then

            CBAdmin.Enabled = True

        Else

            CBAdmin.Enabled = False

        End If

        If context = True Then

            CBMode.SelectedIndex = mode

            change_mode()

        End If

    End Sub

    Private Sub CBMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMode.SelectionChangeCommitted

        mode = CBMode.SelectedIndex

        change_mode()

    End Sub

    Private Sub change_mode()

        Label2.Visible = False
        Label3.Visible = False
        Label3.Text = "Kategorie"
        Label4.Visible = False
        Label6.Visible = False

        CBName.Visible = False
        CBName.Items.Clear()
        CBName.ResetText()

        CBCat.Visible = False
        CBCat.Items.Clear()
        CBCat.ResetText()

        CBArchived.Text = "Archiviert"
        CBArchived.Visible = False

        CBAdmin.Visible = False

        TBBeschreibung.Visible = False
        TBBeschreibung.Text = ""
        BTSave.Visible = False

        TBNewName.Visible = False
        TBNewName.Text = ""
        BTNewName.Visible = False

        TBPw.Visible = False
        TBPw.Text = ""
        BTNewPw.Visible = False

        LPermissions.Visible = False
        CLBPermissions.Visible = False
        BTPerSave.Visible = False

        Dim i As Integer = 0

        If mode = 0 Then

            mode1 = 0

            Do Until i = Database1.projects.Rows.Count

                CBName.Items.Add(Database1.projects.Rows.Item(i)(1))

                i += 1

            Loop

            Label2.Visible = True
            CBName.Visible = True
            Label3.Visible = True
            CBCat.Visible = True
            Label4.Visible = True
            TBBeschreibung.Visible = True
            BTSave.Visible = True
            TBNewName.Visible = True
            BTNewName.Visible = True
            CBArchived.Visible = True

        ElseIf mode = 1 Then

            mode1 = 1

            Do Until i = Database1.category.Rows.Count

                CBName.Items.Add(Database1.category.Rows.Item(i)(1))

                i += 1

            Loop

            Label2.Visible = True
            CBName.Visible = True
            Label4.Visible = True
            TBBeschreibung.Visible = True
            BTSave.Visible = True
            Label5.Visible = True
            TBNewName.Visible = True
            BTNewName.Visible = True

        ElseIf mode = 2 Then

            mode1 = 2

            Do Until i = Database1.camera.Rows.Count

                CBName.Items.Add(Database1.camera.Rows.Item(i)(1))

                i += 1

            Loop

            Label2.Visible = True
            CBName.Visible = True
            Label4.Visible = True
            TBBeschreibung.Visible = True
            BTSave.Visible = True
            TBNewName.Visible = True
            BTNewName.Visible = True

        ElseIf mode = 3 Then

            mode1 = 3

            Do Until i = Database1.User.Rows.Count

                CBName.Items.Add(Database1.User.Rows.Item(i)(1))

                i += 1

            Loop

            Label2.Visible = True
            CBName.Visible = True
            Label5.Visible = True
            TBNewName.Visible = True
            BTNewName.Visible = True
            Label3.Visible = True
            Label3.Text = "Benutzergruppe"
            CBCat.Visible = True
            TBPw.Visible = True
            Label6.Visible = True
            BTNewPw.Visible = True
            CBArchived.Visible = True
            CBArchived.Text = "Aktiviert"
            CBAdmin.Visible = True

        ElseIf mode = 4 Then

            mode1 = 4

            Do Until i = Database1.Usergroup.Rows.Count

                CBName.Items.Add(Database1.Usergroup.Rows.Item(i)(1))

                i += 1

            Loop

            Label2.Visible = True
            CBName.Visible = True
            Label4.Visible = True
            TBBeschreibung.Visible = True
            BTSave.Visible = True
            TBNewName.Visible = True
            BTNewName.Visible = True
            Label5.Visible = True
            LPermissions.Visible = True
            CLBPermissions.Visible = True
            BTPerSave.Visible = True

        End If

        '###Context###

        Dim name As String = ""

        If context = True Then

            If id_to_edit_Pro <> -1 Then

                For Each row As database.projectsRow In Database1.projects

                    If row.ID = id_to_edit_Pro Then

                        name = row.Name

                        Exit For

                    End If

                Next

            ElseIf id_to_edit_Cat <> -1 Then

                For Each row As database.categoryRow In Database1.category

                    If row.ID = id_to_edit_Cat Then

                        name = row.Name

                        Exit For

                    End If

                Next

            ElseIf id_to_edit_Cam <> -1 Then

                For Each row As database.cameraRow In Database1.camera

                    If row.ID = id_to_edit_Cam Then

                        name = row.Name

                        Exit For

                    End If

                Next

            ElseIf id_to_edit_Usr <> -1 Then

                For Each row As database.UserRow In Database1.User

                    If row.ID = id_to_edit_Usr Then

                        name = row.Name

                        Exit For

                    End If

                Next

            ElseIf id_to_edit_UsG <> -1 Then

                For Each row As database.UsergroupRow In Database1.Usergroup

                    If row.ID = id_to_edit_UsG Then

                        name = row.Name

                        Exit For

                    End If

                Next

            End If

            context = False

        End If

        If name <> "" Then CBName.SelectedIndex = CBName.Items.IndexOf(name)

    End Sub

    Private Sub CBName_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CBName.SelectedIndexChanged

        CBCat.Items.Clear()

        If mode1 = 0 Then

            For Each cate As DataRow In Database1.category.Rows

                CBCat.Items.Add(cate(1))

            Next

#Region "selectcat"

            Dim catid As String = "0"

            Dim abfrage As String = "Name = '" & CBName.SelectedItem.ToString & "'"

            Dim foundrows() As DataRow

            foundrows = Database1.projects.Select(abfrage)

            For i = 0 To foundrows.GetUpperBound(0)

                catid = foundrows(i)(2).ToString

                TBBeschreibung.Text = foundrows(i)(3).ToString

                If foundrows(i)(4).Equals("Ja") Then

                    CBArchived.Checked = True

                Else

                    CBArchived.Checked = False

                End If

                CBCat.SelectedItem = foundrows(i)(5).ToString

                Exit For

            Next

#End Region

        ElseIf mode1 = 1 Then

            Dim abfrage As String = "Name = '" & CBName.SelectedItem.ToString & "'"

            Dim foundrows() As DataRow

            foundrows = Database1.category.Select(abfrage)

            For i = 0 To foundrows.GetUpperBound(0)

                TBBeschreibung.Text = foundrows(i)(2).ToString

                Exit For

            Next

        ElseIf mode1 = 2 Then

            Dim abfrage As String = "Name = '" & CBName.SelectedItem.ToString & "'"

            Dim foundrows() As DataRow

            foundrows = Database1.camera.Select(abfrage)

            For i = 0 To foundrows.GetUpperBound(0)

                TBBeschreibung.Text = foundrows(i)(2).ToString

                Exit For

            Next

        ElseIf mode1 = 3 Then

            For Each usergroup As DataRow In Database1.Usergroup.Rows

                CBCat.Items.Add(usergroup(1))

            Next

#Region "selectusergroup"

            Dim usergrID As String = "0"

            Dim abfrage As String = "Name = '" & CBName.SelectedItem.ToString & "'"

            Dim foundrows() As DataRow

            foundrows = Database1.User.Select(abfrage)

            For i = 0 To foundrows.GetUpperBound(0)

                usergrID = foundrows(i)(2).ToString

                If foundrows(i)(3).Equals("Ja") Then

                    CBArchived.Checked = True

                Else

                    CBArchived.Checked = False

                End If

                If foundrows(i)(5).Equals("Ja") Then

                    CBAdmin.Checked = True

                Else

                    CBAdmin.Checked = False

                End If

                CBCat.SelectedItem = foundrows(i)(4).ToString

                Exit For

            Next

#End Region

        ElseIf mode1 = 4 Then

            Dim abfrage As String = "Name = '" & CBName.SelectedItem.ToString & "'"

            Dim foundrows() As DataRow

            foundrows = Database1.Usergroup.Select(abfrage)

            For i = 0 To foundrows.GetUpperBound(0)

                TBBeschreibung.Text = foundrows(i)(2).ToString

#Region "check_boxes"

                Dim tempper As String = foundrows(i)(3).ToString

                Dim temppersplit As String() = tempper.Split(CChar(":"))

                For Each permission As String In temppersplit

                    If permission = "1" Then

                        CLBPermissions.SetItemChecked(i, True)

                    ElseIf permission = "0" Then

                        CLBPermissions.SetItemChecked(i, False)

                    End If

                    i += 1

                Next

#End Region

                Exit For

            Next

        End If

    End Sub

    Private Sub CBCat_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CBCat.SelectionChangeCommitted

        If mode = 0 Then

            Dim catid As String = "0"

#Region "cbcat_to_ID"

            Dim abfrage As String = "Name = '" & CBCat.SelectedItem.ToString & "'"

            Dim foundrows() As DataRow

            foundrows = Database1.category.Select(abfrage)

            Dim i As Integer

            For i = 0 To foundrows.GetUpperBound(0)

                catid = foundrows(i)(0).ToString

                Exit For

            Next

#End Region

            Hauptscreen.client.SendMessage(ip, Convert.ToInt32(My.Settings.Port), Username & ";" & password & ";editProject;" & CBName.SelectedItem.ToString & ";2;" & catid)


        ElseIf mode = 3 Then

            Dim groupid As String = "0"

#Region "cbcat_to_ID"

            Dim abfrage As String = "Name = '" & CBCat.SelectedItem.ToString & "'"

            Dim foundrows() As DataRow

            foundrows = Database1.Usergroup.Select(abfrage)

            Dim i As Integer

            For i = 0 To foundrows.GetUpperBound(0)

                groupid = foundrows(i)(0).ToString

                Exit For

            Next

#End Region

            Hauptscreen.client.SendMessage(ip, Convert.ToInt32(My.Settings.Port), Username & ";" & password & ";editUser;" & CBName.SelectedItem.ToString & ";4;" & groupid)


        End If



    End Sub

    Private Sub CBArchived_CheckedChanged(sender As Object, e As EventArgs) Handles CBArchived.MouseClick

        If mode = 0 Then

            If CBArchived.Checked Then

                Hauptscreen.client.SendMessage(ip, Convert.ToInt32(My.Settings.Port), Username & ";" & password & ";editProject;" & CBName.SelectedItem.ToString & ";5;True")

            Else

                Hauptscreen.client.SendMessage(ip, Convert.ToInt32(My.Settings.Port), Username & ";" & password & ";editProject;" & CBName.SelectedItem.ToString & ";5;False")

            End If


        ElseIf mode = 3 Then

            If CBArchived.Checked Then

                Hauptscreen.client.SendMessage(ip, Convert.ToInt32(My.Settings.Port), Username & ";" & password & ";editUser;" & CBName.SelectedItem.ToString & ";5;True")

            Else

                Hauptscreen.client.SendMessage(ip, Convert.ToInt32(My.Settings.Port), Username & ";" & password & ";editUser;" & CBName.SelectedItem.ToString & ";5;False")

            End If

        End If

    End Sub

    Private Sub BTSave_Click(sender As Object, e As EventArgs) Handles BTSave.MouseClick

        If mode = 0 Then

            Hauptscreen.client.SendMessage(ip, Convert.ToInt32(My.Settings.Port), Username & ";" & password & ";editProject;" & CBName.SelectedItem.ToString & ";3;" & TBBeschreibung.Text)


        ElseIf mode = 1 Then

            Hauptscreen.client.SendMessage(ip, Convert.ToInt32(My.Settings.Port), Username & ";" & password & ";editCategory;" & CBName.SelectedItem.ToString & ";2;" & TBBeschreibung.Text)

        ElseIf mode = 2 Then

            Hauptscreen.client.SendMessage(ip, Convert.ToInt32(My.Settings.Port), Username & ";" & password & ";editCamera;" & CBName.SelectedItem.ToString & ";2;" & TBBeschreibung.Text)

        ElseIf mode = 4 Then

            Hauptscreen.client.SendMessage(ip, Convert.ToInt32(My.Settings.Port), Username & ";" & password & ";editGroup;" & CBName.SelectedItem.ToString & ";2;" & TBBeschreibung.Text)

        End If

    End Sub

    Private Sub BTNewName_Click(sender As Object, e As EventArgs) Handles BTNewName.Click

        If mode = 0 Then

            Hauptscreen.client.SendMessage(ip, Convert.ToInt32(My.Settings.Port), Username & ";" & password & ";editProject;" & CBName.SelectedItem.ToString & ";1;" & TBNewName.Text)

        ElseIf mode = 1 Then

            Hauptscreen.client.SendMessage(ip, Convert.ToInt32(My.Settings.Port), Username & ";" & password & ";editCategory;" & CBName.SelectedItem.ToString & ";1;" & TBNewName.Text)

        ElseIf mode = 2 Then

            Hauptscreen.client.SendMessage(ip, Convert.ToInt32(My.Settings.Port), Username & ";" & password & ";editCamera;" & CBName.SelectedItem.ToString & ";1;" & TBNewName.Text)

        ElseIf mode = 3 Then

            Hauptscreen.client.SendMessage(ip, Convert.ToInt32(My.Settings.Port), Username & ";" & password & ";editUser;" & CBName.SelectedItem.ToString & ";1;" & TBNewName.Text)

        ElseIf mode = 4 Then

            Hauptscreen.client.SendMessage(ip, Convert.ToInt32(My.Settings.Port), Username & ";" & password & ";editGroup;" & CBName.SelectedItem.ToString & ";1;" & TBNewName.Text)

        End If

        Close()

    End Sub

    Private Sub BTPerSave_Click(sender As Object, e As EventArgs) Handles BTPerSave.Click

        Dim permissionarray As New ArrayList
        Dim permission As String = ""

#Region "nullen eifügen"

        permissionarray.Add("0")
        permissionarray.Add("0")
        permissionarray.Add("0")
        permissionarray.Add("0")
        permissionarray.Add("0")
        permissionarray.Add("0")
        permissionarray.Add("0")
        permissionarray.Add("0")
        permissionarray.Add("0")
        permissionarray.Add("0")
        permissionarray.Add("0")
        permissionarray.Add("0")
        permissionarray.Add("0")
        permissionarray.Add("0")
        permissionarray.Add("0")
        permissionarray.Add("0")
        permissionarray.Add("0")
        permissionarray.Add("0")
        permissionarray.Add("0")
        permissionarray.Add("0")
        permissionarray.Add("0")

#End Region

        For Each permissioncheck As Integer In CLBPermissions.CheckedIndices

            permissionarray.RemoveAt(permissioncheck)

            permissionarray.Insert(permissioncheck, "1")

        Next

        For Each item As String In permissionarray
            If permission = "" Then

                permission = item

            Else

                permission = permission & ":" & item

            End If

        Next

        Hauptscreen.client.SendMessage(ip, Convert.ToInt32(My.Settings.Port), Username & ";" & password & ";editGroup;" & CBName.SelectedItem.ToString & ";3;" & permission)

    End Sub

    Private Sub CBAdmin_CheckedChanged(sender As Object, e As EventArgs) Handles CBAdmin.MouseClick

        If mode = 3 Then

            If CBAdmin.Checked Then

                Hauptscreen.client.SendMessage(ip, Convert.ToInt32(My.Settings.Port), Username & ";" & password & ";editUser;" & CBName.SelectedItem.ToString & ";6;True")

            Else

                Hauptscreen.client.SendMessage(ip, Convert.ToInt32(My.Settings.Port), Username & ";" & password & ";editUser;" & CBName.SelectedItem.ToString & ";6;False")

            End If

        End If

    End Sub

    Private Sub BTNewPw_Click(sender As Object, e As EventArgs) Handles BTNewPw.Click

        If mode = 3 Then

            Dim newPw As String = create_salt(TBPw.Text)

            Hauptscreen.client.SendMessage(ip, Convert.ToInt32(My.Settings.Port), Username & ";" & password & ";editUser;" & CBName.SelectedItem.ToString & ";3;" & newsalt)

            Hauptscreen.client.SendMessage(ip, Convert.ToInt32(My.Settings.Port), Username & ";" & password & ";editUser;" & CBName.SelectedItem.ToString & ";2;" & newPw)

        End If

        Close()

    End Sub

    Public Function create_salt(password As String) As String
        Dim hashedResult As String = ""
        newsalt = CreateRandowmSalt()

        Dim convertedToBytes As Byte() = Encoding.UTF8.GetBytes(password & newsalt)
        Dim hashType As HashAlgorithm = New SHA512Managed()
        Dim hashBytes As Byte() = hashType.ComputeHash(convertedToBytes)
        hashedResult = Convert.ToBase64String(hashBytes)

        Return hashedResult

    End Function

    Public Function CreateRandowmSalt() As String

        'the following is the string that will hold the salt charachters

        Dim mix As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+=][}{"

        Dim salt As String = ""

        Dim rnd As New Random

        Dim sb As StringBuilder

        For i As Integer = 1 To 100 'lengt of salt

            Dim x As Integer = rnd.Next(0, mix.Length - 1)

            salt &= (mix.Substring(x, 1))

        Next

        Return salt

    End Function

End Class