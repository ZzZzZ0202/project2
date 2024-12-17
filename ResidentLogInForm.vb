Public Class ResidentLogInForm
    Private Sub ResidentLogInForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the PasswordChar property to mask the password TextBox
        txtresidentpassword.PasswordChar = "*"c
    End Sub

    Private Sub employeelogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles employeelogin.LinkClicked
        ' Navigate to Employee LogIn Form
        Dim employeeForm As New EmployeeLogInForm()
        employeeForm.Show()
        Me.Hide()
    End Sub

    Private Sub residentsignup_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles residentsignup.LinkClicked
        ' Navigate to Resident SignUp Form
        Dim signUpForm As New ResidentSignUpForm()
        signUpForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        ' Get the input values for username and password
        Dim username As String = txtresidentusername.Text.Trim()  ' Username field
        Dim password As String = txtresidentpassword.Text.Trim()  ' Password field

        ' Validate the username and password
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Placeholder logic for validating login credentials
        If username = "resident" And password = "1234" Then
            ' Successful login
            MessageBox.Show("Login successful!")
            ' Navigate to Resident Menu
            Dim menuForm As New ResidentMenu()
            menuForm.Show()
            Me.Hide()
        Else
            ' Invalid credentials
            MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
