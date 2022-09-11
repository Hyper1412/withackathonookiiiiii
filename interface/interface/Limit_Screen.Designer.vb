<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Limit_Screen
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
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Set_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Return_Button = New System.Windows.Forms.Button()
        Me.City = New System.Windows.Forms.ComboBox()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(196, 148)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 21)
        Me.NumericUpDown1.TabIndex = 1
        '
        'Set_Button
        '
        Me.Set_Button.Location = New System.Drawing.Point(348, 284)
        Me.Set_Button.Name = "Set_Button"
        Me.Set_Button.Size = New System.Drawing.Size(75, 23)
        Me.Set_Button.TabIndex = 2
        Me.Set_Button.Text = "Set"
        Me.Set_Button.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(210, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Current Limit: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(492, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Estimated_Price: "
        '
        'Return_Button
        '
        Me.Return_Button.Location = New System.Drawing.Point(315, 363)
        Me.Return_Button.Name = "Return_Button"
        Me.Return_Button.Size = New System.Drawing.Size(147, 35)
        Me.Return_Button.TabIndex = 5
        Me.Return_Button.Text = "Return to Main Menu"
        Me.Return_Button.UseVisualStyleBackColor = True
        '
        'City
        '
        Me.City.FormattingEnabled = True
        Me.City.Location = New System.Drawing.Point(494, 148)
        Me.City.Name = "City"
        Me.City.Size = New System.Drawing.Size(121, 20)
        Me.City.TabIndex = 6
        '
        'Limit_Screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.City)
        Me.Controls.Add(Me.Return_Button)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Set_Button)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Name = "Limit_Screen"
        Me.Text = "Usage Limit"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Set_Button As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Return_Button As Button
    Friend WithEvents City As ComboBox
End Class
