Imports System
Imports System.IO
Imports System.Net
Imports System.Threading
Imports System.Net.Sockets

Public Class Client_Form


    Dim Del_F As String
    Dim Clr_NoteDay As Short
    Const SPath As String = "Client_Set_File"
    Const Wri_path As String = "C:\Robot_WR\"
    Const RP As String = "C:\Robot_RD\"
    Const LP As String = "C:\Robot_LOG\"
    Dim ErrN As Short = 0
    Dim WaitN As Short = 0
    Dim LIp As String = String.Empty
    Dim ATE_SI As String = String.Empty
    Dim SktD As String = String.Empty
    Dim SktI As String = String.Empty
    Dim SktP As String = String.Empty
    Dim SktSst As String = String.Empty
    Const ATE_LP As Short = 5101
    Dim ATE_LA As String
    Dim ATE_LS As Boolean = False
    Dim ATE_LW As Integer
    Dim ATE_LSN As Integer
    Dim LFN As Integer
    Dim LCN As Integer
    Dim DLSave As Integer

    Delegate Sub Dg(ByVal ValueRult As String, ByVal obj As TextBox)
    Delegate Sub Dg_Lst(ByVal ValueRult As String)

    Dim TcpLten As TcpListener
    Dim LtnRec_Thd As Thread
    Dim TcpSend_Thd As Thread
    Dim Client_IP As String




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


            Client_IP = MyTcpClient.Client.RemoteEndPoint.ToString

            Me.Invoke(New Dg_Lst(AddressOf Recevice_Data_Line), MyMessage)
        End While
    End Sub



    Public Sub TCP_Closed()
        On Error Resume Next


        If TcpLten IsNot Nothing Then
            TcpLten.Stop()
        End If

        If LtnRec_Thd IsNot Nothing Then

            LtnRec_Thd.Abort()  
        End If
    

        If Err.Number <> 0 Then Err.Clear()
    End Sub



    Public Sub TCP_Send_Data()
        If SktD = "" Or SktI = "" Or SktP = "" Then Exit Sub
        LFN = LFN + 1
        Try
            Dim MyTcpClient As TcpClient = New TcpClient(SktI, SktP)
            Dim MyTcpStream As Net.Sockets.NetworkStream = MyTcpClient.GetStream()

            Dim MyStream As IO.StreamWriter = New IO.StreamWriter(MyTcpStream, System.Text.UnicodeEncoding.GetEncoding("gb2312"))
            MyStream.Write(SktD)
            MyStream.Flush()
            MyStream.Close()
            LFN = 0
        Catch ex As Exception
            SktSst = "Send Error"
        End Try
    End Sub



    Private Sub Recevice_Data_Line(ByVal StrD As String)
        On Error Resume Next
        Dim TmpSn As String
        Dim TmpVRAM As String

        Dim N As Short
        Dim I As Short
        Dim MkA As Boolean
        Dim RAM_En As Boolean = False

   
        If Mid(StrD, 1, 2) = "A=" Or Mid(StrD, 1, 2) = "B=" Or Mid(StrD, 1, 2) = "C=" Or Mid(StrD, 1, 2) = "D=" Then
            Call Add_toShowLst(StrD)

            TmpVRAM = ""
            I = InStr(StrD, "=VRAM=")
            If I > 0 Then
                RAM_En = True
                TmpVRAM = Mid(StrD, I + 1)
                StrD = Mid(StrD, 1, I - 1)
            End If
            TmpSn = Mid(StrD, 3)

            For I = 1 To 4
                N = InStr(TmpSn, "=&=")
                If N > 0 Then
                    TmpSn = Mid(TmpSn, 1, N - 1) & Mid(TmpSn, N + 3, TmpSn.Length - N - 2)
                Else
                    Exit For
                End If
            Next

            If TmpSn = "" Then
                Call Add_toShowLst(Mid(StrD, 1, 2) & "=Error SN Empty!")
                Exit Sub
            End If

            FileOpen(1, RP & "Bar_" & Mid(StrD, 1, 1), OpenMode.Output)
            PrintLine(1, TmpSn)
            If RAM_En <> "" Then
                PrintLine(1, TmpVRAM)
            End If
            FileClose(1)
            Exit Sub
        End If

        MkA = False
        Select Case StrD
            Case "AST"
                Call Add_toShowLst("A Start Test")
                MkA = True
            Case "BST"
                Call Add_toShowLst("B Start Test")
                MkA = True
            Case "CST"
                Call Add_toShowLst("C Start Test")
                MkA = True
            Case "DST"
                Call Add_toShowLst("D Start Test")
                MkA = True
            Case "AB_Link_OK"
                ATE_LS = True
                ATE_LW = 0
                ATE_LSN = 0
                Status_Lab2.Text = "Connect OK"
                ConState_Txt.Text = "Connect OK"
                ConState_Txt.ForeColor = Color.LawnGreen
                Call Add_toShowLst("Main CD machine connection is OK.")
                Exit Sub
            Case "Re_Link"
                ATE_LS = False
                ATE_LSN = 0
                Status_Lab2.Text = "Connecting..."
                ConState_Txt.Text = "Connecting..."
                ConState_Txt.ForeColor = Color.Yellow
                Buff_Lst.Items.Add("AB_Link_Request" & ATE_LA)
                If Timer_Send_Buffer.Enabled = False Then Timer_Send_Buffer.Enabled = True
                Exit Sub
            Case Else
                Call Add_toShowLst("Error Data:" & StrD)
                Exit Sub
        End Select

        If MkA = True Then
            FileOpen(1, RP & "+(2)$" & StrD & "+(13)(10)", OpenMode.Output)
            PrintLine(1, "AAAAA")
            FileClose(1)
        End If

        If Err.Number <> 0 Then Call Error_Process("Recevice_Data_Line" & ErrorToString())

    End Sub


    Private Sub Start_B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Start_B.Click
        On Error Resume Next

        ATE_LA = "■" & CD_IP_Txt.Text & "■" & ATE_LP

        CD_IP_Txt.Text = Trim(CD_IP_Txt.Text)
        If CD_IP_Txt.Text = "" Then
            MsgBox("Main CD IP can not be empty!", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If Start_B.Text = "Start" Then
            Buff_Lst.Items.Clear()
            Start_B.Text = "Stop"
            Start_B.ForeColor = Color.Red
            Call Connect_CD()
            LtnRec_Thd = New Thread(AddressOf TCP_StartListen)
            LtnRec_Thd.Start()
        Else
            Start_B.Text = "Start"
            Start_B.ForeColor = Color.Blue
            If ATE_LS = True Then
                Buff_Lst.Items.Add("AB_Link_Close" & ATE_LA)
                If Timer_Send_Buffer.Enabled = False Then Timer_Send_Buffer.Enabled = True
            End If

            ATE_LS = False
            Call DisConnect_CD()
            Call TCP_Closed()
        End If

        If Err.Number <> 0 Then Call Error_Process("Start_B_Click" & ErrorToString())
    End Sub



    Private Sub Connect_CD()
        On Error Resume Next
        Dim StrT As String

        Call Add_toShowLst("Robot Remote Manual Connect! -->" & TimeOfDay)


        StrT = Mid(Wri_path, 1, Wri_path.Length - 1)
        If Dir(StrT, FileAttribute.Directory) = "" Then MkDir(StrT)
        StrT = Mid(RP, 1, RP.Length - 1)
        If Dir(StrT, FileAttribute.Directory) = "" Then MkDir(StrT)
        StrT = Mid(LP, 1, LP.Length - 1)
        If Dir(StrT, FileAttribute.Directory) = "" Then MkDir(StrT)

        IP_Lab.Enabled = False
        CD_IP_Txt.Enabled = False

        Status_Lab2.Text = "Connecting..."
        ConState_Txt.Text = "Connecting..."
        ConState_Txt.ForeColor = Color.Yellow

        TimerR.Enabled = True
        TimerR.Interval = 300

        If Err.Number <> 0 Then Call Error_Process("Connect_CD" & ErrorToString()) 'if on error add show list and clear error

    End Sub



    Private Sub DisConnect_CD()
        On Error Resume Next

        Call TCP_Closed()

        Call Add_toShowLst("Robot Remote Manual Disconnect!")

        ConState_Txt.Text = "No Connect"
        Status_Lab2.Text = "No Connect"
        ConState_Txt.ForeColor = Color.Red
        IP_Lab.Enabled = True
        CD_IP_Txt.Enabled = True
        TimerR.Enabled = False

        If Err.Number <> 0 Then Call Error_Process("DisConnect_CD" & ErrorToString())
    End Sub

    Private Sub Main_AB_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim RdStr As String
        On Error Resume Next

        If Dir(Mid(LP, 1, LP.Length - 1), FileAttribute.Directory) = "" Then MkDir(Mid(LP, 1, LP.Length - 1))

        LtnRec_Thd = New Thread(AddressOf TCP_StartListen)
        TcpSend_Thd = New Thread(AddressOf TCP_Send_Data)

        DLSave = Now.Day
        Call Add_toShowLst("Robot Remote Start!")

        If My.Computer.FileSystem.FileExists(SPath) = True Then
            FileOpen(1, SPath, OpenMode.Input)
            Do While Not EOF(1)
                RdStr = LineInput(1)
                If Mid(RdStr, 1, 5) = "IP = " Then CD_IP_Txt.Text = Mid(RdStr, 6)
            Loop
            FileClose(1)
        End If

        Status_Lab3.Text = Now.ToString

        If Err.Number <> 0 Then Call Error_Process("Main_AB_Form_Load" & ErrorToString())
    End Sub

    Private Sub Main_CD_Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        On Error Resume Next

        If MsgBox("Are you sure you quit?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Question?") = MsgBoxResult.No Then
            e.Cancel = True
        Else
            FileOpen(1, SPath, OpenMode.Output)
            PrintLine(1, "IP = " & CD_IP_Txt.Text)
            FileClose(1)

            Call Add_toShowLst("Robot Remote Manual OFF!")
            Call Save_LogToFile()
            Robot_Tool_Sel.Close()

            Call TCP_Closed()

            LtnRec_Thd.Abort()
            TcpSend_Thd.Abort()
        End If

        If Err.Number <> 0 Then Call Error_Process("Main_CD_Form_FormClosing" & ErrorToString()) 'if on error add show list and clear error
    End Sub

    Private Sub TimerR_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TimerR.Tick
        On Error Resume Next

        If ATE_LS = False Then
            If ATE_LSN >= 100 Then
                Start_B.Text = "Start"
                Start_B.ForeColor = Color.Blue
                ATE_LS = False
                ATE_LSN = 0
                Buff_Lst.Items.Add("AB_Link_Close" & ATE_LA)
                If Timer_Send_Buffer.Enabled = False Then Timer_Send_Buffer.Enabled = True

                Call DisConnect_CD()
                Call TCP_Closed()
                Exit Sub
            End If

            If ATE_LW = 0 Or ATE_LW >= 10 Then
                If My.Computer.Network.Ping(CD_IP_Txt.Text, 800) = True Then
                    If Buff_Lst.FindString("AB_Link_Request" & ATE_LA) = -1 Then
                        Buff_Lst.Items.Add("AB_Link_Request" & ATE_LA)
                        If Timer_Send_Buffer.Enabled = False Then Timer_Send_Buffer.Enabled = True
                    End If

                    If Show_Lst.Items.Count > 1 Then
                        If Mid(Show_Lst.Items(Show_Lst.Items.Count - 1), 1, 15) = "Connect events:" Then
                            Show_Lst.Items.RemoveAt(Show_Lst.Items.Count - 1)
                        End If
                    End If

                    Show_Lst.Items.Add("Connect events:" & CStr(100 - ATE_LSN))
                    Show_Lst.SelectedIndex = Show_Lst.Items.Count - 1

                    ATE_LSN = ATE_LSN + 1
                End If
                ATE_LW = 1
            Else
                ATE_LW = ATE_LW + 1
            End If
        End If

        If ATE_LS = True And LFN >= 2 Then
            Status_Lab2.Text = "Connecting..."
            ConState_Txt.Text = "Connecting..."
            ConState_Txt.ForeColor = Color.Yellow
            ATE_LS = False

            If Buff_Lst.FindString("AB_Link_Request" & ATE_LA) = -1 Then
                Buff_Lst.Items.Add("AB_Link_Request" & ATE_LA)
                If Timer_Send_Buffer.Enabled = False Then Timer_Send_Buffer.Enabled = True
            End If
        End If

        If ATE_LS = True Then
            If LCN >= 10 Then
                Buff_Lst.Items.Add("AB_Link_Chk" & ATE_LA)
                If Timer_Send_Buffer.Enabled = False Then Timer_Send_Buffer.Enabled = True
                LCN = 0
            Else
                LCN = LCN + 1
            End If
        End If

        If Status_Lab3.Text <> Now Then
            Status_Lab3.Text = Now
        End If

        If Show_Lst.Items.Count > 2000 Then
            Call Save_LogToFile()
        End If

        Call Clear_Overdue_File()
        Call Loop_Read_ATE_File()

        If Err.Number <> 0 Then Call Error_Process("TimerR_Tick" & ErrorToString())

    End Sub

    Private Sub TimerDel_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TimerDel.Tick
        On Error Resume Next

        If Del_F <> "" Then
            Kill(Wri_path & Del_F)
            TimerDel.Enabled = False
            Del_F = ""
        End If

        If Err.Number <> 0 Then Call Error_Process("TimerDel_Tick" & ErrorToString())

    End Sub

    Private Sub Loop_Read_ATE_File()
        Dim F_Path As String
        Dim F_Name As String
        Dim StrT As String = String.Empty
        Dim TestSN_Str As String = String.Empty
        Dim RecFile As String
        On Error Resume Next

        RecFile = ""
        F_Path = Wri_path
        F_Name = Dir(F_Path, FileAttribute.Directory)
        Do While F_Name <> ""
            If F_Name <> "." And F_Name <> ".." Then
                If (GetAttr(F_Path & F_Name) And FileAttribute.Directory) <> FileAttribute.Directory Then

                    Dim Finformation As System.IO.FileInfo
                    Finformation = My.Computer.FileSystem.GetFileInfo(F_Path & F_Name)
                    If Finformation.Length >= 3 Then
                        RecFile = F_Name
                        Exit Do
                    End If
                End If
            End If
            F_Name = Dir()
        Loop

        If RecFile <> "" Then
            Del_F = RecFile
            TimerDel.Enabled = True
            TimerDel.Interval = 100

            StrT = ""
            FileOpen(1, F_Path & RecFile, OpenMode.Input)
            If Not EOF(1) Then StrT = LineInput(1)
            FileClose(1)
        End If

        TestSN_Str = ""
        Select Case RecFile
            Case "+(02)$AOK+(03)"
                TestSN_Str = "A Test PASS=" & StrT
                Call Add_toShowLst("A Test PASS=" & StrT)
            Case "+(02)$BOK+(03)"
                TestSN_Str = "B Test PASS=" & StrT
                Call Add_toShowLst("B Test PASS=" & StrT)
            Case "+(02)$COK+(03)"
                TestSN_Str = "C Test PASS=" & StrT
                Call Add_toShowLst("C Test PASS=" & StrT)
            Case "+(02)$DOK+(03)"
                TestSN_Str = "D Test PASS=" & StrT
                Call Add_toShowLst("D Test PASS=" & StrT)

            Case "+(02)$ANG+(03)"
                TestSN_Str = "A Test NG=" & StrT
                Call Add_toShowLst("A Test FAIL=" & StrT)
            Case "+(02)$BNG+(03)"
                TestSN_Str = "B Test NG=" & StrT
                Call Add_toShowLst("B Test FAIL=" & StrT)
            Case "+(02)$CNG+(03)"
                TestSN_Str = "C Test NG=" & StrT
                Call Add_toShowLst("C Test FAIL=" & StrT)
            Case "+(02)$DNG+(03)"
                TestSN_Str = "D Test NG=" & StrT
                Call Add_toShowLst("D Test FAIL=" & StrT)

            Case "+(02)$AUK+(03)"
                Call Add_toShowLst("A ATE Unlock")
            Case "+(02)$BUK+(03)"
                Call Add_toShowLst("B ATE Unlock")
            Case "+(02)$CUK+(03)"
                Call Add_toShowLst("C ATE Unlock")
            Case "+(02)$DUK+(03)"
                Call Add_toShowLst("D ATE Unlock")

            Case "+(02)$ALK+(03)"
                Call Add_toShowLst("A ATE Lock")
            Case "+(02)$BLK+(03)"
                Call Add_toShowLst("B ATE Lock")
            Case "+(02)$CLK+(03)"
                Call Add_toShowLst("C ATE Lock")
            Case "+(02)$DLK+(03)"
                Call Add_toShowLst("D ATE Lock")
            Case ""
                Exit Sub
            Case Else
                Call Add_toShowLst("ATE AB:Error Signal=" & RecFile)
                Exit Sub
        End Select

        If TestSN_Str <> "" Then Buff_Lst.Items.Add(TestSN_Str & ATE_LA)
        Buff_Lst.Items.Add(RecFile & ATE_LA)
        If Timer_Send_Buffer.Enabled = False Then Timer_Send_Buffer.Enabled = True

        If Err.Number <> 0 Then Call Error_Process("Loop_Read_ATE_File" & ErrorToString())
    End Sub

    Private Sub Clear_Overdue_File()
        Dim F_Name As String
        Dim T_FileDate As Date
        On Error Resume Next

        If Clr_NoteDay <> Now.Day And Hour(TimeOfDay) = 8 Then
            Clr_NoteDay = Now.Day

            F_Name = Dir(LP, FileAttribute.Directory)
            Do While F_Name <> ""
                If F_Name <> "." And F_Name <> ".." Then
                    If (GetAttr(LP & F_Name) And FileAttribute.Directory) <> FileAttribute.Directory Then
                        T_FileDate = File.GetLastWriteTime(LP & F_Name)
                        If DateDiff(DateInterval.Day, T_FileDate, Now) > 7 Then Kill(LP & F_Name)
                    End If
                End If
                F_Name = Dir()
            Loop
        End If

        If Err.Number <> 0 Then Call Error_Process("Clear_Overdue_File" & ErrorToString())
    End Sub

    Private Sub Send_Tcp_Buffer()
        Dim StrR As String
        Dim I As Short
        Dim N As Short
        On Error Resume Next

        If Buff_Lst.Items.Count = 0 Then Exit Sub

        If TcpSend_Thd.IsAlive = True Then
            If WaitN >= 6 Then
                TcpSend_Thd.Abort()
                WaitN = 0
                Call Add_toShowLst("Socket Send Error!")
            Else
                WaitN = WaitN + 1
            End If
        End If

        StrR = Buff_Lst.Items(0)
        Buff_Lst.Items.RemoveAt(0)
        SktD = ""
        SktI = ""
        SktP = ""
        SktSst = ""
        I = InStr(StrR, "■")
        N = InStr(I + 1, StrR, "■")
        If I <> 0 And N <> 0 Then
            SktD = Mid(StrR, 1, I - 1)
            SktI = Mid(StrR, I + 1, N - I - 1)
            SktP = Mid(StrR, N + 1)
        End If

        If SktD = "" Or SktI = "" Or SktP = "" Then Exit Sub

        TcpSend_Thd = New Thread(AddressOf TCP_Send_Data)
        TcpSend_Thd.Start()

        If Err.Number <> 0 Then Call Error_Process("Send_Tcp_Buffer" & ErrorToString())
    End Sub

    Private Sub Error_Process(ByVal StrErr As String)
        On Error GoTo On_Err

        If StrErr <> "" Then
            Show_Lst.Items.Add(TimeString & "--" & "On_Error:" & StrErr)
            Show_Lst.SelectedIndex = Show_Lst.Items.Count - 1
            Err.Clear()
        End If

On_Err:
    End Sub

    Private Sub Save_LogToFile()
        On Error GoTo On_Err

        'FileOpen(1, LP0 & Now.Year & "-" & Now.Month & "-" & Now.Day & "-Information.log", OpenMode.Append)
        FileOpen(1, Now.Year & "-" & Now.Month & "-" & Now.Day & "-Information.log", OpenMode.Append)
        For I = 0 To Show_Lst.Items.Count - 1
            PrintLine(1, Show_Lst.Items(I))
        Next I
        FileClose(1)

        Show_Lst.Items.Clear()

On_Err:
    End Sub

    Private Sub Add_toShowLst(ByVal StrRef As String)
        On Error GoTo On_Err

        If StrRef <> "" Then
            Show_Lst.Items.Add(TimeString & "--" & StrRef)
            Show_Lst.SelectedIndex = Show_Lst.Items.Count - 1
        End If

        If DLSave <> Now.Day Then
            DLSave = Now.Day
            Call Save_LogToFile()
        End If

        If Show_Lst.Items.Count > 999 Then
            Call Save_LogToFile()
        End If

On_Err:
    End Sub

    Private Sub Timer_Send_Buffer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Send_Buffer.Tick
        On Error Resume Next

        If Buff_Lst.Items.Count > 0 Then
            Call Send_Tcp_Buffer()
        End If

        If Buff_Lst.Items.Count = 0 Then
            Timer_Send_Buffer.Enabled = False
        End If

        If Err.Number <> 0 Then Call Error_Process("Timer_Send_Buffer_Tick" & ErrorToString()) 'if on error add show list and clear error
    End Sub

    Private Sub Temp_B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Temp_B.Click

        Call Recevice_Data_Line(Temp_Txt.Text)

    End Sub

    Private Sub IP_Lab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IP_Lab.Click
        Call Recevice_Data_Line("B=4550A7010036712004EBKS1E4550A7010036712004ECKS1E")
    End Sub
End Class