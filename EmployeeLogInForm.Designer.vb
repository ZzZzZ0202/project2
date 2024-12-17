<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeLogInForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.employeesignup = New System.Windows.Forms.LinkLabel()
        Me.residentlogin = New System.Windows.Forms.LinkLabel()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.txtemployeepassword = New System.Windows.Forms.TextBox()
        Me.txtemployeeusername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(59, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 23)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Not an Resident"
        '
        'employeesignup
        '
        Me.employeesignup.AutoSize = True
        Me.employeesignup.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeesignup.LinkColor = System.Drawing.Color.Black
        Me.employeesignup.Location = New System.Drawing.Point(402, 197)
        Me.employeesignup.Name = "employeesignup"
        Me.employeesignup.Size = New System.Drawing.Size(69, 23)
        Me.employeesignup.TabIndex = 16
        Me.employeesignup.TabStop = True
        Me.employeesignup.Text = "Sign Up"
        '
        'residentlogin
        '
        Me.residentlogin.AutoSize = True
        Me.residentlogin.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.residentlogin.LinkColor = System.Drawing.Color.Black
        Me.residentlogin.Location = New System.Drawing.Point(199, 197)
        Me.residentlogin.Name = "residentlogin"
        Me.residentlogin.Size = New System.Drawing.Size(131, 23)
        Me.residentlogin.TabIndex = 15
        Me.residentlogin.TabStop = True
        Me.residentlogin.Text = "Resident Log In"
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnlogin.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.Location = New System.Drawing.Point(474, 262)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(88, 40)
        Me.btnlogin.TabIndex = 14
        Me.btnlogin.Text = "Log In"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'txtemployeepassword
        '
        Me.txtemployeepassword.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemployeepassword.Location = New System.Drawing.Point(203, 151)
        Me.txtemployeepassword.Name = "txtemployeepassword"
        Me.txtemployeepassword.Size = New System.Drawing.Size(268, 31)
        Me.txtemployeepassword.TabIndex = 13
        '
        'txtemployeeusername
        '
        Me.txtemployeeusername.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemployeeusername.Location = New System.Drawing.Point(203, 102)
        Me.txtemployeeusername.Name = "txtemployeeusername"
        Me.txtemployeeusername.Size = New System.Drawing.Size(268, 31)
        Me.txtemployeeusername.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(154, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(334, 33)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Barangay Imformation Kiosk"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(102, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 23)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Password :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Username :"
        '
        'EmployeeLogInForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(623, 348)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.employeesignup)
        Me.Controls.Add(Me.residentlogin)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.txtemployeepassword)
        Me.Controls.Add(Me.txtemployeeusername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EmployeeLogInForm"
        Me.Text = "EmployeeLogInForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents employeesignup As LinkLabel
    Friend WithEvents residentlogin As LinkLabel
    Friend WithEvents btnlogin As Button
    Friend WithEvents txtemployeepassword As TextBox
    Friend WithEvents txtemployeeusername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
