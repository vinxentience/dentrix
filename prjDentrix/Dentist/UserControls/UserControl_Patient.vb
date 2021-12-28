Public Class UserControl_Patient
    Private Sub UserControl_Patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim UC As New UserControl_patient_patientlist
        addUserControl(UC)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim UC As New UserControl_patient_patientlist
        addUserControl(UC)
    End Sub

    Private Sub addUserControl(userControl As UserControl)
        userControl.Dock = DockStyle.Fill
        pnlPatient.Controls.Clear()
        pnlPatient.Controls.Add(userControl)
        userControl.BringToFront()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim UC As New UserControl_patient_addpatient
        addUserControl(UC)
    End Sub
End Class
