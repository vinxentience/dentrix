Imports MySql.Data.MySqlClient

Public Class UserControl_dashboard
    Dim comm2 As MySqlCommand
    Dim adapter2 As MySqlDataAdapter
    Private Sub UserControl_dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            comm = New MySqlCommand("prcGetTotalPatient", conn)
            With comm
                .Parameters.Clear()
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@did", user_id)
                .ExecuteNonQuery()
            End With
            adapter = New MySqlDataAdapter(comm)
            Dim table As New DataTable()
            adapter.Fill(table)

            lblTotalPatient.Text = table.Rows(0).Item(0).ToString()
            conn.Close()
        Catch ex As Exception
            conn.Close()
        Finally
            conn.Dispose()
        End Try

        Try
            conn.Open()
            comm = New MySqlCommand("prcGetTotalRevenue", conn)
            With comm
                .Parameters.Clear()
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@did", user_id)
                .Parameters.AddWithValue("@date_today", Date.Now().ToString("yyyy-MM-dd"))
                .Parameters.AddWithValue("@service_type", "Service")
                .ExecuteNonQuery()
            End With
            adapter = New MySqlDataAdapter(comm)
            Dim table As New DataTable()
            adapter.Fill(table)

            lblTotalProfitService.Text = Format(table.Rows(0).Item(0), "P###,###,###.##")
            conn.Close()
        Catch ex As Exception
            conn.Close()
        Finally
            conn.Dispose()
        End Try

        Try
            conn.Open()
            comm = New MySqlCommand("prcGetTotalRevenue", conn)
            With comm
                .Parameters.Clear()
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@did", user_id)
                .Parameters.AddWithValue("@date_today", Date.Now().ToString("yyyy-MM-dd"))
                .Parameters.AddWithValue("@service_type", "Item")
                .ExecuteNonQuery()
            End With
            adapter = New MySqlDataAdapter(comm)
            Dim table As New DataTable()
            adapter.Fill(table)

            lblTotalProfitItem.Text = Format(table.Rows(0).Item(0), "P###,###,###.##")
            conn.Close()
        Catch ex As Exception
            conn.Close()
        Finally
            conn.Dispose()
        End Try

        Try
            conn.Open()
            comm = New MySqlCommand("prcTotalUser", conn)
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
        Finally
            conn.Dispose()
        End Try

        Try
            conn.Open()
            comm = New MySqlCommand("prcSearchAppointment", conn)
            With comm
                .Parameters.Clear()
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@did", user_id)
                .Parameters.AddWithValue("@search_filter", "Count Today")
                .Parameters.AddWithValue("@date_from", Date.Now().ToString("yyyy-MM-dd"))
                .Parameters.AddWithValue("@date_to", Date.Now().ToString("yyyy-MM-dd"))
                .Parameters.AddWithValue("@search_status", "N/A")
                .ExecuteNonQuery()
            End With
            adapter = New MySqlDataAdapter(comm)
            Dim table As New DataTable()
            adapter.Fill(table)

            If table.Rows.Count > 0 Then
                lblAppointmentToday.Text = table.Rows(0).Item(0).ToString()
            Else
                lblAppointmentToday.Text = "0"
            End If


            conn.Close()
        Catch ex As Exception
            conn.Close()
        Finally
            conn.Dispose()
        End Try

        Try
            conn.Open()
            comm = New MySqlCommand("prcGetTotalItems", conn)
            With comm
                .Parameters.Clear()
                .CommandType = CommandType.StoredProcedure
                .ExecuteNonQuery()
            End With
            adapter = New MySqlDataAdapter(comm)
            Dim table As New DataTable()
            adapter.Fill(table)

            If table.Rows.Count > 0 Then
                lblTotalItems.Text = table.Rows(0).Item(0).ToString()
            Else
                lblTotalItems.Text = "0"
            End If

            conn.Close()
        Catch ex As Exception
            conn.Close()
        Finally
            conn.Dispose()
        End Try

    End Sub

End Class
