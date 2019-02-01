Module Module1
    ' Q) Calculate the total number of votes and decide who wins or the result is a tie.
    ' Sample Input can be:- 
    ' 5
    ' AABBA
    Sub Main()
        Dim V, A, B As Integer
        Dim Input As String = ""

        Console.WriteLine("Enter the total n.o of votes : ")
        V = Console.ReadLine
        Console.WriteLine("enter on who's favor is the vote : ")
        Input = Console.ReadLine

        For i = 1 To Len(Input)
            If Input(i - 1) = "A" Then
                A = A + 1
            ElseIf Input(i - 1) = "B" Then
                B = B + 1
            End If
        Next

        If A > B Then
            Console.WriteLine("A")
        ElseIf B > A Then
            Console.WriteLine("B")
        Else
            Console.WriteLine("Tie")
        End If
        Console.ReadKey()
    End Sub
End Module
