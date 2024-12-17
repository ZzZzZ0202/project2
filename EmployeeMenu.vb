Public Class EmployeeMenu
    Private Sub EmployeeMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        ' Create an instance of the Update Information Form
        Dim updateManagement As New UpdateManagement()

        ' Show the Update Information Form
        updateManagement.Show()

        ' Optionally hide the current form (EmployeeMenuForm)
        Me.Hide()

    End Sub

    Private Sub btnannouncements_Click(sender As Object, e As EventArgs) Handles btnannouncements.Click
        ' Open the Announcements Form
        Dim employee_Announcement As New Employee_Announcement()
        employee_Announcement.Show()
        Me.Hide()


    End Sub


    Private Sub btnservices_Click(sender As Object, e As EventArgs) Handles btnservices.Click
        ' Open the Services Form
        Dim EmployeeBarangayServices As New EmployeeBarangayServices()
        EmployeeBarangayServices.Show()
        Me.Hide()
    End Sub

    Private Sub btnmanagerecords_Click(sender As Object, e As EventArgs) Handles btnmanagerecords.Click
        ' Open the Manage Records Form
        Dim EmployeeRecordsForm As New EmployeeRecordsForm()
        EmployeeRecordsForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        ' Confirm logout
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Show the Employee Login Form
            Dim loginForm As New EmployeeLogInForm()
            loginForm.Show()

            ' Close the current EmployeeMenu form
            Me.Close()
        End If
    End Sub
End Class