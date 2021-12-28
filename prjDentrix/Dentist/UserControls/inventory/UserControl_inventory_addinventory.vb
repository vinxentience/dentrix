Imports MySql.Data.MySqlClient

Public Class UserControl_inventory_addinventory
    Dim maxCol As Integer
    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UserControl_inventory_addinventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getMaxCol()
    End Sub
    Private Sub getMaxCol()
        conn.Open()
        Try
            comm = New MySqlCommand("prcGetMaxColumnInventory", conn)
            With comm
                .CommandType = CommandType.StoredProcedure
                .ExecuteNonQuery()
            End With

            adapter = New MySqlDataAdapter(comm)
            Dim table As New DataTable()
            adapter.Fill(table)
            maxCol = table.Rows(0).Item(0).ToString()
            lblItemID.Text = maxCol

        Catch ex As Exception
            conn.Close()
        End Try
        conn.Close()
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearInputs()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim dialogResult As DialogResult = MessageBox.Show("Do you want to add this item?", "Inventory", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogResult = DialogResult.Yes And ValidateInputs() Then
            conn.Open()
            Try
                comm = New MySqlCommand("prcAddInventory", conn)
                With comm
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@iid", lblItemID.Text)
                    .Parameters.AddWithValue("@iiname", txtItemName.Text)
                    .Parameters.AddWithValue("@iiqty", txtItemQTY.Text)
                    .Parameters.AddWithValue("@iiunit", txtItemUnit.Text)
                    .Parameters.AddWithValue("@iidesc", txtItemDescription.Text)
                    .Parameters.AddWithValue("@iicost", txtItemCost.Text)
                    .Parameters.AddWithValue("@iibrand", txtItemBrand.Text)
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
        If txtItemCost.Text = String.Empty Or txtItemDescription.Text = String.Empty Or txtItemName.Text = String.Empty Or txtItemQTY.Text = String.Empty Or txtItemUnit.Text = String.Empty Then
            MessageBox.Show("Please fill in the textbox.")
            Return False
        Else
            If IsNumeric(txtItemCost.Text) = False Then
                MessageBox.Show("Item cost must be numberic.")
                Return False
            End If

            If IsNumeric(txtItemQTY.Text) = False Then
                MessageBox.Show("Item quantity must be numberic.")
                Return False
            End If

            Return True
            End If
    End Function

    Private Sub ClearInputs()
        txtItemCost.Text = String.Empty
        txtItemDescription.Text = String.Empty
        txtItemName.Text = String.Empty
        txtItemQTY.Text = String.Empty
        txtItemUnit.Text = String.Empty
        txtItemBrand.Text = String.Empty
    End Sub

    Private Sub txtItemBrand_TextChanged(sender As Object, e As EventArgs) Handles txtItemBrand.TextChanged

    End Sub

    Private Sub txtItemDescription_TextChanged(sender As Object, e As EventArgs) Handles txtItemDescription.TextChanged

    End Sub
End Class
