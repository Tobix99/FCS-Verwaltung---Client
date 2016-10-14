Imports System.IO

Public Class music_form

    Public ip As String = Hauptscreen.Mainserverip
    Public Username As String = Hauptscreen.MainUsername
    Public password As String = Hauptscreen.MainHashedPassword

    Dim start As Boolean = False
    Dim path_to_song As FileInfo

    Dim temppath As New DirectoryInfo(Path.GetTempPath & "\FCS\Client\")
    Dim tempfile As New FileInfo(temppath.FullName & "database.dafcs")

    Dim selectlvitemid As Integer = -1

    Dim tbtitle_old As String = ""
    Dim tbint_old As String = ""
    Dim tbalb_old As String = ""
    Dim tbyear_old As String = ""
    Dim tbgenre_old As String = ""
    Dim tbcomment_old As String = ""

    Private Sub music_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        reload()

    End Sub

    Private Sub music_form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Hauptscreen.music_form_active = False

    End Sub

#Region "TSI"

    Private Sub TSINew_Click(sender As Object, e As EventArgs) Handles TSINew.Click

        OpenSong.ShowDialog()
        Try

            path_to_song = New IO.FileInfo(OpenSong.FileName)

        Catch ex As Exception
            Exit Sub
        End Try

        Dim ext() As String = OpenSong.FileName.Split(CChar("."))

        Player.URL = path_to_song.FullName

        TBTitle.Text = Player.currentMedia.name
        TBTitle.Focus()
        TBTitle.SelectAll()

        TBInterpret.Text = ""
        TBAlbum.Text = ""
        TBYear.Text = ""
        TBGenre.Text = ""
        TBFormat.Text = ext(ext.Count - 1)
        TBTime.Text = "00:00"
        TBComment.Text = ""

        If ext(ext.Count - 1) = "mp3" Or ext(ext.Count - 1) = "MP3" Then

            Dim mp3 As New ID3TagLibrary.MP3File(path_to_song.FullName)

            If mp3.Title <> "" Then TBTitle.Text = mp3.Title
            TBInterpret.Text = mp3.Artist
            TBAlbum.Text = mp3.Album
            TBYear.Text = mp3.Year
            TBGenre.Text = mp3.Genre
            TBComment.Text = mp3.Comment

        End If

        BTSave.Text = "Hinzufügen"

        start = True

    End Sub

    Private Sub Player_PlayStateChange(sender As Object, e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles Player.PlayStateChange

        If e.newState = 3 And start = True Then

            TBTime.Text = Player.currentMedia.durationString
            Player.Ctlcontrols.stop()
            start = False

        End If

    End Sub

    Private Sub TSIReload_Click(sender As Object, e As EventArgs) Handles TSIReload.Click

        reload()

    End Sub

    Private Sub TSIOpenFolder_Click(sender As Object, e As EventArgs) Handles TSIOpenFolder.Click

        Dim selitemlv As String = ""

        For Each SelItem As ListViewItem In LVMusic.SelectedItems

            selitemlv = SelItem.Text

            Exit For

        Next


        For Each musicrow As database.musicRow In Database1.music

            If musicrow.ID.ToString = selitemlv Then

                Process.Start("explorer.exe", "/select,""" & Hauptscreen.music_pool_driveletter & ":\" & musicrow.Interpret & "\" & musicrow.Album & "\" & musicrow.Name & "." & musicrow._Format_ext & """")

            End If

        Next

    End Sub

    Private Sub TSIDelete_Click(sender As Object, e As EventArgs) Handles TSIDelete.Click

        Dim selitemlv As String = ""

        For Each SelItem As ListViewItem In LVMusic.SelectedItems

            selitemlv = SelItem.Text

            Exit For

        Next

        For Each musicrow As database.musicRow In Database1.music

            If musicrow.ID.ToString = selitemlv Then

                delete_Music(musicrow.Name, musicrow.ID.ToString)

            End If

        Next

    End Sub

    Private Sub TSIAudition_Click(sender As Object, e As EventArgs) Handles TSIAudition.Click
        Dim selitemlv As String = ""

        For Each SelItem As ListViewItem In LVMusic.SelectedItems

            selitemlv = SelItem.Text

            Exit For

        Next


        For Each musicrow As database.musicRow In Database1.music

            If musicrow.ID.ToString = selitemlv Then

                Process.Start(My.Settings.Auditions_Path, """" & Hauptscreen.music_pool_driveletter & ":\" & musicrow.Interpret & "\" & musicrow.Album & "\" & musicrow.Name & "." & musicrow._Format_ext & """")

            End If

        Next

    End Sub

#End Region

    Private Sub fill_ListView()

        For Each musicrow As database.musicRow In Database1.music

            Dim lvitem As ListViewItem

            lvitem = LVMusic.Items.Add(musicrow(0).ToString)

            lvitem.SubItems.AddRange(New String() {musicrow(1).ToString, musicrow(2).ToString, musicrow(3).ToString})


        Next

    End Sub

    Private Sub LVMusic_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LVMusic.SelectedIndexChanged

        Dim selitemlv As String = ""

        For Each SelItem As ListViewItem In LVMusic.SelectedItems

            selitemlv = SelItem.Text

            If Convert.ToInt32(selitemlv) = selectlvitemid Then

                Exit Sub

            End If

            selectlvitemid = Convert.ToInt32(SelItem.Text)

        Next


        For Each musicrow As database.musicRow In Database1.music

            If musicrow.ID.ToString = selitemlv Then

#Region "saveoldvalue for edit"

                tbtitle_old = TBTitle.Text
                tbint_old = TBInterpret.Text
                tbalb_old = TBAlbum.Text
                tbyear_old = TBYear.Text
                tbgenre_old = TBGenre.Text
                tbcomment_old = TBComment.Text

#End Region

                TBTitle.Text = musicrow.Name

                TBInterpret.Text = musicrow.Interpret

                TBAlbum.Text = musicrow.Album

                TBYear.Text = musicrow.Year

                TBGenre.Text = musicrow.Genre

                TBComment.Text = musicrow.Comment

                TBFormat.Text = musicrow._Format_ext

                TBTime.Text = musicrow.Time

                Player.URL = Hauptscreen.music_pool_driveletter & ":\" & musicrow.Interpret & "\" & musicrow.Album & "\" & musicrow.Name & "." & musicrow._Format_ext

                start = True

            End If

        Next

    End Sub

    Private Sub BTSave_Click(sender As Object, e As EventArgs) Handles BTSave.Click

        If BTSave.Text = "Hinzufügen" Then

            New_music_entry(TBTitle.Text, TBInterpret.Text, TBAlbum.Text, TBYear.Text, TBGenre.Text, TBComment.Text, TBFormat.Text, TBTime.Text, path_to_song)

        Else

            befor_save()

        End If

        BTSave.Text = "Speichern"

    End Sub

    Public Sub reload()

        LVMusic.Items.Clear()

        Database1.Clear()
        Database1.ReadXml(tempfile.FullName)

        fill_ListView()

    End Sub

    Private Sub befor_save()

        If Not tbtitle_old = TBTitle.Text Then

            save(tbtitle_old, selectlvitemid.ToString, "1", TBTitle.Text)

        End If

        If Not tbint_old = TBInterpret.Text Then

            save(tbtitle_old, selectlvitemid.ToString, "2", TBInterpret.Text)

        End If

        If Not tbalb_old = TBAlbum.Text Then

            save(tbtitle_old, selectlvitemid.ToString, "3", TBAlbum.Text)

        End If

        If Not tbyear_old = TBYear.Text Then

            save(tbtitle_old, selectlvitemid.ToString, "4", TBYear.Text)

        End If

        If Not tbgenre_old = TBGenre.Text Then

            save(tbtitle_old, selectlvitemid.ToString, "5", TBGenre.Text)

        End If

        If Not tbcomment_old = TBComment.Text Then

            save(tbtitle_old, selectlvitemid.ToString, "6", TBComment.Text)

        End If


    End Sub

    Private Sub save(name As String, id As String, editcolumn As String, newvalue As String)

        Hauptscreen.client.SendMessage(ip, Convert.ToInt32(My.Settings.Port), Username & ";" & password & ";editProject;" & name & ";" & id & ";" & editcolumn & ";" & newvalue)

    End Sub

    Private Sub New_music_entry(name As String, interpret As String, album As String, year As String, genre As String, comment As String, ext As String, time As String, path_to_song As IO.FileInfo)

        IO.File.Copy(path_to_song.FullName, Hauptscreen.music_import_driveletter & ":\" & path_to_song.Name, True)

        Hauptscreen.client.SendMessage(ip, Convert.ToInt32(My.Settings.Port), Username & ";" & password & ";createMusic;" & name & ";" & interpret & ";" & album & ";" & year & ";" & genre & ";" & comment & ";" & ext & ";" & time)

    End Sub

    Private Sub delete_Music(name As String, id As String)

        Hauptscreen.client.SendMessage(ip, Convert.ToInt32(My.Settings.Port), Username & ";" & password & ";deleteMusic;" & name & ";" & id)

    End Sub

    Public Sub remove_music_from_lv(id As String)

        For Each item As ListViewItem In LVMusic.Items

            If item.Text = id Then

                For Each musicrow As database.musicRow In Database1.music

                    If musicrow.ID = Convert.ToInt32(id) Then

                        musicrow.Delete()

                        Dim test As Boolean = True

                        Do

                            Try

                                Database1.WriteXml(tempfile.FullName)

                                test = True

                            Catch ex As Exception

                            End Try

                        Loop While test = True

                        Exit For

                    End If

                Next

                LVMusic.Items.Remove(item)

                reload()

                Exit For

            End If

        Next

    End Sub


End Class