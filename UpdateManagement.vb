Public Class UpdateManagement
    Private Sub UpdateManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        ' Create an instance of the Employee Menu Form
        Dim employeeMenu As New EmployeeMenu()

        ' Show the Employee Menu Form
        employeeMenu.Show()

        ' Hide the current form (UpdateInformationForm)
        Me.Hide()
    End Sub

End Class