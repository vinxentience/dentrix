Public Class UserControl_admin_manage_users
    Private Sub addUserControl(userControl As UserControl)
        userControl.Dock = DockStyle.Fill
        pnlPatient.Controls.Clear()
        pnlPatient.Controls.Add(userControl)
        userControl.BringToFront()
    End Sub

    Private Sub UserControl_admin_manage_users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim UC As New UserControl_manageuser_list
        addUserControl(UC)
    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim UC As New UserControl_manageuser_list
        addUserControl(UC)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim UC As New UserControl_admin_addadmin
        addUserControl(UC)
    End Sub


End Class
