Module Module1

    'OUR GLOBAL SPACE
    'We need our array and mid to be Global Variables so that everyone can use them
    Dim numbers(100) As Integer
    Dim midIndex As Integer

    Sub Main()
        Dim randomNumber As Random
        Dim whatToSearch As Integer

        'Filling up the array with random values between 1 and 100
        randomNumber = New Random
        For i = 0 To 99
            numbers(i) = (randomNumber.Next Mod 100) + 1
        Next

        'Sorting our array as Binary Search can only be applied to Sorted Array
        Call BubbleSort(numbers, 100)

        'Lets output the elements of the array
        Console.WriteLine("Printing the Sorted Array")
        For i = 0 To 99
            Console.WriteLine(numbers(i))
        Next

        'Asking for the value we want to search in our array
        Console.WriteLine("Enter the value you want to search in our array: ")
        whatToSearch = Console.ReadLine

        'Example: 45 exists in our array? : False
        Console.WriteLine(whatToSearch & " exists in our array? : " & BinarySearch(0, 99, whatToSearch))

        Console.ReadKey()
    End Sub


    Function BinarySearch(ByRef lowerBound As Integer, ByRef upperBound As Integer, _
                          ByVal whatToSearch As Integer)
        'We will first calculate the mid value
        midIndex = (upperBound + lowerBound) / 2

        'Base Case:
        '   We will terminate (end recursion) when Upper bound becomes lower(lesser) than Lower bound
        '   and it means we have not found the value
        If upperBound < lowerBound Then Return False

        'Base Case:
        '   If our mid value is equal to search then we have found it
        If numbers(midIndex) = whatToSearch Then Return True

        If numbers(midIndex) > whatToSearch Then
            'We need to move Left
            'i.e we need to re-assign our upperbound to (mid - 1)
            'Since we are searching between upper and lower bounds then updating the
            'upper bound will show the effect of discarding the right side of array
            upperBound = midIndex - 1
        End If

        If numbers(midIndex) < whatToSearch Then
            'We need to move Right
            'i.e we need to re-assign our lowerbound to (mid + 1)
            'Since we are searching between upper and lower bounds then updating the
            'lower bound will show the effect of discarding the left side of array
            lowerBound = midIndex + 1
        End If

        Return BinarySearch(lowerBound, upperBound, whatToSearch)
    End Function

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
                    hasSwapped = True 'Setting the flag to true so that We loop again

                    temp = numbers(i)
                    numbers(i) = numbers(i + 1)
                    numbers(i + 1) = temp
                End If

            Next
        End While
    End Sub

End Module
