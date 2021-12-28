Imports MySql.Data.MySqlClient

Public Class frm_edit_inventory
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim dialogResult As DialogResult = MessageBox.Show("Do you want to edit this appointment?", "Appointment", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogResult = DialogResult.Yes And ValidateInputs() Then
            conn.Open()
            Try
                comm = New MySqlCommand("prcUpdateItem", conn)
                With comm
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@iid", lblItemID.Text)
                    .Parameters.AddWithValue("@iname", txtItemName.Text)
                    .Parameters.AddWithValue("@iqty", txtItemQTY.Text)
                    .Parameters.AddWithValue("@idesc", txtItemDescription.Text)
                    .Parameters.AddWithValue("@icost", txtItemCost.Text)
                    .Parameters.AddWithValue("@iunit", txtItemUnit.Text)
                    .Parameters.AddWithValue("@ibrand", txtItemBrand.Text)
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
        If txtItemName.Text = String.Empty Or txtItemQTY.Text = String.Empty Or txtItemDescription.Text = String.Empty Or txtItemCost.Text = String.Empty Then
            MessageBox.Show("Please fill in the textbox.")
            Return False
        Else
            Return True
        End If
    End Function
End Class