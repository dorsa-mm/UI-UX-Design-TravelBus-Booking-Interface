<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EndOfTour
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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 28.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(0, 100)
        Label1.Name = "Label1"
        Label1.Size = New Size(1200, 150)
        Label1.TabIndex = 0
        Label1.Text = "THANK YOU FOR RIDING THE TIME BUS! HOPE YOU ENJOYED!"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.SteelBlue
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(500, 300)
        Button1.Name = "Button1"
        Button1.Size = New Size(200, 45)
        Button1.TabIndex = 1
        Button1.Text = "BACK TO MAIN MENU"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' EndOfTour
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 17.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1200, 550)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "EndOfTour"
        StartPosition = FormStartPosition.CenterScreen
        Text = "END OF TOUR"
        ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
