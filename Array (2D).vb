Module Module1

    Sub Main()
        '/////////////////// 2-Dimensional Array //////////////////////////
        'A 2-Dimensional array holds values in rows and columns which can be
        'thought of as a single 2-D matrix.
        'For example if we want to store 100 integer values in rows and 
        'columns. We use 10x10 array.

        'Declaring an array with a size of 10 x 10 (10 rows and 10 columns)
        Dim x(10, 10) As Integer

        'Initialising the array.
        'We will be using 2 nested for-loops.
        'The outer loop will contain the counter for rows and the inner
        'loop for the columns.
        For i = 1 To 10
            For j = 1 To 10
                x(i, j) = 0  'i refers to the row and j for the column
            Next
        Next

        'Filling the array with consecutive square numbers eg 1,4,9,16,25,36,49.......
        'Note: the carrot '^' sign means 'raise to the power' eg 4^3 = 64
        For i = 1 To 10
            For j = 1 To 10
                x(i, j) = i ^ 2 'We are placing 1 in all the elements of the 1st row
                'then 4 in the 2nd row then 9 in the 3rd row and so on.
            Next
        Next

        'Printing the contents of the array
        For i = 1 To 10
            For j = 1 To 10
                Console.Write(x(i, j) & " ")
            Next
            Console.WriteLine()
        Next

        'CONCLUSION : In 2D array 2 nested loops are used. The outer loop
        '             controls the rows while the inner loop controls the
        '             columns.

        Console.ReadLine()
    End Sub

End Module
