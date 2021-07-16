Imports System.Globalization
Imports System.Text.RegularExpressions
Imports MLBAMGames.Library.API
Imports Newtonsoft.Json

Public Class MLBGameManager
    Inherits GameManager

    Public Overrides ReadOnly Property DictStreamType As Dictionary(Of String, StreamTypeEnum)
        Get
            Return New Dictionary(Of String, StreamTypeEnum)() From {
                {"HOME", StreamTypeEnum.Home}, {"AWAY", StreamTypeEnum.Away}, {"NATIONAL", StreamTypeEnum.National},
                {"FRENCH", StreamTypeEnum.French}}
        End Get
    End Property

    Public Overrides Async Function GetSchedule(startDate As Date) As Task(Of Schedule)
        Dim dateTimeString As String = startDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)
        Dim url As String = String.Format(MLBAPIServiceURLs.scheduleGames, dateTimeString)

        Console.WriteLine("{0}: Game schedule for {1} from MLB.tv", "Fetching",
                          startDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture))

#If DEBUG Then
        Console.WriteLine($"Schedule of: {url}")
#End If

        Dim data = Await Web.SendWebRequestAndGetContentAsync(url)
        If data.Equals(String.Empty) OrElse data.Equals("{}") Then Return Nothing

        Return JsonConvert.DeserializeObject(Of Schedule)(data)
    End Function

    Public Overrides Async Function SetNewGameStream(currentGame As Game, innerStream As API.Item,
                                                   streamType As StreamTypeEnum, streamTypeSelected As String) As Task(Of GameStream)
        Dim gs = New GameStream With {
            .Game = currentGame,
            .Type = streamType,
            .Network = innerStream.callLetters,
            .PlayBackId = innerStream.id,
            .CdnParameter = SettingsExtensions.ReadGameWatchArgsParams().Cdn
        }
        If gs.Network = String.Empty Then gs.Network = EPGMediaEnum.MLBTV.ToString()
        If gs.Type = StreamTypeEnum.Unknown Then
            gs.StreamTypeSelected = streamTypeSelected
        End If
        gs.GameUrl = $"http://{Parameters.HostName}/getM3U8.php?league={SportsEnum.MLB}&id={gs.PlayBackId}&cdn={gs.CdnParameter.ToString().ToLower()}&date={currentGame.GameDate.ToPacificTime().ToString("yyyy-MM-dd")}"
        gs.Title = $"{currentGame.AwayAbbrev} vs {currentGame.HomeAbbrev} on {gs.Network}"

        gs.StreamUrl = Await GetGameFeedUrlAsync(gs)

#If DEBUG Then
        Console.WriteLine($"m3u8 of: {gs.GameUrl}, resolved to: {gs.StreamUrl}")
#End If

        If gs.StreamUrl.Equals(String.Empty) Then
            Console.WriteLine("Game stream: {0} not found or unavailable on the server", gs.Title)
        End If

        Return gs
    End Function

    Public Overrides Async Function GetGameFeedUrlAsync(gameStream As GameStream) As Task(Of String)
        If gameStream.GameUrl.Equals(String.Empty) Then Return String.Empty

        Dim streamUrlReturned = Await Web.SendWebRequestAndGetContentAsync(gameStream.GameUrl)

        ' Recover old streams
        If gameStream.Game.GameDate.ToLocalTime() < DateTime.Today.AddDays(-2) And streamUrlReturned.StartsWith("https://hlslive") Then
            Dim network = gameStream.CdnParameter.ToString().ToLower()
            Dim newServerUrl = streamUrlReturned _
            .Replace($"hlslive-{network}", $"vod-llc").Replace("complete-trimmed.m3u8", "complete_gdfp-trimmed.m3u8")
            Dim matches = Regex.Match(newServerUrl, "(.*media.mlb.com)(.*)(\/[a-z]{2}[0-9]{2}\/)(mlb\/.*)").Groups
            If matches.Count < 5 Then Return streamUrlReturned
            streamUrlReturned = $"{matches(1)}/ps01/{matches(4)}"
        End If

        If streamUrlReturned.Equals(String.Empty) Then Return String.Empty

        Return If(Await Web.SendWebRequestAsync(streamUrlReturned), streamUrlReturned, String.Empty)
    End Function

    Public Overrides Function GetGameStateFromStatus(status As API.Status) As GameStateEnum
        If status.startTimeTBD Then
            Return GameStateEnum.ToBeDetermined
        End If
        Select Case status.statusCode
            Case "S"
                Return GameStateEnum.Scheduled
            Case "P"
                Return GameStateEnum.Pregame
            Case "PW"
                Return GameStateEnum.Pregame
            Case "I"
                Return GameStateEnum.InProgress
            Case "F"
                Return GameStateEnum.StreamEnded
            Case Else
                Return GameStateEnum.ToBeDetermined
        End Select
    End Function

    Public Overrides Function GetGameType(game As API.Game) As GameTypeEnum
        Select Case game.gameType
            Case "S" 'Summer training
                Return GameTypeEnum.Preseason
            Case "R" 'Regular
                Return GameTypeEnum.Season
            Case "F" 'Wild card game: still season
                Return GameTypeEnum.Season
            Case "D" 'Division series
                Return GameTypeEnum.Series
            Case "L" 'League series (Conference)
                Return GameTypeEnum.Series
            Case "W" 'World series (Final series)
                Return GameTypeEnum.Series
            Case Else
                Return GameTypeEnum.Season
        End Select
    End Function

    Public Overrides Function SetGameProgressInfo(currentGame As Game, game As API.Game) As Game
        currentGame.HomeScore = If(game.teams?.home?.score, 0).ToString()
        currentGame.AwayScore = If(game.teams?.away?.score, 0).ToString()
        If currentGame.IsLive Then
            currentGame.GamePeriod = game.linescore.currentInningOrdinal
            currentGame.GameTimeLeft = game.linescore.inningState
            currentGame.IsInIntermission = False
        End If

        Return currentGame
    End Function

    Public Overrides Function SetGameSeriesInfo(currentGame As Game, game As API.Game) As Game
        If game.seriesGameNumber IsNot Nothing Then
            currentGame.SeriesGameNumber = game.seriesGameNumber
            currentGame.SeriesGameStatus = If(game.seriesDescription, String.Empty)
        End If
        Return currentGame
    End Function
End Class