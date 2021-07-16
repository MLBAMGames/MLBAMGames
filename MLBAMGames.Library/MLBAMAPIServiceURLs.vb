Imports System
Imports System.Collections.Generic
Imports System.Text

Public Class NHLAPIServiceURLs
    Public Shared Property scheduleGames As String = "http://statsapi.web.nhl.com/api/v1/schedule?startDate={0}&endDate={0}&expand=schedule.teams,schedule.linescore,schedule.game.seriesSummary,schedule.game.content.media.epg"

    Public Shared Property playoffsTree As String = "https://statsapi.web.nhl.com/api/v1/tournaments/playoffs?expand=round.series,schedule.game.seriesSummary&season={0}"

    Public Shared Property leagueStandings As String = "https://statsapi.web.nhl.com/api/v1/standings/byLeague?season={0}&expand=standings.record"
    Public Shared Property conferenceStandings As String = "https://statsapi.web.nhl.com/api/v1/standings/byConference?season={0}&expand=standings.record"
    Public Shared Property divisionStandings As String = "https://statsapi.web.nhl.com/api/v1/standings/byDivision?season={0}&expand=standings.record"
    Public Shared Property wildCardStandings As String = "https://statsapi.web.nhl.com/api/v1/standings/wildCard?season={0}&expand=standings.record"

    Public Shared Property seasons As String = "https://statsapi.web.nhl.com/api/v1/seasons"
    Public Shared Property teams As String = "https://statsapi.web.nhl.com/api/v1/teams/"
End Class

Public Class MLBAPIServiceURLs
    Public Shared Property scheduleGames As String = "http://statsapi.mlb.com/api/v1/schedule?sportId=1&date={0}&hydrate=team,linescore,game(content(summary,media(epg)))&language=en"

    Public Shared Property leagueStandings As String = "https://statsapi.mlb.com/api/v1/standings?leagueId=103,104&season=2017&standingsTypes=regularSeason&hydrate=division,conference,sport,league,team"
    'Public Shared conferenceStandings As String = "https://statsapi.mlb.com/api/v1/standings/byConference?season={0}&expand=standings.record"
    'Public Shared divisionStandings As String = "https://statsapi.mlb.com/api/v1/standings/byDivision?season={0}&expand=standings.record"
    'Public Shared wildCardStandings As String = "https://statsapi.mlb.com/api/v1/standings/wildCard?season={0}&expand=standings.record"

    Public Shared Property seasons As String = "https://statsapi.mlb.com/api/v1/seasons?sportId=1"
    'Public Shared teams As String = "https://statsapi.mlb.com/api/v1/teams?sportId=1"
End Class