Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class create

    Public ip As String = Hauptscreen.Mainserverip
    Public Username As String = Hauptscreen.MainUsername
    Public password As String = Hauptscreen.MainHashedPassword
    Dim groupid As String = "0"
    Dim newPassword As String
    Dim newsalt As String

    Dim temppath As New DirectoryInfo(Path.GetTempPath & "\FCS\Client\")
    Dim tempfile As New FileInfo(temppath.FullName & "database.dafcs")

    Public mode As Integer = 0
    Public context As Boolean = False

    Private Sub CBMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMode.SelectedIndexChanged

        mode = CBMode.SelectedIndex

        change_mode()

    End Sub

    Private Sub change_mode()

        LName.Visible = False
        TBName.Visible = False
        LDesc.Visible = False
        TBDesc.Visible = False
        LCat.Visible = False
        CBCat.Visible = False
        LPass.Visible = False
        TBPass.Visible = False
        CBActive.Visible = False
        LPermissions.Visible = False
        CLBPermissions.Visible = False
        LCat.Text = "Kategorie"
        BTAboard.Visible = True
        BTCreate.Visible = True
        CBCat.Items.Clear()
        CBAdmin.Visible = False
        LTemplate.Visible = False
        TVTemplates.Visible = False
        Me.Width = 550


        Select Case True
            Case CBMode.SelectedIndex = 0
                LName.Visible = True
                TBName.Visible = True
                LDesc.Visible = True
                TBDesc.Visible = True
                LCat.Visible = True
                CBCat.Visible = True
                LTemplate.Visible = True
                TVTemplates.Visible = True

                Me.Width = 1088

                Dim i As Integer = 0

                Do Until Database1.category.Count = i

                    CBCat.Items.Add(Database1.category.Rows(i)(1))

                    i += 1

                Loop

                If CBCat.Items.Count = 0 Then

                    CBCat.Items.Add("Keine Kategorien Vorhanden")

                End If

#Region "TreeNodes"

                For Each groupRow As database.template_groupsRow In Database1.template_groups
                    Dim TVItem As TreeNode

                    TVItem = TVTemplates.Nodes.Add(groupRow.Name)

                    For Each templaterow As database.templatesRow In Database1.templates
                        Dim TVItem1 As TreeNode

                        If templaterow.Group = groupRow.Name Then

                            TVItem1 = TVItem.Nodes.Add(templaterow.Name)

                        End If

                    Next

                Next

#End Region

            Case CBMode.SelectedIndex = 1
                LName.Visible = True
                TBName.Visible = True
                LDesc.Visible = True
                TBDesc.Visible = True

            Case CBMode.SelectedIndex = 2
                LName.Visible = True
                TBName.Visible = True
                LDesc.Visible = True
                TBDesc.Visible = True

            Case CBMode.SelectedIndex = 3
                LName.Visible = True
                TBName.Visible = True
                LPass.Visible = True
                TBPass.Visible = True
                LCat.Text = "Benutzergruppe"
                LCat.Visible = True
                CBCat.Visible = True
                CBActive.Visible = True
                CBAdmin.Visible = True

                Dim i As Integer = 0

                Do Until Database1.Usergroup.Count = i

                    CBCat.Items.Add(Database1.Usergroup.Rows(i)(1))

                    i += 1

                Loop

                If CBCat.Items.Count = 0 Then

                    CBCat.Items.Add("Keine Benutzergruppen Vorhanden")

                End If

            Case CBMode.SelectedIndex = 4
                LName.Visible = True
                TBName.Visible = True
                LDesc.Visible = True
                TBDesc.Visible = True
                LPermissions.Visible = True
                CLBPermissions.Visible = True

        End Select

        context = False

    End Sub

    Private Sub BTAboard_Click(sender As Object, e As EventArgs) Handles BTAboard.Click

        Me.Close()

    End Sub

    Private Sub create_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mainloc As Point = Hauptscreen.Location

        Me.Location = New Point(mainloc.X + 1063, mainloc.Y)

        Database1.ReadXml(tempfile.FullName)

        If context = True Then

            CBMode.SelectedIndex = mode

            change_mode()

        End If

    End Sub

    Private Function permissionsummary() As String
        Dim permissionarray As New ArrayList
        Dim permission As String = ""

#Region "nullen eifügen"

        permissionarray.Add("0") '0
        permissionarray.Add("0") '1
        permissionarray.Add("0") '2
        permissionarray.Add("0") '3
        permissionarray.Add("0") '4
        permissionarray.Add("0") '5
        permissionarray.Add("0") '6
        permissionarray.Add("0") '7
        permissionarray.Add("0") '8
        permissionarray.Add("0") '9
        permissionarray.Add("0") '10
        permissionarray.Add("0") '11
        permissionarray.Add("0") '12
        permissionarray.Add("0") '13
        permissionarray.Add("0") '14
        permissionarray.Add("0") '15
        permissionarray.Add("0") '16
        permissionarray.Add("0") '17
        permissionarray.Add("0") '18
        permissionarray.Add("0") '19
        permissionarray.Add("0") '20
        permissionarray.Add("0") '21
        permissionarray.Add("0") '22
        permissionarray.Add("0") '23
        permissionarray.Add("0") '24
        permissionarray.Add("0") '25
        permissionarray.Add("0") '26

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

        Return permission
    End Function

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

    Private Sub BTCreate_Click(sender As Object, e As EventArgs) Handles BTCreate.Click

        Me.Validate(True)

        Dim catindex As Integer = 0

        Dim groupindex As Integer = 0

        Dim templateid As Integer = -0

        Try

            For Each templaterow As database.templatesRow In Database1.templates

                If templaterow.Name = TVTemplates.SelectedNode.Text Then

                    templateid = templaterow.ID

                    Exit For
                End If

            Next

        Catch ex As Exception

        End Try


        If CBMode.SelectedIndex = 0 Then

#Region "CatAbfrage"

            Dim abfrage As String = "Name = '" & CBCat.SelectedItem.ToString & "'"

            Dim foundrows() As DataRow

            foundrows = Database1.category.Select(abfrage)

            Dim i As Integer

            For i = 0 To foundrows.GetUpperBound(0)

                catindex = Convert.ToInt32(foundrows(i)(0))

                Exit For

            Next

#End Region

            Hauptscreen.client.SendMessage(ip, Convert.ToInt32(My.Settings.Port), Username & ";" & password & ";createProject;" & TBName.Text & ";" & catindex.ToString & ";" & TBDesc.Text & ";" & templateid)

        ElseIf CBMode.SelectedIndex = 1 Then

            Hauptscreen.client.SendMessage(ip, Convert.ToInt32(My.Settings.Port), Username & ";" & password & ";createCategory;" & TBName.Text & ";" & TBDesc.Text)

        ElseIf CBMode.SelectedIndex = 2 Then

            Hauptscreen.client.SendMessage(ip, Convert.ToInt32(My.Settings.Port), Username & ";" & password & ";createCamera;" & TBName.Text & ";" & TBDesc.Text)

        ElseIf CBMode.SelectedIndex = 3 Then

#Region "GroupAbfrage"

            Dim abfrage As String = "Name = '" & CBCat.SelectedItem.ToString & "'"

            Dim foundrows() As DataRow

            foundrows = Database1.Usergroup.Select(abfrage)

            Dim i As Integer

            For i = 0 To foundrows.GetUpperBound(0)

                groupindex = Convert.ToInt32(foundrows(i)(0))

                Exit For

            Next

#End Region

            Hauptscreen.client.SendMessage(ip, Convert.ToInt32(My.Settings.Port), Username & ";" & password & ";createUser;" & TBName.Text & ";" & create_salt(TBPass.Text) & ";" & newsalt & ";" & groupindex.ToString & ";" & CBActive.Checked.ToString & ";" & CBAdmin.Checked.ToString)

        ElseIf CBMode.SelectedIndex = 4 Then

            Hauptscreen.client.SendMessage(ip, Convert.ToInt32(My.Settings.Port), Username & ";" & password & ";createGroup;" & TBName.Text & ";" & TBDesc.Text & ";" & permissionsummary())

        End If

        Me.Close()

    End Sub

    Private Sub TVTemplates_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TVTemplates.AfterSelect

        For Each templaterow As database.templatesRow In Database1.templates

            If templaterow.Name = e.Node.Text Then

                TBInfo.Text = templaterow.Info

                Exit For
            End If

        Next

    End Sub

End Class