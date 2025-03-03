Public Class ModifyTour
    Private _trips As Trip
    Private isDragging As Boolean = False
    Private draggedPanel As Panel
    Private startPoint As Point
    Public Event Confirm(trip As Trip)

    Public Sub New(trip As Trip)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _trips = trip

        For i As Integer = 0 To _trips.Stops.Count - 1
            CreateDraggablePanel(Panel2, i)
        Next
        lblTripName1.Text = _trips.TripName
    End Sub

    Private Class DraggablePanel
        Inherits Panel
        Public PanelIndex As Integer
        Public CanDrag As Boolean
    End Class

    Private Sub CreateDraggablePanel(container As Panel, index As Integer)
        ' Create panel
        Dim panel As New DraggablePanel
        panel.Size = New Size(150, 110)
        panel.Location = New Point(10 + (index * 160), 15)
        panel.BorderStyle = BorderStyle.FixedSingle
        panel.BackColor = Color.LightGray
        'panel.CanDrag = Not _trips.Stops(index).visited
        panel.PanelIndex = index

        Dim guid As New Label
        guid.Text = _trips.Stops(index).guid
        panel.Controls.Add(guid)
        guid.Hide()

        Dim lbl As New Label
        lbl.AutoSize = False
        lbl.Size = New Size(130, 25)
        lbl.Location = New Point(10, 10)
        lbl.TextAlign = ContentAlignment.MiddleCenter
        lbl.BorderStyle = BorderStyle.FixedSingle
        lbl.BackColor = Color.White
        lbl.Text = _trips.Stops(index).LocationName
        panel.Controls.Add(lbl)

        Dim text As New TextBox
        text.AutoSize = False
        text.Size = New Size(130, 25)
        text.Location = New Point(10, 45)
        text.BorderStyle = BorderStyle.FixedSingle
        text.Text = _trips.Stops(index).Duration
        'text.Enabled = Not _trips.Stops(index).visited
        panel.Controls.Add(text)

        ' Add event handlers for drag and drop
        AddHandler panel.MouseDown, AddressOf Panel_MouseDown
        AddHandler panel.MouseMove, AddressOf Panel_MouseMove
        AddHandler panel.MouseUp, AddressOf Panel_MouseUp

        container.Controls.Add(panel)
    End Sub

    ' Add this new function to get durations and total
    Public Function GetDurationsAndTotal() As (List(Of Double), Double, List(Of String))
        Dim durations As New List(Of Double)
        Dim guidList As New List(Of String)
        Dim total As Double = 0

        ' Get the container panel
        Dim containerPanel = Panel2

        ' Get all panels sorted by X position
        Dim panels = containerPanel.Controls.Cast(Of Panel)() _
                    .OrderBy(Function(p) p.Location.X) _
                    .ToList()

        ' Get duration from each panel's textbox
        For Each panel In panels
            Dim txtDuration As TextBox = panel.Controls.OfType(Of TextBox)().First()
            guidList.Add(panel.Controls.OfType(Of Label)().First().Text)
            Dim duration As Double
            If Double.TryParse(txtDuration.Text, duration) Then
                durations.Add(duration)
                total += duration
            End If
        Next

        Return (durations, total, guidList)
    End Function

    Private Sub Panel_MouseDown(sender As Object, e As MouseEventArgs)
        Dim panel As DraggablePanel = DirectCast(sender, DraggablePanel)

        If e.Button = MouseButtons.Left Then
            isDragging = True
            draggedPanel = DirectCast(sender, Panel)
            startPoint = New Point(e.X, e.Y)
            draggedPanel.BringToFront()
        End If
    End Sub

    Private Sub Panel_MouseMove(sender As Object, e As MouseEventArgs)
        If isDragging Then
            Dim panel As DraggablePanel = DirectCast(sender, DraggablePanel)
            Dim currentPoint As Point = panel.PointToScreen(New Point(e.X, e.Y))
            currentPoint = panel.Parent.PointToClient(currentPoint)

            ' Calculate new position
            Dim newX As Integer = currentPoint.X - startPoint.X

            ' Restrict movement to horizontal only and within container bounds
            If newX < 0 Then
                newX = 0
            ElseIf newX + panel.Width > panel.Parent.Width Then
                newX = panel.Parent.Width - panel.Width
            End If

            ' Update panel position (horizontal only)
            panel.Location = New Point(newX, panel.Location.Y)
        End If
    End Sub

    Private Sub Panel_MouseUp(sender As Object, e As MouseEventArgs)
        isDragging = False

        If draggedPanel IsNot Nothing Then
            ' Snap to nearest valid position
            Dim panel As Panel = DirectCast(sender, Panel)
            Dim snapPosition As Integer = Math.Round(panel.Location.X / 160) * 160

            ' Ensure snap position is within bounds
            If snapPosition < 0 Then
                snapPosition = 0
            ElseIf snapPosition + panel.Width > panel.Parent.Width Then
                snapPosition = panel.Parent.Width - panel.Width
            End If

            panel.Location = New Point(snapPosition, panel.Location.Y)

            ' Rearrange other panels if needed
            RearrangePanels(panel.Parent, panel)
        End If
    End Sub

    Private Sub RearrangePanels(container As Panel, movedPanel As Panel)
        ' Get all panels in the container
        Dim panels As New List(Of Panel)
        For Each ctrl As Control In container.Controls
            If TypeOf ctrl Is Panel Then
                panels.Add(DirectCast(ctrl, Panel))
            End If
        Next

        ' Sort panels by X position
        panels.Sort(Function(a, b) a.Location.X.CompareTo(b.Location.X))

        ' Reposition panels to prevent overlap
        For i As Integer = 0 To panels.Count - 1
            Dim newX As Integer = 10 + (i * 160)
            panels(i).Location = New Point(newX, panels(i).Location.Y)
        Next
    End Sub

    Private lblSelected As Label = Nothing

    Private Sub Label_Click(sender As Object, e As EventArgs) Handles lblTripName1.Click
        Dim clickedLabel = DirectCast(sender, Label)

        If lblSelected IsNot Nothing Then
            lblSelected.BackColor = SystemColors.Control
        End If

        ' Highlight the new label
        lblSelected = DirectCast(sender, Label)
        lblSelected.BackColor = Color.LightBlue
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim MI As New MainInterface()
        MI.Show()
        Me.Hide()
    End Sub

    Private Sub btnModify1_Click(sender As Object, e As EventArgs) Handles btnModify1.Click
        Dim result = GetDurationsAndTotal()
        Dim durations = result.Item1
        Dim total = result.Item2
        Dim guidList = result.Item3

        If total > 6 Then
            MessageBox.Show("Maximum time is 6 hours", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim stopDictionary As Dictionary(Of String, StopDetails) = _trips.Stops.ToDictionary(Function(s) s.guid, Function(s) s)
            Dim reorganizedStops As New List(Of StopDetails)
            For Each guid In guidList
                If stopDictionary.ContainsKey(guid) Then
                    reorganizedStops.Add(stopDictionary(guid))
                End If
            Next
            _trips.Stops = reorganizedStops

            _trips.TotalDuration = 6
            For i As Integer = 0 To _trips.Stops.Count - 1
                _trips.Stops(i).Duration = durations(i)
            Next
            RaiseEvent Confirm(_trips)
            Close()
            MessageBox.Show("Successfully Saved.")
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
End Class
