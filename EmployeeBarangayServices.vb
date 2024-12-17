Public Class EmployeeBarangayServices
    Private Sub BarangayServices_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BarangayServices_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Check if the user clicked the X button
        If e.CloseReason = CloseReason.UserClosing Then
            ' Navigate back to EmployeeMenu
            Dim employeeMenu As New EmployeeMenu()
            employeeMenu.Show()
        End If

    End Sub

    Private Sub btnborrowequipment_Click(sender As Object, e As EventArgs) Handles btnborrowequipment.Click
        ' Open Borrow Equipment Form
        Dim EmployeeBorrowEquipment As New EmployeeBorrowEquipment()
        EmployeeBorrowEquipment.Show()
        Me.Hide()
    End Sub

    Private Sub btnincidentreport_Click(sender As Object, e As EventArgs) Handles btnincidentreport.Click
        ' Open Incident Report Form
        Dim EmployeeIncident_Report As New EmployeeIncident_Report()
        EmployeeIncident_Report.Show()
        Me.Hide()
    End Sub

    Private Sub btnpersonelrequest_Click(sender As Object, e As EventArgs) Handles btnpersonelrequest.Click
        Dim EmployeePersonnelandVehicleRequest As New EmployeePersonnelandVehicleRequest()
        EmployeePersonnelandVehicleRequest.Show()
        Me.Hide()
    End Sub


End Class