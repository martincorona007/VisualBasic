

Module Program

    Sub Main()

        Dim value As String
        Dim v1, v2, v3, v4 As Integer
        Dim resu As String
        Console.WriteLine("intput")
        value = Console.ReadLine()


        Dim ArrayUnidimensional() As Char = value.ToCharArray

        For X = 0 To 3
            'Console.WriteLine("Indice [{0}{1}{2}", X, "] = ", ArrayUnidimensional(X))
            If (X = 0) Then
                v1 = Convert.ToInt32(ArrayUnidimensional(0))
            End If
            If (X = 1) Then
                v2 = Convert.ToInt32(ArrayUnidimensional(1))
            End If
            If (X = 2) Then
                v3 = Convert.ToInt32(ArrayUnidimensional(2))
            End If
            If (X = 3) Then
                v4 = Convert.ToInt32(ArrayUnidimensional(3))
            End If
        Next
        'Console.WriteLine("output")
        'Console.WriteLine(v4)
        'Console.WriteLine(v3)
        'Console.WriteLine(v2)
        'Console.WriteLine(v1)

        Select Case v1
            Case 49 : resu = resu + "M"
            Case 50 : resu = resu + "MM"
            Case 51 : resu = resu + "MMM"
            Case 52 : resu = resu + "IV_"
            Case 53 : resu = resu + "V_"
            Case 54 : resu = resu + "VI_"
            Case 55 : resu = resu + "VII_"
            Case 56 : resu = resu + "VIII_"
            Case 57 : resu = resu + "IX_"

        End Select


        Select Case v2
            Case 49 : resu = resu + "C"
            Case 50 : resu = resu + "CC"
            Case 51 : resu = resu + "CCC"
            Case 52 : resu = resu + "CD"
            Case 53 : resu = resu + "D"
            Case 54 : resu = resu + "DC"
            Case 55 : resu = resu + "DCC"
            Case 56 : resu = resu + "DCCC"
            Case 57 : resu = resu + "CM"

        End Select


        Select Case v3
            Case 49 : resu = resu + "X"
            Case 50 : resu = resu + "XX"
            Case 51 : resu = resu + "XXX"
            Case 52 : resu = resu + "XL"
            Case 53 : resu = resu + "L"
            Case 54 : resu = resu + "LX"
            Case 55 : resu = resu + "LXX"
            Case 56 : resu = resu + "LXXX"
            Case 57 : resu = resu + "XC"
        End Select

        Select Case v4
            Case 49 : resu = resu + "I"
            Case 50 : resu = resu + "II"
            Case 51 : resu = resu + "III"
            Case 52 : resu = resu + "IV"
            Case 53 : resu = resu + "V"
            Case 54 : resu = resu + "VI"
            Case 55 : resu = resu + "VII"
            Case 56 : resu = resu + "VIII"
            Case 57 : resu = resu + "IX"
        End Select
        Console.WriteLine("output ")
        Console.WriteLine(resu)

        Console.ReadLine()
    End Sub

End Module
