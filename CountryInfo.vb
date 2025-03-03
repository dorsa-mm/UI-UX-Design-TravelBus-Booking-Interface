Public Class CountryInfo
    Public Property Description As String
    Public Property Image As Image

    Public Property TravelDescription As String

    Public Sub New(Description As String, Image As Image, TravelDescription As String)
        Me.Description = Description
        Me.Image = Image
        Me.TravelDescription = TravelDescription
    End Sub
End Class
