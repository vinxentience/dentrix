Imports MySql.Data.MySqlClient

Public Class frm_edit_prescription
    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Dim dialogResult As DialogResult = MessageBox.Show("Do you want to edit this appointment?", "Appointment", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogResult = DialogResult.Yes And ValidateInputs() Then
            conn.Open()
            Try
                comm = New MySqlCommand("prcUpdatePrescription", conn)
                With comm
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@pid", lblPrescriptionId.Text)
                    .Parameters.AddWithValue("@mname", txtMedicine.Text)
                    .Parameters.AddWithValue("@mdose", txtDosage.Text)
                    .Parameters.AddWithValue("@mday", txtInterval.Text)

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
        If txtDosage.Text = String.Empty Or txtInterval.Text = String.Empty Or txtMedicine.Text = String.Empty Then
            MessageBox.Show("Please fill in the textbox.")
            Return False
        Else
            Return True
        End If
    End Function
End Class