﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintInventory
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CrystalReportViewer2 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.rptPrintInventory1 = New prjDentrix.rptPrintInventory()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1084, 651)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'CrystalReportViewer2
        '
        Me.CrystalReportViewer2.ActiveViewIndex = 0
        Me.CrystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer2.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer2.Name = "CrystalReportViewer2"
        Me.CrystalReportViewer2.ReportSource = Me.rptPrintInventory1
        Me.CrystalReportViewer2.Size = New System.Drawing.Size(1084, 651)
        Me.CrystalReportViewer2.TabIndex = 1
        '
        'frmPrintInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 651)
        Me.Controls.Add(Me.CrystalReportViewer2)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmPrintInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Inventory"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CrystalReportViewer2 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rptPrintInventory1 As rptPrintInventory
End Class
