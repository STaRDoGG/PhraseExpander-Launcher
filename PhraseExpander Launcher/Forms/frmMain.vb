Imports Microsoft.Win32

Public Class frmMain

    ' Holds the path to PhraseExpander.exe
    Public strPE As String = String.Empty
    ' Holds the time until PE launch
    Public intDelay As Int32 = 5000
    ' Holds the current timer interval
    Public intCurrentValue As Int32 = 0

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' Let's first make sure PhraseExpander isn't already running, just so we don't try launching it more than necessary
        Dim p() As Process = Process.GetProcessesByName("PhraseExpander")

        If p.Count > 0 Then
            If (MessageBox.Show("PhraseExpander is already running. You must close it before using this Lancher." & Environment.NewLine & Environment.NewLine & "Should I close it now for you? (If you choose No, this launcher will just exit).", "PhaseExpander is already running ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) = DialogResult.Yes) Then

                ' If user wants the Running PE killed, do it for him
                ' Note: Would be a bit wiser to do a ForEach loop killing all instances of PE found, in case more than one was found, but I'm rushing this app.
                With p(0)
                    .Kill()
                    .WaitForExit()
                End With

            Else
                ' User chose not to have me kill PE for them, so just exit, we alreadly warned them how things need to be.
                Application.Exit()
            End If
        End If

        ' Continue processing
        Dim bExists As Boolean = False
        Try
            If Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\PhraseExpander.exe") IsNot Nothing Then
                bExists = True
                strPE = Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\PhraseExpander.exe", Nothing, "PE Not Found").ToString
            End If
        Finally
            Registry.LocalMachine.Close()
        End Try

        ' Attempts to automatically locate the PhraseExpander Path on the system
        If bExists = True Then
            With tsLocation
                .Text = "PE Found"
                .ForeColor = Color.SteelBlue
            End With
            Debug.Print("PE Found (Registry)")
        ElseIf FileIO.FileSystem.FileExists(Application.StartupPath & "/PhraseExpander.exe") = True Then
            strPE = Application.StartupPath & "/PhraseExpander.exe"
            With tsLocation
                .Text = "PE Found"
                .ForeColor = Color.Khaki
            End With
            Debug.Print("PE Found (Folder)")
        Else
            With tsLocation
                .Text = "PE Not Found"
                .ForeColor = Color.Red
            End With
            Debug.Print("PhraseExpander.exe wasn't found in the same folder as this launcher OR in the registry key: HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\PhraseExpander.exe. Maybe try a different registry key?")

            ' Alert user that PhraseExpander.exe wasn't found by this app
            MessageBox.Show("PhraseExpander.exe wasn't found, rendering this launcher useless." & Environment.NewLine & Environment.NewLine & "If you're positive that it's installed, then just copy this file to the same folder as PhraseExpander.exe and it should work then.", "Wait a minute, Champ ...", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Application.Exit()
        End If

        ' Read the saved settings and set them
        chkAutorun.Checked = My.Settings.AutoRun
        chkHidden.Checked = My.Settings.Hidden
        intDelay = Convert.ToInt32(My.Settings.Delay)
        pbLaunching.Maximum = Convert.ToInt32(My.Settings.Delay)
        txtMS.Text = My.Settings.Delay.ToString

        If My.Application.CommandLineArgs.Count > 0 Then
            ' Get any command line arguments: if "-hidden", run this app invisibly. (Currently -hidden is the only available argument)
            For Each argument As String In My.Application.CommandLineArgs
                If argument.ToLower.StartsWith("-hidden") Then
                    ' Hide the app
                    ' Note: The form is set to 0% opacity on launch anyway, so technically this isn't necessary, but helps when reading the code to follow the flow
                    Me.Opacity = 0%
                Else
                    ' Show the app if the param isn't "-hidden"
                    ' Note: This isnt the best way to write this, since if adding any future params, it'll always hit this if it's not a "-hidden" param
                    Me.Opacity = 100%
                End If
            Next
        Else
            ' Show the app
            ' Note: Again, not the most effiecent way to write this; would be better to only do "Me.Opacity = 100%" once
            Me.Opacity = 100%
        End If

        Me.Text = "PhraseExpander Launcher v" & Application.ProductVersion & " [ßeta]"

        ' Start the countdown ...
        tmrLaunch.Enabled = True

    End Sub

#Region "Delay Related Functions"

    Private Sub txtMS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMS.KeyPress

        ' Only allow numbers in the text field
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub txtMS_TextChanged(sender As Object, e As EventArgs) Handles txtMS.TextChanged

        Dim intEntered As Int32 = Convert.ToInt32(txtMS.Text)

        ' Save the delay to settings as user types them (Default to 5000 if 0 length, less than 1 or greater than 999999999)
        If txtMS.Text.Length = 0 OrElse intEntered < 1 OrElse intEntered > 999999999 Then
            My.Settings.Delay = "5000"
        Else
            My.Settings.Delay = RoundDownToWholeMilliseconds(intEntered.ToString)
        End If

        ' Save the change to the Timer & Progressbar
        intDelay = Convert.ToInt32(My.Settings.Delay)
        pbLaunching.Maximum = Convert.ToInt32(My.Settings.Delay)

    End Sub

    Public Function RoundDownToWholeMilliseconds(strNumber As String) As String
        ' This function does a very rudimentary rounding of the number passed to it. It only rounds down, not up, 
        ' but this is just fine for a very simple launcher utility like this.

        ' Divide the given number by 1000
        Dim rounded As Int32 = Convert.ToInt32(strNumber) \ 1000

        ' Take the divided # and append 0's to the end, the length of the original given number (i.e. 1250 \ 1000 = 12, 12 + 4 padded 0's = 1200)
        rounded = Convert.ToInt32(rounded.ToString.PadRight(strNumber.Length, Convert.ToChar("0")))

        ' Since we're rounding to Seconds, if the number ends up being less than 1000 milliseconds (1 second), round it up to 1000.
        If rounded < 1000 Then
            rounded = 1000
            ' Update the label
            lblFriendly.Text = "1 sec."
        End If

        ' Update the label
        lblFriendly.Text = (rounded \ 1000).ToString & " secs."

        ' Return the resulting rounded number
        Return rounded.ToString

    End Function

#End Region

#Region "Timer Related Functions"

    Private Sub btnTimerToggle_Click(sender As Object, e As EventArgs) Handles btnTimerToggle.Click

        ' Allows Pausing/Resuming the launch timer
        If tmrLaunch.Enabled = True Then
            btnTimerToggle.Text = "Resume Launch"
        Else
            btnTimerToggle.Text = "Pause Launch"
        End If

        tmrLaunch.Enabled = Not tmrLaunch.Enabled
        pbLaunching.Visible = Not pbLaunching.Visible

    End Sub

    Private Sub tmrLaunch_Tick(sender As Object, e As EventArgs) Handles tmrLaunch.Tick

        ' Increase the counter
        intCurrentValue = intCurrentValue + 1000
        ' Set the progressbar value
        pbLaunching.Value = intCurrentValue ' ## error here while running

        ' If it's time to launch PE, then let's go!
        If intCurrentValue >= intDelay Then

            ' Stop this timer to prevent an error while app closes
            tmrLaunch.Enabled = False

            ' Fire it up! (timed)
            LaunchPE()

            ' And then exit the app (Takes the lazy way out, by not confirming whether or not the launch actually succeded or failed though.)
            Application.Exit()
        End If

    End Sub

#End Region

#Region "Check Boxes"

    Private Sub chkAutorun_CheckedChanged(sender As Object, e As EventArgs) Handles chkAutorun.CheckedChanged
        ' Save the state of the checkbox
        My.Settings.AutoRun = chkAutorun.Checked
    End Sub

    Private Sub chkHidden_CheckedChanged(sender As Object, e As EventArgs) Handles chkHidden.CheckedChanged
        ' Save the state of the checkbox
        My.Settings.Hidden = chkHidden.Checked
    End Sub

#End Region

    Private Sub btnLaunch_Click(sender As Object, e As EventArgs) Handles btnLaunch.Click
        ' Fire it up! (manually)
        LaunchPE()
        ' Note: No automatic app exit, since we may want to tinker more yet.
    End Sub

    Public Sub LaunchPE()

        If strPE.Length > 0 Then

            If chkAutorun.Checked = True Then
                ' Add the /autorun param if user selected it
                Process.Start(strPE, "/autorun")
            Else
                ' Otherwise just run it w/out the parameter
                Process.Start(strPE)
            End If

            With tsLocation
                .Text = "LAUNCHING! ..."
                .Font = New Font(tsLocation.Font, FontStyle.Bold)
                .ForeColor = Color.Green
            End With
        Else
            MessageBox.Show("Couldn't find PhaseExpander on your computer, so I can't launch it for you.", "No Go!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnAddStartup_Click(sender As Object, e As EventArgs) Handles btnAddStartup.Click

        ' TODO: when one is selected, remove all others (checking for existence first?)

        ' Make sure an action was actually selected first
        If Not cboStartup.SelectedIndex = -1 Then

            ' Store the path to this launcher
            Dim strPath As String = """" & Application.ExecutablePath & """"

            ' Add the -hidden param to the path if desired
            If chkHidden.Checked = True Then
                strPath &= " -hidden"
            End If

            Select Case cboStartup.SelectedIndex

                Case 0
                    ' HKLM
                    Dim Key As RegistryKey

                    If Environment.Is64BitOperatingSystem = True Then
                        ' If OS is 64 bit, add to the 64 bit OS key
                        Key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Run", True)
                    Else
                        ' Otherwise, add to the 32 bit OS key
                        Key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", True)
                    End If

                    Key.SetValue("PhraseExpander Launcher", strPath)
                    Key.Close()
                Case 1
                    ' HKCU
                    Dim Key As RegistryKey
                    Key = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", True)
                    Key.SetValue("PhraseExpander Launcher", strPath)
                    Key.Close()
                Case 2
                    ' Startup Folder (Common)
                    If chkHidden.Checked = True Then
                        CreateShortcut(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup), Application.ProductName, "-hidden")
                    Else
                        CreateShortcut(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup), Application.ProductName)
                    End If
                Case 3
                    ' Startup Folder (User)
                    If chkHidden.Checked = True Then
                        CreateShortcut(Environment.GetFolderPath(Environment.SpecialFolder.Startup), Application.ProductName, "-hidden")
                    Else
                        CreateShortcut(Environment.GetFolderPath(Environment.SpecialFolder.Startup), Application.ProductName)
                    End If
            End Select

            ' Again, being lazy here; not checking for genuine success/failure, so essentially this message box is just to alert user that the action finished
            MessageBox.Show("Added PhraseExpander Launcher to your Windows Startup.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        ' Shows the "About" window
        frmAbout.ShowDialog()
    End Sub
End Class
