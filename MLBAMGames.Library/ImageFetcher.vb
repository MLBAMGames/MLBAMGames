Imports System.Drawing
Imports System.IO
Imports System.Reflection
Imports Svg

Public Class ImageFetcher
    Public Shared Function GetEmbeddedImage(fileName As String) As Image
        Dim image As Image = Nothing
        Dim assembly As Assembly = Assembly.GetCallingAssembly()
        Using s As Stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{fileName.ToLower()}.png")
            If s Is Nothing Then Return Nothing
            s.Position = 0
            image = Image.FromStream(s)
        End Using
        Return image
    End Function

    ' to test svg images in app (dev)
    Private Shared Function GetEmbeddedImageSvg(fileName As String) As Bitmap
#If DEBUG Then
        Dim image As Bitmap = Nothing
        Dim assembly As Assembly = Assembly.GetCallingAssembly()
        Using s As Stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{fileName.ToLower()}.svg")
            If s Is Nothing Then Return Nothing
            s.Position = 0
            image = (SvgDocument.Open(Of SvgDocument)(s)).Draw()
        End Using
        Return image
#End If
    End Function

    ' to recreate all png images in output (dev)
    Public Shared Sub ImagesPngFromSvg()
#If DEBUG Then
        Dim assembly As Assembly = Assembly.GetCallingAssembly()
        Dim files = Directory.GetFiles("D:\dev\MLBAMGames\svg\teams\nhl")

        If Not Directory.Exists("c:/output") Then Directory.CreateDirectory("c:/output")

        For Each f In files
            Using s As Stream = File.OpenRead(f)
                If s IsNot Nothing Then
                    s.Position = 0
                    Dim d = (SvgDocument.Open(Of SvgDocument)(s))
                    ' height/width works with svg viewBox property: MLB svgs
                    'd.Width = 64
                    'd.Height = 64
                    Dim x = d.Draw()
                    x.Save($"c:/output/{Path.GetFileName(f).Replace(".svg", ".png")}")
                    'x.Save($"D:\dev\MLBAMGames\MLBGames\Resources\{Path.GetFileName(f).Replace(".svg", ".png")}")
                End If
            End Using
        Next
#End If
    End Sub
End Class
