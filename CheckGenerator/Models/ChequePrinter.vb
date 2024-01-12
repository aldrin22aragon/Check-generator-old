

Public Class ChequePrinter

    Public ChequeFormats As Dictionary(Of Integer, IChequeFormat)


    Public Sub New()
        Dim font As New Font("Arial", 11)
        ChequeFormats = New Dictionary(Of Integer, IChequeFormat)

        Dim xAdjustment As Integer = 280
        Dim yAdjustment As Integer = -280

        ChequeFormats.Add(1, New DefaultChequeFormat(New Point(0, 605 + yAdjustment), New Point(0, 620 + yAdjustment), New Point(595, 618 + yAdjustment), New Point(90, 645 + yAdjustment), New Point(570, 590 + yAdjustment), font))
        ChequeFormats.Add(2, New DefaultChequeFormat(New Point(0, 605 + yAdjustment), New Point(0, 620 + yAdjustment), New Point(595, 618 + yAdjustment), New Point(90, 645 + yAdjustment), New Point(600, 590 + yAdjustment), font))
        ChequeFormats.Add(3, New DefaultChequeFormat(New Point(0, 613 + yAdjustment), New Point(0, 628 + yAdjustment), New Point(585, 630 + yAdjustment), New Point(90, 665 + yAdjustment), New Point(550, 593 + yAdjustment), font))
        ChequeFormats.Add(4, New DefaultChequeFormat(New Point(0, 613 + yAdjustment), New Point(0, 628 + yAdjustment), New Point(500, 630 + yAdjustment), New Point(90, 665 + yAdjustment), New Point(450, 593 + yAdjustment), New Font("Arial", 10)))
        ChequeFormats.Add(5, New DefaultChequeFormat(New Point(0, 605 + yAdjustment), New Point(0, 620 + yAdjustment), New Point(615, 618 + yAdjustment), New Point(90, 645 + yAdjustment), New Point(600, 590 + yAdjustment), font))
        ChequeFormats.Add(6, New DefaultChequeFormat(New Point(0, 595 + yAdjustment), New Point(0, 615 + yAdjustment), New Point(610, 620 + yAdjustment), New Point(80, 648 + yAdjustment), New Point(580, 585 + yAdjustment), font))
        ChequeFormats.Add(7, New MBChequeFormat(New Point(0, 605 + yAdjustment), New Point(0, 620 + yAdjustment), New Point(600, 618 + yAdjustment), New Point(90, 645 + yAdjustment), New Point(580, 590 + yAdjustment), font))
    End Sub






End Class
