
Namespace API
    Public Class Media
        Public Property epg As List(Of Epg)

        Public ReadOnly Property numberOfFeeds As Integer
            Get
                Return If(epg IsNot Nothing, epg?.Sum(Function(x) x.numberOfFeeds), 0)
            End Get
        End Property

        Public ReadOnly Property numberOfRecapFeeds As Integer
            Get
                Return If(epg IsNot Nothing, epg?.Sum(Function(x) x.numberOfRecapFeeds), 0)
            End Get
        End Property
    End Class
End Namespace