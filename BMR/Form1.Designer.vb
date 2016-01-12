<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim C1FlexGrid1 As C1.Win.C1FlexGrid.C1FlexGrid
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.C1Button1 = New C1.Win.C1Input.C1Button
        Me.C1ThemeController1 = New C1.Win.C1Themes.C1ThemeController
        Me.C1Label1 = New C1.Win.C1Input.C1Label
        Me.C1TextBox1 = New C1.Win.C1Input.C1TextBox
        Me.C1SuperErrorProvider1 = New C1.Win.C1SuperTooltip.C1SuperErrorProvider(Me.components)
        Me.C1SuperTooltip1 = New C1.Win.C1SuperTooltip.C1SuperTooltip(Me.components)
        C1FlexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid
        CType(C1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Button1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1SuperErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1FlexGrid1
        '
        C1FlexGrid1.AllowEditing = False
        C1FlexGrid1.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        C1FlexGrid1.BackColor = System.Drawing.Color.White
        C1FlexGrid1.ColumnInfo = "10,1,0,0,0,130,Columns:"
        C1FlexGrid1.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        C1FlexGrid1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        C1FlexGrid1.Location = New System.Drawing.Point(14, 140)
        C1FlexGrid1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        C1FlexGrid1.Name = "C1FlexGrid1"
        C1FlexGrid1.Rows.DefaultSize = 26
        C1FlexGrid1.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        C1FlexGrid1.Size = New System.Drawing.Size(571, 203)
        C1FlexGrid1.StyleInfo = resources.GetString("C1FlexGrid1.StyleInfo")
        C1FlexGrid1.TabIndex = 3
        Me.C1ThemeController1.SetTheme(C1FlexGrid1, "(default)")
        '
        'C1Button1
        '
        Me.C1Button1.Location = New System.Drawing.Point(206, 102)
        Me.C1Button1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.C1Button1.Name = "C1Button1"
        Me.C1Button1.Size = New System.Drawing.Size(90, 30)
        Me.C1Button1.TabIndex = 0
        Me.C1Button1.Text = "C1Button1"
        Me.C1ThemeController1.SetTheme(Me.C1Button1, "(default)")
        Me.C1Button1.UseVisualStyleBackColor = True
        Me.C1Button1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1Label1
        '
        Me.C1Label1.AutoSize = True
        Me.C1Label1.BackColor = System.Drawing.Color.Transparent
        Me.C1Label1.BorderColor = System.Drawing.Color.Transparent
        Me.C1Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.C1Label1.Location = New System.Drawing.Point(158, 41)
        Me.C1Label1.Name = "C1Label1"
        Me.C1Label1.Size = New System.Drawing.Size(70, 20)
        Me.C1Label1.TabIndex = 1
        Me.C1Label1.Tag = Nothing
        Me.C1ThemeController1.SetTheme(Me.C1Label1, "(default)")
        Me.C1Label1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Custom
        '
        'C1TextBox1
        '
        Me.C1TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1TextBox1.Location = New System.Drawing.Point(272, 38)
        Me.C1TextBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.C1TextBox1.Name = "C1TextBox1"
        Me.C1TextBox1.Size = New System.Drawing.Size(216, 25)
        Me.C1TextBox1.TabIndex = 2
        Me.C1TextBox1.Tag = Nothing
        Me.C1ThemeController1.SetTheme(Me.C1TextBox1, "(default)")
        Me.C1TextBox1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(611, 360)
        Me.Controls.Add(C1FlexGrid1)
        Me.Controls.Add(Me.C1TextBox1)
        Me.Controls.Add(Me.C1Label1)
        Me.Controls.Add(Me.C1Button1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.C1ThemeController1.SetTheme(Me, "(default)")
        CType(C1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Button1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1SuperErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents C1Button1 As C1.Win.C1Input.C1Button
    Friend WithEvents C1ThemeController1 As C1.Win.C1Themes.C1ThemeController
    Friend WithEvents C1Label1 As C1.Win.C1Input.C1Label
    Friend WithEvents C1TextBox1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1SuperErrorProvider1 As C1.Win.C1SuperTooltip.C1SuperErrorProvider
    Friend WithEvents C1SuperTooltip1 As C1.Win.C1SuperTooltip.C1SuperTooltip

End Class
