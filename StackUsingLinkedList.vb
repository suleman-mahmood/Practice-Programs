Module Module1

    Structure node
        Dim data As Integer
        Dim nextPointer As Integer
    End Structure

    Const NULLPOINTER = -1
    Const NULLVALUE = -1

    Dim Stack(10) As node
    Dim rootPointer As Integer
    Dim freePointer As Integer

    Sub Main()
        Call InitialiseStack()
        Call Menu()
    End Sub

    Sub Menu()
        Dim choice As Integer
        choice = -1

        While choice <> 0
            Console.Clear()
            Console.WriteLine("STACK using LINKED LIST")
            Console.WriteLine("1- Push Item in the Stack")
            Console.WriteLine("2- Pop the front item from stack")
            Console.WriteLine("3- Print the Stack")

            choice = Console.ReadLine

            If choice = 1 Then Call PushItem()
            If choice = 2 Then Call PopItem()
            If choice = 3 Then Call PrintStack()
        End While
    End Sub

    Sub InitialiseStack()
        rootPointer = NULLPOINTER
        freePointer = 0
        For i = 0 To 9
            Stack(i).data = NULLVALUE
            Stack(i).nextPointer = i + 1
        Next
        Stack(9).nextPointer = NULLPOINTER
    End Sub

    Sub PrintStack()
        Dim currentPointer As Integer

        currentPointer = rootPointer

        If currentPointer = NULLPOINTER Then
            Console.WriteLine("Stack is Empty")
        Else
            While currentPointer <> NULLPOINTER
                Console.Write(Stack(currentPointer).data & " ")
                currentPointer = Stack(currentPointer).nextPointer
            End While
        End If

        Console.WriteLine()
        Console.WriteLine("--- Array ---")
        For i = 0 To 9
            Console.WriteLine(i & ": " & Stack(i).data & " Pointer: " & Stack(i).nextPointer)
        Next
        Console.ReadKey()
    End Sub

    Sub PushItem()
        Dim valueToBePushed As Integer

        Console.WriteLine("Enter the value you want to push in the stack")
        valueToBePushed = Console.ReadLine

        If rootPointer = NULLPOINTER Then
            rootPointer = freePointer
            freePointer = Stack(freePointer).nextPointer
            Stack(rootPointer).data = valueToBePushed
            Stack(rootPointer).nextPointer = NULLPOINTER
        ElseIf freePointer = NULLPOINTER Then
            Console.WriteLine("The stack is FULL")
            Console.ReadKey()
        Else
            Dim newNodePointer As Integer

            newNodePointer = freePointer
            freePointer = Stack(freePointer).nextPointer

            Stack(newNodePointer).data = valueToBePushed
            Stack(newNodePointer).nextPointer = rootPointer
            rootPointer = newNodePointer
        End If
    End Sub

    Sub PopItem()
        If rootPointer = NULLPOINTER Then
            Console.WriteLine("The stack is empty")
            Console.ReadKey()
        Else
            Dim previousNodePointer As Integer
            previousNodePointer = rootPointer

            rootPointer = Stack(rootPointer).nextPointer
            Stack(previousNodePointer).data = NULLVALUE
            Stack(previousNodePointer).nextPointer = freePointer
            freePointer = previousNodePointer
        End If
    End Sub

End Module
