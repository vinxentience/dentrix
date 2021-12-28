Imports MySql.Data.MySqlClient

Public Class UserControl_patient_addpatient
    Dim maxCol As Integer
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim dialogResult As DialogResult = MessageBox.Show("Do you want to register this account?", "Register", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogResult = DialogResult.Yes And ValidateInputs() Then
            conn.Open()
            Try
                comm = New MySqlCommand("prcAddPatient", conn)
                With comm
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@pid", lblPatientId.Text)
                    .Parameters.AddWithValue("@ffname", txtFirstName.Text)
                    .Parameters.AddWithValue("@llname", txtLastName.Text)
                    .Parameters.AddWithValue("@mmname", txtMiddleName.Text)
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

            Try
                comm = New MySqlCommand("prcDentistPatientRelationship", conn)
                With comm
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@did", user_id)
                    .Parameters.AddWithValue("@pid", maxCol)
                    .ExecuteNonQuery()
                End With
            Catch ex As Exception
                conn.Close()
            End Try
            conn.Close()
            getMaxCol()
            ClearInputs()
        Else
        End If
    End Sub

    Private Function ValidateInputs() As Boolean
        If txtAddress.Text = String.Empty Or txtContactNum.Text = String.Empty Or txtEmailAdd.Text = String.Empty Or txtFirstName.Text = String.Empty Or txtLastName.Text = String.Empty Or txtMiddleName.Text = String.Empty Or cmbGender.Text = String.Empty Then
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

    Private Sub ClearInputs()
        txtAddress.Text = String.Empty
        txtContactNum.Text = String.Empty
        txtEmailAdd.Text = String.Empty
        txtFirstName.Text = String.Empty
        txtLastName.Text = String.Empty
        txtMiddleName.Text = String.Empty
        cmbGender.SelectedIndex = -1
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearInputs()
    End Sub

    Private Sub frmRegisterDentist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getMaxCol()
    End Sub

    Private Sub getMaxCol()
        dtpBirthDate.MaxDate = DateTime.Today
        dtpBirthDate.Value = DateTime.Today
        conn.Open()
        Try
            comm = New MySqlCommand("prcGetMaxColumnPatient", conn)
            With comm
                .CommandType = CommandType.StoredProcedure
                .ExecuteNonQuery()
            End With

            adapter = New MySqlDataAdapter(comm)
            Dim table As New DataTable()
            adapter.Fill(table)
            maxCol = table.Rows(0).Item(0).ToString()
            lblPatientId.Text = maxCol

        Catch ex As Exception
            conn.Close()
        End Try
        conn.Close()
    End Sub

End Class
