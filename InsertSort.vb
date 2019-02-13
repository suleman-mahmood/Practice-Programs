Module Module1

    Sub Main()
        Dim numbers(100) As Integer
        Dim randomNumber As Random

        randomNumber = New Random

        'We are filling  the array with random Values
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
        Call InsertSort(numbers, 100)

        'Lets output the elements of the array
        Console.WriteLine("After Sorting:")
        For i = 0 To 99
            Console.WriteLine(numbers(i))
        Next

        Console.ReadKey()
    End Sub

    Sub InsertSort(ByRef numbers() As Integer, ByVal sizeOfArray As Integer)
        'A variable to temporarily hold the value of i'th index
        Dim temp As Integer

        'We need to loop from 2nd index to the last
        For i = 1 To (sizeOfArray - 1)
            'We need to loop from 1st index to the one before "i'th" index
            For j = 0 To (i - 1)
                'Now comparing my j'th index (the one before) with i'th index (the one after)
                If numbers(j) > numbers(i) Then
                    'Lets first save the i'th value in temp
                    temp = numbers(i)
                    'This loop will now push every element forward from j'th position to the i'th position
                    'But it will loop backwards from i'th position to the one after j'th position
                    For k = i To (j + 1) Step -1
                        numbers(k) = numbers(k - 1) 'This (k-1) is the reason we loop till (j+1)'th location
                    Next
                    'Now lets put back our temp to the j'th position
                    numbers(j) = temp
                    'We need to exit this loop to avoid any errors as we have done swapping and need
                    'not to check any value further for my j'th index
                    Exit For
                End If
            Next
        Next
    End Sub

End Module
