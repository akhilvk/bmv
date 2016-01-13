<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFinalPack
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFinalPack))
        Me.btnsave = New C1.Win.C1Input.C1Button
        Me.C1ThemeController1 = New C1.Win.C1Themes.C1ThemeController
        Me.C1SuperTooltip1 = New C1.Win.C1SuperTooltip.C1SuperTooltip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtCount = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.CmbProduct = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtQty = New System.Windows.Forms.TextBox
        Me.txtWeight = New System.Windows.Forms.TextBox
        Me.TxtPack = New System.Windows.Forms.TextBox
        Me.txtBatch = New System.Windows.Forms.TextBox
        Me.txtSap = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.CmbSort = New System.Windows.Forms.ComboBox
        Me.btnClear = New C1.Win.C1Input.C1Button
        Me.btnClose = New C1.Win.C1Input.C1Button
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.btnsave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.btnClear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(152, 252)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(79, 26)
        Me.btnsave.TabIndex = 0
        Me.btnsave.Text = "&Save"
        Me.C1ThemeController1.SetTheme(Me.btnsave, "(default)")
        Me.btnsave.UseVisualStyleBackColor = True
        Me.btnsave.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1ThemeController1
        '
        Me.C1ThemeController1.Theme = "Windows8Green"
        '
        'C1SuperTooltip1
        '
        Me.C1SuperTooltip1.BackgroundGradient = C1.Win.C1SuperTooltip.BackgroundGradient.None
        Me.C1SuperTooltip1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.C1SuperTooltip1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.C1ThemeController1.SetTheme(Me.C1SuperTooltip1, "(default)")
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtCount)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.CmbProduct)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtQty)
        Me.GroupBox1.Controls.Add(Me.txtWeight)
        Me.GroupBox1.Controls.Add(Me.TxtPack)
        Me.GroupBox1.Controls.Add(Me.txtBatch)
        Me.GroupBox1.Controls.Add(Me.txtSap)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(534, 234)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.C1ThemeController1.SetTheme(Me.GroupBox1, "(default)")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(327, 201)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(139, 17)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Packets in Each Carton"
        Me.C1ThemeController1.SetTheme(Me.Label10, "(default)")
        '
        'txtCount
        '
        Me.txtCount.BackColor = System.Drawing.Color.White
        Me.txtCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtCount.Location = New System.Drawing.Point(468, 197)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.Size = New System.Drawing.Size(43, 25)
        Me.txtCount.TabIndex = 16
        Me.C1ThemeController1.SetTheme(Me.txtCount, "(default)")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(310, 201)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 17)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "X"
        Me.C1ThemeController1.SetTheme(Me.Label9, "(default)")
        '
        'CmbProduct
        '
        Me.CmbProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbProduct.BackColor = System.Drawing.Color.White
        Me.CmbProduct.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbProduct.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.CmbProduct.FormattingEnabled = True
        Me.CmbProduct.Location = New System.Drawing.Point(165, 24)
        Me.CmbProduct.Name = "CmbProduct"
        Me.CmbProduct.Size = New System.Drawing.Size(351, 24)
        Me.CmbProduct.TabIndex = 0
        Me.C1ThemeController1.SetTheme(Me.CmbProduct, "(default)")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(11, 201)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "No of Carton To Be Print"
        Me.C1ThemeController1.SetTheme(Me.Label7, "(default)")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(11, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Total Carton Weight"
        Me.C1ThemeController1.SetTheme(Me.Label8, "(default)")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(11, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Pack Size In Gram"
        Me.C1ThemeController1.SetTheme(Me.Label5, "(default)")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(11, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Batch No"
        Me.C1ThemeController1.SetTheme(Me.Label6, "(default)")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(11, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "SAP Code"
        Me.C1ThemeController1.SetTheme(Me.Label3, "(default)")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(355, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "OR"
        Me.C1ThemeController1.SetTheme(Me.Label2, "(default)")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(11, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Product"
        Me.C1ThemeController1.SetTheme(Me.Label1, "(default)")
        '
        'TxtQty
        '
        Me.TxtQty.BackColor = System.Drawing.Color.White
        Me.TxtQty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TxtQty.Location = New System.Drawing.Point(165, 197)
        Me.TxtQty.Name = "TxtQty"
        Me.TxtQty.Size = New System.Drawing.Size(140, 25)
        Me.TxtQty.TabIndex = 6
        Me.C1ThemeController1.SetTheme(Me.TxtQty, "(default)")
        '
        'txtWeight
        '
        Me.txtWeight.BackColor = System.Drawing.Color.White
        Me.txtWeight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtWeight.Location = New System.Drawing.Point(165, 165)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(140, 25)
        Me.txtWeight.TabIndex = 5
        Me.C1ThemeController1.SetTheme(Me.txtWeight, "(default)")
        '
        'TxtPack
        '
        Me.TxtPack.BackColor = System.Drawing.Color.White
        Me.TxtPack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TxtPack.Location = New System.Drawing.Point(165, 133)
        Me.TxtPack.Name = "TxtPack"
        Me.TxtPack.Size = New System.Drawing.Size(140, 25)
        Me.TxtPack.TabIndex = 4
        Me.C1ThemeController1.SetTheme(Me.TxtPack, "(default)")
        '
        'txtBatch
        '
        Me.txtBatch.BackColor = System.Drawing.Color.White
        Me.txtBatch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBatch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtBatch.Location = New System.Drawing.Point(165, 101)
        Me.txtBatch.Name = "txtBatch"
        Me.txtBatch.Size = New System.Drawing.Size(209, 25)
        Me.txtBatch.TabIndex = 3
        Me.C1ThemeController1.SetTheme(Me.txtBatch, "(default)")
        '
        'txtSap
        '
        Me.txtSap.BackColor = System.Drawing.Color.White
        Me.txtSap.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtSap.Location = New System.Drawing.Point(165, 67)
        Me.txtSap.Name = "txtSap"
        Me.txtSap.Size = New System.Drawing.Size(351, 25)
        Me.txtSap.TabIndex = 1
        Me.C1ThemeController1.SetTheme(Me.txtSap, "(default)")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(93, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "SORT TYPE"
        Me.C1ThemeController1.SetTheme(Me.Label4, "(default)")
        '
        'CmbSort
        '
        Me.CmbSort.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbSort.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbSort.BackColor = System.Drawing.Color.White
        Me.CmbSort.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.CmbSort.FormattingEnabled = True
        Me.CmbSort.Location = New System.Drawing.Point(206, 107)
        Me.CmbSort.Name = "CmbSort"
        Me.CmbSort.Size = New System.Drawing.Size(210, 25)
        Me.CmbSort.TabIndex = 2
        Me.C1ThemeController1.SetTheme(Me.CmbSort, "(default)")
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(236, 252)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(79, 26)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "C&lear"
        Me.C1ThemeController1.SetTheme(Me.btnClear, "(default)")
        Me.btnClear.UseVisualStyleBackColor = True
        Me.btnClear.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(320, 252)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(79, 26)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "&Close"
        Me.C1ThemeController1.SetTheme(Me.btnClose, "(default)")
        Me.btnClose.UseVisualStyleBackColor = True
        Me.btnClose.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FrmFinalPack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(551, 285)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.CmbSort)
        Me.Controls.Add(Me.Label4)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FrmFinalPack"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "After Final Pack"
        Me.C1ThemeController1.SetTheme(Me, "(default)")
        CType(Me.btnsave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.btnClear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsave As C1.Win.C1Input.C1Button
    Friend WithEvents C1ThemeController1 As C1.Win.C1Themes.C1ThemeController
    Friend WithEvents C1SuperTooltip1 As C1.Win.C1SuperTooltip.C1SuperTooltip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClose As C1.Win.C1Input.C1Button
    Friend WithEvents btnClear As C1.Win.C1Input.C1Button
    Friend WithEvents txtSap As System.Windows.Forms.TextBox
    Friend WithEvents CmbSort As System.Windows.Forms.ComboBox
    Friend WithEvents txtBatch As System.Windows.Forms.TextBox
    Friend WithEvents TxtQty As System.Windows.Forms.TextBox
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents TxtPack As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbProduct As System.Windows.Forms.ComboBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtCount As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label

End Class
