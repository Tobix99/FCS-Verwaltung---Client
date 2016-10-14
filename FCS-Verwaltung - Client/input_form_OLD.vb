Option Strict On
Imports System.Collections
Imports System.Security.Cryptography
Imports System.Text

Public Class input_form_OLD
    Public mode As Integer = 0
    Public ip As String = Hauptscreen.Mainserverip
    Public Username As String = Hauptscreen.MainUsername
    Public password As String = Hauptscreen.MainHashedPassword
    Dim groupid As String = "0"
    Dim newPassword As String
    Dim newsalt As String

    Private Sub input_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If ip = "" Then

            MessageBox.Show("Fehler! IP nicht übergeben!", "ERROR", MessageBoxButtons.OK)

            Me.Close()

        End If

        Select Case True
            Case mode = 0
                Me.Text = "Neues Projekt erstellen..."
                LName.Text = "Projektname:"
                LCat.Visible = True
                CBCat.Visible = True

            Case mode = 1
                Me.Text = "Neue Kategorie erstellen..."
                LName.Text = "Kategoriename:"

            Case mode = 2
                Me.Text = "Neue Kamera erstellen..."
                LName.Text = "Kameraname:"

            Case mode = 3
                Me.Text = "Neuen Benutzer erstellen..."
                LName.Text = "Benutzernamenname:"
                LDesc.Visible = False
                TBDesc.Visible = False
                LCat.Visible = True
                CBCat.Visible = True
                LPass.Visible = True
                TBPass.Visible = True
                CBActive.Visible = True
                LCat.Text = "Benutzer-Gruppe"


            Case mode = 4
                Me.Text = "Neue Beutzer-Gruppe erstellen..."
                LName.Text = "Beutzer-Gruppenname:"
                LPermissions.Visible = True
                CLBPermissions.Visible = True

        End Select

    End Sub

    Private Function permissionsummary() As String
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

    Private Sub BTAbort_Click(sender As Object, e As EventArgs) Handles BTAbort.Click

        Me.Close()

    End Sub

    Private Sub BTCreate_Click(sender As Object, e As EventArgs) Handles BTCreate.Click

        Select Case True
            Case mode = 0

                Me.Validate(True)

                Hauptscreen.client.SendMessage(ip, Convert.ToInt32(My.Settings.Port), Username & ";" & password & ";createProject;" & TBName.Text & ";" & groupid & ";" & TBDesc.Text)

                Me.Close()

            Case mode = 1

                Me.Validate(True)

                Hauptscreen.client.SendMessage(ip, Convert.ToInt32(My.Settings.Port), Username & ";" & password & ";createCategory;" & TBName.Text & ";" & TBDesc.Text)

                Me.Close()

            Case mode = 2

                Me.Validate(True)

                Hauptscreen.client.SendMessage(ip, Convert.ToInt32(My.Settings.Port), Username & ";" & password & ";createCamera;" & TBName.Text & ";" & TBDesc.Text)

                Me.Close()

            Case mode = 3

                Me.Validate(True)

                Hauptscreen.client.SendMessage(ip, Convert.ToInt32(My.Settings.Port), Username & ";" & password & ";createUser;" & TBName.Text & ";" & create_salt(TBPass.Text) & ";" & newsalt & ";" & "0" & ";" & CBActive.Checked.ToString)

                Me.Close()

            Case mode = 4

                Me.Validate(True)

                Hauptscreen.client.SendMessage(ip, Convert.ToInt32(My.Settings.Port), Username & ";" & password & ";createGroup;" & TBName.Text & ";" & TBDesc.Text & ";" & permissionsummary())

                Me.Close()

        End Select

        Me.Close()

    End Sub
End Class