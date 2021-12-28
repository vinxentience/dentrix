Imports MySql.Data.MySqlClient

Public Class UserControl_appointment_addappointment
    Dim maxCol As Integer
    Private Sub UserControl_appointment_addappointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getMaxCol()
        dtpAppointmentDate.Value = Date.Now
    End Sub

    Private Sub getMaxCol()
        conn.Open()
        Try
            comm = New MySqlCommand("prcGetMaxColumnAppointment", conn)
            With comm
                .CommandType = CommandType.StoredProcedure
                .ExecuteNonQuery()
            End With

            adapter = New MySqlDataAdapter(comm)
            Dim table As New DataTable()
            adapter.Fill(table)
            maxCol = table.Rows(0).Item(0).ToString()
            lblAppointmentID.Text = maxCol

        Catch ex As Exception
            conn.Close()
        End Try
        conn.Close()
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim dialogResult As DialogResult = MessageBox.Show("Do you want to add this appointment?", "Appointment", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogResult = DialogResult.Yes And ValidateInputs() Then
            conn.Open()
            Try
                comm = New MySqlCommand("prcAddAppointment", conn)
                With comm
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@aaid", lblAppointmentID.Text)
                    .Parameters.AddWithValue("@aadesc", txtDescription.Text)
                    .Parameters.AddWithValue("@aadate", dtpAppointmentDate.Value.ToString("yyyy-MM-dd"))
                    .Parameters.AddWithValue("@aatime", txtTime.Text)
                    .ExecuteNonQuery()
                End With
            Catch ex As Exception
                conn.Close()
            End Try

            Try
                comm = New MySqlCommand("prcPatientAppointmentRelationship", conn)
                With comm
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@did", user_id)
                    .Parameters.AddWithValue("@pid", txtPatientID.Text)
                    .Parameters.AddWithValue("@aid", lblAppointmentID.Text)
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
    Private Sub ClearInputs()
        txtDescription.Text = String.Empty
        txtTime.Text = String.Empty
        txtPatientID.Text = String.Empty
        lblPatientName.Text = "[?]"
        dtpAppointmentDate.Value = Date.Now
    End Sub

    Private Function ValidateInputs() As Boolean
        If txtTime.Text = String.Empty Or txtDescription.Text = String.Empty Or txtPatientID.Text = String.Empty Then
            MessageBox.Show("Please fill in the textbox.")
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        With frm_browse_patient
            .ShowDialog()
            txtPatientID.Text = .pid
            lblPatientName.Text = .pname
        End With
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearInputs()
    End Sub

    Private Sub txtPatientID_TextChanged(sender As Object, e As EventArgs) Handles txtPatientID.TextChanged
        If txtPatientID.Text = "" Then
            txtDescription.Enabled = False
            txtTime.Enabled = False
            dtpAppointmentDate.Enabled = False
        Else
            txtDescription.Enabled = True
            txtTime.Enabled = True
            dtpAppointmentDate.Enabled = True
        End If

    End Sub

End Class
