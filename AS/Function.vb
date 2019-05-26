Module Module1

    Sub Main()
        '//////////////////////// FUNCTIONS /////////////////////////////
        'A function is also a block of code that runs when it is called
        'but it also returns a value which is mostly a conclusion of the
        'data passed into it.

        Dim x, y, z As Integer
        Dim avg As Integer

        x = 145 : y = 1465 : z = 151 : avg = 0

        'Note that the function is not called by using the keyword 'Call'
        'but its return value is assigned to a variable which automatically
        'call it
        avg = Average(x, y, z)

        Console.WriteLine("The average of the numbers is : " & avg)

        Console.ReadKey()
    End Sub

    'Note that in almost all of the cases the variables are passed through 'ByVal'
    'In the end the return type of the function is also entered.
    Function Average(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer) As Integer
        Dim result As Integer
        Dim sum As Integer

        sum = a + b + c
        result = sum / 3

        Return result
    End Function





End Module
