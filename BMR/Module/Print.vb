Imports System.Data.SqlClient
Module Print
    Public Function PrintWip(ByVal dt As DataTable, ByVal FrmIndicator As String) As Integer
        Dim _Path As String = Application.StartupPath & "\barcode.txt"

        For i As Integer = 0 To dt.Rows.Count - 1
            Dim DPL As String = ""
            DPL = System.IO.File.ReadAllText(_Path)
            DPL = DPL.Replace("[barcode]", dt.Rows(i)("Carton_Serial_no"))
            DPL = DPL.Replace("[barcode1]", dt.Rows(i)("Carton_Serial_no"))
            DPL = DPL.Replace("[name]", dt.Rows(i)("Product"))
            If FrmIndicator = "W" Then
                Dim a As Decimal = dt.Rows(i)("Carton_Weight")
                Dim b As Decimal = dt.Rows(i)("packet_size")
                Dim c As Decimal
                c = a * 1000 / b
                DPL = DPL.Replace("[name1]", dt.Rows(i)("Batch_No") & "    P Size:" & c & "X" & b)
            Else
                DPL = DPL.Replace("[name1]", dt.Rows(i)("Batch_No") & "    wt:" & dt.Rows(i)("Carton_Weight"))
            End If

            RawPrinterHelper.SendStringToPrinter(DefaultPrinterName(), DPL)
            If FrmIndicator = "Final" Then
                For j As Integer = 0 To dt.Rows.Count - 1
                    Dim DPL1 As String = ""
                    DPL1 = System.IO.File.ReadAllText(_Path)
                    DPL1 = DPL1.Replace("[barcode]", dt.Rows(j)("Packet_Serial_no"))
                    DPL1 = DPL1.Replace("[barcode1]", dt.Rows(j)("Packet_Serial_no"))
                    DPL1 = DPL1.Replace("[name]", dt.Rows(j)("Product"))
                    DPL1 = DPL1.Replace("[name1]", dt.Rows(j)("F_Batch") & "    wt:" & dt.Rows(j)("Carton_Weight"))

                    RawPrinterHelper.SendStringToPrinter(DefaultPrinterName(), DPL1)
                Next
                Exit For
            End If
        Next


    End Function
    Public Function DefaultPrinterName() As String
        Dim oPS As New System.Drawing.Printing.PrinterSettings
        Try
            DefaultPrinterName = oPS.PrinterName
        Catch ex As System.Exception
            DefaultPrinterName = ""
        Finally
            oPS = Nothing
        End Try
    End Function
End Module
