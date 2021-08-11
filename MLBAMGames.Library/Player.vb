Imports System.IO
Imports System.Threading
Imports MetroFramework.Controls

Public Class Player
    Private Const Http = "http"

    Public Shared Sub Watch(args As GameWatchArguments)
        Dim form As IMLBAMForm = Instance.Form

        If args.PlayerPath.Equals(String.Empty) OrElse args.StreamerPath.Equals(String.Empty) Then
            If form.txtStreamerPath.Text.Equals(String.Empty) Then
                Console.WriteLine("Error:  Can't find the specified streamer. The streamer is used to send streams to your media player, please select the one that comes with the app or select a valid path of Livestreamer.exe or Streamlink.exe")
            ElseIf _
                form.txtMpvPath.Text.Equals(String.Empty) AndAlso form.txtVLCPath.Text.Equals(String.Empty) AndAlso
                form.txtMPCPath.Text.Equals(String.Empty) Then
                Console.WriteLine("Error: Can't find mpv.exe : mpv is a media player that we shipped with the app. You probably moved it or deleted it. Please set a player, it needs one.")
            Else
                Console.WriteLine("Error: No media player selected in settings.")
            End If
            Return
        End If

        Dim taskLaunchingStream = New Task(Async Sub()
                                               Parameters.StreamStarted = True
                                               Parameters.SpnStreamingValue = 1
                                               Thread.Sleep(100)
                                               If Not Parameters.IsHostsRedirectionSet Then Await Proxy.WaitToBeReady()
                                               LaunchingStream(args)
                                               Thread.Sleep(100)
                                               Parameters.StreamStarted = False
                                           End Sub)

        taskLaunchingStream.Start()
    End Sub

    Private Shared Sub LaunchingStream(args As GameWatchArguments)
        Dim lstValidLines As _
                New List(Of String) _
                From {"found matching plugin stream", "available streams", "opening stream", "starting player"}
        Dim lstInvalidLines As New List(Of String) From {"could not open stream", "failed to read"}
        Dim progressStep As Integer = (Parameters.SpnLoadingMaxValue) / (lstValidLines.Count + 1)


        Console.WriteLine("Streaming: {0} on {1} using {2} player", args.GameTitle, args.Stream.Network, args.PlayerType.ToString())
        Console.WriteLine("Starting: Streamer {0}", args.ToString(True))

        Dim procStreaming = New Process() With {.StartInfo =
                New ProcessStartInfo With {
                .FileName = args.StreamerPath,
                .Arguments = args.ToString(),
                .UseShellExecute = False,
                .RedirectStandardOutput = True,
                .CreateNoWindow = Not (Instance.Form.tgOutput.Checked And args.Stream.Game IsNot Nothing)}
                }
        procStreaming.EnableRaisingEvents = True

        Dim taskPlayerWatcher = New Task(Sub()
                                             PlayerWatcher(args)
                                         End Sub)

        Try
            procStreaming.Start()

            If Instance.Form.tgOutput.Checked Then Return

            While (procStreaming.StandardOutput.EndOfStream = False)
                Dim line = procStreaming.StandardOutput.ReadLine().ToLower()
                If line.Contains(Http) Then
                    line = line.Substring(0, line.IndexOf(Http, StringComparison.Ordinal)) &
                           "[CENSORED_STREAM_URL]"
                End If
                If lstValidLines.Any(Function(x) line.Contains(x)) Then
                    Parameters.SpnStreamingValue += progressStep
                End If
                If line.Contains(lstValidLines(3)) Then
                    taskPlayerWatcher.Start()
                End If
                Console.WriteLine(line)
                If lstInvalidLines.Any(Function(x) line.Contains(x)) Then
                    Console.WriteLine("Warning: Starting stream failed. Try to use a different quality in settings, so it will try another stream.")
                    Throw New IOException()
                End If
                If line.Contains("player closed") Then Throw New IOException()
                Thread.Sleep(50) 'to let some time for the progress bar to move
            End While
        Catch ex As IOException
        Catch ex As Exception
            Console.WriteLine("Error: Code failed at: {0} - With exception: {1}", $"Starting stream", ex.Message)
        Finally
            Parameters.StreamStarted = False
        End Try
    End Sub

    Private Shared Sub PlayerWatcher(args As GameWatchArguments)
        Dim processes As Process() = Process.GetProcesses()
        Dim i = 0
        While Not _
        processes.Any(Function(p) p.ProcessName.ToLower().Contains(args.PlayerType.ToString().ToLower()) _
        OrElse Parameters.StreamStarted = False _
        OrElse i = 30)
            processes = Process.GetProcesses()
            Thread.Sleep(500)
            i += 1
        End While
        Parameters.SpnStreamingValue = Parameters.SpnStreamingMaxValue - 1
        Thread.Sleep(1000)
        Parameters.StreamStarted = False
    End Sub
End Class
