Public Class ResidentSignUpForm
    Private Sub ResidentSignUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ResidentSignUpForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Redirect to the ResidentLogInForm when this form is closed
        Dim loginForm As New ResidentLogInForm()
        loginForm.Show()

    End Sub
End Class