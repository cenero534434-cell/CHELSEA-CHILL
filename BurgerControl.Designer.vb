<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BurgerControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.image1 = New System.Windows.Forms.PictureBox()
        Me.txtTitle = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.Label()
        CType(Me.image1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'image1
        '
        Me.image1.Location = New System.Drawing.Point(21, 19)
        Me.image1.Name = "image1"
        Me.image1.Size = New System.Drawing.Size(123, 108)
        Me.image1.TabIndex = 0
        Me.image1.TabStop = False
        '
        'txtTitle
        '
        Me.txtTitle.AutoSize = True
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(59, 144)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(38, 16)
        Me.txtTitle.TabIndex = 1
        Me.txtTitle.Text = "Title"
        '
        'txtPrice
        '
        Me.txtPrice.AutoSize = True
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(59, 169)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(35, 15)
        Me.txtPrice.TabIndex = 2
        Me.txtPrice.Text = "Price"
        '
        'BurgerControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.image1)
        Me.Name = "BurgerControl"
        Me.Size = New System.Drawing.Size(164, 210)
        CType(Me.image1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents image1 As PictureBox
    Friend WithEvents txtTitle As Label
    Friend WithEvents txtPrice As Label
End Class
