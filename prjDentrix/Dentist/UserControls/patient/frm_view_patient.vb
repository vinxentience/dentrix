Imports MySql.Data.MySqlClient

Public Class frm_view_patient
    Private Sub frm_view_patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            comm = New MySqlCommand("prcGetPatientName", conn)
            With comm
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@pid", lblPatientId.Text)
                .ExecuteNonQuery()
            End With
            adapter = New MySqlDataAdapter(comm)
            Dim table As New DataTable()
            adapter.Fill(table)

            If table.Rows.Count = 0 Then
                MsgBox("There is an error fetching data", MsgBoxStyle.Critical)
            Else
                txtFname.Text = table.Rows(0).Item(0).ToString()
                txtLname.Text = table.Rows(0).Item(1).ToString()
                txtMname.Text = table.Rows(0).Item(2).ToString()
            End If
            conn.Close()
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
End Class