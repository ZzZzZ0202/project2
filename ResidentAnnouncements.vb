Public Class ResidentAnnouncements
    Private Sub Resident_Announcement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display the latest announcement from AnnouncementManager
        If Not String.IsNullOrEmpty(AnnouncementManager.LatestAnnouncement) Then
            RichTextBox1.Text = AnnouncementManager.LatestAnnouncement
        Else
            ' Default message if no announcement is set
            RichTextBox1.Text = "No announcements available at the moment."
        End If
    End Sub

    Private Sub ResidentAnnouncements_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Dim residentMenu As New ResidentMenu()
            residentMenu.Show()
        End If
    End Sub



    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class