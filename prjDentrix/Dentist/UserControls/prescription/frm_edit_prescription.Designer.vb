<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_edit_prescription
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMedicine = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.lblPatientName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtInterval = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtDosage = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblPrescriptionId = New System.Windows.Forms.Label()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
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
        Me.txtMedicine.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMedicine.FocusedState.Parent = Me.txtMedicine
        Me.txtMedicine.ForeColor = System.Drawing.Color.Black
        Me.txtMedicine.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMedicine.HoverState.Parent = Me.txtMedicine
        Me.txtMedicine.Location = New System.Drawing.Point(16, 110)
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
        Me.Guna2GroupBox1.Controls.Add(Me.lblPatientName)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.txtInterval)
        Me.Guna2GroupBox1.Controls.Add(Me.txtDosage)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.lblPrescriptionId)
        Me.Guna2GroupBox1.Controls.Add(Me.txtMedicine)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(12, 29)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(885, 275)
        Me.Guna2GroupBox1.TabIndex = 26
        Me.Guna2GroupBox1.Text = "Add Prescription"
        '
        'lblPatientName
        '
        Me.lblPatientName.AutoSize = True
        Me.lblPatientName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientName.ForeColor = System.Drawing.Color.Black
        Me.lblPatientName.Location = New System.Drawing.Point(477, 68)
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
        Me.Label3.Location = New System.Drawing.Point(348, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 21)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Patient Name:"
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
        Me.txtInterval.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtInterval.FocusedState.Parent = Me.txtInterval
        Me.txtInterval.ForeColor = System.Drawing.Color.Black
        Me.txtInterval.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtInterval.HoverState.Parent = Me.txtInterval
        Me.txtInterval.Location = New System.Drawing.Point(16, 171)
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
        Me.txtDosage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDosage.FocusedState.Parent = Me.txtDosage
        Me.txtDosage.ForeColor = System.Drawing.Color.Black
        Me.txtDosage.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDosage.HoverState.Parent = Me.txtDosage
        Me.txtDosage.Location = New System.Drawing.Point(486, 171)
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
        'IconButton2
        '
        Me.IconButton2.BackColor = System.Drawing.Color.SeaGreen
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton2.ForeColor = System.Drawing.Color.White
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton2.IconColor = System.Drawing.Color.Black
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.Location = New System.Drawing.Point(420, 335)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(119, 41)
        Me.IconButton2.TabIndex = 27
        Me.IconButton2.Text = "Submit"
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'frm_edit_prescription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(920, 398)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.IconButton2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_edit_prescription"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Prescription"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtMedicine As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents lblPatientName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtInterval As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtDosage As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblPrescriptionId As Label
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
End Class
