Module Module1
    ' Q) Check whether a given string is entirely made up of Only I,O,S,H,Z,X,N
    Sub Main()
        Dim input As String
        Dim check As Char
        Dim isValid = True

        input = Console.ReadLine

        For i = 1 To Len(input) And isValid
            check = input(i - 1)
            If checkValidity(check) Then
                isValid = True
            Else
                isValid = False
            End If
        Next

        If isValid = False Then
            Console.WriteLine("NO")
        ElseIf isValid = True Then
            Console.WriteLine("YES")
        End If
        Console.ReadKey()
    End Sub

    Function checkValidity(ByVal check As Char) As Boolean
        If check = "I" Or check = "O" Or check = "S" Or check = "H" Or check = "Z" Or check = "X" Or check = "N" Then
            Return True
        Else
            Return False
        End If
    End Function

End Module
