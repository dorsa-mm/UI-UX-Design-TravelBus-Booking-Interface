<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateTour
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.btnAdder = New System.Windows.Forms.Button()
        Me.txtDuration = New System.Windows.Forms.TextBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.boxPlace = New System.Windows.Forms.PictureBox()
        Me.lblPlaceName = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.mapBox = New System.Windows.Forms.PictureBox()
        Me.panelContinent = New System.Windows.Forms.Panel()
        Me.lblTimeLine = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAntartica = New System.Windows.Forms.Button()
        Me.btnAfrica = New System.Windows.Forms.Button()
        Me.btnAsia = New System.Windows.Forms.Button()
        Me.btnEurope = New System.Windows.Forms.Button()
        Me.btnSouthAmerica = New System.Windows.Forms.Button()
        Me.btnAustralia = New System.Windows.Forms.Button()
        Me.btnNorthAmerica = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.panelAgeSelection = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        'Me.btnFuture = New System.Windows.Forms.Button()
        Me.btnPast = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtTimeLine = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.panelTourStatus = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelBoxes = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblTourName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.progressDuration = New System.Windows.Forms.ProgressBar()
        Me.btnConfirmTrip = New System.Windows.Forms.Button()
        Me.lblDurationstatus = New System.Windows.Forms.Label()
        Me.panelCreateTour = New System.Windows.Forms.Panel()
        Me.btnTourSet = New System.Windows.Forms.Button()
        Me.txtTourName = New System.Windows.Forms.TextBox()
        Me.lblTourNamePrompt = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        ' -- FORM SETTINGS --
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1256, 667)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CREATE TOUR"
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        '
        ' -- PANEL3 (UPDATED LAYOUT) --
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.lblDesc)
        Me.Panel3.Controls.Add(Me.btnAdder)
        Me.Panel3.Controls.Add(Me.txtDuration)
        Me.Panel3.Controls.Add(Me.NumericUpDown1)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.boxPlace)
        Me.Panel3.Controls.Add(Me.lblPlaceName)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Location = New System.Drawing.Point(689, 358)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(537, 268)
        Me.Panel3.TabIndex = 17
        Me.Panel3.Visible = False
        '
        ' lblDesc
        '
        Me.lblDesc.AutoSize = False
        Me.lblDesc.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.lblDesc.Location = New System.Drawing.Point(20, 10)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(500, 60)
        Me.lblDesc.TabIndex = 6
        Me.lblDesc.Text = "COUNTRY DESCRIPTION HERE"
        '
        ' boxPlace
        '
        Me.boxPlace.Location = New System.Drawing.Point(20, 80)
        Me.boxPlace.Name = "boxPlace"
        Me.boxPlace.Size = New System.Drawing.Size(193, 116)
        Me.boxPlace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.boxPlace.TabIndex = 1
        Me.boxPlace.TabStop = False
        '
        ' lblPlaceName
        '
        Me.lblPlaceName.AutoSize = True
        Me.lblPlaceName.Location = New System.Drawing.Point(240, 80)
        Me.lblPlaceName.Name = "lblPlaceName"
        Me.lblPlaceName.Size = New System.Drawing.Size(85, 15)
        Me.lblPlaceName.TabIndex = 0
        Me.lblPlaceName.Text = "PLACE NAME"
        ' 
        ' Label8 (VISIT DURATION)
        '
        Me.Label8.AutoSize = True
        Me.Label8.Text = "VISIT DURATION (1-6):"
        Me.Label8.Location = New System.Drawing.Point(220, 167)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 15)
        Me.Label8.TabIndex = 2

        ' txtDuration (unchanged)
        '
        Me.txtDuration.Location = New System.Drawing.Point(355, 164)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(30, 23)
        Me.txtDuration.TabIndex = 3

        ' Label12 (STOP NUMBER)
        '
        Me.Label12.AutoSize = True
        Me.Label12.Text = "STOP NUMBER:"
        Me.Label12.Location = New System.Drawing.Point(385, 167)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 15)
        Me.Label12.TabIndex = 2

        ' NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(480, 165)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(40, 23)
        Me.NumericUpDown1.TabIndex = 12
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})

        '
        ' btnAdder (ADD VISIT)
        '
        Me.btnAdder.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAdder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdder.ForeColor = System.Drawing.Color.White
        Me.btnAdder.Location = New System.Drawing.Point(240, 200)
        Me.btnAdder.Name = "btnAdder"
        Me.btnAdder.Size = New System.Drawing.Size(120, 30)
        Me.btnAdder.TabIndex = 5
        Me.btnAdder.Text = "ADD VISIT"
        Me.btnAdder.UseVisualStyleBackColor = False
        '
        ' PANEL2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.ListBox1)
        Me.Panel2.Controls.Add(Me.mapBox)
        Me.Panel2.Location = New System.Drawing.Point(12, 404)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(671, 222)
        Me.Panel2.TabIndex = 16
        Me.Panel2.Visible = False
        '
        ' Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Text = "SELECT YOUR PREFERRED LOCATION"
        Me.Label9.Location = New System.Drawing.Point(5, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(227, 15)
        Me.Label9.TabIndex = 2
        '
        ' ListBox1
        '
        Me.ListBox1.Location = New System.Drawing.Point(5, 26)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(189, 124)
        Me.ListBox1.TabIndex = 1
        '
        ' mapBox
        '
        Me.mapBox.Location = New System.Drawing.Point(210, 26)
        Me.mapBox.Name = "mapBox"
        Me.mapBox.Size = New System.Drawing.Size(151, 165)
        Me.mapBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mapBox.TabIndex = 0
        Me.mapBox.TabStop = False
        '
        ' panelContinent
        '
        Me.panelContinent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelContinent.Controls.Add(Me.lblTimeLine)
        Me.panelContinent.Controls.Add(Me.Label6)
        Me.panelContinent.Controls.Add(Me.btnAntartica)
        Me.panelContinent.Controls.Add(Me.btnAfrica)
        Me.panelContinent.Controls.Add(Me.btnAsia)
        Me.panelContinent.Controls.Add(Me.btnEurope)
        Me.panelContinent.Controls.Add(Me.btnSouthAmerica)
        Me.panelContinent.Controls.Add(Me.btnAustralia)
        Me.panelContinent.Controls.Add(Me.btnNorthAmerica)
        Me.panelContinent.Controls.Add(Me.Label5)
        Me.panelContinent.Location = New System.Drawing.Point(12, 188)
        Me.panelContinent.Name = "panelContinent"
        Me.panelContinent.Size = New System.Drawing.Size(671, 210)
        Me.panelContinent.TabIndex = 15
        Me.panelContinent.Visible = False
        '
        ' lblTimeLine
        '
        Me.lblTimeLine.AutoSize = True
        Me.lblTimeLine.Text = ""
        Me.lblTimeLine.Location = New System.Drawing.Point(121, 7)
        Me.lblTimeLine.Name = "lblTimeLine"
        Me.lblTimeLine.Size = New System.Drawing.Size(0, 15)
        Me.lblTimeLine.TabIndex = 14
        '
        ' Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Text = "CURRENT TIMELINE:"
        Me.Label6.Location = New System.Drawing.Point(3, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 15)
        Me.Label6.TabIndex = 13
        '
        ' btnAntartica
        '
        Me.btnAntartica.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAntartica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAntartica.ForeColor = System.Drawing.Color.White
        Me.btnAntartica.Location = New System.Drawing.Point(20, 148)
        Me.btnAntartica.Name = "btnAntartica"
        Me.btnAntartica.Size = New System.Drawing.Size(340, 39)
        Me.btnAntartica.TabIndex = 12
        Me.btnAntartica.Text = "ANTARCTICA"
        Me.btnAntartica.UseVisualStyleBackColor = False
        '
        ' btnAfrica
        '
        Me.btnAfrica.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAfrica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAfrica.ForeColor = System.Drawing.Color.White
        Me.btnAfrica.Location = New System.Drawing.Point(165, 102)
        Me.btnAfrica.Name = "btnAfrica"
        Me.btnAfrica.Size = New System.Drawing.Size(93, 40)
        Me.btnAfrica.TabIndex = 10
        Me.btnAfrica.Text = "AFRICA"
        Me.btnAfrica.UseVisualStyleBackColor = False
        '
        ' btnAsia
        '
        Me.btnAsia.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAsia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAsia.ForeColor = System.Drawing.Color.White
        Me.btnAsia.Location = New System.Drawing.Point(264, 56)
        Me.btnAsia.Name = "btnAsia"
        Me.btnAsia.Size = New System.Drawing.Size(98, 40)
        Me.btnAsia.TabIndex = 9
        Me.btnAsia.Text = "ASIA"
        Me.btnAsia.UseVisualStyleBackColor = False
        '
        ' btnEurope
        '
        Me.btnEurope.BackColor = System.Drawing.Color.SteelBlue
        Me.btnEurope.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEurope.ForeColor = System.Drawing.Color.White
        Me.btnEurope.Location = New System.Drawing.Point(165, 56)
        Me.btnEurope.Name = "btnEurope"
        Me.btnEurope.Size = New System.Drawing.Size(93, 40)
        Me.btnEurope.TabIndex = 8
        Me.btnEurope.Text = "EUROPE"
        Me.btnEurope.UseVisualStyleBackColor = False
        '
        ' btnSouthAmerica
        '
        Me.btnSouthAmerica.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSouthAmerica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSouthAmerica.ForeColor = System.Drawing.Color.White
        Me.btnSouthAmerica.Location = New System.Drawing.Point(20, 102)
        Me.btnSouthAmerica.Name = "btnSouthAmerica"
        Me.btnSouthAmerica.Size = New System.Drawing.Size(139, 40)
        Me.btnSouthAmerica.TabIndex = 7
        Me.btnSouthAmerica.Text = "SOUTH AMERICA"
        Me.btnSouthAmerica.UseVisualStyleBackColor = False
        '
        ' btnAustralia
        '
        Me.btnAustralia.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAustralia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAustralia.ForeColor = System.Drawing.Color.White
        Me.btnAustralia.Location = New System.Drawing.Point(264, 102)
        Me.btnAustralia.Name = "btnAustralia"
        Me.btnAustralia.Size = New System.Drawing.Size(98, 40)
        Me.btnAustralia.TabIndex = 11
        Me.btnAustralia.Text = "AUSTRALIA"
        Me.btnAustralia.UseVisualStyleBackColor = False
        '
        ' btnNorthAmerica
        '
        Me.btnNorthAmerica.BackColor = System.Drawing.Color.SteelBlue
        Me.btnNorthAmerica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNorthAmerica.ForeColor = System.Drawing.Color.White
        Me.btnNorthAmerica.Location = New System.Drawing.Point(20, 56)
        Me.btnNorthAmerica.Name = "btnNorthAmerica"
        Me.btnNorthAmerica.Size = New System.Drawing.Size(139, 40)
        Me.btnNorthAmerica.TabIndex = 6
        Me.btnNorthAmerica.Text = "NORTH AMERICA"
        Me.btnNorthAmerica.UseVisualStyleBackColor = False
        '
        ' Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Text = "SELECT THE INTENDED CONTINENT OF VISIT:"
        Me.Label5.Location = New System.Drawing.Point(3, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(277, 15)
        Me.Label5.TabIndex = 5
        '
        ' panelAgeSelection
        '
        Me.panelAgeSelection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelAgeSelection.Controls.Add(Me.Label2)
        'Me.panelAgeSelection.Controls.Add(Me.btnFuture)
        Me.panelAgeSelection.Controls.Add(Me.btnPast)
        Me.panelAgeSelection.Location = New System.Drawing.Point(12, 62)
        Me.panelAgeSelection.Name = "panelAgeSelection"
        Me.panelAgeSelection.Size = New System.Drawing.Size(671, 52)
        Me.panelAgeSelection.TabIndex = 13
        Me.panelAgeSelection.Visible = False
        '
        ' Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Text = "PLEASE CLICK BELOW TO TRAVEL TO THE PAST:"
        Me.Label2.Location = New System.Drawing.Point(5, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(263, 15)
        Me.Label2.TabIndex = 5
        '
        ' btnPast
        '
        Me.btnPast.BackColor = System.Drawing.Color.SteelBlue
        Me.btnPast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPast.ForeColor = System.Drawing.Color.White
        Me.btnPast.Location = New System.Drawing.Point(298, 6)
        Me.btnPast.Name = "btnPast"
        Me.btnPast.Size = New System.Drawing.Size(63, 38)
        Me.btnPast.TabIndex = 3
        Me.btnPast.Text = "PAST"
        Me.btnPast.UseVisualStyleBackColor = False
        '
        ' Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.txtTimeLine)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(12, 120)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(671, 62)
        Me.Panel1.TabIndex = 14
        Me.Panel1.Visible = False
        '
        ' btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(198, 22)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(70, 28)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        ' txtTimeLine
        '
        Me.txtTimeLine.Location = New System.Drawing.Point(5, 26)
        Me.txtTimeLine.Name = "txtTimeLine"
        Me.txtTimeLine.Size = New System.Drawing.Size(189, 23)
        Me.txtTimeLine.TabIndex = 1
        '
        ' Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Text = "PLEASE ENTER THE ERA NUMBER YOU WANT TO VISIT (1 PRECAMBRIAN, 2 PALEOZOIC, 3 MESOZOIC, 4 CENOZOIC):"
        Me.Label4.Location = New System.Drawing.Point(3, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(308, 15)
        Me.Label4.TabIndex = 0
        '
        ' panelTourStatus
        '
        Me.panelTourStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelTourStatus.Controls.Add(Me.Panel4)
        Me.panelTourStatus.Controls.Add(Me.Button1)
        Me.panelTourStatus.Controls.Add(Me.lblTourName)
        Me.panelTourStatus.Controls.Add(Me.Label3)
        Me.panelTourStatus.Controls.Add(Me.Label7)
        Me.panelTourStatus.Controls.Add(Me.progressDuration)
        Me.panelTourStatus.Controls.Add(Me.btnConfirmTrip)
        Me.panelTourStatus.Controls.Add(Me.lblDurationstatus)
        Me.panelTourStatus.Location = New System.Drawing.Point(689, 12)
        Me.panelTourStatus.Name = "panelTourStatus"
        Me.panelTourStatus.Size = New System.Drawing.Size(537, 335)
        Me.panelTourStatus.TabIndex = 12
        Me.panelTourStatus.Visible = False
        '
        ' Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.panelBoxes)
        Me.Panel4.Location = New System.Drawing.Point(6, 38)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(503, 233)
        Me.Panel4.TabIndex = 14
        '
        ' Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Text = "CLICK ON TRIPS TO EDIT"
        Me.Label1.Location = New System.Drawing.Point(19, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 15)
        Me.Label1.TabIndex = 4
        '
        ' panelBoxes
        '
        Me.panelBoxes.Location = New System.Drawing.Point(9, 55)
        Me.panelBoxes.Name = "panelBoxes"
        Me.panelBoxes.Size = New System.Drawing.Size(465, 135)
        Me.panelBoxes.TabIndex = 3
        '
        ' Button1 (CANCEL)
        '
        Me.Button1.BackColor = System.Drawing.Color.Firebrick
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(335, 302)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 29)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "CANCEL"
        Me.Button1.UseVisualStyleBackColor = False
        '
        ' lblTourName
        '
        Me.lblTourName.AutoSize = True
        Me.lblTourName.Location = New System.Drawing.Point(84, 8)
        Me.lblTourName.Name = "lblTourName"
        Me.lblTourName.Size = New System.Drawing.Size(0, 15)
        Me.lblTourName.TabIndex = 6
        '
        ' Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Text = "TOUR NAME:"
        Me.Label3.Location = New System.Drawing.Point(6, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 15)
        Me.Label3.TabIndex = 7
        '
        ' Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 311)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "TIME FILLED:"
        '
        ' progressDuration
        '
        Me.progressDuration.ForeColor = System.Drawing.Color.Navy
        Me.progressDuration.Location = New System.Drawing.Point(6, 277)
        Me.progressDuration.Maximum = 6
        Me.progressDuration.Name = "progressDuration"
        Me.progressDuration.Size = New System.Drawing.Size(503, 23)
        Me.progressDuration.TabIndex = 10
        '
        ' btnConfirmTrip
        '
        Me.btnConfirmTrip.BackColor = System.Drawing.Color.ForestGreen
        Me.btnConfirmTrip.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirmTrip.ForeColor = System.Drawing.Color.White
        Me.btnConfirmTrip.Location = New System.Drawing.Point(432, 302)
        Me.btnConfirmTrip.Name = "btnConfirmTrip"
        Me.btnConfirmTrip.Size = New System.Drawing.Size(91, 28)
        Me.btnConfirmTrip.TabIndex = 9
        Me.btnConfirmTrip.Text = "CONFIRM"
        Me.btnConfirmTrip.UseVisualStyleBackColor = False
        '
        ' lblDurationstatus
        '
        Me.lblDurationstatus.AutoSize = True
        Me.lblDurationstatus.Location = New System.Drawing.Point(113, 311)
        Me.lblDurationstatus.Name = "lblDurationstatus"
        Me.lblDurationstatus.Size = New System.Drawing.Size(47, 15)
        Me.lblDurationstatus.TabIndex = 11
        Me.lblDurationstatus.Text = "0.0/6.0"
        '
        ' panelCreateTour
        '
        Me.panelCreateTour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelCreateTour.Controls.Add(Me.btnTourSet)
        Me.panelCreateTour.Controls.Add(Me.txtTourName)
        Me.panelCreateTour.Controls.Add(Me.lblTourNamePrompt)
        Me.panelCreateTour.Location = New System.Drawing.Point(12, 12)
        Me.panelCreateTour.Name = "panelCreateTour"
        Me.panelCreateTour.Size = New System.Drawing.Size(671, 44)
        Me.panelCreateTour.TabIndex = 11
        Me.panelCreateTour.Visible = False
        '
        ' btnTourSet
        '
        Me.btnTourSet.BackColor = System.Drawing.Color.SteelBlue
        Me.btnTourSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTourSet.ForeColor = System.Drawing.Color.White
        Me.btnTourSet.Location = New System.Drawing.Point(308, 10)
        Me.btnTourSet.Name = "btnTourSet"
        Me.btnTourSet.Size = New System.Drawing.Size(86, 24)
        Me.btnTourSet.TabIndex = 2
        Me.btnTourSet.Text = "SET"
        Me.btnTourSet.UseVisualStyleBackColor = False
        '
        ' txtTourName
        '
        Me.txtTourName.Location = New System.Drawing.Point(143, 10)
        Me.txtTourName.Name = "txtTourName"
        Me.txtTourName.Size = New System.Drawing.Size(150, 23)
        Me.txtTourName.TabIndex = 1
        '
        ' lblTourNamePrompt
        '
        Me.lblTourNamePrompt.AutoSize = True
        Me.lblTourNamePrompt.Text = "ENTER TOUR NAME:"
        Me.lblTourNamePrompt.Location = New System.Drawing.Point(0, 14)
        Me.lblTourNamePrompt.Name = "lblTourNamePrompt"
        Me.lblTourNamePrompt.Size = New System.Drawing.Size(123, 15)
        Me.lblTourNamePrompt.TabIndex = 0
        '
        ' Button2 (BACK TO HOME)
        '
        Me.Button2.BackColor = System.Drawing.Color.Firebrick
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(12, 632)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 23)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "BACK TO HOME"
        Me.Button2.UseVisualStyleBackColor = False
        '
        ' CreateTour (Add all controls)
        '
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.panelContinent)
        Me.Controls.Add(Me.panelAgeSelection)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelTourStatus)
        Me.Controls.Add(Me.panelCreateTour)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.boxPlace, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mapBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.panelContinent.ResumeLayout(False)
        Me.panelContinent.PerformLayout()
        Me.panelAgeSelection.ResumeLayout(False)
        Me.panelAgeSelection.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelTourStatus.ResumeLayout(False)
        Me.panelTourStatus.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.panelCreateTour.ResumeLayout(False)
        Me.panelCreateTour.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblDesc As Label
    Friend WithEvents btnAdder As Button
    Friend WithEvents txtDuration As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents boxPlace As PictureBox
    Friend WithEvents lblPlaceName As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents mapBox As PictureBox
    Friend WithEvents panelContinent As Panel
    Friend WithEvents lblTimeLine As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAntartica As Button
    Friend WithEvents btnAfrica As Button
    Friend WithEvents btnAsia As Button
    Friend WithEvents btnEurope As Button
    Friend WithEvents btnSouthAmerica As Button
    Friend WithEvents btnAustralia As Button
    Friend WithEvents btnNorthAmerica As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents panelAgeSelection As Panel
    Friend WithEvents Label2 As Label
    'Friend WithEvents btnFuture As Button
    Friend WithEvents btnPast As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtTimeLine As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents panelTourStatus As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents panelBoxes As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents lblTourName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents progressDuration As ProgressBar
    Friend WithEvents btnConfirmTrip As Button
    Friend WithEvents lblDurationstatus As Label
    Friend WithEvents panelCreateTour As Panel
    Friend WithEvents btnTourSet As Button
    Friend WithEvents txtTourName As TextBox
    Friend WithEvents lblTourNamePrompt As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Button2 As Button
End Class
