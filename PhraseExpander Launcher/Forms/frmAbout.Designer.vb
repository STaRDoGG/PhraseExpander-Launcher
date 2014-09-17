<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.lblAboutDescription = New System.Windows.Forms.Label()
        Me.llPE = New System.Windows.Forms.LinkLabel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.llJSE = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'lblAboutDescription
        '
        Me.lblAboutDescription.Location = New System.Drawing.Point(14, 32)
        Me.lblAboutDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAboutDescription.Name = "lblAboutDescription"
        Me.lblAboutDescription.Size = New System.Drawing.Size(870, 310)
        Me.lblAboutDescription.TabIndex = 0
        Me.lblAboutDescription.Text = resources.GetString("lblAboutDescription.Text")
        '
        'llPE
        '
        Me.llPE.ActiveLinkColor = System.Drawing.Color.MidnightBlue
        Me.llPE.AutoSize = True
        Me.llPE.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llPE.LinkColor = System.Drawing.Color.SteelBlue
        Me.llPE.Location = New System.Drawing.Point(14, 324)
        Me.llPE.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.llPE.Name = "llPE"
        Me.llPE.Size = New System.Drawing.Size(201, 23)
        Me.llPE.TabIndex = 1
        Me.llPE.TabStop = True
        Me.llPE.Text = "PhraseExpander Website"
        Me.llPE.VisitedLinkColor = System.Drawing.Color.MidnightBlue
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(752, 324)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(107, 25)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'llJSE
        '
        Me.llJSE.ActiveLinkColor = System.Drawing.Color.MidnightBlue
        Me.llJSE.AutoSize = True
        Me.llJSE.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llJSE.LinkColor = System.Drawing.Color.SteelBlue
        Me.llJSE.Location = New System.Drawing.Point(554, 331)
        Me.llJSE.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.llJSE.Name = "llJSE"
        Me.llJSE.Size = New System.Drawing.Size(191, 16)
        Me.llJSE.TabIndex = 3
        Me.llJSE.TabStop = True
        Me.llJSE.Text = "Launcher created by J. Scott Elblein"
        Me.llJSE.VisitedLinkColor = System.Drawing.Color.MidnightBlue
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 374)
        Me.Controls.Add(Me.llJSE)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.llPE)
        Me.Controls.Add(Me.lblAboutDescription)
        Me.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbout"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About PhraseExpander Launcher"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAboutDescription As System.Windows.Forms.Label
    Friend WithEvents llPE As System.Windows.Forms.LinkLabel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents llJSE As System.Windows.Forms.LinkLabel
End Class
