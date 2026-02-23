<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Maintenance_EM_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Maintenance_EM_Form))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridUser = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtposition = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BTN_LOGOUT = New System.Windows.Forms.Button()
        Me.BTN_SYSTEMMNGMNT = New System.Windows.Forms.Button()
        Me.BTN_INVENTORY = New System.Windows.Forms.Button()
        Me.BTN_REPORT = New System.Windows.Forms.Button()
        Me.BTN_EXPENSE = New System.Windows.Forms.Button()
        Me.BTN_DASHBOARD = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTN_CASHIER = New System.Windows.Forms.Button()
        Me.txtpassword = New Chelsea_Chill_02.RoundCornerTextbox()
        Me.txtusername = New Chelsea_Chill_02.RoundCornerTextbox()
        Me.txtcontact = New Chelsea_Chill_02.RoundCornerTextbox()
        Me.txtaddress = New Chelsea_Chill_02.RoundCornerTextbox()
        Me.txtname = New Chelsea_Chill_02.RoundCornerTextbox()
        Me.txtcnfrmpass = New Chelsea_Chill_02.RoundCornerTextbox()
        CType(Me.DataGridUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(937, 241)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 25)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Password:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(932, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 25)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = "Username:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(420, 337)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 25)
        Me.Label4.TabIndex = 90
        Me.Label4.Text = "Contact:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(416, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 25)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Address:"
        '
        'DataGridUser
        '
        Me.DataGridUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridUser.BackgroundColor = System.Drawing.Color.White
        Me.DataGridUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridUser.Location = New System.Drawing.Point(305, 528)
        Me.DataGridUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridUser.Name = "DataGridUser"
        Me.DataGridUser.RowHeadersVisible = False
        Me.DataGridUser.RowHeadersWidth = 51
        Me.DataGridUser.RowTemplate.Height = 24
        Me.DataGridUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridUser.Size = New System.Drawing.Size(1075, 343)
        Me.DataGridUser.TabIndex = 76
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(253, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1187, 60)
        Me.Panel2.TabIndex = 75
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(405, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(355, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SYSTEM MANAGEMENT"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(851, 315)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(194, 25)
        Me.Label7.TabIndex = 95
        Me.Label7.Text = "Confirm Password:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(416, 390)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 25)
        Me.Label13.TabIndex = 97
        Me.Label13.Text = "Position:"
        '
        'txtposition
        '
        Me.txtposition.FormattingEnabled = True
        Me.txtposition.Items.AddRange(New Object() {"Manager", "Assistant Manager", "Staff"})
        Me.txtposition.Location = New System.Drawing.Point(527, 394)
        Me.txtposition.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtposition.Name = "txtposition"
        Me.txtposition.Size = New System.Drawing.Size(263, 24)
        Me.txtposition.TabIndex = 98
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(443, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 25)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Name:"
        '
        'txtID
        '
        Me.txtID.AutoSize = True
        Me.txtID.BackColor = System.Drawing.Color.Transparent
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(264, 159)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(134, 25)
        Me.txtID.TabIndex = 102
        Me.txtID.Text = "Employee ID"
        Me.txtID.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Location = New System.Drawing.Point(1127, 273)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(125, 20)
        Me.CheckBox1.TabIndex = 103
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.Location = New System.Drawing.Point(1127, 351)
        Me.CheckBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(125, 20)
        Me.CheckBox2.TabIndex = 104
        Me.CheckBox2.Text = "Show Password"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(1207, 417)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(116, 48)
        Me.btnUpdate.TabIndex = 228
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(1068, 417)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 48)
        Me.btnSave.TabIndex = 227
        Me.btnSave.Text = "Add"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel7.BackgroundImage = CType(resources.GetObject("Panel7.BackgroundImage"), System.Drawing.Image)
        Me.Panel7.Controls.Add(Me.PictureBox3)
        Me.Panel7.Controls.Add(Me.Button14)
        Me.Panel7.Controls.Add(Me.PictureBox2)
        Me.Panel7.Controls.Add(Me.Button15)
        Me.Panel7.Controls.Add(Me.PictureBox5)
        Me.Panel7.Controls.Add(Me.Button16)
        Me.Panel7.Location = New System.Drawing.Point(264, 65)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1155, 75)
        Me.Panel7.TabIndex = 230
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Image = Global.Chelsea_Chill_02.My.Resources.Resources._3067451
        Me.PictureBox3.Location = New System.Drawing.Point(807, 14)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(77, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.White
        Me.Button14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.Location = New System.Drawing.Point(888, 12)
        Me.Button14.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(219, 49)
        Me.Button14.TabIndex = 7
        Me.Button14.Text = "System Settings"
        Me.Button14.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = Global.Chelsea_Chill_02.My.Resources.Resources._3620688
        Me.PictureBox2.Location = New System.Drawing.Point(487, 14)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(77, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.White
        Me.Button15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.Location = New System.Drawing.Point(571, 14)
        Me.Button15.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(115, 49)
        Me.Button15.TabIndex = 5
        Me.Button15.Text = "Supplier"
        Me.Button15.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PictureBox5.Image = Global.Chelsea_Chill_02.My.Resources.Resources._1427815
        Me.PictureBox5.Location = New System.Drawing.Point(45, 12)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(77, 50)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.Location = New System.Drawing.Point(128, 14)
        Me.Button16.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(267, 49)
        Me.Button16.TabIndex = 0
        Me.Button16.Text = "Employee Management"
        Me.Button16.UseVisualStyleBackColor = False
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
        Me.Panel1.TabIndex = 231
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
        Me.BTN_SYSTEMMNGMNT.BackColor = System.Drawing.Color.LightSkyBlue
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
        Me.BTN_INVENTORY.BackColor = System.Drawing.Color.White
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
        'txtpassword
        '
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpassword.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(1064, 236)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(5)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(259, 27)
        Me.txtpassword.TabIndex = 28
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(1060, 185)
        Me.txtusername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtusername.Multiline = True
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(263, 30)
        Me.txtusername.TabIndex = 88
        '
        'txtcontact
        '
        Me.txtcontact.Location = New System.Drawing.Point(527, 334)
        Me.txtcontact.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcontact.Multiline = True
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(263, 34)
        Me.txtcontact.TabIndex = 87
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(527, 236)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(263, 80)
        Me.txtaddress.TabIndex = 86
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(527, 185)
        Me.txtname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtname.Multiline = True
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(263, 34)
        Me.txtname.TabIndex = 85
        '
        'txtcnfrmpass
        '
        Me.txtcnfrmpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcnfrmpass.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcnfrmpass.Location = New System.Drawing.Point(1064, 311)
        Me.txtcnfrmpass.Margin = New System.Windows.Forms.Padding(5)
        Me.txtcnfrmpass.Name = "txtcnfrmpass"
        Me.txtcnfrmpass.Size = New System.Drawing.Size(259, 27)
        Me.txtcnfrmpass.TabIndex = 233
        Me.txtcnfrmpass.UseSystemPasswordChar = True
        '
        'Maintenance_EM_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1440, 900)
        Me.Controls.Add(Me.txtcnfrmpass)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtposition)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.txtcontact)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DataGridUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Maintenance_EM_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maintainance_EM_Form"
        CType(Me.DataGridUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtusername As RoundCornerTextbox
    Friend WithEvents txtcontact As RoundCornerTextbox
    Friend WithEvents txtaddress As RoundCornerTextbox
    Friend WithEvents txtname As RoundCornerTextbox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridUser As DataGridView
    Friend WithEvents txtpassword As RoundCornerTextbox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtposition As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtID As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button14 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button15 As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Button16 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTN_LOGOUT As Button
    Friend WithEvents BTN_SYSTEMMNGMNT As Button
    Friend WithEvents BTN_INVENTORY As Button
    Friend WithEvents BTN_REPORT As Button
    Friend WithEvents BTN_EXPENSE As Button
    Friend WithEvents BTN_DASHBOARD As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BTN_CASHIER As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcnfrmpass As RoundCornerTextbox
End Class
