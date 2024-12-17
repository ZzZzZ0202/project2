Public Class ResidentBarangayServices
    Private Sub ResidentBarangayServices_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnborrowequipment_Click(sender As Object, e As EventArgs) Handles btnborrowequipment.Click
        ' Open BorrowEquipment Report Form
        Dim ResidentBorrowEquipment As New ResidentBorrowEquipment()
        ResidentBorrowEquipment.Show()
        Me.Hide()
    End Sub

    Private Sub btnincidentreport_Click(sender As Object, e As EventArgs) Handles btnincidentreport.Click
        ' Open Incident Report Form
        Dim ResidentIncidentReport As New ResidentIncidentReport()
        ResidentIncidentReport.Show()
        Me.Hide()
    End Sub

    Private Sub btnpersonelrequest_Click(sender As Object, e As EventArgs) Handles btnpersonelrequest.Click
        ' Open Personnel Request Form
        Dim ResidentPersonnelAndVehicleRequest As New ResidentPersonnelAndVehicleRequest()
        ResidentPersonnelAndVehicleRequest.Show()
        Me.Hide()
    End Sub

    Private Sub ResidentBarangayServices_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Check if the user clicked the X button
        If e.CloseReason = CloseReason.UserClosing Then
            ' Navigate back to EmployeeMenu
            Dim ResidentMenu As New ResidentMenu()
            ResidentMenu.Show()
        End If
    End Sub
End Class