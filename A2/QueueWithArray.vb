Module module1

    'Global Space
    Dim queue(9) As Integer
    Dim front, back As Integer
    Const NullValue = -1

    Sub Main()
        front = -1
        back = 0

        Dim temp As Integer = 0

        While temp <> -1
            Console.WriteLine("1: Push")
            Console.WriteLine("2: Pop")
            Console.WriteLine("3: Print")
            Console.WriteLine("Enter Choice")

            temp = Console.ReadLine

            If temp = 1 Then
                Console.WriteLine("Enter New Value")
                temp = Console.ReadLine
                Call Push(temp)
            End If

            If temp = 2 Then Pop()
            If temp = 3 Then Call PrintQueue()
        End While

    End Sub

    Sub Push(ByVal newItem As Integer)
        If front = 9 Then
            'OverFlow, cannot enter more data
        Else
            front = front + 1
            queue(front) = newItem
        End If
    End Sub

    Function Pop() As Integer

        Dim valueToBeDeleted

        If Not isEmpty() Then

            valueToBeDeleted = queue(back)
            queue(back) = NullValue
            back = back + 1

            Return valueToBeDeleted
        Else
            'Underflow, no value exists to be deleted
            Return -1
        End If

    End Function

    Function isEmpty() As Boolean

        If front < back Then
            Return True
        Else
            Return False
        End If

    End Function

    Sub PrintQueue()
        For i = 0 To 9
            Console.WriteLine(i & ": " & queue(i))
        Next
    End Sub
End Module