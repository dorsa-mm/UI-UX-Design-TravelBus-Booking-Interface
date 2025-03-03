Public Class CreateTour
    Public Event Confirm(trip As Trip)
    Public Event CloseCreate()

    Public Shared countryDetails As New Dictionary(Of String, CountryInfo) From {
{"Nigeria", New CountryInfo("Nigeria, the most populous country in Africa, is a vibrant nation known for its diverse cultures, languages, and economic potential.", My.Resources.Nigeria, "Nigeria, the most populous country in Africa, is a vibrant nation with over 250 ethnic groups and a rich cultural heritage. The country is a leading oil producer and has one of the largest economies on the continent. Its dynamic cities, such as Lagos and Abuja, serve as major hubs for commerce and innovation.")},
{"Egypt", New CountryInfo("Egypt, a country linking northeast Africa with the Middle East, is known for its ancient civilization and iconic monuments like the Pyramids of Giza.", My.Resources.Egypt, "Egypt, often called the 'Gift of the Nile,' is famous for its ancient pharaohs and historical landmarks, including the Sphinx and Luxor temples. It is a cultural and political powerhouse in the Arab world. Cairo, its capital, is a bustling metropolis blending ancient history with modern vibrancy.")},
{"South Africa", New CountryInfo("South Africa, located at the southern tip of Africa, is a country renowned for its diverse landscapes, wildlife, and cultural heritage.", My.Resources.SouthAfrica, "South Africa is famously known as the 'Rainbow Nation' due to its multicultural society and rich history. The country boasts incredible biodiversity, with attractions like Kruger National Park and Table Mountain. It has a complex past but is celebrated for its transition to democracy and iconic leaders like Nelson Mandela.")},
{"Kenya", New CountryInfo("Kenya, located in East Africa, is renowned for its breathtaking landscapes, wildlife safaris, and vibrant cultural traditions.", My.Resources.Kenya, "Kenya is home to world-famous national parks such as Maasai Mara, offering spectacular wildlife experiences. The country is also a hub for long-distance runners, producing some of the world’s best athletes. Nairobi, the capital, is a dynamic city blending modernity with traditional culture.")},
{"Ghana", New CountryInfo("Ghana, a West African nation, is known for its rich history, gold resources, and vibrant cultural traditions.", My.Resources.Ghana, "Ghana, formerly known as the Gold Coast, was the first African country to gain independence from colonial rule in 1957. It is celebrated for its warm hospitality, historical sites like Cape Coast Castle, and beautiful beaches. Accra, the capital city, is a thriving center of art, music, and entrepreneurship.")},
{"China", New CountryInfo("China, the world's most populous country, is a global powerhouse known for its rich history, culture, and rapid economic growth.", My.Resources.China, "China is one of the world's oldest civilizations, with landmarks like the Great Wall, Forbidden City, and Terracotta Army. It has undergone significant modernization and is now the second-largest economy globally. The country also boasts diverse natural landscapes, from the Himalayas to the Yangtze River.")},
{"India", New CountryInfo("India, the second-most populous country in the world, is known for its rich cultural heritage, diverse traditions, and growing economy.", My.Resources.India, "India is home to some of the world's oldest civilizations and iconic landmarks such as the Taj Mahal. The country is a global leader in technology, cinema, and spirituality. Its vibrant festivals like Diwali and Holi showcase the unity in diversity of its 1.4 billion people.")},
{"Japan", New CountryInfo("Japan, an island nation in East Asia, is renowned for its technological advancements, traditional culture, and natural beauty.", My.Resources.Japan, "Japan is a land of contrasts, blending ancient traditions such as tea ceremonies and samurai heritage with cutting-edge technology. Iconic landmarks like Mount Fuji and Kyoto’s temples attract millions of tourists annually. Tokyo, its capital, is one of the world's most bustling and innovative cities.")},
{"South Korea", New CountryInfo("South Korea, located in East Asia, is a dynamic country known for its cultural exports, technological innovations, and scenic landscapes.", My.Resources.SouthKorea, "South Korea has gained global fame through K-pop, Korean dramas, and its cuisine, including kimchi and bulgogi. The country is a leader in electronics and automotive industries, with brands like Samsung and Hyundai. Seoul, its capital, is a vibrant metropolis rich in history and modernity.")},
{"Indonesia", New CountryInfo("Indonesia, the largest archipelago in the world, is known for its diverse cultures, stunning landscapes, and rich biodiversity.", My.Resources.Indonesia, "Indonesia spans over 17,000 islands, with Bali being a world-famous tourist destination. It is home to diverse ecosystems, including tropical rainforests and endangered species like orangutans. The country has a vibrant culture influenced by Hindu, Buddhist, Islamic, and indigenous traditions.")},
{"France", New CountryInfo("France, located in Western Europe, is famed for its art, history, cuisine, and iconic landmarks like the Eiffel Tower.", My.Resources.France, "France is the world's most visited country, renowned for its romantic charm and culinary excellence. The country has a rich history reflected in landmarks like Versailles and medieval towns. Paris, its capital, is a global center for fashion, art, and culture.")},
{"Germany", New CountryInfo("Germany, a central European country, is known for its innovation, rich history, and picturesque landscapes.", My.Resources.Germany, "Germany is Europe’s largest economy, renowned for its engineering prowess and brands like BMW and Siemens. Its history spans from the Holy Roman Empire to modern reunification. Visitors flock to landmarks like the Brandenburg Gate and Bavaria's fairy-tale castles.")},
{"Italy", New CountryInfo("Italy, a southern European country, is celebrated for its art, architecture, cuisine, and historical heritage.", My.Resources.Italy, "Italy is the birthplace of the Renaissance, with iconic cities like Florence, Rome, and Venice. Its world-famous cuisine includes pizza, pasta, and gelato. Historical sites such as the Colosseum and Vatican City draw millions of tourists annually.")},
{"Spain", New CountryInfo("Spain, located on the Iberian Peninsula, is renowned for its vibrant culture, historical landmarks, and Mediterranean lifestyle.", My.Resources.Spain, "Spain is famous for flamenco, bullfighting, and its rich culinary traditions, including tapas and paella. Its cities, like Barcelona and Madrid, blend modern innovation with historical charm. Spain’s landscapes range from sunny beaches to the Pyrenees mountains.")},
{"United Kingdom", New CountryInfo("The United Kingdom, comprising England, Scotland, Wales, and Northern Ireland, is known for its historical influence, culture, and institutions.", My.Resources.UnitedKingdom, "The UK has a rich history, from medieval castles to the Industrial Revolution. London, its capital, is a global hub for finance, arts, and culture. Iconic landmarks like Stonehenge, Edinburgh Castle, and Big Ben attract millions of visitors yearly.")},
{"United States", New CountryInfo("The United States of America, commonly referred to as the USA, is a federal republic consisting of 50 states, a federal district and several territories, with a diverse landscape, culture and economy.", My.Resources.UnitedStates, "The United States of America, commonly referred to as the USA, is a federal republic consisting of 50 states, a federal district and several territories. Known for its diverse culture, vibrant cities, stunning natural landscapes and influential economy, the country attracts millions of visitors and immigrants each year.")},
{"Canada", New CountryInfo("Canada, the second-largest country in the world by land area, is known for its natural beauty, multicultural society, and high quality of life.", My.Resources.Canada, "Canada boasts stunning landscapes, including the Rocky Mountains, Niagara Falls, and vast forests. It is a bilingual nation, with English and French as official languages. Cities like Toronto and Vancouver are renowned for their livability and cultural diversity.")},
{"Mexico", New CountryInfo("Mexico, a country in North America, is celebrated for its rich history, vibrant culture, and diverse landscapes.", My.Resources.Mexico, "Mexico’s heritage includes ancient civilizations like the Aztecs and Mayans, leaving behind landmarks like Chichen Itza. The country is known for its lively festivals, such as Día de los Muertos, and world-famous cuisine. Its stunning beaches, such as those in Cancún, attract millions of tourists annually.")},
{"Brazil", New CountryInfo("Brazil, the largest country in South America, is known for its vibrant culture, Amazon rainforest, and world-famous Carnival festival.", My.Resources.Brazil, "Brazil is home to diverse ecosystems, including the Amazon, the world's largest rainforest. The country is a powerhouse in soccer, producing legends like Pelé and Neymar. Rio de Janeiro’s Christ the Redeemer statue and Copacabana Beach are iconic global landmarks.")},
{"Argentina", New CountryInfo("Argentina, the second-largest country in South America, is known for its rich culture, tango music, and diverse landscapes.", My.Resources.Argentina, "Argentina is famous for its passion for football and producing players like Lionel Messi. The country boasts stunning natural wonders such as Iguazu Falls and the Andes Mountains. Buenos Aires, its capital, is a hub of European-inspired architecture and vibrant culture.")},
{"Colombia", New CountryInfo("Colombia, located in South America, is known for its coffee, diverse ecosystems, and vibrant culture.", My.Resources.Colombia, "Colombia is the world's leading exporter of quality coffee beans. Its natural landscapes include the Andes, Amazon rainforest, and Caribbean beaches. The country’s music, like cumbia and vallenato, reflects its rich cultural heritage.")},
{"Chile", New CountryInfo("Chile, a long and narrow country in South America, is known for its dramatic landscapes, from the Atacama Desert to Patagonia.", My.Resources.Chile, "Chile is a long, narrow country in South America, bordered by the Andes Mountains and the Pacific Ocean, known for its diverse geography, rich cultural heritage and prosperous economy.")},
{"Australia", New CountryInfo("Australia is a vast island continent and country in the Southern Hemisphere, characterized by its diverse wildlife, iconic cities and expansive Outback desert.", My.Resources.AustraliaCity, "Australia is famous for its unique and diverse wildlife, including kangaroos, koalas and wombats.The country has a strong economy, driven primarily by service industries, mining and agriculture. Australia's indigenous Aboriginal culture is one of the oldest continuing cultures on Earth.")},
{"New Zealand", New CountryInfo("New Zealand is an island nation in the southwestern Pacific Ocean, recognized for its breathtaking landscapes, diverse wildlife and rich cultural heritage.", My.Resources.NewZealand, "New Zealand's stunning landscapes include mountains, fjords, coastlines and geothermal wonders. The country is a popular destination for outdoor activities like hiking, skiing and bungee jumping. New Zealand has a strong focus on environmental conservation and sustainability.")},
{"Antarctica", New CountryInfo("Antarctica is the Earth's southernmost continent, covered by a thick ice sheet, known for its extreme climate, unique scientific research stations and protected wildlife.", My.Resources.AntarcticaCity, "Antarctica has no permanent residents, only temporary scientists and researchers at various stations. The Antarctic Treaty protects the continent's environment and ecosystem. Antarctica holds about 70% of the world's fresh water in its massive ice sheets.")},
{"Renaissance Florence", New CountryInfo("Renaissance Florence, the cradle of the Renaissance, is renowned for its art, architecture, and culture.", My.Resources.florence_in_the_renaissance_orig, "During the Renaissance, Florence was the epicenter of artistic and cultural rebirth, with figures like Michelangelo and da Vinci leaving a lasting legacy.")},
{"Ancient Greece", New CountryInfo("Ancient Greece, the birthplace of democracy, philosophy, and Western culture.", My.Resources.ancient_greece_gettyimages_475594807, "Ancient Greece is celebrated for its contributions to philosophy, art, and politics, with iconic sites like the Acropolis.")},
    {"Ancient Rome", New CountryInfo("Ancient Rome, a dominant empire known for its engineering, law, and culture.", My.Resources.how_big_was_the_roman_empire, "Ancient Rome shaped the world with innovations like aqueducts, the Colosseum, and a legal system that influences us today.")},
    {"Paris in 1920s", New CountryInfo("Paris in the 1920s, a cultural hub for art, literature, and intellectual movements.", My.Resources.midnight_paris, "Known as the 'Jazz Age,' Paris in the 1920s was alive with creativity, hosting artists like Hemingway and Picasso.")},
    {"Industrial Revolution-UK", New CountryInfo("The Industrial Revolution in the UK, a period of rapid technological advancement and economic transformation.", My.Resources.IndustrialUK, "The UK led the world into the industrial age, pioneering innovations in machinery, manufacturing, and transportation.")},
    {"Irish Revolution", New CountryInfo("The Irish Revolution, a key period in Ireland's struggle for independence from British rule.", My.Resources.Irish, "The Irish Revolution saw pivotal moments that shaped Ireland's identity and led to the establishment of the Irish Free State.")},
    {"Medieval Banquet Hall", New CountryInfo("Experience the charm of a Medieval Banquet Hall, complete with historical ambiance and cuisine.", My.Resources._medieval_banquet_halls_d7050b9a_3619_41ed_87b1_d05ba6787bbf, "Medieval Banquet Halls bring history to life with immersive settings and traditional feasts.")},
    {"First Moon Landing", New CountryInfo("The First Moon Landing, a historic achievement in space exploration by NASA in 1969.", My.Resources.moonlanding3getty, "The Apollo 11 mission marked a monumental moment for humanity as Neil Armstrong set foot on the moon.")},
    {"1960s Earth", New CountryInfo("The 1960s, a transformative decade marked by cultural revolutions and scientific achievements.", My.Resources._1960se, "From civil rights movements to space exploration, the 1960s reshaped society and advanced technology.")},
    {"Christ The Redeemer", New CountryInfo("Christ the Redeemer, a world-famous statue in Rio de Janeiro, Brazil.", My.Resources.CR, "Standing atop Corcovado Mountain, Christ the Redeemer symbolizes peace and hospitality.")},
    {"Iguazu Falls", New CountryInfo("Iguazu Falls, a breathtaking natural wonder on the border of Brazil and Argentina.", My.Resources.Iguazu, "Iguazu Falls is one of the world's largest waterfall systems, offering stunning views and lush surroundings.")},
{"Twelve Apostles", New CountryInfo("The Twelve Apostles, iconic limestone stacks off Australia's Great Ocean Road.", My.Resources.The_Twelve_Apostles_2011, "These natural rock formations are a must-see, showcasing the rugged beauty of Australia's coastline.")},
    {"Research Stations", New CountryInfo("Research Stations, hubs for scientific exploration and discovery in remote areas.", My.Resources.RS, "Research Stations enable groundbreaking studies in regions like Antarctica and deep space.")},
    {"Fossil Zone", New CountryInfo("Fossil Zones, key areas for uncovering Earth's ancient history through paleontological finds.", My.Resources.FZ, "Fossil Zones reveal fascinating insights into the evolution of life and past ecosystems.")}}








    Private Sub BtnTourSet_Click(sender As Object, e As EventArgs) Handles btnTourSet.Click
        Dim tourname As String = txtTourName.Text
        If tourname = "" Then
            MessageBox.Show("Please enter a valid name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            lblTourName.Text = tourname
            panelAgeSelection.Visible = True
            panelTourStatus.Visible = True
        End If
    End Sub

    Private Sub btnPast_Click(sender As Object, e As EventArgs) Handles btnPast.Click
        Panel1.Visible = True
    End Sub

    'Private Sub btnFuture_Click(sender As Object, e As EventArgs) Handles btnFuture.Click
    '   Panel1.Visible = True
    'End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim input As String = txtTimeLine.Text.Trim()
        Dim eraNumber As Integer

        ' Check if the input is a valid integer.
        If Not Integer.TryParse(input, eraNumber) Then
            MessageBox.Show("PLEASE ENTER A NUMBER (1, 2, 3, OR 4) FOR THE ERA.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTimeLine.Focus()
            txtTimeLine.SelectAll()
            Return
        End If

        ' Ensure the number is between 1 and 4.
        If eraNumber < 1 OrElse eraNumber > 4 Then
            MessageBox.Show("PLEASE ENTER A VALID NUMBER (1, 2, 3, OR 4) FOR THE ERA.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTimeLine.Focus()
            txtTimeLine.SelectAll()
            Return
        End If

        ' Map the number to the corresponding era.
        Dim eraName As String = ""
        Select Case eraNumber
            Case 1
                eraName = "PRECAMBRIAN"
            Case 2
                eraName = "PALEOZOIC"
            Case 3
                eraName = "MESOZOIC"
            Case 4
                eraName = "CENOZOIC"
        End Select

        ' Set the label and show the next panel.
        lblTimeLine.Text = eraName
        panelContinent.Visible = True
    End Sub



    Private Sub UpdateMap(continent As String)
        Panel2.Visible = True
        If continent = "NA" Then
            mapBox.Image = My.Resources.north_america_continent_map
        End If
        If continent = "SA" Then
            mapBox.Image = My.Resources.south_america_continent_map
        End If
        If continent = "AF" Then
            mapBox.Image = My.Resources.africa
        End If
        If continent = "AUS" Then
            mapBox.Image = My.Resources.australia
        End If
        If continent = "AS" Then
            mapBox.Image = My.Resources.asia
        End If
        If continent = "EU" Then
            mapBox.Image = My.Resources.europe
        End If
        If continent = "ANT" Then
            mapBox.Image = My.Resources.antarctica
        End If
    End Sub

    Private continentCountries As New Dictionary(Of String, List(Of String)) From {
    {"Africa", New List(Of String) From {"Nigeria", "Egypt", "South Africa", "Kenya", "Ghana"}},
    {"Asia", New List(Of String) From {"China", "India", "Japan"}},
    {"Europe", New List(Of String) From {"Renaissance Florence", "Ancient Greece", "Ancient Rome", "Paris in 1920s", "Industrial Revolution-UK", "Irish Revolution"}},
    {"North America", New List(Of String) From {"United States", "Canada", "Mexico", "Medieval Banquet Hall", "First Moon Landing", "1960s Earth"}},
    {"South America", New List(Of String) From {"Brazil", "Christ The Redeemer", "Iguazu Falls"}},
    {"Australia", New List(Of String) From {"Australia", "New Zealand", "Twelve Apostles"}},
    {"Antarctica", New List(Of String) From {"Research Stations", "Fossil Zone"}}
}
    Private Sub UpdateListBox(continent As String)

        If continentCountries.ContainsKey(continent) Then
            ListBox1.Items.Clear()  ' Clear previous entries
            ListBox1.Items.AddRange(continentCountries(continent).ToArray())
        Else
            MessageBox.Show("No countries available for this continent.", "Information")
        End If
    End Sub

    Private Sub btnNorthAmerica_Click(sender As Object, e As EventArgs) Handles btnNorthAmerica.Click
        UpdateMap("NA")
        UpdateListBox("North America")

    End Sub

    Private Sub btnEurope_Click(sender As Object, e As EventArgs) Handles btnEurope.Click
        UpdateMap("EU")
        UpdateListBox("Europe")

    End Sub

    Private Sub btnAsia_Click(sender As Object, e As EventArgs) Handles btnAsia.Click
        UpdateMap("AS")
        UpdateListBox("Asia")

    End Sub

    Private Sub btnSouthAmerica_Click(sender As Object, e As EventArgs) Handles btnSouthAmerica.Click
        UpdateMap("SA")
        UpdateListBox("South America")

    End Sub

    Private Sub btnAfrica_Click(sender As Object, e As EventArgs) Handles btnAfrica.Click
        UpdateMap("AF")
        UpdateListBox("Africa")

    End Sub

    Private Sub ButtonAussie_Click(sender As Object, e As EventArgs) Handles btnAustralia.Click
        UpdateMap("AUS")
        UpdateListBox("Australia")

    End Sub

    Private Sub btnAntartica_Click(sender As Object, e As EventArgs) Handles btnAntartica.Click
        UpdateMap("ANT")
        UpdateListBox("Antarctica")


    End Sub


    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Panel3.Visible = True
        ' Check if a country is selected
        If ListBox1.SelectedItem IsNot Nothing Then
            Dim selectedCountry As String = ListBox1.SelectedItem.ToString()

            ' Check if country details exist for the selected country
            If countryDetails.ContainsKey(selectedCountry) Then
                Dim info As CountryInfo = countryDetails(selectedCountry)

                ' Update the panel controls with country details
                lblPlaceName.Text = selectedCountry
                lblDesc.Text = info.Description
                boxPlace.Image = info.Image
                ' Load and set the country image
            End If
        End If
    End Sub

    Private cumulativeDuration As Double = 0.0
    Private serialNumber As Integer = 1
    Private stopCount As Integer = 0 ' Track the number of stops



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        panelBoxes.Controls.Clear() ' Clear all stop panels
        cumulativeDuration = 0.0
        stopCount = 0
        serialNumber = 1
        progressDuration.Value = 0
        lblDurationstatus.Text = "0.0/6 hours" ' Reset the duration status label


    End Sub




    Private boxCounter As Integer = 1
    Private boxList As New List(Of Button)






    'Private Sub btnSpawn_Click(sender As Object, e As EventArgs) Handles btnAdder.Click

    '    If ListBox1.SelectedItem Is Nothing Then
    '        MessageBox.Show("Please select a country.", "Warning")
    '        Return
    '    End If

    '    Dim selectedCountry As String = ListBox1.SelectedItem.ToString()
    '    Dim labeldata As String = lblPlaceName.Text

    '    Dim duration As Double
    '    If Not Double.TryParse(txtDuration.Text, duration) Then
    '        MessageBox.Show("Please enter a valid duration in hours (e.g., 1, 1.5).", "Invalid Input")
    '        Return
    '    End If


    '    ' Check if adding this duration would exceed the 6-hour limit
    '    If cumulativeDuration + duration > 6.0 Then
    '        MessageBox.Show("Cannot add this stop. Exceeds maximum tour duration of 6 hours.", "Limit Exceeded")
    '        Return
    '    End If

    '    If stopCount >= 6 Then
    '        MessageBox.Show("Cannot add more stops. Maximum of 6 stops reached.", "Limit Exceeded")
    '        Return
    '    End If





    '    ' Update the cumulative duration and the progress bar
    '    cumulativeDuration += duration
    '    progressDuration.Value = CInt((cumulativeDuration / 6.0) * progressDuration.Maximum)

    '    lblDurationstatus.Text = $"{cumulativeDuration:F1}/6 hours"









    '    ' Update counters
    '    stopCount += 1



    '    serialNumber += 1

    '    ' Clear the duration input for the next entry
    '    txtDuration.Clear()



    '    Dim newBox As New Button With {
    '    .Text = lblPlaceName.Text,
    '    .Width = 65,
    '    .Height = 65,
    '    .BackColor = Color.Black,
    '    .ForeColor = Color.Red,
    '    .FlatStyle = FlatStyle.Flat
    '}
    '    newBox.FlatAppearance.BorderSize = 0
    '    Dim PanelName As String = "panelTripSummary"


    '    AddHandler newBox.Click, Sub(senderObj, args)
    '                                 ShowDataPanel(PanelName)
    '                             End Sub

    '    Dim boxNumber As Integer = 0
    '    Dim reusedIndex As Integer = -1
    '    Dim boxData As String






    '    For i As Integer = 0 To boxList.Count - 1
    '        If boxList(i) Is Nothing Then
    '            reusedIndex = i
    '            boxData = lblPlaceName.Text
    '            Exit For
    '        End If
    '    Next



    '    If reusedIndex = -1 Then
    '        boxNumber = boxCounter
    '        newBox.BackColor = Color.Black


    '        newBox.ForeColor = Color.White
    '        boxList.Add(newBox)
    '        boxCounter += 1
    '    Else
    '        newBox.BackColor = Color.Green
    '        newBox.ForeColor = Color.White


    '        boxList(reusedIndex) = newBox
    '    End If

    '    newBox.Text = lblPlaceName.Text
    '    panelBoxes.Controls.Add(newBox)
    '    PositionBoxes()


    'End Sub



    Private Sub PositionBoxes()
        Dim boxWidth As Integer = 80
        Dim boxHeight As Integer = 80
        Dim spacing As Integer = 5
        Dim maxPanelWidth As Integer = panelBoxes.Width
        Dim boxesPerRow As Integer = maxPanelWidth \ (boxWidth + spacing)

        For i As Integer = 0 To boxList.Count - 1
            Dim box = boxList(i)

            If box IsNot Nothing Then
                Dim row As Integer = i \ boxesPerRow
                Dim col As Integer = i Mod boxesPerRow

                Dim xPos As Integer = col * (boxWidth + spacing)
                Dim yPos As Integer = row * (boxHeight + spacing)
                box.Location = New Point(xPos, yPos)
            End If
        Next
    End Sub

    Dim stopDetailsList As New List(Of StopDetails)

    Private Sub btnAdder_Click(sender As Object, e As EventArgs) Handles btnAdder.Click
        ' Ensure a location is selected
        If ListBox1.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a country.", "Warning")
            Return
        End If

        Dim selectedCountry As String = ListBox1.SelectedItem.ToString()
        Dim duration As Double
        Dim order As Integer

        ' Validate duration input
        If Not Double.TryParse(txtDuration.Text, duration) Then
            MessageBox.Show("Please enter a valid duration in hours (e.g., 1, 1.5).", "Invalid Input")
            Return
        End If
        If Not Integer.TryParse(NumericUpDown1.Value, order) Then
            MessageBox.Show("Please Enter a valid Stop from (1-12)", "Invalid Input")
        End If

        ' Check cumulative duration limit
        If cumulativeDuration + duration > 6.0 Then
            MessageBox.Show("Cannot add this stop. Exceeds maximum tour duration of 6 hours.", "Limit Exceeded")
            Return
        End If

        Dim countryInfo As CountryInfo = countryDetails(selectedCountry)

        ' Create a new StopDetails instance
        Dim stopDetails As New StopDetails(selectedCountry, duration, order, countryInfo)
        stopDetails.Year = txtTimeLine.Text

        ' Create a new button for the stop
        Dim newButton As New Button With {
        .Text = selectedCountry,
        .Width = 80,
        .Height = 80,
        .BackColor = Color.Black,
        .ForeColor = Color.Red,
        .FlatStyle = FlatStyle.Flat,
        .Tag = stopDetails
    }

        ' Add click handler to the button
        AddHandler newButton.Click, AddressOf StopButton_Click

        ' Add button to the panel
        panelBoxes.Controls.Add(newButton)

        ' Update the stop details list
        stopDetails.Button = newButton
        stopDetailsList.Add(stopDetails)

        ' Update cumulative duration
        cumulativeDuration += duration
        progressDuration.Value = CInt((cumulativeDuration / 6.0) * progressDuration.Maximum)
        lblDurationstatus.Text = $"{cumulativeDuration:F1}/6 hours"

        ' Clear input fields
        txtDuration.Clear()

        ' Reposition all buttons dynamically
        PositionBoxes2()

        Panel3.Visible = False        ' Hide the "Place Info" panel
        Panel2.Visible = False        ' Hide the "Location List" panel
        panelContinent.Visible = False ' Hide the "Continent" panel

        Panel1.Visible = True         ' Show the panel prompting for era again
        txtTimeLine.Clear()           ' (Optional) Clear the timeline text box if you want them to type anew

    End Sub





    ' Dynamically arrange buttons in the panel
    Private Sub PositionBoxes2()
        Dim x As Integer = 10
        Dim y As Integer = 10
        Dim margin As Integer = 5

        For Each btn As Button In panelBoxes.Controls.OfType(Of Button)()
            btn.Location = New Point(x, y)
            x += btn.Width + margin
            If x + btn.Width > panelBoxes.Width Then
                x = 10
                y += btn.Height + margin
            End If
        Next
    End Sub


    Private Sub StopButton_Click(sender As Object, e As EventArgs)
        Dim clickedButton As Button = CType(sender, Button)
        Dim stopDetails As StopDetails = CType(clickedButton.Tag, StopDetails)

        ' Display trip summary with options to edit or delete
        Dim result As DialogResult = MessageBox.Show($"Stop Name: {stopDetails.LocationName}{Environment.NewLine}" &
                                                    $"Stop Order: {stopDetails.Order}{Environment.NewLine}" &
                                                 $"Duration: {stopDetails.Duration} hours{Environment.NewLine}" &
                                                 $"{Environment.NewLine}" &
                                                 "Press 'Yes' to Edit, 'No' to Delete this stop.",
                                                 "Edit/Delete Stop", MessageBoxButtons.YesNoCancel)

        If result = DialogResult.Yes Then
            ' Edit the stop
            Dim newDurationStr As String = InputBox("Enter new duration (in hours):", "Edit Duration", stopDetails.Duration.ToString())
            Dim newDuration As Double
            Dim newOrderStr As String = InputBox("Enter new Order (in integers):", "Edit Visit Order", stopDetails.Order.ToString())
            Dim newOrder As Integer

            If Double.TryParse(newDurationStr, newDuration) AndAlso (cumulativeDuration - stopDetails.Duration + newDuration <= 6.0) Then
                ' Update duration
                cumulativeDuration = cumulativeDuration - stopDetails.Duration + newDuration
                stopDetails.Duration = newDuration
                lblDurationstatus.Text = $"{cumulativeDuration:F1}/6 hours"
                progressDuration.Value = CInt((cumulativeDuration / 6.0) * progressDuration.Maximum)
            Else
                MessageBox.Show("Invalid or exceeding duration. Edit canceled.", "Error")
            End If

            If Integer.TryParse(newOrderStr, newOrder) Then
                stopDetails.Order = newOrder
            End If
        ElseIf result = DialogResult.No Then
            ' Delete the stop
            cumulativeDuration -= stopDetails.Duration
            lblDurationstatus.Text = $"{cumulativeDuration:F1}/6 hours"
            progressDuration.Value = CInt((cumulativeDuration / 6.0) * progressDuration.Maximum)
            stopDetailsList.Remove(stopDetails)
            panelBoxes.Controls.Remove(clickedButton)
            PositionBoxes2()
        End If
    End Sub

    Private Sub CreateTour_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelCreateTour.Visible = True
        SetAllTextBoxesUpper(Me)
    End Sub

    Private Sub SetAllTextBoxesUpper(ByVal parentControl As Control)
        For Each ctrl As Control In parentControl.Controls
            If TypeOf ctrl Is TextBox Then
                ' Set the CharacterCasing property to Upper
                DirectCast(ctrl, TextBox).CharacterCasing = CharacterCasing.Upper
            End If
            ' Recursively call this function if the control has child controls.
            If ctrl.HasChildren Then
                SetAllTextBoxesUpper(ctrl)
            End If
        Next
    End Sub

    Private Sub btnConfirmTrip_Click(sender As Object, e As EventArgs) Handles btnConfirmTrip.Click
        ' Create a new Trip object and fill it with the current trip data
        Me.Hide()
        Dim trip As New Trip()
        trip.TripName = lblTourName.Text
        trip.TotalDuration = cumulativeDuration

        ' Add all stops to the trip
        For Each stops As StopDetails In stopDetailsList
            trip.Stops.Add(stops)
        Next

        ' Pass the Trip object to the new form
        Dim tripSummaryForm As New TripOK(trip)
        AddHandler tripSummaryForm.Confirm, AddressOf OnConfirm
        tripSummaryForm.Show() ' Show the new form
    End Sub

    Private Sub OnConfirm(trip As Trip)
        RaiseEvent Confirm(trip)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RaiseEvent CloseCreate()
        Close()
    End Sub
End Class