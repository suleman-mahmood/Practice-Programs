Module Module1
    Structure sturec
        <VBFixedString(10)> Dim name As String 'Pre-processor Directive
        Dim rollNo As Integer
        Dim gender As Char
    End Structure

    Sub Main()
        ''''''''''''''Adding Records iN a new File "sturec" ''''''''''''''
        'Call AddingRecordsInFile()
        'Displaying 3 Records from the file "sturec"
        'Call DisplayRecordsFromFile("sturec", 3)

        '''''''''''''''Searching for Record in File'''''''''''''' 
        'Dim sRollNo As Integer
        'Console.WriteLine("Enter the Roll No: ")
        'sRollNo = Console.ReadLine
        'Call SearchRecordInFile(sRollNo)

        '''''''''''''''Deleting Record from File''''''''''''''
        'Dim dRollNo As Integer
        'Console.WriteLine("Enter the Roll No: ")
        'dRollNo = Console.ReadLine
        'Call DeleteRecord(dRollNo)

        'Call DisplayRecordsFromFile("sturec", 2)
        'Call InsertRecInFile()
        'Call DisplayRecordsFromFile("sturecNew", 2)

        Call SortingItemsInAFile()

        Console.ReadKey()
    End Sub

    'A file named "SortItems" contains two fields: Name and Id
    'We will sort in ascending number of ID
    Structure rec
        Dim id As Integer
        <VBFixedString(10)> Dim name As String
    End Structure
    Sub SortingItemsInAFile()
        Dim record As rec
        Dim totalRecs As Integer
        Dim hasSwapped As Boolean
        Dim swapper As rec

        FileOpen(1, "SortItems", OpenMode.Random, OpenAccess.ReadWrite, , Len(record))

        totalRecs = LOF(1) / Len(record)
        Dim recordsArray(totalRecs) As rec

        For i = 0 To (totalRecs - 1)
            FileGet(1, record, i + 1)
            recordsArray(i) = record
        Next

        While hasSwapped
            hasSwapped = False
            For j = 0 To (totalRecs - 1)
                If recordsArray(j).id > recordsArray(j + 1).id Then
                    hasSwapped = True
                    swapper = recordsArray(j)
                    recordsArray(j) = recordsArray(j + 1)
                    recordsArray(j + 1) = swapper
                End If
            Next
        End While

        For k = 0 To (totalRecs - 1)
            FilePut(1, recordsArray(k), k)
        Next

        FileClose(1)

    End Sub

    Sub InsertRecInFile()
        Dim record As sturec
        Dim totalRecs As Integer
        Dim recLoc As Integer

        FileOpen(1, "sturec", OpenMode.Random, OpenAccess.Read, , Len(record))
        FileOpen(2, "sturecNew", OpenMode.Random, OpenAccess.Write, , Len(record))

        totalRecs = LOF(1) / Len(record)

        Console.WriteLine("Enter the Location where you want to insert Record: ")
        recLoc = Console.ReadLine
        Console.WriteLine("Enter Name: ")
        record.name = Console.ReadLine
        Console.WriteLine("Enter Roll No: ")
        record.rollNo = Console.ReadLine
        Console.WriteLine("Enter Gender(m/f): ")
        record.gender = Console.ReadLine

        FilePut(2, record, recLoc)

        For i = 1 To totalRecs
            FileGet(1, record, i)
            If i >= recLoc Then
                FilePut(2, record, i + 1)
            Else
                FilePut(2, record, i)
            End If
        Next

        FileClose(1)
        FileClose(2)
    End Sub

    Sub DeleteRecord(ByVal dRollNo As Integer)
        Dim record As sturec
        Dim j As Integer
        Dim recFound As Boolean
        j = 1
        recFound = False

        FileOpen(1, "sturec", OpenMode.Random, OpenAccess.Read, , Len(record))
        FileOpen(2, "sturecNew", OpenMode.Random, OpenAccess.Write, , Len(record))

        For i = 1 To 3
            FileGet(1, record, i)
            If Not record.rollNo = dRollNo Then
                FilePut(2, record, j)
                j = j + 1
            Else
                recFound = True
                Console.WriteLine("Record Succesully Deleted..!")
            End If
        Next

        If Not recFound Then
            Console.WriteLine("Record not Found")
        End If

        FileClose(1)
        FileClose(2)
    End Sub

    Sub SearchRecordInFile(ByVal sRollNo As Integer)
        Dim record As sturec
        Dim recFound As Boolean

        recFound = False

        FileOpen(1, "sturec", OpenMode.Random, OpenAccess.Read, , Len(record))

        For i = 1 To 3
            FileGet(1, record, i)
            If record.rollNo = sRollNo Then
                recFound = True
                Console.WriteLine("Name: " & record.name)
                Console.WriteLine("Roll No: " & record.rollNo)
                Console.WriteLine("Gender(m/f): " & record.gender)
            End If
        Next

        If Not recFound Then
            Console.WriteLine("Record Not Found")
        End If

        FileClose(1)
    End Sub

    Sub DisplayRecordsFromFile(ByVal nameOfFile As String, ByVal recToDis As Integer)
        Dim record As sturec
        Dim totalRecs As Integer

        FileOpen(1, nameOfFile, OpenMode.Random, OpenAccess.Read, , Len(record))

        totalRecs = LOF(1) / Len(record)

        For i = 1 To totalRecs
            FileGet(1, record, i)

            Console.WriteLine("Name: " & record.name)
            Console.WriteLine("Roll No: " & record.rollNo)
            Console.WriteLine("Gender(m/f): " & record.gender)
        Next

        FileClose(1)
    End Sub

    Sub AddingRecordsInFile()
        Dim record As sturec

        FileOpen(1, "sturec", OpenMode.Random, OpenAccess.Write, , Len(record))

        For i = 1 To 3
            Console.WriteLine("Enter Name: ")
            record.name = Console.ReadLine
            Console.WriteLine("Enter Roll No: ")
            record.rollNo = Console.ReadLine
            Console.WriteLine("Enter Gender(m/f): ")
            record.gender = Console.ReadLine

            FilePut(1, record, i)
        Next

        FileClose(1)
    End Sub

End Module
