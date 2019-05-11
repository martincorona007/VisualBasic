Module Module1

    Sub Main()
        'Console.WriteLine(vbCrLf + "What is your name? ")
        'Dim name = Console.ReadLine()
        'Dim currentDate = DateTime.Now
        'Console.WriteLine($"{vbCrLf}Hello, {name}, on {currentDate:d} at {currentDate:t}")

        Console.WriteLine("1. Inicio 01,02,03 ")
        Console.WriteLine("2. if-then-else 10,13 ")
        Console.WriteLine("3. Case 14,15 ")
        Console.WriteLine("4. for 20,22 ")
        Console.WriteLine("5. while 25,26,27 ")
        Console.WriteLine("6. arrays 34,35,37 ")
        Console.WriteLine("7. procedure y functions 39,44,45,46,48 ")
        Console.WriteLine("8. Enumerations 51,52 ")
        Console.WriteLine("9. OOP 56 to 60 ")
        Dim opt, opt1, opt2, opt3, opt4, opt5, opt6 As Integer
        Console.WriteLine("Option: ")
        opt = Console.ReadLine()

        Select Case opt
            Case 1
                Console.WriteLine("1. 01 ")
                Console.WriteLine("2. 02 ")
                Console.WriteLine("3. 03 ")
                Console.WriteLine("Option: ")
                opt1 = Console.ReadLine()

                Select Case opt1
                    Case 1
                        Dim V, T, D As Integer

                        Console.WriteLine("1 Se desea calcular la distancia recorrida (m) por un móvil que tiene velocidad constante (m/s) durante un tiempo T (Sg), considerar que es un MRU (Movimiento Rectilíneo Uniforme)")
                        Console.WriteLine("Constant Velocity(m): ")
                        V = Console.ReadLine()
                        Console.WriteLine("Time(Sg): ")
                        T = Console.ReadLine()


                        D = V * T
                        Console.WriteLine("Result: ")
                        Console.Write(D)
                    Case 2
                        Dim n1, n2, n3 As Integer

                        Dim P As Double
                        Console.WriteLine("2 Se necesita obtener el promedio simple de un estudiante a partir de sus tres notas parciales.")

                        Console.WriteLine("Qualification 1: ")
                        n1 = Console.ReadLine()
                        Console.WriteLine("Qualification 2: ")
                        n2 = Console.ReadLine()
                        Console.WriteLine("Qualification 3: ")
                        n3 = Console.ReadLine()
                        P = (n1 + n2 + n3) / 3

                        Console.WriteLine("Result: ")
                        Console.Write(P)
                    Case 3
                        Console.WriteLine("3 Elaborar un algoritmo que solicite el número de respuestas correctas,
incorrectas y en blanco, correspondientes a postulantes, y muestre su puntaje
final considerando, que por cada respuesta correcta tendrá 4 puntos,
respuestas incorrectas tendrá -1 y respuestas en blanco tendrá 0.")

                        Dim RI, RC, RB, PF, PRI, PRC As Integer
                        Console.WriteLine("Correct Answers: ")
                        RC = Console.ReadLine()
                        Console.WriteLine("Incorrect Answers: ")
                        RI = Console.ReadLine()
                        Console.WriteLine("Blanc Answers: ")
                        RB = Console.ReadLine()
                        PRC = RC * 4
                        PRI = RI * -1
                        PF = PRC + PRI
                        Console.WriteLine("Result: ")
                        Console.Write(PF)

                End Select



            Case 2
                Console.WriteLine("1. 10 ")
                Console.WriteLine("2. 13 ")
                Console.WriteLine("Option: ")
                opt2 = Console.ReadLine()
                Select Case opt2
                    Case 1
                        Console.WriteLine("Elabora un algoritmo que solicite la edad de 2 hermanos y muestre un mensaje indicando la edad del mayor y cuantos años de diferencia tiene con el menor. ")
                        Dim E1, E2, DE As Integer
                        Console.WriteLine("Age 1: ")
                        E1 = Console.ReadLine()
                        Console.WriteLine("Age 2: ")
                        E2 = Console.ReadLine()
                        If E1 > E2 Then
                            Console.WriteLine("The first Brother is older, for")
                            DE = E1 - E2
                        Else
                            Console.WriteLine("The Second Brother is older, for")
                            DE = E1 - E2
                        End If
                        Console.WriteLine(DE * -1)

                        Console.WriteLine("years")


                    Case 2
                        Console.WriteLine("Elabora un algoritmo que sirva para identificar el tipo de triangulo conociendo sus tres lados.")
                        Dim L1, L2, L3 As Integer
                        Dim TT As String

                        Console.WriteLine("L1")
                        L1 = Console.ReadLine()
                        Console.WriteLine("L2")
                        L2 = Console.ReadLine()
                        Console.WriteLine("L3")
                        L3 = Console.ReadLine()
                        If L1 < L2 Or L1 > L2 And L2 < L3 Or L3 > L2 And L3 < L1 Or L3 > L1 Then
                            TT = "Escaleno"
                            If L1 = L2 And L2 = L3 Then
                                TT = "Equilatero"
                            Else
                                TT = "Isosceles"
                            End If



                        End If
                        Console.WriteLine(TT)
                End Select

            Case 3
                Console.WriteLine("1. 14 ")
                Console.WriteLine("2. 15 ")
                Console.WriteLine("Option: ")
                opt3 = Console.ReadLine()
                Dim NE As Integer
                Dim ER As String
                Dim MV As Integer
                Dim TB As Double
                Select Case opt3
                    Case 1
                        Console.WriteLine("14 Elabore un algoritmo que permita ingresar un número entero (1 a 10), y muestre su equivalente en romano.")
                        Console.WriteLine("Write: ")
                        NE = Console.ReadLine()
                        Select Case NE
                            Case 1
                                ER = "I"
                            Case 2
                                ER = "II"
                            Case 3
                                ER = "III"
                            Case 4
                                ER = "IV"

                            Case 5
                                ER = "V"
                            Case 6
                                ER = "VI"
                            Case 7
                                ER = "VII"
                            Case 8
                                ER = "VIII"
                            Case 9
                                ER = "IX"
                            Case 10
                                ER = "x"


                        End Select
                        Console.WriteLine(ER)


                    Case 2
                        Console.WriteLine("15. Elabore un algoritmo que permita ingresar el monto de venta alcanzado por un promotor durante el mes, luego de calcular la bonificación que le corresponde sabiendo:")



                        Console.WriteLine("Write: ")
                        MV = Console.ReadLine()
                        Select Case MV
                            Case MV >= 0 And MV < 1000
                                Console.WriteLine("h: ")

                                TB = (0 * MV) / 100
                            Case MV >= 1000 And MV < 5000
                                Console.WriteLine("o: ")
                                TB = (3 * MV) / 100
                            Case MV >= 5000 And MV < 20000
                                Console.WriteLine("l: ")
                                TB = (5 * MV) / 100
                            Case MV >= 20000
                                Console.WriteLine("a: ")
                                TB = (8 * MV) / 100

                        End Select
                        Console.WriteLine("Result: ")
                        Console.WriteLine(TB)


                End Select

            Case 4

                Console.WriteLine("1. 20 ")
                Console.WriteLine("2. 22 ")

                Console.WriteLine("Option: ")
                opt4 = Console.ReadLine()
                Select Case opt4
                    Case 1
                        Console.WriteLine("20. Elaborar un algoritmo que permita mostrar el sueldo promedio de un grupo de empleados.")
                        Dim NE As Integer
                        Dim SP, SS, SE As Double
                        Console.WriteLine("Write  ")
                        NE = Console.ReadLine()
                        For K = 1 To NE
                            Console.WriteLine("Write  ")
                            SE = Console.ReadLine()
                            SS = SS + SE

                        Next
                        SP = SS / NE
                        Console.WriteLine("Result: ")
                        Console.WriteLine(SP)
                    Case 2
                        Console.WriteLine("Elaborar un algoritmo que solicite 2 número enteros y muestre su producto por el método de sumas sucesivas.")
                        Dim PN, SN, P As Integer
                        P = 0
                        Console.WriteLine("Write n1  ")
                        PN = Console.ReadLine()
                        Console.WriteLine("Write n2  ")
                        SN = Console.ReadLine()
                        For k = 1 To SN
                            P = P + PN
                        Next
                        Console.WriteLine("Result")
                        Console.WriteLine(P)
                End Select


            Case 5
                Console.WriteLine("1. 25 ")
                Console.WriteLine("2. 26 ")
                Console.WriteLine("3. 27 ")

                Console.WriteLine("Option: ")
                opt5 = Console.ReadLine()
                Select Case opt5
                    Case 1
                        Console.WriteLine("25. Elaborar un algoritmo que solicite ingresar letras hasta que este ingrese una vocal.")
                        Dim SEMAF As String
                        SEMAF = "V"
                        Dim L As String
                        Do While SEMAF = "V"
                            Console.WriteLine("Write  ")
                            L = Console.ReadLine()
                            Select Case L
                                Case "A"
                                    SEMAF = "R"
                                Case "a"
                                    SEMAF = "R"
                                Case "E"
                                    SEMAF = "R"
                                Case "e"
                                    SEMAF = "R"
                                Case "I"
                                    SEMAF = "R"
                                Case "i"
                                    SEMAF = "R"
                                Case "O"
                                    SEMAF = "R"
                                Case "o"
                                    SEMAF = "R"
                                Case "U"
                                    SEMAF = "R"
                                Case "u"
                                    SEMAF = "R"
                                Case Else
                                    SEMAF = "V"
                            End Select
                        Loop
                    Case 2
                        Console.WriteLine("26. Elabore un algoritmo que muestre los términos de la serie Fibonacci que sean menores a 100000.")
                        Dim A, B, C As Integer
                        A = 0
                        B = 1
                        C = A + B
                        Console.WriteLine(A)

                        Console.WriteLine(B)

                        Do While (C < 100000)
                            Console.WriteLine(C)

                            A = B
                            B = C
                            C = A + B

                        Loop
                    Case 3
                        Console.WriteLine("27. Elaborar un algoritmo que solicite 2 números enteros y un operador aritmético y luego debe de mostrar el resultado de la operación correspondiente.")
                        Dim N1, N2, R As Integer
                        Dim OP As String
                        Console.WriteLine("Write n1  ")
                        N1 = Console.ReadLine()
                        Console.WriteLine("Write n2  ")
                        N2 = Console.ReadLine()
                        Console.WriteLine("Write OP  ")
                        OP = Console.ReadLine()
                        Select Case OP
                            Case "+"
                                R = N1 + N2
                            Case "-"
                                R = N1 - N2
                            Case "*"
                                R = N1 * N2
                            Case "^"
                                R = N1 ^ N2
                            Case Else
                                R = 0
                        End Select
                        Console.WriteLine(R)

                End Select

            Case 6
                Console.WriteLine("1. 34 ")
                Console.WriteLine("2. 35 ")
                Console.WriteLine("3. 37 ")
                Console.WriteLine("Option: ")
                opt6 = Console.ReadLine()

            Case 7
            Case 8
            Case 9
            Case 10
        End Select






        Console.Write(vbCrLf + "Press any key to exit... ")
        Console.ReadKey(True)
    End Sub

End Module
