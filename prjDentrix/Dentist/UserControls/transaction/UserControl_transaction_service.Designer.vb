<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_transaction_service
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
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.lblServiceCost = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblServiceName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.txtServiceID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblPatientName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPatientID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnClear = New FontAwesome.Sharp.IconButton()
        Me.btnSubmit = New FontAwesome.Sharp.IconButton()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTransactionServiceID = New System.Windows.Forms.Label()
        Me.dtpTransactionDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txtPaymentDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPaymentAmount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GroupBox3 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAddedBalance = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtTotalChange = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.Guna2GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.lblServiceCost)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.lblServiceName)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Button2)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Button1)
        Me.Guna2GroupBox1.Controls.Add(Me.txtServiceID)
        Me.Guna2GroupBox1.Controls.Add(Me.lblPatientName)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.txtPatientID)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(12, 21)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(885, 206)
        Me.Guna2GroupBox1.TabIndex = 23
        Me.Guna2GroupBox1.Text = "Add Transaction (Service)"
        '
        'lblServiceCost
        '
        Me.lblServiceCost.AutoSize = True
        Me.lblServiceCost.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceCost.ForeColor = System.Drawing.Color.Black
        Me.lblServiceCost.Location = New System.Drawing.Point(624, 154)
        Me.lblServiceCost.Name = "lblServiceCost"
        Me.lblServiceCost.Size = New System.Drawing.Size(31, 21)
        Me.lblServiceCost.TabIndex = 34
        Me.lblServiceCost.Text = "[?]"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(507, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 21)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Service Cost:"
        '
        'lblServiceName
        '
        Me.lblServiceName.AutoSize = True
        Me.lblServiceName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceName.ForeColor = System.Drawing.Color.Black
        Me.lblServiceName.Location = New System.Drawing.Point(624, 115)
        Me.lblServiceName.Name = "lblServiceName"
        Me.lblServiceName.Size = New System.Drawing.Size(31, 21)
        Me.lblServiceName.TabIndex = 32
        Me.lblServiceName.Text = "[?]"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(495, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 21)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Service Name:"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BorderRadius = 20
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Location = New System.Drawing.Point(280, 56)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(101, 38)
        Me.Guna2Button2.TabIndex = 30
        Me.Guna2Button2.Text = "Browse"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 20
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(766, 56)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(101, 38)
        Me.Guna2Button1.TabIndex = 29
        Me.Guna2Button1.Text = "Browse"
        '
        'txtServiceID
        '
        Me.txtServiceID.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.txtServiceID.BorderRadius = 10
        Me.txtServiceID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtServiceID.DefaultText = ""
        Me.txtServiceID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtServiceID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtServiceID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtServiceID.DisabledState.Parent = Me.txtServiceID
        Me.txtServiceID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtServiceID.Enabled = False
        Me.txtServiceID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtServiceID.FocusedState.Parent = Me.txtServiceID
        Me.txtServiceID.ForeColor = System.Drawing.Color.Black
        Me.txtServiceID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtServiceID.HoverState.Parent = Me.txtServiceID
        Me.txtServiceID.Location = New System.Drawing.Point(499, 56)
        Me.txtServiceID.Name = "txtServiceID"
        Me.txtServiceID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtServiceID.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtServiceID.PlaceholderText = "Service"
        Me.txtServiceID.SelectedText = ""
        Me.txtServiceID.ShadowDecoration.Parent = Me.txtServiceID
        Me.txtServiceID.Size = New System.Drawing.Size(261, 38)
        Me.txtServiceID.TabIndex = 28
        '
        'lblPatientName
        '
        Me.lblPatientName.AutoSize = True
        Me.lblPatientName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientName.ForeColor = System.Drawing.Color.Black
        Me.lblPatientName.Location = New System.Drawing.Point(141, 115)
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
        Me.Label3.Location = New System.Drawing.Point(12, 115)
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
        Me.txtPatientID.Location = New System.Drawing.Point(16, 56)
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPatientID.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtPatientID.PlaceholderText = "Patient ID"
        Me.txtPatientID.SelectedText = ""
        Me.txtPatientID.ShadowDecoration.Parent = Me.txtPatientID
        Me.txtPatientID.Size = New System.Drawing.Size(249, 38)
        Me.txtPatientID.TabIndex = 25
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
        Me.btnClear.Location = New System.Drawing.Point(486, 507)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(119, 41)
        Me.btnClear.TabIndex = 25
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
        Me.btnSubmit.Location = New System.Drawing.Point(292, 507)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(119, 41)
        Me.btnSubmit.TabIndex = 24
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.Controls.Add(Me.Label5)
        Me.Guna2GroupBox2.Controls.Add(Me.lblTransactionServiceID)
        Me.Guna2GroupBox2.Controls.Add(Me.dtpTransactionDate)
        Me.Guna2GroupBox2.Controls.Add(Me.txtPaymentDescription)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(12, 244)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.Parent = Me.Guna2GroupBox2
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(431, 246)
        Me.Guna2GroupBox2.TabIndex = 30
        Me.Guna2GroupBox2.Text = "Description of Payment"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(198, 21)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Transaction ID (Service):"
        '
        'lblTransactionServiceID
        '
        Me.lblTransactionServiceID.AutoSize = True
        Me.lblTransactionServiceID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransactionServiceID.ForeColor = System.Drawing.Color.Black
        Me.lblTransactionServiceID.Location = New System.Drawing.Point(216, 59)
        Me.lblTransactionServiceID.Name = "lblTransactionServiceID"
        Me.lblTransactionServiceID.Size = New System.Drawing.Size(31, 21)
        Me.lblTransactionServiceID.TabIndex = 37
        Me.lblTransactionServiceID.Text = "[?]"
        '
        'dtpTransactionDate
        '
        Me.dtpTransactionDate.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.dtpTransactionDate.BorderRadius = 10
        Me.dtpTransactionDate.BorderThickness = 1
        Me.dtpTransactionDate.CheckedState.Parent = Me.dtpTransactionDate
        Me.dtpTransactionDate.Enabled = False
        Me.dtpTransactionDate.FillColor = System.Drawing.Color.White
        Me.dtpTransactionDate.ForeColor = System.Drawing.Color.Black
        Me.dtpTransactionDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpTransactionDate.HoverState.Parent = Me.dtpTransactionDate
        Me.dtpTransactionDate.Location = New System.Drawing.Point(16, 158)
        Me.dtpTransactionDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpTransactionDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpTransactionDate.Name = "dtpTransactionDate"
        Me.dtpTransactionDate.ShadowDecoration.Parent = Me.dtpTransactionDate
        Me.dtpTransactionDate.Size = New System.Drawing.Size(336, 43)
        Me.dtpTransactionDate.TabIndex = 30
        Me.dtpTransactionDate.Value = New Date(2021, 11, 12, 20, 56, 14, 454)
        '
        'txtPaymentDescription
        '
        Me.txtPaymentDescription.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.txtPaymentDescription.BorderRadius = 10
        Me.txtPaymentDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPaymentDescription.DefaultText = ""
        Me.txtPaymentDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPaymentDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPaymentDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPaymentDescription.DisabledState.Parent = Me.txtPaymentDescription
        Me.txtPaymentDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPaymentDescription.Enabled = False
        Me.txtPaymentDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPaymentDescription.FocusedState.Parent = Me.txtPaymentDescription
        Me.txtPaymentDescription.ForeColor = System.Drawing.Color.Black
        Me.txtPaymentDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPaymentDescription.HoverState.Parent = Me.txtPaymentDescription
        Me.txtPaymentDescription.Location = New System.Drawing.Point(16, 98)
        Me.txtPaymentDescription.Name = "txtPaymentDescription"
        Me.txtPaymentDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPaymentDescription.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtPaymentDescription.PlaceholderText = "Description"
        Me.txtPaymentDescription.SelectedText = ""
        Me.txtPaymentDescription.ShadowDecoration.Parent = Me.txtPaymentDescription
        Me.txtPaymentDescription.Size = New System.Drawing.Size(336, 43)
        Me.txtPaymentDescription.TabIndex = 28
        '
        'txtPaymentAmount
        '
        Me.txtPaymentAmount.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.txtPaymentAmount.BorderRadius = 10
        Me.txtPaymentAmount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPaymentAmount.DefaultText = ""
        Me.txtPaymentAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPaymentAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPaymentAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPaymentAmount.DisabledState.Parent = Me.txtPaymentAmount
        Me.txtPaymentAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPaymentAmount.Enabled = False
        Me.txtPaymentAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPaymentAmount.FocusedState.Parent = Me.txtPaymentAmount
        Me.txtPaymentAmount.ForeColor = System.Drawing.Color.Black
        Me.txtPaymentAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPaymentAmount.HoverState.Parent = Me.txtPaymentAmount
        Me.txtPaymentAmount.Location = New System.Drawing.Point(20, 86)
        Me.txtPaymentAmount.Name = "txtPaymentAmount"
        Me.txtPaymentAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPaymentAmount.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtPaymentAmount.PlaceholderText = "Payment Amount"
        Me.txtPaymentAmount.SelectedText = ""
        Me.txtPaymentAmount.ShadowDecoration.Parent = Me.txtPaymentAmount
        Me.txtPaymentAmount.Size = New System.Drawing.Size(393, 43)
        Me.txtPaymentAmount.TabIndex = 25
        '
        'Guna2GroupBox3
        '
        Me.Guna2GroupBox3.Controls.Add(Me.Label7)
        Me.Guna2GroupBox3.Controls.Add(Me.Label6)
        Me.Guna2GroupBox3.Controls.Add(Me.Label4)
        Me.Guna2GroupBox3.Controls.Add(Me.txtAddedBalance)
        Me.Guna2GroupBox3.Controls.Add(Me.txtTotalChange)
        Me.Guna2GroupBox3.Controls.Add(Me.txtPaymentAmount)
        Me.Guna2GroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Guna2GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox3.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox3.Location = New System.Drawing.Point(466, 244)
        Me.Guna2GroupBox3.Name = "Guna2GroupBox3"
        Me.Guna2GroupBox3.ShadowDecoration.Parent = Me.Guna2GroupBox3
        Me.Guna2GroupBox3.Size = New System.Drawing.Size(431, 246)
        Me.Guna2GroupBox3.TabIndex = 31
        Me.Guna2GroupBox3.Text = "Payment"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(21, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 21)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Payment Amount:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(25, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 21)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Added Balance:"
        Me.Label6.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(21, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 21)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Total Change:"
        Me.Label4.Visible = False
        '
        'txtAddedBalance
        '
        Me.txtAddedBalance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.txtAddedBalance.BorderRadius = 10
        Me.txtAddedBalance.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddedBalance.DefaultText = ""
        Me.txtAddedBalance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAddedBalance.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAddedBalance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAddedBalance.DisabledState.Parent = Me.txtAddedBalance
        Me.txtAddedBalance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAddedBalance.Enabled = False
        Me.txtAddedBalance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAddedBalance.FocusedState.Parent = Me.txtAddedBalance
        Me.txtAddedBalance.ForeColor = System.Drawing.Color.Black
        Me.txtAddedBalance.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAddedBalance.HoverState.Parent = Me.txtAddedBalance
        Me.txtAddedBalance.Location = New System.Drawing.Point(20, 170)
        Me.txtAddedBalance.Name = "txtAddedBalance"
        Me.txtAddedBalance.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddedBalance.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtAddedBalance.PlaceholderText = "Total Balance"
        Me.txtAddedBalance.SelectedText = ""
        Me.txtAddedBalance.ShadowDecoration.Parent = Me.txtAddedBalance
        Me.txtAddedBalance.Size = New System.Drawing.Size(393, 43)
        Me.txtAddedBalance.TabIndex = 28
        Me.txtAddedBalance.Visible = False
        '
        'txtTotalChange
        '
        Me.txtTotalChange.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.txtTotalChange.BorderRadius = 10
        Me.txtTotalChange.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotalChange.DefaultText = ""
        Me.txtTotalChange.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTotalChange.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTotalChange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTotalChange.DisabledState.Parent = Me.txtTotalChange
        Me.txtTotalChange.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTotalChange.Enabled = False
        Me.txtTotalChange.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotalChange.FocusedState.Parent = Me.txtTotalChange
        Me.txtTotalChange.ForeColor = System.Drawing.Color.Black
        Me.txtTotalChange.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotalChange.HoverState.Parent = Me.txtTotalChange
        Me.txtTotalChange.Location = New System.Drawing.Point(20, 170)
        Me.txtTotalChange.Name = "txtTotalChange"
        Me.txtTotalChange.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalChange.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtTotalChange.PlaceholderText = "Total Change"
        Me.txtTotalChange.SelectedText = ""
        Me.txtTotalChange.ShadowDecoration.Parent = Me.txtTotalChange
        Me.txtTotalChange.Size = New System.Drawing.Size(307, 43)
        Me.txtTotalChange.TabIndex = 25
        Me.txtTotalChange.Visible = False
        '
        'UserControl_transaction_service
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Guna2GroupBox3)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Name = "UserControl_transaction_service"
        Me.Size = New System.Drawing.Size(909, 578)
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        Me.Guna2GroupBox3.ResumeLayout(False)
        Me.Guna2GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents txtPatientID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnClear As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSubmit As FontAwesome.Sharp.IconButton
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtServiceID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents txtPaymentDescription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPaymentAmount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dtpTransactionDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblServiceName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPatientName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblServiceCost As Label
    Friend WithEvents Guna2GroupBox3 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAddedBalance As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtTotalChange As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTransactionServiceID As Label
    Friend WithEvents Label7 As Label
End Class
