﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_services_addservice
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
        Me.txtServiceName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtServiceCost = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblServiceID = New System.Windows.Forms.Label()
        Me.btnClear = New FontAwesome.Sharp.IconButton()
        Me.btnSubmit = New FontAwesome.Sharp.IconButton()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.txtServiceName)
        Me.Guna2GroupBox1.Controls.Add(Me.txtServiceCost)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.lblServiceID)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(11, 146)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(885, 228)
        Me.Guna2GroupBox1.TabIndex = 21
        Me.Guna2GroupBox1.Text = "Add Prescription"
        '
        'txtServiceName
        '
        Me.txtServiceName.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.txtServiceName.BorderRadius = 10
        Me.txtServiceName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtServiceName.DefaultText = ""
        Me.txtServiceName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtServiceName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtServiceName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtServiceName.DisabledState.Parent = Me.txtServiceName
        Me.txtServiceName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtServiceName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtServiceName.FocusedState.Parent = Me.txtServiceName
        Me.txtServiceName.ForeColor = System.Drawing.Color.Black
        Me.txtServiceName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtServiceName.HoverState.Parent = Me.txtServiceName
        Me.txtServiceName.Location = New System.Drawing.Point(16, 109)
        Me.txtServiceName.Name = "txtServiceName"
        Me.txtServiceName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtServiceName.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtServiceName.PlaceholderText = "Name of Service"
        Me.txtServiceName.SelectedText = ""
        Me.txtServiceName.ShadowDecoration.Parent = Me.txtServiceName
        Me.txtServiceName.Size = New System.Drawing.Size(440, 55)
        Me.txtServiceName.TabIndex = 15
        '
        'txtServiceCost
        '
        Me.txtServiceCost.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.txtServiceCost.BorderRadius = 10
        Me.txtServiceCost.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtServiceCost.DefaultText = ""
        Me.txtServiceCost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtServiceCost.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtServiceCost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtServiceCost.DisabledState.Parent = Me.txtServiceCost
        Me.txtServiceCost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtServiceCost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtServiceCost.FocusedState.Parent = Me.txtServiceCost
        Me.txtServiceCost.ForeColor = System.Drawing.Color.Black
        Me.txtServiceCost.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtServiceCost.HoverState.Parent = Me.txtServiceCost
        Me.txtServiceCost.Location = New System.Drawing.Point(486, 109)
        Me.txtServiceCost.Name = "txtServiceCost"
        Me.txtServiceCost.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtServiceCost.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtServiceCost.PlaceholderText = "Service Cost"
        Me.txtServiceCost.SelectedText = ""
        Me.txtServiceCost.ShadowDecoration.Parent = Me.txtServiceCost
        Me.txtServiceCost.Size = New System.Drawing.Size(380, 55)
        Me.txtServiceCost.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 21)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Service ID:"
        '
        'lblServiceID
        '
        Me.lblServiceID.AutoSize = True
        Me.lblServiceID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceID.ForeColor = System.Drawing.Color.Black
        Me.lblServiceID.Location = New System.Drawing.Point(109, 68)
        Me.lblServiceID.Name = "lblServiceID"
        Me.lblServiceID.Size = New System.Drawing.Size(31, 21)
        Me.lblServiceID.TabIndex = 12
        Me.lblServiceID.Text = "[?]"
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
        Me.btnClear.Location = New System.Drawing.Point(498, 402)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(119, 41)
        Me.btnClear.TabIndex = 24
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
        Me.btnSubmit.Location = New System.Drawing.Point(303, 402)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(119, 41)
        Me.btnSubmit.TabIndex = 23
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'UserControl_services_addservice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Name = "UserControl_services_addservice"
        Me.Size = New System.Drawing.Size(909, 578)
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents txtServiceName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtServiceCost As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblServiceID As Label
    Friend WithEvents btnClear As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSubmit As FontAwesome.Sharp.IconButton
End Class
