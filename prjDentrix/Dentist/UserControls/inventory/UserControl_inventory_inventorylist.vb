Imports MySql.Data.MySqlClient

Public Class UserControl_inventory_inventorylist
    Private Sub UserControl_inventory_inventorylist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayInventory()
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
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        filteredSearch()
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
    Private Sub cmbFilter_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedValueChanged
        If cmbFilter.SelectedItem = "All" Then
            txtSearchBox.Enabled = False
        ElseIf cmbFilter.SelectedItem = "Out of Stock" Then
            txtSearchBox.Enabled = False
        Else
            txtSearchBox.Enabled = True
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        deletePrintTbl()
        insertPrintTbl(dgvInventory)
        frmPrintInventory.ShowDialog()
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

    Private Sub saveDataToPrint(ByVal data1 As String, ByVal data2 As String, ByVal data3 As String, ByVal data4 As String, ByVal data5 As String, ByVal data6 As String, ByVal data7 As String)
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
                .Parameters.AddWithValue("@temp6", data6)
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

    Private Sub dgvInventory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventory.CellContentClick
        Dim colName As String = dgvInventory.Columns(e.ColumnIndex).Name
        Dim selectedRow As DataGridViewRow
        Dim index As Integer
        Try
            index = e.RowIndex
            selectedRow = dgvInventory.Rows(index)
            If colName = "action_view" Then
                With frm_view_inventory
                    .lblItemID.Text = selectedRow.Cells(3).Value.ToString
                    .txtItemName.Text = selectedRow.Cells(4).Value.ToString
                    .txtItemQTY.Text = selectedRow.Cells(5).Value.ToString
                    .txtItemUnit.Text = selectedRow.Cells(6).Value.ToString
                    .txtItemDescription.Text = selectedRow.Cells(7).Value.ToString
                    .txtItemCost.Text = selectedRow.Cells(8).Value.ToString
                    .txtItemBrand.Text = selectedRow.Cells(9).Value.ToString
                    .ShowDialog()
                End With
            ElseIf colName = "action_edit" Then
                With frm_edit_inventory
                    .lblItemID.Text = selectedRow.Cells(3).Value.ToString
                    .txtItemName.Text = selectedRow.Cells(4).Value.ToString
                    .txtItemQTY.Text = selectedRow.Cells(5).Value.ToString
                    .txtItemUnit.Text = selectedRow.Cells(6).Value.ToString
                    .txtItemDescription.Text = selectedRow.Cells(7).Value.ToString
                    .txtItemCost.Text = selectedRow.Cells(8).Value.ToString
                    .txtItemBrand.Text = selectedRow.Cells(9).Value.ToString
                    .ShowDialog()
                End With
            ElseIf colName = "action_delete" Then
                deleteItem(selectedRow.Cells(3).Value.ToString)
            End If
            displayInventory()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub deleteItem(ByVal iid As Integer)
        Dim dialogResult As DialogResult = MessageBox.Show("Do you want to delete this item?", "Inventory", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogResult = DialogResult.Yes Then
            conn.Open()
            Try
                comm = New MySqlCommand("prcDeleteItem", conn)
                With comm
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@iid", iid)
                    .ExecuteNonQuery()
                End With
            Catch ex As Exception
                conn.Close()
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
End Class
