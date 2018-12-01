Public Class Controls
    Private Sub Form1Opacity_Scroll(sender As Object, e As EventArgs) Handles Form1Opacity.Scroll
        Form1.Opacity = Form1Opacity.Value / 100
        Form1OpacityText.Text = Form1Opacity.Value & "%"
        My.Settings.opacity = Form1Opacity.Value
        My.Settings.Save()
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        My.Settings.Reset()
        My.Settings.position = Form1.Location
        Form1Opacity.Value = My.Settings.opacity
        Form1.Opacity = Form1Opacity.Value / 100
        Form1OpacityText.Text = Form1Opacity.Value & "%"
        MoveButton.Checked = My.Settings.canMove
        showTip.Checked = My.Settings.showTip
        My.Settings.Save()
    End Sub

    Private Sub EndButton_Click(sender As Object, e As EventArgs) Handles EndButton.Click
        End
    End Sub

    Private Sub Controls_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1Opacity.Value = Form1.Opacity * 100
        Form1OpacityText.Text = Form1Opacity.Value & "%"
        MoveButton.Checked = My.Settings.canMove
        showTip.Checked = My.Settings.showTip
    End Sub

    Private Sub MoveButton_CheckedChanged(sender As Object, e As EventArgs) Handles MoveButton.CheckedChanged
        My.Settings.canMove = MoveButton.Checked
        My.Settings.Save()
    End Sub

    Private Sub showTip_CheckedChanged(sender As Object, e As EventArgs) Handles showTip.CheckedChanged
        My.Settings.showTip = showTip.Checked
        My.Settings.Save()
    End Sub
End Class