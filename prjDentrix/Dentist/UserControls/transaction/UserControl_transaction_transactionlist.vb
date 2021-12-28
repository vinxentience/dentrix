Imports MySql.Data.MySqlClient

Public Class UserControl_transaction_transactionlist
    Dim transactionType As String
    Private Sub cmbTransactionType_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbTransactionType.SelectedValueChanged
        Dim table As New DataTable()
        If cmbTransactionType.SelectedItem = "Service" Then
            transactionType = "prcSearchPatientServiceTransaction"
            conn.Open()
            Try
                comm = New MySqlCommand(transactionType, conn)
                With comm
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@did", user_id)
                    .Parameters.AddWithValue("@search_filter", "All")
                    .Parameters.AddWithValue("@patient_name", "")
                    .Parameters.AddWithValue("@date_from", "")
                    .Parameters.AddWithValue("@date_to", "")
                    .ExecuteNonQuery()
                End With
                Dim da As New MySqlDataAdapter
                da.SelectCommand = comm
                Dim dt As New DataTable
                dt.Clear()
                da.Fill(dt)
                dgvTransaction.DataSource = dt

            Catch ex As Exception

            End Try
            conn.Close()
        ElseIf cmbTransactionType.SelectedItem = "Item"
            transactionType = "prcSearchPatientItemTransaction"
            conn.Open()
            Try
                comm = New MySqlCommand(transactionType, conn)
                With comm
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@did", user_id)
                    .Parameters.AddWithValue("@search_filter", "All")
                    .Parameters.AddWithValue("@patient_name", "")
                    .Parameters.AddWithValue("@date_from", "")
                    .Parameters.AddWithValue("@date_to", "")
                    .ExecuteNonQuery()
                End With
                Dim da As New MySqlDataAdapter
                da.SelectCommand = comm
                Dim dt As New DataTable
                dt.Clear()
                da.Fill(dt)
                dgvTransaction.DataSource = dt

            Catch ex As Exception

            End Try
            conn.Close()
        Else
            MsgBox("There is an error fetching data.")
        End If


    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        filteredSearch()
    End Sub

    Private Sub filteredSearch()
        conn.Open()
        Try
            comm = New MySqlCommand(transactionType, conn)
            With comm
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@did", user_id)
                .Parameters.AddWithValue("@search_filter", cmbFilter.Text)
                .Parameters.AddWithValue("@patient_name", txtSearchBox.Text)
                .Parameters.AddWithValue("@date_from", dtpDateFrom.Value.ToString("yyyy-MM-dd"))
                .Parameters.AddWithValue("@date_to", dtpDateTo.Value.ToString("yyyy-MM-dd"))
                .ExecuteNonQuery()
            End With
            Dim da As New MySqlDataAdapter
            da.SelectCommand = comm
            Dim dt As New DataTable
            dt.Clear()
            da.Fill(dt)
            dgvTransaction.DataSource = dt

        Catch ex As Exception

        End Try
        conn.Close()
    End Sub

    Private Sub cmbFilter_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedValueChanged
        If cmbFilter.SelectedItem = "All" Then
            txtSearchBox.Enabled = False
            dtpDateFrom.Enabled = False
            dtpDateTo.Enabled = False
        ElseIf cmbFilter.SelectedItem = "By Name" Then
            txtSearchBox.Enabled = True
            dtpDateFrom.Enabled = False
            dtpDateTo.Enabled = False
        ElseIf cmbFilter.SelectedItem = "Between Dates" Then
            txtSearchBox.Enabled = False
            dtpDateFrom.Enabled = True
            dtpDateTo.Enabled = True
        End If
    End Sub

    Private Sub UserControl_transaction_transactionlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDateFrom.Value = Date.Now
        dtpDateTo.Value = Date.Now
    End Sub

    Private Sub dgvTransaction_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransaction.CellClick
        Dim colName As String = dgvTransaction.Columns(e.ColumnIndex).Name
        Dim selectedRow As DataGridViewRow
        Dim index As Integer
        Try
            index = e.RowIndex
            selectedRow = dgvTransaction.Rows(index)
            If colName = "action_delete" Then
                deleteTransaction(selectedRow.Cells(1).Value.ToString, cmbTransactionType.Text)
                filteredSearch()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub deleteTransaction(ByVal tid As Integer, ByVal ttype As String)
        Dim dialogResult As DialogResult = MessageBox.Show("Do you want to delete this record?", "Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogResult = DialogResult.Yes Then
            conn.Open()
            Try
                comm = New MySqlCommand("prcDeleteTransaction", conn)
                With comm
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@tid", tid)
                    .Parameters.AddWithValue("@ttype", ttype)
                    .ExecuteNonQuery()
                End With
            Catch ex As Exception
                conn.Close()
            End Try
            conn.Close()
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        deletePrintTbl()
        insertPrintTbl(dgvTransaction)
        If cmbTransactionType.Text = "Service" Then
            frmPrintTransaction_Service.ShowDialog()
        Else
            frmPrintTransaction_Item.ShowDialog()
        End If
    End Sub

    Private Sub insertPrintTbl(ByRef printTable As DataGridView)
        Dim row As Integer

        Try
            row = 0
            While row < printTable.RowCount

                With printTable
                    saveDataToPrint(.Rows(row).Cells(1).Value.ToString,
                                    .Rows(row).Cells(2).Value.ToString,
                                    .Rows(row).Cells(3).Value.ToString,
                                    .Rows(row).Cells(4).Value.ToString,
                                    .Rows(row).Cells(5).Value.ToString,
                                    .Rows(row).Cells(6).Value.ToString)
                End With
                row = row + 1
            End While
        Catch ex As Exception
            MsgBox("" + ex.Message)
        End Try
    End Sub

    Private Sub saveDataToPrint(ByVal data1 As String, ByVal data2 As String, ByVal data3 As String, ByVal data4 As Date, ByVal data5 As String, ByVal data6 As String)
        conn.Open()
        Try
            comm = New MySqlCommand("prcPrintTable", conn)
            With comm
                .Parameters.Clear()
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@temp1", data1)
                .Parameters.AddWithValue("@temp2", data2)
                .Parameters.AddWithValue("@temp3", data3)
                .Parameters.AddWithValue("@temp4", Format(data4, "MM/dd/yyyy"))
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


End Class
