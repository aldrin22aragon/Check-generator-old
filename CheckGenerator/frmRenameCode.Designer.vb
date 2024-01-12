<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRenameCode
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
        Me.tbNewCode = New System.Windows.Forms.TextBox()
        Me.lbMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbNewCode
        '
        Me.tbNewCode.Location = New System.Drawing.Point(156, 12)
        Me.tbNewCode.Name = "tbNewCode"
        Me.tbNewCode.Size = New System.Drawing.Size(92, 20)
        Me.tbNewCode.TabIndex = 0
        '
        'lbMessage
        '
        Me.lbMessage.Location = New System.Drawing.Point(12, 15)
        Me.lbMessage.Name = "lbMessage"
        Me.lbMessage.Size = New System.Drawing.Size(138, 23)
        Me.lbMessage.TabIndex = 1
        Me.lbMessage.Text = "CHANGE #### TO"
        '
        'frmRenameCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(260, 49)
        Me.Controls.Add(Me.lbMessage)
        Me.Controls.Add(Me.tbNewCode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRenameCode"
        Me.ShowIcon = False
        Me.Text = "RENAME CODE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbNewCode As TextBox
    Friend WithEvents lbMessage As Label
End Class
