<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ingredients_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ingredients_Form))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtSearch = New Chelsea_Chill_02.RoundCornerTextbox()
        Me.InventoryDT = New System.Windows.Forms.DataGridView()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ProductPicture = New System.Windows.Forms.PictureBox()
        Me.Category = New System.Windows.Forms.Label()
        Me.ProductNameee = New System.Windows.Forms.Label()
        Me.Price = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryDT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ProductPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(636, 33)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 198
        Me.PictureBox1.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txtSearch.Location = New System.Drawing.Point(706, 33)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(742, 34)
        Me.txtSearch.TabIndex = 187
        '
        'InventoryDT
        '
        Me.InventoryDT.BackgroundColor = System.Drawing.Color.LightBlue
        Me.InventoryDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InventoryDT.GridColor = System.Drawing.Color.LavenderBlush
        Me.InventoryDT.Location = New System.Drawing.Point(648, 89)
        Me.InventoryDT.Name = "InventoryDT"
        Me.InventoryDT.RowHeadersWidth = 51
        Me.InventoryDT.RowTemplate.Height = 24
        Me.InventoryDT.Size = New System.Drawing.Size(830, 500)
        Me.InventoryDT.TabIndex = 201
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(658, 631)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(337, 22)
        Me.TextBox4.TabIndex = 224
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(1141, 627)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(337, 22)
        Me.TextBox2.TabIndex = 222
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(1232, 661)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(114, 45)
        Me.btnAdd.TabIndex = 227
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(1364, 661)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(114, 45)
        Me.btnRemove.TabIndex = 228
        Me.btnRemove.Text = "CLEAR"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(654, 600)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 20)
        Me.Label2.TabIndex = 229
        Me.Label2.Text = "Product Ingredient:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(1137, 597)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 230
        Me.Label3.Text = "Amount:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.ProductPicture)
        Me.Panel1.Controls.Add(Me.Category)
        Me.Panel1.Controls.Add(Me.ProductNameee)
        Me.Panel1.Controls.Add(Me.Price)
        Me.Panel1.Location = New System.Drawing.Point(32, 90)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(582, 369)
        Me.Panel1.TabIndex = 232
        '
        'ProductPicture
        '
        Me.ProductPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductPicture.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ProductPicture.Location = New System.Drawing.Point(105, 4)
        Me.ProductPicture.Margin = New System.Windows.Forms.Padding(4)
        Me.ProductPicture.Name = "ProductPicture"
        Me.ProductPicture.Size = New System.Drawing.Size(336, 255)
        Me.ProductPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ProductPicture.TabIndex = 235
        Me.ProductPicture.TabStop = False
        '
        'Category
        '
        Me.Category.AutoSize = True
        Me.Category.BackColor = System.Drawing.Color.Transparent
        Me.Category.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Category.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Category.Location = New System.Drawing.Point(230, 300)
        Me.Category.Name = "Category"
        Me.Category.Size = New System.Drawing.Size(84, 20)
        Me.Category.TabIndex = 233
        Me.Category.Text = "Category"
        '
        'ProductNameee
        '
        Me.ProductNameee.AutoSize = True
        Me.ProductNameee.BackColor = System.Drawing.Color.Transparent
        Me.ProductNameee.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.ProductNameee.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ProductNameee.Location = New System.Drawing.Point(206, 267)
        Me.ProductNameee.Name = "ProductNameee"
        Me.ProductNameee.Size = New System.Drawing.Size(128, 20)
        Me.ProductNameee.TabIndex = 232
        Me.ProductNameee.Text = "Product Name"
        '
        'Price
        '
        Me.Price.AutoSize = True
        Me.Price.BackColor = System.Drawing.Color.Transparent
        Me.Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Price.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Price.Location = New System.Drawing.Point(240, 333)
        Me.Price.Name = "Price"
        Me.Price.Size = New System.Drawing.Size(59, 20)
        Me.Price.TabIndex = 234
        Me.Price.Text = "Price:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ListBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(32, 481)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(582, 234)
        Me.Panel2.TabIndex = 233
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(18, 29)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(549, 196)
        Me.ListBox1.TabIndex = 237
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(14, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 20)
        Me.Label1.TabIndex = 236
        Me.Label1.Text = "Product Ingredients"
        '
        'Ingredients_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Chelsea_Chill_02.My.Resources.Resources.Untitled_design1
        Me.ClientSize = New System.Drawing.Size(1490, 725)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.InventoryDT)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Ingredients_Form"
        Me.Text = "Ingredients_Form"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryDT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ProductPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtSearch As RoundCornerTextbox
    Friend WithEvents InventoryDT As DataGridView
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ProductPicture As PictureBox
    Friend WithEvents Category As Label
    Friend WithEvents ProductNameee As Label
    Friend WithEvents Price As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
End Class
