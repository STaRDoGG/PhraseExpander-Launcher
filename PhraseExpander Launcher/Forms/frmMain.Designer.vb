<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnLaunch = New System.Windows.Forms.Button()
        Me.tmrLaunch = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsLocation = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pbLaunching = New System.Windows.Forms.ToolStripProgressBar()
        Me.Tooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkAutorun = New System.Windows.Forms.CheckBox()
        Me.txtMS = New System.Windows.Forms.TextBox()
        Me.cboStartup = New System.Windows.Forms.ComboBox()
        Me.chkHidden = New System.Windows.Forms.CheckBox()
        Me.btnTimerToggle = New System.Windows.Forms.Button()
        Me.grpDelay = New System.Windows.Forms.GroupBox()
        Me.lblFriendly = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.grpStartup = New System.Windows.Forms.GroupBox()
        Me.btnAddStartup = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.grpDelay.SuspendLayout()
        Me.grpStartup.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLaunch
        '
        Me.btnLaunch.Location = New System.Drawing.Point(266, 21)
        Me.btnLaunch.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnLaunch.Name = "btnLaunch"
        Me.btnLaunch.Size = New System.Drawing.Size(134, 60)
        Me.btnLaunch.TabIndex = 0
        Me.btnLaunch.Text = "Launch"
        Me.Tooltip.SetToolTip(Me.btnLaunch, "Click to manually launch PhraseExpander.")
        Me.btnLaunch.UseVisualStyleBackColor = True
        '
        'tmrLaunch
        '
        Me.tmrLaunch.Interval = 1000
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsLocation, Me.pbLaunching})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 243)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 14, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(410, 30)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsLocation
        '
        Me.tsLocation.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsLocation.Margin = New System.Windows.Forms.Padding(10, 3, 0, 2)
        Me.tsLocation.Name = "tsLocation"
        Me.tsLocation.Size = New System.Drawing.Size(78, 25)
        Me.tsLocation.Text = "PE Not Found"
        '
        'pbLaunching
        '
        Me.pbLaunching.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.pbLaunching.AutoSize = False
        Me.pbLaunching.Margin = New System.Windows.Forms.Padding(108, 3, 10, 3)
        Me.pbLaunching.Maximum = 1000000
        Me.pbLaunching.Name = "pbLaunching"
        Me.pbLaunching.Size = New System.Drawing.Size(200, 24)
        Me.pbLaunching.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbLaunching.ToolTipText = "Launchine PhraseExpander in ..."
        '
        'chkAutorun
        '
        Me.chkAutorun.AutoSize = True
        Me.chkAutorun.Location = New System.Drawing.Point(175, 35)
        Me.chkAutorun.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.chkAutorun.Name = "chkAutorun"
        Me.chkAutorun.Size = New System.Drawing.Size(69, 20)
        Me.chkAutorun.TabIndex = 3
        Me.chkAutorun.Text = "AutoRun"
        Me.Tooltip.SetToolTip(Me.chkAutorun, "Starts PhraseExpander minimized.")
        Me.chkAutorun.UseVisualStyleBackColor = True
        '
        'txtMS
        '
        Me.txtMS.Location = New System.Drawing.Point(8, 36)
        Me.txtMS.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txtMS.MaxLength = 9
        Me.txtMS.Name = "txtMS"
        Me.txtMS.Size = New System.Drawing.Size(74, 20)
        Me.txtMS.TabIndex = 2
        Me.txtMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Tooltip.SetToolTip(Me.txtMS, "Example: 5000 = 5 Seconds." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Note: Will round down to the nearest whole 1000)")
        Me.txtMS.WordWrap = False
        '
        'cboStartup
        '
        Me.cboStartup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStartup.FormattingEnabled = True
        Me.cboStartup.Items.AddRange(New Object() {"HKLM / RUN (Registry, Common)", "HKCU / RUN (Registry, User)", "Startup Folder (Common)", "Startup Folder (User)"})
        Me.cboStartup.Location = New System.Drawing.Point(8, 48)
        Me.cboStartup.MaxDropDownItems = 4
        Me.cboStartup.Name = "cboStartup"
        Me.cboStartup.Size = New System.Drawing.Size(239, 24)
        Me.cboStartup.TabIndex = 5
        Me.Tooltip.SetToolTip(Me.cboStartup, "Select the location to add this launcher to, for launching with Windows.")
        '
        'chkHidden
        '
        Me.chkHidden.AutoSize = True
        Me.chkHidden.Location = New System.Drawing.Point(175, 21)
        Me.chkHidden.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.chkHidden.Name = "chkHidden"
        Me.chkHidden.Size = New System.Drawing.Size(60, 20)
        Me.chkHidden.TabIndex = 4
        Me.chkHidden.Text = "Hidden"
        Me.Tooltip.SetToolTip(Me.chkHidden, "Hides the launcher when started.")
        Me.chkHidden.UseVisualStyleBackColor = True
        '
        'btnTimerToggle
        '
        Me.btnTimerToggle.Location = New System.Drawing.Point(266, 85)
        Me.btnTimerToggle.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btnTimerToggle.Name = "btnTimerToggle"
        Me.btnTimerToggle.Size = New System.Drawing.Size(134, 54)
        Me.btnTimerToggle.TabIndex = 1
        Me.btnTimerToggle.Text = "Pause Launch"
        Me.btnTimerToggle.UseVisualStyleBackColor = True
        '
        'grpDelay
        '
        Me.grpDelay.Controls.Add(Me.lblFriendly)
        Me.grpDelay.Controls.Add(Me.chkAutorun)
        Me.grpDelay.Controls.Add(Me.txtMS)
        Me.grpDelay.Controls.Add(Me.lblDescription)
        Me.grpDelay.Location = New System.Drawing.Point(12, 15)
        Me.grpDelay.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.grpDelay.Name = "grpDelay"
        Me.grpDelay.Padding = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.grpDelay.Size = New System.Drawing.Size(248, 124)
        Me.grpDelay.TabIndex = 6
        Me.grpDelay.TabStop = False
        Me.grpDelay.Text = " PhraseExpander Launch Options  "
        '
        'lblFriendly
        '
        Me.lblFriendly.AutoSize = True
        Me.lblFriendly.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblFriendly.Location = New System.Drawing.Point(87, 39)
        Me.lblFriendly.Name = "lblFriendly"
        Me.lblFriendly.Size = New System.Drawing.Size(0, 16)
        Me.lblFriendly.TabIndex = 15
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(6, 76)
        Me.lblDescription.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(213, 16)
        Me.lblDescription.TabIndex = 5
        Me.lblDescription.Text = "Delay before launching PhraseExpander (ms.)"
        '
        'grpStartup
        '
        Me.grpStartup.Controls.Add(Me.btnAbout)
        Me.grpStartup.Controls.Add(Me.chkHidden)
        Me.grpStartup.Controls.Add(Me.btnAddStartup)
        Me.grpStartup.Controls.Add(Me.cboStartup)
        Me.grpStartup.Location = New System.Drawing.Point(12, 145)
        Me.grpStartup.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.grpStartup.Name = "grpStartup"
        Me.grpStartup.Padding = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.grpStartup.Size = New System.Drawing.Size(388, 86)
        Me.grpStartup.TabIndex = 7
        Me.grpStartup.TabStop = False
        Me.grpStartup.Text = " Add Launcher to Startup "
        '
        'btnAddStartup
        '
        Me.btnAddStartup.Location = New System.Drawing.Point(253, 48)
        Me.btnAddStartup.Name = "btnAddStartup"
        Me.btnAddStartup.Size = New System.Drawing.Size(129, 24)
        Me.btnAddStartup.TabIndex = 6
        Me.btnAddStartup.Text = "Add"
        Me.btnAddStartup.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Location = New System.Drawing.Point(254, 18)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(128, 23)
        Me.btnAbout.TabIndex = 7
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 273)
        Me.Controls.Add(Me.grpStartup)
        Me.Controls.Add(Me.grpDelay)
        Me.Controls.Add(Me.btnTimerToggle)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnLaunch)
        Me.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.Opacity = 0.0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PhraseExpander Launcher"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.grpDelay.ResumeLayout(False)
        Me.grpDelay.PerformLayout()
        Me.grpStartup.ResumeLayout(False)
        Me.grpStartup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLaunch As System.Windows.Forms.Button
    Friend WithEvents tmrLaunch As System.Windows.Forms.Timer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Tooltip As System.Windows.Forms.ToolTip
    Friend WithEvents tsLocation As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnTimerToggle As System.Windows.Forms.Button
    Friend WithEvents pbLaunching As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents grpDelay As System.Windows.Forms.GroupBox
    Friend WithEvents chkAutorun As System.Windows.Forms.CheckBox
    Friend WithEvents txtMS As System.Windows.Forms.TextBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents grpStartup As System.Windows.Forms.GroupBox
    Friend WithEvents btnAddStartup As System.Windows.Forms.Button
    Friend WithEvents cboStartup As System.Windows.Forms.ComboBox
    Friend WithEvents lblFriendly As System.Windows.Forms.Label
    Friend WithEvents chkHidden As System.Windows.Forms.CheckBox
    Friend WithEvents btnAbout As System.Windows.Forms.Button

End Class
