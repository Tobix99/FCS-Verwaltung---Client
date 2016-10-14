<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class create
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(create))
        Me.CBMode = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TBPass = New System.Windows.Forms.TextBox()
        Me.CBCat = New System.Windows.Forms.ComboBox()
        Me.LCat = New System.Windows.Forms.Label()
        Me.LPass = New System.Windows.Forms.Label()
        Me.LName = New System.Windows.Forms.Label()
        Me.TBName = New System.Windows.Forms.TextBox()
        Me.TBDesc = New System.Windows.Forms.TextBox()
        Me.CBActive = New System.Windows.Forms.CheckBox()
        Me.CBAdmin = New System.Windows.Forms.CheckBox()
        Me.LDesc = New System.Windows.Forms.Label()
        Me.CLBPermissions = New System.Windows.Forms.CheckedListBox()
        Me.LPermissions = New System.Windows.Forms.Label()
        Me.BTAboard = New System.Windows.Forms.Button()
        Me.BTCreate = New System.Windows.Forms.Button()
        Me.ProjectsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1 = New FCS_Verwaltung___Client.database()
        Me.TVTemplates = New System.Windows.Forms.TreeView()
        Me.LTemplate = New System.Windows.Forms.Label()
        Me.LInfo = New System.Windows.Forms.Label()
        Me.TBInfo = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ProjectsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CBMode
        '
        Me.CBMode.FormattingEnabled = True
        Me.CBMode.Items.AddRange(New Object() {"Projekt", "Kategorie", "Kamera", "Benutzer", "Benutzer-Gruppe"})
        Me.CBMode.Location = New System.Drawing.Point(126, 72)
        Me.CBMode.Name = "CBMode"
        Me.CBMode.Size = New System.Drawing.Size(147, 21)
        Me.CBMode.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(14, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Modus auswählen"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.TBPass, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.CBCat, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LCat, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LPass, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LName, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TBName, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TBDesc, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.CBActive, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.CBAdmin, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.LDesc, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 99)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(264, 279)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'TBPass
        '
        Me.TBPass.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBPass.Location = New System.Drawing.Point(114, 201)
        Me.TBPass.Name = "TBPass"
        Me.TBPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBPass.Size = New System.Drawing.Size(147, 20)
        Me.TBPass.TabIndex = 14
        Me.TBPass.Visible = False
        '
        'CBCat
        '
        Me.CBCat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBCat.FormattingEnabled = True
        Me.CBCat.Location = New System.Drawing.Point(114, 174)
        Me.CBCat.Name = "CBCat"
        Me.CBCat.Size = New System.Drawing.Size(147, 21)
        Me.CBCat.TabIndex = 12
        Me.CBCat.Visible = False
        '
        'LCat
        '
        Me.LCat.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LCat.AutoSize = True
        Me.LCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCat.ForeColor = System.Drawing.Color.White
        Me.LCat.Location = New System.Drawing.Point(3, 178)
        Me.LCat.Name = "LCat"
        Me.LCat.Size = New System.Drawing.Size(61, 13)
        Me.LCat.TabIndex = 11
        Me.LCat.Text = "Kategorie"
        Me.LCat.Visible = False
        '
        'LPass
        '
        Me.LPass.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LPass.AutoSize = True
        Me.LPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPass.ForeColor = System.Drawing.Color.White
        Me.LPass.Location = New System.Drawing.Point(3, 204)
        Me.LPass.Name = "LPass"
        Me.LPass.Size = New System.Drawing.Size(58, 13)
        Me.LPass.TabIndex = 13
        Me.LPass.Text = "Passwort"
        Me.LPass.Visible = False
        '
        'LName
        '
        Me.LName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LName.AutoSize = True
        Me.LName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LName.ForeColor = System.Drawing.Color.White
        Me.LName.Location = New System.Drawing.Point(3, 6)
        Me.LName.Name = "LName"
        Me.LName.Size = New System.Drawing.Size(39, 13)
        Me.LName.TabIndex = 6
        Me.LName.Text = "Name"
        Me.LName.Visible = False
        '
        'TBName
        '
        Me.TBName.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TBName.Location = New System.Drawing.Point(114, 3)
        Me.TBName.Name = "TBName"
        Me.TBName.Size = New System.Drawing.Size(147, 20)
        Me.TBName.TabIndex = 7
        Me.TBName.Visible = False
        '
        'TBDesc
        '
        Me.TBDesc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBDesc.Location = New System.Drawing.Point(114, 29)
        Me.TBDesc.Multiline = True
        Me.TBDesc.Name = "TBDesc"
        Me.TBDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TBDesc.Size = New System.Drawing.Size(147, 139)
        Me.TBDesc.TabIndex = 9
        Me.TBDesc.Visible = False
        '
        'CBActive
        '
        Me.CBActive.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CBActive.AutoSize = True
        Me.CBActive.Checked = True
        Me.CBActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBActive.ForeColor = System.Drawing.Color.White
        Me.CBActive.Location = New System.Drawing.Point(144, 227)
        Me.CBActive.Name = "CBActive"
        Me.CBActive.Size = New System.Drawing.Size(80, 17)
        Me.CBActive.TabIndex = 15
        Me.CBActive.Text = "Aktiviert?"
        Me.CBActive.UseVisualStyleBackColor = True
        Me.CBActive.Visible = False
        '
        'CBAdmin
        '
        Me.CBAdmin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CBAdmin.AutoSize = True
        Me.CBAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBAdmin.ForeColor = System.Drawing.Color.White
        Me.CBAdmin.Location = New System.Drawing.Point(135, 254)
        Me.CBAdmin.Name = "CBAdmin"
        Me.CBAdmin.Size = New System.Drawing.Size(99, 17)
        Me.CBAdmin.TabIndex = 16
        Me.CBAdmin.Text = "Administrator"
        Me.CBAdmin.UseVisualStyleBackColor = True
        Me.CBAdmin.Visible = False
        '
        'LDesc
        '
        Me.LDesc.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDesc.ForeColor = System.Drawing.Color.White
        Me.LDesc.Location = New System.Drawing.Point(3, 87)
        Me.LDesc.Name = "LDesc"
        Me.LDesc.Size = New System.Drawing.Size(96, 23)
        Me.LDesc.TabIndex = 8
        Me.LDesc.Text = "Beschreibung"
        Me.LDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LDesc.Visible = False
        '
        'CLBPermissions
        '
        Me.CLBPermissions.FormattingEnabled = True
        Me.CLBPermissions.Items.AddRange(New Object() {"Projekt erstellen", "Projekt editieren", "Projekt löschen", "Kategorie erstellen", "Kategorie editieren", "Kategorie löschen", "Kamera erstellen", "Kamera editieren", "Kamera löschen", "Benutzer erstellen", "Benutzer editieren", "Benutzer löschen", "Benutzer-Gruppe erstellen", "Benutzer-Gruppe editieren", "Benutzer-Gruppe löschen", "Musik hinzufügen", "Musikeintrag bearbeiten", "Musik löschen", "Inventar Hinzufügen", "Inventareintrag bearbeiten", "Inventar löschen", "ext. Login", "Port verändern", "Server stoppen", "Server neustarten", "Konsole benutzen", "Daten neu einlesen"})
        Me.CLBPermissions.Location = New System.Drawing.Point(336, 102)
        Me.CLBPermissions.Name = "CLBPermissions"
        Me.CLBPermissions.Size = New System.Drawing.Size(182, 139)
        Me.CLBPermissions.TabIndex = 13
        Me.CLBPermissions.Visible = False
        '
        'LPermissions
        '
        Me.LPermissions.AutoSize = True
        Me.LPermissions.BackColor = System.Drawing.Color.Transparent
        Me.LPermissions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPermissions.ForeColor = System.Drawing.Color.White
        Me.LPermissions.Location = New System.Drawing.Point(282, 105)
        Me.LPermissions.Name = "LPermissions"
        Me.LPermissions.Size = New System.Drawing.Size(48, 13)
        Me.LPermissions.TabIndex = 14
        Me.LPermissions.Text = "Rechte"
        Me.LPermissions.Visible = False
        '
        'BTAboard
        '
        Me.BTAboard.BackColor = System.Drawing.Color.White
        Me.BTAboard.Location = New System.Drawing.Point(329, 382)
        Me.BTAboard.Name = "BTAboard"
        Me.BTAboard.Size = New System.Drawing.Size(75, 23)
        Me.BTAboard.TabIndex = 15
        Me.BTAboard.Text = "Abbrechen"
        Me.BTAboard.UseVisualStyleBackColor = False
        Me.BTAboard.Visible = False
        '
        'BTCreate
        '
        Me.BTCreate.BackColor = System.Drawing.Color.White
        Me.BTCreate.Location = New System.Drawing.Point(417, 382)
        Me.BTCreate.Name = "BTCreate"
        Me.BTCreate.Size = New System.Drawing.Size(75, 23)
        Me.BTCreate.TabIndex = 16
        Me.BTCreate.Text = "Erstellen"
        Me.BTCreate.UseVisualStyleBackColor = False
        Me.BTCreate.Visible = False
        '
        'Database1
        '
        Me.Database1.DataSetName = "database"
        Me.Database1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TVTemplates
        '
        Me.TVTemplates.Location = New System.Drawing.Point(603, 99)
        Me.TVTemplates.Name = "TVTemplates"
        Me.TVTemplates.Size = New System.Drawing.Size(178, 279)
        Me.TVTemplates.TabIndex = 17
        Me.TVTemplates.Visible = False
        '
        'LTemplate
        '
        Me.LTemplate.AutoSize = True
        Me.LTemplate.BackColor = System.Drawing.Color.Transparent
        Me.LTemplate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTemplate.ForeColor = System.Drawing.Color.White
        Me.LTemplate.Location = New System.Drawing.Point(538, 105)
        Me.LTemplate.Name = "LTemplate"
        Me.LTemplate.Size = New System.Drawing.Size(59, 13)
        Me.LTemplate.TabIndex = 18
        Me.LTemplate.Text = "Template"
        Me.LTemplate.Visible = False
        '
        'LInfo
        '
        Me.LInfo.AutoSize = True
        Me.LInfo.BackColor = System.Drawing.Color.Transparent
        Me.LInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LInfo.ForeColor = System.Drawing.Color.White
        Me.LInfo.Location = New System.Drawing.Point(787, 105)
        Me.LInfo.Name = "LInfo"
        Me.LInfo.Size = New System.Drawing.Size(33, 13)
        Me.LInfo.TabIndex = 20
        Me.LInfo.Text = "Info:"
        Me.LInfo.Visible = False
        '
        'TBInfo
        '
        Me.TBInfo.Location = New System.Drawing.Point(826, 99)
        Me.TBInfo.Multiline = True
        Me.TBInfo.Name = "TBInfo"
        Me.TBInfo.Size = New System.Drawing.Size(205, 142)
        Me.TBInfo.TabIndex = 21
        '
        'create
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(534, 424)
        Me.Controls.Add(Me.TBInfo)
        Me.Controls.Add(Me.LInfo)
        Me.Controls.Add(Me.LTemplate)
        Me.Controls.Add(Me.TVTemplates)
        Me.Controls.Add(Me.BTCreate)
        Me.Controls.Add(Me.BTAboard)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBMode)
        Me.Controls.Add(Me.LPermissions)
        Me.Controls.Add(Me.CLBPermissions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "create"
        Me.Text = "Erstellen"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.ProjectsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CBMode As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LDesc As Label
    Friend WithEvents TBDesc As TextBox
    Friend WithEvents LName As Label
    Friend WithEvents TBName As TextBox
    Friend WithEvents LPermissions As Label
    Friend WithEvents CLBPermissions As CheckedListBox
    Friend WithEvents CBActive As CheckBox
    Friend WithEvents TBPass As TextBox
    Friend WithEvents CBCat As ComboBox
    Friend WithEvents LCat As Label
    Friend WithEvents LPass As Label
    Friend WithEvents BTAboard As Button
    Friend WithEvents BTCreate As Button
    Friend WithEvents ProjectsBindingSource As BindingSource
    Friend WithEvents CBAdmin As CheckBox
    Friend WithEvents Database1 As database
    Protected Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TVTemplates As TreeView
    Friend WithEvents LTemplate As Label
    Friend WithEvents LInfo As Label
    Friend WithEvents TBInfo As TextBox
End Class
