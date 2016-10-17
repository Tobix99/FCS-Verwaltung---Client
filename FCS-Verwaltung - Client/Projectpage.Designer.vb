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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Projectpage))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LProject = New System.Windows.Forms.Label()
        Me.Database1 = New FCS_Verwaltung___Client.database()
        Me.LVDataOther = New System.Windows.Forms.ListView()
        Me.Datei = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Typ = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.check_for_data = New System.Windows.Forms.Timer(Me.components)
        Me.check_for_dataother = New System.Windows.Forms.Timer(Me.components)
        Me.TVData = New System.Windows.Forms.TreeView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.QTPlayer = New AxQTOControlLib.AxQTControl()
        Me.TBOtherData = New System.Windows.Forms.TextBox()
        Me.Size = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.Database1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QTPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LVDataOther.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Datei, Me.Typ, Me.Size})
        Me.LVDataOther.FullRowSelect = True
        Me.LVDataOther.Location = New System.Drawing.Point(328, 37)
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
        'check_for_data
        '
        Me.check_for_data.Interval = 500
        '
        'check_for_dataother
        '
        Me.check_for_dataother.Interval = 500
        '
        'TVData
        '
        Me.TVData.Location = New System.Drawing.Point(15, 37)
        Me.TVData.Name = "TVData"
        Me.TVData.Size = New System.Drawing.Size(307, 147)
        Me.TVData.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(325, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Label2"
        '
        'QTPlayer
        '
        Me.QTPlayer.Enabled = True
        Me.QTPlayer.Location = New System.Drawing.Point(12, 190)
        Me.QTPlayer.Name = "QTPlayer"
        Me.QTPlayer.OcxState = CType(resources.GetObject("QTPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.QTPlayer.Size = New System.Drawing.Size(310, 205)
        Me.QTPlayer.TabIndex = 12
        '
        'TBOtherData
        '
        Me.TBOtherData.Location = New System.Drawing.Point(328, 190)
        Me.TBOtherData.Multiline = True
        Me.TBOtherData.Name = "TBOtherData"
        Me.TBOtherData.ReadOnly = True
        Me.TBOtherData.Size = New System.Drawing.Size(273, 205)
        Me.TBOtherData.TabIndex = 13
        '
        'Size
        '
        Me.Size.Text = "Größe"
        '
        'Projectpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 407)
        Me.Controls.Add(Me.TBOtherData)
        Me.Controls.Add(Me.QTPlayer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TVData)
        Me.Controls.Add(Me.LVDataOther)
        Me.Controls.Add(Me.LProject)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Projectpage"
        Me.Text = "Projectpage"
        CType(Me.Database1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QTPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LProject As Label
    Friend WithEvents Database1 As database
    Friend WithEvents LVDataOther As ListView
    Friend WithEvents Datei As ColumnHeader
    Friend WithEvents Typ As ColumnHeader
    Friend WithEvents check_for_data As Timer
    Friend WithEvents check_for_dataother As Timer
    Friend WithEvents TVData As TreeView
    Friend WithEvents Label2 As Label
    Friend WithEvents QTPlayer As AxQTOControlLib.AxQTControl
    Friend WithEvents TBOtherData As TextBox
    Friend WithEvents Size As ColumnHeader
End Class
