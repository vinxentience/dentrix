Imports MySql.Data.MySqlClient

Public Class UserControl_prescription_addprescription
    Dim maxCol As Integer
    Private Sub UserControl_prescription_addprescription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getMaxCol()
    End Sub

    Private Sub getMaxCol()
        conn.Open()
        Try
            comm = New MySqlCommand("prcGetMaxColumnPrescription", conn)
            With comm
                .CommandType = CommandType.StoredProcedure
                .ExecuteNonQuery()
            End With

            adapter = New MySqlDataAdapter(comm)
            Dim table As New DataTable()
            adapter.Fill(table)
            maxCol = table.Rows(0).Item(0).ToString()
            lblPrescriptionId.Text = maxCol

        Catch ex As Exception
            conn.Close()
        End Try
        conn.Close()
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim dialogResult As DialogResult = MessageBox.Show("Do you want to add this prescription?", "Prescription", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogResult = DialogResult.Yes And ValidateInputs() Then
            conn.Open()
            Try
                comm = New MySqlCommand("prcAddPrescription", conn)
                With comm
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@pid", lblPrescriptionId.Text)
                    .Parameters.AddWithValue("@mname", txtMedicine.Text)
                    .Parameters.AddWithValue("@mdosage", txtDosage.Text)
                    .Parameters.AddWithValue("@mday", txtInterval.Text)
                    .ExecuteNonQuery()
                End With
            Catch ex As Exception
                conn.Close()
            End Try

            Try
                comm = New MySqlCommand("prcPatientPrescriptionRelationship", conn)
                With comm
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@did", user_id)
                    .Parameters.AddWithValue("@pid", txtPatientID.Text)
                    .Parameters.AddWithValue("@presid", lblPrescriptionId.Text)
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

    Private Function ValidateInputs() As Boolean
        If txtDosage.Text = String.Empty Or txtInterval.Text = String.Empty Or txtMedicine.Text = String.Empty Or txtPatientID.Text = String.Empty Then
            MessageBox.Show("Please fill in the textbox.")
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub ClearInputs()
        txtDosage.Text = String.Empty
        txtInterval.Text = String.Empty
        txtMedicine.Text = String.Empty
        txtPatientID.Text = String.Empty
        lblPatientName.Text = "[?]"
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        With frm_browse_patient
            .ShowDialog()
            txtPatientID.Text = .pid
            lblPatientName.Text = .pname
        End With
    End Sub

    Private Sub txtPatientID_TextChanged(sender As Object, e As EventArgs) Handles txtPatientID.TextChanged
        If txtPatientID.Text = "" Then
            txtDosage.Enabled = False
            txtMedicine.Enabled = False
            txtInterval.Enabled = False
        Else
            txtDosage.Enabled = True
            txtMedicine.Enabled = True
            txtInterval.Enabled = True
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearInputs()
    End Sub
End Class
