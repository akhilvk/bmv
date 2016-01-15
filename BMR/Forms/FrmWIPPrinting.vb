Public Class FrmWIPPrinting
    Dim Carton_Serial_no As String
    Dim SortId, fullbatch, ExBatch As String
    Dim dtprint As New DataTable
    Public Class barcode
        Public Carton_Serial_no As String
        Public Product As String
        Public Product_code As Integer
        Public Product_type As String
        Public Pur_date As DateTime
        Public sort_Code As Integer
        Public sort As String
        Public pur_loc As Integer
        Public Batch_no As String
        Public Loc_code As Integer
        Public user_code As Integer
        Public packet_size As Integer
        Public Carton_Weight As Decimal
        Public next_Barcode As String
        Public status As Integer
        Public FullBatch_no As String
        Public W_TempCarton As String
    End Class
    Private Sub FrmWIPPrinting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear()
    End Sub
    Public Sub Clear()
        'Dim DT, DT1 As DataTable
        'DT = ReturningDataByQ("SELECT Product_Code,Product_Name FROM dbo.Product_Master WHERE Product_del=0 and Product_type='SFG'")
        'CmbProduct.DataSource = DT
        'CmbProduct.DisplayMember = "Product_Name"
        'CmbProduct.ValueMember = "Product_Code"
        'CmbProduct.SelectedIndex = -1
        LoadCombo(CmbProduct, "SELECT Product_Code,Product_Name FROM Product_Master WHERE Product_type like 'FG%' and Product_del=0 ")

        'DT1 = ReturningDataByQ("SELECT Sort_Code,Sort_Name FROM Sorting_Type")
        'CmbSort.DataSource = DT1
        'CmbSort.DisplayMember = "Sort_Name"
        'CmbSort.ValueMember = "Sort_Code"
        'CmbSort.SelectedIndex = -1
        LoadCombo(CmbSort, "SELECT Sort_Code,Sort_Name FROM Sorting_Type")

        ErrorProvider1.Dispose()

        Dim col As New AutoCompleteStringCollection
        Dr = SelectQuery("SELECT SAP_Code FROM Product_Master WHERE Product_del=0 and Product_type='FG'")
        While Dr.Read
            col.Add(Dr("SAP_Code"))
        End While
        Dr.Close()
        txtSap.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtSap.AutoCompleteCustomSource = col
        txtSap.AutoCompleteMode = AutoCompleteMode.Suggest

        txtSap.Text = ""
        txtBatch.Text = ""
        TxtPack.Text = ""
        TxtQty.Text = ""
        txtWeight.Text = ""
        CmbProduct.Text = ""
        CmbProduct.Focus()
        Try
            If dtprint.Rows.Count > 0 Then
                dtprint.Rows.Clear()
            End If
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub C1Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Clear()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Function validate() As Boolean
        ErrorProvider1.Dispose()
        If CmbProduct.Text.Trim() = "" Then
            'seterr(CmbProduct, "Please Select Valid Product")
            ErrorProvider1.SetError(CmbProduct, "Please Select a Valid Product")
            CmbProduct.Focus()
            Return False
        End If
        If txtSap.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtSap, "Please Enter  Valid Sap Code")
            txtSap.Focus()
            Return False
        End If
        'If CmbSort.Text.Trim() = "" Then
        '    ErrorProvider1.SetError(CmbSort, "Please Select Sort Type")
        '    CmbSort.Focus()
        '    Return False
        'End If
        If txtBatch.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtBatch, "Please Enter Batch No")
            txtBatch.Focus()
            Return False
        End If
        If TxtPack.Text.Trim() = "" Then
            ErrorProvider1.SetError(TxtPack, "Please Enter Pack Size")
            TxtPack.Focus()
            Return False
        End If
        If txtWeight.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtWeight, "Please Enter Carton Weight")
            txtWeight.Focus()
            Return False
        End If
        If TxtQty.Text.Trim() = "" Then
            ErrorProvider1.SetError(TxtQty, "Please Enter Carton Qty")
            TxtQty.Focus()
            Return False
        End If
        If IsNumeric(TxtPack.Text) = False Then
            ErrorProvider1.SetError(TxtPack, "Please Enter Valid Pack Size")
            TxtPack.Focus()
            Return False
        End If
        If IsNumeric(txtWeight.Text) = False Then
            ErrorProvider1.SetError(txtWeight, "Please Enter Valid Carton Weight")
            txtWeight.Focus()
            Return False
        End If
        If IsNumeric(TxtQty.Text) = False Then
            ErrorProvider1.SetError(TxtQty, "Please Enter Valid Quantity")
            TxtQty.Focus()
            Return False
        End If
        If ExBatch = "" Then
            ErrorProvider1.SetError(txtBatch, "Please Enter Valid Batch No")
            txtBatch.Focus()
            Return False
        End If
        Return True
    End Function
    Private Function AddToDt(ByVal objcreator As barcode, ByVal introw As Integer) As DataTable
        If dtprint.Columns.Count = 0 Then
            dtprint.Columns.Add("Carton_Serial_no")
            dtprint.Columns.Add("Product_code")
            dtprint.Columns.Add("Product")
            dtprint.Columns.Add("Product_type")
            dtprint.Columns.Add("Pur_date")
            dtprint.Columns.Add("sort_Code")
            dtprint.Columns.Add("sort")
            dtprint.Columns.Add("pur_loc")
            dtprint.Columns.Add("Batch_no")
            dtprint.Columns.Add("Loc_code")
            dtprint.Columns.Add("packet_size")
            dtprint.Columns.Add("Carton_Weight")
            dtprint.Columns.Add("Full_Batch")
            dtprint.Columns.Add("W_TempCarton")
        End If
        dtprint.Rows.Add()
        dtprint.Rows(introw).Item(0) = objcreator.Carton_Serial_no
        dtprint.Rows(introw).Item(1) = objcreator.Product_code
        dtprint.Rows(introw).Item(2) = objcreator.Product
        dtprint.Rows(introw).Item(3) = objcreator.Product_type
        dtprint.Rows(introw).Item(4) = objcreator.Pur_date
        dtprint.Rows(introw).Item(5) = objcreator.sort_Code
        dtprint.Rows(introw).Item(6) = objcreator.sort
        dtprint.Rows(introw).Item(7) = objcreator.Loc_code
        dtprint.Rows(introw).Item(8) = objcreator.Batch_no
        dtprint.Rows(introw).Item(9) = objcreator.Loc_code
        dtprint.Rows(introw).Item(10) = objcreator.packet_size
        dtprint.Rows(introw).Item(11) = objcreator.Carton_Weight
        dtprint.Rows(introw).Item(12) = objcreator.FullBatch_no
        dtprint.Rows(introw).Item(13) = objcreator.W_TempCarton
    End Function

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim objCreator As New barcode
        'Dim dtprint As DataTable
        Dim QRY As String, SubCarton As String, QRY1 As String = ""
        If validate() Then
            Try
                Dim dttemp As DataTable = ReturningDataByQ("SELECT COUNT(DISTINCT carton_Serial_no )+1000001 No FROM Tbl_WIP_Sub")
                SubCarton = "T" + FrmMain._LocPrefix + dttemp.Rows(0)(0).ToString()
                Dim datetim As DateTime = FormatTo_yyyy_MM_dd(DateTime.Now)
                For intcount = 0 To Val(TxtQty.Text) - 1
                    'FrmMain._LocPrefix = "K"
                    Dim dt As DataTable = ReturningDataByQ("SELECT COUNT(Carton_Serial_no)+10000001 No FROM BARCODE WHERE Loc_Code=" & Loc_Code & "")
                    Carton_Serial_no = "W" + FrmMain._LocPrefix + dt.Rows(0)(0).ToString()
                    fullbatch = ExBatch + FrmMain._LocPrefix
                    'QRY1 = "INSERT INTO Tbl_WIP_Sub (carton_Serial_no,packet_Serial_no,status)VALUES ('" & SubCarton & "','" & Carton_Serial_no & "',0)"
                    'If SaveToDb(QRY1) Then
                    '    QRY1 = QRY1.Replace("'", "|")
                    '    'SaveToDb("INSERT INTO dbo.Sync_Master (Sync_Date,Sync_Query,Location_Code,Status) VALUES('" + datetim + "','" + QRY1 + "'," & Loc_Code & ",0)")
                    'End If
                    QRY = "INSERT INTO Barcode (Carton_Serial_no,Product_code,Product_type,Pur_date,pur_loc,Batch_no,Loc_code,user_code,packet_size,Carton_Weight,status,FullBatch,Sap_code)  VALUES ('" + Carton_Serial_no + "'," & CType(CmbProduct.SelectedItem, itemdata).Value & ",'W',now()," & Loc_Code & ",'" + txtBatch.Text + "'," & Loc_Code & "," & FrmMain._UserCode & "," & TxtPack.Text & "," & txtWeight.Text & ",0,'" & fullbatch & "','" & txtSap.Text & "')"
                    objCreator.Carton_Serial_no = Carton_Serial_no
                    objCreator.Product_code = CType(CmbProduct.SelectedItem, itemdata).Value
                    objCreator.Product = CmbProduct.Text
                    objCreator.Product_type = "W"
                    objCreator.Pur_date = datetim
                    objCreator.sort_Code = 0 'CType(CmbSort.SelectedItem, itemdata).Value
                    objCreator.sort = CmbSort.Text
                    objCreator.Batch_no = txtBatch.Text
                    objCreator.Loc_code = Loc_Code
                    objCreator.packet_size = TxtPack.Text
                    objCreator.Carton_Weight = txtWeight.Text
                    objCreator.FullBatch_no = fullbatch
                    objCreator.W_TempCarton = SubCarton
                    AddToDt(objCreator, intcount)
                    If SaveToDb(QRY) Then
                        QRY = QRY.Replace("'", "|")
                        'SaveToDb("INSERT INTO dbo.Sync_Master (Sync_Date,Sync_Query,Location_Code,Status) VALUES('" + datetim + "','" + QRY + "'," & Loc_Code & ",0)")
                    End If
                    If intcount = Val(TxtQty.Text) - 1 Then
                        If MsgBox("Do You Want to Print Barcodes", MsgBoxStyle.YesNo, "BMR") = MsgBoxResult.Yes Then
                            PrintWip(dtprint, "W")
                            Clear()
                        Else
                            Clear()
                        End If
                    End If
                Next
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub CmbProduct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbProduct.SelectedIndexChanged
        If CmbProduct.Text <> "" Then
            Dr = SelectQuery("select SAP_Code from Product_Master where Product_Code=" & CType(CmbProduct.SelectedItem, itemdata).Value & "")
            If Dr.Read Then
                txtSap.Text = Dr("SAP_Code")
                txtSap.Focus()
            End If
            Dr.Close()
        End If
    End Sub

    Private Sub txtSap_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSap.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtSap.Text = "" Then

                Exit Sub
            End If
            Dim a As String
            Dr = SelectQuery("select Product_Name,Product_type from Product_Master where SAP_Code='" & txtSap.Text.Trim & "'")
            If Dr.Read Then
                Try
                    CmbProduct.Text = Dr("Product_Name")
                    a = Dr("Product_type")
                    If a <> "W" Then
                        CmbProduct.Text = ""
                        seterr(txtSap, "The Product is not a WIP Type")
                        txtSap.Focus()
                    End If
                Catch ex As Exception

                End Try
                SendKeys.Send("{tab}")
            End If
            Dr.Close()
        End If
    End Sub

    Private Sub CmbProduct_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbProduct.KeyDown, txtWeight.KeyDown, TxtPack.KeyDown, txtBatch.KeyDown, CmbSort.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub TxtQty_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtQty.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnsave_Click(sender, e)
        End If
    End Sub

    Private Sub CmbSort_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSort.SelectedIndexChanged
        SendKeys.Send("{tab}")
        Try
            If CmbSort.Text <> "" Then
                Dim dt As DataTable = ReturningDataByQ("SELECT Sort_id FROM Sorting_Type WHERE Sort_Name ='" & CmbSort.Text & "'")
                SortId = dt.Rows(0)(0)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtBatch_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBatch.Leave
        ErrorProvider1.Dispose()
        If txtBatch.Text.Trim() <> "" Then
            Dim dtFBatch As DataTable = ReturningDataByQ("SELECT DISTINCT FullBatch  FROM Barcode WHERE Product_type ='SFG' AND Batch_no ='" + txtBatch.Text + "'")
            If dtFBatch.Rows.Count > 0 Then
                ExBatch = dtFBatch.Rows(0)(0)
            Else
                If ExBatch = "" Then
                    ErrorProvider1.SetError(txtBatch, "Please Enter Valid Batch No")
                    txtBatch.Focus()
                    Exit Sub
                End If
            End If
        End If
    End Sub
End Class
