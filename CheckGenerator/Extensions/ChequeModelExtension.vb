Public Class ChequeModelExtension
    Public Shared Function AmountInWords(ByVal nAmount As String, Optional ByVal wAmount _
                 As String = vbNullString, Optional ByVal nSet As Object = Nothing) As String
        'Let's make sure entered value is numeric
        If Not IsNumeric(nAmount) Then Return "Please enter numeric values only."

        Dim tempDecValue As String = String.Empty : If InStr(nAmount, ".") Then _
            tempDecValue = nAmount.Substring(nAmount.IndexOf("."))
        nAmount = Replace(nAmount, tempDecValue, String.Empty)

        Try
            Dim intAmount As Long = nAmount
            If intAmount > 0 Then
                nSet = IIf((intAmount.ToString.Trim.Length / 3) _
                 > (CLng(intAmount.ToString.Trim.Length / 3)),
                  CLng(intAmount.ToString.Trim.Length / 3) + 1,
                   CLng(intAmount.ToString.Trim.Length / 3))
                Dim eAmount As Long = Microsoft.VisualBasic.Left(intAmount.ToString.Trim,
                  (intAmount.ToString.Trim.Length - ((nSet - 1) * 3)))
                Dim multiplier As Long = 10 ^ (((nSet - 1) * 3))

                Dim Ones() As String =
                {"", "One", "Two", "Three",
                  "Four", "Five",
                  "Six", "Seven", "Eight", "Nine"}
                Dim Teens() As String = {"",
                "Eleven", "Twelve", "Thirteen",
                  "Fourteen", "Fifteen",
                  "Sixteen", "Seventeen", "Eighteen", "Nineteen"}
                Dim Tens() As String = {"", "Ten",
                "Twenty", "Thirty",
                  "Forty", "Fifty", "Sixty",
                  "Seventy", "Eighty", "Ninety"}
                Dim HMBT() As String = {"", "",
                "Thousand", "Million",
                  "Billion", "Trillion",
                  "Quadrillion", "Quintillion"}

                intAmount = eAmount

                Dim nHundred As Integer = intAmount \ 100 : intAmount = intAmount Mod 100
                Dim nTen As Integer = intAmount \ 10 : intAmount = intAmount Mod 10
                Dim nOne As Integer = intAmount \ 1

                If nHundred > 0 Then wAmount = wAmount &
                Ones(nHundred) & " Hundred " 'This is for hundreds                
                If nTen > 0 Then 'This is for tens and teens
                    If nTen = 1 And nOne > 0 Then 'This is for teens 
                        wAmount = wAmount & Teens(nOne) & " "
                    Else 'This is for tens, 10 to 90
                        wAmount = wAmount & Tens(nTen) & IIf(nOne > 0, "-", " ")
                        If nOne > 0 Then wAmount = wAmount & Ones(nOne) & " "
                    End If
                Else 'This is for ones, 1 to 9
                    If nOne > 0 Then wAmount = wAmount & Ones(nOne) & " "
                End If
                wAmount = wAmount & HMBT(nSet) & " "
                wAmount = AmountInWords(CStr(CLng(nAmount) -
                  (eAmount * multiplier)).Trim & tempDecValue, wAmount, nSet - 1)
            Else
                'If Val(nAmount) = 0 Then nAmount = nAmount & _
                'tempDecValue : tempDecValue = String.Empty
                'If (Math.Round(Val(nAmount), 2) * 100) > 0 Then wAmount = _
                '  Trim(AmountInWords(CStr(Math.Round(Val(nAmount), 2) * 100), _
                '  wAmount.Trim & " Pesos And ", 1)) & " Cents"
            End If
        Catch ex As Exception
            MessageBox.Show("Error Encountered: " & ex.Message,
              "Convert Numbers To Words",
              MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "!#ERROR_ENCOUNTERED"
        End Try

        'Trap null values
        If IsNothing(wAmount) = True Then wAmount = String.Empty 'Else wAmount = _
        'IIf(InStr(wAmount.Trim.ToLower, "pesos"), _
        'wAmount.Trim, wAmount.Trim & " Pesos")

        'Display the result
        Return wAmount
    End Function

    Public Shared Function AmountInWords(Amount As Double) As String
        Dim _AmountInWords As String = String.Empty

        If Amount > 0 Then
            Dim amountArgs As String() = Amount.ToString("N2").Split(".")
            If Val(Amount) > 0 Then
                _AmountInWords = " **" & AmountInWords(amountArgs(0)) & " & " & amountArgs(1) & "/100 ONLY**"
            End If
        End If

        Return _AmountInWords
    End Function


    Public Shared Function AdjustPayeeLine(payee As String, font As Font, maxPayeeWidth As Integer, printer As Printing.PrintPageEventArgs) As String
        If GetTextWidth(payee, font, printer) > maxPayeeWidth Then
            Dim payeeArgs As String() = payee.Replace(vbNewLine, " ").Split(" ")

            Dim payeeArgsIndex As Integer = 0

            Dim payeeLine1 As String = String.Empty
            While True
                Dim payeeLineChecker As String = payeeLine1 & " " & payeeArgs(payeeArgsIndex)
                If GetTextWidth(payeeLineChecker, font, printer) <= maxPayeeWidth Then
                    payeeLine1 = payeeLineChecker
                    payeeArgsIndex += 1
                Else
                    Exit While
                End If
            End While

            If payeeArgsIndex < payeeArgs.Length Then
                Dim payeeLine2 As String = String.Empty
                For i As Integer = payeeArgsIndex To payeeArgs.Length - 1
                    payeeLine2 &= payeeArgs(i) & " "
                Next

                Return payeeLine1.Trim & vbNewLine & payeeLine2.Trim
            End If

            Return payeeLine1.Trim
        End If

        Return payee
    End Function



    Public Shared Sub GuagePayeeFontSize(ByRef payee As String, ByRef font As Font, maxPayeeWidth As Integer, printer As Printing.PrintPageEventArgs, shouldAdjustPayeeLine As Boolean)
        Dim newFont As New Font(font.FontFamily, font.Size)
        While True
            If shouldAdjustPayeeLine Then payee = AdjustPayeeLine(payee, newFont, maxPayeeWidth, printer)
            If GetTextWidth(payee, newFont, printer) <= maxPayeeWidth Then
                font = newFont
                Exit While
            Else
                newFont = New Font(font.FontFamily, newFont.Size - 1)
            End If
        End While

    End Sub

    Public Shared Function GetTextWidth(str As String, font As Font, printer As Printing.PrintPageEventArgs) As Integer
        Return printer.Graphics.MeasureString(str, font).Width
    End Function




End Class
