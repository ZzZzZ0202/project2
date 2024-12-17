Public Class EmployeeLogInForm

    Private Sub EmployeeLogInForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the PasswordChar property to mask the password TextBox
        txtemployeepassword.PasswordChar = "*"c
    End Sub

    Private Sub residentlogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles residentlogin.LinkClicked
        ' Navigate to ResidentLogInForm
        Dim residentForm As New ResidentLogInForm()
        residentForm.Show()
        Me.Hide()
    End Sub

    Private Sub employeesignup_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles employeesignup.LinkClicked
        ' Navigate to EmployeeSignUpForm
        Dim signUpForm As New EmployeeSignUpForm()
        signUpForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        ' Get the input values for username and password
        Dim username As String = txtemployeeusername.Text.Trim()  ' Username field
        Dim password As String = txtemployeepassword.Text.Trim()  ' Password field

        ' Validate the username and password
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Placeholder logic for validating login credentials
        If username = "employee" And password = "1234" Then
            ' Successful login
            MessageBox.Show("Login successful!")
            ' Navigate to Employee Menu
            Dim menuForm As New EmployeeMenu()
            menuForm.Show()
            Me.Hide()
        Else
            ' Invalid credentials
            MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class