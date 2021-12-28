Imports MySql.Data.MySqlClient

Public Class frm_edit_appointment
    Dim isDone As String
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim dialogResult As DialogResult = MessageBox.Show("Do you want to edit this appointment?", "Appointment", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogResult = DialogResult.Yes And ValidateInputs() Then
            conn.Open()
            Try
                comm = New MySqlCommand("prcUpdateAppointment", conn)
                With comm
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@aid", lblAppointmentID.Text)
                    .Parameters.AddWithValue("@adesc", txtDescription.Text)
                    .Parameters.AddWithValue("@adate", dtpAppointmentDate.Value.ToString("yyyy-MM-dd"))
                    .Parameters.AddWithValue("@atime", txtTime.Text)
                    .Parameters.AddWithValue("@astatus", isDone)
                    .ExecuteNonQuery()
                End With
            Catch ex As Exception
                conn.Close()
            End Try
            conn.Close()
        End If
        Me.Dispose()
    End Sub

    Private Function ValidateInputs() As Boolean
        If txtTime.Text = String.Empty Or txtDescription.Text = String.Empty Then
            MessageBox.Show("Please fill in the textbox.")
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Guna2ToggleSwitch1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2ToggleSwitch1.CheckedChanged
        If Guna2ToggleSwitch1.Checked = True Then
            isDone = "Done"
        Else
            isDone = "N/A"
        End If
    End Sub
End Class