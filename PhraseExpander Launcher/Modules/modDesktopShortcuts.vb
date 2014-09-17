Option Strict Off
Module modDesktopShortcuts

    ' STARTUP folders (The folders where programs launch at log in / boot up)
    'Dim userStartupFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup)
    'Dim commonStartupFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup)

    ' Start MENU folders (The list at the top of the Start Menu)
    'Dim userStartMenuFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.StartMenu)
    'Dim commonStartMenuFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu)

    ' ----------------------------------------------------------------------------------------------------------

    Public Function CheckShortcut(strShortcutLocation As String, strShortcutName As String) As Boolean
        ' Function checks to see if shortcut exists.
        ' 
        ' Returns FALSE = shortcut does't exist, TRUE if shortcut exists
        ' It is highly recommended to call this sub first. 

        CheckShortcut = False

        ' If the shortcut file doesn't exists, a message box will prompt the user if they want to continue creating the shortcut. 
        If IO.File.Exists(strShortcutLocation & "\" & strShortcutName & ".lnk") Then
            ' Shortcut exists
            CheckShortcut = True
        End If

        Return CheckShortcut

    End Function

    Public Function CreateShortcut(strShortcutLocation As String, strShortcutName As String, Optional strParamaters As String = "") As Boolean
        ' Function creates a shortcut.
        ' 
        ' Returns TRUE if success, FALSE if failure

        CreateShortcut = True

        Try
            Dim objShell As New Object
            Dim objLink As New Object

            objShell = CreateObject("WScript.Shell")

            ' Any added paramaters?
            If strParamaters.Length > 0 Then

            End If

            ' Create the .lnk file
            objLink = objShell.CreateShortcut(strShortcutLocation & "\" & strShortcutName & ".lnk")

            ' Sets the shortcut's link to the application's main executable file. 
            With objLink
                .TargetPath = Application.ExecutablePath
                .Arguments = strParamaters
                .WindowStyle = 1
                .Save()
            End With

        Catch ex As Exception
            ' Mark as Failed
            CreateShortcut = False
            Debug.Print("Error creating shortcut: " & ex.Message)
        End Try

        Return CreateShortcut

    End Function

    Public Function DeleteShortcut() As Boolean
        ' Function deletes a shortcut. (unfinished)
        ' 
        ' Returns TRUE if success, FALSE if failure.

        DeleteShortcut = True
    End Function

End Module
