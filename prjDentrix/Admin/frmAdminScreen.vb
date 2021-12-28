Imports FontAwesome.Sharp
Public Class frmAdminScreen
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
        Dim UC As New UserControl_admin_dashboard
        addUserControl(UC)
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles btnManageUsers.Click
        ActivateButton(sender, Color.FromArgb(248, 233, 161), "Manage Users")
        Dim UC As New UserControl_admin_manage_users
        addUserControl(UC)
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        ActivateButton(sender, Color.FromArgb(248, 233, 161), "Backup / Restore")
        Dim UC As New UserControl_backup
        addUserControl(UC)
    End Sub

    Private Sub frmDentistScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        leftBorder = New Panel()
        leftBorder.Size = New Size(7, 55)
        PanelMenu.Controls.Add(leftBorder)
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

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to logout? Please select an option", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            LogoutClear()
            Me.Close()
            frmLogin.Show()
        End If
    End Sub

    Private Sub ProfilePicture_Click(sender As Object, e As EventArgs) Handles ProfilePicture.Click
        'Dim UC As New UserControl_dentist_profile
        'addUserControl(UC)
    End Sub

End Class