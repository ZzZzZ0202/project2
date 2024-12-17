Public Class ResidentIncidentReport
    Private Sub ResidentIncidentReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ResidentIncidentReport_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Navigate back to ResidentServices when the form is closed
        If e.CloseReason = CloseReason.UserClosing Then
            Dim ResidentBarangayServices As New ResidentBarangayServices()
            ResidentBarangayServices.Show()
        End If
    End Sub

End Class