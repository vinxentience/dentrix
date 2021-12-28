Imports MySql.Data.MySqlClient

Public Class frm_admin_edituser
    Public urole As String
    Public olduid As Integer
    Dim isToggle As Boolean = True
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim dialogResult As DialogResult = MessageBox.Show("Do you want to edit this account?", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogResult = DialogResult.Yes And ValidateInputs() Then
            conn.Open()
            Try
                comm = New MySqlCommand("prcUpdateAccount", conn)
                With comm
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@old_uid", olduid)
                    .Parameters.AddWithValue("@new_uid", txtUserID.Text)
                    .Parameters.AddWithValue("@upass", txtPassword.Text)
                    .Parameters.AddWithValue("@urole", urole)
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
        If txtUserID.Text = String.Empty Or txtPassword.Text = String.Empty Or txtConfirmPassword.Text = String.Empty Then
            MessageBox.Show("Please fill in the textbox.")
            Return False
        Else
            If txtPassword.Text <> txtConfirmPassword.Text Then
                MessageBox.Show("Password does not match.")
                Return False
            ElseIf txtPassword.Text.Length < 8 Then
                MessageBox.Show("Password must at least 8 characters.")
                Return False
            End If
            Return True
        End If
    End Function

    Private Sub frm_admin_edituser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUserID.Text = olduid
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If isToggle Then
            txtUserID.Enabled = True
            btnEdit.Text = "Cancel"
        Else
            txtUserID.Enabled = False
            btnEdit.Text = "Edit"
            txtUserID.Text = olduid
        End If
        isToggle = Not isToggle
    End Sub

    Private Sub frm_admin_edituser_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class