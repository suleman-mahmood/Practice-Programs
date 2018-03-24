Module Module1

    Sub Main()
        'Declaring :
        'x which is to be input from user for which the factorial is calculated
        Dim x As Integer

        'Prompting the user and taking input
        Console.Write("Enter the Number for which you want to calculate the factorial : ")
        x = Console.ReadLine

        'outputing the result to the screen
        Console.WriteLine("The factorial of " & x & " is :- " & Factorial(x))

        Console.ReadKey()
    End Sub

    'This is the funtion to calculate and return the factorial of the number passed to it
    Function Factorial(ByVal n As Integer) As Integer

        'Declaring :
        'i is the counter
        'factorial holds the result
        Dim fact, i As Integer

        'initialising the factorial to 1 as it cannot be zero
        fact = 1

        'Calculating factorial (using backward approach eg 5! = 1*2*3*4*5 is same as 5*4*3*2*1)
        For i = 1 To n
            fact = fact * i
        Next

        Return fact

    End Function

End Module
