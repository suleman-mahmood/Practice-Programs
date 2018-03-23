Module Module1

    Sub Main()
        Dim x, i, factorial As Integer
        factorial = 1

        x = Console.ReadLine

        For i = 1 To x
            factorial = factorial * i
        Next

        Console.WriteLine("The factorial of " & x & " is :- " & factorial)

        Console.ReadKey()
    End Sub

End Module
