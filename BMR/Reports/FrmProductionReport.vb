Public Class FrmProductionReport
    Dim PType, productCode, ProductType As String
    Dim FDate, TDate As DateTime
    Public Sub Clear()
        dtpFDate.Value = DateTime.Now
        dtpFDate.Value = DateTime.Now
        LoadProduct()
        CmbProduct.SelectedValue = -1
        CmbProduct.Text = "All"
        cmbprotype.SelectedValue = -1
        cmbprotype.Text = "All"
        dtpFDate.Focus()
    End Sub
    Public Sub LoadProduct()
        Dim dt As DataTable
        PType = ""
        If cmbprotype.Text = "" Or cmbprotype.Text = "All" Then
            PType = ""
        Else
            PType = cmbprotype.Text
            If PType = "WIP" Then
                PType = "W"
            End If
        End If
        'dt = ReturningDataBySp(DateTime.Now, DateTime.Now, 1, PType, "")
        dt = ReturningDataByQ("SELECT DISTINCT  Product_Code,Product_Name FROM Product_Master  WHERE ('" & PType & "' ='' OR Product_type   ='" & PType & "') AND  Product_del=0 ")
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

    Private Sub cmbprotype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbprotype.SelectedIndexChanged
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
        If cmbprotype.Text = "All" Or cmbprotype.Text = "" Then
            ProductType = ""
        Else
            ProductType = cmbprotype.Text
            If ProductType = "WIP" Then
                ProductType = "W"
            End If
        End If
    End Sub
    Private Sub BtnSummary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSummary.Click
        SetValues()
        Dim dtprint As DataTable
        'dtprint = ReturningDataBySp(FDate, TDate, 2, ProductType, productCode)
        'FDate = Format(FDate, "yyyy-MM-dd")
        Dim a As String = Format(FDate, "yyyy-MM-dd")
        Dim b As String = Format(TDate, "yyyy-MM-dd")
        dtprint = ReturningDataByQ("SELECT A.Carton_Serial_no ,B.Product_Code,B.Product_Name,A.Sap_Code,CASE WHEN  A.Product_type='W' THEN 'WIP' ELSE A.Product_type  END AS Product_type  ,A.Pur_date,C.Sort_Name " & _
  ",A.Batch_no,D.Location_Name Pur_Loc,E.Location_Name Loc_Name,CASE WHEN A.FullBatch<>''THEN A.FullBatch ELSE A.Batch_no END AS FullBatch  ,F.User_Name,A.packet_size,A.Carton_Weight,A.status" & _
  ",G.packet_Serial_no" & _
  " FROM Barcode A " & _
  "LEFT OUTER JOIN Product_Master B ON B.Product_Code = A.Product_code AND B.Product_type = A.Product_type " & _
  " LEFT OUTER JOIN Sorting_Type C ON C.Sort_Code = A.sort_Code" & _
  " LEFT OUTER JOIN Location_Master D ON D.Location_Code=A.pur_loc " & _
  " LEFT OUTER JOIN Location_Master E ON E.Location_Code=A.Loc_code  " & _
  " LEFT OUTER JOIN Tbl_UserMaster F ON F.User_Code = A.user_code" & _
  " LEFT OUTER JOIN Tbl_FinalPack_Sub G ON G.carton_Serial_no = A.Carton_Serial_no" & _
  " WHERE ('" & productCode & "'='' OR A.Product_code  ='" & productCode & "') AND  ('" & ProductType & "' ='' OR A.Product_type  ='" & ProductType & "' )" & _
  "AND (CAST(A.Pur_date AS DATE)  BETWEEN CAST('" & a & "' AS DATE) AND  CAST('" & b & "' AS DATE))")
        If dtprint.Rows.Count > 0 Then
            Dim objcrp As New CrpProductionSummary()
            objcrp.SetDataSource(dtprint)
            objcrp.SetParameterValue("FDate", FDate)
            objcrp.SetParameterValue("TDate", TDate)
            objcrp.SetParameterValue("RptName", "Printing Summary Report ")
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
        'dtprint = ReturningDataBySp(FDate, TDate, 2, ProductType, productCode)
        Dim a As String = Format(FDate, "yyyy-MM-dd")
        Dim b As String = Format(TDate, "yyyy-MM-dd")
        dtprint = ReturningDataByQ("SELECT A.Carton_Serial_no ,B.Product_Code,B.Product_Name,A.Sap_Code,CASE WHEN  A.Product_type='W' THEN 'WIP' ELSE A.Product_type  END AS Product_type  ,A.Pur_date,C.Sort_Name " & _
  ",A.Batch_no,D.Location_Name Pur_Loc,E.Location_Name Loc_Name,CASE WHEN A.FullBatch<>''THEN A.FullBatch ELSE A.Batch_no END AS FullBatch  ,F.User_Name,A.packet_size,A.Carton_Weight,A.status" & _
  ",G.packet_Serial_no" & _
  " FROM Barcode A " & _
  "LEFT OUTER JOIN Product_Master B ON B.Product_Code = A.Product_code AND B.Product_type = A.Product_type " & _
  " LEFT OUTER JOIN Sorting_Type C ON C.Sort_Code = A.sort_Code" & _
  " LEFT OUTER JOIN Location_Master D ON D.Location_Code=A.pur_loc " & _
  " LEFT OUTER JOIN Location_Master E ON E.Location_Code=A.Loc_code  " & _
  " LEFT OUTER JOIN Tbl_UserMaster F ON F.User_Code = A.user_code" & _
  " LEFT OUTER JOIN Tbl_FinalPack_Sub G ON G.carton_Serial_no = A.Carton_Serial_no" & _
  " WHERE ('" & productCode & "'='' OR A.Product_code  ='" & productCode & "') AND  ('" & ProductType & "' ='' OR A.Product_type  ='" & ProductType & "' )" & _
  "AND (CAST(A.Pur_date AS DATE)  BETWEEN CAST('" & a & "' AS DATE) AND  CAST('" & b & "' AS DATE))")
        If dtprint.Rows.Count > 0 Then
            Dim objcrp As New CrpProductionDetailed()
            objcrp.SetDataSource(dtprint)
            objcrp.SetParameterValue("FDate", FDate)
            objcrp.SetParameterValue("TDate", TDate)
            objcrp.SetParameterValue("RptName", "Printing Detailed Report ")
            Dim objviewer As New FrmRptViewer()
            objviewer.CrystalReportViewer1.ReportSource = objcrp
            objviewer.WindowState = FormWindowState.Maximized
            objviewer.Show()
        Else
            MsgBox("NO Report within given Criteria", MsgBoxStyle.OkOnly, "Baby Marine Retail")
        End If
    End Sub
End Class