Public Class ResidentRecordsForm
    Dim dt As New DataTable()

    Private Sub ResidentRecordsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Add columns to the DataTable
        dt.Columns.Add("ResidentID")
        dt.Columns.Add("FullName")
        dt.Columns.Add("Gender")
        dt.Columns.Add("Age", GetType(Integer))
        dt.Columns.Add("Birthdate")
        dt.Columns.Add("Address")
        dt.Columns.Add("ContactNumber")
        dt.Columns.Add("NationalIDNumber")
        dt.Columns.Add("DateRegistered")


        ' Add rows to the DataTable
        dt.Rows.Add("001", "Juan Dela Cruz", "M", 35, "Jan 1, 1988", "123 Sitio Uno", "09123456789", "1234567890123", "Jan 5, 2020")
        dt.Rows.Add("002", "Maria Santos", "F", 28, "Mar 12, 1995", "456 Purok Dos", "09187654321", "1234567890124", "Feb 3, 2021")
        dt.Rows.Add("003", "Pedro Ramos", "M", 42, "May 23, 1981", "789 Sitio Tres", "09123412345", "1234567890125", "Mar 10, 2019")
        dt.Rows.Add("004", "Liza Cruz", "F", 30, "Jul 15, 1993", "101 Sitio Quatro", "09123211234", "1234567890126", "Jun 20, 2022")
        dt.Rows.Add("005", "Roberto Tan", "M", 50, "Nov 28, 1973", "202 Purok Lima", "09123456788", "1234567890127", "Dec 1, 2018")
        dt.Rows.Add("006", "Ana Lopez", "F", 26, "Sep 5, 1997", "303 Sitio Seis", "09123987654", "1234567890128", "Jul 15, 2021")
        dt.Rows.Add("007", "Carlos Mendoza", "M", 33, "Apr 10, 1990", "404 Purok Siete", "09129876543", "1234567890129", "Oct 10, 2020")
        dt.Rows.Add("008", "Elena Reyes", "F", 39, "Feb 20, 1984", "505 Sitio Ocho", "09123487654", "1234567890130", "Nov 12, 2019")
        dt.Rows.Add("009", "Ramon De Guzman", "M", 45, "Jun 30, 1978", "606 Purok Nueve", "09129874321", "1234567890131", "Aug 23, 2018")
        dt.Rows.Add("010", "Sofia Lim", "F", 27, "Dec 25, 1996", "707 Sitio Sampu", "09126789012", "1234567890132", "Jan 14, 2023")
        dt.Rows.Add("011", "Mark Rivera", "M", 40, "Apr 12, 1983", "808 Sitio Uno", "09123567890", "1234567890133", "Feb 2, 2020")
        dt.Rows.Add("012", "Angela Torres", "F", 32, "Jan 9, 1991", "123 Purok Dos", "09124567890", "1234567890134", "May 6, 2021")
        dt.Rows.Add("013", "John Santos", "M", 29, "Jul 23, 1994", "456 Sitio Tres", "09125567890", "1234567890135", "Mar 12, 2019")
        dt.Rows.Add("014", "Carmen Cruz", "F", 34, "Dec 5, 1989", "789 Sitio Quatro", "09126567890", "1234567890136", "Jan 15, 2022")
        dt.Rows.Add("015", "Victor Reyes", "M", 48, "Aug 17, 1975", "202 Purok Lima", "09127567890", "1234567890137", "Nov 23, 2018")
        dt.Rows.Add("016", "Patricia Lopez", "F", 31, "Mar 14, 1992", "303 Sitio Seis", "09128567890", "1234567890138", "Jul 21, 2021")
        dt.Rows.Add("017", "Daniel Mendoza", "M", 36, "Sep 2, 1987", "404 Purok Siete", "09129567890", "1234567890139", "Oct 30, 2020")
        dt.Rows.Add("018", "Melissa Ramos", "F", 37, "Jun 30, 1986", "505 Sitio Ocho", "09130567890", "1234567890140", "Dec 5, 2019")
        dt.Rows.Add("019", "Francisco De Guzman", "M", 55, "Nov 11, 1968", "606 Purok Nueve", "09131567890", "1234567890141", "Sep 1, 2018")
        dt.Rows.Add("020", "Sophia Fernandez", "F", 25, "Feb 19, 1998", "707 Sitio Sampu", "09132567890", "1234567890142", "Jan 20, 2023")

        ' Bind the DataTable to the DataGridView
        DataGridView1.DataSource = dt

    End Sub

    Private Sub ResidentRecordsForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Dim residentMenu As New ResidentMenu()
            residentMenu.Show()
        End If
    End Sub
End Class