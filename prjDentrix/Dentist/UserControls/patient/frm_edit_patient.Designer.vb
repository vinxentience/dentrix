<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_edit_patient
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.btnSubmit = New FontAwesome.Sharp.IconButton()
        Me.txtContactNum = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtEmailAdd = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.txtAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dtpBirthDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.cmbGender = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.txtLname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtMname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPatientId = New System.Windows.Forms.Label()
        Me.txtFname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btnSubmit.Location = New System.Drawing.Point(310, 490)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(134, 41)
        Me.btnSubmit.TabIndex = 9
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'txtContactNum
        '
        Me.txtContactNum.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.txtContactNum.BorderRadius = 10
        Me.txtContactNum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContactNum.DefaultText = ""
        Me.txtContactNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtContactNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtContactNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContactNum.DisabledState.Parent = Me.txtContactNum
        Me.txtContactNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContactNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContactNum.FocusedState.Parent = Me.txtContactNum
        Me.txtContactNum.ForeColor = System.Drawing.Color.Black
        Me.txtContactNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContactNum.HoverState.Parent = Me.txtContactNum
        Me.txtContactNum.Location = New System.Drawing.Point(15, 131)
        Me.txtContactNum.Name = "txtContactNum"
        Me.txtContactNum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContactNum.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtContactNum.PlaceholderText = "Contact Number"
        Me.txtContactNum.SelectedText = ""
        Me.txtContactNum.ShadowDecoration.Parent = Me.txtContactNum
        Me.txtContactNum.Size = New System.Drawing.Size(361, 42)
        Me.txtContactNum.TabIndex = 8
        '
        'txtEmailAdd
        '
        Me.txtEmailAdd.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.txtEmailAdd.BorderRadius = 10
        Me.txtEmailAdd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmailAdd.DefaultText = ""
        Me.txtEmailAdd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmailAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmailAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmailAdd.DisabledState.Parent = Me.txtEmailAdd
        Me.txtEmailAdd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmailAdd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmailAdd.FocusedState.Parent = Me.txtEmailAdd
        Me.txtEmailAdd.ForeColor = System.Drawing.Color.Black
        Me.txtEmailAdd.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmailAdd.HoverState.Parent = Me.txtEmailAdd
        Me.txtEmailAdd.Location = New System.Drawing.Point(15, 73)
        Me.txtEmailAdd.Name = "txtEmailAdd"
        Me.txtEmailAdd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmailAdd.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtEmailAdd.PlaceholderText = "Email Address"
        Me.txtEmailAdd.SelectedText = ""
        Me.txtEmailAdd.ShadowDecoration.Parent = Me.txtEmailAdd
        Me.txtEmailAdd.Size = New System.Drawing.Size(361, 36)
        Me.txtEmailAdd.TabIndex = 7
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.Controls.Add(Me.txtContactNum)
        Me.Guna2GroupBox2.Controls.Add(Me.txtEmailAdd)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(188, 279)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.Parent = Me.Guna2GroupBox2
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(391, 184)
        Me.Guna2GroupBox2.TabIndex = 19
        Me.Guna2GroupBox2.Text = "Contact Information"
        '
        'txtAddress
        '
        Me.txtAddress.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.txtAddress.BorderRadius = 10
        Me.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddress.DefaultText = ""
        Me.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAddress.DisabledState.Parent = Me.txtAddress
        Me.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAddress.FocusedState.Parent = Me.txtAddress
        Me.txtAddress.ForeColor = System.Drawing.Color.Black
        Me.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAddress.HoverState.Parent = Me.txtAddress
        Me.txtAddress.Location = New System.Drawing.Point(395, 171)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtAddress.PlaceholderText = "Complete Address"
        Me.txtAddress.SelectedText = ""
        Me.txtAddress.ShadowDecoration.Parent = Me.txtAddress
        Me.txtAddress.Size = New System.Drawing.Size(459, 42)
        Me.txtAddress.TabIndex = 6
        '
        'dtpBirthDate
        '
        Me.dtpBirthDate.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.dtpBirthDate.BorderRadius = 10
        Me.dtpBirthDate.BorderThickness = 1
        Me.dtpBirthDate.CheckedState.Parent = Me.dtpBirthDate
        Me.dtpBirthDate.FillColor = System.Drawing.Color.White
        Me.dtpBirthDate.ForeColor = System.Drawing.Color.Black
        Me.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpBirthDate.HoverState.Parent = Me.dtpBirthDate
        Me.dtpBirthDate.Location = New System.Drawing.Point(170, 171)
        Me.dtpBirthDate.MaxDate = New Date(2021, 11, 8, 0, 0, 0, 0)
        Me.dtpBirthDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpBirthDate.Name = "dtpBirthDate"
        Me.dtpBirthDate.ShadowDecoration.Parent = Me.dtpBirthDate
        Me.dtpBirthDate.Size = New System.Drawing.Size(220, 42)
        Me.dtpBirthDate.TabIndex = 5
        Me.dtpBirthDate.Value = New Date(2021, 11, 8, 0, 0, 0, 0)
        '
        'cmbGender
        '
        Me.cmbGender.BackColor = System.Drawing.Color.Transparent
        Me.cmbGender.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.cmbGender.BorderRadius = 10
        Me.cmbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGender.FocusedColor = System.Drawing.Color.Empty
        Me.cmbGender.FocusedState.Parent = Me.cmbGender
        Me.cmbGender.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbGender.ForeColor = System.Drawing.Color.Black
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.HoverState.Parent = Me.cmbGender
        Me.cmbGender.ItemHeight = 30
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.ItemsAppearance.Parent = Me.cmbGender
        Me.cmbGender.Location = New System.Drawing.Point(14, 177)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.ShadowDecoration.Parent = Me.cmbGender
        Me.cmbGender.Size = New System.Drawing.Size(150, 36)
        Me.cmbGender.TabIndex = 4
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.txtLname)
        Me.Guna2GroupBox1.Controls.Add(Me.txtMname)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.lblPatientId)
        Me.Guna2GroupBox1.Controls.Add(Me.txtAddress)
        Me.Guna2GroupBox1.Controls.Add(Me.dtpBirthDate)
        Me.Guna2GroupBox1.Controls.Add(Me.cmbGender)
        Me.Guna2GroupBox1.Controls.Add(Me.txtFname)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(7, 16)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(869, 245)
        Me.Guna2GroupBox1.TabIndex = 18
        Me.Guna2GroupBox1.Text = "Personal Information"
        '
        'txtLname
        '
        Me.txtLname.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.txtLname.BorderRadius = 10
        Me.txtLname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLname.DefaultText = ""
        Me.txtLname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLname.DisabledState.Parent = Me.txtLname
        Me.txtLname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLname.FocusedState.Parent = Me.txtLname
        Me.txtLname.ForeColor = System.Drawing.Color.Black
        Me.txtLname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLname.HoverState.Parent = Me.txtLname
        Me.txtLname.Location = New System.Drawing.Point(578, 107)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLname.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtLname.PlaceholderText = "Last Name"
        Me.txtLname.SelectedText = ""
        Me.txtLname.ShadowDecoration.Parent = Me.txtLname
        Me.txtLname.Size = New System.Drawing.Size(276, 48)
        Me.txtLname.TabIndex = 3
        '
        'txtMname
        '
        Me.txtMname.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.txtMname.BorderRadius = 10
        Me.txtMname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMname.DefaultText = ""
        Me.txtMname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMname.DisabledState.Parent = Me.txtMname
        Me.txtMname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMname.FocusedState.Parent = Me.txtMname
        Me.txtMname.ForeColor = System.Drawing.Color.Black
        Me.txtMname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMname.HoverState.Parent = Me.txtMname
        Me.txtMname.Location = New System.Drawing.Point(296, 107)
        Me.txtMname.Name = "txtMname"
        Me.txtMname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMname.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtMname.PlaceholderText = "Middle Name"
        Me.txtMname.SelectedText = ""
        Me.txtMname.ShadowDecoration.Parent = Me.txtMname
        Me.txtMname.Size = New System.Drawing.Size(276, 48)
        Me.txtMname.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(21, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 21)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Patient ID:"
        '
        'lblPatientId
        '
        Me.lblPatientId.AutoSize = True
        Me.lblPatientId.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientId.ForeColor = System.Drawing.Color.Black
        Me.lblPatientId.Location = New System.Drawing.Point(119, 68)
        Me.lblPatientId.Name = "lblPatientId"
        Me.lblPatientId.Size = New System.Drawing.Size(31, 21)
        Me.lblPatientId.TabIndex = 12
        Me.lblPatientId.Text = "[?]"
        '
        'txtFname
        '
        Me.txtFname.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.txtFname.BorderRadius = 10
        Me.txtFname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFname.DefaultText = ""
        Me.txtFname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFname.DisabledState.Parent = Me.txtFname
        Me.txtFname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFname.FocusedState.Parent = Me.txtFname
        Me.txtFname.ForeColor = System.Drawing.Color.Black
        Me.txtFname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFname.HoverState.Parent = Me.txtFname
        Me.txtFname.Location = New System.Drawing.Point(14, 107)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFname.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtFname.PlaceholderText = "First Name"
        Me.txtFname.SelectedText = ""
        Me.txtFname.ShadowDecoration.Parent = Me.txtFname
        Me.txtFname.Size = New System.Drawing.Size(276, 48)
        Me.txtFname.TabIndex = 1
        '
        'frm_edit_patient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(888, 554)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_edit_patient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Patient"
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSubmit As FontAwesome.Sharp.IconButton
    Friend WithEvents txtContactNum As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtEmailAdd As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents txtAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dtpBirthDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents cmbGender As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPatientId As Label
    Friend WithEvents txtFname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtLname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtMname As Guna.UI2.WinForms.Guna2TextBox
End Class
