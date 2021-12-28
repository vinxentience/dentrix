<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_prescription_addprescription
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
        Me.txtMedicine = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.lblPatientName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPatientID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtInterval = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtDosage = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblPrescriptionId = New System.Windows.Forms.Label()
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
        Me.Label1.Size = New System.Drawing.Size(124, 21)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Prescription ID:"
        '
        'txtMedicine
        '
        Me.txtMedicine.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.txtMedicine.BorderRadius = 10
        Me.txtMedicine.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMedicine.DefaultText = ""
        Me.txtMedicine.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMedicine.DisabledState.Parent = Me.txtMedicine
        Me.txtMedicine.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMedicine.Enabled = False
        Me.txtMedicine.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMedicine.FocusedState.Parent = Me.txtMedicine
        Me.txtMedicine.ForeColor = System.Drawing.Color.Black
        Me.txtMedicine.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMedicine.HoverState.Parent = Me.txtMedicine
        Me.txtMedicine.Location = New System.Drawing.Point(16, 179)
        Me.txtMedicine.Name = "txtMedicine"
        Me.txtMedicine.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMedicine.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtMedicine.PlaceholderText = "Name of Medicine"
        Me.txtMedicine.SelectedText = ""
        Me.txtMedicine.ShadowDecoration.Parent = Me.txtMedicine
        Me.txtMedicine.Size = New System.Drawing.Size(850, 55)
        Me.txtMedicine.TabIndex = 0
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Button2)
        Me.Guna2GroupBox1.Controls.Add(Me.lblPatientName)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.txtPatientID)
        Me.Guna2GroupBox1.Controls.Add(Me.txtInterval)
        Me.Guna2GroupBox1.Controls.Add(Me.txtDosage)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.lblPrescriptionId)
        Me.Guna2GroupBox1.Controls.Add(Me.txtMedicine)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(6, 77)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(885, 316)
        Me.Guna2GroupBox1.TabIndex = 20
        Me.Guna2GroupBox1.Text = "Add Prescription"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BorderRadius = 20
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Location = New System.Drawing.Point(387, 123)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(101, 38)
        Me.Guna2Button2.TabIndex = 32
        Me.Guna2Button2.Text = "Browse"
        '
        'lblPatientName
        '
        Me.lblPatientName.AutoSize = True
        Me.lblPatientName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientName.ForeColor = System.Drawing.Color.Black
        Me.lblPatientName.Location = New System.Drawing.Point(619, 130)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(31, 21)
        Me.lblPatientName.TabIndex = 27
        Me.lblPatientName.Text = "[?]"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(494, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 21)
        Me.Label3.TabIndex = 26
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
        Me.txtPatientID.Location = New System.Drawing.Point(16, 110)
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPatientID.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtPatientID.PlaceholderText = "Patient ID"
        Me.txtPatientID.SelectedText = ""
        Me.txtPatientID.ShadowDecoration.Parent = Me.txtPatientID
        Me.txtPatientID.Size = New System.Drawing.Size(355, 63)
        Me.txtPatientID.TabIndex = 25
        '
        'txtInterval
        '
        Me.txtInterval.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.txtInterval.BorderRadius = 10
        Me.txtInterval.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInterval.DefaultText = ""
        Me.txtInterval.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtInterval.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtInterval.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtInterval.DisabledState.Parent = Me.txtInterval
        Me.txtInterval.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtInterval.Enabled = False
        Me.txtInterval.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtInterval.FocusedState.Parent = Me.txtInterval
        Me.txtInterval.ForeColor = System.Drawing.Color.Black
        Me.txtInterval.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtInterval.HoverState.Parent = Me.txtInterval
        Me.txtInterval.Location = New System.Drawing.Point(16, 240)
        Me.txtInterval.Name = "txtInterval"
        Me.txtInterval.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtInterval.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtInterval.PlaceholderText = "Medicine Intake Interval"
        Me.txtInterval.SelectedText = ""
        Me.txtInterval.ShadowDecoration.Parent = Me.txtInterval
        Me.txtInterval.Size = New System.Drawing.Size(440, 55)
        Me.txtInterval.TabIndex = 15
        '
        'txtDosage
        '
        Me.txtDosage.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.txtDosage.BorderRadius = 10
        Me.txtDosage.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDosage.DefaultText = ""
        Me.txtDosage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDosage.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDosage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDosage.DisabledState.Parent = Me.txtDosage
        Me.txtDosage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDosage.Enabled = False
        Me.txtDosage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDosage.FocusedState.Parent = Me.txtDosage
        Me.txtDosage.ForeColor = System.Drawing.Color.Black
        Me.txtDosage.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDosage.HoverState.Parent = Me.txtDosage
        Me.txtDosage.Location = New System.Drawing.Point(486, 240)
        Me.txtDosage.Name = "txtDosage"
        Me.txtDosage.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDosage.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtDosage.PlaceholderText = "Medicine Dosage"
        Me.txtDosage.SelectedText = ""
        Me.txtDosage.ShadowDecoration.Parent = Me.txtDosage
        Me.txtDosage.Size = New System.Drawing.Size(380, 55)
        Me.txtDosage.TabIndex = 14
        '
        'lblPrescriptionId
        '
        Me.lblPrescriptionId.AutoSize = True
        Me.lblPrescriptionId.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrescriptionId.ForeColor = System.Drawing.Color.Black
        Me.lblPrescriptionId.Location = New System.Drawing.Point(142, 68)
        Me.lblPrescriptionId.Name = "lblPrescriptionId"
        Me.lblPrescriptionId.Size = New System.Drawing.Size(31, 21)
        Me.lblPrescriptionId.TabIndex = 12
        Me.lblPrescriptionId.Text = "[?]"
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
        Me.btnClear.Location = New System.Drawing.Point(492, 416)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(119, 41)
        Me.btnClear.TabIndex = 22
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
        Me.btnSubmit.Location = New System.Drawing.Point(297, 416)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(119, 41)
        Me.btnSubmit.TabIndex = 21
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'UserControl_prescription_addprescription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Name = "UserControl_prescription_addprescription"
        Me.Size = New System.Drawing.Size(909, 578)
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtMedicine As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents lblPrescriptionId As Label
    Friend WithEvents btnClear As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSubmit As FontAwesome.Sharp.IconButton
    Friend WithEvents txtInterval As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtDosage As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblPatientName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPatientID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
End Class
