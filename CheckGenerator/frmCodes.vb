Imports System.ComponentModel
Imports System.Data.SQLite

Public Class frmCodes

    Private SelectedPayee As New CodeInf

    Private Sub Check_Records_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Worker.WorkerSupportsCancellation = True

        RefreshCodes()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click, btnAdd.Click
        If tbCode.Text <> "" Then
            With SelectedPayee
                .Code = tbCode.Text
                .CheckType = tbCheckType.Text
                If sender.name = btnAdd.Name Then
                    ExecuteNonQuery(SelectedPayee.ToInsertQuery)
                    MessageBox.Show("Code has been added.")
                Else ExecuteNonQuery(SelectedPayee.ToUpdateQuery)
                    MessageBox.Show("Code has been edited.")
                End If
            End With

            RefreshCodes()
        End If
    End Sub

    Private Sub lstRecords_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRecords.SelectedIndexChanged
        If lstRecords.SelectedItems.Count > 0 Then

            With SelectedPayee
                .ID = lstRecords.SelectedItems(0).SubItems(0).Text
                .Code = lstRecords.SelectedItems(0).SubItems(1).Text
                .CheckType = lstRecords.SelectedItems(0).SubItems(2).Text

                tbCode.Text = .Code
                tbCheckType.Text = .CheckType
            End With
        End If
    End Sub

    Private Sub clear()
        tbCode.Text = ""
        tbCheckType.Text = ""
    End Sub

    Public Sub enableInput(Optional enable As Boolean = False)
        tbCode.ReadOnly = Not enable
        tbCheckType.ReadOnly = Not enable
    End Sub


    Private Sub TryRunWorker(args)
        If Worker.IsBusy Then
            If Not Worker.CancellationPending Then Worker.CancelAsync()
        Else
            enableInput()
            Worker.RunWorkerAsync(args)
        End If

    End Sub

    'Private Sub btnRenameCode_Click(sender As Object, e As EventArgs)
    '    If tbCode.Text <> "" Then
    '        Using re As New frmRenameCode(tbCode.Text)
    '            If re.ShowDialog = DialogResult.OK Then
    '                ExecuteNonQuery(.ToRenameCodeQuery(tbCode.Text, re.NewCode))
    '            End If
    '            tbCode.Text = re.NewCode
    '        End Using
    '    End If
    'End Sub

    Private Sub btnDeleteCode_Click(sender As Object, e As EventArgs) Handles btnDeleteCode.Click
        If tbCode.Text <> "" AndAlso MessageBox.Show("Delete Code " & SelectedPayee.Code & "?", "DELETE CODE", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = DialogResult.Yes Then
            ExecuteNonQuery(CodeInf.ToDeleteCodeQuery(tbCode.Text))

            MessageBox.Show("Code has been deleted.")

            RefreshCodes()
        End If
    End Sub

    Private Sub RefreshCodes()
        Using sqlcon As New SQLite.SQLiteConnection(Constr)
            sqlcon.Open()
            Dim paycom As New SQLiteCommand()
            Dim payread As SQLite.SQLiteDataReader

            paycom = New SQLiteCommand(CodeInf.ToGetCodeList, sqlcon)
            payread = paycom.ExecuteReader
            lstRecords.Items.Clear()
            While payread.Read
                lstRecords.Items.Add(New ListViewItem({payread("Id").ToString, payread("Code").ToString, payread("CheckType").ToString}))
            End While

        End Using
    End Sub
End Class