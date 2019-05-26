Module Module1

    Structure node
        Dim data As Integer
        Dim nextPointer As Integer
    End Structure

    Dim List(10) As node
    Const NULLPOINTER = -1
    Const NULLVALUE = -1

    Dim rootPointer As Integer
    Dim freePointer As Integer

    Sub Main()
        Call InitialiseList()
        Call Menu()
    End Sub

    Sub InitialiseList()
        freePointer = 0
        rootPointer = NULLPOINTER

        For i = 0 To 9
            List(i).data = NULLVALUE
            List(i).nextPointer = i + 1
        Next

        List(9).nextPointer = NULLPOINTER
    End Sub

    Sub Menu()
        Dim choice As Integer
        choice = -1

        While choice <> 0
            Console.Clear()
            Console.WriteLine("Ordered List")
            Console.WriteLine("1- Add Item in the List")
            Console.WriteLine("2- Delete an Item from the List")
            Console.WriteLine("3- Print the List")

            choice = Console.ReadLine

            If choice = 1 Then Call AddItem()
            If choice = 2 Then Call DeleteItem()
            If choice = 3 Then Call PrintList()
        End While

    End Sub

    Sub PrintList()
        Dim currentPointer As Integer

        currentPointer = rootPointer

        While currentPointer <> NULLPOINTER
            Console.Write(List(currentPointer).data & " ")
            currentPointer = List(currentPointer).nextPointer
        End While

        Console.WriteLine("")
        Console.WriteLine("--- Array ---")
        For i = 0 To 9
            Console.WriteLine(i & ": " & List(i).data & " Pointer: " & List(i).nextPointer)
        Next

        Console.ReadKey()
    End Sub

    Sub AddItem()
        Dim newValue As Integer

        Console.WriteLine("Enter New Value to be Added")
        newValue = Console.ReadLine

        If rootPointer = NULLPOINTER Then
            rootPointer = freePointer
            freePointer = List(freePointer).nextPointer
            List(rootPointer).data = newValue
            List(rootPointer).nextPointer = NULLPOINTER
        ElseIf freePointer = NULLPOINTER Then
            Console.WriteLine("List is Full")
            Console.ReadKey()
        Else
            Dim newNodePointer As Integer
            Dim currentPointer As Integer
            Dim previousNodePointer As Integer

            currentPointer = rootPointer
            previousNodePointer = rootPointer
            newNodePointer = freePointer

            freePointer = List(freePointer).nextPointer
            List(newNodePointer).data = newValue

            While currentPointer <> NULLPOINTER
                If List(currentPointer).data > newValue Then
                    Exit While
                End If
                previousNodePointer = currentPointer
                currentPointer = List(currentPointer).nextPointer
            End While

            If currentPointer = previousNodePointer And currentPointer = rootPointer Then
                List(newNodePointer).nextPointer = rootPointer
                rootPointer = newNodePointer
            Else
                List(previousNodePointer).nextPointer = newNodePointer
                List(newNodePointer).nextPointer = currentPointer
            End If
        End If

    End Sub

    Sub DeleteItem()
        Dim valueToDelete As Integer

        Console.WriteLine("Enter the value you want to delete")
        valueToDelete = Console.ReadLine

        If rootPointer = NULLPOINTER Then
            Console.WriteLine("There is no Item in list to delete")
        Else
            Dim currentPointer As Integer
            Dim previousPointer As Integer
            Dim valueFound As Boolean

            currentPointer = rootPointer
            previousPointer = rootPointer
            valueFound = False

            While currentPointer <> NULLPOINTER
                If List(currentPointer).data = valueToDelete Then
                    valueFound = True
                    Exit While
                End If
                previousPointer = currentPointer
                currentPointer = List(currentPointer).nextPointer
            End While
            If Not valueFound Then
                Console.WriteLine("Value not Found")
                Console.ReadKey()
                Exit Sub
            End If
            If currentPointer = previousPointer And currentPointer = rootPointer Then
                List(currentPointer).data = NULLVALUE
                rootPointer = List(currentPointer).nextPointer
                List(currentPointer).nextPointer = freePointer
                freePointer = currentPointer
            Else
                List(currentPointer).data = NULLVALUE
                List(previousPointer).nextPointer = List(currentPointer).nextPointer
                List(currentPointer).nextPointer = freePointer
                freePointer = currentPointer
            End If

        End If

    End Sub

End Module
