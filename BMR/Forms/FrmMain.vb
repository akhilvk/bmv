Imports System.Windows.Forms

Public Class FrmMain
    Public _UserCode As Integer = 0
    Public _Loc_Code As Integer
    Public _LocPrefix As String
    Public _locname As String
    Public _menuPer As String()
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer
    Public Sub ShowForm(ByVal fm As Form, Optional ByVal Headetext As String = "")
        fm.MdiParent = Me
        If Headetext <> "" Then
            fm.Text = Headetext
        End If
        fm.StartPosition = FormStartPosition.Manual
        fm.TopMost = True
        fm.Left = 0
        fm.Top = 0
        fm.Activate()
        fm.Focus()
        fm.Show()
    End Sub
    Private Sub SFGPrintingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SFGPrintingToolStripMenuItem.Click
        ShowForm(frmsfgbarocodeprint)
    End Sub

    Private Sub WIPBarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WIPBarToolStripMenuItem.Click
        ShowForm(FrmWIPPrinting)
    End Sub

    Private Sub FinalPacketFinalCaronPrintingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinalPacketFinalCaronPrintingToolStripMenuItem.Click
        ShowForm(FrmFinalPack)
    End Sub

    Private Sub FrmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub
    Private Sub FrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackgroundImage = Global.BMR.My.Resources.Resources._1450503762_0_Banner_1
        Me.BackgroundImageLayout = ImageLayout.Stretch
        For Each items As ToolStripMenuItem In MenuStrip1.Items
            For i As Integer = 0 To items.DropDownItems.Count - 1
                items.DropDownItems(i).Visible = False
            Next
        Next
        Dim intmenu As Integer

        For Each items As ToolStripMenuItem In MenuStrip1.Items
            For i As Integer = 0 To items.DropDownItems.Count - 1
                If _menuPer(intmenu) = 1 Then
                    items.DropDownItems(i).Visible = True
                End If
                intmenu += 1
            Next
        Next
        ConnectToDB()
        User_Code = 1
        _UserCode = 1
        _Loc_Code = Loc_Code
        Dim dt As DataTable = ReturningDataByQ("SELECT Location_Prefix FROM Location_Master WHERE Location_Code=" & _Loc_Code & " ")
        _LocPrefix = dt(0)(0)
    End Sub

    Private Sub ProductionReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductionReportToolStripMenuItem.Click
        ShowForm(FrmProductionReport)
    End Sub

    Private Sub SFGStorageReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SFGStorageReportToolStripMenuItem.Click
        ShowForm(FrmSFGStoreReport)
    End Sub

    Private Sub BeforeFinalStorageReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeforeFinalStorageReportToolStripMenuItem.Click
        ShowForm(FrmWIPStoreReport)
    End Sub

    Private Sub AfterFinalStorageReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AfterFinalStorageReportToolStripMenuItem.Click
        ShowForm(FrmFGStoreReport)
    End Sub

    Private Sub ScrapAndWastageAfterSFGToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScrapAndWastageAfterSFGToolStripMenuItem.Click
        ShowForm(FrmProcess)
        FrmProcess.Tag = 0
    End Sub
    Private Sub FrmMain_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        If MouseButtons = Windows.Forms.MouseButtons.None Then
            C1RadialMenu1.ShowMenu(Me, New Point(MousePosition.X, MousePosition.Y), False)
        End If
    End Sub
    Private Sub Example_ControlAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.ControlEventArgs) Handles Me.ControlAdded

        AddHandler e.Control.MouseClick, AddressOf Example_MouseClick
    End Sub

    Private Sub Example_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If C1RadialMenu1.Visible = True Then
                C1RadialMenu1.HideMenu()
            Else
                C1RadialMenu1.ShowMenu(Me, New Point(MousePosition.X, MousePosition.Y), False)
            End If
        End If
    End Sub

    Private Sub C1RadialMenu1_ItemClick(ByVal sender As Object, ByVal e As C1.Win.C1Command.RadialMenuItemClickEventArgs) Handles C1RadialMenu1.ItemClick

    End Sub

    Private Sub RadialMenuItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadialMenuItem1.Click
        
    End Sub

    Private Sub RadialMenuItem5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadialMenuItem5.Click
        C1RadialMenu1.HideMenu()
        ShowForm(frmsfgbarocodeprint)
    End Sub

    Private Sub RadialMenuItem6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadialMenuItem6.Click
        C1RadialMenu1.HideMenu()
        ShowForm(FrmWIPPrinting)
    End Sub

    Private Sub RadialMenuItem7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadialMenuItem7.Click
        C1RadialMenu1.HideMenu()
        ShowForm(FrmFinalPack)
    End Sub

    Private Sub RadialMenuItem8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadialMenuItem8.Click
        C1RadialMenu1.HideMenu()
        ShowForm(FrmProcess)
        FrmProcess.Tag = 0
    End Sub

    Private Sub Before_Final_Pack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Before_Final_Pack.Click
        C1RadialMenu1.HideMenu()
        ShowForm(FrmProductionReport)
    End Sub

    Private Sub RadialMenuItem3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadialMenuItem3.Click
        C1RadialMenu1.HideMenu()
        ShowForm(FrmSFGStoreReport)
    End Sub

    Private Sub RadialMenuItem4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadialMenuItem4.Click
        C1RadialMenu1.HideMenu()
        ShowForm(FrmWIPStoreReport)
    End Sub

    Private Sub RadialMenuItem9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadialMenuItem9.Click
        C1RadialMenu1.HideMenu()
        ShowForm(FrmFGStoreReport)
    End Sub

    Private Sub ScrapAndWastageAfterWIPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScrapAndWastageAfterWIPToolStripMenuItem.Click
        ShowForm(FrmProcess)
        FrmProcess.Tag = 1
    End Sub

    Private Sub InvoiceReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvoiceReportToolStripMenuItem.Click
        ShowForm(FrmInvoiceReport)
    End Sub

    Private Sub DespatchReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DespatchReportToolStripMenuItem.Click
        ShowForm(FrmDespatchReport)
    End Sub

    Private Sub ReceiptReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceiptReportToolStripMenuItem.Click
        ShowForm(FrmReciptReport)
    End Sub

    Private Sub RadialMenuItem10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadialMenuItem10.Click
        C1RadialMenu1.HideMenu()
        ShowForm(FrmProcess)
        FrmProcess.Tag = 1
    End Sub

    Private Sub RadialMenuItem11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadialMenuItem11.Click
        C1RadialMenu1.HideMenu()
        ShowForm(FrmDespatchReport)
    End Sub

    Private Sub RadialMenuItem12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadialMenuItem12.Click
        C1RadialMenu1.HideMenu()
        ShowForm(FrmReciptReport)
    End Sub

    Private Sub RadialMenuItem13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadialMenuItem13.Click
        C1RadialMenu1.HideMenu()
        ShowForm(FrmInvoiceReport)
    End Sub
End Class
