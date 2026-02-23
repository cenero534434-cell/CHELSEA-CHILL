<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Manager_Dashboard_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Manager_Dashboard_Form))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.StockStatus = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Expenses = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BTN_LOGOUT = New System.Windows.Forms.Button()
        Me.Maintenance_BTN = New System.Windows.Forms.Button()
        Me.Inventory_BTN = New System.Windows.Forms.Button()
        Me.Report_BTN = New System.Windows.Forms.Button()
        Me.Cashier_BTN = New System.Windows.Forms.Button()
        Me.Financial_BTN = New System.Windows.Forms.Button()
        Me.Dashboard_BTN = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.totalSalesLBL = New System.Windows.Forms.Label()
        Me.RoundCornerTextbox4 = New Chelsea_Chill_02.RoundCornerTextbox()
        Me.RoundCornerTextbox3 = New Chelsea_Chill_02.RoundCornerTextbox()
        Me.Panel2.SuspendLayout()
        CType(Me.StockStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(491, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DASHBOARD"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(252, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1191, 60)
        Me.Panel2.TabIndex = 5
        '
        'StockStatus
        '
        Me.StockStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.StockStatus.BackgroundColor = System.Drawing.Color.LightBlue
        Me.StockStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StockStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StockStatus.Location = New System.Drawing.Point(308, 407)
        Me.StockStatus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StockStatus.Name = "StockStatus"
        Me.StockStatus.RowHeadersVisible = False
        Me.StockStatus.RowHeadersWidth = 51
        Me.StockStatus.RowTemplate.Height = 24
        Me.StockStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.StockStatus.Size = New System.Drawing.Size(1075, 450)
        Me.StockStatus.TabIndex = 12
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(308, 359)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1075, 44)
        Me.Panel3.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(469, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Stock Status"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.DarkCyan
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(684, 157)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(115, 74)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 25
        Me.PictureBox4.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DarkCyan
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(538, 185)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 31)
        Me.Label7.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.DarkCyan
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(534, 233)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 25)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Total Sales"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.DarkCyan
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(1058, 157)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(93, 74)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 29
        Me.PictureBox5.TabStop = False
        '
        'Expenses
        '
        Me.Expenses.AutoSize = True
        Me.Expenses.BackColor = System.Drawing.Color.DarkCyan
        Me.Expenses.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Expenses.ForeColor = System.Drawing.Color.White
        Me.Expenses.Location = New System.Drawing.Point(875, 182)
        Me.Expenses.Name = "Expenses"
        Me.Expenses.Size = New System.Drawing.Size(71, 31)
        Me.Expenses.TabIndex = 28
        Me.Expenses.Text = "0.00"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.DarkCyan
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(886, 232)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(162, 25)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Total Expenses"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.BTN_LOGOUT)
        Me.Panel1.Controls.Add(Me.Maintenance_BTN)
        Me.Panel1.Controls.Add(Me.Inventory_BTN)
        Me.Panel1.Controls.Add(Me.Report_BTN)
        Me.Panel1.Controls.Add(Me.Cashier_BTN)
        Me.Panel1.Controls.Add(Me.Financial_BTN)
        Me.Panel1.Controls.Add(Me.Dashboard_BTN)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(253, 900)
        Me.Panel1.TabIndex = 32
        '
        'BTN_LOGOUT
        '
        Me.BTN_LOGOUT.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTN_LOGOUT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_LOGOUT.ForeColor = System.Drawing.Color.Black
        Me.BTN_LOGOUT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_LOGOUT.Location = New System.Drawing.Point(67, 830)
        Me.BTN_LOGOUT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_LOGOUT.Name = "BTN_LOGOUT"
        Me.BTN_LOGOUT.Size = New System.Drawing.Size(115, 42)
        Me.BTN_LOGOUT.TabIndex = 44
        Me.BTN_LOGOUT.Text = "Log Out"
        Me.BTN_LOGOUT.UseVisualStyleBackColor = False
        '
        'Maintenance_BTN
        '
        Me.Maintenance_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Maintenance_BTN.Location = New System.Drawing.Point(29, 633)
        Me.Maintenance_BTN.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Maintenance_BTN.Name = "Maintenance_BTN"
        Me.Maintenance_BTN.Size = New System.Drawing.Size(191, 79)
        Me.Maintenance_BTN.TabIndex = 14
        Me.Maintenance_BTN.Text = "System Management"
        Me.Maintenance_BTN.UseVisualStyleBackColor = True
        '
        'Inventory_BTN
        '
        Me.Inventory_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inventory_BTN.Location = New System.Drawing.Point(29, 281)
        Me.Inventory_BTN.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Inventory_BTN.Name = "Inventory_BTN"
        Me.Inventory_BTN.Size = New System.Drawing.Size(191, 68)
        Me.Inventory_BTN.TabIndex = 13
        Me.Inventory_BTN.Text = "Inventory"
        Me.Inventory_BTN.UseVisualStyleBackColor = True
        '
        'Report_BTN
        '
        Me.Report_BTN.BackColor = System.Drawing.Color.White
        Me.Report_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Report_BTN.Location = New System.Drawing.Point(29, 368)
        Me.Report_BTN.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Report_BTN.Name = "Report_BTN"
        Me.Report_BTN.Size = New System.Drawing.Size(191, 68)
        Me.Report_BTN.TabIndex = 12
        Me.Report_BTN.Text = "Report"
        Me.Report_BTN.UseVisualStyleBackColor = False
        '
        'Cashier_BTN
        '
        Me.Cashier_BTN.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Cashier_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cashier_BTN.Location = New System.Drawing.Point(29, 545)
        Me.Cashier_BTN.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cashier_BTN.Name = "Cashier_BTN"
        Me.Cashier_BTN.Size = New System.Drawing.Size(191, 68)
        Me.Cashier_BTN.TabIndex = 8
        Me.Cashier_BTN.Text = "Cashier"
        Me.Cashier_BTN.UseVisualStyleBackColor = False
        '
        'Financial_BTN
        '
        Me.Financial_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Financial_BTN.Location = New System.Drawing.Point(29, 455)
        Me.Financial_BTN.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Financial_BTN.Name = "Financial_BTN"
        Me.Financial_BTN.Size = New System.Drawing.Size(191, 68)
        Me.Financial_BTN.TabIndex = 11
        Me.Financial_BTN.Text = "Expense"
        Me.Financial_BTN.UseVisualStyleBackColor = True
        '
        'Dashboard_BTN
        '
        Me.Dashboard_BTN.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Dashboard_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dashboard_BTN.Location = New System.Drawing.Point(29, 192)
        Me.Dashboard_BTN.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Dashboard_BTN.Name = "Dashboard_BTN"
        Me.Dashboard_BTN.Size = New System.Drawing.Size(191, 68)
        Me.Dashboard_BTN.TabIndex = 9
        Me.Dashboard_BTN.Text = "Dashboard"
        Me.Dashboard_BTN.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(40, 21)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(171, 118)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'totalSalesLBL
        '
        Me.totalSalesLBL.AutoSize = True
        Me.totalSalesLBL.BackColor = System.Drawing.Color.DarkCyan
        Me.totalSalesLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalSalesLBL.ForeColor = System.Drawing.Color.White
        Me.totalSalesLBL.Location = New System.Drawing.Point(524, 182)
        Me.totalSalesLBL.Name = "totalSalesLBL"
        Me.totalSalesLBL.Size = New System.Drawing.Size(71, 31)
        Me.totalSalesLBL.TabIndex = 33
        Me.totalSalesLBL.Text = "0.00"
        '
        'RoundCornerTextbox4
        '
        Me.RoundCornerTextbox4.BackColor = System.Drawing.Color.DarkCyan
        Me.RoundCornerTextbox4.Location = New System.Drawing.Point(858, 125)
        Me.RoundCornerTextbox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RoundCornerTextbox4.Multiline = True
        Me.RoundCornerTextbox4.Name = "RoundCornerTextbox4"
        Me.RoundCornerTextbox4.Size = New System.Drawing.Size(305, 164)
        Me.RoundCornerTextbox4.TabIndex = 26
        '
        'RoundCornerTextbox3
        '
        Me.RoundCornerTextbox3.BackColor = System.Drawing.Color.DarkCyan
        Me.RoundCornerTextbox3.Location = New System.Drawing.Point(506, 126)
        Me.RoundCornerTextbox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RoundCornerTextbox3.Multiline = True
        Me.RoundCornerTextbox3.Name = "RoundCornerTextbox3"
        Me.RoundCornerTextbox3.Size = New System.Drawing.Size(305, 164)
        Me.RoundCornerTextbox3.TabIndex = 22
        '
        'Manager_Dashboard_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1439, 900)
        Me.Controls.Add(Me.totalSalesLBL)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Expenses)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.RoundCornerTextbox4)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.RoundCornerTextbox3)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.StockStatus)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Manager_Dashboard_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manager Dashboard"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.StockStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents StockStatus As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents RoundCornerTextbox3 As RoundCornerTextbox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Expenses As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents RoundCornerTextbox4 As RoundCornerTextbox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTN_LOGOUT As Button
    Friend WithEvents Maintenance_BTN As Button
    Friend WithEvents Inventory_BTN As Button
    Friend WithEvents Report_BTN As Button
    Friend WithEvents Cashier_BTN As Button
    Friend WithEvents Financial_BTN As Button
    Friend WithEvents Dashboard_BTN As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents totalSalesLBL As Label
End Class
