Imports System.Globalization
Imports System.Runtime.CompilerServices

Public Module DateExtensions
    Public Function NewDateToPacificTime() As DateTime
        Return _
            TimeZoneInfo.ConvertTime(DateTime.Now(), TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time"))
    End Function

    <Extension()>
    Public Function ToPacificTime(ByVal utcDate As DateTime) As DateTime
        Return TimeZoneInfo.ConvertTime(utcDate, TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time"))
    End Function

    <Extension()>
    Public Function ToFormattedDate(ByVal dt As Date) As String
        Return String.Format(Lang.RmText.GetString("lblFormatWeekMonthDayYear"), dt.ToString("ddd"),
                             dt.ToString("MMM"), dt.Day.ToString, dt.Year.ToString)
    End Function

    Public Function GetFormattedWeek(ByVal number As DayOfWeek) As String
        Return If(CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(number).Length >= 2,
                  CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(number).Substring(0, 2),
                  CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(number).ToString())
    End Function

End Module
