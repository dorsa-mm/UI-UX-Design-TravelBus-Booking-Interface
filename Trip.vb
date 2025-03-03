Imports TimebusB2.MainInterface

Public Class Trip
    Public Property guid As String
    Public Property Stops As List(Of StopDetails)  ' List of stops
    Public Property TotalDuration As Double  ' Total duration
    Public Property TripName As String  ' Name of the trip

    Public Sub New()
        guid = System.Guid.NewGuid.ToString()
        Stops = New List(Of StopDetails)()
        TotalDuration = 0.0
    End Sub
End Class
