﻿Public Class GameStream
    Implements IDisposable
    Private _disposedValue As Boolean
    Public ReadOnly Property Type As StreamTypeEnum
    Public ReadOnly Property Game As Game
    Public ReadOnly Property Network As String
    Private ReadOnly Property PlayBackId As String
    Public Property GameUrl As String = String.Empty
    Public Property CdnParameter As CdnTypeEnum = CdnTypeEnum.Akc
    Public Property Title As String = String.Empty
    Public Property StreamUrl As String = String.Empty
    Public Property StreamTypeSelected As String = String.Empty

    Public ReadOnly Property IsBroken As Boolean
        Get
            Return StreamUrl.Equals(String.Empty)
        End Get
    End Property

    Public Sub New()
    End Sub

    Public Sub New(game As Game, stream As API.Item, type As StreamTypeEnum, streamTypeSelected As String, sport As SportsEnum)
        Me.Game = game
        Network = stream.callLetters
        If Network = String.Empty Then Network = If(sport = SportsEnum.NHL, EPGMediaEnum.NHLTV.ToString(), EPGMediaEnum.MLBTV.ToString())
        PlayBackId = stream.mediaPlaybackId
        Me.Type = type
        If type = StreamTypeEnum.Unknown Then
            Me.StreamTypeSelected = streamTypeSelected
        End If
        CdnParameter = SettingsExtensions.ReadGameWatchArgs().Cdn
        GameUrl = $"http://{Parameters.HostName}/getM3U8.php?league={sport}&id={PlayBackId}&cdn={CdnParameter.ToString().ToLower()}&date={DateHelper.GetPacificTime(game.GameDate).ToString("yyyy-MM-dd")}"
        Title = $"{game.AwayAbbrev} vs {game.HomeAbbrev} on {Network}"
    End Sub

    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not _disposedValue Then
            If disposing Then
                Game.Dispose()
            End If
        End If
        _disposedValue = True
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub

    Protected Overrides Sub Finalize()
        Dispose(False)
    End Sub
End Class

