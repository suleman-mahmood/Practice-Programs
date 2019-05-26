Module module1

    Structure node
        Dim data As Integer
        Dim nextPointer As Integer
    End Structure

    Dim queue(10) As node
    Dim front, back, freePointer As Integer

    Const NULLVALUE = -1
    Const NULLPOINTER = -1

    Sub Main()

        Call InitialiseQueue()

        Dim choice As Integer = 0

        While choice <> -1
            Console.WriteLine("1: Push")
            Console.WriteLine("2: Pop")
            Console.WriteLine("3: Print")
            Console.WriteLine("Enter Choice")

            choice = Console.ReadLine

            If choice = 1 Then
                Console.WriteLine("Enter New Value")
                choice = Console.ReadLine
                Call Push(choice)
            End If

            If choice = 2 Then Pop()
            If choice = 3 Then Call PrintQueue()
        End While
    End Sub

    Sub InitialiseQueue()
        front = NULLPOINTER
        back = NULLPOINTER
        freePointer = 0

        For i = 0 To 9
            queue(i).data = NULLVALUE
            queue(i).nextPointer = i + 1
        Next

        queue(9).nextPointer = NULLPOINTER

    End Sub

    Sub Push(ByVal newItem As Integer)
        If freePointer = NULLPOINTER Then
            'There is no space in Queue
        ElseIf front = NULLPOINTER Then
            'We will have to create the Queue

            front = freePointer
            back = freePointer
            freePointer = queue(freePointer).nextPointer

            queue(front).data = newItem
            queue(front).nextPointer = NULLPOINTER
        Else
            'We will add the data at the front of the queue
            Dim newNodePointer As Integer

            newNodePointer = freePointer
            freePointer = queue(freePointer).nextPointer
            queue(newNodePointer).data = newItem

            queue(front).nextPointer = newNodePointer
            front = newNodePointer
            queue(front).nextPointer = NULLPOINTER

        End If
    End Sub

    Function Pop() As Integer
        If front = NULLPOINTER And back = NULLPOINTER Then
            'There is nothing to delete
            Return -1
        Else
            Dim valueToDelete As Integer
            Dim thisPointer As Integer

            'Saving the pointer and value of the value to be deleted
            valueToDelete = queue(back).data
            thisPointer = back

            'Deleting the value
            queue(back).data = NULLVALUE

            'Updating the back pointer
            back = queue(back).nextPointer

            'Giving back the pointer to free List
            queue(thisPointer).nextPointer = freePointer
            freePointer = thisPointer

            Return valueToDelete
        End If
    End Function

    Sub PrintQueue()
        Dim currentPointer As Integer

        currentPointer = back

        If currentPointer = NULLPOINTER Then
            Console.WriteLine("Queue is Empty")
        Else
            While currentPointer <> NULLPOINTER
                Console.Write(queue(currentPointer).data & " ")
                currentPointer = queue(currentPointer).nextPointer
            End While
        End If

        Console.WriteLine()
        Console.WriteLine("--- Array ---")
        For i = 0 To 9
            Console.WriteLine(i & ": " & queue(i).data & " Pointer: " & queue(i).nextPointer)
        Next
    End Sub

End Module