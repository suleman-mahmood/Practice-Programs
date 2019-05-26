Module Module1

    '//////////////////////////////////////////////////////////////////
    '//////////////////////////// IS PRIME ////////////////////////////
    '//////////////////////////////////////////////////////////////////
    ' This prgram takes a number and checks whether it is a prime 
    ' number or not.
    Sub Main()
        ' Declaring :
        ' x which is the number input
        ' prime which holds whether it is prime or not
        Dim x As Integer
        Dim prime As Boolean

        ' Initialising
        x = 0
        prime = False

        ' Prompting the user and taking input
        Console.WriteLine("Enter Number : ")
        x = Console.ReadLine

        ' Checking whether the number is prime by using our user-declared function
        prime = isPrime(x)

        ' Outputing based on our value of prime
        If prime = True Then
            Console.WriteLine(x & " is a prime number")
        ElseIf prime = False Then
            Console.WriteLine(x & " is not a prime number")
        End If

        Console.ReadKey()
    End Sub

    ' This function checks whether the number input to it is prime or not
    Function isPrime(ByVal n As Integer) As Boolean
        ' Declaring :
        ' i which is the counter
        ' flag which turns to false when the number is divisible by any other number
        Dim i As Integer
        Dim flag As Boolean

        ' making it true so that it remains true until and unless something alters it
        flag = True

        ' this is a basic check for some special numbers which will crash/malfunction our program
        ' NOTE : Return stops the function from continuing and halts it and returns the value it is returning
        If n = 1 Then
            Return False
        ElseIf n = 2 Then
            Return True
        End If

        ' we will be checking for divisibility from 2 to that (number - 1)
        ' if any number(counter) divides the number than the resulting mod
        ' will be 0 so if the mod is 0, we are changing the value of flag to false
        For i = 2 To n - 1
            If n Mod i = 0 Then
                flag = False
            End If
        Next

        'returning the value of the flag
        Return flag

    End Function

End Module
