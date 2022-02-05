Imports System.Text.RegularExpressions

Module REGEX_5

    Sub Main()
        ' Get first match.
        Dim match As Match = Regex.Match("4 and 5", "\d")

        If match.Success Then
            Console.WriteLine(match.Value)
        End If

        ' Get next match.
        match = match.NextMatch()

        If match.Success Then
            Console.WriteLine(match.Value)
        End If
    End Sub

End Module

