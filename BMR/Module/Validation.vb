Imports System.IO
Module Validation
    Public Sub numtext(ByVal cntr As TextBox, ByVal e As KeyPressEventArgs, Optional ByVal dotacceptable As Boolean = True, Optional ByVal ReadOnlyText As Boolean = False)
        If ReadOnlyText = False Then
            If e.KeyChar = Chr(Keys.Back) Then
                Exit Sub
            End If
            If e.KeyChar = "." Then
                If dotacceptable = False Then
                    e.Handled = True
                Else
                    If cntr.Text.IndexOf(".") = -1 Then
                        e.Handled = False
                        Exit Sub
                    Else
                        e.Handled = True
                    End If
                End If
            End If
            If Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub
    ''' <summary>
    ''' Validates whether the controls text property value is not ""
    ''' </summary>
    ''' <param name="ErrMessage">Prefix already in function as "Please Enter "</param>
    ''' <param name="CurrentControlName"></param>
    ''' <param name="NextControlName">To set focus</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function StringTextBoxValidation(ByVal ErrMessage As String, ByVal CurrentControlName As Control, ByVal NextControlName As Control) As Boolean
        Try
            CurrentControlName.Text = CurrentControlName.Text.Trim
            If Trim(CurrentControlName.Text) = "" Then
                MsgBox("Please Enter " & ErrMessage, vbCritical, CompName)
                CurrentControlName.Focus()
                StringTextBoxValidation = True
            Else
                NextControlName.Focus()
                StringTextBoxValidation = False
            End If
        Catch ex As Exception
            WarningMessage(ex.Message)
            StringTextBoxValidation = True
        End Try
    End Function
    ''' <summary>
    ''' Checks the value of text box ,If value=0 then dispays 
    ''' error message "Please Enter Valid " + ErrMessage and returns TRUE
    ''' ELSE Focus will go to next control AND return FALSE 
    ''' </summary>
    ''' <param name="ErrMessage">Error Message--Please Enter Valid  + "ErrMessage"</param>
    ''' <param name="CurrentControlName">Current Control</param>
    ''' <param name="NextControlName">Next Control to Set Focus</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function NumTextBoxValidation(ByVal ErrMessage As String, ByVal CurrentControlName As Control, ByVal NextControlName As Control) As Boolean
        Try
            If Val(CurrentControlName.Text) = 0 Then
                MsgBox("Please Enter Valid " & ErrMessage, vbCritical, CompName)
                CurrentControlName.Text = ""
                CurrentControlName.Focus()
                NumTextBoxValidation = True
            Else
                NextControlName.Focus()
                NumTextBoxValidation = False
            End If
        Catch ex As Exception
            WarningMessage(ex.Message)
            NumTextBoxValidation = True
        End Try
    End Function

    ''' <summary>
    ''' Will check the combobox value is selected or not if not selected....
    ''' Please select ErrMessage
    ''' </summary>
    ''' <param name="ErrMessage"></param>
    ''' <param name="CurrentControlName"></param>
    ''' <param name="NextControlName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ComboTextValidation(ByVal ErrMessage As String, ByVal CurrentControlName As ComboBox, ByVal NextControlName As Control) As Boolean
        Try
            If CurrentControlName.SelectedIndex = -1 Then
                MsgBox("Please Select " & ErrMessage, vbCritical, CompName)
                CurrentControlName.Focus()
                ComboTextValidation = True
            Else
                NextControlName.Focus()
                ComboTextValidation = False
            End If
        Catch ex As Exception
            WarningMessage(ex.Message)
            ComboTextValidation = True
        End Try
    End Function
    Public Function FormatTo_DisplayDate(ByVal DateVal As DateTime) As String
        Return DateVal.Day.ToString("D2") & "-" & DateVal.Month.ToString("D2") & "-" & DateVal.Year.ToString("D4")
    End Function
    Public Function FormatTo_yyyy_MM_dd(ByVal DateVal As DateTime) As String
        Try
            Return DateVal.Year.ToString("D4") & "-" & DateVal.Month.ToString("D2") & "-" & DateVal.Day.ToString("D2")
        Catch ex As Exception
            Debug.Print("Error")
        End Try
        Return Nothing
    End Function
    Public Function FormatTo_DisplayDateTime(ByVal DateVal As DateTime) As String
        Try
            Return DateVal.Day.ToString("D2") & "-" & DateVal.Month.ToString("D2") & "-" & DateVal.Year.ToString("D4") & " " & _
                    DateVal.ToString("hh") & ":" & DateVal.Minute.ToString("D2") & ":" & DateVal.Second.ToString("D2") & " " & DateVal.ToString("tt")
        Catch ex As Exception
            Debug.Print("Error")
        End Try
        Return Nothing
    End Function
    Public Function FormatTo_HH_mm_ss(ByVal TimeVal As TimeSpan) As String
        Try
            Return TimeVal.Hours.ToString("D2") & ":" & TimeVal.Minutes.ToString("D2") & ":" & TimeVal.Seconds.ToString("D2")
        Catch ex As Exception
            Debug.Print("Error")
        End Try
        Return Nothing
    End Function
    Public Function FormatTo_HH_mm_ss(ByVal TimeVal As DateTime) As String
        Try
            Return TimeVal.Hour.ToString("D2") & ":" & TimeVal.Minute.ToString("D2") & ":" & TimeVal.Second.ToString("D2")
        Catch ex As Exception
            Debug.Print("Error")
        End Try
        Return Nothing
    End Function
    Public Function FormatToSqlDateTime(ByVal DateVal As DateTime)
        Return DateVal.Year.ToString("D4") & "-" & DateVal.Month.ToString("D2") & "-" & DateVal.Day.ToString("D2") & " " & DateVal.Hour.ToString("D2") & ":" & DateVal.Minute.ToString("D2") & ":" & DateVal.Second.ToString("D2")
    End Function
    Public Sub WarningMessage(ByVal Mess As String)
        MsgBox(Mess, MsgBoxStyle.Critical, CompName)
    End Sub
    Public Function ConfirmMessage(ByVal Mess As String) As MsgBoxResult '  for any Warining Message lie are u sure to delete data
        ConfirmMessage = MsgBox(Mess, MsgBoxStyle.YesNo + MsgBoxStyle.Question, CompName)
    End Function
    Public Sub InfoMessage(ByVal Mess As String) ' for Record Added, Updated, Deleted
        MsgBox(Mess, MsgBoxStyle.Information, CompName)
    End Sub
    Public Function WorkStation() As String
        WorkStation = "'" & Mid(Environment.MachineName, 1, 30) & "'"
    End Function
   
   
    Public Function Backup_File(ByVal ArgSourceFileName As String, _
                               ByVal DestinationPath As String) As Integer
        Try
            If IO.Directory.Exists(DestinationPath) = False Then
                IO.Directory.CreateDirectory(DestinationPath)
            End If
            Dim FileName As String = IO.Path.GetFileName(ArgSourceFileName)
            Dim NewFileName As String = Now.Year.ToString("D2") & "_" & Now.Month.ToString("D2") & Now.Day.ToString("D2") & "_" & _
                            Now.Hour.ToString("D2") & "_" & Now.Minute.ToString("D2") & "_" & Now.Second.ToString("D2") & FileName
            IO.File.Copy(ArgSourceFileName, DestinationPath & "\" & NewFileName)
        Catch ex As Exception

        End Try
    End Function
    Public Function Diff_Of_Minute_InTimeSpan(ByVal FirstTime As TimeSpan, _
                                          ByVal SecondTime As TimeSpan)
        Dim Hours As Long = SecondTime.Hours - FirstTime.Hours
        Dim Minutes As Long = SecondTime.Minutes - FirstTime.Minutes
        Return ((Hours * 60) + Minutes)
    End Function
    Public Function MinuteDifferInDateTime(ByVal StartDate As DateTime, _
                                           ByVal EndDate As DateTime) As Double
        Dim TmSpan As TimeSpan = EndDate.Subtract(StartDate)
        Return TmSpan.TotalMinutes
    End Function
    Public Function CheckOdd(ByVal ArgNum As Integer) As Boolean
        If ArgNum = 0 Then
            Return False
        End If
        If ArgNum Mod 2 = 1 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Sub WriteToTextFile(ByVal TextFileName As String, ByVal Content As String, Optional ByVal AppendToFile As Boolean = False)
        Dim LogFileWriter As New StreamWriter(TextFileName, AppendToFile)
        LogFileWriter.WriteLine(Content)
        LogFileWriter.Close()
    End Sub
    Public Sub RemoveLastChar(ByRef ArgStr As String)
        If ArgStr <> "" Then
            ArgStr = ArgStr.Substring(0, ArgStr.Length - 1)
        End If
    End Sub
End Module
