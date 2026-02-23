<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Manager_Inventory_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Manager_Inventory_Form))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataGridInventory = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProductID = New System.Windows.Forms.TextBox()
        Me.Category = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Quantity = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Unit = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Description = New System.Windows.Forms.TextBox()
        Me.btnArchive = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.DateAdded = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BTN_LOGOUT = New System.Windows.Forms.Button()
        Me.BTN_SYSTEMMNGMNT = New System.Windows.Forms.Button()
        Me.BTN_INVENTORY = New System.Windows.Forms.Button()
        Me.BTN_REPORT = New System.Windows.Forms.Button()
        Me.BTN_EXPENSE = New System.Windows.Forms.Button()
        Me.BTN_DASHBOARD = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTN_CASHIER = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSearch = New Chelsea_Chill_02.RoundCornerTextbox()
        Me.ExpirationDate = New System.Windows.Forms.DateTimePicker()
        CType(Me.DataGridInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(301, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 25)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "Product Name"
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(307, 107)
        Me.txtProductName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtProductName.Multiline = True
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(359, 32)
        Me.txtProductName.TabIndex = 80
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(1120, 146)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 25)
        Me.Label9.TabIndex = 83
        Me.Label9.Text = "Date Added"
        '
        'DataGridInventory
        '
        Me.DataGridInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridInventory.BackgroundColor = System.Drawing.Color.LightBlue
        Me.DataGridInventory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridInventory.Location = New System.Drawing.Point(307, 462)
        Me.DataGridInventory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridInventory.Name = "DataGridInventory"
        Me.DataGridInventory.RowHeadersVisible = False
        Me.DataGridInventory.RowHeadersWidth = 51
        Me.DataGridInventory.RowTemplate.Height = 24
        Me.DataGridInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridInventory.Size = New System.Drawing.Size(1075, 414)
        Me.DataGridInventory.TabIndex = 64
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(715, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 25)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Product ID"
        Me.Label2.Visible = False
        '
        'ProductID
        '
        Me.ProductID.Location = New System.Drawing.Point(720, 106)
        Me.ProductID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ProductID.Multiline = True
        Me.ProductID.Name = "ProductID"
        Me.ProductID.Size = New System.Drawing.Size(356, 32)
        Me.ProductID.TabIndex = 65
        Me.ProductID.Visible = False
        '
        'Category
        '
        Me.Category.FormattingEnabled = True
        Me.Category.Items.AddRange(New Object() {"Food/Ingredients", "Drinks", "Raw Materials", "Others"})
        Me.Category.Location = New System.Drawing.Point(727, 108)
        Me.Category.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Category.Name = "Category"
        Me.Category.Size = New System.Drawing.Size(359, 24)
        Me.Category.TabIndex = 70
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(251, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1191, 60)
        Me.Panel2.TabIndex = 63
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(722, 207)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 25)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Quantity"
        '
        'Quantity
        '
        Me.Quantity.Location = New System.Drawing.Point(719, 236)
        Me.Quantity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Quantity.Multiline = True
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Size = New System.Drawing.Size(359, 32)
        Me.Quantity.TabIndex = 75
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(722, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 25)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Unit"
        '
        'Unit
        '
        Me.Unit.FormattingEnabled = True
        Me.Unit.Items.AddRange(New Object() {"bottles", "liters", "kilograms", "grams", "pieces"})
        Me.Unit.Location = New System.Drawing.Point(719, 171)
        Me.Unit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Unit.Name = "Unit"
        Me.Unit.Size = New System.Drawing.Size(359, 24)
        Me.Unit.TabIndex = 73
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(722, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 25)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Category"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(1120, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 25)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Expiration Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(303, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 25)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "Description"
        '
        'Description
        '
        Me.Description.Location = New System.Drawing.Point(307, 180)
        Me.Description.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Description.Multiline = True
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(359, 155)
        Me.Description.TabIndex = 86
        '
        'btnArchive
        '
        Me.btnArchive.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnArchive.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArchive.Location = New System.Drawing.Point(1299, 304)
        Me.btnArchive.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnArchive.Name = "btnArchive"
        Me.btnArchive.Size = New System.Drawing.Size(116, 48)
        Me.btnArchive.TabIndex = 179
        Me.btnArchive.Text = "Remove"
        Me.btnArchive.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(1161, 304)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(116, 48)
        Me.btnUpdate.TabIndex = 177
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(1017, 304)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(120, 48)
        Me.btnAdd.TabIndex = 176
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'DateAdded
        '
        Me.DateAdded.Location = New System.Drawing.Point(1125, 176)
        Me.DateAdded.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateAdded.Name = "DateAdded"
        Me.DateAdded.Size = New System.Drawing.Size(279, 22)
        Me.DateAdded.TabIndex = 89
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.BTN_LOGOUT)
        Me.Panel1.Controls.Add(Me.BTN_SYSTEMMNGMNT)
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
        Me.Panel1.TabIndex = 214
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
        'BTN_SYSTEMMNGMNT
        '
        Me.BTN_SYSTEMMNGMNT.BackColor = System.Drawing.Color.White
        Me.BTN_SYSTEMMNGMNT.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_SYSTEMMNGMNT.Location = New System.Drawing.Point(29, 633)
        Me.BTN_SYSTEMMNGMNT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_SYSTEMMNGMNT.Name = "BTN_SYSTEMMNGMNT"
        Me.BTN_SYSTEMMNGMNT.Size = New System.Drawing.Size(191, 81)
        Me.BTN_SYSTEMMNGMNT.TabIndex = 14
        Me.BTN_SYSTEMMNGMNT.Text = "System Management"
        Me.BTN_SYSTEMMNGMNT.UseVisualStyleBackColor = False
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
        Me.PictureBox2.Location = New System.Drawing.Point(695, 418)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 45
        Me.PictureBox2.TabStop = False
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Items.AddRange(New Object() {"All Categories", "Food/Ingredients", "Drinks", "Raw Materials", "Others"})
        Me.cmbCategory.Location = New System.Drawing.Point(311, 426)
        Me.cmbCategory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(355, 24)
        Me.cmbCategory.TabIndex = 92
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(309, 399)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(149, 20)
        Me.Label10.TabIndex = 93
        Me.Label10.Text = "Select Category:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(732, 395)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 20)
        Me.Label11.TabIndex = 94
        Me.Label11.Text = "Search:"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(727, 417)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(375, 31)
        Me.txtSearch.TabIndex = 77
        '
        'ExpirationDate
        '
        Me.ExpirationDate.Location = New System.Drawing.Point(1125, 108)
        Me.ExpirationDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ExpirationDate.Name = "ExpirationDate"
        Me.ExpirationDate.Size = New System.Drawing.Size(279, 22)
        Me.ExpirationDate.TabIndex = 215
        '
        'Manager_Inventory_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1441, 901)
        Me.Controls.Add(Me.ExpirationDate)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnArchive)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.DateAdded)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Description)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DataGridInventory)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ProductID)
        Me.Controls.Add(Me.Category)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Quantity)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Unit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Manager_Inventory_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory_Mngr_Form"
        CType(Me.DataGridInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DataGridInventory As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents ProductID As TextBox
    Friend WithEvents Category As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtSearch As RoundCornerTextbox
    Friend WithEvents Label7 As Label
    Friend WithEvents Quantity As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Unit As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Description As TextBox
    Friend WithEvents btnArchive As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents DateAdded As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTN_LOGOUT As Button
    Friend WithEvents BTN_SYSTEMMNGMNT As Button
    Friend WithEvents BTN_INVENTORY As Button
    Friend WithEvents BTN_REPORT As Button
    Friend WithEvents BTN_EXPENSE As Button
    Friend WithEvents BTN_DASHBOARD As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BTN_CASHIER As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ExpirationDate As DateTimePicker
End Class
