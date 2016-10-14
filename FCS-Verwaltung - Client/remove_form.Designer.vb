<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class remove_form
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(remove_form))
        Me.CBMode = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LName = New System.Windows.Forms.Label()
        Me.CBName = New System.Windows.Forms.ComboBox()
        Me.BTDel = New System.Windows.Forms.Button()
        Me.Database1 = New FCS_Verwaltung___Client.database()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Database1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CBMode
        '
        Me.CBMode.FormattingEnabled = True
        Me.CBMode.Items.AddRange(New Object() {"Projekt", "Kategorie", "Kamera", "Benutzer", "Benutzer-Gruppe"})
        Me.CBMode.Location = New System.Drawing.Point(125, 63)
        Me.CBMode.Name = "CBMode"
        Me.CBMode.Size = New System.Drawing.Size(121, 21)
        Me.CBMode.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(27, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Modus wählen"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 221.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LName, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CBName, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(27, 90)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(310, 31)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'LName
        '
        Me.LName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LName.AutoSize = True
        Me.LName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LName.ForeColor = System.Drawing.Color.White
        Me.LName.Location = New System.Drawing.Point(3, 7)
        Me.LName.Name = "LName"
        Me.LName.Size = New System.Drawing.Size(39, 13)
        Me.LName.TabIndex = 0
        Me.LName.Text = "Name"
        Me.LName.Visible = False
        '
        'CBName
        '
        Me.CBName.FormattingEnabled = True
        Me.CBName.Location = New System.Drawing.Point(98, 3)
        Me.CBName.Name = "CBName"
        Me.CBName.Size = New System.Drawing.Size(121, 21)
        Me.CBName.TabIndex = 1
        Me.CBName.Visible = False
        '
        'BTDel
        '
        Me.BTDel.BackColor = System.Drawing.Color.White
        Me.BTDel.Location = New System.Drawing.Point(31, 136)
        Me.BTDel.Name = "BTDel"
        Me.BTDel.Size = New System.Drawing.Size(75, 23)
        Me.BTDel.TabIndex = 2
        Me.BTDel.Text = "Löschen"
        Me.BTDel.UseVisualStyleBackColor = False
        '
        'Database1
        '
        Me.Database1.DataSetName = "database"
        Me.Database1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'remove_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(368, 191)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTDel)
        Me.Controls.Add(Me.CBMode)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "remove_form"
        Me.Text = "Löschen"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.Database1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CBMode As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Database1 As database
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LName As Label
    Friend WithEvents CBName As ComboBox
    Friend WithEvents BTDel As Button
End Class
