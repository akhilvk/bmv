<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsfgbarocodeprint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsfgbarocodeprint))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtcarton_weight = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtpack_size = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtbatch_no = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.cmbsorttype = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtcarton_wg = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtsap_code = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.cmbproduct = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.btnsave = New C1.Win.C1Input.C1Button
        Me.btnclear = New C1.Win.C1Input.C1Button
        Me.btnclose = New C1.Win.C1Input.C1Button
        Me.C1ThemeController1 = New C1.Win.C1Themes.C1ThemeController
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox2.SuspendLayout()
        CType(Me.btnsave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnclear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.txtcarton_weight)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtpack_size)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtbatch_no)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.cmbsorttype)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtcarton_wg)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtsap_code)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.cmbproduct)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 4)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(537, 273)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.C1ThemeController1.SetTheme(Me.GroupBox2, "(default)")
        '
        'txtcarton_weight
        '
        Me.txtcarton_weight.BackColor = System.Drawing.Color.White
        Me.txtcarton_weight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtcarton_weight.Location = New System.Drawing.Point(136, 206)
        Me.txtcarton_weight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtcarton_weight.Name = "txtcarton_weight"
        Me.txtcarton_weight.Size = New System.Drawing.Size(97, 25)
        Me.txtcarton_weight.TabIndex = 8
        Me.C1ThemeController1.SetTheme(Me.txtcarton_weight, "(default)")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(8, 210)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 15)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "CARTON WEIGHT"
        Me.C1ThemeController1.SetTheme(Me.Label9, "(default)")
        '
        'txtpack_size
        '
        Me.txtpack_size.BackColor = System.Drawing.Color.White
        Me.txtpack_size.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtpack_size.Location = New System.Drawing.Point(136, 172)
        Me.txtpack_size.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtpack_size.Name = "txtpack_size"
        Me.txtpack_size.Size = New System.Drawing.Size(97, 25)
        Me.txtpack_size.TabIndex = 7
        Me.C1ThemeController1.SetTheme(Me.txtpack_size, "(default)")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(10, 176)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 15)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "PACK SIZE"
        Me.C1ThemeController1.SetTheme(Me.Label10, "(default)")
        '
        'txtbatch_no
        '
        Me.txtbatch_no.BackColor = System.Drawing.Color.White
        Me.txtbatch_no.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbatch_no.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtbatch_no.Location = New System.Drawing.Point(136, 139)
        Me.txtbatch_no.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtbatch_no.Name = "txtbatch_no"
        Me.txtbatch_no.Size = New System.Drawing.Size(188, 25)
        Me.txtbatch_no.TabIndex = 6
        Me.C1ThemeController1.SetTheme(Me.txtbatch_no, "(default)")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(8, 143)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 15)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "BATCH NO"
        Me.C1ThemeController1.SetTheme(Me.Label11, "(default)")
        '
        'cmbsorttype
        '
        Me.cmbsorttype.BackColor = System.Drawing.Color.White
        Me.cmbsorttype.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.cmbsorttype.FormattingEnabled = True
        Me.cmbsorttype.Location = New System.Drawing.Point(136, 106)
        Me.cmbsorttype.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbsorttype.Name = "cmbsorttype"
        Me.cmbsorttype.Size = New System.Drawing.Size(188, 25)
        Me.cmbsorttype.TabIndex = 5
        Me.C1ThemeController1.SetTheme(Me.cmbsorttype, "(default)")
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(8, 112)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 15)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "SORT TYPE"
        Me.C1ThemeController1.SetTheme(Me.Label12, "(default)")
        '
        'txtcarton_wg
        '
        Me.txtcarton_wg.BackColor = System.Drawing.Color.White
        Me.txtcarton_wg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtcarton_wg.Location = New System.Drawing.Point(136, 240)
        Me.txtcarton_wg.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtcarton_wg.Name = "txtcarton_wg"
        Me.txtcarton_wg.Size = New System.Drawing.Size(97, 25)
        Me.txtcarton_wg.TabIndex = 9
        Me.C1ThemeController1.SetTheme(Me.txtcarton_wg, "(default)")
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(9, 245)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 15)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "CARTON QTY"
        Me.C1ThemeController1.SetTheme(Me.Label13, "(default)")
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(309, 53)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(27, 15)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "OR"
        Me.C1ThemeController1.SetTheme(Me.Label14, "(default)")
        '
        'txtsap_code
        '
        Me.txtsap_code.BackColor = System.Drawing.Color.White
        Me.txtsap_code.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtsap_code.Location = New System.Drawing.Point(136, 72)
        Me.txtsap_code.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtsap_code.Name = "txtsap_code"
        Me.txtsap_code.Size = New System.Drawing.Size(378, 25)
        Me.txtsap_code.TabIndex = 4
        Me.C1ThemeController1.SetTheme(Me.txtsap_code, "(default)")
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(8, 79)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 15)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "SAP CODE"
        Me.C1ThemeController1.SetTheme(Me.Label15, "(default)")
        '
        'cmbproduct
        '
        Me.cmbproduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbproduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbproduct.BackColor = System.Drawing.Color.White
        Me.cmbproduct.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.cmbproduct.FormattingEnabled = True
        Me.cmbproduct.Location = New System.Drawing.Point(136, 26)
        Me.cmbproduct.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbproduct.Name = "cmbproduct"
        Me.cmbproduct.Size = New System.Drawing.Size(378, 25)
        Me.cmbproduct.TabIndex = 3
        Me.C1ThemeController1.SetTheme(Me.cmbproduct, "(default)")
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(7, 26)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 15)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "PRODUCT"
        Me.C1ThemeController1.SetTheme(Me.Label16, "(default)")
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(131, 285)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(87, 29)
        Me.btnsave.TabIndex = 14
        Me.btnsave.Text = "SAVE"
        Me.C1ThemeController1.SetTheme(Me.btnsave, "(default)")
        Me.btnsave.UseVisualStyleBackColor = True
        Me.btnsave.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(237, 285)
        Me.btnclear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(87, 29)
        Me.btnclear.TabIndex = 15
        Me.btnclear.Text = "CLEAR"
        Me.C1ThemeController1.SetTheme(Me.btnclear, "(default)")
        Me.btnclear.UseVisualStyleBackColor = True
        Me.btnclear.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(344, 285)
        Me.btnclose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(87, 29)
        Me.btnclose.TabIndex = 16
        Me.btnclose.Text = "CLOSE"
        Me.C1ThemeController1.SetTheme(Me.btnclose, "(default)")
        Me.btnclose.UseVisualStyleBackColor = True
        Me.btnclose.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1ThemeController1
        '
        Me.C1ThemeController1.Theme = "Windows8Green"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmsfgbarocodeprint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(562, 319)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmsfgbarocodeprint"
        Me.Text = "SFG BARCODE PRINT"
        Me.C1ThemeController1.SetTheme(Me, "(default)")
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.btnsave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnclear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtcarton_weight As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtpack_size As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtbatch_no As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbsorttype As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtcarton_wg As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtsap_code As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmbproduct As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnsave As C1.Win.C1Input.C1Button
    Friend WithEvents btnclear As C1.Win.C1Input.C1Button
    Friend WithEvents btnclose As C1.Win.C1Input.C1Button
    Friend WithEvents C1ThemeController1 As C1.Win.C1Themes.C1ThemeController
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
