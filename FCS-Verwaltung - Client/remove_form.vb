Imports System.IO

Public Class remove_form

    Public ip As String = Hauptscreen.Mainserverip
    Public Username As String = Hauptscreen.MainUsername
    Public password As String = Hauptscreen.MainHashedPassword

    Public context As Boolean = False

    Public id_to_remove_Pro As Integer = -1
    Public id_to_remove_Cat As Integer = -1
    Public id_to_remove_Cam As Integer = -1
    Public id_to_remove_Usr As Integer = -1
    Public id_to_remove_UsG As Integer = -1

    Dim temppath As New DirectoryInfo(Path.GetTempPath & "\FCS\Client\")
    Dim tempfile As New FileInfo(temppath.FullName & "database.dafcs")

    Public mode As Integer = 0

    Private Sub remove_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mainloc As Point = Hauptscreen.Location

        Me.Location = New Point(mainloc.X + 1063, mainloc.Y)

        Database1.ReadXml(tempfile.FullName)

        If context = True Then

            CBMode.SelectedIndex = mode

            change_mode()

        End If

    End Sub

    Private Sub CBMode_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CBMode.SelectionChangeCommitted

        mode = CBMode.SelectedIndex

        change_mode()

    End Sub

    Private Sub BTDel_Click(sender As Object, e As EventArgs) Handles BTDel.Click

        Me.Validate()

        Try
            If CBName.SelectedItem.ToString = "" Then

            End If

        Catch ex As Exception

            Exit Sub

        End Try

        Dim id As String

        Dim result As DialogResult = MessageBox.Show("Sind Sie sicher, dass sie " & CBName.SelectedItem.ToString & " löschen wollen?", "Sind sie sicher?", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If result = DialogResult.No Then

            Exit Sub

        ElseIf result = DialogResult.Yes Then

            If mode = 0 Then

                For Each row As database.projectsRow In Database1.projects.Rows

                    If row.Name = CBName.SelectedItem.ToString Then

                        id = row.ID.ToString

                    End If

                Next

                Hauptscreen.client.SendMessage(ip, Convert.ToInt32(My.Settings.Port), Username & ";" & password & ";deleteProject;" & CBName.SelectedItem.ToString & ";" & id)

            ElseIf mode = 1 Then

                For Each row As database.categoryRow In Database1.category.Rows

                    If row.Name = CBName.SelectedItem.ToString Then

                        id = row.ID.ToString

                    End If

                Next

                Hauptscreen.client.SendMessage(ip, Convert.ToInt32(My.Settings.Port), Username & ";" & password & ";deleteCategory;" & CBName.SelectedItem.ToString & ";" & id)

            ElseIf mode = 2 Then

                For Each row As database.cameraRow In Database1.camera.Rows

                    If row.Name = CBName.SelectedItem.ToString Then

                        id = row.ID.ToString

                    End If

                Next

                Hauptscreen.client.SendMessage(ip, Convert.ToInt32(My.Settings.Port), Username & ";" & password & ";deleteCamera;" & CBName.SelectedItem.ToString & ";" & id)

            ElseIf mode = 3 Then

                For Each row As database.UserRow In Database1.User.Rows

                    If row.Name = CBName.SelectedItem.ToString Then

                        id = row.ID.ToString

                    End If

                Next

                Hauptscreen.client.SendMessage(ip, Convert.ToInt32(My.Settings.Port), Username & ";" & password & ";deleteUser;" & CBName.SelectedItem.ToString & ";" & id)

            Else

                For Each row As database.UsergroupRow In Database1.Usergroup.Rows

                    If row.Name = CBName.SelectedItem.ToString Then

                        id = row.ID.ToString

                    End If

                Next

                Hauptscreen.client.SendMessage(ip, Convert.ToInt32(My.Settings.Port), Username & ";" & password & ";deleteGroup;" & CBName.SelectedItem.ToString & ";" & id)

            End If

        End If

        Me.Close()

    End Sub

    Private Sub change_mode()

        Dim i As Integer = 0

        LName.Visible = False


        CBName.Visible = False
        CBName.Items.Clear()
        CBName.ResetText()

        '###Combobox###

        If mode = 0 Then

            LName.Visible = True
            CBName.Visible = True

            Do Until i = Database1.projects.Rows.Count

                CBName.Items.Add(Database1.projects.Rows.Item(i)(1))

                i += 1

            Loop

        ElseIf mode = 1 Then

            LName.Visible = True
            CBName.Visible = True

            Do Until i = Database1.category.Rows.Count

                CBName.Items.Add(Database1.category.Rows.Item(i)(1))

                i += 1

            Loop

        ElseIf mode = 2 Then

            LName.Visible = True
            CBName.Visible = True

            Do Until i = Database1.camera.Rows.Count

                CBName.Items.Add(Database1.camera.Rows.Item(i)(1))

                i += 1

            Loop

        ElseIf mode = 3 Then

            LName.Visible = True
            CBName.Visible = True

            Do Until i = Database1.User.Rows.Count

                CBName.Items.Add(Database1.User.Rows.Item(i)(1))

                i += 1

            Loop

        ElseIf mode = 4 Then

            LName.Visible = True
            CBName.Visible = True

            Do Until i = Database1.Usergroup.Rows.Count

                CBName.Items.Add(Database1.Usergroup.Rows.Item(i)(1))

                i += 1

            Loop

        End If

        '###Context###

        Dim name As String = ""

        If context = True Then

            If id_to_remove_Pro <> -1 Then

                For Each row As database.projectsRow In Database1.projects

                    If row.ID = id_to_remove_Pro Then

                        name = row.Name

                        Exit For

                    End If

                Next

            ElseIf id_to_remove_Cat <> -1 Then

                For Each row As database.categoryRow In Database1.category

                    If row.ID = id_to_remove_Cat Then

                        name = row.Name

                        Exit For

                    End If

                Next

            ElseIf id_to_remove_Cam <> -1 Then

                For Each row As database.cameraRow In Database1.camera

                    If row.ID = id_to_remove_Cam Then

                        name = row.Name

                        Exit For

                    End If

                Next

            ElseIf id_to_remove_Usr <> -1 Then

                For Each row As database.UserRow In Database1.User

                    If row.ID = id_to_remove_Usr Then

                        name = row.Name

                        Exit For

                    End If

                Next

            ElseIf id_to_remove_UsG <> -1 Then

                For Each row As database.UsergroupRow In Database1.Usergroup

                    If row.ID = id_to_remove_UsG Then

                        name = row.Name

                        Exit For

                    End If

                Next

            End If

            context = False

        End If

        If name <> "" Then CBName.SelectedIndex = CBName.Items.IndexOf(name)

    End Sub

End Class
