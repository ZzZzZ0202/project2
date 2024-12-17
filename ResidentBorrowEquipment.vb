Public Class ResidentBorrowEquipment
    Private Sub ResidentBorrowEquipment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Adjust DataGridView column sizing
        With dgvborrowdetails
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        End With


        ' Add items to What Item ComboBox
        cmbwhatitem.Items.Add("TV")
        cmbwhatitem.Items.Add("Table")
        cmbwhatitem.Items.Add("Chair")
        cmbwhatitem.Items.Add("Tricycle")
        cmbwhatitem.Items.Add("L300(5)")

        ' Add items to Borrower Type ComboBox
        cmbgender.Items.Add("Male")
        cmbgender.Items.Add("Female")

        ' Set up DataGridView columns
        With dgvborrowdetails
            .ColumnCount = 5
            .Columns(0).Name = "Date Borrow"
            .Columns(1).Name = "Time From"
            .Columns(2).Name = "Time To"
            .Columns(3).Name = "Item Name"
            .Columns(4).Name = "Quantity"
        End With
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        ' Validate input
        If txtrequistion.Text = "" Or txtname.Text = "" Or cmbwhatitem.SelectedIndex = -1 Or txtquantity.Text = "" Then
            MessageBox.Show("Please fill in all required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Add row to DataGridView with current date and time
        dgvborrowdetails.Rows.Add(
        DateTime.Now.ToString("MM-dd-yyyy"),   ' Current Date
        DateTime.Now.ToString("hh:mm tt"),     ' Current Time From
        DateTime.Now.AddHours(1).ToString("hh:mm tt"), ' Time To (1 hour later)
        cmbwhatitem.SelectedItem,              ' Selected Item Name
        txtquantity.Text                       ' Quantity
    )

        ' Clear fields after submission
        txtrequistion.Clear()
        txtname.Clear()
        txtaddress.Clear()
        txtquantity.Clear()
        cmbwhatitem.SelectedIndex = -1
        cmbgender.SelectedIndex = -1
    End Sub

    Private Sub ResidentBorrowEquipment_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Navigate back to ResidentServices when the form is closed
        If e.CloseReason = CloseReason.UserClosing Then
            Dim ResidentBarangayServices As New ResidentBarangayServices()
            ResidentBarangayServices.Show()
        End If
    End Sub

    Private Sub txtquantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtquantity.KeyPress
        ' Allow only numbers and control keys (like Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Only numeric input is allowed for Quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub txtrequistion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtrequistion.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Only numeric input is allowed for Requisition No.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class