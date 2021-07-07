﻿
Imports System.Net
Imports System.Reflection
Imports System.Text.RegularExpressions
Imports Newtonsoft.Json
Imports MLBAMGames.Library.Objects.GitHub

Namespace Utilities

    Public Class GitHub

        Public Const API_LATEST_RELEASES_LINK As String = "https://api.github.com/repos/NHLGames/NHLGames/releases"
        Public Const LATEST_RELEASE_LINK As String = "https://github.com/NHLGames/NHLGames/releases/latest"

        Public Shared Async Function GetReleases() As Task(Of Release())
            Dim request = Web.SetHttpWebRequest(API_LATEST_RELEASES_LINK)

            Console.WriteLine("Getting missing releases...")

            Dim content = Await Web.SendWebRequestAndGetContentAsync(Nothing, request)
            Dim releases = JsonConvert.DeserializeObject(Of Release())(content)

            If releases Is Nothing Then
                Console.WriteLine("Releases were not found.")
                Return Nothing
            End If

            Dim relatedReleases = releases.Reverse().Where(Function(r) AssemblyInfo.IsNewerVersionThanCurrent(r.tag_name)).ToArray()

            If Not relatedReleases.Any() Then
                Console.WriteLine("You are already using the latest version.")
                Updater.LeaveConsole()
            End If

            Return relatedReleases
        End Function

        Public Shared Function GetZipAssetFromRelease(release As Release) As Asset
            Dim asset = release.assets.Where(Function(a) Regex.IsMatch(a.name, "^NHLGames(-|\.)(v?)(\.)?\d+(\.\d+)?(\.\d+)?(-simplified)?.zip$")).FirstOrDefault()
            If asset Is Nothing Then
                Console.WriteLine("This Release did not have any suitable asset to download. Try again later.")
                Throw New ReleaseAssetNotFoundException()
            Else
                Console.WriteLine("Release asset found: {0}", asset.name)
            End If
            Return asset
        End Function

    End Class

End Namespace
