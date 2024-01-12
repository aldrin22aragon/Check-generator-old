Imports System.IO
Module BackProcess
    'Public Function upperFirst(ByVal valStr As String) As String
    '    valStr = valStr.ToLower
    '    upperFirst = ""
    '    If Trim(valStr).Length > 0 Then
    '        upperFirst = "**" & Trim(valStr.Substring(0, 1).ToUpper & valStr.Substring(1, valStr.Length - 1)) & " & " & Trim(Form1.txtAmount.Text.Split(".")(1)) & "/100 only**"
    '    End If

    'End Function
    Function NumberToText(ByVal n As Integer) As String
        Select Case n
            Case 0
                Return ""

            Case 1 To 19
                Dim arr() As String = {"One", "Two", "Three", "Four", "Five", "Six", "Seven", _
                  "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", _
                    "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"}
                Return arr(n - 1) & " "

            Case 20 To 99
                Dim arr() As String = {"Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"}
                Return arr(n \ 10 - 2) & " " & NumberToText(n Mod 10)

            Case 100 To 199
                Return "One Hundred " & NumberToText(n Mod 100)

            Case 200 To 999
                Return NumberToText(n \ 100) & "Hundred " & NumberToText(n Mod 100)

            Case 1000 To 1999
                Return "One Thousand " & NumberToText(n Mod 1000)

            Case 2000 To 999999
                Return NumberToText(n \ 1000) & "Thousand " & NumberToText(n Mod 1000)

            Case 1000000 To 1999999
                Return "One Million " & NumberToText(n Mod 1000000)

            Case 1000000 To 999999999
                Return NumberToText(n \ 1000000) & "Million " & NumberToText(n Mod 1000000)

            Case 1000000000 To 1999999999
                Return "One Billion " & NumberToText(n Mod 1000000000)

            Case Else
                Return NumberToText(n \ 1000000000) & "Billion " _
                  & NumberToText(n Mod 1000000000)
        End Select
    End Function
    Public Function getStrWidth(ByVal str As String, ByVal font As Font, ByVal e As System.Drawing.Printing.PrintPageEventArgs) As Integer
        Dim strSize As SizeF
        strSize = e.Graphics.MeasureString(str, font)
        Return strSize.Width
    End Function

    Public Function getAmount() As String
        getAmount = ""
      If Form1.tbAmount.Text.Length > 0 Then
         'agay
         getAmount = "**" & FormatCurrency(Trim(Form1.tbAmount.Text)).Replace("$", "") & "**"
      End If
   End Function

    Public Sub readCsv(ByVal Path As String)

        Dim datas As String() = File.ReadAllText(Path).Split(vbLf)

        For Each dt In datas
            Dim empdt As String() = dt.Split(",")
            If Not empdt(0).ToString.ToUpper.Trim = "CODE" And Not empdt(0).ToString.Trim = "" Then
                With Form1.lstImportedCheques.Items.Add(empdt(0).ToString)
                    .SubItems.Add(empdt(1).ToString)
                    .SubItems.Add(empdt(2).ToString)
                    .SubItems.Add(empdt(3).ToString)
                    .SubItems.Add(empdt(4).ToString.Trim & "," & empdt(5).ToString.Trim)
                End With
            End If
        Next

    End Sub
    Public Function fixNull(ByVal str As Object) As String
        FixNull = Trim(str & vbNullString)
    End Function

    Public Sub LoadData2(path As String)
        Form1.lstImportedCheques.Items.Clear()
        Using rdr As StreamReader = New StreamReader(path)
            rdr.ReadLine()
            rdr.ReadLine()
            Dim ln As String = rdr.ReadLine
            Dim delimiter As String = ","
            If ln.Split(";").Length >= 4 Then
                delimiter = ";"
            End If

            While ln IsNot Nothing
                Dim flds As String() = ln.Replace("""", "").Replace("""", "").Replace("'", "").Split(delimiter)
                If Not flds(0).ToString.ToUpper = "CODE" And Not flds(0).ToUpper.ToUpper = "" Then
                    With Form1.lstImportedCheques.Items.Add(Form1.lstImportedCheques.Items.Count + 1)
                        .SubItems.Add(flds(0).ToString.Trim)
                        .SubItems.Add(flds(1).ToString)
                        If flds(2).ToString.Contains("�") Then flds(2) = flds(2).ToString.Replace("�", "Ñ")
                        If flds(3).ToString.Contains("�") Then flds(3) = flds(3).ToString.Replace("�", "Ñ")
                        .SubItems.Add(flds(2).ToString)
                        If flds.Length > 3 Then
                            .SubItems.Add(flds(3).ToString)
                            .SubItems.Add(flds(4).ToString.Trim)
                        End If
                    End With
                End If
                ln = rdr.ReadLine
            End While
        End Using
    End Sub


    Public Sub loadData(ByVal path As String)
        Try
            Form1.lstImportedCheques.Items.Clear()
            Dim parser As New Microsoft.VisualBasic.FileIO.TextFieldParser(path)
            parser.SetDelimiters(",")

            Dim i As Integer = 0
            While Not parser.EndOfData
                Dim flds As String() = parser.ReadFields
                If Not flds(0).ToString.ToUpper = "CODE" And Not flds(0).ToUpper.ToUpper = "" Then
                    i += 1
                    With Form1.lstImportedCheques.Items.Add(i)
                        .SubItems.Add(flds(0).ToString.Trim)
                        .SubItems.Add(flds(1).ToString)
                        If flds(2).ToString.Contains("�") Then flds(2) = flds(2).ToString.Replace("�", "Ñ")
                        If flds(3).ToString.Contains("�") Then flds(3) = flds(3).ToString.Replace("�", "Ñ")
                        .SubItems.Add(flds(2).ToString)
                        If flds.Length > 3 Then
                            .SubItems.Add(flds(3).ToString)
                            .SubItems.Add(flds(4).ToString.Trim)
                            .SubItems.Add(flds(5).ToString.Trim)
                        End If
                    End With
                End If
            End While
        Catch ex As Exception
            LoadData2(path)
        End Try
    End Sub

End Module
