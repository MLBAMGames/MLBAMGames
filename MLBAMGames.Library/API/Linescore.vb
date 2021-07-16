
Namespace API
    Public Class Linescore
        Public Property currentPeriod As Integer
        Public Property currentPeriodOrdinal As String
        Public Property currentPeriodTimeRemaining As String
        Public Property periods As List(Of Period)
        Public Property shootoutInfo As Teams
        Public Property teams As Teams
        Public Property powerPlayStrength As String
        Public Property hasShootout As Boolean
        Public Property intermissionInfo As IntermissionInfo
        Public Property powerPlayInfo As PowerPlayInfo

        Public Property currentInning As Integer
        Public Property currentInningOrdinal As String
        Public Property scheduledInnings As Integer
        Public Property inningState As String
        Public Property inningHalf As String
        Public Property isTopInning As Boolean
    End Class
End Namespace