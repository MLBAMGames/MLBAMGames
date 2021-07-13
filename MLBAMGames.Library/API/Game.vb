
Namespace API
    Public Class Game
        Public Property gamePk As Integer
        Public Property link As String
        Public Property gameType As String
        Public Property season As String
        Public Property gameDate As DateTime
        Public Property status As Status
        Public Property teams As Teams
        Public Property linescore As Linescore
        Public Property venue As Venue
        Public Property content As Content
        Public Property seriesSummary As SeriesSummary

        Public ReadOnly Property isValidSeriesGame As Boolean
            Get
                Dim hasGameNumber = seriesSummary?.gameNumber IsNot Nothing
                Dim hasStatus = seriesSummary?.seriesStatusShort IsNot Nothing
                Return hasGameNumber And hasStatus
            End Get
        End Property

        Public ReadOnly Property numberOfFeeds As Integer
            Get
                Return If (content?.media IsNot Nothing, content.media.numberOfFeeds, 0)
            End Get
        End Property

        Public ReadOnly Property EventFeeds As List(Of Item)
            Get
                Return GetEventFeeds()
            End Get
        End Property

        Public ReadOnly Property numberOfRecapFeeds As Integer
            Get
                Return If(content?.media IsNot Nothing, content.media.numberOfRecapFeeds, 0)
            End Get
        End Property

        Public ReadOnly Property numberOfNHLTVFeedsWithRecap As Integer
            Get
                Dim streams = numberOfRecapFeeds + numberOfFeeds
                Return If(streams > 0, numberOfFeeds + 1, numberOfFeeds)
            End Get
        End Property

        Public ReadOnly Property RecapFeeds As List(Of Item)
            Get
                Return GetRecapFeeds()
            End Get
        End Property

        Private Function GetEventFeeds() As List(Of Item)
            Return GetFeeds(EPGMediaEnum.NHLTV, EPGMediaEnum.MLBTV)
        End Function

        Private Function GetRecapFeeds() As List(Of Item)
            Return GetFeeds(EPGMediaEnum.Recap)
        End Function

        Private Function GetFeeds(ByVal ParamArray types() As EPGMediaEnum) As List(Of Item)
            Dim [default] = New List(Of Item)
            If content?.media?.epg IsNot Nothing Then
                Return If(content.media.epg.Find(Function(x) types.Any(Function(t) t.ToString() = x.title))?.items, [default])
            End If
            Return [default]
        End Function
    End Class
End Namespace