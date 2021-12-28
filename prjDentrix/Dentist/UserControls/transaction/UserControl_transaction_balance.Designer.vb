<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserControl_transaction_balance
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.lblPatientName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPatientID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvPatientBalance = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.cmbFilter = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.grpbox_balance_history = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpDateTo = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.dtpDateFrom = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbViewBy = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.grpbox_totalbalance = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.grp_Payment = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.lblTotalBalance = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTotalChange = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPaymentAmount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvTotalBalance = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.grp_description_payment = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblTransactionItemID = New System.Windows.Forms.Label()
        Me.dtpTransactionDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txtPaymentDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSubmit = New FontAwesome.Sharp.IconButton()
        Me.btnClear = New FontAwesome.Sharp.IconButton()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvPatientBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbox_balance_history.SuspendLayout()
        Me.grpbox_totalbalance.SuspendLayout()
        Me.grp_Payment.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvTotalBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_description_payment.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Button2)
        Me.Guna2GroupBox1.Controls.Add(Me.lblPatientName)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.cmbViewBy)
        Me.Guna2GroupBox1.Controls.Add(Me.txtPatientID)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(12, 18)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(397, 234)
        Me.Guna2GroupBox1.TabIndex = 33
        Me.Guna2GroupBox1.Text = "Patient Info"
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
        Me.txtPatientID.Location = New System.Drawing.Point(16, 57)
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPatientID.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtPatientID.PlaceholderText = "Patient ID"
        Me.txtPatientID.SelectedText = ""
        Me.txtPatientID.ShadowDecoration.Parent = Me.txtPatientID
        Me.txtPatientID.Size = New System.Drawing.Size(248, 38)
        Me.txtPatientID.TabIndex = 25
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgvPatientBalance)
        Me.Panel1.Location = New System.Drawing.Point(16, 127)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(447, 418)
        Me.Panel1.TabIndex = 34
        '
        'dgvPatientBalance
        '
        Me.dgvPatientBalance.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvPatientBalance.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPatientBalance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPatientBalance.BackgroundColor = System.Drawing.Color.White
        Me.dgvPatientBalance.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPatientBalance.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvPatientBalance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPatientBalance.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPatientBalance.ColumnHeadersHeight = 50
        Me.dgvPatientBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPatientBalance.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPatientBalance.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPatientBalance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPatientBalance.EnableHeadersVisualStyles = False
        Me.dgvPatientBalance.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvPatientBalance.Location = New System.Drawing.Point(0, 0)
        Me.dgvPatientBalance.Name = "dgvPatientBalance"
        Me.dgvPatientBalance.ReadOnly = True
        Me.dgvPatientBalance.RowHeadersVisible = False
        Me.dgvPatientBalance.RowTemplate.Height = 80
        Me.dgvPatientBalance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPatientBalance.Size = New System.Drawing.Size(447, 418)
        Me.dgvPatientBalance.TabIndex = 1
        Me.dgvPatientBalance.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvPatientBalance.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvPatientBalance.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvPatientBalance.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvPatientBalance.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvPatientBalance.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvPatientBalance.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvPatientBalance.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvPatientBalance.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvPatientBalance.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvPatientBalance.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvPatientBalance.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvPatientBalance.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPatientBalance.ThemeStyle.HeaderStyle.Height = 50
        Me.dgvPatientBalance.ThemeStyle.ReadOnly = True
        Me.dgvPatientBalance.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvPatientBalance.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvPatientBalance.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvPatientBalance.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvPatientBalance.ThemeStyle.RowsStyle.Height = 80
        Me.dgvPatientBalance.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvPatientBalance.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'cmbFilter
        '
        Me.cmbFilter.BackColor = System.Drawing.Color.Transparent
        Me.cmbFilter.BorderRadius = 10
        Me.cmbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFilter.FocusedColor = System.Drawing.Color.Empty
        Me.cmbFilter.FocusedState.Parent = Me.cmbFilter
        Me.cmbFilter.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.HoverState.Parent = Me.cmbFilter
        Me.cmbFilter.ItemHeight = 30
        Me.cmbFilter.Items.AddRange(New Object() {"All", "By Service", "By Item", "Between Dates"})
        Me.cmbFilter.ItemsAppearance.Parent = Me.cmbFilter
        Me.cmbFilter.Location = New System.Drawing.Point(16, 76)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.ShadowDecoration.Parent = Me.cmbFilter
        Me.cmbFilter.Size = New System.Drawing.Size(112, 36)
        Me.cmbFilter.StartIndex = 0
        Me.cmbFilter.TabIndex = 35
        '
        'grpbox_balance_history
        '
        Me.grpbox_balance_history.Controls.Add(Me.Label5)
        Me.grpbox_balance_history.Controls.Add(Me.Label4)
        Me.grpbox_balance_history.Controls.Add(Me.dtpDateTo)
        Me.grpbox_balance_history.Controls.Add(Me.dtpDateFrom)
        Me.grpbox_balance_history.Controls.Add(Me.Label1)
        Me.grpbox_balance_history.Controls.Add(Me.Panel1)
        Me.grpbox_balance_history.Controls.Add(Me.cmbFilter)
        Me.grpbox_balance_history.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.grpbox_balance_history.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.grpbox_balance_history.ForeColor = System.Drawing.Color.White
        Me.grpbox_balance_history.Location = New System.Drawing.Point(415, 18)
        Me.grpbox_balance_history.Name = "grpbox_balance_history"
        Me.grpbox_balance_history.ShadowDecoration.Parent = Me.grpbox_balance_history
        Me.grpbox_balance_history.Size = New System.Drawing.Size(479, 530)
        Me.grpbox_balance_history.TabIndex = 34
        Me.grpbox_balance_history.Text = "Balance History"
        Me.grpbox_balance_history.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(304, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 15)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Date To"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(131, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 15)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Date From"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.dtpDateTo.BorderRadius = 10
        Me.dtpDateTo.BorderThickness = 1
        Me.dtpDateTo.CheckedState.Parent = Me.dtpDateTo
        Me.dtpDateTo.Enabled = False
        Me.dtpDateTo.FillColor = System.Drawing.Color.White
        Me.dtpDateTo.ForeColor = System.Drawing.Color.Black
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpDateTo.HoverState.Parent = Me.dtpDateTo
        Me.dtpDateTo.Location = New System.Drawing.Point(307, 76)
        Me.dtpDateTo.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpDateTo.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.ShadowDecoration.Parent = Me.dtpDateTo
        Me.dtpDateTo.Size = New System.Drawing.Size(169, 36)
        Me.dtpDateTo.TabIndex = 39
        Me.dtpDateTo.Value = New Date(2021, 11, 12, 20, 56, 14, 454)
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.dtpDateFrom.BorderRadius = 10
        Me.dtpDateFrom.BorderThickness = 1
        Me.dtpDateFrom.CheckedState.Parent = Me.dtpDateFrom
        Me.dtpDateFrom.Enabled = False
        Me.dtpDateFrom.FillColor = System.Drawing.Color.White
        Me.dtpDateFrom.ForeColor = System.Drawing.Color.Black
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpDateFrom.HoverState.Parent = Me.dtpDateFrom
        Me.dtpDateFrom.Location = New System.Drawing.Point(134, 76)
        Me.dtpDateFrom.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpDateFrom.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.ShadowDecoration.Parent = Me.dtpDateFrom
        Me.dtpDateFrom.Size = New System.Drawing.Size(167, 36)
        Me.dtpDateFrom.TabIndex = 38
        Me.dtpDateFrom.Value = New Date(2021, 11, 12, 20, 56, 14, 454)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(13, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 15)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Filter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(13, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 15)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Display:"
        '
        'cmbViewBy
        '
        Me.cmbViewBy.BackColor = System.Drawing.Color.Transparent
        Me.cmbViewBy.BorderRadius = 10
        Me.cmbViewBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbViewBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbViewBy.Enabled = False
        Me.cmbViewBy.FocusedColor = System.Drawing.Color.Empty
        Me.cmbViewBy.FocusedState.Parent = Me.cmbViewBy
        Me.cmbViewBy.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbViewBy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbViewBy.FormattingEnabled = True
        Me.cmbViewBy.HoverState.Parent = Me.cmbViewBy
        Me.cmbViewBy.ItemHeight = 30
        Me.cmbViewBy.Items.AddRange(New Object() {"Total Balance Amount", "Balance History"})
        Me.cmbViewBy.ItemsAppearance.Parent = Me.cmbViewBy
        Me.cmbViewBy.Location = New System.Drawing.Point(16, 185)
        Me.cmbViewBy.Name = "cmbViewBy"
        Me.cmbViewBy.ShadowDecoration.Parent = Me.cmbViewBy
        Me.cmbViewBy.Size = New System.Drawing.Size(232, 36)
        Me.cmbViewBy.TabIndex = 38
        '
        'grpbox_totalbalance
        '
        Me.grpbox_totalbalance.Controls.Add(Me.grp_Payment)
        Me.grpbox_totalbalance.Controls.Add(Me.Panel2)
        Me.grpbox_totalbalance.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.grpbox_totalbalance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.grpbox_totalbalance.ForeColor = System.Drawing.Color.White
        Me.grpbox_totalbalance.Location = New System.Drawing.Point(415, 18)
        Me.grpbox_totalbalance.Name = "grpbox_totalbalance"
        Me.grpbox_totalbalance.ShadowDecoration.Parent = Me.grpbox_totalbalance
        Me.grpbox_totalbalance.Size = New System.Drawing.Size(479, 545)
        Me.grpbox_totalbalance.TabIndex = 38
        Me.grpbox_totalbalance.Text = "Total Balance Amount (Please click which transaction type to pay)"
        '
        'grp_Payment
        '
        Me.grp_Payment.Controls.Add(Me.lblTotalBalance)
        Me.grp_Payment.Controls.Add(Me.Label10)
        Me.grp_Payment.Controls.Add(Me.Label7)
        Me.grp_Payment.Controls.Add(Me.Label8)
        Me.grp_Payment.Controls.Add(Me.txtTotalChange)
        Me.grp_Payment.Controls.Add(Me.txtPaymentAmount)
        Me.grp_Payment.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.grp_Payment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.grp_Payment.ForeColor = System.Drawing.Color.White
        Me.grp_Payment.Location = New System.Drawing.Point(16, 318)
        Me.grp_Payment.Name = "grp_Payment"
        Me.grp_Payment.ShadowDecoration.Parent = Me.grp_Payment
        Me.grp_Payment.Size = New System.Drawing.Size(444, 212)
        Me.grp_Payment.TabIndex = 39
        Me.grp_Payment.Text = "Payment of Remaining Balance"
        Me.grp_Payment.Visible = False
        '
        'lblTotalBalance
        '
        Me.lblTotalBalance.AutoSize = True
        Me.lblTotalBalance.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBalance.ForeColor = System.Drawing.Color.Black
        Me.lblTotalBalance.Location = New System.Drawing.Point(150, 51)
        Me.lblTotalBalance.Name = "lblTotalBalance"
        Me.lblTotalBalance.Size = New System.Drawing.Size(31, 21)
        Me.lblTotalBalance.TabIndex = 39
        Me.lblTotalBalance.Text = "[?]"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(23, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 21)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Total Balance:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(28, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 21)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Payment Amount:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(28, 142)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 21)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Total Change:"
        Me.Label8.Visible = False
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
        Me.txtTotalChange.Location = New System.Drawing.Point(27, 166)
        Me.txtTotalChange.Name = "txtTotalChange"
        Me.txtTotalChange.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalChange.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtTotalChange.PlaceholderText = "Total Change"
        Me.txtTotalChange.SelectedText = ""
        Me.txtTotalChange.ShadowDecoration.Parent = Me.txtTotalChange
        Me.txtTotalChange.Size = New System.Drawing.Size(307, 32)
        Me.txtTotalChange.TabIndex = 25
        Me.txtTotalChange.Visible = False
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
        Me.txtPaymentAmount.Location = New System.Drawing.Point(27, 107)
        Me.txtPaymentAmount.Name = "txtPaymentAmount"
        Me.txtPaymentAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPaymentAmount.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtPaymentAmount.PlaceholderText = "Payment Amount"
        Me.txtPaymentAmount.SelectedText = ""
        Me.txtPaymentAmount.ShadowDecoration.Parent = Me.txtPaymentAmount
        Me.txtPaymentAmount.Size = New System.Drawing.Size(307, 32)
        Me.txtPaymentAmount.TabIndex = 25
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgvTotalBalance)
        Me.Panel2.Location = New System.Drawing.Point(19, 56)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(447, 256)
        Me.Panel2.TabIndex = 34
        '
        'dgvTotalBalance
        '
        Me.dgvTotalBalance.AllowUserToAddRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgvTotalBalance.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvTotalBalance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTotalBalance.BackgroundColor = System.Drawing.Color.White
        Me.dgvTotalBalance.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTotalBalance.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvTotalBalance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTotalBalance.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvTotalBalance.ColumnHeadersHeight = 50
        Me.dgvTotalBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvTotalBalance.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTotalBalance.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvTotalBalance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTotalBalance.EnableHeadersVisualStyles = False
        Me.dgvTotalBalance.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTotalBalance.Location = New System.Drawing.Point(0, 0)
        Me.dgvTotalBalance.Name = "dgvTotalBalance"
        Me.dgvTotalBalance.ReadOnly = True
        Me.dgvTotalBalance.RowHeadersVisible = False
        Me.dgvTotalBalance.RowTemplate.Height = 80
        Me.dgvTotalBalance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTotalBalance.Size = New System.Drawing.Size(447, 256)
        Me.dgvTotalBalance.TabIndex = 1
        Me.dgvTotalBalance.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvTotalBalance.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvTotalBalance.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvTotalBalance.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvTotalBalance.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvTotalBalance.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvTotalBalance.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvTotalBalance.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTotalBalance.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTotalBalance.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvTotalBalance.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvTotalBalance.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvTotalBalance.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvTotalBalance.ThemeStyle.HeaderStyle.Height = 50
        Me.dgvTotalBalance.ThemeStyle.ReadOnly = True
        Me.dgvTotalBalance.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvTotalBalance.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvTotalBalance.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvTotalBalance.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvTotalBalance.ThemeStyle.RowsStyle.Height = 80
        Me.dgvTotalBalance.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTotalBalance.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'grp_description_payment
        '
        Me.grp_description_payment.Controls.Add(Me.lblTitle)
        Me.grp_description_payment.Controls.Add(Me.lblTransactionItemID)
        Me.grp_description_payment.Controls.Add(Me.dtpTransactionDate)
        Me.grp_description_payment.Controls.Add(Me.txtPaymentDescription)
        Me.grp_description_payment.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.grp_description_payment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.grp_description_payment.ForeColor = System.Drawing.Color.White
        Me.grp_description_payment.Location = New System.Drawing.Point(12, 336)
        Me.grp_description_payment.Name = "grp_description_payment"
        Me.grp_description_payment.ShadowDecoration.Parent = Me.grp_description_payment
        Me.grp_description_payment.Size = New System.Drawing.Size(397, 181)
        Me.grp_description_payment.TabIndex = 40
        Me.grp_description_payment.Text = "Description of Payment"
        Me.grp_description_payment.Visible = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(8, 51)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(0, 21)
        Me.lblTitle.TabIndex = 38
        '
        'lblTransactionItemID
        '
        Me.lblTransactionItemID.AutoSize = True
        Me.lblTransactionItemID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransactionItemID.ForeColor = System.Drawing.Color.Black
        Me.lblTransactionItemID.Location = New System.Drawing.Point(193, 51)
        Me.lblTransactionItemID.Name = "lblTransactionItemID"
        Me.lblTransactionItemID.Size = New System.Drawing.Size(31, 21)
        Me.lblTransactionItemID.TabIndex = 37
        Me.lblTransactionItemID.Text = "[?]"
        '
        'dtpTransactionDate
        '
        Me.dtpTransactionDate.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.dtpTransactionDate.BorderRadius = 10
        Me.dtpTransactionDate.BorderThickness = 1
        Me.dtpTransactionDate.CheckedState.Parent = Me.dtpTransactionDate
        Me.dtpTransactionDate.FillColor = System.Drawing.Color.White
        Me.dtpTransactionDate.ForeColor = System.Drawing.Color.Black
        Me.dtpTransactionDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpTransactionDate.HoverState.Parent = Me.dtpTransactionDate
        Me.dtpTransactionDate.Location = New System.Drawing.Point(8, 137)
        Me.dtpTransactionDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpTransactionDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpTransactionDate.Name = "dtpTransactionDate"
        Me.dtpTransactionDate.ShadowDecoration.Parent = Me.dtpTransactionDate
        Me.dtpTransactionDate.Size = New System.Drawing.Size(373, 32)
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
        Me.txtPaymentDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPaymentDescription.FocusedState.Parent = Me.txtPaymentDescription
        Me.txtPaymentDescription.ForeColor = System.Drawing.Color.Black
        Me.txtPaymentDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPaymentDescription.HoverState.Parent = Me.txtPaymentDescription
        Me.txtPaymentDescription.Location = New System.Drawing.Point(8, 78)
        Me.txtPaymentDescription.Name = "txtPaymentDescription"
        Me.txtPaymentDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPaymentDescription.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtPaymentDescription.PlaceholderText = "Description"
        Me.txtPaymentDescription.SelectedText = ""
        Me.txtPaymentDescription.ShadowDecoration.Parent = Me.txtPaymentDescription
        Me.txtPaymentDescription.Size = New System.Drawing.Size(373, 35)
        Me.txtPaymentDescription.TabIndex = 28
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
        Me.btnSubmit.Location = New System.Drawing.Point(80, 523)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(119, 41)
        Me.btnSubmit.TabIndex = 41
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        Me.btnSubmit.Visible = False
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
        Me.btnClear.Location = New System.Drawing.Point(226, 523)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(119, 41)
        Me.btnClear.TabIndex = 42
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        Me.btnClear.Visible = False
        '
        'UserControl_transaction_balance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.grp_description_payment)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.grpbox_totalbalance)
        Me.Controls.Add(Me.grpbox_balance_history)
        Me.Name = "UserControl_transaction_balance"
        Me.Size = New System.Drawing.Size(909, 578)
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvPatientBalance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbox_balance_history.ResumeLayout(False)
        Me.grpbox_balance_history.PerformLayout()
        Me.grpbox_totalbalance.ResumeLayout(False)
        Me.grp_Payment.ResumeLayout(False)
        Me.grp_Payment.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvTotalBalance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_description_payment.ResumeLayout(False)
        Me.grp_description_payment.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblPatientName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPatientID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmbFilter As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents grpbox_balance_history As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbViewBy As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents grpbox_totalbalance As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvTotalBalance As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents dgvPatientBalance As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpDateTo As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dtpDateFrom As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents grp_Payment As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTotalChange As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPaymentAmount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents grp_description_payment As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblTransactionItemID As Label
    Friend WithEvents dtpTransactionDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents txtPaymentDescription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSubmit As FontAwesome.Sharp.IconButton
    Friend WithEvents btnClear As FontAwesome.Sharp.IconButton
    Friend WithEvents lblTotalBalance As Label
    Friend WithEvents Label10 As Label
End Class
