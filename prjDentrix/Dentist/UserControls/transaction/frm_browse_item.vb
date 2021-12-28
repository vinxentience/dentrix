Imports MySql.Data.MySqlClient

Public Class frm_browse_item
    Public iid As Integer
    Public iname As String
    Public icost As Double
    Public iqty As Integer
    Private Sub chkboxAutoSearch_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxAutoSearch.CheckedChanged
        If chkboxAutoSearch.Checked = True Then
            btnSearch.Enabled = False
        Else
            btnSearch.Enabled = True
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        filteredSearch()
    End Sub

    Private Sub displayInventory()
        Dim table As New DataTable()
        conn.Open()
        Try
            comm = New MySqlCommand("prcSearchItems", conn)
            With comm
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@search_filter", "All")
                .Parameters.AddWithValue("@name_of_item", "")
                .ExecuteNonQuery()
            End With
            Dim da As New MySqlDataAdapter
            da.SelectCommand = comm
            Dim dt As New DataTable
            dt.Clear()

            da.Fill(dt)
            dgvInventory.DataSource = dt
        Catch ex As Exception
            conn.Close()
        End Try
        conn.Close()
    End Sub

    Private Sub filteredSearch()
        Dim table As New DataTable()
        conn.Open()
        Try
            comm = New MySqlCommand("prcSearchItems", conn)
            With comm
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@search_filter", cmbFilter.Text)
                .Parameters.AddWithValue("@name_of_item", txtSearchBox.Text)
                .ExecuteNonQuery()
            End With
            Dim da As New MySqlDataAdapter
            da.SelectCommand = comm
            Dim dt As New DataTable
            dt.Clear()

            da.Fill(dt)
            dgvInventory.DataSource = dt
        Catch ex As Exception
            conn.Close()
        End Try
        conn.Close()
    End Sub

    Private Sub txtSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBox.TextChanged
        If chkboxAutoSearch.Checked = True Then
            filteredSearch()
        End If
    End Sub

    Private Sub frm_browse_item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayInventory()
    End Sub

    Private Sub dgvInventory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventory.CellClick
        Dim colName As String = dgvInventory.Columns(e.ColumnIndex).Name
        Dim selectedRow As DataGridViewRow
        Dim index As Integer
        Try
            index = e.RowIndex
            selectedRow = dgvInventory.Rows(index)
            iid = selectedRow.Cells(0).Value.ToString
            iname = selectedRow.Cells(1).Value.ToString
            iqty = selectedRow.Cells(2).Value.ToString
            icost = selectedRow.Cells(5).Value.ToString
        Catch ex As Exception

        End Try
        If iqty = 0 And iid <> 0 Then
            MessageBox.Show("This item is out of stock.", "Item Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        Else
            Dim dialogResult As DialogResult = MessageBox.Show("Do you want to select " + dgvInventory.SelectedCells.Item(1).Value.ToString + "?", "Item Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dialogResult = DialogResult.Yes Then
                Me.Dispose()
            End If
        End If

    End Sub

    Private Sub cmbFilter_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedValueChanged
        If cmbFilter.Text = "All" Then
            txtSearchBox.Enabled = False
            txtSearchBox.Clear()
        ElseIf cmbFilter.Text = "By Name" Then
            txtSearchBox.Enabled = True
        ElseIf cmbFilter.Text = "By Brand" Then
            txtSearchBox.Enabled = True
        End If
    End Sub

End Class