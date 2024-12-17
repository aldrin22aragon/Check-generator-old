Public Class CodeInf
    Public ID As Integer
    Public Code As String
    Public CheckType As Integer

    Sub New()

    End Sub
    Sub New(_code As String, _checkType As Integer)
        Code = _code
        CheckType = _checkType
    End Sub
    Public Overrides Function ToString() As String
        Return Code
    End Function

    Public Const ToGetCodeList As String = "SELECT * FROM Codestbl;"

    Public Function ToInsertQuery() As String
        Return String.Format("INSERT INTO Codestbl (Code,CheckType)VALUES('{0}',{1});", Code, CheckType)
    End Function
    Public Function ToUpdateQuery() As String
        Return String.Format("UPDATE Codestbl SET Code='{0}', CheckType={1} WHERE ID={2};", Code, CheckType, ID)
    End Function
    Public Shared Function ToDeleteCodeQuery(code As String)
        Return String.Format("DELETE FROM Codestbl WHERE Code='{0}';", code)
    End Function
    Public Shared Function ToTruncateQuery()
        Return String.Format("DELETE FROM Codestbl;")
    End Function

End Class
