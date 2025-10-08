Public Class Landers
    Private Sub ButtonSatellites_Click(sender As Object, e As EventArgs) Handles ButtonSatellites.Click
        Me.Hide()
        Satellites.Show()
    End Sub

    Private Sub ButtonSpacecraft_Click(sender As Object, e As EventArgs) Handles ButtonSpacecraft.Click
        Me.Hide()
        Spacecraft.Show()
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
