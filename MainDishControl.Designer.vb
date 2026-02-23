<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainDishControl
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
        Me.FlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel
        '
        Me.FlowLayoutPanel.AutoScroll = True
        Me.FlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel.Name = "FlowLayoutPanel"
        Me.FlowLayoutPanel.Size = New System.Drawing.Size(1007, 624)
        Me.FlowLayoutPanel.TabIndex = 0
        '
        'MainDishControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FlowLayoutPanel)
        Me.Name = "MainDishControl"
        Me.Size = New System.Drawing.Size(1007, 624)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel As FlowLayoutPanel
End Class
