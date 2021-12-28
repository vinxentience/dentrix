Imports MySql.Data.MySqlClient

Public Class UserControl_prescription_prescriptionlist
    Private Sub UserControl_prescription_prescriptionlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayPrescription()
    End Sub

    Private Sub displayPrescription()
        conn.Open()
        Try
            comm = New MySqlCommand("prcGetPrescription", conn)
            With comm
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@did", user_id)
                .Parameters.AddWithValue("@search_filter", "All")
                .Parameters.AddWithValue("@search_keyword", "")
                .Parameters.AddWithValue("@search_medicine", "")
                .ExecuteNonQuery()
            End With
            Dim da As New MySqlDataAdapter
            da.SelectCommand = comm
            Dim dt As New DataTable
            dt.Clear()

            da.Fill(dt)
            dgvPrescription.DataSource = dt

        Catch ex As Exception

        End Try
        conn.Close()
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        filteredSearch()
    End Sub

    Private Sub filteredSearch()
        conn.Open()
        Try
            comm = New MySqlCommand("prcGetPrescription", conn)
            With comm
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@did", user_id)
                .Parameters.AddWithValue("@search_filter", cmbFilter.Text)
                .Parameters.AddWithValue("@search_keyword", txtPatientName.Text)
                .Parameters.AddWithValue("@search_medicine", txtMedicine.Text)
                .ExecuteNonQuery()
            End With
            Dim da As New MySqlDataAdapter
            da.SelectCommand = comm
            Dim dt As New DataTable
            dt.Clear()

            da.Fill(dt)
            dgvPrescription.DataSource = dt

        Catch ex As Exception

        End Try
        conn.Close()
    End Sub

    Private Sub cmbFilter_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedValueChanged
        If cmbFilter.Text = "All" Then
            txtPatientName.Enabled = False
            txtMedicine.Enabled = False
            txtPatientName.Clear()
            txtMedicine.Clear()
        ElseIf cmbFilter.Text = "By Name" Then
            txtPatientName.Enabled = True
            txtMedicine.Enabled = False
            txtMedicine.Clear()
        ElseIf cmbFilter.Text = "By Medicine" Then
            txtPatientName.Enabled = False
            txtMedicine.Enabled = True
            txtPatientName.Clear()
        ElseIf cmbFilter.Text = "By Name and Medicine" Then
            txtPatientName.Enabled = True
            txtMedicine.Enabled = True
        End If
    End Sub

    Private Sub dgvPrescription_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPrescription.CellClick
        Dim colName As String = dgvPrescription.Columns(e.ColumnIndex).Name
        Dim selectedRow As DataGridViewRow
        Dim index As Integer
        Try
            index = e.RowIndex
            selectedRow = dgvPrescription.Rows(index)
            If colName = "action_print" Then
                Dim result As DialogResult = MessageBox.Show("Do you want to print a prescription receipt for " + selectedRow.Cells(5).Value.ToString() + "?", "Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Dim print_receipt As New rptPrescriptionReceipt
                    print_receipt.SetParameterValue("dname", u_fname + " " + u_lname)
                    print_receipt.SetParameterValue("pname", selectedRow.Cells(5).Value.ToString())
                    print_receipt.SetParameterValue("pdob", selectedRow.Cells(6).Value)
                    print_receipt.SetParameterValue("paddress", selectedRow.Cells(7).Value.ToString())
                    print_receipt.SetParameterValue("mname", selectedRow.Cells(8).Value.ToString())
                    print_receipt.SetParameterValue("mdosage", selectedRow.Cells(9).Value.ToString())
                    print_receipt.SetParameterValue("mday", selectedRow.Cells(10).Value.ToString())
                    print_receipt.SetParameterValue("rissued", Date.Now.ToString("yyyy-MM-dd"))
                    print_receipt.SetParameterValue("dcontact", u_contact_number)
                    print_receipt.SetParameterValue("demail", u_email_address)
                    frmPrescriptionReceipt.CrystalReportViewer1.ReportSource = print_receipt
                    frmPrescriptionReceipt.ShowDialog()
                End If
            ElseIf colName = "action_edit" Then
                With frm_edit_prescription
                    .lblPrescriptionId.Text = selectedRow.Cells(4).Value.ToString
                    .lblPatientName.Text = selectedRow.Cells(5).Value.ToString
                    .txtMedicine.Text = selectedRow.Cells(8).Value.ToString
                    .txtDosage.Text = selectedRow.Cells(9).Value.ToString
                    .txtInterval.Text = selectedRow.Cells(10).Value.ToString
                    .ShowDialog()
                End With
            ElseIf colName = "action_delete" Then
                deletePrescription(selectedRow.Cells(4).Value.ToString)
            End If
            displayPrescription()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub deletePrescription(ByVal pid As Integer)
        Dim dialogResult As DialogResult = MessageBox.Show("Do you want to delete this record?", "Prescription", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogResult = DialogResult.Yes Then
            conn.Open()
            Try
                comm = New MySqlCommand("prcDeletePrescription", conn)
                With comm
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@pid", pid)
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
        insertPrintTbl(dgvPrescription)
        frmPrintPrescription.ShowDialog()
    End Sub
    Private Sub insertPrintTbl(ByRef printTable As DataGridView)
        Dim row As Integer

        Try
            row = 0
            While row < printTable.RowCount

                With printTable
                    saveDataToPrint(.Rows(row).Cells(5).Value.ToString,
                                    .Rows(row).Cells(6).Value.ToString,
                                    .Rows(row).Cells(7).Value.ToString,
                                    .Rows(row).Cells(8).Value.ToString,
                                    .Rows(row).Cells(9).Value.ToString,
                                    .Rows(row).Cells(10).Value.ToString)
                End With
                row = row + 1
            End While
        Catch ex As Exception
            MsgBox("" + ex.Message)
        End Try
    End Sub

    Private Sub saveDataToPrint(ByVal data1 As String, ByVal data2 As Date, ByVal data3 As String, ByVal data4 As String, ByVal data5 As String, ByVal data6 As String)
        conn.Open()
        Try
            comm = New MySqlCommand("prcPrintTable", conn)
            With comm
                .Parameters.Clear()
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@temp1", data1)
                .Parameters.AddWithValue("@temp2", Format(data2, "MM/dd/yyyy"))
                .Parameters.AddWithValue("@temp3", data3)
                .Parameters.AddWithValue("@temp4", data4)
                .Parameters.AddWithValue("@temp5", data5)
                .Parameters.AddWithValue("@temp6", data6)
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

    Private Sub txtPatientName_TextChanged(sender As Object, e As EventArgs) Handles txtPatientName.TextChanged
        If chkboxAutoSearch.Checked = True Then
            filteredSearch()
        End If
    End Sub

    Private Sub txtMedicine_TextChanged(sender As Object, e As EventArgs) Handles txtMedicine.TextChanged
        If chkboxAutoSearch.Checked = True Then
            filteredSearch()
        End If
    End Sub
End Class
