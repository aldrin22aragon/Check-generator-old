Imports System.Data.SQLite
Imports System.Drawing.Printing
Imports System.IO

Public Class Form1

   Dim dDate As Date = Nothing
   Private ChequePrinter As ChequePrinter

   'Public Class CodeInf
   '    Public Code As String
   '    Public CheckType As String

   '    Sub New(_code As String, _checkType As Integer)
   '        Code = _code
   '        CheckType = _checkType
   '    End Sub 
   '    Public Overrides Function ToString() As String
   '        Return Code
   '    End Function
   'End Class

   Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
      Select Case e.KeyCode
         Case Keys.Add
            btnZin.PerformClick()
         Case Keys.Subtract
            btnZout.PerformClick()
      End Select
   End Sub
   Sub New()

      ' This call is required by the designer.
      InitializeComponent()

      ' Add any initialization after the InitializeComponent() call.

   End Sub
   Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      '   Dim codes As String() = {"CTJ", "CTR", "CTU", "CSI1", "CSI2", "CSI3", "CSI5", "DLI", "MTU", "MPF1", "MPF2", "UBU", "ULA", "ULF", "ULI", "ULU", "SFI"}
      Me.Text = Application.ProductName & " v" & Application.ProductVersion

      Dim bin As String = New DirectoryInfo(Application.StartupPath).Parent.FullName
      If Not Directory.Exists(bin & "\DB") Then
         MessageBox.Show("DB Folder not found.", "Directory not found", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If
      'Directory.CreateDirectory("DB")
      Constr = "Datasource=" & bin & "\DB\PrintDb.db"

      Using sqlcon As New SQLite.SQLiteConnection(Constr)
         sqlcon.Open()
         Dim paycom As New SQLiteCommand()
         Dim payread As SQLite.SQLiteDataReader

         paycom = New SQLiteCommand(CodeInf.ToGetCodeList, sqlcon)
         payread = paycom.ExecuteReader
         While payread.Read
            cbChequeCodes.Items.Add(New CodeInf(payread.Item(1).ToString, payread.Item("CheckType").ToString))
         End While
      End Using


      'cmbCodes.DataSource = codes
      cbChequeCodes.SelectedItem = Nothing
      LoadAutoComp()

      ChequePrinter = New ChequePrinter()


   End Sub

   Private Sub printEndorsement_PrintPage(sender As Object, e As PrintPageEventArgs) Handles printEndorsement.PrintPage
      Dim yadjuster As Integer = -("0" & tbYAxisAdjustment.Text)
      Dim xadjuster As Integer = ("0" & tbXAxisAdjustment.Text)

      Font = New Font("Arial", 9)
      e.PageSettings.Landscape = True
      e.Graphics.DrawString(txtEndorsement.Text, Font, Brushes.Black, 20 + xadjuster, 20)
   End Sub

   Private Sub btnPrintEndorsement_Click(sender As Object, e As EventArgs) Handles btnPrintEndorsement.Click
      If ValidateEndorsement() Then
         If PrintDialog1.ShowDialog = DialogResult.OK Then
            printEndorsement.PrinterSettings = PrintDialog1.PrinterSettings
            printEndorsement.PrinterSettings.DefaultPageSettings.Margins = New Printing.Margins(0, 0, 0, 0)
            printEndorsement.DefaultPageSettings.Landscape = False
            printEndorsement.Print()
         End If
      End If
   End Sub

   Private Sub btnPreviewEndorsement_Click(sender As Object, e As EventArgs) Handles btnPreviewEndorsement.Click
      If ValidateEndorsement() Then
         printEndorsement.PrinterSettings.DefaultPageSettings.Margins = New Printing.Margins(0, 0, 0, 0)
         printEndorsement.DefaultPageSettings.Landscape = False
         PrintPreview.Document = printEndorsement
         PrintPreview.InvalidatePreview()
      End If
   End Sub


   'Private Sub printCheque_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
   '   Dim font As Font = New Drawing.Font("Arial", 11)

   '   'e.PageSettings.Landscape = True
   '   dDate = dtChequeDate.Text

   '   Dim yadjuster As Integer = -("0" & tbYAxisAdjustment.Text)
   '   Dim xadjuster As Integer = ("0" & tbXAxisAdjustment.Text)

   '   Dim code As CodeInf = DirectCast(cbChequeCodes.SelectedItem, CodeInf)


   '   Dim spaceWidth As Integer = 700
   '   e.PageSettings.Landscape = True
   '   e.PageSettings.Margins = New Printing.Margins(0, 0, 0, 0)
   '   dDate = dtChequeDate.Text

   '   Dim payee1 As String = tbPayee1.Text.Trim
   '   Dim payee2 As String = tbPayee2.Text.Trim
   '   'agay
   '   Dim amount As String = "**" & FormatCurrency("0" & tbAmount.Text.Trim).Replace("$", "") & "**"

   '   Dim payee1X As Integer = (spaceWidth - getStrWidth(payee1.ToUpper, font, e)) / 2
   '   Dim payee2X As Integer = (spaceWidth - getStrWidth(payee2, font, e)) / 2

   '   If amount.Length > 0 Then
   '      Dim cents As String() = Nothing
   '      If amount.Contains(".") Then
   '         cents = amount.Split(".")
   '      End If
   '      If Val(amount) > 0 Then
   '         tbAmountInWords.Text = " **" & ChequeModelExtension.AmountInWords(amount) & " & " & cents(1) & "/100 ONLY**"
   '      End If
   '   Else
   '      tbAmountInWords.Text = ""
   '   End If


   '   If code.CheckType = 1 Then
   '      If chbHasChequeDate.Checked Then
   '         e.Graphics.DrawString(Format(CDate(dDate), "MMMM dd, yyyy"), font, Brushes.Black, 570, 590 + yadjuster)
   '      End If
   '      If payee2.Length > 0 Then
   '         e.Graphics.DrawString(payee1.ToUpper, font, Brushes.Black, payee1X, 605 + yadjuster)
   '         e.Graphics.DrawString(payee2, font, Brushes.Black, payee2X, 620 + yadjuster)
   '      Else
   '         e.Graphics.DrawString(payee1.ToUpper, font, Brushes.Black, payee1X, 620 + yadjuster)
   '      End If
   '      'Amount
   '      If Val(tbAmount.Text) > 0 Then
   '         e.Graphics.DrawString(amount, font, Brushes.Black, 595, 618 + yadjuster)
   '      End If
   '      e.Graphics.DrawString(tbAmountInWords.Text, font, Brushes.Black, 90, 645 + yadjuster)
   '   ElseIf code.CheckType = 2 Then 'cmbCodes.SelectedItem = "ULU" Then
   '      If chbHasChequeDate.Checked Then
   '         e.Graphics.DrawString(Format(CDate(dDate), "MMMM dd, yyyy"), font, Brushes.Black, 600, 590 + yadjuster)
   '      End If
   '      If payee2.Length > 0 Then
   '         e.Graphics.DrawString(payee1.ToUpper, font, Brushes.Black, payee1X, 605 + yadjuster)
   '         e.Graphics.DrawString(payee2, font, Brushes.Black, payee2X, 620 + yadjuster)
   '      Else
   '         e.Graphics.DrawString(payee1.ToUpper, font, Brushes.Black, payee1X, 620 + yadjuster)
   '      End If
   '      'Amount
   '      If Val(tbAmount.Text) > 0 Then
   '         e.Graphics.DrawString(amount, font, Brushes.Black, 600, 618 + yadjuster)
   '      End If
   '      e.Graphics.DrawString(tbAmountInWords.Text, font, Brushes.Black, 90, 645 + yadjuster)
   '   ElseIf code.CheckType = 3 Then 'cmbCodes.SelectedItem = "CTR" Or cmbCodes.SelectedItem = "CSI2" Or cmbCodes.SelectedItem = "DLI" Then
   '      If chbHasChequeDate.Checked Then
   '         e.Graphics.DrawString(Format(CDate(dDate), "MMMM dd, yyyy"), font, Brushes.Black, 550, 593 + yadjuster)
   '      End If
   '      If payee2.Length > 0 Then
   '         e.Graphics.DrawString(payee1.ToUpper, font, Brushes.Black, payee1X, 613 + yadjuster)
   '         e.Graphics.DrawString(payee2, font, Brushes.Black, payee2X, 628 + yadjuster)
   '      Else
   '         e.Graphics.DrawString(payee1.ToUpper, font, Brushes.Black, payee1X, 628 + yadjuster)
   '      End If
   '      'Amount
   '      If Val(tbAmount.Text) > 0 Then
   '         e.Graphics.DrawString(amount, font, Brushes.Black, 585, 630 + yadjuster)
   '      End If
   '      e.Graphics.DrawString(tbAmountInWords.Text, font, Brushes.Black, 90, 665 + yadjuster)
   '   ElseIf code.CheckType = 4 Then 'cmbCodes.SelectedItem = "CTJ" Then
   '      spaceWidth = 500
   '      font = New Drawing.Font("Arial", 10)
   '      payee1X = (spaceWidth - getStrWidth(payee1.ToUpper, font, e)) / 2
   '      payee2X = (spaceWidth - getStrWidth(payee2, font, e)) / 2
   '      If chbHasChequeDate.Checked Then
   '         e.Graphics.DrawString(Format(CDate(dDate), "MMMM dd, yyyy"), font, Brushes.Black, 450, 593 + yadjuster)
   '      End If
   '      If payee2.Length > 0 Then
   '         e.Graphics.DrawString(payee1.ToUpper, font, Brushes.Black, payee1X, 613 + yadjuster)
   '         e.Graphics.DrawString(payee2, font, Brushes.Black, payee2X, 628 + yadjuster)
   '      Else
   '         e.Graphics.DrawString(payee1.ToUpper, font, Brushes.Black, payee1X, 628 + yadjuster)
   '      End If
   '      'Amount
   '      If Val(tbAmount.Text) > 0 Then
   '         e.Graphics.DrawString(amount, font, Brushes.Black, 500, 630 + yadjuster)
   '      End If
   '      e.Graphics.DrawString(tbAmountInWords.Text, font, Brushes.Black, 90, 665 + yadjuster)
   '   ElseIf code.CheckType = 5 Then 'cmbCodes.SelectedItem = "MPF1" Then
   '      If chbHasChequeDate.Checked Then
   '         e.Graphics.DrawString(Format(CDate(dDate), "MMMM dd, yyyy"), font, Brushes.Black, 600, 590 + yadjuster)
   '      End If
   '      If payee2.Length > 0 Then
   '         e.Graphics.DrawString(payee1.ToUpper, font, Brushes.Black, payee1X, 605 + yadjuster)
   '         e.Graphics.DrawString(payee2, font, Brushes.Black, payee2X, 620 + yadjuster)
   '      Else
   '         e.Graphics.DrawString(payee1.ToUpper, font, Brushes.Black, payee1X, 620 + yadjuster)
   '      End If
   '      'Amount
   '      If Val(tbAmount.Text) > 0 Then
   '         e.Graphics.DrawString(amount, font, Brushes.Black, 615, 618 + yadjuster)
   '      End If

   '      e.Graphics.DrawString(tbAmountInWords.Text, font, Brushes.Black, 90, 645 + yadjuster)
   '   ElseIf code.CheckType = 6 Then 'cmbCodes.SelectedItem = "MTU" Then
   '      If chbHasChequeDate.Checked Then
   '         e.Graphics.DrawString(Format(CDate(dDate), "MMMM dd, yyyy"), font, Brushes.Black, 580, 585 + yadjuster)
   '      End If
   '      If payee2.Length > 0 Then
   '         e.Graphics.DrawString(payee1.ToUpper, font, Brushes.Black, payee1X, 595 + yadjuster)
   '         e.Graphics.DrawString(payee2, font, Brushes.Black, payee2X, 615 + yadjuster)
   '      Else
   '         e.Graphics.DrawString(payee1.ToUpper, font, Brushes.Black, payee1X, 615 + yadjuster)
   '      End If
   '      'Amount
   '      If Val(tbAmount.Text) > 0 Then
   '         e.Graphics.DrawString(amount, font, Brushes.Black, 610, 620 + yadjuster)
   '      End If
   '      e.Graphics.DrawString(tbAmountInWords.Text, font, Brushes.Black, 80, 648 + yadjuster)
   '   ElseIf code.CheckType = 7 Then 'cmbCodes.SelectedItem = "CSI5" Then
   '      If chbHasChequeDate.Checked Then
   '         Dim datefont As Font = New Drawing.Font("Arial", 9)
   '         Dim month As String = Nothing
   '         Dim day As String = Nothing
   '         Dim year As String = Nothing
   '         For Each c As Char In dDate.ToString("MM")
   '            month += c & "  "
   '         Next
   '         For Each c As Char In dDate.ToString("dd")
   '            day += c & "  "
   '         Next
   '         For Each c As Char In dDate.ToString("yyyy")
   '            year += c & "  "
   '         Next
   '         e.Graphics.DrawString(month, datefont, Brushes.Black, 580, 590 + yadjuster)
   '         e.Graphics.DrawString(day, datefont, Brushes.Black, 630, 590 + yadjuster)
   '         e.Graphics.DrawString(year, datefont, Brushes.Black, 680, 590 + yadjuster)
   '      End If
   '      If payee2.Length > 0 Then
   '         e.Graphics.DrawString(payee1.ToUpper, font, Brushes.Black, payee1X, 605 + yadjuster)
   '         e.Graphics.DrawString(payee2, font, Brushes.Black, payee2X, 620 + yadjuster)
   '      Else
   '         e.Graphics.DrawString(payee1.ToUpper, font, Brushes.Black, payee1X, 620 + yadjuster)
   '      End If
   '      'Amount
   '      If Val(tbAmount.Text) > 0 Then
   '         e.Graphics.DrawString(amount, font, Brushes.Black, 600, 618 + yadjuster)
   '      End If
   '      e.Graphics.DrawString(tbAmountInWords.Text, font, Brushes.Black, 90, 645 + yadjuster)
   '   End If

   '   If chbCrossedCheque.Checked = True Then
   '      e.Graphics.DrawLine(Pens.Black, 100, 570 + yadjuster, 200, 520 + yadjuster)
   '      e.Graphics.DrawLine(Pens.Black, 115, 570 + yadjuster, 215, 520 + yadjuster)
   '      'e.Graphics.DrawLine(Pens.Black, 300, 500, 600, 500) horizontal
   '   End If
   'End Sub



   Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrintCheque.Click
      If ValidateCheque() Then
         If PrintDialog1.ShowDialog = DialogResult.OK Then
            printCheque.PrinterSettings = PrintDialog1.PrinterSettings
            printCheque.PrinterSettings.DefaultPageSettings.Margins = New Printing.Margins(0, 0, 0, 0)
            printCheque.PrinterSettings.DefaultPageSettings.Landscape = True
            printCheque.Print()
            Save()
         End If
      End If
   End Sub

   Private Sub btnPreviewCheque_Click(sender As Object, e As EventArgs) Handles btnPreviewCheque.Click
      If ValidateCheque() Then
         printCheque.DefaultPageSettings = New PageSettings With {
            .Margins = New Printing.Margins(0, 0, 0, 0),
            .Landscape = True
         }
         printCheque.PrinterSettings = New PrinterSettings
         PrintPreview.Document = printCheque
         PrintPreview.InvalidatePreview()
         PrintPreview.Zoom = 0.8
      End If
   End Sub
   Private Sub printCheque_PrintPage2(sender As Object, e As Printing.PrintPageEventArgs) Handles printCheque.PrintPage
      Dim code As CodeInf = DirectCast(cbChequeCodes.SelectedItem, CodeInf)


      Dim chequeDate As Date = Nothing
      If chbHasChequeDate.Checked Then chequeDate = dtChequeDate.Value

      Dim amount As Double = 0
      If tbAmount.Text <> String.Empty Then
         amount = Val(tbAmount.Text.Replace(",", ""))
      End If
      ChequePrinter.ChequeFormats(code.CheckType).Print(tbPayee1.Text, tbPayee2.Text, chequeDate,
                                                               amount,
                                                               e,
                                                               chbCrossedCheque.Checked)
   End Sub


   Private Sub btnZin_Click(sender As Object, e As EventArgs) Handles btnZin.Click
      Try
         PrintPreview.Zoom += 0.1
      Catch
      End Try
   End Sub

   Private Sub btnZout_Click(sender As Object, e As EventArgs) Handles btnZout.Click
      If PrintPreview.Zoom > 0.1 Then
         PrintPreview.Zoom -= 0.1
      End If
   End Sub

   Private Sub txtAmount_Leave(sender As Object, e As EventArgs) Handles tbAmount.TextChanged
      'If tbAmount.Text.Length > 0 Then
      '    tbAmount.Text = Double.Parse(tbAmount.Text).ToString("N2")
      'End If
      Try
         If tbAmount.Text.Length > 0 Then
            If Val(tbAmount.Text) <> 0 Then
               Dim formattedAmount As String = Double.Parse(tbAmount.Text).ToString("N2")
               Dim cents As String() = formattedAmount.Split(".")
               tbAmountInWords.Text = " **" & ChequeModelExtension.AmountInWords(formattedAmount) & " & " & cents(1) & "/100 ONLY**"
            Else tbAmountInWords.Text = ""
            End If
         Else tbAmountInWords.Text = ""
         End If
      Catch
      End Try
   End Sub

   Private Sub txtConfAmount_Leave(sender As Object, e As EventArgs)
      'If tbConfirmAmount.Text.Length > 0 Then
      '    If Val(tbConfirmAmount.Text) <> 0 Then
      '        Dim formattedAmount As String = Double.Parse(tbConfirmAmount.Text).ToString("N2")
      '        Dim cents As String() = formattedAmount.Split(".")
      '        tbAmountInWords.Text = " **" & ChequeModelExtension.AmountInWords(formattedAmount) & " & " & cents(1) & "/100 ONLY**"
      '    Else
      '        tbAmountInWords.Text = ""
      '    End If
      'End If
   End Sub


   Private Sub lvChkData_DragDrop(sender As Object, e As DragEventArgs) Handles lstImportedCheques.DragDrop
      If e.Data.GetDataPresent(DataFormats.FileDrop) Then
         Dim datapaths As String() = e.Data.GetData(DataFormats.FileDrop)
         For Each path In datapaths
            txtImportPath.Text = path
            loadData(path)
         Next
      End If
   End Sub

   Private Sub lvChkData_DragEnter(sender As Object, e As DragEventArgs) Handles lstImportedCheques.DragEnter
      e.Effect = DragDropEffects.Copy
   End Sub


   Private Sub lvChkData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstImportedCheques.SelectedIndexChanged
      If lstImportedCheques.SelectedItems.Count > 0 Then
         For i As Integer = 0 To cbChequeCodes.Items.Count - 1
            If cbChequeCodes.Items(i).code = lstImportedCheques.SelectedItems.Item(0).SubItems(1).Text Then
               cbChequeCodes.SelectedIndex = i
            End If
         Next

         If lstImportedCheques.SelectedItems(0).SubItems(2).Text.Length > 0 Then
            Try
               dtChequeDate.Value = Date.Parse(lstImportedCheques.SelectedItems.Item(0).SubItems(2).Text)
            Catch ex As Exception
               dtChequeDate.Value = Date.Parse(rearrangeDateFormat(lstImportedCheques.SelectedItems.Item(0).SubItems(2).Text))
            End Try
         End If
         tbPayee1.Text = lstImportedCheques.SelectedItems.Item(0).SubItems(3).Text
         tbPayee2.Text = lstImportedCheques.SelectedItems(0).SubItems(4).Text
         tbAmount.Text = Double.Parse("0" & lstImportedCheques.SelectedItems(0).SubItems(5).Text).ToString("N2")
         'tbAmount.Text = Double.Parse(tbAmount.Text).ToString("N2")
         chbCrossedCheque.Checked = lstImportedCheques.SelectedItems(0).SubItems(6).Text.ToUpper = "Y"

         txtConfAmount_Leave(sender, e)
         Application.DoEvents()
      End If

   End Sub

   Private Function rearrangeDateFormat(dt As String) As String
      Dim dtarr As String() = dt.Split("/")
      Return String.Format("{1}/{0}/{2}", dt.Split("/"))
   End Function

   Private Sub btnPrintAll_Click(sender As Object, e As EventArgs) Handles btnPrintAllCheque.Click
      If lstImportedCheques.Items.Count > 0 Then
         If PrintDialog1.ShowDialog = DialogResult.OK Then
            For i = 0 To lstImportedCheques.Items.Count - 1
               lstImportedCheques.Items(i).Selected = True
               lstImportedCheques.Select()
               Application.DoEvents()
               btnPreviewCheque.PerformClick()
               printCheque.PrinterSettings = PrintDialog1.PrinterSettings
               printCheque.DefaultPageSettings.Landscape = True
               printCheque.Print()
               Save()
            Next
            MsgBox("Done", MsgBoxStyle.Information)
         End If
      Else
         MsgBox("No Items To Print", MsgBoxStyle.Critical)
      End If

   End Sub

   Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
      txtImportPath.Text = Nothing
      lstImportedCheques.Items.Clear()
   End Sub



   Private Sub txtPath_DragDrop(sender As Object, e As DragEventArgs) Handles txtImportPath.DragDrop
      If e.Data.GetDataPresent(DataFormats.FileDrop) Then
         Dim datapaths As String() = e.Data.GetData(DataFormats.FileDrop)
         For Each path In datapaths
            loadData(path)
         Next
      End If
   End Sub

   Private Sub txtPath_DragEnter(sender As Object, e As DragEventArgs) Handles txtImportPath.DragEnter
      e.Effect = DragDropEffects.Copy
   End Sub

   Private Sub txtPath_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtImportPath.MouseDoubleClick
      Dim ofd As New OpenFileDialog
      If ofd.ShowDialog = DialogResult.OK Then
         txtImportPath.Text = ofd.FileName
         loadData(ofd.FileName)
      End If
   End Sub

   Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
      tsDt.Text = Now.ToString("MM/dd/yyyy hh:mm:ss")
   End Sub

   Private Sub tsRecords_Click(sender As Object, e As EventArgs) Handles tsRecords.Click
      frmRecords.ShowDialog()
      frmRecords.Owner = Me
   End Sub

   Private Sub btnCodes_Click(sender As Object, e As EventArgs) Handles btnCodes.Click
      frmCodes.ShowDialog()
      frmCodes.Owner = Me
   End Sub
















   Private Function ValidateCheque() As Boolean
      'If Val(Trim(tbAmount.Text.Replace(",", ""))) <> Val(Trim(tbConfirmAmount.Text.Replace(",", ""))) Then
      '    MsgBox("Mismatched Amount", MsgBoxStyle.Critical)
      '    Return False
      'End If
      If cbChequeCodes.SelectedItem Is Nothing Then
         MsgBox("No Selected Code", MsgBoxStyle.Critical)
         Return False
      End If

      Return True
   End Function

   Private Function ValidateEndorsement() As Boolean
      If txtEndorsement.Text.Trim = "" Then
         MsgBox("Endorsement Box Is Empty", vbCritical)
         Return False
      End If

      Return True
   End Function
End Class
