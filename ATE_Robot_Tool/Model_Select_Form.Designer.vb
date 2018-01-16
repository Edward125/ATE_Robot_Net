<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Robot_Tool_Sel
    Inherits System.Windows.Forms.Form


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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Robot_Tool_Sel))
        Me.CD_MT = New System.Windows.Forms.Button()
        Me.AB_MT = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CD_MT
        '
        Me.CD_MT.BackColor = System.Drawing.Color.SkyBlue
        Me.CD_MT.Cursor = System.Windows.Forms.Cursors.Default
        Me.CD_MT.Font = New System.Drawing.Font("新宋体", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CD_MT.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.CD_MT.Location = New System.Drawing.Point(187, 9)
        Me.CD_MT.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CD_MT.Name = "CD_MT"
        Me.CD_MT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CD_MT.Size = New System.Drawing.Size(169, 104)
        Me.CD_MT.TabIndex = 3
        Me.CD_MT.Text = "Client"
        Me.CD_MT.UseVisualStyleBackColor = False
        '
        'AB_MT
        '
        Me.AB_MT.BackColor = System.Drawing.Color.SkyBlue
        Me.AB_MT.Cursor = System.Windows.Forms.Cursors.Default
        Me.AB_MT.Font = New System.Drawing.Font("新宋体", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.AB_MT.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.AB_MT.Location = New System.Drawing.Point(7, 9)
        Me.AB_MT.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.AB_MT.Name = "AB_MT"
        Me.AB_MT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.AB_MT.Size = New System.Drawing.Size(169, 104)
        Me.AB_MT.TabIndex = 2
        Me.AB_MT.Text = "Main"
        Me.AB_MT.UseVisualStyleBackColor = False
        '
        'Robot_Tool_Sel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 121)
        Me.Controls.Add(Me.CD_MT)
        Me.Controls.Add(Me.AB_MT)
        Me.Font = New System.Drawing.Font("新宋体", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Robot_Tool_Sel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ATE Robot Tool For WCD Ver "
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents CD_MT As System.Windows.Forms.Button
    Public WithEvents AB_MT As System.Windows.Forms.Button

End Class
