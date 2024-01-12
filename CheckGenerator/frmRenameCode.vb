Public Class frmRenameCode

    Public NewCode As String
    Sub New(_code As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lbMessage.Text = "CHANGE " & _code & " TO "
    End Sub

    Private Sub tbNewCode_KeyDown(sender As Object, e As KeyEventArgs) Handles tbNewCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            If MessageBox.Show("You sure?") = DialogResult.Yes Then
                DialogResult = DialogResult.OK
            End If
        End If
    End Sub
End Class