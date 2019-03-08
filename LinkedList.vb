Module Module1

    Structure node
        Dim data As Integer
        Dim nextPointer As Integer
    End Structure

    Dim List(10) As node
    Const NULLPOINTER = -1
    Const NULLVALUE = -1

    Dim currentPointer As Integer
    Dim rootPointer As Integer
    Dim freePointer As Integer

    Sub Main()
        Dim choice As Integer

        'Initially both are null
        currentPointer = NULLPOINTER
        rootPointer = NULLPOINTER
        freePointer = 0

        choice = -1

        'Initialising Free List
        For i = 0 To 9
            List(i).nextPointer = i + 1
            List(i).data = NULLVALUE
        Next
        List(9).nextPointer = NULLPOINTER

        While choice <> 0
            Console.Clear()
            choice = Menu()
            If choice <> 0 Then
                If choice = 1 Then Call AddItemsInList()
                If choice = 2 Then Call PrintList()
                If choice = 3 Then Call FindItemInList()
            End If
        End While

    End Sub

    Function Menu()
        Dim choice As Integer

        Console.WriteLine("     MENU     ")
        Console.WriteLine("1) Add data items into List")
        Console.WriteLine("2) Print List")
        Console.WriteLine("3) Find an item in List")
        Console.WriteLine("0) EXIT")
        Console.WriteLine("Your Choice: ")
        choice = Console.ReadLine

        Return choice
    End Function

    Sub AddItemsInList()
        Dim dataToBeAdded As Integer

        Console.WriteLine("Enter data: ")
        dataToBeAdded = Console.ReadLine

        If freePointer <> NULLPOINTER Then
            If rootPointer = NULLPOINTER Then
                rootPointer = freePointer
            End If

            currentPointer = freePointer
            freePointer = List(freePointer).nextPointer
            List(currentPointer).data = dataToBeAdded
        Else
            Console.WriteLine("OVERFLOW..!!!")
        End If
    End Sub

    Sub PrintList()
        Dim pointer As Integer

        pointer = rootPointer

        If pointer <> NULLPOINTER Then
            While pointer <> NULLPOINTER
                Console.WriteLine("DATA: " & List(pointer).data & " NEXT: " & List(pointer).nextPointer)
                pointer = List(pointer).nextPointer
            End While
        Else
            Console.WriteLine("List in Empty..!")
        End If
        Console.ReadKey()
    End Sub

    Sub FindItemInList()
        Dim searchValue As Integer
        Dim pointer As Integer
        Dim isFound As Boolean
        Dim foundPointer As Integer

        pointer = rootPointer
        foundPointer = NULLPOINTER

        If pointer <> NULLPOINTER Then
            Console.WriteLine("Enter the value you want to find in list: ")
            searchValue = Console.ReadLine

            For i = 0 To 9
                If List(pointer).data = searchValue Then
                    isFound = True
                    foundPointer = pointer
                End If
                pointer = List(pointer).nextPointer
            Next

            If isFound Then
                Console.WriteLine("Value Found at: " & foundPointer)
            Else
                Console.WriteLine("Value Not Found..!")
            End If
        Else
            Console.WriteLine("List is Empty..!")
        End If
        Console.ReadKey()
    End Sub

End Module
