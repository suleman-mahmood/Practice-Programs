Module Module1

    Sub Main()
        'Declaring :
        'x which is to be input from user for which the factorial is calculated
        'i is the counter
        'factorial holds the result
        Dim x, i, factorial As Integer

        'initialising the factorial to 1 as it cannot be zero
        factorial = 1

        'Prompting the user and taking input
        Console.Write("Enter the Number for which you want to calculate the factorial : ")
        x = Console.ReadLine

        'Calculating factorial (using backward approach eg 5! = 1*2*3*4*5 is same as 5*4*3*2*1)
        For i = 1 To x
            factorial = factorial * i
        Next

        'outputing the result to the screen
        Console.WriteLine("The factorial of " & x & " is :- " & factorial)

        Console.ReadKey()
    End Sub

End Module
