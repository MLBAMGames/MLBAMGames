Imports System.Globalization
Imports System.Text.RegularExpressions
Imports MLBAMGames.Library.API
Imports Newtonsoft.Json

Public MustInherit Class GameManager
    Implements IDisposable

    Private _disposedValue As Boolean
    Private Const MediaOff = "MEDIA_OFF"

    Public MustOverride ReadOnly Property DictStreamType As Dictionary(Of String, StreamTypeEnum)
    Public MustOverride Async Function GetSchedule(gameDate As Date) As Task(Of Schedule)
    Public MustOverride Function GetGameStateFromStatus(status As API.Status) As GameStateEnum
    Public MustOverride Async Function SetNewGameStream(currentGame As Game, innerStream As API.Item, streamType As StreamTypeEnum, streamTypeSelected As String) As Task(Of GameStream)
    Public MustOverride Async Function GetGameFeedUrlAsync(gameStream As GameStream) As Task(Of String)

    Public Async Function GetGamesAsync(gameDate As Date) As Task(Of Game())
        Dim schedule As Schedule = Await GetSchedule(gameDate)

        If schedule Is Nothing Then
            Console.WriteLine("Error: Failed to fetch games schedule.")
            Return Nothing
        End If

        If Not Parameters.IsServerUp Then
            Console.WriteLine(String.Format(Lang.RmText.GetString($"msgServerSeemsDown"), Parameters.HostName))
        End If

        Dim gamesArray As Game()
        Dim lstStreamsTask As Task()
        Dim currentGameIndex = 0
        Dim currentStreamIndex = 0

        Dim numberOfGames = (Convert.ToInt32(schedule.totalGames))
        Dim numberOfStreams = If(schedule.date?.numberOfFeeds, 0)
        If numberOfGames = 0 Then Return Nothing

        gamesArray = New Game(numberOfGames - 1) {}
        lstStreamsTask = If(Parameters.IsServerUp, New Task(numberOfStreams - 1) {}, New Task() {})

        Dim progressPerGame = Convert.ToInt32(((Parameters.SpnLoadingMaxValue - 1) - Parameters.SpnLoadingValue) / numberOfGames)

        For Each game As API.Game In schedule.date.games

            Dim currentGame = NewGameWithStats(game)

            If Parameters.IsServerUp Then
                Dim progressPerStream = If(game.numberOfFeedsWithRecap <> 0, Convert.ToInt32(progressPerGame / game.numberOfFeedsWithRecap), progressPerGame)
                For Each feed In game.EventFeeds
                    Parameters.SpnLoadingValue += progressPerStream
                    Dim streamType As StreamTypeEnum = GetStreamType(feed.streamTypeSelected)
                    If Not feed.mediaState.Equals(MediaOff) AndAlso numberOfStreams > 0 Then
                        Dim tCurrentGame = currentGame
                        Dim tInnerStream = feed
                        Dim tStreamType = streamType
                        Dim tCurrentGameIndex = currentGameIndex
                        Dim tStreamTypeSelected = feed.streamTypeSelected
                        lstStreamsTask(currentStreamIndex) =
                            Task.Run(Async Function()
                                         Dim newStream = Await SetNewGameStream(tCurrentGame, tInnerStream, tStreamType, tStreamTypeSelected)
                                         If streamType <> StreamTypeEnum.Unknown Then
                                             If gamesArray(tCurrentGameIndex).StreamsDict.ContainsKey(streamType) Then Return
                                             gamesArray(tCurrentGameIndex).StreamsDict.Add(streamType, newStream)
                                         Else
                                             gamesArray(tCurrentGameIndex).StreamsUnknown.Add(newStream)
                                         End If
                                     End Function)

                        If streamType = StreamTypeEnum.Unknown Then
                            Console.WriteLine("Game stream: Stream type unknown for the game {0} vs {1} : {2} - {3}", currentGame.AwayAbbrev,
                                                currentGame.HomeAbbrev,
                                                feed.mediaFeedType,
                                                feed.feedName)
                        End If
                    Else
                        lstStreamsTask(currentStreamIndex) = Task.Run(Sub() Return)
                    End If
                    currentStreamIndex += 1
                Next

                If currentGame.IsEnded AndAlso game.numberOfRecapFeeds <> 0 Then
                    currentGame.Recap = SetGameRecap(game)
                    Parameters.SpnLoadingValue += progressPerStream
                End If
            End If

            gamesArray(currentGameIndex) = currentGame
            currentGameIndex += 1
        Next

        Try
            Await Task.WhenAll(lstStreamsTask).ContinueWith(Sub(x) x.Dispose())
        Catch ex As AggregateException
            Console.WriteLine("Error: Code failed at: {0} - With exception: {1}", $"Getting streams in manager", ex.Message)
        End Try

        Return gamesArray
    End Function

    Private Function NewGameWithStats(game As API.Game)
        Dim currentGame = New Game With {
                .GameDate = game.gameDate.ToUniversalTime(), ' Must use universal time to always get correct date for stream
                .GameId = game.gamePk.ToString(),
                .GameType = Convert.ToInt16(GetChar(game.gamePk.ToString(), 6)) - 48,
                .Home = If(game.teams?.home?.team?.locationName, String.Empty),
                .HomeAbbrev = If(game.teams?.home?.team?.abbreviation, String.Empty),
                .HomeTeam = If(game.teams?.home?.team?.teamName, String.Empty),
                .Away = If(game.teams?.away?.team?.locationName, String.Empty),
                .AwayAbbrev = If(game.teams?.away?.team?.abbreviation, String.Empty),
                .AwayTeam = If(game.teams?.away?.team?.teamName, String.Empty),
                .GameState = GetGameStateFromStatus(game.status),
                .GameStateDetailed = game.status.detailedState
            }

        If currentGame.GameType = GameTypeEnum.Series AndAlso game.seriesSummary?.gameNumber IsNot Nothing Then
            currentGame.SeriesGameNumber = game.seriesSummary?.gameNumber
            currentGame.SeriesGameStatus = If(game.seriesSummary?.seriesStatusShort, String.Empty)
        End If

        If currentGame.GameDate.AddDays(1) < Date.UtcNow AndAlso currentGame.GameState > 0 AndAlso currentGame.GameState < 7 Then
            currentGame.GameState = GameStateEnum.StreamEnded
        End If

        If currentGame.IsStreamable Then
            currentGame.HomeScore = game.teams.home.score.ToString()
            currentGame.AwayScore = game.teams.away.score.ToString()
            If currentGame.IsLive Then
                currentGame.GamePeriod = game.linescore.currentPeriodOrdinal
                currentGame.GameTimeLeft = game.linescore.currentPeriodTimeRemaining
                currentGame.IsInIntermission = If(game.linescore.intermissionInfo?.inIntermission, False)
            End If

            If currentGame.IsInIntermission Then
                currentGame.IntermissionTimeRemaining = Date.MinValue.AddSeconds(game.linescore.intermissionInfo.intermissionTimeRemaining)
            End If
        End If

        Return currentGame
    End Function


    Private Function SetGameRecap(game As API.Game)
        Dim recap = game.RecapFeeds.First()
        Return New GameStream With {
            .Title = recap.title,
            .StreamUrl = recap.recapLink,
            .StreamTypeSelected = StreamTypeEnum.Unknown
        }
    End Function

    Private Function GetStreamType(streamTypeSelected As String) As StreamTypeEnum
        Dim streamTypeAsText = Regex.Replace(streamTypeSelected.ToUpper(), "[^A-Z0-9]", "")

        If DictStreamType.ContainsKey(streamTypeAsText) Then
            Return DictStreamType(streamTypeAsText)
        Else
            Return StreamTypeEnum.Unknown
        End If
    End Function

    Private Sub Dispose(disposing As Boolean)
        If Not _disposedValue Then
            _disposedValue = True
        End If
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub

    Protected Overrides Sub Finalize()
        Dispose(False)
    End Sub
End Class
