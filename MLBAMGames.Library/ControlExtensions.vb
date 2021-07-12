Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Public Module ControlExtensions
    <Extension()>
    Public Function GetPropertyThreadSafe(Of TControl As Control, TResult)(ByVal control As TControl, ByVal getter As Func(Of TControl, TResult)) As TResult
        If control.IsDisposed() Then Return CType(Nothing, TResult)
        If control.InvokeRequired Then
            Return CType(control.Invoke(getter, control), TResult)
        End If
        Return getter(control)
    End Function

    <Extension()>
    Public Sub SetPropertyThreadSafe(Of TControl As Control)(ByVal control As TControl, ByVal setter As MethodInvoker)
        SyncLock control
            If control.IsDisposed() Then Return
            If control.InvokeRequired Then
                control.Invoke(setter)
            Else
                setter()
            End If
        End SyncLock
    End Sub
End Module
