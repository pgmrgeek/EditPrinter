<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditPrinter
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
        Me.btnSaveClose = New System.Windows.Forms.Button()
        Me.grpLayout = New System.Windows.Forms.GroupBox()
        Me.lblprtrNameSize = New System.Windows.Forms.Label()
        Me.tbprtrPrinterName = New System.Windows.Forms.TextBox()
        Me.lblprtrProfileName = New System.Windows.Forms.Label()
        Me.tbprtrProfileName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblprtrSeconds = New System.Windows.Forms.Label()
        Me.lblprtrDPI = New System.Windows.Forms.Label()
        Me.lblprtrYres = New System.Windows.Forms.Label()
        Me.lblprtrXres = New System.Windows.Forms.Label()
        Me.tbprtrVertOffset = New System.Windows.Forms.TextBox()
        Me.tbprtrHorzOffset = New System.Windows.Forms.TextBox()
        Me.tbprtrVertPCT = New System.Windows.Forms.TextBox()
        Me.tbprtrHorzPCT = New System.Windows.Forms.TextBox()
        Me.tbprtrSeconds = New System.Windows.Forms.TextBox()
        Me.tbprtrDPI = New System.Windows.Forms.TextBox()
        Me.tbprtrYres = New System.Windows.Forms.TextBox()
        Me.tbprtrXres = New System.Windows.Forms.TextBox()
        Me.gbPrintSize = New System.Windows.Forms.GroupBox()
        Me.rbPrtSiz8x12 = New System.Windows.Forms.RadioButton()
        Me.rbPrtSiz8x10 = New System.Windows.Forms.RadioButton()
        Me.rbPrtSiz6x9 = New System.Windows.Forms.RadioButton()
        Me.rbPrtSiz6x8 = New System.Windows.Forms.RadioButton()
        Me.rbPrtSiz5x7 = New System.Windows.Forms.RadioButton()
        Me.rbPrtSiz4x6 = New System.Windows.Forms.RadioButton()
        Me.rbPrtSiz2x6 = New System.Windows.Forms.RadioButton()
        Me.rbPrtSiz3x5 = New System.Windows.Forms.RadioButton()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.grpLayoutSelect = New System.Windows.Forms.GroupBox()
        Me.btnDNOneRow = New System.Windows.Forms.Button()
        Me.DeleteThisLayout = New System.Windows.Forms.Button()
        Me.btnUpOneRow = New System.Windows.Forms.Button()
        Me.cbLayoutSelected = New System.Windows.Forms.ComboBox()
        Me.NewLayout = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.rbPrtSizGIF = New System.Windows.Forms.RadioButton()
        Me.grpLayout.SuspendLayout()
        Me.gbPrintSize.SuspendLayout()
        Me.grpLayoutSelect.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSaveClose
        '
        Me.btnSaveClose.Location = New System.Drawing.Point(376, 297)
        Me.btnSaveClose.Name = "btnSaveClose"
        Me.btnSaveClose.Size = New System.Drawing.Size(87, 23)
        Me.btnSaveClose.TabIndex = 0
        Me.btnSaveClose.Text = "Save && Close"
        Me.btnSaveClose.UseVisualStyleBackColor = True
        '
        'grpLayout
        '
        Me.grpLayout.Controls.Add(Me.lblprtrNameSize)
        Me.grpLayout.Controls.Add(Me.tbprtrPrinterName)
        Me.grpLayout.Controls.Add(Me.lblprtrProfileName)
        Me.grpLayout.Controls.Add(Me.tbprtrProfileName)
        Me.grpLayout.Controls.Add(Me.Label7)
        Me.grpLayout.Controls.Add(Me.Label6)
        Me.grpLayout.Controls.Add(Me.Label5)
        Me.grpLayout.Controls.Add(Me.Label4)
        Me.grpLayout.Controls.Add(Me.lblprtrSeconds)
        Me.grpLayout.Controls.Add(Me.lblprtrDPI)
        Me.grpLayout.Controls.Add(Me.lblprtrYres)
        Me.grpLayout.Controls.Add(Me.lblprtrXres)
        Me.grpLayout.Controls.Add(Me.tbprtrVertOffset)
        Me.grpLayout.Controls.Add(Me.tbprtrHorzOffset)
        Me.grpLayout.Controls.Add(Me.tbprtrVertPCT)
        Me.grpLayout.Controls.Add(Me.tbprtrHorzPCT)
        Me.grpLayout.Controls.Add(Me.tbprtrSeconds)
        Me.grpLayout.Controls.Add(Me.tbprtrDPI)
        Me.grpLayout.Controls.Add(Me.tbprtrYres)
        Me.grpLayout.Controls.Add(Me.tbprtrXres)
        Me.grpLayout.Controls.Add(Me.gbPrintSize)
        Me.grpLayout.Controls.Add(Me.btnCancel)
        Me.grpLayout.Controls.Add(Me.grpLayoutSelect)
        Me.grpLayout.Controls.Add(Me.btnSave)
        Me.grpLayout.Controls.Add(Me.btnSaveClose)
        Me.grpLayout.Location = New System.Drawing.Point(8, 7)
        Me.grpLayout.Name = "grpLayout"
        Me.grpLayout.Size = New System.Drawing.Size(578, 362)
        Me.grpLayout.TabIndex = 1
        Me.grpLayout.TabStop = False
        Me.grpLayout.Text = "Printer Definition"
        '
        'lblprtrNameSize
        '
        Me.lblprtrNameSize.AutoSize = True
        Me.lblprtrNameSize.Location = New System.Drawing.Point(20, 112)
        Me.lblprtrNameSize.Name = "lblprtrNameSize"
        Me.lblprtrNameSize.Size = New System.Drawing.Size(68, 13)
        Me.lblprtrNameSize.TabIndex = 56
        Me.lblprtrNameSize.Text = "Printer Name"
        '
        'tbprtrPrinterName
        '
        Me.tbprtrPrinterName.Location = New System.Drawing.Point(30, 131)
        Me.tbprtrPrinterName.Name = "tbprtrPrinterName"
        Me.tbprtrPrinterName.Size = New System.Drawing.Size(274, 20)
        Me.tbprtrPrinterName.TabIndex = 55
        '
        'lblprtrProfileName
        '
        Me.lblprtrProfileName.AutoSize = True
        Me.lblprtrProfileName.Location = New System.Drawing.Point(20, 154)
        Me.lblprtrProfileName.Name = "lblprtrProfileName"
        Me.lblprtrProfileName.Size = New System.Drawing.Size(127, 13)
        Me.lblprtrProfileName.TabIndex = 54
        Me.lblprtrProfileName.Text = "Printer Color Profile Name"
        '
        'tbprtrProfileName
        '
        Me.tbprtrProfileName.Location = New System.Drawing.Point(30, 173)
        Me.tbprtrProfileName.Name = "tbprtrProfileName"
        Me.tbprtrProfileName.Size = New System.Drawing.Size(274, 20)
        Me.tbprtrProfileName.TabIndex = 53
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(437, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 13)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "vertical offset by pixel"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(437, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 13)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "horizontal offset by pixels"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(437, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "vertical scaling pct"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(437, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 13)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "horizontal scaling pct"
        '
        'lblprtrSeconds
        '
        Me.lblprtrSeconds.AutoSize = True
        Me.lblprtrSeconds.Location = New System.Drawing.Point(437, 105)
        Me.lblprtrSeconds.Name = "lblprtrSeconds"
        Me.lblprtrSeconds.Size = New System.Drawing.Size(90, 13)
        Me.lblprtrSeconds.TabIndex = 47
        Me.lblprtrSeconds.Text = "Seconds per print"
        '
        'lblprtrDPI
        '
        Me.lblprtrDPI.AutoSize = True
        Me.lblprtrDPI.Location = New System.Drawing.Point(437, 79)
        Me.lblprtrDPI.Name = "lblprtrDPI"
        Me.lblprtrDPI.Size = New System.Drawing.Size(48, 13)
        Me.lblprtrDPI.TabIndex = 46
        Me.lblprtrDPI.Text = "print DPI"
        '
        'lblprtrYres
        '
        Me.lblprtrYres.AutoSize = True
        Me.lblprtrYres.Location = New System.Drawing.Point(437, 53)
        Me.lblprtrYres.Name = "lblprtrYres"
        Me.lblprtrYres.Size = New System.Drawing.Size(100, 13)
        Me.lblprtrYres.TabIndex = 45
        Me.lblprtrYres.Text = "Y resolution (height)"
        '
        'lblprtrXres
        '
        Me.lblprtrXres.AutoSize = True
        Me.lblprtrXres.Location = New System.Drawing.Point(437, 27)
        Me.lblprtrXres.Name = "lblprtrXres"
        Me.lblprtrXres.Size = New System.Drawing.Size(96, 13)
        Me.lblprtrXres.TabIndex = 44
        Me.lblprtrXres.Text = "X resolution (width)"
        '
        'tbprtrVertOffset
        '
        Me.tbprtrVertOffset.Location = New System.Drawing.Point(376, 206)
        Me.tbprtrVertOffset.Name = "tbprtrVertOffset"
        Me.tbprtrVertOffset.Size = New System.Drawing.Size(55, 20)
        Me.tbprtrVertOffset.TabIndex = 43
        '
        'tbprtrHorzOffset
        '
        Me.tbprtrHorzOffset.Location = New System.Drawing.Point(376, 180)
        Me.tbprtrHorzOffset.Name = "tbprtrHorzOffset"
        Me.tbprtrHorzOffset.Size = New System.Drawing.Size(55, 20)
        Me.tbprtrHorzOffset.TabIndex = 42
        '
        'tbprtrVertPCT
        '
        Me.tbprtrVertPCT.Location = New System.Drawing.Point(376, 154)
        Me.tbprtrVertPCT.Name = "tbprtrVertPCT"
        Me.tbprtrVertPCT.Size = New System.Drawing.Size(55, 20)
        Me.tbprtrVertPCT.TabIndex = 40
        '
        'tbprtrHorzPCT
        '
        Me.tbprtrHorzPCT.Location = New System.Drawing.Point(376, 128)
        Me.tbprtrHorzPCT.Name = "tbprtrHorzPCT"
        Me.tbprtrHorzPCT.Size = New System.Drawing.Size(55, 20)
        Me.tbprtrHorzPCT.TabIndex = 39
        '
        'tbprtrSeconds
        '
        Me.tbprtrSeconds.Location = New System.Drawing.Point(376, 102)
        Me.tbprtrSeconds.Name = "tbprtrSeconds"
        Me.tbprtrSeconds.Size = New System.Drawing.Size(55, 20)
        Me.tbprtrSeconds.TabIndex = 38
        '
        'tbprtrDPI
        '
        Me.tbprtrDPI.Location = New System.Drawing.Point(376, 76)
        Me.tbprtrDPI.Name = "tbprtrDPI"
        Me.tbprtrDPI.Size = New System.Drawing.Size(55, 20)
        Me.tbprtrDPI.TabIndex = 37
        '
        'tbprtrYres
        '
        Me.tbprtrYres.Location = New System.Drawing.Point(376, 50)
        Me.tbprtrYres.Name = "tbprtrYres"
        Me.tbprtrYres.Size = New System.Drawing.Size(55, 20)
        Me.tbprtrYres.TabIndex = 36
        '
        'tbprtrXres
        '
        Me.tbprtrXres.Location = New System.Drawing.Point(376, 24)
        Me.tbprtrXres.Name = "tbprtrXres"
        Me.tbprtrXres.Size = New System.Drawing.Size(55, 20)
        Me.tbprtrXres.TabIndex = 35
        '
        'gbPrintSize
        '
        Me.gbPrintSize.Controls.Add(Me.rbPrtSizGIF)
        Me.gbPrintSize.Controls.Add(Me.rbPrtSiz8x12)
        Me.gbPrintSize.Controls.Add(Me.rbPrtSiz8x10)
        Me.gbPrintSize.Controls.Add(Me.rbPrtSiz6x9)
        Me.gbPrintSize.Controls.Add(Me.rbPrtSiz6x8)
        Me.gbPrintSize.Controls.Add(Me.rbPrtSiz5x7)
        Me.gbPrintSize.Controls.Add(Me.rbPrtSiz4x6)
        Me.gbPrintSize.Controls.Add(Me.rbPrtSiz2x6)
        Me.gbPrintSize.Controls.Add(Me.rbPrtSiz3x5)
        Me.gbPrintSize.Location = New System.Drawing.Point(23, 207)
        Me.gbPrintSize.Name = "gbPrintSize"
        Me.gbPrintSize.Size = New System.Drawing.Size(144, 137)
        Me.gbPrintSize.TabIndex = 34
        Me.gbPrintSize.TabStop = False
        Me.gbPrintSize.Text = "What Print Size?"
        '
        'rbPrtSiz8x12
        '
        Me.rbPrtSiz8x12.AutoSize = True
        Me.rbPrtSiz8x12.Location = New System.Drawing.Point(81, 88)
        Me.rbPrtSiz8x12.Name = "rbPrtSiz8x12"
        Me.rbPrtSiz8x12.Size = New System.Drawing.Size(54, 17)
        Me.rbPrtSiz8x12.TabIndex = 7
        Me.rbPrtSiz8x12.TabStop = True
        Me.rbPrtSiz8x12.Text = "8 x 12"
        Me.rbPrtSiz8x12.UseVisualStyleBackColor = True
        '
        'rbPrtSiz8x10
        '
        Me.rbPrtSiz8x10.AutoSize = True
        Me.rbPrtSiz8x10.Location = New System.Drawing.Point(81, 65)
        Me.rbPrtSiz8x10.Name = "rbPrtSiz8x10"
        Me.rbPrtSiz8x10.Size = New System.Drawing.Size(54, 17)
        Me.rbPrtSiz8x10.TabIndex = 6
        Me.rbPrtSiz8x10.TabStop = True
        Me.rbPrtSiz8x10.Text = "8 x 10"
        Me.rbPrtSiz8x10.UseVisualStyleBackColor = True
        '
        'rbPrtSiz6x9
        '
        Me.rbPrtSiz6x9.AutoSize = True
        Me.rbPrtSiz6x9.Location = New System.Drawing.Point(81, 42)
        Me.rbPrtSiz6x9.Name = "rbPrtSiz6x9"
        Me.rbPrtSiz6x9.Size = New System.Drawing.Size(48, 17)
        Me.rbPrtSiz6x9.TabIndex = 5
        Me.rbPrtSiz6x9.TabStop = True
        Me.rbPrtSiz6x9.Text = "6 x 9"
        Me.rbPrtSiz6x9.UseVisualStyleBackColor = True
        '
        'rbPrtSiz6x8
        '
        Me.rbPrtSiz6x8.AutoSize = True
        Me.rbPrtSiz6x8.Location = New System.Drawing.Point(81, 19)
        Me.rbPrtSiz6x8.Name = "rbPrtSiz6x8"
        Me.rbPrtSiz6x8.Size = New System.Drawing.Size(48, 17)
        Me.rbPrtSiz6x8.TabIndex = 4
        Me.rbPrtSiz6x8.TabStop = True
        Me.rbPrtSiz6x8.Text = "6 x 8"
        Me.rbPrtSiz6x8.UseVisualStyleBackColor = True
        '
        'rbPrtSiz5x7
        '
        Me.rbPrtSiz5x7.AutoSize = True
        Me.rbPrtSiz5x7.Location = New System.Drawing.Point(18, 88)
        Me.rbPrtSiz5x7.Name = "rbPrtSiz5x7"
        Me.rbPrtSiz5x7.Size = New System.Drawing.Size(48, 17)
        Me.rbPrtSiz5x7.TabIndex = 3
        Me.rbPrtSiz5x7.TabStop = True
        Me.rbPrtSiz5x7.Text = "5 x 7"
        Me.rbPrtSiz5x7.UseVisualStyleBackColor = True
        '
        'rbPrtSiz4x6
        '
        Me.rbPrtSiz4x6.AutoSize = True
        Me.rbPrtSiz4x6.Location = New System.Drawing.Point(18, 65)
        Me.rbPrtSiz4x6.Name = "rbPrtSiz4x6"
        Me.rbPrtSiz4x6.Size = New System.Drawing.Size(45, 17)
        Me.rbPrtSiz4x6.TabIndex = 2
        Me.rbPrtSiz4x6.TabStop = True
        Me.rbPrtSiz4x6.Text = "4x 6"
        Me.rbPrtSiz4x6.UseVisualStyleBackColor = True
        '
        'rbPrtSiz2x6
        '
        Me.rbPrtSiz2x6.AutoSize = True
        Me.rbPrtSiz2x6.Location = New System.Drawing.Point(18, 42)
        Me.rbPrtSiz2x6.Name = "rbPrtSiz2x6"
        Me.rbPrtSiz2x6.Size = New System.Drawing.Size(48, 17)
        Me.rbPrtSiz2x6.TabIndex = 1
        Me.rbPrtSiz2x6.TabStop = True
        Me.rbPrtSiz2x6.Text = "2 x 6"
        Me.rbPrtSiz2x6.UseVisualStyleBackColor = True
        '
        'rbPrtSiz3x5
        '
        Me.rbPrtSiz3x5.AutoSize = True
        Me.rbPrtSiz3x5.Location = New System.Drawing.Point(18, 19)
        Me.rbPrtSiz3x5.Name = "rbPrtSiz3x5"
        Me.rbPrtSiz3x5.Size = New System.Drawing.Size(57, 17)
        Me.rbPrtSiz3x5.TabIndex = 0
        Me.rbPrtSiz3x5.TabStop = True
        Me.rbPrtSiz3x5.Text = "3.5 x 5"
        Me.rbPrtSiz3x5.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(469, 297)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 33
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'grpLayoutSelect
        '
        Me.grpLayoutSelect.Controls.Add(Me.btnDNOneRow)
        Me.grpLayoutSelect.Controls.Add(Me.DeleteThisLayout)
        Me.grpLayoutSelect.Controls.Add(Me.btnUpOneRow)
        Me.grpLayoutSelect.Controls.Add(Me.cbLayoutSelected)
        Me.grpLayoutSelect.Controls.Add(Me.NewLayout)
        Me.grpLayoutSelect.Location = New System.Drawing.Point(23, 19)
        Me.grpLayoutSelect.Name = "grpLayoutSelect"
        Me.grpLayoutSelect.Size = New System.Drawing.Size(347, 90)
        Me.grpLayoutSelect.TabIndex = 17
        Me.grpLayoutSelect.TabStop = False
        Me.grpLayoutSelect.Text = "Select the Printer Name to edit"
        '
        'btnDNOneRow
        '
        Me.btnDNOneRow.Location = New System.Drawing.Point(301, 22)
        Me.btnDNOneRow.Name = "btnDNOneRow"
        Me.btnDNOneRow.Size = New System.Drawing.Size(19, 22)
        Me.btnDNOneRow.TabIndex = 56
        Me.btnDNOneRow.Text = "v"
        Me.btnDNOneRow.UseVisualStyleBackColor = True
        '
        'DeleteThisLayout
        '
        Me.DeleteThisLayout.Location = New System.Drawing.Point(151, 51)
        Me.DeleteThisLayout.Name = "DeleteThisLayout"
        Me.DeleteThisLayout.Size = New System.Drawing.Size(114, 23)
        Me.DeleteThisLayout.TabIndex = 39
        Me.DeleteThisLayout.Text = "Delete this Print Def"
        Me.DeleteThisLayout.UseVisualStyleBackColor = True
        '
        'btnUpOneRow
        '
        Me.btnUpOneRow.Location = New System.Drawing.Point(280, 22)
        Me.btnUpOneRow.Name = "btnUpOneRow"
        Me.btnUpOneRow.Size = New System.Drawing.Size(19, 22)
        Me.btnUpOneRow.TabIndex = 55
        Me.btnUpOneRow.Text = "^"
        Me.btnUpOneRow.UseVisualStyleBackColor = True
        '
        'cbLayoutSelected
        '
        Me.cbLayoutSelected.FormattingEnabled = True
        Me.cbLayoutSelected.Location = New System.Drawing.Point(6, 23)
        Me.cbLayoutSelected.Name = "cbLayoutSelected"
        Me.cbLayoutSelected.Size = New System.Drawing.Size(268, 21)
        Me.cbLayoutSelected.TabIndex = 2
        '
        'NewLayout
        '
        Me.NewLayout.Location = New System.Drawing.Point(7, 51)
        Me.NewLayout.Name = "NewLayout"
        Me.NewLayout.Size = New System.Drawing.Size(114, 23)
        Me.NewLayout.TabIndex = 35
        Me.NewLayout.Text = "New Print Def"
        Me.NewLayout.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(295, 297)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'rbPrtSizGIF
        '
        Me.rbPrtSizGIF.AutoSize = True
        Me.rbPrtSizGIF.Location = New System.Drawing.Point(44, 111)
        Me.rbPrtSizGIF.Name = "rbPrtSizGIF"
        Me.rbPrtSizGIF.Size = New System.Drawing.Size(42, 17)
        Me.rbPrtSizGIF.TabIndex = 8
        Me.rbPrtSizGIF.TabStop = True
        Me.rbPrtSizGIF.Text = "GIF"
        Me.rbPrtSizGIF.UseVisualStyleBackColor = True
        '
        'EditPrinter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 379)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpLayout)
        Me.Name = "EditPrinter"
        Me.Text = "Edit Printer Definitions"
        Me.grpLayout.ResumeLayout(False)
        Me.grpLayout.PerformLayout()
        Me.gbPrintSize.ResumeLayout(False)
        Me.gbPrintSize.PerformLayout()
        Me.grpLayoutSelect.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSaveClose As System.Windows.Forms.Button
    Friend WithEvents grpLayout As System.Windows.Forms.GroupBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents grpLayoutSelect As System.Windows.Forms.GroupBox
    Friend WithEvents cbLayoutSelected As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents NewLayout As System.Windows.Forms.Button
    Friend WithEvents DeleteThisLayout As System.Windows.Forms.Button
    Friend WithEvents gbPrintSize As System.Windows.Forms.GroupBox
    Friend WithEvents rbPrtSiz8x12 As System.Windows.Forms.RadioButton
    Friend WithEvents rbPrtSiz8x10 As System.Windows.Forms.RadioButton
    Friend WithEvents rbPrtSiz6x9 As System.Windows.Forms.RadioButton
    Friend WithEvents rbPrtSiz6x8 As System.Windows.Forms.RadioButton
    Friend WithEvents rbPrtSiz5x7 As System.Windows.Forms.RadioButton
    Friend WithEvents rbPrtSiz4x6 As System.Windows.Forms.RadioButton
    Friend WithEvents rbPrtSiz2x6 As System.Windows.Forms.RadioButton
    Friend WithEvents rbPrtSiz3x5 As System.Windows.Forms.RadioButton
    Friend WithEvents lblprtrProfileName As System.Windows.Forms.Label
    Friend WithEvents tbprtrProfileName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblprtrSeconds As System.Windows.Forms.Label
    Friend WithEvents lblprtrDPI As System.Windows.Forms.Label
    Friend WithEvents lblprtrYres As System.Windows.Forms.Label
    Friend WithEvents lblprtrXres As System.Windows.Forms.Label
    Friend WithEvents tbprtrVertOffset As System.Windows.Forms.TextBox
    Friend WithEvents tbprtrHorzOffset As System.Windows.Forms.TextBox
    Friend WithEvents tbprtrVertPCT As System.Windows.Forms.TextBox
    Friend WithEvents tbprtrHorzPCT As System.Windows.Forms.TextBox
    Friend WithEvents tbprtrSeconds As System.Windows.Forms.TextBox
    Friend WithEvents tbprtrDPI As System.Windows.Forms.TextBox
    Friend WithEvents tbprtrYres As System.Windows.Forms.TextBox
    Friend WithEvents tbprtrXres As System.Windows.Forms.TextBox
    Friend WithEvents btnDNOneRow As System.Windows.Forms.Button
    Friend WithEvents btnUpOneRow As System.Windows.Forms.Button
    Friend WithEvents lblprtrNameSize As System.Windows.Forms.Label
    Friend WithEvents tbprtrPrinterName As System.Windows.Forms.TextBox
    Friend WithEvents rbPrtSizGIF As System.Windows.Forms.RadioButton

End Class
