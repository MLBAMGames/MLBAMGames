Public Class GameStream
    Implements IDisposable
    Private _disposedValue As Boolean
    Public Property Type As StreamTypeEnum = StreamerTypeEnum.None
    Public Property Game As Game = Nothing
    Public Property Network As String = String.Empty
    Public Property PlayBackId As String = String.Empty
    Public Property GameUrl As String = String.Empty
    Public Property CdnParameter As CdnTypeEnum = CdnTypeEnum.Akc
    Public Property Title As String = String.Empty
    Public Property StreamUrl As String = String.Empty
    Public Property StreamTypeSelected As String = String.Empty

    Public ReadOnly Property IsBroken As Boolean
        Get
            Return StreamUrl.Equals(String.Empty)
        End Get
    End Property

    Public Sub New()
    End Sub

    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not _disposedValue Then
            If disposing Then
                Game.Dispose()
            End If
        End If
        _disposedValue = True
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub

    Protected Overrides Sub Finalize()
        Dispose(False)
    End Sub
End Class

