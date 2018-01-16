Public Class Lock_Control_Form

    Private Sub Confirm_B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Confirm_B.Click
        Me.Close()
    End Sub

    Private Sub Lock_Control_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = Main_Form.Location
        Me.Top = Me.Top + 130
        Me.Left = Me.Left + 122
    End Sub
End Class