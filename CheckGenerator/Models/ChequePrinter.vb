

Public Class ChequePrinter

    Public ChequeFormats As Dictionary(Of Integer, IChequeFormat)


    Public Sub New(xAdjustment As Integer, yAdjustment As Integer)
        Dim font As New Font("Arial", 11)
        ChequeFormats = New Dictionary(Of Integer, IChequeFormat)

        ChequeFormats.Add(1, New DefaultChequeFormat(
                            payee1Location:=New Point(0 + xAdjustment, 605 + yAdjustment),
                            payee2Location:=New Point(0 + xAdjustment, 620 + yAdjustment),
                            amountLocation:=New Point(595 + xAdjustment, 618 + yAdjustment),
                            amountInWordsLocation:=New Point(90 + xAdjustment, 645 + yAdjustment),
                            chequeDateLocation:=New Point(570 + xAdjustment, 590 + yAdjustment),
                            font:=font,
                            _crossCheckPoint:=New Point(x:=xAdjustment, y:=yAdjustment)
                          ))
        ChequeFormats.Add(2, New DefaultChequeFormat(
                              New Point(0 + xAdjustment, 605 + yAdjustment),
                              New Point(0 + xAdjustment, 620 + yAdjustment),
                              New Point(595 + xAdjustment, 618 + yAdjustment),
                              New Point(90 + xAdjustment, 645 + yAdjustment),
                              New Point(600 + xAdjustment, 590 + yAdjustment),
                              font,
                              New Point(x:=xAdjustment, y:=yAdjustment)
                          ))
        ChequeFormats.Add(3, New DefaultChequeFormat(
                              New Point(0 + xAdjustment, 613 + yAdjustment),
                              New Point(0 + xAdjustment, 628 + yAdjustment),
                              New Point(585 + xAdjustment, 630 + yAdjustment),
                              New Point(90 + xAdjustment, 665 + yAdjustment),
                              New Point(550 + xAdjustment, 593 + yAdjustment),
                              font,
                              New Point(x:=xAdjustment, y:=yAdjustment)
                          ))
        ChequeFormats.Add(4, New DefaultChequeFormat(
                              New Point(0 + xAdjustment, 613 + yAdjustment),
                              New Point(0 + xAdjustment, 628 + yAdjustment),
                              New Point(500 + xAdjustment, 630 + yAdjustment),
                              New Point(90 + xAdjustment, 665 + yAdjustment),
                              New Point(450 + xAdjustment, 593 + yAdjustment),
                              New Font("Arial", 10),
                              New Point(x:=xAdjustment, y:=yAdjustment)
                          ))
        ChequeFormats.Add(5, New DefaultChequeFormat(
                              New Point(0 + xAdjustment, 605 + yAdjustment),
                              New Point(0 + xAdjustment, 620 + yAdjustment),
                              New Point(615 + xAdjustment, 618 + yAdjustment),
                              New Point(90 + xAdjustment, 645 + yAdjustment),
                              New Point(600 + xAdjustment, 590 + yAdjustment),
                              font,
                              New Point(x:=xAdjustment, y:=yAdjustment)
                          ))
        ChequeFormats.Add(6, New DefaultChequeFormat(
                              New Point(0 + xAdjustment, 595 + yAdjustment),
                              New Point(0 + xAdjustment, 615 + yAdjustment),
                              New Point(610 + xAdjustment, 620 + yAdjustment),
                              New Point(80 + xAdjustment, 648 + yAdjustment),
                              New Point(580 + xAdjustment, 585 + yAdjustment),
                              font,
                              New Point(x:=xAdjustment, y:=yAdjustment)
                          ))
        ChequeFormats.Add(7, New MBChequeFormat(
                              payee1Location:=New Point(0 + xAdjustment, 605 + yAdjustment),
                              payee2Location:=New Point(0 + xAdjustment, 620 + yAdjustment),
                              amountLocation:=New Point(600 + xAdjustment, 618 + yAdjustment),
                              amountInWordsLocation:=New Point(90 + xAdjustment, 645 + yAdjustment),
                              chequeDateLocation:=New Point(580 + xAdjustment, 590 + yAdjustment),
                              font:=font,
                              _crossCheckPoint:=New Point(x:=xAdjustment, y:=yAdjustment)
                          ))
    End Sub






End Class
