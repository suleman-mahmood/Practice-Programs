Module module1

    'Global Space
    Dim stack(9) As Integer
    Dim top As Integer
    Const NullValue = -1

    Sub Main()
        top = -1

    End Sub

    Sub Push(ByVal newItem As Integer)
        If top = 9 Then
            'OverFlow, cannot enter more data
        Else
            top = top + 1
            stack(top) = newItem
        End If
    End Sub

    Function Pop() As Integer

        Dim valueToBeDeleted

        If Not isEmpty() Then

            valueToBeDeleted = stack(top)
            stack(top) = NullValue
            top = top - 1

            Return valueToBeDeleted
        Else
            'Underflow, no value exists to be deleted
            Return -1
        End If

    End Function

    Function isEmpty() As Boolean

        If top = -1 Then
            Return True
        Else
            Return False
        End If

    End Function
End Module