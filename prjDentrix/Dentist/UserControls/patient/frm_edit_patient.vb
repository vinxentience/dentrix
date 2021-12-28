Imports MySql.Data.MySqlClient

Public Class frm_edit_patient
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim dialogResult As DialogResult = MessageBox.Show("Do you want to edit this patient?", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogResult = DialogResult.Yes And ValidateInputs() Then
            conn.Open()
            Try
                comm = New MySqlCommand("prcUpdatePatient", conn)
                With comm
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@ppid", lblPatientId.Text)
                    .Parameters.AddWithValue("@ffname", txtFname.Text)
                    .Parameters.AddWithValue("@llname", txtLname.Text)
                    .Parameters.AddWithValue("@mmname", txtMname.Text)
                    .Parameters.AddWithValue("@ggender", cmbGender.Text)
                    .Parameters.AddWithValue("@ccontact", txtContactNum.Text)
                    .Parameters.AddWithValue("@eeaddress", txtEmailAdd.Text)
                    .Parameters.AddWithValue("@ddob", dtpBirthDate.Value.ToString("yyyy-MM-dd"))
                    .Parameters.AddWithValue("@aaddress", txtAddress.Text)
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
        If txtAddress.Text = String.Empty Or txtContactNum.Text = String.Empty Or txtEmailAdd.Text = String.Empty Or txtFname.Text = String.Empty Or txtLname.Text = String.Empty Or txtMname.Text = String.Empty Or cmbGender.Text = String.Empty Then
            MessageBox.Show("Please fill in the textbox.")
            Return False
        Else
            If IsNumeric(txtContactNum.Text) = False Then
                MessageBox.Show("Contact Number must be numberic.")
                Return False
            End If

            Return True
        End If
    End Function


    Private Sub frm_edit_patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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