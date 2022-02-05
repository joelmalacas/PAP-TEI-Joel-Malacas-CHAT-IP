Imports System.Text
Imports System.Text.RegularExpressions
Public Class Validar

    ''' <param name="email">email para validar</param>
    ''' <returns>true é valido , false é inválido</returns>
    Public Shared Function IsValidEmail(ByVal email As String) As Boolean
        Dim padraoRegex As String = "^[-a-zA-Z0-9][-.a-zA-Z0-9]*@[-.a-zA-Z0-9]+(\.[-.a-zA-Z0-9]+)*\." &
        "(com|edu|info|gov|int|mil|net|org|biz|name|museum|coop|aero|pro|tv|[a-zA-Z]{2})$"
        Dim verifica As New RegularExpressions.Regex(padraoRegex, RegexOptions.IgnorePatternWhitespace)
        'boolean variable to return to calling method
        Dim valida As Boolean = False
        'verifica se foi informado um email
        If String.IsNullOrEmpty(email) Then
            valida = False
        Else
            'usar IsMatch para validar o email
            valida = verifica.IsMatch(email)
        End If
        'retorna o valor
        Return valida
    End Function
End Class
