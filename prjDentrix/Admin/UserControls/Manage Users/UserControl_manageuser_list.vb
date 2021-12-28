Imports MySql.Data.MySqlClient

Public Class UserControl_manageuser_list
    Private Sub UserControl_manageuser_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayDentist()
        cmbUserRole.SelectedIndex = 0
    End Sub

    Private Sub displayDentist()
        Dim table As New DataTable()
        conn.Open()
        Try
            comm = New MySqlCommand("prcSearchUser", conn)
            With comm
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@user_role", "Dentist")
                .Parameters.AddWithValue("@search_filter", cmbFilter.Text)
                .Parameters.AddWithValue("@search_value", txtSearchBox.Text)
                .ExecuteNonQuery()
            End With
            Dim da As New MySqlDataAdapter
            da.SelectCommand = comm
            Dim dt As New DataTable
            dt.Clear()

            da.Fill(dt)
            dgvUserlist.DataSource = dt
            Dim imgColumn = DirectCast(dgvUserlist.Columns(8), DataGridViewImageColumn)
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Stretch

        Catch ex As Exception

        End Try
        conn.Close()
    End Sub

    Private Sub displayAdmin()
        Dim table As New DataTable()
        conn.Open()
        Try
            comm = New MySqlCommand("prcSearchUser", conn)
            With comm
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@user_role", "Admin")
                .Parameters.AddWithValue("@search_filter", cmbFilter.Text)
                .Parameters.AddWithValue("@search_value", txtSearchBox.Text)
                .ExecuteNonQuery()
            End With
            Dim da As New MySqlDataAdapter
            da.SelectCommand = comm
            Dim dt As New DataTable
            dt.Clear()

            da.Fill(dt)
            dgvUserlist.DataSource = dt

        Catch ex As Exception

        End Try
        conn.Close()
    End Sub

    Private Sub cmbUserRole_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbUserRole.SelectedValueChanged
        If cmbUserRole.Text = "Admin" Then
            displayAdmin()
        Else
            displayDentist()
        End If
    End Sub

    Private Sub txtSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBox.TextChanged
        If cmbUserRole.Text = "Admin" Then
            displayAdmin()
        Else
            displayDentist()
        End If
    End Sub

    Private Sub dgvUserlist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUserlist.CellContentClick
        Dim colName As String = dgvUserlist.Columns(e.ColumnIndex).Name
        Dim selectedRow As New DataGridViewRow
        Dim index As New Integer
        Try
            index = e.RowIndex
            selectedRow = dgvUserlist.Rows(index)
            If colName = "action_edit" Then
                With frm_admin_edituser
                    .urole = selectedRow.Cells(7).Value.ToString
                    .olduid = selectedRow.Cells(2).Value.ToString
                    .ShowDialog()
                End With
            ElseIf colName = "action_delete" Then
                deleteUser(selectedRow.Cells(2).Value.ToString, selectedRow.Cells(7).Value.ToString)
            End If
            cmbUserRole.SelectedIndex = 0
            displayDentist()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub deleteUser(ByVal uid_delete As Integer, ByVal role As String)
        Dim dialogResult As DialogResult = MessageBox.Show("Do you want to delete this record?", "Manage User", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogResult = DialogResult.Yes Then
            conn.Open()
            Try
                comm = New MySqlCommand("prcDeleteAccount", conn)
                With comm
                    .Parameters.Clear()
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@userid", uid_delete)
                    .Parameters.AddWithValue("@urole", role)
                    .ExecuteNonQuery()
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            conn.Close()
        End If
    End Sub
End Class
