Class Vehicles

    Private carType As String
    Private registrationNumber As Integer
    Private color As String

    Public Sub New(ByVal a As String, ByVal b As Integer, ByVal c As String)
        carType = a
        registrationNumber = b
        color = c
    End Sub

    Public Overridable Sub PrintDetails()
        Console.WriteLine("Car Type: " & Me.carType & " | Registration Number: " & Me.registrationNumber & " | Color: " & Me.color)
    End Sub

    Public Function getCarType() As String
        Return carType
    End Function

    Public Sub setCarType(ByVal a As String)
        Me.carType = a
    End Sub

End Class

Class Bike
    Inherits Vehicles

    Private numberOfTyres As Integer

    Public Sub New(ByVal a As String, ByVal b As Integer, ByVal c As String, ByVal d As Integer)
        MyBase.New(a, b, c)
        numberOfTyres = d
    End Sub

    Public Overrides Sub PrintDetails()
        MyBase.PrintDetails()
        Console.WriteLine("Number of Tyres: " & Me.numberOfTyres)
    End Sub

End Class

Module module1

    Sub Main()
        Dim car As Vehicles
        Dim Ninja As Bike

        Ninja = New Bike("Heavy Bike", 5845484, "Black", 2)
        Ninja.PrintDetails()
        Ninja.setCarType("Heaviest Bike Ever")
        Ninja.PrintDetails()

        car = New Vehicles("Ordinary", 621851, "White")
        car.PrintDetails()

        Console.ReadKey()
    End Sub

End Module