Imports MLBAMGames.Library.API

Public Class Parameters
    Public Const SubredditLink As String = "https://www.reddit.com/r/nhl_games/"
    Public Const LatestReleaseLink As String = "https://github.com/NHLGames/NHLGames/releases/latest"

    Public Const ResizeBorderWidth As Integer = 8
    Public Const TotalTipCount As Integer = 10
    Public Const AnimateTipsEveryTick As Integer = 10000

    Public Shared Property DomainNames As String()

    Public Shared Property AnimateTipsTick As Integer = 0
    Public Shared Property HostName As String = String.Empty
    Public Shared Property IsDarkMode As Boolean = False
    Public Shared Property IsServerUp As Boolean = Nothing
    Public Shared Property IsProxyListening As Task(Of Boolean) = Nothing
    Public Shared Property IsHostsRedirectionSet As Boolean = False
    Public Shared Property ResizeDirection As Integer = -1
    Public Shared Property UILoaded As Boolean = False
    Public Shared Property TodayLiveGamesFirst As Boolean = False
    Public Shared Property StreamStarted As Boolean = False
    Public Shared Property MsgBoxVisible As Boolean = False

    Public Shared Property SpnLoadingValue As Integer = 0
    Public Shared Property SpnLoadingMaxValue As Integer = 1000
    Public Shared Property SpnLoadingVisible As Boolean = False
    Public Shared Property SpnStreamingValue As Integer = 0
    Public Shared Property SpnStreamingMaxValue As Integer = 1000
    Public Shared Property SpnStreamingVisible As Boolean = False

    Public Shared Property StartupPath As String = Nothing

    Public Shared Property Tips As New Dictionary(Of Integer, String)
    Public Shared Property WatchArgsParams As GameWatchArgumentsParameters = New GameWatchArgumentsParameters
End Class
