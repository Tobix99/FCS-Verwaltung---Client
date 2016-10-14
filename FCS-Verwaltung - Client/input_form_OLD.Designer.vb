<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class input_form_OLD
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
        Me.BTCreate = New System.Windows.Forms.Button()
        Me.BTAbort = New System.Windows.Forms.Button()
        Me.LName = New System.Windows.Forms.Label()
        Me.TBName = New System.Windows.Forms.TextBox()
        Me.LDesc = New System.Windows.Forms.Label()
        Me.TBDesc = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LCat = New System.Windows.Forms.Label()
        Me.CBCat = New System.Windows.Forms.ComboBox()
        Me.LPass = New System.Windows.Forms.Label()
        Me.TBPass = New System.Windows.Forms.TextBox()
        Me.CBActive = New System.Windows.Forms.CheckBox()
        Me.CLBPermissions = New System.Windows.Forms.CheckedListBox()
        Me.LPermissions = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTCreate
        '
        Me.BTCreate.Location = New System.Drawing.Point(343, 228)
        Me.BTCreate.Name = "BTCreate"
        Me.BTCreate.Size = New System.Drawing.Size(75, 23)
        Me.BTCreate.TabIndex = 0
        Me.BTCreate.Text = "Erstellen"
        Me.BTCreate.UseVisualStyleBackColor = True
        '
        'BTAbort
        '
        Me.BTAbort.Location = New System.Drawing.Point(424, 228)
        Me.BTAbort.Name = "BTAbort"
        Me.BTAbort.Size = New System.Drawing.Size(75, 23)
        Me.BTAbort.TabIndex = 1
        Me.BTAbort.Text = "Abbrechen"
        Me.BTAbort.UseVisualStyleBackColor = True
        '
        'LName
        '
        Me.LName.AutoSize = True
        Me.LName.Location = New System.Drawing.Point(3, 0)
        Me.LName.Name = "LName"
        Me.LName.Size = New System.Drawing.Size(38, 13)
        Me.LName.TabIndex = 2
        Me.LName.Text = "Name:"
        '
        'TBName
        '
        Me.TBName.Location = New System.Drawing.Point(84, 3)
        Me.TBName.Name = "TBName"
        Me.TBName.Size = New System.Drawing.Size(154, 20)
        Me.TBName.TabIndex = 3
        '
        'LDesc
        '
        Me.LDesc.AutoSize = True
        Me.LDesc.Location = New System.Drawing.Point(3, 26)
        Me.LDesc.Name = "LDesc"
        Me.LDesc.Size = New System.Drawing.Size(75, 13)
        Me.LDesc.TabIndex = 4
        Me.LDesc.Text = "Beschreibung:"
        '
        'TBDesc
        '
        Me.TBDesc.Location = New System.Drawing.Point(84, 29)
        Me.TBDesc.Multiline = True
        Me.TBDesc.Name = "TBDesc"
        Me.TBDesc.Size = New System.Drawing.Size(154, 94)
        Me.TBDesc.TabIndex = 5
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.TBDesc, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LDesc, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TBName, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LName, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LCat, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.CBCat, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LPass, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TBPass, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.CBActive, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LPermissions, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.CLBPermissions, 3, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(487, 210)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'LCat
        '
        Me.LCat.AutoSize = True
        Me.LCat.Location = New System.Drawing.Point(3, 126)
        Me.LCat.Name = "LCat"
        Me.LCat.Size = New System.Drawing.Size(55, 13)
        Me.LCat.TabIndex = 6
        Me.LCat.Text = "Kategorie:"
        Me.LCat.Visible = False
        '
        'CBCat
        '
        Me.CBCat.FormattingEnabled = True
        Me.CBCat.Location = New System.Drawing.Point(84, 129)
        Me.CBCat.Name = "CBCat"
        Me.CBCat.Size = New System.Drawing.Size(154, 21)
        Me.CBCat.TabIndex = 7
        Me.CBCat.Visible = False
        '
        'LPass
        '
        Me.LPass.AutoSize = True
        Me.LPass.Location = New System.Drawing.Point(3, 153)
        Me.LPass.Name = "LPass"
        Me.LPass.Size = New System.Drawing.Size(53, 13)
        Me.LPass.TabIndex = 8
        Me.LPass.Text = "Passwort:"
        Me.LPass.Visible = False
        '
        'TBPass
        '
        Me.TBPass.Location = New System.Drawing.Point(84, 156)
        Me.TBPass.Name = "TBPass"
        Me.TBPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBPass.Size = New System.Drawing.Size(154, 20)
        Me.TBPass.TabIndex = 9
        Me.TBPass.Visible = False
        '
        'CBActive
        '
        Me.CBActive.AutoSize = True
        Me.CBActive.Checked = True
        Me.CBActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBActive.Location = New System.Drawing.Point(84, 182)
        Me.CBActive.Name = "CBActive"
        Me.CBActive.Size = New System.Drawing.Size(70, 17)
        Me.CBActive.TabIndex = 10
        Me.CBActive.Text = "Aktiviert?"
        Me.CBActive.UseVisualStyleBackColor = True
        Me.CBActive.Visible = False
        '
        'CLBPermissions
        '
        Me.CLBPermissions.FormattingEnabled = True
        Me.CLBPermissions.Items.AddRange(New Object() {"Projekt erstellen", "Projekt editieren", "Projekt löschen", "Kategorie erstellen", "Kategorie editieren", "Kategorie löschen", "Kamera erstellen", "Kamera editieren", "Kamera löschen", "Benutzer erstellen", "Benutzer editieren", "Benutzer löschen", "Benutzer-Gruppe erstellen", "Benutzer-Gruppe editieren", "Benutzer-Gruppe löschen", "ext. Login", "Port verändern", "Server stoppen", "Server neustarten"})
        Me.CLBPermissions.Location = New System.Drawing.Point(295, 29)
        Me.CLBPermissions.Name = "CLBPermissions"
        Me.CLBPermissions.Size = New System.Drawing.Size(154, 94)
        Me.CLBPermissions.TabIndex = 11
        Me.CLBPermissions.Visible = False
        '
        'LPermissions
        '
        Me.LPermissions.AutoSize = True
        Me.LPermissions.Location = New System.Drawing.Point(244, 26)
        Me.LPermissions.Name = "LPermissions"
        Me.LPermissions.Size = New System.Drawing.Size(45, 13)
        Me.LPermissions.TabIndex = 12
        Me.LPermissions.Text = "Rechte:"
        Me.LPermissions.Visible = False
        '
        'input_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 260)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.BTAbort)
        Me.Controls.Add(Me.BTCreate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "input_form"
        Me.Text = "Eingabe"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTCreate As Button
    Friend WithEvents BTAbort As Button
    Friend WithEvents LName As Label
    Friend WithEvents TBName As TextBox
    Friend WithEvents LDesc As Label
    Friend WithEvents TBDesc As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LCat As Label
    Friend WithEvents CBCat As ComboBox
    Friend WithEvents LPass As Label
    Friend WithEvents TBPass As TextBox
    Friend WithEvents CBActive As CheckBox
    Friend WithEvents CLBPermissions As CheckedListBox
    Friend WithEvents LPermissions As Label
End Class
