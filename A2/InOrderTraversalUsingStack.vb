Module Module1

    Structure node
        Dim leftPointer As Integer
        Dim data As Integer
        Dim rightPointer As Integer
    End Structure

    Dim binaryTree(10) As node
    Dim rootPointer As Integer
    Dim freePointer As Integer

    Const NULLPOINTER = -1
    Const NULLVALUE = -1

    Dim stack(10) As node
    Dim top As Integer

    Sub Main()
        rootPointer = NULLVALUE
        freePointer = 0
        top = -1

        Call InitialiseTree()
        Call Menu()
    End Sub

    Sub InitialiseTree()
        For i = 0 To 9
            binaryTree(i).leftPointer = NULLPOINTER
            binaryTree(i).rightPointer = i + 1
            binaryTree(i).data = NULLVALUE
        Next
        binaryTree(9).rightPointer = NULLPOINTER
    End Sub

    Sub Menu()
        Dim choice As Integer

        choice = -1

        While choice <> 0
            Console.ReadKey()
            Console.Clear()
            Console.WriteLine("1- ADD data in the Tree")
            Console.WriteLine("2- Print Traversal")
            Console.WriteLine("0- Exit")
            choice = Console.ReadLine
            If choice = 1 Then Call Insertdata()
            If choice = 2 Then Call printTraversal()
        End While

    End Sub

    Sub Insertdata()
        Dim currentPointer As Integer
        Dim valueToBeInserted As Integer

        currentPointer = rootPointer

        Console.WriteLine("Enter the value you want to insert: ")
        valueToBeInserted = Console.ReadLine

        While True
            If currentPointer = NULLPOINTER Then
                rootPointer = freePointer
                freePointer = binaryTree(freePointer).rightPointer
                binaryTree(rootPointer).data = valueToBeInserted
                binaryTree(rootPointer).rightPointer = NULLPOINTER
                Exit While
            End If
            If binaryTree(currentPointer).data > valueToBeInserted Then
                'Move Left
                If binaryTree(currentPointer).leftPointer = NULLPOINTER Then
                    Dim newPointer As Integer
                    newPointer = freePointer
                    freePointer = binaryTree(freePointer).rightPointer
                    binaryTree(newPointer).data = valueToBeInserted
                    binaryTree(newPointer).rightPointer = NULLPOINTER
                    binaryTree(currentPointer).leftPointer = newPointer
                    Exit While
                Else
                    currentPointer = binaryTree(currentPointer).leftPointer
                End If
            Else
                'Move Right
                If binaryTree(currentPointer).rightPointer = NULLPOINTER Then
                    Dim newPointer As Integer
                    newPointer = freePointer
                    freePointer = binaryTree(freePointer).rightPointer
                    binaryTree(newPointer).data = valueToBeInserted
                    binaryTree(newPointer).rightPointer = NULLPOINTER
                    binaryTree(currentPointer).rightPointer = newPointer
                    Exit While
                Else
                    currentPointer = binaryTree(currentPointer).rightPointer
                End If
            End If
        End While

    End Sub

    Sub Push(ByVal valueToBeInserted As node)
        If top = 9 Then
            Exit Sub
        End If
        top = top + 1
        stack(top) = valueToBeInserted
    End Sub

    Function isEmpty()
        If top = -1 Then
            Return True
        Else
            Return False
        End If
    End Function

    Function Pop() As node
        Dim value As node

        value = stack(top)
        top = top - 1

        Return value
    End Function

    Sub printTraversal()
        Dim currentPointer As Integer
        Dim tempNode As node

        currentPointer = rootPointer
        Console.WriteLine()

        While currentPointer <> NULLPOINTER Or Not isEmpty()
            While currentPointer <> NULLPOINTER
                Push(binaryTree(currentPointer))
                currentPointer = binaryTree(currentPointer).leftPointer
            End While
            tempNode = Pop()
            currentPointer = tempNode.rightPointer
            Console.Write(tempNode.data & " ")
        End While
    End Sub

End Module
