Public Class ResidentRequestForm
    Private Sub RequestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RequestForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Dim residentMenu As New ResidentMenu()
            residentMenu.Show()
        End If
    End Sub
End Class