<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShipped
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
        Me.components = New System.ComponentModel.Container()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.txtUnitsDisplay = New System.Windows.Forms.TextBox()
        Me.AverageUnitsToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.txtUnits = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(27, 251)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 2
        Me.btnEnter.Text = "&Enter"
        Me.AverageUnitsToolTip.SetToolTip(Me.btnEnter, "Calculate the Average Units")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'txtUnitsDisplay
        '
        Me.txtUnitsDisplay.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtUnitsDisplay.Location = New System.Drawing.Point(47, 63)
        Me.txtUnitsDisplay.Multiline = True
        Me.txtUnitsDisplay.Name = "txtUnitsDisplay"
        Me.txtUnitsDisplay.ReadOnly = True
        Me.txtUnitsDisplay.Size = New System.Drawing.Size(221, 140)
        Me.txtUnitsDisplay.TabIndex = 0
        Me.txtUnitsDisplay.TabStop = False
        Me.AverageUnitsToolTip.SetToolTip(Me.txtUnitsDisplay, "Displays Daily Units Shipped")
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(227, 251)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.AverageUnitsToolTip.SetToolTip(Me.btnExit, "Exit the Application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(126, 251)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "&Reset"
        Me.AverageUnitsToolTip.SetToolTip(Me.btnReset, "Reset all values")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Location = New System.Drawing.Point(47, 206)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(221, 23)
        Me.lblOutput.TabIndex = 0
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsToolTip.SetToolTip(Me.lblOutput, "Displays the Calculated Average Units Shipped")
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Location = New System.Drawing.Point(44, 38)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(34, 13)
        Me.lblUnits.TabIndex = 0
        Me.lblUnits.Text = "&Units:"
        '
        'lblDays
        '
        Me.lblDays.AutoSize = True
        Me.lblDays.Location = New System.Drawing.Point(233, 38)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(35, 13)
        Me.lblDays.TabIndex = 0
        Me.lblDays.Text = "Day 1"
        Me.AverageUnitsToolTip.SetToolTip(Me.lblDays, "Day of the Week ")
        '
        'txtUnits
        '
        Me.txtUnits.Location = New System.Drawing.Point(84, 35)
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.Size = New System.Drawing.Size(100, 20)
        Me.txtUnits.TabIndex = 1
        Me.AverageUnitsToolTip.SetToolTip(Me.txtUnits, "Enter the Units Shipped for the adjacent Day displayed")
        '
        'frmAverageUnitsShipped
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(334, 311)
        Me.Controls.Add(Me.txtUnits)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtUnitsDisplay)
        Me.Controls.Add(Me.btnEnter)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(350, 350)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(350, 350)
        Me.Name = "frmAverageUnitsShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnter As Button
    Friend WithEvents AverageUnitsToolTip As ToolTip
    Friend WithEvents txtUnitsDisplay As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblOutput As Label
    Friend WithEvents lblUnits As Label
    Friend WithEvents lblDays As Label
    Friend WithEvents txtUnits As TextBox
End Class
