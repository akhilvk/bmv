<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSFGStoreReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSFGStoreReport))
        Me.C1ThemeController1 = New C1.Win.C1Themes.C1ThemeController
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnClose = New C1.Win.C1Input.C1Button
        Me.BtnClear = New C1.Win.C1Input.C1Button
        Me.BtnDetailed = New C1.Win.C1Input.C1Button
        Me.BtnSummary = New C1.Win.C1Input.C1Button
        Me.CmbProduct = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DtpTDate = New System.Windows.Forms.DateTimePicker
        Me.dtpFDate = New System.Windows.Forms.DateTimePicker
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnClear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDetailed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1ThemeController1
        '
        Me.C1ThemeController1.Theme = "Windows8Green"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BtnClose)
        Me.GroupBox1.Controls.Add(Me.BtnClear)
        Me.GroupBox1.Controls.Add(Me.BtnDetailed)
        Me.GroupBox1.Controls.Add(Me.BtnSummary)
        Me.GroupBox1.Controls.Add(Me.CmbProduct)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DtpTDate)
        Me.GroupBox1.Controls.Add(Me.dtpFDate)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(20, 14)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(543, 228)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.C1ThemeController1.SetTheme(Me.GroupBox1, "(default)")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(10, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Product Name"
        Me.C1ThemeController1.SetTheme(Me.Label4, "(default)")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(10, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "To Date"
        Me.C1ThemeController1.SetTheme(Me.Label2, "(default)")
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(370, 183)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(87, 29)
        Me.BtnClose.TabIndex = 7
        Me.BtnClose.Text = "Close"
        Me.C1ThemeController1.SetTheme(Me.BtnClose, "(default)")
        Me.BtnClose.UseVisualStyleBackColor = True
        Me.BtnClose.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(275, 183)
        Me.BtnClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(87, 29)
        Me.BtnClear.TabIndex = 6
        Me.BtnClear.Text = "Clear"
        Me.C1ThemeController1.SetTheme(Me.BtnClear, "(default)")
        Me.BtnClear.UseVisualStyleBackColor = True
        Me.BtnClear.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'BtnDetailed
        '
        Me.BtnDetailed.Location = New System.Drawing.Point(180, 183)
        Me.BtnDetailed.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnDetailed.Name = "BtnDetailed"
        Me.BtnDetailed.Size = New System.Drawing.Size(87, 29)
        Me.BtnDetailed.TabIndex = 5
        Me.BtnDetailed.Text = "Detailed"
        Me.C1ThemeController1.SetTheme(Me.BtnDetailed, "(default)")
        Me.BtnDetailed.UseVisualStyleBackColor = True
        Me.BtnDetailed.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'BtnSummary
        '
        Me.BtnSummary.Location = New System.Drawing.Point(85, 183)
        Me.BtnSummary.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnSummary.Name = "BtnSummary"
        Me.BtnSummary.Size = New System.Drawing.Size(87, 29)
        Me.BtnSummary.TabIndex = 4
        Me.BtnSummary.Text = "Summary"
        Me.C1ThemeController1.SetTheme(Me.BtnSummary, "(default)")
        Me.BtnSummary.UseVisualStyleBackColor = True
        Me.BtnSummary.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'CmbProduct
        '
        Me.CmbProduct.BackColor = System.Drawing.Color.White
        Me.CmbProduct.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.CmbProduct.FormattingEnabled = True
        Me.CmbProduct.Location = New System.Drawing.Point(140, 123)
        Me.CmbProduct.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CmbProduct.Name = "CmbProduct"
        Me.CmbProduct.Size = New System.Drawing.Size(393, 25)
        Me.CmbProduct.TabIndex = 3
        Me.C1ThemeController1.SetTheme(Me.CmbProduct, "(default)")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(10, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "From Date"
        Me.C1ThemeController1.SetTheme(Me.Label1, "(default)")
        '
        'DtpTDate
        '
        Me.DtpTDate.CustomFormat = "dd-MMM-yyyy"
        Me.DtpTDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpTDate.Location = New System.Drawing.Point(140, 85)
        Me.DtpTDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DtpTDate.Name = "DtpTDate"
        Me.DtpTDate.Size = New System.Drawing.Size(175, 25)
        Me.DtpTDate.TabIndex = 1
        '
        'dtpFDate
        '
        Me.dtpFDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpFDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFDate.Location = New System.Drawing.Point(140, 49)
        Me.dtpFDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpFDate.Name = "dtpFDate"
        Me.dtpFDate.Size = New System.Drawing.Size(175, 25)
        Me.dtpFDate.TabIndex = 0
        '
        'FrmSFGStoreReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 253)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FrmSFGStoreReport"
        Me.Text = "SFG Storage Report"
        Me.C1ThemeController1.SetTheme(Me, "(default)")
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnClear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDetailed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1ThemeController1 As C1.Win.C1Themes.C1ThemeController
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpTDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbProduct As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnClose As C1.Win.C1Input.C1Button
    Friend WithEvents BtnClear As C1.Win.C1Input.C1Button
    Friend WithEvents BtnDetailed As C1.Win.C1Input.C1Button
    Friend WithEvents BtnSummary As C1.Win.C1Input.C1Button
End Class
