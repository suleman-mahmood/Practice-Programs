Module Module1

    Sub Main()
        Dim choice As Integer = 2

        While choice <> 0
            Console.Clear()
            Call Menu(choice)
            Select Case choice
                Case 1 : AddRecords()
                Case 2 : SearchRecords()
                Case 3 : DeleteRecords()
                Case 4 : EditRecords()
            End Select
        End While

    End Sub

    Sub Menu(ByRef x As Integer)
        Console.WriteLine("1: Add Records")
        Console.WriteLine("2: Search Records")
        Console.WriteLine("3: Delete Records")
        Console.WriteLine("4: Edit Records")
        Console.WriteLine("0: Exit")
        x = Console.ReadLine()
    End Sub

    Sub AddRecords()
        Console.Clear()
        Dim choice As Char = "y"
        Dim id As Integer
        Dim name As String

        FileOpen(1, "E:\StudentRecord\Data.txt", OpenMode.Append)

        While choice = "Y" Or choice = "y"
            Console.WriteLine("Enter ID : ")
            id = Console.ReadLine
            Console.WriteLine("Enter Name : ")
            name = Console.ReadLine
            WriteLine(1, id)
            WriteLine(1, name)
            Console.WriteLine("Do you want to enter more records ? (y/n) : ")
            choice = Console.ReadLine
        End While
        FileClose(1)
    End Sub

    Sub SearchRecords()
        Console.Clear()
        Dim id As Integer
        Dim name As String
        Dim searchId As Integer
        Dim found As Boolean = False

        FileOpen(1, "E:\StudentRecord\Data.txt", OpenMode.Input)
        Console.WriteLine("Enter the id of the student you want to search for : ")
        searchId = Console.ReadLine

        While Not EOF(1)
            Input(1, id)
            Input(1, name)
            If id = searchId Then
                found = True
                Console.WriteLine("ID : " & id)
                Console.WriteLine("Name : " & name)
            End If
        End While

        If found = False Then
            Console.WriteLine("Records not FOund...!!")
        End If
        Console.ReadKey()
    End Sub

    Sub DeleteRecords()
        Console.Clear()
        Dim id As Integer
        Dim name As String = ""
        Dim deleteId As Integer

        FileOpen(1, "E:\StudentRecord\Data.txt", OpenMode.Input)
        FileOpen(2, "E:\StudentRecord\NewData.txt", OpenMode.Output)
        Console.WriteLine("ENter the id of the records you want to delete : ")
        deleteId = Console.ReadLine

        While Not EOF(1)
            Input(1, id)
            Input(1, name)
            If id <> deleteId Then
                WriteLine(2, id)
                WriteLine(2, name)
            End If
        End While
        FileClose(1)
        FileClose(2)
    End Sub

    Sub EditRecords()
        Console.Clear()
        Dim id As Integer
        Dim name As String = ""
        Dim SearchId As Integer

        FileOpen(1, "E:\StudentRecord\Data.txt", OpenMode.Input)
        FileOpen(2, "E:\StudentRecord\NewData.txt", OpenMode.Output)
        Console.WriteLine("ENter the id of the records you want to Edit : ")
        SearchId = Console.ReadLine

        While Not EOF(1)
            Input(1, id)
            Input(1, name)
            If id = SearchId Then
                Console.WriteLine("Enter New Name :")
                name = Console.ReadLine
                WriteLine(2, id)
                WriteLine(2, name)
            Else
                WriteLine(2, id)
                WriteLine(2, name)
            End If
        End While
        FileClose(1)
        FileClose(2)
    End Sub

End Module

0.