Imports System.IO
Imports MySql.Data.MySqlClient

Public Class UserControl_dentist_profile
    Dim edit_toggle As Boolean = True
    Private Sub UserControl_dentist_profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshUser(user_id, u_role)
        disableFields()
        txtSurname.Text = u_lname
        txtFname.Text = u_fname
        txtMname.Text = u_mname
        txtContact.Text = u_contact_number
        txtEmail.Text = u_email_address
        txtAddress.Text = u_address
        txtRole.Text = u_role
        txtGender.Text = u_gender
        dtpDOB.Value = u_dob
        display_pic.Image = Image.FromStream(memoryStream)
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        If edit_toggle = True Then
            enableFields()
        Else
            disableFields()
        End If
        refreshUser(user_id, u_role)
        edit_toggle = Not edit_toggle
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim ms As New MemoryStream
        display_pic.Image.Save(ms, Imaging.ImageFormat.Jpeg)
        Dim dialogResult As DialogResult = MessageBox.Show("Do you want to update your profile?", "Profile", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogResult = DialogResult.Yes And ValidateInputs() Then
            conn.Open()
            Try
                comm = New MySqlCommand("prcUpdateDentist", conn)
                With comm
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@ddid", user_id)
                    .Parameters.AddWithValue("@ffname", txtFname.Text)
                    .Parameters.AddWithValue("@llname", txtSurname.Text)
                    .Parameters.AddWithValue("@mmname", txtMname.Text)
                    .Parameters.AddWithValue("@ggender", txtGender.Text)
                    .Parameters.AddWithValue("@contact", txtContact.Text)
                    .Parameters.AddWithValue("@eeaddress", txtEmail.Text)
                    .Parameters.AddWithValue("@ddob", dtpDOB.Value.ToString("yyyy-MM-dd"))
                    .Parameters.AddWithValue("@aaddress", txtAddress.Text)
                    .Parameters.AddWithValue("@display_picture", ms.ToArray())
                    .ExecuteNonQuery()
                End With

            Catch ex As Exception
                conn.Close()
            End Try
            MsgBox("Profile Successfully Updated")
            frmDentistScreen.ProfilePicture.Image = display_pic.Image

            disableFields()
            conn.Close()
        End If
    End Sub
    Private Function ValidateInputs() As Boolean
        If txtSurname.Text = String.Empty Or txtFname.Text = String.Empty Or txtMname.Text = String.Empty Or txtContact.Text = String.Empty Or txtEmail.Text = String.Empty Or txtAddress.Text = String.Empty Or txtGender.Text = String.Empty Then
            MessageBox.Show("Please fill in the textbox.")
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub disableFields()
        txtSurname.Enabled = False
        txtFname.Enabled = False
        txtMname.Enabled = False
        txtContact.Enabled = False
        txtEmail.Enabled = False
        txtAddress.Enabled = False
        txtRole.Enabled = False
        txtGender.Enabled = False
        dtpDOB.Enabled = False
        btnUpdate.Visible = False
        btnSelect.Visible = False
        btnCapture.Visible = False
    End Sub

    Private Sub enableFields()
        txtSurname.Enabled = True
        txtFname.Enabled = True
        txtMname.Enabled = True
        txtContact.Enabled = True
        txtEmail.Enabled = True
        txtAddress.Enabled = True
        txtRole.Enabled = True
        txtGender.Enabled = True
        dtpDOB.Enabled = True
        btnUpdate.Visible = True
        btnSelect.Visible = True
        btnCapture.Visible = True
        display_pic.Image = Image.FromStream(memoryStream)
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Choose Image(*.JPG; *.PNG)|*.jpg;*.png"
        If ofd.ShowDialog = DialogResult.OK Then
            display_pic.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub

    Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click
        With frmCaptureImage
            .Show()
        End With
    End Sub
End Class
