Imports System.Drawing
Imports System.Windows.Forms
Imports MetroFramework
Imports MLBAMGames.Library
Imports MLBAMGames.Library.Standings
Imports MLBGames.Controls.NHLStats

Namespace Controls
    Public Class GameControl
        Inherits UserControl
        Implements IDisposable
        Private _game As Game
        Private ReadOnly _showLiveScores As Boolean
        Private ReadOnly _showScores As Boolean
        Private ReadOnly _showSeriesRecord As Boolean
        Private ReadOnly _showTeamCityAbr As Boolean
        Private ReadOnly _showLiveTime As Boolean
        Private ReadOnly _showStanding As Boolean
        Private ReadOnly _broadcasters As Dictionary(Of String, String)
        Public LiveReplayCode As LiveStatusCodeEnum
        Private _lnkUnknowns() As Button
        Private _themeChar = "l"
        Private _defaultBackColor = Color.FromArgb(224, 224, 224)

        Public ReadOnly Property GameId As String
            Get
                Return _game.GameId
            End Get
        End Property

        Public Sub UpdateGame(showScores As Boolean, showLiveScores As Boolean, showSeriesRecord As Boolean,
                              showTeamCityAbr As Boolean, showLiveTime As Boolean, showStanding As Boolean, Optional gameUpdated As Game = Nothing)
            If gameUpdated IsNot Nothing Then
                If gameUpdated.StreamsDict Is Nothing Then Return
                _game = gameUpdated
                gameUpdated.Dispose()
            End If

            lblHeader.Text = String.Empty
            lblCenter.Text = String.Empty
            lblNotInSeason.Text = String.Empty
            lblStreamStatus.Text = String.Empty
            Dim gameState = Lang.RmText.GetString($"enumGameState{Convert.ToInt32(_game.GameState)}").ToUpper()

            If _game.IsLive Then
                btnLiveReplay.Visible = True
                tt.SetToolTip(btnLiveReplay, Lang.RmText.GetString("tipLiveGame"))
                lblCenter.Visible = Not showLiveScores
                lblHomeScore.Visible = showLiveScores
                lblAwayScore.Visible = showLiveScores
                lblHeader.BackColor = MetroColors.Red
                lblHeader.ForeColor = Color.White

                If showLiveTime Then
                    Dim inningState = Lang.RmText.GetString(If(_game.GameIsTopInning, "gameTopInning", "gameBottomInning"))
                    Dim inning = String.Format("{0} {1}", inningState, _game.GameCurrentInning).ToUpper()

                    Dim detail = If(_game.GameStateDetailed.ToLower() <> "in progress", $" - {_game.GameStateDetailed}", String.Empty)
                    lblHeader.Text = inning & detail
                Else
                    lblHeader.Text = gameState
                End If

                If Not showLiveScores Then
                    lblCenter.Text = String.Format("{0}{1}{2}", GetGameTime(), vbCrLf, gameState)
                End If

            ElseIf _game.GameState = GameStateEnum.StreamEnded Then
                lblHomeScore.Visible = showScores
                lblAwayScore.Visible = showScores
                lblCenter.Visible = Not showScores
                btnRecap.Visible = _game.Recap?.StreamUrl <> String.Empty
                tt.SetToolTip(btnRecap, Lang.RmText.GetString("tipRecap"))

                If _game.HomeScore < _game.AwayScore Then
                    lblHomeScore.ForeColor = Color.Gray
                Else
                    lblAwayScore.ForeColor = Color.Gray
                End If

                If showScores Then
                    Dim detail = If(_game.GameStateDetailed.ToLower() <> "final", $" - {_game.GameStateDetailed}", String.Empty)
                    lblHeader.Text = Lang.RmText.GetString("gameStateFinal").ToUpper() & detail
                Else
                    lblCenter.Text = String.Format("{0}{1}{2}", GetGameTime(), vbCrLf, Lang.RmText.GetString("gameStateFinal").ToUpper())
                End If
            ElseIf _game.GameState <= GameStateEnum.Pregame Then
                lblDivider.Visible = False
                lblCenter.Visible = True
                lblCenter.Text = GetGameTime()

                If _game.GameState.Equals(GameStateEnum.Pregame) OrElse _game.AreAnyStreamsAvailable() Then
                    lblHeader.BackColor = MetroColors.Red
                    If showLiveScores Then
                        lblHeader.ForeColor = Color.White
                        lblHeader.Text = gameState
                    Else
                        lblCenter.Text &= String.Format("{0}{1}", vbCrLf, gameState)
                    End If
                End If
            ElseIf _game.IsUnplayable Then
                Dim reason = If(_game.GameStateDetailedReason <> String.Empty, $" - {_game.GameStateDetailedReason}", "")
                lblDivider.Visible = False
                lblHeader.Text = _game.GameStateDetailed.ToUpper() & reason
                lblHeader.BackColor = Color.FromKnownColor(KnownColor.DarkOrange)
                lblCenter.Visible = True
                lblCenter.Text = gameState

                If showLiveScores Then
                    lblHeader.ForeColor = Color.White
                    lblHeader.Text = _game.GameStateDetailed.ToUpper()
                End If
            End If

            If _game.GameType.Equals(GameTypeEnum.Preseason) Then
                lblNotInSeason.Text = Lang.RmText.GetString("lblPreseason").ToUpper()
            ElseIf _game.GameType.Equals(GameTypeEnum.Series) AndAlso _game.SeriesGameNumber <> 0 Then
                Dim isSeriesRecordVisible = showSeriesRecord AndAlso _game.SeriesGameStatus.Length > 0 AndAlso (showScores OrElse (_game.GameState < GameStateEnum.OffTheAir))
                lblNotInSeason.Text = If(isSeriesRecordVisible,
                    String.Format(Lang.RmText.GetString("lblGameAbv"),
                                  _game.SeriesGameNumber.ToString(),
                                  Lang.RmText.GetString("lblSeries")),
                    Lang.RmText.GetString("lblSeries")).ToUpper()
            End If

            If Not _game.AreAnyStreamsAvailable Then
                If Parameters.IsServerUp = False Then
                    lblStreamStatus.Text = Lang.RmText.GetString("lblServerDown")
                ElseIf _game.GameDate.ToLocalTime() > Date.UtcNow.ToLocalTime() And _game.GameState < GameStateEnum.InProgress Then
                    lblStreamStatus.Text = Lang.RmText.GetString("lblStreamAvailableAtGameTime")
                Else
                    lblStreamStatus.Text = Lang.RmText.GetString("lblNoStreamAvailable")
                End If
                flpStreams.Visible = False
            End If

            lblHomeTeam.Visible = showTeamCityAbr
            lblAwayTeam.Visible = showTeamCityAbr

            'If showStanding Then
            '    Adorner.AddBadgeTo(picAway, Standing.GetCurrentStandings(StandingTypeEnum.League, API.Seasons.CurrentSeason.seasonId, _game.AwayTeam))
            '    Adorner.AddBadgeTo(picHome, Standing.GetCurrentStandings(StandingTypeEnum.League, API.Seasons.CurrentSeason.seasonId, _game.HomeTeam))
            'Else
            '    Adorner.RemoveBadgeFrom(picAway)
            '    Adorner.RemoveBadgeFrom(picHome)
            'End If

            tt.SetToolTip(picAway,
                          String.Format(Lang.RmText.GetString("lblAwayTeam"), _game.Away, _game.AwayTeam))
            tt.SetToolTip(picHome,
                          String.Format(Lang.RmText.GetString("lblHomeTeam"), _game.Home, _game.HomeTeam))

            SetLiveStatusIcon()
        End Sub

        Public Sub New(game As Game, showScores As Boolean, showLiveScores As Boolean, showSeriesRecord As Boolean,
                       showTeamCityAbr As Boolean, showLiveTime As Boolean, showStanding As Boolean)

            InitializeComponent()
            _broadcasters = New Dictionary(Of String, String)() From {
                {"ALT", "ALT"},
                {"ATT", "ATT"},
                {"BS", "BS"},
                {"CBC", "CBC"},
                {"CITY", "CBC"},
                {"CNBC", "NBC"},
                {"CSN", "NBC"},
                {"ESPN", "ESPN"},
                {"FS", "FS"},
                {"GOLF", "NBC"},
                {"KCOP", "FS"},
                {"FOX", "FS"},
                {"MSG", "MSG"},
                {"NBC", "NBC"},
                {"NESN", "NESN"},
                {"PRIM", "FS"},
                {"RDS", "RDS"},
                {"ROOT", "ROOT"},
                {"SN", "SN"},
                {"SUN", "FS"},
                {"TCN", "CSN"},
                {"TSN", "TSN"},
                {"TVAS", "TVAS"},
                {"USA", "NBC"},
                {"WGN", "WGN"}}
            _showScores = showScores
            _showLiveScores = showLiveScores
            _showSeriesRecord = showSeriesRecord
            _showTeamCityAbr = showTeamCityAbr
            _showLiveTime = showLiveTime
            _showStanding = showStanding
            _game = game

            SetThemeAndSvgOnControl()

            SetWholeGamePanel()
        End Sub

        Private Sub UpdateGameStreams()
            lblHomeScore.Text = _game.HomeScore
            lblHomeTeam.Text = _game.HomeAbbrev

            lblAwayScore.Text = _game.AwayScore
            lblAwayTeam.Text = _game.AwayAbbrev

            lnkAway.Visible = _game.IsStreamDefined(StreamTypeEnum.Away)
            lnkHome.Visible = _game.IsStreamDefined(StreamTypeEnum.Home)
            lnkFrench.Visible = _game.IsStreamDefined(StreamTypeEnum.French)
            lnkNational.Visible = _game.IsStreamDefined(StreamTypeEnum.National)

            If _game.StreamsUnknown IsNot Nothing Then
                Dim unknownStreams = _game.StreamsUnknown
                ReDim _lnkUnknowns(unknownStreams.Count() - 1)
                For i = 0 To unknownStreams.Count() - 1
                    _lnkUnknowns(i) = New Button()
                    With _lnkUnknowns(i)
                        .Height = 26
                        .Width = 26
                        .Margin = New Padding(4, 6, 4, 6)
                        .FlatStyle = FlatStyle.Flat
                        .FlatAppearance.BorderSize = 0
                        .FlatAppearance.BorderColor = _defaultBackColor
                        .FlatAppearance.MouseOverBackColor = Color.White
                        .BackgroundImageLayout = ImageLayout.Zoom
                        .BackColor = _defaultBackColor
                        .BackgroundImage = ImageFetcher.GetEmbeddedImage("cam")
                        .Name = "lnk" & i
                        .Tag = unknownStreams(i)
                    End With
                    SetStreamButtonLink(unknownStreams(i), _lnkUnknowns(i), unknownStreams(i).StreamTypeSelected)
                    AddHandler _lnkUnknowns(i).Click, AddressOf WatchStream
                    flpStreams.Controls.Add(_lnkUnknowns(i))
                Next
            End If

            If _game.IsUnplayable Then
                bpGameControl.BorderColour = Color.DarkOrange
            Else
                If _game.IsTodaysGame Then
                    bpGameControl.BorderColour = MetroColors.Red
                Else
                    bpGameControl.BorderColour = Color.FromArgb(255, 100, 100, 100)
                End If
            End If

            UpdateGame(_showScores, _showLiveScores, _showSeriesRecord, _showTeamCityAbr, _showLiveTime, _showStanding)
        End Sub

        Private Sub SetWholeGamePanel()
            LiveReplayCode = If(_game.IsOffTheAir, LiveStatusCodeEnum.Replay, LiveStatusCodeEnum.Live)

            SetTeamLogo(picAway, $"{_game.AwayAbbrev}_{_themeChar}")
            SetTeamLogo(picHome, $"{_game.HomeAbbrev}_{_themeChar}")

            SetStreamButtonLink(_game.GetStream(StreamTypeEnum.Away), lnkAway,
                                String.Format(Lang.RmText.GetString("lblTeamStream"), _game.AwayAbbrev))
            SetStreamButtonLink(_game.GetStream(StreamTypeEnum.Home), lnkHome,
                                String.Format(Lang.RmText.GetString("lblTeamStream"), _game.HomeAbbrev))
            SetStreamButtonLink(_game.GetStream(StreamTypeEnum.French), lnkFrench, Lang.RmText.GetString("lblFrenchNetwork"))
            SetStreamButtonLink(_game.GetStream(StreamTypeEnum.National), lnkNational,
                                Lang.RmText.GetString("lblNationalNetwork"))

            UpdateGameStreams()
        End Sub
        Private Function GetGameTime() As String
            If _game.GameStartTimeTDB Then Return String.Empty
            Return _game.GameDate.ToLocalTime().ToString("h:mm tt")
        End Function

        Private Sub SetStreamButtonLink(stream As GameStream, btnLink As Button, tooltip As String)
            If stream Is Nothing Then Return
            If stream.IsBroken Then
                Dim brokenImage = ImageFetcher.GetEmbeddedImage("broken")
                If btnLink.BackgroundImage IsNot Nothing Then btnLink.BackgroundImage.Dispose()
                If brokenImage IsNot Nothing Then btnLink.BackgroundImage = brokenImage
                btnLink.FlatAppearance.MouseOverBackColor = _defaultBackColor
                btnLink.FlatAppearance.MouseDownBackColor = _defaultBackColor
                tt.SetToolTip(btnLink, String.Format(Lang.RmText.GetString("tipBrokenStream")))
            Else
                If stream.Type <= StreamTypeEnum.French Then
                    Dim img As String = GetBroadcasterPicFor(stream.Network)
                    If img <> "" Then
                        Dim networkImage = ImageFetcher.GetEmbeddedImage(img)
                        If networkImage IsNot Nothing Then
                            If btnLink.BackgroundImage IsNot Nothing Then btnLink.BackgroundImage.Dispose()
                            btnLink.BackgroundImage = networkImage
                        End If
                    End If
                    tooltip &= String.Format(Lang.RmText.GetString("lblOnNetwork"), stream.Network)
                End If
                tt.SetToolTip(btnLink, tooltip)
            End If
        End Sub

        Private Sub SetTeamLogo(pic As PictureBox, team As String)
            pic.SizeMode = PictureBoxSizeMode.Zoom
            If String.IsNullOrEmpty(team) = False Then
                Dim img As Bitmap = ImageFetcher.GetEmbeddedImage(team)
                If Not img Is Nothing Then
                    If pic.BackgroundImage IsNot Nothing Then pic.BackgroundImage.Dispose()
                    If img IsNot Nothing Then pic.BackgroundImage = img
                End If
            End If
        End Sub

        Private Function GetBroadcasterPicFor(network As String) As String
            Dim value As String = _broadcasters.Where(Function(kvp) network.ToUpper().StartsWith(kvp.Key.ToString())).Select(
                        Function(kvp) kvp.Value).FirstOrDefault()
            Return If(value <> Nothing, value.ToLower, String.Empty)
        End Function

        Public Sub SetLiveStatusIcon(Optional increase As Boolean = False)
            If increase Then
                LiveReplayCode = If(LiveReplayCode + 1 > LiveStatusCodeEnum.Replay, 0, LiveReplayCode + 1)
            End If

            btnLiveReplay.BackColor = If(LiveReplayCode.Equals(LiveStatusCodeEnum.Live), Color.FromArgb(4, 30, 66), Color.White)

            If btnLiveReplay.BackgroundImage IsNot Nothing Then btnLiveReplay.BackgroundImage.Dispose()
            btnLiveReplay.BackgroundImage = ImageFetcher.GetEmbeddedImage($"live_{CType(LiveReplayCode, Integer)}")

            Dim type = LiveReplayCode.ToString()
            If Not LiveReplayCode.Equals(LiveStatusCodeEnum.Rewind) Then
                tt.SetToolTip(btnLiveReplay, Lang.RmText.GetString("tipLiveStatus" & type))
            Else
                tt.SetToolTip(btnLiveReplay, String.Format(Lang.RmText.GetString("tipLiveStatus" & type),
                                                           WatchArgs().StreamLiveRewind))
            End If
        End Sub

        Private Function WatchArgs() As GameWatchArguments
            Dim params = SettingsExtensions.ReadGameWatchArgsParams()
            Return New GameWatchArguments(params)
        End Function

        Private Sub WatchStream(streamType As StreamerTypeEnum)
            Dim args = WatchArgs()
            args.GameDate = _game.GameDate
            args.Stream = _game.GetStream(streamType)
            args.GameTitle = _game.AwayAbbrev & " @ " & _game.HomeAbbrev
            args.StreamLiveReplayCode = LiveReplayCode
            args.GameIsOnAir = _game.GameState < GameStateEnum.StreamEnded AndAlso
                               _game.GameState > GameStateEnum.Pregame
            If Not args.Stream?.IsBroken Then Player.Watch(args)
        End Sub

        Private Sub WatchStream(sender As Object, e As EventArgs)
            Dim args = WatchArgs()
            args.GameDate = _game.GameDate
            args.Stream = CType(sender, Button).Tag
            args.GameTitle = _game.AwayAbbrev & " @ " & _game.HomeAbbrev
            args.StreamLiveReplayCode = LiveReplayCode
            args.GameIsOnAir = _game.GameState < GameStateEnum.StreamEnded AndAlso
                               _game.GameState > GameStateEnum.Pregame
            If Not args.Stream?.IsBroken Then Player.Watch(args)
        End Sub

        Private Sub btnRecap_Click(sender As Object, e As EventArgs) Handles btnRecap.Click
            Dim args = WatchArgs()
            args.GameDate = _game.GameDate
            args.Stream = _game.Recap
            args.GameTitle = _game.AwayAbbrev & " @ " & _game.HomeAbbrev
            args.GameIsOnAir = False
            Player.Watch(args)
        End Sub

        Private Sub lnkAway_Click(sender As Object, e As EventArgs) Handles lnkAway.Click
            WatchStream(StreamTypeEnum.Away)
        End Sub

        Private Sub lnkFrench_Click(sender As Object, e As EventArgs) Handles lnkFrench.Click
            WatchStream(StreamTypeEnum.French)
        End Sub

        Private Sub lnkNational_Click(sender As Object, e As EventArgs) Handles lnkNational.Click
            WatchStream(StreamTypeEnum.National)
        End Sub

        Private Sub lnkHome_Click(sender As Object, e As EventArgs) Handles lnkHome.Click
            WatchStream(StreamTypeEnum.Home)
        End Sub

        Private Sub lnkThree_Click(sender As Object, e As EventArgs)
            WatchStream(StreamTypeEnum.MultiCam1)
        End Sub

        Private Sub lnkSix_Click(sender As Object, e As EventArgs)
            WatchStream(StreamTypeEnum.MultiCam2)
        End Sub

        Private Sub lnkEnd1_Click(sender As Object, e As EventArgs)
            WatchStream(StreamTypeEnum.EndzoneCam1)
        End Sub

        Private Sub lnkEnd2_Click(sender As Object, e As EventArgs)
            WatchStream(StreamTypeEnum.EndzoneCam2)
        End Sub

        Private Sub lnkRef_Click(sender As Object, e As EventArgs)
            WatchStream(StreamTypeEnum.RefCam)
        End Sub

        Private Sub lnkStar_Click(sender As Object, e As EventArgs)
            WatchStream(StreamTypeEnum.StarCam)
        End Sub

        Protected Overloads Overrides Sub Dispose(disposing As Boolean)
            Try
                If disposing Then
                    If _game.IsStreamDefined(StreamTypeEnum.Unknown) Then
                        For Each lnk In _lnkUnknowns
                            RemoveHandler lnk.Click, AddressOf WatchStream
                        Next
                    End If
                    If tt IsNot Nothing Then tt.Dispose()
                    If btnLiveReplay IsNot Nothing Then btnLiveReplay.Dispose()
                    If lblCenter IsNot Nothing Then lblCenter.Dispose()
                    If lblDivider IsNot Nothing Then lblDivider.Dispose()
                    If picAway IsNot Nothing Then picAway.Dispose()
                    If lblHomeScore IsNot Nothing Then lblHomeScore.Dispose()
                    If lblAwayScore IsNot Nothing Then lblAwayScore.Dispose()
                    If lblAwayTeam IsNot Nothing Then lblAwayTeam.Dispose()
                    If picHome IsNot Nothing Then picHome.Dispose()
                    If lblHomeTeam IsNot Nothing Then lblHomeTeam.Dispose()
                    If lblHeader IsNot Nothing Then lblHeader.Dispose()
                    If flpStreams IsNot Nothing Then flpStreams.Dispose()
                    If lnkHome IsNot Nothing Then lnkHome.Dispose()
                    If lnkAway IsNot Nothing Then lnkAway.Dispose()
                    If lnkNational IsNot Nothing Then lnkNational.Dispose()
                    If lnkFrench IsNot Nothing Then lnkFrench.Dispose()
                    If lblNotInSeason IsNot Nothing Then lblNotInSeason.Dispose()
                    If lblStreamStatus IsNot Nothing Then lblStreamStatus.Dispose()
                    If btnRecap IsNot Nothing Then btnRecap.Dispose()
                    If bpGameControl IsNot Nothing Then
                        bpGameControl.Controls.Clear()
                        bpGameControl.Dispose()
                    End If
                    If components IsNot Nothing Then components.Dispose()
                    _broadcasters.Clear()
                    _game.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        Private Sub btnLiveReplay_Click(sender As Object, e As EventArgs) Handles btnLiveReplay.Click
            SetLiveStatusIcon(True)
        End Sub

        Private Sub SetThemeAndSvgOnControl()
            If Parameters.IsDarkMode Then
                _defaultBackColor = Color.FromArgb(80, 80, 80)
                _themeChar = "d"
                BackColor = Color.FromArgb(60, 60, 60)
                flpStreams.BackColor = Color.FromArgb(80, 80, 80)
                lblHeader.BackColor = Color.FromArgb(80, 80, 80)
                lblStreamStatus.BackColor = Color.FromArgb(80, 80, 80)
                lblStreamStatus.ForeColor = Color.LightGray
                lblAwayTeam.Theme = MetroThemeStyle.Dark
                lblHomeTeam.Theme = MetroThemeStyle.Dark
                lblCenter.Theme = MetroThemeStyle.Dark
                lblHeader.ForeColor = Color.White
                lblAwayScore.ForeColor = Color.LightGray
                lblHomeScore.ForeColor = Color.LightGray
                lblNotInSeason.Theme = MetroThemeStyle.Dark
                lblDivider.BackColor = Color.Black
                btnRecap.FlatAppearance.BorderColor = Color.LightGray
                For Each lnk In New Button() {lnkHome, lnkAway, lnkFrench, lnkNational}
                    lnk.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 80)
                    lnk.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 100, 100)
                Next
            End If

            Dim mlb = $"mlb_{_themeChar}"
            picHome.BackgroundImage = ImageFetcher.GetEmbeddedImage(mlb)
            picAway.BackgroundImage = ImageFetcher.GetEmbeddedImage(mlb)
            lnkHome.BackgroundImage = ImageFetcher.GetEmbeddedImage(mlb)
            lnkAway.BackgroundImage = ImageFetcher.GetEmbeddedImage(mlb)
            lnkFrench.BackgroundImage = ImageFetcher.GetEmbeddedImage(mlb)
            lnkNational.BackgroundImage = ImageFetcher.GetEmbeddedImage(mlb)
            btnRecap.BackgroundImage = ImageFetcher.GetEmbeddedImage($"recap_{_themeChar}")
        End Sub
    End Class
End Namespace
