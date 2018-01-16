Imports System
Imports System.IO
Imports System.Net
Imports System.Threading
Imports System.Net.Sockets

Public Class Main_Form

    Dim PLC_Alarm_Code() As String = {
"",
"",
"",
"",
"",
"",
"",
"",
"",
"A000-急停Alarm",
"A001-左安全門打開Alarm",
"A002-右安全門打開Alarm",
"A003-CC-Link主站模塊故障",
"A004-CC-Link-Robostar模塊故障",
"A005-RS232通訊模塊故障",
"A006-1PG-Alarm",
"A007-查詢條碼SFCS電腦未準備好",
"A008-查詢條碼SFCS電腦網絡中斷",
"A009-PC查詢SFCS反饋超時",
"A010-ATE機台PC未完成準備好",
"A011-ATE-A站台PC未完成準備",
"A012-ATE-B站台PC未完成準備",
"A013-ATE-C站台PC未完成準備",
"A014-ATE-D站台PC未完成準備",
"A015-",
"A016-",
"A017-Robostar程序未選擇Alarm",
"A018-Robostar故障Alarm",
"A019-Robostar TP急停",
"A020-Robostar 未運行故障",
"A021-NG軌道Robostar放片有板超時Alarm",
"A022-OK軌道Robostar放片有板超時Alarm",
"A023-ARM1吸真空異常Alarm",
"A024-ARM2吸真空異常Alarm",
"A025-ARM1破真空異常Alarm",
"A026-ARM2破真空異常Alarm",
"A027-條碼槍擋料氣缸上升故障",
"A028-條碼槍擋料氣缸下降故障",
"A029-",
"A030-載板治具氣缸上升故障",
"A031-載板治具氣缸下降故障",
"A032-載板治具PCB檢測異常故障",
"A033-載板治具PCB定位故障",
"A034-",
"A035-測試OK Robostar放片OK軌道有板",
"A036-載板治具有板故障Alarm",
"A037-ATE治具A站有板故障",
"A038-ATE治具B站有板故障",
"A039-ATE治具C站有板故障",
"A040-ATE治具D站有板故障",
"A041-機械手臂ARM1有板故障",
"A042-機械手臂ARM2有板故障",
"A043-NG皮帶線rRobostar放板時未準備",
"A044-ARM1取板真空異常",
"A045-ARM2取板真空異常",
"A046-ARM2上点Sensor故障",
"A047-ARM2下点Sensor故障",
"A048-",
"A049-",
"A050-ATE刷條碼連續NG達到設定值報警",
"A051-A站ATE測試連續NG達到設定值Alarm",
"A052-B站ATE測試連續NG達到設定值Alarm",
"A053-C站ATE測試連續NG達到設定值Alarm",
"A054-D站ATE測試連續NG達到設定值Alarm",
"A055-AB站ATE连续测试NG锁屏报警",
"A056-CD站ATE连续测试NG锁屏报警",
"A057-",
"A058-",
"A059-",
"A060-A站ATE回原點超時Alarm",
"A061-Robostar運行中A站省力裝置不在開啟點",
"A062-Robostar往A站ATE放片超時Alarm",
"A063-Robostar往A站ATE放片真空異常Alarm",
"A064-Robostar往A站ATE取片超時Alarm",
"A065-Robostar往A站ATE取片真空異常Alarm",
"A066-Robostar往A站PCB板OK放片超時Alarm",
"A067-Robostar往A站PCB板NG放片超時Alarm",
"A068-",
"A069-",
"A070-B站ATE回原點超時Alarm",
"A071-Robostar運行中B站省力裝置不在開啟點",
"A072-Robostar往B站ATE放片超時Alarm",
"A073-Robostar往B站ATE放片真空異常Alarm",
"A074-Robostar往B站ATE取片超時Alarm",
"A075-Robostar往B站ATE取片真空異常Alarm",
"A076-Robostar往B站PCB板OK放片超時Alarm",
"A077-Robostar往B站PCB板NG放片超時Alarm",
"A078-",
"A079-",
"A080-C站ATE回原點超時Alarm",
"A081-Robostar運行中C站省力裝置不在開啟點",
"A082-Robostar往C站ATE放片超時Alarm",
"A083-Robostar往C站ATE放片真空異常Alarm",
"A084-Robostar往C站ATE取片超時Alarm",
"A085-Robostar往C站ATE取片真空異常Alarm",
"A086-Robostar往C站PCB板OK放片超時Alarm",
"A087-Robostar往C站PCB板NG放片超時Alarm",
"A088-",
"A089-",
"A090-D站ATE回原點超時Alarm",
"A091-Robostar運行中D站省力裝置不在開啟點",
"A092-Robostar往D站ATE放片超時Alarm",
"A093-Robostar往D站ATE放片真空異常Alarm",
"A094-Robostar往D站ATE取片超時Alarm",
"A095-Robostar往D站ATE取片真空異常Alarm",
"A096-Robostar往D站PCB板OK放片超時Alarm",
"A097-Robostar往D站PCB板NG放片超時Alarm",
"A098-",
"A099-",
"A100-軌道CV01進片超時Alarm",
"A101-軌道CV01出片超時Alarm",
"A102-軌道CV02進片超時Alarm",
"A103-軌道CV02出片超時Alarm",
"A104-軌道CV03進片超時Alarm",
"A105-軌道CV03出片超時Alarm",
"A106-軌道CV04進片超時Alarm",
"A107-軌道CV04出片超時Alarm",
"A108-軌道CV05進片超時Alarm",
"A109-軌道CV05出片超時Alarm",
"A110-A站ATE Robostar離開干涉區超時Alarm",
"A111-A站ATE PCB定位Alarm",
"A112-A站ATE PCB有板檢測Alarm",
"A113-A站ATE 條碼丟失Alarm",
"A114-A站ATE 省力裝置關閉超時Alarm",
"A115-A站ATE 反饋K11超時Alarm",
"A116-A站ATE PCB測試超時Alarm",
"A117-A站ATE 省力裝置開啟超時Alarm",
"A118-A站ATE 省力裝置回原點超時Alarm",
"A119-A站ATE 省力裝置斷帶故障",
"A120-A站ATE 微動開關損壞",
"A121-A站ATE 異常匯總",
"A122-A站ATE省力装置不开起点位置",
"A123-",
"A124-",
"A125-",
"A126-",
"A127-",
"A128-",
"A129-",
"A130-B站ATE Robostar離開干涉區超時Alarm",
"A131-B站ATE PCB定位Alarm",
"A132-B站ATE PCB有板檢測Alarm",
"A133-B站ATE 條碼丟失Alarm",
"A134-B站ATE 省力裝置關閉超時Alarm",
"A135-B站ATE 條碼反饋超時Alarm",
"A136-B站ATE PCB測試超時Alarm",
"A137-B站ATE 省力裝置開啟超時Alarm",
"A138-B站ATE 省力裝置回原點超時Alarm",
"A139-B站ATE 省力裝置斷帶故障",
"A140-B站ATE 微動開關損壞",
"A141-B站ATE 異常匯總",
"A142-B站ATE省力装置不开起点位置",
"A143-",
"A144-",
"A145-",
"A146-",
"A147-",
"A148-",
"A149-",
"A150-C站ATE Robostar離開干涉區超時Alarm",
"A151-C站ATE PCB定位Alarm",
"A152-C站ATE PCB有板檢測Alarm",
"A153-C站ATE 條碼丟失Alarm",
"A154-C站ATE 省力裝置關閉超時Alarm",
"A155-C站ATE 條碼反饋超時Alarm",
"A156-C站ATE PCB測試超時Alarm",
"A157-C站ATE 省力裝置開啟超時Alarm",
"A158-C站ATE 省力裝置回原點超時Alarm",
"A159-C站ATE 省力裝置斷帶故障",
"A160-C站ATE 微動開關損壞",
"A161-C站ATE 異常匯總",
"A162-C站ATE省力装置不开起点位置",
"A163-",
"A164-",
"A165-",
"A166-",
"A167-",
"A168-",
"A169-",
"A170-D站ATE Robostar離開干涉區超時Alarm",
"A171-D站ATE PCB定位Alarm",
"A172-D站ATE PCB有板檢測Alarm",
"A173-D站ATE 條碼丟失Alarm",
"A174-D站ATE 省力裝置關閉超時Alarm",
"A175-D站ATE 條碼反饋超時Alarm",
"A176-D站ATE PCB測試超時Alarm",
"A177-D站ATE 省力裝置開啟超時Alarm",
"A178-D站ATE 省力裝置回原點超時Alarm",
"A179-D站ATE 省力裝置斷帶故障",
"A180-D站ATE 微動開關損壞",
"A181-D站ATE 異常匯總",
"A182-D站ATE省力装置不开起点位置",
"A183-",
"A184-",
"A185-",
"A186-",
"A187-",
"A188-",
"A189-",
"A190-",
"A191-",
"A192-",
"A193-",
"A194-",
"A195-",
"A196-",
"A197-",
"A198-",
"A199-"}

    Const ATE_Wpath As String = "C:\Robot_WR\"
    Const ATE_Rpath As String = "C:\Robot_RD\"
    Const Log_Path As String = "C:\Robot_LOG\"
    Const Temp_Data_F As String = "Robot_Tmp"
    Const SFCS_TA As String = "SFCF00002: Route error, Please go to TA - DIP_ATE."
    Const SFCS_Tup As String = "SFCF00002: Route error, Please go to TD - DIP_Function_A."
    Const First_ChkSn As String = "CN0P380WWSC007470M1TA00"
    Const SetFile_Path As String = "Main_Set_File"
    Dim PLC_IPadd As String
    Dim SnMk As Short = 0
    Dim TestMk(4) As Short
    Dim TestSN(4) As String
    Dim PLC_ReSet(99, 3) As String
    Dim PLC_ReN As Short = 0
    Dim Alarm_Mk(300) As Boolean
    Dim PSU As Boolean
    Dim PRCon As Short
    Dim TempSN_BfA(50) As String
    Dim TempSN_BfB(50) As String
    Dim Slzz_St(10) As Short

    Dim Msn_Ref As String
    Dim SN_Var(9) As String
    Dim Msn_Var(9) As String
    Dim VRAM_Note As String
    Dim VRAM_Var(9) As String
    Dim Ct_Var As String

    Dim SN1_Buff As String
    Dim ChkRoute_En As Boolean = False '
    Dim ChkMulti_En As Boolean = False
    Dim V_En As Boolean = False
    Dim Sn_Ready As Short = 0
    Dim Del_F As String
    Dim Sn_Timer_Tn As Integer
    Dim PLC_Time As Short
    Dim DayLog_Save As Integer
    Dim Test_StT(4) As Date
    Dim Double_Tim As Single
    Dim ErrPt As Short
    Dim TCP_WaitN As Short = 0
    Dim Thd_Sn1 As String
    Dim Thd_Sn2 As String
    Dim Thd_Sn3 As String
    Dim Thd_Sn4 As String
    Dim Thd_St1 As String
    Dim Thd_St2 As String
    Dim Thd_St3 As String
    Dim Thd_St4 As String
    Dim Thd_ChkRt_Run As Boolean
    Dim Lp As String = String.Empty
    Dim SktData As String = String.Empty
    Dim SktIP As String = String.Empty
    Dim SktPort As String = String.Empty  '
    Dim SktSst As String = String.Empty
    Const ATE_LP As Short = 5101
    Dim ATE_LA As String
    Dim ATE_LS As TcpListener
    Dim L_Thd As Thread    '
    Dim T_Thd As Thread
    Dim C_Thd As Thread
    Dim M_Thd As Thread
    Dim CIP As String
    Delegate Sub Dg_Text(ByVal ValueRult As String, ByVal obj As TextBox)
    Delegate Sub Dg_Lst(ByVal ValueRult As String)

    Private Sub Thread_ChkRoute_MultiSN()
        Dim Get_Sn(4) As String
        Dim Get_Fb As String = String.Empty
        On Error Resume Next

        If Thd_Sn1 = "" Then Exit Sub
        Thd_Sn2 = ""
        Thd_Sn3 = ""
        Thd_Sn4 = ""
        If ChkMulti_En = False Then GoTo Multi_SN_End
        Err.Clear()
        If Ct_Var = "F721" Then
            Dim Web_Link721 As F721_Web.WebService = New F721_Web.WebService
            Get_Sn = Web_Link721.GetLinkUSN(Thd_Sn1, Get_Fb)
        End If
        If Ct_Var = "F722" Then
            Dim Web_Link722 As F722_Web.WebServiceSoapClient = New F722_Web.WebServiceSoapClient
            Get_Sn = Web_Link722.GetLinkUSN(Thd_Sn1, Get_Fb)
        End If
        If Err.Number <> 0 Or Get_Fb <> "OK" Then
            Thd_Sn1 = "Error"
            Err.Clear()
            GoTo Multi_SN_End
        End If
        If Get_Sn.Length >= 1 Then Thd_Sn1 = Get_Sn(0)
        If Get_Sn.Length >= 2 Then Thd_Sn2 = Get_Sn(1)
        If Get_Sn.Length >= 3 Then Thd_Sn3 = Get_Sn(2)
        If Get_Sn.Length >= 4 Then Thd_Sn4 = Get_Sn(3)
        If Thd_Sn1 = "" Then
            Thd_Sn1 = "Error"
            Exit Sub
        End If
Multi_SN_End:
        If ChkRoute_En = False Then GoTo Check_Route_End

        Err.Clear()
        If Ct_Var = "F721" Then
            Dim Web_721 As F721_Web.WebService = New F721_Web.WebService
            If Thd_Sn1 <> "" Then Thd_St1 = Web_721.CheckRoute(Thd_Sn1, "AA")
            If Thd_Sn2 <> "" Then Thd_St2 = Web_721.CheckRoute(Thd_Sn2, "AA")
            If Thd_Sn3 <> "" Then Thd_St3 = Web_721.CheckRoute(Thd_Sn3, "AA")
            If Thd_Sn4 <> "" Then Thd_St4 = Web_721.CheckRoute(Thd_Sn4, "AA")
        End If


        If Ct_Var = "F722" Then
            Dim Web_722 As F722_Web.WebServiceSoap = New F722_Web.WebServiceSoapClient
            If Thd_Sn1 <> "" Then Thd_St1 = Web_722.CheckRoute(Thd_Sn1, "AA")
            If Thd_Sn2 <> "" Then Thd_St2 = Web_722.CheckRoute(Thd_Sn2, "AA")
            If Thd_Sn3 <> "" Then Thd_St3 = Web_722.CheckRoute(Thd_Sn3, "AA")
            If Thd_Sn4 <> "" Then Thd_St4 = Web_722.CheckRoute(Thd_Sn4, "AA")
        End If

        Thd_ChkRt_Run = True
Check_Route_End:

        If Err.Number <> 0 Then Err.Clear()
    End Sub

    Public Sub TCP_StartListen()
        On Error Resume Next

        TcpLten = New TcpListener(IPAddress.Any, ATE_LP)
        TcpLten.Start()

        While (True)
            Dim MyTcpClient As TcpClient = TcpLten.AcceptTcpClient()

            Dim MyStream As NetworkStream = MyTcpClient.GetStream()
            Dim MyBytes(1024) As Byte
            Dim MyBytesRead As Integer = MyStream.Read(MyBytes, 0, MyBytes.Length)
            Dim MyMessage As String = System.Text.UnicodeEncoding.GetEncoding("gb2312").GetString(MyBytes, 0, MyBytesRead)
            CIP = MyTcpClient.Client.RemoteEndPoint.ToString
            Me.Invoke(New Dg_Lst(AddressOf Recevice_Data_Line), MyMessage)
        End While

        If Err.Number <> 0 Then Err.Clear()
    End Sub
    Public Sub TCP_Closed()
        On Error Resume Next

        If L_Thd IsNot Nothing Then
            L_Thd.Abort()
        End If
        If TcpLten IsNot Nothing Then
            TcpLten.Stop()
        End If
    End Sub
    Public Sub TCP_Send_Data()
        If SktData = "" Or SktIP = "" Or SktPort = "" Then Exit Sub
        Try
            Dim MyTcpClient As TcpClient = New TcpClient(SktIP, SktPort)
            Dim MyTcpStream As Net.Sockets.NetworkStream = MyTcpClient.GetStream()

            Dim MyStream As IO.StreamWriter = New IO.StreamWriter(MyTcpStream, System.Text.UnicodeEncoding.GetEncoding("gb2312"))
            MyStream.Write(SktData)  
            MyStream.Close()  '
        Catch ex As Exception
            SktSst = "Send Error"
        End Try
        If Err.Number <> 0 Then Err.Clear()
    End Sub
    Private Sub Recevice_Data_Line(ByVal RecStr As String)
        Dim I As Short
        Dim StrMK As Short
        Dim OctMK As Short
        Dim HexMK As Short
        Dim OctS As Short
        Dim HexS As Short
        Dim StrSF As String
        Dim StrA As String
        On Error Resume Next
        If Mid(RecStr, 1, 12) = "A Test PASS=" Or Mid(RecStr, 1, 12) = "B Test PASS=" _
            Or Mid(RecStr, 1, 12) = "C Test PASS=" Or Mid(RecStr, 1, 12) = "D Test PASS=" _
            Or Mid(RecStr, 1, 10) = "A Test NG=" Or Mid(RecStr, 1, 10) = "B Test NG=" _
            Or Mid(RecStr, 1, 10) = "C Test NG=" Or Mid(RecStr, 1, 10) = "D Test NG=" Then
            Call All_Log_Add(RecStr)
            RecStr = ""
            Exit Sub '
        End If
        Select Case RecStr
            Case "+(02)$AOK+(03)"
                ATE_AST.BackColor = Color.Green
                Test_StT(1) = Now
                AST_Lab.Text = "Test OK"
                If AxActProgType1.SetDevice("D201", 13) <> 0 Then
                    PLC_ReSet(PLC_ReN, 0) = "D201"
                    PLC_ReSet(PLC_ReN, 1) = 13
                    PLC_ReSet(PLC_ReN, 2) = "w"
                    PLC_ReSet(PLC_ReN, 3) = "0"
                    PLC_ReN = PLC_ReN + 1
                End If
            Case "+(02)$BOK+(03)"
                ATE_BSt.BackColor = Color.Green
                Test_StT(2) = Now
                BST_Lab.Text = "Test OK"
                If AxActProgType1.SetDevice("D202", 13) <> 0 Then
                    PLC_ReSet(PLC_ReN, 0) = "D202"
                    PLC_ReSet(PLC_ReN, 1) = 13
                    PLC_ReSet(PLC_ReN, 2) = "w"
                    PLC_ReSet(PLC_ReN, 3) = "0"
                    PLC_ReN = PLC_ReN + 1
                End If
            Case "+(02)$COK+(03)"
                ATE_CSt.BackColor = Color.Green
                Test_StT(3) = Now
                CST_Lab.Text = "Test OK"
                If AxActProgType1.SetDevice("D203", 13) <> 0 Then
                    PLC_ReSet(PLC_ReN, 0) = "D203"
                    PLC_ReSet(PLC_ReN, 1) = 13
                    PLC_ReSet(PLC_ReN, 2) = "w"
                    PLC_ReSet(PLC_ReN, 3) = "0"
                    PLC_ReN = PLC_ReN + 1
                End If
            Case "+(02)$DOK+(03)"
                ATE_DSt.BackColor = Color.Green
                Test_StT(4) = Now
                DST_Lab.Text = "Test OK"
                If AxActProgType1.SetDevice("D204", 13) <> 0 Then
                    PLC_ReSet(PLC_ReN, 0) = "D204"
                    PLC_ReSet(PLC_ReN, 1) = 13
                    PLC_ReSet(PLC_ReN, 2) = "w"
                    PLC_ReSet(PLC_ReN, 3) = "0"
                    PLC_ReN = PLC_ReN + 1
                End If
            Case "+(02)$ANG+(03)"
                ATE_AST.BackColor = Color.Red
                Test_StT(1) = Now
                AST_Lab.Text = "Test OK"
                If AxActProgType1.SetDevice("D201", 14) <> 0 Then
                    PLC_ReSet(PLC_ReN, 0) = "D201"
                    PLC_ReSet(PLC_ReN, 1) = 14
                    PLC_ReSet(PLC_ReN, 2) = "w"
                    PLC_ReSet(PLC_ReN, 3) = "0"
                    PLC_ReN = PLC_ReN + 1
                End If
            Case "+(02)$BNG+(03)"
                ATE_BSt.BackColor = Color.Red
                Test_StT(2) = Now
                BST_Lab.Text = "Test OK"
                If AxActProgType1.SetDevice("D202", 14) <> 0 Then
                    PLC_ReSet(PLC_ReN, 0) = "D202"
                    PLC_ReSet(PLC_ReN, 1) = 14
                    PLC_ReSet(PLC_ReN, 2) = "w"
                    PLC_ReSet(PLC_ReN, 3) = "0"
                    PLC_ReN = PLC_ReN + 1
                End If
            Case "+(02)$CNG+(03)"
                ATE_CSt.BackColor = Color.Red
                Test_StT(3) = Now
                CST_Lab.Text = "Test Fail"
                If AxActProgType1.SetDevice("D203", 14) <> 0 Then
                    PLC_ReSet(PLC_ReN, 0) = "D203"
                    PLC_ReSet(PLC_ReN, 1) = 14
                    PLC_ReSet(PLC_ReN, 2) = "w"
                    PLC_ReSet(PLC_ReN, 3) = "0"
                    PLC_ReN = PLC_ReN + 1
                End If
            Case "+(02)$DNG+(03)"
                ATE_DSt.BackColor = Color.Red
                Test_StT(4) = Now
                DST_Lab.Text = "Test Fail"
                If AxActProgType1.SetDevice("D204", 14) <> 0 Then
                    PLC_ReSet(PLC_ReN, 0) = "D204"
                    PLC_ReSet(PLC_ReN, 1) = 14
                    PLC_ReSet(PLC_ReN, 2) = "w"
                    PLC_ReSet(PLC_ReN, 3) = "0"
                    PLC_ReN = PLC_ReN + 1
                End If
            Case "+(02)$AUK+(03)"
                If AxActProgType1.SetDevice("D210", 0) <> 0 Then
                    PLC_ReSet(PLC_ReN, 0) = "D210"
                    PLC_ReSet(PLC_ReN, 1) = 0
                    PLC_ReSet(PLC_ReN, 2) = "w"
                    PLC_ReSet(PLC_ReN, 3) = "0"
                    PLC_ReN = PLC_ReN + 1
                End If
                Call All_Log_Add("A ATE Unlock")
            Case "+(02)$BUK+(03)"
                If AxActProgType1.SetDevice("D210", 0) <> 0 Then
                    PLC_ReSet(PLC_ReN, 0) = "D210"
                    PLC_ReSet(PLC_ReN, 1) = 0
                    PLC_ReSet(PLC_ReN, 2) = "w"
                    PLC_ReSet(PLC_ReN, 3) = "0"
                    PLC_ReN = PLC_ReN + 1
                End If
                Call All_Log_Add("B ATE Unlock")
            Case "+(02)$CUK+(03)"
                If AxActProgType1.SetDevice("D211", 0) <> 0 Then
                    PLC_ReSet(PLC_ReN, 0) = "D211"
                    PLC_ReSet(PLC_ReN, 1) = 0
                    PLC_ReSet(PLC_ReN, 2) = "w"
                    PLC_ReSet(PLC_ReN, 3) = "0"
                    PLC_ReN = PLC_ReN + 1
                End If
                Call All_Log_Add("C ATE Unlock")
            Case "+(02)$DUK+(03)"
                If AxActProgType1.SetDevice("D211", 0) <> 0 Then
                    PLC_ReSet(PLC_ReN, 0) = "D211"
                    PLC_ReSet(PLC_ReN, 1) = 0
                    PLC_ReSet(PLC_ReN, 2) = "w"
                    PLC_ReSet(PLC_ReN, 3) = "0"
                    PLC_ReN = PLC_ReN + 1
                End If
                Call All_Log_Add("D ATE Unlock")
            Case "+(02)$ALK+(03)"
                If AxActProgType1.SetDevice("D210", 90) <> 0 Then
                    PLC_ReSet(PLC_ReN, 0) = "D210"
                    PLC_ReSet(PLC_ReN, 1) = 90
                    PLC_ReSet(PLC_ReN, 2) = "w"
                    PLC_ReSet(PLC_ReN, 3) = "0"
                    PLC_ReN = PLC_ReN + 1
                End If
                Call All_Log_Add("A ATE Lock")
            Case "+(02)$BLK+(03)"
                If AxActProgType1.SetDevice("D210", 90) <> 0 Then
                    PLC_ReSet(PLC_ReN, 0) = "D210"
                    PLC_ReSet(PLC_ReN, 1) = 90
                    PLC_ReSet(PLC_ReN, 2) = "w"
                    PLC_ReSet(PLC_ReN, 3) = "0"
                    PLC_ReN = PLC_ReN + 1
                End If
                Call All_Log_Add("B ATE Lock")
            Case "+(02)$CLK+(03)"
                If AxActProgType1.SetDevice("D211", 90) <> 0 Then
                    PLC_ReSet(PLC_ReN, 0) = "D211"
                    PLC_ReSet(PLC_ReN, 1) = 90
                    PLC_ReSet(PLC_ReN, 2) = "w"
                    PLC_ReSet(PLC_ReN, 3) = "0"
                    PLC_ReN = PLC_ReN + 1
                End If
                Call All_Log_Add("C ATE Lock")
            Case "+(02)$DLK+(03)"
                If AxActProgType1.SetDevice("D211", 90) <> 0 Then
                    PLC_ReSet(PLC_ReN, 0) = "D211"
                    PLC_ReSet(PLC_ReN, 1) = 90
                    PLC_ReSet(PLC_ReN, 2) = "w"
                    PLC_ReSet(PLC_ReN, 3) = "0"
                    PLC_ReN = PLC_ReN + 1
                End If
                Call All_Log_Add("D ATE Lock")
            Case "AB_Link_Request"
                If ATE_LS = True Then
                    Exit Sub
                    Exit Select
                End If
                St_Panel2.Text = "Connect OK"
                ATECon_StTxt.Text = "Connect OK"
                ATECon_StTxt.ForeColor = Color.LawnGreen
                Link_Timer = Microsoft.VisualBasic.Timer
                If CIP <> "" Then
                    I = InStr(CIP, ":")
                    If I > 0 Then
                        CIP = Mid(CIP, 1, I - 1)
                    End If
                    ATE_LA = "■" & CIP & "■" & ATE_LP
                    AB_IP_Lab.Text = "ATE Connect IP: " & CIP
                    Buff_TCPLst.Items.Add("AB_Link_OK" & ATE_LA)
                    If Timer_Send_Buffer.Enabled = False Then Timer_Send_Buffer.Enabled = True
                    ATE_LS = True
                End If
                Exit Sub
            Case "AB_Link_Chk"
                If ATE_LS = True Then
                    Link_Timer = Microsoft.VisualBasic.Timer
                Else
                    If CIP <> "" Then
                        I = InStr(CIP, ":")
                        If I > 0 Then
                            CIP = Mid(CIP, 1, I - 1)
                        End If
                        Buff_TCPLst.Items.Add("Re_Link" & "■" & CIP & "■" & ATE_LP)
                        If Timer_Send_Buffer.Enabled = False Then Timer_Send_Buffer.Enabled = True
                    End If
                End If
                Exit Sub
            Case "AB_Link_Close"
                St_Panel2.Text = "Connecting..."
                ATECon_StTxt.Text = "Connecting..."
                ATECon_StTxt.ForeColor = Color.Yellow
                AB_IP_Lab.Text = "ATE Connect IP:"
                ATE_LA = ""
                ATE_LS = False
            Case ""
                Exit Sub
            Case Else
                Call All_Log_Add("ATE AB:Error Signal=" & RecStr)
                Exit Sub
        End Select
        If Err.Number <> 0 Then Call Error_Process("Recevice_Data_Line" & ErrorToString())
    End Sub
    Private Sub Main_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim T_FileDate As Date
        Dim I As Short
        On Error Resume Next
        If Dir(Mid(Log_Path, 1, Log_Path.Length - 1), FileAttribute.Directory) = "" Then MkDir(Mid(Log_Path, 1, Log_Path.Length - 1)) '如是沒有Log路徑建立目錄
        Customer_Cmb.Text = "F721"
        DayLog_Save = Now.Day
        Test_StT(1) = Now
        Test_StT(2) = Now
        Test_StT(3) = Now
        Test_StT(4) = Now
        For I = 0 To 9
            Msn_Var(I) = ""
            VRAM_Var(I) = ""
            SN_Var(I) = ""
        Next
        Call Load_Setting_File()
        Call All_Log_Add("Tool Start!")
        FileOpen(1, ATE_Wpath & "AA", OpenMode.Output)
        FileClose(1)
        FileOpen(1, ATE_Rpath & "AA", OpenMode.Output)
        FileClose(1)
        Kill(ATE_Wpath & "*.*")
        Kill(ATE_Rpath & "*.*")
        L_Thd = New Thread(AddressOf TCP_StartListen)
        T_Thd = New Thread(AddressOf TCP_Send_Data)
        Thd_Sn1 = First_ChkSn
        Thd_ChkRt_Run = True
        C_Thd = New Thread(AddressOf Thread_ChkRoute_MultiSN)
        C_Thd.Start()
        If Err.Number <> 0 Then Call Error_Process("Main_CD_Form_Load" & ErrorToString())
    End Sub
    Private Sub Main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        On Error Resume Next
        If MsgBox("Are you sure Quit?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Question") = MsgBoxResult.Yes Then
            Call All_Log_Add("Robot Tool OFF!")
            Call All_Log_Add("@@")
            Call Save_Setting_File()
            Call TCP_Closed()
            If L_Thd IsNot Nothing Then
                If L_Thd.ThreadState = ThreadState.Running Then
                    L_Thd.Abort()
                End If
            End If
            If T_Thd IsNot Nothing Then
                If T_Thd.ThreadState = ThreadState.Running Then
                    T_Thd.Abort()
                End If
            End If
            If C_Thd IsNot Nothing Then
                If C_Thd.ThreadState = ThreadState.Running Then
                    C_Thd.Abort()
                End If
            End If
            Robot_Tool_Sel.Close()
        Else
            e.Cancel = True
        End If
        If Err.Number <> 0 Then Call Error_Process("Main_CD_FormClosing" & ErrorToString())
    End Sub
    Private Sub Start_B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Start_B.Click
        Dim Return_St As Integer
        On Error Resume Next
        If Start_B.Text = "Start" Then
            PLC_IPadd = Trim(PLC_IPTxt.Text)
            ChkRoute_En = SN_ChkRoute.Checked
            ChkMulti_En = Multi_SN_Chk.Checked
            V_En = False
            Ct_Var = Customer_Cmb.Text
            If PLC_IPadd = "" Then
                MsgBox("Error, Robot PLC IP Adress Empty!", MsgBoxStyle.Critical, "Error Information")
                Exit Sub
            End If
            If My.Computer.Network.Ping(PLC_IPadd, 800) <> True Then
                MsgBox("Error,""" & PLC_IPadd & """ IP Pin Check Error!", MsgBoxStyle.Critical, "Error Information")
                Call All_Log_Add("Error,""" & PLC_IPadd & """ IP Pin Check Error!")
                Exit Sub
            End If
            Call PLC_Connect(Return_St)
            If Return_St <> 0 Then
                MsgBox("Error,PLC Network Connect Error!", MsgBoxStyle.Critical, "Error Information")
                Call All_Log_Add("Error,PLC Network Connect Error!")
                Exit Sub
            End If
            Call All_Log_Add("PLC """ & PLC_IPadd & """ IP Pin Check OK")
            Call All_Log_Add("PLC Network Connect OK")
            Call Start_Mode_Set()
            If L_Thd.ThreadState = ThreadState.Running Then
                L_Thd.Abort()
            End If
            L_Thd = New Thread(AddressOf TCP_StartListen)
            L_Thd.Start()
        Else
            Call Stop_Mode_Set()
            Call TCP_Closed()
            Call PLC_Disconnect(Return_St)
        End If
        If Err.Number <> 0 Then Call Error_Process("Start_B_Click" & ErrorToString())
    End Sub
    Private Sub Start_Mode_Set()
        On Error Resume Next
        If Dir(Mid(ATE_Wpath, 1, ATE_Wpath.Length - 1), FileAttribute.Directory) = "" Then MkDir(Mid(ATE_Wpath, 1, ATE_Wpath.Length - 1))
        If Dir(Mid(ATE_Rpath, 1, ATE_Rpath.Length - 1), FileAttribute.Directory) = "" Then MkDir(Mid(ATE_Rpath, 1, ATE_Rpath.Length - 1))
        Call All_Log_Add("Manual Start!")
        St_Panel2.Text = "Connecting..."
        ATECon_StTxt.Text = "Connecting..."
        ATECon_StTxt.ForeColor = Color.Yellow
        Start_B.Text = "Stop"
        Start_B.ForeColor = Color.Red
        AB_IP_Lab.Text = "ATE Connect IP: "
        ATE_LS = False
        PLCCon_StTxt.Text = "Connect OK"
        PLCCon_StTxt.ForeColor = Color.LawnGreen
        Sn_Ready = 0
        Set_GpB.Enabled = False
        State_GpB.Enabled = True
        Alarm_Reset_B.Enabled = True
        Buzzer_Off_B.Enabled = True
        PLC_Start_B.Enabled = True
        PLC_Model_B.Enabled = True
        PLC_Stop_B.Enabled = True
        PLC_Pause_B.Enabled = True
        PLC_Origin_B.Enabled = True
        PLC_ReMate_B.Enabled = True
        Manual_Test_B.Enabled = True
        SN_Clear_B.Enabled = True
        Astation_B.Enabled = True
        Bstation_B.Enabled = True
        Cstation_B.Enabled = True
        Dstation_B.Enabled = True
        Apause_B.Enabled = True
        Bpause_B.Enabled = True
        Cpause_B.Enabled = True
        Dpause_B.Enabled = True
        Aslzz_Open_B.Enabled = True
        Aslzz_Close_B.Enabled = True
        Bslzz_Open_B.Enabled = True
        Bslzz_Close_B.Enabled = True
        Cslzz_Open_B.Enabled = True
        Cslzz_Close_B.Enabled = True
        Dslzz_Open_B.Enabled = True
        Dslzz_Close_B.Enabled = True
        Timer_ATE_F.Enabled = True
        Timer_ATE_F.Interval = 300
        Timer_RdPLC.Enabled = True
        Timer_RdPLC.Interval = 300
        If Err.Number <> 0 Then Call Error_Process("Start_Mode_Set" & ErrorToString()) 
    End Sub
    Private Sub Stop_Mode_Set()
        On Error Resume Next
        Call All_Log_Add("Manual Stop!")
        St_Panel2.Text = "No Connect"
        Start_B.Text = "Start"
        Start_B.ForeColor = Color.Blue
        ATECon_StTxt.Text = "No Connect"
        ATECon_StTxt.ForeColor = Color.Yellow
        AB_IP_Lab.Text = "ATE Connect IP: "
        ATE_LA = ""
        ATE_LS = False
        PLCCon_StTxt.Text = "No Connect"
        PLCCon_StTxt.ForeColor = Color.Yellow
        Set_GpB.Enabled = True
        State_GpB.Enabled = False
        Alarm_Reset_B.Enabled = False
        Buzzer_Off_B.Enabled = False
        PLC_Start_B.Enabled = False
        PLC_Model_B.Enabled = False
        PLC_Stop_B.Enabled = False
        PLC_Pause_B.Enabled = False
        PLC_Origin_B.Enabled = False
        PLC_ReMate_B.Enabled = False
        Manual_Test_B.Enabled = False
        SN_Clear_B.Enabled = False
        Astation_B.Enabled = False
        Bstation_B.Enabled = False
        Cstation_B.Enabled = False
        Dstation_B.Enabled = False
        Apause_B.Enabled = False
        Bpause_B.Enabled = False
        Cpause_B.Enabled = False
        Dpause_B.Enabled = False
        Aslzz_Open_B.Enabled = False
        Aslzz_Close_B.Enabled = False
        Bslzz_Open_B.Enabled = False
        Bslzz_Close_B.Enabled = False
        Cslzz_Open_B.Enabled = False
        Cslzz_Close_B.Enabled = False
        Dslzz_Open_B.Enabled = False
        Dslzz_Close_B.Enabled = False
        Timer_ATE_F.Enabled = False
        Timer_RdPLC.Enabled = False
        If Err.Number <> 0 Then Call Error_Process("Stop_Mode_Set" & ErrorToString())
    End Sub
    Private Sub Load_Setting_File()
        Dim StrA As String
        On Error Resume Next
        If My.Computer.FileSystem.FileExists(SetFile_Path) = False Then Exit Sub
        FileOpen(1, SetFile_Path, OpenMode.Input)
        Do While Not EOF(1)
            StrA = LineInput(1)
            If Mid(StrA, 1, 7) = "PLC IP:" Then PLC_IPTxt.Text = Mid(StrA, 8)
            If Mid(StrA, 1, 23) = "SN check route Enabled:" Then SN_ChkRoute.Checked = Mid(StrA, 24)
            If Mid(StrA, 1, 24) = "Search Multi SN Enabled:" Then Multi_SN_Chk.Checked = Mid(StrA, 25)
            If Mid(StrA, 1, 16) = "Customer Select:" Then Customer_Cmb.Text = Mid(StrA, 17)
        Loop
        FileClose(1)
        If Err.Number <> 0 Then Call Error_Process("Load_Setting_File" & ErrorToString())
    End Sub
    Private Sub Save_Setting_File()
        On Error Resume Next
        FileOpen(1, SetFile_Path, OpenMode.Output)
        PrintLine(1, "PLC IP:" & PLC_IPTxt.Text)
        PrintLine(1, "SN check route Enabled:" & SN_ChkRoute.Checked)
        PrintLine(1, "Search Multi SN Enabled:" & Multi_SN_Chk.Checked)
        PrintLine(1, "Customer Select:" & Customer_Cmb.Text)
        FileClose(1)
        If Err.Number <> 0 Then Call Error_Process("Save_Setting_File" & ErrorToString())
    End Sub
    Private Sub Timer_RdPLC_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_RdPLC.Tick
        Dim TSt_ShowB As Button = ATE_AST
        Dim TSt_ShowLab As Label = AST_Lab
        Dim Now_St As String = String.Empty
        Dim PLC_D As String = String.Empty
        Dim PLC_Signal(9) As Integer
        Dim TmpSN(30) As Integer
        Dim PLC_SnLst(300) As Integer
        Dim VRAM_T As String = String.Empty '
        Dim St_Mk As Short = 0
        Dim I As Integer
        Dim N As Integer
        Dim SN_T As Integer
        Dim MkA As Boolean
        On Error Resume Next
        If AxActProgType1.ReadDeviceBlock("D100", 9, PLC_Signal(0)) <> 0 Then
            PRCon = PRCon + 1
            Call All_Log_Add("PLC D00 Signal Read Error!")
        End If
        If PLC_Signal(0) + PLC_Signal(1) + PLC_Signal(2) + PLC_Signal(3) + PLC_Signal(4) = 0 Then
            GoTo Sn_Jumper
        End If
        If PLC_Signal(0) = 10 And (SnMk = 0 Or SnMk > 1) Then
            Call All_Log_Add("Robot SN Ready Check")
            If AxActProgType1.SetDevice("D200", 10) = 0 Then
                SnMk = 1
                AxActProgType1.SetDevice("D100", 0) '
            Else
                PRCon = PRCon + 1
                Call All_Log_Add("Send to PLC Data Error!-D200(10)")
            End If
        End If
        If PLC_Signal(0) = 11 And SnMk = 1 Then
            If AxActProgType1.ReadDeviceBlock("D1000", 30, TmpSN(0)) = 0 Then
                SnMk = 2
                Call Sn_Dec_Str(TmpSN, SN_T)
                SN_T = UCase(Trim(SN_T))
                Call All_Log_Add("Temp SN Check=" & SN_T)
                If ChkRoute_En Then  '
                    Thd_Sn1 = SN_T
                    Msn_Ref = SN_T '
                    Thd_St1 = ""
                    If C_Thd.ThreadState = ThreadState.Running Then C_Thd.Abort()
                    If ChkMulti_En Or V_En Then
                        I = Array.IndexOf(SN_Var, "")
                        If I = -1 Then
                            For I = 0 To 9
                                If SN_Lst.FindString(SN_Var(I)) = -1 Then
                                    SN_Var(I) = ""
                                    Msn_Var(I) = ""
                                    VRAM_Var(I) = ""
                                End If
                            Next
                            I = Array.IndexOf(SN_Var, "")
                            SN_Var(I) = SN_T
                        Else
                            SN_Var(I) = SN_T
                        End If
                    End If
                    Sn_Ready = 0
                    Thd_ChkRt_Run = False
                    C_Thd = New Thread(AddressOf Thread_ChkRoute_MultiSN)
                    C_Thd.Start()
                    Timer_SN.Enabled = True
                End If
            Else
                PRCon = PRCon + 1
                Call All_Log_Add("Read PLC Data Error!-D1000(SN)")
                GoTo Sn_Jumper
            End If
        End If
        If PLC_Signal(0) = 11 And SnMk = 2 Then
            If AxActProgType1.SetDevice("D200", 11) = 0 Then
                SnMk = 3
            Else
                PRCon = PRCon + 1
                Call All_Log_Add("Send PLC Data Error!-D200(11)")
                GoTo Sn_Jumper
            End If
        End If
        If PLC_Signal(0) = 11 And SnMk = 3 Then
            If ChkRoute_En = True And Sn_Ready = 1 Then
                If AxActProgType1.SetDevice("D200", 12) = 0 Then
                    SnMk = 4
                    If ChkMulti_En Or V_En Then
                        I = Array.IndexOf(SN_Var, Msn_Ref)
                        If I <> -1 Then
                            Msn_Var(I) = Thd_Sn1
                            If Thd_Sn2 <> "" Then Msn_Var(I) = Msn_Var(I) & "=&=" & Thd_Sn2
                            If Thd_Sn3 <> "" Then Msn_Var(I) = Msn_Var(I) & "=&=" & Thd_Sn3
                            If Thd_Sn4 <> "" Then Msn_Var(I) = Msn_Var(I) & "=&=" & Thd_Sn4
                            VRAM_Var(I) = VRAM_Note '
                            Call All_Log_Add("Temp SN CheckRoute OK(" & I.ToString & ")=" & Msn_Var(I) & " " & VRAM_Var(I))
                        End If
                    Else
                        Call All_Log_Add("Temp SN CheckRoute OK=" & Thd_Sn1)
                    End If
                Else
                    PRCon = PRCon + 1
                    Call All_Log_Add("Send PLC Data Error!-D200(12)")
                    GoTo Sn_Jumper
                End If
                Sn_Ready = 0
            End If
            If ChkRoute_En = True And Sn_Ready = 2 Then
                If AxActProgType1.SetDevice("D200", 13) = 0 Then
                    SnMk = 4
                    If ChkMulti_En Or V_En Then
                        I = Array.IndexOf(SN_Var, Msn_Ref)
                        If I <> -1 Then
                            Call All_Log_Add("Temp SN CheckRoute NG=" & Thd_Sn1 & " " & Thd_Sn2 & " " & Thd_Sn3 & " " & Thd_Sn4)
                            SN_Var(I) = ""
                            Msn_Var(I) = ""
                            VRAM_Var(I) = ""
                        End If
                    Else
                        Call All_Log_Add("Temp SN CheckRoute NG=" & Thd_Sn1)
                    End If
                Else
                    PRCon = PRCon + 1
                    Call All_Log_Add("Send PLC Data Error!-D200(12)")
                    GoTo Sn_Jumper
                End If
                Sn_Ready = 0
            End If
            If ChkRoute_En = False Then
                If AxActProgType1.SetDevice("D200", 12) = 0 Then
                    Call All_Log_Add("Temp SN CheckRoute By Pass=" & Thd_Sn1)
                    SnMk = 4
                Else
                    PRCon = PRCon + 1
                    Call All_Log_Add("Send PLC Data Error!-D200(12)")
                    GoTo Sn_Jumper
                End If
            End If
        End If
        If PLC_Signal(0) = 15 And SnMk = 4 Then
            If AxActProgType1.SetDevice("D200", 15) = 0 Then
                SnMk = 0
            Else
                PRCon = PRCon + 1
                Call All_Log_Add("Send PLC Data Error!-D200(15)")
                GoTo Sn_Jumper
            End If
        End If
Sn_Jumper:
        For St_Mk = 1 To 4
            If St_Mk = 1 Then
                Now_St = "A"
                TSt_ShowB = ATE_AST
                TSt_ShowLab = AST_Lab
            End If
            If St_Mk = 2 Then
                Now_St = "B"
                TSt_ShowB = ATE_BSt
                TSt_ShowLab = BST_Lab
            End If
            If St_Mk = 3 Then
                Now_St = "C"
                TSt_ShowB = ATE_CSt
                TSt_ShowLab = CST_Lab
            End If
            If St_Mk = 4 Then
                Now_St = "D"
                TSt_ShowB = ATE_DSt
                TSt_ShowLab = DST_Lab
            End If
            If PLC_Signal(St_Mk) = 10 And (TestMk(St_Mk) = 0 Or TestMk(St_Mk) > 1) Then
                Call All_Log_Add(Now_St & "=Test Ready Check")
                If AxActProgType1.SetDevice("D20" & St_Mk.ToString, 10) = 0 Then
                    TestMk(St_Mk) = 1
                    AxActProgType1.SetDevice("D10" & St_Mk.ToString, 0)
                Else
                    PRCon = PRCon + 1
                    Call All_Log_Add("Send to PLC Data Error!-D20" & St_Mk.ToString & "(10)")
                End If
            End If
            If AxActProgType1.ReadDeviceBlock("D1" & St_Mk.ToString & "00", 30, TmpSN(0)) = 0 Then
                If AxActProgType1.SetDevice("D20" & St_Mk.ToString, 11) <> 0 Then
                    GoTo Test_Jumper
                End If
                TestMk(St_Mk) = 2
                Call Sn_Dec_Str(TmpSN, SN_T)
                SN_T = UCase(Trim(SN_T))
                If Mid(SN_T, SN_T.Length) = Chr(13) Then SN_T = Mid(SN_T, 1, SN_T.Length - 1)
                If ChkMulti_En Or V_En Then
                    I = Array.IndexOf(SN_Var, SN_T)
                    If I <> -1 Then
                        If ChkMulti_En Then
                            SN_T = Msn_Var(I)
                            For N = 1 To 4
                                N = InStr(SN_T, "=&=")
                                If N > 0 Then
                                    SN_T = Mid(SN_T, 1, N - 1) & Mid(SN_T, N + 3, SN_T.Length - N - 2)
                                Else
                                    Exit For
                                End If
                            Next
                        End If
                        If V_En Then VRAM_T = VRAM_Var(I)
                        SN_Var(I) = ""
                        Msn_Var(I) = ""
                        VRAM_Var(I) = ""
                    Else
                        Call All_Log_Add("Get Multi SN Error!")
                        Call All_Log_Add("SN_T=" & SN_T)
                        For I = 0 To 9
                            Call All_Log_Add("SN_Var " & I.ToString & "=" & SN_Var(I))
                        Next
                    End If
                End If
                Call All_Log_Add(Now_St & " Load PCBA SN=" & SN_T & " " & VRAM_T)
                If SN_T <> "" Then
                    FileOpen(1, ATE_Rpath & "Bar_" & Now_St, OpenMode.Output)
                    PrintLine(1, SN_T)
                    FileClose(1)
                Else
                    Call All_Log_Add(Now_St & "=Error SN Empty!")
                End If
                TestSN(St_Mk) = SN_T
                If V_En Then
                    Buff_TCPLst.Items.Add(Now_St & "=" & SN_T & "=VRAM=" & VRAM_T & ATE_LA)
                Else
                    Buff_TCPLst.Items.Add(Now_St & "=" & SN_T & ATE_LA)
                End If
                Timer_Send_Buffer.Enabled = True
                Test_StT(St_Mk) = Now
                TSt_ShowB.BackColor = Color.Olive
                TSt_ShowLab.Text = "SN Ready"
            Else
                PRCon = PRCon + 1
                Call All_Log_Add("Read PLC Data Error!-D1" & St_Mk.ToString & "00(SN)")
                GoTo Test_Jumper
            End If
            If PLC_Signal(St_Mk) = 12 And TestMk(St_Mk) = 2 Then
                If AxActProgType1.SetDevice("D20" & St_Mk.ToString, 12) <> 0 Then
                    Call All_Log_Add("Send to PLC Data Error!-D20" & St_Mk.ToString & "(12)")
                End If
                TestMk(St_Mk) = 3
                FileOpen(1, ATE_Rpath & "+(2)$" & Now_St & "ST+(13)(10)", OpenMode.Output)
                PrintLine(1, "AAAAA")
                FileClose(1)
                Buff_TCPLst.Items.Add(Now_St & "ST" & ATE_LA)
                Timer_Send_Buffer.Enabled = True
                TSt_ShowB.BackColor = Color.Yellow
                Test_StT(St_Mk) = Now
                TSt_ShowLab.Text = "Testing"
                Call All_Log_Add(Now_St & "=Start Test=" & TestSN(St_Mk))
            End If
            If PLC_Signal(St_Mk) = 15 And TestMk(St_Mk) = 3 Then
                If AxActProgType1.SetDevice("D20" & St_Mk.ToString, 15) = 0 Then
                    TestMk(St_Mk) = 4
                Else
                    PRCon = PRCon + 1
                    Call All_Log_Add("Send to PLC Data Error!-D20" & St_Mk.ToString & "(15)")
                End If
            End If
        Next

Test_Jumper:

        If Manual_Test_B.BackColor = Color.LawnGreen Then
            For St_Mk = 5 To 8
                If St_Mk = 5 Then
                    Now_St = "A"
                    TSt_ShowB = ATE_AST
                    TSt_ShowLab = AST_Lab
                End If
                If St_Mk = 6 Then
                    Now_St = "B"
                    TSt_ShowB = ATE_BSt
                    TSt_ShowLab = BST_Lab
                End If
                If St_Mk = 7 Then
                    Now_St = "C"
                    TSt_ShowB = ATE_CSt
                    TSt_ShowLab = CST_Lab
                End If
                If St_Mk = 8 Then
                    Now_St = "D"
                    TSt_ShowB = ATE_DSt
                    TSt_ShowLab = DST_Lab
                End If
                If PLC_Signal(St_Mk) = 11 And Slzz_St(St_Mk) <> PLC_Signal(St_Mk) Then
                    FileOpen(1, ATE_Rpath & "+(2)$" & Now_St & "ST+(13)(10)", OpenMode.Output)
                    PrintLine(1, "AAAAA")
                    FileClose(1)
                    Buff_TCPLst.Items.Add(Now_St & "ST" & ATE_LA)
                    Timer_Send_Buffer.Enabled = True
                    TSt_ShowB.BackColor = Color.Yellow
                    Test_StT(St_Mk) = Now
                    TSt_ShowLab.Text = "Testing"
                    Call All_Log_Add(Now_St & "=Start Test")
                End If
                Slzz_St(St_Mk) = PLC_Signal(St_Mk)
            Next
        End If
        If AxActProgType1.ReadDeviceBlock("D1000", 100, PLC_SnLst(0)) = 0 Then
            ReDim TmpSN(30)
            For I = 0 To 29
                TmpSN(I) = PLC_SnLst(I)
            Next
            SN_T = ""
            Call Sn_Dec_Str(TmpSN, SN_T)
            If SN_Lst.Items.Count >= 1 Then
                If SN_Lst.Items(0) <> SN_T Then SN_Lst.Items(0) = SN_T
            Else
                SN_Lst.Items.Add(SN_T)
            End If
            ReDim TmpSN(30)
            For I = 0 To 29
                TmpSN(I) = PLC_SnLst(30 + I)
            Next
            SN_T = ""
            Call Sn_Dec_Str(TmpSN, SN_T)
            If SN_Lst.Items.Count >= 2 Then
                If SN_Lst.Items(1) <> SN_T Then SN_Lst.Items(1) = SN_T
            Else
                SN_Lst.Items.Add(SN_T)
            End If
            ReDim TmpSN(30)
            For I = 0 To 29
                TmpSN(I) = PLC_SnLst(60 + I)
            Next
            SN_T = ""
            Call Sn_Dec_Str(TmpSN, SN_T)
            If SN_Lst.Items(2) <> SN_T Then SN_Lst.Items(2) = SN_T
        Else
            SN_Lst.Items.Add(SN_T)
        End If

        If PLC_ReN > 0 Then
            MkA = False
            For I = 0 To PLC_ReN
                If PLC_ReSet(I, 2) = "w" Then
                    MkA = True
                    If AxActProgType1.SetDevice(PLC_ReSet(I, 0), PLC_ReSet(I, 1)) <> 0 Then
                        PLC_ReSet(I, 3) = (Val(PLC_ReSet(I, 3)) + 1).ToString
                        Call All_Log_Add("Send PLC Data Error!-" & PLC_ReSet(I, 1) & "(" & PLC_ReSet(I, 2) & ")")
                        If PLC_ReSet(I, 3) = "3" Then
                            PLC_ReSet(I, 0) = ""
                            PLC_ReSet(I, 1) = ""
                            PLC_ReSet(I, 2) = ""
                            PLC_ReSet(I, 3) = ""
                        End If
                    Else
                        PLC_ReSet(I, 0) = ""
                        PLC_ReSet(I, 1) = ""
                        PLC_ReSet(I, 2) = ""
                        PLC_ReSet(I, 3) = ""
                    End If
                End If
            Next
            If MkA = False Then PLC_ReN = 0
        End If

        If PSU Then
            PSU = False
            Call Update_Robot_State()
            Call PLC_Alarm_Show()
        Else
            PSU = True
        End If
        If PRCon > 14 And PRCon < 1000 Then
            Call PLC_Disconnect(I)
            PRCon = 1001
        End If
        If PRCon > 1000 Then
            Call PLC_Connect(I)
            PRCon = 0
            If I <> 0 Then
                Call All_Log_Add("Error,PLC Network Connect Error!")
            End If
        End If
        If Err.Number <> 0 Then Call Error_Process("Timer_RdPLC_Tick" & ErrorToString()) 'if on error add show list and clear error
    End Sub
    Private Sub Sn_Dec_Str(ByVal Dec_In() As Integer, ByRef SN_Data As String)
        Dim I As Short
        Dim TmpStr As String
        On Error Resume Next
        SN_Data = ""
        For I = 0 To 13
            If Dec_In(I) = 0 Then Exit For
            TmpStr = Hex(Dec_In(I))
            If TmpStr.Length = 3 And Mid(TmpStr, 1, 1) = "D" Then TmpStr = Mid(TmpStr, 2)

            If TmpStr.Length >= 3 And Mid(TmpStr, 3, 2) <> "00" Then SN_Data = SN_Data & ChrW(Convert.ToInt32(Mid(TmpStr, 3, 2), 16))
            If TmpStr.Length > 0 And Mid(TmpStr, 1, 2) <> "00" Then SN_Data = SN_Data & ChrW(Convert.ToInt32(Mid(TmpStr, 1, 2), 16))
        Next
        If Err.Number <> 0 Then Call Error_Process("Sn_Dec_Str" & ErrorToString())
    End Sub
    Private Sub Dec_to_Bin(ByVal Rd() As Integer, ByRef Dec_V() As Integer)
        Dim I As Integer
        Dim N As Integer
        Dim Code_Loc As String
        On Error Resume Next
        If Rd(0) + Rd(1) + Rd(2) + Rd(3) + Rd(4) + Rd(5) + Rd(6) + Rd(7) + Rd(8) + Rd(9) + Rd(10) + Rd(11) + Rd(12) = 0 Then
            ReDim Dec_V(208)
            Exit Sub
        End If
        For I = 0 To 12
            Code_Loc = ""
            Do While Rd(I)
                Code_Loc = Rd(I) Mod 2 & Code_Loc
                Rd(I) = Rd(I) \ 2
            Loop
            Code_Loc = Space(16 - Code_Loc.Length) & Code_Loc
            For N = 1 To 16
                If Mid(Code_Loc, 17 - N, 1) = "0" Or Mid(Code_Loc, 17 - N, 1) = " " Then
                    Dec_V(I * 16 + N) = 0
                Else
                    Dec_V(I * 16 + N) = 1
                End If
            Next
        Next
        If Err.Number <> 0 Then Call Error_Process("Dec_to_Bin" & ErrorToString())
    End Sub
    Private Sub Update_Robot_State()
        Dim TRD_D(4) As Integer
        Dim MRd_D(2) As Integer
        Dim Rd_D(13) As Integer
        Dim Bit_V(208) As Integer
        On Error Resume Next
        AxActProgType1.ReadDeviceBlock("M1008", 3, Rd_D(0))
        AxActProgType1.ReadDeviceBlock("X0", 4, TRD_D(0))
        AxActProgType1.ReadDeviceBlock("M1488", 2, MRd_D(0))
        Rd_D(3) = MRd_D(0)
        Rd_D(4) = TRD_D(0)
        Rd_D(5) = TRD_D(1)
        Rd_D(6) = TRD_D(2)
        Rd_D(7) = TRD_D(3)
        Rd_D(8) = MRd_D(1)
        Call Dec_to_Bin(Rd_D, Bit_V)

        If Bit_V(1) = 1 Then
            Manual_Test_B.BackColor = Color.LawnGreen
            Manual_Test_B.ForeColor = Color.Firebrick
        Else
            Manual_Test_B.BackColor = Color.WhiteSmoke
            Manual_Test_B.ForeColor = Color.Black
        End If
        If Bit_V(4) = 1 Then
            Buzzer_Off_B.BackColor = Color.LawnGreen
            Buzzer_Off_B.ForeColor = Color.Firebrick
        Else
            Buzzer_Off_B.BackColor = Color.WhiteSmoke
            Buzzer_Off_B.ForeColor = Color.Black
        End If

        If Bit_V(14) = 1 Then
            Astation_B.BackColor = Color.LawnGreen
            Astation_B.ForeColor = Color.Firebrick
            Apause_B.Enabled = True
        Else
            Astation_B.BackColor = Color.Gray
            Astation_B.ForeColor = Color.Yellow
            Apause_B.Enabled = False
        End If
        If Bit_V(15) = 1 Then
            Apause_B.BackColor = Color.Sienna
            Apause_B.ForeColor = Color.Lime
        Else
            Apause_B.BackColor = Color.Gray
            Apause_B.ForeColor = Color.Yellow
        End If
        If Bit_V(19) = 1 Then
            Bstation_B.BackColor = Color.LawnGreen
            Bstation_B.ForeColor = Color.Firebrick
            Bpause_B.Enabled = True
        Else
            Bstation_B.BackColor = Color.Gray
            Bstation_B.ForeColor = Color.Yellow
            Bpause_B.Enabled = False
        End If
        If Bit_V(20) = 1 Then
            Bpause_B.BackColor = Color.Sienna
            Bpause_B.ForeColor = Color.Lime
        Else
            Bpause_B.BackColor = Color.Gray
            Bpause_B.ForeColor = Color.Yellow
        End If
        If Bit_V(24) = 1 Then
            Cstation_B.BackColor = Color.LawnGreen
            Cstation_B.ForeColor = Color.Firebrick
            Cpause_B.Enabled = True
        Else
            Cstation_B.BackColor = Color.Gray
            Cstation_B.ForeColor = Color.Yellow
            Cpause_B.Enabled = False
        End If
        If Bit_V(25) = 1 Then
            Cpause_B.BackColor = Color.Sienna
            Cpause_B.ForeColor = Color.Lime
        Else
            Cpause_B.BackColor = Color.Gray
            Cpause_B.ForeColor = Color.Yellow
        End If
        If Bit_V(29) = 1 Then
            Dstation_B.BackColor = Color.LawnGreen
            Dstation_B.ForeColor = Color.Firebrick
            Dpause_B.Enabled = True
        Else
            Dstation_B.BackColor = Color.Gray
            Dstation_B.ForeColor = Color.Yellow
            Dpause_B.Enabled = False
        End If
        If Bit_V(30) = 1 Then
            Dpause_B.BackColor = Color.Sienna
            Dpause_B.ForeColor = Color.Lime
        Else
            Dpause_B.BackColor = Color.Gray
            Dpause_B.ForeColor = Color.Yellow
        End If
        If Bit_V(62) = 1 Then
            If Bit_V(61) = 1 Then
                PLC_Start_B.BackColor = Color.LawnGreen
                PLC_Start_B.ForeColor = Color.Firebrick
                PLC_Stop_B.Enabled = True
                PLC_Pause_B.Enabled = True
                PLC_Origin_B.Enabled = False
                PLC_ReMate_B.Enabled = False
            Else
                PLC_Start_B.BackColor = Color.WhiteSmoke
                PLC_Start_B.ForeColor = Color.Black
                If Bit_V(129) = 1 Then
                    PLC_Pause_B.Enabled = False
                    PLC_Stop_B.Enabled = True
                    PLC_Origin_B.Enabled = False
                    PLC_ReMate_B.Enabled = False
                Else
                    PLC_Pause_B.Enabled = False
                    PLC_Stop_B.Enabled = False
                    PLC_Origin_B.Enabled = True
                    PLC_ReMate_B.Enabled = True
                End If
            End If
            Manual_Test_B.Enabled = False
            PLC_Model_B.BackColor = Color.LawnGreen
            PLC_Model_B.ForeColor = Color.Firebrick
            Aslzz_Open_B.Enabled = False
            Bslzz_Open_B.Enabled = False
            Cslzz_Open_B.Enabled = False
            Dslzz_Open_B.Enabled = False
            Aslzz_Close_B.Enabled = False
            Bslzz_Close_B.Enabled = False
            Cslzz_Close_B.Enabled = False
            Dslzz_Close_B.Enabled = False
        Else
            PLC_Start_B.BackColor = Color.WhiteSmoke
            PLC_Start_B.ForeColor = Color.Black
            PLC_Pause_B.Enabled = False
            PLC_Stop_B.Enabled = False
            PLC_Origin_B.Enabled = True
            PLC_ReMate_B.Enabled = True
            Manual_Test_B.Enabled = True
            PLC_Model_B.BackColor = Color.RoyalBlue
            PLC_Model_B.ForeColor = Color.Yellow
            Aslzz_Open_B.Enabled = True
            Bslzz_Open_B.Enabled = True
            Cslzz_Open_B.Enabled = True
            Dslzz_Open_B.Enabled = True
            Aslzz_Close_B.Enabled = True
            Bslzz_Close_B.Enabled = True
            Cslzz_Close_B.Enabled = True
            Dslzz_Close_B.Enabled = True
            TestMk(1) = 0
            TestMk(2) = 0
            TestMk(3) = 0
            TestMk(4) = 0
            SnMk = 0
        End If
        If Bit_V(63) = 1 Then
            PLC_Stop_B.BackColor = Color.Yellow
            PLC_Stop_B.ForeColor = Color.Purple
        Else
            PLC_Stop_B.BackColor = Color.WhiteSmoke
            PLC_Stop_B.ForeColor = Color.Black
        End If
        If Bit_V(64) = 1 Then
            PLC_Origin_B.BackColor = Color.Yellow
            PLC_Origin_B.ForeColor = Color.Purple
        Else
            PLC_Origin_B.BackColor = Color.WhiteSmoke
            PLC_Origin_B.ForeColor = Color.Black
        End If
        If Bit_V(129) = 1 Then
            PLC_Pause_B.BackColor = Color.Red
            PLC_Pause_B.ForeColor = Color.LawnGreen
        Else
            PLC_Pause_B.BackColor = Color.WhiteSmoke
            PLC_Pause_B.ForeColor = Color.Black
        End If
        If Bit_V(77) = 1 Then
            A_Light_Lab.BackColor = Color.LawnGreen
            A_Light_Lab.ForeColor = Color.Firebrick
        Else
            A_Light_Lab.BackColor = Color.Gray
            A_Light_Lab.ForeColor = Color.Yellow
        End If
        If Bit_V(78) = 1 Then
            A_Sw_Lab.BackColor = Color.LawnGreen
            A_Sw_Lab.ForeColor = Color.Firebrick
        Else
            A_Sw_Lab.BackColor = Color.Gray
            A_Sw_Lab.ForeColor = Color.Yellow
        End If
        If Bit_V(89) = 1 Then
            B_Light_Lab.BackColor = Color.LawnGreen
            B_Light_Lab.ForeColor = Color.Firebrick
        Else
            B_Light_Lab.BackColor = Color.Gray
            B_Light_Lab.ForeColor = Color.Yellow
        End If
        If Bit_V(90) = 1 Then
            B_Sw_Lab.BackColor = Color.LawnGreen
            B_Sw_Lab.ForeColor = Color.Firebrick
        Else
            B_Sw_Lab.BackColor = Color.Gray
            B_Sw_Lab.ForeColor = Color.Yellow
        End If
        If Bit_V(101) = 1 Then
            C_Light_Lab.BackColor = Color.LawnGreen
            C_Light_Lab.ForeColor = Color.Firebrick
        Else
            C_Light_Lab.BackColor = Color.Gray
            C_Light_Lab.ForeColor = Color.Yellow
        End If
        If Bit_V(102) = 1 Then
            C_Sw_Lab.BackColor = Color.LawnGreen
            C_Sw_Lab.ForeColor = Color.Firebrick
        Else
            C_Sw_Lab.BackColor = Color.Gray
            C_Sw_Lab.ForeColor = Color.Yellow
        End If
        If Bit_V(113) = 1 Then
            D_Light_Lab.BackColor = Color.LawnGreen
            D_Light_Lab.ForeColor = Color.Firebrick
        Else
            D_Light_Lab.BackColor = Color.Gray
            D_Light_Lab.ForeColor = Color.Yellow
        End If
        If Bit_V(114) = 1 Then
            D_Sw_Lab.BackColor = Color.LawnGreen
            D_Sw_Lab.ForeColor = Color.Firebrick
        Else
            D_Sw_Lab.BackColor = Color.Gray
            D_Sw_Lab.ForeColor = Color.Yellow
        End If
        If Err.Number <> 0 Then Call Error_Process("Update_Robot_State" & ErrorToString())
    End Sub
    Private Sub PLC_Alarm_Show()
        Dim Rd_D(13) As Integer
        Dim Bit_V(208) As Integer
        On Error Resume Next
        AxActProgType1.ReadDeviceBlock("M2992", 13, Rd_D(0))
        Call Dec_to_Bin(Rd_D, Bit_V)
        Call PLC_Find_Code(Bit_V)
        If Err.Number <> 0 Then Call Error_Process("PLC_Alarm_Show" & ErrorToString())
    End Sub
    Private Sub PLC_Find_Code(ByVal Dec_V() As Integer)
        Dim I As Integer
        Dim StrA As String
        On Error Resume Next
        StrA = ""
        For I = 9 To 208
            If Dec_V(I) = 1 Then
                If PLC_Alarm_Code(I) <> "" Then
                    If StrA <> "" Then StrA = StrA & vbCrLf
                    StrA = StrA & PLC_Alarm_Code(I)
                    If Alarm_Mk(I) = False Then
                        Alarm_Mk(I) = True
                        Call All_Log_Add(PLC_Alarm_Code(I) & "----Start")
                    End If
                End If
            ElseIf Alarm_Mk(I) = True Then
                Call All_Log_Add(PLC_Alarm_Code(I) & "--End")
                Alarm_Mk(I) = False
            End If
            Dec_V(I) = 0
        Next
        PLC_Alarm_Txt.Text = StrA
        If Err.Number <> 0 Then Call Error_Process("PLC_Find_Code" & ErrorToString())
    End Sub
    Private Sub Show_CheckRoute_Result(ByVal StrD As String, ByVal obj As TextBox)
        Dim I As Short
        On Error Resume Next
        If StrD = SFCS_TA Or StrD = SFCS_Tup Then
            obj.Text = "SFCS Check Route OK"
            obj.ForeColor = Color.LawnGreen
            Exit Sub
        End If
        I = InStr(StrD, ":")
        If I > 0 Then
            obj.ForeColor = Color.Yellow
            obj.Text = Trim(Mid(StrD, I + 1))
        End If
        If Err.Number <> 0 Then Call Error_Process("Show_CheckRoute_Result" & ErrorToString())
    End Sub
    Private Sub Show_GetSN_Result(ByVal StrD As String, ByVal obj As TextBox)
        On Error Resume Next
        obj.Text = StrD
        If Err.Number <> 0 Then Call Error_Process("Show_GetSN_Result" & ErrorToString())
    End Sub
    Private Sub Timer_ATE_F_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer_ATE_F.Tick
        Dim Send_File As String
        Dim MyName As String
        Dim I As Short
        Dim StrSF As String
        Dim TmpStr As String = String.Empty
        Dim TmpDate As Date
        Dim Log_Name As String
        Dim Now_Timer As Single
        On Error Resume Next
        Now_Timer = Microsoft.VisualBasic.Timer
        If ATE_LS = True And Now_Timer - Link_Timer >= 4 Then
            Link_Timer = Now_Timer
            St_Panel2.Text = "Connecting..."
            ATECon_StTxt.Text = "Connecting..."
            ATECon_StTxt.ForeColor = Color.Yellow
            AB_IP_Lab.Text = "ATE Connect IP:"
            ATE_LA = ""
            ATE_LS = False
            Call All_Log_Add("AB machine connect interrupt!")
        ElseIf ATE_LS = True And Now_Timer < Link_Timer Then
            Link_Timer = Now_Timer
        End If
        If DateDiff(DateInterval.Minute, Test_StT(1), Now) >= 5 And AST_Lab.Text <> "None" Then
            AST_Lab.Text = "None"
            ATE_AST.BackColor = Color.Gray
            Call All_Log_Add("Test Time Out=A!")
        End If
        If DateDiff(DateInterval.Minute, Test_StT(2), Now) >= 5 And BST_Lab.Text <> "None" Then
            BST_Lab.Text = "None"
            ATE_BSt.BackColor = Color.Gray
            Call All_Log_Add("Test Time Out=B!")
        End If
        If DateDiff(DateInterval.Minute, Test_StT(3), Now) >= 5 And CST_Lab.Text <> "None" Then
            CST_Lab.Text = "None"
            ATE_CSt.BackColor = Color.Gray
            Call All_Log_Add("Test Time Out=C!")
        End If
        If DateDiff(DateInterval.Minute, Test_StT(4), Now) >= 5 And DST_Lab.Text <> "None" Then
            DST_Lab.Text = "None"
            ATE_DSt.BackColor = Color.Gray
            Call All_Log_Add("Test Time Out=D!")
        End If
        If St_Panel3.Text <> Now.ToString Then St_Panel3.Text = Now.ToString

        If PLC_Time <> 8 And Hour(Now) = 8 Then
            If Timer_Send_Buffer.Enabled = False Then Timer_Send_Buffer.Enabled = True
            Call All_Log_Add("(AM) PLC And ATE PC Calibrate Time!")
            PLC_Time = 8
            Log_Name = Dir(Log_Path, FileAttribute.Directory)
            Do While Log_Name <> ""
                If Log_Name <> "." And Log_Name <> ".." Then
                    If (GetAttr(Log_Path & Log_Name) And FileAttribute.Directory) <> FileAttribute.Directory Then
                        TmpDate = FileDateTime(Log_Path & Log_Name)
                        If TmpDate < System.DateTime.FromOADate(Today.ToOADate - 7) Then Kill(Log_Path & Log_Name)
                    End If
                End If
                Log_Name = Dir()
            Loop
        End If

        If PLC_Time <> 20 And Hour(Now) = 20 Then
            If Timer_Send_Buffer.Enabled = False Then Timer_Send_Buffer.Enabled = True
            Call All_Log_Add("(PM) PLC And ATE PC Calibrate Time!")
            PLC_Time = 20
        End If
        If Hour(Now) <> 8 And Hour(Now) <> 20 Then PLC_Time = 0
        Send_File = ""
        MyName = Dir(ATE_Wpath, FileAttribute.Directory)
        Do While MyName <> ""
            If MyName <> "." And MyName <> ".." Then
                If (GetAttr(ATE_Wpath & MyName) And FileAttribute.Directory) <> FileAttribute.Directory Then
                    Dim Finformation As System.IO.FileInfo
                    Finformation = My.Computer.FileSystem.GetFileInfo(ATE_Wpath & MyName)
                    If Finformation.Length >= 3 Then
                        Send_File = MyName
                        Exit Do
                    End If
                End If
            End If
            MyName = Dir()
        Loop
        If Send_File <> "" Then
            Del_F = Send_File
            Timer_DEL_F.Enabled = True
            Timer_DEL_F.Interval = 100
            TmpStr = ""
            FileOpen(1, ATE_Wpath & Send_File, OpenMode.Input)
            If Not EOF(1) Then TmpStr = LineInput(1)
            FileClose(1)
        End If
        Select Case Send_File
            Case "+(02)$AOK+(03)"
                ATE_AST.BackColor = Color.Green
                Test_StT(1) = Now
                AST_Lab.Text = "Test OK"
                If AxActProgType1.SetDevice("D201", 13) <> 0 Then
                    PLC_ReSet(PLC_ReN, 0) = "D201"
                    PLC_ReSet(PLC_ReN, 1) = 13
                    PLC_ReSet(PLC_ReN, 2) = "w"
                    PLC_ReSet(PLC_ReN, 3) = "0"
                    PLC_ReN = PLC_ReN + 1
                End If
                Call All_Log_Add("A Test PASS=" & TmpStr)
            Case "+(02)$BOK+(03)"
                ATE_BSt.BackColor = Color.Green
                Test_StT(2) = Now
                BST_Lab.Text = "Test OK"
                If AxActProgType1.SetDevice("D202", 13) <> 0 Then
                    PLC_ReSet(PLC_ReN, 0) = "D202"
                    PLC_ReSet(PLC_ReN, 1) = 13
                    PLC_ReSet(PLC_ReN, 2) = "w"
                    PLC_ReSet(PLC_ReN, 3) = "0"
                    PLC_ReN = PLC_ReN + 1
                End If
                Call All_Log_Add("B Test PASS=" & TmpStr)
            Case "+(02)$COK+(03)"
                ATE_CSt.BackColor = Color.Green
                Test_StT(3) = Now
                CST_Lab.Text = "Test OK"
                If AxActProgType1.SetDevice("D203", 13) <> 0 Then
                    PLC_ReSet(PLC_ReN, 0) = "D203"
                    PLC_ReSet(PLC_ReN, 1) = 13
                    PLC_ReSet(PLC_ReN, 2) = "w"
                    PLC_ReSet(PLC_ReN, 3) = "0"
                    PLC_ReN = PLC_ReN + 1
                End If
                Call All_Log_Add("C Test PASS=" & TmpStr)
            Case "+(02)$DOK+(03)"
                ATE_DSt.BackColor = Color.Green
                Test_StT(4) = Now
                DST_Lab.Text = "Test OK"
                If AxActProgType1.SetDevice("D204", 13) <> 0 Then
                    PLC_ReSet(PLC_ReN, 0) = "D204"
                    PLC_ReSet(PLC_ReN, 1) = 13
                    PLC_ReSet(PLC_ReN, 2) = "w"
                    PLC_ReSet(PLC_ReN, 3) = "0"
                    PLC_ReN = PLC_ReN + 1
                End If
                Call All_Log_Add("D Test PASS=" & TmpStr)
            Case "+(02)$ANG+(03)"
                ATE_AST.BackColor = Color.Red
                Test_StT(1) = Now
                AST_Lab.Text = "Test Fail"
                If AxActProgType1.SetDevice("D201", 14) <> 0 Then
                    PLC_ReSet(PLC_ReN, 0) = "D201"
                    PLC_ReSet(PLC_ReN, 1) = 14
                    PLC_ReSet(PLC_ReN, 2) = "w"
                    PLC_ReSet(PLC_ReN, 3) = "0"
                    PLC_ReN = PLC_ReN + 1
                End If
                Call All_Log_Add("A Test FAIL=" & TmpStr)
            Case "+(02)$BNG+(03)"
                ATE_BSt.BackColor = Color.Red
                Test_StT(2) = Now
                BST_Lab.Text = "Test Fail"
                If AxActProgType1.SetDevice("D202", 14) <> 0 Then
                    PLC_ReSet(PLC_ReN, 0) = "D202"
                    PLC_ReSet(PLC_ReN, 1) = 14
                    PLC_ReSet(PLC_ReN, 2) = "w"
                    PLC_ReSet(PLC_ReN, 3) = "0"
                    PLC_ReN = PLC_ReN + 1
                End If
                Call All_Log_Add("B Test FAIL=" & TmpStr)
            Case "+(02)$CNG+(03)"
                ATE_CSt.BackColor = Color.Red
                Test_StT(3) = Now
                CST_Lab.Text = "Test Fail"
                If AxActProgType1.SetDevice("D203", 14) <> 0 Then
                    PLC_ReSet(PLC_ReN, 0) = "D203"
                    PLC_ReSet(PLC_ReN, 1) = 14
                    PLC_ReSet(PLC_ReN, 2) = "w"
                    PLC_ReSet(PLC_ReN, 3) = "0"
                    PLC_ReN = PLC_ReN + 1
                End If
                Call All_Log_Add("C Test FAIL=" & TmpStr)

            Case "+(02)$DNG+(03)"
                ATE_DSt.BackColor = Color.Red
                Test_StT(4) = Now
                DST_Lab.Text = "Test Fail"
                If AxActProgType1.SetDevice("D204", 14) <> 0 Then
                    PLC_ReSet(PLC_ReN, 0) = "D204"
                    PLC_ReSet(PLC_ReN, 1) = 14
                    PLC_ReSet(PLC_ReN, 2) = "w"
                    PLC_ReSet(PLC_ReN, 3) = "0"
                    PLC_ReN = PLC_ReN + 1
                End If
                Call All_Log_Add("D Test FAIL=" & TmpStr)

            Case "+(02)$AUK+(03)"
                If AxActProgType1.SetDevice("D210", 0) <> 0 Then
                    PLC_ReSet(PLC_ReN, 0) = "D210"
                    PLC_ReSet(PLC_ReN, 1) = 0
                    PLC_ReSet(PLC_ReN, 2) = "w"
                    PLC_ReSet(PLC_ReN, 3) = "0"
                    PLC_ReN = PLC_ReN + 1
                End If
                Call All_Log_Add("A Unlock")

            Case "+(02)$BUK+(03)"
                If AxActProgType1.SetDevice("D210", 0) <> 0 Then
                    PLC_ReSet(PLC_ReN, 0) = "D210"
                    PLC_ReSet(PLC_ReN, 1) = 0
                    PLC_ReSet(PLC_ReN, 2) = "w"
                    PLC_ReSet(PLC_ReN, 3) = "0"
                    PLC_ReN = PLC_ReN + 1
                End If
                Call All_Log_Add("B Unlock")

            Case "+(02)$CUK+(03)"
                If AxActProgType1.SetDevice("D211", 0) <> 0 Then
                    PLC_ReSet(PLC_ReN, 0) = "D211"
                    PLC_ReSet(PLC_ReN, 1) = 0
                    PLC_ReSet(PLC_ReN, 2) = "w"
                    PLC_ReSet(PLC_ReN, 3) = "0"
                    PLC_ReN = PLC_ReN + 1
                End If
                Call All_Log_Add("C Unlock")

            Case "+(02)$DUK+(03)"
                If AxActProgType1.SetDevice("D211", 0) <> 0 Then
                    PLC_ReSet(PLC_ReN, 0) = "D211"
                    PLC_ReSet(PLC_ReN, 1) = 0
                    PLC_ReSet(PLC_ReN, 2) = "w"
                    PLC_ReSet(PLC_ReN, 3) = "0"
                    PLC_ReN = PLC_ReN + 1
                End If
                Call All_Log_Add("D Unlock")

            Case "+(02)$ALK+(03)"
                If AxActProgType1.SetDevice("D210", 90) <> 0 Then
                    PLC_ReSet(PLC_ReN, 0) = "D210"
                    PLC_ReSet(PLC_ReN, 1) = 90
                    PLC_ReSet(PLC_ReN, 2) = "w"
                    PLC_ReSet(PLC_ReN, 3) = "0"
                    PLC_ReN = PLC_ReN + 1
                End If
                Call All_Log_Add("A Lock")

            Case "+(02)$BLK+(03)"
                If AxActProgType1.SetDevice("D210", 90) <> 0 Then
                    PLC_ReSet(PLC_ReN, 0) = "D210"
                    PLC_ReSet(PLC_ReN, 1) = 90
                    PLC_ReSet(PLC_ReN, 2) = "w"
                    PLC_ReSet(PLC_ReN, 3) = "0"
                    PLC_ReN = PLC_ReN + 1
                End If
                Call All_Log_Add("B Lock")

            Case "+(02)$CLK+(03)"
                If AxActProgType1.SetDevice("D211", 90) <> 0 Then
                    PLC_ReSet(PLC_ReN, 0) = "D211"
                    PLC_ReSet(PLC_ReN, 1) = 90
                    PLC_ReSet(PLC_ReN, 2) = "w"
                    PLC_ReSet(PLC_ReN, 3) = "0"
                    PLC_ReN = PLC_ReN + 1
                End If
                Call All_Log_Add("C Lock")

            Case "+(02)$DLK+(03)"
                If AxActProgType1.SetDevice("D211", 90) <> 0 Then
                    PLC_ReSet(PLC_ReN, 0) = "D211"
                    PLC_ReSet(PLC_ReN, 1) = 90
                    PLC_ReSet(PLC_ReN, 2) = "w"
                    PLC_ReSet(PLC_ReN, 3) = "0"
                    PLC_ReN = PLC_ReN + 1
                End If
                Call All_Log_Add("D Lock")

            Case ""
                Exit Sub
            Case Else
                Call All_Log_Add("ATE Error Signal=" & Send_File)
                Exit Sub
        End Select

        If Err.Number <> 0 Then Call Error_Process("Timer_ATE_F_Tick" & ErrorToString())
    End Sub
    Private Sub Timer_SN_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_SN.Tick
        Dim SnBuf As String
        Dim MkA(4) As Boolean
        On Error Resume Next

        If C_Thd.ThreadState = ThreadState.Running Then
            C_Thd.Abort()
        End If

        If Thd_Sn1 <> "" And Thd_St1 = "" Then
            Call All_Log_Add("Check Route Time Out!")
        End If

        Sn_Timer_Tn = 0
        Thd_St1 = ""
        Thd_St2 = ""
        Thd_St3 = ""
        Thd_St4 = ""
        Sn_Ready = 2
        Thd_ChkRt_Run = False
        Timer_SN.Enabled = False
        Exit Sub

        Sn_Timer_Tn = Sn_Timer_Tn + 1



        If Thd_ChkRt_Run = False Then Exit Sub

        SnBuf = ""
        If Thd_Sn1 <> "" Then SnBuf = Thd_Sn1
        If Thd_Sn2 <> "" Then SnBuf = SnBuf & "|" & Thd_Sn2
        If Thd_Sn3 <> "" Then SnBuf = SnBuf & "|" & Thd_Sn3
        If Thd_Sn4 <> "" Then SnBuf = SnBuf & "|" & Thd_Sn4

        MkA(1) = True
        MkA(2) = True
        MkA(3) = True
        MkA(4) = True


        If Thd_Sn1 <> "" And (Thd_St1 = SFCS_TA Or Thd_St1 = SFCS_Tup) Then
            MkA(1) = True
        ElseIf Thd_Sn1 <> "" Then
            MkA(1) = False
            Call All_Log_Add("Check Route NG:" & Thd_Sn1)
            Call All_Log_Add(Thd_St1)
        End If

        If Thd_Sn2 <> "" And (Thd_St2 = SFCS_TA Or Thd_St2 = SFCS_Tup) Then
            MkA(2) = True
        ElseIf Thd_Sn2 <> "" Then
            MkA(2) = False
            Call All_Log_Add("Check Route NG:" & Thd_Sn2)
            Call All_Log_Add(Thd_St2)
        End If

        If Thd_Sn3 <> "" And (Thd_St3 = SFCS_TA Or Thd_St3 = SFCS_Tup) Then
            MkA(3) = True
        ElseIf Thd_Sn3 <> "" Then
            MkA(3) = False
            Call All_Log_Add("Check Route NG:" & Thd_Sn3)
            Call All_Log_Add(Thd_St3)
        End If

        If Thd_Sn4 <> "" And (Thd_St4 = SFCS_TA Or Thd_St4 = SFCS_Tup) Then
            MkA(4) = True
        ElseIf Thd_Sn4 <> "" Then
            MkA(4) = False
            Call All_Log_Add("Check Route NG:" & Thd_Sn4)
            Call All_Log_Add(Thd_St4)
        End If

        If MkA(1) = False Or MkA(2) = False Or MkA(3) = False Or MkA(4) = False Then
            Sn_Ready = 2
        Else
            Sn_Ready = 1

            FileOpen(1, Log_Path & Now.Year & "-" & Now.Month & "-" & Now.Day & "-Scanner List.log", OpenMode.Append)
            PrintLine(1, Now & "-" & SnBuf)
            FileClose(1)
        End If

        Sn_Timer_Tn = 0
        Thd_St1 = ""
        Thd_St2 = ""
        Thd_St3 = ""
        Thd_St4 = ""
        Thd_ChkRt_Run = False
        Timer_SN.Enabled = False

        If Err.Number <> 0 Then Call Error_Process("Timer_SN_Tick:" & ErrorToString()) 'if on error add show list and clear error
    End Sub

    Private Sub All_Log_Add(ByVal StrData As String)
        On Error GoTo On_Err

        If StrData <> "" And StrData <> "@@" Then
            Show_Lst.Items.Add(TimeString & "--" & StrData)
            Show_Lst.SelectedIndex = Show_Lst.Items.Count - 1
        End If

        If DayLog_Save <> Now.Day Then
            DayLog_Save = Now.Day
            StrData = "@@"
        End If

        If Show_Lst.Items.Count > 999 Or StrData = "@@" Then
            Dim I As Integer
            FileOpen(1, Log_Path & Now.Year & "-" & Now.Month & "-" & Now.Day & "-Information.log", OpenMode.Append)
            For I = 0 To Show_Lst.Items.Count - 1
                PrintLine(1, Show_Lst.Items(I))
            Next
            FileClose(1)
            Show_Lst.Items.Clear()
        End If

On_Err:
        If Err.Number <> 0 Then Call Error_Process("All_Log_Add" & Err.Number)

    End Sub

    Private Sub Error_Process(ByVal StrErr As String)
        On Error GoTo On_Err

        Err_Count_La.Text = Val(Err_Count_La.Text) + 1

        If StrErr <> "" Then
            Show_Lst.Items.Add(TimeString & "--" & "On_Error:" & StrErr)
            Show_Lst.SelectedIndex = Show_Lst.Items.Count - 1
            Err.Clear()
        End If
On_Err:
    End Sub

    Private Sub PLC_Connect(ByRef Return_N As Integer)
        On Error Resume Next
        AxActProgType1.ActCpuType = 520
        AxActProgType1.ActHostAddress = PLC_IPadd
        AxActProgType1.ActCpuTimeOut = 10000
        AxActProgType1.ActSourceStationNumber = 5556
        AxActProgType1.ActUnitType = 74
        AxActProgType1.ActProtocolType = 5
        Return_N = AxActProgType1.Open()

        If Err.Number <> 0 Then Call Error_Process("PLC_Connect" & ErrorToString())
    End Sub

    Private Sub PLC_Disconnect(ByRef Return_N As Integer)
        On Error Resume Next

        Return_N = AxActProgType1.Close()
        If Err.Number <> 0 Then Call Error_Process("PLC_Disconnect" & ErrorToString())
    End Sub

    Private Sub SetLk_Chk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetLk_Chk.CheckedChanged
        On Error Resume Next

        If SetLk_Chk.Checked = True Then
            PLC_IP_Lab.Enabled = False
            PLC_IPTxt.Enabled = False
            SN_ChkRoute.Enabled = False
            Multi_SN_Chk.Enabled = False
            Customer_Cmb.Enabled = False
            Customer_Lab.Enabled = False
        Else
            PLC_IP_Lab.Enabled = True
            PLC_IPTxt.Enabled = True
            SN_ChkRoute.Enabled = True
            Customer_Cmb.Enabled = True
            Customer_Lab.Enabled = True
            If SN_ChkRoute.Checked Then Multi_SN_Chk.Enabled = True
        End If

        If Err.Number <> 0 Then Call Error_Process("SetLk_Chk_CheckedChanged" & ErrorToString())
    End Sub

    Private Sub Tool_LogGrpB_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tool_LogGrpB.DoubleClick
        On Error Resume Next
        Call All_Log_Add("@@")
        Show_Lst.Items.Clear()
        If Err.Number <> 0 Then Call Error_Process("Save_Clear_Log_B_Click" & ErrorToString())
    End Sub

    Private Sub Astation_B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Astation_B.Click
        If Astation_B.BackColor = Color.Gray Then
            If AxActProgType1.SetDevice("M1021", 1) = 0 Then
                Call All_Log_Add("Set A Station ON OK")
            Else
                Call All_Log_Add("Set A Station Error!")
            End If
        Else
            If AxActProgType1.SetDevice("M1021", 0) = 0 Then
                Call All_Log_Add("Set A Station OFF OK")
            Else
                Call All_Log_Add("Set A Station Error!")
            End If
        End If
    End Sub

    Private Sub Bstation_B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bstation_B.Click
        If Bstation_B.BackColor = Color.Gray Then
            If AxActProgType1.SetDevice("M1026", 1) = 0 Then
                Call All_Log_Add("Set B Station ON OK")
            Else
                Call All_Log_Add("Set B Station Error!")
            End If
        Else
            If AxActProgType1.SetDevice("M1026", 0) = 0 Then
                Call All_Log_Add("Set B Station OFF OK")
            Else
                Call All_Log_Add("Set B Station Error!")
            End If
        End If
    End Sub

    Private Sub Cstation_B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cstation_B.Click
        If Cstation_B.BackColor = Color.Gray Then
            If AxActProgType1.SetDevice("M1031", 1) = 0 Then
                Call All_Log_Add("Set C Station ON OK")
            Else
                Call All_Log_Add("Set C Station Error!")
            End If
        Else
            If AxActProgType1.SetDevice("M1031", 0) = 0 Then
                Call All_Log_Add("Set C Station OFF OK")
            Else
                Call All_Log_Add("Set C Station Error!")
            End If
        End If
    End Sub

    Private Sub Dstation_B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dstation_B.Click
        If Dstation_B.BackColor = Color.Gray Then
            If AxActProgType1.SetDevice("M1036", 1) = 0 Then
                Call All_Log_Add("Set D Station ON OK")
            Else
                Call All_Log_Add("Set D Station Error!")
            End If
        Else
            If AxActProgType1.SetDevice("M1036", 0) = 0 Then
                Call All_Log_Add("Set D Station OFF OK")
            Else
                Call All_Log_Add("Set D Station Error!")
            End If
        End If
    End Sub

    Private Sub Manual_Mode_B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Manual_Test_B.Click
        If Manual_Test_B.BackColor = Color.WhiteSmoke Then
            If AxActProgType1.SetDevice("M1008", 1) = 0 Then
                Call All_Log_Add("Set Manual Mode ON OK")
            Else
                Call All_Log_Add("Set Manual Mode Error!")
            End If
        Else
            If AxActProgType1.SetDevice("M1008", 0) = 0 Then
                Call All_Log_Add("Set Manual Mode OFF OK")
            Else
                Call All_Log_Add("Set Manual Mode Error!")
            End If
        End If
    End Sub

    Private Sub Alarm_Reset_B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Alarm_Reset_B.Click
        If AxActProgType1.SetDevice("M1010", 1) = 0 Then
            Call All_Log_Add("Set Alarm Reset OK")
        Else
            Call All_Log_Add("Set Alarm Reset Error!")
        End If
        AxActProgType1.SetDevice("M1010", 0)
    End Sub

    Private Sub Buzzer_Off_B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buzzer_Off_B.Click
        If Buzzer_Off_B.BackColor = Color.WhiteSmoke Then
            If AxActProgType1.SetDevice("M1011", 1) = 0 Then
                Call All_Log_Add("Set Manual Mode ON OK")
            Else
                Call All_Log_Add("Set Manual Mode Error!")
            End If
        Else
            If AxActProgType1.SetDevice("M1011", 0) = 0 Then
                Call All_Log_Add("Set Manual Mode OFF OK")
            Else
                Call All_Log_Add("Set Manual Mode Error!")
            End If
        End If
    End Sub

    Private Sub Robot_Start_B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PLC_Start_B.Click
        If PLC_Start_B.BackColor = Color.WhiteSmoke Then
            If AxActProgType1.SetDevice("M1000", 1) = 0 Then
                Call All_Log_Add("Set Robot Start OK")
            Else
                Call All_Log_Add("Set Robot Start Error!")
            End If
        End If
        AxActProgType1.SetDevice("M1000", 0)
    End Sub

    Private Sub PLC_Model_B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PLC_Model_B.Click
        If PLC_Start_B.BackColor = Color.LawnGreen Then
            Call All_Log_Add("Error! Automatic mode can be set!")
            Exit Sub
        End If
        If PLC_Model_B.BackColor = Color.RoyalBlue Then
            If AxActProgType1.SetDevice("M1001", 1) = 0 Then
                Call All_Log_Add("Set Robot Model OK")
            Else
                Call All_Log_Add("Set Robot Model Error!")
            End If
        Else
            If AxActProgType1.SetDevice("M1001", 0) = 0 Then
                Call All_Log_Add("Set Robot Model OK")
            Else
                Call All_Log_Add("Set Robot Model Error!")
            End If
        End If
    End Sub
    Private Sub PLC_Stop_B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PLC_Stop_B.Click
        If AxActProgType1.SetDevice("M1002", 1) = 0 Then
            Call All_Log_Add("Set Robot Stop OK")
        Else
            Call All_Log_Add("Set Robot Stop Error!")
        End If
        AxActProgType1.SetDevice("M1002", 0)
    End Sub
    Private Sub PLC_Pause_B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PLC_Pause_B.Click
        If AxActProgType1.SetDevice("M1004", 1) = 0 Then
            Call All_Log_Add("Set Robot Pause OK")
        Else
            Call All_Log_Add("Set Robot Pause Error!")
        End If
        AxActProgType1.SetDevice("M1004", 0)
    End Sub

    Private Sub PLC_Origin_B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PLC_Origin_B.Click
        If AxActProgType1.SetDevice("M1003", 1) = 0 Then
            Call All_Log_Add("Set Robot Origin OK")
        Else
            Call All_Log_Add("Set Robot Origin Error!")
        End If
        AxActProgType1.SetDevice("M1003", 0)
    End Sub
    Private Sub PLC_ReMate_B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PLC_ReMate_B.Click
        If PLC_ReMate_B.BackColor = Color.WhiteSmoke Then
            Dim RsT(9) As Integer

            RsT(0) = AxActProgType1.SetDevice("M1020", 1)
            RsT(1) = AxActProgType1.SetDevice("M1025", 1)
            RsT(2) = AxActProgType1.SetDevice("M1030", 1)
            RsT(3) = AxActProgType1.SetDevice("M1035", 1)
            RsT(4) = AxActProgType1.SetDevice("M1040", 1)

            If RsT(0) + RsT(1) + RsT(2) + RsT(3) + RsT(4) = 0 Then
                Call All_Log_Add("Set Robot ReMate OK")
            Else
                Call All_Log_Add("Set Robot ReMate Error!")
            End If
            RsT(0) = AxActProgType1.SetDevice("M1020", 0)
            RsT(1) = AxActProgType1.SetDevice("M1025", 0)
            RsT(2) = AxActProgType1.SetDevice("M1030", 0)
            RsT(3) = AxActProgType1.SetDevice("M1035", 0)
            RsT(4) = AxActProgType1.SetDevice("M1040", 0)

        End If
    End Sub

    Private Sub Aslzz_Open_B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aslzz_Open_B.Click
        If AxActProgType1.SetDevice("M1073", 1) = 0 Then
            Call All_Log_Add("Set A Save Labour Open OK")
        Else
            Call All_Log_Add("Set A Save Labour Open Error!")
        End If
        AxActProgType1.SetDevice("M1073", 0)
    End Sub

    Private Sub Aslzz_Close_B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aslzz_Close_B.Click
        If AxActProgType1.SetDevice("M1072", 1) = 0 Then
            Call All_Log_Add("Set A Save Labour Close OK")
        Else
            Call All_Log_Add("Set A Save Labour Close Error!")
        End If
        AxActProgType1.SetDevice("M1072", 0)
    End Sub

    Private Sub Bslzz_Open_B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bslzz_Open_B.Click
        If AxActProgType1.SetDevice("M1083", 1) = 0 Then
            Call All_Log_Add("Set B Save Labour Open OK")
        Else
            Call All_Log_Add("Set B Save Labour Open Error!")
        End If
        AxActProgType1.SetDevice("M1083", 0)
    End Sub

    Private Sub Bslzz_Close_B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bslzz_Close_B.Click
        If AxActProgType1.SetDevice("M1082", 1) = 0 Then
            Call All_Log_Add("Set B Save Labour Close OK")
        Else
            Call All_Log_Add("Set B Save Labour Close Error!")
        End If
        AxActProgType1.SetDevice("M1082", 0)
    End Sub

    Private Sub Cslzz_Open_B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cslzz_Open_B.Click
        If AxActProgType1.SetDevice("M1093", 1) = 0 Then
            Call All_Log_Add("Set C Save Labour Open OK")
        Else
            Call All_Log_Add("Set C Save Labour Open Error!")
        End If
        AxActProgType1.SetDevice("M1093", 0)
    End Sub

    Private Sub Cslzz_Close_B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cslzz_Close_B.Click
        If AxActProgType1.SetDevice("M1092", 1) = 0 Then
            Call All_Log_Add("Set C Save Labour Close OK")
        Else
            Call All_Log_Add("Set C Save Labour Close Error!")
        End If
        AxActProgType1.SetDevice("M1092", 0)
    End Sub

    Private Sub Dslzz_Open_B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dslzz_Open_B.Click
        If AxActProgType1.SetDevice("M1103", 1) = 0 Then
            Call All_Log_Add("Set D Save Labour Open OK")
        Else
            Call All_Log_Add("Set D Save Labour Open Error!")
        End If
        AxActProgType1.SetDevice("M1103", 0)
    End Sub

    Private Sub Dslzz_Close_B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dslzz_Close_B.Click
        If AxActProgType1.SetDevice("M1102", 1) = 0 Then
            Call All_Log_Add("Set D Save Labour Close OK")
        Else
            Call All_Log_Add("Set D Save Labour Close Error!")
        End If
        AxActProgType1.SetDevice("M1102", 0)
    End Sub

    Private Sub Apause_B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Apause_B.Click
        If Apause_B.BackColor = Color.Gray Then
            If AxActProgType1.SetDevice("M1022", 1) = 0 Then
                Call All_Log_Add("Set A Robot Pause OK")
            Else
                Call All_Log_Add("Set A Robot Pause Error!")
            End If
        Else
            If AxActProgType1.SetDevice("M1022", 0) = 0 Then
                Call All_Log_Add("Set A Robot Restart OK")
            Else
                Call All_Log_Add("Set A Robot Pause Error!")
            End If
        End If
    End Sub

    Private Sub Bpause_B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bpause_B.Click
        If Bpause_B.BackColor = Color.Gray Then
            If AxActProgType1.SetDevice("M1027", 1) = 0 Then
                Call All_Log_Add("Set B Robot Pause OK")
            Else
                Call All_Log_Add("Set B Robot Pause Error!")
            End If
        Else
            If AxActProgType1.SetDevice("M1027", 0) = 0 Then
                Call All_Log_Add("Set B Robot Restart OK")
            Else
                Call All_Log_Add("Set B Robot Pause Error!")
            End If
        End If
    End Sub

    Private Sub Cpause_B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cpause_B.Click
        If Cpause_B.BackColor = Color.Gray Then
            If AxActProgType1.SetDevice("M1032", 1) = 0 Then
                Call All_Log_Add("Set C Robot Pause OK")
            Else
                Call All_Log_Add("Set C Robot Pause Error!")
            End If
        Else
            If AxActProgType1.SetDevice("M1032", 0) = 0 Then
                Call All_Log_Add("Set C Robot Pause OK")
            Else
                Call All_Log_Add("Set C Robot Pause Error!")
            End If
        End If
    End Sub

    Private Sub Dpause_B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dpause_B.Click
        If Dpause_B.BackColor = Color.Gray Then
            If AxActProgType1.SetDevice("M1037", 1) = 0 Then
                Call All_Log_Add("Set D Robot Pause OK")
            Else
                Call All_Log_Add("Set D Robot Pause Error!")
            End If
        Else
            If AxActProgType1.SetDevice("M1037", 0) = 0 Then
                Call All_Log_Add("Set D Robot Restart OK")
            Else
                Call All_Log_Add("Set D Robot Pause Error!")
            End If
        End If
    End Sub

    Private Sub Timer_Send_Buffer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Send_Buffer.Tick
        Dim StrR As String
        Dim I As Short
        Dim N As Short
        On Error Resume Next
        If Buff_TCPLst.Items.Count = 0 Then Exit Sub

        If T_Thd.IsAlive = True Then
            If TCP_WaitN >= 6 Then
                T_Thd.Abort()
                TCP_WaitN = 0
            Else
                TCP_WaitN = TCP_WaitN + 1
            End If
        End If

        StrR = Buff_TCPLst.Items(0)
        Buff_TCPLst.Items.RemoveAt(0)

        SktData = ""
        SktIP = ""
        SktPort = ""
        SktSst = ""
        I = InStr(StrR, "■")
        N = InStr(I + 1, StrR, "■")
        If I <> 0 And N <> 0 Then
            SktData = Mid(StrR, 1, I - 1)
            SktIP = Mid(StrR, I + 1, N - I - 1)
            SktPort = Mid(StrR, N + 1)
        End If
        If SktData = "" Or SktIP = "" Or SktPort = "" Then Exit Sub

        T_Thd = New Thread(AddressOf TCP_Send_Data)
        T_Thd.Start()
        If Buff_TCPLst.Items.Count = 0 Then
            Timer_Send_Buffer.Enabled = False
        End If

        If Err.Number <> 0 Then Err.Clear()
    End Sub

    Private Sub SN_Clear_B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SN_Clear_B.Click
        Dim Tsn_0(100) As Integer
        On Error Resume Next

        If AxActProgType1.WriteDeviceBlock("D1000", 100, Tsn_0(100)) <> 0 Then
            Call All_Log_Add("Clear PLC SN Buffer Error!")
        Else
            Call All_Log_Add("Clear PLC SN Buffer OK")
        End If

        If Err.Number <> 0 Then Call Error_Process("SN_Clear_B_Click" & ErrorToString())
    End Sub

    Private Sub SN_ChkRoute_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SN_ChkRoute.CheckedChanged
        If SetLk_Chk.Checked Then Exit Sub

        If SN_ChkRoute.Checked Then
            Multi_SN_Chk.Enabled = True
        Else
            Multi_SN_Chk.Checked = False
            Multi_SN_Chk.Enabled = False
        End If

    End Sub

    Private Sub Lock_Control_B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lock_Control_B.Click
        Lock_Control_Form.Show()
    End Sub

End Class