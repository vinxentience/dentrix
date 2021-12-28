Imports FontAwesome.Sharp

Public Class frmDentistScreen
    Private currentBtn As IconButton
    Private leftBorder As Panel
    Private Sub IconButton7_Click(sender As Object, e As EventArgs) Handles IconButton7.Click
        Application.Exit()
    End Sub

    Private Sub ActivateButton(senderBtn As Object, customColor As Color, lblFormTitle As String)
        If senderBtn IsNot Nothing Then
            DisableButton()
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText

            leftBorder.BackColor = customColor
            leftBorder.Location = New Point(0, currentBtn.Location.Y)
            leftBorder.Visible = True
            leftBorder.BringToFront()

            currentIcon.IconChar = currentBtn.IconChar
            currentIcon.IconColor = customColor

            lblTitle.Text = lblFormTitle
            lblTitle.ForeColor = customColor
        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(46, 52, 88)
            currentBtn.IconColor = Color.White
            currentBtn.ForeColor = Color.White
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
        End If
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ActivateButton(sender, Color.FromArgb(248, 233, 161), "Dashboard")
        Dim UC As New UserControl_dashboard
        addUserControl(UC)
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles btnPatient.Click
        ActivateButton(sender, Color.FromArgb(248, 233, 161), "Patient")
        Dim UC As New UserControl_Patient
        addUserControl(UC)
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles btnAppointment.Click
        ActivateButton(sender, Color.FromArgb(248, 233, 161), "Appointment")
        Dim UC As New UserControl_appointment
        addUserControl(UC)
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles btnPrescription.Click
        ActivateButton(sender, Color.FromArgb(248, 233, 161), "Prescription")
        Dim UC As New UserControl_prescription
        addUserControl(UC)
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        ActivateButton(sender, Color.FromArgb(248, 233, 161), "Inventory")
        Dim UC As New UserControl_inventory
        addUserControl(UC)
    End Sub

    Private Sub IconButton6_Click(sender As Object, e As EventArgs)
        ActivateButton(sender, Color.FromArgb(248, 233, 161), "Transaction")
        Dim UC As New UserControl_transaction
        addUserControl(UC)
    End Sub

    Private Sub frmDentistScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        leftBorder = New Panel()
        leftBorder.Size = New Size(7, 55)
        PanelMenu.Controls.Add(leftBorder)
        ProfilePicture.Image = Image.FromStream(memoryStream)
        Dim UC As New UserControl_home
        addUserControl(UC)
    End Sub

    Private Sub Reset()
        DisableButton()
        leftBorder.Visible = False
        currentIcon.IconChar = IconChar.Home
        currentIcon.IconColor = Color.White
        lblTitle.Text = "Home"
    End Sub

    Private Sub addUserControl(userControl As UserControl)
        userControl.Dock = DockStyle.Fill
        UserControlPanel.Controls.Clear()
        UserControlPanel.Controls.Add(userControl)
        userControl.BringToFront()
    End Sub

    Private Sub tmrTimer_Tick(sender As Object, e As EventArgs) Handles tmrTimer.Tick
        lblClock.Text = DateTime.Now.ToString("hh:mm:ss tt").ToUpper
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click
        Dim UC As New UserControl_home
        addUserControl(UC)
        Reset()
    End Sub

    Private Sub ProfilePicture_Click(sender As Object, e As EventArgs) Handles ProfilePicture.Click
        DisableButton()
        lblTitle.Text = "Profile"
        leftBorder.Visible = False
        lblTitle.ForeColor = Color.FromArgb(248, 233, 161)
        Dim UC As New UserControl_dentist_profile
        addUserControl(UC)
    End Sub

    Private Sub IconButton1_Click_1(sender As Object, e As EventArgs) Handles btnServices.Click
        ActivateButton(sender, Color.FromArgb(248, 233, 161), "Services")
        Dim UC As New UserControl_services
        addUserControl(UC)
    End Sub

    Private Sub btnTransaction_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click
        ActivateButton(sender, Color.FromArgb(248, 233, 161), "Services")
        Dim UC As New UserControl_transaction
        addUserControl(UC)
    End Sub

    Private Sub btnLogout_Click_1(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to logout? Please select an option", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            LogoutClear()
            Me.Close()
            frmLogin.Show()
        End If
    End Sub
End Class