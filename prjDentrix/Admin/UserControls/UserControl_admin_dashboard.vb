Imports MySql.Data.MySqlClient

Public Class UserControl_admin_dashboard
    Private Sub UserControl_admin_dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            comm = New MySqlCommand("prcGetTotalDentist", conn)
            With comm
                .CommandType = CommandType.StoredProcedure
                .ExecuteNonQuery()
            End With
            adapter = New MySqlDataAdapter(comm)
            Dim table As New DataTable()
            adapter.Fill(table)

            lblTotalDentist.Text = table.Rows(0).Item(0).ToString()
            conn.Close()
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

        Try
            conn.Open()
            comm = New MySqlCommand("prcGetTotalAdmin", conn)
            With comm
                .CommandType = CommandType.StoredProcedure
                .ExecuteNonQuery()
            End With
            adapter = New MySqlDataAdapter(comm)
            Dim table As New DataTable()
            adapter.Fill(table)

            lblTotalAdmins.Text = table.Rows(0).Item(0).ToString()
            conn.Close()
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

        Try
            conn.Open()
            comm = New MySqlCommand("prcGetTotalUser", conn)
            With comm
                .CommandType = CommandType.StoredProcedure
                .ExecuteNonQuery()
            End With
            adapter = New MySqlDataAdapter(comm)
            Dim table As New DataTable()
            adapter.Fill(table)

            lblTotalUser.Text = table.Rows(0).Item(0).ToString()
            conn.Close()
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
End Class
