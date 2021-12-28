Imports MySql.Data.MySqlClient

Public Class frm_browse_service_type
    Public sid As Integer
    Public sname As String
    Public scost As Double
    Private Sub chkboxAutoSearch_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxAutoSearch.CheckedChanged
        If chkboxAutoSearch.Checked = True Then
            btnSearch.Enabled = False
        Else
            btnSearch.Enabled = True
        End If
    End Sub

    Private Sub frm_browse_service_type_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayService()
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
            Dim imgColumn = DirectCast(dgvService.Columns(10), DataGridViewImageColumn)
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Stretch

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
            Dim imgColumn = DirectCast(dgvService.Columns(10), DataGridViewImageColumn)
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Stretch

        Catch ex As Exception

        End Try
        conn.Close()
    End Sub

    Private Sub txtSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBox.TextChanged
        If chkboxAutoSearch.Checked = True Then
            filteredSearch()
        End If
    End Sub

    Private Sub cmbFilter_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedValueChanged
        If cmbFilter.Text = "All" Then
            txtSearchBox.Enabled = False
            txtSearchBox.Clear()
        ElseIf cmbFilter.Text = "By Service" Then
            txtSearchBox.Enabled = True
        End If
    End Sub

    Private Sub dgvPatients_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvService.CellContentClick
        Dim colName As String = dgvService.Columns(e.ColumnIndex).Name
        Dim selectedRow As DataGridViewRow
        Dim index As Integer
        Try
            index = e.RowIndex
            selectedRow = dgvService.Rows(index)
            sid = selectedRow.Cells(0).Value.ToString
            sname = selectedRow.Cells(1).Value.ToString
            scost = selectedRow.Cells(2).Value.ToString
        Catch ex As Exception

        End Try

        Dim dialogResult As DialogResult = MessageBox.Show("Do you want to select " + dgvService.SelectedCells.Item(1).Value.ToString + "?", "Service Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogResult = DialogResult.Yes Then
            Me.Dispose()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        filteredSearch()
    End Sub

End Class