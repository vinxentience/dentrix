Imports System.IO
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class frmRegisterDentist
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim ms As New MemoryStream
        ProfileContainer.Image.Save(ms, ProfileContainer.Image.RawFormat)

        Dim dialogResult As DialogResult = MessageBox.Show("Do you want to register this account?", "Register", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogResult = DialogResult.Yes And ValidateInputs() Then
            conn.Open()
            Try
                comm = New MySqlCommand("prcCreateAccount", conn)
                With comm
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@uid", txtUserID.Text)
                    .Parameters.AddWithValue("@pass", txtPassword.Text)
                    .Parameters.AddWithValue("@urole", "dentist")
                    .ExecuteNonQuery()
                End With
            Catch ex As Exception
                conn.Close()
            End Try

            Try
                comm = New MySqlCommand("prcUpdateDentist", conn)
                With comm
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@ddid", txtUserID.Text)
                    .Parameters.AddWithValue("@ffname", txtFirstName.Text)
                    .Parameters.AddWithValue("@llname", txtLastName.Text)
                    .Parameters.AddWithValue("@mmname", txtMiddleName.Text)
                    .Parameters.AddWithValue("@ggender", cmbGender.Text)
                    .Parameters.AddWithValue("@contact", txtContactNum.Text)
                    .Parameters.AddWithValue("@eeaddress", txtEmailAdd.Text)
                    .Parameters.AddWithValue("@ddob", dtpBirthDate.Value.ToString("yyyy-MM-dd"))
                    .Parameters.AddWithValue("@aaddress", txtAddress.Text)
                    .Parameters.AddWithValue("@display_picture", ms.ToArray())
                    .ExecuteNonQuery()
                End With
                Me.Dispose()
                frmLogin.Show()
            Catch ex As Exception
                conn.Close()
            End Try
            conn.Close()
        Else
        End If
    End Sub

    Private Function ValidateInputs() As Boolean
        If txtAddress.Text = String.Empty Or txtContactNum.Text = String.Empty Or txtEmailAdd.Text = String.Empty Or txtFirstName.Text = String.Empty Or txtLastName.Text = String.Empty Or txtMiddleName.Text = String.Empty Or txtPassword.Text = String.Empty Or txtUserID.Text = String.Empty Or cmbGender.Text = String.Empty Then
            MessageBox.Show("Please fill in the textbox.")
            Return False
        Else
            If txtPassword.Text.Length < 8 Then
                MessageBox.Show("Password must be 8 or more characters.")
                Return False
            End If

            If IsNumeric(txtContactNum.Text) = False Then
                MessageBox.Show("Contact Number must be numberic.")
                Return False
            End If

            If txtPassword.Text <> txtConfirm.Text Then
                MessageBox.Show("Password doesn't match.")
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
        txtPassword.Text = String.Empty
        txtUserID.Text = String.Empty
        txtConfirm.Text = String.Empty
        cmbGender.SelectedIndex = -1
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearInputs()
    End Sub

    Private Sub frmRegisterDentist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpBirthDate.MaxDate = DateTime.Today
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        frmLogin.Show()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Choose Image(*.JPG; *.PNG)|*.jpg;*.png"
        If ofd.ShowDialog = DialogResult.OK Then
            ProfileContainer.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        With frmCaptureImage
            .Show()
        End With
    End Sub

    Private Sub txtUserID_TextChanged(sender As Object, e As EventArgs) Handles txtUserID.TextChanged
        conn.Open()
        Try
            comm = New MySqlCommand("prcCheckAccountExist", conn)
            With comm
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@uid", txtUserID.Text)
                .ExecuteNonQuery()
            End With
            adapter = New MySqlDataAdapter(comm)
            Dim table As New DataTable()
            adapter.Fill(table)
            If CInt(table.Rows(0).Item(0).ToString()) > 0 Then
                Label1.Text = "Account Already Exist"
                Label1.Visible = True
            Else
                Label1.Text = ""
                Label1.Visible = False
            End If
        Catch ex As Exception
            conn.Close()
        End Try
        conn.Close()
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If txtPassword.Text = "" Then
            Label2.Text = ""
            Label2.Visible = False
        ElseIf txtPassword.Text.Length < 8 Then
            Label2.Text = "Password must be 8 or more characters."
            Label2.Visible = True
        Else
            Label2.Text = ""
            Label2.Visible = False
        End If
    End Sub

    Private Sub txtConfirm_TextChanged(sender As Object, e As EventArgs) Handles txtConfirm.TextChanged
        If txtPassword.Text = "" Then
            Label3.Text = ""
            Label3.Visible = False
        ElseIf txtPassword.Text <> txtConfirm.Text Then
            Label3.Text = "Password doesn't match."
            Label3.Visible = True
        Else
            Label3.Text = ""
            Label3.Visible = False
        End If
    End Sub

    Private Sub frmRegisterDentist_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmLogin.Show()
    End Sub
End Class