<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Emergency_Procedure
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

    'NOTE: The following procedure is required by the Windows Form Designer.
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Button1 = New Button()
        Label2 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._Stop
        PictureBox1.Location = New Point(311, 119)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(296, 228)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(100, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(707, 25)
        Label1.TabIndex = 1
        Label1.Text = "Due to an Emergency, this trip is cancelled and the Bus is returning back to home!"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Gainsboro
        Button1.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(385, 365)
        Button1.Name = "Button1"
        Button1.Size = New Size(142, 32)
        Button1.TabIndex = 2
        Button1.Text = "Back to Home"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.0F, FontStyle.Italic, GraphicsUnit.Point)
        Label2.Location = New Point(270, 409)
        Label2.Name = "Label2"
        Label2.Size = New Size(380, 15)
        Label2.TabIndex = 3
        Label2.Text = "To experience the trip again, please return back to home and create a new tour."
        ' 
        ' Emergency_Procedure
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 17.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(914, 480)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "Emergency_Procedure"
        Text = "Emergency Procedure"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
End Class
