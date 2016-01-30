Imports System.Data.SqlClient
Imports System.Net
Imports MySql.Data.MySqlClient

Public Class FrmProcess
    Dim Sql_Connection As New MySqlConnection
    Dim listscrap As New List(Of String)
    Dim strScrapcode, StrWasteCode As String
    Private Sub FrmProcess_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        clear()
    End Sub
    Public Sub LoadCombo(ByVal Cntr As ComboBox, ByVal Qry As String, Optional ByVal defaultval As Boolean = False)
        Dim SQLCmd As New MySqlCommand
        Dim SQLDr As MySqlDataReader

        AssignConnection(SQLCmd)

        If Sql_Connection.State = ConnectionState.Closed Then
            If ConnectToDB() = False Then
                WarningMessage("Connection To DB Failed")
                End
            End If
        End If


        ' Try
        Cntr.Text = ""
        Cntr.SelectedIndex = -1
        Cntr.Items.Clear()
        If defaultval = True Then
            Cntr.Items.Add(New itemdata(0, "<<NA>>"))
        End If

        If Qry = "" Then
            Exit Sub
        End If

        SQLCmd.CommandText = Qry
        SQLDr = SQLCmd.ExecuteReader
        While SQLDr.Read
            If SQLDr.FieldCount < 2 Then
                Cntr.Items.Add(New itemdata(SQLDr(0), SQLDr(0)))
            Else
                Cntr.Items.Add(New itemdata(SQLDr(0), SQLDr(1)))
            End If

        End While
        SQLDr.Close()

        If defaultval = True Then
            If Cntr.Items.Count > 0 Then
                Cntr.SelectedIndex = 0
            End If
        End If
        'Cntr.AutoCompleteSource = AutoCompleteSource.CustomSource
        'Cntr.AutoCompleteMode = AutoCompleteMode.Suggest
        SQLCmd.Dispose()

    End Sub
    Private Sub clear()
        Dim cmd As New MySqlCommand
        Dim dt, dt1 As New DataTable
        cmd.CommandText = "select Product_code,Product_name from Product_Master where Product_del=0"
        AssignConnection(cmd)
        If ConnectToDB() Then
            LoadCombo(CmbProduct, "SELECT Product_Code,Product_Name FROM Product_Master WHERE Product_del=0")
            CmbProduct.DisplayMember = "ProductName"
            CmbProduct.ValueMember = "Product_Code"
            'CmbProduct.Splits(0).DisplayColumns(0).Visible = False
            'CmbProduct.Splits(0).DisplayColumns(1).Width = 447
        End If
        listscrap.Clear()
        'cmd.CommandText = "select * from tbl_shiftmaster where totime in (select FromTime from tbl_shiftmaster where  convert(varchar,GETDATE(),114) > convert(datetime,FromTime,114) and convert(varchar,GETDATE(),114) < convert(datetime,totime,114)) and shift_del=0"
        'cmd.CommandText = "Select * from tbl_shiftmaster"
        'AssignConnection(cmd)
        'If ConnectToDB() Then
        '    Dr = cmd.ExecuteReader
        '    dt1.Load(Dr)
        '    CmbShift.DataSource = dt1
        '    CmbShift.DisplayMember = "shiftname"
        '    CmbShift.ValueMember = "shift_code"
        '    'CmbShift.Splits(0).DisplayColumns(0).Visible = False
        '    'CmbShift.Splits(0).DisplayColumns(2).Visible = False
        '    'CmbShift.Splits(0).DisplayColumns(3).Visible = False
        '    'CmbShift.Splits(0).DisplayColumns(1).Width = 200
        '    Dr.Close()
        '    If dt1.Rows.Count > 0 Then
        '        For i As Integer = 0 To dt1.Rows.Count - 1
        '            Dim datestr As String = DateTime.Now.ToString()
        '            Dim dtstr() As String = datestr.Split(" ")
        '            Dim tmstr As String = dtstr(1).Replace(".", ":")
        '            Dim tmarr() As String = tmstr.Split(":")
        '            Dim tblfrom As String = dt1.Rows(i).Item("FromTime").ToString()
        '            Dim tblto As String = dt1.Rows(i).Item("ToTime").ToString()

        '            If Format(TimeValue(tmstr), "HH:mm:ss") > Format(TimeValue(tblfrom), "HH:mm:ss") And Format(TimeValue(tmstr), "HH:mm:ss") < Format(TimeValue(tblto), "HH:mm:ss") Then
        '                Try
        '                    CmbShift.SelectedValue = dt1.Rows(i - 1).Item("shift_Code").ToString()
        '                    'lblshift.Text = dt1.Rows(i).Item("ShiftName").ToString()
        '                    Exit For
        '                Catch ex As Exception
        '                    CmbShift.SelectedValue = dt1.Rows(dt1.Rows.Count - 1).Item("shift_Code").ToString()
        '                End Try
        '            End If
        '        Next
        '    End If

        'End If
        ''CmbShift.Text = ""
        ''CmbShift.SelectedIndex = 0
        'CmbShift.Enabled = False
        'For intcount = 0 To CmbShift.ListCount - 1
        '    If Format(TimeOfDay, "HH:mm:ss tt") >= Format(CDate(CmbShift.Columns(2).CellText(intcount)), "HH:mm:ss tt") And Format(TimeOfDay, "HH:mm:ss tt") <= Format(CDate(CmbShift.Columns(3).CellText(intcount)), "HH:mm:ss tt") Then
        '        'CmbShift.SelectedText = CmbShift.Columns(1).CellText(intcount)
        '        CmbShift.SelectedValue = CmbShift.Columns(0).CellText(intcount)
        '        'Dim i As Integer = CmbShift.SelectedValue
        '    End If
        'Next
        Dim col As New AutoCompleteStringCollection
        Dr = SelectQuery("SELECT SAP_Code FROM Product_Master WHERE Product_del=0 and Product_type='FG'")
        While Dr.Read
            col.Add(Dr("SAP_Code"))
        End While
        Dr.Close()
        txtSap.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtSap.AutoCompleteCustomSource = col
        txtSap.AutoCompleteMode = AutoCompleteMode.Suggest
        cboBatchno.Text = ""
        TxtProcessQty.Clear()
        DateTimePicker1.Value = Date.Today
        txtSap.Text = ""
        strScrapcode = ""
        txtscanQty.Text = ""
        TxtScrapQty.Text = ""
        txtWaste.Text = ""
        CmbProduct.SelectedValue = 0
        C1SuperErrorProvider1.Clear()
        C1SuperTooltip1.RemoveAll()
        C1SuperTooltip1.Hide()
    End Sub

    Private Sub CmbProduct_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbProduct.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboBatchno.Focus()
        End If
    End Sub

    Private Sub CmbProduct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbProduct.SelectedValueChanged
        If CmbProduct.Text <> "" Then
            Dr = SelectQuery("select SAP_Code from Product_Master where Product_Code=" & CType(CmbProduct.SelectedItem, itemdata).Value & "")
            If Dr.Read Then
                txtSap.Text = Dr("SAP_Code")
                txtSap.Focus()
            End If
            Dr.Close()
            Dr = SelectQuery("select Scrap_code,Waste_code from product_master where Product_Code=" & CType(CmbProduct.SelectedItem, itemdata).Value & "")
            If Dr.HasRows Then
                Dr.Read()
                strScrapcode = Dr(0).ToString
                StrWasteCode = Dr(1).ToString
            Else
                strScrapcode = ""
                StrWasteCode = ""
            End If
            Dr.Close()
            If Me.Tag = 0 Then
                LoadCombo(cboBatchno, "select distinct(batch_no) from barcode where Product_type='SFG' and Product_Code=" & CType(CmbProduct.SelectedItem, itemdata).Value & " and status=1 and loc_code='" & Loc_Code & "' and batch_no not in(select batch_no from tbl_inventory where Sapcode='" & txtSap.Text & "'  and type=0 and loc_code='" & Loc_Code & "')")
            Else
                LoadCombo(cboBatchno, "select distinct(batch_no) from barcode where Product_type='W' and Product_Code=" & CType(CmbProduct.SelectedItem, itemdata).Value & " and status=1 and loc_code=" & Loc_Code & " and batch_no not in(select batch_no from tbl_inventory where Sapcode='" & txtSap.Text & "' and date='" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "' and type=1 and loc_code='" & Loc_Code & "')")
            End If
        End If
    End Sub
    Private Sub txtBatchno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboBatchno.KeyDown
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader
        If e.KeyCode = Keys.Enter Then
            If cboBatchno.Text <> "" Then
                'cmd.CommandText = "select   A.Product_Code,A.Product_Name from Product_Master A inner join Barcode B on A.Product_Code=B.Product_code where B.Batch_no=?bno and A.Product_del=0 and B.product_type=?type Limit 1"
                'AssignConnection(cmd)
                'If ConnectToDB() Then
                '    With cmd
                '        .Parameters.AddWithValue("?bno", txtBatchno.Text)
                '        .Parameters.Add(New MySqlParameter("?type", IIf(Me.Tag = 0, "SFG", "W")))
                '    End With
                '    'Dim query As String = cmd.CommandText
                '    'For Each p As MySqlParameter In cmd.Parameters
                '    '    query = query.Replace(p.ParameterName, p.Value.ToString())
                '    'Next
                '    'cmd.CommandText = query
                '    dr = cmd.ExecuteReader
                '    If dr.HasRows Then
                '        Dim i As Integer
                '        While dr.Read
                '            i = dr(0)
                '        End While
                '        dr.Close()
                '        CmbProduct.SelectedValue = i
                '        TxtProcessQty.Focus()
                '    Else
                '        MsgBox("Invalid Batchno", MsgBoxStyle.OkOnly, "BMR")
                '        dr.Close()
                '    End If
                'End If
                C1SuperErrorProvider1.Clear()
                C1SuperTooltip1.RemoveAll()
                C1SuperTooltip1.Hide()
                DateTimePicker1.Focus()
            Else
                C1SuperErrorProvider1.SetError(cboBatchno, "Enter Valid Batchno")
                C1SuperTooltip1.SetToolTip(cboBatchno, "Enter Batchno")
                C1SuperTooltip1.IsBalloon = True
            End If
        End If
    End Sub
    Private Sub CmbShift_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtscanQty.KeyDown
        If e.KeyCode = Keys.Enter Then
            ProcessTabKey(True)
        ElseIf e.KeyCode = Keys.Left Then
            If sender.name = "CmbShift" Then
                ProcessTabKey(False)
            End If
        ElseIf e.KeyCode = Keys.Up Then
            If sender.name <> "CmbShift" Then
                ProcessTabKey(False)
            End If
        End If

    End Sub

    Private Sub TxtProcessQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtProcessQty.KeyDown
        If e.KeyCode = Keys.Enter Then
            If CmbProduct.SelectedIndex <> -1 Then
                If Me.Tag = 0 Then
                    Dim cmd As New MySqlCommand
                    cmd.CommandText = "select  sum(Carton_Weight) from Barcode where Batch_no=?bno and Product_type='SFG' and status=1 and loc_code=?loc and sap_code=?prod and store_date=?date"
                    AssignConnection(cmd)
                    With cmd
                        .Parameters.AddWithValue("?bno", cboBatchno.Text)
                        .Parameters.AddWithValue("?loc", Loc_Code)
                        .Parameters.AddWithValue("?prod", txtSap.Text)
                        .Parameters.AddWithValue("?date", Format(DateTimePicker1.Value, "yyyy-MM-dd"))
                    End With
                    Dr = cmd.ExecuteReader
                    While Dr.Read
                        If Val(Dr(0).ToString) > Val(TxtProcessQty.Text) Then
                            TxtProcessQty.FindForm()
                            C1SuperErrorProvider1.SetError(TxtProcessQty, "Process quantity Entered Less than Actual Process Qty..Actual Qty : " & Dr(0).ToString & "")
                            C1SuperTooltip1.SetToolTip(TxtProcessQty, "Enter Correct Process Qty")
                            C1SuperTooltip1.IsBalloon = True
                            txtscanQty.Text = Val(Dr(0).ToString)
                            'TxtScrapQty.Focus()
                            'txtscrapscan.Focus()
                        ElseIf Val(Dr(0).ToString) = 0 Then
                            C1SuperErrorProvider1.SetError(TxtProcessQty, "Cant Find Process Qty for this Batch")
                            C1SuperTooltip1.SetToolTip(TxtProcessQty, "Enter Correct Process Qty")
                            C1SuperTooltip1.IsBalloon = True
                            TxtProcessQty.Focus()
                        Else
                            C1SuperErrorProvider1.Clear()
                            C1SuperTooltip1.RemoveAll()
                            C1SuperTooltip1.Hide()
                            txtscanQty.Text = Val(Dr(0).ToString)
                            'txtscrapscan.Focus()
                            'TxtScrapQty.Focus()
                        End If
                    End While
                    Dr.Close()
                    cmd.Parameters.Clear()
                    'cmd.CommandText = "select sum(B.carton_weight) from tbl_scrapstorage A inner join barcode B on A.carton_serial_no=B.carton_serial_no inner join product_master C on c.product_code=A.Product_code inner join scrap_prod_link D on A.Product_code=D.scrap_code  where D.product_code=?prod and A.batch_no=?bno and A.store_date=?date and A.loc_code=?loc"
                    cmd.CommandText = "select sum(B.carton_weight) from tbl_scrapstorage A inner join barcode B on A.carton_serial_no=B.carton_serial_no inner join product_master C on c.product_code=A.Product_code    where c.Sap_code=?prod and A.batch_no=?bno and A.store_date=?date and A.loc_code=?loc"
                    AssignConnection(cmd)
                    With cmd
                        .Parameters.AddWithValue("?bno", cboBatchno.Text)
                        .Parameters.AddWithValue("?loc", Loc_Code)
                        '.Parameters.AddWithValue("?prod", CType(CmbProduct.SelectedItem, itemdata).Value)
                        .Parameters.AddWithValue("?prod", strScrapcode)
                        .Parameters.AddWithValue("?date", Format(DateTimePicker1.Value, "yyyy-MM-dd"))
                    End With
                    Dr = cmd.ExecuteReader
                    If Dr.HasRows Then
                        C1SuperErrorProvider1.Clear()
                        C1SuperTooltip1.RemoveAll()
                        C1SuperTooltip1.Hide()
                        While Dr.Read
                            TxtScrapQty.Text = Dr(0).ToString
                        End While
                        Dr.Close()
                    Else
                        C1SuperErrorProvider1.SetError(TxtScrapQty, "Cant Find Scrap Qty for this Batch")
                        C1SuperTooltip1.SetToolTip(TxtProcessQty, "No Scrap Qty")
                        C1SuperTooltip1.IsBalloon = True
                    End If
                    txtWaste.Focus()
                Else
                    Dim cmd As New MySqlCommand("select  SUM(Carton_Weight) from Barcode where Batch_no=?batchno and Product_type='W' and status=1 and loc_code=?loc  and sap_code=?prod and STR_TO_DATE(store_date, '%Y-%m-%d') = convert(?date,char)")
                    AssignConnection(cmd)
                    With cmd
                        .Parameters.AddWithValue("?batchno", cboBatchno.Text)
                        .Parameters.AddWithValue("?loc", Loc_Code)
                        .Parameters.AddWithValue("?date", Format(DateTimePicker1.Value, "yyyy-MM-dd"))
                        .Parameters.AddWithValue("?prod", txtSap.Text)
                    End With
                    Dim i As Integer
                    i = Val(cmd.ExecuteScalar.ToString)
                    'If i = 0 Then
                    '    cmd.Parameters.Clear()
                    '    cmd.CommandText = ("select  SUM(Carton_Weight) from Barcode where Batch_no=?batchno and Product_type='FG' and status=1 and loc_code=?loc and shift=?Date and  convert(Store_date,char) =convert(subdate(current_date, 1),char)")
                    '    AssignConnection(cmd)
                    '    With cmd
                    '        .Parameters.AddWithValue("?batchno", cboBatchno.Text)
                    '        .Parameters.AddWithValue("?loc", Loc_Code)
                    '        .Parameters.AddWithValue("?date", Format(DateTimePicker1.Value, "yyyy-MM-dd"))
                    '    End With
                    '    i = Val(cmd.ExecuteScalar.ToString)
                    'End If
                    'While Dr.Read
                    'End While
                    Dr.Close()
                    If Val(i) > Val(TxtProcessQty.Text) Then
                        TxtProcessQty.FindForm()
                        C1SuperErrorProvider1.SetError(TxtProcessQty, "Process quantity Entered Less than Actual Process Qty..Actual Qty : " & i.ToString & "")
                        C1SuperTooltip1.SetToolTip(TxtProcessQty, "Enter Correct Process Qty")
                        C1SuperTooltip1.IsBalloon = True
                        txtscanQty.Text = Val(i.ToString)
                        'txtscrapscan.Focus()
                        'txtscanQty.Focus()
                    ElseIf Val(i) = 0 Then
                        C1SuperErrorProvider1.SetError(TxtProcessQty, "Cant Find Process Qty for this Batch")
                        C1SuperTooltip1.SetToolTip(TxtProcessQty, "Enter Correct Process Qty")
                        C1SuperTooltip1.IsBalloon = True
                        TxtProcessQty.Focus()
                    Else
                        C1SuperErrorProvider1.Clear()
                        C1SuperTooltip1.RemoveAll()
                        C1SuperTooltip1.Hide()
                        txtscanQty.Text = Val(i.ToString)
                        'txtscrapscan.Focus()
                    End If
                    Dr.Close()
                    cmd.Parameters.Clear()
                    cmd.CommandText = "select sum(B.carton_weight) from tbl_scrapstorage A inner join barcode B on A.carton_serial_no=B.carton_serial_no inner join product_master C on c.product_code=A.Product_code    where c.Sap_code=?prod and A.batch_no=?bno and A.store_date=?date and A.loc_code=?loc"
                    AssignConnection(cmd)
                    With cmd
                        .Parameters.AddWithValue("?bno", cboBatchno.Text)
                        .Parameters.AddWithValue("?loc", Loc_Code)
                        '.Parameters.AddWithValue("?prod", CType(CmbProduct.SelectedItem, itemdata).Value)
                        .Parameters.AddWithValue("?prod", strScrapcode)
                        .Parameters.AddWithValue("?date", Format(DateTimePicker1.Value, "yyyy-MM-dd"))
                    End With
                    Dr = cmd.ExecuteReader
                    If Dr.HasRows Then
                        C1SuperErrorProvider1.Clear()
                        C1SuperTooltip1.RemoveAll()
                        C1SuperTooltip1.Hide()
                        While Dr.Read
                            TxtScrapQty.Text = Dr(0).ToString
                        End While
                        Dr.Close()
                    Else
                        C1SuperErrorProvider1.SetError(TxtScrapQty, "Cant Find Scrap Qty for this Batch")
                        C1SuperTooltip1.SetToolTip(TxtProcessQty, "No Scrap Qty")
                        C1SuperTooltip1.IsBalloon = True
                    End If
                    txtWaste.Focus()
                End If
            Else
                MsgBox("Select a Product", MsgBoxStyle.Critical, "BMR")
            End If
        End If
    End Sub
    'Private Sub TxtScrapQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtScrapQty.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        If TxtScrapQty.Text <> "" Then
    '            If Val(TxtScrapQty.Text) > Val(txtscanQty.Text) Then
    '                C1SuperErrorProvider1.SetError(TxtScrapQty, "Scrap quantity Entered Greater than Scan Qty.Recheck Entered Qty")
    '                C1SuperTooltip1.SetToolTip(TxtScrapQty, "Enter Correct Scrap Qty")
    '                C1SuperTooltip1.IsBalloon = True
    '                TxtScrapQty.Focus()
    '            Else
    '                C1SuperErrorProvider1.Clear()
    '                C1SuperTooltip1.RemoveAll()
    '                C1SuperTooltip1.Hide()
    '                txtWaste.Text = Val(TxtProcessQty.Text) - Val(txtscanQty.Text) - Val(TxtScrapQty.Text)
    '                btnsave.Focus()
    '            End If
    '        End If
    '        End If
    'End Sub
    Private Function validateme() As Boolean
        If cboBatchno.Text = "" Then
            C1SuperErrorProvider1.SetError(cboBatchno, "Enter Batchno")
            C1SuperTooltip1.SetToolTip(cboBatchno, "Enter Batchno")
            C1SuperTooltip1.IsBalloon = True
            cboBatchno.Focus()
            Return False
        ElseIf CmbProduct.Text = "" Then
            C1SuperErrorProvider1.SetError(CmbProduct, "Enter product")
            C1SuperTooltip1.SetToolTip(CmbProduct, "Enter product")
            C1SuperTooltip1.IsBalloon = True
            Return False
        ElseIf TxtProcessQty.Text = "" Then
            C1SuperErrorProvider1.SetError(TxtProcessQty, "Enter Process Quantity")
            C1SuperTooltip1.SetToolTip(TxtProcessQty, "Enter Process Quantity")
            C1SuperTooltip1.IsBalloon = True
            TxtProcessQty.Focus()
            Return False
        ElseIf txtscanQty.Text = "" Then
            C1SuperErrorProvider1.SetError(txtscanQty, "Enter Scan Quantity")
            C1SuperTooltip1.SetToolTip(txtscanQty, "Enter Scan Quantity")
            C1SuperTooltip1.IsBalloon = True
            txtscanQty.Focus()
            Return False
        ElseIf TxtScrapQty.Text = "" Then
            C1SuperErrorProvider1.SetError(TxtScrapQty, "Enter Scrap Quantity")
            C1SuperTooltip1.SetToolTip(TxtScrapQty, "Enter Scrap Quantity")
            C1SuperTooltip1.IsBalloon = True
            TxtScrapQty.Focus()
            Return False
        ElseIf txtWaste.Text = "" Or Val(txtWaste.Text) < 0 Then
            C1SuperErrorProvider1.SetError(txtWaste, "Enter Correct Waste Quantity")
            C1SuperTooltip1.SetToolTip(txtWaste, "Enter Correct Waste Quantity")
            C1SuperTooltip1.IsBalloon = True
            txtWaste.Focus()
            Return False
        Else
            C1SuperErrorProvider1.Clear()
            C1SuperTooltip1.RemoveAll()
            C1SuperTooltip1.Hide()
            Return True
        End If
        
    End Function

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clear()
    End Sub
    Private Function checkdupl() As Boolean
        Dim cmd As New MySqlCommand
        If Me.Tag = 0 Then
            cmd = New MySqlCommand("Select * from tbl_Inventory where batch_no=?bno and date=?date and type=?type  and Scrap_code=?sap")
            AssignConnection(cmd)
            With cmd
                .Parameters.Add("?bno", cboBatchno.Text)
                .Parameters.Add("?sap", strScrapcode)
                .Parameters.Add("?date", Format(DateTimePicker1.Value, "yyyy-MM-dd"))
                .Parameters.Add("?type", Me.Tag)
            End With
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                MsgBox("Scrap quantity For this Item Already Exist", MsgBoxStyle.OkOnly, "BMR")
                TxtScrapQty.Text = "0"
                txtWaste.Text = "0"
                TxtProcessQty.Text = Val(txtscanQty.Text) + Val(TxtScrapQty.Text) + Val(txtWaste.Text)
            End If
            Dr.Close()
            cmd.Parameters.Clear()
            cmd = New MySqlCommand("Select * from tbl_Inventory where batch_no=?bno and type=?type and loc_code=?loc and SAPcode=?prod")
            AssignConnection(cmd)
            With cmd
                .Parameters.AddWithValue("?bno", cboBatchno.Text)
                .Parameters.AddWithValue("?type", Me.Tag)
                .Parameters.AddWithValue("?loc", Loc_Code)
                .Parameters.AddWithValue("?prod", txtSap.Text)
            End With
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                MsgBox("Already Entered", MsgBoxStyle.OkOnly, "BMR")
                Dr.Close()
                Return True
            Else
                Dr.Close()
                Return False
            End If
        Else
            'cmd = New MySqlCommand("select case when A.Sum1=B.sum2 then 'True' else 'False' end as result from (select SUM(carton_weight) as Sum1 from barcode where Batch_no=?batchno and Product_type='FG' and status=1) as A,(select SUM(CONVERT(scan_qty,UNSIGNED INTEGER)) as sum2 from tbl_Inventory where Batch_no=?batchno and type=1) as B")
            'AssignConnection(cmd)
            'With cmd
            '    .Parameters.AddWithValue("?batchno", cboBatchno.Text)
            'End With
            'If cmd.ExecuteScalar.ToString = "True" Then
            '    MsgBox("Processed quantity is Equal to Scanned qauntity.Cannot Enter Any more ", MsgBoxStyle.OkOnly, "BMR")
            '    Return True
            'End If
            cmd = New MySqlCommand("Select * from tbl_Inventory where batch_no=?bno and date=?date and type=?type  and Scrap_code=?sap")
            AssignConnection(cmd)
            With cmd
                .Parameters.Add("?bno", cboBatchno.Text)
                .Parameters.Add("?sap", strScrapcode)
                .Parameters.Add("?date", Format(DateTimePicker1.Value, "yyyy-MM-dd"))
                .Parameters.Add("?type", Me.Tag)
            End With
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                MsgBox("Scrap quantity For this Item Already Exist", MsgBoxStyle.OkOnly, "BMR")
                TxtScrapQty.Text = "0"
                txtWaste.Text = "0"
                TxtProcessQty.Text = Val(txtscanQty.Text) + Val(TxtScrapQty.Text) + Val(txtWaste.Text)
            End If
            Dr.Close()
            cmd = New MySqlCommand("Select * from tbl_Inventory where batch_no=?bno and date=?date and type=?type  and SAPcode=?sap")
            AssignConnection(cmd)
            With cmd
                .Parameters.Add("?bno", cboBatchno.Text)
                .Parameters.Add("?sap", txtSap.Text)
                .Parameters.Add("?date", Format(DateTimePicker1.Value, "yyyy-MM-dd"))
                .Parameters.Add("?type", Me.Tag)
            End With
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                MsgBox("Already Entered", MsgBoxStyle.OkOnly, "BMR")
                Dr.Close()
                Return True
            Else
                Dr.Close()
                Return False
            End If
        End If
    End Function

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim cmd As New MySqlCommand
        If validateme() = True And checkdupl() = False Then
            If MsgBox("Do you want to Save?", MsgBoxStyle.YesNo, "BMR") = MsgBoxResult.Yes Then
                Try
                    cmd = New MySqlCommand("Insert into tbl_Inventory values(?bno,?sap,?prod,?date,?pqty,?scanqty,?scrap,?wqty,?type,?loc,?Scrapcode,?Wastecode,0)")
                    AssignConnection(cmd)
                    With cmd
                        .Parameters.AddWithValue("?bno", cboBatchno.Text)
                        .Parameters.AddWithValue("?sap", txtSap.Text)
                        .Parameters.AddWithValue("?prod", CType(CmbProduct.SelectedItem, itemdata).Value)
                        .Parameters.AddWithValue("?date", Format(DateTimePicker1.Value, "yyyy-MM-dd"))
                        '.Parameters.AddWithValue("?shift", CmbShift.SelectedValue)
                        .Parameters.AddWithValue("?pqty", TxtProcessQty.Text)
                        .Parameters.AddWithValue("?scanqty", txtscanQty.Text)
                        .Parameters.AddWithValue("?scrap", TxtScrapQty.Text)
                        .Parameters.AddWithValue("?wqty", txtWaste.Text)
                        .Parameters.AddWithValue("?type", Me.Tag)
                        .Parameters.AddWithValue("?loc", Loc_Code)
                        .Parameters.AddWithValue("?Scrapcode", strScrapcode)
                        .Parameters.AddWithValue("?Wastecode", StrWasteCode)
                    End With
                    cmd.ExecuteNonQuery()
                    clear()
                Catch ex As Exception
                    MsgBox("Failed To save", MsgBoxStyle.OkOnly, "BMR")
                End Try
            End If
        End If
    End Sub

    Private Sub txtSap_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSap.KeyDown
        If txtSap.Text <> "" Then
            cboBatchno.Focus()
        End If
    End Sub

    Private Sub DateTimePicker1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DateTimePicker1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.Tag = 0 Then
                Dim cmd As New MySqlCommand
                cmd.CommandText = "select  sum(Carton_Weight) from Barcode where Batch_no=?bno and Product_type='SFG' and status=1 and loc_code=?loc and sap_code=?prod and store_date=?date"
                AssignConnection(cmd)
                With cmd
                    .Parameters.AddWithValue("?bno", cboBatchno.Text)
                    .Parameters.AddWithValue("?loc", Loc_Code)
                    .Parameters.AddWithValue("?prod", txtSap.Text)
                    .Parameters.AddWithValue("?date", Format(DateTimePicker1.Value, "yyyy-MM-dd"))
                End With
                Dr = cmd.ExecuteReader
                While Dr.Read
                    If Val(Dr(0).ToString) > Val(TxtProcessQty.Text) Then
                        'TxtProcessQty.Focus()
                        C1SuperErrorProvider1.SetError(TxtProcessQty, "Scanned quantity for this batch on given date: " & Dr(0).ToString & "")
                        'C1SuperTooltip1.SetToolTip(TxtProcessQty, "Enter Correct Process Qty")
                        'C1SuperTooltip1.IsBalloon = True
                        'TxtProcessQty.Focus()
                    ElseIf Val(Dr(0).ToString) = 0 Then
                        C1SuperErrorProvider1.SetError(TxtProcessQty, "Cant Find Process Qty for this Batch on given date")
                        'C1SuperTooltip1.SetToolTip(TxtProcessQty, "Enter Correct Process Qty")
                        'C1SuperTooltip1.IsBalloon = True
                        'TxtProcessQty.Focus()
                    Else
                        C1SuperErrorProvider1.Clear()
                        C1SuperTooltip1.RemoveAll()
                        C1SuperTooltip1.Hide()
                        'txtscanQty.Text = Val(Dr(0).ToString)
                        'TxtScrapQty.Focus()
                    End If
                End While
                Dr.Close()
            Else
                Dim cmd As New MySqlCommand("select  SUM(Carton_Weight) from Barcode where Batch_no=?batchno and Product_type='W' and status=1 and loc_code=?loc  and sap_code=?prod and STR_TO_DATE(store_date, '%Y-%m-%d') = convert(?date,char)")
                AssignConnection(cmd)
                With cmd
                    .Parameters.AddWithValue("?batchno", cboBatchno.Text)
                    .Parameters.AddWithValue("?loc", Loc_Code)
                    .Parameters.AddWithValue("?date", Format(DateTimePicker1.Value, "yyyy-MM-dd"))
                    .Parameters.AddWithValue("?prod", txtSap.Text)
                End With
                Dim i As Integer
                i = Val(cmd.ExecuteScalar.ToString)
                'If i = 0 Then
                '    cmd.Parameters.Clear()
                '    cmd.CommandText = ("select  SUM(Carton_Weight) from Barcode where Batch_no=?batchno and Product_type='FG' and status=1 and loc_code=?loc and shift=?Date and  convert(Store_date,char) =convert(subdate(current_date, 1),char)")
                '    AssignConnection(cmd)
                '    With cmd
                '        .Parameters.AddWithValue("?batchno", cboBatchno.Text)
                '        .Parameters.AddWithValue("?loc", Loc_Code)
                '        .Parameters.AddWithValue("?date", Format(DateTimePicker1.Value, "yyyy-MM-dd"))
                '    End With
                '    i = Val(cmd.ExecuteScalar.ToString)
                'End If
                'While Dr.Read
                'End While
                Dr.Close()
                If Val(i) > Val(TxtProcessQty.Text) Then
                    'TxtProcessQty.FindForm()
                    C1SuperErrorProvider1.SetError(TxtProcessQty, "Scanned quantity for this batch on given date: " & i.ToString & "")
                    'C1SuperTooltip1.SetToolTip(TxtProcessQty, "Enter Correct Process Qty")
                    'C1SuperTooltip1.IsBalloon = True
                    'TxtProcessQty.Focus()
                ElseIf Val(i) = 0 Then
                    C1SuperErrorProvider1.SetError(TxtProcessQty, "Cant Find Process Qty for this Batch")
                    'C1SuperTooltip1.SetToolTip(TxtProcessQty, "Enter Correct Process Qty")
                    'C1SuperTooltip1.IsBalloon = True
                    'TxtProcessQty.Focus()
                Else
                    C1SuperErrorProvider1.Clear()
                    C1SuperTooltip1.RemoveAll()
                    C1SuperTooltip1.Hide()
                    ''txtscanQty.Text = Val(i.ToString)
                    'TxtScrapQty.Focus()
                End If
                Dr.Close()
            End If
            TxtProcessQty.Focus()
        End If
    End Sub

    'Private Sub txtscrapscan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    Try
    '        If e.KeyCode = Keys.Enter Then
    '            If txtscrapscan.Text <> "" Then
    '                For intcount = 0 To listscrap.Count - 1
    '                    If txtscrapscan.Text = listscrap.Item(intcount) Then
    '                        MsgBox("Already Added Scrap Quantity for this Barcode", MsgBoxStyle.Critical, "BMR")
    '                        txtscrapscan.Text = ""
    '                        Exit Sub
    '                    End If
    '                Next
    '                Dim sqlcmd1 As MySqlCommand
    '                sqlcmd1 = New MySqlCommand("Select * from barcode where carton_serial_no=?cno and product_type='SCR' and status=1 and batch_no=?bno")
    '                AssignConnection(sqlcmd1)
    '                With sqlcmd1
    '                    .Parameters.AddWithValue("?cno", txtscrapscan.Text)
    '                    .Parameters.AddWithValue("?bno", cboBatchno.Text)
    '                End With
    '                Dr = sqlcmd1.ExecuteReader
    '                If Dr.HasRows Then
    '                    While Dr.Read
    '                        listscrap.Add(txtscrapscan.Text)
    '                        TxtScrapQty.Text = Val(TxtScrapQty.Text) + Dr("carton_weight")
    '                    End While
    '                Else
    '                    MsgBox("Invalid Scan", MsgBoxStyle.Critical, "BMR")
    '                End If
    '                'txtscrapscan.Text = ""
    '                Dr.Close()
    '            Else
    '                If TxtScrapQty.Text <> "" Then
    '                    If Val(TxtScrapQty.Text) > Val(txtscanQty.Text) Then
    '                        C1SuperErrorProvider1.SetError(TxtScrapQty, "Scrap quantity Entered Greater than Scan Qty.Recheck Entered Qty")
    '                        C1SuperTooltip1.SetToolTip(TxtScrapQty, "Enter Correct Scrap Qty")
    '                        C1SuperTooltip1.IsBalloon = True
    '                        TxtScrapQty.Focus()
    '                    Else
    '                        C1SuperErrorProvider1.Clear()
    '                        C1SuperTooltip1.RemoveAll()
    '                        C1SuperTooltip1.Hide()
    '                        txtWaste.Text = Val(TxtProcessQty.Text) - Val(txtscanQty.Text) - Val(TxtScrapQty.Text)
    '                        txtWaste.Focus()
    '                    End If
    '                End If
    '            End If
    '        End If

    '    Catch ex As Exception
    '        Dr.Close()
    '    End Try
    'End Sub

    Private Sub txtWaste_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtWaste.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtWaste.Text <> "" Then
                TxtProcessQty.Text = Val(txtWaste.Text) + Val(txtscanQty.Text) + Val(TxtScrapQty.Text)
                btnsave.Focus()
            Else
                If MsgBox("Wastage Entry Empty!!Do you want to save as Nil Waste?", MsgBoxStyle.YesNo, "BMR") = MsgBoxResult.No Then
                    txtWaste.Focus()
                Else
                    txtWaste.Text = ""
                    btnsave.Focus()
                End If
            End If
        End If
    End Sub
End Class