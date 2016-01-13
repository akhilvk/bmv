Public Class FrmReciptReport
    Dim PType, productCode, ProductType As String
    Dim FDate, TDate As DateTime
    Public Sub Clear()
        dtpFDate.Value = DateTime.Now
        dtpFDate.Value = DateTime.Now
        LoadProduct()
        CmbProduct.SelectedValue = -1
        CmbProduct.Text = "All"
        dtpFDate.Focus()
    End Sub
    Public Sub LoadProduct()
        Dim dt As DataTable
        PType = ""
        'dt = ReturningDataBySp(DateTime.Now, DateTime.Now, 1, "FG", "")
        dt = ReturningDataByQ("SELECT DISTINCT  Product_Code,Product_Name FROM Product_Master  WHERE   Product_del=0 ")
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
    End Sub

    Private Sub BtnDetailed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDetailed.Click
        SetValues()
        Dim dtprint As DataTable
        'dtprint = ReturningDataBySp(FDate, TDate, 5, "FG", productCode)
        Dim a As String = Format(FDate, "yyyy-MM-dd")
        Dim b As String = Format(TDate, "yyyy-MM-dd")
        'dtprint = ReturningDataBySp(FDate, TDate, 4, "W", productCode)
        dtprint = ReturningDataByQ("SELECT f.Product_Name,d.Product_code,a.Rec_code,a.Rec_date,a.Rec_type,b.Location_Name FromLoc,c.Location_Name ToLoc,Status, " & _
"d.plan_qty,d.scan_qty,e.carton_serial_no FROM bmr.tbl_receipt a " & _
"left outer join location_master b on a.from_loc_code=b.Location_Code " & _
"left outer join location_master c on a.To_loc_code=c.Location_Code " & _
"left outer join tbl_receiptsub d on a.Rec_code=d.Rec_code " & _
"left outer join tbl_receiptscan e on e.Rec_code=a.Rec_code " & _
"left outer join product_master f on f.Product_Code=d.product_code " & _
   "WHERE  ('" & productCode & "'='' OR D.Product_code  ='" & productCode & "') " & _
     "AND  (CAST(a.Rec_date AS DATE)  BETWEEN  CAST('" & a & "' AS DATE) AND  CAST('" & b & "' AS DATE))")
        If dtprint.Rows.Count > 0 Then
            Dim objcrp As New CrpRecipt()
            objcrp.SetDataSource(dtprint)
            objcrp.SetParameterValue("FDate", FDate)
            objcrp.SetParameterValue("TDate", TDate)
            objcrp.SetParameterValue("RptName", " Recipt Report ")
            Dim objviewer As New FrmRptViewer()
            objviewer.CrystalReportViewer1.ReportSource = objcrp
            objviewer.WindowState = FormWindowState.Maximized
            objviewer.Show()
        Else
            MsgBox("NO Report within given Criteria", MsgBoxStyle.OkOnly, "Baby Marine Retail")
        End If
    End Sub
End Class