Imports TobixLibs.Net
Imports System.Security.Cryptography
Imports System.Text

Public Class Login

    Dim WithEvents Server As ServerClass
    Dim client As New ClientClass
    Public ServerIp As String = ""
    Public port As Integer = Convert.ToInt32(My.Settings.Port)
    Private Username As String = ""
    Private Passwort As String = ""
    Private Passworthash As String = ""
    Private salt As String = ""
    Dim tempip As String = ""
    Dim static_ip_bo As Boolean = My.Settings.static_ip_bo
    Dim static_ip_st As String = My.Settings.staic_ip_st

    Dim admincount As Integer = 0

    Private Sub BTLogin_Click(sender As Object, e As EventArgs) Handles BTLogin.Click

        BTLogin.Enabled = False

        ServerIp = TBServerIP.Text
        Username = TBUs.Text
        Passwort = MTBPass.Text

        Try

            client.SendMessage(ServerIp, port, Username & ";123;salt")

        Catch ex As Exception

            If MessageBox.Show("IP nicht gefunden!", "Fehler!", MessageBoxButtons.OK) = DialogResult.OK Then

                BTLogin.Enabled = True

            End If

        End Try

    End Sub

    Private Function md5_hash(password As String) As String

        Dim hashedResult As String = ""

        Dim convertedToBytes As Byte() = Encoding.UTF8.GetBytes(password & salt)
        Dim hashType As HashAlgorithm = New SHA512Managed()
        Dim hashBytes As Byte() = hashType.ComputeHash(convertedToBytes)
        hashedResult = Convert.ToBase64String(hashBytes)

        Return hashedResult

    End Function

    Private Sub login_send()

        Passworthash = md5_hash(Passwort)

        Try

            client.SendMessage(ServerIp, port, Username & ";" & Passworthash & ";login")

        Catch ex As Exception

            If MessageBox.Show("IP nicht gefunden!", "Fehler!", MessageBoxButtons.OK) = DialogResult.OK Then



            End If

        End Try

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.KeyPreview = True

        firewall()

        'not needed --> User can't see Drive, but Programm can see it --> elevated right's .... :DD
        'change_drive_mapping()

        Server = New ServerClass(port, True, static_ip_bo, static_ip_st)
        'Server = New ServerClass(port, True, true, "192.168.178.72")

        Server.StartServer()

    End Sub

    Private Sub change_drive_mapping()

        Dim readValue As String

        Try

            readValue = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", "EnableLinkedConnections", Nothing).ToString

        Catch ex As Exception

            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", "EnableLinkedConnections", "00000001", Microsoft.Win32.RegistryValueKind.DWord)

            MessageBox.Show("Sie müssen den PC neustarten um das Programm richtig nutzen zu können!", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            Exit Sub

        End Try


        If readValue <> "1" Then

            Dim autoshell = My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", True)
            '' Set the value to 0
            autoshell.SetValue("EnableLinkedConnections", "00000001", Microsoft.Win32.RegistryValueKind.DWord)
            autoshell.Close()

            MessageBox.Show("Sie müssen den PC neustarten um das Programm richtig nutzen zu können!", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        End If



    End Sub

    Private Sub OnIncomingMessage(ByVal Args As ServerClass.InMessEvArgs) Handles Server.IncomingMessage

        Dim DATA As String = Args.message

        Dim senderip As String = Args.senderIP

        Dim array As String() = DATA.Split(CChar(";"))

        Select Case True

            Case array(0) = "salt"
                If array(1) = "false" Then

                    MessageBox.Show("Benutzername und/oder Passwort sind falsch!")

                    Me.Invoke(Sub() BTLogin.Enabled = True)

                    Exit Sub

                End If
                salt = array(1)
                login_send()

            Case array(0) = "logincorrect"
                If array(1) = "true" Then

                    If array(2) = "True" Then

                        Invoke(Sub() Hauptscreen.admin = True)

                    End If

                    Server.StopServer()

                    Invoke(Sub() Hauptscreen.MainUsername = Username)
                    Invoke(Sub() Hauptscreen.MainHashedPassword = Passworthash)
                    Invoke(Sub() Hauptscreen.Mainserverip = ServerIp)
                    Invoke(Sub() Hauptscreen.Show())

                Else

                    MessageBox.Show("Benutzername und/oder Passwort sind falsch!")

                    Me.Invoke(Sub() BTLogin.Enabled = True)

                End If

            Case array(0) = "scan"

                If Not senderip = Server.LocalIP Then

                    Me.Invoke(Sub() LBIP.Items.Add(senderip))

                End If

            Case array(0) = "userdisabled"

                MessageBox.Show("Sie wurden deaktiviert! Wende sie sich für weitere Infos an den Administrator!", "Fehler!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Me.Invoke(Sub() BTLogin.Enabled = True)

        End Select

    End Sub

    Private Sub firewall()

        Dim procStartInfo As New ProcessStartInfo
        Dim cmdpro As New Process

        With procStartInfo
            .UseShellExecute = True
            .FileName = "cmd.exe"
            .WindowStyle = ProcessWindowStyle.Hidden
            .Verb = "runas" 'add this to prompt for elevation
            .Arguments = " /c netsh advfirewall firewall show rule name=""FCS-Verwaltung Client"" || netsh advfirewall firewall add rule name=""FCS-Verwaltung Client"" dir=in action=allow localport=42647 protocol=tcp"
        End With

        Try

            cmdpro = Process.Start(procStartInfo)

        Catch ex As Exception

            Me.Close()

        End Try

    End Sub

    Private Sub BTScan_Click(sender As Object, e As EventArgs) Handles BTScan.Click

        If Not Thread1.IsBusy And Not Thread10.IsBusy Then

            Me.Width = 426
            PBIP.Value = 0
            PBIP.Maximum = 254

            tempip = TBServerIP.Text

            Thread1.RunWorkerAsync()
            Thread2.RunWorkerAsync()
            Thread3.RunWorkerAsync()
            Thread4.RunWorkerAsync()
            Thread5.RunWorkerAsync()
            Thread6.RunWorkerAsync()
            Thread7.RunWorkerAsync()
            Thread8.RunWorkerAsync()
            Thread9.RunWorkerAsync()
            Thread10.RunWorkerAsync()

        End If

    End Sub

    Private Sub performPBstep()

        Me.Invoke(Sub() PBIP.Value += 1)

    End Sub

    Private Sub LBIP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBIP.SelectedIndexChanged

        Try

            If LBIP.SelectedItem.ToString = "" Then

            End If

        Catch ex As Exception

            Exit Sub

        End Try


        If LBIP.SelectedItem.ToString <> "Scan abgeschlossen" Then

            TBServerIP.Text = LBIP.SelectedItem.ToString

        End If

    End Sub

#Region "Thread"

    Private Sub Thread1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Thread1.DoWork

        Dim i As Integer = 0
        Dim iptemp As String() = tempip.Split(CChar("."))
        Dim ip As String = iptemp(0) & "." & iptemp(1) & "." & iptemp(2) & "."

        While i <> 25

            performPBstep()

            i += 1

            Try

                client.SendMessage(ip & i.ToString, port, "scan")

            Catch ex As Exception

            End Try

        End While

    End Sub

    Private Sub Thread2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Thread2.DoWork

        Dim i As Integer = 25
        Dim iptemp As String() = tempip.Split(CChar("."))
        Dim ip As String = iptemp(0) & "." & iptemp(1) & "." & iptemp(2) & "."

        While i <> 50

            performPBstep()

            i += 1

            Try

                client.SendMessage(ip & i.ToString, port, "scan")

            Catch ex As Exception

            End Try

        End While

    End Sub

    Private Sub Thread3_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Thread3.DoWork

        Dim i As Integer = 50
        Dim iptemp As String() = tempip.Split(CChar("."))
        Dim ip As String = iptemp(0) & "." & iptemp(1) & "." & iptemp(2) & "."

        While i <> 75

            performPBstep()

            i += 1

            Try

                client.SendMessage(ip & i.ToString, port, "scan")

            Catch ex As Exception

            End Try

        End While

    End Sub

    Private Sub Thread4_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Thread4.DoWork

        Dim i As Integer = 75
        Dim iptemp As String() = tempip.Split(CChar("."))
        Dim ip As String = iptemp(0) & "." & iptemp(1) & "." & iptemp(2) & "."

        While i <> 100

            performPBstep()

            i += 1

            Try

                client.SendMessage(ip & i.ToString, port, "scan")

            Catch ex As Exception

            End Try

        End While

    End Sub

    Private Sub Thread5_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Thread5.DoWork

        Dim i As Integer = 100
        Dim iptemp As String() = tempip.Split(CChar("."))
        Dim ip As String = iptemp(0) & "." & iptemp(1) & "." & iptemp(2) & "."

        While i <> 125

            performPBstep()

            i += 1

            Try

                client.SendMessage(ip & i.ToString, port, "scan")

            Catch ex As Exception

            End Try

        End While

    End Sub

    Private Sub Thread6_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Thread6.DoWork

        Dim i As Integer = 125
        Dim iptemp As String() = tempip.Split(CChar("."))
        Dim ip As String = iptemp(0) & "." & iptemp(1) & "." & iptemp(2) & "."

        While i <> 150

            performPBstep()

            i += 1

            Try

                client.SendMessage(ip & i.ToString, port, "scan")

            Catch ex As Exception

            End Try

        End While

    End Sub

    Private Sub Thread7_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Thread7.DoWork

        Dim i As Integer = 150
        Dim iptemp As String() = tempip.Split(CChar("."))
        Dim ip As String = iptemp(0) & "." & iptemp(1) & "." & iptemp(2) & "."

        While i <> 175

            performPBstep()

            i += 1

            Try

                client.SendMessage(ip & i.ToString, port, "scan")

            Catch ex As Exception

            End Try

        End While

    End Sub

    Private Sub Thread8_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Thread8.DoWork

        Dim i As Integer = 175
        Dim iptemp As String() = tempip.Split(CChar("."))
        Dim ip As String = iptemp(0) & "." & iptemp(1) & "." & iptemp(2) & "."

        While i <> 200

            performPBstep()

            i += 1

            Try

                client.SendMessage(ip & i.ToString, port, "scan")

            Catch ex As Exception

            End Try

        End While

    End Sub

    Private Sub Thread9_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Thread9.DoWork

        Dim i As Integer = 200
        Dim iptemp As String() = tempip.Split(CChar("."))
        Dim ip As String = iptemp(0) & "." & iptemp(1) & "." & iptemp(2) & "."

        While i <> 225

            performPBstep()

            i += 1

            Try

                client.SendMessage(ip & i.ToString, port, "scan")

            Catch ex As Exception

            End Try

        End While

    End Sub

    Private Sub Thread10_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Thread10.DoWork

        Dim i As Integer = 225
        Dim iptemp As String() = tempip.Split(CChar("."))
        Dim ip As String = iptemp(0) & "." & iptemp(1) & "." & iptemp(2) & "."

        While i <> 254

            performPBstep()

            i += 1

            Try

                client.SendMessage(ip & i.ToString, port, "scan")

            Catch ex As Exception

            End Try

            If i = 254 Then

                Me.Invoke(Sub() LBIP.Items.Add("Scan abgeschlossen"))

            End If

        End While

    End Sub

#End Region

    Private Sub Login_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown


        If e.KeyData = Keys.A Then

            If Not admincount >= 20 Then

                admincount += 1

            Else

                input_dialog.mode = 3
                input_dialog.Show()

            End If

        End If

    End Sub

End Class
