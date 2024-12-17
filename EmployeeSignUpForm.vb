Imports MySql.Data.MySqlClient
Public Class EmployeeSignUpForm
    ' Connection string to MySQL (Ensure MySQL user/password is correct and compatible)
    Dim connectionString As String = "Server=127.0.0.1;Port=3306;Database=BarangayInformationSystem;Uid=root;Pwd=YourPassword;"

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btncreate.Click
        ' Capture input data from the form
        Dim firstName As String = txtfirstname.Text
        Dim middleName As String = txtmiddlename.Text
        Dim lastName As String = txtlastname.Text
        Dim age As String = txtage.Text
        Dim sex As String = txtsex.Text
        Dim username As String = txtuname.Text
        Dim password As String = txtpassword.Text
        Dim employmentRole As String = txtrole.Text
        Dim email As String = txtemail.Text
        Dim barangayAccessCode As String = txtaccesscode.Text

        ' Validate if any required field is empty
        If String.IsNullOrEmpty(firstName) OrElse
           String.IsNullOrEmpty(lastName) OrElse
           String.IsNullOrEmpty(username) OrElse
           String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Insert query to add data into the Employee table
        Dim query As String = "INSERT INTO Employees (FirstName, MiddleName, LastName, Age, Sex, Username, Password, EmploymentRole, Email, BarangayAccessCode) " &
                              "VALUES (@FirstName, @MiddleName, @LastName, @Age, @Sex, @Username, @Password, @EmploymentRole, @Email, @BarangayAccessCode)"

        ' Database connection
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Execute SQL Command
                Using command As New MySqlCommand(query, connection)
                    ' Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@FirstName", firstName)
                    command.Parameters.AddWithValue("@MiddleName", middleName)
                    command.Parameters.AddWithValue("@LastName", lastName)
                    command.Parameters.AddWithValue("@Age", age)
                    command.Parameters.AddWithValue("@Sex", sex)
                    command.Parameters.AddWithValue("@Username", username)
                    command.Parameters.AddWithValue("@Password", password) ' Note: Hash passwords in real-world scenarios
                    command.Parameters.AddWithValue("@EmploymentRole", employmentRole)
                    command.Parameters.AddWithValue("@Email", email)
                    command.Parameters.AddWithValue("@BarangayAccessCode", barangayAccessCode)

                    ' Execute the query
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Employee account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ClearFormFields()
                    Else
                        MessageBox.Show("Failed to create account. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As MySqlException
                ' Handle specific database errors
                If ex.Number = 1045 Then
                    MessageBox.Show("Access denied: Invalid username or password.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf ex.Number = 1049 Then
                    MessageBox.Show("Unknown database. Please check the database name.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                ' General error handling
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub ClearFormFields()
        ' Clears all input fields
        txtfirstname.Clear()
        txtmiddlename.Clear()
        txtlastname.Clear()
        txtage.Clear()
        txtsex.Clear()
        txtuname.Clear()
        txtpassword.Clear()
        txtrole.Clear()
        txtemail.Clear()
        txtaccesscode.Clear()
    End Sub

    Private Sub EmployeeSignUpForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Redirect to Employee Login Form
        Dim loginForm As New EmployeeLogInForm()
        loginForm.Show()
    End Sub

    Private Sub EmployeeSignUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class