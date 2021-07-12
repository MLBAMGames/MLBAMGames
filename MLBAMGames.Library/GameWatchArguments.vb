﻿Imports System.IO

Public Class GameWatchArguments
    Const DefaultSegment = 12
    Public Property GameDate As Date = Now
    Public Property Quality As StreamQualityEnum = StreamQualityEnum.best
    Public Property Is60Fps As Boolean = True
    Public Property Cdn As CdnTypeEnum = CdnTypeEnum.Akc
    Public Property Stream As GameStream = Nothing
    Public Property GameTitle As String = String.Empty
    Public Property PlayerPath As String = String.Empty
    Public Property PlayerType As PlayerTypeEnum = PlayerTypeEnum.None
    Public Property StreamerPath As String = String.Empty
    Public Property UseCustomStreamerArgs As Boolean = True
    Public Property CustomStreamerArgs As String
    Public Property UseCustomPlayerArgs As Boolean = True
    Public Property CustomPlayerArgs As String
    Public Property UseOutputArgs As Boolean = False
    Public Property PlayerOutputPath As String = String.Empty
    Public Property StreamLiveRewind As Integer = 5
    Public Property GameIsOnAir As Boolean = False
    Public Property StreamLiveReplayCode As LiveStatusCodeEnum = LiveStatusCodeEnum.Live
    Public Property StreamerType As StreamerTypeEnum = StreamerTypeEnum.None
    Public Property StreamLiveReplay As LiveReplayEnum = LiveReplayEnum.StreamStarts

    Public Shared ReadOnly StreamerDefaultArgs As Dictionary(Of String, String) = New Dictionary(Of String, String)() From {
        {"--hls-segment-threads", "2"}, {"--hls-segment-attempts", "9"}, {"--hls-segment-timeout", "10"}, {"--hls-timeout", "180"}}

    Public Shared ReadOnly MpvDefaultArgs As Dictionary(Of String, String) = New Dictionary(Of String, String)() From {
        {"--cache", "yes"}}

    Public Shared ReadOnly VlcDefaultArgs As Dictionary(Of String, String) = New Dictionary(Of String, String)() From {
        {"--file-caching", "10000"}, {"--network-caching", "10000"}}

    Public Shared SavedPlayerArgs As Dictionary(Of PlayerTypeEnum, String()) = New Dictionary(Of PlayerTypeEnum, String())() From {
        {PlayerTypeEnum.Mpc, {}},
        {PlayerTypeEnum.Vlc, VlcDefaultArgs.Select(Function(kvp) $"{kvp.Key}={kvp.Value}").ToArray()},
        {PlayerTypeEnum.Mpv, MpvDefaultArgs.Select(Function(kvp) $"{kvp.Key}={kvp.Value}").ToArray()},
        {PlayerTypeEnum.None, {}}
    }

    Public Overrides Function ToString() As String
        Return OutputArgs(False)
    End Function

    Public Overloads Function ToString(safeOutput As Boolean)
        Return OutputArgs(safeOutput)
    End Function

    Private Function IsProxyNecessary() As Boolean
        Return Not Parameters.IsHostsRedirectionSet AndAlso Not Stream.Type.Equals(StreamTypeEnum.Recap)
    End Function

    Private Function GetStreamQuality() As String
        Dim selectedQualities = ""
        Dim addQuality = Quality
        Dim maxQuality = CType([Enum].GetValues(GetType(StreamQualityEnum)), Integer()).Max()
        While addQuality < maxQuality
            selectedQualities &= addQuality.ToString().Substring(1) & ","
            addQuality = addQuality + 1
        End While
        selectedQualities &= StreamQualityEnum.worst.ToString()
        Return selectedQualities
    End Function

    Private Function OutputArgs(safeOutput As Boolean) As String
#If DEBUG Then
        safeOutput = False
#End If
        If String.IsNullOrEmpty(PlayerPath) OrElse PlayerType.Equals(PlayerTypeEnum.None) Then _
            Console.WriteLine(Lang.EnglishRmText.GetString("errorPlayerPathEmpty"))

        Dim result As String

        If UseOutputArgs And Stream.Game Is Nothing Then
            UseOutputArgs = False
        End If

        If UseOutputArgs Then
            result = OutputArgs() & ReplayArgs()
        Else
            result = PlayerArgs() & ReplayArgs()
        End If

        If IsProxyNecessary() Then result &= StreamlinkHttpsProxyArgs()
        result &= RetryArgs()
        If UseCustomStreamerArgs Then result &= CustomStreamerArgs
        If Not safeOutput Then result &= NhlCookieArgs()
        If Not safeOutput Then result &= UserAgentArgs()
        result &= If(safeOutput, StreamLinkCensoredArgs(), StreamLinkArgs())
        result &= If(Is60Fps, StreamBestQualityArgs(), StreamQualityArgs())

        Return result
    End Function

    Private Function PlayerArgs() As String
        Dim args = String.Empty
        Dim literalPlayerArgs = If(UseCustomPlayerArgs, CustomPlayerArgs, String.Empty)
        Dim title = $"{GameTitle} - {Stream.Network} - {Quality.ToString()}"
        Select Case PlayerType
            Case PlayerTypeEnum.Mpv
                args &= $"--force-window=immediate --title=""""{title}"""" --user-agent=User-Agent=""""{Web.UserAgent}"""""
            Case PlayerTypeEnum.Vlc
                args &= $"--meta-title=""""{title}"""" "
                If IsProxyNecessary() Then args &= $"{VlcHttpProxyArgs()} "
            Case PlayerTypeEnum.Mpc
        End Select
        Return $"--player ""{PlayerPath} {args} {literalPlayerArgs}"" "
    End Function

    Private Function ReplayArgs() As String
        ' v1.4.0: Seeking through live game only works with mpv when Proxy is enabled
        Dim hlsPlayersReady = If(IsProxyNecessary(),
            New PlayerTypeEnum() {PlayerTypeEnum.Mpv},
            New PlayerTypeEnum() {PlayerTypeEnum.Mpv, PlayerTypeEnum.Mpc})

        Dim presetHls = If(hlsPlayersReady.Contains(PlayerType),
                           "--player-passthrough=hls ",
                           String.Empty)

        If GameIsOnAir Then
            If Not StreamLiveReplayCode.Equals(LiveStatusCodeEnum.Live) Then
                Return $"--hls-live-edge={ReplayMinutes()} "
            Else
                Return presetHls
            End If
        Else
            Return presetHls
        End If
    End Function

    Private Function ReplayMinutes() As Integer
        Select Case StreamLiveReplayCode
            Case LiveStatusCodeEnum.Rewind
                Return StreamLiveRewind * DefaultSegment
            Case LiveStatusCodeEnum.Replay
                Dim segments = CType((Date.UtcNow - GameDate).TotalMinutes, Integer) * DefaultSegment
                If segments <= 0 Then StreamLiveReplay = LiveReplayEnum.StreamStarts
                Select Case StreamLiveReplay
                    Case LiveReplayEnum.PuckDrop
                        Return segments - (DefaultSegment * 10)
                    Case LiveReplayEnum.GameTime
                        Return segments
                End Select
                Return 9999
        End Select
        Return DefaultSegment
    End Function

    Private Function StreamlinkHttpsProxyArgs() As String
        Return String.Format("--https-proxy=""https://127.0.0.1:{0}"" --http-proxy=""http://127.0.0.1:{0}"" ", Proxy.MLBAMProxy.port)
    End Function

    Private Function VlcHttpProxyArgs() As String
        Return String.Format("--http-proxy=""https://127.0.0.1:{0}"" --http-reconnect --http-forward-cookies", Proxy.MLBAMProxy.port)
    End Function

    Private Function RetryArgs() As String
        Return $"--stream-types=hls "
    End Function

    Private Function NhlCookieArgs() As String
        Return $" --http-cookie=""mediaAuth={Web.GetRandomString(240)} """
    End Function

    Private Function UserAgentArgs() As String
        Return $" --http-header=""User-Agent={Web.UserAgent}"" "
    End Function

    Private Function StreamLinkArgs() As String
        Return $" ""hls://{Stream.StreamUrl.Replace("CDN", Cdn.ToString().ToLower())} "
    End Function

    Private Function StreamLinkCensoredArgs() As String
        Return $" ""hls://{Lang.EnglishRmText.GetString("msgCensoredStream")} "
    End Function

    Private Function StreamBestQualityArgs() As String
        Return $"name_key=bitrate"" best --http-no-ssl-verify"
    End Function

    Private Function StreamQualityArgs() As String
        Return $""" {GetStreamQuality()} --http-no-ssl-verify"
    End Function

    Private Function OutputArgs() As String
        Dim outputPath As String = PlayerOutputPath.
                Replace("(DATE)", DateHelper.GetPacificTime(Stream.Game.GameDate).ToString("yyyy-MM-dd")).
                Replace("(HOME)", Stream.Game.HomeAbbrev).
                Replace("(AWAY)", Stream.Game.AwayAbbrev).
                Replace("(TYPE)", Stream.Type.ToString()).
                Replace("(NETWORK)", Stream.Network)
        Dim suffix = 1
        Dim originalName = Path.GetFileNameWithoutExtension(outputPath)
        Dim originalExt = Path.GetExtension(outputPath)
        While (My.Computer.FileSystem.FileExists(outputPath))
            outputPath = Path.ChangeExtension(
                Path.Combine(Path.GetDirectoryName(outputPath), originalName & "_" & suffix), originalExt)
            suffix += 1
        End While

        Return $"-f -o ""{outputPath}"" "
    End Function
End Class
