Module Module1

    Sub Main()
        Dim x, y, z As Integer
        Dim avg As Integer

        x = 5 : y = 56 : z = 45
        avg = -1

        Console.WriteLine("The value of average before calling is : " & avg)

        Call Average(x, y, z, avg)

        Console.WriteLine("The value of average after calling is : " & avg)

        Console.ReadKey()
    End Sub

    'We are now declaring the subroutine with parameters.
    'ByVal will make a copy of the variable passed into the parameter
    'eg the value in x is copied in variable a.
    'ByRef passes the same variable to the subroutine thus changing the
    'name from which it is called eg avg and result are addressing to the
    'same memory address and are indeed same variables but with different names.
    Sub Average(ByVal a As Integer, ByVal b As Integer, _
                ByVal c As Integer, ByRef result As Integer)

        Dim sum As Integer

        sum = a + b + c

        result = sum / 3
    End Sub




End Module
