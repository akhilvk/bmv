Imports System.Data.SqlClient
Imports System.IO
Imports System.IO.Ports
Module Mdl_BMR
    '-----------------------
    Public SettingsLineCode_Mdl As String = ""
    'Public UsLineCode_Mdl As String = ""
    'Public UsLineName_Mdl As String = ""
    'Public UsLinePrefix_Mdl As String = ""
    'Public UsLineMC As String = "NA"
    Public Const PalletNoConstLength As Integer = 11

    'Always Multiply The Standard Time With This Constant for Production Scheduling
    'Here The 85 is the percentage of Production Efficiency
    'If production Efficiency is 70 then The Value should be change to (100/70)
    Public Const ProductionEfficiency As Double = (100 / 85)
    Public Const MinPrevOrderQty As Double = 100
    'Public SFGLeadDays As Int16 = 3
    Public SFGLeadDays As Int16 = 1

    Public Structure StStock
        Dim ItemCode As String
        Dim ItemName As String
        Dim Warehouse As String
        Dim BatchNum As String
        Dim BatchQty As Double
    End Structure
    Public Structure MatStock
        Dim ItemCode As String
        Dim MatQty As Double
    End Structure
    Public Enum EnmSerialNoStatus
        BoxNotFilled = -2
        PalletNotFilled = -1
        PalletNoPrinted = 0
        PalletNoScanned = 1
        PalletNoUploaded = 2
    End Enum

    'Public Function SearchItem(ByVal ArgPartNo As String) As clsItemMaster
    '    Dr = SelectQuery("EXEC EMR_ItemMasterSingle '" & ArgPartNo & "'")
    '    If Dr.Read Then
    '        Dim Item As New clsItemMaster
    '        Item.PartNo = Dr("Part No").ToString
    '        Item.CustPartNo = Dr("Customer Part No").ToString
    '        Item.CustCode = Dr("Customer Code").ToString
    '        Item.CustName = Dr("Customer Name").ToString
    '        Item.PartDesc = Dr("Description").ToString
    '        Item.Uom = Dr("UOM").ToString
    '        Item.StdBoxQnty = Dr("Standard Box Quantity").ToString
    '        Item.StdPalletQnty = Dr("Standard Pallet Quantity").ToString
    '        Item.MaterialType = Dr("Material Type").ToString
    '        Item.PrintMethod = Dr("Print Method").ToString
    '        Item.ProgramName = Dr("Program Name").ToString
    '        Item.Cavity = Dr("Cavity").ToString
    '        Dr.Close()
    '        Return Item
    '    Else
    '        Dr.Close()
    '        Return Nothing
    '    End If
    'End Function
    'Public Function LoadComboItem(ByVal ArgCombo As ComboBox) As Integer
    '    ArgCombo.Items.Clear()
    '    ArgCombo.SelectedIndex = -1
    '    ArgCombo.Text = ""
    '    Dim LstofItems As New List(Of clsItemMaster)
    '    Dr = SelectQuery("EXEC EMR_ItemMaster")
    '    While Dr.Read
    '        Dim ObjItem As New clsItemMaster
    '        ObjItem.PartNo = Dr("Part No").ToString
    '        ObjItem.CustPartNo = Dr("Customer Part No").ToString
    '        ObjItem.CustCode = Dr("Customer Code").ToString
    '        ObjItem.CustName = Dr("Customer Name").ToString
    '        ObjItem.PartDesc = Dr("Description").ToString
    '        ObjItem.Uom = Dr("UOM").ToString
    '        ObjItem.StdBoxQnty = Dr("Standard Box Quantity").ToString
    '        ObjItem.StdPalletQnty = Dr("Standard Pallet Quantity").ToString
    '        ObjItem.MaterialType = Dr("Material Type").ToString
    '        ObjItem.PrintMethod = Dr("Print Method").ToString
    '        ObjItem.ProgramName = Dr("Program Name").ToString
    '        ObjItem.Cavity = Dr("Cavity").ToString
    '        LstofItems.Add(ObjItem)
    '    End While
    '    Dr.Close()
    '    ArgCombo.Items.AddRange(LstofItems.ToArray)

    'End Function
    Public Function GetLstViewObject(ByVal CntofColumns As Integer) As ListViewItem
        Dim ObjLstItem As New ListViewItem("")
        For i As Int16 = 1 To CntofColumns
            ObjLstItem.SubItems.Add("")
        Next
        Return ObjLstItem
    End Function
    Public Function GetLstViewObject(ByVal ArgLst As ListView) As ListViewItem
        Dim ObjLstItem As New ListViewItem("")
        For i As Int16 = 1 To ArgLst.Columns.Count
            ObjLstItem.SubItems.Add("")
        Next
        Return ObjLstItem
    End Function
    'Public Sub ErrorMessage(ByVal mess As String)
    '    ExecuteQuery("insert into Err_log values(" & User_Code & ",'" + mess.ToString + "','" + Environment.MachineName + "','" + Format(Now.Date, "yyyy-MM-dd") + "',0)")
    'End Sub
    Public Function ReturnItemCode(ByVal Combo As ComboBox)
        Return Combo.SelectedItem.PartNo
    End Function
    Public Function ReturnItemDesc(ByVal Combo As ComboBox)
        Return Combo.SelectedItem.PartDesc
    End Function

    Public Sub SetMyComboItem(ByVal iID As Integer, ByVal Combo As ComboBox)
        For i As Integer = 0 To Combo.Items.Count - 1
            If CType(Combo.Items(i), itemdata).Value = iID Then
                Combo.SelectedIndex = i
                Exit Sub
            End If
        Next
    End Sub



    Public Function PrintSerialNo(ByVal ArgSerialNo As String) As Integer

    End Function
    Public Function PrintBoxNo(ByVal ArgBoxNo As String, ByVal BoxId As String, ByVal LineId As String, ByVal WOID As String) As Integer
        Dim _Path As String = Application.StartupPath & "\FGBOX.txt"
        Dim DPL As String = "", printer As String = ""
        DPL = System.IO.File.ReadAllText(_Path)
        printer = DefaultPrinterName()
        Dr = SelectQuery("SELECT DISTINCT dbo.WOMT.DocNum, dbo.PLMT.ItemName, dbo.PRD_MN.BOXID, dbo.PLMT.ItemCode, SUM(dbo.PRD_MN.QTY) AS Qnty," & _
             "dbo.PRD_MN.LI_PX + 'B' + CONVERT(varchar(50), dbo.PRD_MN.BOXID) AS BOXNO, dbo.PRD_MN.LI_PX " & _
             "FROM dbo.PLMT INNER JOIN dbo.WOMT ON dbo.PLMT.PlanNo = dbo.WOMT.PlanNo INNER JOIN dbo.PRD_MN ON dbo.WOMT.ID = dbo.PRD_MN.WOMT_ID " & _
             " WHERE dbo.PRD_MN.BOXID = '" + BoxId.ToString + "' and PRD_MN.SERIAL_DEL=0 and PRD_MN.LI_ID=" & LineId & " and WOMT.ID=" & WOID & " GROUP BY dbo.WOMT.DocNum, dbo.PLMT.ItemName, dbo.PRD_MN.BOXID, dbo.PLMT.ItemCode, dbo.PRD_MN.LI_PX ")
        If Dr.Read Then
            DPL = DPL.Replace("[WO]", Trim(Dr("DOCNUM")))
            DPL = DPL.Replace("[CPNO]", Dr.Item("ITEMCODE"))

            DPL = DPL.Replace("[BOX]", ArgBoxNo)
            DPL = DPL.Replace("[BOX1]", ArgBoxNo)

            DPL = DPL.Replace("[IDSC]", Dr.Item("ITEMNAME"))
            DPL = DPL.Replace("[QTY]", Dr.Item("QNTY"))
            RawPrinterHelper.SendStringToPrinter(DefaultPrinterName, DPL)
        End If
        Dr.Close()
    End Function
    Public Function PrintPalletNo(ByVal ArgPalletNo As String, ByVal PalletId As String, ByVal LineId As String, ByVal WOID As String) As Integer
        Dim _Path As String = Application.StartupPath & "\FGPALLET.txt"
        Dim DPL As String = "", printer As String = ""
        DPL = System.IO.File.ReadAllText(_Path)
        printer = DefaultPrinterName()
        Dr = SelectQuery("SELECT DISTINCT dbo.WOMT.DocNum, dbo.PLMT.ItemName, dbo.PRD_MN.PALLETID, dbo.PLMT.ItemCode, SUM(dbo.PRD_MN.QTY) AS Qnty," & _
             "dbo.PRD_MN.LI_PX + 'P' + CONVERT(varchar(50), dbo.PRD_MN.PALLETID) AS BOXNO, dbo.PRD_MN.LI_PX " & _
             "FROM dbo.PLMT INNER JOIN dbo.WOMT ON dbo.PLMT.PlanNo = dbo.WOMT.PlanNo INNER JOIN dbo.PRD_MN ON dbo.WOMT.ID = dbo.PRD_MN.WOMT_ID " & _
             " WHERE dbo.PRD_MN.PALLETID = '" + PalletId.ToString + "' and PRD_MN.SERIAL_DEL=0 and PRD_MN.LI_ID=" & LineId & " and WOMT.ID=" & WOID & " GROUP BY dbo.WOMT.DocNum, dbo.PLMT.ItemName, dbo.PRD_MN.PALLETID, dbo.PLMT.ItemCode, dbo.PRD_MN.LI_PX ")
        If Dr.Read Then
            DPL = DPL.Replace("[WO]", Trim(Dr("DOCNUM")))
            DPL = DPL.Replace("[CPNO]", Dr.Item("ITEMCODE"))
            DPL = DPL.Replace("[PAL]", ArgPalletNo)
            DPL = DPL.Replace("[PAL1]", ArgPalletNo)

            DPL = DPL.Replace("[IDSC]", Dr.Item("ITEMNAME"))
            DPL = DPL.Replace("[QTY]", Dr.Item("QNTY"))
            RawPrinterHelper.SendStringToPrinter(DefaultPrinterName, DPL)
        End If
        Dr.Close()
    End Function
    Public Function Printline(ByVal Arglinename As String, ByVal Arglinecode As String) As Integer
        Dim _Path As String = Application.StartupPath & "\Line.txt"
        Dim DPL As String = "", printer As String = ""
        DPL = System.IO.File.ReadAllText(_Path)
        printer = DefaultPrinterName()
        DPL = DPL.Replace("[linebarcode]", Arglinecode)
        DPL = DPL.Replace("[linebarcode1]", Arglinename)
        RawPrinterHelper.SendStringToPrinter(DefaultPrinterName, DPL)
    End Function
    Public Function PrintResource(ByVal Argresname As String, ByVal Argrescode As String) As Integer
        Dim _Path As String = Application.StartupPath & "\Res.txt"
        Dim DPL As String = "", printer As String = ""
        DPL = System.IO.File.ReadAllText(_Path)
        printer = DefaultPrinterName()
        DPL = DPL.Replace("[resbarcode]", Argrescode)
        DPL = DPL.Replace("[resbarcode1]", Argresname)
        RawPrinterHelper.SendStringToPrinter(DefaultPrinterName, DPL)
    End Function
End Module
