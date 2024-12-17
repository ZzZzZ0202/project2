Public Class EmployeeIncident_Report
    Private Sub EmployeeIncident_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Do NOT create a new instance of this form here. Remove the following lines:
        ' Dim EmployeeIncident_Report As New EmployeeIncident_Report()
        ' EmployeeIncident_Report.Show()
        ' Me.Hide()
    End Sub

    Private Sub EmployeeIncident_Report_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Navigate back to EmployeeBarangayServices when the form is closed
        If e.CloseReason = CloseReason.UserClosing Then
            Dim EmployeeBarangayServices As New EmployeeBarangayServices()
            EmployeeBarangayServices.Show()
        End If
    End Sub


End Class