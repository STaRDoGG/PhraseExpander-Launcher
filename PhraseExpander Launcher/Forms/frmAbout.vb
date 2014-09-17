Public Class frmAbout

    Private Sub llPE_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llPE.LinkClicked
        ' Launch the PE website (via the GD shortener)
        Process.Start("http://geekdrop.com/x/phrase-expander")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Close this window
        Me.Close()
    End Sub

    Private Sub llJSE_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llJSE.LinkClicked
        ' Launch the GD website
        Process.Start("http://geekdrop.com")
    End Sub
End Class