Imports System.Text.RegularExpressions

Module REGEX_4

    ''' <summary>
    ''' Member field regular expression.
    ''' </summary>
    Private _reg As Regex = New Regex("content/([A-Za-z0-9\-]+)\.aspx$",
                                      RegexOptions.IgnoreCase)

    Sub Main()
        ' The input string.
        Dim value As String = "/content/alternate-1.aspx"

        ' Invoke the Match method.
        ' ... Use the regex field.
        Dim m As Match = _reg.Match(value)

        ' If successful, write the group.
        If (m.Success) Then
            Dim key As String = m.Groups(1).Value
            Console.WriteLine(key)
        End If
    End Sub

End Module
