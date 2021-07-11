
Namespace API
    Public Class [Date]
        Public Property [date] As String
        Public Property totalItems As Integer
        Public Property totalEvents As Integer
        Public Property totalGames As Integer
        Public Property totalMatches As Integer
        Public Property games As List(Of Game)
        Public Property events As List(Of Object)
        Public Property matches As List(Of Object)

        Public ReadOnly Property numberOfFeeds As Integer
            Get
                Return games.Sum(Function(x) x.numberOfFeeds)
            End Get
        End Property

        Public ReadOnly Property numberOfRecapFeeds As Integer
            Get
                Return games.Sum(Function(x) x.numberOfRecapFeeds)
            End Get
        End Property
    End Class
End Namespace