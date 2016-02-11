Imports MySql.Data.MySqlClient
Public Class FrmLogin
    Private Sub OK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim cmd As New MySqlCommand
        Dim dt, dt1 As New DataTable
        Try
            dt = ReturningDataByQ("select * from Tbl_UserMaster where User_Name='" & txtuname.Text & "' and User_Pwd='" & txtpwd.Text & "'")
            
            If dt.Rows.Count > 0 Then
                If txtpwd.Text <> dt.Rows(0)("user_pwd").ToString Or txtuname.Text <> dt.Rows(0)("user_name").ToString Then
                    MsgBox("UserName OR Password is incorrect", MsgBoxStyle.Critical, "BMR")
                    txtuname.Text = ""
                    txtpwd.Text = ""
                    txtuname.Focus()
                Else
                    dt1 = ReturningDataByQ("select A.User_Code,A.User_Pwd,B.menu from Tbl_UserMaster A inner join tbl_permission B on A.user_code=B.user_code where A.User_Name='" & txtuname.Text & "'")
                    'With cmd
                    '    .Parameters.AddWithValue("@uname", txtuname.Text)
                    'End With
                    'Dr = ExecuteQuery(cmd.CommandText)
                    'While Dr.Read
                    '    'usercode = Dr(0)
                    '    ''If IsDBNull(dr(1)) = False Then
                    '    ''    currlocation = dr(1)
                    '    ''    location1 = dr(1)
                    '    ''    'divcode = dr(2)
                    '    ''    usrpwd = decryptpwd(dr(1))
                    '    ''    'empcode = dr(4)
                    '    ''End If
                    '    'usrpwd = Dr(1)
                    'End While
                    'Dr.Close()
                    'cmd.CommandText = "select * from empmaster where emp_code=" & empcode & ""
                    'dr = cmd.ExecuteReader
                    'If dr.Read Then
                    '    empname = dr(1)
                    'End If
                    'Dr.Close()
                    'FrmMain._UserCode = usercode
                    FrmMain._menuPer = Strings.Split(dt1.Rows(0)("menu"), ",")
                    If dt.Rows.Count > 0 Then
                        'FrmMain._uname = txtuname.Text
                        FrmMain.Show()
                        FrmMain.Text = "Daily Fish Logged in user" & dt.Rows(0)("User_name") & " at " & Date.Now & ""
                        Me.Hide()
                    Else
                        MsgBox("Invalid Login", MsgBoxStyle.OkOnly, "BMR")
                        Exit Sub
                    End If
                End If
            Else
                    If txtuname.Text = "admin" Then
                    dt = ReturningDataByQ("select A.user_code,A.User_pwd ,B.menu from Tbl_UserMaster A inner join tbl_permission B on A.user_code=B.user_code where A.User_Name like 'admin'")
                    If dt.Rows.Count > 0 Then
                        If txtpwd.Text = dt.Rows(0)("user_pwd") Then
                            'usercode = Dr(0)
                            'usrpwd = decryptpwd(Dr(1))
                            'Dr.Close()
                            'FrmMain._UserCode = usercode
                            'FrmMain._uname = txtuname.Text
                            FrmMain._menuPer = Strings.Split(dt.Rows(0)("menu"), ",")
                            FrmMain.Show()
                            FrmMain.Text = "Daily Fish Logged in user" & dt.Rows(0)("User_name") & " at " & Date.Now & ""
                            Me.Hide()
                        End If
                    Else
                        MsgBox("UserName OR Password is incorrect", MsgBoxStyle.Critical, "BMR")
                        txtuname.Text = ""
                        txtpwd.Text = ""
                        txtuname.Focus()
                    End If
                End If
            End If
            'Dr.Close()
        Catch ex As MySqlException
            'Dr.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "BMR")
        Catch ex As Exception
            'Dr.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "BMR")
        End Try
    End Sub
    Private Sub FrmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If ConnectToDB() = False Then
            Application.Exit()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub txtuname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtuname.KeyDown, txtpwd.KeyDown
        If e.KeyCode = Keys.Enter Then
            ProcessTabKey(True)
        End If
    End Sub
End Class