<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResidentLogInForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtresidentusername = New System.Windows.Forms.TextBox()
        Me.txtresidentpassword = New System.Windows.Forms.TextBox()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.employeelogin = New System.Windows.Forms.LinkLabel()
        Me.residentsignup = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(100, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(105, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(152, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(336, 35)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Barangay Imformation Kiosk"
        '
        'txtresidentusername
        '
        Me.txtresidentusername.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtresidentusername.Location = New System.Drawing.Point(206, 103)
        Me.txtresidentusername.Name = "txtresidentusername"
        Me.txtresidentusername.Size = New System.Drawing.Size(268, 31)
        Me.txtresidentusername.TabIndex = 3
        '
        'txtresidentpassword
        '
        Me.txtresidentpassword.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtresidentpassword.Location = New System.Drawing.Point(206, 152)
        Me.txtresidentpassword.Name = "txtresidentpassword"
        Me.txtresidentpassword.Size = New System.Drawing.Size(268, 31)
        Me.txtresidentpassword.TabIndex = 4
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnlogin.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.Location = New System.Drawing.Point(477, 263)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(88, 40)
        Me.btnlogin.TabIndex = 5
        Me.btnlogin.Text = "Log In"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'employeelogin
        '
        Me.employeelogin.AutoSize = True
        Me.employeelogin.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeelogin.LinkColor = System.Drawing.Color.Black
        Me.employeelogin.Location = New System.Drawing.Point(202, 198)
        Me.employeelogin.Name = "employeelogin"
        Me.employeelogin.Size = New System.Drawing.Size(138, 23)
        Me.employeelogin.TabIndex = 6
        Me.employeelogin.TabStop = True
        Me.employeelogin.Text = "Employee Log In"
        '
        'residentsignup
        '
        Me.residentsignup.AutoSize = True
        Me.residentsignup.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.residentsignup.LinkColor = System.Drawing.Color.Black
        Me.residentsignup.Location = New System.Drawing.Point(405, 198)
        Me.residentsignup.Name = "residentsignup"
        Me.residentsignup.Size = New System.Drawing.Size(69, 23)
        Me.residentsignup.TabIndex = 7
        Me.residentsignup.TabStop = True
        Me.residentsignup.Text = "Sign Up"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(62, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Not an Resident"
        '
        'ResidentLogInForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(614, 345)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.residentsignup)
        Me.Controls.Add(Me.employeelogin)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.txtresidentpassword)
        Me.Controls.Add(Me.txtresidentusername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ResidentLogInForm"
        Me.Text = "ResidentLogIn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtresidentusername As TextBox
    Friend WithEvents txtresidentpassword As TextBox
    Friend WithEvents btnlogin As Button
    Friend WithEvents employeelogin As LinkLabel
    Friend WithEvents residentsignup As LinkLabel
    Friend WithEvents Label4 As Label
End Class
