Imports MySql.Data.MySqlClient

Public Class UserControl_services_addservice
    Dim maxCol As Integer
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim dialogResult As DialogResult = MessageBox.Show("Do you want to add this prescription?", "Prescription", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogResult = DialogResult.Yes And ValidateInputs() Then
            conn.Open()
            Try
                comm = New MySqlCommand("prcAddService", conn)
                With comm
                    .Parameters.Clear()
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@ssid", lblServiceID.Text)
                    .Parameters.AddWithValue("@ssname", txtServiceName.Text)
                    .Parameters.AddWithValue("@sscost", txtServiceCost.Text)
                    .ExecuteNonQuery()
                End With
            Catch ex As Exception
                conn.Close()
            End Try
            conn.Close()
            ClearInputs()
            getMaxCol()
        End If
    End Sub

    Private Sub getMaxCol()
        conn.Open()
        Try
            comm = New MySqlCommand("prcGetMaxColumnServices", conn)
            With comm
                .CommandType = CommandType.StoredProcedure
                .ExecuteNonQuery()
            End With

            adapter = New MySqlDataAdapter(comm)
            Dim table As New DataTable()
            adapter.Fill(table)
            maxCol = table.Rows(0).Item(0).ToString()
            lblServiceID.Text = maxCol

        Catch ex As Exception
            conn.Close()
        End Try
        conn.Close()
    End Sub

    Private Sub ClearInputs()
        txtServiceCost.Text = String.Empty
        txtServiceName.Text = String.Empty
    End Sub

    Private Function ValidateInputs() As Boolean
        If txtServiceName.Text = String.Empty Or txtServiceCost.Text = String.Empty Then
            MessageBox.Show("Please fill in the textbox.")
            Return False
        Else
            If IsNumeric(txtServiceCost.Text) = False Then
                MessageBox.Show("Service cost must be numberic.")
                Return False
            End If
            Return True
        End If
    End Function

    Private Sub UserControl_services_addservice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getMaxCol()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearInputs()
    End Sub
End Class
