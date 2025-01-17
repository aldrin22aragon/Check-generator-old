﻿Module mdlNumtoWord

    Dim mOnesArray(8) As String
    Dim mOneTensArray(9) As String
    Dim mTensArray(7) As String
    Dim mPlaceValues(4) As String

    Public Function upperFirst(ByVal valStr As String) As String
        valStr = valStr.ToLower
        upperFirst = ""
        If Trim(valStr).Length > 0 Then
            upperFirst = "   " & Trim(valStr.Substring(0, 1).ToUpper & valStr.Substring(1, valStr.Length - 1)) & " and " & Trim(Form1.tbAmount.Text.Split(".")(1)) & "/100 only  "
        End If

    End Function

    Public Function convertToWord() As String

        mOnesArray(0) = "one"
        mOnesArray(1) = "two"
        mOnesArray(2) = "three"
        mOnesArray(3) = "four"
        mOnesArray(4) = "five"
        mOnesArray(5) = "six"
        mOnesArray(6) = "seven"
        mOnesArray(7) = "eight"
        mOnesArray(8) = "nine"

        mOneTensArray(0) = "ten"
        mOneTensArray(1) = "eleven"
        mOneTensArray(2) = "twelve"
        mOneTensArray(3) = "thirteen"
        mOneTensArray(4) = "fourteen"
        mOneTensArray(5) = "fifteen"
        mOneTensArray(6) = "sixteen"
        mOneTensArray(7) = "seventeen"
        mOneTensArray(8) = "eightteen"
        mOneTensArray(9) = "nineteen"

        mTensArray(0) = "twenty"
        mTensArray(1) = "thirty"
        mTensArray(2) = "forty"
        mTensArray(3) = "fifty"
        mTensArray(4) = "sixty"
        mTensArray(5) = "seventy"
        mTensArray(6) = "eighty"
        mTensArray(7) = "ninety"

        mPlaceValues(0) = "hundred"
        mPlaceValues(1) = "thousand"
        mPlaceValues(2) = "million"
        mPlaceValues(3) = "billion"
        mPlaceValues(4) = "trillion"

        convertToWord = ""
        convertToWord = ConvertNumberToWords()

    End Function

    Private Function getOnes(ByVal OneDigit As Integer) As String
        getOnes = ""

        If OneDigit = 0 Then
            Exit Function
        End If

        getOnes = mOnesArray(OneDigit - 1)
    End Function


    Private Function GetTens(ByVal TensDigit As Integer) As String

        GetTens = ""

        If TensDigit = 0 Or TensDigit = 1 Then
            Exit Function
        End If

        GetTens = mTensArray(TensDigit - 2)

    End Function

    Public Function ConvertNumberToWords() As String 'ByVal NumberValue As String

        Dim Delimiter As String = " "
        Dim TensDelimiter As String = "-"
        Dim mNumberValue As String = ""
        Dim mNumbers As String = ""
        Dim mNumWord As String = ""
        Dim mFraction As String = ""
        Dim mNumberStack() As String
        Dim j As Integer = 0
        Dim i As Integer = 0
        Dim mOneTens As Boolean = False

        ConvertNumberToWords = ""
        mNumbers = Trim(Form1.tbAmount.Text.Split(".")(0).Replace(",", "").Replace(" ", ""))

        For j = mNumbers.Length - 1 To 0 Step -1
            ReDim Preserve mNumberStack(i)

            mNumberStack(i) = mNumbers(j)
            i += 1
        Next

        For j = mNumbers.Length - 1 To 0 Step -1
            Select Case j
                Case 0, 3, 6, 9, 12
                    ' ones  value
                    If Not mOneTens Then
                        mNumWord &= getOnes(Val(mNumberStack(j))) & Delimiter
                    End If

                    Select Case j
                        Case 3
                            ' thousands
                            If Val(mNumbers.Substring(0, 1)) > 0 Then
                                mNumWord &= mPlaceValues(1) & Delimiter
                            End If

                        Case 6
                            ' millions
                            '1000000
                            If Val(mNumbers.Substring(1, 3)) > 0 Then
                                mNumWord &= mPlaceValues(2) & Delimiter
                            End If

                        Case 9
                            ' billions
                            '1000000000
                            Dim ss As String
                            If mNumbers.Length = 10 Then
                                ss = mNumbers.Substring(1, 6)
                            Else

                            End If
                            If Val(mNumbers.Substring(1, 6)) > 0 Then

                            End If
                            mNumWord &= mPlaceValues(3) & Delimiter
                        Case 12
                            ' trillions
                            mNumWord &= mPlaceValues(4) & Delimiter
                    End Select


                Case Is = 1, 4, 7, 10, 13
                    ' tens value
                    If Val(mNumberStack(j)) = 0 Then
                        mNumWord &= Trim(getOnes(Val(mNumberStack(j - 1))) & Delimiter)
                        mOneTens = True
                        Exit Select
                    End If

                    If Val(mNumberStack(j)) = 1 Then
                        mNumWord &= mOneTensArray(Val(mNumberStack(j - 1))) & Delimiter
                        mOneTens = True
                        Exit Select
                    End If

                    mNumWord &= GetTens(Val(mNumberStack(j)))

                    ' this places the tensdelimiter; check for succeeding 0
                    If Val(mNumberStack(j - 1)) <> 0 Then
                        mNumWord &= TensDelimiter
                    End If
                    mOneTens = False

                Case Else
                    ' hundreds value 
                    mNumWord &= Trim(getOnes(Val(mNumberStack(j))) & Delimiter)

                    If Val(mNumberStack(j)) <> 0 Then
                        mNumWord &= mPlaceValues(0) & Delimiter
                    End If
            End Select
        Next

        Return mNumWord
    End Function



End Module
