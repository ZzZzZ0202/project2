Public Class ResidentMenu
    Private Sub ResidentMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnusermanagement_Click(sender As Object, e As EventArgs) Handles btnusermanagement.Click
        ' Open User Management Form
        Dim userManagement As New UserManagement()
        userManagement.Show()
        Me.Hide()
    End Sub

    Private Sub btnrecords_Click(sender As Object, e As EventArgs) Handles btnrecords.Click
        ' Open Records Form
        Dim residentRecordsForm As New ResidentRecordsForm()
        residentRecordsForm.Show()
        Me.Hide()

    End Sub

    Private Sub btnrequest_Click(sender As Object, e As EventArgs) Handles btnrequest.Click
        Dim RequestForm As New ResidentRequestForm()
        RequestForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnservices_Click(sender As Object, e As EventArgs) Handles btnservices.Click
        ' Open Services Form
        Dim ResidentBarangayServices As New ResidentBarangayServices()
        ResidentBarangayServices.Show()
        Me.Hide()
    End Sub

    Private Sub btnannouncements_Click(sender As Object, e As EventArgs) Handles btnannouncements.Click
        Dim residentAnnouncements As New ResidentAnnouncements()
        residentAnnouncements.Show()
        Me.Hide()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        ' Confirm logout
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Show the Resident Login Form
            Dim residentLoginForm As New ResidentLogInForm()
            residentLoginForm.Show()

            ' Close the current ResidentMenu form
            Me.Close()
        End If
    End Sub
End Class