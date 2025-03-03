<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SelectTour
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
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.DarkBlue
        Label1.Location = New Point(0, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(713, 40)
        Label1.TabIndex = 0
        Label1.Text = "SELECT TOUR"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' SelectTour
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(713, 437)
        Controls.Add(Label1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "SelectTour"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Select Tour"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
End Class
