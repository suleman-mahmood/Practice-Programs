Module module1

    Sub Main()
        Dim numbers(99) As Integer
        Dim randomNumber As Random

        randomNumber = New Random

        'Filling up the array with random values between 1 and 100
        For i = 0 To 99
            numbers(i) = (randomNumber.Next() Mod 100) + 1
        Next

        'Lets output the elements of the array
        Console.WriteLine("Before Sorting:")
        For i = 0 To 99
            Console.WriteLine(numbers(i))
        Next

        'Calling the insert sort Procedure by passing my array as
        'a reference so that it comes back sorted
        Call BubbleSort(numbers, 100)

        'Lets output the elements of the array
        Console.WriteLine("After Sorting:")
        For i = 0 To 99
            Console.WriteLine(numbers(i))
        Next

        Console.ReadKey()
    End Sub

    Sub BubbleSort(ByRef numbers() As Integer, ByVal sizeOfArray As Integer)

        Dim hasSwapped As Boolean
        Dim temp As Integer

        hasSwapped = True

        While hasSwapped

            hasSwapped = False

            'We are looping from first to the second last index (because we need to compare i with i + 1
            For i = 0 To (sizeOfArray - 2)
                'If previous value is greater then the next one then we Swap
                If numbers(i) > numbers(i + 1) Then
                    'Setting the flag to true so that We loop again
                    hasSwapped = True

                    temp = numbers(i)
                    numbers(i) = numbers(i + 1)
                    numbers(i + 1) = temp
                End If
            Next

        End While

    End Sub

End Module