﻿Public Class frmsfgbarocodeprint
    Dim SortId As String
    Private Sub frmsfgbarocodeprint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ConnectToDB() = False Then
            MsgBox("Connection Error")
        End If
        clr()
    End Sub
    Private Sub clr()
        txtsap_code.Clear()
        ErrorProvider1.Dispose()
        LoadCombo(cmbproduct, "SELECT Product_Code,Product_Name FROM Product_Master WHERE Product_del=0 and Product_type='SFG'")
        'LoadCombo(cmbsorttype, "SELECT Sort_Code,Sort_Name FROM Sorting_Type")
        Dim col As New AutoCompleteStringCollection
        Dr = SelectQuery("SELECT SAP_Code FROM Product_Master WHERE Product_del=0 and Product_type='SFG'")
        While Dr.Read
            col.Add(Dr("SAP_Code"))
        End While
        Dr.Close()
        txtsap_code.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtsap_code.AutoCompleteCustomSource = col
        txtsap_code.AutoCompleteMode = AutoCompleteMode.Suggest
        txtbatch_no.Clear()
        txtcarton_wg.Clear()
        txtpack_size.Clear()

        txtcarton_weight.Clear()
        cmbproduct.Text = ""
        cmbsorttype.Text = ""
        cmbproduct.Focus()
    End Sub

    Private Sub cmbproduct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbproduct.SelectedIndexChanged
        If cmbproduct.Text <> "" Then
            Dr = SelectQuery("select SAP_Code from Product_Master where Product_Code=" & CType(cmbproduct.SelectedItem, itemdata).Value & "")
            If Dr.Read Then
                txtsap_code.Text = Dr("SAP_Code")
            End If
            Dr.Close()
        End If
    End Sub

    Private Sub txtsap_code_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsap_code.KeyDown
        Dim strprod As String
        If e.KeyCode = Keys.Enter Then
            If cmbproduct.Text <> "" Then
                If MsgBox("You have Already Selected a Product? do you want to Replace it?", MsgBoxStyle.YesNo, "BMR") = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
            If txtsap_code.Text = "" Then
                MsgBox("Please Enter SAP Code")
                Exit Sub
            End If
            Dim a As String
            Try
                Dr = SelectQuery("select Product_Name,Product_type from Product_Master where SAP_Code='" & txtsap_code.Text.Trim & "'")
                If Dr.Read Then
                    strprod = Dr("Product_Name")
                    a = Dr("Product_type")
                    If a <> "SFG" Then
                        cmbproduct.Text = ""
                        ErrorProvider1.SetError(txtsap_code, "The Product is not a SFG Type")
                        txtsap_code.Focus()
                    End If
                    Dr.Close()
                End If
                cmbproduct.Text = strprod
                cmbproduct.Focus()
                SendKeys.Send("{ENTER}")
                txtbatch_no.Focus()
            Catch ex As Exception
                txtsap_code.Text = ""
                'Dr.Close()
            End Try
            Dr.Close()
            txtbatch_no.Focus()
        End If
    End Sub

    Private Sub cmbproduct_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbproduct.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cmbproduct.Text <> "" Then
                txtbatch_no.Focus()
            End If
        End If
    End Sub

    Private Sub cmbsorttype_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbsorttype.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cmbsorttype.Text <> "" Then
                'txtbatch_no.Focus()
                txtcarton_weight.Focus()
            End If
        End If
    End Sub

    Private Sub txtbatch_no_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbatch_no.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtbatch_no.Text <> "" Then
                txtcarton_weight.Focus()
            End If
        End If
    End Sub

    Private Sub txtpack_size_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpack_size.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtpack_size.Text <> "" Then
                txtcarton_weight.Focus()
            End If
        End If
    End Sub

    Private Sub txtcarton_weight_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcarton_weight.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtcarton_weight.Text <> "" Then
                txtcarton_wg.Focus()
            End If
        End If
    End Sub

    Private Sub txtcarton_wg_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcarton_wg.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtcarton_wg.Text <> "" Then
                btnsave_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        ErrorProvider1.Dispose()
        If StringTextBoxValidation("Product", cmbproduct, txtsap_code) = True Then Exit Sub
        If StringTextBoxValidation("SAP CODE", txtsap_code, cmbsorttype) = True Then Exit Sub
        'If StringTextBoxValidation("SORT TYPE", cmbsorttype, txtbatch_no) = True Then Exit Sub
        If StringTextBoxValidation("BATCH NO", txtbatch_no, txtpack_size) = True Then Exit Sub
        'If StringTextBoxValidation("PACK SIZE", txtpack_size, txtcarton_weight) = True Then Exit Sub
        If StringTextBoxValidation("CARTON WEIGHT", txtcarton_weight, txtcarton_wg) = True Then Exit Sub
        If StringTextBoxValidation("Quantity", txtcarton_wg, txtcarton_wg) = True Then Exit Sub
        If IsNumeric(txtcarton_wg.Text) = False Then
            ErrorProvider1.SetError(txtcarton_weight, "Please Enter Valid Quantity")
            Exit Sub
        End If
        'If IsNumeric(txtpack_size.Text) = False Then
        '    ErrorProvider1.SetError(txtpack_size, "Please Enter Valid Pack Size")
        '    Exit Sub
        'End If
        If IsNumeric(txtcarton_weight.Text) = False Then
            ErrorProvider1.SetError(txtcarton_weight, "Please Enter Valid Carton Weight")
            Exit Sub
        End If
        If ConnectToDB(True) = False Then
            MsgBox("Connection Error")
        End If
        Dim begintrn As Boolean = False
        Try
            BeginTransaction()
            begintrn = True
            Dim ReadAllText As String = ""
            Dim StringBuilder As String = ""
            'and Product_code=" & CType(cmbproduct.SelectedItem, itemdata).Value & " 
            Dim dt As DataTable = ReturningDataByQ("SELECT  Batch_no No FROM barcode WHERE Batch_no='" & txtbatch_no.Text & "' AND Product_type='SFG' GROUP BY Product_code;")
            Dim dtcount As Int16 = dt.Rows.Count
            dtcount = dtcount + 1
            If dtcount = 100 Then
                MsgBox("Batch Limitted")
                txtbatch_no.Focus()
                Exit Sub
            End If
            Dim a As String = dtcount.ToString()
            
            For i As Integer = 0 To Val(txtcarton_wg.Text) - 1
                If a.Length = 1 Then
                    a = "0" + a
                End If
                ReadAllText = System.IO.File.ReadAllText(Application.StartupPath & "/Barcode.txt")
                Dim Serial_no As String = ""
                Dr = SelectQuery("SELECT IFNULL( MAX( SUBSTRING( carton_serial_no, 3, LENGTH( carton_serial_no ) ) ) , 10000000 ) +1 FROM  `barcode` WHERE Loc_Code=" + Loc_Code + "")
                If Dr.Read Then
                    Serial_no = Dr(0)
                End If
                Dr.Close()
                Loc_Prefix = FrmMain._LocPrefix
                Serial_no = "C" & Loc_Prefix & Serial_no
                Dim datestr As String = FormatTo_yyyy_MM_dd(DateTime.Now)
                datestr &= " " & Format(DateTime.Now, "HH:mm:ss")

                Dim FullBatch As String = txtbatch_no.Text + a + Loc_Prefix

                'Dim FullBatch As String = txtbatch_no.Text + SortId + Loc_Prefix

                Dim query As String = "insert into barcode(Carton_Serial_no,Product_code,Product_type,Pur_date,sort_code,pur_loc" & _
                             ",Batch_no,Loc_code,user_code,packet_size,Carton_Weight,status,Sap_Code,FullBatch) values('" & Serial_no & "'," & _
                             "" & CType(cmbproduct.SelectedItem, itemdata).Value & ",'SFG','" & datestr & "'," & _
                             "0," & Loc_Code & ",'" & txtbatch_no.Text & "'," & _
                             "" & Loc_Code & "," & User_Code & ",0," & txtcarton_weight.Text & ",0,'" & txtsap_code.Text & "','" & FullBatch & "')"

                ExecuteQuery(query)
                'synctable(query)
                ReadAllText = ReadAllText.Replace("[barcode]", Serial_no)
                ReadAllText = ReadAllText.Replace("[barcode1]", Serial_no)
                ReadAllText = ReadAllText.Replace("[name]", CType(cmbproduct.SelectedItem, itemdata).Description)
                ReadAllText = ReadAllText.Replace("[name1]", txtbatch_no.Text & "    wt:" & txtcarton_weight.Text)
                StringBuilder &= ReadAllText & vbCrLf
            Next
            CommitTransaction()
            RawPrinterHelper.SendStringToPrinter(DefaultPrinterName, StringBuilder)
                    clr()
        Catch ex As Exception
            If begintrn = True Then
                RollBackTransaction()
            End If
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        clr()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub cmbsorttype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsorttype.SelectedIndexChanged
        SendKeys.Send("{tab}")
        Try
            If cmbsorttype.Text <> "" Then
                Dim dt As DataTable = ReturningDataByQ("SELECT Sort_id FROM Sorting_Type WHERE Sort_Name ='" & cmbsorttype.Text & "'")
                SortId = dt.Rows(0)(0)
            End If
        Catch ex As Exception
            cmbsorttype.Text = ""
        End Try
    End Sub
End Class