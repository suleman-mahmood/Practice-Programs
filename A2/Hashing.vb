Module module1

    Sub Main()
        Dim numbers(9) As Integer
        Dim temp As Integer
        Dim index As Integer

        Const NULLVALUE = -1

        For i = 0 To 9
            numbers(i) = NULLVALUE
        Next

        For i = 0 To 9
            'Generates a random number between 1 and 100
            temp = (New Random().Next Mod 100) + 1
            'Finds the hash of temp
            index = calculateHash(temp)

            'If the hash location is free then insert data
            If numbers(index) = NULLVALUE Then
                numbers(index) = temp
            Else
                Dim count As Integer
                count = index
                'We will use open Hashing and find the next free location after our index
                While numbers(count) <> NULLVALUE
                    count = count + 1
                    'If we are at end of array then we loop back to the start to find free location
                    If count > 9 Then
                        count = 0
                    End If
                End While
                'Insert data at free location
                numbers(count) = temp
            End If
        Next

        For i = 0 To 9
            Console.WriteLine(numbers(i))
        Next
        Console.ReadKey()
    End Sub

    Function calculateHash(ByVal value As Integer) As Integer
        Return value Mod 10
    End Function

End Module