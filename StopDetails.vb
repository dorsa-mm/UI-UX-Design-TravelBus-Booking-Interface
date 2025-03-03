Public Class StopDetails
    Public Property guid As String
    Public Property LocationName As String
    Public Property Duration As Double
    Public Property Order As Integer
    Public Property Button As Button
    Public Property CountryInfo As CountryInfo
    Public Property Year As String = "0"

    Public visited As Boolean = False

    ' Constructor to initialize all properties
    Public Sub New(locationName As String, duration As Double, order As Integer, CountryInfo As CountryInfo)
        guid = System.Guid.NewGuid.ToString()
        Me.LocationName = locationName
        Me.Duration = duration
        Me.Order = order
        Me.CountryInfo = CountryInfo
    End Sub
End Class
