<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.BTLogin = New System.Windows.Forms.Button()
        Me.TBUs = New System.Windows.Forms.TextBox()
        Me.MTBPass = New System.Windows.Forms.MaskedTextBox()
        Me.TBPort = New System.Windows.Forms.TextBox()
        Me.TBServerIP = New System.Windows.Forms.TextBox()
        Me.BTScan = New System.Windows.Forms.Button()
        Me.LBIP = New System.Windows.Forms.ListBox()
        Me.PBIP = New System.Windows.Forms.ProgressBar()
        Me.Thread1 = New System.ComponentModel.BackgroundWorker()
        Me.Thread2 = New System.ComponentModel.BackgroundWorker()
        Me.Thread3 = New System.ComponentModel.BackgroundWorker()
        Me.Thread4 = New System.ComponentModel.BackgroundWorker()
        Me.Thread5 = New System.ComponentModel.BackgroundWorker()
        Me.Thread6 = New System.ComponentModel.BackgroundWorker()
        Me.Thread7 = New System.ComponentModel.BackgroundWorker()
        Me.Thread8 = New System.ComponentModel.BackgroundWorker()
        Me.Thread9 = New System.ComponentModel.BackgroundWorker()
        Me.Thread10 = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'BTLogin
        '
        Me.BTLogin.BackColor = System.Drawing.Color.Transparent
        Me.BTLogin.BackgroundImage = CType(resources.GetObject("BTLogin.BackgroundImage"), System.Drawing.Image)
        Me.BTLogin.Location = New System.Drawing.Point(146, 156)
        Me.BTLogin.Name = "BTLogin"
        Me.BTLogin.Size = New System.Drawing.Size(75, 23)
        Me.BTLogin.TabIndex = 1
        Me.BTLogin.Text = "Login"
        Me.BTLogin.UseVisualStyleBackColor = False
        '
        'TBUs
        '
        Me.TBUs.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.FCS_Verwaltung___Client.My.MySettings.Default, "LastUsername", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TBUs.Location = New System.Drawing.Point(96, 51)
        Me.TBUs.Name = "TBUs"
        Me.TBUs.Size = New System.Drawing.Size(125, 20)
        Me.TBUs.TabIndex = 2
        Me.TBUs.Text = Global.FCS_Verwaltung___Client.My.MySettings.Default.LastUsername
        '
        'MTBPass
        '
        Me.MTBPass.Location = New System.Drawing.Point(96, 78)
        Me.MTBPass.Name = "MTBPass"
        Me.MTBPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.MTBPass.Size = New System.Drawing.Size(125, 20)
        Me.MTBPass.TabIndex = 5
        Me.MTBPass.Text = "IthebT?LFS"
        '
        'TBPort
        '
        Me.TBPort.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.FCS_Verwaltung___Client.My.MySettings.Default, "Port", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TBPort.Location = New System.Drawing.Point(96, 130)
        Me.TBPort.Name = "TBPort"
        Me.TBPort.Size = New System.Drawing.Size(125, 20)
        Me.TBPort.TabIndex = 10
        Me.TBPort.Text = Global.FCS_Verwaltung___Client.My.MySettings.Default.Port
        '
        'TBServerIP
        '
        Me.TBServerIP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.FCS_Verwaltung___Client.My.MySettings.Default, "LastServerIP", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TBServerIP.Location = New System.Drawing.Point(96, 104)
        Me.TBServerIP.Name = "TBServerIP"
        Me.TBServerIP.Size = New System.Drawing.Size(125, 20)
        Me.TBServerIP.TabIndex = 9
        Me.TBServerIP.Text = Global.FCS_Verwaltung___Client.My.MySettings.Default.LastServerIP
        '
        'BTScan
        '
        Me.BTScan.BackColor = System.Drawing.Color.Transparent
        Me.BTScan.BackgroundImage = CType(resources.GetObject("BTScan.BackgroundImage"), System.Drawing.Image)
        Me.BTScan.ForeColor = System.Drawing.Color.Black
        Me.BTScan.Location = New System.Drawing.Point(12, 156)
        Me.BTScan.Name = "BTScan"
        Me.BTScan.Size = New System.Drawing.Size(128, 23)
        Me.BTScan.TabIndex = 11
        Me.BTScan.Text = "nach Server Scannen"
        Me.BTScan.UseVisualStyleBackColor = False
        '
        'LBIP
        '
        Me.LBIP.FormattingEnabled = True
        Me.LBIP.Location = New System.Drawing.Point(227, 6)
        Me.LBIP.Name = "LBIP"
        Me.LBIP.Size = New System.Drawing.Size(170, 108)
        Me.LBIP.TabIndex = 12
        '
        'PBIP
        '
        Me.PBIP.BackColor = System.Drawing.Color.White
        Me.PBIP.Location = New System.Drawing.Point(227, 120)
        Me.PBIP.Name = "PBIP"
        Me.PBIP.Size = New System.Drawing.Size(170, 14)
        Me.PBIP.TabIndex = 13
        '
        'Thread1
        '
        '
        'Thread2
        '
        '
        'Thread3
        '
        '
        'Thread4
        '
        '
        'Thread5
        '
        '
        'Thread6
        '
        '
        'Thread7
        '
        '
        'Thread8
        '
        '
        'Thread9
        '
        '
        'Thread10
        '
        '
        'Login
        '
        Me.AcceptButton = Me.BTLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(227, 189)
        Me.Controls.Add(Me.PBIP)
        Me.Controls.Add(Me.LBIP)
        Me.Controls.Add(Me.BTScan)
        Me.Controls.Add(Me.TBPort)
        Me.Controls.Add(Me.TBServerIP)
        Me.Controls.Add(Me.MTBPass)
        Me.Controls.Add(Me.TBUs)
        Me.Controls.Add(Me.BTLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTLogin As Button
    Friend WithEvents TBUs As TextBox
    Friend WithEvents MTBPass As MaskedTextBox
    Friend WithEvents TBServerIP As TextBox
    Friend WithEvents TBPort As TextBox
    Friend WithEvents BTScan As Button
    Friend WithEvents LBIP As ListBox
    Friend WithEvents PBIP As ProgressBar
    Friend WithEvents Thread1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Thread2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Thread3 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Thread4 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Thread5 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Thread6 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Thread7 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Thread8 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Thread9 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Thread10 As System.ComponentModel.BackgroundWorker
End Class
