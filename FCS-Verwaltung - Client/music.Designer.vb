<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class music_form
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(music_form))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LVMusic = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CHName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Interpret = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Album = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CMSLVMusic = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TSINew = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSIDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSIAudition = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSIReload = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSIOpenFolder = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTSave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBYear = New System.Windows.Forms.TextBox()
        Me.TBGenre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBComment = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBFormat = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBTime = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBAlbum = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBInterpret = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBTitle = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.OpenSong = New System.Windows.Forms.OpenFileDialog()
        Me.Player = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Database1 = New FCS_Verwaltung___Client.database()
        Me.CMSLVMusic.SuspendLayout()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Musik"
        '
        'LVMusic
        '
        Me.LVMusic.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.CHName, Me.Interpret, Me.Album})
        Me.LVMusic.ContextMenuStrip = Me.CMSLVMusic
        Me.LVMusic.FullRowSelect = True
        Me.LVMusic.Location = New System.Drawing.Point(12, 25)
        Me.LVMusic.MultiSelect = False
        Me.LVMusic.Name = "LVMusic"
        Me.LVMusic.Size = New System.Drawing.Size(782, 283)
        Me.LVMusic.TabIndex = 1
        Me.LVMusic.UseCompatibleStateImageBehavior = False
        Me.LVMusic.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 52
        '
        'CHName
        '
        Me.CHName.Text = "Name"
        Me.CHName.Width = 241
        '
        'Interpret
        '
        Me.Interpret.Text = "Interpret"
        Me.Interpret.Width = 182
        '
        'Album
        '
        Me.Album.Text = "Album"
        Me.Album.Width = 211
        '
        'CMSLVMusic
        '
        Me.CMSLVMusic.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSINew, Me.TSIDelete, Me.TSIAudition, Me.TSIReload, Me.TSIOpenFolder})
        Me.CMSLVMusic.Name = "CMSLVMusic"
        Me.CMSLVMusic.Size = New System.Drawing.Size(198, 136)
        '
        'TSINew
        '
        Me.TSINew.Name = "TSINew"
        Me.TSINew.Size = New System.Drawing.Size(197, 22)
        Me.TSINew.Text = "Hinzufügen"
        '
        'TSIDelete
        '
        Me.TSIDelete.Name = "TSIDelete"
        Me.TSIDelete.Size = New System.Drawing.Size(197, 22)
        Me.TSIDelete.Text = "Löschen"
        '
        'TSIAudition
        '
        Me.TSIAudition.Name = "TSIAudition"
        Me.TSIAudition.Size = New System.Drawing.Size(197, 22)
        Me.TSIAudition.Text = "In Auditions bearbeiten"
        '
        'TSIReload
        '
        Me.TSIReload.Name = "TSIReload"
        Me.TSIReload.Size = New System.Drawing.Size(197, 22)
        Me.TSIReload.Text = "Aktualisieren"
        '
        'TSIOpenFolder
        '
        Me.TSIOpenFolder.Name = "TSIOpenFolder"
        Me.TSIOpenFolder.Size = New System.Drawing.Size(197, 22)
        Me.TSIOpenFolder.Text = "Ordner öffnen"
        '
        'BTSave
        '
        Me.BTSave.Location = New System.Drawing.Point(960, 285)
        Me.BTSave.Name = "BTSave"
        Me.BTSave.Size = New System.Drawing.Size(75, 23)
        Me.BTSave.TabIndex = 8
        Me.BTSave.Text = "Speichern"
        Me.BTSave.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(800, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Jahr:"
        '
        'TBYear
        '
        Me.TBYear.Location = New System.Drawing.Point(890, 103)
        Me.TBYear.Name = "TBYear"
        Me.TBYear.Size = New System.Drawing.Size(145, 20)
        Me.TBYear.TabIndex = 5
        '
        'TBGenre
        '
        Me.TBGenre.Location = New System.Drawing.Point(890, 129)
        Me.TBGenre.Name = "TBGenre"
        Me.TBGenre.Size = New System.Drawing.Size(145, 20)
        Me.TBGenre.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(800, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Genre:"
        '
        'TBComment
        '
        Me.TBComment.Location = New System.Drawing.Point(890, 207)
        Me.TBComment.Multiline = True
        Me.TBComment.Name = "TBComment"
        Me.TBComment.Size = New System.Drawing.Size(145, 72)
        Me.TBComment.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(800, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Kommentar:"
        '
        'TBFormat
        '
        Me.TBFormat.Enabled = False
        Me.TBFormat.Location = New System.Drawing.Point(890, 155)
        Me.TBFormat.Name = "TBFormat"
        Me.TBFormat.Size = New System.Drawing.Size(145, 20)
        Me.TBFormat.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(800, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Format:"
        '
        'TBTime
        '
        Me.TBTime.Enabled = False
        Me.TBTime.Location = New System.Drawing.Point(890, 181)
        Me.TBTime.Name = "TBTime"
        Me.TBTime.Size = New System.Drawing.Size(145, 20)
        Me.TBTime.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(800, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Länge:"
        '
        'TBAlbum
        '
        Me.TBAlbum.Location = New System.Drawing.Point(890, 77)
        Me.TBAlbum.Name = "TBAlbum"
        Me.TBAlbum.Size = New System.Drawing.Size(145, 20)
        Me.TBAlbum.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(800, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Album:"
        '
        'TBInterpret
        '
        Me.TBInterpret.Location = New System.Drawing.Point(890, 51)
        Me.TBInterpret.Name = "TBInterpret"
        Me.TBInterpret.Size = New System.Drawing.Size(145, 20)
        Me.TBInterpret.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(800, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Interpret:"
        '
        'TBTitle
        '
        Me.TBTitle.Location = New System.Drawing.Point(890, 25)
        Me.TBTitle.Name = "TBTitle"
        Me.TBTitle.Size = New System.Drawing.Size(145, 20)
        Me.TBTitle.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(800, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Titel:"
        '
        'OpenSong
        '
        Me.OpenSong.RestoreDirectory = True
        '
        'Player
        '
        Me.Player.Enabled = True
        Me.Player.Location = New System.Drawing.Point(12, 314)
        Me.Player.Name = "Player"
        Me.Player.OcxState = CType(resources.GetObject("Player.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Player.Size = New System.Drawing.Size(782, 46)
        Me.Player.TabIndex = 9
        Me.Player.UseWaitCursor = True
        '
        'Database1
        '
        Me.Database1.DataSetName = "database"
        Me.Database1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'music_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1051, 372)
        Me.Controls.Add(Me.Player)
        Me.Controls.Add(Me.TBTitle)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TBInterpret)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TBAlbum)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TBTime)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TBFormat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TBComment)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TBGenre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TBYear)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTSave)
        Me.Controls.Add(Me.LVMusic)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "music_form"
        Me.Text = "Musikserver"
        Me.CMSLVMusic.ResumeLayout(False)
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Database1 As database
    Friend WithEvents Label1 As Label
    Friend WithEvents LVMusic As ListView
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents CHName As ColumnHeader
    Friend WithEvents Interpret As ColumnHeader
    Friend WithEvents Album As ColumnHeader
    Friend WithEvents BTSave As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TBYear As TextBox
    Friend WithEvents TBGenre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TBComment As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TBFormat As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TBTime As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CMSLVMusic As ContextMenuStrip
    Friend WithEvents TSINew As ToolStripMenuItem
    Friend WithEvents TSIDelete As ToolStripMenuItem
    Friend WithEvents TBAlbum As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TBInterpret As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TBTitle As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TSIAudition As ToolStripMenuItem
    Friend WithEvents OpenSong As OpenFileDialog
    Friend WithEvents Player As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents TSIReload As ToolStripMenuItem
    Friend WithEvents TSIOpenFolder As ToolStripMenuItem
End Class
