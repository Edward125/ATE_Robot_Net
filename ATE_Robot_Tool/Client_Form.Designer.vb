<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Client_Form
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Client_Form))
        Me.Start_B = New System.Windows.Forms.Button()
        Me.TimerDel = New System.Windows.Forms.Timer(Me.components)
        Me.Status_Lab3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Status_Lab1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Status_Lab2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusBar1 = New System.Windows.Forms.StatusStrip()
        Me.TimerR = New System.Windows.Forms.Timer(Me.components)
        Me.CD_IP_Txt = New System.Windows.Forms.TextBox()
        Me.Show_Lst = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IP_Lab = New System.Windows.Forms.Label()
        Me.ConState_Txt = New System.Windows.Forms.TextBox()
        Me.Buff_Lst = New System.Windows.Forms.ListBox()
        Me.Timer_Send_Buffer = New System.Windows.Forms.Timer(Me.components)
        Me.Temp_B = New System.Windows.Forms.Button()
        Me.Temp_Txt = New System.Windows.Forms.TextBox()
        Me.StatusBar1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Start_B
        '
        Me.Start_B.BackColor = System.Drawing.SystemColors.Control
        Me.Start_B.Cursor = System.Windows.Forms.Cursors.Default
        Me.Start_B.Font = New System.Drawing.Font("新宋体", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Start_B.ForeColor = System.Drawing.Color.Blue
        Me.Start_B.Location = New System.Drawing.Point(153, 203)
        Me.Start_B.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Start_B.Name = "Start_B"
        Me.Start_B.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Start_B.Size = New System.Drawing.Size(89, 32)
        Me.Start_B.TabIndex = 31
        Me.Start_B.Text = "Start"
        Me.Start_B.UseVisualStyleBackColor = False
        '
        'TimerDel
        '
        Me.TimerDel.Interval = 300
        '
        'Status_Lab3
        '
        Me.Status_Lab3.AutoSize = False
        Me.Status_Lab3.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.Status_Lab3.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.Status_Lab3.Margin = New System.Windows.Forms.Padding(0)
        Me.Status_Lab3.Name = "Status_Lab3"
        Me.Status_Lab3.Size = New System.Drawing.Size(133, 22)
        '
        'Status_Lab1
        '
        Me.Status_Lab1.AutoSize = False
        Me.Status_Lab1.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.Status_Lab1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.Status_Lab1.Font = New System.Drawing.Font("新宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Status_Lab1.Margin = New System.Windows.Forms.Padding(0)
        Me.Status_Lab1.Name = "Status_Lab1"
        Me.Status_Lab1.Size = New System.Drawing.Size(133, 22)
        Me.Status_Lab1.Text = "Robot Barcode Tool"
        '
        'Status_Lab2
        '
        Me.Status_Lab2.AutoSize = False
        Me.Status_Lab2.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.Status_Lab2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.Status_Lab2.Font = New System.Drawing.Font("新宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Status_Lab2.Margin = New System.Windows.Forms.Padding(0)
        Me.Status_Lab2.Name = "Status_Lab2"
        Me.Status_Lab2.Size = New System.Drawing.Size(122, 22)
        Me.Status_Lab2.Text = "None"
        '
        'StatusBar1
        '
        Me.StatusBar1.Font = New System.Drawing.Font("新宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.StatusBar1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Status_Lab1, Me.Status_Lab2, Me.Status_Lab3})
        Me.StatusBar1.Location = New System.Drawing.Point(0, 241)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Size = New System.Drawing.Size(403, 22)
        Me.StatusBar1.TabIndex = 24
        '
        'TimerR
        '
        Me.TimerR.Interval = 300
        '
        'CD_IP_Txt
        '
        Me.CD_IP_Txt.AcceptsReturn = True
        Me.CD_IP_Txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CD_IP_Txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CD_IP_Txt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CD_IP_Txt.Location = New System.Drawing.Point(140, 171)
        Me.CD_IP_Txt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CD_IP_Txt.MaxLength = 0
        Me.CD_IP_Txt.Name = "CD_IP_Txt"
        Me.CD_IP_Txt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CD_IP_Txt.Size = New System.Drawing.Size(98, 21)
        Me.CD_IP_Txt.TabIndex = 17
        '
        'Show_Lst
        '
        Me.Show_Lst.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Show_Lst.Cursor = System.Windows.Forms.Cursors.Default
        Me.Show_Lst.Font = New System.Drawing.Font("新宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Show_Lst.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Show_Lst.ItemHeight = 12
        Me.Show_Lst.Location = New System.Drawing.Point(8, 20)
        Me.Show_Lst.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Show_Lst.Name = "Show_Lst"
        Me.Show_Lst.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Show_Lst.Size = New System.Drawing.Size(385, 148)
        Me.Show_Lst.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("新宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(143, 12)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Show All Communication:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'IP_Lab
        '
        Me.IP_Lab.BackColor = System.Drawing.SystemColors.Control
        Me.IP_Lab.Cursor = System.Windows.Forms.Cursors.Default
        Me.IP_Lab.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IP_Lab.Location = New System.Drawing.Point(11, 173)
        Me.IP_Lab.Name = "IP_Lab"
        Me.IP_Lab.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IP_Lab.Size = New System.Drawing.Size(126, 17)
        Me.IP_Lab.TabIndex = 18
        Me.IP_Lab.Text = "Main ATE IP Address:"
        '
        'ConState_Txt
        '
        Me.ConState_Txt.BackColor = System.Drawing.Color.Gray
        Me.ConState_Txt.Font = New System.Drawing.Font("新宋体", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ConState_Txt.ForeColor = System.Drawing.Color.Yellow
        Me.ConState_Txt.Location = New System.Drawing.Point(244, 171)
        Me.ConState_Txt.Name = "ConState_Txt"
        Me.ConState_Txt.ReadOnly = True
        Me.ConState_Txt.Size = New System.Drawing.Size(149, 22)
        Me.ConState_Txt.TabIndex = 32
        Me.ConState_Txt.Text = "No Connect"
        Me.ConState_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Buff_Lst
        '
        Me.Buff_Lst.Font = New System.Drawing.Font("新宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Buff_Lst.FormattingEnabled = True
        Me.Buff_Lst.ItemHeight = 12
        Me.Buff_Lst.Location = New System.Drawing.Point(414, 20)
        Me.Buff_Lst.Name = "Buff_Lst"
        Me.Buff_Lst.Size = New System.Drawing.Size(284, 76)
        Me.Buff_Lst.TabIndex = 33
        Me.Buff_Lst.Visible = False
        '
        'Timer_Send_Buffer
        '
        Me.Timer_Send_Buffer.Interval = 50
        '
        'Temp_B
        '
        Me.Temp_B.Location = New System.Drawing.Point(449, 138)
        Me.Temp_B.Name = "Temp_B"
        Me.Temp_B.Size = New System.Drawing.Size(115, 29)
        Me.Temp_B.TabIndex = 34
        Me.Temp_B.Text = "Temp Button"
        Me.Temp_B.UseVisualStyleBackColor = True
        Me.Temp_B.Visible = False
        '
        'Temp_Txt
        '
        Me.Temp_Txt.Location = New System.Drawing.Point(414, 102)
        Me.Temp_Txt.Name = "Temp_Txt"
        Me.Temp_Txt.Size = New System.Drawing.Size(214, 21)
        Me.Temp_Txt.TabIndex = 35
        Me.Temp_Txt.Visible = False
        '
        'Client_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 263)
        Me.Controls.Add(Me.Temp_Txt)
        Me.Controls.Add(Me.Temp_B)
        Me.Controls.Add(Me.Buff_Lst)
        Me.Controls.Add(Me.ConState_Txt)
        Me.Controls.Add(Me.Start_B)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.CD_IP_Txt)
        Me.Controls.Add(Me.Show_Lst)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IP_Lab)
        Me.Font = New System.Drawing.Font("新宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Client_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ATE Robot Tool Ver "
        Me.StatusBar1.ResumeLayout(False)
        Me.StatusBar1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Start_B As System.Windows.Forms.Button
    Public WithEvents TimerDel As System.Windows.Forms.Timer
    Public WithEvents Status_Lab3 As System.Windows.Forms.ToolStripStatusLabel
    Public WithEvents Status_Lab1 As System.Windows.Forms.ToolStripStatusLabel
    Public WithEvents Status_Lab2 As System.Windows.Forms.ToolStripStatusLabel
    Public WithEvents StatusBar1 As System.Windows.Forms.StatusStrip
    Public WithEvents TimerR As System.Windows.Forms.Timer
    Public WithEvents CD_IP_Txt As System.Windows.Forms.TextBox
    Public WithEvents Show_Lst As System.Windows.Forms.ListBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents IP_Lab As System.Windows.Forms.Label
    Friend WithEvents ConState_Txt As System.Windows.Forms.TextBox
    Friend WithEvents Buff_Lst As System.Windows.Forms.ListBox
    Friend WithEvents Timer_Send_Buffer As System.Windows.Forms.Timer
    Friend WithEvents Temp_B As System.Windows.Forms.Button
    Friend WithEvents Temp_Txt As System.Windows.Forms.TextBox
End Class
