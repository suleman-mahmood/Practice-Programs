Module Module1

    Sub Main()
        '/////////////////// 1-Dimensional Array //////////////////////////
        'An array is a Data Structure which can hold multiple values of a
        'single data type consecutively.
        'For example if we want to store 100 integer values we use an array 
        'rather than 100 variables.

        'Declaring an array with a size of 100 (100 rows only)
        Dim x(100) As Integer

        'Initialising the array.
        'We will always use for-loop for initialising as it has
        'a built-in counter in it
        For i = 1 To 100
            x(i) = 0
        Next

        'Filling the array with consecutive square numbers eg 1,4,9,16,25,36,49.......
        'Note: the carrot '^' sign means 'raise to the power' eg 4^3 = 64
        For i = 1 To 100
            x(i) = i ^ 2
        Next

        'Printing the contents of the array
        For i = 1 To 100
            Console.WriteLine("The " & i & " element of the array is : " & x(i))
        Next

        'CONCLUSION : When using the array in a loop the elements of the array
        '             are usually accessed by the counter variable (eg x(i)).
        '            This enables us to access consecutive elements and store 
        '             values in it or read the values stored on it.

        Console.ReadLine()
    End Sub

End Module
