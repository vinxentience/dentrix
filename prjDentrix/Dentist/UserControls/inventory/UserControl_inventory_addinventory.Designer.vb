﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_inventory_addinventory
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
        Me.txtItemName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.txtItemCost = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtItemDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtItemQTY = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtItemUnit = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblItemID = New System.Windows.Forms.Label()
        Me.btnClear = New FontAwesome.Sharp.IconButton()
        Me.btnSubmit = New FontAwesome.Sharp.IconButton()
        Me.txtItemBrand = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtItemName
        '
        Me.txtItemName.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.txtItemName.BorderRadius = 10
        Me.txtItemName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtItemName.DefaultText = ""
        Me.txtItemName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtItemName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtItemName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItemName.DisabledState.Parent = Me.txtItemName
        Me.txtItemName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItemName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItemName.FocusedState.Parent = Me.txtItemName
        Me.txtItemName.ForeColor = System.Drawing.Color.Black
        Me.txtItemName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItemName.HoverState.Parent = Me.txtItemName
        Me.txtItemName.Location = New System.Drawing.Point(13, 103)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtItemName.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtItemName.PlaceholderText = "Item Name"
        Me.txtItemName.SelectedText = ""
        Me.txtItemName.ShadowDecoration.Parent = Me.txtItemName
        Me.txtItemName.Size = New System.Drawing.Size(471, 64)
        Me.txtItemName.TabIndex = 1
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.txtItemBrand)
        Me.Guna2GroupBox1.Controls.Add(Me.txtItemCost)
        Me.Guna2GroupBox1.Controls.Add(Me.txtItemDescription)
        Me.Guna2GroupBox1.Controls.Add(Me.txtItemQTY)
        Me.Guna2GroupBox1.Controls.Add(Me.txtItemUnit)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.lblItemID)
        Me.Guna2GroupBox1.Controls.Add(Me.txtItemName)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(13, 84)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(882, 340)
        Me.Guna2GroupBox1.TabIndex = 23
        Me.Guna2GroupBox1.Text = "Add Item"
        '
        'txtItemCost
        '
        Me.txtItemCost.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.txtItemCost.BorderRadius = 10
        Me.txtItemCost.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtItemCost.DefaultText = ""
        Me.txtItemCost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtItemCost.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtItemCost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItemCost.DisabledState.Parent = Me.txtItemCost
        Me.txtItemCost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItemCost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItemCost.FocusedState.Parent = Me.txtItemCost
        Me.txtItemCost.ForeColor = System.Drawing.Color.Black
        Me.txtItemCost.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItemCost.HoverState.Parent = Me.txtItemCost
        Me.txtItemCost.Location = New System.Drawing.Point(13, 179)
        Me.txtItemCost.Name = "txtItemCost"
        Me.txtItemCost.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtItemCost.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtItemCost.PlaceholderText = "Item Cost"
        Me.txtItemCost.SelectedText = ""
        Me.txtItemCost.ShadowDecoration.Parent = Me.txtItemCost
        Me.txtItemCost.Size = New System.Drawing.Size(426, 63)
        Me.txtItemCost.TabIndex = 3
        '
        'txtItemDescription
        '
        Me.txtItemDescription.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.txtItemDescription.BorderRadius = 10
        Me.txtItemDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtItemDescription.DefaultText = ""
        Me.txtItemDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtItemDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtItemDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItemDescription.DisabledState.Parent = Me.txtItemDescription
        Me.txtItemDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItemDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItemDescription.FocusedState.Parent = Me.txtItemDescription
        Me.txtItemDescription.ForeColor = System.Drawing.Color.Black
        Me.txtItemDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItemDescription.HoverState.Parent = Me.txtItemDescription
        Me.txtItemDescription.Location = New System.Drawing.Point(445, 179)
        Me.txtItemDescription.Name = "txtItemDescription"
        Me.txtItemDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtItemDescription.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtItemDescription.PlaceholderText = "Item Description"
        Me.txtItemDescription.SelectedText = ""
        Me.txtItemDescription.ShadowDecoration.Parent = Me.txtItemDescription
        Me.txtItemDescription.Size = New System.Drawing.Size(404, 64)
        Me.txtItemDescription.TabIndex = 4
        '
        'txtItemQTY
        '
        Me.txtItemQTY.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.txtItemQTY.BorderRadius = 10
        Me.txtItemQTY.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtItemQTY.DefaultText = ""
        Me.txtItemQTY.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtItemQTY.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtItemQTY.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItemQTY.DisabledState.Parent = Me.txtItemQTY
        Me.txtItemQTY.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItemQTY.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItemQTY.FocusedState.Parent = Me.txtItemQTY
        Me.txtItemQTY.ForeColor = System.Drawing.Color.Black
        Me.txtItemQTY.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItemQTY.HoverState.Parent = Me.txtItemQTY
        Me.txtItemQTY.Location = New System.Drawing.Point(227, 248)
        Me.txtItemQTY.Name = "txtItemQTY"
        Me.txtItemQTY.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtItemQTY.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtItemQTY.PlaceholderText = "Item Quantity"
        Me.txtItemQTY.SelectedText = ""
        Me.txtItemQTY.ShadowDecoration.Parent = Me.txtItemQTY
        Me.txtItemQTY.Size = New System.Drawing.Size(240, 64)
        Me.txtItemQTY.TabIndex = 5
        '
        'txtItemUnit
        '
        Me.txtItemUnit.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.txtItemUnit.BorderRadius = 10
        Me.txtItemUnit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtItemUnit.DefaultText = ""
        Me.txtItemUnit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtItemUnit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtItemUnit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItemUnit.DisabledState.Parent = Me.txtItemUnit
        Me.txtItemUnit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItemUnit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItemUnit.FocusedState.Parent = Me.txtItemUnit
        Me.txtItemUnit.ForeColor = System.Drawing.Color.Black
        Me.txtItemUnit.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItemUnit.HoverState.Parent = Me.txtItemUnit
        Me.txtItemUnit.Location = New System.Drawing.Point(473, 249)
        Me.txtItemUnit.Name = "txtItemUnit"
        Me.txtItemUnit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtItemUnit.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtItemUnit.PlaceholderText = "Item Unit"
        Me.txtItemUnit.SelectedText = ""
        Me.txtItemUnit.ShadowDecoration.Parent = Me.txtItemUnit
        Me.txtItemUnit.Size = New System.Drawing.Size(262, 64)
        Me.txtItemUnit.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 21)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Item ID:"
        '
        'lblItemID
        '
        Me.lblItemID.AutoSize = True
        Me.lblItemID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemID.ForeColor = System.Drawing.Color.Black
        Me.lblItemID.Location = New System.Drawing.Point(90, 68)
        Me.lblItemID.Name = "lblItemID"
        Me.lblItemID.Size = New System.Drawing.Size(31, 21)
        Me.lblItemID.TabIndex = 12
        Me.lblItemID.Text = "[?]"
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
        Me.btnClear.Location = New System.Drawing.Point(487, 459)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(111, 42)
        Me.btnClear.TabIndex = 8
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
        Me.btnSubmit.Location = New System.Drawing.Point(345, 459)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(107, 42)
        Me.btnSubmit.TabIndex = 7
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'txtItemBrand
        '
        Me.txtItemBrand.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.txtItemBrand.BorderRadius = 10
        Me.txtItemBrand.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtItemBrand.DefaultText = ""
        Me.txtItemBrand.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtItemBrand.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtItemBrand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItemBrand.DisabledState.Parent = Me.txtItemBrand
        Me.txtItemBrand.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtItemBrand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItemBrand.FocusedState.Parent = Me.txtItemBrand
        Me.txtItemBrand.ForeColor = System.Drawing.Color.Black
        Me.txtItemBrand.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItemBrand.HoverState.Parent = Me.txtItemBrand
        Me.txtItemBrand.Location = New System.Drawing.Point(490, 103)
        Me.txtItemBrand.Name = "txtItemBrand"
        Me.txtItemBrand.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtItemBrand.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtItemBrand.PlaceholderText = "Item Brand"
        Me.txtItemBrand.SelectedText = ""
        Me.txtItemBrand.ShadowDecoration.Parent = Me.txtItemBrand
        Me.txtItemBrand.Size = New System.Drawing.Size(359, 64)
        Me.txtItemBrand.TabIndex = 2
        '
        'UserControl_inventory_addinventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Name = "UserControl_inventory_addinventory"
        Me.Size = New System.Drawing.Size(909, 578)
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtItemName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents txtItemQTY As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtItemUnit As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnClear As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSubmit As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents lblItemID As Label
    Friend WithEvents txtItemDescription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtItemCost As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtItemBrand As Guna.UI2.WinForms.Guna2TextBox
End Class
