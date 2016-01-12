Public Class FrmWIPStoreReport
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
        'dt = ReturningDataBySp(DateTime.Now, DateTime.Now, 1, "W", "")
        dt = ReturningDataByQ("SELECT DISTINCT  Product_Code,Product_Name FROM Product_Master  WHERE (Product_type   ='W') AND  Product_del=0 ")
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

    Private Sub BtnDetailed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDetailed.Click
        SetValues()
        Dim dtprint As DataTable
        Dim a As String = Format(FDate, "yyyy-MM-dd")
        Dim b As String = Format(TDate, "yyyy-MM-dd")
        'dtprint = ReturningDataBySp(FDate, TDate, 4, "W", productCode)
        dtprint = ReturningDataByQ("SELECT A.store_date ,A.carton_Serial_no ,A.Product_Code,B.Product_Name ,B.Product_Type  ,C.Location_Name , " & _
        "A.batch_no, D.User_Name " & _
     "FROM Tbl_WIPStorage A " & _
     "LEFT OUTER JOIN Product_Master B ON B.Product_Code = A.Product_Code " & _
     "LEFT OUTER JOIN Location_Master C ON A.Loc_Code =C.Location_Code " & _
     "LEFT OUTER JOIN Tbl_UserMaster D ON D.User_Code =A.user_code " & _
     "WHERE  ('" & productCode & "'='' OR A.Product_code  ='" & productCode & "') AND B.Product_Type  ='FG' " & _
     "AND  (CAST(A.store_date AS DATE)  BETWEEN  CAST('" & a & "' AS DATE) AND  CAST('" & b & "' AS DATE))")
        If dtprint.Rows.Count > 0 Then
            Dim objcrp As New CrpWIPStorage()
            objcrp.SetDataSource(dtprint)
            objcrp.SetParameterValue("FDate", FDate)
            objcrp.SetParameterValue("TDate", TDate)
            objcrp.SetParameterValue("RptName", " Before Final Storage Report ")
            Dim objviewer As New FrmRptViewer()
            objviewer.CrystalReportViewer1.ReportSource = objcrp
            objviewer.WindowState = FormWindowState.Maximized
            objviewer.Show()
        Else
            MsgBox("NO Report within given Criteria", MsgBoxStyle.OkOnly, "Baby Marine Retail")
        End If
    End Sub
End Class