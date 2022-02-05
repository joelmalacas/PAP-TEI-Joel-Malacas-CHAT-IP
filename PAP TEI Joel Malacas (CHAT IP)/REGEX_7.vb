Imports System.Text.RegularExpressions

Module REGEX_7

    Sub Main()
        Dim value As String = "xxyy"

        ' Match the start with a "^" char.
        If Regex.IsMatch(value, "^xx") Then
            Console.WriteLine("ISMATCH START")
        End If

        ' Match the end with a "$" char.
        If Regex.IsMatch(value, "yy$") Then
            Console.WriteLine("ISMATCH END")
        End If
    End Sub

End Module