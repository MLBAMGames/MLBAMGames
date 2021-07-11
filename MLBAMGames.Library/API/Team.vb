﻿
Imports MLBAMGames.Library.Standings

Namespace API
    Public Class Team
        Public Property id As Integer
        Public Property name As String
        Public Property link As String
        Public Property venue As Venue
        Public Property abbreviation As String
        Public Property teamName As String
        Public Property locationName As String
        Public Property firstYearOfPlay As String
        Public Property division As Division
        Public Property conference As Conference
        Public Property franchise As Franchise
        Public Property shortName As String
        Public Property officialSiteUrl As String
        Public Property franchiseId As Integer
        Public Property active As Boolean

        Public Shared Property TeamAbbreviation As Dictionary(Of String, String) = New Dictionary(Of String, String)
    End Class

    Public Class TeamRootobject
        Public Property teams As List(Of Team)

        Public Shared Function GetTeamRootobject() As TeamRootobject
            Return DataAccessLayer.ExecuteAPICall(Of TeamRootobject)(NHLAPIServiceURLs.teams)
        End Function
    End Class
End Namespace