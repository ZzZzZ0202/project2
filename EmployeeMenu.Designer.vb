<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeMenu
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnservices = New System.Windows.Forms.Button()
        Me.btnannouncements = New System.Windows.Forms.Button()
        Me.btnmanagerecords = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.label1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(256, 42)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(201, 35)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Employee Menu"
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnupdate.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnupdate.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(83, 104)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(193, 62)
        Me.btnupdate.TabIndex = 1
        Me.btnupdate.Text = "Update Information"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btnservices
        '
        Me.btnservices.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnservices.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnservices.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnservices.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnservices.Location = New System.Drawing.Point(83, 203)
        Me.btnservices.Name = "btnservices"
        Me.btnservices.Size = New System.Drawing.Size(193, 62)
        Me.btnservices.TabIndex = 2
        Me.btnservices.Text = "Services"
        Me.btnservices.UseVisualStyleBackColor = False
        '
        'btnannouncements
        '
        Me.btnannouncements.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnannouncements.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnannouncements.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnannouncements.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnannouncements.Location = New System.Drawing.Point(429, 104)
        Me.btnannouncements.Name = "btnannouncements"
        Me.btnannouncements.Size = New System.Drawing.Size(193, 62)
        Me.btnannouncements.TabIndex = 3
        Me.btnannouncements.Text = "Announcements"
        Me.btnannouncements.UseVisualStyleBackColor = False
        '
        'btnmanagerecords
        '
        Me.btnmanagerecords.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnmanagerecords.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnmanagerecords.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnmanagerecords.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmanagerecords.Location = New System.Drawing.Point(429, 203)
        Me.btnmanagerecords.Name = "btnmanagerecords"
        Me.btnmanagerecords.Size = New System.Drawing.Size(193, 62)
        Me.btnmanagerecords.TabIndex = 4
        Me.btnmanagerecords.Text = "Manage Records"
        Me.btnmanagerecords.UseVisualStyleBackColor = False
        '
        'btnlogout
        '
        Me.btnlogout.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnlogout.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.Location = New System.Drawing.Point(83, 309)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(102, 36)
        Me.btnlogout.TabIndex = 5
        Me.btnlogout.Text = "Log Out"
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'EmployeeMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(711, 372)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.btnmanagerecords)
        Me.Controls.Add(Me.btnannouncements)
        Me.Controls.Add(Me.btnservices)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "EmployeeMenu"
        Me.Text = "EmployeeMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label1 As Label
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnservices As Button
    Friend WithEvents btnannouncements As Button
    Friend WithEvents btnmanagerecords As Button
    Friend WithEvents btnlogout As Button
End Class
