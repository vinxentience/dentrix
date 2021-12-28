Imports System.IO
Imports MySql.Data.MySqlClient
Public Class UserControl_patient_patientlist

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        filteredSearch()
    End Sub

    Private Sub filteredSearch()
        Dim table As New DataTable()
        conn.Open()
        Try
            comm = New MySqlCommand("prcSearchPatient", conn)
            With comm
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@patient_name", txtSearchBox.Text)
                .Parameters.AddWithValue("@search_filter", cmbFilter.Text)
                .Parameters.AddWithValue("@patient_gender", cmbGender.Text)
                .Parameters.AddWithValue("@did", user_id)
                .ExecuteNonQuery()
            End With
            Dim da As New MySqlDataAdapter
            da.SelectCommand = comm
            Dim dt As New DataTable
            dt.Clear()

            da.Fill(dt)
            dgvPatients.DataSource = dt
            Dim imgColumn = DirectCast(dgvPatients.Columns(7), DataGridViewImageColumn)
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Stretch

        Catch ex As Exception

        End Try
        conn.Close()
    End Sub

    Private Sub cmbFilter_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedValueChanged
        If cmbFilter.Text = "All" Then
            cmbGender.Enabled = False
            txtSearchBox.Enabled = False
            cmbGender.SelectedText = ""
            txtSearchBox.Clear()
        ElseIf cmbFilter.Text = "By Name" Then
            cmbGender.Enabled = False
            cmbGender.SelectedText = ""
            txtSearchBox.Enabled = True
        ElseIf cmbFilter.Text = "By Gender" Then
            cmbGender.Enabled = True
            txtSearchBox.Enabled = False
            txtSearchBox.Clear()
        ElseIf cmbFilter.Text = "By Name and Gender" Then
            txtSearchBox.Enabled = True
            cmbGender.Enabled = True
        End If
    End Sub

    Private Sub UserControl_patient_patientlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayPatient()
    End Sub

    Private Sub displayPatient()
        Dim table As New DataTable()
        conn.Open()
        Try
            comm = New MySqlCommand("prcSearchPatient", conn)
            With comm
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@patient_name", "")
                .Parameters.AddWithValue("@search_filter", "All")
                .Parameters.AddWithValue("@patient_gender", "")
                .Parameters.AddWithValue("@did", user_id)
                .ExecuteNonQuery()
            End With
            Dim da As New MySqlDataAdapter
            da.SelectCommand = comm
            Dim dt As New DataTable
            dt.Clear()

            da.Fill(dt)
            dgvPatients.DataSource = dt
            Dim imgColumn = DirectCast(dgvPatients.Columns(10), DataGridViewImageColumn)
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Stretch

        Catch ex As Exception

        End Try
        conn.Close()
    End Sub

    Private Sub dgvPatients_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPatients.CellClick
        Dim colName As String = dgvPatients.Columns(e.ColumnIndex).Name
        Dim selectedRow As New DataGridViewRow
        Dim index As New Integer
        Try
            index = e.RowIndex
            selectedRow = dgvPatients.Rows(index)
            If colName = "action_view" Then
                With frm_view_patient
                    .lblPatientId.Text = selectedRow.Cells(3).Value.ToString
                    If selectedRow.Cells(5).Value.ToString = "Male" Then
                        .cmbGender.SelectedIndex = 0
                    Else
                        .cmbGender.SelectedIndex = 1
                    End If
                    .txtContactNum.Text = selectedRow.Cells(6).Value.ToString
                    .txtEmailAdd.Text = selectedRow.Cells(7).Value.ToString
                    .dtpBirthDate.Value = selectedRow.Cells(8).Value
                    .txtAddress.Text = selectedRow.Cells(9).Value.ToString
                    .ShowDialog()
                End With
            ElseIf colName = "action_edit" Then
                With frm_edit_patient
                    .lblPatientId.Text = selectedRow.Cells(3).Value.ToString
                    If selectedRow.Cells(5).Value.ToString = "Male" Then
                        .cmbGender.SelectedIndex = 0
                    Else
                        .cmbGender.SelectedIndex = 1
                    End If
                    .txtContactNum.Text = selectedRow.Cells(6).Value.ToString
                    .txtEmailAdd.Text = selectedRow.Cells(7).Value.ToString
                    .dtpBirthDate.Value = selectedRow.Cells(8).Value
                    .txtAddress.Text = selectedRow.Cells(9).Value.ToString
                    .ShowDialog()
                End With
                displayPatient()
            ElseIf colName = "action_delete" Then
                deletePatient(selectedRow.Cells(3).Value.ToString)
                displayPatient()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub deletePatient(ByVal pid As Integer)
        Dim dialogResult As DialogResult = MessageBox.Show("Do you want to delete this record?", "Patient", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogResult = DialogResult.Yes Then
            conn.Open()
            Try
                comm = New MySqlCommand("prcDeletePatient", conn)
                With comm
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@ppid", pid)
                    .ExecuteNonQuery()
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            conn.Close()
        End If
    End Sub

    Private Sub chkboxAutoSearch_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxAutoSearch.CheckedChanged
        If chkboxAutoSearch.Checked = True Then
            btnSearch.Enabled = False
        Else
            btnSearch.Enabled = True
        End If
    End Sub

    Private Sub txtSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBox.TextChanged
        If chkboxAutoSearch.Checked = True Then
            filteredSearch()
        End If
    End Sub

    Private Sub cmbGender_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbGender.SelectedValueChanged
        If chkboxAutoSearch.Checked = True Then
            filteredSearch()
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        deletePrintTbl()
        insertPrintTbl(dgvPatients)
        frmPrintPatient.ShowDialog()
    End Sub

    Private Sub insertPrintTbl(ByRef printTable As DataGridView)
        Dim row As Integer

        Try
            row = 0
            While row < printTable.RowCount

                With printTable
                    saveDataToPrint(.Rows(row).Cells(3).Value.ToString,
                                    .Rows(row).Cells(4).Value.ToString,
                                    .Rows(row).Cells(5).Value.ToString,
                                    .Rows(row).Cells(6).Value.ToString,
                                    .Rows(row).Cells(7).Value.ToString,
                                    .Rows(row).Cells(8).Value.ToString,
                                    .Rows(row).Cells(9).Value.ToString)
                End With
                row = row + 1
            End While
        Catch ex As Exception
            MsgBox("" + ex.Message)
        End Try
    End Sub

    Private Sub saveDataToPrint(ByVal data1 As String, ByVal data2 As String, ByVal data3 As String, ByVal data4 As String, ByVal data5 As String, ByVal data6 As Date, ByVal data7 As String)
        conn.Open()
        Try
            comm = New MySqlCommand("prcPrintTable", conn)
            With comm
                .Parameters.Clear()
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@temp1", data1)
                .Parameters.AddWithValue("@temp2", data2)
                .Parameters.AddWithValue("@temp3", data3)
                .Parameters.AddWithValue("@temp4", data4)
                .Parameters.AddWithValue("@temp5", data5)
                .Parameters.AddWithValue("@temp6", Format(data6, "MM/dd/yyyy"))
                .Parameters.AddWithValue("@temp7", data7)
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
End Class
