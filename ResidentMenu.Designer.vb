<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResidentMenu
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
        Me.btnrequest = New System.Windows.Forms.Button()
        Me.btnannouncements = New System.Windows.Forms.Button()
        Me.btnrecords = New System.Windows.Forms.Button()
        Me.btnusermanagement = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnservices = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnrequest
        '
        Me.btnrequest.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnrequest.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnrequest.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnrequest.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrequest.Location = New System.Drawing.Point(437, 205)
        Me.btnrequest.Name = "btnrequest"
        Me.btnrequest.Size = New System.Drawing.Size(193, 62)
        Me.btnrequest.TabIndex = 9
        Me.btnrequest.Text = "Request"
        Me.btnrequest.UseVisualStyleBackColor = False
        '
        'btnannouncements
        '
        Me.btnannouncements.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnannouncements.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnannouncements.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnannouncements.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnannouncements.Location = New System.Drawing.Point(437, 106)
        Me.btnannouncements.Name = "btnannouncements"
        Me.btnannouncements.Size = New System.Drawing.Size(193, 62)
        Me.btnannouncements.TabIndex = 8
        Me.btnannouncements.Text = "Announcements"
        Me.btnannouncements.UseVisualStyleBackColor = False
        '
        'btnrecords
        '
        Me.btnrecords.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnrecords.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnrecords.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnrecords.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrecords.Location = New System.Drawing.Point(96, 205)
        Me.btnrecords.Name = "btnrecords"
        Me.btnrecords.Size = New System.Drawing.Size(193, 62)
        Me.btnrecords.TabIndex = 7
        Me.btnrecords.Text = "Records"
        Me.btnrecords.UseVisualStyleBackColor = False
        '
        'btnusermanagement
        '
        Me.btnusermanagement.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnusermanagement.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnusermanagement.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnusermanagement.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnusermanagement.Location = New System.Drawing.Point(96, 106)
        Me.btnusermanagement.Name = "btnusermanagement"
        Me.btnusermanagement.Size = New System.Drawing.Size(193, 62)
        Me.btnusermanagement.TabIndex = 6
        Me.btnusermanagement.Text = "User Management"
        Me.btnusermanagement.UseVisualStyleBackColor = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.SystemColors.Desktop
        Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.label1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(277, 28)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(187, 35)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Resident Menu"
        '
        'btnservices
        '
        Me.btnservices.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnservices.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnservices.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnservices.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnservices.Location = New System.Drawing.Point(437, 305)
        Me.btnservices.Name = "btnservices"
        Me.btnservices.Size = New System.Drawing.Size(193, 62)
        Me.btnservices.TabIndex = 10
        Me.btnservices.Text = "Services"
        Me.btnservices.UseVisualStyleBackColor = False
        '
        'btnlogout
        '
        Me.btnlogout.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnlogout.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.Location = New System.Drawing.Point(106, 328)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(96, 39)
        Me.btnlogout.TabIndex = 11
        Me.btnlogout.Text = "Log Out"
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'ResidentMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(716, 413)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.btnservices)
        Me.Controls.Add(Me.btnrequest)
        Me.Controls.Add(Me.btnannouncements)
        Me.Controls.Add(Me.btnrecords)
        Me.Controls.Add(Me.btnusermanagement)
        Me.Controls.Add(Me.label1)
        Me.Name = "ResidentMenu"
        Me.Text = "ResidentMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnrequest As Button
    Friend WithEvents btnannouncements As Button
    Friend WithEvents btnrecords As Button
    Friend WithEvents btnusermanagement As Button
    Friend WithEvents label1 As Label
    Friend WithEvents btnservices As Button
    Friend WithEvents btnlogout As Button
End Class
