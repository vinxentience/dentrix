Public Class UserControl_inventory
    Private Sub addUserControl(userControl As UserControl)
        userControl.Dock = DockStyle.Fill
        pnlInventory.Controls.Clear()
        pnlInventory.Controls.Add(userControl)
        userControl.BringToFront()
    End Sub


    Private Sub UserControl_inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim UC As New UserControl_inventory_inventorylist
        addUserControl(UC)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim UC As New UserControl_inventory_inventorylist
        addUserControl(UC)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim UC As New UserControl_inventory_addinventory
        addUserControl(UC)
    End Sub
End Class
