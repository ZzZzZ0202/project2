Public Class Employee_Announcement
    ' Declare the MonthCalendar control (assumes it's added on the form)
    Private WithEvents monthCalendar1 As New MonthCalendar()

    ' Declare variables for dragging
    Private isDragging As Boolean = False
    Private mouseOffset As Point

    Private Sub Employee_Announcement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load default announcements
        DisplayDefaultAnnouncements()

        ' Make RichTextBox1 non-editable by default
        RichTextBox1.ReadOnly = True

        ' Optionally, hide the calendar initially
        monthCalendar1.Visible = False
        Me.Controls.Add(monthCalendar1) ' Add the calendar to the form dynamically

        ' Set initial position of the calendar at the left-bottom corner
        monthCalendar1.Location = New Point(0, Me.ClientSize.Height - monthCalendar1.Height)
    End Sub

    Private Sub DisplayDefaultAnnouncements()
        ' If there's an announcement in the AnnouncementManager, display it in RichTextBox1
        If Not String.IsNullOrEmpty(AnnouncementManager.LatestAnnouncement) Then
            RichTextBox1.Text = AnnouncementManager.LatestAnnouncement
        Else
            ' Default announcement if none exists
            Dim announcementText As String =
            "PETS A: Ika-6 ng Hulyo 2024" & Environment.NewLine &
            "MULA SA: Tanggapan ng Punong Barangay" & Environment.NewLine &
            "PAKSA: Isang Bayanihan Para sa Barangay Clean-Up Drive" & Environment.NewLine &
            Environment.NewLine &
            "Sa lahat ng residente ng Barangay: " & Environment.NewLine &
            "Inaanyayahan po ang lahat na makilahok sa gaganaping Bayanihan para sa Barangay Clean-Up Drive " &
            "na magaganap sa darating na Sabado, ika-6 ng Hulyo 2024, mula alas-7 ng umaga hanggang alas-12 ng tanghali. " &
            "Layunin ng gawaing ito na mapanatili ang kalinisan at kaayusan ng ating komunidad." & Environment.NewLine &
            Environment.NewLine &
            "Mga dapat dalhin:" & Environment.NewLine &
            "- Walis, pala, sako, at iba pang gamit panglinis." & Environment.NewLine &
            "- Sariling inuming tubig para manatiling hydrated." & Environment.NewLine &
            Environment.NewLine &
            "Ang inyong pakikiisa ay lubos na mahalaga para sa tagumpay ng ating gawain. " &
            "Maraming salamat at inaasahan namin ang inyong presensya!" & Environment.NewLine &
            Environment.NewLine &
            "Para sa karagdagang impormasyon, makipag-ugnayan sa ating Barangay Hall."

            ' Display the default text in RichTextBox
            RichTextBox1.Text = announcementText
        End If
    End Sub

    Private Sub btnmanage_Click(sender As Object, e As EventArgs) Handles btnmanage.Click
        ' Toggle editability of the RichTextBox
        If RichTextBox1.ReadOnly Then
            ' If it's read-only, make it editable
            RichTextBox1.ReadOnly = False
        Else
            ' If it's editable, make it read-only again
            RichTextBox1.ReadOnly = True
        End If
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        ' Prompt the user to enter a new announcement
        Dim newAnnouncement As String = InputBox("Enter the new announcement:", "Add Announcement")

        ' If input is not empty, update the shared LatestAnnouncement property
        If newAnnouncement.Trim() <> "" Then
            ' Add current date and time to the announcement
            Dim currentDate As String = DateTime.Now.ToString("yyyy-MM-dd")
            Dim currentTime As String = DateTime.Now.ToString("hh:mm tt")
            Dim formattedAnnouncement As String =
                "--------------------------------------" & Environment.NewLine &
                "DATE: " & currentDate & Environment.NewLine &
                "TIME: " & currentTime & Environment.NewLine &
                "ANNOUNCEMENT: " & Environment.NewLine & newAnnouncement & Environment.NewLine &
                "--------------------------------------"

            ' Update the LatestAnnouncement in AnnouncementManager
            AnnouncementManager.LatestAnnouncement = formattedAnnouncement

            ' Display the new announcement in the RichTextBox
            RichTextBox1.AppendText(Environment.NewLine & formattedAnnouncement)
        Else
            MessageBox.Show("No announcement was entered.", "Add Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnschedule_Click(sender As Object, e As EventArgs) Handles btnschedule.Click
        ' Display the calendar for the current month
        monthCalendar1.Visible = True
        monthCalendar1.BringToFront() ' Ensure the calendar stays on top
    End Sub

    ' Handle the dragging of the MonthCalendar
    Private Sub monthCalendar1_MouseDown(sender As Object, e As MouseEventArgs) Handles monthCalendar1.MouseDown
        ' Start dragging
        If e.Button = MouseButtons.Left Then
            isDragging = True
            mouseOffset = e.Location
        End If
    End Sub

    Private Sub monthCalendar1_MouseMove(sender As Object, e As MouseEventArgs) Handles monthCalendar1.MouseMove
        ' Update the position of the calendar during dragging
        If isDragging Then
            monthCalendar1.Location = New Point(
                monthCalendar1.Left + e.X - mouseOffset.X,
                monthCalendar1.Top + e.Y - mouseOffset.Y
            )
        End If
    End Sub

    Private Sub monthCalendar1_MouseUp(sender As Object, e As MouseEventArgs) Handles monthCalendar1.MouseUp
        ' Stop dragging
        isDragging = False
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        ' Optional: Code if anything should happen on text change
    End Sub

    Private Sub Employee_Announcement_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Redirect to EmployeeMenu when this form is closing
        If e.CloseReason = CloseReason.UserClosing Then
            Dim EmployeeMenu As New EmployeeMenu()
            EmployeeMenu.Show()
        End If
    End Sub
End Class