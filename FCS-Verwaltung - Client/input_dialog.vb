Public Class input_dialog

    Public mode As Integer = 0

    Private Sub input_dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If mode = 0 Then

            Label1.Text = "Neuer Benutzername:"
            TextBox1.Text = My.Settings.net_username

        ElseIf mode = 1 Then
            Label1.Text = "Neues Passwort:"
            TextBox1.PasswordChar = Convert.ToChar("*")
            TextBox1.Text = "0000"

        ElseIf mode = 2 Then
            Label1.Text = "PC-Name:"
            TextBox1.Text = My.Settings.net_computer

        ElseIf mode = 3 Then
            Label1.Text = "IP:"
            TextBox1.Text = My.Settings.staic_ip_st
            CBStaticIP.Checked = My.Settings.static_ip_bo
            CBStaticIP.Visible = True

        ElseIf mode = 4 Then
            Label1.Text = "Pfad zu Premiere:"
            TextBox1.Text = My.Settings.Premiere_Path

        ElseIf mode = 5 Then
            Label1.Text = "Pfad zu Auditions:"
            TextBox1.Text = My.Settings.Auditions_Path

        End If

        TextBox1.Focus()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If mode = 0 Then

            My.Settings.net_username = TextBox1.Text

        ElseIf mode = 1 Then

            My.Settings.net_password = TextBox1.Text

        ElseIf mode = 2 Then

            My.Settings.net_computer = TextBox1.Text

        ElseIf mode = 3 Then

            My.Settings.staic_ip_st = TextBox1.Text
            My.Settings.static_ip_bo = CBStaticIP.Checked

        ElseIf mode = 4 Then

            My.Settings.Premiere_Path = TextBox1.Text

        ElseIf mode = 5 Then

            My.Settings.Auditions_Path = TextBox1.Text

        End If

        Me.Close()

    End Sub

End Class