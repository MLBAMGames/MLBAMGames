Imports System.Globalization
Imports System.Text.RegularExpressions
Imports MLBAMGames.Library.API
Imports Newtonsoft.Json

Public Class NHLGameManager
    Inherits GameManager

    Public Overrides ReadOnly Property DictStreamType As Dictionary(Of String, StreamTypeEnum)
        Get
            Return New Dictionary(Of String, StreamTypeEnum)() From {
                {"HOME", StreamTypeEnum.Home}, {"AWAY", StreamTypeEnum.Away}, {"NATIONAL", StreamTypeEnum.National},
                {"FRENCH", StreamTypeEnum.French},
                {"MULTICAM1", StreamTypeEnum.MultiCam1}, {"MULTICAM2", StreamTypeEnum.MultiCam2},
                {"ENDZONECAM1", StreamTypeEnum.EndzoneCam1}, {"ENDZONECAM2", StreamTypeEnum.EndzoneCam2},
                {"REFCAM", StreamTypeEnum.RefCam}, {"STARCAM", StreamTypeEnum.StarCam}}
        End Get
    End Property

    Public Overrides Async Function GetSchedule(startDate As Date) As Task(Of Schedule)
        Dim dateTimeString As String = startDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)
        Dim url As String = String.Format(NHLAPIServiceURLs.scheduleGames, dateTimeString)

        Console.WriteLine("{0}: Game schedule for {1} from NHL.tv", "Fetching",
                          startDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture))

        Dim data = Await Web.SendWebRequestAndGetContentAsync(url)
        If data.Equals(String.Empty) OrElse data.Equals("{}") Then Return Nothing

        Return JsonConvert.DeserializeObject(Of Schedule)(data)
    End Function

    Public Overrides Async Function SetNewGameStream(currentGame As Game, innerStream As API.Item,
                                                   streamType As StreamTypeEnum, streamTypeSelected As String) As Task(Of GameStream)
        Dim gs = New GameStream() With {
            .Game = currentGame,
            .Type = streamType,
            .Network = innerStream.callLetters,
            .PlayBackId = innerStream.mediaPlaybackId,
            .CdnParameter = SettingsExtensions.ReadGameWatchArgsParams().Cdn
        }
        If gs.Network = String.Empty Then gs.Network = EPGMediaEnum.NHLTV.ToString()
        If gs.Type = StreamTypeEnum.Unknown Then
            gs.StreamTypeSelected = streamTypeSelected
        End If
        gs.GameUrl = $"http://{Parameters.HostName}/getM3U8.php?league={SportsEnum.NHL}&id={gs.PlayBackId}&cdn={gs.CdnParameter.ToString().ToLower()}&date={currentGame.GameDate.ToPacificTime().ToString("yyyy-MM-dd")}"
        gs.Title = $"{currentGame.AwayAbbrev} vs {currentGame.HomeAbbrev} on {gs.Network}"

        gs.StreamUrl = Await GetGameFeedUrlAsync(gs)

        If gs.StreamUrl.Equals(String.Empty) Then
            Console.WriteLine("Game stream: {0} not found or unavailable on the server", gs.Title)
        End If

        Return gs
    End Function

    Public Overrides Async Function GetGameFeedUrlAsync(gameStream As GameStream) As Task(Of String)
        If gameStream.GameUrl.Equals(String.Empty) Then Return String.Empty

        Dim streamUrlReturned = Await Web.SendWebRequestAndGetContentAsync(gameStream.GameUrl)

        If streamUrlReturned.Equals(String.Empty) OrElse streamUrlReturned.ToLower().Equals("not available yet") Then Return String.Empty

        ' Recover old streams
        If gameStream.Game.GameDate.ToLocalTime() < DateTime.Today.AddDays(-2) And streamUrlReturned.StartsWith("https://hlslive") Then
            Dim network = gameStream.CdnParameter.ToString().ToLower()
            Dim newServerUrl = streamUrlReturned _
            .Replace($"hlslive-{network}.med2.med", $"hlslive-{network}.med") _
            .Replace($"hlslive-{network}", $"vod-{network}-na1")
            Dim matches = Regex.Match(newServerUrl, "(.*nhl.com)(.*)(\/[a-z]{2}[0-9]{2}\/)(nhl\/.*)").Groups
            If matches.Count < 5 Then Return streamUrlReturned
            streamUrlReturned = $"{matches(1)}/ps01/{matches(4)}"
        End If

        Return If(Await Web.SendWebRequestAsync(streamUrlReturned), streamUrlReturned, String.Empty)
    End Function

    Public Overrides Function GetGameStateFromStatus(status As API.Status) As GameStateEnum
        Dim code = Convert.ToInt16(If(status.statusCode, 0).ToString())
        Return If(code > 10, 11, code)
    End Function

    Public Overrides Function GetGameType(game As API.Game) As GameTypeEnum
        Return CType(Convert.ToInt16(GetChar(game.gamePk.ToString(), 6)) - 48, GameTypeEnum)
    End Function

    Public Overrides Function SetGameProgressInfo(currentGame As Game, game As API.Game) As Game
        currentGame.HomeScore = If(game.teams?.home?.score, 0).ToString()
        currentGame.AwayScore = If(game.teams?.away?.score, 0).ToString()
        If currentGame.IsLive Then
            currentGame.GamePeriod = game.linescore.currentPeriodOrdinal
            currentGame.GameTimeLeft = game.linescore.currentPeriodTimeRemaining
            currentGame.IsInIntermission = If(game.linescore.intermissionInfo?.inIntermission, False)
        End If

        If currentGame.IsInIntermission Then
            currentGame.IntermissionTimeRemaining = Date.MinValue.AddSeconds(game.linescore.intermissionInfo.intermissionTimeRemaining)
        End If
        Return currentGame
    End Function

    Public Overrides Function SetGameSeriesInfo(currentGame As Game, game As API.Game) As Game
        If game.seriesSummary?.gameNumber IsNot Nothing Then
            currentGame.SeriesGameNumber = game.seriesSummary?.gameNumber
            currentGame.SeriesGameStatus = If(game.seriesSummary?.seriesStatusShort, String.Empty)
        End If
        Return currentGame
    End Function
End Class
