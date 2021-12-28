Imports MySql.Data.MySqlClient

Public Class UserControl_transaction_service
    Dim service_cost As Double
    Dim maxCol As Integer
    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        With frm_browse_patient
            .ShowDialog()
            txtPatientID.Text = .pid
            lblPatientName.Text = .pname
        End With
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        With frm_browse_service_type
            .ShowDialog()
            txtServiceID.Text = .sid
            lblServiceName.Text = .sname
            lblServiceCost.Text = .scost
        End With
        service_cost = CDbl(lblServiceCost.Text)
    End Sub

    Private Sub txtServiceID_TextChanged(sender As Object, e As EventArgs) Handles txtServiceID.TextChanged
        If txtPatientID.Text = String.Empty Or txtServiceID.Text = String.Empty Then
            txtPaymentAmount.Enabled = False
            dtpTransactionDate.Enabled = False
            txtPaymentDescription.Enabled = False
        Else
            txtPaymentAmount.Enabled = True
            dtpTransactionDate.Enabled = True
            txtPaymentDescription.Enabled = True
            getMaxCol()
        End If
    End Sub

    Private Sub getMaxCol()
        conn.Open()
        Try
            comm = New MySqlCommand("prcGetMaxColumnServiceTransaction", conn)
            With comm
                .CommandType = CommandType.StoredProcedure
                .ExecuteNonQuery()
            End With

            adapter = New MySqlDataAdapter(comm)
            Dim table As New DataTable()
            adapter.Fill(table)
            maxCol = table.Rows(0).Item(0).ToString()
            lblTransactionServiceID.Text = maxCol

        Catch ex As Exception
            conn.Close()
        End Try
        conn.Close()
    End Sub
    Private Sub txtPaymentAmount_TextChanged(sender As Object, e As EventArgs) Handles txtPaymentAmount.TextChanged
        If txtPaymentAmount.Text = "" Then
            Label6.Visible = False
            txtAddedBalance.Visible = False
            Label4.Visible = False
        Else
            Try
                Dim payment As Double = CDbl(txtPaymentAmount.Text)
                Dim total As Double
                txtTotalChange.Visible = False
                If service_cost > payment Then
                    Label4.Visible = False
                    txtTotalChange.Visible = False
                    Label6.Visible = True
                    txtAddedBalance.Visible = True

                    total = service_cost - payment
                    txtAddedBalance.Text = Format(total, "###,###,###.##")
                ElseIf service_cost < payment Then
                    Label4.Visible = True
                    txtTotalChange.Visible = True
                    Label6.Visible = False
                    txtAddedBalance.Visible = False

                    total = payment - service_cost
                    txtTotalChange.Text = Format(total, "###,###,###.##")
                Else
                    Label6.Visible = False
                    txtAddedBalance.Visible = False
                    Label4.Visible = False
                    txtTotalChange.Visible = False
                End If

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim dialogResult As DialogResult = MessageBox.Show("Do you want to add this transaction? Warning: You can not edit this transaction once submitted.", "Service Transation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If dialogResult = DialogResult.Yes And ValidateInputs() Then
            conn.Open()
            Try
                comm = New MySqlCommand("prcAddPaymentService", conn)
                With comm
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@tsid", lblTransactionServiceID.Text)
                    .Parameters.AddWithValue("@amt", txtPaymentAmount.Text)
                    .Parameters.AddWithValue("@pdate", dtpTransactionDate.Value.ToString("yyyy-MM-dd"))
                    .Parameters.AddWithValue("@pdesc", txtPaymentDescription.Text)
                    .Parameters.AddWithValue("@srender", lblServiceName.Text)
                    .ExecuteNonQuery()
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Try
                comm = New MySqlCommand("prcPatientTransactionServiceRelationship", conn)
                With comm
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@did", user_id)
                    .Parameters.AddWithValue("@pid", txtPatientID.Text)
                    .Parameters.AddWithValue("@sid", txtServiceID.Text)
                    .Parameters.AddWithValue("@tsid", lblTransactionServiceID.Text)
                    .ExecuteNonQuery()
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Try
                Dim payment As Double = CDbl(txtPaymentAmount.Text)
                If service_cost > payment Then
                    Try
                        comm = New MySqlCommand("prcAddPatientBalance", conn)
                        With comm
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.AddWithValue("@pid", txtPatientID.Text)
                            .Parameters.AddWithValue("@bamt", txtAddedBalance.Text)
                            .Parameters.AddWithValue("@tdate", dtpTransactionDate.Value.ToString("yyyy-MM-dd"))
                            .Parameters.AddWithValue("@ttype", "Service")
                            .ExecuteNonQuery()
                        End With
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    Dim total_service_balance As Double
                    Try
                        comm = New MySqlCommand("prcDisplayTotalBalance", conn)
                        With comm
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.AddWithValue("@patient_id", txtPatientID.Text)
                            .Parameters.AddWithValue("@filter", "Service")
                            .ExecuteNonQuery()
                        End With
                        Dim da As New MySqlDataAdapter
                        da.SelectCommand = comm
                        Dim dt As New DataTable
                        dt.Clear()
                        da.Fill(dt)
                        total_service_balance = dt.Rows(0).Item(1).ToString()
                    Catch ex As Exception

                    End Try

                    Try
                        comm = New MySqlCommand("prcUpdateTotalBalancePatient", conn)
                        Dim new_total_balance As Double
                        new_total_balance = total_service_balance + CDbl(txtAddedBalance.Text)
                        MsgBox(new_total_balance)
                        With comm
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.AddWithValue("@patient_id", txtPatientID.Text)
                            .Parameters.AddWithValue("@tamt", new_total_balance)
                            .Parameters.AddWithValue("@ttype", "Service")
                            .ExecuteNonQuery()
                        End With
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            Catch ex As Exception

            End Try

            conn.Close()
            ClearInputs()
        Else
        End If
    End Sub

    Private Function ValidateInputs() As Boolean
        If txtPatientID.Text = String.Empty Or txtServiceID.Text = String.Empty Or txtPaymentDescription.Text = String.Empty Or txtPaymentAmount.Text = String.Empty Then
            MessageBox.Show("Please make sure to fill in the textboxes.")
            Return False
        Else
            If IsNumeric(txtPaymentAmount.Text) = False Then
                MessageBox.Show("Payment Amount Must be numeric.")
                Return False
            End If
            Return True
        End If
    End Function

    Private Sub ClearInputs()
        txtPatientID.Text = String.Empty
        txtServiceID.Text = String.Empty
        txtTotalChange.Text = String.Empty
        txtAddedBalance.Text = String.Empty
        txtPaymentDescription.Text = String.Empty
        txtPaymentAmount.Text = String.Empty
        dtpTransactionDate.Value = Date.Now
        lblPatientName.Text = "[?]"
        lblServiceCost.Text = "[?]"
        lblServiceName.Text = "[?]"
        lblTransactionServiceID.Text = "[?]"
    End Sub

    Private Sub UserControl_transaction_service_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpTransactionDate.Value = Date.Now
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearInputs()
    End Sub
End Class
