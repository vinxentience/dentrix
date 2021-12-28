<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_appointment_addappointment
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.lblPatientName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPatientID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtTime = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblAppointmentID = New System.Windows.Forms.Label()
        Me.dtpAppointmentDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.btnClear = New FontAwesome.Sharp.IconButton()
        Me.btnSubmit = New FontAwesome.Sharp.IconButton()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 21)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Appointment ID:"
        '
        'txtDescription
        '
        Me.txtDescription.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.txtDescription.BorderRadius = 10
        Me.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescription.DefaultText = ""
        Me.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescription.DisabledState.Parent = Me.txtDescription
        Me.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescription.Enabled = False
        Me.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescription.FocusedState.Parent = Me.txtDescription
        Me.txtDescription.ForeColor = System.Drawing.Color.Black
        Me.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescription.HoverState.Parent = Me.txtDescription
        Me.txtDescription.Location = New System.Drawing.Point(16, 177)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescription.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtDescription.PlaceholderText = "Description"
        Me.txtDescription.SelectedText = ""
        Me.txtDescription.ShadowDecoration.Parent = Me.txtDescription
        Me.txtDescription.Size = New System.Drawing.Size(864, 48)
        Me.txtDescription.TabIndex = 0
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Button2)
        Me.Guna2GroupBox1.Controls.Add(Me.lblPatientName)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.txtPatientID)
        Me.Guna2GroupBox1.Controls.Add(Me.txtTime)
        Me.Guna2GroupBox1.Controls.Add(Me.lblAppointmentID)
        Me.Guna2GroupBox1.Controls.Add(Me.dtpAppointmentDate)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.txtDescription)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(6, 77)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(900, 293)
        Me.Guna2GroupBox1.TabIndex = 13
        Me.Guna2GroupBox1.Text = "Add Appointment"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BorderRadius = 20
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Location = New System.Drawing.Point(336, 124)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(101, 38)
        Me.Guna2Button2.TabIndex = 31
        Me.Guna2Button2.Text = "Browse"
        '
        'lblPatientName
        '
        Me.lblPatientName.AutoSize = True
        Me.lblPatientName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientName.ForeColor = System.Drawing.Color.Black
        Me.lblPatientName.Location = New System.Drawing.Point(573, 133)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(31, 21)
        Me.lblPatientName.TabIndex = 24
        Me.lblPatientName.Text = "[?]"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(450, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 21)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Patient Name:"
        '
        'txtPatientID
        '
        Me.txtPatientID.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.txtPatientID.BorderRadius = 10
        Me.txtPatientID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPatientID.DefaultText = ""
        Me.txtPatientID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPatientID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPatientID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPatientID.DisabledState.Parent = Me.txtPatientID
        Me.txtPatientID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPatientID.Enabled = False
        Me.txtPatientID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPatientID.FocusedState.Parent = Me.txtPatientID
        Me.txtPatientID.ForeColor = System.Drawing.Color.Black
        Me.txtPatientID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPatientID.HoverState.Parent = Me.txtPatientID
        Me.txtPatientID.Location = New System.Drawing.Point(16, 116)
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPatientID.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtPatientID.PlaceholderText = "Patient ID"
        Me.txtPatientID.SelectedText = ""
        Me.txtPatientID.ShadowDecoration.Parent = Me.txtPatientID
        Me.txtPatientID.Size = New System.Drawing.Size(304, 55)
        Me.txtPatientID.TabIndex = 22
        '
        'txtTime
        '
        Me.txtTime.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.txtTime.BorderRadius = 10
        Me.txtTime.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTime.DefaultText = ""
        Me.txtTime.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTime.DisabledState.Parent = Me.txtTime
        Me.txtTime.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTime.Enabled = False
        Me.txtTime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTime.FocusedState.Parent = Me.txtTime
        Me.txtTime.ForeColor = System.Drawing.Color.Black
        Me.txtTime.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTime.HoverState.Parent = Me.txtTime
        Me.txtTime.Location = New System.Drawing.Point(16, 231)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTime.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtTime.PlaceholderText = "Appointment Time (hh:mm:ss)"
        Me.txtTime.SelectedText = ""
        Me.txtTime.ShadowDecoration.Parent = Me.txtTime
        Me.txtTime.Size = New System.Drawing.Size(481, 48)
        Me.txtTime.TabIndex = 21
        '
        'lblAppointmentID
        '
        Me.lblAppointmentID.AutoSize = True
        Me.lblAppointmentID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppointmentID.ForeColor = System.Drawing.Color.Black
        Me.lblAppointmentID.Location = New System.Drawing.Point(156, 68)
        Me.lblAppointmentID.Name = "lblAppointmentID"
        Me.lblAppointmentID.Size = New System.Drawing.Size(31, 21)
        Me.lblAppointmentID.TabIndex = 20
        Me.lblAppointmentID.Text = "[?]"
        '
        'dtpAppointmentDate
        '
        Me.dtpAppointmentDate.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.dtpAppointmentDate.BorderRadius = 10
        Me.dtpAppointmentDate.BorderThickness = 1
        Me.dtpAppointmentDate.CheckedState.Parent = Me.dtpAppointmentDate
        Me.dtpAppointmentDate.Enabled = False
        Me.dtpAppointmentDate.FillColor = System.Drawing.Color.White
        Me.dtpAppointmentDate.ForeColor = System.Drawing.Color.Black
        Me.dtpAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpAppointmentDate.HoverState.Parent = Me.dtpAppointmentDate
        Me.dtpAppointmentDate.Location = New System.Drawing.Point(503, 231)
        Me.dtpAppointmentDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpAppointmentDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpAppointmentDate.Name = "dtpAppointmentDate"
        Me.dtpAppointmentDate.ShadowDecoration.Parent = Me.dtpAppointmentDate
        Me.dtpAppointmentDate.Size = New System.Drawing.Size(377, 48)
        Me.dtpAppointmentDate.TabIndex = 14
        Me.dtpAppointmentDate.Value = New Date(2021, 11, 12, 20, 56, 14, 454)
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.SeaGreen
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnClear.IconColor = System.Drawing.Color.Black
        Me.btnClear.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClear.Location = New System.Drawing.Point(468, 396)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(134, 41)
        Me.btnClear.TabIndex = 19
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.SeaGreen
        Me.btnSubmit.FlatAppearance.BorderSize = 0
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnSubmit.IconColor = System.Drawing.Color.Black
        Me.btnSubmit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSubmit.Location = New System.Drawing.Point(298, 396)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(134, 41)
        Me.btnSubmit.TabIndex = 18
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'UserControl_appointment_addappointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Name = "UserControl_appointment_addappointment"
        Me.Size = New System.Drawing.Size(909, 578)
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtDescription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents dtpAppointmentDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnClear As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSubmit As FontAwesome.Sharp.IconButton
    Friend WithEvents lblAppointmentID As Label
    Friend WithEvents txtTime As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPatientID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblPatientName As Label
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
End Class
