Public Class SettingsExtensions
    Public Shared Function ReadGameWatchArgsParams(Optional defaultReturnValue As Object = Nothing) As GameWatchArgumentsParameters
        Dim args As Object = Instance.Form.GetSetting("DefaultWatchArgsParams")

        If String.IsNullOrEmpty(args) OrElse IsNothing(args) Then Return defaultReturnValue

        If TypeOf args Is GameWatchArgumentsParameters Then
            args = DirectCast(args, GameWatchArgumentsParameters)
            Return args
        End If

        Try
            Return Serialization.DeserializeObject(Of GameWatchArgumentsParameters)(args)
        Catch ex As Exception
            Console.WriteLine("Error : Failed to deserialize setting value of '{0}' to type '{1}'", Instance.Form.GetSetting("DefaultWatchArgsParams"), NameOf(GameWatchArguments))
            Return defaultReturnValue
        End Try
    End Function

    Public Shared Function ReadAdDetectionConfigs(Optional defaultReturnValue As Object = Nothing) As AdDetectionConfigs
        Dim configs As Object = Instance.Form.GetSetting("AdDetection")

        If String.IsNullOrEmpty(configs) OrElse IsNothing(configs) Then Return defaultReturnValue

        If TypeOf configs Is AdDetectionConfigs Then
            configs = DirectCast(configs, AdDetectionConfigs)
            Return configs
        End If

        Try
            Return Serialization.DeserializeObject(Of AdDetectionConfigs)(configs)
        Catch ex As Exception
            Console.WriteLine("Error : Failed to deserialize setting value of '{0}' to type '{1}'", Instance.Form.GetSetting("AdDetection"), NameOf(AdDetectionConfigs))
            Return defaultReturnValue
        End Try
    End Function
End Class
