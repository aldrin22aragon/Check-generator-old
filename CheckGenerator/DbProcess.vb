
Imports System.Data.SQLite
Module DbProcess
    Public Constr As String = "Datasource=" & Application.StartupPath & "/PrintDb.db"

    Public Sub Save()
        Using sqlcon As New SQLite.SQLiteConnection(Constr)
            sqlcon.Open()
            'Dim code As String = Form1.cmbCodes.Text
            Dim newRecord As New PayeeInf

            newRecord._date = Form1.dtChequeDate.Text
            newRecord.Payee1 = Form1.tbPayee1.Text
            newRecord.Payee2 = Form1.tbPayee2.Text
            newRecord.Amount = Form1.tbAmount.Text
            newRecord.Code = DirectCast(Form1.cbChequeCodes.SelectedItem, CodeInf).Code
            newRecord.CheckType = DirectCast(Form1.cbChequeCodes.SelectedItem, CodeInf).CheckType

            Dim sqlcom As New SQLite.SQLiteCommand(newRecord.ToInsertQuery, sqlcon)
            sqlcom.ExecuteNonQuery()

        End Using
    End Sub

    Public Sub LoadAutoComp()
        Using sqlcon As New SQLite.SQLiteConnection(Constr)
            sqlcon.Open()
            Dim autoComppay1 As New AutoCompleteStringCollection
            Dim autoComppay2 As New AutoCompleteStringCollection
            Dim amount As New AutoCompleteStringCollection
            'For Payee1
            Dim paycom As New SQLiteCommand("Select Payee1 from CheckData", sqlcon)
            Dim payread As SQLite.SQLiteDataReader
            payread = paycom.ExecuteReader
            While payread.Read
                Dim pay1 As String = payread(0).ToString
                If pay1.Contains("´") Then pay1 = pay1.Replace("´", "'")
                autoComppay1.Add(pay1)
            End While

            'for payee2
            Dim paycom2 As New SQLiteCommand("Select Payee2 from CheckData", sqlcon)
            Dim payread2 As SQLite.SQLiteDataReader
            payread2 = paycom2.ExecuteReader
            While payread2.Read
                Dim pay2 As String = payread2(0).ToString
                If pay2.Contains("´") Then pay2.Replace("´", "'")
                autoComppay2.Add(pay2)
            End While

            'for Amount
            Dim payamount As New SQLiteCommand("Select Amount from CheckData", sqlcon)
            Dim amountread As SQLite.SQLiteDataReader
            amountread = payamount.ExecuteReader
            While amountread.Read
                amount.Add(amountread(0).ToString)
            End While

            Form1.tbPayee1.AutoCompleteCustomSource = autoComppay1
            Form1.tbPayee2.AutoCompleteCustomSource = autoComppay2
            Form1.tbAmount.AutoCompleteCustomSource = amount

        End Using
    End Sub

    Public Sub ExecuteNonQuery(qry As String)
        Using sqlcon As New SQLite.SQLiteConnection(Constr)
            sqlcon.Open()


            Dim sqlcom As New SQLite.SQLiteCommand(qry, sqlcon)
            sqlcom.ExecuteNonQuery()

            sqlcon.Close()
        End Using
    End Sub
End Module
