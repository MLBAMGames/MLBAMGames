Imports System.IO
Imports MetroFramework.Controls

Public Class GameWatchArgumentsParameters
    Public Property Quality As StreamQualityEnum = StreamQualityEnum.best
    Public Property Is60Fps As Boolean = True
    Public Property Cdn As CdnTypeEnum = CdnTypeEnum.Akc
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
    Public Property StreamLiveReplayCode As LiveStatusCodeEnum = LiveStatusCodeEnum.Live
    Public Property StreamerType As StreamerTypeEnum = StreamerTypeEnum.None
    Public Property StreamLiveReplay As LiveReplayEnum = LiveReplayEnum.StreamStarts

    Public Sub New()
    End Sub

    Public Sub New(params As GameWatchArgumentsParameters)
        Quality = params.Quality
        Is60Fps = params.Is60Fps
        Cdn = params.Cdn
        PlayerPath = params.PlayerPath
        PlayerType = params.PlayerType
        StreamerPath = params.StreamerPath
        UseCustomStreamerArgs = params.UseCustomStreamerArgs
        CustomStreamerArgs = params.CustomStreamerArgs
        UseCustomPlayerArgs = params.UseCustomPlayerArgs
        CustomPlayerArgs = params.CustomPlayerArgs
        UseOutputArgs = params.UseOutputArgs
        PlayerOutputPath = params.PlayerOutputPath
        StreamLiveRewind = params.StreamLiveRewind
        StreamLiveReplayCode = params.StreamLiveReplayCode
        StreamerType = params.StreamerType
        StreamLiveReplay = params.StreamLiveReplay
    End Sub

    Public Shared Function GetPlayerType(form As IMLBAMForm) As PlayerTypeEnum
        If form.rbMPV.Checked Then
            Return PlayerTypeEnum.Mpv
        ElseIf form.rbMPC.Checked Then
            Return PlayerTypeEnum.Mpc
        ElseIf form.rbVLC.Checked Then
            Return PlayerTypeEnum.Vlc
        Else
            Return PlayerTypeEnum.None
        End If
    End Function

    Public Shared Function RenewArgsParams(Optional forceSet As Boolean = False) As GameWatchArgumentsParameters

        Dim form As IMLBAMForm = Instance.Form

        If Parameters.UILoaded OrElse forceSet Then
            Dim params As New GameWatchArgumentsParameters With {
                .Is60Fps = form.cbStreamQuality.SelectedIndex = 0,
                .Quality = form.cbStreamQuality.SelectedIndex,
                .StreamLiveRewind = form.tbLiveRewind.Value * 5,
                .StreamLiveReplay = form.cbLiveReplay.SelectedIndex,
                .StreamerPath = form.txtStreamerPath.Text,
                .StreamerType = GetStreamerType(form.txtStreamerPath.Text),
                .PlayerType = GetPlayerType(form),
                .PlayerPath = GetPlayerPath(form),
                .UseCustomPlayerArgs = form.tgPlayer.Checked,
                .CustomPlayerArgs = form.txtPlayerArgs.Text,
                .UseCustomStreamerArgs = form.tgStreamer.Checked,
                .CustomStreamerArgs = form.txtStreamerArgs.Text,
                .Cdn = GetCdn(form.tgAlternateCdn),
                .UseOutputArgs = form.tgOutput.Checked,
                .PlayerOutputPath = form.txtOutputArgs.Text
            }

            Instance.Form.SetSetting("DefaultWatchArgsParams", Serialization.SerializeObject(Of GameWatchArgumentsParameters)(params))

            Return params
        End If

        Return New GameWatchArgumentsParameters()
    End Function

    Private Shared Function GetPlayerPath(form As IMLBAMForm) As String
        If form.rbMPV.Checked Then
            Return form.txtMpvPath.Text
        ElseIf form.rbMPC.Checked Then
            Return form.txtMPCPath.Text
        ElseIf form.rbVLC.Checked Then
            Return form.txtVLCPath.Text
        Else
            Return String.Empty
        End If
    End Function

    Private Shared Function GetCdn(tgAlternateCdn As MetroToggle) As CdnTypeEnum
        Return If(tgAlternateCdn.Checked, CdnTypeEnum.L3C, CdnTypeEnum.Akc)
    End Function

    Private Shared Function GetStreamerType(streamerPath As String) As StreamerTypeEnum
        Dim selectedStreamerExe = Path.GetFileNameWithoutExtension(streamerPath).ToLower()
        If selectedStreamerExe = StreamerTypeEnum.LiveStreamer.ToString().ToLower() Then
            Return StreamerTypeEnum.LiveStreamer
        ElseIf selectedStreamerExe = StreamerTypeEnum.StreamLink.ToString().ToLower() Then
            Return StreamerTypeEnum.StreamLink
        Else
            Return StreamerTypeEnum.None
        End If
    End Function
End Class