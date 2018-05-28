Imports System
Imports System.IO
Imports System.Threading

'====================================================================
'                              PrinterLayout
'====================================================================
'
' Copyright (c) 2017. Bay Area Event Photography. All Rights Reserved.
'
' BETA Release x.xx (A work in progress)
'
'"PrinterLayout.exe" is a Microsoft Visual Studio 2010 Visual Basic .NET
'program that provides a user interface read/write the printer definition file.
'
Public Class EditPrinter

    Private Sub EditPrinter_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.Text = Me.Text & "  " & Globals.Version

        ReadPrinterFile()                       ' load the printer definitions

        Globals.prtrIndex = -1                  ' this layout files maxim

        FormLoadLayout(0)                       ' load the file data into the form fields, first entry

        cbLayoutSelected.Items.Clear()          ' clear it out

        If Globals.prtrMax > 0 Then
            For n = 0 To Globals.prtrMax - 1
                cbLayoutSelected.Items.Add(Globals.prtrName(n))
            Next
            cbLayoutSelected.SelectedIndex = 0
        End if

        Globals.running = True

    End Sub

    '-----------------------====< ReadBKFGFile() >====---------------------------
    ' read in the .CVS file listing all the standard & custom backgrounds/foregrounds
    '
    Private Sub ReadPrinterFile()
        Call _prtrreader("C:\onsite\software\printers.csv")
    End Sub

    '-----------------------====< ReadBKFGFile() >====---------------------------
    ' read in the .CVS file listing all the standard & custom backgrounds/foregrounds
    '
    Private Sub WritePrinterFile()
        Call _prtrwriter("C:\onsite\software\printers.csv")
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs)
        ' save the layout changes
        FormSaveLayout(Globals.prtrIndex)
        WritePrinterFile()
    End Sub

    Private Sub btnSaveClose_Click(sender As System.Object, e As System.EventArgs)
        'save all changes, and return to open dialog
        FormSaveLayout(Globals.prtrIndex)
        WritePrinterFile()
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs)
        Me.Hide()
    End Sub

    Private Sub NewRowButton_Click(sender As System.Object, e As System.EventArgs)
        Dim cc As Integer = 0
        'Dim dnum As Integer
        Dim newNam As String

        ' Prompt the user for a new name
        ' add the new name
        newNam = "Enter printer name/print size"

        ' add to the bottom of the list
        cbLayoutSelected.Items.Add(newNam)

        ' create a new data for this entry
        setupdefaultprinter(newNam, cbLayoutSelected.Items.Count() - 1)

        ' add one to the array of data
        Globals.prtrMax = cbLayoutSelected.Items.Count

        ' point to the new entry
        Globals.prtrIndex = cbLayoutSelected.Items.Count - 1

        ' load the new data into the form instance data
        FormLoadLayout(Globals.prtrIndex)

        ' point the list at the new entry
        cbLayoutSelected.SelectedIndex = Globals.prtrIndex

    End Sub

    Private Sub DeleteThisLayout_Click(sender As System.Object, e As System.EventArgs) Handles DeleteThisLayout.Click
        Dim cc As MsgBoxResult
        Dim runstate As Boolean

        ' cant delete the one last entry..
        If Globals.prtrMax = 1 Then
            MsgBox("Minimum of one printer needed.")
            Return
        End If

        ' verify this is okay
        cc = MsgBox("Are you sure you want to delete """ + cbLayoutSelected.Text + "?""", MsgBoxStyle.OkCancel, "Delete this Print Def?")

        ' 1 is okay!
        If cc = 1 Then

            ' pause the change states while we reorder things
            runstate = Globals.running
            Globals.running = False

            ' kill the entry in the combo box
            cbLayoutSelected.Items.RemoveAt(cbLayoutSelected.SelectedIndex)
            ' point to the first layout to keep things simple
            cbLayoutSelected.SelectedIndex = 0

            ' copy the array back overwritting one entry
            For i = Globals.prtrIndex To Globals.prtrMax - 1

                Globals.prtrName(i) = Globals.prtrName(i + 1)               ' arrCurrentRow(0)
                Globals.prtrPrtSize(i) = Globals.prtrPrtSize(i + 1)         ' arrCurrentRow(1)
                Globals.prtrXres(i) = Globals.prtrXres(i + 1)               ' arrCurrentRow(2)
                Globals.prtrYres(i) = Globals.prtrYres(i + 1)               ' arrCurrentRow(3)
                Globals.prtrDPI(i) = Globals.prtrDPI(i + 1)                 ' arrCurrentRow(4)
                Globals.prtrProfile(i) = Globals.prtrProfile(i + 1)         ' arrCurrentRow(5)
                Globals.prtrRatio(i) = Globals.prtrRatio(i + 1)             ' arrCurrentRow(6)
                Globals.prtrSeconds(i) = Globals.prtrSeconds(i + 1)         ' arrCurrentRow(7)
                Globals.prtrHorzPCT(i) = Globals.prtrHorzPCT(i + 1)         ' arrCurrentRow(8)
                Globals.prtrVertPCT(i) = Globals.prtrVertPCT(i + 1)         ' arrCurrentRow(9)
                Globals.prtrHorzOffset(i) = Globals.prtrHorzOffset(i + 1)   ' arrCurrentRow(10)
                Globals.prtrVertOffset(i) = Globals.prtrVertOffset(i + 1)   ' arrCurrentRow(11)
                Globals.prtrStartupSecs(i) = Globals.prtrStartupSecs(i + 1) ' arrCurrentRow(12)
                Globals.prtrbestXres(i) = Globals.prtrbestXres(i + 1)       ' arrCurrentRow(13)
                Globals.prtrbestYres(i) = Globals.prtrbestYres(i + 1)       ' arrCurrentRow(14)

            Next

            ' point to the first entry
            Globals.prtrIndex = 0
            Globals.prtrMax -= 1

            ' now load the next item in the form
            FormLoadLayout(Globals.prtrIndex)

            Globals.running = runstate

        End If

    End Sub

    Private Sub btnSave_Click_1(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        FormSaveLayout(Globals.prtrIndex)
        WritePrinterFile()          ' save the changes
    End Sub

    Private Sub btnSaveClose_Click_1(sender As System.Object, e As System.EventArgs) Handles btnSaveClose.Click
        FormSaveLayout(Globals.prtrIndex)
        Globals.CompletionCode = 0
        Globals.running = False
        WritePrinterFile()          ' save the changes
        Globals.CompletionCode = 1
        Globals.running = False
        Me.Close()
    End Sub

    Private Sub btnCancel_Click_1(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Globals.CompletionCode = 1
        Globals.running = False
        Me.Close()
    End Sub

    Private Sub cbLayoutSelected_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbLayoutSelected.SelectedIndexChanged
        Static Dim sema As Integer = -1

        sema += 1
        If sema = 0 Then

            If Globals.running Then

                ' selected layout is changing, so save the changes back to the globals

                If Globals.prtrIndex > -1 Then

                    ' save the last name
                    FormSaveLayout(Globals.prtrIndex)
                    Globals.prtrName(Globals.prtrIndex) = tbprtrPrinterName.Text

                End If

                ' load the globals for the new selected index
                FormLoadLayout(cbLayoutSelected.SelectedIndex)

            End If

        End If
        sema -= 1

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbprtrPrinterName.TextChanged
        'Dim str As String
        If Globals.running Then
            cbLayoutSelected.Items(cbLayoutSelected.SelectedIndex) = tbprtrPrinterName.Text
        End If
        ' Str = tbprtrPrinterName.Text
    End Sub

    Private Sub NewLayout_Click(sender As System.Object, e As System.EventArgs) Handles NewLayout.Click
        If Globals.prtrMax < 255 Then

            ' add space to the array, add a string to the combo box
            Globals.prtrMax += 1
            setupdefaultprinter("enter name & print size", Globals.prtrMax - 1)
            FormLoadLayout(Globals.prtrMax - 1)
            cbLayoutSelected.Items.Add("enter name & print size")
            cbLayoutSelected.SelectedIndex = Globals.prtrMax - 1

        End If
    End Sub

    Private Sub btnUpOneRow_Click(sender As System.Object, e As System.EventArgs) Handles btnUpOneRow.Click

        If (Globals.prtrIndex > 0) Then
            FormSaveLayout(Globals.prtrIndex)
            _swapPrinterArrayRows(Globals.prtrIndex - 1, Globals.prtrIndex)
            Globals.prtrIndex -= 1
            FormLoadLayout(Globals.prtrIndex)
            _reloadNameCombobox()
            cbLayoutSelected.SelectedIndex = Globals.prtrIndex
        End If

    End Sub

    Private Sub btnDNOneRow_Click(sender As System.Object, e As System.EventArgs) Handles btnDNOneRow.Click

        If ((Globals.prtrIndex + 1) < Globals.prtrMax) Then
            FormSaveLayout(Globals.prtrIndex)
            _swapPrinterArrayRows(Globals.prtrIndex, Globals.prtrIndex + 1)
            Globals.prtrIndex += 1
            FormLoadLayout(Globals.prtrIndex)
            _reloadNameCombobox()
            cbLayoutSelected.SelectedIndex = Globals.prtrIndex
        End If

    End Sub

    Private Sub _reloadNameCombobox()
        Dim n As Integer
        Dim isrunning As Boolean

        ' temporarily suspend the running to avoid a bunch of overhead
        isrunning = Globals.running
        Globals.running = False

        ' clear the array then reload it
        cbLayoutSelected.Items.Clear()
        For n = 0 To Globals.prtrMax - 1
            cbLayoutSelected.Items.Add(Globals.prtrName(n))
        Next

        Globals.running = isrunning

    End Sub
    Private Sub _swapPrinterArrayRows(row1 As Integer, row2 As Integer)
        Dim s As String
        Dim i As Integer

        s = Globals.prtrName(row1)
        Globals.prtrName(row1) = Globals.prtrName(row2)
        Globals.prtrName(row2) = s

        i = Globals.prtrPrtSize(row1)
        Globals.prtrPrtSize(row1) = Globals.prtrPrtSize(row2)
        Globals.prtrPrtSize(row2) = i

        i = Globals.prtrXres(row1)
        Globals.prtrXres(row1) = Globals.prtrXres(row2)
        Globals.prtrXres(row2) = i

        i = Globals.prtrYres(row1)
        Globals.prtrYres(row1) = Globals.prtrYres(row2)
        Globals.prtrYres(row2) = i

        i = Globals.prtrDPI(row1)
        Globals.prtrDPI(row1) = Globals.prtrDPI(row2)
        Globals.prtrDPI(row2) = i

        s = Globals.prtrProfile(row1)
        Globals.prtrProfile(row1) = Globals.prtrProfile(row2)
        Globals.prtrProfile(row2) = s

        i = Globals.prtrRatio(row1)
        Globals.prtrRatio(row1) = Globals.prtrRatio(row2)
        Globals.prtrRatio(row2) = i

        i = Globals.prtrSeconds(row1)
        Globals.prtrSeconds(row1) = Globals.prtrSeconds(row2)
        Globals.prtrSeconds(row2) = i

        i = Globals.prtrHorzPCT(row1)
        Globals.prtrHorzPCT(row1) = Globals.prtrHorzPCT(row2)
        Globals.prtrHorzPCT(row2) = i

        i = Globals.prtrVertPCT(row1)
        Globals.prtrVertPCT(row1) = Globals.prtrVertPCT(row2)
        Globals.prtrVertPCT(row2) = i

        i = Globals.prtrHorzOffset(row1)
        Globals.prtrHorzOffset(row1) = Globals.prtrHorzOffset(row2)
        Globals.prtrHorzOffset(row2) = i

        i = Globals.prtrVertOffset(row1)
        Globals.prtrVertOffset(row1) = Globals.prtrVertOffset(row2)
        Globals.prtrVertOffset(row2) = i

        i = Globals.prtrStartupSecs(row1)
        Globals.prtrStartupSecs(row1) = Globals.prtrStartupSecs(row2)
        Globals.prtrStartupSecs(row2) = i

        i = Globals.prtrbestXres(row1)
        Globals.prtrbestXres(row1) = Globals.prtrbestXres(row2)
        Globals.prtrbestXres(row2) = i

        i = Globals.prtrbestYres(row1)
        Globals.prtrbestYres(row1) = Globals.prtrbestYres(row2)
        Globals.prtrbestYres(row2) = i

    End Sub

    Private Sub _prtrreader(ByRef fname As String)
        Dim str As String
        Dim quot As String = Chr(34)

        Dim ioReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(fname)

        ioReader.TextFieldType = FileIO.FieldType.Delimited
        ioReader.SetDelimiters(",")

        Globals.prtrMax = 0
        Globals.cmtMaxCount = 0

        While Not ioReader.EndOfData

            Dim arrCurrentRow As String() = ioReader.ReadFields()

            str = arrCurrentRow(0)

            ' save comments to be rewritten at the start of the file
            If Microsoft.VisualBasic.Left(str, 1) = ":" Then
                Globals.cmtStrings(Globals.cmtMaxCount) = str
                Globals.cmtMaxCount += 1
            Else

                If Microsoft.VisualBasic.Len(str) > 1 Then      ' avoid cr/lf blank lines

                    ' load all the variable to make this layout work
                    Globals.prtrName(Globals.prtrMax) = arrCurrentRow(0)
                    Globals.prtrPrtSize(Globals.prtrMax) = arrCurrentRow(1)

                    Globals.prtrXres(Globals.prtrMax) = arrCurrentRow(2)
                    Globals.prtrYres(Globals.prtrMax) = arrCurrentRow(3)
                    Globals.prtrbestXres(Globals.prtrMax) = Globals.prtrXres(Globals.prtrMax)
                    Globals.prtrbestYres(Globals.prtrMax) = Globals.prtrYres(Globals.prtrMax)

                    Globals.prtrDPI(Globals.prtrMax) = arrCurrentRow(4)
                    Globals.prtrProfile(Globals.prtrMax) = arrCurrentRow(5)
                    Globals.prtrRatio(Globals.prtrMax) = arrCurrentRow(6)
                    Globals.prtrSeconds(Globals.prtrMax) = arrCurrentRow(7)
                    Globals.prtrHorzPCT(Globals.prtrMax) = arrCurrentRow(8)
                    Globals.prtrVertPCT(Globals.prtrMax) = arrCurrentRow(9)
                    Globals.prtrHorzOffset(Globals.prtrMax) = arrCurrentRow(10)
                    Globals.prtrVertOffset(Globals.prtrMax) = arrCurrentRow(11)

                    If arrCurrentRow.Count > 12 Then
                        Globals.prtrStartupSecs(Globals.prtrMax) = arrCurrentRow(12)
                    End If

                    ' additional data with extended layout - bestX,BestY,unused,unused
                    If arrCurrentRow.Count > 13 Then
                        Globals.prtrbestXres(Globals.prtrMax) = arrCurrentRow(13)
                        Globals.prtrbestYres(Globals.prtrMax) = arrCurrentRow(14)
                    End If

                    cbLayoutSelected.Items.Add(Globals.prtrName(Globals.prtrMax))

                    If Globals.prtrProfile(Globals.prtrMax) = "-" Then
                        Globals.prtrProfile(Globals.prtrMax) = "none"
                    End If

                    Globals.prtrMax += 1

                End If

                End If

        End While

        ioReader.Close()

    End Sub

    Private Sub _prtrwriter(ByRef fname As String)
        Dim i As Integer
        Dim str As String
        Dim profile As String
        Dim s As String
        Dim quot As String = Chr(34)
        Dim quotc As String = Chr(34) + ","
        Dim file = My.Computer.FileSystem.OpenTextFileWriter(fname, False)

        If Globals.prtrMax > 0 Then

            ' write out the comments

            If Globals.cmtMaxCount > 0 Then

                For i = 0 To Globals.cmtMaxCount - 1
                    If Globals.cmtStrings(i).Length > 0 Then
                        file.WriteLine(quot + Globals.cmtStrings(i) + quot)
                    Else
                        MsgBox("skipping " + quot + Globals.cmtStrings(i) + quot)
                    End If
                Next

            End If

            ' now, write out each line item
            For i = 0 To Globals.prtrMax - 1

                profile = Globals.prtrProfile(i)
                str = Globals.prtrProfile(i).ToLower
                If str.Substring(0, 4) = "none" Then
                    profile = "-"
                End If

                'file.WriteLine("Here is the first string.")

                s = quot + Globals.prtrName(i) + quotc                      ' arrCurrentRow(0)
                s = s + quot + Globals.prtrPrtSize(i).ToString + quotc      ' arrCurrentRow(1)
                s = s + quot + Globals.prtrXres(i).ToString + quotc         ' arrCurrentRow(2)
                s = s + Globals.prtrYres(i).ToString + ","                  ' arrCurrentRow(3)
                s = s + Globals.prtrDPI(i).ToString + ","                   ' arrCurrentRow(4)
                s = s + quot + profile + quotc                              ' arrCurrentRow(5)
                s = s + Globals.prtrRatio(i).ToString + ","                 ' arrCurrentRow(6)
                s = s + Globals.prtrSeconds(i).ToString + ","               ' arrCurrentRow(7)
                s = s + Globals.prtrHorzPCT(i).ToString + ","               ' arrCurrentRow(8)
                s = s + Globals.prtrVertPCT(i).ToString + ","               ' arrCurrentRow(9)
                s = s + Globals.prtrHorzOffset(i).ToString + ","            ' arrCurrentRow(10)
                s = s + Globals.prtrVertOffset(i).ToString + ","            ' arrCurrentRow(11)
                s = s + Globals.prtrStartupSecs(i).ToString + ","           ' arrCurrentRow(12)
                s = s + Globals.prtrbestXres(i).ToString + ","              ' arrCurrentRow(13)
                s = s + Globals.prtrbestYres(i).ToString + ",0,0"           ' arrCurrentRow(14),(15),(16)
                file.WriteLine(s)

            Next

            ' increment the layout string array index to the next entry
            'Globals.bkFgStrMax += 1         ' Move to next row of string array FIX: max is 256

            file.Close()

        End If

    End Sub

    Private Sub setupdefaultprinter(nam As String, index As Integer)

        ' this sets up a default bkg/fg layout set.  Hopefully, set '000' is intalled..

        Globals.prtrName(index) = nam

        Globals.prtrPrtSize(index) = 3    ' 4x6
        Globals.prtrXres(index) = 1800    ' X res
        Globals.prtrYres(index) = 1200    ' Y res
        Globals.prtrDPI(index) = 300
        Globals.prtrProfile(index) = "none"
        Globals.prtrRatio(index) = 8      ' 0x1000
        Globals.prtrSeconds(index) = 8
        Globals.prtrHorzPCT(index) = 100
        Globals.prtrVertPCT(index) = 100
        Globals.prtrHorzOffset(index) = 0
        Globals.prtrVertOffset(index) = 0
        Globals.prtrStartupSecs(index) = 5
        Globals.prtrbestXres(index) = 1800    ' X res
        Globals.prtrbestYres(index) = 1200    ' Y res

    End Sub

    ' 
    ' load the printer array data into the form variables
    '
    Private Sub FormLoadLayout(ByVal index As Integer)

        Globals.prtrIndex = index

        If Globals.prtrPrtSize(index) = 1 Then
            rbPrtSiz3x5.Checked = True
        End If
        If Globals.prtrPrtSize(index) = 2 Then
            rbPrtSiz2x6.Checked = True
        End If
        If Globals.prtrPrtSize(index) = 3 Then
            rbPrtSiz4x6.Checked = True
        End If
        If Globals.prtrPrtSize(index) = 4 Then
            rbPrtSiz5x7.Checked = True
        End If
        If Globals.prtrPrtSize(index) = 5 Then
            rbPrtSiz6x8.Checked = True
        End If
        If Globals.prtrPrtSize(index) = 6 Then
            rbPrtSiz6x9.Checked = True
        End If
        If Globals.prtrPrtSize(index) = 7 Then
            rbPrtSiz8x10.Checked = True
        End If
        If Globals.prtrPrtSize(index) = 8 Then
            rbPrtSiz8x12.Checked = True
        End If
        If Globals.prtrPrtSize(index) = 9 Then
            rbPrtSizGIF.Checked = True
        End If
        If Globals.prtrPrtSize(index) = 10 Then
            rbPrtSizGIF.Checked = True
        End If
        If Globals.prtrPrtSize(index) = 11 Then
            rbPrtSizGIF.Checked = True
        End If
        If Globals.prtrPrtSize(index) = 12 Then
            rbPrtSizGIF.Checked = True
        End If
        If Globals.prtrPrtSize(index) = 13 Then
            rbPrtSizGIF.Checked = True
        End If

        tbprtrPrinterName.Text = Globals.prtrName(index)
        tbprtrXres.Text = Globals.prtrXres(index)
        tbprtrYres.Text = Globals.prtrYres(index)
        tbprtrDPI.Text = Globals.prtrDPI(index)
        tbprtrProfileName.Text = Globals.prtrProfile(index)
        tbprtrSeconds.Text = Globals.prtrSeconds(index)
        tbprtrHorzPCT.Text = Globals.prtrHorzPCT(index)
        tbprtrVertPCT.Text = Globals.prtrVertPCT(index)
        tbprtrHorzOffset.Text = Globals.prtrHorzOffset(index)
        tbprtrVertOffset.Text = Globals.prtrVertOffset(index)
        tbprtrStartupSecs.Text = Globals.prtrStartupSecs(index)
        tbBestFitX.Text = Globals.prtrbestXres(index)
        tbBestFitY.Text = Globals.prtrbestYres(index)

    End Sub

    Private Sub FormSaveLayout(ByVal index As Integer)

        'Globals.BkFgIndex = index
        Globals.prtrName(index) = cbLayoutSelected.Text

        If rbPrtSiz3x5.Checked = True Then
            Globals.prtrPrtSize(index) = 1
            Globals.prtrRatio(index) = 4
        End If
        If rbPrtSiz2x6.Checked = True Then
            Globals.prtrPrtSize(index) = 2
            Globals.prtrRatio(index) = 16
        End If
        If rbPrtSiz4x6.Checked = True Then
            Globals.prtrPrtSize(index) = 3
            Globals.prtrRatio(index) = 8
        End If
        If rbPrtSiz5x7.Checked = True Then
            Globals.prtrPrtSize(index) = 4
            Globals.prtrRatio(index) = 4
        End If
        If rbPrtSiz6x8.Checked = True Then
            Globals.prtrPrtSize(index) = 5
            Globals.prtrRatio(index) = 2
        End If
        If rbPrtSiz6x9.Checked = True Then
            Globals.prtrPrtSize(index) = 6
            Globals.prtrRatio(index) = 8
        End If
        If rbPrtSiz8x10.Checked = True Then
            Globals.prtrPrtSize(index) = 7
            Globals.prtrRatio(index) = 1
        End If
        If rbPrtSiz8x12.Checked = True Then
            Globals.prtrPrtSize(index) = 8
            Globals.prtrRatio(index) = 8
        End If
        If rbPrtSizGIF.Checked = True Then
            If Globals.prtrPrtSize(index) = 9 Then
                Globals.prtrRatio(index) = 8
            End If
            If Globals.prtrPrtSize(index) = 10 Then
                Globals.prtrRatio(index) = 8
            End If
            If Globals.prtrPrtSize(index) = 11 Then
                Globals.prtrRatio(index) = 2
            End If
            If Globals.prtrPrtSize(index) = 12 Then
                Globals.prtrRatio(index) = 2
            End If
            If Globals.prtrPrtSize(index) = 13 Then
                Globals.prtrRatio(index) = 2
            End If
        End If

        Globals.prtrName(index) = tbprtrPrinterName.Text
        Globals.prtrXres(index) = tbprtrXres.Text
        Globals.prtrYres(index) = tbprtrYres.Text
        Globals.prtrDPI(index) = tbprtrDPI.Text
        Globals.prtrProfile(index) = tbprtrProfileName.Text
        Globals.prtrSeconds(index) = tbprtrSeconds.Text
        Globals.prtrHorzPCT(index) = tbprtrHorzPCT.Text
        Globals.prtrVertPCT(index) = tbprtrVertPCT.Text
        Globals.prtrHorzOffset(index) = tbprtrHorzOffset.Text
        Globals.prtrVertOffset(index) = tbprtrVertOffset.Text
        Globals.prtrStartupSecs(index) = tbprtrStartupSecs.Text
        Globals.prtrbestXres(index) = tbBestFitX.Text
        Globals.prtrbestYres(index) = tbBestFitY.Text

    End Sub

    Private Sub tbprtrHorzPCT_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbprtrHorzPCT.TextChanged

    End Sub

    Private Sub grpLayout_Enter(sender As System.Object, e As System.EventArgs) Handles grpLayout.Enter

    End Sub
End Class


' ============================================= DATA =================================================

Public Class Globals

    Public Shared Version As String = "Version 1.00"    ' Version string

    ' the form instances
    'Public Shared fOpenLayout As OpenLayout
    Public Shared fEditPrinter As EditPrinter
    'Public Shared fNewLayout As NewLayout

    ' Array of bk/fg layouts for the user to select from
    Public Shared prtrStrings(256) As String        ' holds all strings from the layout file
    Public Shared prtrStrMax As Integer = 0         ' max count of the string array

    Public Shared LayoutFileName As String          ' name of the file we're editing
    Public Shared prtrAllLayoutsIndex = 0           ' layout file index to specfic layout
    Public Shared prtrIndex As Int16 = 0            ' what entry we're working on right now
    Public Shared prtrMax As Int16 = 0              ' max counter for these arrays
    Public Shared prtrName(256) As String           ' name of the layout
    Public Shared prtrPrtSize(256) As Integer       ' Print size:
    '                                                   1 = 3.5x5 
    '                                                   2 = 2x6
    '                                                   3 = 4x6
    '                                                   4 = 5x7
    '                                                   5 = 6x8 
    '                                                   6 = 6x9 
    '                                                   7 = 8x10 
    '                                                   8 = 8x12 
    '                                                   9 = 480x320 
    '                                                   10 = 640x427(3x2) 
    '                                                   11 = 640x480
    '                                                   12 = 800x600
    '                                                   13 = 1024x768
    Public Shared prtrXres(256) As Integer           ' long size, typically width
    Public Shared prtrYres(256) As Integer           ' short side, typically height
    Public Shared prtrDPI(256) As Integer            ' print DPI for this printer
    Public Shared prtrProfile(256) As String         ' Color Profile name from MFG, must be installed
    Public Shared prtrRatio(256) As Int16            ' ratio supported - see below
    Public Shared prtrSeconds(256) As Integer        ' seconds per print
    Public Shared prtrHorzPCT(256) As Integer        ' horizontal scale-to percentage
    Public Shared prtrVertPCT(256) As Integer        ' vertical scale-to percentage
    Public Shared prtrHorzOffset(256) As Integer     ' horizontal offset by X pixels
    Public Shared prtrVertOffset(256) As Integer     ' vertical offset by X pixels
    Public Shared prtrStartupSecs(256) As Integer    ' Startup Seconds
    Public Shared prtrbestXres(256) As Integer       ' best fit width
    Public Shared prtrbestYres(256) As Integer       ' best fit height

    'Public Shared prtrSetName(256) As String        ' action set name
    'Public Shared prtrFolder(256) As String         ' top level layout folder name such as '000'
    'Public Shared BkFgGifLayers(256) As Integer     ' number of image layers required by the gif
    'Public Shared BkFgCustLayers(256) As Integer    ' number of image layers required by the print
    'Public Shared BkFgFGSelect(256) As Int16        ' uses foreground? -1 leave alone, 0=unchecked, 1=checked 
    'Public Shared BkFgBKSelect(256) As Int16        ' uses background? -1 leave alone, 0=unchecked, 1=checked
    'Public Shared BkFgMultLayers(256) As Int16      ' enable multiple bk/fg selection? -1 leave alone, 0=unchecked, 1=checked
    'Public Shared BkFgImage1Bk(256) As Int16        ' 1 must always have one layout
    'Public Shared BkFgImage2Bk(256) As Int16        ' 2 if there is a 2nd layout, -1 = not used 
    'Public Shared BkFgImage3Bk(256) As Int16        ' 3 if there is a 3rd layout, -1 = not used 
    'Public Shared BkFgImage4Bk(256) As Int16        ' 4 if there is a 4th layout, -1 = not used 
    'Public Shared BkFgAnimated(256) As Int16        ' Bk/Fg files are used as animation layers, 0=false,1=true
    'Public Shared BkFgGIFDelay(256) As Int16        ' GIF needs delay at end
    '
    Public Shared cmtMaxCount As Integer             ' comment strings read from the printer file
    Public Shared cmtStrings(256) As String          ' number of comments saved

    Public Shared CompletionCode As Integer
    Public Shared running As Boolean

End Class



