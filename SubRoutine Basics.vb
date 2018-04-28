Module Module1

    Sub Main()
        '///////////////// PROCEDURES/SUB-ROUTINES //////////////////////
        'A subroutine is a block of code that runs whenever it is called.
        'Main() is the major subroutine which is called once everytime a 
        'program is runned.

        'We use the keyword "Call" to call a subroutine
        Call Message()

        Console.ReadKey()
    End Sub


    'We have declared a subroutine called message which prints a statement
    'whenever it is called.
    'Note: No parameters are included
    Sub Message()
        Console.WriteLine("The subroutine was called...!")
    End Sub


End Module
