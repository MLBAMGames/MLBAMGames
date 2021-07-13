﻿Imports System.IO

Public Class FileAccess
    Public Shared Function IsFileReadonly(path As String) As Boolean
        Dim attributes As FileAttributes = File.GetAttributes(path)
        Return (attributes And FileAttributes.[ReadOnly]) = FileAttributes.[ReadOnly]
    End Function

    Public Shared Sub RemoveReadOnly(path As String)
        Dim attributes As FileAttributes = File.GetAttributes(path)

        If (attributes And FileAttributes.[ReadOnly]) = FileAttributes.[ReadOnly] Then
            ' Make the file RW
            attributes = RemoveAttribute(attributes, FileAttributes.[ReadOnly])
            File.SetAttributes(path, attributes)
            Console.WriteLine("Status: The {0} file is no longer Read Only", path)
        End If
    End Sub

    Public Shared Sub AddReadonly(path As String)
        File.SetAttributes(path, File.GetAttributes(path) Or FileAttributes.ReadOnly)
        Console.WriteLine("The {0} file is now set back to Read Only", path)
    End Sub

    Private Shared Function RemoveAttribute(attributes As FileAttributes, attributesToRemove As FileAttributes) _
        As FileAttributes
        Return attributes And Not attributesToRemove
    End Function

    Public Shared Function HasAccess(filePath As String, Optional writeAccess As Boolean = True) As Boolean
        Try
            If writeAccess Then
                Using File.Open(filePath & ".bak", FileMode.OpenOrCreate, IO.FileAccess.ReadWrite, FileShare.None)
                End Using
            End If

            Using File.Open(filePath, FileMode.OpenOrCreate, IO.FileAccess.ReadWrite, FileShare.None)
            End Using

            Return True
        Catch ex As Exception
            Console.WriteLine("Error: Checking access to path: {0}", ex.Message)
            Return False
        End Try
    End Function
End Class
