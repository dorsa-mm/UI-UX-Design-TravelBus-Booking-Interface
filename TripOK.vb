Public Class TripOK
    Private _trip As Trip
    Public Event Confirm(trip As Trip)

    ' Constructor to receive the trip data
    Public Sub New(trip As Trip)
        InitializeComponent()
        _trip = trip
    End Sub

    ' Load the trip data into the controls when the form loads
    Private Sub TripSummaryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display trip name
        lblTripname.Text = _trip.TripName

        ' Display the stops in a ListBox or other controls
        For Each stops As StopDetails In _trip.Stops
            ListBoxStops.Items.Add($"{stops.Order}. {stops.LocationName} - {stops.Duration} hours")
        Next
    End Sub

    ' Handle modifications or updates to the trip in this form
    Private Sub btnModifyTrip_Click(sender As Object, e As EventArgs) Handles btnModifyTrip.Click
        RaiseEvent Confirm(_trip)
        Me.Close()
    End Sub
End Class