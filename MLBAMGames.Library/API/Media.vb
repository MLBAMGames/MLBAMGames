
Namespace API
    Public Class Media
        Public Property epg As List(Of Epg)

        Public ReadOnly Property numberOfFeeds As Integer
            Get
                Return epg.Sum(Function(x) x.numberOfFeeds)
            End Get
        End Property

        Public ReadOnly Property numberOfRecapFeeds As Integer
            Get
                Return epg.Sum(Function(x) x.numberOfRecapFeeds)
            End Get
        End Property
    End Class
End Namespace