Public Class SelectTour
    Private _trips As List(Of Trip)
    Public Event Confirm(trip As Trip)
    Private _isModify As Boolean
    Private _isPilot As Boolean
    Public Event TourEnd()

    Public Sub New(trips As List(Of Trip), isModify As Boolean, isPilot As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _trips = trips
        _isModify = isModify
        _isPilot = isPilot
        ShowTrips(_trips)
    End Sub

    Private Sub ShowTrips(trips As List(Of Trip))
        ' Calculate center dynamically:
        Dim buttonWidth As Integer = 200
        Dim startX As Integer = (Me.ClientSize.Width - buttonWidth) \ 2
        Dim startY As Integer = 95 ' You can adjust the vertical starting point as needed
        Dim buttonHeight As Integer = 30 ' Height of each button
        Dim verticalSpacing As Integer = 10 ' Space between buttons

        For i As Integer = 0 To trips.Count - 1
            Dim trip As Trip = trips(i)

            ' Create a new button for each trip
            Dim tripButton As New Button()
            tripButton.Text = trip.TripName
            tripButton.Size = New Size(buttonWidth, buttonHeight)
            tripButton.Location = New Point(startX, startY + i * (buttonHeight + verticalSpacing))

            ' Optionally, add a click event handler for each button
            AddHandler tripButton.Click, Sub(sender, e) HandleTripButtonClick(trip)

            ' Add the button to the form or container
            Me.Controls.Add(tripButton)
        Next
    End Sub


    ' Example handler for trip button clicks
    Private Sub HandleTripButtonClick(trip As Trip)
        If _isModify Then
            Dim ModifyTour As New ModifyTour(trip)
            AddHandler ModifyTour.Confirm, AddressOf Modified
            ModifyTour.Show()
        ElseIf _isPilot Then
            Dim Cockpit As New CockpitForm(trip)
            AddHandler Cockpit.TourEnd, AddressOf EndedTour
            AddHandler Cockpit.Emergency, AddressOf EndedTour
            Cockpit.Show()
        Else
            Dim Visitor As New VisitorView(trip)
            AddHandler Visitor.TourEnd, AddressOf EndedTour
            Visitor.Show()
        End If
        Close()
    End Sub

    Private Sub EndedTour()
        RaiseEvent TourEnd()
    End Sub

    Private Sub Modified(trip As Trip)
        RaiseEvent Confirm(trip)
    End Sub


End Class