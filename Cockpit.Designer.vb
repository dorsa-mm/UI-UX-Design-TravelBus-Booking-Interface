<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CockpitForm
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
        Panel1 = New Panel()
        ZoomOut = New PictureBox()
        ZoomIn = New PictureBox()
        WindowBox = New PictureBox()
        Panel2 = New Panel()
        Year = New Label()
        Label4 = New Label()
        Information = New Label()
        Label3 = New Label()
        Location = New Label()
        Label2 = New Label()
        Tour_Name = New Label()
        Label1 = New Label()
        Panel3 = New Panel()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Backward = New RadioButton()
        Forward = New RadioButton()
        Label7 = New Label()
        SpeedMinus = New Button()
        SpeedPlus = New Button()
        Speed = New Label()
        Label5 = New Label()
        Button1 = New Button()
        CheckBox1 = New CheckBox()
        ProgressBar1 = New ProgressBar()
        Label6 = New Label()
        Panel1.SuspendLayout()
        CType(ZoomOut, ComponentModel.ISupportInitialize).BeginInit()
        CType(ZoomIn, ComponentModel.ISupportInitialize).BeginInit()
        CType(WindowBox, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(ZoomOut)
        Panel1.Controls.Add(ZoomIn)
        Panel1.Controls.Add(WindowBox)
        Panel1.Location = New Point(9, 8)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(607, 471)
        Panel1.TabIndex = 0
        ' 
        ' ZoomOut
        ' 
        ZoomOut.Image = My.Resources.Resources.zoom_out
        ZoomOut.Location = New Point(546, 422)
        ZoomOut.Margin = New Padding(3, 2, 3, 2)
        ZoomOut.Name = "ZoomOut"
        ZoomOut.Size = New Size(54, 43)
        ZoomOut.SizeMode = PictureBoxSizeMode.StretchImage
        ZoomOut.TabIndex = 2
        ZoomOut.TabStop = False
        ' 
        ' ZoomIn
        ' 
        ZoomIn.Image = My.Resources.Resources.zoom_in
        ZoomIn.Location = New Point(488, 422)
        ZoomIn.Margin = New Padding(3, 2, 3, 2)
        ZoomIn.Name = "ZoomIn"
        ZoomIn.Size = New Size(52, 43)
        ZoomIn.SizeMode = PictureBoxSizeMode.StretchImage
        ZoomIn.TabIndex = 1
        ZoomIn.TabStop = False
        ' 
        ' WindowBox
        ' 
        WindowBox.BackColor = SystemColors.ActiveBorder
        WindowBox.Location = New Point(-24, -11)
        WindowBox.Margin = New Padding(3, 2, 3, 2)
        WindowBox.Name = "WindowBox"
        WindowBox.Size = New Size(651, 494)
        WindowBox.SizeMode = PictureBoxSizeMode.StretchImage
        WindowBox.TabIndex = 0
        WindowBox.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.WhiteSmoke
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(Year)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Information)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Location)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Tour_Name)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(620, 7)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(590, 219)
        Panel2.TabIndex = 1
        ' 
        ' Year
        ' 
        Year.AutoSize = True
        Year.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        Year.Location = New Point(56, 162)
        Year.Name = "Year"
        Year.Size = New Size(43, 15)
        Year.TabIndex = 7
        Year.Text = "Label5"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(12, 162)
        Label4.Name = "Label4"
        Label4.Size = New Size(32, 15)
        Label4.TabIndex = 6
        Label4.Text = "Year:"
        ' 
        ' Information
        ' 
        Information.Font = New Font("Segoe UI", 9.0F, FontStyle.Italic, GraphicsUnit.Point)
        Information.Location = New Point(93, 38)
        Information.Name = "Information"
        Information.Size = New Size(255, 114)
        Information.TabIndex = 5
        Information.Text = "Label4"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(12, 38)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 15)
        Label3.TabIndex = 4
        Label3.Text = "Information:"
        ' 
        ' Location
        ' 
        Location.AutoSize = True
        Location.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        Location.Location = New Point(93, 22)
        Location.Name = "Location"
        Location.Size = New Size(43, 15)
        Location.TabIndex = 3
        Location.Text = "Label3"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(12, 22)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 15)
        Label2.TabIndex = 2
        Label2.Text = "Location:"
        ' 
        ' Tour_Name
        ' 
        Tour_Name.AutoSize = True
        Tour_Name.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        Tour_Name.Location = New Point(93, 8)
        Tour_Name.Name = "Tour_Name"
        Tour_Name.Size = New Size(43, 15)
        Tour_Name.TabIndex = 1
        Tour_Name.Text = "Label2"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 15)
        Label1.TabIndex = 0
        Label1.Text = "Tour Name:"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.WhiteSmoke
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(Button4)
        Panel3.Controls.Add(Button3)
        Panel3.Controls.Add(Button2)
        Panel3.Controls.Add(Backward)
        Panel3.Controls.Add(Forward)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(SpeedMinus)
        Panel3.Controls.Add(SpeedPlus)
        Panel3.Controls.Add(Speed)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Button1)
        Panel3.Controls.Add(CheckBox1)
        Panel3.Location = New Point(620, 230)
        Panel3.Margin = New Padding(3, 2, 3, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(590, 249)
        Panel3.TabIndex = 2
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.Location = New Point(108, 209)
        Button4.Margin = New Padding(3, 2, 3, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(142, 22)
        Button4.TabIndex = 20
        Button4.Text = "Jump to Next Visit"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(12, 209)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(82, 22)
        Button3.TabIndex = 19
        Button3.Text = "Pause Time"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(466, 174)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(109, 31)
        Button2.TabIndex = 18
        Button2.Text = "Emergency Stop"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Backward
        ' 
        Backward.AutoSize = True
        Backward.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Backward.Location = New Point(136, 41)
        Backward.Margin = New Padding(3, 2, 3, 2)
        Backward.Name = "Backward"
        Backward.Size = New Size(105, 19)
        Backward.TabIndex = 17
        Backward.Text = "Backward Time"
        Backward.UseVisualStyleBackColor = True
        ' 
        ' Forward
        ' 
        Forward.AutoSize = True
        Forward.Checked = True
        Forward.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Forward.Location = New Point(21, 41)
        Forward.Margin = New Padding(3, 2, 3, 2)
        Forward.Name = "Forward"
        Forward.Size = New Size(97, 19)
        Forward.TabIndex = 16
        Forward.TabStop = True
        Forward.Text = "Forward Time"
        Forward.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(134, 12)
        Label7.Name = "Label7"
        Label7.Size = New Size(64, 15)
        Label7.TabIndex = 15
        Label7.Text = "Light Years"
        ' 
        ' SpeedMinus
        ' 
        SpeedMinus.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        SpeedMinus.Location = New Point(244, 8)
        SpeedMinus.Margin = New Padding(3, 2, 3, 2)
        SpeedMinus.Name = "SpeedMinus"
        SpeedMinus.Size = New Size(33, 22)
        SpeedMinus.TabIndex = 14
        SpeedMinus.Text = "-"
        SpeedMinus.UseVisualStyleBackColor = True
        ' 
        ' SpeedPlus
        ' 
        SpeedPlus.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        SpeedPlus.Location = New Point(206, 8)
        SpeedPlus.Margin = New Padding(3, 2, 3, 2)
        SpeedPlus.Name = "SpeedPlus"
        SpeedPlus.Size = New Size(32, 22)
        SpeedPlus.TabIndex = 13
        SpeedPlus.Text = "+"
        SpeedPlus.UseVisualStyleBackColor = True
        ' 
        ' Speed
        ' 
        Speed.AutoSize = True
        Speed.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Speed.Location = New Point(103, 12)
        Speed.Name = "Speed"
        Speed.Size = New Size(25, 15)
        Speed.TabIndex = 12
        Speed.Text = "100"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(12, 11)
        Label5.Name = "Label5"
        Label5.Size = New Size(85, 15)
        Label5.TabIndex = 8
        Label5.Text = "Current Speed:"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(466, 209)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(109, 34)
        Button1.TabIndex = 11
        Button1.Text = "Return to Origin"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Checked = True
        CheckBox1.CheckState = CheckState.Checked
        CheckBox1.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox1.Location = New Point(21, 64)
        CheckBox1.Margin = New Padding(3, 2, 3, 2)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(76, 19)
        CheckBox1.TabIndex = 10
        CheckBox1.Text = "Autopilot"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(214, 496)
        ProgressBar1.Margin = New Padding(3, 2, 3, 2)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(983, 26)
        ProgressBar1.TabIndex = 3
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(1, 501)
        Label6.Name = "Label6"
        Label6.Size = New Size(152, 15)
        Label6.TabIndex = 4
        Label6.Text = "Time Till Next Destination"
        ' 
        ' CockpitForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CornflowerBlue
        ClientSize = New Size(1221, 533)
        Controls.Add(Label6)
        Controls.Add(ProgressBar1)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "CockpitForm"
        Text = "Cockpit"
        Panel1.ResumeLayout(False)
        CType(ZoomOut, ComponentModel.ISupportInitialize).EndInit()
        CType(ZoomIn, ComponentModel.ISupportInitialize).EndInit()
        CType(WindowBox, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents WindowBox As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Tour_Name As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Location As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Information As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Year As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ZoomOut As PictureBox
    Friend WithEvents ZoomIn As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents SpeedMinus As Button
    Friend WithEvents SpeedPlus As Button
    Friend WithEvents Speed As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Backward As RadioButton
    Friend WithEvents Forward As RadioButton
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label6 As Label
End Class
