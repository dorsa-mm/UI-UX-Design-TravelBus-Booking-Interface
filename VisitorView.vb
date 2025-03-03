Public Class VisitorView
    Private volumeRow As PictureBox()
    Private brightnessRow As PictureBox()
    Private temperatureRow As PictureBox()
    Private aromaRow As PictureBox()
    Private _trip As Trip
    Private WithEvents slideTimer As New Timer()
    Private currentIndex As Integer = 0
    Private WithEvents progressTimer As New Timer()
    Private remainingTime As Integer = 0
    Private _skipNext As Boolean = False
    Public Event TourEnd()
    Private imageScale As Double = 1.0
    Private originalWidth As Integer
    Private originalHeight As Integer
    Private isDragging As Boolean = False
    Private startPoint As Point
    ' Track current levels for each setting
    Private volumeLevel As Integer = 3          ' start with 3 "lit"
    Private brightnessLevel As Integer = 3
    Private temperatureLevel As Integer = 3
    Private aromaLevel As Integer = 3

    Private stopStartTime As DateTime
    Private currentStopDuration As Integer



    Public Sub New(trip As Trip)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        _trip = trip
        Tour_Name.Text = _trip.TripName
        slideTimer.Interval = 20000 * _trip.Stops(currentIndex).Duration
        volumeRow = {PictureBox2, PictureBox3, PictureBox4, PictureBox5, PictureBox6}
        brightnessRow = {PictureBox11, PictureBox10, PictureBox9, PictureBox8, PictureBox7}
        temperatureRow = {PictureBox16, PictureBox15, PictureBox14, PictureBox13, PictureBox12}
        aromaRow = {PictureBox21, PictureBox20, PictureBox19, PictureBox18, PictureBox17}
        originalWidth = WindowBox.Width
        originalHeight = WindowBox.Height
        StartTrip()
    End Sub

    Private Sub StartTrip()
        If _trip.Stops.Count > 0 Then
            ShowCurrentTrip()
        End If
    End Sub

    Private Sub ShowCurrentTrip()
        progressTimer.Interval = 100
        progressTimer.Start()

        ' Calculate this stop’s duration (in milliseconds)
        currentStopDuration = 20000 * _trip.Stops(currentIndex).Duration
        slideTimer.Interval = currentStopDuration
        slideTimer.Start()

        ' Record the time this stop started
        stopStartTime = DateTime.Now

        WindowBox.Image = _trip.Stops(currentIndex).CountryInfo.Image
        TourLocation.Text = _trip.Stops(currentIndex).LocationName
        Information.Text = _trip.Stops(currentIndex).CountryInfo.TravelDescription
        Year.Text = _trip.Stops(currentIndex).Year
    End Sub


    Private Sub slideTimer_Tick(sender As Object, e As EventArgs) Handles slideTimer.Tick
        ' Move to next trip
        If _skipNext Then
            currentIndex = (currentIndex + 2)
        Else
            currentIndex = (currentIndex + 1)
        End If
        If currentIndex >= _trip.Stops.Count Then
            Dim endTour As New EndOfTour
            AddHandler endTour.EndTour, AddressOf TourEnded
            endTour.Show()
            slideTimer.Stop()
            progressTimer.Stop()
            Close()
        Else
            ShowCurrentTrip()
        End If
    End Sub

    Private Sub TourEnded()
        slideTimer.Stop()
        progressTimer.Stop()
        RaiseEvent TourEnd()
    End Sub

    Private Sub progressTimer_Tick(sender As Object, e As EventArgs) Handles progressTimer.Tick
        ' Calculate elapsed time in milliseconds for this stop
        Dim elapsedMs As Double = (DateTime.Now - stopStartTime).TotalMilliseconds
        Dim fraction As Double = elapsedMs / currentStopDuration
        If fraction < 0 Then fraction = 0
        If fraction > 1 Then fraction = 1

        ProgressBar1.Value = CInt(100 * fraction)

        ' Calculate remaining time for this stop and format it (mm:ss)
        Dim remainingMs As Double = currentStopDuration - elapsedMs
        If remainingMs < 0 Then remainingMs = 0
        Dim ts As TimeSpan = TimeSpan.FromMilliseconds(remainingMs)

        ' Calculate total remaining time for the trip
        Dim totalRemaining As Double = currentStopDuration - elapsedMs
        For i As Integer = currentIndex + 1 To _trip.Stops.Count - 1
            totalRemaining += 20000 * _trip.Stops(i).Duration
        Next
        Dim totalTs As TimeSpan = TimeSpan.FromMilliseconds(totalRemaining)

        Label4.Text = "Time Remaining (This Stop): " & ts.ToString("mm\:ss") & vbCrLf &
                  "Total Trip Remaining: " & totalTs.ToString("hh\:mm\:ss")
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        remainingTime = slideTimer.Interval - (Environment.TickCount Mod slideTimer.Interval)
        slideTimer.Stop()
        progressTimer.Stop()
        Dim modifyTour As New ModifyTour(_trip)
        AddHandler modifyTour.Confirm, AddressOf UpdateTrip
        modifyTour.Show()
    End Sub

    Private Sub UpdateTrip(trip As Trip)
        _trip = trip
        slideTimer.Interval = 30000 * _trip.Stops(currentIndex).Duration
        If remainingTime > 0 Then
            slideTimer.Interval = remainingTime
            remainingTime = 0
        End If
        slideTimer.Start()
        progressTimer.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        _skipNext = True
        Button2.BackColor = Color.Red
    End Sub

    Private Sub ZoomIn_Click(sender As Object, e As EventArgs) Handles ZoomIn.Click
        imageScale += 0.1 ' Increment the zoom scale
        ApplyZoom()
    End Sub

    Private Sub ApplyZoom()
        Dim img As Image = WindowBox.Image
        WindowBox.Width = CInt(WindowBox.Width * imageScale)
        WindowBox.Height = CInt(WindowBox.Height * imageScale)
    End Sub

    Private Sub ZoomOut_Click(sender As Object, e As EventArgs) Handles ZoomOut.Click
        If WindowBox.Height > originalHeight And WindowBox.Width > originalWidth Then ' Prevent zooming out too far
            imageScale -= 0.1
            ApplyZoom()
        End If
    End Sub

    Private Sub WindowBox_MouseDown(sender As Object, e As MouseEventArgs) Handles WindowBox.MouseDown
        isDragging = True
        startPoint = e.Location
    End Sub

    Private Sub WindowBox_MouseMove(sender As Object, e As MouseEventArgs) Handles WindowBox.MouseMove
        If isDragging Then
            Dim dx As Integer = e.X - startPoint.X
            Dim dy As Integer = e.Y - startPoint.Y

            Dim newX As Integer = Math.Max(Math.Min(WindowBox.Left + dx, 0), Panel1.Width - WindowBox.Width)
            Dim newY As Integer = Math.Max(Math.Min(WindowBox.Top + dy, 0), Panel1.Height - WindowBox.Height)

            WindowBox.Location = New Point(newX, newY)
        End If
    End Sub

    Private Sub WindowBox_MouseUp(sender As Object, e As MouseEventArgs) Handles WindowBox.MouseUp
        isDragging = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Stop your timers first
        slideTimer.Stop()
        progressTimer.Stop()

        ' Create an instance of the Emergency_Procedure form
        Dim emergForm As New Emergency_Procedure()

        ' Show the emergency form
        emergForm.Show()

        ' Close current form
        Close()
    End Sub

    Private Sub VisitorView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateVolumeBoxes()
        UpdateBrightnessBoxes()
        UpdateTemperatureBoxes()
        UpdateAromaBoxes()
    End Sub

    Private Sub UpdateVolumeBoxes()
        Dim volumeBoxes As PictureBox() = {PictureBox2, PictureBox3, PictureBox4, PictureBox5, PictureBox6}
        For i As Integer = 0 To 4
            If i < volumeLevel Then
                volumeBoxes(i).BackColor = Color.GreenYellow
            Else
                volumeBoxes(i).BackColor = Color.DarkGray
            End If
        Next
    End Sub

    Private Sub UpdateBrightnessBoxes()
        Dim brightnessBoxes As PictureBox() = {PictureBox11, PictureBox10, PictureBox9, PictureBox8, PictureBox7}
        For i As Integer = 0 To 4
            If i < brightnessLevel Then
                brightnessBoxes(i).BackColor = Color.GreenYellow
            Else
                brightnessBoxes(i).BackColor = Color.DarkGray
            End If
        Next
    End Sub

    Private Sub UpdateTemperatureBoxes()
        Dim temperatureBoxes As PictureBox() = {PictureBox16, PictureBox15, PictureBox14, PictureBox13, PictureBox12}
        For i As Integer = 0 To 4
            If i < temperatureLevel Then
                temperatureBoxes(i).BackColor = Color.GreenYellow
            Else
                temperatureBoxes(i).BackColor = Color.DarkGray
            End If
        Next
    End Sub

    Private Sub UpdateAromaBoxes()
        Dim aromaBoxes As PictureBox() = {PictureBox21, PictureBox20, PictureBox19, PictureBox18, PictureBox17}
        For i As Integer = 0 To 4
            If i < aromaLevel Then
                aromaBoxes(i).BackColor = Color.GreenYellow
            Else
                aromaBoxes(i).BackColor = Color.DarkGray
            End If
        Next
    End Sub

    '---------------------
    ' Volume button handlers
    '---------------------
    Private Sub VolumeUp_Click(sender As Object, e As EventArgs) Handles VolumeUp.Click
        If volumeLevel < 5 Then
            volumeLevel += 1
        End If
        UpdateVolumeBoxes()
    End Sub

    Private Sub VolumeDown_Click(sender As Object, e As EventArgs) Handles VolumeDown.Click
        If volumeLevel > 0 Then
            volumeLevel -= 1
        End If
        UpdateVolumeBoxes()
    End Sub

    '---------------------
    ' Brightness button handlers
    '---------------------
    Private Sub BrightnessUp_Click(sender As Object, e As EventArgs) Handles BrightnessUp.Click
        If brightnessLevel < 5 Then
            brightnessLevel += 1
        End If
        UpdateBrightnessBoxes()
    End Sub

    Private Sub BrightnessDown_Click(sender As Object, e As EventArgs) Handles BrightnessDown.Click
        If brightnessLevel > 0 Then
            brightnessLevel -= 1
        End If
        UpdateBrightnessBoxes()
    End Sub

    '---------------------
    ' Temperature button handlers
    '---------------------
    Private Sub TemperatureUp_Click(sender As Object, e As EventArgs) Handles TempUp.Click
        If temperatureLevel < 5 Then
            temperatureLevel += 1
        End If
        UpdateTemperatureBoxes()
    End Sub

    Private Sub TemperatureDown_Click(sender As Object, e As EventArgs) Handles TempDown.Click
        If temperatureLevel > 0 Then
            temperatureLevel -= 1
        End If
        UpdateTemperatureBoxes()
    End Sub

    '---------------------
    ' Aroma button handlers
    '---------------------
    Private Sub AromaUp_Click(sender As Object, e As EventArgs) Handles AromaUp.Click
        If aromaLevel < 5 Then
            aromaLevel += 1
        End If
        UpdateAromaBoxes()
    End Sub

    Private Sub AromaDown_Click(sender As Object, e As EventArgs) Handles AromaDown.Click
        If aromaLevel > 0 Then
            aromaLevel -= 1
        End If
        UpdateAromaBoxes()
    End Sub
End Class
