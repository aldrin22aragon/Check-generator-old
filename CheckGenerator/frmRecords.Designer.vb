<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecords
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstRecords = New System.Windows.Forms.ListView()
        Me.itmnum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pay1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pay2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.amount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chktype = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.tbDelete = New System.Windows.Forms.Button()
        Me.tbCode = New System.Windows.Forms.TextBox()
        Me.tbPayee2 = New System.Windows.Forms.TextBox()
        Me.tbPayee1 = New System.Windows.Forms.TextBox()
        Me.tbAmount = New System.Windows.Forms.TextBox()
        Me.tbDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnRenameCode = New System.Windows.Forms.Button()
        Me.Worker = New System.ComponentModel.BackgroundWorker()
        Me.btnDeleteCode = New System.Windows.Forms.Button()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.PB1 = New System.Windows.Forms.ProgressBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbCheckType = New System.Windows.Forms.TextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstRecords
        '
        Me.lstRecords.AllowDrop = True
        Me.lstRecords.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstRecords.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.itmnum, Me.code, Me.dt, Me.pay1, Me.pay2, Me.amount, Me.chktype})
        Me.lstRecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRecords.FullRowSelect = True
        Me.lstRecords.GridLines = True
        Me.lstRecords.HideSelection = False
        Me.lstRecords.Location = New System.Drawing.Point(11, 117)
        Me.lstRecords.Margin = New System.Windows.Forms.Padding(2)
        Me.lstRecords.Name = "lstRecords"
        Me.lstRecords.Size = New System.Drawing.Size(951, 220)
        Me.lstRecords.TabIndex = 1
        Me.lstRecords.UseCompatibleStateImageBehavior = False
        Me.lstRecords.View = System.Windows.Forms.View.Details
        '
        'itmnum
        '
        Me.itmnum.Text = "ID"
        Me.itmnum.Width = 48
        '
        'code
        '
        Me.code.Text = "CODE"
        Me.code.Width = 87
        '
        'dt
        '
        Me.dt.Text = "DATE"
        Me.dt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.dt.Width = 123
        '
        'pay1
        '
        Me.pay1.Text = "PAYEE LINE 1"
        Me.pay1.Width = 257
        '
        'pay2
        '
        Me.pay2.Text = "PAYEE LINE 2"
        Me.pay2.Width = 270
        '
        'amount
        '
        Me.amount.Text = "AMOUNT"
        Me.amount.Width = 91
        '
        'chktype
        '
        Me.chktype.Text = "TYPE"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(323, 89)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(47, 23)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'tbDelete
        '
        Me.tbDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbDelete.Location = New System.Drawing.Point(828, 88)
        Me.tbDelete.Name = "tbDelete"
        Me.tbDelete.Size = New System.Drawing.Size(134, 23)
        Me.tbDelete.TabIndex = 3
        Me.tbDelete.Text = "DELETE SELECTED"
        Me.tbDelete.UseVisualStyleBackColor = True
        '
        'tbCode
        '
        Me.tbCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.tbCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbCode.Location = New System.Drawing.Point(93, 6)
        Me.tbCode.Name = "tbCode"
        Me.tbCode.Size = New System.Drawing.Size(75, 20)
        Me.tbCode.TabIndex = 4
        '
        'tbPayee2
        '
        Me.tbPayee2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbPayee2.Location = New System.Drawing.Point(93, 62)
        Me.tbPayee2.Name = "tbPayee2"
        Me.tbPayee2.Size = New System.Drawing.Size(277, 20)
        Me.tbPayee2.TabIndex = 5
        '
        'tbPayee1
        '
        Me.tbPayee1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbPayee1.Location = New System.Drawing.Point(93, 35)
        Me.tbPayee1.Name = "tbPayee1"
        Me.tbPayee1.Size = New System.Drawing.Size(277, 20)
        Me.tbPayee1.TabIndex = 6
        '
        'tbAmount
        '
        Me.tbAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbAmount.Location = New System.Drawing.Point(93, 91)
        Me.tbAmount.Name = "tbAmount"
        Me.tbAmount.Size = New System.Drawing.Size(75, 20)
        Me.tbAmount.TabIndex = 7
        '
        'tbDate
        '
        Me.tbDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tbDate.Location = New System.Drawing.Point(283, 6)
        Me.tbDate.Name = "tbDate"
        Me.tbDate.Size = New System.Drawing.Size(87, 20)
        Me.tbDate.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(241, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "DATE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "PAYEE LINE 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "CODE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "AMOUNT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "PAYEE LINE 2"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(175, 3)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(60, 23)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnRenameCode
        '
        Me.btnRenameCode.Location = New System.Drawing.Point(376, 4)
        Me.btnRenameCode.Name = "btnRenameCode"
        Me.btnRenameCode.Size = New System.Drawing.Size(123, 23)
        Me.btnRenameCode.TabIndex = 16
        Me.btnRenameCode.Text = "RENAME CODE"
        Me.btnRenameCode.UseVisualStyleBackColor = True
        Me.btnRenameCode.Visible = False
        '
        'Worker
        '
        '
        'btnDeleteCode
        '
        Me.btnDeleteCode.Location = New System.Drawing.Point(376, 33)
        Me.btnDeleteCode.Name = "btnDeleteCode"
        Me.btnDeleteCode.Size = New System.Drawing.Size(123, 23)
        Me.btnDeleteCode.TabIndex = 17
        Me.btnDeleteCode.Text = "DELETE CODE"
        Me.btnDeleteCode.UseVisualStyleBackColor = True
        Me.btnDeleteCode.Visible = False
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Location = New System.Drawing.Point(376, 89)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(123, 23)
        Me.btnSaveChanges.TabIndex = 18
        Me.btnSaveChanges.Text = "SAVE CHANGES"
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        Me.btnSaveChanges.Visible = False
        '
        'PB1
        '
        Me.PB1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PB1.Location = New System.Drawing.Point(0, 343)
        Me.PB1.Name = "PB1"
        Me.PB1.Size = New System.Drawing.Size(973, 5)
        Me.PB1.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(174, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "CHECK TYPE"
        '
        'tbCheckType
        '
        Me.tbCheckType.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbCheckType.Location = New System.Drawing.Point(254, 91)
        Me.tbCheckType.Name = "tbCheckType"
        Me.tbCheckType.Size = New System.Drawing.Size(63, 20)
        Me.tbCheckType.TabIndex = 21
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(887, 4)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 24
        Me.btnRefresh.Text = "REFRESH"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'frmRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 348)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbCheckType)
        Me.Controls.Add(Me.PB1)
        Me.Controls.Add(Me.btnSaveChanges)
        Me.Controls.Add(Me.btnDeleteCode)
        Me.Controls.Add(Me.btnRenameCode)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbDate)
        Me.Controls.Add(Me.tbAmount)
        Me.Controls.Add(Me.tbPayee1)
        Me.Controls.Add(Me.tbPayee2)
        Me.Controls.Add(Me.tbCode)
        Me.Controls.Add(Me.tbDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lstRecords)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmRecords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Records"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstRecords As System.Windows.Forms.ListView
    Friend WithEvents itmnum As System.Windows.Forms.ColumnHeader
    Friend WithEvents code As System.Windows.Forms.ColumnHeader
    Friend WithEvents dt As System.Windows.Forms.ColumnHeader
    Friend WithEvents pay1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents pay2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents amount As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnAdd As Button
    Friend WithEvents tbDelete As Button
    Friend WithEvents tbCode As TextBox
    Friend WithEvents tbPayee2 As TextBox
    Friend WithEvents tbPayee1 As TextBox
    Friend WithEvents tbAmount As TextBox
    Friend WithEvents tbDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnRenameCode As Button
    Friend WithEvents Worker As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnDeleteCode As Button
    Friend WithEvents btnSaveChanges As Button
    Friend WithEvents PB1 As ProgressBar
    Friend WithEvents Label6 As Label
    Friend WithEvents tbCheckType As TextBox
    Friend WithEvents chktype As ColumnHeader
    Friend WithEvents btnRefresh As Button
End Class
