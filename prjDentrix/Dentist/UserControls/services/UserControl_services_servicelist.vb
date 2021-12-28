Imports MySql.Data.MySqlClient

Public Class UserControl_services_servicelist
    Private Sub chkboxAutoSearch_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxAutoSearch.CheckedChanged
        If chkboxAutoSearch.Checked = True Then
            btnSearch.Enabled = False
        Else
            btnSearch.Enabled = True
        End If
    End Sub

    Private Sub displayService()
        Dim table As New DataTable()
        conn.Open()
        Try
            comm = New MySqlCommand("prcSearchService", conn)
            With comm
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@search_filter", "All")
                .Parameters.AddWithValue("@name_of_service", "")
                .ExecuteNonQuery()
            End With
            Dim da As New MySqlDataAdapter
            da.SelectCommand = comm
            Dim dt As New DataTable
            dt.Clear()

            da.Fill(dt)
            dgvService.DataSource = dt

        Catch ex As Exception

        End Try
        conn.Close()
    End Sub

    Private Sub filteredSearch()
        Dim table As New DataTable()
        conn.Open()
        Try
            comm = New MySqlCommand("prcSearchService", conn)
            With comm
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@search_filter", cmbFilter.Text)
                .Parameters.AddWithValue("@name_of_service", txtSearchBox.Text)
                .ExecuteNonQuery()
            End With
            Dim da As New MySqlDataAdapter
            da.SelectCommand = comm
            Dim dt As New DataTable
            dt.Clear()

            da.Fill(dt)
            dgvService.DataSource = dt

        Catch ex As Exception

        End Try
        conn.Close()
    End Sub

    Private Sub UserControl_services_servicelist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayService()
    End Sub

    Private Sub cmbFilter_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedValueChanged
        If cmbFilter.Text = "All" Then
            txtSearchBox.Enabled = False
        Else
            txtSearchBox.Enabled = True
        End If
    End Sub

    Private Sub txtSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBox.TextChanged
        If chkboxAutoSearch.Checked = True Then
            filteredSearch()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        filteredSearch()
    End Sub

    Private Sub dgvService_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvService.CellClick
        Dim colName As String = dgvService.Columns(e.ColumnIndex).Name
        Dim selectedRow As New DataGridViewRow
        Dim index As New Integer
        Try
            index = e.RowIndex
            selectedRow = dgvService.Rows(index)
            If colName = "action_view" Then
                With frm_view_service
                    .lblServiceID.Text = selectedRow.Cells(3).Value.ToString
                    .txtServiceName.Text = selectedRow.Cells(4).Value.ToString
                    .txtServiceCost.Text = selectedRow.Cells(5).Value.ToString
                    .ShowDialog()
                End With
            ElseIf colName = "action_edit" Then
                With frm_edit_service
                    .lblServiceID.Text = selectedRow.Cells(3).Value.ToString
                    .txtServiceName.Text = selectedRow.Cells(4).Value.ToString
                    .txtServiceCost.Text = selectedRow.Cells(5).Value.ToString
                    .ShowDialog()
                End With
                displayService()
            ElseIf colName = "action_delete" Then
                deleteService(selectedRow.Cells(3).Value.ToString)
                displayService()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub deleteService(ByVal sid As Integer)
        Dim dialogResult As DialogResult = MessageBox.Show("Do you want to delete this record?", "Service", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogResult = DialogResult.Yes Then
            conn.Open()
            Try
                comm = New MySqlCommand("prcDeleteService", conn)
                With comm
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@sid", sid)
                    .ExecuteNonQuery()
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            conn.Close()
        End If
    End Sub
End Class
