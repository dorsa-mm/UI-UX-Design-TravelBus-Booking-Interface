<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VisitorView
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
        WindowBox = New PictureBox()
        Panel1 = New Panel()
        ZoomIn = New PictureBox()
        ZoomOut = New PictureBox()
        Panel2 = New Panel()
        PictureBox17 = New PictureBox()
        PictureBox18 = New PictureBox()
        PictureBox19 = New PictureBox()
        PictureBox20 = New PictureBox()
        PictureBox21 = New PictureBox()
        AromaUp = New PictureBox()
        AromaDown = New PictureBox()
        PictureBox1 = New PictureBox()
        PictureBox12 = New PictureBox()
        PictureBox13 = New PictureBox()
        PictureBox14 = New PictureBox()
        PictureBox15 = New PictureBox()
        PictureBox16 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        PictureBox9 = New PictureBox()
        PictureBox10 = New PictureBox()
        PictureBox11 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        Tour_Name = New Label()
        TempUp = New PictureBox()
        TempDown = New PictureBox()
        BrightnessDown = New PictureBox()
        BrightnessUp = New PictureBox()
        VolumeDown = New PictureBox()
        VolumeUp = New PictureBox()
        Temp = New PictureBox()
        Brightness = New PictureBox()
        Volume = New PictureBox()
        VolumeLabel = New Label()
        BrightnessLabel = New Label()
        TemperatureLabel = New Label()
        AromaLabel = New Label()
        Panel3 = New Panel()
        Button3 = New Button()
        Button2 = New Button()
        Information = New Label()
        Label3 = New Label()
        TourLocation = New Label()
        Label2 = New Label()
        Year = New Label()
        Label1 = New Label()
        Button1 = New Button()
        Label4 = New Label()
        ProgressBar1 = New ProgressBar()
        CType(WindowBox, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(ZoomIn, ComponentModel.ISupportInitialize).BeginInit()
        CType(ZoomOut, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox17, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox18, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox19, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox20, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox21, ComponentModel.ISupportInitialize).BeginInit()
        CType(AromaUp, ComponentModel.ISupportInitialize).BeginInit()
        CType(AromaDown, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox12, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox13, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox14, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox15, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox16, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(TempUp, ComponentModel.ISupportInitialize).BeginInit()
        CType(TempDown, ComponentModel.ISupportInitialize).BeginInit()
        CType(BrightnessDown, ComponentModel.ISupportInitialize).BeginInit()
        CType(BrightnessUp, ComponentModel.ISupportInitialize).BeginInit()
        CType(VolumeDown, ComponentModel.ISupportInitialize).BeginInit()
        CType(VolumeUp, ComponentModel.ISupportInitialize).BeginInit()
        CType(Temp, ComponentModel.ISupportInitialize).BeginInit()
        CType(Brightness, ComponentModel.ISupportInitialize).BeginInit()
        CType(Volume, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' WindowBox
        ' 
        WindowBox.BackColor = SystemColors.ActiveBorder
        WindowBox.BorderStyle = BorderStyle.Fixed3D
        WindowBox.Location = New Point(-34, -17)
        WindowBox.Margin = New Padding(3, 2, 3, 2)
        WindowBox.Name = "WindowBox"
        WindowBox.Size = New Size(756, 546)
        WindowBox.SizeMode = PictureBoxSizeMode.StretchImage
        WindowBox.TabIndex = 0
        WindowBox.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(ZoomIn)
        Panel1.Controls.Add(ZoomOut)
        Panel1.Controls.Add(WindowBox)
        Panel1.Location = New Point(10, 9)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(676, 513)
        Panel1.TabIndex = 0
        ' 
        ' ZoomIn
        ' 
        ZoomIn.Image = My.Resources.Resources.zoom_in
        ZoomIn.Location = New Point(541, 456)
        ZoomIn.Margin = New Padding(3, 2, 3, 2)
        ZoomIn.Name = "ZoomIn"
        ZoomIn.Size = New Size(56, 46)
        ZoomIn.SizeMode = PictureBoxSizeMode.StretchImage
        ZoomIn.TabIndex = 2
        ZoomIn.TabStop = False
        ' 
        ' ZoomOut
        ' 
        ZoomOut.Image = My.Resources.Resources.zoom_out
        ZoomOut.Location = New Point(603, 456)
        ZoomOut.Margin = New Padding(3, 2, 3, 2)
        ZoomOut.Name = "ZoomOut"
        ZoomOut.Size = New Size(58, 46)
        ZoomOut.SizeMode = PictureBoxSizeMode.StretchImage
        ZoomOut.TabIndex = 1
        ZoomOut.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Gainsboro
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(PictureBox17)
        Panel2.Controls.Add(PictureBox18)
        Panel2.Controls.Add(PictureBox19)
        Panel2.Controls.Add(PictureBox20)
        Panel2.Controls.Add(PictureBox21)
        Panel2.Controls.Add(AromaUp)
        Panel2.Controls.Add(AromaDown)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(PictureBox12)
        Panel2.Controls.Add(PictureBox13)
        Panel2.Controls.Add(PictureBox14)
        Panel2.Controls.Add(PictureBox15)
        Panel2.Controls.Add(PictureBox16)
        Panel2.Controls.Add(PictureBox7)
        Panel2.Controls.Add(PictureBox8)
        Panel2.Controls.Add(PictureBox9)
        Panel2.Controls.Add(PictureBox10)
        Panel2.Controls.Add(PictureBox11)
        Panel2.Controls.Add(PictureBox6)
        Panel2.Controls.Add(PictureBox5)
        Panel2.Controls.Add(PictureBox4)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(Tour_Name)
        Panel2.Controls.Add(TempUp)
        Panel2.Controls.Add(TempDown)
        Panel2.Controls.Add(BrightnessDown)
        Panel2.Controls.Add(BrightnessUp)
        Panel2.Controls.Add(VolumeDown)
        Panel2.Controls.Add(VolumeUp)
        Panel2.Controls.Add(Temp)
        Panel2.Controls.Add(Brightness)
        Panel2.Controls.Add(Volume)
        Panel2.Controls.Add(VolumeLabel)
        Panel2.Controls.Add(BrightnessLabel)
        Panel2.Controls.Add(TemperatureLabel)
        Panel2.Controls.Add(AromaLabel)
        Panel2.Location = New Point(691, 11)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(541, 233)
        Panel2.TabIndex = 1
        ' 
        ' PictureBox17
        ' 
        PictureBox17.BackColor = Color.DarkGray
        PictureBox17.Location = New Point(419, 185)
        PictureBox17.Margin = New Padding(3, 2, 3, 2)
        PictureBox17.Name = "PictureBox17"
        PictureBox17.Size = New Size(25, 40)
        PictureBox17.TabIndex = 33
        PictureBox17.TabStop = False
        ' 
        ' PictureBox18
        ' 
        PictureBox18.BackColor = Color.DarkGray
        PictureBox18.Location = New Point(389, 185)
        PictureBox18.Margin = New Padding(3, 2, 3, 2)
        PictureBox18.Name = "PictureBox18"
        PictureBox18.Size = New Size(25, 40)
        PictureBox18.TabIndex = 32
        PictureBox18.TabStop = False
        ' 
        ' PictureBox19
        ' 
        PictureBox19.BackColor = Color.GreenYellow
        PictureBox19.Location = New Point(358, 185)
        PictureBox19.Margin = New Padding(3, 2, 3, 2)
        PictureBox19.Name = "PictureBox19"
        PictureBox19.Size = New Size(25, 40)
        PictureBox19.TabIndex = 31
        PictureBox19.TabStop = False
        ' 
        ' PictureBox20
        ' 
        PictureBox20.BackColor = Color.GreenYellow
        PictureBox20.Location = New Point(327, 185)
        PictureBox20.Margin = New Padding(3, 2, 3, 2)
        PictureBox20.Name = "PictureBox20"
        PictureBox20.Size = New Size(25, 40)
        PictureBox20.TabIndex = 30
        PictureBox20.TabStop = False
        ' 
        ' PictureBox21
        ' 
        PictureBox21.BackColor = Color.GreenYellow
        PictureBox21.Location = New Point(297, 185)
        PictureBox21.Margin = New Padding(3, 2, 3, 2)
        PictureBox21.Name = "PictureBox21"
        PictureBox21.Size = New Size(25, 40)
        PictureBox21.TabIndex = 29
        PictureBox21.TabStop = False
        ' 
        ' AromaUp
        ' 
        AromaUp.BackColor = SystemColors.ButtonFace
        AromaUp.Cursor = Cursors.Hand
        AromaUp.Image = My.Resources.Resources.green_up
        AromaUp.Location = New Point(159, 185)
        AromaUp.Margin = New Padding(3, 2, 3, 2)
        AromaUp.Name = "AromaUp"
        AromaUp.Size = New Size(62, 40)
        AromaUp.SizeMode = PictureBoxSizeMode.StretchImage
        AromaUp.TabIndex = 28
        AromaUp.TabStop = False
        ' 
        ' AromaDown
        ' 
        AromaDown.BackColor = SystemColors.ButtonFace
        AromaDown.Cursor = Cursors.Hand
        AromaDown.Image = My.Resources.Resources.blue_down
        AromaDown.Location = New Point(227, 185)
        AromaDown.Margin = New Padding(3, 2, 3, 2)
        AromaDown.Name = "AromaDown"
        AromaDown.Size = New Size(65, 40)
        AromaDown.SizeMode = PictureBoxSizeMode.StretchImage
        AromaDown.TabIndex = 27
        AromaDown.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ButtonFace
        PictureBox1.Image = My.Resources.Resources.aroma
        PictureBox1.Location = New Point(98, 185)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(56, 40)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 26
        PictureBox1.TabStop = False
        ' 
        ' PictureBox12
        ' 
        PictureBox12.BackColor = Color.DarkGray
        PictureBox12.Location = New Point(419, 141)
        PictureBox12.Margin = New Padding(3, 2, 3, 2)
        PictureBox12.Name = "PictureBox12"
        PictureBox12.Size = New Size(25, 40)
        PictureBox12.TabIndex = 25
        PictureBox12.TabStop = False
        ' 
        ' PictureBox13
        ' 
        PictureBox13.BackColor = Color.DarkGray
        PictureBox13.Location = New Point(389, 141)
        PictureBox13.Margin = New Padding(3, 2, 3, 2)
        PictureBox13.Name = "PictureBox13"
        PictureBox13.Size = New Size(25, 40)
        PictureBox13.TabIndex = 24
        PictureBox13.TabStop = False
        ' 
        ' PictureBox14
        ' 
        PictureBox14.BackColor = Color.GreenYellow
        PictureBox14.Location = New Point(358, 141)
        PictureBox14.Margin = New Padding(3, 2, 3, 2)
        PictureBox14.Name = "PictureBox14"
        PictureBox14.Size = New Size(25, 40)
        PictureBox14.TabIndex = 23
        PictureBox14.TabStop = False
        ' 
        ' PictureBox15
        ' 
        PictureBox15.BackColor = Color.GreenYellow
        PictureBox15.Location = New Point(327, 141)
        PictureBox15.Margin = New Padding(3, 2, 3, 2)
        PictureBox15.Name = "PictureBox15"
        PictureBox15.Size = New Size(25, 40)
        PictureBox15.TabIndex = 22
        PictureBox15.TabStop = False
        ' 
        ' PictureBox16
        ' 
        PictureBox16.BackColor = Color.GreenYellow
        PictureBox16.Location = New Point(297, 141)
        PictureBox16.Margin = New Padding(3, 2, 3, 2)
        PictureBox16.Name = "PictureBox16"
        PictureBox16.Size = New Size(25, 40)
        PictureBox16.TabIndex = 21
        PictureBox16.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.DarkGray
        PictureBox7.Location = New Point(419, 97)
        PictureBox7.Margin = New Padding(3, 2, 3, 2)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(25, 40)
        PictureBox7.TabIndex = 20
        PictureBox7.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = Color.DarkGray
        PictureBox8.Location = New Point(389, 97)
        PictureBox8.Margin = New Padding(3, 2, 3, 2)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(25, 40)
        PictureBox8.TabIndex = 19
        PictureBox8.TabStop = False
        ' 
        ' PictureBox9
        ' 
        PictureBox9.BackColor = Color.GreenYellow
        PictureBox9.Location = New Point(358, 97)
        PictureBox9.Margin = New Padding(3, 2, 3, 2)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(25, 40)
        PictureBox9.TabIndex = 18
        PictureBox9.TabStop = False
        ' 
        ' PictureBox10
        ' 
        PictureBox10.BackColor = Color.GreenYellow
        PictureBox10.Location = New Point(327, 97)
        PictureBox10.Margin = New Padding(3, 2, 3, 2)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(25, 40)
        PictureBox10.TabIndex = 17
        PictureBox10.TabStop = False
        ' 
        ' PictureBox11
        ' 
        PictureBox11.BackColor = Color.GreenYellow
        PictureBox11.Location = New Point(297, 97)
        PictureBox11.Margin = New Padding(3, 2, 3, 2)
        PictureBox11.Name = "PictureBox11"
        PictureBox11.Size = New Size(25, 40)
        PictureBox11.TabIndex = 16
        PictureBox11.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.DarkGray
        PictureBox6.Location = New Point(419, 52)
        PictureBox6.Margin = New Padding(3, 2, 3, 2)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(25, 40)
        PictureBox6.TabIndex = 15
        PictureBox6.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.DarkGray
        PictureBox5.Location = New Point(389, 52)
        PictureBox5.Margin = New Padding(3, 2, 3, 2)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(25, 40)
        PictureBox5.TabIndex = 14
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.GreenYellow
        PictureBox4.Location = New Point(358, 52)
        PictureBox4.Margin = New Padding(3, 2, 3, 2)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(25, 40)
        PictureBox4.TabIndex = 13
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.GreenYellow
        PictureBox3.Location = New Point(327, 52)
        PictureBox3.Margin = New Padding(3, 2, 3, 2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(25, 40)
        PictureBox3.TabIndex = 12
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.GreenYellow
        PictureBox2.Location = New Point(297, 52)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(25, 40)
        PictureBox2.TabIndex = 11
        PictureBox2.TabStop = False
        ' 
        ' Tour_Name
        ' 
        Tour_Name.AutoSize = True
        Tour_Name.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        Tour_Name.Location = New Point(18, 9)
        Tour_Name.Name = "Tour_Name"
        Tour_Name.Size = New Size(68, 15)
        Tour_Name.TabIndex = 10
        Tour_Name.Text = "Tour Name"
        ' 
        ' TempUp
        ' 
        TempUp.BackColor = SystemColors.ButtonFace
        TempUp.Cursor = Cursors.Hand
        TempUp.Image = My.Resources.Resources.green_up
        TempUp.Location = New Point(159, 141)
        TempUp.Margin = New Padding(3, 2, 3, 2)
        TempUp.Name = "TempUp"
        TempUp.Size = New Size(62, 40)
        TempUp.SizeMode = PictureBoxSizeMode.StretchImage
        TempUp.TabIndex = 9
        TempUp.TabStop = False
        ' 
        ' TempDown
        ' 
        TempDown.BackColor = SystemColors.ButtonFace
        TempDown.Cursor = Cursors.Hand
        TempDown.Image = My.Resources.Resources.blue_down
        TempDown.Location = New Point(227, 141)
        TempDown.Margin = New Padding(3, 2, 3, 2)
        TempDown.Name = "TempDown"
        TempDown.Size = New Size(65, 40)
        TempDown.SizeMode = PictureBoxSizeMode.StretchImage
        TempDown.TabIndex = 8
        TempDown.TabStop = False
        ' 
        ' BrightnessDown
        ' 
        BrightnessDown.BackColor = SystemColors.ButtonFace
        BrightnessDown.Cursor = Cursors.Hand
        BrightnessDown.Image = My.Resources.Resources.blue_down
        BrightnessDown.Location = New Point(227, 97)
        BrightnessDown.Margin = New Padding(3, 2, 3, 2)
        BrightnessDown.Name = "BrightnessDown"
        BrightnessDown.Size = New Size(65, 40)
        BrightnessDown.SizeMode = PictureBoxSizeMode.StretchImage
        BrightnessDown.TabIndex = 7
        BrightnessDown.TabStop = False
        ' 
        ' BrightnessUp
        ' 
        BrightnessUp.BackColor = SystemColors.ButtonFace
        BrightnessUp.Cursor = Cursors.Hand
        BrightnessUp.Image = My.Resources.Resources.green_up
        BrightnessUp.Location = New Point(159, 97)
        BrightnessUp.Margin = New Padding(3, 2, 3, 2)
        BrightnessUp.Name = "BrightnessUp"
        BrightnessUp.Size = New Size(62, 40)
        BrightnessUp.SizeMode = PictureBoxSizeMode.StretchImage
        BrightnessUp.TabIndex = 6
        BrightnessUp.TabStop = False
        ' 
        ' VolumeDown
        ' 
        VolumeDown.BackColor = SystemColors.ButtonFace
        VolumeDown.Cursor = Cursors.Hand
        VolumeDown.Image = My.Resources.Resources.blue_down
        VolumeDown.Location = New Point(227, 52)
        VolumeDown.Margin = New Padding(3, 2, 3, 2)
        VolumeDown.Name = "VolumeDown"
        VolumeDown.Size = New Size(65, 40)
        VolumeDown.SizeMode = PictureBoxSizeMode.StretchImage
        VolumeDown.TabIndex = 5
        VolumeDown.TabStop = False
        ' 
        ' VolumeUp
        ' 
        VolumeUp.BackColor = SystemColors.ButtonFace
        VolumeUp.Cursor = Cursors.Hand
        VolumeUp.Image = My.Resources.Resources.green_up
        VolumeUp.Location = New Point(159, 52)
        VolumeUp.Margin = New Padding(3, 2, 3, 2)
        VolumeUp.Name = "VolumeUp"
        VolumeUp.Size = New Size(62, 40)
        VolumeUp.SizeMode = PictureBoxSizeMode.StretchImage
        VolumeUp.TabIndex = 4
        VolumeUp.TabStop = False
        ' 
        ' Temp
        ' 
        Temp.BackColor = SystemColors.ButtonFace
        Temp.Image = My.Resources.Resources.temperature
        Temp.Location = New Point(98, 141)
        Temp.Margin = New Padding(3, 2, 3, 2)
        Temp.Name = "Temp"
        Temp.Size = New Size(56, 40)
        Temp.SizeMode = PictureBoxSizeMode.StretchImage
        Temp.TabIndex = 2
        Temp.TabStop = False
        ' 
        ' Brightness
        ' 
        Brightness.BackColor = SystemColors.ButtonFace
        Brightness.BackgroundImageLayout = ImageLayout.None
        Brightness.Image = My.Resources.Resources.brightness
        Brightness.Location = New Point(98, 97)
        Brightness.Margin = New Padding(3, 2, 3, 2)
        Brightness.Name = "Brightness"
        Brightness.Size = New Size(56, 40)
        Brightness.SizeMode = PictureBoxSizeMode.StretchImage
        Brightness.TabIndex = 1
        Brightness.TabStop = False
        ' 
        ' Volume
        ' 
        Volume.BackColor = SystemColors.ButtonFace
        Volume.Image = My.Resources.Resources.sound
        Volume.Location = New Point(98, 52)
        Volume.Margin = New Padding(3, 2, 3, 2)
        Volume.Name = "Volume"
        Volume.Size = New Size(56, 40)
        Volume.SizeMode = PictureBoxSizeMode.StretchImage
        Volume.TabIndex = 0
        Volume.TabStop = False
        ' 
        ' VolumeLabel
        ' 
        VolumeLabel.AutoSize = True
        VolumeLabel.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        VolumeLabel.Location = New Point(20, 64)
        VolumeLabel.Name = "VolumeLabel"
        VolumeLabel.Size = New Size(56, 15)
        VolumeLabel.TabIndex = 34
        VolumeLabel.Text = "VOLUME"
        ' 
        ' BrightnessLabel
        ' 
        BrightnessLabel.AutoSize = True
        BrightnessLabel.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        BrightnessLabel.Location = New Point(5, 107)
        BrightnessLabel.Name = "BrightnessLabel"
        BrightnessLabel.Size = New Size(81, 15)
        BrightnessLabel.TabIndex = 35
        BrightnessLabel.Text = "BRIGHTNESS"
        ' 
        ' TemperatureLabel
        ' 
        TemperatureLabel.AutoSize = True
        TemperatureLabel.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        TemperatureLabel.Location = New Point(3, 152)
        TemperatureLabel.Name = "TemperatureLabel"
        TemperatureLabel.Size = New Size(89, 15)
        TemperatureLabel.TabIndex = 36
        TemperatureLabel.Text = "TEMPERATURE"
        ' 
        ' AromaLabel
        ' 
        AromaLabel.AutoSize = True
        AromaLabel.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        AromaLabel.Location = New Point(25, 196)
        AromaLabel.Name = "AromaLabel"
        AromaLabel.Size = New Size(51, 15)
        AromaLabel.TabIndex = 37
        AromaLabel.Text = "AROMA"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ButtonFace
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(Button3)
        Panel3.Controls.Add(Button2)
        Panel3.Controls.Add(Information)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(TourLocation)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(Year)
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(Button1)
        Panel3.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Panel3.Location = New Point(692, 248)
        Panel3.Margin = New Padding(3, 2, 3, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(540, 276)
        Panel3.TabIndex = 2
        ' 
        ' Button3
        ' 
        Button3.ForeColor = Color.Red
        Button3.Location = New Point(408, 190)
        Button3.Name = "Button3"
        Button3.Size = New Size(103, 50)
        Button3.TabIndex = 8
        Button3.Text = "Request for Emergency Stop"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(408, 50)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(103, 22)
        Button2.TabIndex = 7
        Button2.Text = "Skip Next Visit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Information
        ' 
        Information.Font = New Font("Tahoma", 8.25F, FontStyle.Italic, GraphicsUnit.Point)
        Information.Location = New Point(107, 80)
        Information.Name = "Information"
        Information.Size = New Size(259, 184)
        Information.TabIndex = 6
        Information.Text = "Label4"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(19, 80)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 15)
        Label3.TabIndex = 5
        Label3.Text = "Information: "
        ' 
        ' TourLocation
        ' 
        TourLocation.AutoSize = True
        TourLocation.Location = New Point(107, 47)
        TourLocation.Name = "TourLocation"
        TourLocation.Size = New Size(41, 15)
        TourLocation.TabIndex = 4
        TourLocation.Text = "Label3"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(19, 47)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 15)
        Label2.TabIndex = 3
        Label2.Text = "Location: "
        ' 
        ' Year
        ' 
        Year.AutoSize = True
        Year.Location = New Point(107, 19)
        Year.Name = "Year"
        Year.Size = New Size(41, 15)
        Year.TabIndex = 2
        Year.Text = "Label2"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(19, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 15)
        Label1.TabIndex = 1
        Label1.Text = "Era (number): "
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(408, 19)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(103, 22)
        Button1.TabIndex = 0
        Button1.Text = "Modify Tour"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(10, 527)
        Label4.Name = "Label4"
        Label4.Size = New Size(165, 15)
        Label4.TabIndex = 3
        Label4.Text = "Time Remaining (This Stop): "
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(231, 527)
        ProgressBar1.Margin = New Padding(3, 2, 3, 2)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(999, 15)
        ProgressBar1.TabIndex = 4
        ' 
        ' VisitorView
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1241, 577)
        Controls.Add(ProgressBar1)
        Controls.Add(Label4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(3, 2, 3, 2)
        Name = "VisitorView"
        Text = "VisitorView"
        CType(WindowBox, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(ZoomIn, ComponentModel.ISupportInitialize).EndInit()
        CType(ZoomOut, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox17, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox18, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox19, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox20, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox21, ComponentModel.ISupportInitialize).EndInit()
        CType(AromaUp, ComponentModel.ISupportInitialize).EndInit()
        CType(AromaDown, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox12, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox13, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox14, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox15, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox16, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(TempUp, ComponentModel.ISupportInitialize).EndInit()
        CType(TempDown, ComponentModel.ISupportInitialize).EndInit()
        CType(BrightnessDown, ComponentModel.ISupportInitialize).EndInit()
        CType(BrightnessUp, ComponentModel.ISupportInitialize).EndInit()
        CType(VolumeDown, ComponentModel.ISupportInitialize).EndInit()
        CType(VolumeUp, ComponentModel.ISupportInitialize).EndInit()
        CType(Temp, ComponentModel.ISupportInitialize).EndInit()
        CType(Brightness, ComponentModel.ISupportInitialize).EndInit()
        CType(Volume, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents WindowBox As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Temp As PictureBox
    Friend WithEvents Brightness As PictureBox
    Friend WithEvents Volume As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents VolumeDown As PictureBox
    Friend WithEvents VolumeUp As PictureBox
    Friend WithEvents TempUp As PictureBox
    Friend WithEvents TempDown As PictureBox
    Friend WithEvents BrightnessDown As PictureBox
    Friend WithEvents BrightnessUp As PictureBox
    Friend WithEvents Tour_Name As Label
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents PictureBox16 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Information As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TourLocation As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Year As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox17 As PictureBox
    Friend WithEvents PictureBox18 As PictureBox
    Friend WithEvents PictureBox19 As PictureBox
    Friend WithEvents PictureBox20 As PictureBox
    Friend WithEvents PictureBox21 As PictureBox
    Friend WithEvents AromaUp As PictureBox
    Friend WithEvents AromaDown As PictureBox
    Friend WithEvents ZoomIn As PictureBox
    Friend WithEvents ZoomOut As PictureBox
    Friend WithEvents Button3 As Button

    Friend WithEvents VolumeLabel As Label
    Friend WithEvents BrightnessLabel As Label
    Friend WithEvents TemperatureLabel As Label
    Friend WithEvents AromaLabel As Label

End Class