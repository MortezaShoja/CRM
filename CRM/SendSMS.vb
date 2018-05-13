Public Class SendSMS
    Private SendSMS As New WebService.Send
    Private Message As Integer = 0
    Private TS As TimeSpleater
    Private Opcode() As Byte
    Private RecCode() As Long
    Private IC As InternetChecker


    Public Sub Send(ByVal ID As String, ByVal MobileNumbers As String, ByVal SenderNummber As String, ByVal MessageText As String, Optional ByVal Mode As String = "Cracked")

        Dim nu() As String = MobileNumbers.Split(",")
        Dim sms As New WebService.Send()
        Dim rec As Long() = Nothing
        Dim status As Byte() = Nothing
        Dim Up As New UpdateClass

        IC = New InternetChecker

        If Not IC.IsConnectionAvailable() = False Then

            Try
                Select Case Mode
                    Case Is = "Cracked"
                        Message = sms.SendSms("c.morteza.shoja", "smsMaster2012", New String() {MobileNumbers}, SenderNummber, MessageText, False, "", rec, status)
                    Case Is = "Normal"
                        Message = sms.SendSms("c.morteza.shoja", "smsMaster2012", nu, SenderNummber, MessageText, False, "", rec, status)
                End Select

                'Message :
                ' InvalidUserPass=0,
                ' Successfull = 1,
                ' NoCredit = 2,
                ' DailyLimit = 3,
                ' SendLimit = 4,
                ' InvalidNumber = 5

                'Status :
                ' Sent=0,
                ' Failed=1
            Catch ex As Exception
                Message = 6
            End Try


            Select Case Message

                Case Is = 0
                    'Me.MessageListBox.Items.Add("نام کاربری یا کلمه عبور اشتباه می باشد" & " -- " & Now.TimeOfDay.ToString)
                    Up.UpdateDatabase(ID, "نام کاربری یا کلمه عبور اشتباه می باشد." & " -- " & Now.TimeOfDay.ToString, 0)
                Case Is = 1
                    'Me.MessageListBox.Items.Add("ارسال پیامک با موفقیت انجام شد" & " -- " & Now.TimeOfDay.ToString)
                    Up.UpdateDatabase(ID, "ارسال پیامک با موفقیت انجام شد." & " -- " & Now.TimeOfDay.ToString, 1)
                Case Is = 2
                    'Me.MessageListBox.Items.Add("اعتبار شما برای ارسال کافی نمی باشد" & " -- " & Now.TimeOfDay.ToString)
                    Up.UpdateDatabase(ID, "اعتبار شما برای ارسال کافی نمی باشد." & " -- " & Now.TimeOfDay.ToString, 0)
                Case Is = 3
                    'Me.MessageListBox.Items.Add("خطای نا مشخص" & " -- " & Now.TimeOfDay.ToString)
                    Up.UpdateDatabase(ID, ".محدودیت زمان ارسال" & " -- " & Now.TimeOfDay.ToString, 0)
                Case Is = 4
                    'Me.MessageListBox.Items.Add("محدودیت در ارسال" & " -- " & Now.TimeOfDay.ToString)
                    Up.UpdateDatabase(ID, "محدودیت در ارسال." & " -- " & Now.TimeOfDay.ToString, 0)
                Case Is = 5
                    'Me.MessageListBox.Items.Add("شماره مرکز ارسال پیامک اشتباه می باشد" & " -- " & Now.TimeOfDay.ToString)
                    Up.UpdateDatabase(ID, "شماره مرکز ارسال پیامک اشتباه می باشد." & " -- " & Now.TimeOfDay.ToString, 0)
                Case Is = 6
                    Up.UpdateDatabase(ID, Message.ToString & ".ارسال پیامک با موفقیت انجام شد" & " -- " & Now.TimeOfDay.ToString, 1)

            End Select

            If Message > 6 Then
                Up.UpdateDatabase(ID, Message.ToString & ".خطای نا معلوم ---- کد خطا " & " -- " & Now.TimeOfDay.ToString, 0)
            End If
        Else
            Up.UpdateDatabase(ID, "7" & "خطای در برقراری ارتباط با شبکه اینترنت. " & " -- " & Now.TimeOfDay.ToString, 0)
        End If
        Message = 0
        MessageText = String.Empty
        MobileNumbers = String.Empty
    End Sub

    'Public Sub Send(ByVal ID As String, ByVal MobileNumbers As String, ByVal SenderNummber As String, ByVal MessageText As String)

    '    Dim sms As New WebService.Send()
    '    Dim rec As Long() = Nothing
    '    Dim status As Byte() = Nothing
    '    Dim Up As New UpdateClass

    '    IC = New InternetChecker

    '    If Not IC.IsConnectionAvailable() = False Then

    '        Try
    '            Message = sms.SendSms("c.morteza.shoja", "smsMaster2012", New String() {MobileNumbers}, SenderNummber, MessageText, False, "", rec, status)

    '            'Message :
    '            ' InvalidUserPass=0,
    '            ' Successfull = 1,
    '            ' NoCredit = 2,
    '            ' DailyLimit = 3,
    '            ' SendLimit = 4,
    '            ' InvalidNumber = 5

    '            'Status :
    '            ' Sent=0,
    '            ' Failed=1
    '        Catch ex As Exception
    '            Message = 6
    '        End Try


    '        Select Case Message

    '            Case Is = 0
    '                'Me.MessageListBox.Items.Add("نام کاربری یا کلمه عبور اشتباه می باشد" & " -- " & Now.TimeOfDay.ToString)
    '                Up.UpdateDatabase(ID, "نام کاربری یا کلمه عبور اشتباه می باشد." & " -- " & Now.TimeOfDay.ToString, 0)
    '            Case Is = 1
    '                'Me.MessageListBox.Items.Add("ارسال پیامک با موفقیت انجام شد" & " -- " & Now.TimeOfDay.ToString)
    '                Up.UpdateDatabase(ID, "ارسال پیامک با موفقیت انجام شد." & " -- " & Now.TimeOfDay.ToString, 1)
    '            Case Is = 2
    '                'Me.MessageListBox.Items.Add("اعتبار شما برای ارسال کافی نمی باشد" & " -- " & Now.TimeOfDay.ToString)
    '                Up.UpdateDatabase(ID, "اعتبار شما برای ارسال کافی نمی باشد." & " -- " & Now.TimeOfDay.ToString, 0)
    '            Case Is = 3
    '                'Me.MessageListBox.Items.Add("خطای نا مشخص" & " -- " & Now.TimeOfDay.ToString)
    '                Up.UpdateDatabase(ID, ".محدودیت زمان ارسال" & " -- " & Now.TimeOfDay.ToString, 0)
    '            Case Is = 4
    '                'Me.MessageListBox.Items.Add("محدودیت در ارسال" & " -- " & Now.TimeOfDay.ToString)
    '                Up.UpdateDatabase(ID, "محدودیت در ارسال." & " -- " & Now.TimeOfDay.ToString, 0)
    '            Case Is = 5
    '                'Me.MessageListBox.Items.Add("شماره مرکز ارسال پیامک اشتباه می باشد" & " -- " & Now.TimeOfDay.ToString)
    '                Up.UpdateDatabase(ID, "شماره مرکز ارسال پیامک اشتباه می باشد." & " -- " & Now.TimeOfDay.ToString, 0)
    '            Case Is = 6
    '                Up.UpdateDatabase(ID, Message.ToString & ".ارسال پیامک با موفقیت انجام شد" & " -- " & Now.TimeOfDay.ToString, 1)

    '        End Select

    '        If Message > 6 Then
    '            Up.UpdateDatabase(ID, Message.ToString & ".خطای نا معلوم ---- کد خطا " & " -- " & Now.TimeOfDay.ToString, 0)
    '        End If
    '    Else
    '        Up.UpdateDatabase(ID, "7" & "خطای در برقراری ارتباط با شبکه اینترنت. " & " -- " & Now.TimeOfDay.ToString, 0)
    '    End If
    '    Message = 0
    '    MessageText = String.Empty
    '    MobileNumbers = String.Empty
    'End Sub
End Class
