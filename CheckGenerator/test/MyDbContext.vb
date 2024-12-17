Imports System.Data.Entity

Public Class MyDbContext
    Inherits DbContext

    ' DbSet properties represent tables in the database
    Public Property Products As DbSet(Of Product)
End Class
