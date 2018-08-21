<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Form))
        Me.ATE_DSt = New System.Windows.Forms.Button()
        Me.ATE_CSt = New System.Windows.Forms.Button()
        Me.Timer_ATE_F = New System.Windows.Forms.Timer(Me.components)
        Me.ATE_BSt = New System.Windows.Forms.Button()
        Me.Show_Lst = New System.Windows.Forms.ListBox()
        Me.Timer_DEL_F = New System.Windows.Forms.Timer(Me.components)
        Me.Start_B = New System.Windows.Forms.Button()
        Me.Timer_SN = New System.Windows.Forms.Timer(Me.components)
        Me.AB_IP_Lab = New System.Windows.Forms.Label()
        Me.ATE_AST = New System.Windows.Forms.Button()
        Me.ATECon_StTxt = New System.Windows.Forms.TextBox()
        Me.DST_Lab = New System.Windows.Forms.Label()
        Me.CST_Lab = New System.Windows.Forms.Label()
        Me.BST_Lab = New System.Windows.Forms.Label()
        Me.AST_Lab = New System.Windows.Forms.Label()
        Me.AB_Connect_Lab = New System.Windows.Forms.Label()
        Me.PLC_RD_Lst = New System.Windows.Forms.ListBox()
        Me.Buff_TCPLst = New System.Windows.Forms.ListBox()
        Me.Timer_Send_Buffer = New System.Windows.Forms.Timer(Me.components)
        Me.St_Lab = New System.Windows.Forms.StatusStrip()
        Me.St_Panel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.St_Panel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.St_Panel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.St_Panel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Err_Count_La = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer_RdPLC = New System.Windows.Forms.Timer(Me.components)
        Me.Astation_B = New System.Windows.Forms.Button()
        Me.PLC_Alarm_Txt = New System.Windows.Forms.TextBox()
        Me.Bstation_B = New System.Windows.Forms.Button()
        Me.Cstation_B = New System.Windows.Forms.Button()
        Me.Dstation_B = New System.Windows.Forms.Button()
        Me.Alarm_Reset_B = New System.Windows.Forms.Button()
        Me.Buzzer_Off_B = New System.Windows.Forms.Button()
        Me.State_GpB = New System.Windows.Forms.GroupBox()
        Me.Dslzz_Close_B = New System.Windows.Forms.Button()
        Me.Cslzz_Close_B = New System.Windows.Forms.Button()
        Me.Bslzz_Close_B = New System.Windows.Forms.Button()
        Me.Aslzz_Close_B = New System.Windows.Forms.Button()
        Me.Dslzz_Open_B = New System.Windows.Forms.Button()
        Me.Cslzz_Open_B = New System.Windows.Forms.Button()
        Me.Bslzz_Open_B = New System.Windows.Forms.Button()
        Me.Aslzz_Open_B = New System.Windows.Forms.Button()
        Me.D_Light_Lab = New System.Windows.Forms.Label()
        Me.D_Sw_Lab = New System.Windows.Forms.Label()
        Me.C_Light_Lab = New System.Windows.Forms.Label()
        Me.C_Sw_Lab = New System.Windows.Forms.Label()
        Me.B_Light_Lab = New System.Windows.Forms.Label()
        Me.B_Sw_Lab = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.A_Light_Lab = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.A_Sw_Lab = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Dpause_B = New System.Windows.Forms.Button()
        Me.Apause_B = New System.Windows.Forms.Button()
        Me.Bpause_B = New System.Windows.Forms.Button()
        Me.Cpause_B = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PLCCon_StTxt = New System.Windows.Forms.TextBox()
        Me.PLC_Start_B = New System.Windows.Forms.Button()
        Me.Manual_Test_B = New System.Windows.Forms.Button()
        Me.PLC_IPTxt = New System.Windows.Forms.TextBox()
        Me.PLC_IP_Lab = New System.Windows.Forms.Label()
        Me.Tool_LogGrpB = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PLC_ReMate_B = New System.Windows.Forms.Button()
        Me.PLC_Origin_B = New System.Windows.Forms.Button()
        Me.PLC_Pause_B = New System.Windows.Forms.Button()
        Me.PLC_Stop_B = New System.Windows.Forms.Button()
        Me.PLC_Model_B = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.SN_Clear_B = New System.Windows.Forms.Button()
        Me.SN_Lst = New System.Windows.Forms.ListBox()
        Me.Set_GpB = New System.Windows.Forms.GroupBox()
        Me.Customer_Cmb = New System.Windows.Forms.ComboBox()
        Me.Multi_SN_Chk = New System.Windows.Forms.CheckBox()
        Me.SetLk_Chk = New System.Windows.Forms.CheckBox()
        Me.SN_ChkRoute = New System.Windows.Forms.CheckBox()
        Me.Customer_Lab = New System.Windows.Forms.Label()
        Me.AxActProgType1 = New AxActProgTypeLib.AxActProgType()
        Me.Lock_Control_B = New System.Windows.Forms.Button()
        Me.St_Lab.SuspendLayout()
        Me.State_GpB.SuspendLayout()
        Me.Tool_LogGrpB.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Set_GpB.SuspendLayout()
        CType(Me.AxActProgType1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ATE_DSt
        '
        Me.ATE_DSt.AutoSize = True
        Me.ATE_DSt.BackColor = System.Drawing.SystemColors.Control
        Me.ATE_DSt.Cursor = System.Windows.Forms.Cursors.Default
        Me.ATE_DSt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ATE_DSt.Font = New System.Drawing.Font("新宋体", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ATE_DSt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ATE_DSt.Location = New System.Drawing.Point(395, 5)
        Me.ATE_DSt.Name = "ATE_DSt"
        Me.ATE_DSt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ATE_DSt.Size = New System.Drawing.Size(39, 26)
        Me.ATE_DSt.TabIndex = 21
        Me.ATE_DSt.Text = "D"
        Me.ATE_DSt.UseVisualStyleBackColor = False
        '
        'ATE_CSt
        '
        Me.ATE_CSt.AutoSize = True
        Me.ATE_CSt.BackColor = System.Drawing.SystemColors.Control
        Me.ATE_CSt.Cursor = System.Windows.Forms.Cursors.Default
        Me.ATE_CSt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ATE_CSt.Font = New System.Drawing.Font("新宋体", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ATE_CSt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ATE_CSt.Location = New System.Drawing.Point(283, 5)
        Me.ATE_CSt.Name = "ATE_CSt"
        Me.ATE_CSt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ATE_CSt.Size = New System.Drawing.Size(39, 26)
        Me.ATE_CSt.TabIndex = 20
        Me.ATE_CSt.Text = "C"
        Me.ATE_CSt.UseVisualStyleBackColor = False
        '
        'Timer_ATE_F
        '
        Me.Timer_ATE_F.Interval = 300
        '
        'ATE_BSt
        '
        Me.ATE_BSt.AutoSize = True
        Me.ATE_BSt.BackColor = System.Drawing.SystemColors.Control
        Me.ATE_BSt.Cursor = System.Windows.Forms.Cursors.Default
        Me.ATE_BSt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ATE_BSt.Font = New System.Drawing.Font("新宋体", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ATE_BSt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ATE_BSt.Location = New System.Drawing.Point(164, 5)
        Me.ATE_BSt.Name = "ATE_BSt"
        Me.ATE_BSt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ATE_BSt.Size = New System.Drawing.Size(39, 26)
        Me.ATE_BSt.TabIndex = 19
        Me.ATE_BSt.Text = "B"
        Me.ATE_BSt.UseVisualStyleBackColor = False
        '
        'Show_Lst
        '
        Me.Show_Lst.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Show_Lst.Cursor = System.Windows.Forms.Cursors.Default
        Me.Show_Lst.Font = New System.Drawing.Font("新宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Show_Lst.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Show_Lst.ItemHeight = 12
        Me.Show_Lst.Location = New System.Drawing.Point(3, 16)
        Me.Show_Lst.Name = "Show_Lst"
        Me.Show_Lst.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Show_Lst.Size = New System.Drawing.Size(467, 100)
        Me.Show_Lst.TabIndex = 1
        '
        'Timer_DEL_F
        '
        Me.Timer_DEL_F.Interval = 1
        '
        'Start_B
        '
        Me.Start_B.BackColor = System.Drawing.SystemColors.Control
        Me.Start_B.Cursor = System.Windows.Forms.Cursors.Default
        Me.Start_B.Font = New System.Drawing.Font("新宋体", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Start_B.ForeColor = System.Drawing.Color.Blue
        Me.Start_B.Location = New System.Drawing.Point(161, 417)
        Me.Start_B.Name = "Start_B"
        Me.Start_B.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Start_B.Size = New System.Drawing.Size(137, 31)
        Me.Start_B.TabIndex = 0
        Me.Start_B.Text = "Start"
        Me.Start_B.UseVisualStyleBackColor = False
        '
        'Timer_SN
        '
        '
        'AB_IP_Lab
        '
        Me.AB_IP_Lab.AutoSize = True
        Me.AB_IP_Lab.Font = New System.Drawing.Font("新宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.AB_IP_Lab.Location = New System.Drawing.Point(500, 181)
        Me.AB_IP_Lab.Name = "AB_IP_Lab"
        Me.AB_IP_Lab.Size = New System.Drawing.Size(107, 12)
        Me.AB_IP_Lab.TabIndex = 45
        Me.AB_IP_Lab.Text = "ATE Connect IP:NA"
        '
        'ATE_AST
        '
        Me.ATE_AST.AutoSize = True
        Me.ATE_AST.BackColor = System.Drawing.SystemColors.Control
        Me.ATE_AST.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ATE_AST.Font = New System.Drawing.Font("新宋体", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ATE_AST.Location = New System.Drawing.Point(50, 5)
        Me.ATE_AST.Name = "ATE_AST"
        Me.ATE_AST.Size = New System.Drawing.Size(39, 26)
        Me.ATE_AST.TabIndex = 18
        Me.ATE_AST.Text = "A"
        Me.ATE_AST.UseVisualStyleBackColor = False
        '
        'ATECon_StTxt
        '
        Me.ATECon_StTxt.BackColor = System.Drawing.Color.Gray
        Me.ATECon_StTxt.Font = New System.Drawing.Font("新宋体", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ATECon_StTxt.ForeColor = System.Drawing.Color.Yellow
        Me.ATECon_StTxt.Location = New System.Drawing.Point(582, 152)
        Me.ATECon_StTxt.Name = "ATECon_StTxt"
        Me.ATECon_StTxt.ReadOnly = True
        Me.ATECon_StTxt.Size = New System.Drawing.Size(90, 21)
        Me.ATECon_StTxt.TabIndex = 34
        Me.ATECon_StTxt.Text = "No Connect"
        Me.ATECon_StTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DST_Lab
        '
        Me.DST_Lab.BackColor = System.Drawing.SystemColors.Control
        Me.DST_Lab.Cursor = System.Windows.Forms.Cursors.Default
        Me.DST_Lab.Font = New System.Drawing.Font("新宋体", 9.75!)
        Me.DST_Lab.ForeColor = System.Drawing.Color.Black
        Me.DST_Lab.Location = New System.Drawing.Point(362, 33)
        Me.DST_Lab.Name = "DST_Lab"
        Me.DST_Lab.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DST_Lab.Size = New System.Drawing.Size(103, 17)
        Me.DST_Lab.TabIndex = 19
        Me.DST_Lab.Text = "None"
        Me.DST_Lab.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CST_Lab
        '
        Me.CST_Lab.BackColor = System.Drawing.SystemColors.Control
        Me.CST_Lab.Cursor = System.Windows.Forms.Cursors.Default
        Me.CST_Lab.Font = New System.Drawing.Font("新宋体", 9.75!)
        Me.CST_Lab.ForeColor = System.Drawing.Color.Black
        Me.CST_Lab.Location = New System.Drawing.Point(251, 33)
        Me.CST_Lab.Name = "CST_Lab"
        Me.CST_Lab.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CST_Lab.Size = New System.Drawing.Size(103, 17)
        Me.CST_Lab.TabIndex = 18
        Me.CST_Lab.Text = "None"
        Me.CST_Lab.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BST_Lab
        '
        Me.BST_Lab.BackColor = System.Drawing.SystemColors.Control
        Me.BST_Lab.Cursor = System.Windows.Forms.Cursors.Default
        Me.BST_Lab.Font = New System.Drawing.Font("新宋体", 9.75!)
        Me.BST_Lab.ForeColor = System.Drawing.Color.Black
        Me.BST_Lab.Location = New System.Drawing.Point(131, 33)
        Me.BST_Lab.Name = "BST_Lab"
        Me.BST_Lab.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BST_Lab.Size = New System.Drawing.Size(103, 17)
        Me.BST_Lab.TabIndex = 17
        Me.BST_Lab.Text = "None"
        Me.BST_Lab.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'AST_Lab
        '
        Me.AST_Lab.BackColor = System.Drawing.SystemColors.Control
        Me.AST_Lab.Cursor = System.Windows.Forms.Cursors.Default
        Me.AST_Lab.Font = New System.Drawing.Font("新宋体", 9.75!)
        Me.AST_Lab.ForeColor = System.Drawing.Color.Black
        Me.AST_Lab.Location = New System.Drawing.Point(18, 33)
        Me.AST_Lab.Name = "AST_Lab"
        Me.AST_Lab.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.AST_Lab.Size = New System.Drawing.Size(103, 17)
        Me.AST_Lab.TabIndex = 16
        Me.AST_Lab.Text = "None"
        Me.AST_Lab.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'AB_Connect_Lab
        '
        Me.AB_Connect_Lab.AutoSize = True
        Me.AB_Connect_Lab.BackColor = System.Drawing.SystemColors.Control
        Me.AB_Connect_Lab.Cursor = System.Windows.Forms.Cursors.Default
        Me.AB_Connect_Lab.Font = New System.Drawing.Font("新宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.AB_Connect_Lab.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AB_Connect_Lab.Location = New System.Drawing.Point(501, 156)
        Me.AB_Connect_Lab.Name = "AB_Connect_Lab"
        Me.AB_Connect_Lab.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.AB_Connect_Lab.Size = New System.Drawing.Size(77, 12)
        Me.AB_Connect_Lab.TabIndex = 7
        Me.AB_Connect_Lab.Text = "ATE Connect:"
        '
        'PLC_RD_Lst
        '
        Me.PLC_RD_Lst.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PLC_RD_Lst.Cursor = System.Windows.Forms.Cursors.Default
        Me.PLC_RD_Lst.Enabled = False
        Me.PLC_RD_Lst.ForeColor = System.Drawing.SystemColors.WindowText
        Me.PLC_RD_Lst.ItemHeight = 12
        Me.PLC_RD_Lst.Location = New System.Drawing.Point(9, 25)
        Me.PLC_RD_Lst.Name = "PLC_RD_Lst"
        Me.PLC_RD_Lst.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PLC_RD_Lst.Size = New System.Drawing.Size(232, 160)
        Me.PLC_RD_Lst.TabIndex = 29
        '
        'Buff_TCPLst
        '
        Me.Buff_TCPLst.Font = New System.Drawing.Font("新宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Buff_TCPLst.FormattingEnabled = True
        Me.Buff_TCPLst.ItemHeight = 12
        Me.Buff_TCPLst.Location = New System.Drawing.Point(40, 415)
        Me.Buff_TCPLst.Name = "Buff_TCPLst"
        Me.Buff_TCPLst.Size = New System.Drawing.Size(81, 28)
        Me.Buff_TCPLst.TabIndex = 43
        Me.Buff_TCPLst.Visible = False
        '
        'Timer_Send_Buffer
        '
        Me.Timer_Send_Buffer.Interval = 50
        '
        'St_Lab
        '
        Me.St_Lab.Font = New System.Drawing.Font("新宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.St_Lab.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.St_Panel1, Me.St_Panel2, Me.St_Panel3, Me.St_Panel4, Me.Err_Count_La})
        Me.St_Lab.Location = New System.Drawing.Point(0, 459)
        Me.St_Lab.Name = "St_Lab"
        Me.St_Lab.Size = New System.Drawing.Size(699, 22)
        Me.St_Lab.TabIndex = 47
        Me.St_Lab.Text = "St_Lab"
        '
        'St_Panel1
        '
        Me.St_Panel1.AutoSize = False
        Me.St_Panel1.Name = "St_Panel1"
        Me.St_Panel1.Size = New System.Drawing.Size(165, 17)
        Me.St_Panel1.Text = "Robot Tool"
        '
        'St_Panel2
        '
        Me.St_Panel2.AutoSize = False
        Me.St_Panel2.Name = "St_Panel2"
        Me.St_Panel2.Size = New System.Drawing.Size(120, 17)
        Me.St_Panel2.Text = "No Connect"
        '
        'St_Panel3
        '
        Me.St_Panel3.AutoSize = False
        Me.St_Panel3.Name = "St_Panel3"
        Me.St_Panel3.Size = New System.Drawing.Size(160, 17)
        Me.St_Panel3.Text = "System Time"
        '
        'St_Panel4
        '
        Me.St_Panel4.AutoSize = False
        Me.St_Panel4.Name = "St_Panel4"
        Me.St_Panel4.Size = New System.Drawing.Size(160, 17)
        Me.St_Panel4.Text = "Tool Error Count:"
        Me.St_Panel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Err_Count_La
        '
        Me.Err_Count_La.AutoSize = False
        Me.Err_Count_La.Name = "Err_Count_La"
        Me.Err_Count_La.Size = New System.Drawing.Size(50, 17)
        Me.Err_Count_La.Text = "0"
        '
        'Timer_RdPLC
        '
        '
        'Astation_B
        '
        Me.Astation_B.BackColor = System.Drawing.Color.Gray
        Me.Astation_B.Enabled = False
        Me.Astation_B.Font = New System.Drawing.Font("新宋体", 9.0!)
        Me.Astation_B.ForeColor = System.Drawing.Color.Yellow
        Me.Astation_B.Location = New System.Drawing.Point(8, 97)
        Me.Astation_B.Name = "Astation_B"
        Me.Astation_B.Size = New System.Drawing.Size(40, 25)
        Me.Astation_B.TabIndex = 2
        Me.Astation_B.Text = "A站"
        Me.Astation_B.UseVisualStyleBackColor = False
        '
        'PLC_Alarm_Txt
        '
        Me.PLC_Alarm_Txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PLC_Alarm_Txt.ForeColor = System.Drawing.Color.DarkRed
        Me.PLC_Alarm_Txt.Location = New System.Drawing.Point(6, 15)
        Me.PLC_Alarm_Txt.Multiline = True
        Me.PLC_Alarm_Txt.Name = "PLC_Alarm_Txt"
        Me.PLC_Alarm_Txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.PLC_Alarm_Txt.Size = New System.Drawing.Size(467, 69)
        Me.PLC_Alarm_Txt.TabIndex = 51
        '
        'Bstation_B
        '
        Me.Bstation_B.BackColor = System.Drawing.Color.Gray
        Me.Bstation_B.Enabled = False
        Me.Bstation_B.Font = New System.Drawing.Font("新宋体", 9.0!)
        Me.Bstation_B.ForeColor = System.Drawing.Color.Yellow
        Me.Bstation_B.Location = New System.Drawing.Point(8, 126)
        Me.Bstation_B.Name = "Bstation_B"
        Me.Bstation_B.Size = New System.Drawing.Size(40, 25)
        Me.Bstation_B.TabIndex = 3
        Me.Bstation_B.Text = "B站"
        Me.Bstation_B.UseVisualStyleBackColor = False
        '
        'Cstation_B
        '
        Me.Cstation_B.BackColor = System.Drawing.Color.Gray
        Me.Cstation_B.Enabled = False
        Me.Cstation_B.Font = New System.Drawing.Font("新宋体", 9.0!)
        Me.Cstation_B.ForeColor = System.Drawing.Color.Yellow
        Me.Cstation_B.Location = New System.Drawing.Point(107, 97)
        Me.Cstation_B.Name = "Cstation_B"
        Me.Cstation_B.Size = New System.Drawing.Size(40, 25)
        Me.Cstation_B.TabIndex = 4
        Me.Cstation_B.Text = "C站"
        Me.Cstation_B.UseVisualStyleBackColor = False
        '
        'Dstation_B
        '
        Me.Dstation_B.BackColor = System.Drawing.Color.Gray
        Me.Dstation_B.Enabled = False
        Me.Dstation_B.Font = New System.Drawing.Font("新宋体", 9.0!)
        Me.Dstation_B.ForeColor = System.Drawing.Color.Yellow
        Me.Dstation_B.Location = New System.Drawing.Point(107, 126)
        Me.Dstation_B.Name = "Dstation_B"
        Me.Dstation_B.Size = New System.Drawing.Size(40, 25)
        Me.Dstation_B.TabIndex = 5
        Me.Dstation_B.Text = "D站"
        Me.Dstation_B.UseVisualStyleBackColor = False
        '
        'Alarm_Reset_B
        '
        Me.Alarm_Reset_B.Enabled = False
        Me.Alarm_Reset_B.Font = New System.Drawing.Font("新宋体", 9.0!)
        Me.Alarm_Reset_B.Location = New System.Drawing.Point(8, 90)
        Me.Alarm_Reset_B.Name = "Alarm_Reset_B"
        Me.Alarm_Reset_B.Size = New System.Drawing.Size(41, 34)
        Me.Alarm_Reset_B.TabIndex = 10
        Me.Alarm_Reset_B.Text = "異常重置"
        Me.Alarm_Reset_B.UseVisualStyleBackColor = True
        '
        'Buzzer_Off_B
        '
        Me.Buzzer_Off_B.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Buzzer_Off_B.Enabled = False
        Me.Buzzer_Off_B.Font = New System.Drawing.Font("新宋体", 9.0!)
        Me.Buzzer_Off_B.Location = New System.Drawing.Point(60, 90)
        Me.Buzzer_Off_B.Name = "Buzzer_Off_B"
        Me.Buzzer_Off_B.Size = New System.Drawing.Size(41, 34)
        Me.Buzzer_Off_B.TabIndex = 11
        Me.Buzzer_Off_B.Text = "蜂鳴關閉"
        Me.Buzzer_Off_B.UseVisualStyleBackColor = False
        '
        'State_GpB
        '
        Me.State_GpB.Controls.Add(Me.Dslzz_Close_B)
        Me.State_GpB.Controls.Add(Me.Cslzz_Close_B)
        Me.State_GpB.Controls.Add(Me.Bslzz_Close_B)
        Me.State_GpB.Controls.Add(Me.Aslzz_Close_B)
        Me.State_GpB.Controls.Add(Me.Dslzz_Open_B)
        Me.State_GpB.Controls.Add(Me.Cslzz_Open_B)
        Me.State_GpB.Controls.Add(Me.Bslzz_Open_B)
        Me.State_GpB.Controls.Add(Me.Aslzz_Open_B)
        Me.State_GpB.Controls.Add(Me.D_Light_Lab)
        Me.State_GpB.Controls.Add(Me.D_Sw_Lab)
        Me.State_GpB.Controls.Add(Me.C_Light_Lab)
        Me.State_GpB.Controls.Add(Me.C_Sw_Lab)
        Me.State_GpB.Controls.Add(Me.B_Light_Lab)
        Me.State_GpB.Controls.Add(Me.B_Sw_Lab)
        Me.State_GpB.Controls.Add(Me.Label13)
        Me.State_GpB.Controls.Add(Me.A_Light_Lab)
        Me.State_GpB.Controls.Add(Me.Label10)
        Me.State_GpB.Controls.Add(Me.A_Sw_Lab)
        Me.State_GpB.Controls.Add(Me.Label7)
        Me.State_GpB.Controls.Add(Me.Label1)
        Me.State_GpB.Controls.Add(Me.Label3)
        Me.State_GpB.Controls.Add(Me.Label6)
        Me.State_GpB.Controls.Add(Me.Dpause_B)
        Me.State_GpB.Controls.Add(Me.Dstation_B)
        Me.State_GpB.Controls.Add(Me.Apause_B)
        Me.State_GpB.Controls.Add(Me.Astation_B)
        Me.State_GpB.Controls.Add(Me.Bpause_B)
        Me.State_GpB.Controls.Add(Me.Bstation_B)
        Me.State_GpB.Controls.Add(Me.Cpause_B)
        Me.State_GpB.Controls.Add(Me.Cstation_B)
        Me.State_GpB.Font = New System.Drawing.Font("新宋体", 9.0!)
        Me.State_GpB.Location = New System.Drawing.Point(488, 200)
        Me.State_GpB.Name = "State_GpB"
        Me.State_GpB.Size = New System.Drawing.Size(200, 248)
        Me.State_GpB.TabIndex = 54
        Me.State_GpB.TabStop = False
        Me.State_GpB.Text = "Robot and ATE State"
        '
        'Dslzz_Close_B
        '
        Me.Dslzz_Close_B.Enabled = False
        Me.Dslzz_Close_B.Location = New System.Drawing.Point(150, 211)
        Me.Dslzz_Close_B.Name = "Dslzz_Close_B"
        Me.Dslzz_Close_B.Size = New System.Drawing.Size(44, 32)
        Me.Dslzz_Close_B.TabIndex = 52
        Me.Dslzz_Close_B.Text = "D Close"
        Me.Dslzz_Close_B.UseVisualStyleBackColor = True
        '
        'Cslzz_Close_B
        '
        Me.Cslzz_Close_B.Enabled = False
        Me.Cslzz_Close_B.Location = New System.Drawing.Point(102, 211)
        Me.Cslzz_Close_B.Name = "Cslzz_Close_B"
        Me.Cslzz_Close_B.Size = New System.Drawing.Size(44, 32)
        Me.Cslzz_Close_B.TabIndex = 52
        Me.Cslzz_Close_B.Text = "C Close"
        Me.Cslzz_Close_B.UseVisualStyleBackColor = True
        '
        'Bslzz_Close_B
        '
        Me.Bslzz_Close_B.Enabled = False
        Me.Bslzz_Close_B.Location = New System.Drawing.Point(54, 211)
        Me.Bslzz_Close_B.Name = "Bslzz_Close_B"
        Me.Bslzz_Close_B.Size = New System.Drawing.Size(44, 32)
        Me.Bslzz_Close_B.TabIndex = 52
        Me.Bslzz_Close_B.Text = "B Close"
        Me.Bslzz_Close_B.UseVisualStyleBackColor = True
        '
        'Aslzz_Close_B
        '
        Me.Aslzz_Close_B.Enabled = False
        Me.Aslzz_Close_B.Location = New System.Drawing.Point(6, 211)
        Me.Aslzz_Close_B.Name = "Aslzz_Close_B"
        Me.Aslzz_Close_B.Size = New System.Drawing.Size(44, 32)
        Me.Aslzz_Close_B.TabIndex = 52
        Me.Aslzz_Close_B.Text = "A Close"
        Me.Aslzz_Close_B.UseVisualStyleBackColor = True
        '
        'Dslzz_Open_B
        '
        Me.Dslzz_Open_B.Enabled = False
        Me.Dslzz_Open_B.Location = New System.Drawing.Point(150, 173)
        Me.Dslzz_Open_B.Name = "Dslzz_Open_B"
        Me.Dslzz_Open_B.Size = New System.Drawing.Size(44, 32)
        Me.Dslzz_Open_B.TabIndex = 52
        Me.Dslzz_Open_B.Text = "D Open"
        Me.Dslzz_Open_B.UseVisualStyleBackColor = True
        '
        'Cslzz_Open_B
        '
        Me.Cslzz_Open_B.Enabled = False
        Me.Cslzz_Open_B.Location = New System.Drawing.Point(102, 173)
        Me.Cslzz_Open_B.Name = "Cslzz_Open_B"
        Me.Cslzz_Open_B.Size = New System.Drawing.Size(44, 32)
        Me.Cslzz_Open_B.TabIndex = 52
        Me.Cslzz_Open_B.Text = "C Open"
        Me.Cslzz_Open_B.UseVisualStyleBackColor = True
        '
        'Bslzz_Open_B
        '
        Me.Bslzz_Open_B.Enabled = False
        Me.Bslzz_Open_B.Location = New System.Drawing.Point(54, 173)
        Me.Bslzz_Open_B.Name = "Bslzz_Open_B"
        Me.Bslzz_Open_B.Size = New System.Drawing.Size(44, 32)
        Me.Bslzz_Open_B.TabIndex = 52
        Me.Bslzz_Open_B.Text = "B Open"
        Me.Bslzz_Open_B.UseVisualStyleBackColor = True
        '
        'Aslzz_Open_B
        '
        Me.Aslzz_Open_B.Enabled = False
        Me.Aslzz_Open_B.Location = New System.Drawing.Point(6, 173)
        Me.Aslzz_Open_B.Name = "Aslzz_Open_B"
        Me.Aslzz_Open_B.Size = New System.Drawing.Size(44, 32)
        Me.Aslzz_Open_B.TabIndex = 52
        Me.Aslzz_Open_B.Text = "A Open"
        Me.Aslzz_Open_B.UseVisualStyleBackColor = True
        '
        'D_Light_Lab
        '
        Me.D_Light_Lab.BackColor = System.Drawing.Color.Gray
        Me.D_Light_Lab.Font = New System.Drawing.Font("新宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.D_Light_Lab.ForeColor = System.Drawing.Color.Yellow
        Me.D_Light_Lab.Location = New System.Drawing.Point(152, 62)
        Me.D_Light_Lab.Name = "D_Light_Lab"
        Me.D_Light_Lab.Size = New System.Drawing.Size(42, 16)
        Me.D_Light_Lab.TabIndex = 51
        Me.D_Light_Lab.Text = "Sensor"
        Me.D_Light_Lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'D_Sw_Lab
        '
        Me.D_Sw_Lab.BackColor = System.Drawing.Color.Gray
        Me.D_Sw_Lab.Font = New System.Drawing.Font("新宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.D_Sw_Lab.ForeColor = System.Drawing.Color.Yellow
        Me.D_Sw_Lab.Location = New System.Drawing.Point(152, 36)
        Me.D_Sw_Lab.Name = "D_Sw_Lab"
        Me.D_Sw_Lab.Size = New System.Drawing.Size(42, 16)
        Me.D_Sw_Lab.TabIndex = 51
        Me.D_Sw_Lab.Text = "Switch"
        Me.D_Sw_Lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C_Light_Lab
        '
        Me.C_Light_Lab.BackColor = System.Drawing.Color.Gray
        Me.C_Light_Lab.Font = New System.Drawing.Font("新宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.C_Light_Lab.ForeColor = System.Drawing.Color.Yellow
        Me.C_Light_Lab.Location = New System.Drawing.Point(104, 62)
        Me.C_Light_Lab.Name = "C_Light_Lab"
        Me.C_Light_Lab.Size = New System.Drawing.Size(42, 16)
        Me.C_Light_Lab.TabIndex = 51
        Me.C_Light_Lab.Text = "Sensor"
        Me.C_Light_Lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C_Sw_Lab
        '
        Me.C_Sw_Lab.BackColor = System.Drawing.Color.Gray
        Me.C_Sw_Lab.Font = New System.Drawing.Font("新宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.C_Sw_Lab.ForeColor = System.Drawing.Color.Yellow
        Me.C_Sw_Lab.Location = New System.Drawing.Point(104, 36)
        Me.C_Sw_Lab.Name = "C_Sw_Lab"
        Me.C_Sw_Lab.Size = New System.Drawing.Size(42, 16)
        Me.C_Sw_Lab.TabIndex = 51
        Me.C_Sw_Lab.Text = "Switch"
        Me.C_Sw_Lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'B_Light_Lab
        '
        Me.B_Light_Lab.BackColor = System.Drawing.Color.Gray
        Me.B_Light_Lab.Font = New System.Drawing.Font("新宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.B_Light_Lab.ForeColor = System.Drawing.Color.Yellow
        Me.B_Light_Lab.Location = New System.Drawing.Point(56, 62)
        Me.B_Light_Lab.Name = "B_Light_Lab"
        Me.B_Light_Lab.Size = New System.Drawing.Size(42, 16)
        Me.B_Light_Lab.TabIndex = 51
        Me.B_Light_Lab.Text = "Sensor"
        Me.B_Light_Lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'B_Sw_Lab
        '
        Me.B_Sw_Lab.BackColor = System.Drawing.Color.Gray
        Me.B_Sw_Lab.Font = New System.Drawing.Font("新宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.B_Sw_Lab.ForeColor = System.Drawing.Color.Yellow
        Me.B_Sw_Lab.Location = New System.Drawing.Point(56, 36)
        Me.B_Sw_Lab.Name = "B_Sw_Lab"
        Me.B_Sw_Lab.Size = New System.Drawing.Size(42, 16)
        Me.B_Sw_Lab.TabIndex = 51
        Me.B_Sw_Lab.Text = "Switch"
        Me.B_Sw_Lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("新宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(163, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(11, 12)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "D"
        '
        'A_Light_Lab
        '
        Me.A_Light_Lab.BackColor = System.Drawing.Color.Gray
        Me.A_Light_Lab.Font = New System.Drawing.Font("新宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.A_Light_Lab.ForeColor = System.Drawing.Color.Yellow
        Me.A_Light_Lab.Location = New System.Drawing.Point(8, 62)
        Me.A_Light_Lab.Name = "A_Light_Lab"
        Me.A_Light_Lab.Size = New System.Drawing.Size(42, 16)
        Me.A_Light_Lab.TabIndex = 51
        Me.A_Light_Lab.Text = "Sensor"
        Me.A_Light_Lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("新宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(115, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(11, 12)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "C"
        '
        'A_Sw_Lab
        '
        Me.A_Sw_Lab.BackColor = System.Drawing.Color.Gray
        Me.A_Sw_Lab.Font = New System.Drawing.Font("新宋体", 9.0!)
        Me.A_Sw_Lab.ForeColor = System.Drawing.Color.Yellow
        Me.A_Sw_Lab.Location = New System.Drawing.Point(8, 36)
        Me.A_Sw_Lab.Name = "A_Sw_Lab"
        Me.A_Sw_Lab.Size = New System.Drawing.Size(42, 16)
        Me.A_Sw_Lab.TabIndex = 51
        Me.A_Sw_Lab.Text = "Switch"
        Me.A_Sw_Lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("新宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(67, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(11, 12)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "B"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("新宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(57, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(95, 12)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ATE Save Labour"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("新宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(40, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(119, 12)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "PLC Station Setting"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("新宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(19, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(11, 12)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "A"
        '
        'Dpause_B
        '
        Me.Dpause_B.BackColor = System.Drawing.Color.Gray
        Me.Dpause_B.Enabled = False
        Me.Dpause_B.Font = New System.Drawing.Font("新宋体", 9.0!)
        Me.Dpause_B.ForeColor = System.Drawing.Color.Yellow
        Me.Dpause_B.Location = New System.Drawing.Point(150, 126)
        Me.Dpause_B.Name = "Dpause_B"
        Me.Dpause_B.Size = New System.Drawing.Size(40, 25)
        Me.Dpause_B.TabIndex = 5
        Me.Dpause_B.Text = "暫停"
        Me.Dpause_B.UseVisualStyleBackColor = False
        '
        'Apause_B
        '
        Me.Apause_B.BackColor = System.Drawing.Color.Gray
        Me.Apause_B.Enabled = False
        Me.Apause_B.Font = New System.Drawing.Font("新宋体", 9.0!)
        Me.Apause_B.ForeColor = System.Drawing.Color.Yellow
        Me.Apause_B.Location = New System.Drawing.Point(51, 97)
        Me.Apause_B.Name = "Apause_B"
        Me.Apause_B.Size = New System.Drawing.Size(40, 25)
        Me.Apause_B.TabIndex = 2
        Me.Apause_B.Text = "暫停"
        Me.Apause_B.UseVisualStyleBackColor = False
        '
        'Bpause_B
        '
        Me.Bpause_B.BackColor = System.Drawing.Color.Gray
        Me.Bpause_B.Enabled = False
        Me.Bpause_B.Font = New System.Drawing.Font("新宋体", 9.0!)
        Me.Bpause_B.ForeColor = System.Drawing.Color.Yellow
        Me.Bpause_B.Location = New System.Drawing.Point(51, 126)
        Me.Bpause_B.Name = "Bpause_B"
        Me.Bpause_B.Size = New System.Drawing.Size(40, 25)
        Me.Bpause_B.TabIndex = 3
        Me.Bpause_B.Text = "暫停"
        Me.Bpause_B.UseVisualStyleBackColor = False
        '
        'Cpause_B
        '
        Me.Cpause_B.BackColor = System.Drawing.Color.Gray
        Me.Cpause_B.Enabled = False
        Me.Cpause_B.Font = New System.Drawing.Font("新宋体", 9.0!)
        Me.Cpause_B.ForeColor = System.Drawing.Color.Yellow
        Me.Cpause_B.Location = New System.Drawing.Point(150, 97)
        Me.Cpause_B.Name = "Cpause_B"
        Me.Cpause_B.Size = New System.Drawing.Size(40, 25)
        Me.Cpause_B.TabIndex = 4
        Me.Cpause_B.Text = "暫停"
        Me.Cpause_B.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("新宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(501, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(77, 12)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "PLC Connect:"
        '
        'PLCCon_StTxt
        '
        Me.PLCCon_StTxt.BackColor = System.Drawing.Color.Gray
        Me.PLCCon_StTxt.Font = New System.Drawing.Font("新宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.PLCCon_StTxt.ForeColor = System.Drawing.Color.Yellow
        Me.PLCCon_StTxt.Location = New System.Drawing.Point(582, 124)
        Me.PLCCon_StTxt.Name = "PLCCon_StTxt"
        Me.PLCCon_StTxt.ReadOnly = True
        Me.PLCCon_StTxt.Size = New System.Drawing.Size(90, 21)
        Me.PLCCon_StTxt.TabIndex = 34
        Me.PLCCon_StTxt.Text = "No Connect"
        Me.PLCCon_StTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PLC_Start_B
        '
        Me.PLC_Start_B.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PLC_Start_B.Enabled = False
        Me.PLC_Start_B.Font = New System.Drawing.Font("新宋体", 9.0!)
        Me.PLC_Start_B.ForeColor = System.Drawing.Color.Black
        Me.PLC_Start_B.Location = New System.Drawing.Point(107, 90)
        Me.PLC_Start_B.Name = "PLC_Start_B"
        Me.PLC_Start_B.Size = New System.Drawing.Size(41, 34)
        Me.PLC_Start_B.TabIndex = 12
        Me.PLC_Start_B.Text = "開始"
        Me.PLC_Start_B.UseVisualStyleBackColor = False
        '
        'Manual_Test_B
        '
        Me.Manual_Test_B.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Manual_Test_B.Enabled = False
        Me.Manual_Test_B.Font = New System.Drawing.Font("新宋体", 9.0!)
        Me.Manual_Test_B.Location = New System.Drawing.Point(424, 90)
        Me.Manual_Test_B.Name = "Manual_Test_B"
        Me.Manual_Test_B.Size = New System.Drawing.Size(41, 34)
        Me.Manual_Test_B.TabIndex = 13
        Me.Manual_Test_B.Text = "手投模式"
        Me.Manual_Test_B.UseVisualStyleBackColor = False
        '
        'PLC_IPTxt
        '
        Me.PLC_IPTxt.Location = New System.Drawing.Point(64, 33)
        Me.PLC_IPTxt.Name = "PLC_IPTxt"
        Me.PLC_IPTxt.Size = New System.Drawing.Size(110, 21)
        Me.PLC_IPTxt.TabIndex = 16
        Me.PLC_IPTxt.Tag = ""
        '
        'PLC_IP_Lab
        '
        Me.PLC_IP_Lab.AutoSize = True
        Me.PLC_IP_Lab.Font = New System.Drawing.Font("新宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.PLC_IP_Lab.Location = New System.Drawing.Point(11, 37)
        Me.PLC_IP_Lab.Name = "PLC_IP_Lab"
        Me.PLC_IP_Lab.Size = New System.Drawing.Size(47, 12)
        Me.PLC_IP_Lab.TabIndex = 45
        Me.PLC_IP_Lab.Text = "PLC IP:"
        '
        'Tool_LogGrpB
        '
        Me.Tool_LogGrpB.Controls.Add(Me.Show_Lst)
        Me.Tool_LogGrpB.Font = New System.Drawing.Font("新宋体", 9.0!)
        Me.Tool_LogGrpB.Location = New System.Drawing.Point(5, 286)
        Me.Tool_LogGrpB.Name = "Tool_LogGrpB"
        Me.Tool_LogGrpB.Size = New System.Drawing.Size(477, 126)
        Me.Tool_LogGrpB.TabIndex = 55
        Me.Tool_LogGrpB.TabStop = False
        Me.Tool_LogGrpB.Text = "Tool Log List"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.PLC_Alarm_Txt)
        Me.GroupBox3.Controls.Add(Me.Alarm_Reset_B)
        Me.GroupBox3.Controls.Add(Me.Buzzer_Off_B)
        Me.GroupBox3.Controls.Add(Me.PLC_ReMate_B)
        Me.GroupBox3.Controls.Add(Me.PLC_Start_B)
        Me.GroupBox3.Controls.Add(Me.PLC_Origin_B)
        Me.GroupBox3.Controls.Add(Me.PLC_Pause_B)
        Me.GroupBox3.Controls.Add(Me.PLC_Stop_B)
        Me.GroupBox3.Controls.Add(Me.PLC_Model_B)
        Me.GroupBox3.Controls.Add(Me.Manual_Test_B)
        Me.GroupBox3.Font = New System.Drawing.Font("新宋体", 9.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 53)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(477, 130)
        Me.GroupBox3.TabIndex = 56
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "PLC Alarm"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(220, 46)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(178, 21)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "45508B01013571001611KSAD"
        Me.TextBox1.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(404, 47)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 17)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'PLC_ReMate_B
        '
        Me.PLC_ReMate_B.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PLC_ReMate_B.Enabled = False
        Me.PLC_ReMate_B.Font = New System.Drawing.Font("新宋体", 9.0!)
        Me.PLC_ReMate_B.Location = New System.Drawing.Point(380, 90)
        Me.PLC_ReMate_B.Name = "PLC_ReMate_B"
        Me.PLC_ReMate_B.Size = New System.Drawing.Size(41, 34)
        Me.PLC_ReMate_B.TabIndex = 12
        Me.PLC_ReMate_B.Text = "復位原料"
        Me.PLC_ReMate_B.UseVisualStyleBackColor = False
        '
        'PLC_Origin_B
        '
        Me.PLC_Origin_B.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PLC_Origin_B.Enabled = False
        Me.PLC_Origin_B.Font = New System.Drawing.Font("新宋体", 9.0!)
        Me.PLC_Origin_B.Location = New System.Drawing.Point(323, 90)
        Me.PLC_Origin_B.Name = "PLC_Origin_B"
        Me.PLC_Origin_B.Size = New System.Drawing.Size(53, 34)
        Me.PLC_Origin_B.TabIndex = 12
        Me.PLC_Origin_B.Text = "回原點"
        Me.PLC_Origin_B.UseVisualStyleBackColor = False
        '
        'PLC_Pause_B
        '
        Me.PLC_Pause_B.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PLC_Pause_B.Enabled = False
        Me.PLC_Pause_B.Font = New System.Drawing.Font("新宋体", 9.0!)
        Me.PLC_Pause_B.Location = New System.Drawing.Point(278, 90)
        Me.PLC_Pause_B.Name = "PLC_Pause_B"
        Me.PLC_Pause_B.Size = New System.Drawing.Size(41, 34)
        Me.PLC_Pause_B.TabIndex = 12
        Me.PLC_Pause_B.Text = "暫停"
        Me.PLC_Pause_B.UseVisualStyleBackColor = False
        '
        'PLC_Stop_B
        '
        Me.PLC_Stop_B.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PLC_Stop_B.Enabled = False
        Me.PLC_Stop_B.Font = New System.Drawing.Font("新宋体", 9.0!)
        Me.PLC_Stop_B.ForeColor = System.Drawing.Color.Black
        Me.PLC_Stop_B.Location = New System.Drawing.Point(232, 90)
        Me.PLC_Stop_B.Name = "PLC_Stop_B"
        Me.PLC_Stop_B.Size = New System.Drawing.Size(41, 34)
        Me.PLC_Stop_B.TabIndex = 12
        Me.PLC_Stop_B.Text = "停止"
        Me.PLC_Stop_B.UseVisualStyleBackColor = False
        '
        'PLC_Model_B
        '
        Me.PLC_Model_B.BackColor = System.Drawing.Color.RoyalBlue
        Me.PLC_Model_B.Enabled = False
        Me.PLC_Model_B.Font = New System.Drawing.Font("新宋体", 9.0!)
        Me.PLC_Model_B.ForeColor = System.Drawing.Color.White
        Me.PLC_Model_B.Location = New System.Drawing.Point(152, 90)
        Me.PLC_Model_B.Name = "PLC_Model_B"
        Me.PLC_Model_B.Size = New System.Drawing.Size(75, 34)
        Me.PLC_Model_B.TabIndex = 12
        Me.PLC_Model_B.Text = "自動/手動"
        Me.PLC_Model_B.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.SN_Clear_B)
        Me.GroupBox4.Controls.Add(Me.SN_Lst)
        Me.GroupBox4.Font = New System.Drawing.Font("新宋体", 9.0!)
        Me.GroupBox4.Location = New System.Drawing.Point(5, 187)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(477, 97)
        Me.GroupBox4.TabIndex = 57
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "MB SN"
        '
        'SN_Clear_B
        '
        Me.SN_Clear_B.Enabled = False
        Me.SN_Clear_B.Location = New System.Drawing.Point(427, 20)
        Me.SN_Clear_B.Name = "SN_Clear_B"
        Me.SN_Clear_B.Size = New System.Drawing.Size(46, 52)
        Me.SN_Clear_B.TabIndex = 8
        Me.SN_Clear_B.Text = "Clear"
        Me.SN_Clear_B.UseVisualStyleBackColor = True
        '
        'SN_Lst
        '
        Me.SN_Lst.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SN_Lst.Cursor = System.Windows.Forms.Cursors.Default
        Me.SN_Lst.Font = New System.Drawing.Font("新宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.SN_Lst.ForeColor = System.Drawing.SystemColors.WindowText
        Me.SN_Lst.ItemHeight = 12
        Me.SN_Lst.Location = New System.Drawing.Point(9, 13)
        Me.SN_Lst.Name = "SN_Lst"
        Me.SN_Lst.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SN_Lst.Size = New System.Drawing.Size(412, 76)
        Me.SN_Lst.TabIndex = 9
        '
        'Set_GpB
        '
        Me.Set_GpB.Controls.Add(Me.Customer_Cmb)
        Me.Set_GpB.Controls.Add(Me.Multi_SN_Chk)
        Me.Set_GpB.Controls.Add(Me.SetLk_Chk)
        Me.Set_GpB.Controls.Add(Me.SN_ChkRoute)
        Me.Set_GpB.Controls.Add(Me.PLC_IPTxt)
        Me.Set_GpB.Controls.Add(Me.PLC_IP_Lab)
        Me.Set_GpB.Controls.Add(Me.Customer_Lab)
        Me.Set_GpB.Font = New System.Drawing.Font("新宋体", 9.0!)
        Me.Set_GpB.Location = New System.Drawing.Point(488, 1)
        Me.Set_GpB.Name = "Set_GpB"
        Me.Set_GpB.Size = New System.Drawing.Size(200, 200)
        Me.Set_GpB.TabIndex = 59
        Me.Set_GpB.TabStop = False
        Me.Set_GpB.Text = "Setting"
        '
        'Customer_Cmb
        '
        Me.Customer_Cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Customer_Cmb.FormattingEnabled = True
        Me.Customer_Cmb.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Customer_Cmb.Items.AddRange(New Object() {"F721", "F722"})
        Me.Customer_Cmb.Location = New System.Drawing.Point(85, 99)
        Me.Customer_Cmb.Name = "Customer_Cmb"
        Me.Customer_Cmb.Size = New System.Drawing.Size(89, 20)
        Me.Customer_Cmb.TabIndex = 46
        '
        'Multi_SN_Chk
        '
        Me.Multi_SN_Chk.AutoSize = True
        Me.Multi_SN_Chk.Checked = True
        Me.Multi_SN_Chk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Multi_SN_Chk.Location = New System.Drawing.Point(17, 81)
        Me.Multi_SN_Chk.Name = "Multi_SN_Chk"
        Me.Multi_SN_Chk.Size = New System.Drawing.Size(162, 16)
        Me.Multi_SN_Chk.TabIndex = 14
        Me.Multi_SN_Chk.Text = "Search SFCS Multi BD SN"
        Me.Multi_SN_Chk.UseVisualStyleBackColor = True
        '
        'SetLk_Chk
        '
        Me.SetLk_Chk.AutoSize = True
        Me.SetLk_Chk.Checked = True
        Me.SetLk_Chk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SetLk_Chk.Location = New System.Drawing.Point(113, 13)
        Me.SetLk_Chk.Name = "SetLk_Chk"
        Me.SetLk_Chk.Size = New System.Drawing.Size(72, 16)
        Me.SetLk_Chk.TabIndex = 17
        Me.SetLk_Chk.Text = "Lock Set"
        Me.SetLk_Chk.UseVisualStyleBackColor = True
        '
        'SN_ChkRoute
        '
        Me.SN_ChkRoute.AutoSize = True
        Me.SN_ChkRoute.Checked = True
        Me.SN_ChkRoute.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SN_ChkRoute.Location = New System.Drawing.Point(17, 59)
        Me.SN_ChkRoute.Name = "SN_ChkRoute"
        Me.SN_ChkRoute.Size = New System.Drawing.Size(168, 16)
        Me.SN_ChkRoute.TabIndex = 15
        Me.SN_ChkRoute.Text = "Barcode SFCS Check Route"
        Me.SN_ChkRoute.UseVisualStyleBackColor = True
        '
        'Customer_Lab
        '
        Me.Customer_Lab.AutoSize = True
        Me.Customer_Lab.BackColor = System.Drawing.SystemColors.Control
        Me.Customer_Lab.Cursor = System.Windows.Forms.Cursors.Default
        Me.Customer_Lab.Font = New System.Drawing.Font("新宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Customer_Lab.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Customer_Lab.Location = New System.Drawing.Point(20, 104)
        Me.Customer_Lab.Name = "Customer_Lab"
        Me.Customer_Lab.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Customer_Lab.Size = New System.Drawing.Size(59, 12)
        Me.Customer_Lab.TabIndex = 7
        Me.Customer_Lab.Text = "Customer:"
        '
        'AxActProgType1
        '
        Me.AxActProgType1.Enabled = True
        Me.AxActProgType1.Location = New System.Drawing.Point(326, 417)
        Me.AxActProgType1.Name = "AxActProgType1"
        Me.AxActProgType1.OcxState = CType(resources.GetObject("AxActProgType1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxActProgType1.Size = New System.Drawing.Size(32, 32)
        Me.AxActProgType1.TabIndex = 60
        '
        'Lock_Control_B
        '
        Me.Lock_Control_B.Font = New System.Drawing.Font("新宋体", 9.0!)
        Me.Lock_Control_B.Location = New System.Drawing.Point(365, 417)
        Me.Lock_Control_B.Name = "Lock_Control_B"
        Me.Lock_Control_B.Size = New System.Drawing.Size(110, 30)
        Me.Lock_Control_B.TabIndex = 61
        Me.Lock_Control_B.Text = "Lock Control"
        Me.Lock_Control_B.UseVisualStyleBackColor = True
        '
        'Main_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 481)
        Me.Controls.Add(Me.Lock_Control_B)
        Me.Controls.Add(Me.ATE_DSt)
        Me.Controls.Add(Me.DST_Lab)
        Me.Controls.Add(Me.ATE_AST)
        Me.Controls.Add(Me.ATE_CSt)
        Me.Controls.Add(Me.CST_Lab)
        Me.Controls.Add(Me.BST_Lab)
        Me.Controls.Add(Me.AB_Connect_Lab)
        Me.Controls.Add(Me.AST_Lab)
        Me.Controls.Add(Me.AB_IP_Lab)
        Me.Controls.Add(Me.ATECon_StTxt)
        Me.Controls.Add(Me.ATE_BSt)
        Me.Controls.Add(Me.PLCCon_StTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AxActProgType1)
        Me.Controls.Add(Me.Set_GpB)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Tool_LogGrpB)
        Me.Controls.Add(Me.State_GpB)
        Me.Controls.Add(Me.Buff_TCPLst)
        Me.Controls.Add(Me.St_Lab)
        Me.Controls.Add(Me.Start_B)
        Me.Font = New System.Drawing.Font("新宋体", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.MaximizeBox = False
        Me.Name = "Main_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ATE Robot Tool For WCD Network version "
        Me.St_Lab.ResumeLayout(False)
        Me.St_Lab.PerformLayout()
        Me.State_GpB.ResumeLayout(False)
        Me.State_GpB.PerformLayout()
        Me.Tool_LogGrpB.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.Set_GpB.ResumeLayout(False)
        Me.Set_GpB.PerformLayout()
        CType(Me.AxActProgType1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents ATE_DSt As System.Windows.Forms.Button
    Public WithEvents ATE_CSt As System.Windows.Forms.Button
    Public WithEvents Timer_ATE_F As System.Windows.Forms.Timer
    Public WithEvents ATE_BSt As System.Windows.Forms.Button
    Public WithEvents Show_Lst As System.Windows.Forms.ListBox
    Public WithEvents Timer_DEL_F As System.Windows.Forms.Timer
    Public WithEvents Start_B As System.Windows.Forms.Button
    Public WithEvents Timer_SN As System.Windows.Forms.Timer
    Public WithEvents DST_Lab As System.Windows.Forms.Label
    Public WithEvents CST_Lab As System.Windows.Forms.Label
    Public WithEvents BST_Lab As System.Windows.Forms.Label
    Public WithEvents AST_Lab As System.Windows.Forms.Label
    Public WithEvents AB_Connect_Lab As System.Windows.Forms.Label
    Public WithEvents PLC_RD_Lst As System.Windows.Forms.ListBox
    Friend WithEvents ATECon_StTxt As System.Windows.Forms.TextBox
    Friend WithEvents Buff_TCPLst As System.Windows.Forms.ListBox
    Friend WithEvents ATE_AST As System.Windows.Forms.Button
    Friend WithEvents Timer_Send_Buffer As System.Windows.Forms.Timer
    Friend WithEvents AB_IP_Lab As System.Windows.Forms.Label
    Friend WithEvents St_Panel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents St_Panel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents St_Panel3 As System.Windows.Forms.ToolStripStatusLabel
    Public WithEvents St_Lab As System.Windows.Forms.StatusStrip
    Friend WithEvents Timer_RdPLC As System.Windows.Forms.Timer
    Friend WithEvents Astation_B As System.Windows.Forms.Button
    Friend WithEvents PLC_Alarm_Txt As System.Windows.Forms.TextBox
    Friend WithEvents Bstation_B As System.Windows.Forms.Button
    Friend WithEvents Cstation_B As System.Windows.Forms.Button
    Friend WithEvents Dstation_B As System.Windows.Forms.Button
    Friend WithEvents Alarm_Reset_B As System.Windows.Forms.Button
    Friend WithEvents Buzzer_Off_B As System.Windows.Forms.Button
    Friend WithEvents State_GpB As System.Windows.Forms.GroupBox
    Friend WithEvents Tool_LogGrpB As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Set_GpB As System.Windows.Forms.GroupBox
    Friend WithEvents AxActProgType1 As AxActProgTypeLib.AxActProgType
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PLCCon_StTxt As System.Windows.Forms.TextBox
    Friend WithEvents A_Sw_Lab As System.Windows.Forms.Label
    Friend WithEvents D_Light_Lab As System.Windows.Forms.Label
    Friend WithEvents D_Sw_Lab As System.Windows.Forms.Label
    Friend WithEvents C_Light_Lab As System.Windows.Forms.Label
    Friend WithEvents C_Sw_Lab As System.Windows.Forms.Label
    Friend WithEvents B_Light_Lab As System.Windows.Forms.Label
    Friend WithEvents B_Sw_Lab As System.Windows.Forms.Label
    Public WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents A_Light_Lab As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PLC_IP_Lab As System.Windows.Forms.Label
    Friend WithEvents PLC_IPTxt As System.Windows.Forms.TextBox
    Friend WithEvents SetLk_Chk As System.Windows.Forms.CheckBox
    Friend WithEvents SN_ChkRoute As System.Windows.Forms.CheckBox
    Friend WithEvents Multi_SN_Chk As System.Windows.Forms.CheckBox
    Friend WithEvents Manual_Test_B As System.Windows.Forms.Button
    Friend WithEvents PLC_Start_B As System.Windows.Forms.Button
    Public WithEvents SN_Lst As System.Windows.Forms.ListBox
    Friend WithEvents SN_Clear_B As System.Windows.Forms.Button
    Friend WithEvents St_Panel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Err_Count_La As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PLC_Model_B As System.Windows.Forms.Button
    Friend WithEvents PLC_ReMate_B As System.Windows.Forms.Button
    Friend WithEvents PLC_Origin_B As System.Windows.Forms.Button
    Friend WithEvents PLC_Stop_B As System.Windows.Forms.Button
    Friend WithEvents PLC_Pause_B As System.Windows.Forms.Button
    Friend WithEvents Bslzz_Close_B As System.Windows.Forms.Button
    Friend WithEvents Aslzz_Close_B As System.Windows.Forms.Button
    Friend WithEvents Bslzz_Open_B As System.Windows.Forms.Button
    Friend WithEvents Aslzz_Open_B As System.Windows.Forms.Button
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Dslzz_Close_B As System.Windows.Forms.Button
    Friend WithEvents Cslzz_Close_B As System.Windows.Forms.Button
    Friend WithEvents Dslzz_Open_B As System.Windows.Forms.Button
    Friend WithEvents Cslzz_Open_B As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Lock_Control_B As System.Windows.Forms.Button
    Friend WithEvents Apause_B As System.Windows.Forms.Button
    Friend WithEvents Bpause_B As System.Windows.Forms.Button
    Friend WithEvents Dpause_B As System.Windows.Forms.Button
    Friend WithEvents Cpause_B As System.Windows.Forms.Button
    Friend WithEvents Customer_Cmb As System.Windows.Forms.ComboBox
    Public WithEvents Customer_Lab As System.Windows.Forms.Label
End Class
