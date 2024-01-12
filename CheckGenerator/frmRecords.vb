Imports System.ComponentModel
Imports System.Data.SQLite

Public Class frmRecords

    Private SelectedPayee As New PayeeInf

    Private Sub Check_Records_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Worker.WorkerSupportsCancellation = True
        SelectedPayee.Action = PayeeInf.ActionType.Add
        enableInput(True)

        btnRefresh.PerformClick()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click, btnSaveChanges.Click
        If tbCode.Text <> "" Then
            With SelectedPayee
                If sender.name = btnAdd.Name Then
                    .Action = PayeeInf.ActionType.Add
                Else .Action = PayeeInf.ActionType.Edit
                End If
                .Amount = tbAmount.Text
                .Code = tbCode.Text
                .Payee1 = tbPayee1.Text
                .Payee2 = tbPayee2.Text
                ._date = tbDate.Value.ToString("MMM dd, yyyy")
                .CheckType = tbCheckType.Text
            End With

            ExecuteNonQuery(SelectedPayee.ToSaveQuery)
            MessageBox.Show("Code has been added.")

            clear()
            tbCode.Text = SelectedPayee.Code
        End If
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        SelectedPayee.Action = PayeeInf.ActionType.Add
        clear()
    End Sub

    Private Sub tbDelete_Click(sender As Object, e As EventArgs) Handles tbDelete.Click
        If tbCode.Text <> "" AndAlso MessageBox.Show("Delete " & lstRecords.SelectedItems.Count & " records?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim qry As String = ""
            For i As Integer = 0 To lstRecords.SelectedItems.Count - 1
                qry &= PayeeInf.ToDeleteQuery(lstRecords.SelectedItems(i).SubItems(0).Text)
            Next
            ExecuteNonQuery(qry)

            MessageBox.Show("selected Records has been deleted.")

            clear()
            tbCode.Text = SelectedPayee.Code
        End If
    End Sub

    Private Sub lstRecords_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRecords.SelectedIndexChanged
        If lstRecords.SelectedItems.Count > 1 Then
            SelectedPayee.Action = PayeeInf.ActionType.MultiSelect
            enableInput()
        ElseIf lstRecords.SelectedItems.Count = 1 Then
            SelectedPayee.Action = PayeeInf.ActionType.Edit
            With SelectedPayee
                .ID = lstRecords.SelectedItems(0).SubItems(0).Text
                .Code = lstRecords.SelectedItems(0).SubItems(1).Text

                If lstRecords.SelectedItems(0).SubItems(2).Text <> "" Then
                    ._date = Date.Parse(lstRecords.SelectedItems(0).SubItems(2).Text)
                Else ._date = Now
                End If

                .Payee1 = lstRecords.SelectedItems(0).SubItems(3).Text
                .Payee2 = lstRecords.SelectedItems(0).SubItems(4).Text
                .Amount = lstRecords.SelectedItems(0).SubItems(5).Text
                .CheckType = lstRecords.SelectedItems(0).SubItems(6).Text

                tbAmount.Text = .Amount
                tbCode.Text = .Code
                tbDate.Value = ._date
                tbPayee1.Text = .Payee1
                tbPayee2.Text = .Payee2
                tbCheckType.Text = .CheckType
                enableInput(True)
            End With
        End If
    End Sub

    Private Sub clear()
        tbAmount.Text = ""
        tbCode.Text = ""
        tbPayee1.Text = ""
        tbPayee2.Text = ""
        tbCheckType.Text = ""
    End Sub

    Public Sub enableInput(Optional enable As Boolean = False)
        tbAmount.ReadOnly = Not enable
        tbCode.ReadOnly = Not enable
        tbDate.Enabled = enable
        tbPayee1.ReadOnly = Not enable
        tbPayee2.ReadOnly = Not enable
        tbCheckType.ReadOnly = Not enable
    End Sub

    Private Sub tbCode_TextChanged(sender As Object, e As EventArgs) Handles tbCode.TextChanged
        lstRecords.Items.Clear()
        If tbCode.TextLength > 2 Then
            TryRunWorker({tbCode.Text, 1})
        End If
    End Sub

    Private Sub Worker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Worker.DoWork
        Try
            Using sqlcon As New SQLite.SQLiteConnection(Constr)
                sqlcon.Open()
                Dim paycom As New SQLiteCommand()
                Select Case e.Argument(1)
                    Case 0
                        paycom = New SQLiteCommand(PayeeInf.ToSelectQuery(), sqlcon)
                    Case 1
                        paycom = New SQLiteCommand(PayeeInf.ToSelectCodeQuery(e.Argument(0)), sqlcon)
                    Case 2
                        paycom = New SQLiteCommand(PayeeInf.ToSelectByGroupQuery(e.Argument(0)), sqlcon)
                End Select

                Dim payread As SQLite.SQLiteDataReader
                payread = paycom.ExecuteReader

                Dim newlist As New List(Of ListViewItem)
                While payread.Read
                    If Not e.Cancel Then
                        Dim itm As New ListViewItem({payread(0).ToString, payread(1).ToString, payread(2).ToString, payread(3).ToString, payread(4).ToString, payread(5).ToString, payread(6).ToString})
                        newlist.Add(itm.Clone)
                    Else
                        Exit While
                    End If
                End While
                lstRecords.Invoke(Sub()
                                      lstRecords.Items.AddRange(newlist.ToArray)
                                      enableInput(True)
                                  End Sub)
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Worker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles Worker.RunWorkerCompleted

    End Sub

    Private Sub TryRunWorker(args)
        If Worker.IsBusy Then
            If Not Worker.CancellationPending Then Worker.CancelAsync()
        Else
            enableInput()
            Worker.RunWorkerAsync(args)
        End If

    End Sub

    Private Sub btnRenameCode_Click(sender As Object, e As EventArgs) Handles btnRenameCode.Click
        If tbCode.Text <> "" Then
            Using re As New frmRenameCode(tbCode.Text)
                If re.ShowDialog = DialogResult.OK Then
                    ExecuteNonQuery(PayeeInf.ToRenameCodeQuery(tbCode.Text, re.NewCode))
                End If
                tbCode.Text = re.NewCode
            End Using
        End If
    End Sub

    Private Sub btnDeleteCode_Click(sender As Object, e As EventArgs) Handles btnDeleteCode.Click
        If tbCode.Text <> "" AndAlso MessageBox.Show("Delete Code " & SelectedPayee.Code & "?", "DELETE CODE", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = DialogResult.Yes Then
            ExecuteNonQuery(PayeeInf.ToDeleteCodeQuery(tbCode.Text))

            MessageBox.Show("Code has been deleted.")

            btnRefresh.PerformClick()
        End If
    End Sub

    Private Sub btnDeleteDuplicates_Click(sender As Object, e As EventArgs)
        Dim qry As String = ""
        Using sqlcon As New SQLite.SQLiteConnection(Constr)
            sqlcon.Open()
            Dim paycom As New SQLiteCommand()
            Dim payread As SQLite.SQLiteDataReader

            paycom = New SQLiteCommand(PayeeInf.ToCheckDuplicateQuery(), sqlcon)
            payread = paycom.ExecuteReader

            While payread.Read
                Dim newPayee As New PayeeInf(payread)
                qry &= newPayee.ToInsertQuery
            End While
            'Else MessageBox.Show("No Duplicate Found.", "DELETE DUPLICATES", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If
        End Using

        If MessageBox.Show("Delete All Duplicates?", "DELETE DUPLICATES", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = DialogResult.Yes Then
            ExecuteNonQuery(PayeeInf.ToTruncateQuery())
            ExecuteNonQuery(qry)
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Using sqlcon As New SQLite.SQLiteConnection(Constr)
            sqlcon.Open()
            Dim paycom As New SQLiteCommand()
            Dim payread As SQLite.SQLiteDataReader

            paycom = New SQLiteCommand(PayeeInf.ToSelectByGroupQuery("Code"), sqlcon)
            payread = paycom.ExecuteReader
            Dim autoCode As New AutoCompleteStringCollection
            While payread.Read
                autoCode.Add(payread(1).ToString)
            End While
            tbCode.AutoCompleteCustomSource = autoCode


        End Using
    End Sub
End Class