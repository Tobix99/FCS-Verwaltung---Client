<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Hauptscreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hauptscreen))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSIRef = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSIExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.BearbeitenToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSINew = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSIEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSIDelte = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjkteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSIImport = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSIImportOtherData = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSIMusic = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarsystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSIUpdates = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ConsoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSIConsole = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSIRestart = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSIReload = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSICurrentClientVersion = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSIStopMachine = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSIStaticIP = New System.Windows.Forms.ToolStripMenuItem()
        Me.PremierePfadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuditionsPfadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NetzwerkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSINetworkusername = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSINetworkpassword = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSINetworkComputer = New System.Windows.Forms.ToolStripMenuItem()
        Me.LUsername = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSServerIP = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSOwnIP = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSPB1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.TSSImportFile = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.TSSEncoding = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BTFolderOpen = New System.Windows.Forms.Button()
        Me.openPremiere = New System.Windows.Forms.Button()
        Me.openinPremiere = New System.Windows.Forms.Button()
        Me.LVPro = New System.Windows.Forms.ListView()
        Me.CMSProject = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TSMCreatePro = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMEditPro = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMDelPro = New System.Windows.Forms.ToolStripMenuItem()
        Me.LVSmallImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LVCat = New System.Windows.Forms.ListView()
        Me.CMSCat = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TSMCreateCat = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMCatEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMDelCat = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LVCam = New System.Windows.Forms.ListView()
        Me.CMSCamera = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TSMCreateCam = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMCamEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMCamDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LVUser = New System.Windows.Forms.ListView()
        Me.CMSUser = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TSMCreateUsr = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMUsrEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMDelUsr = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LVUserGroups = New System.Windows.Forms.ListView()
        Me.CMSUserGroups = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TSMCreateUsG = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMUsGEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMDelUsG = New System.Windows.Forms.ToolStripMenuItem()
        Me.serverrestart = New System.ComponentModel.BackgroundWorker()
        Me.serverstop = New System.ComponentModel.BackgroundWorker()
        Me.Database1 = New FCS_Verwaltung___Client.database()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.LBLog = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.CMSProject.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.CMSCat.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.CMSCamera.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.CMSUser.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.CMSUserGroups.SuspendLayout()
        CType(Me.Database1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = CType(resources.GetObject("MenuStrip1.BackgroundImage"), System.Drawing.Image)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.BearbeitenToolStripMenuItem4, Me.ProjkteToolStripMenuItem, Me.ExtrasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1084, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSIRef, Me.TSIExit})
        Me.DateiToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "&Datei"
        '
        'TSIRef
        '
        Me.TSIRef.BackColor = System.Drawing.Color.White
        Me.TSIRef.Name = "TSIRef"
        Me.TSIRef.Size = New System.Drawing.Size(142, 22)
        Me.TSIRef.Text = "Aktualisieren"
        '
        'TSIExit
        '
        Me.TSIExit.Name = "TSIExit"
        Me.TSIExit.Size = New System.Drawing.Size(142, 22)
        Me.TSIExit.Text = "Beenden"
        '
        'BearbeitenToolStripMenuItem4
        '
        Me.BearbeitenToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSINew, Me.TSIEdit, Me.TSIDelte})
        Me.BearbeitenToolStripMenuItem4.ForeColor = System.Drawing.Color.White
        Me.BearbeitenToolStripMenuItem4.Name = "BearbeitenToolStripMenuItem4"
        Me.BearbeitenToolStripMenuItem4.Size = New System.Drawing.Size(60, 20)
        Me.BearbeitenToolStripMenuItem4.Text = "&Objekte"
        '
        'TSINew
        '
        Me.TSINew.Name = "TSINew"
        Me.TSINew.Size = New System.Drawing.Size(130, 22)
        Me.TSINew.Text = "Neu"
        '
        'TSIEdit
        '
        Me.TSIEdit.Name = "TSIEdit"
        Me.TSIEdit.Size = New System.Drawing.Size(130, 22)
        Me.TSIEdit.Text = "Bearbeiten"
        '
        'TSIDelte
        '
        Me.TSIDelte.Name = "TSIDelte"
        Me.TSIDelte.Size = New System.Drawing.Size(130, 22)
        Me.TSIDelte.Text = "Löschen"
        '
        'ProjkteToolStripMenuItem
        '
        Me.ProjkteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSIImport, Me.TSIImportOtherData, Me.TSIMusic, Me.InventarsystemToolStripMenuItem})
        Me.ProjkteToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ProjkteToolStripMenuItem.Name = "ProjkteToolStripMenuItem"
        Me.ProjkteToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ProjkteToolStripMenuItem.Text = "&Anderes"
        '
        'TSIImport
        '
        Me.TSIImport.Name = "TSIImport"
        Me.TSIImport.Size = New System.Drawing.Size(272, 22)
        Me.TSIImport.Text = "Videodatein für Projekt importieren"
        '
        'TSIImportOtherData
        '
        Me.TSIImportOtherData.Name = "TSIImportOtherData"
        Me.TSIImportOtherData.Size = New System.Drawing.Size(272, 22)
        Me.TSIImportOtherData.Text = "Andere Datein für Projekt importieren"
        '
        'TSIMusic
        '
        Me.TSIMusic.Name = "TSIMusic"
        Me.TSIMusic.Size = New System.Drawing.Size(272, 22)
        Me.TSIMusic.Text = "Musik"
        '
        'InventarsystemToolStripMenuItem
        '
        Me.InventarsystemToolStripMenuItem.Name = "InventarsystemToolStripMenuItem"
        Me.InventarsystemToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
        Me.InventarsystemToolStripMenuItem.Text = "Inventarsystem"
        '
        'ExtrasToolStripMenuItem
        '
        Me.ExtrasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSIUpdates, Me.ToolStripSeparator3, Me.ConsoleToolStripMenuItem, Me.ClientToolStripMenuItem, Me.NetzwerkToolStripMenuItem})
        Me.ExtrasToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ExtrasToolStripMenuItem.Name = "ExtrasToolStripMenuItem"
        Me.ExtrasToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.ExtrasToolStripMenuItem.Text = "&Extras"
        '
        'TSIUpdates
        '
        Me.TSIUpdates.Name = "TSIUpdates"
        Me.TSIUpdates.Size = New System.Drawing.Size(177, 22)
        Me.TSIUpdates.Text = "Auf Updates prüfen"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(174, 6)
        '
        'ConsoleToolStripMenuItem
        '
        Me.ConsoleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSIConsole, Me.TSIRestart, Me.TSIReload, Me.TSICurrentClientVersion, Me.TSIStopMachine})
        Me.ConsoleToolStripMenuItem.Name = "ConsoleToolStripMenuItem"
        Me.ConsoleToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ConsoleToolStripMenuItem.Text = "Server"
        '
        'TSIConsole
        '
        Me.TSIConsole.Name = "TSIConsole"
        Me.TSIConsole.Size = New System.Drawing.Size(179, 22)
        Me.TSIConsole.Text = "Console"
        '
        'TSIRestart
        '
        Me.TSIRestart.Name = "TSIRestart"
        Me.TSIRestart.Size = New System.Drawing.Size(179, 22)
        Me.TSIRestart.Text = "Neustarten"
        '
        'TSIReload
        '
        Me.TSIReload.Name = "TSIReload"
        Me.TSIReload.Size = New System.Drawing.Size(179, 22)
        Me.TSIReload.Text = "Neuladen"
        '
        'TSICurrentClientVersion
        '
        Me.TSICurrentClientVersion.Name = "TSICurrentClientVersion"
        Me.TSICurrentClientVersion.Size = New System.Drawing.Size(179, 22)
        Me.TSICurrentClientVersion.Text = "Client Version"
        '
        'TSIStopMachine
        '
        Me.TSIStopMachine.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSIStopMachine.Name = "TSIStopMachine"
        Me.TSIStopMachine.Size = New System.Drawing.Size(179, 22)
        Me.TSIStopMachine.Text = "Server ausschalten"
        '
        'ClientToolStripMenuItem
        '
        Me.ClientToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSIStaticIP, Me.PremierePfadToolStripMenuItem, Me.AuditionsPfadToolStripMenuItem})
        Me.ClientToolStripMenuItem.Name = "ClientToolStripMenuItem"
        Me.ClientToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ClientToolStripMenuItem.Text = "Client"
        '
        'TSIStaticIP
        '
        Me.TSIStaticIP.Name = "TSIStaticIP"
        Me.TSIStaticIP.Size = New System.Drawing.Size(152, 22)
        Me.TSIStaticIP.Text = "Static IP"
        '
        'PremierePfadToolStripMenuItem
        '
        Me.PremierePfadToolStripMenuItem.Name = "PremierePfadToolStripMenuItem"
        Me.PremierePfadToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PremierePfadToolStripMenuItem.Text = "Premiere Pfad"
        '
        'AuditionsPfadToolStripMenuItem
        '
        Me.AuditionsPfadToolStripMenuItem.Name = "AuditionsPfadToolStripMenuItem"
        Me.AuditionsPfadToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AuditionsPfadToolStripMenuItem.Text = "Auditions Pfad"
        '
        'NetzwerkToolStripMenuItem
        '
        Me.NetzwerkToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSINetworkusername, Me.TSINetworkpassword, Me.TSINetworkComputer})
        Me.NetzwerkToolStripMenuItem.Name = "NetzwerkToolStripMenuItem"
        Me.NetzwerkToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.NetzwerkToolStripMenuItem.Text = "Netzwerk"
        '
        'TSINetworkusername
        '
        Me.TSINetworkusername.Name = "TSINetworkusername"
        Me.TSINetworkusername.Size = New System.Drawing.Size(150, 22)
        Me.TSINetworkusername.Text = "Benutzername"
        '
        'TSINetworkpassword
        '
        Me.TSINetworkpassword.Name = "TSINetworkpassword"
        Me.TSINetworkpassword.Size = New System.Drawing.Size(150, 22)
        Me.TSINetworkpassword.Text = "Passwort"
        '
        'TSINetworkComputer
        '
        Me.TSINetworkComputer.Name = "TSINetworkComputer"
        Me.TSINetworkComputer.Size = New System.Drawing.Size(150, 22)
        Me.TSINetworkComputer.Text = "Computer"
        '
        'LUsername
        '
        Me.LUsername.AutoSize = True
        Me.LUsername.BackColor = System.Drawing.Color.Transparent
        Me.LUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LUsername.ForeColor = System.Drawing.Color.White
        Me.LUsername.Location = New System.Drawing.Point(168, 67)
        Me.LUsername.Name = "LUsername"
        Me.LUsername.Size = New System.Drawing.Size(145, 24)
        Me.LUsername.TabIndex = 3
        Me.LUsername.Text = "Benutzername"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackgroundImage = CType(resources.GetObject("StatusStrip1.BackgroundImage"), System.Drawing.Image)
        Me.StatusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.TSServerIP, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.TSSOwnIP, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5, Me.TSPB1, Me.TSSImportFile, Me.ToolStripStatusLabel6, Me.ToolStripStatusLabel7, Me.ToolStripProgressBar1, Me.TSSEncoding})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 469)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1084, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(91, 17)
        Me.ToolStripStatusLabel1.Text = "Verbunden mit: "
        '
        'TSServerIP
        '
        Me.TSServerIP.ForeColor = System.Drawing.Color.White
        Me.TSServerIP.Name = "TSServerIP"
        Me.TSServerIP.Size = New System.Drawing.Size(88, 17)
        Me.TSServerIP.Text = "000.000.000.000"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel2.Text = "|"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(58, 17)
        Me.ToolStripStatusLabel3.Text = "Eigene IP:"
        '
        'TSSOwnIP
        '
        Me.TSSOwnIP.ForeColor = System.Drawing.Color.White
        Me.TSSOwnIP.Name = "TSSOwnIP"
        Me.TSSOwnIP.Size = New System.Drawing.Size(88, 17)
        Me.TSSOwnIP.Text = "000.000.000.000"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel4.Text = "|"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(77, 17)
        Me.ToolStripStatusLabel5.Text = "Importstatus:"
        '
        'TSPB1
        '
        Me.TSPB1.Name = "TSPB1"
        Me.TSPB1.Size = New System.Drawing.Size(100, 16)
        '
        'TSSImportFile
        '
        Me.TSSImportFile.ForeColor = System.Drawing.Color.White
        Me.TSSImportFile.Name = "TSSImportFile"
        Me.TSSImportFile.Size = New System.Drawing.Size(43, 17)
        Me.TSSImportFile.Text = "File.ext"
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel6.Text = "|"
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(91, 17)
        Me.ToolStripStatusLabel7.Text = "Encodingstatus:"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'TSSEncoding
        '
        Me.TSSEncoding.ForeColor = System.Drawing.Color.White
        Me.TSSEncoding.Name = "TSSEncoding"
        Me.TSSEncoding.Size = New System.Drawing.Size(43, 17)
        Me.TSSEncoding.Text = "File.ext"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.BTFolderOpen)
        Me.GroupBox1.Controls.Add(Me.openPremiere)
        Me.GroupBox1.Controls.Add(Me.openinPremiere)
        Me.GroupBox1.Controls.Add(Me.LVPro)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(31, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(506, 174)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Projekte"
        '
        'BTFolderOpen
        '
        Me.BTFolderOpen.BackColor = System.Drawing.Color.White
        Me.BTFolderOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTFolderOpen.ForeColor = System.Drawing.Color.Black
        Me.BTFolderOpen.Location = New System.Drawing.Point(392, 123)
        Me.BTFolderOpen.Name = "BTFolderOpen"
        Me.BTFolderOpen.Size = New System.Drawing.Size(108, 43)
        Me.BTFolderOpen.TabIndex = 3
        Me.BTFolderOpen.Text = "Ordner Öffnen"
        Me.BTFolderOpen.UseVisualStyleBackColor = False
        '
        'openPremiere
        '
        Me.openPremiere.BackColor = System.Drawing.Color.White
        Me.openPremiere.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.openPremiere.ForeColor = System.Drawing.Color.Black
        Me.openPremiere.Location = New System.Drawing.Point(392, 19)
        Me.openPremiere.Name = "openPremiere"
        Me.openPremiere.Size = New System.Drawing.Size(108, 43)
        Me.openPremiere.TabIndex = 2
        Me.openPremiere.Text = "Premiere öffnen"
        Me.openPremiere.UseVisualStyleBackColor = False
        '
        'openinPremiere
        '
        Me.openinPremiere.BackColor = System.Drawing.Color.White
        Me.openinPremiere.Enabled = False
        Me.openinPremiere.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.openinPremiere.ForeColor = System.Drawing.Color.Black
        Me.openinPremiere.Location = New System.Drawing.Point(392, 70)
        Me.openinPremiere.Name = "openinPremiere"
        Me.openinPremiere.Size = New System.Drawing.Size(108, 43)
        Me.openinPremiere.TabIndex = 1
        Me.openinPremiere.Text = "Projekt in Premiere öffnen"
        Me.openinPremiere.UseVisualStyleBackColor = False
        '
        'LVPro
        '
        Me.LVPro.ContextMenuStrip = Me.CMSProject
        Me.LVPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVPro.Location = New System.Drawing.Point(6, 19)
        Me.LVPro.Name = "LVPro"
        Me.LVPro.Size = New System.Drawing.Size(380, 147)
        Me.LVPro.TabIndex = 0
        Me.LVPro.UseCompatibleStateImageBehavior = False
        Me.LVPro.View = System.Windows.Forms.View.SmallIcon
        '
        'CMSProject
        '
        Me.CMSProject.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMCreatePro, Me.TSMEditPro, Me.TSMDelPro})
        Me.CMSProject.Name = "CMSCamera"
        Me.CMSProject.Size = New System.Drawing.Size(131, 70)
        Me.CMSProject.Text = "Kamera"
        '
        'TSMCreatePro
        '
        Me.TSMCreatePro.Name = "TSMCreatePro"
        Me.TSMCreatePro.Size = New System.Drawing.Size(130, 22)
        Me.TSMCreatePro.Text = "Neu"
        '
        'TSMEditPro
        '
        Me.TSMEditPro.Name = "TSMEditPro"
        Me.TSMEditPro.Size = New System.Drawing.Size(130, 22)
        Me.TSMEditPro.Text = "Bearbeiten"
        '
        'TSMDelPro
        '
        Me.TSMDelPro.Name = "TSMDelPro"
        Me.TSMDelPro.Size = New System.Drawing.Size(130, 22)
        Me.TSMDelPro.Text = "Löschen"
        '
        'LVSmallImageList
        '
        Me.LVSmallImageList.ImageStream = CType(resources.GetObject("LVSmallImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.LVSmallImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.LVSmallImageList.Images.SetKeyName(0, "Graph1")
        Me.LVSmallImageList.Images.SetKeyName(1, "Graph2")
        Me.LVSmallImageList.Images.SetKeyName(2, "Graph3")
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.LVCat)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(31, 275)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(506, 174)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kategorien"
        '
        'LVCat
        '
        Me.LVCat.ContextMenuStrip = Me.CMSCat
        Me.LVCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVCat.Location = New System.Drawing.Point(6, 19)
        Me.LVCat.Name = "LVCat"
        Me.LVCat.Size = New System.Drawing.Size(494, 149)
        Me.LVCat.TabIndex = 6
        Me.LVCat.UseCompatibleStateImageBehavior = False
        Me.LVCat.View = System.Windows.Forms.View.Details
        '
        'CMSCat
        '
        Me.CMSCat.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMCreateCat, Me.TSMCatEdit, Me.TSMDelCat})
        Me.CMSCat.Name = "CMSCamera"
        Me.CMSCat.Size = New System.Drawing.Size(131, 70)
        Me.CMSCat.Text = "Kamera"
        '
        'TSMCreateCat
        '
        Me.TSMCreateCat.Name = "TSMCreateCat"
        Me.TSMCreateCat.Size = New System.Drawing.Size(130, 22)
        Me.TSMCreateCat.Text = "Neu"
        '
        'TSMCatEdit
        '
        Me.TSMCatEdit.Name = "TSMCatEdit"
        Me.TSMCatEdit.Size = New System.Drawing.Size(130, 22)
        Me.TSMCatEdit.Text = "Bearbeiten"
        '
        'TSMDelCat
        '
        Me.TSMDelCat.Name = "TSMDelCat"
        Me.TSMDelCat.Size = New System.Drawing.Size(130, 22)
        Me.TSMDelCat.Text = "Löschen"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.LVCam)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(543, 95)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(187, 174)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Kameras"
        '
        'LVCam
        '
        Me.LVCam.ContextMenuStrip = Me.CMSCamera
        Me.LVCam.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVCam.Location = New System.Drawing.Point(6, 19)
        Me.LVCam.Name = "LVCam"
        Me.LVCam.Size = New System.Drawing.Size(175, 147)
        Me.LVCam.TabIndex = 6
        Me.LVCam.UseCompatibleStateImageBehavior = False
        Me.LVCam.View = System.Windows.Forms.View.Details
        '
        'CMSCamera
        '
        Me.CMSCamera.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMCreateCam, Me.TSMCamEdit, Me.TSMCamDelete})
        Me.CMSCamera.Name = "CMSCamera"
        Me.CMSCamera.Size = New System.Drawing.Size(131, 70)
        Me.CMSCamera.Text = "Kamera"
        '
        'TSMCreateCam
        '
        Me.TSMCreateCam.Name = "TSMCreateCam"
        Me.TSMCreateCam.Size = New System.Drawing.Size(130, 22)
        Me.TSMCreateCam.Text = "Neu"
        '
        'TSMCamEdit
        '
        Me.TSMCamEdit.Name = "TSMCamEdit"
        Me.TSMCamEdit.Size = New System.Drawing.Size(130, 22)
        Me.TSMCamEdit.Text = "Bearbeiten"
        '
        'TSMCamDelete
        '
        Me.TSMCamDelete.Name = "TSMCamDelete"
        Me.TSMCamDelete.Size = New System.Drawing.Size(130, 22)
        Me.TSMCamDelete.Text = "Löschen"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.LVUser)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(543, 275)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(247, 174)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Benutzer"
        '
        'LVUser
        '
        Me.LVUser.ContextMenuStrip = Me.CMSUser
        Me.LVUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVUser.Location = New System.Drawing.Point(6, 19)
        Me.LVUser.Name = "LVUser"
        Me.LVUser.Size = New System.Drawing.Size(235, 149)
        Me.LVUser.TabIndex = 6
        Me.LVUser.UseCompatibleStateImageBehavior = False
        Me.LVUser.View = System.Windows.Forms.View.Details
        '
        'CMSUser
        '
        Me.CMSUser.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMCreateUsr, Me.TSMUsrEdit, Me.TSMDelUsr})
        Me.CMSUser.Name = "CMSCamera"
        Me.CMSUser.Size = New System.Drawing.Size(131, 70)
        Me.CMSUser.Text = "Kamera"
        '
        'TSMCreateUsr
        '
        Me.TSMCreateUsr.Name = "TSMCreateUsr"
        Me.TSMCreateUsr.Size = New System.Drawing.Size(130, 22)
        Me.TSMCreateUsr.Text = "Neu"
        '
        'TSMUsrEdit
        '
        Me.TSMUsrEdit.Name = "TSMUsrEdit"
        Me.TSMUsrEdit.Size = New System.Drawing.Size(130, 22)
        Me.TSMUsrEdit.Text = "Bearbeiten"
        '
        'TSMDelUsr
        '
        Me.TSMDelUsr.Name = "TSMDelUsr"
        Me.TSMDelUsr.Size = New System.Drawing.Size(130, 22)
        Me.TSMDelUsr.Text = "Löschen"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.LVUserGroups)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(796, 275)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(247, 174)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Benutzer-Gruppen"
        '
        'LVUserGroups
        '
        Me.LVUserGroups.ContextMenuStrip = Me.CMSUserGroups
        Me.LVUserGroups.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVUserGroups.Location = New System.Drawing.Point(6, 19)
        Me.LVUserGroups.Name = "LVUserGroups"
        Me.LVUserGroups.Size = New System.Drawing.Size(235, 149)
        Me.LVUserGroups.TabIndex = 6
        Me.LVUserGroups.UseCompatibleStateImageBehavior = False
        Me.LVUserGroups.View = System.Windows.Forms.View.Details
        '
        'CMSUserGroups
        '
        Me.CMSUserGroups.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMCreateUsG, Me.TSMUsGEdit, Me.TSMDelUsG})
        Me.CMSUserGroups.Name = "CMSCamera"
        Me.CMSUserGroups.Size = New System.Drawing.Size(131, 70)
        Me.CMSUserGroups.Text = "Kamera"
        '
        'TSMCreateUsG
        '
        Me.TSMCreateUsG.Name = "TSMCreateUsG"
        Me.TSMCreateUsG.Size = New System.Drawing.Size(130, 22)
        Me.TSMCreateUsG.Text = "Neu"
        '
        'TSMUsGEdit
        '
        Me.TSMUsGEdit.Name = "TSMUsGEdit"
        Me.TSMUsGEdit.Size = New System.Drawing.Size(130, 22)
        Me.TSMUsGEdit.Text = "Bearbeiten"
        '
        'TSMDelUsG
        '
        Me.TSMDelUsG.Name = "TSMDelUsG"
        Me.TSMDelUsG.Size = New System.Drawing.Size(130, 22)
        Me.TSMDelUsG.Text = "Löschen"
        '
        'serverrestart
        '
        '
        'serverstop
        '
        '
        'Database1
        '
        Me.Database1.DataSetName = "database"
        Me.Database1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.LBLog)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.White
        Me.GroupBox6.Location = New System.Drawing.Point(736, 95)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(307, 174)
        Me.GroupBox6.TabIndex = 11
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Log"
        Me.GroupBox6.Visible = False
        '
        'LBLog
        '
        Me.LBLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLog.FormattingEnabled = True
        Me.LBLog.HorizontalScrollbar = True
        Me.LBLog.Items.AddRange(New Object() {"Log"})
        Me.LBLog.Location = New System.Drawing.Point(6, 19)
        Me.LBLog.Name = "LBLog"
        Me.LBLog.Size = New System.Drawing.Size(295, 147)
        Me.LBLog.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(46, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Willkommen"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Visible = False
        '
        'Hauptscreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1084, 491)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.LUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Hauptscreen"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FCS-Server"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.CMSProject.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.CMSCat.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.CMSCamera.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.CMSUser.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.CMSUserGroups.ResumeLayout(False)
        CType(Me.Database1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DateiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TSIRef As ToolStripMenuItem
    Friend WithEvents LUsername As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents TSServerIP As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents TSSOwnIP As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents TSPB1 As ToolStripProgressBar
    Friend WithEvents TSSImportFile As ToolStripStatusLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LVSmallImageList As ImageList
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LVCat As ListView
    Friend WithEvents ProjkteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExtrasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TSIImport As ToolStripMenuItem
    Friend WithEvents TSIUpdates As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ConsoleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents LVCam As ListView
    Friend WithEvents TSIExit As ToolStripMenuItem
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents LVUser As ListView
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents LVUserGroups As ListView
    Friend WithEvents TSIConsole As ToolStripMenuItem
    Friend WithEvents TSIRestart As ToolStripMenuItem
    Friend WithEvents TSIReload As ToolStripMenuItem
    Friend WithEvents BearbeitenToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents TSINew As ToolStripMenuItem
    Friend WithEvents TSIEdit As ToolStripMenuItem
    Friend WithEvents TSIDelte As ToolStripMenuItem
    Friend WithEvents CMSCamera As ContextMenuStrip
    Friend WithEvents TSMCamDelete As ToolStripMenuItem
    Friend WithEvents serverrestart As System.ComponentModel.BackgroundWorker
    Friend WithEvents serverstop As System.ComponentModel.BackgroundWorker
    Friend WithEvents NetzwerkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TSINetworkusername As ToolStripMenuItem
    Friend WithEvents TSINetworkpassword As ToolStripMenuItem
    Friend WithEvents LVPro As ListView
    Friend WithEvents ToolStripStatusLabel6 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel7 As ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents TSSEncoding As ToolStripStatusLabel
    Friend WithEvents TSINetworkComputer As ToolStripMenuItem
    Friend WithEvents ClientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TSIStaticIP As ToolStripMenuItem
    Friend WithEvents openinPremiere As Button
    Friend WithEvents PremierePfadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Database1 As database
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents openPremiere As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TSIMusic As ToolStripMenuItem
    Friend WithEvents InventarsystemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TSIStopMachine As ToolStripMenuItem
    Friend WithEvents TSICurrentClientVersion As ToolStripMenuItem
    Friend WithEvents CMSProject As ContextMenuStrip
    Friend WithEvents TSMDelPro As ToolStripMenuItem
    Friend WithEvents CMSCat As ContextMenuStrip
    Friend WithEvents TSMDelCat As ToolStripMenuItem
    Friend WithEvents CMSUser As ContextMenuStrip
    Friend WithEvents TSMDelUsr As ToolStripMenuItem
    Friend WithEvents CMSUserGroups As ContextMenuStrip
    Friend WithEvents TSMDelUsG As ToolStripMenuItem
    Friend WithEvents TSMCreatePro As ToolStripMenuItem
    Friend WithEvents TSMEditPro As ToolStripMenuItem
    Friend WithEvents TSMCreateCat As ToolStripMenuItem
    Friend WithEvents TSMCatEdit As ToolStripMenuItem
    Friend WithEvents TSMCreateCam As ToolStripMenuItem
    Friend WithEvents TSMCamEdit As ToolStripMenuItem
    Friend WithEvents TSMCreateUsr As ToolStripMenuItem
    Friend WithEvents TSMUsrEdit As ToolStripMenuItem
    Friend WithEvents TSMCreateUsG As ToolStripMenuItem
    Friend WithEvents TSMUsGEdit As ToolStripMenuItem
    Friend WithEvents AuditionsPfadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LBLog As ListBox
    Friend WithEvents TSIImportOtherData As ToolStripMenuItem
    Friend WithEvents BTFolderOpen As Button
End Class
