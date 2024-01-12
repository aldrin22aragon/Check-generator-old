<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCodes
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbCheckType = New System.Windows.Forms.TextBox()
        Me.btnDeleteCode = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbCode = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lstRecords = New System.Windows.Forms.ListView()
        Me.itmnum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chktype = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Worker = New System.ComponentModel.BackgroundWorker()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "CHECK TYPE"
        '
        'tbCheckType
        '
        Me.tbCheckType.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbCheckType.Location = New System.Drawing.Point(92, 30)
        Me.tbCheckType.Name = "tbCheckType"
        Me.tbCheckType.Size = New System.Drawing.Size(76, 20)
        Me.tbCheckType.TabIndex = 30
        '
        'btnDeleteCode
        '
        Me.btnDeleteCode.Location = New System.Drawing.Point(303, 28)
        Me.btnDeleteCode.Name = "btnDeleteCode"
        Me.btnDeleteCode.Size = New System.Drawing.Size(123, 23)
        Me.btnDeleteCode.TabIndex = 28
        Me.btnDeleteCode.Text = "DELETE CODE"
        Me.btnDeleteCode.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "CODE"
        '
        'tbCode
        '
        Me.tbCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.tbCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbCode.Location = New System.Drawing.Point(92, 6)
        Me.tbCode.Name = "tbCode"
        Me.tbCode.Size = New System.Drawing.Size(76, 20)
        Me.tbCode.TabIndex = 24
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(174, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(123, 23)
        Me.btnAdd.TabIndex = 23
        Me.btnAdd.Text = "ADD CODE"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lstRecords
        '
        Me.lstRecords.AllowDrop = True
        Me.lstRecords.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstRecords.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.itmnum, Me.code, Me.chktype})
        Me.lstRecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRecords.FullRowSelect = True
        Me.lstRecords.GridLines = True
        Me.lstRecords.HideSelection = False
        Me.lstRecords.Location = New System.Drawing.Point(11, 55)
        Me.lstRecords.Margin = New System.Windows.Forms.Padding(2)
        Me.lstRecords.Name = "lstRecords"
        Me.lstRecords.Size = New System.Drawing.Size(415, 265)
        Me.lstRecords.TabIndex = 32
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
        Me.code.Width = 108
        '
        'chktype
        '
        Me.chktype.Text = "TYPE"
        Me.chktype.Width = 52
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Location = New System.Drawing.Point(174, 28)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(123, 23)
        Me.btnSaveChanges.TabIndex = 33
        Me.btnSaveChanges.Text = "SAVE CHANGES"
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        '
        'frmCodes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 331)
        Me.Controls.Add(Me.btnSaveChanges)
        Me.Controls.Add(Me.lstRecords)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbCheckType)
        Me.Controls.Add(Me.btnDeleteCode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbCode)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "frmCodes"
        Me.Text = "frmCodes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents tbCheckType As TextBox
    Friend WithEvents btnDeleteCode As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents tbCode As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents lstRecords As ListView
    Friend WithEvents itmnum As ColumnHeader
    Friend WithEvents code As ColumnHeader
    Friend WithEvents chktype As ColumnHeader
    Friend WithEvents Worker As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnSaveChanges As Button
End Class
