<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.C1ThemeController1 = New C1.Win.C1Themes.C1ThemeController
        Me.C1CommandMenu1 = New C1.Win.C1Command.C1CommandMenu
        Me.C1CommandLink2 = New C1.Win.C1Command.C1CommandLink
        Me.C1StatusBar1 = New C1.Win.C1Ribbon.C1StatusBar
        Me.C1SuperTooltip1 = New C1.Win.C1SuperTooltip.C1SuperTooltip(Me.components)
        Me.C1SuperErrorProvider1 = New C1.Win.C1SuperTooltip.C1SuperErrorProvider(Me.components)
        Me.C1RadialMenu1 = New C1.Win.C1Command.C1RadialMenu
        Me.RadialMenuItem1 = New C1.Win.C1Command.RadialMenuItem
        Me.RadialMenuItem5 = New C1.Win.C1Command.RadialMenuItem
        Me.RadialMenuItem8 = New C1.Win.C1Command.RadialMenuItem
        Me.RadialMenuItem6 = New C1.Win.C1Command.RadialMenuItem
        Me.RadialMenuItem10 = New C1.Win.C1Command.RadialMenuItem
        Me.RadialMenuItem7 = New C1.Win.C1Command.RadialMenuItem
        Me.RadialMenuItem2 = New C1.Win.C1Command.RadialMenuItem
        Me.Before_Final_Pack = New C1.Win.C1Command.RadialMenuItem
        Me.RadialMenuItem3 = New C1.Win.C1Command.RadialMenuItem
        Me.RadialMenuItem4 = New C1.Win.C1Command.RadialMenuItem
        Me.RadialMenuItem9 = New C1.Win.C1Command.RadialMenuItem
        Me.RadialMenuItem11 = New C1.Win.C1Command.RadialMenuItem
        Me.RadialMenuItem12 = New C1.Win.C1Command.RadialMenuItem
        Me.RadialMenuItem13 = New C1.Win.C1Command.RadialMenuItem
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder
        Me.C1CommandControl1 = New C1.Win.C1Command.C1CommandControl
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.TransactionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SFGPrintingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ScrapAndWastageAfterSFGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WIPBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ScrapAndWastageAfterWIPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FinalPacketFinalCaronPrintingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProductionReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SFGStorageReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BeforeFinalStorageReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AfterFinalStorageReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DespatchReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReceiptReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InvoiceReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BarcodeReprintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1StatusBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1SuperErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'C1CommandMenu1
        '
        Me.C1CommandMenu1.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink2})
        Me.C1CommandMenu1.HideNonRecentLinks = False
        Me.C1CommandMenu1.Name = "C1CommandMenu1"
        Me.C1CommandMenu1.ShortcutText = ""
        Me.C1CommandMenu1.Text = "Masters"
        Me.C1ThemeController1.SetTheme(Me.C1CommandMenu1, "(default)")
        Me.C1CommandMenu1.VisualStyle = C1.Win.C1Command.VisualStyle.Custom
        Me.C1CommandMenu1.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Blue
        '
        'C1CommandLink2
        '
        Me.C1CommandLink2.Text = "New Command"
        '
        'C1StatusBar1
        '
        Me.C1StatusBar1.Location = New System.Drawing.Point(0, 395)
        Me.C1StatusBar1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.C1StatusBar1.Name = "C1StatusBar1"
        Me.C1StatusBar1.Size = New System.Drawing.Size(939, 22)
        Me.C1ThemeController1.SetTheme(Me.C1StatusBar1, "(default)")
        Me.C1StatusBar1.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Custom
        '
        'C1SuperTooltip1
        '
        Me.C1SuperTooltip1.BackgroundGradient = C1.Win.C1SuperTooltip.BackgroundGradient.None
        Me.C1SuperTooltip1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.C1SuperTooltip1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.C1ThemeController1.SetTheme(Me.C1SuperTooltip1, "(default)")
        '
        'C1SuperErrorProvider1
        '
        Me.C1SuperErrorProvider1.ContainerControl = Me
        Me.C1ThemeController1.SetTheme(Me.C1SuperErrorProvider1, "(default)")
        '
        'C1RadialMenu1
        '
        Me.C1RadialMenu1.ButtonRadius = 26
        Me.C1RadialMenu1.Image = Global.BMR.My.Resources.Resources.Stallion_logo_round
        Me.C1RadialMenu1.Items.Add(Me.RadialMenuItem1)
        Me.C1RadialMenu1.Items.Add(Me.RadialMenuItem2)
        Me.C1RadialMenu1.Radius = 220
        Me.C1ThemeController1.SetTheme(Me.C1RadialMenu1, "Office2010Blue")
        '
        'RadialMenuItem1
        '
        Me.RadialMenuItem1.Items.Add(Me.RadialMenuItem5)
        Me.RadialMenuItem1.Items.Add(Me.RadialMenuItem8)
        Me.RadialMenuItem1.Items.Add(Me.RadialMenuItem6)
        Me.RadialMenuItem1.Items.Add(Me.RadialMenuItem10)
        Me.RadialMenuItem1.Items.Add(Me.RadialMenuItem7)
        Me.RadialMenuItem1.Name = "RadialMenuItem1"
        Me.RadialMenuItem1.Text = "Transactions"
        '
        'RadialMenuItem5
        '
        Me.RadialMenuItem5.Name = "RadialMenuItem5"
        Me.RadialMenuItem5.Text = "SFG Barcode Print"
        '
        'RadialMenuItem8
        '
        Me.RadialMenuItem8.Name = "RadialMenuItem8"
        Me.RadialMenuItem8.Text = "Scrap and Wastage(After SFG)"
        '
        'RadialMenuItem6
        '
        Me.RadialMenuItem6.Name = "RadialMenuItem6"
        Me.RadialMenuItem6.Text = "Before Pack Print"
        '
        'RadialMenuItem10
        '
        Me.RadialMenuItem10.Name = "RadialMenuItem10"
        Me.RadialMenuItem10.Text = "Scrap And Wastage(After BeforePack)"
        '
        'RadialMenuItem7
        '
        Me.RadialMenuItem7.Name = "RadialMenuItem7"
        Me.RadialMenuItem7.Text = "After Pack Print"
        '
        'RadialMenuItem2
        '
        Me.RadialMenuItem2.Items.Add(Me.Before_Final_Pack)
        Me.RadialMenuItem2.Items.Add(Me.RadialMenuItem3)
        Me.RadialMenuItem2.Items.Add(Me.RadialMenuItem4)
        Me.RadialMenuItem2.Items.Add(Me.RadialMenuItem9)
        Me.RadialMenuItem2.Items.Add(Me.RadialMenuItem11)
        Me.RadialMenuItem2.Items.Add(Me.RadialMenuItem12)
        Me.RadialMenuItem2.Items.Add(Me.RadialMenuItem13)
        Me.RadialMenuItem2.Name = "RadialMenuItem2"
        Me.RadialMenuItem2.Text = "Reports"
        '
        'Before_Final_Pack
        '
        Me.Before_Final_Pack.Name = "Before_Final_Pack"
        Me.Before_Final_Pack.Text = "Barcode Print Report"
        '
        'RadialMenuItem3
        '
        Me.RadialMenuItem3.Name = "RadialMenuItem3"
        Me.RadialMenuItem3.Text = "SFG Storage Report"
        '
        'RadialMenuItem4
        '
        Me.RadialMenuItem4.Name = "RadialMenuItem4"
        Me.RadialMenuItem4.Text = "Before Pack Storage Report"
        '
        'RadialMenuItem9
        '
        Me.RadialMenuItem9.Name = "RadialMenuItem9"
        Me.RadialMenuItem9.Text = "After Pack Storage Report"
        '
        'RadialMenuItem11
        '
        Me.RadialMenuItem11.Name = "RadialMenuItem11"
        Me.RadialMenuItem11.Text = "Despatch Report"
        '
        'RadialMenuItem12
        '
        Me.RadialMenuItem12.Name = "RadialMenuItem12"
        Me.RadialMenuItem12.Text = "Reciept Report"
        '
        'RadialMenuItem13
        '
        Me.RadialMenuItem13.Name = "RadialMenuItem13"
        Me.RadialMenuItem13.Text = "Invoice Report"
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.C1CommandMenu1)
        Me.C1CommandHolder1.Commands.Add(Me.C1CommandControl1)
        Me.C1CommandHolder1.Owner = Me
        '
        'C1CommandControl1
        '
        Me.C1CommandControl1.Name = "C1CommandControl1"
        Me.C1CommandControl1.ShortcutText = ""
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransactionsToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(939, 25)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TransactionsToolStripMenuItem
        '
        Me.TransactionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SFGPrintingToolStripMenuItem, Me.ScrapAndWastageAfterSFGToolStripMenuItem, Me.WIPBarToolStripMenuItem, Me.ScrapAndWastageAfterWIPToolStripMenuItem, Me.FinalPacketFinalCaronPrintingToolStripMenuItem, Me.ToolStripMenuItem1, Me.BarcodeReprintToolStripMenuItem})
        Me.TransactionsToolStripMenuItem.Name = "TransactionsToolStripMenuItem"
        Me.TransactionsToolStripMenuItem.Size = New System.Drawing.Size(86, 19)
        Me.TransactionsToolStripMenuItem.Text = "Transactions"
        '
        'SFGPrintingToolStripMenuItem
        '
        Me.SFGPrintingToolStripMenuItem.Name = "SFGPrintingToolStripMenuItem"
        Me.SFGPrintingToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.SFGPrintingToolStripMenuItem.Text = "SFG Barcode Printing"
        '
        'ScrapAndWastageAfterSFGToolStripMenuItem
        '
        Me.ScrapAndWastageAfterSFGToolStripMenuItem.Name = "ScrapAndWastageAfterSFGToolStripMenuItem"
        Me.ScrapAndWastageAfterSFGToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.ScrapAndWastageAfterSFGToolStripMenuItem.Text = "Scrap And Wastage(After SFG)"
        '
        'WIPBarToolStripMenuItem
        '
        Me.WIPBarToolStripMenuItem.Name = "WIPBarToolStripMenuItem"
        Me.WIPBarToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.WIPBarToolStripMenuItem.Text = "Before Final Pack"
        '
        'ScrapAndWastageAfterWIPToolStripMenuItem
        '
        Me.ScrapAndWastageAfterWIPToolStripMenuItem.Name = "ScrapAndWastageAfterWIPToolStripMenuItem"
        Me.ScrapAndWastageAfterWIPToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.ScrapAndWastageAfterWIPToolStripMenuItem.Text = "Scrap and wastage (After WIP)"
        '
        'FinalPacketFinalCaronPrintingToolStripMenuItem
        '
        Me.FinalPacketFinalCaronPrintingToolStripMenuItem.Name = "FinalPacketFinalCaronPrintingToolStripMenuItem"
        Me.FinalPacketFinalCaronPrintingToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.FinalPacketFinalCaronPrintingToolStripMenuItem.Text = "After Final Pack"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(233, 22)
        Me.ToolStripMenuItem1.Text = "Scrap Print"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductionReportToolStripMenuItem, Me.SFGStorageReportToolStripMenuItem, Me.BeforeFinalStorageReportToolStripMenuItem, Me.AfterFinalStorageReportToolStripMenuItem, Me.DespatchReportToolStripMenuItem, Me.ReceiptReportToolStripMenuItem, Me.InvoiceReportToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 19)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'ProductionReportToolStripMenuItem
        '
        Me.ProductionReportToolStripMenuItem.Name = "ProductionReportToolStripMenuItem"
        Me.ProductionReportToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.ProductionReportToolStripMenuItem.Text = "Barcode Printing Report"
        '
        'SFGStorageReportToolStripMenuItem
        '
        Me.SFGStorageReportToolStripMenuItem.Name = "SFGStorageReportToolStripMenuItem"
        Me.SFGStorageReportToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.SFGStorageReportToolStripMenuItem.Text = "SFG Storage Report"
        '
        'BeforeFinalStorageReportToolStripMenuItem
        '
        Me.BeforeFinalStorageReportToolStripMenuItem.Name = "BeforeFinalStorageReportToolStripMenuItem"
        Me.BeforeFinalStorageReportToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.BeforeFinalStorageReportToolStripMenuItem.Text = "Before Final Storage Report"
        '
        'AfterFinalStorageReportToolStripMenuItem
        '
        Me.AfterFinalStorageReportToolStripMenuItem.Name = "AfterFinalStorageReportToolStripMenuItem"
        Me.AfterFinalStorageReportToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.AfterFinalStorageReportToolStripMenuItem.Text = "After Final Storage Report"
        '
        'DespatchReportToolStripMenuItem
        '
        Me.DespatchReportToolStripMenuItem.Name = "DespatchReportToolStripMenuItem"
        Me.DespatchReportToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.DespatchReportToolStripMenuItem.Text = "Despatch Report"
        '
        'ReceiptReportToolStripMenuItem
        '
        Me.ReceiptReportToolStripMenuItem.Name = "ReceiptReportToolStripMenuItem"
        Me.ReceiptReportToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.ReceiptReportToolStripMenuItem.Text = "Receipt Report"
        '
        'InvoiceReportToolStripMenuItem
        '
        Me.InvoiceReportToolStripMenuItem.Name = "InvoiceReportToolStripMenuItem"
        Me.InvoiceReportToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.InvoiceReportToolStripMenuItem.Text = "Invoice Report"
        '
        'BarcodeReprintToolStripMenuItem
        '
        Me.BarcodeReprintToolStripMenuItem.Name = "BarcodeReprintToolStripMenuItem"
        Me.BarcodeReprintToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.BarcodeReprintToolStripMenuItem.Text = "Barcode Reprint"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.BMR.My.Resources.Resources._1450503762_0_Banner_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(939, 417)
        Me.Controls.Add(Me.C1StatusBar1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmMain"
        Me.Text = "BMR"
        Me.C1ThemeController1.SetTheme(Me, "(default)")
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1StatusBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1SuperErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents C1ThemeController1 As C1.Win.C1Themes.C1ThemeController
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents C1CommandMenu1 As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents C1CommandLink2 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandControl1 As C1.Win.C1Command.C1CommandControl
    Friend WithEvents C1StatusBar1 As C1.Win.C1Ribbon.C1StatusBar
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TransactionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents C1SuperTooltip1 As C1.Win.C1SuperTooltip.C1SuperTooltip
    Friend WithEvents SFGPrintingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WIPBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FinalPacketFinalCaronPrintingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductionReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents C1SuperErrorProvider1 As C1.Win.C1SuperTooltip.C1SuperErrorProvider
    Friend WithEvents SFGStorageReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BeforeFinalStorageReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AfterFinalStorageReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScrapAndWastageAfterSFGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents C1RadialMenu1 As C1.Win.C1Command.C1RadialMenu
    Friend WithEvents RadialMenuItem1 As C1.Win.C1Command.RadialMenuItem
    Friend WithEvents RadialMenuItem2 As C1.Win.C1Command.RadialMenuItem
    Friend WithEvents RadialMenuItem5 As C1.Win.C1Command.RadialMenuItem
    Friend WithEvents RadialMenuItem6 As C1.Win.C1Command.RadialMenuItem
    Friend WithEvents RadialMenuItem7 As C1.Win.C1Command.RadialMenuItem
    Friend WithEvents RadialMenuItem8 As C1.Win.C1Command.RadialMenuItem
    Friend WithEvents Before_Final_Pack As C1.Win.C1Command.RadialMenuItem
    Friend WithEvents RadialMenuItem3 As C1.Win.C1Command.RadialMenuItem
    Friend WithEvents RadialMenuItem4 As C1.Win.C1Command.RadialMenuItem
    Friend WithEvents RadialMenuItem9 As C1.Win.C1Command.RadialMenuItem
    Friend WithEvents ScrapAndWastageAfterWIPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InvoiceReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DespatchReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReceiptReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RadialMenuItem10 As C1.Win.C1Command.RadialMenuItem
    Friend WithEvents RadialMenuItem11 As C1.Win.C1Command.RadialMenuItem
    Friend WithEvents RadialMenuItem12 As C1.Win.C1Command.RadialMenuItem
    Friend WithEvents RadialMenuItem13 As C1.Win.C1Command.RadialMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarcodeReprintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
