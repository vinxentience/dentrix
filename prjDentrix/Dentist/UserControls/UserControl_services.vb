Public Class UserControl_services
    Private Sub addUserControl(userControl As UserControl)
        userControl.Dock = DockStyle.Fill
        pnlService.Controls.Clear()
        pnlService.Controls.Add(userControl)
        userControl.BringToFront()
    End Sub

    Private Sub UserControl_services_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim UC As New UserControl_services_servicelist
        addUserControl(UC)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim UC As New UserControl_services_servicelist
        addUserControl(UC)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim UC As New UserControl_services_addservice
        addUserControl(UC)
    End Sub
End Class
