<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProcess
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProcess))
        Me.C1ThemeController1 = New C1.Win.C1Themes.C1ThemeController
        Me.btnClose = New C1.Win.C1Input.C1Button
        Me.btnClear = New C1.Win.C1Input.C1Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.cboBatchno = New System.Windows.Forms.ComboBox
        Me.CmbProduct = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtProcessQty = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtWaste = New System.Windows.Forms.TextBox
        Me.TxtScrapQty = New System.Windows.Forms.TextBox
        Me.txtscanQty = New System.Windows.Forms.TextBox
        Me.txtSap = New System.Windows.Forms.TextBox
        Me.btnsave = New C1.Win.C1Input.C1Button
        Me.C1SuperErrorProvider1 = New C1.Win.C1SuperTooltip.C1SuperErrorProvider(Me.components)
        Me.C1SuperTooltip1 = New C1.Win.C1SuperTooltip.C1SuperTooltip(Me.components)
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.btnsave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1SuperErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1ThemeController1
        '
        Me.C1ThemeController1.Theme = "Windows8Green"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(310, 300)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(79, 26)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "&Close"
        Me.C1ThemeController1.SetTheme(Me.btnClose, "(default)")
        Me.btnClose.UseVisualStyleBackColor = True
        Me.btnClose.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(226, 300)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(79, 26)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "C&lear"
        Me.C1ThemeController1.SetTheme(Me.btnClear, "(default)")
        Me.btnClear.UseVisualStyleBackColor = True
        Me.btnClear.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.cboBatchno)
        Me.GroupBox1.Controls.Add(Me.CmbProduct)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TxtProcessQty)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtWaste)
        Me.GroupBox1.Controls.Add(Me.TxtScrapQty)
        Me.GroupBox1.Controls.Add(Me.txtscanQty)
        Me.GroupBox1.Controls.Add(Me.txtSap)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(514, 283)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.C1ThemeController1.SetTheme(Me.GroupBox1, "(default)")
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(138, 121)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(152, 20)
        Me.DateTimePicker1.TabIndex = 21
        '
        'cboBatchno
        '
        Me.cboBatchno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboBatchno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboBatchno.BackColor = System.Drawing.Color.White
        Me.cboBatchno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.cboBatchno.FormattingEnabled = True
        Me.cboBatchno.Location = New System.Drawing.Point(138, 90)
        Me.cboBatchno.Name = "cboBatchno"
        Me.cboBatchno.Size = New System.Drawing.Size(152, 21)
        Me.cboBatchno.TabIndex = 20
        Me.C1ThemeController1.SetTheme(Me.cboBatchno, "(default)")
        '
        'CmbProduct
        '
        Me.CmbProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbProduct.BackColor = System.Drawing.Color.White
        Me.CmbProduct.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.CmbProduct.FormattingEnabled = True
        Me.CmbProduct.Location = New System.Drawing.Point(138, 14)
        Me.CmbProduct.Name = "CmbProduct"
        Me.CmbProduct.Size = New System.Drawing.Size(351, 21)
        Me.CmbProduct.TabIndex = 19
        Me.C1ThemeController1.SetTheme(Me.CmbProduct, "(default)")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(25, 158)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "PROCESS QTY"
        Me.C1ThemeController1.SetTheme(Me.Label9, "(default)")
        '
        'TxtProcessQty
        '
        Me.TxtProcessQty.BackColor = System.Drawing.Color.White
        Me.TxtProcessQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtProcessQty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TxtProcessQty.Location = New System.Drawing.Point(138, 154)
        Me.TxtProcessQty.Name = "TxtProcessQty"
        Me.TxtProcessQty.Size = New System.Drawing.Size(152, 20)
        Me.TxtProcessQty.TabIndex = 4
        Me.C1ThemeController1.SetTheme(Me.TxtProcessQty, "(default)")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(46, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "BATCH NO"
        Me.C1ThemeController1.SetTheme(Me.Label7, "(default)")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(47, 253)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "WASTAGE"
        Me.C1ThemeController1.SetTheme(Me.Label8, "(default)")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(40, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "SCRAP QTY"
        Me.C1ThemeController1.SetTheme(Me.Label5, "(default)")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(24, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "SCANNED QTY"
        Me.C1ThemeController1.SetTheme(Me.Label6, "(default)")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(70, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "DATE"
        Me.C1ThemeController1.SetTheme(Me.Label4, "(default)")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(47, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "SAP CODE"
        Me.C1ThemeController1.SetTheme(Me.Label3, "(default)")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(267, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "OR"
        Me.C1ThemeController1.SetTheme(Me.Label2, "(default)")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(48, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "PRODUCT"
        Me.C1ThemeController1.SetTheme(Me.Label1, "(default)")
        '
        'txtWaste
        '
        Me.txtWaste.BackColor = System.Drawing.Color.White
        Me.txtWaste.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtWaste.Location = New System.Drawing.Point(138, 249)
        Me.txtWaste.Name = "txtWaste"
        Me.txtWaste.Size = New System.Drawing.Size(152, 20)
        Me.txtWaste.TabIndex = 7
        Me.C1ThemeController1.SetTheme(Me.txtWaste, "(default)")
        '
        'TxtScrapQty
        '
        Me.TxtScrapQty.BackColor = System.Drawing.Color.White
        Me.TxtScrapQty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TxtScrapQty.Location = New System.Drawing.Point(138, 217)
        Me.TxtScrapQty.Name = "TxtScrapQty"
        Me.TxtScrapQty.Size = New System.Drawing.Size(152, 20)
        Me.TxtScrapQty.TabIndex = 6
        Me.C1ThemeController1.SetTheme(Me.TxtScrapQty, "(default)")
        '
        'txtscanQty
        '
        Me.txtscanQty.BackColor = System.Drawing.Color.White
        Me.txtscanQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtscanQty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtscanQty.Location = New System.Drawing.Point(138, 185)
        Me.txtscanQty.Name = "txtscanQty"
        Me.txtscanQty.ReadOnly = True
        Me.txtscanQty.Size = New System.Drawing.Size(152, 20)
        Me.txtscanQty.TabIndex = 5
        Me.C1ThemeController1.SetTheme(Me.txtscanQty, "(default)")
        '
        'txtSap
        '
        Me.txtSap.BackColor = System.Drawing.Color.White
        Me.txtSap.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtSap.Location = New System.Drawing.Point(138, 58)
        Me.txtSap.Name = "txtSap"
        Me.txtSap.Size = New System.Drawing.Size(351, 20)
        Me.txtSap.TabIndex = 2
        Me.C1ThemeController1.SetTheme(Me.txtSap, "(default)")
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(142, 300)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(79, 26)
        Me.btnsave.TabIndex = 1
        Me.btnsave.Text = "&Save"
        Me.C1ThemeController1.SetTheme(Me.btnsave, "(default)")
        Me.btnsave.UseVisualStyleBackColor = True
        Me.btnsave.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1SuperErrorProvider1
        '
        Me.C1SuperErrorProvider1.ContainerControl = Me
        Me.C1ThemeController1.SetTheme(Me.C1SuperErrorProvider1, "(default)")
        Me.C1SuperErrorProvider1.ToolTip = Me.C1SuperTooltip1
        '
        'C1SuperTooltip1
        '
        Me.C1SuperTooltip1.BackgroundGradient = C1.Win.C1SuperTooltip.BackgroundGradient.None
        Me.C1SuperTooltip1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.C1SuperTooltip1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.C1ThemeController1.SetTheme(Me.C1SuperTooltip1, "(default)")
        '
        'FrmProcess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 332)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnsave)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmProcess"
        Me.Text = "Wastage And Scrap Management"
        Me.C1ThemeController1.SetTheme(Me, "(default)")
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.btnsave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1SuperErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1ThemeController1 As C1.Win.C1Themes.C1ThemeController
    Friend WithEvents btnClose As C1.Win.C1Input.C1Button
    Friend WithEvents btnClear As C1.Win.C1Input.C1Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtWaste As System.Windows.Forms.TextBox
    Friend WithEvents TxtScrapQty As System.Windows.Forms.TextBox
    Friend WithEvents txtscanQty As System.Windows.Forms.TextBox
    Friend WithEvents txtSap As System.Windows.Forms.TextBox
    Friend WithEvents btnsave As C1.Win.C1Input.C1Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtProcessQty As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents C1SuperErrorProvider1 As C1.Win.C1SuperTooltip.C1SuperErrorProvider
    Friend WithEvents C1SuperTooltip1 As C1.Win.C1SuperTooltip.C1SuperTooltip
    Friend WithEvents CmbProduct As System.Windows.Forms.ComboBox
    Friend WithEvents cboBatchno As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
