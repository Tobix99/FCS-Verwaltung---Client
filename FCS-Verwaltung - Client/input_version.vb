Public Class input_version

    Public ip As String = Hauptscreen.Mainserverip
    Public Username As String = Hauptscreen.MainUsername
    Public password As String = Hauptscreen.MainHashedPassword


    Private Sub input_version_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim version As String = Hauptscreen.currentversion

        Dim tempveri() As String = version.Split(CChar("."))

        TB1.Text = tempveri(0)

        TB2.Text = tempveri(1)

        TB3.Text = tempveri(2)

        Label4.Text = Hauptscreen.version

        Label5.Text = Hauptscreen.currentversion

    End Sub

    Private Sub BTSave_Click(sender As Object, e As EventArgs) Handles BTSave.Click

        Hauptscreen.client.SendMessage(ip, Convert.ToInt32(My.Settings.Port), Username & ";" & password & ";setVersion;" & TB1.Text & "." & TB2.Text & "." & TB3.Text)

        Me.Close()

    End Sub

End Class