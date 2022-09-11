<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usage_Screen
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Update_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Return_Button = New System.Windows.Forms.Button()
        Me.Increase_Button = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(776, 402)
        Me.DataGridView1.TabIndex = 4
        '
        'Update_Timer
        '
        Me.Update_Timer.Enabled = True
        Me.Update_Timer.Interval = 300000
        '
        'Return_Button
        '
        Me.Return_Button.Location = New System.Drawing.Point(328, 420)
        Me.Return_Button.Name = "Return_Button"
        Me.Return_Button.Size = New System.Drawing.Size(140, 23)
        Me.Return_Button.TabIndex = 5
        Me.Return_Button.Text = "Return to Main Menu"
        Me.Return_Button.UseVisualStyleBackColor = True
        '
        'Increase_Button
        '
        Me.Increase_Button.Location = New System.Drawing.Point(641, 420)
        Me.Increase_Button.Name = "Increase_Button"
        Me.Increase_Button.Size = New System.Drawing.Size(75, 23)
        Me.Increase_Button.TabIndex = 6
        Me.Increase_Button.Text = "Increase"
        Me.Increase_Button.UseVisualStyleBackColor = True
        '
        'Usage_Screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 459)
        Me.Controls.Add(Me.Increase_Button)
        Me.Controls.Add(Me.Return_Button)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Usage_Screen"
        Me.Text = "Water Usage"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Update_Timer As Timer
    Friend WithEvents Return_Button As Button
    Friend WithEvents Increase_Button As Button
End Class
