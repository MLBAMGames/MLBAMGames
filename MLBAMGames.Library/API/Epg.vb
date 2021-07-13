
Namespace API
    Public Class Epg
        Public Const AUDIO As String = "Audio"
        Public Const EXTHIGHLIGHTS As String = "Extended Highlights"
        Public Const POWERPLAY As String = "Power Play"

        Public Property title As String
        Public Property platform As String
        Public Property items As List(Of Item)
        Public Property topicList As String

        Public ReadOnly Property numberOfFeeds As Integer
            Get
                Return If(
                    {EPGMediaEnum.NHLTV.ToString(), EPGMediaEnum.MLBTV.ToString()}.Contains(title),
                    items.Count(),
                    0)
            End Get
        End Property

        Public ReadOnly Property numberOfRecapFeeds As Integer
            Get
                Return If(title = EPGMediaEnum.Recap.ToString(), items.Count(), 0)
            End Get
        End Property
    End Class
End Namespace