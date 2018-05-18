Module Module1

    Sub Main()
        'A class for generating random numbers
        Dim randomnNumber As Random
        'number_1 contains random number between 1 and 100 
        'number_2 contains random number between 101 and 200
        Dim number_1, number_2 As Integer
        'toss decides which number to display 
        Dim toss As Integer

        'Generating random numbers
        randomnNumber = New Random
        number_1 = randomnNumber.Next() Mod 100 + 1
        number_2 = randomnNumber.Next() Mod 100 + 101
        toss = randomnNumber.Next() Mod 10 + 1

        If toss >= 1 And toss <= 7 Then
            Console.WriteLine("A random number between 1 and 200 given that probability of 1 and 100 is 70% : " & number_1)
        Else
            Console.WriteLine("A random number between 1 and 200 given that probability of 1 and 100 is 70% : " & number_2)
        End If
        Console.WriteLine()

        Call frequency(randomnNumber)

        Console.ReadKey()
    End Sub

    Sub frequency(ByVal randomNum As Random)
        Dim num_1, num_2, toss As Integer
        Dim freq_1, freq_2 As Integer
        Dim percent_1, percent_2 As Integer

        freq_1 = 0 : freq_2 = 0

        For i = 1 To 500
            num_1 = randomNum.Next() Mod 100 + 1
            num_2 = randomNum.Next() Mod 100 + 101
            toss = randomNum.Next() Mod 10 + 1

            If toss >= 1 And toss <= 7 Then
                freq_1 = freq_1 + 1
            Else
                freq_2 = freq_2 + 1
            End If
        Next
        Console.WriteLine("The result of 500 generated numbers is :- ")
        Console.WriteLine()
        Console.WriteLine("The frequency of numbers between 1 and 100 is : " & freq_1)
        Console.WriteLine("The frequency of numbers between 101 and 200 is : " & freq_2)

        percent_1 = (freq_1 / 500) * 100
        percent_2 = (freq_2 / 500) * 100

        Console.WriteLine("Percentage of numbers between 1 and 100 : " & percent_1)
        Console.WriteLine("Percentage of numbers between 101 and 200 : " & percent_2)
    End Sub

End Module
