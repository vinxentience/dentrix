Public Class UserControl_appointment
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim UC As New UserControl_appointment_appointmentlist
        addUserControl(UC)
    End Sub

    Private Sub addUserControl(userControl As UserControl)
        userControl.Dock = DockStyle.Fill
        pnlAppointment.Controls.Clear()
        pnlAppointment.Controls.Add(userControl)
        userControl.BringToFront()
    End Sub

    Private Sub pnlPatient_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub UserControl_appointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim UC As New UserControl_appointment_appointmentlist
        addUserControl(UC)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim UC As New UserControl_appointment_addappointment
        addUserControl(UC)
    End Sub

End Class
