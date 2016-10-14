<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class edit_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(edit_form))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBMode = New System.Windows.Forms.ComboBox()
        Me.Database1 = New FCS_Verwaltung___Client.database()
        Me.CBName = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.CBCat = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBBeschreibung = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BTSave = New System.Windows.Forms.Button()
        Me.TBNewName = New System.Windows.Forms.TextBox()
        Me.BTNewName = New System.Windows.Forms.Button()
        Me.CBAdmin = New System.Windows.Forms.CheckBox()
        Me.TBPw = New System.Windows.Forms.TextBox()
        Me.CBArchived = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BTNewPw = New System.Windows.Forms.Button()
        Me.LPermissions = New System.Windows.Forms.Label()
        Me.CLBPermissions = New System.Windows.Forms.CheckedListBox()
        Me.BTPerSave = New System.Windows.Forms.Button()
        CType(Me.Database1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Modus wählen"
        '
        'CBMode
        '
        Me.CBMode.FormattingEnabled = True
        Me.CBMode.Items.AddRange(New Object() {"Projekt", "Kategorie", "Kamera", "Benutzer", "Benutzer-Gruppe"})
        Me.CBMode.Location = New System.Drawing.Point(123, 79)
        Me.CBMode.Name = "CBMode"
        Me.CBMode.Size = New System.Drawing.Size(139, 21)
        Me.CBMode.TabIndex = 2
        '
        'Database1
        '
        Me.Database1.DataSetName = "database"
        Me.Database1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CBName
        '
        Me.CBName.FormattingEnabled = True
        Me.CBName.Location = New System.Drawing.Point(108, 3)
        Me.CBName.Name = "CBName"
        Me.CBName.Size = New System.Drawing.Size(139, 21)
        Me.CBName.TabIndex = 3
        Me.CBName.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.CBCat, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TBBeschreibung, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.BTSave, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TBNewName, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.BTNewName, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.CBName, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CBAdmin, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.TBPw, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.CBArchived, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.BTNewPw, 2, 4)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.ForeColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(15, 106)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(372, 259)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'CBCat
        '
        Me.CBCat.FormattingEnabled = True
        Me.CBCat.Location = New System.Drawing.Point(108, 30)
        Me.CBCat.Name = "CBCat"
        Me.CBCat.Size = New System.Drawing.Size(139, 21)
        Me.CBCat.TabIndex = 6
        Me.CBCat.Visible = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Kategorie"
        Me.Label3.Visible = False
        '
        'TBBeschreibung
        '
        Me.TBBeschreibung.Location = New System.Drawing.Point(108, 86)
        Me.TBBeschreibung.Multiline = True
        Me.TBBeschreibung.Name = "TBBeschreibung"
        Me.TBBeschreibung.Size = New System.Drawing.Size(139, 86)
        Me.TBBeschreibung.TabIndex = 8
        Me.TBBeschreibung.Visible = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Beschreibung"
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Neuer Name"
        Me.Label5.Visible = False
        '
        'BTSave
        '
        Me.BTSave.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BTSave.BackColor = System.Drawing.Color.White
        Me.BTSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTSave.ForeColor = System.Drawing.Color.Black
        Me.BTSave.Location = New System.Drawing.Point(253, 117)
        Me.BTSave.Name = "BTSave"
        Me.BTSave.Size = New System.Drawing.Size(116, 23)
        Me.BTSave.TabIndex = 11
        Me.BTSave.Text = "Text speichern"
        Me.BTSave.UseVisualStyleBackColor = False
        Me.BTSave.Visible = False
        '
        'TBNewName
        '
        Me.TBNewName.Location = New System.Drawing.Point(108, 57)
        Me.TBNewName.Name = "TBNewName"
        Me.TBNewName.Size = New System.Drawing.Size(139, 20)
        Me.TBNewName.TabIndex = 14
        Me.TBNewName.Visible = False
        '
        'BTNewName
        '
        Me.BTNewName.BackColor = System.Drawing.Color.White
        Me.BTNewName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNewName.ForeColor = System.Drawing.Color.Black
        Me.BTNewName.Location = New System.Drawing.Point(253, 57)
        Me.BTNewName.Name = "BTNewName"
        Me.BTNewName.Size = New System.Drawing.Size(116, 23)
        Me.BTNewName.TabIndex = 15
        Me.BTNewName.Text = "Name speichern"
        Me.BTNewName.UseVisualStyleBackColor = False
        Me.BTNewName.Visible = False
        '
        'CBAdmin
        '
        Me.CBAdmin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CBAdmin.AutoSize = True
        Me.CBAdmin.Enabled = False
        Me.CBAdmin.Location = New System.Drawing.Point(128, 234)
        Me.CBAdmin.Name = "CBAdmin"
        Me.CBAdmin.Size = New System.Drawing.Size(99, 17)
        Me.CBAdmin.TabIndex = 16
        Me.CBAdmin.Text = "Administrator"
        Me.CBAdmin.UseVisualStyleBackColor = True
        Me.CBAdmin.Visible = False
        '
        'TBPw
        '
        Me.TBPw.Location = New System.Drawing.Point(108, 178)
        Me.TBPw.Name = "TBPw"
        Me.TBPw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBPw.Size = New System.Drawing.Size(139, 20)
        Me.TBPw.TabIndex = 18
        Me.TBPw.Visible = False
        '
        'CBArchived
        '
        Me.CBArchived.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CBArchived.AutoSize = True
        Me.CBArchived.Location = New System.Drawing.Point(137, 207)
        Me.CBArchived.Name = "CBArchived"
        Me.CBArchived.Size = New System.Drawing.Size(80, 17)
        Me.CBArchived.TabIndex = 10
        Me.CBArchived.Text = "Archiviert"
        Me.CBArchived.UseVisualStyleBackColor = True
        Me.CBArchived.Visible = False
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Neues Passwort"
        Me.Label6.Visible = False
        '
        'BTNewPw
        '
        Me.BTNewPw.BackColor = System.Drawing.Color.White
        Me.BTNewPw.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNewPw.ForeColor = System.Drawing.Color.Black
        Me.BTNewPw.Location = New System.Drawing.Point(253, 178)
        Me.BTNewPw.Name = "BTNewPw"
        Me.BTNewPw.Size = New System.Drawing.Size(116, 23)
        Me.BTNewPw.TabIndex = 19
        Me.BTNewPw.Text = "Passwort speichern"
        Me.BTNewPw.UseVisualStyleBackColor = False
        Me.BTNewPw.Visible = False
        '
        'LPermissions
        '
        Me.LPermissions.AutoSize = True
        Me.LPermissions.BackColor = System.Drawing.Color.Transparent
        Me.LPermissions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPermissions.ForeColor = System.Drawing.Color.White
        Me.LPermissions.Location = New System.Drawing.Point(361, 112)
        Me.LPermissions.Name = "LPermissions"
        Me.LPermissions.Size = New System.Drawing.Size(52, 13)
        Me.LPermissions.TabIndex = 16
        Me.LPermissions.Text = "Rechte:"
        Me.LPermissions.Visible = False
        '
        'CLBPermissions
        '
        Me.CLBPermissions.FormattingEnabled = True
        Me.CLBPermissions.Items.AddRange(New Object() {"Projekt erstellen", "Projekt editieren", "Projekt löschen", "Kategorie erstellen", "Kategorie editieren", "Kategorie löschen", "Kamera erstellen", "Kamera editieren", "Kamera löschen", "Benutzer erstellen", "Benutzer editieren", "Benutzer löschen", "Benutzer-Gruppe erstellen", "Benutzer-Gruppe editieren", "Benutzer-Gruppe löschen", "Musik hinzufügen", "Musikeintrag bearbeiten", "Musik löschen", "Inventar Hinzufügen", "Inventareintrag bearbeiten", "Inventar löschen", "ext. Login", "Port verändern", "Server stoppen", "Server neustarten", "Konsole benutzen", "Daten neu einlesen"})
        Me.CLBPermissions.Location = New System.Drawing.Point(419, 112)
        Me.CLBPermissions.Name = "CLBPermissions"
        Me.CLBPermissions.Size = New System.Drawing.Size(176, 139)
        Me.CLBPermissions.TabIndex = 15
        Me.CLBPermissions.Visible = False
        '
        'BTPerSave
        '
        Me.BTPerSave.BackColor = System.Drawing.Color.White
        Me.BTPerSave.Location = New System.Drawing.Point(493, 257)
        Me.BTPerSave.Name = "BTPerSave"
        Me.BTPerSave.Size = New System.Drawing.Size(102, 23)
        Me.BTPerSave.TabIndex = 16
        Me.BTPerSave.Text = "Rechte speichern"
        Me.BTPerSave.UseVisualStyleBackColor = False
        Me.BTPerSave.Visible = False
        '
        'edit_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(606, 368)
        Me.Controls.Add(Me.BTPerSave)
        Me.Controls.Add(Me.CLBPermissions)
        Me.Controls.Add(Me.LPermissions)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.CBMode)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "edit_form"
        Me.Text = "Bearbeiten"
        CType(Me.Database1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents CBMode As ComboBox
    Friend WithEvents Database1 As database
    Friend WithEvents CBName As ComboBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CBCat As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TBBeschreibung As TextBox
    Friend WithEvents CBArchived As CheckBox
    Friend WithEvents BTSave As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TBNewName As TextBox
    Friend WithEvents BTNewName As Button
    Friend WithEvents LPermissions As Label
    Friend WithEvents CLBPermissions As CheckedListBox
    Friend WithEvents BTPerSave As Button
    Friend WithEvents CBAdmin As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BTNewPw As Button
    Friend WithEvents TBPw As TextBox
End Class
