Public Class UserControl_transaction
    Private Sub addUserControl(userControl As UserControl)
        userControl.Dock = DockStyle.Fill
        pnlPrescription.Controls.Clear()
        pnlPrescription.Controls.Add(userControl)
        userControl.BringToFront()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim UC As New UserControl_transaction_transactionlist
        addUserControl(UC)
    End Sub

    Private Sub UserControl_transaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim UC As New UserControl_transaction_transactionlist
        addUserControl(UC)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim UC As New UserControl_transaction_service
        addUserControl(UC)
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim UC As New UserControl_transaction_item
        addUserControl(UC)
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Dim UC As New UserControl_transaction_balance
        addUserControl(UC)
    End Sub
End Class
