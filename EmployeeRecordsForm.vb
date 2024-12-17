Public Class EmployeeRecordsForm
    Dim dt As New DataTable()
    Private Sub EmployeeRecordsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add columns to the DataTable (no ID column)
        dt.Columns.Add("FullName")
        dt.Columns.Add("Gender")
        dt.Columns.Add("Age", GetType(Integer))
        dt.Columns.Add("Birthdate")
        dt.Columns.Add("Address")
        dt.Columns.Add("ContactNumber")
        dt.Columns.Add("NationalIDNumber")
        dt.Columns.Add("DateRegistered")

        ' Add rows to the DataTable
        dt.Rows.Add("Juan Dela Cruz", "M", 35, "Jan 1, 1988", "Cebu City, Cebu", "09123456789", "1234567890123", "Jan 5, 2020")
        dt.Rows.Add("Maria Santos", "F", 28, "Mar 12, 1995", "Davao City, Davao del Sur", "09187654321", "1234567890124", "Feb 3, 2021")
        dt.Rows.Add("Pedro Ramos", "M", 42, "May 23, 1981", "Quezon City, Metro Manila", "09123412345", "1234567890125", "Mar 10, 2019")
        dt.Rows.Add("Liza Cruz", "F", 30, "Jul 15, 1993", "Baguio City, Benguet", "09123211234", "1234567890126", "Jun 20, 2022")
        dt.Rows.Add("Roberto Tan", "M", 50, "Nov 28, 1973", "Iloilo City, Iloilo", "09123456788", "1234567890127", "Dec 1, 2018")
        dt.Rows.Add("Ana Lopez", "F", 26, "Sep 5, 1997", "Bacolod City, Negros Occidental", "09123987654", "1234567890128", "Jul 15, 2021")
        dt.Rows.Add("Carlos Mendoza", "M", 33, "Apr 10, 1990", "Puerto Princesa, Palawan", "09129876543", "1234567890129", "Oct 10, 2020")
        dt.Rows.Add("Elena Reyes", "F", 39, "Feb 20, 1984", "Legazpi City, Albay", "09123487654", "1234567890130", "Nov 12, 2019")
        dt.Rows.Add("Ramon De Guzman", "M", 45, "Jun 30, 1978", "Cagayan de Oro, Misamis Oriental", "09129874321", "1234567890131", "Aug 23, 2018")
        dt.Rows.Add("Sofia Lim", "F", 27, "Dec 25, 1996", "General Santos City, South Cotabato", "09126789012", "1234567890132", "Jan 14, 2023")
        dt.Rows.Add("Mark Rivera", "M", 40, "Apr 12, 1983", "Tagaytay City, Cavite", "09123567890", "1234567890133", "Feb 2, 2020")
        dt.Rows.Add("Angela Torres", "F", 32, "Jan 9, 1991", "San Fernando City, Pampanga", "09124567890", "1234567890134", "May 6, 2021")
        dt.Rows.Add("John Santos", "M", 29, "Jul 23, 1994", "Zamboanga City, Zamboanga del Sur", "09125567890", "1234567890135", "Mar 12, 2019")
        dt.Rows.Add("Carmen Cruz", "F", 34, "Dec 5, 1989", "Tuguegarao City, Cagayan", "09126567890", "1234567890136", "Jan 15, 2022")
        dt.Rows.Add("Victor Reyes", "M", 48, "Aug 17, 1975", "Batangas City, Batangas", "09127567890", "1234567890137", "Nov 23, 2018")
        dt.Rows.Add("Patricia Lopez", "F", 31, "Mar 14, 1992", "Naga City, Camarines Sur", "09128567890", "1234567890138", "Jul 21, 2021")
        dt.Rows.Add("Daniel Mendoza", "M", 36, "Sep 2, 1987", "Laoag City, Ilocos Norte", "09129567890", "1234567890139", "Oct 30, 2020")
        dt.Rows.Add("Melissa Ramos", "F", 37, "Jun 30, 1986", "Vigan City, Ilocos Sur", "09130567890", "1234567890140", "Dec 5, 2019")
        dt.Rows.Add("Francisco De Guzman", "M", 55, "Nov 11, 1968", "Dumaguete City, Negros Oriental", "09131567890", "1234567890141", "Sep 1, 2018")
        dt.Rows.Add("Sophia Fernandez", "F", 25, "Feb 19, 1998", "Calamba City, Laguna", "09132567890", "1234567890142", "Jan 20, 2023")

        ' Bind the DataTable to the DataGridView
        DataGridView1.DataSource = dt
    End Sub

    Private Sub EmployeeRecordsForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Check if the user clicked the X button
        If e.CloseReason = CloseReason.UserClosing Then
            ' Navigate back to EmployeeMenu
            Dim employeeMenu As New EmployeeMenu()
            employeeMenu.Show()
        End If
    End Sub
End Class