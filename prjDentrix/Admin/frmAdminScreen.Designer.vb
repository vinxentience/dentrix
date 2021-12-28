<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdminScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminScreen))
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblClock = New System.Windows.Forms.Label()
        Me.ProfilePicture = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.currentIcon = New FontAwesome.Sharp.IconPictureBox()
        Me.IconButton7 = New FontAwesome.Sharp.IconButton()
        Me.btnLogout = New FontAwesome.Sharp.IconButton()
        Me.btnBackup = New FontAwesome.Sharp.IconButton()
        Me.btnManageUsers = New FontAwesome.Sharp.IconButton()
        Me.btnDashboard = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.PanelMenu = New Guna.UI2.WinForms.Guna2Panel()
        Me.tmrTimer = New System.Windows.Forms.Timer(Me.components)
        Me.UserControlPanel = New System.Windows.Forms.Panel()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.ProfilePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.currentIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.lblClock)
        Me.Guna2Panel2.Controls.Add(Me.ProfilePicture)
        Me.Guna2Panel2.Controls.Add(Me.lblTitle)
        Me.Guna2Panel2.Controls.Add(Me.currentIcon)
        Me.Guna2Panel2.Controls.Add(Me.IconButton7)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Guna2Panel2.Location = New System.Drawing.Point(221, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(893, 48)
        Me.Guna2Panel2.TabIndex = 6
        '
        'lblClock
        '
        Me.lblClock.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClock.AutoSize = True
        Me.lblClock.BackColor = System.Drawing.Color.Transparent
        Me.lblClock.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClock.ForeColor = System.Drawing.Color.White
        Me.lblClock.Location = New System.Drawing.Point(698, 13)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(72, 21)
        Me.lblClock.TabIndex = 7
        Me.lblClock.Text = "00:00:00"
        '
        'ProfilePicture
        '
        Me.ProfilePicture.BackColor = System.Drawing.Color.Transparent
        Me.ProfilePicture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ProfilePicture.Image = CType(resources.GetObject("ProfilePicture.Image"), System.Drawing.Image)
        Me.ProfilePicture.Location = New System.Drawing.Point(812, 4)
        Me.ProfilePicture.Name = "ProfilePicture"
        Me.ProfilePicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.ProfilePicture.ShadowDecoration.Parent = Me.ProfilePicture
        Me.ProfilePicture.Size = New System.Drawing.Size(40, 39)
        Me.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProfilePicture.TabIndex = 0
        Me.ProfilePicture.TabStop = False
        Me.ProfilePicture.UseTransparentBackground = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(52, 18)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(40, 16)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Home"
        '
        'currentIcon
        '
        Me.currentIcon.BackColor = System.Drawing.Color.Transparent
        Me.currentIcon.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.currentIcon.IconColor = System.Drawing.Color.White
        Me.currentIcon.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.currentIcon.Location = New System.Drawing.Point(14, 10)
        Me.currentIcon.Name = "currentIcon"
        Me.currentIcon.Size = New System.Drawing.Size(32, 32)
        Me.currentIcon.TabIndex = 4
        Me.currentIcon.TabStop = False
        '
        'IconButton7
        '
        Me.IconButton7.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.IconButton7.Dock = System.Windows.Forms.DockStyle.Right
        Me.IconButton7.FlatAppearance.BorderSize = 0
        Me.IconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton7.ForeColor = System.Drawing.Color.White
        Me.IconButton7.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.IconButton7.IconColor = System.Drawing.Color.White
        Me.IconButton7.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton7.IconSize = 30
        Me.IconButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton7.Location = New System.Drawing.Point(857, 0)
        Me.IconButton7.Name = "IconButton7"
        Me.IconButton7.Size = New System.Drawing.Size(36, 48)
        Me.IconButton7.TabIndex = 5
        Me.IconButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton7.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.btnLogout.IconColor = System.Drawing.Color.White
        Me.btnLogout.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLogout.IconSize = 30
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogout.Location = New System.Drawing.Point(0, 341)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnLogout.Size = New System.Drawing.Size(221, 55)
        Me.btnLogout.TabIndex = 9
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnBackup
        '
        Me.btnBackup.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnBackup.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBackup.FlatAppearance.BorderSize = 0
        Me.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackup.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackup.ForeColor = System.Drawing.Color.White
        Me.btnBackup.IconChar = FontAwesome.Sharp.IconChar.Database
        Me.btnBackup.IconColor = System.Drawing.Color.White
        Me.btnBackup.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnBackup.IconSize = 30
        Me.btnBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBackup.Location = New System.Drawing.Point(0, 286)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnBackup.Size = New System.Drawing.Size(221, 55)
        Me.btnBackup.TabIndex = 5
        Me.btnBackup.Text = "Backup / Restore"
        Me.btnBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnBackup.UseVisualStyleBackColor = False
        '
        'btnManageUsers
        '
        Me.btnManageUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnManageUsers.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnManageUsers.FlatAppearance.BorderSize = 0
        Me.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageUsers.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageUsers.ForeColor = System.Drawing.Color.White
        Me.btnManageUsers.IconChar = FontAwesome.Sharp.IconChar.UserCircle
        Me.btnManageUsers.IconColor = System.Drawing.Color.White
        Me.btnManageUsers.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnManageUsers.IconSize = 30
        Me.btnManageUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnManageUsers.Location = New System.Drawing.Point(0, 231)
        Me.btnManageUsers.Name = "btnManageUsers"
        Me.btnManageUsers.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnManageUsers.Size = New System.Drawing.Size(221, 55)
        Me.btnManageUsers.TabIndex = 4
        Me.btnManageUsers.Text = "Manage Users"
        Me.btnManageUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnManageUsers.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.TachometerAlt
        Me.btnDashboard.IconColor = System.Drawing.Color.White
        Me.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDashboard.IconSize = 30
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDashboard.Location = New System.Drawing.Point(0, 176)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(221, 55)
        Me.btnDashboard.TabIndex = 3
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(221, 176)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(58, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "D E N T R I X"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(29, 18)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(145, 136)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'PanelMenu
        '
        Me.PanelMenu.Controls.Add(Me.btnLogout)
        Me.PanelMenu.Controls.Add(Me.btnBackup)
        Me.PanelMenu.Controls.Add(Me.btnManageUsers)
        Me.PanelMenu.Controls.Add(Me.btnDashboard)
        Me.PanelMenu.Controls.Add(Me.Panel1)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.ShadowDecoration.Parent = Me.PanelMenu
        Me.PanelMenu.Size = New System.Drawing.Size(221, 634)
        Me.PanelMenu.TabIndex = 5
        '
        'tmrTimer
        '
        Me.tmrTimer.Enabled = True
        Me.tmrTimer.Interval = 1000
        '
        'UserControlPanel
        '
        Me.UserControlPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UserControlPanel.Location = New System.Drawing.Point(221, 48)
        Me.UserControlPanel.Name = "UserControlPanel"
        Me.UserControlPanel.Size = New System.Drawing.Size(893, 586)
        Me.UserControlPanel.TabIndex = 8
        '
        'frmAdminScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1114, 634)
        Me.Controls.Add(Me.UserControlPanel)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAdminScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAdminScreen"
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.ProfilePicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.currentIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblClock As Label
    Friend WithEvents ProfilePicture As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents currentIcon As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconButton7 As FontAwesome.Sharp.IconButton
    Friend WithEvents btnLogout As FontAwesome.Sharp.IconButton
    Friend WithEvents btnBackup As FontAwesome.Sharp.IconButton
    Friend WithEvents btnManageUsers As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents PanelMenu As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents tmrTimer As Timer
    Friend WithEvents UserControlPanel As Panel
End Class
