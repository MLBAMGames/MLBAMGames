Imports System.Globalization
Imports System.Text.RegularExpressions
Imports MLBAMGames.Library.API
Imports Newtonsoft.Json

Public Class MLBGameManager
    Inherits GameManager

    Public Overrides ReadOnly Property DictStreamType As Dictionary(Of String, StreamTypeEnum)
        Get
            Return New Dictionary(Of String, StreamTypeEnum)() From {
                {"HOME", StreamTypeEnum.Home}, {"AWAY", StreamTypeEnum.Away}
            }
        End Get
    End Property

    Public Overrides Async Function GetSchedule(startDate As Date) As Task(Of Schedule)
        Dim dateTimeString As String = startDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)
        Dim url As String = String.Format(MLBAPIServiceURLs.scheduleGames, dateTimeString)

        Console.WriteLine("{0}: Game schedule for {1} from MLB.tv", "Fetching",
                          startDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture))

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
        gs.GameUrl = $"http://{Parameters.HostName}/getM3U8.php?league={SportsEnum.MLB}&id={gs.PlayBackId}&cdn={gs.CdnParameter.ToString().ToLower()}&date={DateHelper.GetPacificTime(currentGame.GameDate).ToString("yyyy-MM-dd")}"
        gs.Title = $"{currentGame.AwayAbbrev} vs {currentGame.HomeAbbrev} on {gs.Network}"


        gs.StreamUrl = Await GetGameFeedUrlAsync(gs)

        If gs.StreamUrl.Equals(String.Empty) Then
            Console.WriteLine("Game stream: {0} not found or unavailable on the server", gs.Title)
        End If

        Return gs
    End Function

    Public Overrides Function GetGameStateFromStatus(status As API.Status) As GameStateEnum
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
                Return GameStateEnum.Undefined
        End Select
    End Function
End Class