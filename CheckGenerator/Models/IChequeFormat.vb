Public Interface IChequeFormat
    Sub Print(payee1 As String, payee3 As String, chequeDate As Date, amount As Double, printer As Printing.PrintPageEventArgs, crossed As Boolean, Optional xAdjustment As Integer = 0, Optional yAdjustment As Integer = 0)
End Interface


Public Interface Person
   Function getFullName() As String
End Interface
Public Interface ClassRoom
   Function getStudents() As String()
   Function getFullName() As String
End Interface

Class Aa
   Implements ClassRoom
   Public Sub ssss()

   End Sub
   Public Function getStudents() As String() Implements ClassRoom.getStudents
      Throw New NotImplementedException()
   End Function

   Public Function getFullName() As String Implements ClassRoom.getFullName
      Throw New NotImplementedException()
   End Function
End Class
