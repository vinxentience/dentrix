Imports MySql.Data.MySqlClient

Public Class UserControl_transaction_item
    Dim item_cost As Double
    Dim max_numeric As Integer
    Dim maxCol As Integer

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        With frm_browse_patient
            .ShowDialog()
            txtPatientID.Text = .pid
            lblPatientName.Text = .pname
        End With
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try
            With frm_browse_item
                .ShowDialog()
                txtItemID.Text = .iid
                lblItemName.Text = .iname
                item_cost = .icost
                max_numeric = .iqty
            End With

            nmrc_qty.Enabled = True
            nmrc_qty.Maximum = max_numeric
            nmrc_qty.Value = 1
            lblItemCost.Text = nmrc_qty.Value * item_cost
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtItemID_TextChanged(sender As Object, e As EventArgs) Handles txtItemID.TextChanged
        If txtPatientID.Text = String.Empty Or txtItemID.Text = String.Empty Then
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

    Private Sub txtPaymentAmount_TextChanged(sender As Object, e As EventArgs) Handles txtPaymentAmount.TextChanged
        If txtPaymentAmount.Text = "" Then
            Label6.Visible = False
            txtAddedBalance.Visible = False
            Label4.Visible = False
        Else
            Try
                Dim total_item_cost As Double = CDbl(lblItemCost.Text)
                Dim payment As Double = CDbl(txtPaymentAmount.Text)
                Dim total As Double
                txtTotalChange.Visible = False
                If total_item_cost > payment Then
                    Label4.Visible = False
                    txtTotalChange.Visible = False
                    Label6.Visible = True
                    txtAddedBalance.Visible = True

                    total = total_item_cost - payment
                    txtAddedBalance.Text = Format(total, "###,###,###.##")
                ElseIf total_item_cost < payment Then
                    Label4.Visible = True
                    txtTotalChange.Visible = True
                    Label6.Visible = False
                    txtAddedBalance.Visible = False

                    total = payment - total_item_cost
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
        Dim dialogResult As DialogResult = MessageBox.Show("Do you want to add this transaction? Warning: You can not edit this transaction once submitted.", "Item Transation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If dialogResult = DialogResult.Yes And ValidateInputs() Then
            conn.Open()
            Try
                comm = New MySqlCommand("prcAddPaymentItem", conn)
                With comm
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@tiid", lblTransactionItemID.Text)
                    .Parameters.AddWithValue("@amt", txtPaymentAmount.Text)
                    .Parameters.AddWithValue("@pdate", dtpTransactionDate.Value.ToString("yyyy-MM-dd"))
                    .Parameters.AddWithValue("@pdesc", txtPaymentDescription.Text)
                    .Parameters.AddWithValue("@iname", lblItemName.Text)
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
                    .Parameters.AddWithValue("@iid", txtItemID.Text)
                    .Parameters.AddWithValue("@tiid", lblTransactionItemID.Text)
                    .ExecuteNonQuery()
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Try
                Dim total_item_cost As Double = CDbl(lblItemCost.Text)
                Dim payment As Double = CDbl(txtPaymentAmount.Text)
                If total_item_cost > payment Then
                    Try
                        comm = New MySqlCommand("prcAddPatientBalance", conn)
                        With comm
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.AddWithValue("@pid", txtPatientID.Text)
                            .Parameters.AddWithValue("@bamt", txtAddedBalance.Text)
                            .Parameters.AddWithValue("@tdate", dtpTransactionDate.Value.ToString("yyyy-MM-dd"))
                            .Parameters.AddWithValue("@ttype", "Item")
                            .ExecuteNonQuery()
                        End With
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                    Dim total_item_balance As Double
                    Try
                        comm = New MySqlCommand("prcDisplayTotalBalance", conn)
                        With comm
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.AddWithValue("@patient_id", txtPatientID.Text)
                            .Parameters.AddWithValue("@filter", "Item")
                            .ExecuteNonQuery()
                        End With
                        Dim da As New MySqlDataAdapter
                        da.SelectCommand = comm
                        Dim dt As New DataTable
                        dt.Clear()
                        da.Fill(dt)
                        total_item_balance = dt.Rows(0).Item(1).ToString()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                    Try
                        comm = New MySqlCommand("prcUpdateTotalBalancePatient", conn)
                        Dim new_total_balance As Double
                        new_total_balance = total_item_balance + CDbl(txtAddedBalance.Text)
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
                End If
            Catch ex As Exception

            End Try

            Try
                comm = New MySqlCommand("prcUpdateItemQunatity", conn)
                Dim new_quantity As Integer = max_numeric - nmrc_qty.Value
                With comm
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@iid", txtItemID.Text)
                    .Parameters.AddWithValue("@iqty", new_quantity)
                    .ExecuteNonQuery()
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            conn.Close()
            ClearInputs()
        Else
        End If
    End Sub

    Private Function ValidateInputs() As Boolean
        If txtPatientID.Text = String.Empty Or txtItemID.Text = String.Empty Or txtPaymentDescription.Text = String.Empty Or txtPaymentAmount.Text = String.Empty Then
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
        txtItemID.Text = String.Empty
        txtTotalChange.Text = String.Empty
        txtAddedBalance.Text = String.Empty
        txtPaymentDescription.Text = String.Empty
        txtPaymentAmount.Text = String.Empty
        dtpTransactionDate.Value = Date.Now
        nmrc_qty.Value = 1
        nmrc_qty.Enabled = False
        lblPatientName.Text = "[?]"
        lblItemCost.Text = "[?]"
        lblItemName.Text = "[?]"
        lblTransactionItemID.Text = "[?]"
    End Sub

    Private Sub UserControl_transaction_item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpTransactionDate.Value = Date.Now
    End Sub

    Private Sub nmrc_qty_ValueChanged(sender As Object, e As EventArgs) Handles nmrc_qty.ValueChanged
        lblItemCost.Text = nmrc_qty.Value * item_cost
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearInputs()
    End Sub
End Class
