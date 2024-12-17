<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeBarangayServices
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
        Me.btnincidentreport = New System.Windows.Forms.Button()
        Me.btnborrowequipment = New System.Windows.Forms.Button()
        Me.btnpersonelrequest = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(231, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Barangay Services"
        '
        'btnincidentreport
        '
        Me.btnincidentreport.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnincidentreport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnincidentreport.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnincidentreport.Location = New System.Drawing.Point(104, 142)
        Me.btnincidentreport.Name = "btnincidentreport"
        Me.btnincidentreport.Size = New System.Drawing.Size(156, 62)
        Me.btnincidentreport.TabIndex = 1
        Me.btnincidentreport.Text = "Incident Report"
        Me.btnincidentreport.UseVisualStyleBackColor = False
        '
        'btnborrowequipment
        '
        Me.btnborrowequipment.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnborrowequipment.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnborrowequipment.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnborrowequipment.Location = New System.Drawing.Point(262, 276)
        Me.btnborrowequipment.Name = "btnborrowequipment"
        Me.btnborrowequipment.Size = New System.Drawing.Size(156, 63)
        Me.btnborrowequipment.TabIndex = 2
        Me.btnborrowequipment.Text = "Borrow Equipment"
        Me.btnborrowequipment.UseVisualStyleBackColor = False
        '
        'btnpersonelrequest
        '
        Me.btnpersonelrequest.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnpersonelrequest.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnpersonelrequest.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpersonelrequest.Location = New System.Drawing.Point(432, 142)
        Me.btnpersonelrequest.Name = "btnpersonelrequest"
        Me.btnpersonelrequest.Size = New System.Drawing.Size(165, 63)
        Me.btnpersonelrequest.TabIndex = 4
        Me.btnpersonelrequest.Text = "Personel and Vehicle Request"
        Me.btnpersonelrequest.UseVisualStyleBackColor = False
        '
        'EmployeeBarangayServices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(698, 414)
        Me.Controls.Add(Me.btnpersonelrequest)
        Me.Controls.Add(Me.btnborrowequipment)
        Me.Controls.Add(Me.btnincidentreport)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EmployeeBarangayServices"
        Me.Text = "EmployeeBarangayServices"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnincidentreport As Button
    Friend WithEvents btnborrowequipment As Button
    Friend WithEvents btnpersonelrequest As Button
End Class
