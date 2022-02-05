Imports System.Text.RegularExpressions

Module REGEX_3

    Sub Main()
        ' The input string.
        Dim value As String = "/content/alternate-1.aspx"

        ' Invoke the Match method.
        Dim m As Match = Regex.Match(value,
                                     "content/([A-Za-z0-9\-]+)\.aspx$",
                                     RegexOptions.IgnoreCase)

        ' If successful, write the group.
        If (m.Success) Then
            Dim key As String = m.Groups(1).Value
            Console.WriteLine(key)
        End If
    End Sub

End Module