Public Class EndOfTour
    Public Event EndTour()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
        RaiseEvent EndTour()
    End Sub
End Class