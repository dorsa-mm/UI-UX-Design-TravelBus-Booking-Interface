Public Class CockpitForm
    Private _trip As Trip
    Public Event TourEnd()
    Public Event Emergency()

    Private currentIndex As Integer = 0
    Private WithEvents slideTimer As New Timer()
    Private WithEvents progressTimer As New Timer()

    ' For image zoom/drag
    Private originalWidth As Integer
    Private originalHeight As Integer
    Private isDragging As Boolean = False
    Private imageScale As Double = 1.0
    Private startPoint As Point

    ' Speed/timing variables
    Private currentSpeed As Integer = 100   ' 100 = normal speed
    Private baseDuration As Integer           ' Base duration (ms) for the current stop (without speed adjustment)
    Private currentStopDuration As Integer    ' Effective duration for the current stop, adjusted by speed
    Private stopStartTime As DateTime         ' When the current stop started

    ' Pause toggle
    Private pause As Boolean = False

    Public Sub New(trip As Trip)
        ' This call is required by the designer.
        InitializeComponent()

        ' Save the trip and update the UI
        _trip = trip
        Tour_Name.Text = _trip.TripName

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

        ' Calculate the base duration for the current stop (in ms)
        baseDuration = 20000 * _trip.Stops(currentIndex).Duration
        ' Adjust by speed multiplier
        currentStopDuration = CInt(baseDuration * (100 / currentSpeed))
        slideTimer.Interval = currentStopDuration
        slideTimer.Start()

        stopStartTime = DateTime.Now

        ' Update UI with current stop details
        WindowBox.Image = _trip.Stops(currentIndex).CountryInfo.Image
        Location.Text = _trip.Stops(currentIndex).LocationName
        Information.Text = _trip.Stops(currentIndex).CountryInfo.TravelDescription
        Year.Text = _trip.Stops(currentIndex).Year
    End Sub

    ' When the current stop time elapses, move to the next stop.
    Private Sub slideTimer_Tick(sender As Object, e As EventArgs) Handles slideTimer.Tick
        currentIndex += 1
        If currentIndex >= _trip.Stops.Count Then
            Dim endTour As New EndOfTour()
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
        RaiseEvent TourEnd()
    End Sub

    ' Update the progress bar and time remaining labels.
    Private Sub progressTimer_Tick(sender As Object, e As EventArgs) Handles progressTimer.Tick
        Dim elapsedMs As Double = (DateTime.Now - stopStartTime).TotalMilliseconds * (100 / currentSpeed)
        Dim fraction As Double = elapsedMs / currentStopDuration
        If fraction < 0 Then fraction = 0
        If fraction > 1 Then fraction = 1
        ProgressBar1.Value = CInt(100 * fraction)

        ' Calculate remaining time for this stop
        Dim remainingMs As Double = currentStopDuration - elapsedMs
        If remainingMs < 0 Then remainingMs = 0
        Dim tsStop As TimeSpan = TimeSpan.FromMilliseconds(remainingMs)

        ' Calculate total trip remaining (this stop + subsequent stops)
        Dim totalRemainingMs As Double = remainingMs
        For i As Integer = currentIndex + 1 To _trip.Stops.Count - 1
            totalRemainingMs += 20000 * _trip.Stops(i).Duration * (100 / currentSpeed)
        Next
        Dim tsTotal As TimeSpan = TimeSpan.FromMilliseconds(totalRemainingMs)

        Label6.Text = "Time Till Next Destination: " & tsStop.ToString("mm\:ss") & vbCrLf &
                      "Total Trip Remaining: " & tsTotal.ToString("hh\:mm\:ss")
    End Sub

    '===========================
    ' Zoom & Drag Handlers
    '===========================
    Private Sub ZoomIn_Click(sender As Object, e As EventArgs) Handles ZoomIn.Click
        imageScale += 0.1
        ApplyZoom()
    End Sub

    Private Sub ZoomOut_Click(sender As Object, e As EventArgs) Handles ZoomOut.Click
        If WindowBox.Height > originalHeight AndAlso WindowBox.Width > originalWidth Then
            imageScale -= 0.1
            ApplyZoom()
        End If
    End Sub

    Private Sub ApplyZoom()
        WindowBox.Width = CInt(originalWidth * imageScale)
        WindowBox.Height = CInt(originalHeight * imageScale)
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

    '===========================
    ' Speed Controls: Increase/Decrease Speed and adjust timers
    '===========================
    Private Sub SpeedPlus_Click(sender As Object, e As EventArgs) Handles SpeedPlus.Click
        currentSpeed += 10
        Speed.Text = currentSpeed.ToString()
        UpdateCurrentStopDuration()
    End Sub

    Private Sub SpeedMinus_Click(sender As Object, e As EventArgs) Handles SpeedMinus.Click
        If currentSpeed > 10 Then
            currentSpeed -= 10
        End If
        Speed.Text = currentSpeed.ToString()
        UpdateCurrentStopDuration()
    End Sub

    Private Sub UpdateCurrentStopDuration()
        ' Recalculate effective duration based on the new speed
        Dim elapsedBase As Double = (DateTime.Now - stopStartTime).TotalMilliseconds
        Dim newTotalDuration As Integer = CInt(baseDuration * (100 / currentSpeed))
        Dim newElapsedScaled As Integer = CInt(elapsedBase * (100 / currentSpeed))
        Dim newRemaining As Integer = newTotalDuration - newElapsedScaled
        If newRemaining < 0 Then newRemaining = 0
        slideTimer.Interval = newRemaining
        currentStopDuration = newTotalDuration
    End Sub

    '===========================
    ' Autopilot Checkbox
    '===========================
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            BackColor = Color.CornflowerBlue
            slideTimer.Start()
            progressTimer.Start()
        Else
            BackColor = Color.GreenYellow
            slideTimer.Stop()
            progressTimer.Stop()
        End If
    End Sub

    '===========================
    ' Forward/Backward Radio Buttons
    '===========================
    Private Sub Forward_CheckedChanged(sender As Object, e As EventArgs) Handles Forward.CheckedChanged
        If Forward.Checked Then
            Backward.Checked = False
        End If
    End Sub

    Private Sub Backward_CheckedChanged(sender As Object, e As EventArgs) Handles Backward.CheckedChanged
        If Backward.Checked Then
            Forward.Checked = False
        End If
    End Sub

    '===========================
    ' Pause / Resume Button
    '===========================
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If pause Then
            Button3.Text = "Pause Time"
            pause = False
            slideTimer.Start()
            progressTimer.Start()
        Else
            Button3.Text = "Resume Time"
            pause = True
            slideTimer.Stop()
            progressTimer.Stop()
        End If
    End Sub

    '===========================
    ' Return Origin Button
    '===========================
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Reset currentIndex to 0 and restart the current stop
        currentIndex = 0
        slideTimer.Stop()
        progressTimer.Stop()
        ShowCurrentTrip()
    End Sub

    '===========================
    ' Jump to Next Visit Button
    '===========================
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        currentIndex += 1
        If currentIndex >= _trip.Stops.Count Then
            RaiseEvent TourEnd()
            slideTimer.Stop()
            progressTimer.Stop()
            Close()
        Else
            ShowCurrentTrip()
        End If
    End Sub

    '===========================
    ' Emergency Stop Button
    '===========================
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Stop the timers
        slideTimer.Stop()
        progressTimer.Stop()

        ' Create and show the Emergency_Procedure form
        Dim emergForm As New Emergency_Procedure()
        emergForm.Show()

        ' Close the cockpit form if desired
        Close()
    End Sub

End Class
