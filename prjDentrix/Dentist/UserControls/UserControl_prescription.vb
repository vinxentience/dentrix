﻿Public Class UserControl_prescription
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim UC As New UserControl_prescription_prescriptionlist
        addUserControl(UC)
    End Sub

    Private Sub addUserControl(userControl As UserControl)
        userControl.Dock = DockStyle.Fill
        pnlPrescription.Controls.Clear()
        pnlPrescription.Controls.Add(userControl)
        userControl.BringToFront()
    End Sub

    Private Sub UserControl_prescription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim UC As New UserControl_prescription_prescriptionlist
        addUserControl(UC)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim UC As New UserControl_prescription_addprescription
        addUserControl(UC)
    End Sub
End Class
