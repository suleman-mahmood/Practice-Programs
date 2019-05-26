Module Module1

    Structure node
        Dim leftPointer As Integer
        Dim data As Integer
        Dim rightPointer As Integer
    End Structure

    Dim binaryTree(10) As node
    Dim rootPointer As Integer

    Const NULLPOINTER = -1
    Const NULLVALUE = -1

    Sub Main()
        rootPointer = 0

        Call InitialiseTree()

        Call Menu()

    End Sub

    Sub InitialiseTree()
        For i = 0 To 9
            binaryTree(i).leftPointer = NULLPOINTER
            binaryTree(i).rightPointer = NULLPOINTER
            binaryTree(i).data = NULLVALUE
        Next
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
            If choice = 2 Then Call PrintTraversal(rootPointer)
        End While

    End Sub


    Sub Insertdata()
        Dim currentPosition As Integer
        Dim valueToBeInserted As Integer

        currentPosition = 0

        Console.WriteLine("Enter the value you want to insert: ")
        valueToBeInserted = Console.ReadLine

        While True
            If binaryTree(currentPosition).data = NULLVALUE Then
                binaryTree(currentPosition).data = valueToBeInserted
                Exit While
            End If

            If binaryTree(currentPosition).data < valueToBeInserted Then
                'Move Right
                If binaryTree(currentPosition).rightPointer = NULLPOINTER Then
                    Dim tempPosition As Integer

                    tempPosition = 0

                    While binaryTree(tempPosition).data <> NULLVALUE
                        tempPosition = tempPosition + 1
                    End While

                    binaryTree(tempPosition).data = valueToBeInserted
                    binaryTree(currentPosition).rightPointer = tempPosition

                    Exit While
                Else
                    currentPosition = binaryTree(currentPosition).rightPointer
                End If
            Else
                'Move Left
                If binaryTree(currentPosition).leftPointer = NULLPOINTER Then
                    Dim tempPosition As Integer

                    tempPosition = 0

                    While binaryTree(tempPosition).data <> NULLVALUE
                        tempPosition = tempPosition + 1
                    End While

                    binaryTree(tempPosition).data = valueToBeInserted
                    binaryTree(currentPosition).leftPointer = tempPosition

                    Exit While
                Else
                    currentPosition = binaryTree(currentPosition).leftPointer
                End If
            End If
        End While

    End Sub


    Sub PrintTraversal(ByVal currentPosition)
        If currentPosition <> NULLPOINTER Then
            PrintTraversal(binaryTree(currentPosition).leftPointer)
            Console.WriteLine(binaryTree(currentPosition).data & " ")
            PrintTraversal(binaryTree(currentPosition).rightPointer)
        End If
    End Sub


End Module
