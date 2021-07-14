Imports System.ComponentModel
Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Windows.Forms
Imports MLBAMGames.Library.API
Imports Newtonsoft.Json

Public Class Web
    Public Const UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/87.0.4280.88 Safari/537.36"
    Private Const s = "abcdefghijklmnopqrstuvwxyz0123456789"
    Private Shared r As New Random
    Const BYTES_IN_MEGABYTE = 1_000_000

    Shared WithEvents _wc As WebClient = New WebClient()

    Public Shared Function GetRandomString(intLength As Integer)
        Dim sb As New StringBuilder

        For i = 1 To intLength
            Dim idx As Integer = r.Next(0, 35)
            sb.Append(s.Substring(idx, 1))
        Next

        Return sb.ToString()
    End Function

    Public Shared Function SetHttpWebRequest(address As String) As HttpWebRequest
        Dim defaultHttpWebRequest = CType(WebRequest.Create(New Uri(address)), HttpWebRequest)
        defaultHttpWebRequest.UserAgent = UserAgent
        defaultHttpWebRequest.Method = WebRequestMethods.Http.Head
        defaultHttpWebRequest.Proxy = WebRequest.DefaultWebProxy
        defaultHttpWebRequest.CookieContainer = New CookieContainer()
        defaultHttpWebRequest.CookieContainer.Add(New Cookie("mediaAuth", GetRandomString(240), String.Empty, "nhl.com"))

        Return defaultHttpWebRequest
    End Function

    Public Shared Async Function SendWebRequestAsync(address As String, Optional httpWebRequest As HttpWebRequest = Nothing) As Task(Of Boolean)
        If address Is Nothing AndAlso httpWebRequest Is Nothing Then Return False

        Dim myHttpWebRequest As HttpWebRequest
        Dim result = False

        myHttpWebRequest = If(httpWebRequest, SetHttpWebRequest(address))

        Try
            Using _
                myHttpWebResponse As HttpWebResponse =
                    Await myHttpWebRequest.GetResponseAsync().ConfigureAwait(False)
                result = (myHttpWebResponse.StatusCode = HttpStatusCode.OK)
            End Using
        Catch
        End Try

        Return result
    End Function

    Public Shared Async Function SendWebRequestAndGetContentAsync(address As String, Optional httpWebRequest As HttpWebRequest = Nothing) As Task(Of String)
        Dim content = New MemoryStream()
        Dim myHttpWebRequest As HttpWebRequest

        myHttpWebRequest = If(httpWebRequest, SetHttpWebRequest(address))
        myHttpWebRequest.Method = WebRequestMethods.Http.Get

        Try
            Using myHttpWebResponse As HttpWebResponse = Await myHttpWebRequest.GetResponseAsync().ConfigureAwait(False)
                If myHttpWebResponse.StatusCode = HttpStatusCode.OK Then
                    Using reader As Stream = myHttpWebResponse.GetResponseStream()
                        reader.CopyTo(content)
                    End Using
                End If
            End Using
        Catch ex As Exception
            content.Dispose()
            Return String.Empty
        End Try

        Dim result = Encoding.UTF8.GetString(content.ToArray())
        content.Dispose()

        Return result
    End Function

    Public Shared Async Function CheckAppCanRun() As Task(Of String)
        Dim errorMessage = String.Empty

        If Environment.Version < New Version(4, 0, 30319, 0) Then
            errorMessage = "missingFramework"
        ElseIf Not Await SendWebRequestAsync("https://www.google.com") Then
            errorMessage = "noWebAccess"
        End If

        Await GitHubAPI.GetVersion()
        Await GitHubAPI.GetAccouncement()

        Dim hostName As String = Parameters.HostName
        Parameters.IsServerUp = If(Not hostName.Equals(String.Empty), Await SendWebRequestAsync($"http://{hostName}"), False)

        Return errorMessage
    End Function

    Public Shared Sub SetRedirectionServerInApp(Optional LogIt As Boolean = True)
        Parameters.HostName = Instance.Form.cbServers.SelectedItem.ToString()
        Instance.Form.SetSetting("SelectedServer", Parameters.HostName)
        If LogIt Then
            Console.WriteLine(
                "Status: Setting updated for '{0}' to '{1}'",
                Lang.RmText.GetString("lblHostname"),
                Parameters.HostName)
        End If
    End Sub

    Public Shared Async Function DownloadFileAsync(url As String, tag As String) As Task(Of String)
        Dim uri As Uri = New Uri(url)
        Console.WriteLine("Downloading update {0}...", tag)
        Dim fileName = Updater.ProjectDirectory + "update-" + tag + ".zip"
        Await _wc.DownloadFileTaskAsync(uri, fileName)
        Return fileName
    End Function

    Private Shared Sub WebClient_DownloadProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs) Handles _wc.DownloadProgressChanged
        SyncLock e.UserState
            Console.SetCursorPosition(0, Console.CursorTop - 1)
            Console.WriteLine("{0} % completed ({1} of {2} Mo.)",
                          e.ProgressPercentage,
                          ToMo(e.BytesReceived),
                          ToMo(e.TotalBytesToReceive))
        End SyncLock
    End Sub

    Private Shared Sub WebClient_DownloadFileCompleted(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs) Handles _wc.DownloadFileCompleted
        If e.Cancelled Then
            Console.WriteLine("File download cancelled.")
        End If

        If e.Error IsNot Nothing Then
            Console.WriteLine(e.Error.ToString())
        End If
    End Sub

    Private Shared Function ToMo(bytes As Long) As String
        Return Math.Round((bytes / BYTES_IN_MEGABYTE), 2).ToString("0.00")
    End Function
End Class
