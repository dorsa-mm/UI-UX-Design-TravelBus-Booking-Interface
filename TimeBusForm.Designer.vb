<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TimeBusForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TimeBusForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ' Make the form bigger and set a neutral background color
        Me.ClientSize = New System.Drawing.Size(900, 500)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TimeBus - B2"
        '
        'Label1
        '
        ' Turn off AutoSize so we can center the text easily
        Me.Label1.AutoSize = False
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        ' Manually size and position so it’s centered at the top
        Me.Label1.Location = New System.Drawing.Point(50, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(800, 60)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "WELCOME TO TIMEBUS INC."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = False
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        ' Position under Label1, centered
        Me.Label2.Location = New System.Drawing.Point(50, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(800, 60)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "By clicking on this button, you agree to the terms and conditions of TimeBus Inc."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SteelBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.White
        ' Center the button below Label2
        Me.Button1.Location = New System.Drawing.Point(250, 200)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(400, 60)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "START THE PROGRAM"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Add controls to the form
        '
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
End Class
