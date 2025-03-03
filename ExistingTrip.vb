Public Class ExistingTrip
    Public Event Confirm(trip As Trip)
    Public Event CloseExisting()

    ' When the user selects the first package (Ice Age package)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim trip As New Trip()
        trip.TripName = "Ice Age Tour"
        trip.TotalDuration = 6.0
        ' Create stops for this package using the shared dictionary from CreateTour
        trip.Stops.Add(New StopDetails("The Alps", 1, 1, CreateTour.countryDetails("Nigeria")))
        trip.Stops.Add(New StopDetails("Scandinavia", 2, 1, CreateTour.countryDetails("Egypt")))
        trip.Stops.Add(New StopDetails("Antarctica", 3, 1, CreateTour.countryDetails("Germany")))
        ' Raise the Confirm event so the main interface can process this trip
        RaiseEvent Confirm(trip)
        Me.Close()
    End Sub

    ' For the second package (Jurassic Age package)
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim trip As New Trip()
        trip.TripName = "Jurassic Age Tour"
        trip.TotalDuration = 6.0
        trip.Stops.Add(New StopDetails("Pangaea's Breakup", 1, 1, CreateTour.countryDetails("France")))
        trip.Stops.Add(New StopDetails("Solnhofen", 2, 1, CreateTour.countryDetails("Italy")))
        trip.Stops.Add(New StopDetails("Morrison Age", 3, 2, CreateTour.countryDetails("United States")))
        RaiseEvent Confirm(trip)
        Me.Close()
    End Sub

    ' For the third package (Cyberpunk 2055 package)
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim trip As New Trip()
        trip.TripName = "Cyberpunk 2055 Tour"
        trip.TotalDuration = 6.0
        trip.Stops.Add(New StopDetails("The Net", 1, 1, CreateTour.countryDetails("Italy")))
        trip.Stops.Add(New StopDetails("Megabuilding", 2, 1, CreateTour.countryDetails("Italy")))
        trip.Stops.Add(New StopDetails("The Afterlife", 3, 1, CreateTour.countryDetails("Spain")))
        trip.Stops.Add(New StopDetails("The Badlands", 4, 2, CreateTour.countryDetails("Spain")))
        trip.Stops.Add(New StopDetails("Night City", 5, 1, CreateTour.countryDetails("France")))
        RaiseEvent Confirm(trip)
        Me.Close()
    End Sub

    ' Back to Home button handler
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        RaiseEvent CloseExisting()
        Me.Close()
    End Sub

End Class
