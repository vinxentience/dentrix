Imports MySql.Data.MySqlClient
Public Class UserControl_appointment_appointmentlist

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        filteredSearch()
    End Sub

    Private Sub filteredSearch()
        Dim table As New DataTable()
        conn.Open()
        Try
            comm = New MySqlCommand("prcSearchAppointment", conn)
            With comm
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@did", user_id)
                .Parameters.AddWithValue("@search_filter", cmbFilter.Text)
                .Parameters.AddWithValue("@date_from", date_from.Value.ToString("yyyy-MM-dd"))
                .Parameters.AddWithValue("@date_to", date_to.Value.ToString("yyyy-MM-dd"))
                .Parameters.AddWithValue("@search_status", cmbStatus.Text)
                .ExecuteNonQuery()
            End With
            Dim da As New MySqlDataAdapter
            da.SelectCommand = comm
            Dim dt As New DataTable
            dt.Clear()
            da.Fill(dt)
            dgvAppointment.DataSource = dt

        Catch ex As Exception

        End Try
        conn.Close()
    End Sub

    Private Sub cmbFilter_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedValueChanged
        If cmbFilter.Text = "All" Then
            date_from.Enabled = False
            date_to.Enabled = False
            cmbStatus.Enabled = False
            date_from.Value = DateTime.Today
            date_to.Value = DateTime.Today
            lblDateFrom.Text = ""
            lblDateTo.Text = ""
        ElseIf cmbFilter.Text = "Specific Date" Then
            date_from.Enabled = True
            date_to.Enabled = False
            cmbStatus.Enabled = False
            lblDateFrom.Text = "Specific Date"
            lblDateTo.Text = ""
        ElseIf cmbFilter.Text = "Between Dates" Then
            date_from.Enabled = True
            date_to.Enabled = True
            cmbStatus.Enabled = False
            lblDateFrom.Text = "Date From"
            lblDateTo.Text = "Date To"
        ElseIf cmbFilter.Text = "Status" Then
            date_from.Enabled = True
            date_to.Enabled = True
            cmbStatus.Enabled = True
            lblDateFrom.Text = "Date From"
            lblDateTo.Text = "Date To"
        End If
    End Sub

    Private Sub UserControl_appointment_appointmentlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        date_from.Value = DateTime.Today
        date_to.Value = DateTime.Today
        lblDateFrom.Text = ""
        lblDateTo.Text = ""
        displayAppointment()
    End Sub

    Private Sub displayAppointment()
        Dim table As New DataTable()
        conn.Open()
        Try
            comm = New MySqlCommand("prcSearchAppointment", conn)
            With comm
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@did", user_id)
                .Parameters.AddWithValue("@search_filter", "All")
                .Parameters.AddWithValue("@date_from", "")
                .Parameters.AddWithValue("@date_to", "")
                .Parameters.AddWithValue("@search_status", "")
                .ExecuteNonQuery()
            End With
            Dim da As New MySqlDataAdapter
            da.SelectCommand = comm
            Dim dt As New DataTable
            dt.Clear()
            da.Fill(dt)
            dgvAppointment.DataSource = dt
        Catch ex As Exception
            conn.Close()
        End Try
        conn.Dispose()
    End Sub

    Private Sub dgvPatients_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAppointment.CellClick
        Dim colName As String = dgvAppointment.Columns(e.ColumnIndex).Name
        Dim selectedRow As DataGridViewRow
        Dim index As Integer
        Try
            index = e.RowIndex
            selectedRow = dgvAppointment.Rows(index)
            If colName = "action_view" Then
                With frm_view_appointment
                    .lblAppointmentID.Text = selectedRow.Cells(3).Value.ToString
                    .lblPatientName.Text = selectedRow.Cells(4).Value.ToString
                    .txtDescription.Text = selectedRow.Cells(5).Value.ToString
                    .dtpAppointmentDate.Value = selectedRow.Cells(6).Value
                    .txtTime.Text = selectedRow.Cells(7).Value.ToString
                    .lblStatus.Text = selectedRow.Cells(8).Value.ToString
                    If selectedRow.Cells(8).Value.ToString = "Done" Then
                        .lblStatus.ForeColor = Color.DarkGreen
                    Else
                        .lblStatus.ForeColor = Color.DarkRed
                    End If
                    .ShowDialog()
                End With
            ElseIf colName = "action_edit" Then
                With frm_edit_appointment
                    .lblAppointmentID.Text = selectedRow.Cells(3).Value.ToString
                    .lblPatientName.Text = selectedRow.Cells(4).Value.ToString
                    .txtDescription.Text = selectedRow.Cells(5).Value.ToString
                    .dtpAppointmentDate.Value = selectedRow.Cells(6).Value
                    .txtTime.Text = selectedRow.Cells(7).Value.ToString
                    If selectedRow.Cells(8).Value.ToString = "Done" Then
                        .Guna2ToggleSwitch1.Checked = True
                    Else
                        .Guna2ToggleSwitch1.Checked = False
                    End If
                    .ShowDialog()
                End With
                displayAppointment()
            ElseIf colName = "action_delete" Then
                deleteAppointment(selectedRow.Cells(3).Value.ToString)
                displayAppointment()
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub deleteAppointment(ByVal aaid As Integer)
        Dim dialogResult As DialogResult = MessageBox.Show("Do you want to delete this record?", "Appointment", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogResult = DialogResult.Yes Then
            conn.Open()
            Try
                comm = New MySqlCommand("prcDeleteAppointment", conn)
                With comm
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@aaid", aaid)
                    .ExecuteNonQuery()
                End With
            Catch ex As Exception
                conn.Close()
            End Try
            conn.Close()
        End If
    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        deletePrintTbl()
        insertPrintTbl(dgvAppointment)
        frmPrintAppointment.ShowDialog()
    End Sub
    Private Sub insertPrintTbl(ByRef printTable As DataGridView)
        Dim row As Integer

        Try
            row = 0
            While row < printTable.RowCount

                With printTable
                    saveDataToPrint(.Rows(row).Cells(4).Value.ToString,
                                    .Rows(row).Cells(5).Value.ToString,
                                    .Rows(row).Cells(6).Value.ToString,
                                    .Rows(row).Cells(7).Value.ToString,
                                    .Rows(row).Cells(8).Value.ToString)
                End With
                row = row + 1
            End While
        Catch ex As Exception
            MsgBox("" + ex.Message)
        End Try
    End Sub

    Private Sub saveDataToPrint(ByVal data1 As String, ByVal data2 As String, ByVal data3 As Date, ByVal data4 As String, ByVal data5 As String)
        conn.Open()
        Try
            comm = New MySqlCommand("prcPrintTable", conn)
            With comm
                .Parameters.Clear()
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@temp1", data1)
                .Parameters.AddWithValue("@temp2", data2)
                .Parameters.AddWithValue("@temp3", Format(data3, "MM/dd/yyyy"))
                .Parameters.AddWithValue("@temp4", data4)
                .Parameters.AddWithValue("@temp5", data5)
                .Parameters.AddWithValue("@temp6", "")
                .Parameters.AddWithValue("@temp7", "")
                .Parameters.AddWithValue("@temp8", "")
                .Parameters.AddWithValue("@temp9", "")
                .Parameters.AddWithValue("@temp10", "")
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            conn.Close()
        End Try
        conn.Close()
    End Sub

    Private Sub chkboxAutoSearch_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxAutoSearch.CheckedChanged
        If chkboxAutoSearch.Checked = True Then
            btnSearch.Enabled = False
        Else
            btnSearch.Enabled = True
        End If
    End Sub

    Private Sub date_from_ValueChanged(sender As Object, e As EventArgs) Handles date_from.ValueChanged
        If chkboxAutoSearch.Checked = True Then
            filteredSearch()
        End If
    End Sub

    Private Sub date_to_ValueChanged(sender As Object, e As EventArgs) Handles date_to.ValueChanged
        If chkboxAutoSearch.Checked = True Then
            filteredSearch()
        End If
    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatus.SelectedIndexChanged
        If chkboxAutoSearch.Checked = True Then
            filteredSearch()
        End If
    End Sub
End Class
