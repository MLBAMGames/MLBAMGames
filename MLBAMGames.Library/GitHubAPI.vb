﻿Imports System.Net
Imports System.Reflection
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports MLBAMGames.Library.GitHub
Imports Newtonsoft.Json

Public Class GitHubAPI

    Private Shared ReadOnly Property _regexVersion As Regex = New Regex($"(\d+\.)(\d+\.)?(\d+\.)?(\*|\d+)")
    Private Shared ReadOnly Property _regexTag As Regex = New Regex($"[^0-9.]")
    Private Shared ReadOnly Property _project As String = Assembly.GetCallingAssembly().GetName().Name
    Private Shared ReadOnly Property _repoLink As String = $"https://api.github.com/repos/MLBAMGames/{_project}"

    Public Shared Async Function GetVersion() As Task
        Dim request = GetGitHubApiRequest($"{_repoLink}/releases/latest")

        If request Is Nothing Then Return

        Dim content = Await Web.SendWebRequestAndGetContentAsync(Nothing, request)
        Dim release = JsonConvert.DeserializeObject(Of Release)(content)

        If release Is Nothing Then Return

        Dim versionTag = ParseTagToVersionString(release.tag_name)

        If Not _regexVersion.IsMatch(versionTag) Then Return

        Dim gitHubTagVersion = New Version(versionTag)
        Dim assemblyVersion = Assembly.GetExecutingAssembly().GetName().Version

        If gitHubTagVersion <= assemblyVersion Then Return

        Instance.Form.lnkRelease.Text = String.Format(Lang.RmText.GetString("lnkNewVersionText"), gitHubTagVersion)
        Instance.Form.lnkRelease.Visible = True
        Instance.Form.lblTip.Visible = False

        If GetLastBuildVersionSkipped() = gitHubTagVersion Then Return

        Dim changelog = BuildChangeLog(release.body)

        Dim dialogTitle = String.Format(Lang.RmText.GetString("msgNewVersionAvailable"), gitHubTagVersion)
        Dim dialogMessage = If(String.IsNullOrEmpty(changelog),
                Lang.RmText.GetString("msgChangeLogNone"),
                String.Format(Lang.RmText.GetString("msgChangeLog"), vbCrLf, changelog))
        Dim dialogResult = Instance.Form.MsgBox(
                dialogMessage,
                dialogTitle,
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information)

        If dialogResult = DialogResult.OK Then
            Update()
        End If

        Instance.Form.SetSetting("LastBuildVersionSkipped", gitHubTagVersion.ToString())
    End Function

    Public Shared Async Function GetAccouncement() As Task
        Dim request = GetGitHubApiRequest($"{_repoLink}/issues?state=open&labels=announcement")

        If request Is Nothing Then Return

        Dim content = Await Web.SendWebRequestAndGetContentAsync(Nothing, request)
        Dim issues = JsonConvert.DeserializeObject(Of Issue())(content)

        If issues Is Nothing OrElse issues.Count = 0 Then Return
        Dim issue = issues.First()

        If String.IsNullOrWhiteSpace(issue.title) OrElse String.IsNullOrWhiteSpace(issue.body) Then Return

        Dim issueBodySplitted = issue.body.Split(New Char() {"\r\n", "\r", "\n"})
        Dim dialogMessage = issueBodySplitted.Take(5).Aggregate(Function(c, n) $"{c}\n{n}")

        Dim dialogResult = Instance.Form.MsgBox(
                dialogMessage,
                Lang.RmText.GetString("msgAnnouncement"),
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)
    End Function

    Private Shared Function GetGitHubApiRequest(url As String) As HttpWebRequest
        Dim uriGitHub = Nothing

        If Not Uri.TryCreate(url, UriKind.Absolute, result:=uriGitHub) Then Return Nothing

        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
        Dim request = CType(WebRequest.Create(uriGitHub), HttpWebRequest)
        request.Method = WebRequestMethods.Http.Get
        request.UserAgent = "NHLGames"

        Return request
    End Function

    Private Shared Function GetLastBuildVersionSkipped() As Version
        Dim lastBuildVersionSkipped = Instance.Form.GetSetting("LastBuildVersionSkipped")
        If Not _regexVersion.IsMatch(lastBuildVersionSkipped) Then Return Nothing

        Return New Version(lastBuildVersionSkipped)
    End Function

    Private Shared Function ParseTagToVersionString(tag As String) As String
        Return If(String.IsNullOrEmpty(tag), String.Empty, _regexTag.Replace(tag, String.Empty))
    End Function

    Public Shared Sub Update()
        Process.Start(New ProcessStartInfo(Application.StartupPath + "/Updater/Updater.exe"))
        Application.Exit()
    End Sub

    Private Shared Function BuildChangeLog(body As String) As String
        If String.IsNullOrWhiteSpace(body) Then Return String.Empty

        Dim releaseBodySplitted = body.Split(New Char() {vbCrLf, vbCr, vbLf})
        If Not releaseBodySplitted.Any() Then Return String.Empty

        Dim filteredBodySplitted = releaseBodySplitted.Where(Function(x) Not String.IsNullOrWhiteSpace(x) AndAlso (x.StartsWith("- ") OrElse x.StartsWith("#")))
        If Not filteredBodySplitted.Any() Then Return String.Empty

        Dim skipLeftOfChangeLog = filteredBodySplitted.SkipWhile(Function(x) Not x.Replace(" ", String.Empty).ToUpperInvariant().Contains("CHANGELOG"))
        If skipLeftOfChangeLog.Count() <= 1 Then Return String.Empty
        skipLeftOfChangeLog = skipLeftOfChangeLog.Skip(1)

        Dim skipRightOfChangeLog = skipLeftOfChangeLog.TakeWhile(Function(x) x.StartsWith("- "))
        If Not skipRightOfChangeLog.Any() Then
            skipRightOfChangeLog = skipLeftOfChangeLog
        End If

        Return skipRightOfChangeLog.Take(5).Aggregate(Function(c, n) $"{c}{vbCrLf}{n}")
    End Function

End Class
