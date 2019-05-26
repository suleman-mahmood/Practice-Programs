Module Module1

    Sub Main()
        '/////////////////////////////////////////////////////////////////
        ' ////////////////////// Creating A Triangle /////////////////////
        '/////////////////////////////////////////////////////////////////
        ' In this program we will be creating a triangle of base and height 
        ' input by the user and fill it with the desired character input by
        ' the user.

        'declaring the size of the triangle
        Dim size As Integer
        'declaring the counters
        Dim i, j, k As Integer
        'declaring the characters with which you want to fill the triangle
        Dim filler As Char

        'initialising the variables
        size = 0 : filler = "" : i = 0 : j = 0 : k = 0

        'prompting and taking inputs from the user
        Console.WriteLine("Enter the size of the triangle : ")
        size = Console.ReadLine
        Console.WriteLine("Enter a single character for which you want to fill the triangle with : ")
        filler = Console.ReadLine

        'creating the triangle
        For i = 1 To size

            'this loop will print the spaces
            For j = i To size - 1
                'NOTE : we are using console.write to print on the same line
                Console.Write(" ")
            Next

            'this loop will print the chracter (filler)
            For k = 1 To i
                'NOTE : we are using console.write to print on the same line
                Console.Write(filler)
                Console.Write(filler)
            Next

            'this will cause a line break and make us go to the next line
            Console.WriteLine()
        Next

        Console.ReadKey()
    End Sub

End Module
