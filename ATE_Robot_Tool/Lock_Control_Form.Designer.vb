<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lock_Control_Form
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Show_Lab = New System.Windows.Forms.Label()
        Me.Confirm_B = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Show_Lab
        '
        Me.Show_Lab.AutoSize = True
        Me.Show_Lab.Font = New System.Drawing.Font("新宋体", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Show_Lab.ForeColor = System.Drawing.Color.Red
        Me.Show_Lab.Location = New System.Drawing.Point(10, 53)
        Me.Show_Lab.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Show_Lab.Name = "Show_Lab"
        Me.Show_Lab.Size = New System.Drawing.Size(432, 29)
        Me.Show_Lab.TabIndex = 0
        Me.Show_Lab.Text = "維護人員作業中,禁止操作手臂"
        '
        'Confirm_B
        '
        Me.Confirm_B.Font = New System.Drawing.Font("新宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Confirm_B.ForeColor = System.Drawing.Color.Blue
        Me.Confirm_B.Location = New System.Drawing.Point(150, 156)
        Me.Confirm_B.Margin = New System.Windows.Forms.Padding(4)
        Me.Confirm_B.Name = "Confirm_B"
        Me.Confirm_B.Size = New System.Drawing.Size(150, 37)
        Me.Confirm_B.TabIndex = 1
        Me.Confirm_B.Text = "Confirm OK"
        Me.Confirm_B.UseVisualStyleBackColor = True
        '
        'Lock_Control_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 222)
        Me.ControlBox = False
        Me.Controls.Add(Me.Confirm_B)
        Me.Controls.Add(Me.Show_Lab)
        Me.Font = New System.Drawing.Font("新宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Lock_Control_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Operator Warning !!!"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Show_Lab As System.Windows.Forms.Label
    Friend WithEvents Confirm_B As System.Windows.Forms.Button
End Class
