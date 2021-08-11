﻿Imports System.Collections.ObjectModel
Imports System.Threading
Imports MLBAMGames.Library.My.Resources
Imports MLBAMGames.Library.Modules
Imports NAudio.CoreAudioApi

Public Class AdDetection
    Implements IDisposable
    Public Shared Engine As AdDetection

    Private _disposedValue As Boolean

    Private _mediaPlayerProcesses As List(Of Integer)
    Private ReadOnly _adModules As List(Of IAdModule) = New List(Of IAdModule)
    Private _previousAdPlayingState As Boolean
    Private _newAdPlayingState As Boolean
    Private _initializationTasks As List(Of Task)
    Private Shared _settings As AdDetectionConfigs
    Private ReadOnly _lastSoundTime As Dictionary(Of Integer, DateTime) = New Dictionary(Of Integer, DateTime)
    Private _aMmDevices As New MMDeviceEnumerator()

    Private Property RequiredSilenceMilliseconds As Integer = 500
    Private ReadOnly Property PollPeriodMilliseconds As Integer = 500
    Private Property DetectionEnabled As Boolean

    Private ReadOnly Property MediaPlayerProcesses As ReadOnlyCollection(Of Integer)
        Get
            Return New ReadOnlyCollection(Of Integer)(_mediaPlayerProcesses)
        End Get
    End Property

    Public Property IsEnabled As Boolean
        Get
            Return DetectionEnabled
        End Get
        Set
            DetectionEnabled = Value
        End Set
    End Property

    Private Function IsAdCurrentlyPlaying() As Boolean
        Dim closedProcesses = _lastSoundTime.Keys.Where(Function(x) Not MediaPlayerProcesses.Contains(x)).ToList()
        Dim newProcesses = MediaPlayerProcesses.Where(Function(x) Not _lastSoundTime.Keys.Contains(x)).ToList()

        For Each closedProcessId In closedProcesses
            _lastSoundTime.Remove(closedProcessId)
        Next

        For Each newProcessId In newProcesses
            AddOrUpdateLastSoundOccured(newProcessId)
        Next

        For Each processId In MediaPlayerProcesses
            Dim audioSession = GetAudioSession(processId)
            If audioSession Is Nothing Then Return False
            If GetCurrentVolume(audioSession) > 0 Then
                AddOrUpdateLastSoundOccured(processId)
            End If
        Next

        Return _lastSoundTime.Values.All(Function(x) DateTime.Now - x > TimeSpan.FromMilliseconds(RequiredSilenceMilliseconds))
    End Function

    Private Sub AddOrUpdateLastSoundOccured(processId As Integer)
        If _lastSoundTime.ContainsKey(processId) Then
            _lastSoundTime(processId) = DateTime.Now
        Else
            _lastSoundTime.Add(processId, DateTime.MinValue)
        End If
    End Sub

    Public Function GetAudioSession(processId As Integer) As AudioSessionControl
        Dim DefaultAudioEndPointDevice As MMDevice = _aMmDevices.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia)
        Dim sessionsDefaultAudioEndPointDevice = DefaultAudioEndPointDevice.AudioSessionManager.Sessions
        For i = 0 To sessionsDefaultAudioEndPointDevice.Count - 1
            If sessionsDefaultAudioEndPointDevice(i).GetProcessID <> processId Then Continue For
            Return sessionsDefaultAudioEndPointDevice(i)
        Next
        Return Nothing
    End Function

    Public Function GetCurrentVolume(audioSession As AudioSessionControl) As Double
        If audioSession Is Nothing Then Return 0.0
        Dim x = audioSession.DisplayName
        Dim volumeList = New List(Of Double)
        For j = 0 To 2
            Dim audioMeter As AudioMeterInformation = audioSession.AudioMeterInformation
            Dim p = Math.Round(audioMeter.MasterPeakValue * 100.0, 1)
            volumeList.Add(p)
            Thread.Sleep(60)
        Next
        Return volumeList.DefaultIfEmpty().Average()
    End Function

    Public Function IsInAdModulesList(moduleTitle As AdModulesEnum) As Boolean
        SyncLock _adModules
            Return _adModules.Exists(Function(x) x.Title = moduleTitle)
        End SyncLock
    End Function

    Public Function AddModule(m As IAdModule) As Task
        SyncLock _adModules
            _adModules.Add(m)
            Return Task.Run(Sub()
                                m.Initialize()
                            End Sub)
        End SyncLock
    End Function

    Public Sub RemoveModule(moduleTitle As AdModulesEnum)
        SyncLock _adModules
            Dim modulesToRemove = _adModules.Where(Function(x) x.Title = moduleTitle).ToList()
            For Each m In modulesToRemove
                _adModules.Remove(m)
                m.DisposeIt()
            Next
        End SyncLock
    End Sub

    Public Sub Start()
        _previousAdPlayingState = False
        _initializationTasks = _adModules.Select(Function(x) AddModule(x)).ToList()
        Task.Run(AddressOf LoopForever)
    End Sub

    Private Sub NotifyModules()
        SyncLock _adModules
            For Each adModule In _adModules
                Dim m = adModule
                Task.Run(Sub()
                             m.AdPlaying()
                         End Sub)

                If _previousAdPlayingState = _newAdPlayingState Then Return

                If _newAdPlayingState Then
                    Task.Run(Sub()
                                 m.AdStarted()
                             End Sub)
                Else
                    Task.Run(Sub()
                                 m.AdEnded()
                             End Sub)
                End If
            Next
        End SyncLock
    End Sub

    Private Async Sub LoopForever()
        Try
            Task.WaitAll(_initializationTasks.ToArray(), TimeSpan.FromSeconds(5))
        Catch ex As Exception
            Console.WriteLine("Warning: Ad Detection: Problem initializing tasks: {0}", ex.Message)
        End Try
        While DetectionEnabled
            Try
                If Not IsMediaPlayerCurrentlyPlaying() Then
                    Await Task.Delay(TimeSpan.FromSeconds(2))
                    Continue While
                End If
                Await Task.Delay(PollPeriodMilliseconds)
                Dim newAdPlayingState = IsAdCurrentlyPlaying()
                _newAdPlayingState = IsAdCurrentlyPlaying()
                NotifyModules()
                _previousAdPlayingState = newAdPlayingState
            Catch ex As Exception
                Console.WriteLine("Warning: Ad Detection: Unexpected Exception: {0}", ex.Message)
            End Try
        End While
    End Sub

    Private Function IsMediaPlayerCurrentlyPlaying() As Boolean
        Dim vlcProcesses = Process.GetProcessesByName("vlc").
            Where(Function(x) x.MainWindowTitle = "fd://0 - VLC media player" OrElse x.MainWindowTitle.ToLower().Contains(" @ ") OrElse x.MainWindowTitle.ToLower().Contains("GAME_VIDEO")).
            Select(Function(x) x.Id)
        Dim mpc64Processes = Process.GetProcessesByName("MPC-HC64").
            Where(Function(x) x.MainWindowTitle = "stdin" OrElse x.MainWindowTitle.ToLower().Contains(" @ ") OrElse x.MainWindowTitle.ToLower().Contains(".m3u8")).
            Select(Function(x) x.Id)
        Dim mpc32Processes = Process.GetProcessesByName("MPC-HC").
            Where(Function(x) x.MainWindowTitle = "stdin" OrElse x.MainWindowTitle.ToLower().Contains(" @ ") OrElse x.MainWindowTitle.ToLower().Contains(".m3u8")).
            Select(Function(x) x.Id)
        Dim mpvProcesses = Process.GetProcessesByName("mpv").
            Select(Function(x) x.Id)

        _mediaPlayerProcesses = vlcProcesses.Concat(mpc64Processes).Concat(mpc32Processes).Concat(mpvProcesses).ToList()
        Return _mediaPlayerProcesses.Count <> 0
    End Function

    Public Shared Function Renew(Optional forceSet As Boolean = False) As AdDetectionConfigs
        If Parameters.UILoaded OrElse forceSet Then
            _settings = New AdDetectionConfigs With {
                .IsEnabled = Instance.Form.tgModules.Checked,
                .EnabledSpotifyModule = Instance.Form.tgMedia.Checked,
                .EnabledObsModule = Instance.Form.tgOBS.Checked,
                .EnabledSpotifyForceToOpen = Instance.Form.chkSpotifyForceToStart.Checked,
                .EnabledSpotifyPlayNextSong = Instance.Form.chkSpotifyPlayNextSong.Checked,
                .EnabledSpotifyHotkeys = Instance.Form.chkSpotifyHotkeys.Checked
            }

            If Not String.IsNullOrEmpty(Instance.Form.txtMediaControlDelay.Text) Then
                _settings.MediaControlDelay = Instance.Form.txtMediaControlDelay.Text
            End If

            _settings.EnabledObsGameSceneHotKey.Key = Instance.Form.txtGameKey.Text
            _settings.EnabledObsGameSceneHotKey.Ctrl = Instance.Form.chkGameCtrl.Checked
            _settings.EnabledObsGameSceneHotKey.Alt = Instance.Form.chkGameAlt.Checked
            _settings.EnabledObsGameSceneHotKey.Shift = Instance.Form.chkGameShift.Checked

            _settings.EnabledObsAdSceneHotKey.Key = Instance.Form.txtAdKey.Text
            _settings.EnabledObsAdSceneHotKey.Ctrl = Instance.Form.chkAdCtrl.Checked
            _settings.EnabledObsAdSceneHotKey.Alt = Instance.Form.chkAdAlt.Checked
            _settings.EnabledObsAdSceneHotKey.Shift = Instance.Form.chkAdShift.Checked

            Instance.Form.SetSetting("AdDetection", Serialization.SerializeObject(Of AdDetectionConfigs)(_settings))

            Return _settings
        End If

        Return New AdDetectionConfigs()
    End Function

    Private Sub Dispose(disposing As Boolean)
        If Not _disposedValue Then
            _disposedValue = True
        End If
        _aMmDevices.Dispose()
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub

    Protected Overrides Sub Finalize()
        Dispose(False)
    End Sub
End Class
