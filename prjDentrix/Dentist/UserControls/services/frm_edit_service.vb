Imports MySql.Data.MySqlClient

Public Class frm_edit_service
    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Dim dialogResult As DialogResult = MessageBox.Show("Do you want to edit this patient?", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogResult = DialogResult.Yes And ValidateInputs() Then
            conn.Open()
            Try
                comm = New MySqlCommand("prcUpdateService", conn)
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
            Me.Dispose()
        Else
        End If
    End Sub

    Private Function ValidateInputs() As Boolean
        If txtServiceName.Text = String.Empty Or txtServiceCost.Text = String.Empty Then
            MessageBox.Show("Please fill in the textbox.")
            Return False
        Else
            Return True
        End If
    End Function
End Class