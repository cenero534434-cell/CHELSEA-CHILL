<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AssistantMngr_Inventory_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AssistantMngr_Inventory_Form))
        Me.DataGridInventory = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BTN_LOGOUT = New System.Windows.Forms.Button()
        Me.BTN_INVENTORY = New System.Windows.Forms.Button()
        Me.BTN_REPORT = New System.Windows.Forms.Button()
        Me.BTN_EXPENSE = New System.Windows.Forms.Button()
        Me.BTN_DASHBOARD = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTN_CASHIER = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New Chelsea_Chill_02.RoundCornerTextbox()
        CType(Me.DataGridInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridInventory
        '
        Me.DataGridInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridInventory.BackgroundColor = System.Drawing.Color.LightBlue
        Me.DataGridInventory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridInventory.Location = New System.Drawing.Point(305, 186)
        Me.DataGridInventory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridInventory.Name = "DataGridInventory"
        Me.DataGridInventory.RowHeadersVisible = False
        Me.DataGridInventory.RowHeadersWidth = 51
        Me.DataGridInventory.RowTemplate.Height = 24
        Me.DataGridInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridInventory.Size = New System.Drawing.Size(1075, 572)
        Me.DataGridInventory.TabIndex = 184
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(251, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1191, 60)
        Me.Panel2.TabIndex = 183
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(507, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INVENTORY"
        '
        'btnReload
        '
        Me.btnReload.BackColor = System.Drawing.Color.SkyBlue
        Me.btnReload.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReload.Location = New System.Drawing.Point(1211, 773)
        Me.btnReload.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(169, 62)
        Me.btnReload.TabIndex = 212
        Me.btnReload.Text = "Refresh"
        Me.btnReload.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.BTN_LOGOUT)
        Me.Panel1.Controls.Add(Me.BTN_INVENTORY)
        Me.Panel1.Controls.Add(Me.BTN_REPORT)
        Me.Panel1.Controls.Add(Me.BTN_EXPENSE)
        Me.Panel1.Controls.Add(Me.BTN_DASHBOARD)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.BTN_CASHIER)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(253, 900)
        Me.Panel1.TabIndex = 213
        '
        'BTN_LOGOUT
        '
        Me.BTN_LOGOUT.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTN_LOGOUT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_LOGOUT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BTN_LOGOUT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_LOGOUT.Location = New System.Drawing.Point(60, 834)
        Me.BTN_LOGOUT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_LOGOUT.Name = "BTN_LOGOUT"
        Me.BTN_LOGOUT.Size = New System.Drawing.Size(120, 46)
        Me.BTN_LOGOUT.TabIndex = 44
        Me.BTN_LOGOUT.Text = "Log Out"
        Me.BTN_LOGOUT.UseVisualStyleBackColor = False
        '
        'BTN_INVENTORY
        '
        Me.BTN_INVENTORY.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BTN_INVENTORY.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_INVENTORY.Location = New System.Drawing.Point(29, 281)
        Me.BTN_INVENTORY.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_INVENTORY.Name = "BTN_INVENTORY"
        Me.BTN_INVENTORY.Size = New System.Drawing.Size(191, 68)
        Me.BTN_INVENTORY.TabIndex = 13
        Me.BTN_INVENTORY.Text = "Inventory"
        Me.BTN_INVENTORY.UseVisualStyleBackColor = False
        '
        'BTN_REPORT
        '
        Me.BTN_REPORT.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_REPORT.Location = New System.Drawing.Point(29, 370)
        Me.BTN_REPORT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_REPORT.Name = "BTN_REPORT"
        Me.BTN_REPORT.Size = New System.Drawing.Size(191, 68)
        Me.BTN_REPORT.TabIndex = 12
        Me.BTN_REPORT.Text = "Report"
        Me.BTN_REPORT.UseVisualStyleBackColor = True
        '
        'BTN_EXPENSE
        '
        Me.BTN_EXPENSE.BackColor = System.Drawing.Color.White
        Me.BTN_EXPENSE.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EXPENSE.Location = New System.Drawing.Point(29, 459)
        Me.BTN_EXPENSE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_EXPENSE.Name = "BTN_EXPENSE"
        Me.BTN_EXPENSE.Size = New System.Drawing.Size(191, 68)
        Me.BTN_EXPENSE.TabIndex = 11
        Me.BTN_EXPENSE.Text = "Expenses"
        Me.BTN_EXPENSE.UseVisualStyleBackColor = False
        '
        'BTN_DASHBOARD
        '
        Me.BTN_DASHBOARD.BackColor = System.Drawing.Color.White
        Me.BTN_DASHBOARD.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_DASHBOARD.Location = New System.Drawing.Point(29, 192)
        Me.BTN_DASHBOARD.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_DASHBOARD.Name = "BTN_DASHBOARD"
        Me.BTN_DASHBOARD.Size = New System.Drawing.Size(191, 68)
        Me.BTN_DASHBOARD.TabIndex = 9
        Me.BTN_DASHBOARD.Text = "Dashboard"
        Me.BTN_DASHBOARD.UseVisualStyleBackColor = False
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
        'BTN_CASHIER
        '
        Me.BTN_CASHIER.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BTN_CASHIER.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CASHIER.Location = New System.Drawing.Point(29, 546)
        Me.BTN_CASHIER.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_CASHIER.Name = "BTN_CASHIER"
        Me.BTN_CASHIER.Size = New System.Drawing.Size(191, 68)
        Me.BTN_CASHIER.TabIndex = 8
        Me.BTN_CASHIER.Text = "Cashier"
        Me.BTN_CASHIER.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(308, 134)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 214
        Me.PictureBox2.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(345, 111)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 20)
        Me.Label11.TabIndex = 218
        Me.Label11.Text = "Search:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(856, 110)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(149, 20)
        Me.Label10.TabIndex = 220
        Me.Label10.Text = "Select Category:"
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Items.AddRange(New Object() {"All Categories", "Food/Ingredients", "Drinks", "Raw Materials", "Others"})
        Me.cmbCategory.Location = New System.Drawing.Point(857, 137)
        Me.cmbCategory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(321, 24)
        Me.cmbCategory.TabIndex = 219
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(340, 135)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(485, 31)
        Me.txtSearch.TabIndex = 215
        '
        'AssistantMngr_Inventory_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1440, 900)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnReload)
        Me.Controls.Add(Me.DataGridInventory)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "AssistantMngr_Inventory_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AssistantMngr_Inventory_Form"
        CType(Me.DataGridInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridInventory As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnReload As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTN_LOGOUT As Button
    Friend WithEvents BTN_INVENTORY As Button
    Friend WithEvents BTN_REPORT As Button
    Friend WithEvents BTN_EXPENSE As Button
    Friend WithEvents BTN_DASHBOARD As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BTN_CASHIER As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtSearch As RoundCornerTextbox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbCategory As ComboBox
End Class
