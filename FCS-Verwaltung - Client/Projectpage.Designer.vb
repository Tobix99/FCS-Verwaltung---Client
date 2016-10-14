<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Projectpage
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LProject = New System.Windows.Forms.Label()
        Me.Database1 = New FCS_Verwaltung___Client.database()
        Me.LVDataOther = New System.Windows.Forms.ListView()
        Me.Datei = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Typ = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LVDatafiles = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.check_for_data = New System.Windows.Forms.Timer(Me.components)
        Me.check_for_dataother = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Database1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Projekt: "
        '
        'LProject
        '
        Me.LProject.AutoSize = True
        Me.LProject.Location = New System.Drawing.Point(64, 21)
        Me.LProject.Name = "LProject"
        Me.LProject.Size = New System.Drawing.Size(16, 13)
        Me.LProject.TabIndex = 1
        Me.LProject.Text = "---"
        '
        'Database1
        '
        Me.Database1.DataSetName = "database"
        Me.Database1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LVDataOther
        '
        Me.LVDataOther.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Datei, Me.Typ})
        Me.LVDataOther.FullRowSelect = True
        Me.LVDataOther.Location = New System.Drawing.Point(291, 37)
        Me.LVDataOther.MultiSelect = False
        Me.LVDataOther.Name = "LVDataOther"
        Me.LVDataOther.Size = New System.Drawing.Size(273, 147)
        Me.LVDataOther.TabIndex = 2
        Me.LVDataOther.UseCompatibleStateImageBehavior = False
        Me.LVDataOther.View = System.Windows.Forms.View.Details
        '
        'Datei
        '
        Me.Datei.Text = "Datei"
        Me.Datei.Width = 120
        '
        'Typ
        '
        Me.Typ.Text = "Typ"
        '
        'LVDatafiles
        '
        Me.LVDatafiles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.LVDatafiles.FullRowSelect = True
        Me.LVDatafiles.Location = New System.Drawing.Point(12, 37)
        Me.LVDatafiles.MultiSelect = False
        Me.LVDatafiles.Name = "LVDatafiles"
        Me.LVDatafiles.Size = New System.Drawing.Size(273, 147)
        Me.LVDatafiles.TabIndex = 4
        Me.LVDatafiles.UseCompatibleStateImageBehavior = False
        Me.LVDatafiles.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Datei"
        Me.ColumnHeader1.Width = 120
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Typ"
        '
        'check_for_data
        '
        Me.check_for_data.Interval = 500
        '
        'check_for_dataother
        '
        Me.check_for_dataother.Interval = 500
        '
        'Projectpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 357)
        Me.Controls.Add(Me.LVDatafiles)
        Me.Controls.Add(Me.LVDataOther)
        Me.Controls.Add(Me.LProject)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Projectpage"
        Me.Text = "Projectpage"
        CType(Me.Database1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LProject As Label
    Friend WithEvents Database1 As database
    Friend WithEvents LVDataOther As ListView
    Friend WithEvents Datei As ColumnHeader
    Friend WithEvents Typ As ColumnHeader
    Friend WithEvents LVDatafiles As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents check_for_data As Timer
    Friend WithEvents check_for_dataother As Timer
End Class
