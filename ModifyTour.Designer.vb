<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModifyTour
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
        GroupBox1 = New GroupBox()
        Panel2 = New Panel()
        Label6 = New Label()
        Label7 = New Label()
        btnModify1 = New Button()
        lblTripName1 = New Label()
        Label1 = New Label()
        Button2 = New Button()
        Label9 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Panel2)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(btnModify1)
        GroupBox1.Controls.Add(lblTripName1)
        GroupBox1.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.Location = New Point(20, 100)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1254, 330)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Location = New Point(170, 35)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1060, 180)
        Panel2.TabIndex = 25
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(10, 85)
        Label6.Name = "Label6"
        Label6.Size = New Size(115, 19)
        Label6.TabIndex = 24
        Label6.Text = "VISIT DURATION:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(10, 50)
        Label7.Name = "Label7"
        Label7.Size = New Size(114, 19)
        Label7.TabIndex = 23
        Label7.Text = "VISIT LOCATION:"
        ' 
        ' btnModify1
        ' 
        btnModify1.BackColor = Color.ForestGreen
        btnModify1.FlatStyle = FlatStyle.Flat
        btnModify1.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnModify1.ForeColor = Color.White
        btnModify1.Location = New Point(1140, 235)
        btnModify1.Name = "btnModify1"
        btnModify1.Size = New Size(90, 35)
        btnModify1.TabIndex = 21
        btnModify1.Text = "SAVE"
        btnModify1.UseVisualStyleBackColor = False
        ' 
        ' lblTripName1
        ' 
        lblTripName1.AutoSize = True
        lblTripName1.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblTripName1.Location = New Point(10, 15)
        lblTripName1.Name = "lblTripName1"
        lblTripName1.Size = New Size(53, 19)
        lblTripName1.TabIndex = 2
        lblTripName1.Text = "LABEL1"
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.DarkBlue
        Label1.Location = New Point(0, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(1294, 45)
        Label1.TabIndex = 3
        Label1.Text = "MODIFY YOUR TRIP"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.SteelBlue
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(20, 10)
        Button2.Name = "Button2"
        Button2.Size = New Size(140, 35)
        Button2.TabIndex = 4
        Button2.Text = "BACK TO HOME"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.Font = New Font("Segoe UI", 10.0F, FontStyle.Italic, GraphicsUnit.Point)
        Label9.Location = New Point(0, 60)
        Label9.Name = "Label9"
        Label9.Size = New Size(1294, 30)
        Label9.TabIndex = 5
        Label9.Text = "INSTRUCTIONS: TO MODIFY YOUR TRIP, DRAG THE BOXES TO REORGANIZE THE ORDER, OR EDIT THE DURATION."
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ModifyTour
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1294, 450)
        Controls.Add(Label9)
        Controls.Add(Button2)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "ModifyTour"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MODIFY TOUR"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnModify1 As Button
    Friend WithEvents lblTripName1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel2 As Panel
End Class
