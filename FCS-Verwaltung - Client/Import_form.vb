Imports System.IO
Imports Microsoft.VisualBasic.Strings

Public Class Import_form

    Public import_driveletter As String = Hauptscreen.import_driveletter

    Dim temppath As New DirectoryInfo(Path.GetTempPath & "\FCS\Client\")
    Dim tempfile As New FileInfo(temppath.FullName & "database.dafcs")

    Dim importfiles As String()
    Dim import_projectid As Integer
    Dim import_cameraid As Integer

    Dim cbpro_chan As Boolean = False
    Dim cbcam_chan As Boolean = False
    Dim fileselected As Boolean = False

    Private Sub BTSubmit_Click(sender As Object, e As EventArgs) Handles BTSubmit.Click

        LStatus.Text = "Datei(en) werden übertragen..."

        BTSubmit.Enabled = False

        PBCopy.Value = 0

        'PBCopy.Maximum = importfiles.Count

        For Each importfile In importfiles

            Dim ext() As String = importfile.Split(CChar("."))

            Dim r As Random = New Random
            Dim randomint As Integer = r.Next(1, 999)

            'File.Copy(importfile, import_driveletter & ":\" & Format(import_projectid, "000") & "-" & Format(import_cameraid, "000") & "-" & Format(Hauptscreen.import_clipnumber, "000") & "-" & Format(randomint, "000") & "." & ext(ext.Count - 1), False)

            copy(importfile, import_driveletter & ":\" & Format(import_projectid, "000") & "-" & Format(import_cameraid, "000") & "-" & Format(Hauptscreen.import_clipnumber, "000") & "-" & Format(randomint, "000") & "." & ext(ext.Count - 1))

            'PBCopy.PerformStep()

            Hauptscreen.import_clipnumber += 1

        Next

        BTSubmit.Enabled = True

        BTSubmit.Visible = False

        LStatus.Text = "Datei(en) erfolgreich übertragen..."

    End Sub

    Private Sub BTSel_Click(sender As Object, e As EventArgs) Handles BTSel.Click

        If ImportDialog.ShowDialog() = DialogResult.Cancel Then

            fileselected = False

        ElseIf ImportDialog.FileNames(0) <> "OpenFileDialog1" Then

            fileselected = True

        End If

        importfiles = ImportDialog.FileNames

        If cbpro_chan And cbcam_chan And fileselected = True Then

            BTSubmit.Visible = True

        End If

    End Sub

    Private Sub Import_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Database1.ReadXml(tempfile.FullName)

        fill_combobox()

    End Sub

    Private Sub fill_combobox()

        Dim i As Integer = 0

        Do Until i = Database1.projects.Rows.Count

            CBPro.Items.Add(Database1.projects.Rows.Item(i)(1))

            i += 1

        Loop

        i = 0

        Do Until i = Database1.camera.Rows.Count

            CBCam.Items.Add(Database1.camera.Rows.Item(i)(1))

            i += 1

        Loop

    End Sub

    Private Sub CBPro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBPro.SelectedIndexChanged

        Dim abfrage As String = "Name = '" & CBPro.SelectedItem.ToString & "'"

        Dim foundrows() As DataRow

        foundrows = Database1.projects.Select(abfrage)

        Dim i As Integer

        For i = 0 To foundrows.GetUpperBound(0)

            import_projectid = Convert.ToInt32(foundrows(i)(0))

        Next i

        cbpro_chan = True

        If cbpro_chan And cbcam_chan And fileselected = True Then

            BTSubmit.Visible = True

        End If

    End Sub

    Private Sub CBCam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBCam.SelectedIndexChanged

        Dim abfrage As String = "Name = '" & CBCam.SelectedItem.ToString & "'"

        Dim foundrows() As DataRow

        foundrows = Database1.camera.Select(abfrage)

        Dim i As Integer

        For i = 0 To foundrows.GetUpperBound(0)

            import_cameraid = Convert.ToInt32(foundrows(i)(0))

        Next i

        cbcam_chan = True

        If cbpro_chan And cbcam_chan And fileselected = True Then

            BTSubmit.Visible = True

        End If

    End Sub

    Private Sub copy(from As String, dest As String)

        Dim sr As New FileStream(from, IO.FileMode.Open)
        Dim sw As New FileStream(dest, IO.FileMode.Create)
        Dim len As Long = sr.Length - 1
        Dim buffer(1024) As Byte
        Dim bytesread As Integer

        While sr.Position < len
            bytesread = (sr.Read(buffer, 0, 1024))
            sw.Write(buffer, 0, bytesread)
            PBCopy.Value = CInt(sr.Position / len * 100)
            Application.DoEvents()
        End While

        sw.Flush()
        sw.Close()
        sr.Close()

    End Sub

End Class