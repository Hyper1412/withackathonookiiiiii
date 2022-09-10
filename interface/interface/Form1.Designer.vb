<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Options = New System.Windows.Forms.Button()
        Me.TotUseLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Limit
        '
        Me.Limit.Location = New System.Drawing.Point(304, 368)
        Me.Limit.Name = "Limit"
        Me.Limit.Size = New System.Drawing.Size(186, 39)
        Me.Limit.TabIndex = 0
        Me.Limit.Text = "Set Limit"
        Me.Limit.UseVisualStyleBackColor = True
        '
        'Usage
        '
        Me.Usage.Location = New System.Drawing.Point(87, 376)
        Me.Usage.Name = "Usage"
        Me.Usage.Size = New System.Drawing.Size(107, 23)
        Me.Usage.TabIndex = 1
        Me.Usage.Text = "Water Usage"
        Me.Usage.UseVisualStyleBackColor = True
        '
        'Options
        '
        Me.Options.Location = New System.Drawing.Point(617, 376)
        Me.Options.Name = "Options"
        Me.Options.Size = New System.Drawing.Size(90, 23)
        Me.Options.TabIndex = 2
        Me.Options.Text = "Preferences"
        Me.Options.UseVisualStyleBackColor = True
        '
        'TotUseLabel
        '
        Me.TotUseLabel.AutoSize = True
        Me.TotUseLabel.Location = New System.Drawing.Point(338, 39)
        Me.TotUseLabel.Name = "TotUseLabel"
        Me.TotUseLabel.Size = New System.Drawing.Size(113, 12)
        Me.TotUseLabel.TabIndex = 3
        Me.TotUseLabel.Text = "Total Water Usage:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 300000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TotUseLabel)
        Me.Controls.Add(Me.Options)
        Me.Controls.Add(Me.Usage)
        Me.Controls.Add(Me.Limit)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Limit As Button
    Friend WithEvents Usage As Button
    Friend WithEvents Options As Button
    Friend WithEvents TotUseLabel As Label
    Friend WithEvents Timer1 As Timer
End Class
