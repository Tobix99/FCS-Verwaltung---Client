<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class import_form_other
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(import_form_other))
        Me.PBCopy = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBCam = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBPro = New System.Windows.Forms.ComboBox()
        Me.BTSubmit = New System.Windows.Forms.Button()
        Me.BTSel = New System.Windows.Forms.Button()
        Me.Database1 = New FCS_Verwaltung___Client.database()
        Me.ImportDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.Database1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBCopy
        '
        Me.PBCopy.BackColor = System.Drawing.Color.White
        Me.PBCopy.Location = New System.Drawing.Point(17, 147)
        Me.PBCopy.Name = "PBCopy"
        Me.PBCopy.Size = New System.Drawing.Size(268, 23)
        Me.PBCopy.Step = 1
        Me.PBCopy.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.PBCopy.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(14, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Art"
        '
        'CBCam
        '
        Me.CBCam.FormattingEnabled = True
        Me.CBCam.Items.AddRange(New Object() {"Bild", "Audio", "Text", "Projektdateien"})
        Me.CBCam.Location = New System.Drawing.Point(77, 108)
        Me.CBCam.Name = "CBCam"
        Me.CBCam.Size = New System.Drawing.Size(208, 21)
        Me.CBCam.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(14, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Projekt"
        '
        'CBPro
        '
        Me.CBPro.FormattingEnabled = True
        Me.CBPro.Location = New System.Drawing.Point(77, 81)
        Me.CBPro.Name = "CBPro"
        Me.CBPro.Size = New System.Drawing.Size(208, 21)
        Me.CBPro.TabIndex = 7
        '
        'BTSubmit
        '
        Me.BTSubmit.BackColor = System.Drawing.Color.White
        Me.BTSubmit.Location = New System.Drawing.Point(304, 106)
        Me.BTSubmit.Name = "BTSubmit"
        Me.BTSubmit.Size = New System.Drawing.Size(75, 23)
        Me.BTSubmit.TabIndex = 13
        Me.BTSubmit.Text = "Übertragen"
        Me.BTSubmit.UseVisualStyleBackColor = False
        Me.BTSubmit.Visible = False
        '
        'BTSel
        '
        Me.BTSel.BackColor = System.Drawing.Color.White
        Me.BTSel.Location = New System.Drawing.Point(304, 79)
        Me.BTSel.Name = "BTSel"
        Me.BTSel.Size = New System.Drawing.Size(75, 23)
        Me.BTSel.TabIndex = 12
        Me.BTSel.Text = "Auswählen"
        Me.BTSel.UseVisualStyleBackColor = False
        '
        'Database1
        '
        Me.Database1.DataSetName = "database"
        Me.Database1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ImportDialog
        '
        Me.ImportDialog.Multiselect = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(328, 147)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'import_form_other
        '
        Me.AcceptButton = Me.BTSel
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(426, 194)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BTSubmit)
        Me.Controls.Add(Me.BTSel)
        Me.Controls.Add(Me.PBCopy)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CBCam)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBPro)
        Me.Name = "import_form_other"
        Me.Text = "Andere Datein Importieren"
        CType(Me.Database1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PBCopy As ProgressBar
    Friend WithEvents Label2 As Label
    Friend WithEvents CBCam As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CBPro As ComboBox
    Friend WithEvents BTSubmit As Button
    Friend WithEvents BTSel As Button
    Friend WithEvents Database1 As database
    Friend WithEvents ImportDialog As OpenFileDialog
    Friend WithEvents Button1 As Button
End Class
