Imports System.Text.RegularExpressions

Module REGEX_8
    Dim _regex As Regex = New Regex("X.+0", RegexOptions.Compiled)

    Sub Version1()
        ' Use compiled regular expression stored as field.
        If _regex.IsMatch("X12340") = False Then
            Throw New Exception
        End If
    End Sub

    Sub Version2()
        ' Do not use compiled Regex.
        If Regex.IsMatch("X12340", "X.+0") = False Then
            Throw New Exception
        End If
    End Sub

    Sub Main()
        Dim m As Integer = 100000
        Dim s1 As Stopwatch = Stopwatch.StartNew

        ' Version 1: use RegexOptions.Compiled.
        For i As Integer = 0 To m - 1
            Version1()
        Next
        s1.Stop()

        Dim s2 As Stopwatch = Stopwatch.StartNew

        ' Version 2: do not compile the Regex.
        For i As Integer = 0 To m - 1
            Version2()
        Next
        s2.Stop()

        Dim u As Integer = 1000000
        Console.WriteLine(((s1.Elapsed.TotalMilliseconds * u) / m).ToString("0.00 ns"))
        Console.WriteLine(((s2.Elapsed.TotalMilliseconds * u) / m).ToString("0.00 ns"))
    End Sub
End Module
