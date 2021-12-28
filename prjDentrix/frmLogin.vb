Imports MySql.Data.MySqlClient
Public Class frmLogin
    Dim password_toggle As Boolean = True
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click


        Try
            conn.Open()
            comm = New MySqlCommand("prcAuthenticateUser", conn)
            With comm
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@uid", txtUsername.Text)
                .Parameters.AddWithValue("@pass", txtPassword.Text)
                .ExecuteNonQuery()
            End With
            adapter = New MySqlDataAdapter(comm)
            Dim table As New DataTable()
            adapter.Fill(table)

            If table.Rows.Count = 0 Then
                MsgBox("Access Denied. Wrong username or password", MsgBoxStyle.Critical)
            Else
                If table.Rows(0).Item(1).ToString() = "dentist" Then
                    MsgBox("Access Granted! Welcome dentist", MsgBoxStyle.Information)
                    Userinfo(txtUsername.Text, table.Rows(0).Item(1).ToString())
                    frmDentistScreen.Show()
                Else
                    MsgBox("Access Granted! Welcome admin", MsgBoxStyle.Information)
                    Userinfo(txtUsername.Text, table.Rows(0).Item(1).ToString())
                    frmAdminScreen.Show()
                End If
                Me.Hide()
            End If
            txtUsername.Text = ""
            txtPassword.Text = ""
            conn.Close()
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
    End Sub

    Private Sub txtPassword_IconRightClick(sender As Object, e As EventArgs) Handles txtPassword.IconRightClick
        If password_toggle = True Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
        password_toggle = Not password_toggle
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Hide()
        frmRegisterDentist.Show()
    End Sub
End Class