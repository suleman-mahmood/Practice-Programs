Module Module1
    '////////////////////////////////////////////////////////////////
    '//////////////////// THE SUM,HIGHEST,LOWEST ////////////////////
    '////////////////////////////////////////////////////////////////
    '////////////////////// ARRAY APPROACH //////////////////////////
    '////////////////////////////////////////////////////////////////
    'This program calculates the sum,highest,lowest of unknown
    'amount of numbers.

    Sub Main()
        Dim Amount, i, j, sum, highest, lowest As Integer

        highest = 0
        lowest = 999999999

        Console.WriteLine("Enter the amount of Numbers you want to enter :")
        Amount = Console.ReadLine

        Dim num(Amount) As Integer

        For i = 1 To Amount
            Console.WriteLine("Enter Number : ")
            num(i) = Console.ReadLine
        Next

        For j = 1 To Amount
            sum = sum + num(j)
            If num(j) > highest Then
                highest = num(j)
            End If
            If num(j) < lowest Then
                lowest = num(j)
            End If
        Next

        Console.WriteLine("The sum of numbers is : " & sum)
        Console.WriteLine("The highest number is : " & highest)
        Console.WriteLine("The lowest number is  : " & lowest)


        Console.ReadKey()
    End Sub

    '////////////////////////////////////////////////////////////////
    '////////////////////// NON-ARRAY APPROACH //////////////////////
    '////////////////////////////////////////////////////////////////

    'Sub Main()
    '    Dim Amount, i, j, sum, highest, lowest, x As Integer

    '    highest = 0
    '    lowest = 999999999

    '    Console.WriteLine("Enter the amount of Numbers you want to enter :")
    '    Amount = Console.ReadLine

    '    For i = 1 To Amount
    '        Console.WriteLine("Enter Number : ")
    '        x = Console.ReadLine

    '        sum = sum + x
    '        If x > highest Then
    '            highest = x
    '        End If
    '        If x < lowest Then
    '            lowest = x
    '        End If
    '    Next

    '    Console.WriteLine("The sum of numbers is : " & sum)
    '    Console.WriteLine("The highest number is : " & highest)
    '    Console.WriteLine("The lowest number is  : " & lowest)


    '    Console.ReadKey()
    'End Sub
End Module
