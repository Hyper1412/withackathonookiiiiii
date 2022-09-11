<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Screen
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
        Me.Limit = New System.Windows.Forms.Button()
        Me.Usage = New System.Windows.Forms.Button()
        Me.TotUseLabel = New System.Windows.Forms.Label()
        Me.Main_Update_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Limit_Label = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Limit
        '
        Me.Limit.Location = New System.Drawing.Point(499, 360)
        Me.Limit.Name = "Limit"
        Me.Limit.Size = New System.Drawing.Size(186, 39)
        Me.Limit.TabIndex = 0
        Me.Limit.Text = "Water Limit"
        Me.Limit.UseVisualStyleBackColor = True
        '
        'Usage
        '
        Me.Usage.Location = New System.Drawing.Point(122, 360)
        Me.Usage.Name = "Usage"
        Me.Usage.Size = New System.Drawing.Size(190, 39)
        Me.Usage.TabIndex = 1
        Me.Usage.Text = "Water Usage"
        Me.Usage.UseVisualStyleBackColor = True
        '
        'TotUseLabel
        '
        Me.TotUseLabel.AutoSize = True
        Me.TotUseLabel.Location = New System.Drawing.Point(175, 42)
        Me.TotUseLabel.Name = "TotUseLabel"
        Me.TotUseLabel.Size = New System.Drawing.Size(137, 12)
        Me.TotUseLabel.TabIndex = 3
        Me.TotUseLabel.Text = "Total Water Usage: (L)"
        '
        'Main_Update_Timer
        '
        Me.Main_Update_Timer.Enabled = True
        Me.Main_Update_Timer.Interval = 3000
        '
        'Limit_Label
        '
        Me.Limit_Label.AutoSize = True
        Me.Limit_Label.Location = New System.Drawing.Point(532, 42)
        Me.Limit_Label.Name = "Limit_Label"
        Me.Limit_Label.Size = New System.Drawing.Size(65, 12)
        Me.Limit_Label.TabIndex = 4
        Me.Limit_Label.Text = "Limit: (L)"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.[interface].My.Resources.Resources.Group_1
        Me.PictureBox1.Location = New System.Drawing.Point(241, 103)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(356, 201)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Main_Screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Limit_Label)
        Me.Controls.Add(Me.TotUseLabel)
        Me.Controls.Add(Me.Usage)
        Me.Controls.Add(Me.Limit)
        Me.Name = "Main_Screen"
        Me.Text = "Water Usage Tracker"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Limit As Button
    Friend WithEvents Usage As Button
    Friend WithEvents TotUseLabel As Label
    Friend WithEvents Main_Update_Timer As Timer
    Friend WithEvents Limit_Label As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
