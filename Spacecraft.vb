Public Class Spacecraft

    Private Sub Spacecraft_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBoxInfo.LoadFile("spacecraft.txt", RichTextBoxStreamType.PlainText)
    End Sub
    Private Sub ButtonSatellites_Click(sender As Object, e As EventArgs) Handles ButtonSatellites.Click
        Me.Hide()
        Satellites.Show()
    End Sub

    Private Sub ButtonLanders_Click(sender As Object, e As EventArgs) Handles ButtonLanders.Click
        Me.Hide()
        Landers.Show()
    End Sub

    Private Sub ButtonSpaceStations_Click(sender As Object, e As EventArgs) Handles ButtonSpaceStations.Click
        Me.Hide()
        SpaceStations.Show()
    End Sub

    Private Sub ButtonHome_Click(sender As Object, e As EventArgs) Handles ButtonHome.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Application.Exit()
    End Sub
End Class
