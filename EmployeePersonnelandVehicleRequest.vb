Public Class EmployeePersonnelandVehicleRequest
    Private Sub EmployeePersonnelandVehicleRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This event triggers when the form loads

    End Sub
    ' This Sub handles the form submission logic
    ' This Sub handles the form submission logic
    Private Sub SubmitRequest()
        ' Variables to collect form inputs
        Dim name As String = txtname.Text
        Dim dateValue As String = txtdate.Text
        Dim address As String = txtaddress.Text
        Dim contactNumber As String = txtcontactnumber.Text
        Dim purpose As String = rtbpurpose.Text
        Dim selectedPersonnel As String = ""
        Dim selectedVehicle As String = ""
        Dim timeNeed As String = txttimeneed.Text

        ' Collect selected Personnel
        If chktanod.Checked Then selectedPersonnel &= "Tanod, "
        If chkclinicnurse.Checked Then selectedPersonnel &= "Clinic Nurse, "
        If chkcleaner.Checked Then selectedPersonnel &= "Cleaner, "

        ' Collect selected Vehicle
        If chkpatrol.Checked Then selectedVehicle &= "Patrol, "
        If chkservicevan.Checked Then selectedVehicle &= "Service Van, "
        If chkservicetricycle.Checked Then selectedVehicle &= "Service Tricycle, "

        ' Validate required fields
        If name = "" Or dateValue = "" Or address = "" Or purpose = "" Then
            MessageBox.Show("Please fill in all required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if the "I Agree" checkbox is checked
        If Not chkagree.Checked Then
            MessageBox.Show("You must agree to the declaration to submit the request!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Confirm submission if "I Agree" is checked
        MessageBox.Show("Request Submitted Successfully!" & vbCrLf &
                        "Name: " & name & vbCrLf &
                        "Date: " & dateValue & vbCrLf &
                        "Address: " & address & vbCrLf &
                        "Contact Number: " & contactNumber & vbCrLf &
                        "Personnel: " & selectedPersonnel & vbCrLf &
                        "Vehicle: " & selectedVehicle & vbCrLf &
                        "Purpose: " & purpose & vbCrLf &
                        "Time Needed: " & timeNeed, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' This event triggers when the Submit button is clicked
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        SubmitRequest() ' Call the SubmitRequest method
    End Sub

    ' This event handles what happens when the form is closing
    Private Sub EmployeePersonnelandVehicleRequest_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Navigate back to EmployeeBarangayServices when the form is closed
        If e.CloseReason = CloseReason.UserClosing Then
            Dim EmployeeBarangayServices As New EmployeeBarangayServices()
            EmployeeBarangayServices.Show()
        End If
    End Sub

End Class