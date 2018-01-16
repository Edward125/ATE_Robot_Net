Imports System

Public Class Robot_Tool_Sel
    Dim Tool_Ver As Object

    Private Sub AB_MT_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles AB_MT.Click

        Main_Form.Show()
        Main_Form.Text = Main_Form.Text & Tool_Ver
        Me.Hide()

    End Sub


    Private Sub CD_MT_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CD_MT.Click

        Client_Form.Show()
        Client_Form.Text = Client_Form.Text & Tool_Ver
        Me.Hide()

    End Sub


    Private Sub Sel_MT_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        If Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1 Then
            MsgBox("Repeated open Robot Rool!", MsgBoxStyle.Critical, "Error")
            Application.Exit()
        End If

        Tool_Ver = "11.03"
        Me.Text = Me.Text & Tool_Ver

    End Sub


End Class
