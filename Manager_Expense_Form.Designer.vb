<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Manager_Expense_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Manager_Expense_Form))
        Me.BTN_LOGOUT = New System.Windows.Forms.Button()
        Me.BTN_SYSTEMMNGMNT = New System.Windows.Forms.Button()
        Me.BTN_INVENTORY = New System.Windows.Forms.Button()
        Me.BTN_REPORT = New System.Windows.Forms.Button()
        Me.BTN_EXPENSE = New System.Windows.Forms.Button()
        Me.BTN_DASHBOARD = New System.Windows.Forms.Button()
        Me.BTN_CASHIER = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dtpExpenseDate = New System.Windows.Forms.DateTimePicker()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtTypeofTransaction = New System.Windows.Forms.TextBox()
        Me.txtExpenseID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridExpenses = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridExpenses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.BTN_INVENTORY.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_INVENTORY.Location = New System.Drawing.Point(29, 281)
        Me.BTN_INVENTORY.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_INVENTORY.Name = "BTN_INVENTORY"
        Me.BTN_INVENTORY.Size = New System.Drawing.Size(191, 68)
        Me.BTN_INVENTORY.TabIndex = 13
        Me.BTN_INVENTORY.Text = "Inventory"
        Me.BTN_INVENTORY.UseVisualStyleBackColor = True
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
        Me.BTN_EXPENSE.BackColor = System.Drawing.Color.LightSkyBlue
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
        Me.Panel1.TabIndex = 200
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
        'dtpExpenseDate
        '
        Me.dtpExpenseDate.Location = New System.Drawing.Point(657, 199)
        Me.dtpExpenseDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpExpenseDate.Name = "dtpExpenseDate"
        Me.dtpExpenseDate.Size = New System.Drawing.Size(359, 22)
        Me.dtpExpenseDate.TabIndex = 198
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(928, 324)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(116, 48)
        Me.btnDelete.TabIndex = 197
        Me.btnDelete.Text = "Remove"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(779, 324)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(116, 48)
        Me.btnUpdate.TabIndex = 196
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(625, 324)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 48)
        Me.btnSave.TabIndex = 195
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtTypeofTransaction
        '
        Me.txtTypeofTransaction.Location = New System.Drawing.Point(657, 116)
        Me.txtTypeofTransaction.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTypeofTransaction.Multiline = True
        Me.txtTypeofTransaction.Name = "txtTypeofTransaction"
        Me.txtTypeofTransaction.Size = New System.Drawing.Size(359, 54)
        Me.txtTypeofTransaction.TabIndex = 192
        '
        'txtExpenseID
        '
        Me.txtExpenseID.AutoSize = True
        Me.txtExpenseID.BackColor = System.Drawing.Color.Transparent
        Me.txtExpenseID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpenseID.Location = New System.Drawing.Point(395, 81)
        Me.txtExpenseID.Name = "txtExpenseID"
        Me.txtExpenseID.Size = New System.Drawing.Size(123, 25)
        Me.txtExpenseID.TabIndex = 189
        Me.txtExpenseID.Text = "Expenses ID"
        Me.txtExpenseID.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(515, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EXPENSES"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(249, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1191, 60)
        Me.Panel2.TabIndex = 186
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(657, 254)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAmount.Multiline = True
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(359, 32)
        Me.txtAmount.TabIndex = 194
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(307, 412)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1075, 44)
        Me.Panel3.TabIndex = 188
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(467, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Chart Flow"
        '
        'DataGridExpenses
        '
        Me.DataGridExpenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridExpenses.BackgroundColor = System.Drawing.Color.LightBlue
        Me.DataGridExpenses.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridExpenses.GridColor = System.Drawing.Color.Black
        Me.DataGridExpenses.Location = New System.Drawing.Point(308, 462)
        Me.DataGridExpenses.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridExpenses.Name = "DataGridExpenses"
        Me.DataGridExpenses.RowHeadersVisible = False
        Me.DataGridExpenses.RowHeadersWidth = 51
        Me.DataGridExpenses.RowTemplate.Height = 24
        Me.DataGridExpenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridExpenses.Size = New System.Drawing.Size(1075, 409)
        Me.DataGridExpenses.TabIndex = 187
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(431, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(205, 25)
        Me.Label3.TabIndex = 201
        Me.Label3.Text = "Type of Transaction"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(491, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 25)
        Me.Label4.TabIndex = 202
        Me.Label4.Text = "Expense Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(555, 258)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 25)
        Me.Label7.TabIndex = 203
        Me.Label7.Text = "Amount"
        '
        'Manager_Expense_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1439, 896)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dtpExpenseDate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtTypeofTransaction)
        Me.Controls.Add(Me.txtExpenseID)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.DataGridExpenses)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Manager_Expense_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Financials_Form"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridExpenses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_LOGOUT As Button
    Friend WithEvents BTN_SYSTEMMNGMNT As Button
    Friend WithEvents BTN_INVENTORY As Button
    Friend WithEvents BTN_REPORT As Button
    Friend WithEvents BTN_EXPENSE As Button
    Friend WithEvents BTN_DASHBOARD As Button
    Friend WithEvents BTN_CASHIER As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dtpExpenseDate As DateTimePicker
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtTypeofTransaction As TextBox
    Friend WithEvents txtExpenseID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridExpenses As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
End Class
