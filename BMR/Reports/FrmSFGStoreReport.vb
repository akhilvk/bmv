Imports MySql.Data.MySqlClient

Public Class FrmSFGStoreReport
    Dim PType, productCode, ProductType As String
    Dim FDate, TDate As DateTime
    Public Sub Clear()
        dtpFDate.Value = DateTime.Now
        dtpFDate.Value = DateTime.Now
        LoadProduct()
        CmbProduct.SelectedValue = -1
        CmbProduct.Text = "All"
        'cmbprotype.SelectedValue = -1
        'cmbprotype.Text = "All"
        dtpFDate.Focus()
    End Sub
    Public Sub LoadProduct()
        Dim dt As DataTable
        PType = ""
        'If cmbprotype.Text = "" Or cmbprotype.Text = "All" Then
        '    PType = ""
        'Else
        '    PType = cmbprotype.Text
        '    If PType = "WIP" Then
        '        PType = "W"
        '    End If
        'End If
        'dt = ReturningDataBySp(DateTime.Now, DateTime.Now, 1, "SFG", "")
        dt = ReturningDataByQ("SELECT DISTINCT  Product_Code,Product_Name FROM Product_Master  WHERE (Product_type='SFG') AND  Product_del=0 ")
        CmbProduct.DataSource = dt
        CmbProduct.DisplayMember = "Product_Name"
        CmbProduct.ValueMember = "Product_Code"
        CmbProduct.SelectedValue = -1
        CmbProduct.Text = "All"
    End Sub
    Private Sub FrmProductionReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear()
    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        Clear()
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub cmbprotype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadProduct()
    End Sub
    Public Sub SetValues()
        FDate = dtpFDate.Value
        TDate = DtpTDate.Value
        If CmbProduct.Text = "All" Or CmbProduct.Text = "" Then
            productCode = ""
        Else
            productCode = CmbProduct.SelectedValue
        End If
        'If cmbprotype.Text = "All" Or cmbprotype.Text = "" Then
        '    ProductType = ""
        'Else
        '    ProductType = cmbprotype.Text
        '    If ProductType = "WIP" Then
        '        ProductType = "W"
        '    End If
        'End If
    End Sub
    Private Sub BtnSummary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSummary.Click
        SetValues()
        Dim dtprint As DataTable
        Dim a As String = Format(FDate, "yyyy-MM-dd")
        Dim b As String = Format(TDate, "yyyy-MM-dd")
        'dtprint = ReturningDataBySp(FDate, TDate, 3, "SFG", productCode)
        dtprint = ReturningDataByQ("SELECT A.store_date,A.carton_Serial_no,A.Product_Code,B.Product_Name,B.SAP_Code,B.Product_Type,C.Location_Name ,A.batch_no " & _
  ",D.User_Name,E.Pur_date,F.Sort_Name,E.packet_size ,E.Carton_Weight  FROM Tbl_SFGStorage A " & _
  "LEFT OUTER JOIN Product_Master B ON B.Product_Code = A.Product_Code  " & _
  "LEFT OUTER JOIN Location_Master C ON A.Loc_Code=C.Location_Code  " & _
  "LEFT OUTER JOIN Tbl_UserMaster D ON D.User_Code=A.usercode " & _
  "LEFT OUTER JOIN Barcode E ON A.carton_Serial_no =E.Carton_Serial_no " & _
  "LEFT OUTER JOIN Sorting_Type F ON F.Sort_Code =E.sort_Code " & _
  "WHERE (B.Product_Type  ='SFG') AND  ('" & productCode & "'='' OR A.Product_code  ='" & productCode & "') AND  " & _
  " (CAST(A.store_date AS DATE)  BETWEEN CAST('" & a & "' AS DATE) AND  CAST('" & b & "' AS DATE))")
        If dtprint.Rows.Count > 0 Then
            Dim objcrp As New CrpSFGStorageSummary()
            objcrp.SetDataSource(dtprint)
            objcrp.SetParameterValue("FDate", FDate)
            objcrp.SetParameterValue("TDate", TDate)
            objcrp.SetParameterValue("RptName", " SFG Storage Summary Report ")
            Dim objviewer As New FrmRptViewer()
            objviewer.CrystalReportViewer1.ReportSource = objcrp
            objviewer.WindowState = FormWindowState.Maximized
            objviewer.Show()
        Else
            MsgBox("NO Report within given Criteria", MsgBoxStyle.OkOnly, "Baby Marine Retail")
        End If
    End Sub

    Private Sub BtnDetailed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDetailed.Click
        SetValues()
        Dim dtprint As DataTable
        'dtprint = ReturningDataBySp(FDate, TDate, 3, "SFG", productCode)
        Dim a As String = Format(FDate, "yyyy-MM-dd")
        Dim b As String = Format(TDate, "yyyy-MM-dd")
        'dtprint = ReturningDataBySp(FDate, TDate, 3, "SFG", productCode)
        dtprint = ReturningDataByQ("SELECT A.store_date,A.carton_Serial_no,A.Product_Code,B.Product_Name,B.SAP_Code,B.Product_Type,C.Location_Name ,A.batch_no " & _
  ",D.User_Name,E.Pur_date,F.Sort_Name,E.packet_size ,E.Carton_Weight  FROM Tbl_SFGStorage A " & _
  "LEFT OUTER JOIN Product_Master B ON B.Product_Code = A.Product_Code  " & _
  "LEFT OUTER JOIN Location_Master C ON A.Loc_Code=C.Location_Code  " & _
  "LEFT OUTER JOIN Tbl_UserMaster D ON D.User_Code=A.usercode " & _
  "LEFT OUTER JOIN Barcode E ON A.carton_Serial_no =E.Carton_Serial_no " & _
  "LEFT OUTER JOIN Sorting_Type F ON F.Sort_Code =E.sort_Code " & _
  "WHERE (B.Product_Type  ='SFG') AND  ('" & productCode & "'='' OR A.Product_code  ='" & productCode & "') AND  " & _
  " (CAST(A.store_date AS DATE)  BETWEEN CAST('" & a & "' AS DATE) AND  CAST('" & b & "' AS DATE))")
        If dtprint.Rows.Count > 0 Then
            Dim objcrp As New CrpSFGStorageDetailed()
            objcrp.SetDataSource(dtprint)
            objcrp.SetParameterValue("FDate", FDate)
            objcrp.SetParameterValue("TDate", TDate)
            objcrp.SetParameterValue("RptName", "SFG Storage Detailed Report ")
            Dim objviewer As New FrmRptViewer()
            objviewer.CrystalReportViewer1.ReportSource = objcrp
            objviewer.WindowState = FormWindowState.Maximized
            objviewer.Show()
        Else
            MsgBox("NO Report within given Criteria", MsgBoxStyle.OkOnly, "Baby Marine Retail")
        End If
    End Sub
End Class