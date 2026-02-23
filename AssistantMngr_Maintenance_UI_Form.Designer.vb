<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssistantMngr_Maintenance_UI_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AssistantMngr_Maintenance_UI_Form))
        Me.txtID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridUser = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BTN_LOGOUT = New System.Windows.Forms.Button()
        Me.BTN_INVENTORY = New System.Windows.Forms.Button()
        Me.BTN_REPORT = New System.Windows.Forms.Button()
        Me.BTN_EXPENSE = New System.Windows.Forms.Button()
        Me.BTN_DASHBOARD = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTN_CASHIER = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtusername = New Chelsea_Chill_02.RoundCornerTextbox()
        Me.txtcontact = New Chelsea_Chill_02.RoundCornerTextbox()
        Me.txtaddress = New Chelsea_Chill_02.RoundCornerTextbox()
        Me.txtname = New Chelsea_Chill_02.RoundCornerTextbox()
        Me.txtpassword = New Chelsea_Chill_02.RoundCornerTextbox()
        Me.txtcnfrmpass = New Chelsea_Chill_02.RoundCornerTextbox()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.AutoSize = True
        Me.txtID.BackColor = System.Drawing.Color.Transparent
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(299, 76)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(134, 25)
        Me.txtID.TabIndex = 127
        Me.txtID.Text = "Employee ID"
        Me.txtID.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(405, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 25)
        Me.Label2.TabIndex = 125
        Me.Label2.Text = "Name"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(249, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1187, 60)
        Me.Panel2.TabIndex = 107
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(401, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(355, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SYSTEM MANAGEMENT"
        '
        'DataGridUser
        '
        Me.DataGridUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridUser.BackgroundColor = System.Drawing.Color.White
        Me.DataGridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridUser.Location = New System.Drawing.Point(304, 495)
        Me.DataGridUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridUser.Name = "DataGridUser"
        Me.DataGridUser.RowHeadersVisible = False
        Me.DataGridUser.RowHeadersWidth = 51
        Me.DataGridUser.RowTemplate.Height = 24
        Me.DataGridUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridUser.Size = New System.Drawing.Size(1075, 261)
        Me.DataGridUser.TabIndex = 108
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(381, 311)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 25)
        Me.Label4.TabIndex = 137
        Me.Label4.Text = "Contact"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(797, 300)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(187, 25)
        Me.Label6.TabIndex = 142
        Me.Label6.Text = "Confirm Password"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(887, 224)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 25)
        Me.Label8.TabIndex = 140
        Me.Label8.Text = "Password"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(879, 149)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 25)
        Me.Label10.TabIndex = 139
        Me.Label10.Text = "Username"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Location = New System.Drawing.Point(1138, 257)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(125, 20)
        Me.CheckBox1.TabIndex = 104
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.Location = New System.Drawing.Point(1137, 332)
        Me.CheckBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(125, 20)
        Me.CheckBox2.TabIndex = 147
        Me.CheckBox2.Text = "Show Password"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(1068, 392)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(116, 48)
        Me.btnUpdate.TabIndex = 231
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
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
        Me.Panel1.Location = New System.Drawing.Point(-4, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(253, 900)
        Me.Panel1.TabIndex = 232
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
        Me.BTN_EXPENSE.Text = "Expense"
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(379, 208)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 25)
        Me.Label7.TabIndex = 136
        Me.Label7.Text = "Address"
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(1000, 142)
        Me.txtusername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtusername.Multiline = True
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(263, 34)
        Me.txtusername.TabIndex = 138
        '
        'txtcontact
        '
        Me.txtcontact.Location = New System.Drawing.Point(484, 305)
        Me.txtcontact.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcontact.Multiline = True
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(263, 34)
        Me.txtcontact.TabIndex = 135
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(484, 204)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(263, 80)
        Me.txtaddress.TabIndex = 134
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(484, 144)
        Me.txtname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtname.Multiline = True
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(263, 34)
        Me.txtname.TabIndex = 110
        '
        'txtpassword
        '
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpassword.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(1004, 217)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(5)
        Me.txtpassword.Multiline = True
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(259, 33)
        Me.txtpassword.TabIndex = 45
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'txtcnfrmpass
        '
        Me.txtcnfrmpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcnfrmpass.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcnfrmpass.Location = New System.Drawing.Point(1003, 292)
        Me.txtcnfrmpass.Margin = New System.Windows.Forms.Padding(5)
        Me.txtcnfrmpass.Multiline = True
        Me.txtcnfrmpass.Name = "txtcnfrmpass"
        Me.txtcnfrmpass.Size = New System.Drawing.Size(259, 33)
        Me.txtcnfrmpass.TabIndex = 233
        Me.txtcnfrmpass.UseSystemPasswordChar = True
        '
        'AssistantMngr_Maintenance_UI_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1427, 886)
        Me.Controls.Add(Me.txtcnfrmpass)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtcontact)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.DataGridUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "AssistantMngr_Maintenance_UI_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AssistantMngr_Maintenance_Form"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtname As RoundCornerTextbox
    Friend WithEvents DataGridUser As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcontact As RoundCornerTextbox
    Friend WithEvents txtaddress As RoundCornerTextbox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtusername As RoundCornerTextbox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTN_LOGOUT As Button
    Friend WithEvents BTN_INVENTORY As Button
    Friend WithEvents BTN_REPORT As Button
    Friend WithEvents BTN_EXPENSE As Button
    Friend WithEvents BTN_DASHBOARD As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BTN_CASHIER As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtpassword As RoundCornerTextbox
    Friend WithEvents txtcnfrmpass As RoundCornerTextbox
End Class
