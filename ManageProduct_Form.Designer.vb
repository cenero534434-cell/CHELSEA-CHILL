<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManageProduct_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageProduct_Form))
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lstSearchResults = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCategory = New System.Windows.Forms.ComboBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtImagePath = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.txtSearch = New Chelsea_Chill_02.RoundCornerTextbox()
        Me.InventoryDT = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Ingredient1 = New System.Windows.Forms.TextBox()
        Me.Ingredient2 = New System.Windows.Forms.TextBox()
        Me.Ingredient4 = New System.Windows.Forms.TextBox()
        Me.Ingredient3 = New System.Windows.Forms.TextBox()
        Me.Ingredient6 = New System.Windows.Forms.TextBox()
        Me.Ingredient5 = New System.Windows.Forms.TextBox()
        Me.Ingredient8 = New System.Windows.Forms.TextBox()
        Me.Ingredient7 = New System.Windows.Forms.TextBox()
        Me.Amount8 = New System.Windows.Forms.TextBox()
        Me.Amount7 = New System.Windows.Forms.TextBox()
        Me.Amount6 = New System.Windows.Forms.TextBox()
        Me.Amount5 = New System.Windows.Forms.TextBox()
        Me.Amount4 = New System.Windows.Forms.TextBox()
        Me.Amount3 = New System.Windows.Forms.TextBox()
        Me.Amount2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Amount1 = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryDT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtProductName
        '
        resources.ApplyResources(Me.txtProductName, "txtProductName")
        Me.txtProductName.Name = "txtProductName"
        '
        'txtPrice
        '
        resources.ApplyResources(Me.txtPrice, "txtPrice")
        Me.txtPrice.Name = "txtPrice"
        '
        'lstSearchResults
        '
        Me.lstSearchResults.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.lstSearchResults, "lstSearchResults")
        Me.lstSearchResults.FormattingEnabled = True
        Me.lstSearchResults.Name = "lstSearchResults"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Name = "Label4"
        '
        'txtCategory
        '
        resources.ApplyResources(Me.txtCategory, "txtCategory")
        Me.txtCategory.FormattingEnabled = True
        Me.txtCategory.Items.AddRange(New Object() {resources.GetString("txtCategory.Items"), resources.GetString("txtCategory.Items1"), resources.GetString("txtCategory.Items2"), resources.GetString("txtCategory.Items3")})
        Me.txtCategory.Name = "txtCategory"
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.CornflowerBlue
        resources.ApplyResources(Me.btnBrowse, "btnBrowse")
        Me.btnBrowse.ForeColor = System.Drawing.Color.Black
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'txtImagePath
        '
        resources.ApplyResources(Me.txtImagePath, "txtImagePath")
        Me.txtImagePath.Name = "txtImagePath"
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.PictureBox2, "PictureBox2")
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnDelete, "btnDelete")
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        resources.ApplyResources(Me.btnUpdate, "btnUpdate")
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnSave, "btnSave")
        Me.btnSave.Name = "btnSave"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtProductID
        '
        resources.ApplyResources(Me.txtProductID, "txtProductID")
        Me.txtProductID.Name = "txtProductID"
        '
        'txtSearch
        '
        resources.ApplyResources(Me.txtSearch, "txtSearch")
        Me.txtSearch.Name = "txtSearch"
        '
        'InventoryDT
        '
        Me.InventoryDT.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.InventoryDT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.InventoryDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InventoryDT.GridColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.InventoryDT, "InventoryDT")
        Me.InventoryDT.Name = "InventoryDT"
        Me.InventoryDT.RowHeadersVisible = False
        Me.InventoryDT.RowTemplate.Height = 24
        Me.InventoryDT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Name = "Label1"
        '
        'Ingredient1
        '
        resources.ApplyResources(Me.Ingredient1, "Ingredient1")
        Me.Ingredient1.Name = "Ingredient1"
        '
        'Ingredient2
        '
        resources.ApplyResources(Me.Ingredient2, "Ingredient2")
        Me.Ingredient2.Name = "Ingredient2"
        '
        'Ingredient4
        '
        resources.ApplyResources(Me.Ingredient4, "Ingredient4")
        Me.Ingredient4.Name = "Ingredient4"
        '
        'Ingredient3
        '
        resources.ApplyResources(Me.Ingredient3, "Ingredient3")
        Me.Ingredient3.Name = "Ingredient3"
        '
        'Ingredient6
        '
        resources.ApplyResources(Me.Ingredient6, "Ingredient6")
        Me.Ingredient6.Name = "Ingredient6"
        '
        'Ingredient5
        '
        resources.ApplyResources(Me.Ingredient5, "Ingredient5")
        Me.Ingredient5.Name = "Ingredient5"
        '
        'Ingredient8
        '
        resources.ApplyResources(Me.Ingredient8, "Ingredient8")
        Me.Ingredient8.Name = "Ingredient8"
        '
        'Ingredient7
        '
        resources.ApplyResources(Me.Ingredient7, "Ingredient7")
        Me.Ingredient7.Name = "Ingredient7"
        '
        'Amount8
        '
        resources.ApplyResources(Me.Amount8, "Amount8")
        Me.Amount8.Name = "Amount8"
        '
        'Amount7
        '
        resources.ApplyResources(Me.Amount7, "Amount7")
        Me.Amount7.Name = "Amount7"
        '
        'Amount6
        '
        resources.ApplyResources(Me.Amount6, "Amount6")
        Me.Amount6.Name = "Amount6"
        '
        'Amount5
        '
        resources.ApplyResources(Me.Amount5, "Amount5")
        Me.Amount5.Name = "Amount5"
        '
        'Amount4
        '
        resources.ApplyResources(Me.Amount4, "Amount4")
        Me.Amount4.Name = "Amount4"
        '
        'Amount3
        '
        resources.ApplyResources(Me.Amount3, "Amount3")
        Me.Amount3.Name = "Amount3"
        '
        'Amount2
        '
        resources.ApplyResources(Me.Amount2, "Amount2")
        Me.Amount2.Name = "Amount2"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Name = "Label5"
        '
        'Amount1
        '
        resources.ApplyResources(Me.Amount1, "Amount1")
        Me.Amount1.Name = "Amount1"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnClear, "btnClear")
        Me.btnClear.Name = "btnClear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'ManageProduct_Form
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Amount8)
        Me.Controls.Add(Me.Amount7)
        Me.Controls.Add(Me.Amount6)
        Me.Controls.Add(Me.Amount5)
        Me.Controls.Add(Me.Amount4)
        Me.Controls.Add(Me.Amount3)
        Me.Controls.Add(Me.Amount2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Amount1)
        Me.Controls.Add(Me.Ingredient8)
        Me.Controls.Add(Me.Ingredient7)
        Me.Controls.Add(Me.Ingredient6)
        Me.Controls.Add(Me.Ingredient5)
        Me.Controls.Add(Me.Ingredient4)
        Me.Controls.Add(Me.Ingredient3)
        Me.Controls.Add(Me.Ingredient2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Ingredient1)
        Me.Controls.Add(Me.InventoryDT)
        Me.Controls.Add(Me.txtProductID)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtImagePath)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstSearchResults)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.txtSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ManageProduct_Form"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryDT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSearch As RoundCornerTextbox
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lstSearchResults As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCategory As ComboBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents txtImagePath As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents InventoryDT As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Ingredient1 As TextBox
    Friend WithEvents Ingredient2 As TextBox
    Friend WithEvents Ingredient4 As TextBox
    Friend WithEvents Ingredient3 As TextBox
    Friend WithEvents Ingredient6 As TextBox
    Friend WithEvents Ingredient5 As TextBox
    Friend WithEvents Ingredient8 As TextBox
    Friend WithEvents Ingredient7 As TextBox
    Friend WithEvents Amount8 As TextBox
    Friend WithEvents Amount7 As TextBox
    Friend WithEvents Amount6 As TextBox
    Friend WithEvents Amount5 As TextBox
    Friend WithEvents Amount4 As TextBox
    Friend WithEvents Amount3 As TextBox
    Friend WithEvents Amount2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Amount1 As TextBox
    Friend WithEvents btnClear As Button
End Class
