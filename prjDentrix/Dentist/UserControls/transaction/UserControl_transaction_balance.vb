Imports MySql.Data.MySqlClient

Public Class UserControl_transaction_balance
    Dim maxCol As Integer
    Dim selected_transaction_type As String
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        With frm_browse_patient
            .ShowDialog()
            txtPatientID.Text = .pid
            lblPatientName.Text = .pname
        End With
    End Sub

    Private Sub txtPatientID_TextChanged(sender As Object, e As EventArgs) Handles txtPatientID.TextChanged
        If txtPatientID.Text = String.Empty Then
            cmbViewBy.Enabled = False
        Else
            cmbViewBy.Enabled = True
            displayTotalBalance()
            cmbViewBy.SelectedIndex = 0
            grp_Payment.Visible = False
            grp_description_payment.Visible = False
            btnSubmit.Visible = False
            btnClear.Visible = False
        End If
    End Sub

    Private Sub filteredSearch()
        conn.Open()
        Try
            comm = New MySqlCommand("prcSearchPatientBalance", conn)
            With comm
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@pid", txtPatientID.Text)
                .Parameters.AddWithValue("@search_filter", cmbFilter.Text)
                .Parameters.AddWithValue("@date_from", dtpDateFrom.Value.ToString("yyyy-MM-dd"))
                .Parameters.AddWithValue("@date_to", dtpDateTo.Value.ToString("yyyy-MM-dd"))
                .ExecuteNonQuery()
            End With
            Dim da As New MySqlDataAdapter
            da.SelectCommand = comm
            Dim dt As New DataTable
            dt.Clear()
            da.Fill(dt)
            dgvPatientBalance.DataSource = dt

        Catch ex As Exception

        End Try
        conn.Close()
    End Sub

    Private Sub displayTotalBalance()
        conn.Open()
        Try
            comm = New MySqlCommand("prcDisplayTotalBalance", conn)
            With comm
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@patient_id", txtPatientID.Text)
                .Parameters.AddWithValue("@filter", "All")
                .ExecuteNonQuery()
            End With
            Dim da As New MySqlDataAdapter
            da.SelectCommand = comm
            Dim dt As New DataTable
            dt.Clear()
            da.Fill(dt)
            dgvTotalBalance.DataSource = dt

        Catch ex As Exception

        End Try
        conn.Close()
    End Sub

    Private Sub Guna2ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbViewBy.SelectedValueChanged
        If cmbViewBy.Text = "Balance History" Then
            grpbox_balance_history.Visible = True
            grpbox_totalbalance.Visible = False
            grp_Payment.Visible = False
            grp_description_payment.Visible = False
            btnSubmit.Visible = False
            btnClear.Visible = False
            filteredSearch()
        ElseIf cmbViewBy.Text = "Total Balance Amount" Then
            grpbox_balance_history.Visible = False
            grpbox_totalbalance.Visible = True
            getMaxColItem()
            displayTotalBalance()
        End If
    End Sub

    Private Sub cmbFilter_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedValueChanged
        If cmbFilter.Text = "Between Dates" Then
            dtpDateFrom.Enabled = True
            dtpDateTo.Enabled = True
        Else
            dtpDateFrom.Enabled = False
            dtpDateTo.Enabled = False
        End If
        filteredSearch()
    End Sub

    Private Sub UserControl_transaction_balance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDateFrom.Value = Date.Now
        dtpDateTo.Value = Date.Now
        dtpTransactionDate.Value = Date.Now
    End Sub

    Private Sub dtpDateFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateFrom.ValueChanged
        filteredSearch()
    End Sub

    Private Sub dtpDateTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateTo.ValueChanged
        filteredSearch()
    End Sub

    Private Sub dgvTotalBalance_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTotalBalance.CellClick
        Dim selectedRow As DataGridViewRow
        Dim index As Integer
        Try
            index = e.RowIndex
            selectedRow = dgvTotalBalance.Rows(index)

            If selectedRow.Cells(1).Value.ToString() = "0" Then
                MsgBox("There is no remaining balance on patient's " & selectedRow.Cells(2).Value.ToString & " transaction.")
                grp_Payment.Visible = False
                grp_description_payment.Visible = False
                btnSubmit.Visible = False
                btnClear.Visible = False
            Else
                lblTotalBalance.Text = selectedRow.Cells(1).Value.ToString()
                selected_transaction_type = selectedRow.Cells(2).Value.ToString()

                If selected_transaction_type = "Service" Then
                    getMaxColService()
                    lblTitle.Text = "Transaction ID (Service):"
                Else
                    lblTitle.Text = "Transaction ID (Item):"
                    getMaxColItem()
                End If
                grp_Payment.Visible = True
                grp_description_payment.Visible = True
                btnSubmit.Visible = True
                btnClear.Visible = True
                txtPaymentAmount.Enabled = True
                checkPaymentAmount()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearInputs()
    End Sub

    Private Sub getMaxColItem()
        conn.Open()
        Try
            comm = New MySqlCommand("prcGetMaxColumnItemTransaction", conn)
            With comm
                .CommandType = CommandType.StoredProcedure
                .ExecuteNonQuery()
            End With

            adapter = New MySqlDataAdapter(comm)
            Dim table As New DataTable()
            adapter.Fill(table)
            maxCol = table.Rows(0).Item(0).ToString()
            lblTransactionItemID.Text = maxCol

        Catch ex As Exception
            conn.Close()
        End Try
        conn.Close()
    End Sub

    Private Sub getMaxColService()
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
            lblTransactionItemID.Text = maxCol

        Catch ex As Exception
            conn.Close()
        End Try
        conn.Close()
    End Sub

    Private Sub ClearInputs()
        txtTotalChange.Text = String.Empty
        txtPaymentDescription.Text = String.Empty
        txtPaymentAmount.Text = String.Empty
        dtpTransactionDate.Value = Date.Now
        lblTotalBalance.Text = "[?]"
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim dialogResult As DialogResult = MessageBox.Show("Do you want to add this transaction?", "Item Transation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogResult = DialogResult.Yes And ValidateInputs() Then
            If selected_transaction_type = "Item" Then
                pay_item()
            Else
                pay_service()
            End If
            displayTotalBalance()
            getMaxColItem()
        End If
    End Sub

    Private Sub pay_item()
        conn.Open()
        Try
            comm = New MySqlCommand("prcAddPaymentItem", conn)
            With comm
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@tiid", lblTransactionItemID.Text)
                .Parameters.AddWithValue("@amt", txtPaymentAmount.Text)
                .Parameters.AddWithValue("@pdate", dtpTransactionDate.Value.ToString("yyyy-MM-dd"))
                .Parameters.AddWithValue("@pdesc", txtPaymentDescription.Text)
                .Parameters.AddWithValue("@iname", "Payment for Remaining Balance")
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            comm = New MySqlCommand("prcPatientTransactionItemRelationship", conn)
            With comm
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@did", user_id)
                .Parameters.AddWithValue("@pid", txtPatientID.Text)
                .Parameters.AddWithValue("@iid", 0)
                .Parameters.AddWithValue("@tiid", lblTransactionItemID.Text)
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            comm = New MySqlCommand("prcUpdateTotalBalancePatient", conn)
            Dim new_total_balance As Double
            If CDbl(lblTotalBalance.Text) <= CDbl(txtPaymentAmount.Text) Then
                new_total_balance = 0
            Else
                new_total_balance = Math.Abs(CDbl(lblTotalBalance.Text) - CDbl(txtPaymentAmount.Text))
            End If
            With comm
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@patient_id", txtPatientID.Text)
                .Parameters.AddWithValue("@tamt", new_total_balance)
                .Parameters.AddWithValue("@ttype", "Item")
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ClearInputs()
        conn.Close()
    End Sub

    Private Sub pay_service()
        conn.Open()
        Try
            comm = New MySqlCommand("prcAddPaymentService", conn)
            With comm
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@tsid", lblTransactionItemID.Text)
                .Parameters.AddWithValue("@amt", txtPaymentAmount.Text)
                .Parameters.AddWithValue("@pdate", dtpTransactionDate.Value.ToString("yyyy-MM-dd"))
                .Parameters.AddWithValue("@pdesc", txtPaymentDescription.Text)
                .Parameters.AddWithValue("@srender", "Payment for Remaining Balance")
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
                .Parameters.AddWithValue("@sid", 0)
                .Parameters.AddWithValue("@tsid", lblTransactionItemID.Text)
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            comm = New MySqlCommand("prcUpdateTotalBalancePatient", conn)
            Dim new_total_balance As Double
            If CDbl(lblTotalBalance.Text) <= CDbl(txtPaymentAmount.Text) Then
                new_total_balance = 0
            Else
                new_total_balance = Math.Abs(CDbl(lblTotalBalance.Text) - CDbl(txtPaymentAmount.Text))
            End If
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
        ClearInputs()
        conn.Close()
    End Sub
    Private Function ValidateInputs() As Boolean
        If txtPatientID.Text = String.Empty Or txtPaymentDescription.Text = String.Empty Or txtPaymentAmount.Text = String.Empty Then
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

    Private Sub txtPaymentAmount_TextChanged(sender As Object, e As EventArgs) Handles txtPaymentAmount.TextChanged
        checkPaymentAmount()
    End Sub

    Private Sub checkPaymentAmount()
        If txtPaymentAmount.Text = "" Then
            Label4.Visible = False
        Else
            Try
                Dim total_item_cost As Double = CDbl(lblTotalBalance.Text)
                Dim payment As Double = CDbl(txtPaymentAmount.Text)
                Dim total As Double
                txtTotalChange.Visible = False
                If total_item_cost > payment Then
                    Label8.Visible = False
                    txtTotalChange.Visible = False
                    total = total_item_cost - payment
                ElseIf total_item_cost < payment Then
                    Label8.Visible = True
                    txtTotalChange.Visible = True
                    total = payment - total_item_cost
                    txtTotalChange.Text = Format(total, "###,###,###.##")
                Else
                    Label8.Visible = False
                    txtTotalChange.Visible = False
                End If

            Catch ex As Exception

            End Try
        End If
    End Sub

End Class
