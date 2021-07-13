Imports System
Imports System.Collections.Generic
Imports System.Text

Public Class NHLAPIServiceURLs
    Public Shared scheduleGames As String = "http://statsapi.web.nhl.com/api/v1/schedule?startDate={0}&endDate={1}&expand=schedule.teams,schedule.linescore,schedule.game.seriesSummary,schedule.game.content.media.epg"

    Public Shared playoffsTree As String = "https://statsapi.web.nhl.com/api/v1/tournaments/playoffs?expand=round.series,schedule.game.seriesSummary&season={0}"

    Public Shared leagueStandings As String = "https://statsapi.web.nhl.com/api/v1/standings/byLeague?season={0}&expand=standings.record"
    Public Shared conferenceStandings As String = "https://statsapi.web.nhl.com/api/v1/standings/byConference?season={0}&expand=standings.record"
    Public Shared divisionStandings As String = "https://statsapi.web.nhl.com/api/v1/standings/byDivision?season={0}&expand=standings.record"
    Public Shared wildCardStandings As String = "https://statsapi.web.nhl.com/api/v1/standings/wildCard?season={0}&expand=standings.record"

    Public Shared seasons As String = "https://statsapi.web.nhl.com/api/v1/seasons"
    Public Shared teams As String = "https://statsapi.web.nhl.com/api/v1/teams/"
End Class

Public Class MLBAPIServiceURLs
    Public Shared scheduleGames As String = "http://statsapi.mlb.com/api/v1/schedule?sportId=1&date={0}&hydrate=team,linescore,game(content(summary,media(epg))"

    'Public Shared leagueStandings As String = "https://statsapi.mlb.com/api/v1/standings/byLeague?season={0}&expand=standings.record"
    'Public Shared conferenceStandings As String = "https://statsapi.mlb.com/api/v1/standings/byConference?season={0}&expand=standings.record"
    'Public Shared divisionStandings As String = "https://statsapi.mlb.com/api/v1/standings/byDivision?season={0}&expand=standings.record"
    'Public Shared wildCardStandings As String = "https://statsapi.mlb.com/api/v1/standings/wildCard?season={0}&expand=standings.record"

    'Public Shared seasons As String = "https://statsapi.mlb.com/api/v1/seasons"
    'Public Shared teams As String = "https://statsapi.mlb.com/api/v1/teams/"
End Class