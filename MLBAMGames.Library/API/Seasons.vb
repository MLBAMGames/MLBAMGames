Namespace API
    Public Class Seasons
        Public Property seasons As List(Of Season)

        Public Shared CurrentSeason As Season

        Public Shared Function GetAllNHLSeasons() As List(Of Season)
            Dim seasons As Seasons = DataAccessLayer.ExecuteAPICall(Of Seasons)(NHLAPIServiceURLs.seasons)

            seasons.seasons.Reverse()

            CurrentSeason = seasons.seasons.First()

            Return seasons.seasons
        End Function

        Public Shared Function GetAllMLBSeasons() As List(Of Season)
            Dim seasons As Seasons = DataAccessLayer.ExecuteAPICall(Of Seasons)(MLBAPIServiceURLs.seasons)

            seasons.seasons.Reverse()

            CurrentSeason = seasons.seasons.First()

            Return seasons.seasons
        End Function
    End Class
End Namespace

