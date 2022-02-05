Imports System.Text.RegularExpressions

Module REGEX_6
    Function IsValid(ByRef value As String) As Boolean
        Return Regex.IsMatch(value, "^[a-zA-Z0-9]*$")
    End Function

    Sub Main()
        Console.WriteLine(IsValid("dotnetperls0123"))
        Console.WriteLine(IsValid("DotNetPerls"))
        Console.WriteLine(IsValid(":-)"))
    End Sub
End Module