Public Class UserManagement
    Private Sub UserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        ' Create an instance of the Resident Menu Form
        Dim ResidentMenu As New ResidentMenu()

        ' Show the Resident Menu Form
        ResidentMenu.Show()

        ' Hide the current form (UpdateInformationForm)
        Me.Hide()
    End Sub
End Class