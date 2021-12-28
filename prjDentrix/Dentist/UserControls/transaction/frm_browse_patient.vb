Imports MySql.Data.MySqlClient

Public Class frm_browse_patient
    Public pid As Integer
    Public pname As String
    Private Sub frm_browse_patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        filteredSearch()
    End Sub

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxAutoSearch.CheckedChanged
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

    Private Sub dgvPatients_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPatients.CellContentClick
        Dim colName As String = dgvPatients.Columns(e.ColumnIndex).Name
        Dim selectedRow As DataGridViewRow
        Dim index As Integer
        Try
            index = e.RowIndex
            selectedRow = dgvPatients.Rows(index)
            pid = selectedRow.Cells(0).Value.ToString
            pname = selectedRow.Cells(1).Value.ToString
        Catch ex As Exception

        End Try

        Dim dialogResult As DialogResult = MessageBox.Show("Do you want to select " + dgvPatients.SelectedCells.Item(1).Value.ToString + "?", "Service Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogResult = DialogResult.Yes Then
            Me.Dispose()
        End If
    End Sub

    Private Sub cmbGender_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbGender.SelectedValueChanged
        If chkboxAutoSearch.Checked = True Then
            filteredSearch()
        End If
    End Sub
End Class