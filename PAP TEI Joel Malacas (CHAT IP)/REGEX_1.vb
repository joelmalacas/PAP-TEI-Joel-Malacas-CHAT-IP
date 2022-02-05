Imports System.Text.RegularExpressions

Module REGEX_1
    Sub Main()
        ' Step 1: create Regex.
        Dim regex As Regex = New Regex("\w+")

        ' Step 2: call Match on Regex.
        Dim match As Match = regex.Match(" do?")

        ' Step 3: test the Success bool.
        ' ... If we have Success, write the Value.
        If match.Success Then
            Console.WriteLine("RESULT: [{0}]", match.Value)
        End If
    End Sub
End Module
