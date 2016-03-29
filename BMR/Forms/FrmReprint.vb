Imports MySql.Data.MySqlClient
Public Class FrmReprint

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim _path As String
        If TextBox1.Text <> "" Then
            If TextBox1.Text.Substring(0, 1) = "C" Then
                Dim dt1 As DataTable = ReturningDataByQ("Select * from barcode A inner join product_master B on A.Product_code=B.product_code  where A.carton_serial_no='" & TextBox1.Text & "' and A.Product_type='SFG'")
                If dt1.Rows.Count = 0 Then
                    MsgBox("No barcode exist for this No", MsgBoxStyle.Critical, "BMR")
                    Exit Sub
                Else
                    _Path = Application.StartupPath & "\barcode.txt"

                    For i As Integer = 0 To dt1.Rows.Count - 1
                        Dim DPL As String = ""
                        DPL = System.IO.File.ReadAllText(_path)
                        DPL = DPL.Replace("[barcode]", dt1.Rows(i)("Carton_Serial_no"))
                        DPL = DPL.Replace("[barcode1]", dt1.Rows(i)("Carton_Serial_no"))
                        DPL = DPL.Replace("[name]", dt1.Rows(i)("Product_name"))
                        DPL = DPL.Replace("[name1]", dt1.Rows(i)("Batch_No") & "    wt:" & dt1.Rows(i)("Carton_Weight"))
                        RawPrinterHelper.SendStringToPrinter(DefaultPrinterName(), DPL)
                    Next
                End If
            ElseIf TextBox1.Text.Substring(0, 1) = "W" Then
                Dim dt1 As DataTable = ReturningDataByQ("Select * from barcode A inner join product_master B on A.Product_code=B.product_code  where A.carton_serial_no='" & TextBox1.Text & "' and A.Product_type='W'")
                If dt1.Rows.Count = 0 Then
                    MsgBox("No barcode exist for this No", MsgBoxStyle.Critical, "BMR")
                    Exit Sub
                Else
                    _path = Application.StartupPath & "\barcode.txt"

                    For i As Integer = 0 To dt1.Rows.Count - 1
                        Dim DPL As String = ""
                        DPL = System.IO.File.ReadAllText(_path)
                        DPL = DPL.Replace("[barcode]", dt1.Rows(i)("Carton_Serial_no"))
                        DPL = DPL.Replace("[barcode1]", dt1.Rows(i)("Carton_Serial_no"))
                        DPL = DPL.Replace("[name]", dt1.Rows(i)("Product_name"))
                        Dim a As Decimal = dt1.Rows(i)("Carton_Weight")
                        Dim b As Decimal = dt1.Rows(i)("packet_size")
                        Dim c As Decimal
                        c = a * 1000 / b
                        DPL = DPL.Replace("[name1]", dt1.Rows(i)("Batch_No") & "    P Size:" & c & "X" & b)
                        RawPrinterHelper.SendStringToPrinter(DefaultPrinterName(), DPL)
                    Next
                End If
            ElseIf TextBox1.Text.Substring(0, 1) = "F" Then
                Dim dt1 As DataTable = ReturningDataByQ("Select * from barcode where carton_serial_no='" & TextBox1.Text & "' and Product_type='FG'")
                If dt1.Rows.Count = 0 Then
                    MsgBox("No barcode exist for this No", MsgBoxStyle.Critical, "BMR")
                    Exit Sub
                Else
                    Dim FCartn As String = ""
                    _path = Application.StartupPath & "\Final.txt"
                    For i As Integer = 0 To dt1.Rows.Count - 1
                        Dim DPL As String = ""
                        If i = 0 Or FCartn <> dt1.Rows(i)("Carton_Serial_no") Then
                            FCartn = dt1.Rows(i)("Carton_Serial_no")
                            DPL = System.IO.File.ReadAllText(_path)
                            DPL = DPL.Replace("[barcode]", dt1.Rows(i)("Carton_Serial_no"))
                            DPL = DPL.Replace("[barcode1]", dt1.Rows(i)("Carton_Serial_no"))
                            'DPL = DPL.Replace("[NAME]", dt.Rows(i)("Product"))
                            DPL = DPL.Replace("[NAME1]", dt1.Rows(i)("Batch_No") & "    wt:" & dt1.Rows(i)("Carton_Weight"))
                        End If
                        RawPrinterHelper.SendStringToPrinter(DefaultPrinterName(), DPL)
                    Next
                End If
            ElseIf TextBox1.Text.Substring(0, 1) = "P" Then
                Dim dt1 As DataTable = ReturningDataByQ("Select * from Tbl_finalPack_sub   where Packet_serial_no='" & TextBox1.Text & "'")
                If dt1.Rows.Count = 0 Then
                    MsgBox("No barcode exist for this No", MsgBoxStyle.Critical, "BMR")
                    Exit Sub
                Else
                    For j As Integer = 0 To dt1.Rows.Count - 1
                        _path = Application.StartupPath & "\Final.txt"
                        Dim DPL1 As String = ""
                        DPL1 = System.IO.File.ReadAllText(_path)
                        DPL1 = DPL1.Replace("[barcode]", dt1.Rows(j)("Packet_Serial_no"))
                        DPL1 = DPL1.Replace("[barcode1]", dt1.Rows(j)("Packet_Serial_no"))
                        'DPL1 = DPL1.Replace("[NAME]", dt.Rows(j)("Product"))
                        DPL1 = DPL1.Replace("[NAME1]", dt1.Rows(j)("Batch_no"))

                        RawPrinterHelper.SendStringToPrinter(DefaultPrinterName(), DPL1)
                    Next
                End If
            End If
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class