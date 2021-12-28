Imports System.IO
Imports MySql.Data.MySqlClient
Module UserModel
    Public user_id As String
    Public u_fname As String
    Public u_lname As String
    Public u_mname As String
    Public u_gender As String
    Public u_contact_number As String
    Public u_email_address As String
    Public u_dob As String
    Public u_address As String
    Public u_role As String
    Public u_display_picture As Byte()
    Public memoryStream As MemoryStream
    Sub Userinfo(uid As Integer, urole As String)
        Try
            comm = New MySqlCommand("prcGetUser", conn)
            With comm
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@uid", uid)
                .Parameters.AddWithValue("@urole", urole)
                .ExecuteNonQuery()
            End With
            adapter = New MySqlDataAdapter(comm)
            Dim table As New DataTable()
            adapter.Fill(table)

            If table.Rows.Count = 0 Then
                MsgBox("User does not exist", MsgBoxStyle.Critical)
            Else
                If urole = "dentist" Then
                    user_id = table.Rows(0).Item(1).ToString
                    u_fname = table.Rows(0).Item(2).ToString
                    u_lname = table.Rows(0).Item(3).ToString
                    u_mname = table.Rows(0).Item(4).ToString
                    u_gender = table.Rows(0).Item(5).ToString
                    u_contact_number = table.Rows(0).Item(6).ToString
                    u_email_address = table.Rows(0).Item(7).ToString
                    u_dob = table.Rows(0).Item(8).ToString
                    u_address = table.Rows(0).Item(9).ToString
                    u_display_picture = table.Rows(0).Item(11)
                    memoryStream = New MemoryStream(u_display_picture)
                    u_role = urole
                End If
            End If
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Public Sub refreshUser(uid As Integer, urole As String)
        conn.Open()
        Userinfo(uid, urole)
        conn.Close()
    End Sub

    Sub LogoutClear()
        user_id = vbEmpty
        u_fname = vbEmpty
        u_lname = vbEmpty
        u_mname = vbEmpty
        u_gender = vbEmpty
        u_contact_number = vbEmpty
        u_email_address = vbEmpty
        u_dob = vbEmpty
        u_address = vbEmpty
        u_role = vbEmpty
    End Sub
End Module

