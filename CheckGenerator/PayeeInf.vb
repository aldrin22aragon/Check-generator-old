

Imports System.Data.SQLite

Public Class PayeeInf
    Public ID As Integer
    Public Code As String
    Public Payee1 As String
    Public Payee2 As String
    Public _date As String
    Public Amount As String
    Public CheckType As Integer
    Public Action As ActionType
    Public Enum ActionType
        Add
        Edit
        MultiSelect
    End Enum


    Sub New()

    End Sub

    Sub New(rdr As SQLiteDataReader)
        With rdr
            ID = .Item(0).ToString
            Code = .Item(1).ToString
            Payee1 = .Item(2).ToString
            Payee1 = .Item(3).ToString
            _date = .Item(4).ToString
            Amount = .Item(5).ToString
        End With
    End Sub




    Public Shared Function ToCheckDuplicateQuery() As String
        Return "SELECT * FROM CheckData GROUP BY Code,`Date`, Payee1, Payee2, Amount;"
    End Function
    Public Function ToInsertQuery() As String
        Return String.Format("INSERT INTO CheckData (Code,`Date`,Payee1,Payee2,Amount,CheckType)VALUES('{0}','{1}','{2}','{3}','{4}',{5});", Code, _date, Payee1.Replace("'", "''"), Payee2.Replace("'", "''"), Amount, CheckType)
    End Function
    Public Function ToUpdateQuery() As String
        Return String.Format("UPDATE CheckData SET Code='{0}', `Date`='{1}', Payee1='{2}', Payee2='{3}', Amount='{4}', CheckType={5} WHERE ID={6};", Code, _date, Payee1.Replace("'", "''"), Payee2.Replace("'", "''"), Amount, CheckType, ID)
    End Function
    Public Shared Function ToDeleteQuery(_id As String) As String
        Return String.Format("DELETE FROM CheckData WHERE ID={0};", _id)
    End Function
    Public Shared Function ToDeleteCodeQuery(code As String)
        Return String.Format("DELETE FROM CheckData WHERE Code='{0}';", code)
    End Function
    Public Shared Function ToTruncateQuery()
        Return String.Format("DELETE FROM CheckData;")
    End Function

    Public Function ToSaveQuery()
        If Action = ActionType.Add Then
            Return ToInsertQuery()
        ElseIf Action = ActionType.Edit Then
            Return ToUpdateQuery()
        End If
        Return ""
    End Function

    Public Shared Function ToRenameCodeQuery(code As String, newCode As String)
        Return String.Format("UPDATE CheckData SET Code='{0}' WHERE Code={1};", code, newCode)
        code = newCode
    End Function


    Public Shared Function ToSelectQuery() As String
        Return String.Format("SELECT * FROM CheckData;")
    End Function
    Public Shared Function ToSelectCodeQuery(_code As String) As String
        Return String.Format("SELECT * FROM CheckData WHERE Code='{0}';", _code)
    End Function
    Public Shared Function ToSelectByGroupQuery(header As String) As String
        Return String.Format("SELECT * FROM CheckData GROUP BY {0};", header)
    End Function

    Public Shared Function ToGetCodeList()
        Return String.Format("SELECT * FROM CodeList;")
    End Function

End Class
